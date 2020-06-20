Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmTransferedItems
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmTransferedItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        filter()
        LoadGridviewAppearance(GridView1)
    End Sub

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(dateconfirmed,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(dateconfirmed,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        LoadXgrid("select (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'Transfer From', (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'Transfer To',(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Product', " _
                           + " Quantity, (select unit from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Unit', Remarks,date_format(dateconfirmed, '%Y-%m-%d %r') as 'Date Received' from tbltransferitem inner join tbltransferbatch on tbltransferitem.batchcode = tbltransferbatch.batchcode where confirmed = 1 " & filterasof & " order by dateconfirmed desc", "tbltransferitem", Em, GridView1, Me)
        '  GridView1.Columns("inventory_from").Visible = False
        GridView1.Columns("Remarks").ColumnEdit = MemoEdit
        XgridColCurrency({"Quantity"}, GridView1)
        XgridColAlign({"Quantity", "Date Received"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

#Region "REPORT SETTINGS"
    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
       
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub
#End Region

End Class