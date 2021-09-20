<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Treatment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel_hospital = New System.Windows.Forms.Panel()
        Me.Panel_lab = New System.Windows.Forms.Panel()
        Me.Panel_treatment = New System.Windows.Forms.Panel()
        Me.btn_Labouratory = New System.Windows.Forms.Button()
        Me.btn_Treatment = New System.Windows.Forms.Button()
        Me.btn_Hospital = New System.Windows.Forms.Button()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_more_dis = New System.Windows.Forms.Label()
        Me.influenza_btn = New Carecroft.RoundButton()
        Me.car_btn = New Carecroft.RoundButton()
        Me.diab_btn = New Carecroft.RoundButton()
        Me.tb_btn = New Carecroft.RoundButton()
        Me.dengue_btn = New Carecroft.RoundButton()
        Me.maleria_btn = New Carecroft.RoundButton()
        Me.Button_more_disease = New System.Windows.Forms.Button()
        Me.panelmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_hospital
        '
        Me.Panel_hospital.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_hospital.Location = New System.Drawing.Point(-5, 427)
        Me.Panel_hospital.Name = "Panel_hospital"
        Me.Panel_hospital.Size = New System.Drawing.Size(25, 165)
        Me.Panel_hospital.TabIndex = 3
        '
        'Panel_lab
        '
        Me.Panel_lab.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_lab.Location = New System.Drawing.Point(0, 251)
        Me.Panel_lab.Name = "Panel_lab"
        Me.Panel_lab.Size = New System.Drawing.Size(17, 155)
        Me.Panel_lab.TabIndex = 3
        '
        'Panel_treatment
        '
        Me.Panel_treatment.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_treatment.Location = New System.Drawing.Point(0, 108)
        Me.Panel_treatment.Name = "Panel_treatment"
        Me.Panel_treatment.Size = New System.Drawing.Size(20, 128)
        Me.Panel_treatment.TabIndex = 2
        '
        'btn_Labouratory
        '
        Me.btn_Labouratory.FlatAppearance.BorderSize = 0
        Me.btn_Labouratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Labouratory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Labouratory.Location = New System.Drawing.Point(3, 251)
        Me.btn_Labouratory.Name = "btn_Labouratory"
        Me.btn_Labouratory.Size = New System.Drawing.Size(146, 155)
        Me.btn_Labouratory.TabIndex = 3
        Me.btn_Labouratory.Text = "Labouratory"
        Me.btn_Labouratory.UseVisualStyleBackColor = True
        '
        'btn_Treatment
        '
        Me.btn_Treatment.FlatAppearance.BorderSize = 0
        Me.btn_Treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Treatment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Treatment.Location = New System.Drawing.Point(3, 108)
        Me.btn_Treatment.Name = "btn_Treatment"
        Me.btn_Treatment.Size = New System.Drawing.Size(146, 128)
        Me.btn_Treatment.TabIndex = 2
        Me.btn_Treatment.Text = "Treatment"
        Me.btn_Treatment.UseVisualStyleBackColor = True
        '
        'btn_Hospital
        '
        Me.btn_Hospital.FlatAppearance.BorderSize = 0
        Me.btn_Hospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Hospital.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Hospital.Location = New System.Drawing.Point(0, 427)
        Me.btn_Hospital.Name = "btn_Hospital"
        Me.btn_Hospital.Size = New System.Drawing.Size(146, 165)
        Me.btn_Hospital.TabIndex = 4
        Me.btn_Hospital.Text = "Hospital"
        Me.btn_Hospital.UseVisualStyleBackColor = True
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.Panel_hospital)
        Me.panelmenu.Controls.Add(Me.Panel_lab)
        Me.panelmenu.Controls.Add(Me.Panel_treatment)
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Controls.Add(Me.btn_Labouratory)
        Me.panelmenu.Controls.Add(Me.btn_Treatment)
        Me.panelmenu.Controls.Add(Me.btn_Hospital)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 592)
        Me.panelmenu.TabIndex = 1
        '
        'RoundButton1
        '
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Image = Global.Carecroft.My.Resources.Resources.user
        Me.RoundButton1.Location = New System.Drawing.Point(0, 0)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(146, 102)
        Me.RoundButton1.TabIndex = 2
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1072, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(146, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 81)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Treatment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_more_dis
        '
        Me.Label_more_dis.AutoSize = True
        Me.Label_more_dis.Location = New System.Drawing.Point(505, 563)
        Me.Label_more_dis.Name = "Label_more_dis"
        Me.Label_more_dis.Size = New System.Drawing.Size(139, 20)
        Me.Label_more_dis.TabIndex = 5
        Me.Label_more_dis.Text = "For more Disease:"
        '
        'influenza_btn
        '
        Me.influenza_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.influenza
        Me.influenza_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.influenza_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.influenza_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.influenza_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.influenza_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.influenza_btn.Location = New System.Drawing.Point(909, 333)
        Me.influenza_btn.Name = "influenza_btn"
        Me.influenza_btn.Size = New System.Drawing.Size(244, 158)
        Me.influenza_btn.TabIndex = 11
        Me.influenza_btn.Text = "influenza"
        Me.influenza_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.influenza_btn.UseVisualStyleBackColor = True
        '
        'car_btn
        '
        Me.car_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.Cardiovascular_disease
        Me.car_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.car_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.car_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.car_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car_btn.Location = New System.Drawing.Point(573, 332)
        Me.car_btn.Name = "car_btn"
        Me.car_btn.Size = New System.Drawing.Size(244, 158)
        Me.car_btn.TabIndex = 10
        Me.car_btn.Text = "Cardiovascular disease"
        Me.car_btn.UseVisualStyleBackColor = True
        '
        'diab_btn
        '
        Me.diab_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.diabites
        Me.diab_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.diab_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.diab_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.diab_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diab_btn.Location = New System.Drawing.Point(235, 334)
        Me.diab_btn.Name = "diab_btn"
        Me.diab_btn.Size = New System.Drawing.Size(244, 158)
        Me.diab_btn.TabIndex = 9
        Me.diab_btn.Text = "Diabetes"
        Me.diab_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.diab_btn.UseVisualStyleBackColor = True
        '
        'tb_btn
        '
        Me.tb_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.tb
        Me.tb_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tb_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_btn.Location = New System.Drawing.Point(909, 123)
        Me.tb_btn.Name = "tb_btn"
        Me.tb_btn.Size = New System.Drawing.Size(244, 158)
        Me.tb_btn.TabIndex = 8
        Me.tb_btn.Text = "Tuberculosis"
        Me.tb_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tb_btn.UseVisualStyleBackColor = True
        '
        'dengue_btn
        '
        Me.dengue_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.dengue
        Me.dengue_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dengue_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dengue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dengue_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dengue_btn.Location = New System.Drawing.Point(577, 123)
        Me.dengue_btn.Name = "dengue_btn"
        Me.dengue_btn.Size = New System.Drawing.Size(244, 158)
        Me.dengue_btn.TabIndex = 7
        Me.dengue_btn.Text = "Dengue"
        Me.dengue_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.dengue_btn.UseVisualStyleBackColor = True
        '
        'maleria_btn
        '
        Me.maleria_btn.BackgroundImage = Global.Carecroft.My.Resources.Resources.maleria_image
        Me.maleria_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.maleria_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maleria_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maleria_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleria_btn.Location = New System.Drawing.Point(235, 123)
        Me.maleria_btn.Name = "maleria_btn"
        Me.maleria_btn.Size = New System.Drawing.Size(244, 158)
        Me.maleria_btn.TabIndex = 6
        Me.maleria_btn.Text = "Maleria"
        Me.maleria_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.maleria_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.maleria_btn.UseVisualStyleBackColor = True
        '
        'Button_more_disease
        '
        Me.Button_more_disease.Location = New System.Drawing.Point(650, 554)
        Me.Button_more_disease.Name = "Button_more_disease"
        Me.Button_more_disease.Size = New System.Drawing.Size(128, 31)
        Me.Button_more_disease.TabIndex = 12
        Me.Button_more_disease.Text = "Click Here"
        Me.Button_more_disease.UseVisualStyleBackColor = True
        '
        'Treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 592)
        Me.Controls.Add(Me.Button_more_disease)
        Me.Controls.Add(Me.influenza_btn)
        Me.Controls.Add(Me.car_btn)
        Me.Controls.Add(Me.diab_btn)
        Me.Controls.Add(Me.tb_btn)
        Me.Controls.Add(Me.dengue_btn)
        Me.Controls.Add(Me.maleria_btn)
        Me.Controls.Add(Me.Label_more_dis)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Treatment"
        Me.Text = "Treatment"
        Me.panelmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_hospital As Panel
    Friend WithEvents Panel_lab As Panel
    Friend WithEvents Panel_treatment As Panel
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents btn_Labouratory As Button
    Friend WithEvents btn_Treatment As Button
    Friend WithEvents btn_Hospital As Button
    Friend WithEvents panelmenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_more_dis As Label
    Friend WithEvents maleria_btn As RoundButton
    Friend WithEvents dengue_btn As RoundButton
    Friend WithEvents tb_btn As RoundButton
    Friend WithEvents diab_btn As RoundButton
    Friend WithEvents car_btn As RoundButton
    Friend WithEvents influenza_btn As RoundButton
    Friend WithEvents Button_more_disease As Button
End Class
