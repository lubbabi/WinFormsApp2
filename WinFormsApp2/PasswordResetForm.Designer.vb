<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordResetForm
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
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        NewPasswordTB = New TextBox()
        Label7 = New Label()
        EmailAddressTB = New TextBox()
        Label8 = New Label()
        ResetPasswordBTN = New Button()
        ConfirmPW = New TextBox()
        Label1 = New Label()
        SendOTP = New Button()
        OTPcode = New TextBox()
        Label6 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        ExitPRF = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Black
        PictureBox2.Location = New Point(12, 183)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(10, 50)
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(28, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(325, 50)
        Label4.TabIndex = 15
        Label4.Text = "ACCOUNT RECOVERY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 10.8F)
        Label2.ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        Label2.Location = New Point(90, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 31)
        Label2.TabIndex = 20
        Label2.Text = "Colegio De Montalban"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        Label3.Location = New Point(90, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(298, 31)
        Label3.TabIndex = 19
        Label3.Text = "BARANGAY E-VOTING SYSTEM"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.montalbanlogo
        PictureBox4.Location = New Point(12, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(72, 72)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(34, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(320, 100)
        Label5.TabIndex = 21
        Label5.Text = "To reset your password, please provide the email associated with your account"
        ' 
        ' NewPasswordTB
        ' 
        NewPasswordTB.Font = New Font("Segoe UI", 12F)
        NewPasswordTB.Location = New Point(453, 336)
        NewPasswordTB.Name = "NewPasswordTB"
        NewPasswordTB.Size = New Size(295, 34)
        NewPasswordTB.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(453, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 28)
        Label7.TabIndex = 31
        Label7.Text = "New Password"
        ' 
        ' EmailAddressTB
        ' 
        EmailAddressTB.Font = New Font("Segoe UI", 12F)
        EmailAddressTB.Location = New Point(453, 183)
        EmailAddressTB.Name = "EmailAddressTB"
        EmailAddressTB.Size = New Size(295, 34)
        EmailAddressTB.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(453, 152)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 28)
        Label8.TabIndex = 30
        Label8.Text = "Email Address"
        ' 
        ' ResetPasswordBTN
        ' 
        ResetPasswordBTN.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(97))
        ResetPasswordBTN.FlatAppearance.BorderSize = 0
        ResetPasswordBTN.FlatStyle = FlatStyle.Flat
        ResetPasswordBTN.Font = New Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetPasswordBTN.ForeColor = SystemColors.ControlLight
        ResetPasswordBTN.Location = New Point(453, 474)
        ResetPasswordBTN.Name = "ResetPasswordBTN"
        ResetPasswordBTN.Size = New Size(295, 50)
        ResetPasswordBTN.TabIndex = 25
        ResetPasswordBTN.Text = "RESET"
        ResetPasswordBTN.UseVisualStyleBackColor = False
        ' 
        ' ConfirmPW
        ' 
        ConfirmPW.Font = New Font("Segoe UI", 12F)
        ConfirmPW.Location = New Point(453, 413)
        ConfirmPW.Name = "ConfirmPW"
        ConfirmPW.Size = New Size(295, 34)
        ConfirmPW.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(453, 382)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 28)
        Label1.TabIndex = 33
        Label1.Text = "Confirm Password"
        ' 
        ' SendOTP
        ' 
        SendOTP.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(97))
        SendOTP.FlatAppearance.BorderSize = 0
        SendOTP.FlatStyle = FlatStyle.Flat
        SendOTP.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SendOTP.ForeColor = SystemColors.ControlLight
        SendOTP.Location = New Point(635, 260)
        SendOTP.Name = "SendOTP"
        SendOTP.Size = New Size(113, 34)
        SendOTP.TabIndex = 34
        SendOTP.Text = "Send Code"
        SendOTP.UseVisualStyleBackColor = False
        ' 
        ' OTPcode
        ' 
        OTPcode.Font = New Font("Segoe UI", 12F)
        OTPcode.Location = New Point(453, 260)
        OTPcode.Name = "OTPcode"
        OTPcode.Size = New Size(176, 34)
        OTPcode.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(453, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 28)
        Label6.TabIndex = 36
        Label6.Text = "OTP"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(451, 98)
        Label9.Name = "Label9"
        Label9.Size = New Size(290, 40)
        Label9.TabIndex = 37
        Label9.Text = "Recover Your Account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(454, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 3)
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' ExitPRF
        ' 
        ExitPRF.BackColor = Color.Firebrick
        ExitPRF.FlatAppearance.BorderSize = 0
        ExitPRF.FlatAppearance.MouseOverBackColor = Color.Silver
        ExitPRF.FlatStyle = FlatStyle.Flat
        ExitPRF.Font = New Font("Manrope ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitPRF.ForeColor = SystemColors.ControlLight
        ExitPRF.Location = New Point(792, 0)
        ExitPRF.Name = "ExitPRF"
        ExitPRF.Size = New Size(32, 29)
        ExitPRF.TabIndex = 39
        ExitPRF.Text = "X"
        ExitPRF.UseVisualStyleBackColor = False
        ' 
        ' PasswordResetForm
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources._1917195_plain
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(823, 583)
        Controls.Add(ExitPRF)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(OTPcode)
        Controls.Add(SendOTP)
        Controls.Add(ConfirmPW)
        Controls.Add(Label1)
        Controls.Add(NewPasswordTB)
        Controls.Add(Label7)
        Controls.Add(EmailAddressTB)
        Controls.Add(Label8)
        Controls.Add(ResetPasswordBTN)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PasswordResetForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RecoverAccountForm"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NewPasswordTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EmailAddressTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ResetPasswordBTN As Button
    Friend WithEvents ConfirmPW As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SendOTP As Button
    Friend WithEvents OTPcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitPRF As Button
End Class
