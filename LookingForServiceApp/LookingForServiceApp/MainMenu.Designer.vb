<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Bt_Profile = New System.Windows.Forms.Button()
        Me.Lb_UserName = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Pb_User = New System.Windows.Forms.PictureBox()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Bt_Search = New System.Windows.Forms.Button()
        Me.lb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.Pb_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_Profile
        '
        Me.Bt_Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Profile.Location = New System.Drawing.Point(29, 128)
        Me.Bt_Profile.Name = "Bt_Profile"
        Me.Bt_Profile.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Profile.TabIndex = 6
        Me.Bt_Profile.Text = "Your Profile"
        Me.Bt_Profile.UseVisualStyleBackColor = False
        '
        'Lb_UserName
        '
        Me.Lb_UserName.AutoSize = True
        Me.Lb_UserName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_UserName.Location = New System.Drawing.Point(52, 95)
        Me.Lb_UserName.Name = "Lb_UserName"
        Me.Lb_UserName.Size = New System.Drawing.Size(44, 19)
        Me.Lb_UserName.TabIndex = 7
        Me.Lb_UserName.Text = "Nick"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Pb_User)
        Me.Panel.Controls.Add(Me.Bt_Profile)
        Me.Panel.Controls.Add(Me.Lb_UserName)
        Me.Panel.Location = New System.Drawing.Point(223, 38)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(166, 165)
        Me.Panel.TabIndex = 9
        '
        'Pb_User
        '
        Me.Pb_User.Image = Global.LookingForServiceApp.My.Resources.Resources.Avatar
        Me.Pb_User.InitialImage = Nothing
        Me.Pb_User.Location = New System.Drawing.Point(42, 0)
        Me.Pb_User.Name = "Pb_User"
        Me.Pb_User.Size = New System.Drawing.Size(85, 80)
        Me.Pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb_User.TabIndex = 8
        Me.Pb_User.TabStop = False
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.InicioToolStripMenuItem.Text = "Home"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MenuToolStripMenuItem.Text = "Main Menu"
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
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ContactToolStripMenuItem.Text = "Contact "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(409, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Bt_Search
        '
        Me.Bt_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Search.Location = New System.Drawing.Point(47, 166)
        Me.Bt_Search.Name = "Bt_Search"
        Me.Bt_Search.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Search.TabIndex = 11
        Me.Bt_Search.Text = "Search"
        Me.Bt_Search.UseVisualStyleBackColor = False
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Font = New System.Drawing.Font("Constantia", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(24, 38)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(184, 22)
        Me.lb.TabIndex = 78
        Me.lb.Text = "Welcome to LOOKS!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 57)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Find services in your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "city whenever" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you need it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 226)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Bt_Search)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.Pb_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_UserName As Label
    Friend WithEvents Pb_User As PictureBox
    Friend WithEvents Panel As Panel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Public WithEvents Bt_Search As Button
    Friend WithEvents lb As Label
    Friend WithEvents Label1 As Label
    Public WithEvents Bt_Profile As Button
End Class
