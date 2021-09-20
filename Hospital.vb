Public Class Hospital
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim main As New ApplicationMainForm()
        main.Show()
        Hide()
    End Sub

    Private Sub Labouratory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_lab.Visible = False
        Panel_treatment.Visible = False
        Panel_hospital.Visible = True

        If My.Computer.Network.IsAvailable Then
            WebBrowser1.Navigate("https://www.bing.com/maps?osid=7d7ff214-4d0a-479c-89ec-f5edfd8579da&cp=23.058652~72.541419&lvl=13&imgid=12ddbcf7-6a65-47e2-9452-c23426949708&v=2&sV=2&form=S00027")
        Else
            MessageBox.Show("internet is not avialable")
            End
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btn_Labouratory_Click(sender As Object, e As EventArgs) Handles btn_Labouratory.Click
        Dim lb As New Labouratory
        lb.Show()
        Hide()

    End Sub

    Private Sub btn_Treatment_Click(sender As Object, e As EventArgs) Handles btn_Treatment.Click
        Dim tr As New Treatment
        tr.Show()
        Hide()

    End Sub



    Private Sub btn_Treatment_MouseLeave(sender As Object, e As EventArgs) Handles btn_Treatment.MouseLeave
        Panel_treatment.Visible = False
    End Sub

    Private Sub btn_Labouratory_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Labouratory.MouseMove
        Panel_lab.Visible = True

    End Sub

    Private Sub btn_Treatment_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Treatment.MouseMove
        Panel_treatment.Visible = True
    End Sub

    Private Sub btn_Labouratory_MouseLeave(sender As Object, e As EventArgs) Handles btn_Labouratory.MouseLeave
        Panel_lab.Visible = False
    End Sub
End Class