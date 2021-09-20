Public Class doctorhomepage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://docs.google.com/spreadsheets/d/12MkQWaonNs943DLk3H7xXf8Mjy0wLRaWLSd3-3wurYw/edit#gid=1465643219")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginoption.Show()
        Hide()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class