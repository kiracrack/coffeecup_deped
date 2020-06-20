Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class frmDepedFFESummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)

        loadInventoryTo()
        loadAccountable
        loadProduct()
        filterInventory()

    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        If officeid.Text <> "" Then
            loadAccountable()
        End If
    End Sub

    Public Sub loadAccountable()
        If officeid.Text = "" Then
            LoadXgridLookupSearch("SELECT accountid as code, fullname as 'Select' from tblaccounts where accountid in (select accountable from tblofficeequipment) order by fullname asc", "tblaccounts", txtaccountablePerson, gridAccountable, Me)
        Else
            LoadXgridLookupSearch("SELECT accountid as code, fullname as 'Select' from tblaccounts where accountid in (select accountable from tblofficeequipment where officeid='" & officeid.Text & "') order by fullname asc", "tblaccounts", txtaccountablePerson, gridAccountable, Me)
        End If
        gridAccountable.Columns("code").Visible = False
    End Sub

    Private Sub txtaccountablePerson_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaccountablePerson.EditValueChanged
        On Error Resume Next
        txtaccountableid.Text = txtaccountablePerson.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Sub loadProduct()
        LoadXgridLookupSearch("SELECT productid as code, productname as 'Select' from tblofficeequipment group by productid order by productname asc", "tblofficeequipment", txtProduct, gridProduct, Me)
        gridProduct.Columns("code").Visible = False
    End Sub
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        productid.Text = txtProduct.Properties.View.GetFocusedRowCellValue("code").ToString()

    End Sub


    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        If txtTemplate.Text = "" And ckTemplate.Checked = False Then
            XtraMessageBox.Show("Please select template!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTemplate.Focus()
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterInventory()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterInventory()
        'If txtTemplate.Text = "" Then Exit Sub
        Dim viewalloffices As String = "" : Dim accountable As String = "" : Dim stockhouse As String = "" : Dim product As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If

        If ckAccountable.Checked = True Then
            accountable = ""
        Else
            accountable = " and accountable ='" & txtaccountableid.Text & "'"
        End If

        If ckProduct.Checked = True Then
            product = ""
        Else
            product = " and productid ='" & productid.Text & "'"
        End If
        Dim template As String = ""
        If ckTemplate.Checked = False Then
            If txtTemplate.SelectedIndex = 0 Then
                template = " and unitcost <=15000"
            ElseIf txtTemplate.SelectedIndex = 1 Then
                template = " and unitcost >15000"
            End If
        End If
        'Product Code,Article,Model,Description
        LoadXgrid("Select id as 'Entry Code', issuereference as " & If(ckTemplate.Checked = True, "'ICS/PAR No.'", If(txtTemplate.SelectedIndex = 0, "'ICS No.'", "'PAR No.'")) & ", officeid," _
                  + " (select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as 'Office' , " _
                  + " productid as 'Product Code', " _
                  + " (select DESCRIPTION from tblprosubcategory where subcatid = tblofficeequipment.subcatid) as 'Article', " _
                  + " (select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as 'Model', " _
                  + " serialnumber as 'Serial Number', " _
                  + " productname as 'Description', " _
                  + " (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as 'Accountable Person'," _
                  + " productdetails as 'Equipment Details', " _
                  + " if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as 'Property Number', " _
                  + " unitstatus as 'Unit Status', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalcost as Total, estimatedlife as 'Estimated Used Life', date_format(dateacquired, '%Y-%m-%d') as 'Date Acquired', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblofficeequipment.vendorid) as 'Supplier' " _
                  + " from tblofficeequipment where id <>'' " & viewalloffices & accountable & product & template & " order by productname asc", "tblofficeequipment", Em, GridView1, Me)

        'GridView1.Columns("Office").Group()
        'GridView1.ExpandAllGroups()

        XgridHideColumn({"officeid"}, GridView1)
        XgridColCurrency({"Unit Cost", "Total"}, GridView1)
        XgridColAlign({"Entry Code", "Product Code", "Date Acquired", "Serial Number", "Model", "Property Tag", "Property Number", "Unit Status", "Estimated Used Life", "ICS/PAR No.", "ICS No.", "PAR No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
        GridView1.Columns("Entry Code").Width = 100
        GridView1.Columns("Product Code").Width = 100
        GridView1.Columns("Quantity").Width = 120
        GridView1.Columns("Unit Cost").Width = 150
        GridView1.Columns("Total").Width = 150
        GridView1.Columns("Equipment Details").ColumnEdit = MemoEdit

        GridView1.Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center

        XgridGroupSummaryCurrency({"Total"}, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        ShowPrintButton()
    End Sub
    
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

  
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
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

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmDepEdAddFEE.Show(Me)
    End Sub

    Private Sub EditEquimentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEquimentToolStripMenuItem.Click
        frmDepEdAddFEE.id.Text = GridView1.GetFocusedRowCellValue("Entry Code").ToString
        frmDepEdAddFEE.mode.Text = "edit"
        frmDepEdAddFEE.Show(Me)
    End Sub

    Private Sub ckAccountable_CheckedChanged(sender As Object, e As EventArgs) Handles ckAccountable.CheckedChanged
        If ckAccountable.Checked = True Then
            txtaccountablePerson.Enabled = False
        Else
            txtaccountablePerson.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintCustodian.ItemClick
        If MessageBox.Show("Are you sure you want to print as issuance? ICS Number will generate ang increment for next report. Select NO for print view only", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            GenerateInventoryCustodianSlip(txtaccountableid.Text, GridView1, True, Me)
        Else
            GenerateInventoryCustodianSlip(txtaccountableid.Text, GridView1, False, Me)
        End If
    End Sub

    Private Sub PrintStickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintStickerToolStripMenuItem.Click
        If GridView1.SelectedRowsCount > 1 Then
            
            Dim selected As String = ""
            For I = 0 To GridView1.SelectedRowsCount - 1
                selected += "id=" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code").ToString & " or "
            Next

            msda = Nothing : dsreport = New DataSet
            msda = New MySqlDataAdapter("select * from tblofficeequipment where (" & selected.Remove(selected.Length - 3, 3) & ")", conn)
            msda.Fill(dsreport, 0)

            int_report = 2 'chạy cái subreport
            Dim f As New frmReportDesigner
            f.Show()
        Else
            int_report = 1 'chạy report đơn
            strMaNV = GridView1.GetFocusedRowCellValue("Entry Code").ToString
            Dim f As New frmReportDesigner
            f.Show()
        End If
       
    End Sub

    Public Sub ShowPrintButton()
        If txtTemplate.SelectedIndex = 0 Then
            cmdPAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If txtaccountableid.Text = "" Then
                cmdPrintCustodian.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If GridView1.RowCount > 0 Then
                    cmdPrintCustodian.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If
            End If
        ElseIf txtTemplate.SelectedIndex = 1 Then
            cmdPrintCustodian.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If txtaccountableid.Text = "" Then
                cmdPAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If GridView1.RowCount > 0 Then
                    cmdPAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If
            End If
        End If
       
    End Sub

    Private Sub cmdPAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPAR.ItemClick
        If MessageBox.Show("Are you sure you want to print as issuance? ICS Number will generate ang increment for next report. Select NO for print view only", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            GeneratePropertyAcknowledgementReceipt(txtaccountableid.Text, GridView1, True, Me)
        Else
            GeneratePropertyAcknowledgementReceipt(txtaccountableid.Text, GridView1, False, Me)
        End If

    End Sub

    Private Sub PulloutItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PulloutItemToolStripMenuItem.Click
        For I = 0 To GridView1.SelectedRowsCount - 1
            If countqry("tblofficeequipmentpulloutitem", "trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code").ToString & "' and trncode=''") = 0 Then
                Dim trncode As String = ""
                If frmPulloutForm.Visible = True Then
                    trncode = frmPulloutForm.trncode.Text
                End If
                com.CommandText = "insert into tblofficeequipmentpulloutitem set trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code").ToString & "',originoffice='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid").ToString & "', trncode='" & trncode & "', " _
                    + " productid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Product Code").ToString & "', itemname='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Description").ToString & "', qty='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Quantity").ToString & "', " _
                    + " unit='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Unit").ToString & "'" : com.ExecuteNonQuery()
            End If

        Next
        If GridView1.SelectedRowsCount = 0 Then
            MessageBox.Show("Please select atleast one on the item list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If frmPulloutForm.Visible = True Then
            frmPulloutForm.LoadTemporaryItem()
            frmPulloutForm.Focus()
        Else
            frmPulloutForm.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form
        PrintDatagridview(Me.Text, "DATABASE RECORDS", If(ck_inventory.Checked = True, "ALL INVENTORY", "OFFICE: " & txtInventory.Text) & "<br/>" & If(ckAccountable.Checked = True, "ALL ACCOUNTABLE", "ACCOUNTABLE: " & txtaccountablePerson.Text) & "<br/>" & If(ckProduct.Checked = True, "ALL PRODUCTS", "PRODUCT NAME: " & txtProduct.Text), GridView1, Me)
    End Sub

    Private Sub ckProduct_CheckedChanged(sender As Object, e As EventArgs) Handles ckProduct.CheckedChanged
        If ckProduct.Checked = True Then
            txtProduct.Enabled = False
            cmdPrintPropertyCard.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            txtProduct.Enabled = True
            cmdPrintPropertyCard.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ckTemplate_CheckedChanged(sender As Object, e As EventArgs) Handles ckTemplate.CheckedChanged
        If ckTemplate.Checked = True Then
            txtTemplate.Enabled = False
        Else
            txtTemplate.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmEquipmentReport.ShowDialog(Me)
    End Sub

    Private Sub SetSequenceNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSequenceNoToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Entry Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmUpdateVotersListing.txtTotalSelected.Text = GridView1.SelectedRowsCount - 1
        If frmUpdateVotersListing.Visible = True Then
            frmUpdateVotersListing.Focus()
        Else
            frmUpdateVotersListing.Show(Me)
        End If
    End Sub

    Public Function UpdateListingNo(ByVal beginNo As Integer)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblofficeequipment set sequenceno='" & beginNo & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "'" : com.ExecuteNonQuery()
            'GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "No.", beginNo)
            beginNo += 1
        Next
        filterInventory()
        Return 0
    End Function

    'productid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("productid").ToString()
    '  txtUnit.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("Unit").ToString()
    '  catid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("catid").ToString()
    '  subcatid.Text = txtProductItemName.Properties.View.GetFocusedRowCellValue("subcatid").ToString()

    Public Function UpdateProduct(ByVal productid As String, ByVal productname As String, ByVal codename As String, ByVal unit As String, ByVal catid As String, ByVal subcatid As String, ByVal modelid As String, ByVal modelName As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            Dim GetCategoryname As String = qrysingledata("description", "description", "tblprocategory where catid='" & catid & "'")
            Dim GetSubCategoryname As String = qrysingledata("description", "description", "tblprosubcategory where subcatid='" & subcatid & "'")

            com.CommandText = "update tblofficeequipment set productid='" & productid & "', productname='" & rchar(productname) & "', codename='" & codename & "', catid='" & catid & "',subcatid='" & subcatid & "', unit='" & unit & "', modelid='" & modelid & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code") & "'" : com.ExecuteNonQuery()
            'Product Code,Article,Model,Description
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Product Code", productid)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Article", GetSubCategoryname)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Model", modelName)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Description", productname)
        Next
        Return 0
    End Function

    Private Sub UpdateProductBatchingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProductBatchingToolStripMenuItem.Click
        frmUpdateBatchEquipment.ShowDialog(Me)
    End Sub

    Private Sub DeleteEquipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEquipmentToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblofficeequipment where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Entry Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            filterInventory()
        End If
    End Sub

    Private Sub cmdPrintPropertyCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrintPropertyCard.ItemClick
        Dim category As String = qrysingledata("category", "(select description from tblprocategory where catid=tblglobalproducts.catid) as category", "where productid='" & productid.Text & "'", "tblglobalproducts")
        GeneratePropertyCard(productid.Text, txtProduct.Text, category, If(txtTemplate.SelectedIndex = 0, "ICS", "PAR"), Me)
    End Sub
End Class