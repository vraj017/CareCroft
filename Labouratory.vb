Imports System.Text
Public Class Labouratory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim main As New ApplicationMainForm()
        main.Show()
        Hide()

    End Sub

    Private Sub Labouratory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_lab.Visible = True
        Panel_treatment.Visible = False
        Panel_hospital.Visible = False

        WebBrowser1.Navigate("https://www.bing.com/maps?osid=0c794f40-19e1-4e32-b7ab-379b9eeec133&cp=23.050799~72.550207&lvl=13&imgid=a9b2f226-4256-4964-8d45-9ff7a0bd3226&v=2&sV=2&form=S00027")
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_Treatment_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Treatment.MouseMove
        Panel_treatment.Visible = True

    End Sub

    Private Sub btn_Treatment_MouseLeave(sender As Object, e As EventArgs) Handles btn_Treatment.MouseLeave
        Panel_treatment.Visible = False

    End Sub

    Private Sub btn_Hospital_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Hospital.MouseMove
        Panel_hospital.Visible = True

    End Sub

    Private Sub btn_Hospital_MouseLeave(sender As Object, e As EventArgs) Handles btn_Hospital.MouseLeave
        Panel_hospital.Visible = False
    End Sub


    Private Sub btn_Hospital_Click(sender As Object, e As EventArgs) Handles btn_Hospital.Click
        Dim hos As New Hospital

        hos.Show()
        Hide()

    End Sub

    Private Sub btn_Treatment_Click(sender As Object, e As EventArgs) Handles btn_Treatment.Click

        Dim tr As New Treatment
        tr.Show()
        Hide()
    End Sub

End Class