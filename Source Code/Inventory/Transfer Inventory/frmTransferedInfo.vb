Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmTransferedInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmTransferNew_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ClearMaster()
    End Sub
    Private Sub frmTransferNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadBatchInformation()
        filterBatch()
        LoadGridviewAppearance(GridView1)
    End Sub
    Public Sub ClearMaster()
        Batchcode.Text = getGlobalTrnid("BT", globaluserid)
        txtInventoryfrom.Text = ""
        txtInventoryto.Text = ""
        txtRequestby.Text = ""
        txtNote.Text = ""
    End Sub
    Public Sub LoadBatchInformation()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'From', " _
                      + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'To', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                      + " (select designation from tblaccounts where accountid = tbltransferbatch.requestby) as 'position', " _
                      + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status' from tbltransferbatch where batchcode='" & Batchcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtInventoryfrom.Text = rst("From").ToString
            txtInventoryto.Text = rst("To").ToString
            txtRequestby.Text = rst("Request By").ToString
            txtDesignation.Text = rst("position").ToString
            txtNote.Text = rst("note").ToString
            inventoryfrom.Text = rst("inventory_from").ToString
            inventoryto.Text = rst("inventory_to").ToString
            txtStatus.Text = StrConv(rst("Status").ToString, vbProperCase)
            lblTitle.Text = StrConv(rst("Status").ToString, vbProperCase) & " Request Transfer"
            If rst("Status").ToString = "Not yet Confirm" Then
                cmdConfirm.Visible = True
                cmdPrint.Visible = False
            Else
                cmdConfirm.Visible = False
                cmdPrint.Visible = True
            End If
        End While
        rst.Close()
    End Sub
    Public Sub filterBatch()
        LoadXgrid("Select trnid,refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid and actived=1 limit 1) as 'Particular', " _
                           + " (select description from tblprocategory inner join tblglobalproducts on tblprocategory.catid = tblprocategory.catid where productid=tbltransferitem.itemid and actived=1 limit 1) as 'Category', " _
                           + " Quantity, " _
                           + " (select unit from tblglobalproducts where PRODUCTID=tbltransferitem.itemid and actived=1 limit 1) as 'Unit', " _
                           + " Remarks " _
                           + " from tbltransferitem where batchcode = '" & Batchcode.Text & "'" _
                           + " order by datetrn asc", "tbltransferitem", Em, GridView1, Me)
        GridView1.BestFitColumns()
        GridView1.Columns("trnid").Visible = False
        GridView1.Columns("refcode").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrency({"Quantity"}, GridView1)
        XgridColAlign({"Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim report As New rptPurchaseRequest()
        report.pid.Text = StrConv(Batchcode.Text, vbUpperCase)
        report.txtRequestby.Text = StrConv(txtRequestby.Text, vbUpperCase)
        report.txtdesignation.Text = txtDesignation.Text
        report.txtoffice.Text = txtInventoryto.Text
        report.txtDateRequest.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        report.txtpurchasetype.Text = UCase(lblTitle.Text)
        report.txtdetails.Text = "Transfer Item From " & StrConv(txtInventoryfrom.Text, vbProperCase) & " to " & StrConv(txtInventoryto.Text, vbProperCase) & " (" & txtNote.Text & ")"
        report.ReportFooter.Visible = False
        'report.TransferRequest()
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If qrysingledata("inventorymethod", "inventorymethod", " where officeid='" & inventoryto.Text & "'", "tblcompoffice") = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Continue confirm batch transfer inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("Select tbltransferitem.*,tblinventory.catid,tblinventory.unit,tblinventory.purchasedprice as unitcost,(select itemname from tblglobalproducts where productid=tblinventory.productid) as 'productname', " _
                                    + " (select description from tblprocategory where catid = tblinventory.catid) as 'categoryname' from tbltransferitem inner join tblinventory on tbltransferitem.refcode = tblinventory.trnid where batchcode='" & Batchcode.Text & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    UpdateInventory("Transfer stock", "", inventoryto.Text, "", "", .Rows(cnt)("itemid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("unitcost").ToString())), "Received from " + LCase(txtInventoryfrom.Text), "", "", Now)
                    StockoutInventory("Transfer stock", .Rows(cnt)("refcode").ToString(), inventoryfrom.Text, .Rows(cnt)("itemid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("unitcost").ToString())), "Transfer to " + LCase(txtInventoryto.Text), globalofficeid, "", "", Now)
                End With
            Next
            com.CommandText = "update tbltransferbatch set confirmed=1, confirmedby='" & globaluserid & "', dateconfirmed=current_timestamp where batchcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
            frmTransferedRequestList.filter()
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Request successfully confirmed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class