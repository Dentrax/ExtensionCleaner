<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblSürüm = New System.Windows.Forms.Label()
        Me.lblTelifHakkı = New System.Windows.Forms.Label()
        Me.lblHaklar = New System.Windows.Forms.Label()
        Me.btnTamam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Location = New System.Drawing.Point(12, 9)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(13, 16)
        Me.lblProgram.TabIndex = 1
        Me.lblProgram.Text = "-"
        '
        'lblSürüm
        '
        Me.lblSürüm.AutoSize = True
        Me.lblSürüm.Location = New System.Drawing.Point(12, 39)
        Me.lblSürüm.Name = "lblSürüm"
        Me.lblSürüm.Size = New System.Drawing.Size(13, 16)
        Me.lblSürüm.TabIndex = 2
        Me.lblSürüm.Text = "-"
        '
        'lblTelifHakkı
        '
        Me.lblTelifHakkı.AutoSize = True
        Me.lblTelifHakkı.Location = New System.Drawing.Point(12, 69)
        Me.lblTelifHakkı.Name = "lblTelifHakkı"
        Me.lblTelifHakkı.Size = New System.Drawing.Size(13, 16)
        Me.lblTelifHakkı.TabIndex = 3
        Me.lblTelifHakkı.Text = "-"
        '
        'lblHaklar
        '
        Me.lblHaklar.AutoSize = True
        Me.lblHaklar.Location = New System.Drawing.Point(12, 99)
        Me.lblHaklar.Name = "lblHaklar"
        Me.lblHaklar.Size = New System.Drawing.Size(13, 16)
        Me.lblHaklar.TabIndex = 4
        Me.lblHaklar.Text = "-"
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(66, 129)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(75, 23)
        Me.btnTamam.TabIndex = 5
        Me.btnTamam.Text = "OK"
        Me.btnTamam.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(234, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTamam)
        Me.Controls.Add(Me.lblHaklar)
        Me.Controls.Add(Me.lblTelifHakkı)
        Me.Controls.Add(Me.lblSürüm)
        Me.Controls.Add(Me.lblProgram)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblSürüm As System.Windows.Forms.Label
    Friend WithEvents lblTelifHakkı As System.Windows.Forms.Label
    Friend WithEvents lblHaklar As System.Windows.Forms.Label
    Friend WithEvents btnTamam As System.Windows.Forms.Button
End Class
