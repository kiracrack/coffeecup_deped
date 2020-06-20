Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmHotelBreakdownSales
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        txtfrmdate.EditValue = CDate(Now)
        GridView1.Focus()
        filterReport()

    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterReport()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterReport()
        If ckDetailed.Checked = True Then
            FilterDetailed()
        Else
            FilterSummary()
        End If
    End Sub
    Public Sub FilterDetailed()
        LoadXgrid("SELECT (select description from tblhotelroomtype where code=tblhotelroomsalesbreakdown.roomtype) as 'Room Type',roomno as 'Room No.',(select description from tblhotelroomrates where ratecode=tblhotelroomsalesbreakdown.rateid) as 'Rate Type',breakdowntype as 'BreakDownType',itemname as 'Description',amount*quantity as 'Amount',date_format(trndate,'%Y-%m-%d') as 'Date Transaction' FROM `tblhotelroomsalesbreakdown` where trndate='" & ConvertDate(txtfrmdate.EditValue) & "'", "tblhotelroomsalesbreakdown", Em, GridView1, Me)

        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Room Type", "Room No.", "BreakDownType", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGroupSummaryCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()
    End Sub

    Public Sub FilterSummary()
        LoadXgrid("SELECT itemname as 'Description', sum(amount*quantity) as 'Total Transaction' FROM `tblhotelroomsalesbreakdown` where trndate='" & ConvertDate(txtfrmdate.EditValue) & "' group by itemname", "tblhotelroomsalesbreakdown", Em, GridView1, Me)
        XgridColCurrency({"Total Transaction"}, GridView1)
        XgridColWidth({"Description"}, GridView1, 250)
        'GridView1.BestFitColumns()
        XgridGeneralSummaryCurrency({"Total Transaction"}, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filterReport()
    End Sub

    Private Sub cmdPrintReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintReport.ItemClick
        PrintGeneralReport(Me.Text, "Date Filter: " & txtfrmdate.Text, GridView1, Me)
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text & " " & txtfrmdate.Text, GridView1)
    End Sub

    Private Sub txtfrmdate_EditValueChanged(sender As Object, e As EventArgs) Handles txtfrmdate.EditValueChanged
        filterReport()
    End Sub
End Class