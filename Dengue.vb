Public Class Dengue
    Private Sub Dengue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_prevention_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prevention.CheckedChanged, RadioButton1.CheckedChanged
        RichTextBox_prevention.Visible = True
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tr As New Treatment
        tr.Show()
        Hide()
    End Sub

    Private Sub RadioButton_Symptoms_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Symptoms.CheckedChanged, RadioButton2.CheckedChanged
        RichTextBox_symptoms.Visible = True
        RichTextBox_prevention.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_Treatment_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Treatment.CheckedChanged, RadioButton3.CheckedChanged
        RichTextBox_treatment.Visible = True
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False

    End Sub

    Private Sub RadioButton_Causes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Causes.CheckedChanged, RadioButton4.CheckedChanged
        RichTextBox_Causes.Visible = True
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_other_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_other.CheckedChanged, RadioButton5.CheckedChanged
        RichTextBox_other.Visible = True
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False

    End Sub
End Class