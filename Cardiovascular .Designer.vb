﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cardiovascular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cardiovascular))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton_other = New System.Windows.Forms.RadioButton()
        Me.RadioButton_causes = New System.Windows.Forms.RadioButton()
        Me.RadioButton_treatment = New System.Windows.Forms.RadioButton()
        Me.RadioButton_symptoms = New System.Windows.Forms.RadioButton()
        Me.RadioButton_prevention = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Button_cardi = New System.Windows.Forms.Button()
        Me.RichTextBox_overview = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_prevention = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_symptoms = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_treatment = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_Causes = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_other = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(742, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "For informational purposes only. Consult your local medical authority for advice." &
    " (information from google)"
        '
        'RadioButton_other
        '
        Me.RadioButton_other.AutoSize = True
        Me.RadioButton_other.Location = New System.Drawing.Point(1102, 96)
        Me.RadioButton_other.Name = "RadioButton_other"
        Me.RadioButton_other.Size = New System.Drawing.Size(74, 24)
        Me.RadioButton_other.TabIndex = 45
        Me.RadioButton_other.Text = "Other"
        Me.RadioButton_other.UseVisualStyleBackColor = True
        '
        'RadioButton_causes
        '
        Me.RadioButton_causes.AutoSize = True
        Me.RadioButton_causes.Location = New System.Drawing.Point(880, 96)
        Me.RadioButton_causes.Name = "RadioButton_causes"
        Me.RadioButton_causes.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton_causes.TabIndex = 44
        Me.RadioButton_causes.Text = "Causes"
        Me.RadioButton_causes.UseVisualStyleBackColor = True
        '
        'RadioButton_treatment
        '
        Me.RadioButton_treatment.AutoSize = True
        Me.RadioButton_treatment.Location = New System.Drawing.Point(633, 96)
        Me.RadioButton_treatment.Name = "RadioButton_treatment"
        Me.RadioButton_treatment.Size = New System.Drawing.Size(116, 24)
        Me.RadioButton_treatment.TabIndex = 43
        Me.RadioButton_treatment.Text = "Treatement"
        Me.RadioButton_treatment.UseVisualStyleBackColor = True
        '
        'RadioButton_symptoms
        '
        Me.RadioButton_symptoms.AutoSize = True
        Me.RadioButton_symptoms.Location = New System.Drawing.Point(386, 96)
        Me.RadioButton_symptoms.Name = "RadioButton_symptoms"
        Me.RadioButton_symptoms.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton_symptoms.TabIndex = 42
        Me.RadioButton_symptoms.Text = "Symptoms"
        Me.RadioButton_symptoms.UseVisualStyleBackColor = True
        '
        'RadioButton_prevention
        '
        Me.RadioButton_prevention.AutoSize = True
        Me.RadioButton_prevention.Location = New System.Drawing.Point(180, 96)
        Me.RadioButton_prevention.Name = "RadioButton_prevention"
        Me.RadioButton_prevention.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton_prevention.TabIndex = 41
        Me.RadioButton_prevention.Text = "Prevention"
        Me.RadioButton_prevention.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cardiovascular"
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
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Controls.Add(Me.Button_cardi)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 536)
        Me.panelmenu.TabIndex = 39
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
        'Button_cardi
        '
        Me.Button_cardi.BackgroundImage = Global.Carecroft.My.Resources.Resources.Cardiovascular_disease
        Me.Button_cardi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cardi.FlatAppearance.BorderSize = 0
        Me.Button_cardi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cardi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cardi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_cardi.Location = New System.Drawing.Point(0, 81)
        Me.Button_cardi.Name = "Button_cardi"
        Me.Button_cardi.Size = New System.Drawing.Size(149, 452)
        Me.Button_cardi.TabIndex = 2
        Me.Button_cardi.Text = "Cardiovascular"
        Me.Button_cardi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_cardi.UseVisualStyleBackColor = True
        '
        'RichTextBox_overview
        '
        Me.RichTextBox_overview.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_overview.Name = "RichTextBox_overview"
        Me.RichTextBox_overview.ReadOnly = True
        Me.RichTextBox_overview.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_overview.TabIndex = 47
        Me.RichTextBox_overview.Text = resources.GetString("RichTextBox_overview.Text")
        '
        'RichTextBox_prevention
        '
        Me.RichTextBox_prevention.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_prevention.Name = "RichTextBox_prevention"
        Me.RichTextBox_prevention.ReadOnly = True
        Me.RichTextBox_prevention.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_prevention.TabIndex = 48
        Me.RichTextBox_prevention.Text = resources.GetString("RichTextBox_prevention.Text")
        '
        'RichTextBox_symptoms
        '
        Me.RichTextBox_symptoms.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_symptoms.Name = "RichTextBox_symptoms"
        Me.RichTextBox_symptoms.ReadOnly = True
        Me.RichTextBox_symptoms.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_symptoms.TabIndex = 49
        Me.RichTextBox_symptoms.Text = resources.GetString("RichTextBox_symptoms.Text")
        '
        'RichTextBox_treatment
        '
        Me.RichTextBox_treatment.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_treatment.Name = "RichTextBox_treatment"
        Me.RichTextBox_treatment.ReadOnly = True
        Me.RichTextBox_treatment.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_treatment.TabIndex = 50
        Me.RichTextBox_treatment.Text = resources.GetString("RichTextBox_treatment.Text")
        '
        'RichTextBox_Causes
        '
        Me.RichTextBox_Causes.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_Causes.Name = "RichTextBox_Causes"
        Me.RichTextBox_Causes.ReadOnly = True
        Me.RichTextBox_Causes.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_Causes.TabIndex = 51
        Me.RichTextBox_Causes.Text = resources.GetString("RichTextBox_Causes.Text")
        '
        'RichTextBox_other
        '
        Me.RichTextBox_other.Location = New System.Drawing.Point(146, 126)
        Me.RichTextBox_other.Name = "RichTextBox_other"
        Me.RichTextBox_other.ReadOnly = True
        Me.RichTextBox_other.Size = New System.Drawing.Size(1153, 387)
        Me.RichTextBox_other.TabIndex = 52
        Me.RichTextBox_other.Text = resources.GetString("RichTextBox_other.Text")
        '
        'Cardiovascular
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
        Me.Controls.Add(Me.RadioButton_other)
        Me.Controls.Add(Me.RadioButton_causes)
        Me.Controls.Add(Me.RadioButton_treatment)
        Me.Controls.Add(Me.RadioButton_symptoms)
        Me.Controls.Add(Me.RadioButton_prevention)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cardiovascular"
        Me.Text = "Cardiovascular"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton_other As RadioButton
    Friend WithEvents RadioButton_causes As RadioButton
    Friend WithEvents RadioButton_treatment As RadioButton
    Friend WithEvents RadioButton_symptoms As RadioButton
    Friend WithEvents RadioButton_prevention As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents panelmenu As Panel
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Button_cardi As Button
    Friend WithEvents RichTextBox_overview As RichTextBox
    Friend WithEvents RichTextBox_prevention As RichTextBox
    Friend WithEvents RichTextBox_symptoms As RichTextBox
    Friend WithEvents RichTextBox_treatment As RichTextBox
    Friend WithEvents RichTextBox_Causes As RichTextBox
    Friend WithEvents RichTextBox_other As RichTextBox
End Class
