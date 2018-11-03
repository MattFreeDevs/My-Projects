Imports System.Data.SqlClient

Public Class LoginForm
    Public Property ConnString As String = "Server= LAPTOP-RHVD8225; DataBase = LookingForServiceDB; Integrated Security = true"
    Private Sub Bt_Login_Click(sender As Object, e As EventArgs) Handles Bt_Login.Click
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Login 
            Dim command As New SqlCommand("SELECT * FROM USERS where Nick = @username and Password = @password", connection)

            command.Parameters.Add("@username", SqlDbType.VarChar).Value = tb_Username.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = tb_Password.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("Username or Password are invalid")
            Else
                Dim Frm As New MainMenu
                Frm.ConnString = Me.ConnString
                Frm.Session = tb_Username.Text
                Me.Hide()
                Frm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try


    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Application.Exit()
    End Sub

    Private Sub llbl_CreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_CreateAccount.LinkClicked
        Dim Frm As New CreateAccount
        Frm.ConnString = Me.ConnString
        Frm.ShowDialog()
    End Sub
End Class
