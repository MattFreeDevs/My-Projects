<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProfile))
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Lb_Username = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rb_Company = New System.Windows.Forms.RadioButton()
        Me.Rb_Customer = New System.Windows.Forms.RadioButton()
        Me.Tb_email = New System.Windows.Forms.TextBox()
        Me.Tb_SecondName = New System.Windows.Forms.TextBox()
        Me.Tb_Name = New System.Windows.Forms.TextBox()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserName_lb = New System.Windows.Forms.Label()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Bt_ChangePassword = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bt_Delete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.ForeColor = System.Drawing.Color.Red
        Me.Lb_email.Location = New System.Drawing.Point(206, 347)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(120, 13)
        Me.Lb_email.TabIndex = 44
        Me.Lb_email.Text = "* Email cannot be empty"
        Me.Lb_email.Visible = False
        '
        'Lb_Username
        '
        Me.Lb_Username.AutoSize = True
        Me.Lb_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Username.ForeColor = System.Drawing.Color.Red
        Me.Lb_Username.Location = New System.Drawing.Point(206, 118)
        Me.Lb_Username.Name = "Lb_Username"
        Me.Lb_Username.Size = New System.Drawing.Size(142, 13)
        Me.Lb_Username.TabIndex = 42
        Me.Lb_Username.Text = "* Username cannot be empty"
        Me.Lb_Username.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(115, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 23)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "EDIT YOUR PROFILE"
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(274, 467)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 39
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'Bt_Save
        '
        Me.Bt_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Save.Location = New System.Drawing.Point(36, 467)
        Me.Bt_Save.Name = "Bt_Save"
        Me.Bt_Save.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Save.TabIndex = 38
        Me.Bt_Save.Text = "Save"
        Me.Bt_Save.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "What kind of user are you going to be?"
        '
        'Rb_Company
        '
        Me.Rb_Company.AutoSize = True
        Me.Rb_Company.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Company.Location = New System.Drawing.Point(246, 418)
        Me.Rb_Company.Name = "Rb_Company"
        Me.Rb_Company.Size = New System.Drawing.Size(94, 23)
        Me.Rb_Company.TabIndex = 36
        Me.Rb_Company.Text = "Company"
        Me.Rb_Company.UseVisualStyleBackColor = True
        '
        'Rb_Customer
        '
        Me.Rb_Customer.AutoSize = True
        Me.Rb_Customer.Checked = True
        Me.Rb_Customer.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Customer.Location = New System.Drawing.Point(76, 418)
        Me.Rb_Customer.Name = "Rb_Customer"
        Me.Rb_Customer.Size = New System.Drawing.Size(95, 23)
        Me.Rb_Customer.TabIndex = 35
        Me.Rb_Customer.TabStop = True
        Me.Rb_Customer.Text = "Customer"
        Me.Rb_Customer.UseVisualStyleBackColor = True
        '
        'Tb_email
        '
        Me.Tb_email.Location = New System.Drawing.Point(209, 324)
        Me.Tb_email.Name = "Tb_email"
        Me.Tb_email.Size = New System.Drawing.Size(145, 20)
        Me.Tb_email.TabIndex = 34
        '
        'Tb_SecondName
        '
        Me.Tb_SecondName.Location = New System.Drawing.Point(209, 271)
        Me.Tb_SecondName.Name = "Tb_SecondName"
        Me.Tb_SecondName.Size = New System.Drawing.Size(145, 20)
        Me.Tb_SecondName.TabIndex = 33
        '
        'Tb_Name
        '
        Me.Tb_Name.Location = New System.Drawing.Point(209, 219)
        Me.Tb_Name.Name = "Tb_Name"
        Me.Tb_Name.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Name.TabIndex = 32
        '
        'tb_Username
        '
        Me.tb_Username.Location = New System.Drawing.Point(209, 95)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(145, 20)
        Me.tb_Username.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Second Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Name:"
        '
        'UserName_lb
        '
        Me.UserName_lb.AutoSize = True
        Me.UserName_lb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_lb.Location = New System.Drawing.Point(49, 96)
        Me.UserName_lb.Name = "UserName_lb"
        Me.UserName_lb.Size = New System.Drawing.Size(90, 19)
        Me.UserName_lb.TabIndex = 23
        Me.UserName_lb.Text = "User Name:"
        '
        'Tb_Password
        '
        Me.Tb_Password.Enabled = False
        Me.Tb_Password.Location = New System.Drawing.Point(209, 149)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_Password.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Password.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 19)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Password:"
        '
        'Bt_ChangePassword
        '
        Me.Bt_ChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_ChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_ChangePassword.Location = New System.Drawing.Point(209, 175)
        Me.Bt_ChangePassword.Name = "Bt_ChangePassword"
        Me.Bt_ChangePassword.Size = New System.Drawing.Size(145, 26)
        Me.Bt_ChangePassword.TabIndex = 96
        Me.Bt_ChangePassword.Text = "Change password"
        Me.Bt_ChangePassword.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 24)
        Me.MenuStrip1.TabIndex = 97
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'bt_Delete
        '
        Me.bt_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bt_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Delete.Location = New System.Drawing.Point(155, 467)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(113, 30)
        Me.bt_Delete.TabIndex = 98
        Me.bt_Delete.Text = "Delete"
        Me.bt_Delete.UseVisualStyleBackColor = False
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 519)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Bt_ChangePassword)
        Me.Controls.Add(Me.Tb_Password)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Lb_email)
        Me.Controls.Add(Me.Lb_Username)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Rb_Company)
        Me.Controls.Add(Me.Rb_Customer)
        Me.Controls.Add(Me.Tb_email)
        Me.Controls.Add(Me.Tb_SecondName)
        Me.Controls.Add(Me.Tb_Name)
        Me.Controls.Add(Me.tb_Username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserName_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_email As Label
    Friend WithEvents Lb_Username As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents Bt_Save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Rb_Company As RadioButton
    Friend WithEvents Rb_Customer As RadioButton
    Friend WithEvents Tb_email As TextBox
    Friend WithEvents Tb_SecondName As TextBox
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserName_lb As Label
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Bt_ChangePassword As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bt_Delete As Button
End Class
