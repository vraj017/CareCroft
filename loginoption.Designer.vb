<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginoption
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Buttonclose = New System.Windows.Forms.Button()
        Me.loginfordoctor = New Carecroft.RoundButton()
        Me.loginforpatient = New Carecroft.RoundButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(212, 652)
        Me.panelmenu.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Buttonclose)
        Me.Panel2.Location = New System.Drawing.Point(-142, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1335, 100)
        Me.Panel2.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(729, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 40)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Login"
        '
        'Buttonclose
        '
        Me.Buttonclose.BackColor = System.Drawing.Color.Red
        Me.Buttonclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonclose.FlatAppearance.BorderSize = 0
        Me.Buttonclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonclose.Location = New System.Drawing.Point(1225, -4)
        Me.Buttonclose.Name = "Buttonclose"
        Me.Buttonclose.Size = New System.Drawing.Size(110, 104)
        Me.Buttonclose.TabIndex = 0
        Me.Buttonclose.Text = "X"
        Me.Buttonclose.UseVisualStyleBackColor = False
        '
        'loginfordoctor
        '
        Me.loginfordoctor.BackColor = System.Drawing.Color.LightSkyBlue
        Me.loginfordoctor.BackgroundImage = Global.Carecroft.My.Resources.Resources.doctor
        Me.loginfordoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginfordoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginfordoctor.Location = New System.Drawing.Point(252, 216)
        Me.loginfordoctor.Name = "loginfordoctor"
        Me.loginfordoctor.Size = New System.Drawing.Size(379, 226)
        Me.loginfordoctor.TabIndex = 21
        Me.loginfordoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loginfordoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginfordoctor.UseVisualStyleBackColor = False
        '
        'loginforpatient
        '
        Me.loginforpatient.BackgroundImage = Global.Carecroft.My.Resources.Resources.patients_
        Me.loginforpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginforpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginforpatient.Location = New System.Drawing.Point(785, 216)
        Me.loginforpatient.Name = "loginforpatient"
        Me.loginforpatient.Size = New System.Drawing.Size(379, 221)
        Me.loginforpatient.TabIndex = 22
        Me.loginforpatient.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(409, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Doctor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(942, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Patient"
        '
        'loginoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 652)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginforpatient)
        Me.Controls.Add(Me.loginfordoctor)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginoption"
        Me.Text = "loginoption"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Buttonclose As Button
    Friend WithEvents loginfordoctor As RoundButton
    Friend WithEvents loginforpatient As RoundButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
