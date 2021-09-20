Public Class ApplicationMainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginoption.Show()
        Hide()


    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click


    End Sub

    Private Sub RoundButton_treatment_Click(sender As Object, e As EventArgs) Handles RoundButton_treatment.Click
        Dim tr As New Treatment
        tr.Show()
        Hide()

    End Sub

    Private Sub RoundButton_lab_Click(sender As Object, e As EventArgs) Handles RoundButton_lab.Click
        Dim lb As New Labouratory
        lb.Show()
        Hide()
    End Sub

    Private Sub RoundButton_hospital_Click(sender As Object, e As EventArgs) Handles RoundButton_hospital.Click
        Dim hs As New Hospital
        hs.Show()
        Hide()

    End Sub

    Private Sub RoundButton_Appointment_Click(sender As Object, e As EventArgs) Handles RoundButton_Appointment.Click
        Process.Start("https://bit.ly/Carecroftbooking")
    End Sub
End Class