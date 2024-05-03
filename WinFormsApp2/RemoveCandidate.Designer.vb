<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveCandidate
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
        Panel1 = New Panel()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CandidateLN = New TextBox()
        Panel3 = New Panel()
        CStatus = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        CCount = New TextBox()
        CandidateMN = New TextBox()
        Panel5 = New Panel()
        CandidateFN = New TextBox()
        Label1 = New Label()
        CandidateEA = New TextBox()
        Panel2 = New Panel()
        CandidatePN = New TextBox()
        RemoveCABTN = New Button()
        PictureBox3 = New PictureBox()
        RemoveCID = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(CandidateLN)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(CandidateMN)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(CandidateFN)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CandidateEA)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(CandidatePN)
        Panel1.Controls.Add(RemoveCABTN)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(RemoveCID)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(964, 795)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(278, 409)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 23)
        Label5.TabIndex = 128
        Label5.Text = "(AUTOFILL)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(19, 568)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(640, 3)
        PictureBox1.TabIndex = 127
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label4.Location = New Point(52, 402)
        Label4.Name = "Label4"
        Label4.Size = New Size(231, 40)
        Label4.TabIndex = 126
        Label4.Text = "CANDIDATE DETAIL :"
        ' 
        ' CandidateLN
        ' 
        CandidateLN.BackColor = SystemColors.Window
        CandidateLN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateLN.Location = New Point(434, 448)
        CandidateLN.Name = "CandidateLN"
        CandidateLN.PlaceholderText = " Last Name"
        CandidateLN.ReadOnly = True
        CandidateLN.RightToLeft = RightToLeft.No
        CandidateLN.Size = New Size(185, 34)
        CandidateLN.TabIndex = 121
        CandidateLN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        Panel3.Controls.Add(CStatus)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(363, 64)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(299, 148)
        Panel3.TabIndex = 120
        ' 
        ' CStatus
        ' 
        CStatus.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        CStatus.BorderStyle = BorderStyle.None
        CStatus.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CStatus.Location = New Point(55, 65)
        CStatus.Name = "CStatus"
        CStatus.ReadOnly = True
        CStatus.Size = New Size(188, 41)
        CStatus.TabIndex = 73
        CStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 31)
        Label3.TabIndex = 72
        Label3.Text = "Candidate Status :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 31)
        Label6.TabIndex = 72
        Label6.Text = "Total Candidate:"
        ' 
        ' CCount
        ' 
        CCount.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        CCount.BorderStyle = BorderStyle.None
        CCount.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CCount.Location = New Point(52, 65)
        CCount.Name = "CCount"
        CCount.ReadOnly = True
        CCount.Size = New Size(188, 41)
        CCount.TabIndex = 73
        CCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' CandidateMN
        ' 
        CandidateMN.BackColor = SystemColors.Window
        CandidateMN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateMN.Location = New Point(243, 448)
        CandidateMN.Name = "CandidateMN"
        CandidateMN.PlaceholderText = " Middle Name"
        CandidateMN.ReadOnly = True
        CandidateMN.Size = New Size(185, 34)
        CandidateMN.TabIndex = 122
        CandidateMN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(16, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(14, 40)
        Panel5.TabIndex = 118
        ' 
        ' CandidateFN
        ' 
        CandidateFN.BackColor = SystemColors.Window
        CandidateFN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateFN.Location = New Point(52, 448)
        CandidateFN.Name = "CandidateFN"
        CandidateFN.PlaceholderText = " First Name"
        CandidateFN.ReadOnly = True
        CandidateFN.Size = New Size(185, 34)
        CandidateFN.TabIndex = 123
        CandidateFN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 40)
        Label1.TabIndex = 113
        Label1.Text = "REMOVE CANDIDATE"
        ' 
        ' CandidateEA
        ' 
        CandidateEA.BackColor = SystemColors.Window
        CandidateEA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidateEA.Location = New Point(243, 502)
        CandidateEA.Name = "CandidateEA"
        CandidateEA.PlaceholderText = " Email Address"
        CandidateEA.ReadOnly = True
        CandidateEA.Size = New Size(376, 34)
        CandidateEA.TabIndex = 125
        CandidateEA.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(CCount)
        Panel2.Location = New Point(16, 64)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(299, 148)
        Panel2.TabIndex = 119
        ' 
        ' CandidatePN
        ' 
        CandidatePN.BackColor = SystemColors.Window
        CandidatePN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CandidatePN.Location = New Point(52, 502)
        CandidatePN.Name = "CandidatePN"
        CandidatePN.PlaceholderText = " Phone Number"
        CandidatePN.ReadOnly = True
        CandidatePN.Size = New Size(185, 34)
        CandidatePN.TabIndex = 124
        CandidatePN.TextAlign = HorizontalAlignment.Center
        ' 
        ' RemoveCABTN
        ' 
        RemoveCABTN.BackColor = Color.SeaGreen
        RemoveCABTN.FlatAppearance.BorderSize = 0
        RemoveCABTN.FlatStyle = FlatStyle.Flat
        RemoveCABTN.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveCABTN.ForeColor = SystemColors.ControlLight
        RemoveCABTN.Location = New Point(33, 611)
        RemoveCABTN.Name = "RemoveCABTN"
        RemoveCABTN.Size = New Size(111, 35)
        RemoveCABTN.TabIndex = 117
        RemoveCABTN.Text = "REMOVE"
        RemoveCABTN.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(19, 224)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(640, 3)
        PictureBox3.TabIndex = 116
        PictureBox3.TabStop = False
        ' 
        ' RemoveCID
        ' 
        RemoveCID.BackColor = SystemColors.Window
        RemoveCID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveCID.Location = New Point(229, 309)
        RemoveCID.Name = "RemoveCID"
        RemoveCID.Size = New Size(204, 34)
        RemoveCID.TabIndex = 115
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label2.Location = New Point(243, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 40)
        Label2.TabIndex = 114
        Label2.Text = "CANDIDATE ID :"
        ' 
        ' RemoveCandidate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 795)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RemoveCandidate"
        Text = "RemoveCandidate"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CandidateLN As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CandidateMN As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CandidateFN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CandidateEA As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CCount As TextBox
    Friend WithEvents CandidatePN As TextBox
    Friend WithEvents RemoveCABTN As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RemoveCID As TextBox
    Friend WithEvents Label2 As Label
End Class
