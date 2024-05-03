<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Label5 = New Label()
        Label6 = New Label()
        LoginBTN = New Button()
        ResetPassword = New LinkLabel()
        LoginUsernameTB = New TextBox()
        CheckBox1 = New CheckBox()
        LoginPasswordTB = New TextBox()
        CreateAccountLINK = New LinkLabel()
        Panel1 = New Panel()
        CloseProgram = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Outfit Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(87, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 47)
        Label5.TabIndex = 12
        Label5.Text = "LOG IN"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Outfit", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(33, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(245, 34)
        Label6.TabIndex = 13
        Label6.Text = "TO ACCESS THE SYSTEM"
        ' 
        ' LoginBTN
        ' 
        LoginBTN.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(97))
        LoginBTN.FlatAppearance.BorderSize = 0
        LoginBTN.FlatStyle = FlatStyle.Flat
        LoginBTN.Font = New Font("Poppins", 10.8F)
        LoginBTN.ForeColor = SystemColors.ControlLight
        LoginBTN.Location = New Point(175, 403)
        LoginBTN.Name = "LoginBTN"
        LoginBTN.Size = New Size(245, 46)
        LoginBTN.TabIndex = 16
        LoginBTN.Text = "LOGIN"
        LoginBTN.UseVisualStyleBackColor = False
        ' 
        ' ResetPassword
        ' 
        ResetPassword.AutoSize = True
        ResetPassword.BackColor = Color.Transparent
        ResetPassword.Font = New Font("Poppins", 9F)
        ResetPassword.ForeColor = SystemColors.ControlText
        ResetPassword.LinkColor = Color.Black
        ResetPassword.Location = New Point(298, 350)
        ResetPassword.Name = "ResetPassword"
        ResetPassword.Size = New Size(129, 26)
        ResetPassword.TabIndex = 21
        ResetPassword.TabStop = True
        ResetPassword.Text = "Reset Password"
        ' 
        ' LoginUsernameTB
        ' 
        LoginUsernameTB.Font = New Font("Segoe UI", 10.8F)
        LoginUsernameTB.Location = New Point(175, 257)
        LoginUsernameTB.Name = "LoginUsernameTB"
        LoginUsernameTB.PlaceholderText = "Admin ID"
        LoginUsernameTB.Size = New Size(245, 31)
        LoginUsernameTB.TabIndex = 18
        LoginUsernameTB.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Poppins", 9F)
        CheckBox1.ForeColor = SystemColors.Desktop
        CheckBox1.Location = New Point(175, 347)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(97, 30)
        CheckBox1.TabIndex = 20
        CheckBox1.Text = "Show PS"
        CheckBox1.TextAlign = ContentAlignment.BottomCenter
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' LoginPasswordTB
        ' 
        LoginPasswordTB.Font = New Font("Segoe UI", 10.8F)
        LoginPasswordTB.Location = New Point(175, 305)
        LoginPasswordTB.Name = "LoginPasswordTB"
        LoginPasswordTB.PlaceholderText = "Password"
        LoginPasswordTB.Size = New Size(245, 31)
        LoginPasswordTB.TabIndex = 19
        LoginPasswordTB.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateAccountLINK
        ' 
        CreateAccountLINK.AutoSize = True
        CreateAccountLINK.BackColor = Color.Transparent
        CreateAccountLINK.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CreateAccountLINK.LinkColor = Color.OrangeRed
        CreateAccountLINK.Location = New Point(12, 505)
        CreateAccountLINK.Name = "CreateAccountLINK"
        CreateAccountLINK.Size = New Size(205, 20)
        CreateAccountLINK.TabIndex = 27
        CreateAccountLINK.TabStop = True
        CreateAccountLINK.Text = "Create Administrator Account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Panel1.Controls.Add(CloseProgram)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(592, 156)
        Panel1.TabIndex = 28
        ' 
        ' CloseProgram
        ' 
        CloseProgram.BackColor = Color.Firebrick
        CloseProgram.FlatAppearance.BorderSize = 0
        CloseProgram.FlatAppearance.MouseOverBackColor = Color.Silver
        CloseProgram.FlatStyle = FlatStyle.Flat
        CloseProgram.Font = New Font("Manrope ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseProgram.ForeColor = SystemColors.ControlLight
        CloseProgram.Location = New Point(560, 0)
        CloseProgram.Name = "CloseProgram"
        CloseProgram.Size = New Size(32, 29)
        CloseProgram.TabIndex = 40
        CloseProgram.Text = "X"
        CloseProgram.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(142, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(311, 409)
        Panel2.TabIndex = 26
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(252, 164)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 7.20000029F)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(527, 508)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 17)
        Label1.TabIndex = 30
        Label1.Text = "© CDM"
        ' 
        ' LoginForm
        ' 
        AcceptButton = LoginBTN
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.Gainsboro
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(592, 534)
        Controls.Add(PictureBox1)
        Controls.Add(LoginPasswordTB)
        Controls.Add(ResetPassword)
        Controls.Add(CheckBox1)
        Controls.Add(LoginUsernameTB)
        Controls.Add(LoginBTN)
        Controls.Add(Label1)
        Controls.Add(CreateAccountLINK)
        Controls.Add(Panel1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LoginBTN As Button
    Friend WithEvents ResetPassword As LinkLabel
    Friend WithEvents LoginUsernameTB As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LoginPasswordTB As TextBox
    Friend WithEvents CreateAccountLINK As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseProgram As Button
End Class
