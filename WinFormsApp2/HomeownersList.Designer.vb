<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeownersList
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
        HomeownersDataGridView = New DataGridView()
        CType(HomeownersDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HomeownersDataGridView
        ' 
        HomeownersDataGridView.AllowUserToAddRows = False
        HomeownersDataGridView.AllowUserToDeleteRows = False
        HomeownersDataGridView.BackgroundColor = SystemColors.Control
        HomeownersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HomeownersDataGridView.Dock = DockStyle.Fill
        HomeownersDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        HomeownersDataGridView.Location = New Point(0, 0)
        HomeownersDataGridView.Name = "HomeownersDataGridView"
        HomeownersDataGridView.ReadOnly = True
        HomeownersDataGridView.RowHeadersWidth = 51
        HomeownersDataGridView.Size = New Size(800, 450)
        HomeownersDataGridView.StandardTab = True
        HomeownersDataGridView.TabIndex = 92
        ' 
        ' HomeownersList
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(800, 450)
        Controls.Add(HomeownersDataGridView)
        FormBorderStyle = FormBorderStyle.None
        Name = "HomeownersList"
        Text = "HomeownersList"
        WindowState = FormWindowState.Maximized
        CType(HomeownersDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HomeownersDataGridView As DataGridView
End Class
