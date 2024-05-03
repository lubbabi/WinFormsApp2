Public Class MainWindow
    Dim progressValue As Integer = 0

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressValue += 4

        ProgressBar1.Value = progressValue

        Select Case progressValue
            Case Is < 30
                Label3.Text = "Loading..."
            Case Is < 70
                Label3.Text = "Still Loading..."
            Case Is < 100
                Label3.Text = "Almost There..."
            Case Else
                Label3.Text = "Loading Complete"
                LoginForm.Show()
                Me.Hide()
                Timer1.Stop()
        End Select

        Label4.Text = progressValue & "%"
    End Sub
End Class
