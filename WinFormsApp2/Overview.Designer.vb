<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        Panel3 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        ViewListCandidates = New Button()
        ViewListHomeowners = New Button()
        Panel4 = New Panel()
        CandidatesBox = New Panel()
        CCount = New TextBox()
        Label3 = New Label()
        HomeownersBox = New Panel()
        HCount = New TextBox()
        Label2 = New Label()
        Panel5 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CandidatesBox.SuspendLayout()
        HomeownersBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(ViewListCandidates)
        Panel1.Controls.Add(ViewListHomeowners)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(CandidatesBox)
        Panel1.Controls.Add(HomeownersBox)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(964, 795)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(16, 261)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(14, 40)
        Panel3.TabIndex = 93
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(36, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 40)
        Label4.TabIndex = 92
        Label4.Text = "LIST OF -"
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(27, 320)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(863, 407)
        Panel2.TabIndex = 91
        ' 
        ' ViewListCandidates
        ' 
        ViewListCandidates.BackColor = Color.SeaGreen
        ViewListCandidates.Cursor = Cursors.Hand
        ViewListCandidates.FlatAppearance.BorderSize = 0
        ViewListCandidates.FlatStyle = FlatStyle.Flat
        ViewListCandidates.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewListCandidates.ForeColor = SystemColors.ControlLight
        ViewListCandidates.Location = New Point(349, 195)
        ViewListCandidates.Name = "ViewListCandidates"
        ViewListCandidates.Size = New Size(227, 35)
        ViewListCandidates.TabIndex = 90
        ViewListCandidates.Text = "View List of Candidates"
        ViewListCandidates.UseVisualStyleBackColor = False
        ' 
        ' ViewListHomeowners
        ' 
        ViewListHomeowners.BackColor = Color.SeaGreen
        ViewListHomeowners.Cursor = Cursors.Hand
        ViewListHomeowners.FlatAppearance.BorderSize = 0
        ViewListHomeowners.FlatStyle = FlatStyle.Flat
        ViewListHomeowners.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewListHomeowners.ForeColor = SystemColors.ControlLight
        ViewListHomeowners.Location = New Point(39, 195)
        ViewListHomeowners.Name = "ViewListHomeowners"
        ViewListHomeowners.Size = New Size(227, 35)
        ViewListHomeowners.TabIndex = 89
        ViewListHomeowners.Text = "View List of Homeowners"
        ViewListHomeowners.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(165), CByte(2))
        Panel4.Location = New Point(614, 64)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(272, 125)
        Panel4.TabIndex = 88
        ' 
        ' CandidatesBox
        ' 
        CandidatesBox.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        CandidatesBox.Controls.Add(CCount)
        CandidatesBox.Controls.Add(Label3)
        CandidatesBox.Location = New Point(315, 64)
        CandidatesBox.Name = "CandidatesBox"
        CandidatesBox.Size = New Size(272, 125)
        CandidatesBox.TabIndex = 87
        ' 
        ' CCount
        ' 
        CCount.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        CCount.BorderStyle = BorderStyle.None
        CCount.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CCount.ForeColor = Color.White
        CCount.Location = New Point(115, 53)
        CCount.Name = "CCount"
        CCount.ReadOnly = True
        CCount.Size = New Size(147, 35)
        CCount.TabIndex = 72
        CCount.Text = " "
        CCount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(7, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 31)
        Label3.TabIndex = 1
        Label3.Text = "Total Candidates"
        ' 
        ' HomeownersBox
        ' 
        HomeownersBox.BackColor = Color.FromArgb(CByte(255), CByte(165), CByte(2))
        HomeownersBox.Controls.Add(HCount)
        HomeownersBox.Controls.Add(Label2)
        HomeownersBox.Location = New Point(16, 64)
        HomeownersBox.Name = "HomeownersBox"
        HomeownersBox.Size = New Size(272, 125)
        HomeownersBox.TabIndex = 86
        ' 
        ' HCount
        ' 
        HCount.BackColor = Color.FromArgb(CByte(255), CByte(165), CByte(2))
        HCount.BorderStyle = BorderStyle.None
        HCount.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HCount.ForeColor = Color.White
        HCount.Location = New Point(114, 53)
        HCount.Name = "HCount"
        HCount.ReadOnly = True
        HCount.Size = New Size(147, 35)
        HCount.TabIndex = 71
        HCount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(7, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 31)
        Label2.TabIndex = 0
        Label2.Text = "Total Homeowners"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(16, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(14, 40)
        Panel5.TabIndex = 85
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 40)
        Label1.TabIndex = 84
        Label1.Text = "OVERVIEW STATUS"
        ' 
        ' Overview
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(964, 795)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Overview"
        Text = "Overview"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CandidatesBox.ResumeLayout(False)
        CandidatesBox.PerformLayout()
        HomeownersBox.ResumeLayout(False)
        HomeownersBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ViewListCandidates As Button
    Friend WithEvents ViewListHomeowners As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CandidatesBox As Panel
    Friend WithEvents CCount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HomeownersBox As Panel
    Friend WithEvents HCount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
End Class
