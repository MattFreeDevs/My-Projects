<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UserName_lb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.Bt_Login = New System.Windows.Forms.Button()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.llbl_CreateAccount = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserName_lb
        '
        Me.UserName_lb.AutoSize = True
        Me.UserName_lb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_lb.Location = New System.Drawing.Point(28, 123)
        Me.UserName_lb.Name = "UserName_lb"
        Me.UserName_lb.Size = New System.Drawing.Size(97, 19)
        Me.UserName_lb.TabIndex = 0
        Me.UserName_lb.Text = "User Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password:"
        '
        'tb_Username
        '
        Me.tb_Username.Location = New System.Drawing.Point(153, 122)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(145, 20)
        Me.tb_Username.TabIndex = 2
        '
        'tb_Password
        '
        Me.tb_Password.Location = New System.Drawing.Point(153, 170)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.Size = New System.Drawing.Size(145, 20)
        Me.tb_Password.TabIndex = 3
        '
        'Bt_Login
        '
        Me.Bt_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Login.Location = New System.Drawing.Point(32, 258)
        Me.Bt_Login.Name = "Bt_Login"
        Me.Bt_Login.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Login.TabIndex = 4
        Me.Bt_Login.Text = "Login"
        Me.Bt_Login.UseVisualStyleBackColor = False
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(185, 258)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 5
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'llbl_CreateAccount
        '
        Me.llbl_CreateAccount.AutoSize = True
        Me.llbl_CreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_CreateAccount.Location = New System.Drawing.Point(29, 212)
        Me.llbl_CreateAccount.Name = "llbl_CreateAccount"
        Me.llbl_CreateAccount.Size = New System.Drawing.Size(124, 13)
        Me.llbl_CreateAccount.TabIndex = 7
        Me.llbl_CreateAccount.TabStop = True
        Me.llbl_CreateAccount.Text = "Create New Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LookingForServiceApp.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(120, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 311)
        Me.Controls.Add(Me.llbl_CreateAccount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Login)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_Username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserName_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName_lb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents Bt_Login As Button
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents llbl_CreateAccount As LinkLabel
End Class
