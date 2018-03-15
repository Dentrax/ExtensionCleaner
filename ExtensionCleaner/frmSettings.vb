'====================================================
' ExtensionCleaner Copyright(C) 2012 Furkan Türkal
' This program comes with ABSOLUTELY NO WARRANTY; This Is free software,
' And you are welcome to redistribute it under certain conditions; See
' file LICENSE, which Is part of this source code package, for details.
'====================================================

Public Class frmSettings
    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        Dim İçerik As Boolean = chkİçerik.CheckState
        Dim Auto As Boolean = chkOtoTemizle.CheckState
        If İçerik = True Then
            frmMain.gbİçerik.Enabled = True
        Else
            frmMain.gbİçerik.Enabled = False
        End If
        If Auto = True Then
            frmMain.TimerBaşla()
        Else
            frmMain.TimerDur()
        End If
        Me.Visible = False
        frmMain.Visible = True
    End Sub
    Private Sub frmAyarlar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        frmMain.Visible = True
    End Sub
End Class