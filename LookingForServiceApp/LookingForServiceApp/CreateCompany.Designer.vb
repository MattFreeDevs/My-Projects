<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateCompany))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lb_Location = New System.Windows.Forms.Label()
        Me.Lb_CompanyName = New System.Windows.Forms.Label()
        Me.Lb_Nif = New System.Windows.Forms.Label()
        Me.Tb_Description = New System.Windows.Forms.TextBox()
        Me.Tb_Email = New System.Windows.Forms.TextBox()
        Me.Tb_PhoneNumber = New System.Windows.Forms.TextBox()
        Me.Tb_Location = New System.Windows.Forms.TextBox()
        Me.Tb_Nif = New System.Windows.Forms.TextBox()
        Me.tb_CompanyName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_2 = New System.Windows.Forms.Label()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Create = New System.Windows.Forms.Button()
        Me.Lb_PhoneNumber = New System.Windows.Forms.Label()
        Me.Lb_Email = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_TypeBusiness = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CREATE A NEW COMPANY"
        '
        'Lb_Location
        '
        Me.Lb_Location.AutoSize = True
        Me.Lb_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Location.ForeColor = System.Drawing.Color.Red
        Me.Lb_Location.Location = New System.Drawing.Point(198, 278)
        Me.Lb_Location.Name = "Lb_Location"
        Me.Lb_Location.Size = New System.Drawing.Size(135, 13)
        Me.Lb_Location.TabIndex = 37
        Me.Lb_Location.Text = "* Location cannot be empty"
        Me.Lb_Location.Visible = False
        '
        'Lb_CompanyName
        '
        Me.Lb_CompanyName.AutoSize = True
        Me.Lb_CompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CompanyName.ForeColor = System.Drawing.Color.Red
        Me.Lb_CompanyName.Location = New System.Drawing.Point(198, 115)
        Me.Lb_CompanyName.Name = "Lb_CompanyName"
        Me.Lb_CompanyName.Size = New System.Drawing.Size(168, 13)
        Me.Lb_CompanyName.TabIndex = 36
        Me.Lb_CompanyName.Text = "* Company name cannot be empty"
        Me.Lb_CompanyName.Visible = False
        '
        'Lb_Nif
        '
        Me.Lb_Nif.AutoSize = True
        Me.Lb_Nif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Nif.ForeColor = System.Drawing.Color.Red
        Me.Lb_Nif.Location = New System.Drawing.Point(211, 168)
        Me.Lb_Nif.Name = "Lb_Nif"
        Me.Lb_Nif.Size = New System.Drawing.Size(111, 13)
        Me.Lb_Nif.TabIndex = 35
        Me.Lb_Nif.Text = "* NIF cannot be empty"
        Me.Lb_Nif.Visible = False
        '
        'Tb_Description
        '
        Me.Tb_Description.Location = New System.Drawing.Point(146, 413)
        Me.Tb_Description.Multiline = True
        Me.Tb_Description.Name = "Tb_Description"
        Me.Tb_Description.Size = New System.Drawing.Size(200, 97)
        Me.Tb_Description.TabIndex = 34
        '
        'Tb_Email
        '
        Me.Tb_Email.Location = New System.Drawing.Point(201, 360)
        Me.Tb_Email.Name = "Tb_Email"
        Me.Tb_Email.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Email.TabIndex = 33
        '
        'Tb_PhoneNumber
        '
        Me.Tb_PhoneNumber.Location = New System.Drawing.Point(201, 308)
        Me.Tb_PhoneNumber.Name = "Tb_PhoneNumber"
        Me.Tb_PhoneNumber.Size = New System.Drawing.Size(145, 20)
        Me.Tb_PhoneNumber.TabIndex = 32
        '
        'Tb_Location
        '
        Me.Tb_Location.Location = New System.Drawing.Point(201, 255)
        Me.Tb_Location.Name = "Tb_Location"
        Me.Tb_Location.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Location.TabIndex = 31
        '
        'Tb_Nif
        '
        Me.Tb_Nif.Location = New System.Drawing.Point(201, 145)
        Me.Tb_Nif.Name = "Tb_Nif"
        Me.Tb_Nif.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Nif.TabIndex = 30
        '
        'tb_CompanyName
        '
        Me.tb_CompanyName.Location = New System.Drawing.Point(201, 92)
        Me.tb_CompanyName.Name = "tb_CompanyName"
        Me.tb_CompanyName.Size = New System.Drawing.Size(145, 20)
        Me.tb_CompanyName.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "NIF:"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.lb_2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.Location = New System.Drawing.Point(38, 93)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(126, 19)
        Me.lb_2.TabIndex = 23
        Me.lb_2.Text = "Company Name:"
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(214, 538)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 39
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'Bt_Create
        '
        Me.Bt_Create.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Create.Location = New System.Drawing.Point(61, 538)
        Me.Bt_Create.Name = "Bt_Create"
        Me.Bt_Create.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Create.TabIndex = 38
        Me.Bt_Create.Text = "Create"
        Me.Bt_Create.UseVisualStyleBackColor = False
        '
        'Lb_PhoneNumber
        '
        Me.Lb_PhoneNumber.AutoSize = True
        Me.Lb_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PhoneNumber.ForeColor = System.Drawing.Color.Red
        Me.Lb_PhoneNumber.Location = New System.Drawing.Point(198, 331)
        Me.Lb_PhoneNumber.Name = "Lb_PhoneNumber"
        Me.Lb_PhoneNumber.Size = New System.Drawing.Size(165, 13)
        Me.Lb_PhoneNumber.TabIndex = 40
        Me.Lb_PhoneNumber.Text = "* Phone Number cannot be empty"
        Me.Lb_PhoneNumber.Visible = False
        '
        'Lb_Email
        '
        Me.Lb_Email.AutoSize = True
        Me.Lb_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Email.ForeColor = System.Drawing.Color.Red
        Me.Lb_Email.Location = New System.Drawing.Point(198, 383)
        Me.Lb_Email.Name = "Lb_Email"
        Me.Lb_Email.Size = New System.Drawing.Size(120, 13)
        Me.Lb_Email.TabIndex = 41
        Me.Lb_Email.Text = "* Email cannot be empty"
        Me.Lb_Email.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(198, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "*Type of Business cannot be empty"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Type of Business:"
        '
        'Cb_TypeBusiness
        '
        Me.Cb_TypeBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TypeBusiness.FormattingEnabled = True
        Me.Cb_TypeBusiness.Location = New System.Drawing.Point(201, 197)
        Me.Cb_TypeBusiness.Name = "Cb_TypeBusiness"
        Me.Cb_TypeBusiness.Size = New System.Drawing.Size(145, 21)
        Me.Cb_TypeBusiness.TabIndex = 45
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
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
        'CreateCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 594)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Cb_TypeBusiness)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Lb_Email)
        Me.Controls.Add(Me.Lb_PhoneNumber)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Create)
        Me.Controls.Add(Me.Lb_Location)
        Me.Controls.Add(Me.Lb_CompanyName)
        Me.Controls.Add(Me.Lb_Nif)
        Me.Controls.Add(Me.Tb_Description)
        Me.Controls.Add(Me.Tb_Email)
        Me.Controls.Add(Me.Tb_PhoneNumber)
        Me.Controls.Add(Me.Tb_Location)
        Me.Controls.Add(Me.Tb_Nif)
        Me.Controls.Add(Me.tb_CompanyName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_2)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Lb_Location As Label
    Friend WithEvents Lb_CompanyName As Label
    Friend WithEvents Lb_Nif As Label
    Friend WithEvents Tb_Description As TextBox
    Friend WithEvents Tb_Email As TextBox
    Friend WithEvents Tb_PhoneNumber As TextBox
    Friend WithEvents Tb_Location As TextBox
    Friend WithEvents Tb_Nif As TextBox
    Friend WithEvents tb_CompanyName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_2 As Label
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents Bt_Create As Button
    Friend WithEvents Lb_PhoneNumber As Label
    Friend WithEvents Lb_Email As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_TypeBusiness As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
End Class
