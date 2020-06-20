Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmDirectPurchaseOrder
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

 
        End If
        Return ProcessCmdKey
    End Function
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_purchaseorder)
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdBarAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
       
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        lblOffice.Text = "Select " & GlobalOfficeCaption
        filter()
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_purchaseorder, Me)
        gv_purchaseorder.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Sub filter()
        On Error Resume Next
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " where date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " where date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select cast(ponumber as char(50)) as 'PO Number', (select companyname from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier',invoiceno as 'Invoice No.', subtotal as 'Sub Total',Vat,  charges as 'Charges',discount as 'Discount',totalamount as 'Total',date_format(datetrn,'%Y-%m-%d')  as 'Date Transaction',(select fullname from tblaccounts where accountid = createby) as 'Transaction by', if(cancelled=1,'Cancelled', if(verified=1,'Verified','Unverified')) as 'Status',Note,Verified,(select fullname from tblaccounts where accountid=verifiedby) as 'Verified by',date_format(dateverified,'%Y-%m-%d') as 'Date Verified',paymentupdated as 'Paid', paymentrefnumber as 'Payment Reference',Cancelled,(select fullname from tblaccounts where accountid=cancelledby) as 'Cancelled by',date_format(datecancelled,'%Y-%m-%d') as 'Date Cancelled' from  tblpurchaseorder " & If(ckPending.Checked = True, "where verified=0 and cancelled=0 ", filterasof & " and (paymentupdated=" & ckPaid.CheckState & " or cancelled=" & ckCancelled.CheckState & ") ") & If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' ") & " order by datetrn asc", "tblpurchaseorder", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseorder")

        XgridColCurrency({"Sub Total", "Vat", "Charges", "Discount", "Total"}, GridView1)
        XgridColAlign({"PO Number", "Invoice No.", "Date Transaction", "Status", "Date Cancelled", "Date Verified", "Payment Reference"}, GridView1, HorzAlignment.Center)

        XgridColWidth({"Supplier"}, GridView1, 200)
        XgridColWidth({"Sub Total", "Vat", "Charges", "Discount", "Total"}, GridView1, 80)
        XgridGeneralSummaryCurrency({"Sub Total", "Vat", "Charges", "Discount", "Total"}, GridView1)
        GridView1.Columns("PO Number").Visible = False

        msda = New MySqlDataAdapter("select cast(ponumber as char(50)) as 'PO Number', itemname  as 'Product', (select description from tblprocategory where catid = tblpurchaseorderitem.catid) as 'Category', Quantity,Unit,cost as 'Unit Cost',Total, Remarks,(select itemname from tblglobalproducts inner join tblinventoryffe on tblinventoryffe.productid = tblglobalproducts.productid where tblinventoryffe.ffecode = tblpurchaseorderitem.allocatedrefcode) as 'Allocated Expenses' from tblpurchaseorderitem", conn)
        msda.Fill(dst, "tblpurchaseorderitem")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblpurchaseorder").Columns("PO Number")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblpurchaseorderitem").Columns("PO Number")

        dst.Relations.Add("PurchaseDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("PurchaseDetails", BandgridView)

        Em.DataSource = dst.Tables("tblpurchaseorder")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblpurchaseorderitem"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"PO Number"}, BandgridView)
        XgridColCurrency({"Unit Cost", "Total"}, BandgridView)
        XgridColAlign({"Quantity", "Unit"}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, BandgridView)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Cancelled"))
        If status = "Checked" Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = DefaultForeColor
        End If

    End Sub
     
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("PO Number").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            XtraMessageBox.Show("Editing verified Puchase order not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Editing cancelled Puchase order not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmDirectCreatePurchaseOrder.mode.Text = ""
        frmDirectCreatePurchaseOrder.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmDirectCreatePurchaseOrder.mode.Text = "edit"
        If frmDirectCreatePurchaseOrder.Visible = True Then
            frmDirectCreatePurchaseOrder.Focus()
        Else
            frmDirectCreatePurchaseOrder.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("PO Number") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            XtraMessageBox.Show("Cancelling verified Puchase order not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Purchase Order already cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblpurchaseorder set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where ponumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString & "'" : com.ExecuteNonQuery()
            Next
            filter()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If     
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdBarAdd.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmDirectCreatePurchaseOrder.Visible = True Then
            frmDirectCreatePurchaseOrder.Focus()
        Else
            frmDirectCreatePurchaseOrder.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        GridView1.ShowFindPanel()
    End Sub
     


    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub
     

    Private Sub ViewInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("PO Number") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("PO Number") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Pending Invoices").ToString = "0" Then
            XtraMessageBox.Show("There's no Pending Invoices to create billing", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmBillingStatement.accountno.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmBillingStatement.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmBillingStatement.txtClient.Properties.ReadOnly = True
        frmBillingStatement.Show(Me)
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("PO Number") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("PO Number") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmStatementOfAccount.mode.Text = "view"
        frmStatementOfAccount.accountno.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmStatementOfAccount.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmStatementOfAccount.txtClient.Properties.ReadOnly = True
        frmStatementOfAccount.Show(Me)
    End Sub

    Private Sub PaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("PO Number") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'If Val(qrysingledata("openbalance", "sum(debit)- sum(credit) as 'openbalance'", "where journalmode='client-accounts' and accountno='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "' and cancelled=0", "tblglaccountledger")) - Val(qrysingledata("payment", "sum(paymentamount) as 'payment'", "where accountno='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "' and verified=0 and cancelled=0", "tblpaymenttransactions")) <= 0 Then
        '    XtraMessageBox.Show("Cannot create client's payment when the balance due is zero or less than zero!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        frmClientPayment.LoadClientInfo()
        frmClientPayment.cifid.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmClientPayment.txtClientAccount.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmClientPayment.txtClientAccount.Properties.ReadOnly = True
        frmClientPayment.Show(Me)
    End Sub

    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmClientTransactionHistory.accountno.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmClientTransactionHistory.Text = "Transaction History of " & StrConv(GridView1.GetFocusedRowCellValue("Client Name").ToString, VbStrConv.ProperCase)
        frmClientTransactionHistory.Show(Me)
    End Sub

    Private Sub cmdColumnFilter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        filter()
    End Sub

 
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckPending.CheckedChanged
        If ckPending.Checked = True Then
            txttodate.Enabled = False
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
        End If
    End Sub
 
    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(Me.Text, "", gridview1, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub UpdateInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInvoiceToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("PO Number").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = False Then
            XtraMessageBox.Show("Purchase order not yet verified", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Paid") = True Then
            XtraMessageBox.Show("Purchase order is already paid", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Cancelled purchase order are not allowed! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmDirectPOUpdateInvoiceDetails.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmDirectPOUpdateInvoiceDetails.txtSupplier.Text = GridView1.GetFocusedRowCellValue("Supplier").ToString
        frmDirectPOUpdateInvoiceDetails.ShowDialog(Me)
    End Sub

    
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub
End Class