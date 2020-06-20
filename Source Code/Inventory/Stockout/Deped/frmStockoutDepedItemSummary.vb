Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmStockoutDepedItemSummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTransferedItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        loadInventoryTo()
        filter()
        LoadGridviewAppearance(gv_Office)
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub

    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datestockout,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datestockout,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("select id as 'Series No.',concat(date_format(datestockout,'%Y-%m'),'-',tblstockoutbatch.stockoutno) as 'RIS No.',  (select officename from tblcompoffice where officeid = tblstockoutitem.officeid) as '" & GlobalOfficeCaption & "', " _
                         + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                         + " (select description from tblstockouttype where stockouttypeid = tblstockoutitem.stockouttypeid) as 'Stockout Type', " _
                         + " allocatedstock as 'Allocated', " _
                         + " if(allocatedstock=1,(select officename from tblcompoffice where officeid = tblstockoutitem.allocatedofficeid),'') as 'Allocated Office', " _
                         + " Quantity, Unit, purchasedprice as 'Unit Price', (purchasedprice*quantity) as 'Total', tblstockoutitem.Remarks, " _
                         + " (select fullname as FULLNAME from tblaccounts where accountid=tblstockoutitem.requestby) as 'Requested by', " _
                         + " (select fullname from tblaccounts where accountid = tblstockoutitem.trnby) as 'Transaction By', " _
                         + " date_format(datestockout,'%Y-%m-%d') as 'Stockout Date' " _
                         + " from tblstockoutitem inner join tblstockoutbatch on tblstockoutitem.batchcode = tblstockoutbatch.batchcode where id<>'' " & If(ck_inventory.Checked = True, "", " and officeid='" & officeid.Text & "' ") & filterasof & " and cancelled=0 order by datestockout desc", "tblstockoutitem", Em, GridView1, Me)

        XgridColAlign({"Series No.", "RIS No.", "Quantity", "Unit", "Stockout Date", "Stockout Time"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridColCurrency({"Unit Price", "Total"}, GridView1)
        XgridGroupSummaryCurrency({"Total"}, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        XgridColWidth({"Unit Price", "Total"}, GridView1, 90)
    End Sub


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region


    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        filter()
    End Sub

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub ckasof_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If LCase(GlobalReportTemplate) = "deped" Then
            Dim filterasof As String = ""
            If ckasof.Checked = True Then
                filterasof = " where date_format(datestockout,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
            Else
                filterasof = " where date_format(datestockout,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
            End If
            GenerateDepedRSMITemplate(txttodate.EditValue, filterasof, Me)
        Else
            PrintDatagridview(Me.Text, "DATABASE RECORDS", If(ckasof.Checked = True, "Report Filter: ALL RECORDS", "Report Filter: From " & txtfrmdate.Text & " to " & txttodate.Text), GridView1, Me)
            'PrintGeneralReportWithDate(ckasof.CheckState, txtfrmdate.EditValue, txttodate.EditValue, Me.Text & " (" & If(ck_inventory.Checked = True, "All Office", txtInventory.Text) & ")", gridview1, Me)
        End If

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel("Stock out consumable summary " & If(ck_inventory.Checked = True, "all office", txtInventory.Text) & " as of " & CDate(Now).ToString("yyyy-MM-dd"), GridView1)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If frmStockoutDepedRequest.Visible = True Then
            frmStockoutDepedRequest.Focus()
        Else
            frmStockoutDepedRequest.Show(Me)
        End If
    End Sub
End Class