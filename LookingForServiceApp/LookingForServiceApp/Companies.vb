Imports System.Data.SqlClient

Public Class Companies
    Public Property Session As String
    Public Property ConnString As String
    Dim ds As New DataSet
    Private Sub Companies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Conexión con la BBDD
        Dim connection As New SqlConnection(ConnString)
        Try
            connection.Open()
            'Obtencion tipos de negocio
            Dim command As New SqlCommand("SELECT * FROM BUSINESS ORDER BY TYPE ASC", connection)

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)
            table.Rows.Add("")

            Cb_TypeBusiness.DataSource = table
            Cb_TypeBusiness.DisplayMember = "Type"
            Cb_TypeBusiness.ValueMember = "Type"

            'Cerrar conexión con BBDD
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

        Try
            connection.Open()

            'Obtención ciudades
            Dim cmdSelectCities As New SqlCommand("SELECT DISTINCT [Location] FROM COMPANIES ORDER BY [Location] ASC", connection)
            Dim adp2 As New SqlDataAdapter(cmdSelectCities)
            Dim tbCities As New DataTable()

            adp2.Fill(tbCities)
            tbCities.Rows.Add("")

            CB_Location.DataSource = tbCities
            CB_Location.DisplayMember = "Location"
            CB_Location.ValueMember = "Location"

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

        Try
            connection.Open()

            'Formación DrawGrid
            Dim cmdSelect As New SqlCommand("SELECT Name AS 'Company Name',Location AS 'City',Phone,BusinessType AS 'Type',Email,Description FROM COMPANIES", connection)

            Dim adpr As New SqlDataAdapter(cmdSelect)
            adpr.Fill(ds)

            DGV_Companies.DataSource = ds.Tables(0)
            DGV_Companies.Columns(5).Width = 200

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

    End Sub

    Private Sub Bt_Filter_Click(sender As Object, e As EventArgs) Handles Bt_Filter.Click

        ds.Clear()
        Try
            'Conexión con la BBDD
            Dim connection As New SqlConnection(ConnString)
            connection.Open()
            Dim cmdSearch As SqlCommand

            If CB_Location.SelectedValue.ToString() = "" Then
                If Cb_TypeBusiness.SelectedValue.ToString() = "" Then
                    cmdSearch = New SqlCommand("SELECT Name AS 'Company Name',Location AS 'City',
                    Phone,BusinessType AS 'Type',Email,Description FROM COMPANIES ", connection)
                Else
                    cmdSearch = New SqlCommand("SELECT Name AS 'Company Name',Location AS 'City',
                    Phone,BusinessType AS 'Type',Email,Description FROM COMPANIES WHERE BusinessType=@type", connection)
                    cmdSearch.Parameters.Add("@type", SqlDbType.VarChar).Value = Cb_TypeBusiness.SelectedValue.ToString
                End If
            Else
                If Cb_TypeBusiness.SelectedValue.ToString() = "" Then
                    cmdSearch = New SqlCommand("SELECT Name AS 'Company Name',Location AS 'City',
                    Phone,BusinessType AS 'Type',Email,Description FROM COMPANIES WHERE Location=@location", connection)
                    cmdSearch.Parameters.Add("@location", SqlDbType.VarChar).Value = CB_Location.SelectedValue.ToString
                Else
                    cmdSearch = New SqlCommand("SELECT Name AS 'Company Name',Location AS 'City',
                    Phone,BusinessType AS 'Type',Email,Description FROM COMPANIES WHERE Location=@location AND BusinessType=@type", connection)
                    cmdSearch.Parameters.Add("@location", SqlDbType.VarChar).Value = CB_Location.SelectedValue.ToString
                    cmdSearch.Parameters.Add("@type", SqlDbType.VarChar).Value = Cb_TypeBusiness.SelectedValue.ToString
                End If
            End If

            Dim adapter As New SqlDataAdapter(cmdSearch)
            adapter.Fill(ds)

            DGV_Companies.DataSource = ds.Tables(0)
            DGV_Companies.Columns(5).Width = 200

            'Cerrar conexión con BBDD
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Unexpected error. Please, contact with the admin. " + ex.Message)
        End Try

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