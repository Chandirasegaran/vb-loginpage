<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signupform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gree = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.Label()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.citytxt = New System.Windows.Forms.TextBox()
        Me.signinbtn = New System.Windows.Forms.Button()
        Me.Exitlogin = New System.Windows.Forms.Button()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gree
        '
        Me.gree.AutoSize = True
        Me.gree.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gree.Location = New System.Drawing.Point(258, 26)
        Me.gree.Name = "gree"
        Me.gree.Size = New System.Drawing.Size(258, 45)
        Me.gree.TabIndex = 4
        Me.gree.Text = "Create Account"
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Location = New System.Drawing.Point(206, 106)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(44, 16)
        Me.name.TabIndex = 5
        Me.name.Text = "Name"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(206, 142)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(45, 16)
        Me.email.TabIndex = 6
        Me.email.Text = "E-Mail"
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Location = New System.Drawing.Point(206, 173)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(67, 16)
        Me.pass.TabIndex = 7
        Me.pass.Text = "Password"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(206, 207)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(115, 16)
        Me.password.TabIndex = 8
        Me.password.Text = "Confirm Password"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(206, 237)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(46, 16)
        Me.phone.TabIndex = 9
        Me.phone.Text = "Phone"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Location = New System.Drawing.Point(206, 268)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(32, 16)
        Me.age.TabIndex = 10
        Me.age.Text = "Age"
        '
        'city
        '
        Me.city.AutoSize = True
        Me.city.Location = New System.Drawing.Point(206, 299)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(29, 16)
        Me.city.TabIndex = 11
        Me.city.Text = "City"
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(371, 106)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(197, 22)
        Me.nametxt.TabIndex = 12
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(371, 142)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(197, 22)
        Me.emailtxt.TabIndex = 13
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(371, 173)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(197, 22)
        Me.passtxt.TabIndex = 14
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.passwordtxt.Location = New System.Drawing.Point(371, 207)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(197, 22)
        Me.passwordtxt.TabIndex = 15
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(371, 237)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(197, 22)
        Me.phonetxt.TabIndex = 16
        '
        'agetxt
        '
        Me.agetxt.Location = New System.Drawing.Point(371, 268)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(197, 22)
        Me.agetxt.TabIndex = 17
        '
        'citytxt
        '
        Me.citytxt.Location = New System.Drawing.Point(371, 299)
        Me.citytxt.Name = "citytxt"
        Me.citytxt.Size = New System.Drawing.Size(197, 22)
        Me.citytxt.TabIndex = 18
        '
        'signinbtn
        '
        Me.signinbtn.BackColor = System.Drawing.Color.Transparent
        Me.signinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.signinbtn.FlatAppearance.BorderSize = 0
        Me.signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signinbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.signinbtn.Location = New System.Drawing.Point(246, 380)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(274, 31)
        Me.signinbtn.TabIndex = 19
        Me.signinbtn.Text = "Already Having Account? Sign in."
        Me.signinbtn.UseVisualStyleBackColor = False
        '
        'Exitlogin
        '
        Me.Exitlogin.Location = New System.Drawing.Point(399, 339)
        Me.Exitlogin.Name = "Exitlogin"
        Me.Exitlogin.Size = New System.Drawing.Size(75, 35)
        Me.Exitlogin.TabIndex = 21
        Me.Exitlogin.Text = "Cancel"
        Me.Exitlogin.UseVisualStyleBackColor = True
        '
        'signupbtn
        '
        Me.signupbtn.Location = New System.Drawing.Point(295, 339)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(75, 35)
        Me.signupbtn.TabIndex = 20
        Me.signupbtn.Text = "Sign Up"
        Me.signupbtn.UseVisualStyleBackColor = True
        '
        'Signupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exitlogin)
        Me.Controls.Add(Me.signupbtn)
        Me.Controls.Add(Me.signinbtn)
        Me.Controls.Add(Me.citytxt)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.gree)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Dim name As String
        name = "Signupform"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gree As Label
    Friend WithEvents name As Label
    Friend WithEvents email As Label
    Friend WithEvents pass As Label
    Friend WithEvents password As Label
    Friend WithEvents phone As Label
    Friend WithEvents age As Label
    Friend WithEvents city As Label
    Friend WithEvents nametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents agetxt As TextBox
    Friend WithEvents citytxt As TextBox
    Friend WithEvents signinbtn As Button
    Friend WithEvents Exitlogin As Button
    Friend WithEvents signupbtn As Button
End Class
