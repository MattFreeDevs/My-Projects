<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.UserName_lb = New System.Windows.Forms.Label()
        Me.tb_oldPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_NewPassword1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_NewPassword2 = New System.Windows.Forms.TextBox()
        Me.Lb_password1 = New System.Windows.Forms.Label()
        Me.Lb_password2 = New System.Windows.Forms.Label()
        Me.Lb_password = New System.Windows.Forms.Label()
        Me.Bt_Save = New System.Windows.Forms.Button()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserName_lb
        '
        Me.UserName_lb.AutoSize = True
        Me.UserName_lb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_lb.Location = New System.Drawing.Point(25, 97)
        Me.UserName_lb.Name = "UserName_lb"
        Me.UserName_lb.Size = New System.Drawing.Size(78, 19)
        Me.UserName_lb.TabIndex = 41
        Me.UserName_lb.Text = "Password:"
        '
        'tb_oldPassword
        '
        Me.tb_oldPassword.Location = New System.Drawing.Point(185, 96)
        Me.tb_oldPassword.Name = "tb_oldPassword"
        Me.tb_oldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_oldPassword.Size = New System.Drawing.Size(145, 20)
        Me.tb_oldPassword.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "CHANGE YOUR PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "New Password:"
        '
        'Tb_NewPassword1
        '
        Me.Tb_NewPassword1.Location = New System.Drawing.Point(185, 155)
        Me.Tb_NewPassword1.Name = "Tb_NewPassword1"
        Me.Tb_NewPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_NewPassword1.Size = New System.Drawing.Size(145, 20)
        Me.Tb_NewPassword1.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Repeat Passowrd:"
        '
        'Tb_NewPassword2
        '
        Me.Tb_NewPassword2.Location = New System.Drawing.Point(185, 214)
        Me.Tb_NewPassword2.Name = "Tb_NewPassword2"
        Me.Tb_NewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_NewPassword2.Size = New System.Drawing.Size(145, 20)
        Me.Tb_NewPassword2.TabIndex = 47
        '
        'Lb_password1
        '
        Me.Lb_password1.AutoSize = True
        Me.Lb_password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_password1.ForeColor = System.Drawing.Color.Red
        Me.Lb_password1.Location = New System.Drawing.Point(182, 178)
        Me.Lb_password1.Name = "Lb_password1"
        Me.Lb_password1.Size = New System.Drawing.Size(141, 13)
        Me.Lb_password1.TabIndex = 50
        Me.Lb_password1.Text = "* Password cannot be empty"
        Me.Lb_password1.Visible = False
        '
        'Lb_password2
        '
        Me.Lb_password2.AutoSize = True
        Me.Lb_password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_password2.ForeColor = System.Drawing.Color.Red
        Me.Lb_password2.Location = New System.Drawing.Point(182, 237)
        Me.Lb_password2.Name = "Lb_password2"
        Me.Lb_password2.Size = New System.Drawing.Size(135, 13)
        Me.Lb_password2.TabIndex = 51
        Me.Lb_password2.Text = "* Passwords are not equals"
        Me.Lb_password2.Visible = False
        '
        'Lb_password
        '
        Me.Lb_password.AutoSize = True
        Me.Lb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_password.ForeColor = System.Drawing.Color.Red
        Me.Lb_password.Location = New System.Drawing.Point(182, 119)
        Me.Lb_password.Name = "Lb_password"
        Me.Lb_password.Size = New System.Drawing.Size(94, 13)
        Me.Lb_password.TabIndex = 52
        Me.Lb_password.Text = "* Invalid Password"
        Me.Lb_password.Visible = False
        '
        'Bt_Save
        '
        Me.Bt_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Save.Location = New System.Drawing.Point(56, 276)
        Me.Bt_Save.Name = "Bt_Save"
        Me.Bt_Save.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Save.TabIndex = 48
        Me.Bt_Save.Text = "Save"
        Me.Bt_Save.UseVisualStyleBackColor = False
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(209, 276)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 49
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem, Me.ContactToolMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip.TabIndex = 54
        Me.MenuStrip.Text = "MenuStrip2"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.LogOutStripMenuItem, Me.ExitStripMenuItem})
        Me.ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenuItem.Text = "Home"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MenuToolStripMenuItem.Text = "Main Menu"
        '
        'LogOutStripMenuItem
        '
        Me.LogOutStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogOutStripMenuItem.Name = "LogOutStripMenuItem"
        Me.LogOutStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LogOutStripMenuItem.Text = "Log out"
        '
        'ExitStripMenuItem
        '
        Me.ExitStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitStripMenuItem.Name = "ExitStripMenuItem"
        Me.ExitStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitStripMenuItem.Text = "Exit"
        '
        'ContactToolMenuItem
        '
        Me.ContactToolMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ContactToolMenuItem.ForeColor = System.Drawing.Color.White
        Me.ContactToolMenuItem.Name = "ContactToolMenuItem"
        Me.ContactToolMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ContactToolMenuItem.Text = "Contact "
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 326)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Lb_password)
        Me.Controls.Add(Me.Lb_password2)
        Me.Controls.Add(Me.Lb_password1)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Save)
        Me.Controls.Add(Me.Tb_NewPassword2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tb_NewPassword1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_oldPassword)
        Me.Controls.Add(Me.UserName_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName_lb As Label
    Friend WithEvents tb_oldPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_NewPassword1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_NewPassword2 As TextBox
    Friend WithEvents Lb_password1 As Label
    Friend WithEvents Lb_password2 As Label
    Friend WithEvents Lb_password As Label
    Friend WithEvents Bt_Save As Button
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolMenuItem As ToolStripMenuItem
End Class
