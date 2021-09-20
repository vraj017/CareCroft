Public Class Search_Disease
    Private Sub Search_Disease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            WebBrowser1.Navigate("http://www.google.com/")
        Else
            MessageBox.Show("internet is not avialable")
            End
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As New Treatment()
        b.Show()
        Me.Hide()
    End Sub
End Class