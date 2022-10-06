<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.signinbtn = New System.Windows.Forms.Button()
        Me.Exitlogin = New System.Windows.Forms.Button()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.gree = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'signinbtn
        '
        Me.signinbtn.Location = New System.Drawing.Point(298, 256)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(75, 35)
        Me.signinbtn.TabIndex = 0
        Me.signinbtn.Text = "Sign in"
        Me.signinbtn.UseVisualStyleBackColor = True
        '
        'Exitlogin
        '
        Me.Exitlogin.Location = New System.Drawing.Point(402, 256)
        Me.Exitlogin.Name = "Exitlogin"
        Me.Exitlogin.Size = New System.Drawing.Size(75, 35)
        Me.Exitlogin.TabIndex = 1
        Me.Exitlogin.Text = "Cancel"
        Me.Exitlogin.UseVisualStyleBackColor = True
        '
        'signupbtn
        '
        Me.signupbtn.BackColor = System.Drawing.Color.Transparent
        Me.signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.signupbtn.FlatAppearance.BorderSize = 0
        Me.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signupbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.signupbtn.Location = New System.Drawing.Point(257, 305)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(274, 23)
        Me.signupbtn.TabIndex = 2
        Me.signupbtn.Text = "Don't have Account? Create new one."
        Me.signupbtn.UseVisualStyleBackColor = False
        '
        'gree
        '
        Me.gree.AutoSize = True
        Me.gree.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gree.Location = New System.Drawing.Point(214, 65)
        Me.gree.Name = "gree"
        Me.gree.Size = New System.Drawing.Size(377, 46)
        Me.gree.TabIndex = 3
        Me.gree.Text = "Login to your Account"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(265, 145)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(45, 16)
        Me.email.TabIndex = 4
        Me.email.Text = "E-Mail"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(265, 203)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(67, 16)
        Me.password.TabIndex = 5
        Me.password.Text = "Password"
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(355, 142)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(152, 22)
        Me.emailtxt.TabIndex = 6
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(355, 203)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(152, 22)
        Me.passwordtxt.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.gree)
        Me.Controls.Add(Me.signupbtn)
        Me.Controls.Add(Me.Exitlogin)
        Me.Controls.Add(Me.signinbtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents signinbtn As Button
    Friend WithEvents Exitlogin As Button
    Friend WithEvents signupbtn As Button
    Friend WithEvents gree As Label
    Friend WithEvents email As Label
    Friend WithEvents password As Label
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents passwordtxt As TextBox
End Class
