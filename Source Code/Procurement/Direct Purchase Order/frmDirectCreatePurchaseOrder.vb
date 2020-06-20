Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop

Public Class frmDirectCreatePurchaseOrder
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F4) Then
            Me.Close()
 
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPurchaseOrder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MdiCoffeeCup.cmdNewRequest.Enabled = True

    End Sub

    Private Sub frmDirectPurchaseOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
       UpdatePurchaseOrder() : frmDirectPurchaseOrder.filter()
    End Sub
    Private Sub frmNewPackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        loadCompOffice()
        loadVendors()
        If mode.Text = "edit" Then
            loadPOInformation()
        Else
            createPOnumber()
        End If
        filterCurrentPO()
    End Sub
    Public Sub createPOnumber()
        If GlobalEnableponumbersequence = True Then
            ponumber.ReadOnly = True
            ponumber.Text = getDirectPONumberSequence()
        Else
            ponumber.ReadOnly = False
        End If
    End Sub
    Public Sub loadPOInformation()
        Dim office As String = "" : Dim vendor As String = ""
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as 'office',(select companyname from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'vendor' from tblpurchaseorder where ponumber ='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            office = rst("office").ToString
            vendorid.Text = rst("vendorid").ToString
            vendor = rst("vendor").ToString
            txtNote.Text = rst("note").ToString
        End While
        rst.Close()
        txtoffice.Text = office
        txtVendor.Text = vendor
    End Sub
    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice where enableoperation=1 order by officename", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtoffice.Properties.ValueMember = GlobalOfficeCaption
    End Sub
    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtoffice.Text = txtoffice.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
    End Sub

    Public Sub loadVendors()
        LoadXgridLookupSearch("SELECT vendorid,companyname as 'Vendor' from tblglobalvendor  order by  companyname asc", "tblglobalvendor", txtVendor, gridVendor, Me)
        txtVendor.Properties.PopupFormSize = New Size(480, 350)
        gridVendor.Columns("vendorid").Visible = False
    End Sub
    Private Sub txtsuplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVendor.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
        filterCurrentPO()
    End Sub

 
    Public Sub filterCurrentPO()
            LoadXgrid("Select trnid,productid, " _
                 + " itemname as 'Product', " _
                 + " Quantity, Unit, Cost as 'Unit Price', Total, Remarks from tblpurchaseorderitem " _
                 + " where ponumber='" & ponumber.Text & "'", "tblpurchaseorderitem", Em, GridView1, Me)

            GridView1.Columns("trnid").Visible = False
            GridView1.Columns("productid").Visible = False
            XgridColCurrency({"Unit Price"}, GridView1)
            XgridColCurrency({"Total"}, GridView1)
            GridView1.BestFitColumns()
            GridView1.Columns("Quantity").Width = 60
            GridView1.Columns("Unit Price").Width = 100
            GridView1.Columns("Total").Width = 140
            GridView1.Columns("Remarks").Width = 250

            GridView1.Columns("Remarks").ColumnEdit = MemoEdit
            XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Total"}, GridView1)

    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuclose.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterCurrentPO()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdadd.ItemClick
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtVendor.Text = "" Then
            XtraMessageBox.Show("Please select vendor!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVendor.Focus()
            Exit Sub
        End If
        frmDirectPurchaseOrderItem.officeid.Text = officeid.Text
        frmDirectPurchaseOrderItem.vendorid.Text = vendorid.Text
        frmDirectPurchaseOrderItem.ponumber.Text = ponumber.Text
        frmDirectPurchaseOrderItem.ckCompanyProducts.Text = "View " & StrConv(txtVendor.Text, VbStrConv.ProperCase) & " Products List Only"
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmDirectPurchaseOrderItem.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Unable to continue! there are no item(s) to process!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim poDIR = Application.StartupPath.ToString & "\Purchase Order\" & ConvertDate(Now)
        Dim Template As String = Application.StartupPath.ToString & "\Templates\PurchaseOrderTemplate.xlsx"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Purchase Order\" & ConvertDate(CDate(Now)) & "\" & ponumber.Text & ".xlsx"
        If Not System.IO.Directory.Exists(poDIR) Then
            System.IO.Directory.CreateDirectory(poDIR)
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim xlApp As Excel._Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        xlApp = New Excel.Application
        xlApp.Visible = True
        xlBook = xlApp.Workbooks.Open(SaveLocation)
        xlSheet = xlBook.Sheets(1)

        xlSheet.Cells(2, 1).value = UCase(compname)
        xlSheet.Cells(3, 1).value = compadd
        xlSheet.Cells(4, 1).value = compnumber
 
        xlSheet.Cells(6, 7).value = "PO Number: " & ponumber.Text
        xlSheet.Cells(18, 1).value = globalfullname
        xlSheet.Cells(19, 1).value = globaldesignation

        xlSheet.Cells(18, 3).value = UCase(CompAproveName)
        xlSheet.Cells(19, 3).value = StrConv(compApproveDesig, VbStrConv.ProperCase)

        com.CommandText = "Select * from tblglobalvendor where vendorid='" & vendorid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Cells(7, 2).value = rst("companyname").ToString
            xlSheet.Cells(8, 2).value = rst("compadd").ToString
        End While
        rst.Close()

        Dim StartRow As Integer = 11
        com.CommandText = "select * from tblpurchaseorderitem where ponumber ='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            xlSheet.Rows(StartRow).Insert()
            xlSheet.Cells(StartRow, 1).value = rst("quantity").ToString
            xlSheet.Cells(StartRow, 2).value = rst("itemname").ToString
            xlSheet.Cells(StartRow, 5).value = rst("unit").ToString
            xlSheet.Cells(StartRow, 6).value = rst("cost").ToString
            xlSheet.Cells(StartRow, 7).value = rst("total").ToString
            StartRow = StartRow + 1
        End While
        rst.Close()
        xlBook.Save()

    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdfinish.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Unable to continue! there are no item(s) to process!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GLobalEmailNotifyReceivedPOstock = True And countqry("tblaccounts", "notifyreceivedpostock=1") > 0 Then
                frmDirectPOMessage.ShowDialog(Me)
                If frmDirectPOMessage.confirmedPO = True Then
                    If mode.Text = "edit" Then
                        com.CommandText = "update tblpurchaseorder set subtotal='" & Val(CC(GridView1.Columns("Total").SummaryText)) & "',  note='" & txtNote.Text & "', forpo=1 where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
                    Else
                        SavePurchaseOrder()
                    End If
                    If mode.Text = "edit" Then
                        RecordApprovingHistory("purchase order", ponumber.Text, ponumber.Text, "revised purchase order", frmDirectPOMessage.txtMessage.Text)
                    Else
                        NextEmailPurchaseOrderApprover(ponumber.Text, "1", "")
                        RecordApprovingHistory("purchase order", ponumber.Text, ponumber.Text, "processed", frmDirectPOMessage.txtMessage.Text)
                    End If
                    txtVendor.Properties.DataSource = Nothing : vendorid.Text = "" : txtVendor.Text = "" : txtNote.Text = "" : loadVendors() : filterCurrentPO() : frmDirectPurchaseOrder.filter()
                    XtraMessageBox.Show("Purchase order succesfully revice!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Else
                If mode.Text = "edit" Then
                    com.CommandText = "update tblpurchaseorder set subtotal='" & Val(CC(GridView1.Columns("Total").SummaryText)) & "',  note='" & txtNote.Text & "', forpo=1 where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
                Else
                    SavePurchaseOrder()
                End If
                txtVendor.Properties.DataSource = Nothing : vendorid.Text = "" : txtVendor.Text = "" : txtNote.Text = "" : loadVendors() : filterCurrentPO() : frmDirectPurchaseOrder.filter()
                XtraMessageBox.Show("Purchase order succesfully posted and subject for clearing!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub
    Public Function SavePurchaseOrder()
        Dim requestref As String = getGlobalTrnid("po", globaluserid)
        com.CommandText = "insert into tblpurchaseorder set ponumber='" & ponumber.Text & "', requestref='" & requestref & "', corporatelevel=1, officeid='" & officeid.Text & "', vendorid='" & vendorid.Text & "', subtotal='" & Val(CC(GridView1.Columns("Total").SummaryText)) & "', totalamount='" & Val(CC(GridView1.Columns("Total").SummaryText)) & "',  createby='" & globaluserid & "', datetrn=current_timestamp, note='" & rchar(txtNote.Text) & "',  forpo=1" : com.ExecuteNonQuery()
        com.CommandText = "update tblpurchaseorderitem set requestref='" & requestref & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
        Return True
    End Function
    Public Function UpdatePurchaseOrder()
        com.CommandText = "update tblpurchaseorder set subtotal='" & If(GridView1.RowCount = 0, 0, Val(CC(GridView1.Columns("Total").SummaryText))) & "',  note='" & rchar(txtNote.Text) & "', forpo=1 where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
        Return True
    End Function
    Private Sub EditQuantityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditQuantityToolStripMenuItem.Click
        If CheckSelectedRow("productid", GridView1) = True Then
            frmDirectPurchaseOrderItemSelect.txtItemname.Text = GridView1.GetFocusedRowCellValue("Product").ToString()
            frmDirectPurchaseOrderItemSelect.trnid.Text = GridView1.GetFocusedRowCellValue("trnid").ToString()
            frmDirectPurchaseOrderItemSelect.mode.Text = "edit"
            frmDirectPurchaseOrderItemSelect.officeid.Text = officeid.Text
            frmDirectPurchaseOrderItemSelect.proid.Text = GridView1.GetFocusedRowCellValue("productid").ToString()
            frmDirectPurchaseOrderItemSelect.ponumber.Text = ponumber.Text
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmDirectPurchaseOrderItemSelect.Show(Me)
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                DeleteRow("trnid", "trnid", "tblpurchaseorderitem", GridView1, Me)
            End If
        End If
    End Sub
End Class