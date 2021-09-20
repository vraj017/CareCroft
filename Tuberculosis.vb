Public Class Tuberculosis
    Private Sub home_Click(sender As Object, e As EventArgs)
        Dim home As New ApplicationMainForm
        home.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tr As New Treatment
        tr.Show()
        Hide()
    End Sub

    Private Sub RadioButton1_prevention_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prevention.CheckedChanged
        richtextbox_prevention.Visible = True
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub Tuberculosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        richtextbox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False

    End Sub

    Private Sub RadioButton2_symptoms_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_symptoms.CheckedChanged
        RichTextBox_symptoms.Visible = True
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
        richtextbox_prevention.Visible = False
    End Sub

    Private Sub RadioButton_treatment_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_treatment.CheckedChanged
        richtextbox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = True
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_causes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_causes.CheckedChanged
        richtextbox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = True
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_other_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_other.CheckedChanged
        richtextbox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = True
    End Sub
End Class