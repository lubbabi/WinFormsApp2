<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveHomeowner
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
        HomeownerLN = New TextBox()
        Panel3 = New Panel()
        HStatus = New TextBox()
        Label3 = New Label()
        HomeownerMN = New TextBox()
        Panel5 = New Panel()
        HomeownerFN = New TextBox()
        Label1 = New Label()
        HomeownerEA = New TextBox()
        Panel2 = New Panel()
        Label6 = New Label()
        HCount = New TextBox()
        HomeownerPN = New TextBox()
        RemoveHOBTN = New Button()
        PictureBox3 = New PictureBox()
        RemoveHID = New TextBox()
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
        Panel1.Controls.Add(HomeownerLN)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(HomeownerMN)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(HomeownerFN)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(HomeownerEA)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(HomeownerPN)
        Panel1.Controls.Add(RemoveHOBTN)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(RemoveHID)
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
        Label5.Location = New Point(297, 414)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 23)
        Label5.TabIndex = 112
        Label5.Text = "(AUTOFILL)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(19, 570)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(640, 3)
        PictureBox1.TabIndex = 111
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label4.Location = New Point(52, 404)
        Label4.Name = "Label4"
        Label4.Size = New Size(253, 40)
        Label4.TabIndex = 109
        Label4.Text = "HOMEOWNER DETAIL :"
        ' 
        ' HomeownerLN
        ' 
        HomeownerLN.BackColor = SystemColors.Window
        HomeownerLN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerLN.Location = New Point(434, 450)
        HomeownerLN.Name = "HomeownerLN"
        HomeownerLN.PlaceholderText = " Last Name"
        HomeownerLN.ReadOnly = True
        HomeownerLN.RightToLeft = RightToLeft.No
        HomeownerLN.Size = New Size(185, 34)
        HomeownerLN.TabIndex = 104
        HomeownerLN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        Panel3.Controls.Add(HStatus)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(363, 66)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(299, 148)
        Panel3.TabIndex = 96
        ' 
        ' HStatus
        ' 
        HStatus.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        HStatus.BorderStyle = BorderStyle.None
        HStatus.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HStatus.Location = New Point(55, 58)
        HStatus.Name = "HStatus"
        HStatus.ReadOnly = True
        HStatus.Size = New Size(188, 41)
        HStatus.TabIndex = 73
        HStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 31)
        Label3.TabIndex = 72
        Label3.Text = "Homeowner Status :"
        ' 
        ' HomeownerMN
        ' 
        HomeownerMN.BackColor = SystemColors.Window
        HomeownerMN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerMN.Location = New Point(243, 450)
        HomeownerMN.Name = "HomeownerMN"
        HomeownerMN.PlaceholderText = " Middle Name"
        HomeownerMN.ReadOnly = True
        HomeownerMN.Size = New Size(185, 34)
        HomeownerMN.TabIndex = 105
        HomeownerMN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(16, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(14, 40)
        Panel5.TabIndex = 89
        ' 
        ' HomeownerFN
        ' 
        HomeownerFN.BackColor = SystemColors.Window
        HomeownerFN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerFN.Location = New Point(52, 450)
        HomeownerFN.Name = "HomeownerFN"
        HomeownerFN.PlaceholderText = " First Name"
        HomeownerFN.ReadOnly = True
        HomeownerFN.Size = New Size(185, 34)
        HomeownerFN.TabIndex = 106
        HomeownerFN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 40)
        Label1.TabIndex = 72
        Label1.Text = "REMOVE HOMEOWNER"
        ' 
        ' HomeownerEA
        ' 
        HomeownerEA.BackColor = SystemColors.Window
        HomeownerEA.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerEA.Location = New Point(243, 504)
        HomeownerEA.Name = "HomeownerEA"
        HomeownerEA.PlaceholderText = " Email Address"
        HomeownerEA.ReadOnly = True
        HomeownerEA.Size = New Size(376, 34)
        HomeownerEA.TabIndex = 108
        HomeownerEA.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(HCount)
        Panel2.Location = New Point(16, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(299, 148)
        Panel2.TabIndex = 95
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10.8F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 31)
        Label6.TabIndex = 72
        Label6.Text = "Total Homeowners:"
        ' 
        ' HCount
        ' 
        HCount.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(159))
        HCount.BorderStyle = BorderStyle.None
        HCount.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HCount.Location = New Point(52, 58)
        HCount.Name = "HCount"
        HCount.ReadOnly = True
        HCount.Size = New Size(188, 41)
        HCount.TabIndex = 73
        HCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' HomeownerPN
        ' 
        HomeownerPN.BackColor = SystemColors.Window
        HomeownerPN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomeownerPN.Location = New Point(52, 504)
        HomeownerPN.Name = "HomeownerPN"
        HomeownerPN.PlaceholderText = " Phone Number"
        HomeownerPN.ReadOnly = True
        HomeownerPN.Size = New Size(185, 34)
        HomeownerPN.TabIndex = 107
        HomeownerPN.TextAlign = HorizontalAlignment.Center
        ' 
        ' RemoveHOBTN
        ' 
        RemoveHOBTN.BackColor = Color.SeaGreen
        RemoveHOBTN.FlatAppearance.BorderSize = 0
        RemoveHOBTN.FlatStyle = FlatStyle.Flat
        RemoveHOBTN.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveHOBTN.ForeColor = SystemColors.ControlLight
        RemoveHOBTN.Location = New Point(33, 613)
        RemoveHOBTN.Name = "RemoveHOBTN"
        RemoveHOBTN.Size = New Size(111, 35)
        RemoveHOBTN.TabIndex = 84
        RemoveHOBTN.Text = "REMOVE"
        RemoveHOBTN.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(19, 226)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(640, 3)
        PictureBox3.TabIndex = 83
        PictureBox3.TabStop = False
        ' 
        ' RemoveHID
        ' 
        RemoveHID.BackColor = SystemColors.Window
        RemoveHID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveHID.Location = New Point(229, 311)
        RemoveHID.Name = "RemoveHID"
        RemoveHID.Size = New Size(204, 34)
        RemoveHID.TabIndex = 76
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 13.8F, FontStyle.Underline)
        Label2.Location = New Point(229, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 40)
        Label2.TabIndex = 73
        Label2.Text = "HOMEOWNER ID :"
        ' 
        ' RemoveHomeowner
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 795)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RemoveHomeowner"
        Text = "RemoveHomeowner"
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
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HStatus As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ImageFileName As TextBox
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents DeleteImage As Button
    Friend WithEvents SelectImage As Button
    Friend WithEvents HomeownerDOB As DateTimePicker
    Friend WithEvents HomeownerAge As TextBox
    Friend WithEvents RemoveHOBTN As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RemoveHID As TextBox
    Friend WithEvents HomeownerGender As TextBox
    Friend WithEvents HomeownerFA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HomeownerLN As TextBox
    Friend WithEvents HomeownerMN As TextBox
    Friend WithEvents HomeownerFN As TextBox
    Friend WithEvents HomeownerEA As TextBox
    Friend WithEvents HomeownerPN As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HCount As TextBox
End Class
