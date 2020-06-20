Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmTransferNew
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmDepositNormal_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If GridView1.RowCount <> 0 Then
            If XtraMessageBox.Show("Are you sure you want to cancel current transfer request?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For I = 0 To GridView1.RowCount - 1
                    com.CommandText = "DELETE from tbltransferitem where trnid='" & GridView1.GetRowCellValue(I, "trnid").ToString & "'" : com.ExecuteNonQuery()
                Next
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmTransferNew_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ClearMaster()
    End Sub
    Private Sub frmTransferNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gv_officeinventory)
        LoadGridviewAppearance(gv_transferTo)
        LoadGridviewAppearance(gv_requestby)
        LoadGridviewAppearance(gv_product)
        LoadGridviewAppearance(GridView1)
        Batchcode.Text = getGlobalTrnid("BT", globaluserid)
        trnid.Text = getGlobalTrnid("trn", globaluserid)
        loadOfficeInventory()
        loadRequestBy()
        filterBatch()
    End Sub
    Public Sub ClearMaster()
        Batchcode.Text = getGlobalTrnid("BT", globaluserid)

        txtofficeinventory.Properties.DataSource = Nothing
        txtofficeinventory.Text = "" : fromInventoryId.Text = ""
        loadOfficeInventory()

        txtTransferTo.Properties.DataSource = Nothing
        txtTransferTo.Text = "" : transferto.Text = ""
        loadTransferTo()

        txtRequestby.Properties.DataSource = Nothing
        txtRequestby.Text = "" : txtreqid.Text = ""
        loadRequestBy()

        txtNote.Text = ""
    End Sub
    Public Sub ClearDetail()
        trnid.Text = getGlobalTrnid("trn", globaluserid)
        ReferenceCode.Text = ""
        txtProduct.Properties.DataSource = Nothing
        txtProduct.Text = "" : productid.Text = ""
        loadProducts()

        txtquantity.Text = "1"
        txtUnit.Text = ""
        catid.Text = ""
        txtAvailableQuantity.Text = ""
        txtremarks.Text = ""
        txtProduct.Focus()
        txtProduct.ShowPopup()
    End Sub
    Public Sub loadOfficeInventory()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice order by officename asc", "tblcompoffice", txtofficeinventory, gv_officeinventory, Me)
        txtofficeinventory.Properties.DisplayMember = GlobalOfficeCaption
        txtofficeinventory.Properties.ValueMember = GlobalOfficeCaption
        gv_officeinventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtofficeinventory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtofficeinventory.EditValueChanged
        On Error Resume Next
        fromInventoryId.Text = txtofficeinventory.Properties.View.GetFocusedRowCellValue("officeid").ToString
        If fromInventoryId.Text <> "" Then
            loadProducts()
            loadTransferTo()
        End If
    End Sub

    Public Sub loadTransferTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice where officeid <> '" & fromInventoryId.Text & "' order by officename asc", "tblcompoffice", txtTransferTo, gv_transferTo, Me)
        gv_transferTo.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferTo.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtTransferTo.Properties.View.FocusedRowHandle.ToString)
        transferto.Text = txtTransferTo.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Sub loadRequestBy()
        LoadXgridLookupSearch("SELECT accountid, fullname as 'Fullname',designation as Position from tblaccounts where username <> 'ROOT' order by FULLNAME asc", "tblaccounts", txtRequestby, gv_requestby, Me)
        gv_requestby.Columns("accountid").Visible = False
    End Sub
    Private Sub txtRequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestby.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRequestby.Properties.View.FocusedRowHandle.ToString)
        txtreqid.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtDesignation.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("Position").ToString()
    End Sub
    Public Sub loadProducts()
        txtquantity.Text = "1"
        If fromInventoryId.Text = "" Then Exit Sub
        LoadXgridLookupSearch("SELECT trnid, productname as 'Select', quantity - ifnull((select sum(quantity) from tbltransferitem inner join tbltransferbatch on tbltransferitem.batchcode = tbltransferbatch.batchcode where itemid = tblinventory.productid and inventory_from = '" & fromInventoryId.Text & "' and tbltransferbatch.confirmed=0 and cancelled=0),0) as 'Available Quantity', purchasedprice as UnitCost from tblinventory where quantity > 0 and officeid='" & fromInventoryId.Text & "' order by productname asc ", "tblinventory", txtProduct, gv_product, Me)
        gv_product.Columns("trnid").Visible = False
        XgridColCurrency({"Available Quantity"}, gv_product)
        XgridColAlign({"Available Quantity"}, gv_product, DevExpress.Utils.HorzAlignment.Center)
        'gv_product.Columns("Available Quantity").Width = 120
        'XgridColWidth({"UnitCost", "Available Quantity"}, gv_product, 100)
        XgridColCurrency({"UnitCost"}, gv_product)
    End Sub
    
    Private Sub txtProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProduct.EditValueChanged
        On Error Resume Next
        ReferenceCode.Text = txtProduct.Properties.View.GetFocusedRowCellValue("trnid").ToString()
    End Sub
    Public Sub filterBatch()
        LoadXgrid("Select tbltransferitem.trnid,tbltransferitem.refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Particular', " _
                           + " (select description from tblprocategory where catid=tblinventory.catid) as 'Category', " _
                           + " tbltransferitem.Quantity, tblinventory.Unit, unitcost as 'Unit Cost', " _
                           + " tbltransferitem.quantity*unitcost as 'Total Cost', " _
                           + If(EnableModuleSales = True, "sellingprice as 'Selling Cost', ", "") _
                           + " tbltransferitem.Remarks " _
                           + " from tbltransferitem inner join tblinventory on tbltransferitem.refcode = tblinventory.trnid where batchcode = '" & Batchcode.Text & "' and tbltransferitem.trnby='" & globaluserid & "' " _
                           + " order by datetrn asc", "tbltransferitem", Em, GridView1, Me)

        GridView1.BestFitColumns()
        GridView1.Columns("trnid").Visible = False
        GridView1.Columns("refcode").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        RemovedNoValueColumn("Remarks", GridView1, Me)
        XgridColCurrency({"Quantity", "Unit Cost", "Total Cost"}, GridView1)
        If EnableModuleSales = True Then
            XgridColCurrency({"Selling Cost"}, GridView1)
        End If
        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub
    Private Sub cmdstckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If txtofficeinventory.Text = "" Then
            XtraMessageBox.Show("Please select from inventory!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferTo.Focus()
            Exit Sub
        ElseIf txtProduct.Text = "" Then
            XtraMessageBox.Show("Please select Item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        ElseIf txtquantity.Text = "" Or Val(CC(txtquantity.Text)) < 1 Then
            XtraMessageBox.Show("Please enter valid quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtquantity.Text)) > Val(txtAvailableQuantity.Text) Then
            XtraMessageBox.Show("Maximum quantity is " & FormatNumber(txtAvailableQuantity.Text, 2) & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into tbltransferitem set  " _
                                + " batchcode='" & Batchcode.Text & "', " _
                                + " refcode='" & ReferenceCode.Text & "', " _
                                + " itemid='" & productid.Text & "', " _
                                + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                                + " unitcost='" & Val(CC(txtUnitCost.Text)) & "', " _
                                + " remarks='" & rchar(txtremarks.Text) & "', " _
                                + " trnby='" & globaluserid & "', " _
                                + " datetrn=current_timestamp" : com.ExecuteNonQuery()
        ClearDetail()
        filterBatch()
    End Sub
    Private Sub referenceNo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenceCode.EditValueChanged
        com.CommandText = "select * from tblinventory where trnid = '" & ReferenceCode.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            productid.Text = rst("productid").ToString
            catid.Text = rst("catid").ToString
            txtUnit.Text = rst("unit").ToString
            txtAvailableQuantity.Text = rst("quantity").ToString
            txtquantity.Text = rst("quantity").ToString
            txtUnitCost.Text = rst("purchasedprice").ToString
        End While
        rst.Close()

        If txtProduct.Text = "" Then
            txtquantity.Enabled = False
        Else
            txtquantity.Enabled = True
        End If
        txtquantity.Focus()
    End Sub

    Private Sub txtUnitCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnitCost.EditValueChanged
        Calculator()
    End Sub

    Public Sub Calculator()
        txtTotalCost.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtquantity.Text)))
    End Sub
    Private Sub txtquantity_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtquantity.EditValueChanged
        If txtquantity.Text = "" Or Val(CC(txtquantity.Text)) < 1 Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        Else
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
        End If
        Calculator()
    End Sub
 
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("Theres no item to transfer!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProduct.Focus()
            Exit Sub
        ElseIf txtofficeinventory.Text = "" Then
            XtraMessageBox.Show("Please select from inventory!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferTo.Focus()
            Exit Sub
        ElseIf txtTransferTo.Text = "" Then
            XtraMessageBox.Show("Please select transfer to!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransferTo.Focus()
            Exit Sub
        ElseIf txtRequestby.Text = "" Then
            XtraMessageBox.Show("Please select request by!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRequestby.Focus()
            Exit Sub
        ElseIf txtNote.Text = "" Then
            XtraMessageBox.Show("Please enter note for receiver!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNote.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Continue to create request batch transfer?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            com.CommandText = "insert into tbltransferbatch set batchcode='" & Batchcode.Text & "', " _
                                   + " inventory_from='" & fromInventoryId.Text & "', " _
                                   + " inventory_to='" & transferto.Text & "', " _
                                   + " note='" & txtNote.Text & "', " _
                                   + " requestby='" & txtreqid.Text & "', " _
                                   + " datetransfer=current_timestamp, " _
                                   + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            com.CommandText = "update tbltransferitem set status=0 where batchcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
            ClearMaster() : filterBatch()
            frmTransferedRequestList.filter()
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Transfer request successfully created", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim report As New rptPurchaseRequest()
        report.pid.Text = Batchcode.Text
        report.txtRequestby.Text = StrConv(txtRequestby.Text, vbUpperCase)
        report.txtdesignation.Text = txtDesignation.Text
        report.txtoffice.Text = txtTransferTo.Text
        report.officeid.Text = fromInventoryId.Text
        report.txtDateRequest.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        report.txtpurchasetype.Text = UCase(lblTitle.Text)
        report.txtdetails.Text = "Transfer Item from " & StrConv(txtofficeinventory.Text, vbProperCase) & " to " & StrConv(txtTransferTo.Text, vbProperCase) & " (" & txtNote.Text & ")"
        report.ReportFooter.Visible = True
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub RemoveParticularToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveParticularToolStripMenuItem.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to remove this item?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblinventory set quantity= quantity+" & Val(CC(GridView1.GetFocusedRowCellValue("Quantity").ToString)) & " where trnid='" & GridView1.GetFocusedRowCellValue("refcode").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE from tbltransferitem where trnid='" & GridView1.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
                loadProducts()
                filterBatch()
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterBatch()
    End Sub

End Class