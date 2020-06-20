Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmHotelSalesBreakdown
    Private BandgridView As GridView
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
        txttodate.EditValue = CDate(Now)

        filterInventory()

    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterInventory()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterInventory()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(a.datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(a.datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("SELECT (select officename from tblcompoffice where officeid=a.officeid) as 'Transaction Office', (select officename from tblcompoffice where officeid=b.officeid) as 'Due From',  (select officename from tblcompoffice where officeid=a.officeid) as 'Due to',a.Remarks,a.debit as 'Amount', (select fullname from tblaccounts where accountid=a.trnby) as 'Transaction by', date_format(a.datetrn,'%Y-%m-%d %r') as 'Date Transaction' FROM `tblhoteltransaction` as a inner join tblhotelroomtransaction as b on a.folioid = b.folioid   where a.chargefrompos=1 and a.debit > 0 and a.officeid<>b.officeid and a.cancelled=0 " & filterasof & " order by a.datetrn asc;", "tblhoteltransaction", Em, GridView1, Me)

        'XgridHideColumn({"officeid", "menumakerstockref"}, GridView1)
        GridView1.Columns("Transaction Office").Group()
        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Transaction By", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGroupSummaryCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()

    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filterInventory()
    End Sub

    Private Sub cmdPrintReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintReport.ItemClick
        PrintGeneralReportWithDate(ckasof.CheckState, txtfrmdate.EditValue, txttodate.EditValue, Me.Text, Em, Me)
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel("Inter Office Transaction Report " & If(ckasof.Checked = True, " as of " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd"), "from " & CDate(txtfrmdate.EditValue).ToString("yyyy-MM-dd") & " to " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd")), GridView1)
    End Sub
End Class