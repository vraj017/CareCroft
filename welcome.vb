Public Class welcome
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Enabled = True
        Label2.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            loginoption.Show()
            Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class