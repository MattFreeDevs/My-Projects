Imports System.Data.SqlClient

Public Class YourCompany
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

    Private Sub YourCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sesión Usuario
        Dim id As Int16 = Session_Id()
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            ' Informacion de la empresa del usuario
            Dim cmdSelectCompany As New SqlCommand("SELECT * FROM COMPANIES WHERE Owner_Id=@id", connection)

            cmdSelectCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim adp2 As New SqlDataAdapter(cmdSelectCompany)

            Dim tbCompany As New DataTable()

            adp2.Fill(tbCompany)

            If tbCompany.Rows.Count > 0 Then
                Lb_CompanyName.Text = tbCompany.Rows(0).Item(0)
                Lb_NIF.Text = tbCompany.Rows(0).Item(1)
                Lb_Location.Text = tbCompany.Rows(0).Item(2)
                Lb_PhoneNumber.Text = tbCompany.Rows(0).Item(3)
                Lb_Type.Text = tbCompany.Rows(0).Item(4)
                Lb_Email.Text = tbCompany.Rows(0).Item(5)
                Lb_Description.Text = tbCompany.Rows(0).Item(6)
            End If

            'Cerrar conexión con BBDD
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

    End Sub

    Private Sub Bt_Edit_Click(sender As Object, e As EventArgs) Handles Bt_Edit.Click
        Dim Frm As New EditCompany
        Frm.ConnString = Me.ConnString
        Frm.Session = Me.Session
        Frm.ShowDialog()
    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Me.Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Dim Frm As New MainMenu
        Frm.Session = Me.Session
        Frm.ConnString = Me.ConnString
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
        Frm.ShowDialog()
    End Sub

End Class