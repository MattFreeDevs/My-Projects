Imports System.Data.SqlClient

Public Class MainMenu
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

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sesión Usuario
        Dim id As Int16 = Session_Id()
        Lb_UserName.Text = Session

        'Panel Perfil
        Pb_User.Location = New Point((Panel.Width - Pb_User.Width) / 2, 0)
        Lb_UserName.Location = New Point((Panel.Width - Lb_UserName.Width) / 2, 95)
        Bt_Profile.Location = New Point((Panel.Width - Bt_Profile.Width) / 2, 130)

    End Sub

    Private Sub Bt_Profile_Click(sender As Object, e As EventArgs) Handles Bt_Profile.Click
        Dim Frm As New YourProfile
        Frm.ConnString = Me.ConnString
        Frm.Session = Me.Session
        Frm.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim Frm As New LoginForm
        Me.Hide()
        Frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Dim Frm As New ContactMe
        Frm.ShowDialog()
    End Sub

    Private Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click
        Dim Frm As New Companies
        Frm.ConnString = Me.ConnString
        Frm.Session = Me.Session
        Frm.ShowDialog()
    End Sub
End Class