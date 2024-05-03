<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Button1 = New Button()
        Panel13 = New Panel()
        Button3 = New Button()
        Button6 = New Button()
        Panel12 = New Panel()
        ExitDashboard = New Button()
        Panel11 = New Panel()
        RemoveCandidateBTN = New Button()
        Panel10 = New Panel()
        RemoveHomeownerBTN = New Button()
        Panel9 = New Panel()
        addCandidateBTN = New Button()
        Panel8 = New Panel()
        addHomeownerBTN = New Button()
        Panel7 = New Panel()
        OverviewBTN = New Button()
        Panel5 = New Panel()
        Panel4 = New Panel()
        PictureBox9 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        BackBTN = New Button()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel13)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Panel12)
        Panel1.Controls.Add(ExitDashboard)
        Panel1.Controls.Add(Panel11)
        Panel1.Controls.Add(RemoveCandidateBTN)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(RemoveHomeownerBTN)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(addCandidateBTN)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(addHomeownerBTN)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(OverviewBTN)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(273, 833)
        Panel1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Dock = DockStyle.Bottom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Image = My.Resources.Resources.icons8_system_information_32
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 607)
        Button1.Name = "Button1"
        Button1.Size = New Size(273, 55)
        Button1.TabIndex = 46
        Button1.Text = "  Election Status"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Transparent
        Panel13.BackgroundImageLayout = ImageLayout.None
        Panel13.Dock = DockStyle.Bottom
        Panel13.Location = New Point(0, 662)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(273, 10)
        Panel13.TabIndex = 45
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Dock = DockStyle.Bottom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Image = My.Resources.Resources.icons8_comparison_or_versus_of_election_candidate_avatar_32
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(0, 672)
        Button3.Name = "Button3"
        Button3.Size = New Size(273, 55)
        Button3.TabIndex = 44
        Button3.Text = "  Election Setting"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Dock = DockStyle.Bottom
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.Control
        Button6.Image = My.Resources.Resources.icons8_ballot_32
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 727)
        Button6.Name = "Button6"
        Button6.Size = New Size(273, 55)
        Button6.TabIndex = 43
        Button6.Text = "  Voting Ballot"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel12.BackgroundImageLayout = ImageLayout.None
        Panel12.Dock = DockStyle.Bottom
        Panel12.Location = New Point(0, 782)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(273, 10)
        Panel12.TabIndex = 42
        ' 
        ' ExitDashboard
        ' 
        ExitDashboard.AutoSize = True
        ExitDashboard.BackColor = Color.Transparent
        ExitDashboard.Dock = DockStyle.Bottom
        ExitDashboard.FlatAppearance.BorderSize = 0
        ExitDashboard.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        ExitDashboard.FlatStyle = FlatStyle.Flat
        ExitDashboard.Font = New Font("Poppins", 10.8F)
        ExitDashboard.ForeColor = SystemColors.ControlLight
        ExitDashboard.Image = My.Resources.Resources.logout_32
        ExitDashboard.ImageAlign = ContentAlignment.MiddleLeft
        ExitDashboard.Location = New Point(0, 792)
        ExitDashboard.Name = "ExitDashboard"
        ExitDashboard.Size = New Size(273, 41)
        ExitDashboard.TabIndex = 40
        ExitDashboard.Text = "  Exit"
        ExitDashboard.TextAlign = ContentAlignment.MiddleLeft
        ExitDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        ExitDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel11.BackgroundImageLayout = ImageLayout.None
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 474)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(273, 10)
        Panel11.TabIndex = 39
        ' 
        ' RemoveCandidateBTN
        ' 
        RemoveCandidateBTN.AutoSize = True
        RemoveCandidateBTN.BackColor = Color.Transparent
        RemoveCandidateBTN.Dock = DockStyle.Top
        RemoveCandidateBTN.FlatAppearance.BorderSize = 0
        RemoveCandidateBTN.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        RemoveCandidateBTN.FlatStyle = FlatStyle.Flat
        RemoveCandidateBTN.Font = New Font("Poppins", 10.8F)
        RemoveCandidateBTN.ForeColor = SystemColors.ControlLight
        RemoveCandidateBTN.Image = My.Resources.Resources.delete_document_32
        RemoveCandidateBTN.ImageAlign = ContentAlignment.MiddleLeft
        RemoveCandidateBTN.Location = New Point(0, 419)
        RemoveCandidateBTN.Name = "RemoveCandidateBTN"
        RemoveCandidateBTN.Size = New Size(273, 55)
        RemoveCandidateBTN.TabIndex = 38
        RemoveCandidateBTN.Text = "  Remove Candidate"
        RemoveCandidateBTN.TextAlign = ContentAlignment.MiddleLeft
        RemoveCandidateBTN.TextImageRelation = TextImageRelation.ImageBeforeText
        RemoveCandidateBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Transparent
        Panel10.BackgroundImageLayout = ImageLayout.None
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 409)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(273, 10)
        Panel10.TabIndex = 37
        ' 
        ' RemoveHomeownerBTN
        ' 
        RemoveHomeownerBTN.AutoSize = True
        RemoveHomeownerBTN.BackColor = Color.Transparent
        RemoveHomeownerBTN.Dock = DockStyle.Top
        RemoveHomeownerBTN.FlatAppearance.BorderSize = 0
        RemoveHomeownerBTN.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        RemoveHomeownerBTN.FlatStyle = FlatStyle.Flat
        RemoveHomeownerBTN.Font = New Font("Poppins", 10.8F)
        RemoveHomeownerBTN.ForeColor = SystemColors.ControlLight
        RemoveHomeownerBTN.Image = My.Resources.Resources.denied_32
        RemoveHomeownerBTN.ImageAlign = ContentAlignment.MiddleLeft
        RemoveHomeownerBTN.Location = New Point(0, 354)
        RemoveHomeownerBTN.Name = "RemoveHomeownerBTN"
        RemoveHomeownerBTN.Size = New Size(273, 55)
        RemoveHomeownerBTN.TabIndex = 36
        RemoveHomeownerBTN.Text = "  Remove Homeowner"
        RemoveHomeownerBTN.TextAlign = ContentAlignment.MiddleLeft
        RemoveHomeownerBTN.TextImageRelation = TextImageRelation.ImageBeforeText
        RemoveHomeownerBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel9.BackgroundImageLayout = ImageLayout.None
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 337)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(273, 17)
        Panel9.TabIndex = 35
        ' 
        ' addCandidateBTN
        ' 
        addCandidateBTN.AutoSize = True
        addCandidateBTN.BackColor = Color.Transparent
        addCandidateBTN.Dock = DockStyle.Top
        addCandidateBTN.FlatAppearance.BorderSize = 0
        addCandidateBTN.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        addCandidateBTN.FlatStyle = FlatStyle.Flat
        addCandidateBTN.Font = New Font("Poppins", 10.8F)
        addCandidateBTN.ForeColor = SystemColors.ControlLight
        addCandidateBTN.Image = My.Resources.Resources.profile_32
        addCandidateBTN.ImageAlign = ContentAlignment.MiddleLeft
        addCandidateBTN.Location = New Point(0, 282)
        addCandidateBTN.Name = "addCandidateBTN"
        addCandidateBTN.Size = New Size(273, 55)
        addCandidateBTN.TabIndex = 34
        addCandidateBTN.Text = "  Add Candidate"
        addCandidateBTN.TextAlign = ContentAlignment.MiddleLeft
        addCandidateBTN.TextImageRelation = TextImageRelation.ImageBeforeText
        addCandidateBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Transparent
        Panel8.BackgroundImageLayout = ImageLayout.None
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 272)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(273, 10)
        Panel8.TabIndex = 33
        ' 
        ' addHomeownerBTN
        ' 
        addHomeownerBTN.AutoSize = True
        addHomeownerBTN.BackColor = Color.Transparent
        addHomeownerBTN.Dock = DockStyle.Top
        addHomeownerBTN.FlatAppearance.BorderSize = 0
        addHomeownerBTN.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        addHomeownerBTN.FlatStyle = FlatStyle.Flat
        addHomeownerBTN.Font = New Font("Poppins", 10.8F)
        addHomeownerBTN.ForeColor = SystemColors.ControlLight
        addHomeownerBTN.Image = My.Resources.Resources.add_user
        addHomeownerBTN.ImageAlign = ContentAlignment.MiddleLeft
        addHomeownerBTN.Location = New Point(0, 217)
        addHomeownerBTN.Name = "addHomeownerBTN"
        addHomeownerBTN.Size = New Size(273, 55)
        addHomeownerBTN.TabIndex = 32
        addHomeownerBTN.Text = "  Add Homeowner"
        addHomeownerBTN.TextAlign = ContentAlignment.MiddleLeft
        addHomeownerBTN.TextImageRelation = TextImageRelation.ImageBeforeText
        addHomeownerBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel7.BackgroundImageLayout = ImageLayout.None
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 200)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(273, 17)
        Panel7.TabIndex = 31
        ' 
        ' OverviewBTN
        ' 
        OverviewBTN.AutoSize = True
        OverviewBTN.BackColor = Color.Transparent
        OverviewBTN.Dock = DockStyle.Top
        OverviewBTN.FlatAppearance.BorderSize = 0
        OverviewBTN.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        OverviewBTN.FlatStyle = FlatStyle.Flat
        OverviewBTN.Font = New Font("Poppins", 10.8F)
        OverviewBTN.ForeColor = SystemColors.ControlLight
        OverviewBTN.Image = My.Resources.Resources.dashboard_32
        OverviewBTN.ImageAlign = ContentAlignment.MiddleLeft
        OverviewBTN.Location = New Point(0, 145)
        OverviewBTN.Name = "OverviewBTN"
        OverviewBTN.Size = New Size(273, 55)
        OverviewBTN.TabIndex = 30
        OverviewBTN.Text = "  Overview"
        OverviewBTN.TextAlign = ContentAlignment.MiddleLeft
        OverviewBTN.TextImageRelation = TextImageRelation.ImageBeforeText
        OverviewBTN.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.BackgroundImageLayout = ImageLayout.None
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(273, 10)
        Panel5.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(PictureBox9)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(LinkLabel1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(273, 97)
        Panel4.TabIndex = 27
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Black
        PictureBox9.Location = New Point(92, 5)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(5, 82)
        PictureBox9.TabIndex = 24
        PictureBox9.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources.user
        PictureBox6.Location = New Point(12, 5)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(82, 82)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(103, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 24)
        Label1.TabIndex = 20
        Label1.Text = "FN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(103, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 20)
        Label2.TabIndex = 21
        Label2.Text = "AT"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(103, 57)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(132, 30)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Admin Setting"
        LinkLabel1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(109), CByte(33), CByte(79))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(273, 38)
        Panel2.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.ImageAlign = ContentAlignment.BottomCenter
        Label4.Location = New Point(6, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(227, 22)
        Label4.TabIndex = 22
        Label4.Text = "ADMINISTRATOR DASHBOARD"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Panel3.Controls.Add(BackBTN)
        Panel3.Controls.Add(Label4)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(273, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(964, 38)
        Panel3.TabIndex = 26
        ' 
        ' BackBTN
        ' 
        BackBTN.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        BackBTN.Dock = DockStyle.Right
        BackBTN.FlatAppearance.BorderSize = 0
        BackBTN.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow
        BackBTN.FlatStyle = FlatStyle.Flat
        BackBTN.ForeColor = SystemColors.Control
        BackBTN.Location = New Point(896, 0)
        BackBTN.Name = "BackBTN"
        BackBTN.Size = New Size(68, 38)
        BackBTN.TabIndex = 0
        BackBTN.Text = "Back"
        BackBTN.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.AutoScroll = True
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(273, 38)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(964, 795)
        Panel6.TabIndex = 27
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1237, 833)
        ControlBox = False
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents RemoveCandidateBTN As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents RemoveHomeownerBTN As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents addCandidateBTN As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents addHomeownerBTN As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents OverviewBTN As Button
    Friend WithEvents ExitDashboard As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BackBTN As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel13 As Panel
End Class
