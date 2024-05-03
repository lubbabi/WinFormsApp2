<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCandidate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCandidate))
        Panel1 = New Panel()
        Label9 = New Label()
        CandidatePosition = New ComboBox()
        Label8 = New Label()
        CategoryCB = New ComboBox()
        Label7 = New Label()
        Panel2 = New Panel()
        TABox = New TextBox()
        Label6 = New Label()
        ImageFileName = New TextBox()
        ImageBox = New PictureBox()
        DeleteImage = New Button()
        SelectImage = New Button()
        Label5 = New Label()
        Panel5 = New Panel()
        PictureBox1 = New PictureBox()
        DateOfBirth = New DateTimePicker()
        CandidateCS = New TextBox()
        ClearBTN = New Button()
        SubmitBTN = New Button()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        CandidateLN = New TextBox()
        CandidateMN = New TextBox()
        CandidateFN = New TextBox()
        CandidateGender = New TextBox()
        CandidateEA = New TextBox()
        CandidatePN = New TextBox()
        CandidateFA = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ImageBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(CandidatePosition)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(CategoryCB)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(ImageFileName)
        Panel1.Controls.Add(ImageBox)
        Panel1.Controls.Add(DeleteImage)
        Panel1.Controls.Add(SelectImage)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(DateOfBirth)
        Panel1.Controls.Add(CandidateCS)
        Panel1.Controls.Add(ClearBTN)
        Panel1.Controls.Add(SubmitBTN)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(CandidateLN)
        Panel1.Controls.Add(CandidateMN)
        Panel1.Controls.Add(CandidateFN)
        Panel1.Controls.Add(CandidateGender)
        Panel1.Controls.Add(CandidateEA)
        Panel1.Controls.Add(CandidatePN)
        Panel1.Controls.Add(CandidateFA)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(964, 795)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.BackColor = SystemColors.ActiveCaption
        Label9.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(16, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(567, 158)
        Label9.TabIndex = 0
        Label9.Text = resources.GetString("Label9.Text")
        ' 
        ' CandidatePosition
        ' 
        CandidatePosition.Font = New Font("Segoe UI", 12F)
        CandidatePosition.FormattingEnabled = True
        CandidatePosition.Location = New Point(682, 563)
        CandidatePosition.Name = "CandidatePosition"
        CandidatePosition.Size = New Size(189, 36)
        CandidatePosition.TabIndex = 75
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(688, 521)
        Label8.Name = "Label8"
        Label8.Size = New Size(178, 36)
        Label8.TabIndex = 74
        Label8.Text = "SELECT POSITION"
        ' 
        ' CategoryCB
        ' 
        CategoryCB.Font = New Font("Segoe UI", 12F)
        CategoryCB.FormattingEnabled = True
        CategoryCB.Location = New Point(682, 432)
        CategoryCB.Name = "CategoryCB"
        CategoryCB.Size = New Size(189, 36)
        CategoryCB.TabIndex = 73
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(693, 393)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 36)
        Label7.TabIndex = 72
        Label7.Text = "HOA CATEGORY"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(TABox)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(645, 619)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 125)
        Panel2.TabIndex = 71
        ' 
        ' TABox
        ' 
        TABox.BorderStyle = BorderStyle.None
        TABox.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TABox.Location = New Point(12, 50)
        TABox.Name = "TABox"
        TABox.ReadOnly = True
        TABox.Size = New Size(243, 41)
        TABox.TabIndex = 73
        TABox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(12, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 30)
        Label6.TabIndex = 72
        Label6.Text = "Total Registered Candidate"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ImageFileName
        ' 
        ImageFileName.BackColor = SystemColors.Window
        ImageFileName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ImageFileName.Location = New Point(682, 289)
        ImageFileName.Name = "ImageFileName"
        ImageFileName.ReadOnly = True
        ImageFileName.Size = New Size(189, 27)
        ImageFileName.TabIndex = 70
        ImageFileName.TextAlign = HorizontalAlignment.Center
        ' 
        ' ImageBox
        ' 
        ImageBox.BackColor = Color.Transparent
        ImageBox.BackgroundImage = My.Resources.Resources.user__1_
        ImageBox.BackgroundImageLayout = ImageLayout.Stretch
        ImageBox.Location = New Point(682, 108)
        ImageBox.Name = "ImageBox"
        ImageBox.Size = New Size(189, 172)
        ImageBox.SizeMode = PictureBoxSizeMode.StretchImage
        ImageBox.TabIndex = 69
        ImageBox.TabStop = False
        ' 
        ' DeleteImage
        ' 
        DeleteImage.AutoSize = True
        DeleteImage.BackColor = Color.DimGray
        DeleteImage.FlatAppearance.BorderSize = 0
        DeleteImage.FlatStyle = FlatStyle.Flat
        DeleteImage.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeleteImage.ForeColor = SystemColors.ControlLight
        DeleteImage.Location = New Point(807, 339)
        DeleteImage.Name = "DeleteImage"
        DeleteImage.Size = New Size(63, 35)
        DeleteImage.TabIndex = 68
        DeleteImage.Text = "Delete"
        DeleteImage.UseVisualStyleBackColor = False
        ' 
        ' SelectImage
        ' 
        SelectImage.AutoSize = True
        SelectImage.BackColor = Color.DimGray
        SelectImage.FlatAppearance.BorderSize = 0
        SelectImage.FlatStyle = FlatStyle.Flat
        SelectImage.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SelectImage.ForeColor = SystemColors.ControlLight
        SelectImage.Location = New Point(682, 339)
        SelectImage.Name = "SelectImage"
        SelectImage.Size = New Size(111, 35)
        SelectImage.TabIndex = 67
        SelectImage.Text = "Select Image"
        SelectImage.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(684, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 36)
        Label5.TabIndex = 66
        Label5.Text = "Candidate Photo"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(16, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(14, 40)
        Panel5.TabIndex = 65
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(16, 619)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(567, 3)
        PictureBox1.TabIndex = 64
        PictureBox1.TabStop = False
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateOfBirth.Cursor = Cursors.Hand
        DateOfBirth.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateOfBirth.Format = DateTimePickerFormat.Short
        DateOfBirth.Location = New Point(398, 340)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(185, 34)
        DateOfBirth.TabIndex = 63
        ' 
        ' CandidateCS
        ' 
        CandidateCS.BackColor = SystemColors.Window
        CandidateCS.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateCS.Location = New Point(207, 340)
        CandidateCS.Name = "CandidateCS"
        CandidateCS.PlaceholderText = " Civil Status"
        CandidateCS.RightToLeft = RightToLeft.No
        CandidateCS.Size = New Size(185, 34)
        CandidateCS.TabIndex = 62
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.DimGray
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = SystemColors.ControlLight
        ClearBTN.Location = New Point(395, 666)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(185, 44)
        ClearBTN.TabIndex = 61
        ClearBTN.Text = "Reset"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' SubmitBTN
        ' 
        SubmitBTN.BackColor = Color.SeaGreen
        SubmitBTN.FlatAppearance.BorderSize = 0
        SubmitBTN.FlatStyle = FlatStyle.Flat
        SubmitBTN.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubmitBTN.ForeColor = SystemColors.ControlLight
        SubmitBTN.Location = New Point(16, 666)
        SubmitBTN.Name = "SubmitBTN"
        SubmitBTN.Size = New Size(185, 44)
        SubmitBTN.TabIndex = 60
        SubmitBTN.Text = "DONE"
        SubmitBTN.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(16, 237)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(567, 3)
        PictureBox3.TabIndex = 59
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 12F, FontStyle.Underline)
        Label4.Location = New Point(16, 521)
        Label4.Name = "Label4"
        Label4.Size = New Size(257, 36)
        Label4.TabIndex = 58
        Label4.Text = "CONTACT INFORMATION :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 12F, FontStyle.Underline)
        Label3.Location = New Point(16, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 36)
        Label3.TabIndex = 55
        Label3.Text = "RESIDENTIAL ADDRESS :"
        ' 
        ' CandidateLN
        ' 
        CandidateLN.BackColor = SystemColors.Window
        CandidateLN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateLN.Location = New Point(398, 289)
        CandidateLN.Name = "CandidateLN"
        CandidateLN.PlaceholderText = " Last Name"
        CandidateLN.RightToLeft = RightToLeft.No
        CandidateLN.Size = New Size(185, 34)
        CandidateLN.TabIndex = 46
        ' 
        ' CandidateMN
        ' 
        CandidateMN.BackColor = SystemColors.Window
        CandidateMN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateMN.Location = New Point(207, 289)
        CandidateMN.Name = "CandidateMN"
        CandidateMN.PlaceholderText = " Middle Name"
        CandidateMN.Size = New Size(185, 34)
        CandidateMN.TabIndex = 47
        ' 
        ' CandidateFN
        ' 
        CandidateFN.BackColor = SystemColors.Window
        CandidateFN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateFN.Location = New Point(16, 289)
        CandidateFN.Name = "CandidateFN"
        CandidateFN.PlaceholderText = " First Name"
        CandidateFN.Size = New Size(185, 34)
        CandidateFN.TabIndex = 48
        ' 
        ' CandidateGender
        ' 
        CandidateGender.BackColor = SystemColors.Window
        CandidateGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateGender.Location = New Point(16, 340)
        CandidateGender.Name = "CandidateGender"
        CandidateGender.PlaceholderText = " Gender"
        CandidateGender.RightToLeft = RightToLeft.No
        CandidateGender.Size = New Size(185, 34)
        CandidateGender.TabIndex = 53
        ' 
        ' CandidateEA
        ' 
        CandidateEA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateEA.Location = New Point(207, 565)
        CandidateEA.Name = "CandidateEA"
        CandidateEA.PlaceholderText = " Email Address"
        CandidateEA.Size = New Size(373, 34)
        CandidateEA.TabIndex = 51
        ' 
        ' CandidatePN
        ' 
        CandidatePN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidatePN.Location = New Point(16, 565)
        CandidatePN.Name = "CandidatePN"
        CandidatePN.PlaceholderText = " Phone Number"
        CandidatePN.Size = New Size(185, 34)
        CandidatePN.TabIndex = 50
        ' 
        ' CandidateFA
        ' 
        CandidateFA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateFA.Location = New Point(16, 435)
        CandidateFA.Multiline = True
        CandidateFA.Name = "CandidateFA"
        CandidateFA.PlaceholderText = " Full Address (Block, Lot, Phase, etc)"
        CandidateFA.Size = New Size(564, 66)
        CandidateFA.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 12F, FontStyle.Underline)
        Label2.Location = New Point(13, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 36)
        Label2.TabIndex = 7
        Label2.Text = "PERSONAL INFORMATION :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 40)
        Label1.TabIndex = 3
        Label1.Text = "ADD CANDIDATE TO ELECTION"
        ' 
        ' AddCandidate
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(964, 795)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AddCandidate"
        Text = "AddCandidate"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ImageBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CandidateLN As TextBox
    Friend WithEvents CandidateMN As TextBox
    Friend WithEvents CandidateFN As TextBox
    Friend WithEvents CandidateGender As TextBox
    Friend WithEvents CandidateEA As TextBox
    Friend WithEvents CandidatePN As TextBox
    Friend WithEvents CandidateFA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ClearBTN As Button
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents CandidateCS As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents DeleteImage As Button
    Friend WithEvents SelectImage As Button
    Friend WithEvents ImageFileName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TABox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CategoryCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CandidatePosition As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
