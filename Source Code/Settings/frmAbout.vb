Imports System.IO
Imports DevExpress.Skins

Public Class frmAbout
    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        Dim bfversion As Date = System.IO.File.GetLastWriteTime(My.Application.Info.DirectoryPath).ToShortDateString()
        Me.Text = "About " & GlobalSystemname
        txtSystemName.Text = GlobalSystemname
        LabelControl3.Text = "Build File Version " & Format(bfversion, "yy.M.d") & GlobalDatabaseVersion
    End Sub

    Private Sub HyperLinkEdit1_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles HyperLinkEdit1.OpenLink
        Dim mailPrefix As String = "mailto:"
        If Not e.EditValue.ToString().ToLower().StartsWith(mailPrefix) Then
            e.EditValue = mailPrefix + e.EditValue.ToString()
        End If
    End Sub
End Class