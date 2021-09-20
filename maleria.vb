Public Class maleria
    Private Sub btn_Maleria_Click(sender As Object, e As EventArgs) Handles btn_Maleria.Click

        RichTextBox_maleria.Visible = True
        RichTextBox_prevention.Visible = False
        RadioButton_prevention.Visible = True
        RadioButton_Symptoms.Visible = True
        RadioButton_Treatment.Visible = True
        RadioButton_Speciality.Visible = True
        RadioButton_other.Visible = True
        Label_waring.Visible = True
        Label2.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tr As New Treatment

        tr.Show()
        Hide()

    End Sub
    Private Sub maleria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox_maleria.Visible = True
        RichTextBox_prevention.Visible = False
        RichTextBox_Symptoms.Visible = False
        RichTextBox_Treatment.Visible = False
        RichTextBox_Speciality.Visible = False
        RichTextBox1_other.Visible = False

    End Sub

    Private Sub RadioButton_prevention_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_prevention.CheckedChanged
        RichTextBox_prevention.Visible = True
        RichTextBox_Symptoms.Visible = False
        RichTextBox_Treatment.Visible = False
        RichTextBox_Speciality.Visible = False
        RichTextBox1_other.Visible = False
        RichTextBox_maleria.Visible = False

    End Sub

    Private Sub RadioButton_Symptoms_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Symptoms.CheckedChanged
        RichTextBox_Symptoms.Visible = True
        RichTextBox_Treatment.Visible = False
        RichTextBox_Speciality.Visible = False
        RichTextBox1_other.Visible = False
        RichTextBox_maleria.Visible = False
        RichTextBox_prevention.Visible = False

    End Sub

    Private Sub RadioButton_Treatment_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Treatment.CheckedChanged
        RichTextBox_Treatment.Visible = True
        RichTextBox_Speciality.Visible = False
        RichTextBox1_other.Visible = False
        RichTextBox_maleria.Visible = False
        RichTextBox_prevention.Visible = False
        RichTextBox_Symptoms.Visible = False

    End Sub

    Private Sub RadioButton_Speciality_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Speciality.CheckedChanged
        RichTextBox_Speciality.Visible = True
        RichTextBox1_other.Visible = False
        RichTextBox_maleria.Visible = False
        RichTextBox_prevention.Visible = False
        RichTextBox_Symptoms.Visible = False
        RichTextBox_Treatment.Visible = False

    End Sub

    Private Sub RadioButton_other_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_other.CheckedChanged
        RichTextBox1_other.Visible = True
        RichTextBox_maleria.Visible = False
        RichTextBox_prevention.Visible = False
        RichTextBox_Symptoms.Visible = False
        RichTextBox_Treatment.Visible = False
        RichTextBox_Speciality.Visible = False
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs)
        Dim home As New ApplicationMainForm
        home.Show()
        Hide()
    End Sub
End Class