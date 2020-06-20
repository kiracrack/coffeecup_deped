Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutDepedRequest
    Private tempID As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = Keys.F2 Then
            If mode.Text <> "view" Then
                menuInventory.PerformClick()
            End If
        ElseIf keyData = Keys.Delete Then
            If mode.Text <> "view" Then
                toolRemove.PerformClick()
            End If
        ElseIf keyData = Keys.F3 Then
            If mode.Text <> "view" Then
                menuClear.PerformClick()
            End If
        ElseIf keyData = Keys.Control + Keys.S Then
            If mode.Text <> "view" Then
                cmdSaveDraft.PerformClick()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmNewStockout_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        mode.Text = ""
    End Sub

    Public Sub FilterNew()
        LoadXgrid("Select id,refcode,officeid,productid, (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + "  (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                            + " Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost', Remarks " _
                            + " from tblstockoutitem where batchcode='" & txtbatchcode.Text & "' ", "tblstockoutitem", Cm, Gridview1, Me)

        XgridHideColumn({"id", "refcode", "officeid", "productid"}, Gridview1)
        XgridColCurrency({"Unit Cost", "Total Cost"}, Gridview1)
        XgridColAlign({"Quantity", "Stockout Date"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolRemove.Click
        If CheckSelectedRow("refcode", Gridview1) = True Then
            If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "DELETE from tblstockoutitem where id='" & Gridview1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                StockinInventory("Stockout Cancelled", Gridview1.GetFocusedRowCellValue("refcode").ToString, Gridview1.GetFocusedRowCellValue("officeid").ToString, Gridview1.GetFocusedRowCellValue("productid").ToString, Val(CC(Gridview1.GetFocusedRowCellValue("Quantity").ToString)), Val(CC(Gridview1.GetFocusedRowCellValue("Unit Cost").ToString)), Gridview1.GetFocusedRowCellValue("Remarks").ToString, globalofficeid, "", "", Now)
                FilterNew()
            End If
        End If
    End Sub

    Private Sub frmStockoutBatchRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblstockoutitem", "batchcode='" & txtbatchcode.Text & "'") > 0 Then
            If countqry("tblstockoutbatch", "batchcode='" & txtbatchcode.Text & "'") = 0 Then
                If XtraMessageBox.Show("System found there are transaction item currently not saved! Please save your transaction or it will cancel your current stockout?" + Environment.NewLine + "Important Note: current stockout data will be lost!" & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    msda = Nothing : dst = New DataSet
                    msda = New MySqlDataAdapter("select * from tblstockoutitem where batchcode='" & txtbatchcode.Text & "'", conn)
                    msda.Fill(dst, 0)
                    For cnt = 0 To dst.Tables(0).Rows.Count - 1
                        With (dst.Tables(0))
                            com.CommandText = "DELETE from tblstockoutitem where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            StockinInventory("Stockout Cancelled", .Rows(cnt)("refcode").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("Quantity").ToString())), Val(CC(.Rows(cnt)("purchasedprice").ToString())), "cancelled", globalofficeid, "", "", Now)
                        End With
                    Next
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmWidrawalPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(Gridview1)
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(gridallocatedoffice)
        txtDateStockout.Text = CDate(Now.ToShortDateString)
        If mode.Text = "edit" Then
            txtRemarks.Properties.ReadOnly = False
            txtoffice.Properties.ReadOnly = False
            cmdSaveAndFinish.Visible = True
            menuInventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            menuClear.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSaveDraft.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Cm.ContextMenuStrip = Mainmenu
            ShowInfo()

        ElseIf mode.Text = "view" Then
            txtRemarks.Properties.ReadOnly = True
            txtoffice.Properties.ReadOnly = True
            cmdSaveAndFinish.Visible = False
            menuInventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            menuClear.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSaveDraft.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Cm.ContextMenuStrip = Nothing
            ShowInfo()
        Else
            clearfields()
            txtRemarks.Properties.ReadOnly = False
            txtoffice.Properties.ReadOnly = False
            cmdSaveAndFinish.Visible = True
            menuInventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            menuClear.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSaveDraft.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Cm.ContextMenuStrip = Mainmenu
        End If
        FilterNew()
        loadCompOffice()
        loadAllocatedCompOffice()
        loadrequestdby()
    End Sub

    Public Sub loadrequestdby()
        LoadXgridLookupSearch("SELECT accountid, Fullname from tblaccounts where username <> 'ROOT' and deleted=0 order by FULLNAME asc", "tblaccounts", txtRequestby, g_requestor, Me)
        g_requestor.Columns("accountid").Visible = False
    End Sub
    Private Sub txtRequestor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRequestby.EditValueChanged
        On Error Resume Next
        requestorid.Text = txtRequestby.Properties.View.GetFocusedRowCellValue("accountid").ToString()
    End Sub

    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False

    End Sub
    Private Sub txtoffice_EditValueChanged(sender As Object, e As EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        
    End Sub

    Public Sub clearfields()
        If mode.Text <> "edit" Then
            stockoutno.Text = getLastTransactionID("stockoutno", "stockoutno", "tblstockoutbatch where date_format(datestockout,'%Y')='" & CDate(txtDateStockout.EditValue).Year & "'")
            txtbatchcode.Text = getLastTransactionID("stockoutno", "stockoutno", "tblstockoutbatch")
        End If
        txtoffice.Properties.DataSource = Nothing
        txtoffice.Text = ""
        officeid.Text = ""
        txtOfficeAllocated.Text = ""
        allocatedofficeid.Text = ""
        txtRemarks.Text = ""
        mode.Text = ""
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuClear.ItemClick
        If XtraMessageBox.Show("Are you sure you want to cancel current transaction?" + Environment.NewLine + "Important Note: current transaction data will be lost!" & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            clearfields()
        End If
    End Sub

    Public Sub ShowInfo()
        If mode.Text = "edit" Or mode.Text = "view" Then
            Dim alloc As Boolean = False : Dim allocaofice As String = "" : Dim allocated_officeid As String = ""
            com.CommandText = "select *, (select officename from tblcompoffice where officeid = tblstockoutbatch.inventory) as inventoryfrom, " _
                                        + " (select fullname from tblaccounts where accountid = tblstockoutbatch.requestby) as request_by, " _
                                        + " (select officename from tblcompoffice where officeid = tblstockoutbatch.allocatedoffice) as officeallocated, " _
                                         + " (select initialcode from tblcompoffice where officeid = tblstockoutbatch.allocatedoffice) as centercode " _
                                        + " from tblstockoutbatch where batchcode = '" & txtbatchcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                stockoutno.Text = rst("stockoutno").ToString
                txtoffice.Text = rst("inventoryfrom").ToString
                officeid.Text = rst("inventory").ToString
                txtCentercode.Text = rst("centercode").ToString
                txtDateStockout.EditValue = CDate(rst("datestockout").ToString)
                alloc = rst("allocatedstockout")
                allocaofice = rst("officeallocated").ToString
                allocated_officeid = rst("allocatedoffice").ToString
                requestorid.Text = rst("requestby").ToString
                txtRequestby.Text = rst("request_by").ToString
                txtRemarks.Text = rst("remarks").ToString
                If CBool(rst("cancelled")) = True Then
                    cmdPrint.Visible = False
                Else
                    cmdPrint.Visible = True
                End If
            End While
            rst.Close()
            ckAllocatedStockout.Checked = alloc
            txtOfficeAllocated.Text = allocaofice
            allocatedofficeid.Text = allocated_officeid
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSaveDraft.ItemClick
        ConfirmedStockout(False)
    End Sub


    Public Sub ConfirmedStockout(ByVal verified As Boolean)
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please office inventory!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtOfficeAllocated.Text = "" And ckAllocatedStockout.Checked = True Then
            XtraMessageBox.Show("Please select allocated office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeAllocated.Focus()
            Exit Sub
        End If
        If verified = True Then
            If XtraMessageBox.Show("Are you sure you want to finish current transaction?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Else
                Exit Sub
            End If
        End If
        If countqry("tblstockoutbatch", "batchcode='" & txtbatchcode.Text & "'") = 0 Then
            com.CommandText = "INSERT into tblstockoutbatch set batchcode ='" & txtbatchcode.Text & "', " _
                         + " stockoutno='" & stockoutno.Text & "'," _
                         + " inventory='" & officeid.Text & "', " _
                         + " datestockout='" & ConvertDate(txtDateStockout.EditValue) & "'," _
                         + " allocatedstockout=" & ckAllocatedStockout.CheckState & ", " _
                         + " allocatedoffice='" & allocatedofficeid.Text & "', " _
                         + " remarks='" & rchar(txtRemarks.Text) & "', " _
                         + " requestby='" & requestorid.Text & "', " _
                         + " datetrn=current_timestamp, " _
                         + " trnby='" & globaluserid & "', " _
                         + " verified=" & verified & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblstockoutbatch set " _
                         + " stockoutno='" & stockoutno.Text & "'," _
                         + " inventory='" & officeid.Text & "', " _
                         + " datestockout='" & ConvertDate(txtDateStockout.EditValue) & "'," _
                         + " allocatedstockout=" & ckAllocatedStockout.CheckState & ", " _
                         + " allocatedoffice='" & allocatedofficeid.Text & "', " _
                         + " requestby='" & requestorid.Text & "', " _
                         + " remarks='" & rchar(txtRemarks.Text) & "', " _
                         + " datetrn=current_timestamp, " _
                         + " trnby='" & globaluserid & "', " _
                         + " verified=" & verified & " where batchcode='" & txtbatchcode.Text & "'" : com.ExecuteNonQuery()
        End If
        If verified = True Then
            frmStockoutDepedSummary.FilterStockoutSummary()
            XtraMessageBox.Show("Stockout request successfully verified!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            frmStockoutDepedSummary.FilterStockoutSummary()
            XtraMessageBox.Show("Stockout request successfully saved as draft!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterNew()
    End Sub

    Private Sub ViewAppearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAppearanceToolStripMenuItem.Click
        frmUserProfile.formatGrid(Gridview1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdSaveAndFinish.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        ConfirmedStockout(True)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllocatedStockout.CheckedChanged
        If ckAllocatedStockout.Checked = True Then
            txtOfficeAllocated.Properties.DataSource = Nothing
            txtOfficeAllocated.Text = ""
            allocatedofficeid.Text = ""
            loadAllocatedCompOffice()
            txtOfficeAllocated.Properties.ReadOnly = False
        Else
            txtOfficeAllocated.Properties.DataSource = Nothing
            txtOfficeAllocated.Text = ""
            allocatedofficeid.Text = ""
            txtOfficeAllocated.Properties.ReadOnly = True
        End If
    End Sub

    Public Sub loadAllocatedCompOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select Office',initialcode from tblcompoffice order by officename asc", "tblcompoffice", txtOfficeAllocated, gridallocatedoffice, Me)
        gridallocatedoffice.Columns("officeid").Visible = False
        gridallocatedoffice.Columns("initialcode").Visible = False

    End Sub
    Private Sub txtOfficeAllocated_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficeAllocated.EditValueChanged
        On Error Resume Next
        allocatedofficeid.Text = txtOfficeAllocated.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtCentercode.Text = txtOfficeAllocated.Properties.View.GetFocusedRowCellValue("initialcode").ToString
    End Sub

    Private Sub menuInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuInventory.ItemClick
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please office inventory!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtOfficeAllocated.Text = "" And ckAllocatedStockout.Checked = True Then
            XtraMessageBox.Show("Please select allocated office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeAllocated.Focus()
            Exit Sub
        End If
        frmStockoutDepedInventory.mode.Text = "batch"
        frmStockoutDepedInventory.officeid.Text = officeid.Text
        frmStockoutDepedInventory.batchcode.Text = txtbatchcode.Text
        frmStockoutDepedInventory.alllocatedofficeid.Text = allocatedofficeid.Text
        frmStockoutDepedInventory.txtDate.Text = txtDateStockout.Text
        frmStockoutDepedInventory.ShowDialog(Me)
    End Sub

    Private Sub cmdSaveOnly_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        GenerateStockoutDepedTemplate(txtOfficeAllocated.Text, txtCentercode.Text, stockoutno.Text, txtDateStockout.EditValue, requestorid.Text, txtRemarks.Text, Me)
    End Sub

End Class