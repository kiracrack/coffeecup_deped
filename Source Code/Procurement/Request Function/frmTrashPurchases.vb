Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraSplashScreen

Public Class frmTrashPurchases

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
           

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        ElseIf keyData = (Keys.F3) Then
            menu_View.PerformClick()

        ElseIf keyData = (Keys.F5) Then
            menu_Refresh.PerformClick()

       
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmViewPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me) 
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        loadInventoryTo()
        filter()
        lblOffice.Text = "Select " & GlobalOfficeCaption
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Sub filter()
        Dim viewalloffices As String = "" : Dim filterasof As String = ""
        If ck_inventory.Checked = True Then
            viewalloffices = ""
        Else
            viewalloffices = " and officeid ='" & officeid.Text & "'"
        End If
       
        If ckasof.Checked = True Then
            filterasof = " where date_format(datedeleted,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " where date_format(datedeleted,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("Select officeid,PID as 'Request No', " _
                 + " (select officename from tblcompoffice where officeid = tbldelpurchasetitle.officeid) as '" & GlobalOfficeCaption & "', " _
                 + " (select fullname from tblaccounts where accountid = tbldelpurchasetitle.REQUESTBY) as 'Request By' , " _
                 + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                 + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                 + " (select DESCRIPTION from tblrequesttype where POTYPEID=tbldelpurchasetitle.POTYPEID) as 'Request Type', " _
                 + " ifnull((select sum(total) from tbldelpurchaseitem where purchaseid=tbldelpurchasetitle.pid),0) as 'Total Amount', " _
                 + " (select fullname from tblaccounts where accountid = tbldelpurchasetitle.checkedby) as 'Checked by' , " _
                 + " CASE WHEN STATUS='0' THEN 'Received' WHEN STATUS='1' THEN 'Pending' WHEN STATUS='2' THEN 'Approved' WHEN STATUS='3' THEN 'Disapproved' WHEN STATUS='4' THEN 'Revised' WHEN STATUS='5' THEN 'Draft' END  as 'Request Status', " _
                 + " (select fullname from tblaccounts where accountid = tbldelpurchasetitle.PURCHASER) as 'Purchaser',  " _
                 + "  date_format(datedeleted, '%Y-%m-%d %r') as 'Date Cancelled',  " _
                 + "  Reason, " _
                 + " (select fullname from tblaccounts where accountid = tbldelpurchasetitle.requestdelby) as 'Request Cancel by'  " _
                 + " from tbldelpurchasetitle " _
                 + "  " & filterasof & viewalloffices _
                 + " order by datedeleted desc", "tbldelpurchasetitle", Em, GridView1, Me)
        GridView1.Columns("officeid").Visible = False
        XgridColAlign({"Date Request", "Time Request", "Request Status"}, GridView1, HorzAlignment.Center)

        ' GridView1.Columns("Details").ColumnEdit = MemoEdit
        XgridColCurrency({"Total Amount"}, GridView1)

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total Amount"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:n} Php"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total Amount")
        GridView1.GroupSummary.Add(item1)
        GridView1.BestFitColumns()
        GridView1.Columns("Reason").ColumnEdit = MemoEdit
        GridView1.Columns("Reason").Width = 250
        GridView1.Columns("Total Amount").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Amount").SummaryItem.DisplayFormat = "{0:n} Php"
        GridView1.Columns("Total Amount").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Amount").View, GridView).OptionsView.ShowFooter = True

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Refresh.Click
        filter()
    End Sub

    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        filter()
    End Sub

    Private Sub menuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_View.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            frmTrashItem.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString
            frmTrashItem.Text = "Request for " + GridView1.GetFocusedRowCellValue("Request By").ToString
            frmTrashItem.Show(Me)
        End If
    End Sub

   
    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Me.Close()
    End Sub

    Private Sub ViewAppearanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAppearanceToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
       
    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub ck_inventory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        filter()
    End Sub

    Private Sub BarCheckItem2_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem2.CheckedChanged
        If BarCheckItem2.Checked = True Then
            SplitContainerControl1.Collapsed = False
        Else
            SplitContainerControl1.Collapsed = True
        End If
    End Sub

    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click

    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        menu_View.PerformClick()
    End Sub

    Private Sub RestoreToPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToPendingToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue this action?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblrequisitions select  pid,requestby,officeid,potypeid,details,purchaser,daterequest,approvinglevel, status,dateapproval,checkedby,recievedby,datecieved,reference,remarks, pmtstatus from tbldelpurchasetitle where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblrequisitionsitem select tblrequisitionsitem.* from tbldelpurchaseitem inner join tblrequisitions on tblrequisitionsitem.PURCHASEID = tblrequisitions.PID where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()

            com.CommandText = "delete tbldelpurchaseitem,tbldelpurchasetitle from tbldelpurchaseitem inner join tbldelpurchasetitle on tbldelpurchaseitem.PURCHASEID = tbldelpurchasetitle.PID where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "Delete from tbldelpurchasetitle where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()

            filter()
            XtraMessageBox.Show("Request Successfully Restored!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class