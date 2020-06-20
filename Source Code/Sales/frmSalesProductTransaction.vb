Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmSalesProductTransaction
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
            filterasof = " and date_format(postingdate,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("select id,officeid,customproductorder,menumakerstockref, (select officename from tblcompoffice where officeid = tblsalestransaction.officeid) as '" & GlobalOfficeCaption & "', batchcode as 'Batch Code', " _
                        + " date_format(postingdate,'%Y-%m-%d') as 'Posting Date', " _
                        + " (select fullname from tblaccounts where accountid=tblsalestransaction.userid) as 'Cashier', " _
                        + " date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction', " _
                        + " (select companyname from tblclientaccounts where cifid = tblsalestransaction.cifid) as 'Client', " _
                        + " productname as 'Product Name', " _
                        + " (select description from tblprocategory where catid=tblsalestransaction.catid) as 'Category', " _
                        + " Quantity, Unit, purchasedprice as 'Purchase Price', originalsellprice as 'Unit Price',  disrate as 'Discount Rate', distotal as 'Discount',chargetotal as 'Charge', taxtotal as VAT, svchargetotal as 'SVC', total as 'Total Amount',Income as Revenue , " _
                        + " (select fullname from tblaccounts where accountid=tblsalestransaction.attendingperson) as 'Attending Personnel' " _
                        + " from tblsalestransaction where onhold=0 and cancelled=0 and void=0 " & filterasof & viewalloffices _
                        + " order by datetrn asc", "tblsalestransaction", Em, GridView1, Me)

        XgridHideColumn({"id", "officeid", "customproductorder", "menumakerstockref"}, GridView1)
        XgridColCurrency({"Quantity", "Purchase Price", "Unit Price", "Discount", "Charge", "Total Amount", "Revenue", "VAT", "SVC"}, GridView1)
        XgridColAlign({"Batch Code", "Posting Date", "Discount Rate", "Date Transaction", "Unit", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGroupSummaryCurrency({"Purchase Price", "Unit Price", "Discount", "Charge", "Total Amount", "Revenue"}, GridView1)
        XgridGeneralSummaryCurrency({"Purchase Price", "Unit Price", "Discount", "Charge", "Total Amount", "Revenue"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Cashier"}, GridView1, 180)

        GridView1.Columns(GlobalOfficeCaption).Group()
        GridView1.ExpandAllGroups()
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
 
    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("menumakerstockref").ToString = "" Then
            MessageBox.Show("Please select product from menu maker item", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmProductMenuItemReports.Text = StrConv(GridView1.GetFocusedRowCellValue("Product Name").ToString, vbProperCase)
        frmProductMenuItemReports.txtReportDescription.Text = GridView1.GetFocusedRowCellValue("Quantity").ToString & "@" & GridView1.GetFocusedRowCellValue("Unit Price").ToString & " sold by " & StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString, vbProperCase)
        frmProductMenuItemReports.refnumber.Text = GridView1.GetFocusedRowCellValue("menumakerstockref").ToString
        If frmProductMenuItemReports.Visible = False Then
            frmProductMenuItemReports.Show(Me)
        End If

    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        filterInventory()
    End Sub

    Private Sub cmdPrintReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintReport.ItemClick
        PrintDatagridview(If(ck_inventory.Checked = True, "SALES ITEM REPORT LOGS", " SALES ITEM REPORT LOGS <br/>" & txtInventory.Text), "DATABASE RECORDS", If(ckasof.Checked = True, "Report Filter: ALL RECORDS", "Report Filter: From " & txtfrmdate.Text & " to " & txttodate.Text), GridView1, Me)

        'PrintGeneralReportWithDate(ckasof.CheckState, txtfrmdate.EditValue, txttodate.EditValue, Me.Text & " (" & If(ck_inventory.Checked = True, "All Office", txtInventory.Text) & ")", gridview1, Me)
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel("Sales Report " & If(ckasof.Checked = True, " as of " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd"), "from " & CDate(txtfrmdate.EditValue).ToString("yyyy-MM-dd") & " to " & CDate(txttodate.EditValue).ToString("yyyy-MM-dd")), GridView1)
    End Sub

    Private Sub ViewSubProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSubProductToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("customproductorder").ToString) = False Then
            MessageBox.Show("Please select product from custom product item", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmProductSubItem.Text = StrConv(GridView1.GetFocusedRowCellValue("Product Name").ToString, vbProperCase)
        frmProductSubItem.txtReportDescription.Text = GridView1.GetFocusedRowCellValue("Quantity").ToString & "@" & GridView1.GetFocusedRowCellValue("Unit Price").ToString & " sold by " & StrConv(GridView1.GetFocusedRowCellValue("Cashier").ToString, vbProperCase)
        frmProductSubItem.refnumber.Text = GridView1.GetFocusedRowCellValue("id").ToString
        If frmProductSubItem.Visible = False Then
            frmProductSubItem.Show(Me)
        End If
    End Sub
End Class