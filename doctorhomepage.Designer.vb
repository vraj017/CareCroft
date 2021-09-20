<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctorhomepage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RoundButton1 = New Carecroft.RoundButton()
        Me.Panel1.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(146, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 81)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(757, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.panelmenu.Controls.Add(Me.RoundButton1)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(146, 567)
        Me.panelmenu.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(146, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(844, 490)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "booked appointment"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RoundButton1
        '
        Me.RoundButton1.BackgroundImage = Global.Carecroft.My.Resources.Resources.doctor1
        Me.RoundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Location = New System.Drawing.Point(0, 0)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(146, 145)
        Me.RoundButton1.TabIndex = 2
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'doctorhomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 567)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "doctorhomepage"
        Me.Text = "doctorhomepage"
        Me.Panel1.ResumeLayout(False)
        Me.panelmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents panelmenu As Panel
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Button2 As Button
End Class
