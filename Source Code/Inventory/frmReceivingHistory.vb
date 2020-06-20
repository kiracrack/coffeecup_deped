Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Public Class frmReceivingHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPendingPayables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()

        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text

        txtfrmdate.EditValue = Format(globalsysdate.ToShortDateString)
        txttodate.EditValue = Format(globalsysdate.ToShortDateString)
        filter()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        filter()
    End Sub
    Public Sub filter()
        If XtraTabControl1.SelectedTabPage Is tabnew Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            filterNew()
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
            filterReceived()
        End If
    End Sub
    Private Sub chrptdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chrptdate.CheckedChanged
        If chrptdate.Checked = True Then
            Paneldate.Enabled = True
        Else
            Paneldate.Enabled = False
        End If
        queryreport()
    End Sub
    Public Sub queryreport()
        If convertdate(txtfrmdate.Text) > convertdate(txttodate.Text) Then
            XtraMessageBox.Show("Invalid date searching! Query from date is greater than to date", "Date Parameter's Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chrptdate.Checked = True Then
            rptsettings = " and date_format(tblrecieving.lastupdate,'%Y-%m-%d') between '" & convertdate(txtfrmdate.Text) & "'  and '" & convertdate(txttodate.Text) & "' "
        Else
            rptsettings = ""
        End If
        filter()
    End Sub
    Public Sub filterNew()
        LoadXgrid("select trnid, batchcode as 'Batch Code', " _
                      + " (select details from tblsalescategory inner join tblproductsales on tblproductsales.catid = tblsalescategory.catid where productid=tblrecieving.productid) as 'Product Category', " _
                      + " (select itemname from tblproductsales where productid = tblrecieving.productid)  as 'Item Name', " _
                      + " quantity as 'Quantity' , " _
                      + " (select unit from tblproductsales where productid = tblrecieving.productid)  as 'Unit', " _
                      + " Remarks, " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.lasttrnby) as 'Transaction By', " _
                      + " (select office from tblaccounts where accountid=tblrecieving.lasttrnby) as 'Received From', " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.deliverby) as 'Delivered By', " _
                      + " lastupdate as 'Date Sent' " _
                      + " from tblrecieving where status = 1 " & rptsettings & "  order by lastupdate desc", "tblrecieving", Em, GridView1, Me)

        GridView1.Columns("trnid").Visible = False
        XgridColCurrency("Quantity", GridView1)
        GridView1.BestFitColumns()

    End Sub
    Public Sub filterReceived()
        LoadXgrid("select trnid, batchcode as 'Batch Code', " _
                      + " (select details from tblsalescategory inner join tblproductsales on tblproductsales.catid = tblsalescategory.catid where productid=tblrecieving.productid) as 'Product Category', " _
                      + " (select itemname from tblproductsales where productid = tblrecieving.productid)  as 'Item Name', " _
                      + " quantity as 'Quantity' , " _
                      + " (select unit from tblproductsales where productid = tblrecieving.productid)  as 'Unit', " _
                      + " Remarks, " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.lasttrnby) as 'Transaction By', " _
                      + " (select office from tblaccounts where accountid=tblrecieving.lasttrnby) as 'Received From', " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.deliverby) as 'Delivered By', " _
                      + " lastupdate as 'Date Sent', " _
                      + " (select DESCRIPTION from tblstockcategory where STOCKID=tblrecieving.stockto) as 'Stock to', " _
                      + " datereceived as 'Date Received', " _
                      + " (select fullname from tblaccounts where accountid=tblrecieving.receivedby) as 'Received By' " _
                      + " from tblrecieving where status = 0 " & rptsettings & "  order by lastupdate desc", "tblrecieving", Em, GridView1, Me)

        GridView1.Columns("trnid").Visible = False
        XgridColCurrency("Quantity", GridView1)
        GridView1.BestFitColumns()

    End Sub
    Private Sub gridView1_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As MasterRowGetLevelDefaultViewEventArgs) Handles GridView1.MasterRowGetLevelDefaultView
        Dim view As GridView = New GridView(Em)
        view.Assign(Em.MainView, True)
        view.OptionsView.ShowGroupPanel = False
        e.DefaultView = view
    End Sub

    Private Sub gvMain_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Column.VisibleIndex = 0 And View.IsMasterRowEmpty(e.RowHandle) Then
            CType(e.Cell, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo).CellButtonRect = Rectangle.Empty
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        GridView1.ShowFindPanel()
        queryreport()
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub
    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()
        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString
        report.txttitle.Text = txttitle.Text
        report.txtcustom.Text = txtCustom.Text

        If chrptdate.Checked = True Then
            report.txtfrom.Text = txtfrmdate.Text
            report.txtto.Text = txttodate.Text
        End If

        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
    
    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class