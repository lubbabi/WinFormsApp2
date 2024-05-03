<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidatesList
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
        CandidatesDataGridView = New DataGridView()
        CType(CandidatesDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CandidatesDataGridView
        ' 
        CandidatesDataGridView.AllowUserToAddRows = False
        CandidatesDataGridView.AllowUserToDeleteRows = False
        CandidatesDataGridView.BackgroundColor = SystemColors.Control
        CandidatesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CandidatesDataGridView.Dock = DockStyle.Fill
        CandidatesDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        CandidatesDataGridView.Location = New Point(0, 0)
        CandidatesDataGridView.Name = "CandidatesDataGridView"
        CandidatesDataGridView.ReadOnly = True
        CandidatesDataGridView.RowHeadersWidth = 51
        CandidatesDataGridView.Size = New Size(800, 450)
        CandidatesDataGridView.StandardTab = True
        CandidatesDataGridView.TabIndex = 93
        ' 
        ' CandidatesList
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(800, 450)
        Controls.Add(CandidatesDataGridView)
        FormBorderStyle = FormBorderStyle.None
        Name = "CandidatesList"
        Text = "CandidatesList"
        WindowState = FormWindowState.Maximized
        CType(CandidatesDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CandidatesDataGridView As DataGridView
End Class
