Imports System.Data.SqlClient

Public Class CreateAccount
    Public Property ConnString As String
    Private Sub Bt_Create_Click(sender As Object, e As EventArgs) Handles Bt_Create.Click

        CheckInformation()

        If CheckInformation() Then
            Try
                'Conexión con la BBDD
                Dim connection As New SqlConnection(ConnString)
                connection.Open()

                Dim command As New SqlCommand("SELECT * FROM USERS where Nick = @username or Email = @email", connection)

                command.Parameters.Add("@username", SqlDbType.VarChar).Value = tb_Username.Text
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_email.Text

                Dim adapter As New SqlDataAdapter(command)

                Dim table As New DataTable()

                adapter.Fill(table)

                If table.Rows.Count() <= 0 Then
                    Dim commInsert As New SqlCommand("INSERT INTO USERS VALUES (@username,@password,@name,@secondname,@email,@type)", connection)

                    commInsert.Parameters.Add("@username", SqlDbType.VarChar).Value = tb_Username.Text
                    commInsert.Parameters.Add("@password", SqlDbType.VarChar).Value = Tb_password1.Text
                    commInsert.Parameters.Add("@name", SqlDbType.VarChar).Value = Tb_Name.Text
                    commInsert.Parameters.Add("@secondname", SqlDbType.VarChar).Value = Tb_SecondName.Text
                    commInsert.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_email.Text
                    If Rb_Customer.Checked Then
                        commInsert.Parameters.Add("@type", SqlDbType.VarChar).Value = "customer"
                    End If
                    If Rb_Company.Checked Then
                        commInsert.Parameters.Add("@type", SqlDbType.VarChar).Value = "company"
                    End If

                    commInsert.ExecuteNonQuery()
                    MessageBox.Show("Account created." + vbNewLine + "Log in to start the App.")
                    Me.Close()
                Else
                    MessageBox.Show("Username or Email are already in use")
                End If

                'Cerrar conexión con BBDD
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            End Try
        End If
    End Sub

    Public Function CheckInformation()
        Dim count As Integer
        count = 0
        If tb_Username.Text = "" Then
            Lb_Username.Visible = True
            count = count + 1
        Else
            Lb_Username.Visible = False
        End If
        If Tb_password1.Text = "" Then
            Lb_password1.Visible = True
            count = count + 1
        Else
            Lb_password1.Visible = False
        End If
        If Tb_password1.Text <> Tb_password2.Text Then
            Lb_password2.Visible = True
            count = count + 1
        Else
            Lb_password2.Visible = False
        End If
        If Tb_email.Text = "" Then
            Lb_email.Visible = True
            count = count + 1
        Else
            Lb_email.Visible = False
        End If
        If count <= 0 Then
            Return "true"
        Else
            Return "false"
        End If
    End Function

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Me.Close()
    End Sub
End Class