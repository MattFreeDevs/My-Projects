Imports System.Data.SqlClient

Public Class ChangePassword
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

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bt_Save_Click(sender As Object, e As EventArgs) Handles Bt_Save.Click
        'Sesión Usuario
        Dim id As Int16 = Session_Id()

        'Check Password
        CheckPassword()
        If CheckPassword() Then
            Try
                'Conexión con la BBDD
                Dim connection As New SqlConnection(ConnString)
                connection.Open()

                'Información del Usuario
                Dim cmdSelectPassword As New SqlCommand("SELECT * FROM USERS WHERE Id=@id AND Password=@password", connection)

                cmdSelectPassword.Parameters.Add("@id", SqlDbType.Int).Value = id
                cmdSelectPassword.Parameters.Add("@password", SqlDbType.VarChar).Value = tb_oldPassword.Text

                Dim adapter As New SqlDataAdapter(cmdSelectPassword)

                Dim tb As New DataTable()

                adapter.Fill(tb)

                If tb.Rows.Count > 0 Then
                    Dim cmdUpdatePassword As New SqlCommand("UPDATE USERS SET Password=@password WHERE Id=@id", connection)

                    cmdUpdatePassword.Parameters.Add("@id", SqlDbType.Int).Value = id
                    cmdUpdatePassword.Parameters.Add("@password", SqlDbType.VarChar).Value = Tb_NewPassword1.Text
                    cmdUpdatePassword.ExecuteNonQuery()

                    If cmdUpdatePassword.ExecuteNonQuery() Then
                        MessageBox.Show("Password succesfully changed")
                        Dim Frm As New MainMenu
                        Frm.Session = Me.Session
                        Frm.ConnString = Me.ConnString
                        For Each Form In My.Application.OpenForms
                            Form.Hide()
                        Next
                        Frm.Show()
                    End If
                Else
                    Lb_password.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Me.Hide()
    End Sub


    Public Function CheckPassword()
        Dim count As Integer
        count = 0
        If tb_oldPassword.Text = "" Then
            Lb_password.Visible = True
            count = count + 1
        Else
            Lb_password.Visible = False
        End If
        If Tb_NewPassword1.Text = "" Then
            Lb_password1.Visible = True
            count = count + 1
        Else
            Lb_password1.Visible = False
        End If
        If Tb_NewPassword2.Text <> Tb_NewPassword1.Text Then
            Lb_password2.Visible = True
            count = count + 1
        Else
            Lb_password2.Visible = False
        End If
        If count > 0 Then
            Return "False"
        Else
            Return "True"
        End If
    End Function

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim Frm As New MainMenu
        Frm.Session = Me.Session
        Frm.ConnString = Me.ConnString
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
        Frm.Show()
    End Sub

    Private Sub LogOutStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutStripMenuItem.Click
        Dim Frm As New LoginForm
        For Each Form In My.Application.OpenForms
            Form.Hide()
        Next
        Frm.Show()
    End Sub

    Private Sub ExitStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ContactToolMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolMenuItem.Click
        Dim Frm As New ContactMe
        Frm.ShowDialog()
    End Sub
End Class