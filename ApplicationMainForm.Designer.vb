<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationMainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RoundButton_treatment = New Carecroft.RoundButton()
        Me.RoundButton_hospital = New Carecroft.RoundButton()
        Me.RoundButton_lab = New Carecroft.RoundButton()
        Me.RoundButton_Appointment = New Carecroft.RoundButton()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 648)
        Me.panelmenu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(146, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 81)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
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
        'RoundButton_treatment
        '
        Me.RoundButton_treatment.BackgroundImage = Global.Carecroft.My.Resources.Resources.treatment
        Me.RoundButton_treatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton_treatment.Location = New System.Drawing.Point(152, 406)
        Me.RoundButton_treatment.Name = "RoundButton_treatment"
        Me.RoundButton_treatment.Size = New System.Drawing.Size(248, 242)
        Me.RoundButton_treatment.TabIndex = 5
        Me.RoundButton_treatment.Text = "Treatment"
        Me.RoundButton_treatment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RoundButton_treatment.UseVisualStyleBackColor = True
        '
        'RoundButton_hospital
        '
        Me.RoundButton_hospital.BackgroundImage = Global.Carecroft.My.Resources.Resources.hos
        Me.RoundButton_hospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton_hospital.Location = New System.Drawing.Point(742, 406)
        Me.RoundButton_hospital.Name = "RoundButton_hospital"
        Me.RoundButton_hospital.Size = New System.Drawing.Size(248, 242)
        Me.RoundButton_hospital.TabIndex = 4
        Me.RoundButton_hospital.Text = "Hospital"
        Me.RoundButton_hospital.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RoundButton_hospital.UseVisualStyleBackColor = True
        '
        'RoundButton_lab
        '
        Me.RoundButton_lab.BackgroundImage = Global.Carecroft.My.Resources.Resources.lab
        Me.RoundButton_lab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton_lab.Location = New System.Drawing.Point(450, 406)
        Me.RoundButton_lab.Name = "RoundButton_lab"
        Me.RoundButton_lab.Size = New System.Drawing.Size(248, 242)
        Me.RoundButton_lab.TabIndex = 3
        Me.RoundButton_lab.Text = "Labouratory"
        Me.RoundButton_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RoundButton_lab.UseVisualStyleBackColor = True
        '
        'RoundButton_Appointment
        '
        Me.RoundButton_Appointment.BackgroundImage = Global.Carecroft.My.Resources.Resources.book_appointment
        Me.RoundButton_Appointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton_Appointment.Location = New System.Drawing.Point(1050, 406)
        Me.RoundButton_Appointment.Name = "RoundButton_Appointment"
        Me.RoundButton_Appointment.Size = New System.Drawing.Size(248, 242)
        Me.RoundButton_Appointment.TabIndex = 2
        Me.RoundButton_Appointment.Text = "Appointment"
        Me.RoundButton_Appointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RoundButton_Appointment.UseVisualStyleBackColor = True
        '
        'RoundButton1
        '
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Image = Global.Carecroft.My.Resources.Resources.user
        Me.RoundButton1.Location = New System.Drawing.Point(0, 0)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(146, 113)
        Me.RoundButton1.TabIndex = 2
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Carecroft.My.Resources.Resources.logo
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(438, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 326)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Carecroft.My.Resources.Resources._2178_twitter_1200x600_animated1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(146, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1164, 326)
        Me.Panel2.TabIndex = 6
        '
        'ApplicationMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 648)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RoundButton_treatment)
        Me.Controls.Add(Me.RoundButton_hospital)
        Me.Controls.Add(Me.RoundButton_lab)
        Me.Controls.Add(Me.RoundButton_Appointment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ApplicationMainForm"
        Me.panelmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents RoundButton_Appointment As RoundButton
    Friend WithEvents RoundButton_lab As RoundButton
    Friend WithEvents RoundButton_hospital As RoundButton
    Friend WithEvents RoundButton_treatment As RoundButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
