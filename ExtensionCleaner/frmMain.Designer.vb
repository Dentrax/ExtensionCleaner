<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lvDosyalar = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDosyaAdı = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDosyaYolu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBoyut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTür = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ttAçıklama = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnListele = New System.Windows.Forms.Button()
        Me.btnListeSil = New System.Windows.Forms.Button()
        Me.lbContains = New System.Windows.Forms.ListBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnKaldır = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.btnTamam = New System.Windows.Forms.Button()
        Me.txtKelime = New System.Windows.Forms.TextBox()
        Me.gbİçerik = New System.Windows.Forms.GroupBox()
        Me.lblSonrakiTemizlik = New System.Windows.Forms.Label()
        Me.lblSonrakiTemizlikSn = New System.Windows.Forms.Label()
        Me.btnAutoDurdur = New System.Windows.Forms.Button()
        Me.tsMenü = New System.Windows.Forms.ToolStrip()
        Me.ttÜstte = New System.Windows.Forms.ToolStripButton()
        Me.ttAyırıcı1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttDosyaYolu = New System.Windows.Forms.ToolStripButton()
        Me.ttAyırıcı2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttAyarlar = New System.Windows.Forms.ToolStripButton()
        Me.ttAyırıcı3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttHakkında = New System.Windows.Forms.ToolStripButton()
        Me.ssLog = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMenüÜst = New System.Windows.Forms.MenuStrip()
        Me.ttDosya = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttHakkında2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttÇıkış = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrHazır = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAuto = New System.Windows.Forms.Timer(Me.components)
        Me.NIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gbExtension = New System.Windows.Forms.GroupBox()
        Me.cbAnalyzeExtension = New System.Windows.Forms.ComboBox()
        Me.lblAnalyzeExtension = New System.Windows.Forms.Label()
        Me.gbİçerik.SuspendLayout()
        Me.tsMenü.SuspendLayout()
        Me.ssLog.SuspendLayout()
        Me.tsMenüÜst.SuspendLayout()
        Me.gbExtension.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDosyalar
        '
        Me.lvDosyalar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colDosyaAdı, Me.colDosyaYolu, Me.colBoyut, Me.colTür})
        Me.lvDosyalar.Location = New System.Drawing.Point(12, 53)
        Me.lvDosyalar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvDosyalar.Name = "lvDosyalar"
        Me.lvDosyalar.Size = New System.Drawing.Size(620, 134)
        Me.lvDosyalar.TabIndex = 1
        Me.ttAçıklama.SetToolTip(Me.lvDosyalar, "Files")
        Me.lvDosyalar.UseCompatibleStateImageBehavior = False
        Me.lvDosyalar.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "#"
        Me.colID.Width = 50
        '
        'colDosyaAdı
        '
        Me.colDosyaAdı.Text = "File Name"
        Me.colDosyaAdı.Width = 150
        '
        'colDosyaYolu
        '
        Me.colDosyaYolu.Text = "File Path"
        Me.colDosyaYolu.Width = 100
        '
        'colBoyut
        '
        Me.colBoyut.Text = "File Size"
        Me.colBoyut.Width = 100
        '
        'colTür
        '
        Me.colTür.Text = "File Type"
        Me.colTür.Width = 100
        '
        'ttAçıklama
        '
        Me.ttAçıklama.AutomaticDelay = 250
        '
        'btnListele
        '
        Me.btnListele.Location = New System.Drawing.Point(476, 194)
        Me.btnListele.Name = "btnListele"
        Me.btnListele.Size = New System.Drawing.Size(75, 23)
        Me.btnListele.TabIndex = 6
        Me.btnListele.Text = "List"
        Me.ttAçıklama.SetToolTip(Me.btnListele, "Dosyaları listeler.")
        Me.btnListele.UseVisualStyleBackColor = True
        '
        'btnListeSil
        '
        Me.btnListeSil.Location = New System.Drawing.Point(557, 194)
        Me.btnListeSil.Name = "btnListeSil"
        Me.btnListeSil.Size = New System.Drawing.Size(75, 23)
        Me.btnListeSil.TabIndex = 7
        Me.btnListeSil.Text = "Delete All"
        Me.ttAçıklama.SetToolTip(Me.btnListeSil, "Hepsini siler.")
        Me.btnListeSil.UseVisualStyleBackColor = True
        '
        'lbContains
        '
        Me.lbContains.FormattingEnabled = True
        Me.lbContains.ItemHeight = 16
        Me.lbContains.Items.AddRange(New Object() {"fatal", "log", "error", "filter", "..."})
        Me.lbContains.Location = New System.Drawing.Point(6, 22)
        Me.lbContains.Name = "lbContains"
        Me.lbContains.Size = New System.Drawing.Size(120, 116)
        Me.lbContains.TabIndex = 9
        Me.ttAçıklama.SetToolTip(Me.lbContains, "Listelenecek ve silinecek dosyalar, bu kelimeleri içeriyorsa siler.")
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(132, 51)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(25, 23)
        Me.btnEkle.TabIndex = 10
        Me.btnEkle.Text = "<"
        Me.ttAçıklama.SetToolTip(Me.btnEkle, "Kelimeyi ekle.")
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'btnKaldır
        '
        Me.btnKaldır.Location = New System.Drawing.Point(182, 51)
        Me.btnKaldır.Name = "btnKaldır"
        Me.btnKaldır.Size = New System.Drawing.Size(25, 23)
        Me.btnKaldır.TabIndex = 11
        Me.btnKaldır.Text = ">"
        Me.ttAçıklama.SetToolTip(Me.btnKaldır, "Kelimeyi kaldır.")
        Me.btnKaldır.UseVisualStyleBackColor = True
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(132, 83)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(75, 23)
        Me.btnTemizle.TabIndex = 12
        Me.btnTemizle.Text = "Clean"
        Me.ttAçıklama.SetToolTip(Me.btnTemizle, "Listeyi temizler.")
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(132, 115)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(75, 23)
        Me.btnTamam.TabIndex = 13
        Me.btnTamam.Text = "OK"
        Me.ttAçıklama.SetToolTip(Me.btnTamam, "Kelimeleri güncelle.")
        Me.btnTamam.UseVisualStyleBackColor = True
        '
        'txtKelime
        '
        Me.txtKelime.Location = New System.Drawing.Point(132, 22)
        Me.txtKelime.Name = "txtKelime"
        Me.txtKelime.Size = New System.Drawing.Size(75, 23)
        Me.txtKelime.TabIndex = 8
        Me.ttAçıklama.SetToolTip(Me.txtKelime, "Eklenecek kelime.")
        '
        'gbİçerik
        '
        Me.gbİçerik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbİçerik.Controls.Add(Me.lbContains)
        Me.gbİçerik.Controls.Add(Me.btnTamam)
        Me.gbİçerik.Controls.Add(Me.txtKelime)
        Me.gbİçerik.Controls.Add(Me.btnTemizle)
        Me.gbİçerik.Controls.Add(Me.btnEkle)
        Me.gbİçerik.Controls.Add(Me.btnKaldır)
        Me.gbİçerik.Enabled = False
        Me.gbİçerik.Location = New System.Drawing.Point(12, 194)
        Me.gbİçerik.Name = "gbİçerik"
        Me.gbİçerik.Size = New System.Drawing.Size(223, 154)
        Me.gbİçerik.TabIndex = 14
        Me.gbİçerik.TabStop = False
        Me.gbİçerik.Text = "Content"
        Me.ttAçıklama.SetToolTip(Me.gbİçerik, "İçeriği ayarlar.")
        '
        'lblSonrakiTemizlik
        '
        Me.lblSonrakiTemizlik.AutoSize = True
        Me.lblSonrakiTemizlik.Location = New System.Drawing.Point(477, 332)
        Me.lblSonrakiTemizlik.Name = "lblSonrakiTemizlik"
        Me.lblSonrakiTemizlik.Size = New System.Drawing.Size(120, 16)
        Me.lblSonrakiTemizlik.TabIndex = 15
        Me.lblSonrakiTemizlik.Text = "Next auto clean-up:"
        Me.ttAçıklama.SetToolTip(Me.lblSonrakiTemizlik, "Sonraki temizleme.")
        Me.lblSonrakiTemizlik.Visible = False
        '
        'lblSonrakiTemizlikSn
        '
        Me.lblSonrakiTemizlikSn.AutoSize = True
        Me.lblSonrakiTemizlikSn.ForeColor = System.Drawing.Color.Red
        Me.lblSonrakiTemizlikSn.Location = New System.Drawing.Point(603, 332)
        Me.lblSonrakiTemizlikSn.Name = "lblSonrakiTemizlikSn"
        Me.lblSonrakiTemizlikSn.Size = New System.Drawing.Size(29, 16)
        Me.lblSonrakiTemizlikSn.TabIndex = 16
        Me.lblSonrakiTemizlikSn.Text = "300"
        Me.ttAçıklama.SetToolTip(Me.lblSonrakiTemizlikSn, "Kalan süre.")
        Me.lblSonrakiTemizlikSn.Visible = False
        '
        'btnAutoDurdur
        '
        Me.btnAutoDurdur.Location = New System.Drawing.Point(557, 223)
        Me.btnAutoDurdur.Name = "btnAutoDurdur"
        Me.btnAutoDurdur.Size = New System.Drawing.Size(75, 23)
        Me.btnAutoDurdur.TabIndex = 17
        Me.btnAutoDurdur.Text = "Stop"
        Me.ttAçıklama.SetToolTip(Me.btnAutoDurdur, "Otomatik temizliği durdur.")
        Me.btnAutoDurdur.UseVisualStyleBackColor = True
        Me.btnAutoDurdur.Visible = False
        '
        'tsMenü
        '
        Me.tsMenü.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttÜstte, Me.ttAyırıcı1, Me.ttDosyaYolu, Me.ttAyırıcı2, Me.ttAyarlar, Me.ttAyırıcı3, Me.ttHakkında})
        Me.tsMenü.Location = New System.Drawing.Point(0, 24)
        Me.tsMenü.Name = "tsMenü"
        Me.tsMenü.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsMenü.Size = New System.Drawing.Size(644, 25)
        Me.tsMenü.TabIndex = 3
        Me.tsMenü.Text = "Menü"
        '
        'ttÜstte
        '
        Me.ttÜstte.Checked = True
        Me.ttÜstte.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ttÜstte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttÜstte.Image = CType(resources.GetObject("ttÜstte.Image"), System.Drawing.Image)
        Me.ttÜstte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttÜstte.Name = "ttÜstte"
        Me.ttÜstte.Size = New System.Drawing.Size(23, 22)
        Me.ttÜstte.Text = "Always top"
        Me.ttÜstte.ToolTipText = "Uygulamayı her zaman üstte tut."
        '
        'ttAyırıcı1
        '
        Me.ttAyırıcı1.Name = "ttAyırıcı1"
        Me.ttAyırıcı1.Size = New System.Drawing.Size(6, 25)
        '
        'ttDosyaYolu
        '
        Me.ttDosyaYolu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttDosyaYolu.Image = CType(resources.GetObject("ttDosyaYolu.Image"), System.Drawing.Image)
        Me.ttDosyaYolu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttDosyaYolu.Name = "ttDosyaYolu"
        Me.ttDosyaYolu.Size = New System.Drawing.Size(23, 22)
        Me.ttDosyaYolu.Text = "Select file path"
        '
        'ttAyırıcı2
        '
        Me.ttAyırıcı2.Name = "ttAyırıcı2"
        Me.ttAyırıcı2.Size = New System.Drawing.Size(6, 25)
        '
        'ttAyarlar
        '
        Me.ttAyarlar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttAyarlar.Image = Global.Extension_Cleaner.My.Resources.Resources.Ayarlar
        Me.ttAyarlar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttAyarlar.Name = "ttAyarlar"
        Me.ttAyarlar.Size = New System.Drawing.Size(23, 22)
        Me.ttAyarlar.Text = "Settings"
        '
        'ttAyırıcı3
        '
        Me.ttAyırıcı3.Name = "ttAyırıcı3"
        Me.ttAyırıcı3.Size = New System.Drawing.Size(6, 25)
        '
        'ttHakkında
        '
        Me.ttHakkında.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttHakkında.Image = CType(resources.GetObject("ttHakkında.Image"), System.Drawing.Image)
        Me.ttHakkında.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttHakkında.Name = "ttHakkında"
        Me.ttHakkında.Size = New System.Drawing.Size(23, 22)
        Me.ttHakkında.Text = "About"
        '
        'ssLog
        '
        Me.ssLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.ssLog.Location = New System.Drawing.Point(0, 356)
        Me.ssLog.Name = "ssLog"
        Me.ssLog.Size = New System.Drawing.Size(644, 22)
        Me.ssLog.TabIndex = 4
        Me.ssLog.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(42, 17)
        Me.lblStatus.Text = "Ready."
        Me.lblStatus.ToolTipText = "Durum göstergesi."
        '
        'tsMenüÜst
        '
        Me.tsMenüÜst.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttDosya})
        Me.tsMenüÜst.Location = New System.Drawing.Point(0, 0)
        Me.tsMenüÜst.Name = "tsMenüÜst"
        Me.tsMenüÜst.Size = New System.Drawing.Size(644, 24)
        Me.tsMenüÜst.TabIndex = 5
        Me.tsMenüÜst.Text = "Menü"
        '
        'ttDosya
        '
        Me.ttDosya.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttHakkında2, Me.ttÇıkış})
        Me.ttDosya.Name = "ttDosya"
        Me.ttDosya.Size = New System.Drawing.Size(37, 20)
        Me.ttDosya.Text = "File"
        Me.ttDosya.ToolTipText = "Dosya"
        '
        'ttHakkında2
        '
        Me.ttHakkında2.Name = "ttHakkında2"
        Me.ttHakkında2.Size = New System.Drawing.Size(107, 22)
        Me.ttHakkında2.Text = "About"
        Me.ttHakkında2.ToolTipText = "Hakkında"
        '
        'ttÇıkış
        '
        Me.ttÇıkış.Name = "ttÇıkış"
        Me.ttÇıkış.Size = New System.Drawing.Size(107, 22)
        Me.ttÇıkış.Text = "Exit"
        Me.ttÇıkış.ToolTipText = "Çıkış yap."
        '
        'tmrHazır
        '
        Me.tmrHazır.Interval = 10000
        '
        'tmrAuto
        '
        Me.tmrAuto.Interval = 1000
        '
        'NIcon
        '
        Me.NIcon.Icon = CType(resources.GetObject("NIcon.Icon"), System.Drawing.Icon)
        Me.NIcon.Text = "DMP Cleaner"
        Me.NIcon.Visible = True
        '
        'gbExtension
        '
        Me.gbExtension.Controls.Add(Me.cbAnalyzeExtension)
        Me.gbExtension.Controls.Add(Me.lblAnalyzeExtension)
        Me.gbExtension.Location = New System.Drawing.Point(241, 200)
        Me.gbExtension.Name = "gbExtension"
        Me.gbExtension.Size = New System.Drawing.Size(200, 148)
        Me.gbExtension.TabIndex = 18
        Me.gbExtension.TabStop = False
        Me.gbExtension.Text = "Analyze Info"
        '
        'cbAnalyzeExtension
        '
        Me.cbAnalyzeExtension.FormattingEnabled = True
        Me.cbAnalyzeExtension.Items.AddRange(New Object() {"*.txt", "*.log", "*.dump", "*.dmp", "*.cfg", "*.lnk", "*.temp", "*.tmp", ""})
        Me.cbAnalyzeExtension.Location = New System.Drawing.Point(87, 16)
        Me.cbAnalyzeExtension.Name = "cbAnalyzeExtension"
        Me.cbAnalyzeExtension.Size = New System.Drawing.Size(107, 24)
        Me.cbAnalyzeExtension.TabIndex = 1
        Me.cbAnalyzeExtension.Text = "*.txt"
        '
        'lblAnalyzeExtension
        '
        Me.lblAnalyzeExtension.AutoSize = True
        Me.lblAnalyzeExtension.Location = New System.Drawing.Point(6, 19)
        Me.lblAnalyzeExtension.Name = "lblAnalyzeExtension"
        Me.lblAnalyzeExtension.Size = New System.Drawing.Size(67, 16)
        Me.lblAnalyzeExtension.TabIndex = 0
        Me.lblAnalyzeExtension.Text = "Extension:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(644, 378)
        Me.Controls.Add(Me.gbExtension)
        Me.Controls.Add(Me.btnAutoDurdur)
        Me.Controls.Add(Me.lblSonrakiTemizlikSn)
        Me.Controls.Add(Me.lblSonrakiTemizlik)
        Me.Controls.Add(Me.gbİçerik)
        Me.Controls.Add(Me.btnListeSil)
        Me.Controls.Add(Me.btnListele)
        Me.Controls.Add(Me.ssLog)
        Me.Controls.Add(Me.tsMenü)
        Me.Controls.Add(Me.tsMenüÜst)
        Me.Controls.Add(Me.lvDosyalar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extension Cleaner"
        Me.gbİçerik.ResumeLayout(False)
        Me.gbİçerik.PerformLayout()
        Me.tsMenü.ResumeLayout(False)
        Me.tsMenü.PerformLayout()
        Me.ssLog.ResumeLayout(False)
        Me.ssLog.PerformLayout()
        Me.tsMenüÜst.ResumeLayout(False)
        Me.tsMenüÜst.PerformLayout()
        Me.gbExtension.ResumeLayout(False)
        Me.gbExtension.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvDosyalar As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDosyaAdı As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDosyaYolu As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBoyut As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTür As System.Windows.Forms.ColumnHeader
    Friend WithEvents ttAçıklama As System.Windows.Forms.ToolTip
    Friend WithEvents tsMenü As System.Windows.Forms.ToolStrip
    Friend WithEvents ttÜstte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ssLog As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ttAyırıcı1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ttHakkında As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsMenüÜst As System.Windows.Forms.MenuStrip
    Friend WithEvents ttDosya As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttDosyaYolu As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrHazır As System.Windows.Forms.Timer
    Friend WithEvents ttHakkında2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttÇıkış As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListele As System.Windows.Forms.Button
    Friend WithEvents btnListeSil As System.Windows.Forms.Button
    Friend WithEvents txtKelime As System.Windows.Forms.TextBox
    Friend WithEvents lbContains As System.Windows.Forms.ListBox
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents btnKaldır As System.Windows.Forms.Button
    Friend WithEvents btnTemizle As System.Windows.Forms.Button
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents gbİçerik As System.Windows.Forms.GroupBox
    Friend WithEvents ttAyırıcı2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ttAyarlar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ttAyırıcı3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrAuto As System.Windows.Forms.Timer
    Friend WithEvents lblSonrakiTemizlik As System.Windows.Forms.Label
    Friend WithEvents lblSonrakiTemizlikSn As System.Windows.Forms.Label
    Friend WithEvents NIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnAutoDurdur As System.Windows.Forms.Button
    Friend WithEvents gbExtension As GroupBox
    Friend WithEvents cbAnalyzeExtension As ComboBox
    Friend WithEvents lblAnalyzeExtension As Label
End Class
