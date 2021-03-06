﻿Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmPurchaseOrder
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub

    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_purchaseorder)
        LoadOffice()
        FilterOption()
    End Sub
    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabOffice Then
            Em.Parent = XtraTabControl1.SelectedTabPage
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
        End If
        filterPurchaseOrder()
    End Sub
    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_purchaseorder, Me)
        gv_purchaseorder.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Function filterPurchaseOrder()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        '#update expired purchase order
        If countqry("tblpurchaseorder", "(dateexpiry<current_date and dateexpiry is not null ) and verified=0 and cancelled=0;") > 0 Then
            com.CommandText = "update tblpurchaseorder set expired=true where (dateexpiry<current_date and dateexpiry is not null ) and verified=0 and cancelled=0;" : com.ExecuteNonQuery()
        End If

        dst.Clear()
        LoadXgrid("Select cast(concat(requestref,vendorid) as char(100)) as relcode, requestref as 'Request No.', officeid,vendorid, ponumber as 'PO Number', " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " ifnull((select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid),'DELETED SUPPLIER') as 'Supplier', " _
                   + " invoiceno as 'Invoice No.', totalamount as 'Total', " _
                   + " totalamount - (select ifnull(sum(tax+amount),0) from tbldisbursementdetails where ponumber = tblpurchaseorder.ponumber) as 'Balance', " _
                   + " case when corporatelevel=1 then 'CORPORATE OFFICE' else '" & UCase(GlobalOfficeCaption) & "' end as 'Request Level', " _
                   + " (select fullname from tblaccounts where accountid = tblpurchaseorder.createby) as 'Created By', " _
                   + " date_format(datetrn,'%Y-%m-%d') as 'Date Created',date_format(datetrn,'%r') as 'Time Created', " _
                   + " verified as Approved, " _
                   + " Forwarded, " _
                   + " Delivered, " _
                   + " paymentrequested as 'Payment Requested', " _
                   + " paymentupdated as Paid, " _
                   + " Closed, " _
                   + PurchaseOrderStatus.Remove(PurchaseOrderStatus.Length - 2, 2) _
                   + " from tblpurchaseorder where " & If(XtraTabControl1.SelectedTabPage Is tabOffice, " corporatelevel=0 ", " corporatelevel=1 ") & " and forpo=1 " & If(ck_inventory.Checked = True, "", " and officeid ='" & officeid.Text & "' ") _
                   + If(ckPendingRequest.Checked = True, " and (verified=0 or paymentupdated=0 or delivered=0 or paymentrequested=0  or closed=0) ", filterasof) & " and cancelled=0 order by datetrn desc", "tblpurchaseorder", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseorder")
        Em.DataSource = dst.Tables("tblpurchaseorder")

        '############## MAIN Gridview #####################

        XgridHideColumn({"relcode", "officeid", "vendorid"}, GridView1)
        GridView1.BestFitColumns()
        XgridColCurrency({"Total"}, GridView1)
        XgridColWidth({"Total", "Balance"}, GridView1, 120)
        XgridColCurrency({"Balance", "Total"}, GridView1)
        XgridColAlign({"Request No.", "PO Number", "Invoice No.", "Date Created", "Time Created", "Status", "Request Level"}, GridView1, HorzAlignment.Center)

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n} Php"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total")

        GridView1.GroupSummary.Add(item1)
        GridView1.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:n}"
        GridView1.Columns("Total").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True
        SaveFilterColumn(GridView1, Me.Text)

    End Function


    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        FilterOption()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmPurchaseOrderProfile.mode.Text = "po"
        frmPurchaseOrderProfile.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmPurchaseOrderProfile.Visible = True Then
            frmPurchaseOrderProfile.Focus()
        Else
            frmPurchaseOrderProfile.Show(Me)
        End If

    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdViewItem.PerformClick()
    End Sub

    Private Sub ChangeApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeApprovalToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "CLOSED" Then
            XtraMessageBox.Show("Closed account not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmChangeApproving.mode.Text = "po"
        frmChangeApproving.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmChangeApproving.Show(Me)
    End Sub

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            LoadOffice()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, XtraTabControl1.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            ckasof.Checked = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
        FilterOption()
    End Sub

  
    Private Sub UpdateInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInvoiceToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("PO Number").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
          
        End If
        frmDirectPOUpdateInvoiceDetails.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        frmDirectPOUpdateInvoiceDetails.txtSupplier.Text = GridView1.GetFocusedRowCellValue("Supplier").ToString
        frmDirectPOUpdateInvoiceDetails.ShowDialog(Me)
    End Sub

    Private Sub ChangeSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSupplierToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmChangeProductSupplier.mode.Text = "po"
            frmChangeProductSupplier.Show(Me)
        End If
    End Sub
    Public Function ChangeSupplier(ByVal vendorid As String)
        Dim newSupplier As String = qrysingledata("companyname", "companyname", "tblglobalvendor where vendorid='" & vendorid & "'")
        com.CommandText = "UPDATE tblpurchaseorder set vendorid='" & vendorid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "UPDATE tblpurchaseorderitem set vendorid='" & vendorid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("PO Number").ToString & "'" : com.ExecuteNonQuery()
        RecordApprovingHistory("purchase order", GridView1.GetFocusedRowCellValue("Request No.").ToString, GridView1.GetFocusedRowCellValue("PO Number").ToString, "processed", "change supplier from " & GridView1.GetFocusedRowCellValue("Supplier").ToString & " to " & newSupplier)
        XtraMessageBox.Show("Supplier successfully changed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        filterPurchaseOrder()
    End Function

     
End Class