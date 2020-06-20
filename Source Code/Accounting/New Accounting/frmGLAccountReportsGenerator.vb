Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmGLAccountReportsGenerator
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = (Keys.Control) + Keys.P Then
            ' printreport()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtReportDate.EditValue = CDate(Now)
        LoadCompany()
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If companyid.Text = "" Then Exit Sub
        LoadXgrid("CALL sp_acct_capture('" & companyid.Text & "','" & ConvertDate(txtReportDate.EditValue) & "')", "CALL sp_acct_capture('" & companyid.Text & "','" & ConvertDate(txtReportDate.EditValue) & "')", Em, GridView1, Me)
        XgridColCurrency({"Credit", "Debit"}, GridView1)
        XgridGroupSummaryCurrency({"Credit", "Debit"}, GridView1)
        XgridGeneralSummaryCurrency({"Credit", "Debit"}, GridView1)
        XgridColWidth({"Credit", "Debit"}, GridView1, 150)
        XgridColAlign({"Reference No"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub txtReportDate_EditValueChanged(sender As Object, e As EventArgs) Handles txtReportDate.EditValueChanged
        cmdaction.PerformClick()
    End Sub
End Class