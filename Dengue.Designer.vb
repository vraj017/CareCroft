<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dengue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dengue))
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Button_dengue = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_waring = New System.Windows.Forms.Label()
        Me.RadioButton_other = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Causes = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Treatment = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Symptoms = New System.Windows.Forms.RadioButton()
        Me.RadioButton_prevention = New System.Windows.Forms.RadioButton()
        Me.RichTextBox_overview = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_prevention = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_symptoms = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_treatment = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_Causes = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_other = New System.Windows.Forms.RichTextBox()
        Me.btn_Maleria = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Controls.Add(Me.Button_dengue)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 536)
        Me.panelmenu.TabIndex = 4
        '
        'RoundButton1
        '
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Image = Global.Carecroft.My.Resources.Resources.user
        Me.RoundButton1.Location = New System.Drawing.Point(0, -3)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(149, 81)
        Me.RoundButton1.TabIndex = 2
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'Button_dengue
        '
        Me.Button_dengue.BackgroundImage = Global.Carecroft.My.Resources.Resources.dengue
        Me.Button_dengue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_dengue.FlatAppearance.BorderSize = 0
        Me.Button_dengue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_dengue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_dengue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_dengue.Location = New System.Drawing.Point(0, 81)
        Me.Button_dengue.Name = "Button_dengue"
        Me.Button_dengue.Size = New System.Drawing.Size(149, 452)
        Me.Button_dengue.TabIndex = 2
        Me.Button_dengue.Text = "Dengue"
        Me.Button_dengue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_dengue.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(146, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1153, 81)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dengue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1072, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 81)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label_waring
        '
        Me.Label_waring.AutoSize = True
        Me.Label_waring.Location = New System.Drawing.Point(334, 513)
        Me.Label_waring.Name = "Label_waring"
        Me.Label_waring.Size = New System.Drawing.Size(742, 20)
        Me.Label_waring.TabIndex = 18
        Me.Label_waring.Text = "For informational purposes only. Consult your local medical authority for advice." &
    " (information from google)"
        '
        'RadioButton_other
        '
        Me.RadioButton_other.AutoSize = True
        Me.RadioButton_other.Location = New System.Drawing.Point(1087, 93)
        Me.RadioButton_other.Name = "RadioButton_other"
        Me.RadioButton_other.Size = New System.Drawing.Size(74, 24)
        Me.RadioButton_other.TabIndex = 17
        Me.RadioButton_other.Text = "Other"
        Me.RadioButton_other.UseVisualStyleBackColor = True
        '
        'RadioButton_Causes
        '
        Me.RadioButton_Causes.AutoSize = True
        Me.RadioButton_Causes.Location = New System.Drawing.Point(865, 93)
        Me.RadioButton_Causes.Name = "RadioButton_Causes"
        Me.RadioButton_Causes.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton_Causes.TabIndex = 16
        Me.RadioButton_Causes.Text = "Causes"
        Me.RadioButton_Causes.UseVisualStyleBackColor = True
        '
        'RadioButton_Treatment
        '
        Me.RadioButton_Treatment.AutoSize = True
        Me.RadioButton_Treatment.Location = New System.Drawing.Point(618, 93)
        Me.RadioButton_Treatment.Name = "RadioButton_Treatment"
        Me.RadioButton_Treatment.Size = New System.Drawing.Size(116, 24)
        Me.RadioButton_Treatment.TabIndex = 15
        Me.RadioButton_Treatment.Text = "Treatement"
        Me.RadioButton_Treatment.UseVisualStyleBackColor = True
        '
        'RadioButton_Symptoms
        '
        Me.RadioButton_Symptoms.AutoSize = True
        Me.RadioButton_Symptoms.Location = New System.Drawing.Point(371, 93)
        Me.RadioButton_Symptoms.Name = "RadioButton_Symptoms"
        Me.RadioButton_Symptoms.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton_Symptoms.TabIndex = 14
        Me.RadioButton_Symptoms.Text = "Symptoms"
        Me.RadioButton_Symptoms.UseVisualStyleBackColor = True
        '
        'RadioButton_prevention
        '
        Me.RadioButton_prevention.AutoSize = True
        Me.RadioButton_prevention.Location = New System.Drawing.Point(165, 93)
        Me.RadioButton_prevention.Name = "RadioButton_prevention"
        Me.RadioButton_prevention.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton_prevention.TabIndex = 13
        Me.RadioButton_prevention.Text = "Prevention"
        Me.RadioButton_prevention.UseVisualStyleBackColor = True
        '
        'RichTextBox_overview
        '
        Me.RichTextBox_overview.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_overview.Name = "RichTextBox_overview"
        Me.RichTextBox_overview.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_overview.TabIndex = 19
        Me.RichTextBox_overview.Text = resources.GetString("RichTextBox_overview.Text")
        '
        'RichTextBox_prevention
        '
        Me.RichTextBox_prevention.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_prevention.Name = "RichTextBox_prevention"
        Me.RichTextBox_prevention.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_prevention.TabIndex = 20
        Me.RichTextBox_prevention.Text = resources.GetString("RichTextBox_prevention.Text")
        '
        'RichTextBox_symptoms
        '
        Me.RichTextBox_symptoms.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_symptoms.Name = "RichTextBox_symptoms"
        Me.RichTextBox_symptoms.ReadOnly = True
        Me.RichTextBox_symptoms.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_symptoms.TabIndex = 21
        Me.RichTextBox_symptoms.Text = resources.GetString("RichTextBox_symptoms.Text")
        '
        'RichTextBox_treatment
        '
        Me.RichTextBox_treatment.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_treatment.Name = "RichTextBox_treatment"
        Me.RichTextBox_treatment.ReadOnly = True
        Me.RichTextBox_treatment.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_treatment.TabIndex = 22
        Me.RichTextBox_treatment.Text = resources.GetString("RichTextBox_treatment.Text")
        '
        'RichTextBox_Causes
        '
        Me.RichTextBox_Causes.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_Causes.Name = "RichTextBox_Causes"
        Me.RichTextBox_Causes.ReadOnly = True
        Me.RichTextBox_Causes.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_Causes.TabIndex = 23
        Me.RichTextBox_Causes.Text = resources.GetString("RichTextBox_Causes.Text")
        '
        'RichTextBox_other
        '
        Me.RichTextBox_other.Location = New System.Drawing.Point(146, 123)
        Me.RichTextBox_other.Name = "RichTextBox_other"
        Me.RichTextBox_other.ReadOnly = True
        Me.RichTextBox_other.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_other.TabIndex = 24
        Me.RichTextBox_other.Text = resources.GetString("RichTextBox_other.Text")
        '
        'btn_Maleria
        '
        Me.btn_Maleria.FlatAppearance.BorderSize = 0
        Me.btn_Maleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maleria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Maleria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Maleria.Image = Global.Carecroft.My.Resources.Resources.maleria_image
        Me.btn_Maleria.Location = New System.Drawing.Point(-3, 70)
        Me.btn_Maleria.Name = "btn_Maleria"
        Me.btn_Maleria.Size = New System.Drawing.Size(149, 411)
        Me.btn_Maleria.TabIndex = 3
        Me.btn_Maleria.Text = "Maleria"
        Me.btn_Maleria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Maleria.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(165, 93)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "Prevention"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(371, 93)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "Symptoms"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(618, 93)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(116, 24)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.Text = "Treatement"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(865, 93)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.Text = "Causes"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(1087, 93)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(74, 24)
        Me.RadioButton5.TabIndex = 17
        Me.RadioButton5.Text = "Other"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(742, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "For informational purposes only. Consult your local medical authority for advice." &
    " (information from google)"
        '
        'Dengue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 536)
        Me.Controls.Add(Me.RichTextBox_other)
        Me.Controls.Add(Me.RichTextBox_Causes)
        Me.Controls.Add(Me.RichTextBox_treatment)
        Me.Controls.Add(Me.RichTextBox_symptoms)
        Me.Controls.Add(Me.RichTextBox_prevention)
        Me.Controls.Add(Me.RichTextBox_overview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_waring)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton_other)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton_Causes)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton_Treatment)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton_Symptoms)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton_prevention)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.btn_Maleria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dengue"
        Me.Text = "Dengue"
        Me.panelmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Maleria As Button
    Friend WithEvents panelmenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label_waring As Label
    Friend WithEvents RadioButton_other As RadioButton
    Friend WithEvents RadioButton_Causes As RadioButton
    Friend WithEvents RadioButton_Treatment As RadioButton
    Friend WithEvents RadioButton_Symptoms As RadioButton
    Friend WithEvents RadioButton_prevention As RadioButton
    Friend WithEvents RichTextBox_overview As RichTextBox
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Button_dengue As Button
    Friend WithEvents RichTextBox_prevention As RichTextBox
    Friend WithEvents RichTextBox_symptoms As RichTextBox
    Friend WithEvents RichTextBox_treatment As RichTextBox
    Friend WithEvents RichTextBox_Causes As RichTextBox
    Friend WithEvents RichTextBox_other As RichTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Label3 As Label
End Class
