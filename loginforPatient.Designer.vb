<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginforPatient
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.Labelgotosignup = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxusername = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.panelmenu)
        Me.Panel1.Controls.Add(Me.Labelgotosignup)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBoxpassword)
        Me.Panel1.Controls.Add(Me.TextBoxusername)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1293, 661)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Carecroft.My.Resources.Resources.patients_
        Me.PictureBox1.Location = New System.Drawing.Point(270, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 379)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(212, 661)
        Me.panelmenu.TabIndex = 18
        '
        'Labelgotosignup
        '
        Me.Labelgotosignup.AutoSize = True
        Me.Labelgotosignup.Location = New System.Drawing.Point(770, 424)
        Me.Labelgotosignup.Name = "Labelgotosignup"
        Me.Labelgotosignup.Size = New System.Drawing.Size(120, 20)
        Me.Labelgotosignup.TabIndex = 6
        Me.Labelgotosignup.Text = "Create Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(580, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(747, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(707, 277)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxpassword.TabIndex = 2
        '
        'TextBoxusername
        '
        Me.TextBoxusername.Location = New System.Drawing.Point(707, 221)
        Me.TextBoxusername.Name = "TextBoxusername"
        Me.TextBoxusername.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxusername.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 100)
        Me.Panel2.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(473, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(308, 40)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Login For Patient"
        '
        'loginforPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 671)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginforPatient"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Labelgotosignup As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents panelmenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
