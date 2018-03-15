'====================================================
' ExtensionCleaner Copyright(C) 2012 Furkan Türkal
' This program comes with ABSOLUTELY NO WARRANTY; This Is free software,
' And you are welcome to redistribute it under certain conditions; See
' file LICENSE, which Is part of this source code package, for details.
'====================================================

Public Class frmAbout
    Private Sub frmHakkında_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "About"
        Me.lblProgram.Text = My.Application.Info.AssemblyName
        Me.lblSürüm.Text = "ver. " & My.Application.Info.Version.ToString
        Me.lblTelifHakkı.Text = "Copyright © Furkan Türkal. 2012"
        Me.lblHaklar.Text = "This project under MIT license"
    End Sub
    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        Me.Dispose()
    End Sub
End Class