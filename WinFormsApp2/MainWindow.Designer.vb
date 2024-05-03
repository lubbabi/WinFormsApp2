<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.montalbanlogo
        PictureBox4.Location = New Point(12, 142)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(128, 128)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Black
        PictureBox5.Location = New Point(143, 92)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(285, 3)
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(146, 316)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(255, 3)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Outfit Medium", 32F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(146, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 221)
        Label1.TabIndex = 0
        Label1.Text = "Barangay E-Voting System"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Timer1
        ' 
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Outfit", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(168, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 25)
        Label2.TabIndex = 10
        Label2.Text = "Colegio De Montalban"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(97))
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.Location = New Point(0, 471)
        ProgressBar1.MarqueeAnimationSpeed = 80
        ProgressBar1.Maximum = 104
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(795, 23)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 13.8F)
        Label3.Location = New Point(401, 425)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 40)
        Label3.TabIndex = 12
        Label3.Text = "L"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 13.8F)
        Label4.Location = New Point(737, 425)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 40)
        Label4.TabIndex = 13
        Label4.Text = "N"
        ' 
        ' MainWindow
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources._1917195_Flip
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(795, 494)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ProgressBar1)
        Controls.Add(Label2)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox4)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Area"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
