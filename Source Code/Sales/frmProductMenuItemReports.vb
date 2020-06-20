Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmProductMenuItemReports
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport(Me.Text, txtReportDescription.Text, GridView1, Me)
    End Sub

    Private Sub refnumber_TextChanged(sender As Object, e As EventArgs) Handles refnumber.TextChanged
        LoadXgrid("SELECT stockno as 'Stock No.', ProductName, Quantity, Unit, Purchasedprice as 'Purchase Price',(purchasedprice*Quantity) as 'Total'  FROM `tblsalesmenumakerstockout` where refnumber='" & refnumber.Text & "'; ", "tblsalesmenumakerstockout", Em, GridView1, Me)

        XgridColCurrency({"Quantity", "Purchase Price", "Total"}, GridView1)
        XgridColAlign({"Stock No.", "Unit", "Quantity"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Total"}, GridView1, 90)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class