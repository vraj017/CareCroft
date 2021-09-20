Public Class Treatment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim main As New ApplicationMainForm()
        main.Show()
        Hide()
    End Sub

    Private Sub Treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_treatment.Visible = True
        Panel_lab.Visible = False
        Panel_hospital.Visible = False


    End Sub
    Private Sub btn_Labouratory_MouseLeave(sender As Object, e As EventArgs) Handles btn_Labouratory.MouseLeave
        Panel_lab.Visible = False

    End Sub

    Private Sub btn_Labouratory_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Labouratory.MouseMove
        Panel_lab.Visible = True

    End Sub

    Private Sub btn_Hospital_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_Hospital.MouseMove
        Panel_hospital.Visible = True

    End Sub

    Private Sub btn_Hospital_MouseLeave(sender As Object, e As EventArgs) Handles btn_Hospital.MouseLeave
        Panel_hospital.Visible = False
    End Sub


    Private Sub btn_Labouratory_Click(sender As Object, e As EventArgs) Handles btn_Labouratory.Click
        Dim lab As New Labouratory()
        lab.Show()
        Hide()

    End Sub

    Private Sub btn_Hospital_Click(sender As Object, e As EventArgs) Handles btn_Hospital.Click
        Dim hs As New Hospital
        hs.Show()
        Hide()

    End Sub


    Private Sub maleria_btn_Click(sender As Object, e As EventArgs) Handles maleria_btn.Click
        Dim dis As New maleria
        dis.Show()
        Hide()

    End Sub

    Private Sub dengue_btn_Click(sender As Object, e As EventArgs) Handles dengue_btn.Click
        Dim de As New Dengue
        de.Show()
        Hide()

    End Sub

    Private Sub tb_btn_Click(sender As Object, e As EventArgs) Handles tb_btn.Click
        Dim tba As New Tuberculosis
        tba.Show()
        Hide()

    End Sub

    Private Sub diab_btn_Click(sender As Object, e As EventArgs) Handles diab_btn.Click
        Dim dia As New diabetes
        dia.Show()
        Hide()

    End Sub

    Private Sub influenza_btn_Click(sender As Object, e As EventArgs) Handles influenza_btn.Click
        Dim inf As New influenza
        inf.Show()
        Hide()

    End Sub

    Private Sub car_btn_Click(sender As Object, e As EventArgs) Handles car_btn.Click
        Dim car As New Cardiovascular
        car.Show()
        Hide()

    End Sub

    Private Sub Button_more_disease_Click(sender As Object, e As EventArgs) Handles Button_more_disease.Click
        Dim sd As New Search_Disease
        sd.Show()
        Hide()

    End Sub


End Class