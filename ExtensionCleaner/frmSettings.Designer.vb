<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.ttAçıklama = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTamam = New System.Windows.Forms.Button()
        Me.chkSimgeDurumu = New System.Windows.Forms.CheckBox()
        Me.chkKaydet = New System.Windows.Forms.CheckBox()
        Me.chkAkıllıTemizle = New System.Windows.Forms.CheckBox()
        Me.chkDurumBilgi = New System.Windows.Forms.CheckBox()
        Me.chkOtoTemizle = New System.Windows.Forms.CheckBox()
        Me.chkİçerik = New System.Windows.Forms.CheckBox()
        Me.chkBildirim = New System.Windows.Forms.CheckBox()
        Me.gbAyarlar = New System.Windows.Forms.GroupBox()
        Me.gbAyarlar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttAçıklama
        '
        Me.ttAçıklama.AutomaticDelay = 250
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(86, 220)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(75, 23)
        Me.btnTamam.TabIndex = 0
        Me.btnTamam.Text = "OK"
        Me.ttAçıklama.SetToolTip(Me.btnTamam, "Tamam")
        Me.btnTamam.UseVisualStyleBackColor = True
        '
        'chkSimgeDurumu
        '
        Me.chkSimgeDurumu.AutoSize = True
        Me.chkSimgeDurumu.Location = New System.Drawing.Point(6, 126)
        Me.chkSimgeDurumu.Name = "chkSimgeDurumu"
        Me.chkSimgeDurumu.Size = New System.Drawing.Size(115, 20)
        Me.chkSimgeDurumu.TabIndex = 3
        Me.chkSimgeDurumu.Text = "Minimize dialog"
        Me.ttAçıklama.SetToolTip(Me.chkSimgeDurumu, "Program kapatıldığında otomatik olarak simge durumuna küçüldür.")
        Me.chkSimgeDurumu.UseVisualStyleBackColor = True
        '
        'chkKaydet
        '
        Me.chkKaydet.AutoSize = True
        Me.chkKaydet.Enabled = False
        Me.chkKaydet.Location = New System.Drawing.Point(6, 178)
        Me.chkKaydet.Name = "chkKaydet"
        Me.chkKaydet.Size = New System.Drawing.Size(182, 20)
        Me.chkKaydet.TabIndex = 2
        Me.chkKaydet.Text = "Save settings automatically"
        Me.ttAçıklama.SetToolTip(Me.chkKaydet, "Ayarları otomatik olarak kaydet.")
        Me.chkKaydet.UseVisualStyleBackColor = True
        '
        'chkAkıllıTemizle
        '
        Me.chkAkıllıTemizle.AutoSize = True
        Me.chkAkıllıTemizle.Checked = True
        Me.chkAkıllıTemizle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAkıllıTemizle.Location = New System.Drawing.Point(6, 100)
        Me.chkAkıllıTemizle.Name = "chkAkıllıTemizle"
        Me.chkAkıllıTemizle.Size = New System.Drawing.Size(110, 20)
        Me.chkAkıllıTemizle.TabIndex = 2
        Me.chkAkıllıTemizle.Text = "Smart Cleaner"
        Me.ttAçıklama.SetToolTip(Me.chkAkıllıTemizle, "Gizli dosyalar ile birlikte dosyaları yok eder.")
        Me.chkAkıllıTemizle.UseVisualStyleBackColor = True
        '
        'chkDurumBilgi
        '
        Me.chkDurumBilgi.AutoSize = True
        Me.chkDurumBilgi.Checked = True
        Me.chkDurumBilgi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDurumBilgi.Location = New System.Drawing.Point(6, 74)
        Me.chkDurumBilgi.Name = "chkDurumBilgi"
        Me.chkDurumBilgi.Size = New System.Drawing.Size(197, 20)
        Me.chkDurumBilgi.TabIndex = 2
        Me.chkDurumBilgi.Text = "Show details in the status bar"
        Me.ttAçıklama.SetToolTip(Me.chkDurumBilgi, "Durum çubuğu toplam dosyalar hakkında bilgi verir.")
        Me.chkDurumBilgi.UseVisualStyleBackColor = True
        '
        'chkOtoTemizle
        '
        Me.chkOtoTemizle.AutoSize = True
        Me.chkOtoTemizle.Location = New System.Drawing.Point(6, 48)
        Me.chkOtoTemizle.Name = "chkOtoTemizle"
        Me.chkOtoTemizle.Size = New System.Drawing.Size(144, 20)
        Me.chkOtoTemizle.TabIndex = 2
        Me.chkOtoTemizle.Text = "Enable Auto-Cleaner"
        Me.ttAçıklama.SetToolTip(Me.chkOtoTemizle, "Her 5 dakikada bir otomatik olarak .DMP dosyaları temizlenir.")
        Me.chkOtoTemizle.UseVisualStyleBackColor = True
        '
        'chkİçerik
        '
        Me.chkİçerik.AutoSize = True
        Me.chkİçerik.Enabled = False
        Me.chkİçerik.Location = New System.Drawing.Point(6, 22)
        Me.chkİçerik.Name = "chkİçerik"
        Me.chkİçerik.Size = New System.Drawing.Size(148, 20)
        Me.chkİçerik.TabIndex = 2
        Me.chkİçerik.Text = "Use 'Content' System"
        Me.ttAçıklama.SetToolTip(Me.chkİçerik, "İçerik sistemini kullanın.")
        Me.chkİçerik.UseVisualStyleBackColor = True
        '
        'chkBildirim
        '
        Me.chkBildirim.AutoSize = True
        Me.chkBildirim.Checked = True
        Me.chkBildirim.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBildirim.Location = New System.Drawing.Point(6, 152)
        Me.chkBildirim.Name = "chkBildirim"
        Me.chkBildirim.Size = New System.Drawing.Size(143, 20)
        Me.chkBildirim.TabIndex = 4
        Me.chkBildirim.Text = "User notification box"
        Me.ttAçıklama.SetToolTip(Me.chkBildirim, "Bir işlem yapıldığında bildirim kutusu gösterilir.")
        Me.chkBildirim.UseVisualStyleBackColor = True
        '
        'gbAyarlar
        '
        Me.gbAyarlar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbAyarlar.Controls.Add(Me.chkBildirim)
        Me.gbAyarlar.Controls.Add(Me.chkSimgeDurumu)
        Me.gbAyarlar.Controls.Add(Me.chkKaydet)
        Me.gbAyarlar.Controls.Add(Me.chkAkıllıTemizle)
        Me.gbAyarlar.Controls.Add(Me.chkDurumBilgi)
        Me.gbAyarlar.Controls.Add(Me.chkOtoTemizle)
        Me.gbAyarlar.Controls.Add(Me.chkİçerik)
        Me.gbAyarlar.Location = New System.Drawing.Point(12, 12)
        Me.gbAyarlar.Name = "gbAyarlar"
        Me.gbAyarlar.Size = New System.Drawing.Size(236, 202)
        Me.gbAyarlar.TabIndex = 1
        Me.gbAyarlar.TabStop = False
        Me.gbAyarlar.Text = "Settings"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(260, 250)
        Me.Controls.Add(Me.gbAyarlar)
        Me.Controls.Add(Me.btnTamam)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Opacity = 0.85R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.gbAyarlar.ResumeLayout(False)
        Me.gbAyarlar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ttAçıklama As System.Windows.Forms.ToolTip
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents gbAyarlar As System.Windows.Forms.GroupBox
    Friend WithEvents chkOtoTemizle As System.Windows.Forms.CheckBox
    Friend WithEvents chkİçerik As System.Windows.Forms.CheckBox
    Friend WithEvents chkSimgeDurumu As System.Windows.Forms.CheckBox
    Friend WithEvents chkKaydet As System.Windows.Forms.CheckBox
    Friend WithEvents chkAkıllıTemizle As System.Windows.Forms.CheckBox
    Friend WithEvents chkDurumBilgi As System.Windows.Forms.CheckBox
    Friend WithEvents chkBildirim As System.Windows.Forms.CheckBox
End Class
