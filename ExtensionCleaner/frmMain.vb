'====================================================
' ExtensionCleaner Copyright(C) 2012 Furkan Türkal
' This program comes with ABSOLUTELY NO WARRANTY; This Is free software,
' And you are welcome to redistribute it under certain conditions; See
' file LICENSE, which Is part of this source code package, for details.
'====================================================

Imports System.IO
Imports System.Net

Public Class frmMain
    Private WithEvents Tray As NotifyIcon
    Private WithEvents MainMenu As ContextMenuStrip
    Private WithEvents mnuDisplayForm As ToolStripMenuItem
    Private WithEvents mnuAyarlar As ToolStripMenuItem
    Private WithEvents mnuSep1 As ToolStripSeparator
    Private WithEvents mnuSep2 As ToolStripSeparator
    Private WithEvents mnuSep3 As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem
    Private WithEvents mnuCheckUpdate As ToolStripMenuItem
    Private WithEvents mnuHakkında As ToolStripMenuItem
    Private WithEvents mnuYardım As ToolStripMenuItem
    Dim DosyaYolu As String
    Dim ArrayList As New ArrayList
    Dim ContainsList(50) As String
    Dim ToplamTemizleme As Integer
    Dim Başlık As String = My.Application.Info.AssemblyName
    Private Sub DizinIceriginiListeyeEkle(ByVal dizin As String, ByVal uzantı As String)
        Try
            Dim Sıra As Integer = 0
            Dim Bytes As Long
            'Dim Sıra2 As Integer = 0
            Dim dizindekiDosyalar As String() = Directory.GetFiles(dizin, uzantı)
            For Each dosya As String In dizindekiDosyalar
                Sıra = Sıra + 1
                Dim dosyaBilgi As New FileInfo(dosya)
                Dim dosyaSıra As Integer = Sıra
                Dim dosyaAdi As String = dosyaBilgi.Name
                Dim dosyaYol As String = dosyaBilgi.DirectoryName & "\"
                Dim dosyaBoyut As Long = dosyaBilgi.Length
                Dim dosyaTürü As String = dosyaBilgi.Extension
                Dim dosyaTamYol As String = dosyaYol + dosyaAdi
                Bytes = Bytes + dosyaBoyut.ToString
                'If dosyaAdi.Contains(lbContains.Items.Count) Then
                'Sıra2 = Sıra2 + 1
                'Dim dosyaSıra2 As Integer = Sıra2
                Dim item As New ListViewItem(dosyaSıra)
                item.SubItems.Add(dosyaAdi)
                item.SubItems.Add(dosyaYol)
                item.SubItems.Add(dosyaBoyut.ToString() + " byte")
                item.SubItems.Add("[" + dosyaTürü + "]")
                lvDosyalar.Items.Add(item)
                ArrayList.Add(dosyaTamYol)
                'End If
            Next
            If Not Sıra <> 0 Then
                If frmSettings.chkDurumBilgi.Checked = True Then
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim TotalKB As Double = Bytes / 1024
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", Sıra & " files listed. Total size: " & TotalKB.ToString & " kb.", ToolTipIcon.Info)
                        lblStatus.Text = Sıra & " files listed. Total size: " & TotalKB.ToString & " kb."
                        tmrHazır.Start()
                    Else
                        Dim TotalKB As Double = Bytes / 1024
                        lblStatus.Text = Sıra & " files listed. Total size: " & TotalKB.ToString & " kb."
                        tmrHazır.Start()
                    End If
                Else
                    lblStatus.Text = Sıra & " files listed."
                    tmrHazır.Start()
                End If
            Else
                If frmSettings.chkDurumBilgi.Checked = True Then
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim TotalKB As Double = Bytes / 1024
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", Sıra & " files listed. Total size: " & TotalKB.ToString & " kb.", ToolTipIcon.Info)
                        lblStatus.Text = Sıra & " files listed. Total size: " & TotalKB.ToString & " kb."
                        tmrHazır.Start()
                    Else
                        Dim TotalKB As Double = Bytes / 1024
                        lblStatus.Text = Sıra & " files listed. Total size: " & TotalKB.ToString & " kb."
                        tmrHazır.Start()
                    End If

                Else
                    If frmSettings.chkBildirim.Checked = True Then
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", Sıra & " files listed.", ToolTipIcon.Info)
                        lblStatus.Text = Sıra & " files listed."
                        tmrHazır.Start()
                    Else
                        lblStatus.Text = Sıra & " files listed."
                        tmrHazır.Start()
                    End If

                End If

            End If
        Catch
            lblStatus.Text = "Dosya yolu hatalı."
            tmrHazır.Start()
        End Try
    End Sub
    Private Function Contains() As String
        For counter = 0 To ContainsList.Length - 1
            Return CInt(ContainsList(counter) * 2)
        Next
    End Function
    Private Sub DelArrayList(ByVal List As ArrayList, ByRef Auto As Boolean)
        Try
            If frmSettings.chkAkıllıTemizle.Checked = True Then
                If Auto = True Then
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", "[Auto Cleaner] " & totalDeleteCount & " files deleted as smart.", ToolTipIcon.Info)
                        lblStatus.Text = "[Auto Cleaner] " & totalDeleteCount & " files deleted as smart."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    Else
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        lblStatus.Text = "[Auto Cleaner] " & totalDeleteCount & " files deleted as smart."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    End If

                Else
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", totalDeleteCount & " files deleted as smart.", ToolTipIcon.Info)
                        lblStatus.Text = totalDeleteCount & " files deleted as smart."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    Else
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        lblStatus.Text = totalDeleteCount & " files deleted as smart."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    End If

                End If
            Else
                If Auto = True Then
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", "[Auto Cleaner] " & totalDeleteCount & " files deleted.", ToolTipIcon.Info)
                        lblStatus.Text = "[Auto Cleaner] " & totalDeleteCount & " files deleted."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    Else
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        lblStatus.Text = "[Auto Cleaner] " & totalDeleteCount & " files deleted."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    End If

                Else
                    If frmSettings.chkBildirim.Checked = True Then
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        lblStatus.Text = totalDeleteCount & " files deleted."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                        NIcon.ShowBalloonTip(&H1388, "Extension Cleaner", totalDeleteCount & " files deleted.", ToolTipIcon.Info)
                    Else
                        Dim totalDeleteCount As Integer = 0
                        For Each num In List
                            totalDeleteCount = totalDeleteCount + 1
                            My.Computer.FileSystem.DeleteFile(num)
                        Next
                        lblStatus.Text = totalDeleteCount & " files deleted."
                        tmrHazır.Start()
                        lvDosyalar.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            lblStatus.Text = "Error: " & ex.Message
            tmrHazır.Start()
        End Try
    End Sub
    Private Sub ttÜstte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttÜstte.Click
        Dim Üstte As Boolean = ttÜstte.CheckState
        If ttÜstte.CheckState = CheckState.Unchecked Then
            Me.TopMost = False
            Me.ttÜstte.Image = My.Resources.ÜstteTutma
            ttÜstte.CheckState = CheckState.Checked
        ElseIf ttÜstte.CheckState = CheckState.Checked Then
            Me.TopMost = True
            Me.ttÜstte.Image = My.Resources.ÜstteTut
            ttÜstte.CheckState = CheckState.Unchecked
        Else
            Me.TopMost = False
            Me.ttÜstte.Image = My.Resources.ÜstteTutma
            ttÜstte.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub ttDosyaYolu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttDosyaYolu.Click
        If DosyaYolu IsNot Nothing Then
            If DosyaYolu.Contains(":") And DosyaYolu.Contains("\") Then
                Dim Mesaj As String = "Please select the path to the files to be clean" + vbNewLine + "Example: C:\files\to\clean"
                DosyaYolu = InputBox(Mesaj, Başlık, DosyaYolu, 100, 100)
            Else
                Dim Mesaj As String = "Please select the path to the files to be clean" + vbNewLine + "Example: C:\files\to\clean"
                DosyaYolu = InputBox(Mesaj, Başlık, Nothing, 100, 100)
            End If
        Else
            Dim Mesaj As String = "Please select the path to the files to be clean" + vbNewLine + "Example: C:\files\to\clean"
            DosyaYolu = InputBox(Mesaj, Başlık, Nothing, 100, 100)
        End If
    End Sub
    Private Sub tmrHazır_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHazır.Tick
        lblStatus.Text = "Ready."
        tmrHazır.Stop()
    End Sub
    Private Sub btnListele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListele.Click
        'lvDosyalar.Clear()
        If Not DosyaYolu IsNot Nothing Then
            lblStatus.Text = "Please select a file path"
            tmrHazır.Start()
        Else
            If DosyaYolu.Contains(":") And DosyaYolu.Contains("\") Then
                If (cbAnalyzeExtension.Text IsNot Nothing) Then
                    DizinIceriginiListeyeEkle(DosyaYolu, cbAnalyzeExtension.Text)
                Else
                    lblStatus.Text = "Please select a valid file extension"
                    tmrHazır.Start()
                End If
            Else
                lblStatus.Text = "Please select a valid file path"
                tmrHazır.Start()
            End If
        End If
    End Sub
    Private Sub btnListeSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListeSil.Click
        DelArrayList(ArrayList, False)
    End Sub
    Private Sub frmAna_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmSettings.chkSimgeDurumu.Checked = True Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            NIcon.Visible = True
        Else
            If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Extension Cleaner") = MsgBoxResult.Yes Then
                If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Extension Cleaner") = MsgBoxResult.Yes Then
                    End
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub frmAna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        mnuDisplayForm = New ToolStripMenuItem("Extension Cleaner'i aç")
        mnuSep1 = New ToolStripSeparator()
        mnuAyarlar = New ToolStripMenuItem("Settings")
        mnuCheckUpdate = New ToolStripMenuItem("Güncelleme Kontrol")
        mnuCheckUpdate.Enabled = False
        mnuYardım = New ToolStripMenuItem("Help...")
        mnuSep2 = New ToolStripSeparator()
        mnuHakkında = New ToolStripMenuItem("About...")
        mnuSep3 = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem("Exit")
        MainMenu = New ContextMenuStrip
        MainMenu.Items.AddRange(New ToolStripItem() {mnuDisplayForm, mnuSep1, mnuAyarlar, mnuCheckUpdate, mnuSep2, mnuYardım, mnuHakkında, mnuSep3, mnuExit})
        NIcon.ContextMenuStrip = MainMenu
        NIcon.Visible = True
        NIcon.ShowBalloonTip(&H1388, "Welcome", "Extension Cleaner", ToolTipIcon.Info)
    End Sub
    Private Sub Tray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.DoubleClick
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
    End Sub
    Private Sub NIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NIcon.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
    End Sub
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If MsgBox("Çıkmak istediğinize eminmisiniz ?", MsgBoxStyle.YesNoCancel, "Extension Cleaner") = MsgBoxResult.Yes Then
            If MsgBox("Çıkmak istediğinize eminmisiniz ?", MsgBoxStyle.YesNo, "Extension Cleaner") = MsgBoxResult.Yes Then
                End
            End If
        End If
    End Sub
    Private Sub mnuAyarlar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAyarlar.Click
        Me.Visible = False
        frmSettings.Visible = True
    End Sub
    Private Sub mnuDisplayForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDisplayForm.Click
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
    End Sub
    Private Sub mnuHakkında_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHakkında.Click
        frmAbout.Visible = True
    End Sub
    Private Sub ttHakkında_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttHakkında.Click
        frmAbout.Show()
    End Sub
    Private Sub ttHakkında2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttHakkında2.Click
        frmAbout.Show()
    End Sub
    Private Sub btnEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkle.Click
        Try
            If txtKelime.Text <> String.Empty Then
                If Not lbContains.Items.Contains(txtKelime.Text) Then
                    lbContains.Items.Add(txtKelime.Text)
                    lblStatus.Text = "Yeni kelime eklendi : " & txtKelime.Text
                    tmrHazır.Start()
                Else
                    lblStatus.Text = "Kelime zaten listede mevcut."
                    tmrHazır.Start()
                End If
            Else
                lblStatus.Text = "Kelime adı girilmedi."
                tmrHazır.Start()
            End If
        Catch ex As Exception
            lblStatus.Text = "Hata: " & ex.Message
            tmrHazır.Start()
        End Try
    End Sub
    Private Sub btnKaldır_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaldır.Click
        Try
            Dim lst As New List(Of Object)
            For Each a As Object In lbContains.SelectedItems
                lst.Add(a)
            Next
            For Each a As Object In lst
                lbContains.Items.Remove(a)
            Next
            lbContains.SelectedIndex = 0
            lblStatus.Text = "Kelime kaldırıldı : " & lbContains.SelectedItem.ToString
            tmrHazır.Start()
        Catch ex As Exception
            If lbContains.SelectedIndex = False Then
                lblStatus.Text = "Hata: " & ex.Message
                tmrHazır.Start()
            Else
                lblStatus.Text = "Kelime seçilmedi."
                tmrHazır.Start()
            End If
        End Try
    End Sub
    Private Sub btnTemizle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemizle.Click
        Try
            lbContains.Items.Clear()
            lblStatus.Text = "Kelime listesi temizlendi."
            tmrHazır.Start()
        Catch ex As Exception
            lblStatus.Text = "Hata: " & ex.Message
            tmrHazır.Start()
        End Try
    End Sub
    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        For i = 0 To lbContains.Items.Count
            'ContainsList.Add(lbContains.Items.ToString)
        Next i
    End Sub
    Private Sub ttAyarlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttAyarlar.Click
        Me.Visible = False
        frmSettings.Visible = True
    End Sub
    Sub TimerBaşla()
        lblSonrakiTemizlik.Visible = True
        lblSonrakiTemizlikSn.Visible = True
        btnAutoDurdur.Visible = True
        frmSettings.chkOtoTemizle.Checked = True
        lblSonrakiTemizlikSn.ForeColor = Color.Red
        lblSonrakiTemizlikSn.Text = 300
        tmrAuto.Start()
    End Sub
    Sub TimerDur()
        lblSonrakiTemizlik.Visible = False
        lblSonrakiTemizlikSn.Visible = False
        btnAutoDurdur.Visible = False
        frmSettings.chkOtoTemizle.Checked = False
        lblSonrakiTemizlikSn.ForeColor = Color.Red
        lblSonrakiTemizlikSn.Text = 300
        tmrAuto.Stop()
    End Sub
    Private Sub tmrAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAuto.Tick
        lblSonrakiTemizlikSn.Text = lblSonrakiTemizlikSn.Text - 1
        If lblSonrakiTemizlikSn.Text < 300 Then
            lblSonrakiTemizlikSn.ForeColor = Color.Red
        ElseIf lblSonrakiTemizlikSn.Text < 150 Then
            lblSonrakiTemizlikSn.ForeColor = Color.Chocolate
        ElseIf lblSonrakiTemizlikSn.Text < 50 Then
            lblSonrakiTemizlikSn.ForeColor = Color.Lime
        ElseIf lblSonrakiTemizlikSn.Text < 5 Then
            lblSonrakiTemizlikSn.ForeColor = Color.MidnightBlue
        ElseIf lblSonrakiTemizlikSn.Text = 0 Then
            ToplamTemizleme = ToplamTemizleme + 1
            DelArrayList(ArrayList, True)
            lblSonrakiTemizlikSn.Text = 300
        End If
    End Sub
    Private Sub btnAutoDurdur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoDurdur.Click
        TimerDur()
    End Sub
    Private Sub ttÇıkış_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttÇıkış.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Extension Cleaner") = MsgBoxResult.Yes Then
            If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Extension Cleaner") = MsgBoxResult.Yes Then
                End
            End If
        End If
    End Sub

End Class
