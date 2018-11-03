Imports System.Data.SqlClient

Public Class YourProfile
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

    Private Sub YourProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sesión Usuario
        Dim id As Int16 = Session_Id()
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Información del Usuario
            Dim cmdSelectUser As New SqlCommand("SELECT Nick,Name,SecondName,Email,[Type] FROM USERS WHERE Id=@id", connection)

            cmdSelectUser.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim adp2 As New SqlDataAdapter(cmdSelectUser)

            Dim tbUserInfo As New DataTable()

            adp2.Fill(tbUserInfo)

            If tbUserInfo.Rows.Count > 0 Then
                Lb_Nick.Text = tbUserInfo.Rows(0).Item(0)
                Lb_Name.Text = tbUserInfo.Rows(0).Item(1)
                Lb_SecondName.Text = tbUserInfo.Rows(0).Item(2)
                Lb_Email.Text = tbUserInfo.Rows(0).Item(3)
                Lb_TypeAccount.Text = tbUserInfo.Rows(0).Item(4)

                'Activar botón de empresa
                If tbUserInfo.Rows(0).Item(4) = "company" Or tbUserInfo.Rows(0).Item(4) = "admin" Then
                    Bt_YourCompany.Visible = True
                End If
            End If

            'Cerrar conexión con BBDD
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

    End Sub

    Private Sub Bt_Edit_Click(sender As Object, e As EventArgs) Handles Bt_Edit.Click
        Dim Frm As New EditProfile
        Frm.Session = Me.Session
        Frm.ConnString = Me.ConnString
        Frm.ShowDialog()
    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Bt_YourCompany_Click(sender As Object, e As EventArgs) Handles Bt_YourCompany.Click

        'Sesión Usuario
        Dim id As Int16 = Session_Id()

        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Comprobar si existe Empresa 
            Dim cmdCompany As New SqlCommand("SELECT * FROM COMPANIES WHERE Owner_Id=@id", connection)

            cmdCompany.Parameters.Add("@id", SqlDbType.Int).Value = id

            Dim adp2 As New SqlDataAdapter(cmdCompany)

            Dim tbCompany As New DataTable()

            adp2.Fill(tbCompany)

            If tbCompany.Rows.Count > 0 Then
                Dim Frm As New YourCompany
                Frm.Session = Me.Session
                Frm.ConnString = Me.ConnString
                Frm.ShowDialog()
            Else
                If MessageBox.Show("You haven't created a company yet. Do you want to create one now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                    Exit Sub
                End If
                Dim Frm As New CreateCompany
                Frm.Session = Me.Session
                Frm.ConnString = Me.ConnString
                Frm.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try
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