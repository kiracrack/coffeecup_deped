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

Public Class frmInventoryFFESummary
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

        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintReport()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)


        loadInventoryTo()

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        If GlobalEnableStockHouse = True Then
            cmdStockHouseInfor.Visible = True
        Else
            cmdStockHouseInfor.Visible = False
        End If
        lblOffice.Text = "Select " & GlobalOfficeCaption
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdStockHouseInfor.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            cmdStockHouseInfor.Visible = False
            ToolStripSeparator2.Visible = False
        End If
    End Sub


    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        If ck_inventory.Checked = True Then
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filterInventory()
        SplashScreenManager.CloseForm()
    End Sub
    Public Sub filterInventory()
        Dim viewalloffices As String = "" : Dim filterasof As String = "" : Dim stockhouse As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If
        If ckasof.Checked = True Then
            filterasof = " and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        'Dim dst As New DataSet
        'msda = New MySqlDataAdapter("Select *,timestampdiff(month, datepurchased, current_date) as 'AsMonth', " _
        '                                    + " format(PERIOD_DIFF(date_format(current_date,'%Y%m'),date_format(datepurchased,'%Y%m'))/12,1) as `AsYear` from tblinventoryffe where actived=1 " & filterasof & viewalloffices, conn)
        'msda.Fill(dst, 0)
        'For cnt = 0 To dst.Tables(0).Rows.Count - 1
        '    With (dst.Tables(0))
        '        If .Rows(cnt)("depreciationmode").ToString() = "0" Then
        '            com.CommandText = "update tblinventoryffe set age='" & .Rows(cnt)("AsYear").ToString() & " Year(s)', bookvalue=" & Val(CC(DepreciationReduce(.Rows(cnt)("total").ToString(), .Rows(cnt)("AsYear").ToString(), .Rows(cnt)("depreciationvalue").ToString()))) & ",depreciationtype='Reducing Balance " & .Rows(cnt)("depreciationvalue").ToString() & "%' where ffecode='" & .Rows(cnt)("ffecode").ToString() & "'" : com.ExecuteNonQuery()
        '        Else
        '            com.CommandText = "update tblinventoryffe set age='" & .Rows(cnt)("AsMonth").ToString() & " Month(s)', bookvalue=" & Val(CC(DepreciationStraight(.Rows(cnt)("total").ToString(), .Rows(cnt)("AsMonth").ToString(), .Rows(cnt)("depreciationvalue").ToString()))) & ",depreciationtype='Straight Line " & .Rows(cnt)("depreciationvalue").ToString() & " Year(s)' where ffecode='" & .Rows(cnt)("ffecode").ToString() & "'" : com.ExecuteNonQuery()
        '        End If
        '    End With
        'Next

        LoadXgrid("Select ffecode as 'FFE Code'," _
                  + " (select officename from tblcompoffice where officeid=tblinventoryffe.officeid) as '" & GlobalOfficeCaption & "' , " _
                  + " productid as 'Product Code', " _
                  + " productname as 'Particular', " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'FFE Type', " _
                  + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                  + " categoryname as 'Category', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalamount as Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as 'Supplier', " _
                  + " if(warranty=1,date_format(warrantydate,'%Y-%m-%d'),'-') as 'Date Warranty', " _
                  + " bookvalue as 'Book Value', monthlydepreciation as 'Monthly Depreciation', date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
                  + " acctableperson as 'Accountable Person', date_format(acctdateissued, '%Y-%m-%d') as 'Date Issued', " _
                  + " case when disposed=1 then 'Disposed' else 'Actived' end as 'Status', " _
                  + " Flaged, " _
                  + " flagedreason as 'Flaged Reason', lockedediting " _
                  + " from tblinventoryffe where disposed=0 " & filterasof & viewalloffices, "tblinventoryffe", Em, GridView1, Me)

        GridView1.Columns(GlobalOfficeCaption).Group()
        GridView1.ExpandAllGroups()
        XgridHideColumn({"lockedediting"}, GridView1)
        XgridColCurrency({"Unit Cost", "Total", "Book Value", "Monthly Depreciation"}, GridView1)
        XgridColAlign({"FFE Code", "Product Code", "Date Purchased", "Status", "Date Warranty", "Last Depreciation Date", "Date Issued"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
        GridView1.Columns("Product Code").Width = 100
        GridView1.Columns("Quantity").Width = 120
        GridView1.Columns("Unit Cost").Width = 150
        GridView1.Columns("Total").Width = 150
        GridView1.Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        SaveFilterColumn(GridView1, Me.Text)

        XgridGroupSummaryCurrency({"Total", "Book Value"}, GridView1)
        XgridGeneralSummaryCurrency({"Total", "Book Value"}, GridView1)
        
  
    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        'If gen_filterappearance = True Then
        '    Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Accountable Person"))
        '    Dim unitstatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
        '    If status = "Not assigned yet" Then
        '        If e.Column.Name = "colAccountablePerson" Then
        '            e.Appearance.ForeColor = Color.Red
        '        End If
        '    End If
        '    If unitstatus = "Inactive" Then
        '        e.Appearance.ForeColor = Color.Red
        '        e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        '    End If
        'End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdaction.PerformClick()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
            PrintSummaryToolStripMenuItem.Enabled = False
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
            If txtInventory.Text = "" Then
                PrintSummaryToolStripMenuItem.Enabled = False
            Else
                PrintSummaryToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        PrintReport()
    End Sub
    Public Sub PrintReport()
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no transaction to print!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfrmdate.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblreportsetting set title='" & rchar(txtReportTitle.Text) & "', customtext='' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()
        Dim report As New rptInventorySummary()

        If ck_inventory.Checked = True Then
        Else
            report.officeid.Text = officeid.Text
        End If
        If ckasof.Enabled = True Then
            If ckasof.Checked = True Then
                report.txtReportPeriod.Text = "As of " & txttodate.Text
            Else
                report.txtReportPeriod.Text = "From " & txtfrmdate.Text & " To " & txttodate.Text
            End If
        Else
            report.txtReportPeriod.Text = "As of " & Format(Now.ToString("MMMM dd, yyyy"))
        End If

        report.txtReportType.Text = "Inventory Summary"
        report.txtReportTitle.Text = UCase(txtReportTitle.Text)
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        report.ShowRibbonPreviewDialog()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintReport()
    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub


    Private Sub cmdUnitInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitInformation.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            frmFFEAccountabilityLog.ffecode.Text = GridView1.GetFocusedRowCellValue("FFE Code").ToString
            If frmFFEAccountabilityLog.Visible = True Then
                frmFFEAccountabilityLog.Focus()
            Else
                frmFFEAccountabilityLog.Show(Me)
            End If
        End If
    End Sub
    Private Sub ColumnChooserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdColumnFilter.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            Dim colname As String = ""
            For I = 0 To GridView1.Columns.Count - 1
                colname += GridView1.Columns(I).FieldName & ","
            Next
            frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
            frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
            frmColumnFilter.ShowDialog(Me)
        End If
    End Sub


    Private Sub cmdViewAttachment_Click(sender As Object, e As EventArgs) Handles cmdViewAttachment.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            ViewAttachmentPackage_Database({GridView1.GetFocusedRowCellValue("FFE Code").ToString}, "")
        End If
    End Sub

    Private Sub SetAttachmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAttachmentToolStripMenuItem1.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            frmSetAttachment.refno.Text = GridView1.GetFocusedRowCellValue("FFE Code").ToString()
            frmSetAttachment.Show(Me)
        End If
    End Sub

    Private Sub AllocatedExpensesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllocated.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            frmHistory_AllocatedExpenses.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
            frmHistory_AllocatedExpenses.refcode.Text = GridView1.GetFocusedRowCellValue("FFE Code").ToString
            frmHistory_AllocatedExpenses.XtraTabControl1.SelectedTabPage.Text = "ALLOCATED EXPENSES REPORT OF " & GridView1.GetFocusedRowCellValue("Particular").ToString
            frmHistory_AllocatedExpenses.Show(Me)
        End If
    End Sub

    Private Sub SetStockHouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStockHouseInfor.Click
        If CheckSelectedRow("FFE Code", GridView1) = True Then
            frmSetStockHouse.trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
            frmSetStockHouse.refcode.Text = GridView1.GetFocusedRowCellValue("FFE Code").ToString
            frmSetStockHouse.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
            frmSetStockHouse.inventorytype.Text = "cffe"
            frmSetStockHouse.Show(Me)
        End If
    End Sub
 

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmFFETypeManagement.ShowDialog(Me)
    End Sub

    Private Sub PrintMemorandumOfReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMemorandumOfReceiptToolStripMenuItem.Click
        PrintFFeMR(GridView1.GetFocusedRowCellValue("FFE Code").ToString, Me)
    End Sub
End Class