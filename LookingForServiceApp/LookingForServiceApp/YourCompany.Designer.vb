<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YourCompany
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YourCompany))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Edit = New System.Windows.Forms.Button()
        Me.Lb_Type = New System.Windows.Forms.Label()
        Me.Lb_Description = New System.Windows.Forms.Label()
        Me.Lb_Email = New System.Windows.Forms.Label()
        Me.Lb_PhoneNumber = New System.Windows.Forms.Label()
        Me.Lb_Location = New System.Windows.Forms.Label()
        Me.Lb_NIF = New System.Windows.Forms.Label()
        Me.Lb_CompanyName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Type of Business:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "NIF:"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.lb_2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.Location = New System.Drawing.Point(42, 92)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(126, 19)
        Me.lb_2.TabIndex = 47
        Me.lb_2.Text = "Company Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 23)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "YOUR COMPANY"
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(210, 504)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 68
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'Bt_Edit
        '
        Me.Bt_Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Edit.Location = New System.Drawing.Point(57, 504)
        Me.Bt_Edit.Name = "Bt_Edit"
        Me.Bt_Edit.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Edit.TabIndex = 67
        Me.Bt_Edit.Text = "Edit"
        Me.Bt_Edit.UseVisualStyleBackColor = False
        '
        'Lb_Type
        '
        Me.Lb_Type.AutoSize = True
        Me.Lb_Type.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Type.Location = New System.Drawing.Point(206, 198)
        Me.Lb_Type.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_Type.Name = "Lb_Type"
        Me.Lb_Type.Size = New System.Drawing.Size(67, 19)
        Me.Lb_Type.TabIndex = 75
        Me.Lb_Type.Text = "business"
        '
        'Lb_Description
        '
        Me.Lb_Description.AutoSize = True
        Me.Lb_Description.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Description.Location = New System.Drawing.Point(206, 412)
        Me.Lb_Description.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_Description.Name = "Lb_Description"
        Me.Lb_Description.Size = New System.Drawing.Size(88, 19)
        Me.Lb_Description.TabIndex = 74
        Me.Lb_Description.Text = "description"
        '
        'Lb_Email
        '
        Me.Lb_Email.AutoSize = True
        Me.Lb_Email.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Email.Location = New System.Drawing.Point(206, 359)
        Me.Lb_Email.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_Email.Name = "Lb_Email"
        Me.Lb_Email.Size = New System.Drawing.Size(49, 19)
        Me.Lb_Email.TabIndex = 73
        Me.Lb_Email.Text = "email"
        '
        'Lb_PhoneNumber
        '
        Me.Lb_PhoneNumber.AutoSize = True
        Me.Lb_PhoneNumber.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PhoneNumber.Location = New System.Drawing.Point(206, 305)
        Me.Lb_PhoneNumber.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_PhoneNumber.Name = "Lb_PhoneNumber"
        Me.Lb_PhoneNumber.Size = New System.Drawing.Size(53, 19)
        Me.Lb_PhoneNumber.TabIndex = 72
        Me.Lb_PhoneNumber.Text = "phone"
        '
        'Lb_Location
        '
        Me.Lb_Location.AutoSize = True
        Me.Lb_Location.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Location.Location = New System.Drawing.Point(206, 252)
        Me.Lb_Location.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_Location.Name = "Lb_Location"
        Me.Lb_Location.Size = New System.Drawing.Size(67, 19)
        Me.Lb_Location.TabIndex = 71
        Me.Lb_Location.Text = "location"
        '
        'Lb_NIF
        '
        Me.Lb_NIF.AutoSize = True
        Me.Lb_NIF.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NIF.Location = New System.Drawing.Point(206, 145)
        Me.Lb_NIF.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_NIF.Name = "Lb_NIF"
        Me.Lb_NIF.Size = New System.Drawing.Size(28, 19)
        Me.Lb_NIF.TabIndex = 70
        Me.Lb_NIF.Text = "nif"
        '
        'Lb_CompanyName
        '
        Me.Lb_CompanyName.AutoSize = True
        Me.Lb_CompanyName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CompanyName.Location = New System.Drawing.Point(206, 92)
        Me.Lb_CompanyName.MaximumSize = New System.Drawing.Size(175, 0)
        Me.Lb_CompanyName.Name = "Lb_CompanyName"
        Me.Lb_CompanyName.Size = New System.Drawing.Size(48, 19)
        Me.Lb_CompanyName.TabIndex = 69
        Me.Lb_CompanyName.Text = "name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 76
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        'YourCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 559)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Lb_Type)
        Me.Controls.Add(Me.Lb_Description)
        Me.Controls.Add(Me.Lb_Email)
        Me.Controls.Add(Me.Lb_PhoneNumber)
        Me.Controls.Add(Me.Lb_Location)
        Me.Controls.Add(Me.Lb_NIF)
        Me.Controls.Add(Me.Lb_CompanyName)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Edit)
        Me.Controls.Add(Me.Label8)
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
        Me.Name = "YourCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents Bt_Edit As Button
    Friend WithEvents Lb_Type As Label
    Friend WithEvents Lb_Description As Label
    Friend WithEvents Lb_Email As Label
    Friend WithEvents Lb_PhoneNumber As Label
    Friend WithEvents Lb_Location As Label
    Friend WithEvents Lb_NIF As Label
    Friend WithEvents Lb_CompanyName As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
End Class
