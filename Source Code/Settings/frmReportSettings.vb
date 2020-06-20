Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmReportSettings
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Public gv As DataGridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepositOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If txtReportForm.Text = "" Then
            LoadToComboBoxQuery("reporttitle", "reporttitle", "tblreportsetting order by reporttitle asc", txtReportTitle)
            txtReportTitle.Enabled = True
        Else
            ShowReportInfo()
            txtReportTitle.Enabled = False
        End If
        ShowReportInfo()
    End Sub

    Private Sub txtReportTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtReportTitle.SelectedIndexChanged
        txtReportForm.Text = qrysingledata("formname", "formname", "where reporttitle='" & txtReportTitle.Text & "'", "tblreportsetting")
        ShowReportInfo()
    End Sub
    Public Sub ShowReportInfo()
        com.CommandText = "select * from tblreportsetting where formname='" & txtReportForm.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            reportid.Text = rst("id").ToString
            txtReportTitle.Text = rst("reporttitle").ToString
            txtPaperKind.Text = rst("paperkind").ToString
            ckorientation.Checked = rst("landscape")
        End While
        rst.Close()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        If txtReportForm.Text = "" Then
            XtraMessageBox.Show("Please select report form!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReportForm.Focus()
            Exit Sub
        ElseIf txtReportTitle.Text = "" Then
            XtraMessageBox.Show("Please enter report title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReportTitle.Focus()
            Exit Sub
        ElseIf txtPaperKind.Text = "" Then
            XtraMessageBox.Show("Please select default paperkind!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPaperKind.Focus()
            Exit Sub
        End If
        If countqry("tblreportsetting", "formname='" & txtReportForm.Text & "'") = 0 Then
            com.CommandText = "insert into tblreportsetting set formname='" & txtReportForm.Text & "', reporttitle='" & rchar(txtReportTitle.Text) & "', landscape='" & ckorientation.CheckState & "',paperkind='" & txtPaperKind.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblreportsetting set reporttitle='" & rchar(txtReportTitle.Text) & "', landscape='" & ckorientation.CheckState & "',paperkind='" & txtPaperKind.Text & "' where formname='" & txtReportForm.Text & "'" : com.ExecuteNonQuery()
        End If
        XtraMessageBox.Show("Report successfuly saved! Please close this form and click print again", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class