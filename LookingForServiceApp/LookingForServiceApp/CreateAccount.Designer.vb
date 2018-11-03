<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        Me.UserName_lb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.Tb_password1 = New System.Windows.Forms.TextBox()
        Me.Tb_Name = New System.Windows.Forms.TextBox()
        Me.Tb_password2 = New System.Windows.Forms.TextBox()
        Me.Tb_email = New System.Windows.Forms.TextBox()
        Me.Tb_SecondName = New System.Windows.Forms.TextBox()
        Me.Rb_Customer = New System.Windows.Forms.RadioButton()
        Me.Rb_Company = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Create = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lb_password1 = New System.Windows.Forms.Label()
        Me.Lb_Username = New System.Windows.Forms.Label()
        Me.Lb_password2 = New System.Windows.Forms.Label()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserName_lb
        '
        Me.UserName_lb.AutoSize = True
        Me.UserName_lb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_lb.Location = New System.Drawing.Point(31, 76)
        Me.UserName_lb.Name = "UserName_lb"
        Me.UserName_lb.Size = New System.Drawing.Size(90, 19)
        Me.UserName_lb.TabIndex = 1
        Me.UserName_lb.Text = "User Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Repeat password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Second Name:"
        '
        'tb_Username
        '
        Me.tb_Username.Location = New System.Drawing.Point(207, 75)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(145, 20)
        Me.tb_Username.TabIndex = 7
        '
        'Tb_password1
        '
        Me.Tb_password1.Location = New System.Drawing.Point(207, 131)
        Me.Tb_password1.Name = "Tb_password1"
        Me.Tb_password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_password1.Size = New System.Drawing.Size(145, 20)
        Me.Tb_password1.TabIndex = 8
        '
        'Tb_Name
        '
        Me.Tb_Name.Location = New System.Drawing.Point(207, 240)
        Me.Tb_Name.Name = "Tb_Name"
        Me.Tb_Name.Size = New System.Drawing.Size(145, 20)
        Me.Tb_Name.TabIndex = 10
        '
        'Tb_password2
        '
        Me.Tb_password2.Location = New System.Drawing.Point(207, 187)
        Me.Tb_password2.Name = "Tb_password2"
        Me.Tb_password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_password2.Size = New System.Drawing.Size(145, 20)
        Me.Tb_password2.TabIndex = 9
        '
        'Tb_email
        '
        Me.Tb_email.Location = New System.Drawing.Point(207, 345)
        Me.Tb_email.Name = "Tb_email"
        Me.Tb_email.Size = New System.Drawing.Size(145, 20)
        Me.Tb_email.TabIndex = 12
        '
        'Tb_SecondName
        '
        Me.Tb_SecondName.Location = New System.Drawing.Point(207, 292)
        Me.Tb_SecondName.Name = "Tb_SecondName"
        Me.Tb_SecondName.Size = New System.Drawing.Size(145, 20)
        Me.Tb_SecondName.TabIndex = 11
        '
        'Rb_Customer
        '
        Me.Rb_Customer.AutoSize = True
        Me.Rb_Customer.Checked = True
        Me.Rb_Customer.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Customer.Location = New System.Drawing.Point(58, 437)
        Me.Rb_Customer.Name = "Rb_Customer"
        Me.Rb_Customer.Size = New System.Drawing.Size(95, 23)
        Me.Rb_Customer.TabIndex = 13
        Me.Rb_Customer.TabStop = True
        Me.Rb_Customer.Text = "Customer"
        Me.Rb_Customer.UseVisualStyleBackColor = True
        '
        'Rb_Company
        '
        Me.Rb_Company.AutoSize = True
        Me.Rb_Company.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Company.Location = New System.Drawing.Point(228, 437)
        Me.Rb_Company.Name = "Rb_Company"
        Me.Rb_Company.Size = New System.Drawing.Size(94, 23)
        Me.Rb_Company.TabIndex = 14
        Me.Rb_Company.Text = "Company"
        Me.Rb_Company.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "What kind of user are you going to be?"
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cancel.Location = New System.Drawing.Point(211, 489)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Cancel.TabIndex = 17
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = False
        '
        'Bt_Create
        '
        Me.Bt_Create.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bt_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Create.Location = New System.Drawing.Point(58, 489)
        Me.Bt_Create.Name = "Bt_Create"
        Me.Bt_Create.Size = New System.Drawing.Size(113, 30)
        Me.Bt_Create.TabIndex = 16
        Me.Bt_Create.Text = "Create"
        Me.Bt_Create.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "CREATE A NEW ACCOUNT"
        '
        'Lb_password1
        '
        Me.Lb_password1.AutoSize = True
        Me.Lb_password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_password1.ForeColor = System.Drawing.Color.Red
        Me.Lb_password1.Location = New System.Drawing.Point(204, 154)
        Me.Lb_password1.Name = "Lb_password1"
        Me.Lb_password1.Size = New System.Drawing.Size(141, 13)
        Me.Lb_password1.TabIndex = 19
        Me.Lb_password1.Text = "* Password cannot be empty"
        Me.Lb_password1.Visible = False
        '
        'Lb_Username
        '
        Me.Lb_Username.AutoSize = True
        Me.Lb_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Username.ForeColor = System.Drawing.Color.Red
        Me.Lb_Username.Location = New System.Drawing.Point(204, 98)
        Me.Lb_Username.Name = "Lb_Username"
        Me.Lb_Username.Size = New System.Drawing.Size(142, 13)
        Me.Lb_Username.TabIndex = 20
        Me.Lb_Username.Text = "* Username cannot be empty"
        Me.Lb_Username.Visible = False
        '
        'Lb_password2
        '
        Me.Lb_password2.AutoSize = True
        Me.Lb_password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_password2.ForeColor = System.Drawing.Color.Red
        Me.Lb_password2.Location = New System.Drawing.Point(204, 210)
        Me.Lb_password2.Name = "Lb_password2"
        Me.Lb_password2.Size = New System.Drawing.Size(135, 13)
        Me.Lb_password2.TabIndex = 21
        Me.Lb_password2.Text = "* Passwords are not equals"
        Me.Lb_password2.Visible = False
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.ForeColor = System.Drawing.Color.Red
        Me.Lb_email.Location = New System.Drawing.Point(204, 368)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(120, 13)
        Me.Lb_email.TabIndex = 22
        Me.Lb_email.Text = "* Email cannot be empty"
        Me.Lb_email.Visible = False
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 540)
        Me.Controls.Add(Me.Lb_email)
        Me.Controls.Add(Me.Lb_password2)
        Me.Controls.Add(Me.Lb_Username)
        Me.Controls.Add(Me.Lb_password1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Create)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Rb_Company)
        Me.Controls.Add(Me.Rb_Customer)
        Me.Controls.Add(Me.Tb_email)
        Me.Controls.Add(Me.Tb_SecondName)
        Me.Controls.Add(Me.Tb_Name)
        Me.Controls.Add(Me.Tb_password2)
        Me.Controls.Add(Me.Tb_password1)
        Me.Controls.Add(Me.tb_Username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserName_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOOKS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName_lb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents Tb_password1 As TextBox
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Tb_password2 As TextBox
    Friend WithEvents Tb_email As TextBox
    Friend WithEvents Tb_SecondName As TextBox
    Friend WithEvents Rb_Customer As RadioButton
    Friend WithEvents Rb_Company As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents Bt_Create As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Lb_password1 As Label
    Friend WithEvents Lb_Username As Label
    Friend WithEvents Lb_password2 As Label
    Friend WithEvents Lb_email As Label
End Class
