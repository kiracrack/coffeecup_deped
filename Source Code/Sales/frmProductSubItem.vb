Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductSubItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmProductSubItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport(Me.Text, txtReportDescription.Text, GridView1, Me)
    End Sub

    Private Sub refnumber_TextChanged(sender As Object, e As EventArgs) Handles refnumber.TextChanged
        LoadXgrid("SELECT  ProductName, Quantity,Unit, UnitPrice, (UnitPrice*Quantity) as 'Total'  FROM `tblsalesproductcustomorder` where postrn='" & refnumber.Text & "'; ", "tblsalesproductcustomorder", Em, GridView1, Me)

        XgridColCurrency({"Quantity", "UnitPrice", "Total"}, GridView1)
        XgridColAlign({"Quantity", "Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Total"}, GridView1, 90)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class