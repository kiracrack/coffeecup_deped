Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmProductPriceList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAddVendorItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        filterPriceList()
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Visible = True
        Else
            cmdRemove.Visible = False
        End If
    End Sub

    Public Sub filterPriceList()
        LoadXgrid("Select id, (select ucase(COMPANYNAME) from tblglobalvendor where vendorid = tblitemvendor.vendorid) as Vendor, procost as 'Selling Price',Unit, lastupdate as 'Last Update' from tblitemvendor where itemid='" & productid.Text & "' order by procost asc", "tblitemvendor", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColAlign({"Unit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Selling Price"}, GridView1)
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblitemvendor", GridView1, Me)
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filterPriceList()
    End Sub
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, productname.Text & " Price List", gridview1, Me)
    End Sub

    Private Sub productid_EditValueChanged(sender As Object, e As EventArgs) Handles productid.EditValueChanged
        filterPriceList()
    End Sub
End Class