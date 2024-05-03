<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        components = New ComponentModel.Container()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LastNameTB = New TextBox()
        MiddleNameTB = New TextBox()
        FirstNameTB = New TextBox()
        BarangayTB = New TextBox()
        MunicipalityCityTB = New TextBox()
        StateProvinceTB = New TextBox()
        HouseNoStreetTB = New TextBox()
        PhoneNumberTB = New TextBox()
        EmailAddressTB = New TextBox()
        SubmitBTN = New Button()
        ClearBTN = New Button()
        Label8 = New Label()
        Label11 = New Label()
        FileName = New TextBox()
        SelectID = New Button()
        QRImage = New PictureBox()
        VerifyBTN = New Button()
        ProgressBar1 = New ProgressBar()
        VerificationResultTB = New TextBox()
        DateOfBirth = New TextBox()
        SexTB = New TextBox()
        PlaceOfBirth = New TextBox()
        Label12 = New Label()
        PhilSysCN = New TextBox()
        Label13 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        VerifyCheck = New PictureBox()
        Label15 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        ExitBTN = New Button()
        Label14 = New Label()
        Label16 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        CType(QRImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerifyCheck, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(558, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 36)
        Label2.TabIndex = 1
        Label2.Text = "Full Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(558, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 36)
        Label3.TabIndex = 2
        Label3.Text = "Date of Birth :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(558, 540)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 36)
        Label4.TabIndex = 3
        Label4.Text = "* Residential Address :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(558, 669)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 36)
        Label5.TabIndex = 4
        Label5.Text = "* Contact Information :"
        ' 
        ' LastNameTB
        ' 
        LastNameTB.BackColor = SystemColors.ControlLight
        LastNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LastNameTB.Location = New Point(558, 286)
        LastNameTB.Name = "LastNameTB"
        LastNameTB.PlaceholderText = " Last Name"
        LastNameTB.ReadOnly = True
        LastNameTB.RightToLeft = RightToLeft.No
        LastNameTB.Size = New Size(185, 34)
        LastNameTB.TabIndex = 10
        ' 
        ' MiddleNameTB
        ' 
        MiddleNameTB.BackColor = SystemColors.ControlLight
        MiddleNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MiddleNameTB.Location = New Point(940, 286)
        MiddleNameTB.Name = "MiddleNameTB"
        MiddleNameTB.PlaceholderText = " Middle Name"
        MiddleNameTB.ReadOnly = True
        MiddleNameTB.Size = New Size(185, 34)
        MiddleNameTB.TabIndex = 11
        ' 
        ' FirstNameTB
        ' 
        FirstNameTB.BackColor = SystemColors.ControlLight
        FirstNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstNameTB.Location = New Point(749, 286)
        FirstNameTB.Name = "FirstNameTB"
        FirstNameTB.PlaceholderText = " First Name"
        FirstNameTB.ReadOnly = True
        FirstNameTB.Size = New Size(185, 34)
        FirstNameTB.TabIndex = 12
        ' 
        ' BarangayTB
        ' 
        BarangayTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BarangayTB.Location = New Point(931, 619)
        BarangayTB.Name = "BarangayTB"
        BarangayTB.PlaceholderText = " Barangay"
        BarangayTB.Size = New Size(185, 34)
        BarangayTB.TabIndex = 14
        ' 
        ' MunicipalityCityTB
        ' 
        MunicipalityCityTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MunicipalityCityTB.Location = New Point(558, 619)
        MunicipalityCityTB.Name = "MunicipalityCityTB"
        MunicipalityCityTB.PlaceholderText = " Municipality/City"
        MunicipalityCityTB.Size = New Size(345, 34)
        MunicipalityCityTB.TabIndex = 15
        ' 
        ' StateProvinceTB
        ' 
        StateProvinceTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StateProvinceTB.Location = New Point(931, 579)
        StateProvinceTB.Name = "StateProvinceTB"
        StateProvinceTB.PlaceholderText = " State/Province"
        StateProvinceTB.Size = New Size(185, 34)
        StateProvinceTB.TabIndex = 16
        ' 
        ' HouseNoStreetTB
        ' 
        HouseNoStreetTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HouseNoStreetTB.Location = New Point(558, 579)
        HouseNoStreetTB.Name = "HouseNoStreetTB"
        HouseNoStreetTB.PlaceholderText = " House No. / Street"
        HouseNoStreetTB.Size = New Size(345, 34)
        HouseNoStreetTB.TabIndex = 17
        ' 
        ' PhoneNumberTB
        ' 
        PhoneNumberTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PhoneNumberTB.Location = New Point(558, 708)
        PhoneNumberTB.Name = "PhoneNumberTB"
        PhoneNumberTB.PlaceholderText = " Phone Number"
        PhoneNumberTB.Size = New Size(205, 34)
        PhoneNumberTB.TabIndex = 18
        ' 
        ' EmailAddressTB
        ' 
        EmailAddressTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailAddressTB.Location = New Point(769, 708)
        EmailAddressTB.Name = "EmailAddressTB"
        EmailAddressTB.PlaceholderText = " Email Address"
        EmailAddressTB.Size = New Size(346, 34)
        EmailAddressTB.TabIndex = 19
        ' 
        ' SubmitBTN
        ' 
        SubmitBTN.BackColor = Color.SeaGreen
        SubmitBTN.FlatAppearance.BorderSize = 0
        SubmitBTN.FlatStyle = FlatStyle.Flat
        SubmitBTN.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubmitBTN.ForeColor = SystemColors.ControlLight
        SubmitBTN.Location = New Point(559, 782)
        SubmitBTN.Name = "SubmitBTN"
        SubmitBTN.Size = New Size(344, 47)
        SubmitBTN.TabIndex = 23
        SubmitBTN.Text = "SUBMIT"
        SubmitBTN.UseVisualStyleBackColor = False
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.DimGray
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = SystemColors.ControlLight
        ClearBTN.Location = New Point(932, 782)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(184, 47)
        ClearBTN.TabIndex = 24
        ClearBTN.Text = "CLEAR"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(558, 427)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 36)
        Label8.TabIndex = 26
        Label8.Text = "Sex :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(89, 157)
        Label11.Name = "Label11"
        Label11.Size = New Size(222, 36)
        Label11.TabIndex = 35
        Label11.Text = "PhilSys Verification"
        ' 
        ' FileName
        ' 
        FileName.BackColor = SystemColors.Window
        FileName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FileName.Location = New Point(60, 201)
        FileName.Name = "FileName"
        FileName.ReadOnly = True
        FileName.RightToLeft = RightToLeft.No
        FileName.Size = New Size(183, 34)
        FileName.TabIndex = 36
        ' 
        ' SelectID
        ' 
        SelectID.BackColor = Color.FromArgb(CByte(31), CByte(67), CByte(128))
        SelectID.Cursor = Cursors.Hand
        SelectID.FlatStyle = FlatStyle.Flat
        SelectID.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SelectID.ForeColor = SystemColors.Control
        SelectID.Location = New Point(251, 201)
        SelectID.Name = "SelectID"
        SelectID.Size = New Size(96, 34)
        SelectID.TabIndex = 37
        SelectID.Text = "Select ID"
        SelectID.UseVisualStyleBackColor = False
        ' 
        ' QRImage
        ' 
        QRImage.BackColor = Color.FromArgb(CByte(31), CByte(67), CByte(128))
        QRImage.Image = My.Resources.Resources.Screenshot_2024_04_09_134609
        QRImage.Location = New Point(58, 243)
        QRImage.Name = "QRImage"
        QRImage.Size = New Size(289, 250)
        QRImage.SizeMode = PictureBoxSizeMode.StretchImage
        QRImage.TabIndex = 38
        QRImage.TabStop = False
        ' 
        ' VerifyBTN
        ' 
        VerifyBTN.BackColor = Color.FromArgb(CByte(31), CByte(67), CByte(128))
        VerifyBTN.FlatStyle = FlatStyle.Flat
        VerifyBTN.Font = New Font("Roboto Condensed", 12F)
        VerifyBTN.ForeColor = SystemColors.Control
        VerifyBTN.Location = New Point(58, 500)
        VerifyBTN.Name = "VerifyBTN"
        VerifyBTN.Size = New Size(289, 34)
        VerifyBTN.TabIndex = 39
        VerifyBTN.Text = "Verify"
        VerifyBTN.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.Window
        ProgressBar1.Location = New Point(60, 806)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(289, 23)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 40
        ' 
        ' VerificationResultTB
        ' 
        VerificationResultTB.BackColor = SystemColors.Window
        VerificationResultTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        VerificationResultTB.Location = New Point(60, 548)
        VerificationResultTB.Multiline = True
        VerificationResultTB.Name = "VerificationResultTB"
        VerificationResultTB.ReadOnly = True
        VerificationResultTB.RightToLeft = RightToLeft.No
        VerificationResultTB.ScrollBars = ScrollBars.Horizontal
        VerificationResultTB.Size = New Size(289, 250)
        VerificationResultTB.TabIndex = 41
        VerificationResultTB.TextAlign = HorizontalAlignment.Center
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.BackColor = SystemColors.ControlLight
        DateOfBirth.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateOfBirth.Location = New Point(558, 375)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.ReadOnly = True
        DateOfBirth.RightToLeft = RightToLeft.No
        DateOfBirth.Size = New Size(185, 34)
        DateOfBirth.TabIndex = 42
        ' 
        ' SexTB
        ' 
        SexTB.BackColor = SystemColors.ControlLight
        SexTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SexTB.Location = New Point(558, 466)
        SexTB.Name = "SexTB"
        SexTB.ReadOnly = True
        SexTB.RightToLeft = RightToLeft.No
        SexTB.Size = New Size(185, 34)
        SexTB.TabIndex = 43
        ' 
        ' PlaceOfBirth
        ' 
        PlaceOfBirth.BackColor = SystemColors.ControlLight
        PlaceOfBirth.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PlaceOfBirth.Location = New Point(749, 375)
        PlaceOfBirth.Name = "PlaceOfBirth"
        PlaceOfBirth.ReadOnly = True
        PlaceOfBirth.RightToLeft = RightToLeft.No
        PlaceOfBirth.Size = New Size(376, 34)
        PlaceOfBirth.TabIndex = 45
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.Control
        Label12.Location = New Point(750, 336)
        Label12.Name = "Label12"
        Label12.Size = New Size(153, 36)
        Label12.TabIndex = 44
        Label12.Text = "Place of Birth :"
        ' 
        ' PhilSysCN
        ' 
        PhilSysCN.BackColor = SystemColors.ControlLight
        PhilSysCN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PhilSysCN.Location = New Point(750, 466)
        PhilSysCN.Name = "PhilSysCN"
        PhilSysCN.ReadOnly = True
        PhilSysCN.RightToLeft = RightToLeft.No
        PhilSysCN.Size = New Size(372, 34)
        PhilSysCN.TabIndex = 47
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.Control
        Label13.Location = New Point(750, 427)
        Label13.Name = "Label13"
        Label13.Size = New Size(292, 36)
        Label13.TabIndex = 46
        Label13.Text = "PhilSys Card Number (PCN):"
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' VerifyCheck
        ' 
        VerifyCheck.BackColor = SystemColors.Window
        VerifyCheck.Image = My.Resources.Resources.check
        VerifyCheck.Location = New Point(155, 693)
        VerifyCheck.Name = "VerifyCheck"
        VerifyCheck.Size = New Size(96, 83)
        VerifyCheck.SizeMode = PictureBoxSizeMode.Zoom
        VerifyCheck.TabIndex = 48
        VerifyCheck.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Roboto Condensed", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.Control
        Label15.Location = New Point(560, 177)
        Label15.Name = "Label15"
        Label15.Size = New Size(419, 59)
        Label15.TabIndex = 48
        Label15.Text = "Once your national ID is verified, these fields will automatically fill."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(28, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 50)
        Label1.TabIndex = 0
        Label1.Text = "VOTER'S REGISTRATION"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Black
        PictureBox2.Location = New Point(12, 102)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(10, 50)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Firebrick
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Silver
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.Font = New Font("Manrope ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBTN.ForeColor = SystemColors.ControlLight
        ExitBTN.Location = New Point(1096, 12)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(32, 29)
        ExitBTN.TabIndex = 2
        ExitBTN.Text = "X"
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Poppins", 10.8F)
        Label14.ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        Label14.Location = New Point(90, 53)
        Label14.Name = "Label14"
        Label14.Size = New Size(216, 31)
        Label14.TabIndex = 52
        Label14.Text = "Colegio De Montalban"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(18), CByte(75), CByte(219))
        Label16.Location = New Point(90, 19)
        Label16.Name = "Label16"
        Label16.Size = New Size(298, 31)
        Label16.TabIndex = 51
        Label16.Text = "BARANGAY E-VOTING SYSTEM"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.montalbanlogo
        PictureBox4.Location = New Point(12, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(72, 72)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 50
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(558, 525)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(564, 3)
        PictureBox3.TabIndex = 53
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(558, 759)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(564, 3)
        PictureBox1.TabIndex = 54
        PictureBox1.TabStop = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ControlLight
        BackgroundImage = My.Resources.Resources._1917195_plain
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1140, 841)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(Label15)
        Controls.Add(Label2)
        Controls.Add(Label14)
        Controls.Add(Label3)
        Controls.Add(Label16)
        Controls.Add(LastNameTB)
        Controls.Add(PictureBox4)
        Controls.Add(PhilSysCN)
        Controls.Add(PictureBox2)
        Controls.Add(MiddleNameTB)
        Controls.Add(ExitBTN)
        Controls.Add(Label13)
        Controls.Add(Label1)
        Controls.Add(FirstNameTB)
        Controls.Add(PlaceOfBirth)
        Controls.Add(VerifyCheck)
        Controls.Add(Label8)
        Controls.Add(Label12)
        Controls.Add(VerificationResultTB)
        Controls.Add(DateOfBirth)
        Controls.Add(VerifyBTN)
        Controls.Add(SexTB)
        Controls.Add(QRImage)
        Controls.Add(SelectID)
        Controls.Add(FileName)
        Controls.Add(Label11)
        Controls.Add(ClearBTN)
        Controls.Add(SubmitBTN)
        Controls.Add(EmailAddressTB)
        Controls.Add(PhoneNumberTB)
        Controls.Add(HouseNoStreetTB)
        Controls.Add(StateProvinceTB)
        Controls.Add(MunicipalityCityTB)
        Controls.Add(BarangayTB)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ProgressBar1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegistrationForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Voter's Registration"
        CType(QRImage, ComponentModel.ISupportInitialize).EndInit()
        CType(VerifyCheck, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LastNameTB As TextBox
    Friend WithEvents MiddleNameTB As TextBox
    Friend WithEvents FirstNameTB As TextBox
    Friend WithEvents BarangayTB As TextBox
    Friend WithEvents MunicipalityCityTB As TextBox
    Friend WithEvents StateProvinceTB As TextBox
    Friend WithEvents HouseNoStreetTB As TextBox
    Friend WithEvents PhoneNumberTB As TextBox
    Friend WithEvents EmailAddressTB As TextBox
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents ClearBTN As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FileName As TextBox
    Friend WithEvents SelectID As Button
    Friend WithEvents QRImage As PictureBox
    Friend WithEvents VerifyBTN As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents VerificationResultTB As TextBox
    Friend WithEvents DateOfBirth As TextBox
    Friend WithEvents SexTB As TextBox
    Friend WithEvents PlaceOfBirth As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PhilSysCN As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents VerifyCheck As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
