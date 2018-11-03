Imports System.Data.SqlClient

Public Class EditProfile
    Public Property Session As String
    Public Property ConnString As String

    Public Function Session_Id()
        'Sesión de usuario
        Dim id As Integer = 0
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            Dim cmdSession As New SqlCommand("SELECT Id FROM USERS WHERE Nick=@username", connection)

            cmdSession.Parameters.Add("@username", SqlDbType.VarChar).Value = Session

            Dim adp As New SqlDataAdapter(cmdSession)

            Dim tbUser As New DataTable()

            adp.Fill(tbUser)

            If tbUser.Rows.Count > 0 Then
                id = CInt(cmdSession.ExecuteScalar)
            End If

            'Cerrar conexión con BBDD
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

        Return id
    End Function

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sesión Usuario
        Dim id As Int16 = Session_Id()

        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Información del Usuario
            Dim cmdSelectUser As New SqlCommand("SELECT Nick,Password,Name,SecondName,Email,[Type] FROM USERS WHERE Id=@id", connection)

            cmdSelectUser.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim adp2 As New SqlDataAdapter(cmdSelectUser)

            Dim tbUserInfo As New DataTable()

            adp2.Fill(tbUserInfo)

            If tbUserInfo.Rows.Count > 0 Then
                tb_Username.Text = tbUserInfo.Rows(0).Item(0)
                Tb_Password.Text = tbUserInfo.Rows(0).Item(1)
                Tb_Name.Text = tbUserInfo.Rows(0).Item(2)
                Tb_SecondName.Text = tbUserInfo.Rows(0).Item(3)
                Tb_email.Text = tbUserInfo.Rows(0).Item(4)
                If tbUserInfo.Rows(0).Item(5) = "customer" Then
                    Rb_Customer.Checked = True
                    Rb_Company.Checked = False
                Else
                    Rb_Customer.Checked = False
                    Rb_Company.Checked = True
                End If
            End If

            'Cerrar conexión con BBDD
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try
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

    Public Function DeleteCompany()
        'Sesión usuario
        Dim id As Int16 = Session_Id()

        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Borrado empresa
            Dim cmdDeleteCompany As New SqlCommand("DELETE COMPANIES WHERE Owner_Id=@id", connection)

            cmdDeleteCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim rowsAffected As Integer = cmdDeleteCompany.ExecuteNonQuery()

            'Cerrar conexión con BBDD
            connection.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Company sucessfully deleted")
            End If

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            Exit Function
        End Try
    End Function

    Private Sub Bt_Save_Click(sender As Object, e As EventArgs) Handles Bt_Save.Click

        'Sesión usuario
        Dim id As Int16 = Session_Id()

        CheckInformation()

        If CheckInformation() Then
            Try
                'Conexión con la BBDD
                Dim connection As New SqlConnection(ConnString)
                connection.Open()

                'Comprobar si el usuario es una empresa
                Dim cmdUserCompany As New SqlCommand("SELECT * FROM COMPANIES WHERE Owner_Id=@id ", connection)

                cmdUserCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

                Dim adp As New SqlDataAdapter(cmdUserCompany)

                Dim tbUserCompany As New DataTable()

                adp.Fill(tbUserCompany)

                'Comprobar nuevos datos
                Dim cmdSelect As New SqlCommand("SELECT * FROM(SELECT * FROM USERS WHERE Id<>@id) AS t
                WHERE Nick = @username OR Email = @email", connection)

                cmdSelect.Parameters.Add("@id", SqlDbType.Int).Value = id
                cmdSelect.Parameters.Add("@username", SqlDbType.VarChar).Value = tb_Username.Text
                cmdSelect.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_email.Text

                Dim adapter As New SqlDataAdapter(cmdSelect)

                Dim table As New DataTable()

                adapter.Fill(table)

                If table.Rows.Count <= 0 Then

                    Dim cmdUpdate As New SqlCommand("UPDATE USERS SET Nick=@username,
                    Password=@password, Name=@name, SecondName=@secondname, Email=@email, 
                    Type=@type WHERE Id=@id", connection)

                    cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = id
                    cmdUpdate.Parameters.Add("@username", SqlDbType.VarChar).Value = tb_Username.Text
                    cmdUpdate.Parameters.Add("@password", SqlDbType.VarChar).Value = Tb_Password.Text
                    cmdUpdate.Parameters.Add("@name", SqlDbType.VarChar).Value = Tb_Name.Text
                    cmdUpdate.Parameters.Add("@secondname", SqlDbType.VarChar).Value = Tb_SecondName.Text
                    cmdUpdate.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_email.Text
                    If Rb_Customer.Checked Then
                        If tbUserCompany.Rows.Count > 0 Then
                            If MessageBox.Show("You have a company associated to this account." + vbNewLine +
                                               "If you change your type to 'Customer', the information of your company will be deleted." + vbNewLine +
                                               " Do you agree with that?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                                Exit Sub
                            End If
                            DeleteCompany()
                        End If
                        cmdUpdate.Parameters.Add("@type", SqlDbType.VarChar).Value = "customer"
                    Else
                        cmdUpdate.Parameters.Add("@type", SqlDbType.VarChar).Value = "company"
                    End If
                    cmdUpdate.ExecuteNonQuery()

                    If cmdUpdate.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Data saved")
                        Session = tb_Username.Text
                        Dim Frm As New MainMenu
                        Frm.Session = Me.Session
                        Frm.ConnString = Me.ConnString

                        For Each Form In My.Application.OpenForms
                            Form.Hide()
                        Next

                        'Cerrar conexión con BBDD
                        connection.Close()

                        Frm.Show()
                    End If
                Else
                    MessageBox.Show("User Name or Email are already in use")
                End If
            Catch ex As Exception
                MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Bt_ChangePassword_Click(sender As Object, e As EventArgs) Handles Bt_ChangePassword.Click
        Dim Frm As New ChangePassword
        Frm.Session = Me.Session
        Frm.ConnString = Me.ConnString
        Frm.ShowDialog()
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        If MessageBox.Show("Are you sure you wish to delete your user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
            Exit Sub
        End If

        Dim id As Int16 = Session_Id()

        'Comprobar si el usuario es una empresa
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            Dim cmdCompany As New SqlCommand("SELECT * FROM COMPANIES WHERE Owner_Id=@id ", connection)

            cmdCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim adp As New SqlDataAdapter(cmdCompany)

            Dim tbCompany As New DataTable()

            adp.Fill(tbCompany)

            'Cerrar conexión con BBDD
            connection.Close()

            If tbCompany.Rows.Count > 0 Then
                If MessageBox.Show("If you delete your user, your company will be deleted. Do you agree with that?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                    Exit Sub
                End If
                Try
                    'Conexión con la BBDD
                    connection.Open()

                    'Borrado empresa
                    Dim cmdDeleteCompany As New SqlCommand("DELETE COMPANIES WHERE Owner_Id=@id", connection)

                    cmdDeleteCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

                    Dim rowsAffected As Integer = cmdDeleteCompany.ExecuteNonQuery()

                    'Cerrar conexión con BBDD
                    connection.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Company sucessfully deleted")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
                    Exit Sub
                End Try
            End If
            Try
                'Conexión con la BBDD
                connection.Open()

                Dim cmdDeleteUser As New SqlCommand("DELETE USERS WHERE Id=@id", connection)

                cmdDeleteUser.Parameters.Add("@id", SqlDbType.Int).Value = id

                Dim rowsAffected2 As Integer = cmdDeleteUser.ExecuteNonQuery()

                'Cerrar conexión con BBDD
                connection.Close()

                If rowsAffected2 > 0 Then
                    MessageBox.Show("User succesfully deleted")
                    Dim Frm As New LoginForm
                    For Each Form In My.Application.OpenForms
                        Form.Hide()
                    Next
                    Frm.Show()
                End If
            Catch ex As Exception
                MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try
    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Me.Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Dim Frm As New MainMenu
        Frm.Session = Session
        Frm.ConnString = ConnString
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
        Frm.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim Frm As New LoginForm
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
        Frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Dim Frm As New ContactMe
        Frm.Show()
    End Sub

End Class