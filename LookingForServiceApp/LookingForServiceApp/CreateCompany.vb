﻿Imports System.Data.SqlClient

Public Class CreateCompany
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

    Private Sub CreateCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()

            'Obtencion tipos de negocio
            Dim command As New SqlCommand("SELECT * FROM BUSINESS ORDER BY TYPE ASC", connection)

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            Cb_TypeBusiness.DataSource = table
            Cb_TypeBusiness.DisplayMember = "Type"
            Cb_TypeBusiness.ValueMember = "Type"

            'Cerrar conexión con BBDD
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try
    End Sub

    Public Function CheckInformation()
        Dim count As Integer
        count = 0
        If tb_CompanyName.Text = "" Then
            Lb_CompanyName.Visible = True
            count = count + 1
        Else
            Lb_CompanyName.Visible = False
        End If
        If Tb_Nif.Text = "" Then
            Lb_Nif.Visible = True
            count = count + 1
        Else
            Lb_Nif.Visible = False
        End If
        If Tb_Location.Text = "" Then
            Lb_Location.Visible = True
            count = count + 1
        Else
            Lb_Location.Visible = False
        End If
        If Tb_PhoneNumber.Text = "" Then
            Lb_PhoneNumber.Visible = True
            count = count + 1
        Else
            Lb_PhoneNumber.Visible = False
        End If
        If Tb_Email.Text = "" Then
            Lb_Email.Visible = True
            count = count + 1
        Else
            Lb_Email.Visible = False
        End If
        If count <= 0 Then
            Return "true"
        Else
            Return "false"
        End If
    End Function

    Private Sub Bt_Create_Click(sender As Object, e As EventArgs) Handles Bt_Create.Click
        'Sesión Usuario
        Dim id As Int16 = Session_Id()

        CheckInformation()

        If CheckInformation() Then
            Try
                'Conexión con la BBDD
                Dim connection As New SqlConnection(ConnString)
                connection.Open()

                Dim command As New SqlCommand("SELECT * FROM COMPANIES WHERE Name=@name OR NIF=@nif OR Phone=@phone OR  Email=@email", connection)

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = tb_CompanyName.Text
                command.Parameters.Add("@nif", SqlDbType.VarChar).Value = Tb_Nif.Text
                command.Parameters.Add("@phone", SqlDbType.Int).Value = Tb_PhoneNumber.Text
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_Email.Text

                Dim adapter As New SqlDataAdapter(command)

                Dim table As New DataTable()

                adapter.Fill(table)

                If table.Rows.Count <= 0 Then
                    Dim cmdInsert As New SqlCommand("INSERT INTO COMPANIES VALUES 
                    (@name,@nif,@location,@phone,@type,@email,@description,@ownerid)", connection)

                    cmdInsert.Parameters.Add("@name", SqlDbType.VarChar).Value = tb_CompanyName.Text
                    cmdInsert.Parameters.Add("@nif", SqlDbType.VarChar).Value = Tb_Nif.Text
                    cmdInsert.Parameters.Add("@location", SqlDbType.VarChar).Value = Tb_Location.Text
                    cmdInsert.Parameters.Add("@phone", SqlDbType.Int).Value = Tb_PhoneNumber.Text
                    cmdInsert.Parameters.Add("@type", SqlDbType.VarChar).Value = Cb_TypeBusiness.SelectedValue.ToString
                    cmdInsert.Parameters.Add("@email", SqlDbType.VarChar).Value = Tb_Email.Text
                    cmdInsert.Parameters.Add("@description", SqlDbType.VarChar).Value = Tb_Description.Text
                    cmdInsert.Parameters.Add("@ownerid", SqlDbType.Int).Value = id
                    cmdInsert.ExecuteNonQuery()
                    MessageBox.Show("Company created")
                    Me.Close()
                Else
                    MessageBox.Show("Company name, NIF, phone number or email are already in use")
                End If

                'Cerrar conexión con BBDD
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
            End Try
        End If
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