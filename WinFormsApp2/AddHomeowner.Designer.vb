<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddHomeowner
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
        Panel5 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        THBox = New TextBox()
        Label6 = New Label()
        ImageFileName = New TextBox()
        ImageBox = New PictureBox()
        DeleteImage = New Button()
        SelectImage = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        HomeownerDOB = New DateTimePicker()
        HomeownerAge = New TextBox()
        ClearBTN = New Button()
        SubmitBTN = New Button()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        HomeownerLN = New TextBox()
        HomeownerMN = New TextBox()
        HomeownerFN = New TextBox()
        HomeownerGender = New TextBox()
        HomeownerEA = New TextBox()
        HomeownerPN = New TextBox()
        HomeownerFA = New TextBox()
        Label2 = New Label()
        Panel2.SuspendLayout()
        CType(ImageBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(16, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(14, 40)
        Panel5.TabIndex = 113
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 40)
        Label1.TabIndex = 96
        Label1.Text = "ADD HOMEOWNER"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(THBox)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(358, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(220, 148)
        Panel2.TabIndex = 119
        ' 
        ' THBox
        ' 
        THBox.BorderStyle = BorderStyle.None
        THBox.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        THBox.Location = New Point(48, 59)
        THBox.Name = "THBox"
        THBox.ReadOnly = True
        THBox.Size = New Size(155, 41)
        THBox.TabIndex = 73
        THBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 31)
        Label6.TabIndex = 72
        Label6.Text = "Total Homeowners:"
        ' 
        ' ImageFileName
        ' 
        ImageFileName.BackColor = SystemColors.Window
        ImageFileName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ImageFileName.Location = New Point(172, 93)
        ImageFileName.Name = "ImageFileName"
        ImageFileName.PlaceholderText = "(Optional)"
        ImageFileName.ReadOnly = True
        ImageFileName.Size = New Size(180, 27)
        ImageFileName.TabIndex = 118
        ImageFileName.TextAlign = HorizontalAlignment.Center
        ' 
        ' ImageBox
        ' 
        ImageBox.BackColor = Color.Transparent
        ImageBox.BackgroundImage = My.Resources.Resources.user__1_
        ImageBox.BackgroundImageLayout = ImageLayout.Stretch
        ImageBox.Location = New Point(11, 57)
        ImageBox.Name = "ImageBox"
        ImageBox.Size = New Size(154, 148)
        ImageBox.SizeMode = PictureBoxSizeMode.StretchImage
        ImageBox.TabIndex = 117
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
        DeleteImage.Location = New Point(289, 170)
        DeleteImage.Name = "DeleteImage"
        DeleteImage.Size = New Size(63, 35)
        DeleteImage.TabIndex = 116
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
        SelectImage.Location = New Point(171, 170)
        SelectImage.Name = "SelectImage"
        SelectImage.Size = New Size(111, 35)
        SelectImage.TabIndex = 115
        SelectImage.Text = "Select Image"
        SelectImage.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(172, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 31)
        Label5.TabIndex = 114
        Label5.Text = "Homeowner Photo"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(17, 597)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(567, 3)
        PictureBox1.TabIndex = 112
        PictureBox1.TabStop = False
        ' 
        ' HomeownerDOB
        ' 
        HomeownerDOB.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerDOB.Cursor = Cursors.Hand
        HomeownerDOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerDOB.Format = DateTimePickerFormat.Short
        HomeownerDOB.Location = New Point(393, 320)
        HomeownerDOB.Name = "HomeownerDOB"
        HomeownerDOB.Size = New Size(185, 34)
        HomeownerDOB.TabIndex = 111
        ' 
        ' HomeownerAge
        ' 
        HomeownerAge.BackColor = SystemColors.Window
        HomeownerAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerAge.Location = New Point(202, 320)
        HomeownerAge.Name = "HomeownerAge"
        HomeownerAge.PlaceholderText = " Age"
        HomeownerAge.RightToLeft = RightToLeft.No
        HomeownerAge.Size = New Size(185, 34)
        HomeownerAge.TabIndex = 110
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.DimGray
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = SystemColors.ControlLight
        ClearBTN.Location = New Point(489, 654)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(89, 35)
        ClearBTN.TabIndex = 109
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
        SubmitBTN.Location = New Point(14, 654)
        SubmitBTN.Name = "SubmitBTN"
        SubmitBTN.Size = New Size(111, 35)
        SubmitBTN.TabIndex = 108
        SubmitBTN.Text = "SUBMIT"
        SubmitBTN.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(11, 217)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(567, 3)
        PictureBox3.TabIndex = 107
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label4.Location = New Point(14, 496)
        Label4.Name = "Label4"
        Label4.Size = New Size(296, 40)
        Label4.TabIndex = 106
        Label4.Text = "CONTACT INFORMATION :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label3.Location = New Point(11, 371)
        Label3.Name = "Label3"
        Label3.Size = New Size(265, 40)
        Label3.TabIndex = 105
        Label3.Text = "RESIDENTIAL ADDRESS :"
        ' 
        ' HomeownerLN
        ' 
        HomeownerLN.BackColor = SystemColors.Window
        HomeownerLN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerLN.Location = New Point(393, 269)
        HomeownerLN.Name = "HomeownerLN"
        HomeownerLN.PlaceholderText = " Last Name"
        HomeownerLN.RightToLeft = RightToLeft.No
        HomeownerLN.Size = New Size(185, 34)
        HomeownerLN.TabIndex = 98
        ' 
        ' HomeownerMN
        ' 
        HomeownerMN.BackColor = SystemColors.Window
        HomeownerMN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerMN.Location = New Point(202, 269)
        HomeownerMN.Name = "HomeownerMN"
        HomeownerMN.PlaceholderText = " Middle Name"
        HomeownerMN.Size = New Size(185, 34)
        HomeownerMN.TabIndex = 99
        ' 
        ' HomeownerFN
        ' 
        HomeownerFN.BackColor = SystemColors.Window
        HomeownerFN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerFN.Location = New Point(11, 269)
        HomeownerFN.Name = "HomeownerFN"
        HomeownerFN.PlaceholderText = " First Name"
        HomeownerFN.Size = New Size(185, 34)
        HomeownerFN.TabIndex = 100
        ' 
        ' HomeownerGender
        ' 
        HomeownerGender.BackColor = SystemColors.Window
        HomeownerGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerGender.Location = New Point(11, 320)
        HomeownerGender.Name = "HomeownerGender"
        HomeownerGender.PlaceholderText = " Gender"
        HomeownerGender.RightToLeft = RightToLeft.No
        HomeownerGender.Size = New Size(185, 34)
        HomeownerGender.TabIndex = 104
        ' 
        ' HomeownerEA
        ' 
        HomeownerEA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerEA.Location = New Point(225, 541)
        HomeownerEA.Name = "HomeownerEA"
        HomeownerEA.PlaceholderText = " Email Address"
        HomeownerEA.Size = New Size(353, 34)
        HomeownerEA.TabIndex = 103
        ' 
        ' HomeownerPN
        ' 
        HomeownerPN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerPN.Location = New Point(14, 541)
        HomeownerPN.Name = "HomeownerPN"
        HomeownerPN.PlaceholderText = " Phone Number"
        HomeownerPN.Size = New Size(205, 34)
        HomeownerPN.TabIndex = 102
        ' 
        ' HomeownerFA
        ' 
        HomeownerFA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerFA.Location = New Point(11, 416)
        HomeownerFA.Multiline = True
        HomeownerFA.Name = "HomeownerFA"
        HomeownerFA.PlaceholderText = " Full Address (Block, Lot, Phase, etc)"
        HomeownerFA.Size = New Size(564, 66)
        HomeownerFA.TabIndex = 101
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label2.Location = New Point(11, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(298, 40)
        Label2.TabIndex = 97
        Label2.Text = "PERSONAL INFORMATION :"
        ' 
        ' AddHomeowner
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(964, 795)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(ImageFileName)
        Controls.Add(ImageBox)
        Controls.Add(DeleteImage)
        Controls.Add(SelectImage)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(HomeownerDOB)
        Controls.Add(HomeownerAge)
        Controls.Add(ClearBTN)
        Controls.Add(SubmitBTN)
        Controls.Add(PictureBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(HomeownerLN)
        Controls.Add(HomeownerMN)
        Controls.Add(HomeownerFN)
        Controls.Add(HomeownerGender)
        Controls.Add(HomeownerEA)
        Controls.Add(HomeownerPN)
        Controls.Add(HomeownerFA)
        Controls.Add(Label2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AddHomeowner"
        Text = "AddHomeowner"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ImageBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents THBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ImageFileName As TextBox
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents DeleteImage As Button
    Friend WithEvents SelectImage As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeownerDOB As DateTimePicker
    Friend WithEvents HomeownerAge As TextBox
    Friend WithEvents ClearBTN As Button
    Friend WithEvents SubmitBTN As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HomeownerLN As TextBox
    Friend WithEvents HomeownerMN As TextBox
    Friend WithEvents HomeownerFN As TextBox
    Friend WithEvents HomeownerGender As TextBox
    Friend WithEvents HomeownerEA As TextBox
    Friend WithEvents HomeownerPN As TextBox
    Friend WithEvents HomeownerFA As TextBox
    Friend WithEvents Label2 As Label
End Class
