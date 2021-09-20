Public Class loginoption


    Private Sub loginforpatient_Click(sender As Object, e As EventArgs) Handles loginforpatient.Click
        Hide()
        Dim lp As New loginforPatient()
        lp.show()

    End Sub

    Private Sub Buttonclose_Click(sender As Object, e As EventArgs) Handles Buttonclose.Click
        Application.Exit()

    End Sub

    Private Sub loginoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginfordoctor_Click(sender As Object, e As EventArgs) Handles loginfordoctor.Click
        Hide()
        Dim ld As New LoginforDoctor()
        ld.Show()
    End Sub
End Class