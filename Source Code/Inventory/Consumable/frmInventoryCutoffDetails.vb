Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryCutoffDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
 
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filter()

    End Sub
     
    Public Sub filter()
        If cmdGroupbyCategory.Checked = True Then
            LoadXgrid("Select categoryname as 'Category', ifnull(sum((purchasedprice*quantity)),0) as 'Total' " _
                   + " from tblinventorylocked where officeid='" & officeid.Text & "' and  date_format(cutoff,'%Y-%m')='" & cutoff.Text & "' group by catid", "tblinventorylocked", Em, GridView1, Me)
            XgridColCurrency({"Total"}, GridView1)
        Else
            LoadXgrid("Select productname as 'Particular', " _
                      + " categoryname as 'Category', " _
                      + " Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type', " _
                      + " quantity as 'Quantity',Unit, " _
                      + " purchasedprice as 'Purchased Price',(purchasedprice*quantity) as 'Total', " _
                      + " date_format(lastupdate, '%Y-%m-%d %r') as 'Date Inventory' " _
                      + " from tblinventorylocked where officeid='" & officeid.Text & "' and date_format(cutoff,'%Y-%m') ='" & cutoff.Text & "'", "tblinventorylocked", Em, GridView1, Me)
            GridView1.Columns("Total").Width = 120

            XgridColCurrencyDecimalCount({"Quantity"}, 4, GridView1)
            XgridColCurrency({"Purchased Price", "Total"}, GridView1)
            XgridColAlign({"Inventory Type", "Quantity"}, GridView1, HorzAlignment.Center)
            XgridGroupSummaryCurrency({"Total"}, GridView1)
            XgridGeneralSummaryCurrency({"Total"}, GridView1)
        End If
    End Sub


    Private Sub DisplayFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2 : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

  
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
  

    Private Sub itemid_EditValueChanged(sender As Object, e As EventArgs) Handles cutoff.EditValueChanged
        filter()
    End Sub

    Private Sub cmdGroupbyCategory_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGroupbyCategory.CheckedChanged
        filter()
    End Sub

    Private Sub cmdPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
        PrintGeneralReport(Me.Text, txtDescription.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportGridToExcel(txtDescription.Text, GridView1)
    End Sub
End Class