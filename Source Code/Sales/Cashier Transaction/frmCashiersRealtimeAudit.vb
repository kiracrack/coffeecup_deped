Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCashiersRealtimeAudit
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadCurrentBlotter()
      
    End Sub

    Public Sub LoadCurrentBlotter()
        LoadXgrid("select officeid,userid, trncode as 'Transaction Code', date_format(dateopen,'%Y-%m-%d') as 'Transaction Date',(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as 'Office', (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier', cashend as 'System Cash End',cashonhand as 'Actual Cash',if(overages=0,shortages,overages) as 'Variance', if(openfortrn=0,'CLOSED','OPEN') as 'Status'  from tblsalessummary where verified=0 and openfortrn=1 and cancelled=0", "tblsalessummary", Em, GridView1, Me)
        GridView1.Columns("Office").Group()
        GridView1.ExpandAllGroups()
        XgridHideColumn({"officeid", "userid"}, GridView1)
        XgridColWidth({"Cashier"}, GridView1, 220)
        XgridColWidth({"System Cash End", "Actual Cash", "Variance"}, GridView1, 120)
        XgridColAlign({"Transaction Date", "Clearing Status", "Transaction Code", "Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"System Cash End", "Actual Cash", "Variance"}, GridView1)
    End Sub


    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        LoadCurrentBlotter()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmPOSTransactionHistory.globalSalesTrnCOde.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmPOSTransactionHistory.Text = "TRN# (" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & ") " & StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString, vbProperCase)
            If frmPOSTransactionHistory.Visible = False Then
                frmPOSTransactionHistory.Show(Me)
            End If
        End If
    End Sub
End Class