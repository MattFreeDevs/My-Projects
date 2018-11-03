<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Companies
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Companies))
        Me.DGV_Companies = New System.Windows.Forms.DataGridView()
        Me.COMPANIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookingForServiceDBDataSet = New LookingForServiceApp.LookingForServiceDBDataSet()
        Me.COMPANIESTableAdapter = New LookingForServiceApp.LookingForServiceDBDataSetTableAdapters.COMPANIESTableAdapter()
        Me.Bt_Filter = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cb_TypeBusiness = New System.Windows.Forms.ComboBox()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.DGV_Companies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookingForServiceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Companies
        '
        Me.DGV_Companies.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Companies.Location = New System.Drawing.Point(12, 85)
        Me.DGV_Companies.Name = "DGV_Companies"
        Me.DGV_Companies.ReadOnly = True
        Me.DGV_Companies.Size = New System.Drawing.Size(746, 240)
        Me.DGV_Companies.TabIndex = 0
        '
        'COMPANIESBindingSource
        '
        Me.COMPANIESBindingSource.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource.DataSource = Me.LookingForServiceDBDataSet
        '
        'LookingForServiceDBDataSet
        '
        Me.LookingForServiceDBDataSet.DataSetName = "LookingForServiceDBDataSet"
        Me.LookingForServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMPANIESTableAdapter
        '
        Me.COMPANIESTableAdapter.ClearBeforeFill = True
        '
        'Bt_Filter
        '
        Me.Bt_Filter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Filter.Location = New System.Drawing.Point(225, 355)
        Me.Bt_Filter.Name = "Bt_Filter"
        Me.Bt_Filter.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Filter.TabIndex = 63
        Me.Bt_Filter.Text = "Search"
        Me.Bt_Filter.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(386, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Type of Business:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "City:"
        '
        'Cb_TypeBusiness
        '
        Me.Cb_TypeBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TypeBusiness.FormattingEnabled = True
        Me.Cb_TypeBusiness.Location = New System.Drawing.Point(539, 38)
        Me.Cb_TypeBusiness.Name = "Cb_TypeBusiness"
        Me.Cb_TypeBusiness.Size = New System.Drawing.Size(145, 21)
        Me.Cb_TypeBusiness.TabIndex = 68
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(446, 355)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 69
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'CB_Location
        '
        Me.CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(147, 38)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(145, 21)
        Me.CB_Location.TabIndex = 70
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.InicioToolStripMenuItem.Text = "Home"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ContactToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 72
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Companies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(770, 402)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CB_Location)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Cb_TypeBusiness)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bt_Filter)
        Me.Controls.Add(Me.DGV_Companies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Companies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        CType(Me.DGV_Companies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookingForServiceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Companies As DataGridView
    Friend WithEvents LookingForServiceDBDataSet As LookingForServiceDBDataSet
    Friend WithEvents COMPANIESBindingSource As BindingSource
    Friend WithEvents COMPANIESTableAdapter As LookingForServiceDBDataSetTableAdapters.COMPANIESTableAdapter
    Friend WithEvents Bt_Filter As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cb_TypeBusiness As ComboBox
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents CB_Location As ComboBox
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
