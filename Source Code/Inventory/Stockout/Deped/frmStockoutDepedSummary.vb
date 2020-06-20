Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutDepedSummary
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmAccountPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadGridviewAppearance(GridView1)
        FilterStockoutSummary()
    End Sub

    Public Function FilterStockoutSummary()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "where date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = "where date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select batchcode as 'Stockout No.',  (select officename from tblcompoffice where officeid=tblstockoutbatch.inventory) as 'Inventory', " _
                                        + " date_format(datestockout, '%Y-%m-%d') as 'Date Stockout', " _
                                        + " allocatedstockout as 'Allocated Stockout', " _
                                        + " (select officename from tblcompoffice where officeid=tblstockoutbatch.allocatedoffice) as 'Allocated Office'," _
                                        + " (select count(*) from tblstockoutitem where batchcode=tblstockoutbatch.batchcode) as 'Total Item', " _
                                        + " ifnull((select sum(purchasedprice) from tblstockoutitem where batchcode=tblstockoutbatch.batchcode),0) as 'Total Amount', " _
                                        + " (select fullname from tblaccounts where accountid=tblstockoutbatch.requestby) as 'Requested by', " _
                                        + " Remarks, " _
                                        + " date_format(datetrn, '%Y-%m-%d') as 'Date Transactions', " _
                                        + " (select fullname from tblaccounts where accountid=tblstockoutbatch.trnby) as 'Transaction by', " _
                                        + " Verified, " _
                                        + " Cancelled, " _
                                        + " date_format(datecancelled, '%Y-%m-%d') as 'Date Cancelled', " _
                                        + " (select fullname from tblaccounts where accountid=tblstockoutbatch.cancelledby) as 'Cancelled by' " _
                                        + " from tblstockoutbatch  " & If(ckPendingRequest.Checked = True, " where verified=0 and cancelled=0 ", filterasof) & " order by datetrn desc", "tblstockoutbatch", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblstockoutbatch")

        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"Stockout No.", "Date Stockout", "Total Item"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()

        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)

        msda = New MySqlDataAdapter("Select batchcode as 'Stockout No.', (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'Product Name', (select description from tblprocategory where catid=tblstockoutitem.catid) as 'Category', Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',Remarks from tblstockoutitem", conn)
        msda.Fill(dst, "tblstockoutitem")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblstockoutbatch").Columns("Stockout No.")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblstockoutitem").Columns("Stockout No.")

        dst.Relations.Add("StockoutDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("StockoutDetails", BandgridView)

        Em.DataSource = dst.Tables("tblstockoutbatch")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblstockoutitem"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"Stockout No."}, BandgridView)
        XgridColCurrency({"Unit Cost", "Total Cost"}, BandgridView)
        XgridGeneralSummaryCurrency({"Unit Cost", "Total Cost"}, BandgridView)
        XgridColWidth({"Product Name"}, BandgridView, 300)
        XgridColAlign({"Quantity", "Unit"}, BandgridView, HorzAlignment.Center)
        SaveFilterColumn(GridView1, Me.Text)
        Return True
    End Function

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterStockoutSummary()
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
        FilterStockoutSummary()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, Me.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
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
        FilterStockoutSummary()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmVouchersInformation.Show(Me)
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVoucherToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Stockout No.").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            'ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            '    XtraMessageBox.Show("Editing verified Batch Stockout not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Editing cancelled Batch Stockout not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If frmStockoutDepedRequest.Visible = True Then
            frmStockoutDepedRequest.mode.Text = "edit"
            frmStockoutDepedRequest.txtbatchcode.Text = GridView1.GetFocusedRowCellValue("Stockout No.").ToString()
            frmStockoutDepedRequest.Focus()
        Else
            frmStockoutDepedRequest.mode.Text = "edit"
            frmStockoutDepedRequest.txtbatchcode.Text = GridView1.GetFocusedRowCellValue("Stockout No.").ToString()
            frmStockoutDepedRequest.Show(Me)
        End If

    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelVoucherToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Stockout No.").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            'ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            '    XtraMessageBox.Show("Cancelling verified Batch Stockout is not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            '    XtraMessageBox.Show("Batch Stockout already cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently Cancel this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblstockoutbatch set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where batchcode='" & GridView1.GetFocusedRowCellValue("Stockout No.").ToString & "'" : com.ExecuteNonQuery()

            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblstockoutitem where batchcode='" & GridView1.GetFocusedRowCellValue("Stockout No.").ToString & "'", conn)
            msda.Fill(dst, 0)

            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    StockinInventory("Stockout Cancelled", .Rows(cnt)("refcode").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("purchasedprice").ToString())), "cancelled", globalofficeid, "", "", Now)
                    com.CommandText = "update tblstockoutitem set status=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                End With
            Next

            FilterStockoutSummary()
            XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCreateBatch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCreateBatch.ItemClick
        If frmStockoutDepedRequest.Visible = True Then
            frmStockoutDepedRequest.Focus()
        Else
            frmStockoutDepedRequest.Show(Me)
        End If

    End Sub


    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click

        If frmStockoutDepedRequest.Visible = True Then
            frmStockoutDepedRequest.mode.Text = "view"
            frmStockoutDepedRequest.txtbatchcode.Text = GridView1.GetFocusedRowCellValue("Stockout No.").ToString()
            frmStockoutDepedRequest.Focus()
        Else
            frmStockoutDepedRequest.mode.Text = "view"
            frmStockoutDepedRequest.txtbatchcode.Text = GridView1.GetFocusedRowCellValue("Stockout No.").ToString()
            frmStockoutDepedRequest.Show(Me)
        End If
    End Sub
End Class