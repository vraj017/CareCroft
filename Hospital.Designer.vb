<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospital
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
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.Panel_lab = New System.Windows.Forms.Panel()
        Me.Panel_treatment = New System.Windows.Forms.Panel()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Panel_hospital = New System.Windows.Forms.Panel()
        Me.btn_Hospital = New System.Windows.Forms.Button()
        Me.btn_Labouratory = New System.Windows.Forms.Button()
        Me.btn_Treatment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.panelmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.Panel_lab)
        Me.panelmenu.Controls.Add(Me.Panel_treatment)
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Controls.Add(Me.Panel_hospital)
        Me.panelmenu.Controls.Add(Me.btn_Hospital)
        Me.panelmenu.Controls.Add(Me.btn_Labouratory)
        Me.panelmenu.Controls.Add(Me.btn_Treatment)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 1080)
        Me.panelmenu.TabIndex = 3
        '
        'Panel_lab
        '
        Me.Panel_lab.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_lab.Location = New System.Drawing.Point(0, 447)
        Me.Panel_lab.Name = "Panel_lab"
        Me.Panel_lab.Size = New System.Drawing.Size(14, 334)
        Me.Panel_lab.TabIndex = 14
        '
        'Panel_treatment
        '
        Me.Panel_treatment.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_treatment.Location = New System.Drawing.Point(0, 96)
        Me.Panel_treatment.Name = "Panel_treatment"
        Me.Panel_treatment.Size = New System.Drawing.Size(14, 321)
        Me.Panel_treatment.TabIndex = 8
        '
        'RoundButton1
        '
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Image = Global.Carecroft.My.Resources.Resources.user
        Me.RoundButton1.Location = New System.Drawing.Point(0, 0)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(150, 81)
        Me.RoundButton1.TabIndex = 2
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'Panel_hospital
        '
        Me.Panel_hospital.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_hospital.Location = New System.Drawing.Point(0, 807)
        Me.Panel_hospital.Name = "Panel_hospital"
        Me.Panel_hospital.Size = New System.Drawing.Size(14, 273)
        Me.Panel_hospital.TabIndex = 13
        '
        'btn_Hospital
        '
        Me.btn_Hospital.FlatAppearance.BorderSize = 0
        Me.btn_Hospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Hospital.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Hospital.Location = New System.Drawing.Point(0, 807)
        Me.btn_Hospital.Name = "btn_Hospital"
        Me.btn_Hospital.Size = New System.Drawing.Size(147, 270)
        Me.btn_Hospital.TabIndex = 16
        Me.btn_Hospital.Text = "Hospital"
        Me.btn_Hospital.UseVisualStyleBackColor = True
        '
        'btn_Labouratory
        '
        Me.btn_Labouratory.FlatAppearance.BorderSize = 0
        Me.btn_Labouratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Labouratory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Labouratory.Location = New System.Drawing.Point(3, 447)
        Me.btn_Labouratory.Name = "btn_Labouratory"
        Me.btn_Labouratory.Size = New System.Drawing.Size(147, 334)
        Me.btn_Labouratory.TabIndex = 7
        Me.btn_Labouratory.Text = "Labouratory"
        Me.btn_Labouratory.UseVisualStyleBackColor = True
        '
        'btn_Treatment
        '
        Me.btn_Treatment.FlatAppearance.BorderSize = 0
        Me.btn_Treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Treatment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Treatment.Location = New System.Drawing.Point(0, 96)
        Me.btn_Treatment.Name = "btn_Treatment"
        Me.btn_Treatment.Size = New System.Drawing.Size(147, 321)
        Me.btn_Treatment.TabIndex = 6
        Me.btn_Treatment.Text = "Treatment"
        Me.btn_Treatment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1687, 0)
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
        Me.Panel1.Size = New System.Drawing.Size(1774, 81)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(639, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hospital"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(146, 81)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1774, 999)
        Me.WebBrowser1.TabIndex = 5
        '
        'Hospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hospital"
        Me.Text = "Hospital"
        Me.panelmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents panelmenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_hospital As Panel
    Friend WithEvents btn_Hospital As Button
    Friend WithEvents Panel_treatment As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel_lab As Panel
    Friend WithEvents btn_Labouratory As Button
    Friend WithEvents btn_Treatment As Button
    Friend WithEvents Label1 As Label
End Class
