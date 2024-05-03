<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreation
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
        FirstNameTB = New TextBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        LastNameTB = New TextBox()
        Label6 = New Label()
        EmailAddressTB = New TextBox()
        ExitBTN = New Button()
        Label7 = New Label()
        Label8 = New Label()
        UsernameTB = New TextBox()
        AccountTypeCB = New ComboBox()
        Label9 = New Label()
        ConfirmPWTB = New TextBox()
        Label10 = New Label()
        PasswordTB = New TextBox()
        CreateBTN = New Button()
        Label11 = New Label()
        GenderTB = New TextBox()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        AgeNUD = New NumericUpDown()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label13 = New Label()
        PictureBox4 = New PictureBox()
        Label14 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AgeNUD, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FirstNameTB
        ' 
        FirstNameTB.BackColor = SystemColors.Control
        FirstNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstNameTB.Location = New Point(454, 103)
        FirstNameTB.Name = "FirstNameTB"
        FirstNameTB.RightToLeft = RightToLeft.No
        FirstNameTB.Size = New Size(185, 34)
        FirstNameTB.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(455, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 28)
        Label3.TabIndex = 11
        Label3.Text = "First Name :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Black
        PictureBox2.Location = New Point(12, 183)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(10, 50)
        PictureBox2.TabIndex = 14
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
        Label4.Size = New Size(320, 50)
        Label4.TabIndex = 13
        Label4.Text = "ACCOUNT CREATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(670, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 28)
        Label5.TabIndex = 15
        Label5.Text = "Last Name :"
        ' 
        ' LastNameTB
        ' 
        LastNameTB.BackColor = SystemColors.Control
        LastNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LastNameTB.Location = New Point(669, 103)
        LastNameTB.Name = "LastNameTB"
        LastNameTB.RightToLeft = RightToLeft.No
        LastNameTB.Size = New Size(185, 34)
        LastNameTB.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(455, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 28)
        Label6.TabIndex = 17
        Label6.Text = "Email Address :"
        ' 
        ' EmailAddressTB
        ' 
        EmailAddressTB.BackColor = SystemColors.Control
        EmailAddressTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailAddressTB.Location = New Point(454, 180)
        EmailAddressTB.Name = "EmailAddressTB"
        EmailAddressTB.RightToLeft = RightToLeft.No
        EmailAddressTB.Size = New Size(400, 34)
        EmailAddressTB.TabIndex = 18
        ' 
        ' ExitBTN
        ' 
        ExitBTN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ExitBTN.BackColor = Color.Firebrick
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Silver
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.Font = New Font("Manrope ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBTN.ForeColor = SystemColors.ControlLight
        ExitBTN.Location = New Point(859, 0)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(32, 29)
        ExitBTN.TabIndex = 19
        ExitBTN.Text = "X"
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(669, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 28)
        Label7.TabIndex = 22
        Label7.Text = "Account Type :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(455, 340)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 28)
        Label8.TabIndex = 20
        Label8.Text = "Username :"
        ' 
        ' UsernameTB
        ' 
        UsernameTB.BackColor = SystemColors.Control
        UsernameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameTB.Location = New Point(454, 374)
        UsernameTB.Name = "UsernameTB"
        UsernameTB.RightToLeft = RightToLeft.No
        UsernameTB.Size = New Size(185, 34)
        UsernameTB.TabIndex = 21
        ' 
        ' AccountTypeCB
        ' 
        AccountTypeCB.BackColor = SystemColors.Control
        AccountTypeCB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AccountTypeCB.FormattingEnabled = True
        AccountTypeCB.Location = New Point(670, 372)
        AccountTypeCB.Name = "AccountTypeCB"
        AccountTypeCB.Size = New Size(184, 36)
        AccountTypeCB.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(669, 417)
        Label9.Name = "Label9"
        Label9.Size = New Size(187, 28)
        Label9.TabIndex = 34
        Label9.Text = "Confirm Password :"
        ' 
        ' ConfirmPWTB
        ' 
        ConfirmPWTB.BackColor = SystemColors.Control
        ConfirmPWTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ConfirmPWTB.Location = New Point(669, 453)
        ConfirmPWTB.Name = "ConfirmPWTB"
        ConfirmPWTB.RightToLeft = RightToLeft.No
        ConfirmPWTB.Size = New Size(185, 34)
        ConfirmPWTB.TabIndex = 35
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(455, 418)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 28)
        Label10.TabIndex = 32
        Label10.Text = "Password :"
        ' 
        ' PasswordTB
        ' 
        PasswordTB.BackColor = SystemColors.Control
        PasswordTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTB.Location = New Point(454, 453)
        PasswordTB.Name = "PasswordTB"
        PasswordTB.RightToLeft = RightToLeft.No
        PasswordTB.Size = New Size(185, 34)
        PasswordTB.TabIndex = 33
        ' 
        ' CreateBTN
        ' 
        CreateBTN.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(97))
        CreateBTN.FlatAppearance.BorderSize = 0
        CreateBTN.FlatStyle = FlatStyle.Flat
        CreateBTN.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CreateBTN.ForeColor = SystemColors.ControlLight
        CreateBTN.Location = New Point(454, 510)
        CreateBTN.Name = "CreateBTN"
        CreateBTN.Size = New Size(400, 47)
        CreateBTN.TabIndex = 36
        CreateBTN.Text = "CREATE"
        CreateBTN.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(455, 233)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 28)
        Label11.TabIndex = 37
        Label11.Text = "Gender :"
        ' 
        ' GenderTB
        ' 
        GenderTB.BackColor = SystemColors.Control
        GenderTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GenderTB.Location = New Point(455, 267)
        GenderTB.Name = "GenderTB"
        GenderTB.RightToLeft = RightToLeft.No
        GenderTB.Size = New Size(185, 34)
        GenderTB.TabIndex = 38
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.Control
        Label12.Location = New Point(670, 232)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 28)
        Label12.TabIndex = 39
        Label12.Text = "Age :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(455, 325)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 3)
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' AgeNUD
        ' 
        AgeNUD.BackColor = SystemColors.Control
        AgeNUD.Font = New Font("Segoe UI", 12F)
        AgeNUD.Location = New Point(669, 266)
        AgeNUD.Margin = New Padding(4)
        AgeNUD.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        AgeNUD.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        AgeNUD.Name = "AgeNUD"
        AgeNUD.Size = New Size(184, 34)
        AgeNUD.TabIndex = 42
        AgeNUD.Value = New Decimal(New Integer() {18, 0, 0, 0})
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(458, 48)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(248, 3)
        PictureBox3.TabIndex = 44
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(455, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 40)
        Label1.TabIndex = 43
        Label1.Text = "Create An Account"
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
        Label2.TabIndex = 47
        Label2.Text = "Colegio De Montalban"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        Label13.Location = New Point(90, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(298, 31)
        Label13.TabIndex = 46
        Label13.Text = "BARANGAY E-VOTING SYSTEM"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.montalbanlogo
        PictureBox4.Location = New Point(12, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(72, 72)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 45
        PictureBox4.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(34, 233)
        Label14.Name = "Label14"
        Label14.Size = New Size(320, 100)
        Label14.TabIndex = 48
        Label14.Text = "Complete all fields to create your account. Ensure all information is entered correctly."
        ' 
        ' AccountCreation
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources._1917195_plain
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(890, 583)
        Controls.Add(Label14)
        Controls.Add(Label2)
        Controls.Add(Label13)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(GenderTB)
        Controls.Add(CreateBTN)
        Controls.Add(Label9)
        Controls.Add(ConfirmPWTB)
        Controls.Add(Label10)
        Controls.Add(PasswordTB)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(UsernameTB)
        Controls.Add(ExitBTN)
        Controls.Add(Label6)
        Controls.Add(EmailAddressTB)
        Controls.Add(Label5)
        Controls.Add(LastNameTB)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(FirstNameTB)
        Controls.Add(AccountTypeCB)
        Controls.Add(AgeNUD)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AccountCreation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "z"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(AgeNUD, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FirstNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LastNameTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmailAddressTB As TextBox
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents AccountTypeCB As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ConfirmPWTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents CreateBTN As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GenderTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AgeNUD As NumericUpDown
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label14 As Label
End Class
