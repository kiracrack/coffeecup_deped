Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmSalesTransaction
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
        lblOffice.Text = "Select " & GlobalOfficeCaption
        loadInventoryTo()
        filterInventory()
        If EnableModuleFuel = True Then
            cmdpunpReading.Visible = True
        Else
            cmdpunpReading.Visible = False
        End If
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
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
        Dim viewalloffices As String = "" : Dim filterasof As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If
        If ckasof.Checked = True Then
            filterasof = " and date_format(dateopen,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(dateopen,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("SELECT trncode as 'Transaction Code',officeid, (select officename from tblcompoffice where officeid=tblsalessummary.officeid) as '" & If(GlobalOfficeCaption = "", "Office", GlobalOfficeCaption) & "', " _
                                + " (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'Cashier', " _
                                + " date_format(dateopen,'%Y-%m-%d %r') as 'Date Open', " _
                                + " date_format(dateopen,'%Y-%m-%d %r') as 'Date Close', " _
                                + " begcash as 'Beginning Cash', " _
                                + " cashend as 'Total Cash Sales', " _
                                + " cashonhand as 'Actual Cash on Hand', " _
                                + " if(overages=0,shortages,overages) as 'Cash Variance', " _
                                + " totalcash as 'Total Bills', " _
                                + " totalcoins as 'Total Coins', " _
                                + " nextbeginningcash as 'Next Beggining Cash', " _
                                + " cashremitted as 'Total Cash Remitted', " _
                                + " amountdeposited as 'Amount Deposited', " _
                                + " (select accountname from tblbankaccounts where bankcode=tblsalessummary.bankdeposited) as 'Account Deposited' " _
                                + " FROM `tblsalessummary`  where verified=1 and cancelled=0 " & filterasof & viewalloffices _
                                + " order by dateopen asc", "tblsalessummary", Em, GridView1, Me)
        XgridHideColumn({"officeid"}, GridView1)
        XgridColAlign({"Transaction Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Beginning Cash", "Total AR", "Total Client Payment", "Total Client Journal", "Debit Account Journal", "Credit Account Journal", "Total Other Transaction", _
                          "Total Charges", "Total Discount", "Total Tax", "Total Chit", "Total Sales", "Total Cash Sales", "Actual Cash on Hand", "Cash Variance", "Total Income", _
                          "Total Expense", "Total Check", "Total Credit Card", "Total Payment Deposit", "Total Bills", "Total Coins", _
                          "Next Beggining Cash", "Total Cash Remitted", "Amount Deposited"}, GridView1)

        XgridGeneralSummaryCurrency({"Beginning Cash", "Total AR", "Total Client Payment", "Total Client Journal", "Debit Account Journal", "Credit Account Journal", "Total Other Transaction", _
                          "Total Charges", "Total Discount", "Total Tax", "Total Chit", "Total Sales", "Total Cash Sales", "Actual Cash on Hand", "Cash Variance", "Total Income", _
                          "Total Expense", "Total Check", "Total Credit Card", "Total Payment Deposit", "Total Bills", "Total Coins", _
                          "Next Beggining Cash", "Total Cash Remitted", "Amount Deposited"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Cashier"}, GridView1, 180)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Cash Variance"))
            If e.Column.FieldName = "Cash Variance" Then
                If Val(CC(status)) < 0 Then
                    e.Appearance.ForeColor = Color.Red
                ElseIf Val(CC(status)) > 0 Then
                    e.Appearance.ForeColor = Color.Blue
                End If
            End If
            If e.Column.FieldName = "Actual Cash on Hand" Then
                e.Appearance.BackColor = Color.Gold
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdpunpReading.Click
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmShowPumpReading.trnsumcode.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmShowPumpReading.Show(Me)
        End If
    End Sub

    
    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        If CheckSelectedRow("Transaction Code", GridView1) = True Then
            frmPOSTransactionHistory.globalSalesTrnCOde.Text = GridView1.GetFocusedRowCellValue("Transaction Code").ToString
            frmPOSTransactionHistory.Text = StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString & "(" & GridView1.GetFocusedRowCellValue("Transaction Code").ToString & ")", vbProperCase)
            If frmPOSTransactionHistory.Visible = False Then
                frmPOSTransactionHistory.Show(Me)
            End If
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filterInventory()
    End Sub

    Private Sub cmdPrintReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintReport.ItemClick
        PrintGeneralReportWithDate(ckasof.CheckState, txtfrmdate.EditValue, txttodate.EditValue, Me.Text & " (" & If(ck_inventory.Checked = True, "All Office", txtInventory.Text) & ")", GridView1, Me)
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel("Sales Report " & If(ckasof.Checked = True, " as of " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd"), "from " & CDate(txtfrmdate.EditValue).ToString("yyyy-MM-dd") & " to " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd")), GridView1)
    End Sub
End Class