Public Class influenza
    Private Sub influenza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_prevention_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prevention.CheckedChanged
        RichTextBox_prevention.Visible = True
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_symptoms_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_symptoms.CheckedChanged
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = True
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_treatment_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_treatment.CheckedChanged
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = True
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_causes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_causes.CheckedChanged
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = False
    End Sub

    Private Sub RadioButton_other_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_other.CheckedChanged
        RichTextBox_prevention.Visible = False
        RichTextBox_symptoms.Visible = False
        RichTextBox_treatment.Visible = False
        RichTextBox_Causes.Visible = False
        RichTextBox_other.Visible = True
    End Sub

    Private Sub RichTextBox_other_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_other.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tr As New Treatment
        tr.Show()
        Hide()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) 
        Dim home As New ApplicationMainForm
        home.Show()
        Hide()
    End Sub
End Class