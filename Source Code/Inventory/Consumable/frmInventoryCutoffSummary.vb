Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmInventoryCutoffSummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventoryCutoffSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadYear()
    End Sub

    Public Sub LoadYear()
        LoadToComboBoxQuery("str", "distinct date_format(cutoff,'%Y') as str", "tblinventorylocked order by date_format(cutoff,'%Y') asc", txtYear)
    End Sub

    Private Sub txtYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtYear.SelectedValueChanged
        LoadMonth()
    End Sub

    Public Sub LoadMonth()
        LoadToComboBoxQuery("str", "distinct date_format(cutoff,'%M') as str", "tblinventorylocked where date_format(cutoff,'%Y')='" & txtYear.Text & "' order by date_format(cutoff,'%m') asc", txtMonth)
    End Sub
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        LoadData()
    End Sub

    Public Sub LoadData()
        If txtYear.Text = "Year" Or txtMonth.Text = "Month" Then Exit Sub
        com.CommandText = "drop temporary table if exists inventorylocked ;" : com.ExecuteNonQuery()
        com.CommandText = "create temporary table inventorylocked select cutoff,officeid,(select ucase(officename) from tblcompoffice where officeid=tblinventorylocked.officeid) as office, prepaid, sum(purchasedprice*quantity) as total from tblinventorylocked where date_format(cutoff,'%Y-%m') = '" & txtYear.Text & "-" & CDate("1/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM") & "' group by officeid,prepaid;" : com.ExecuteNonQuery()

        LoadXgrid("select a.officeid, a.Office, " _
                    + " ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=0 and cutoff=a.cutoff),0) as 'On Hand', " _
                    + " ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=1 and cutoff=a.cutoff),0) as 'Prepaid' " _
                    + " from inventorylocked as a where date_format(a.cutoff,'%Y-%m') = '" & txtYear.Text & "-" & CDate("1/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM") & "' group by a.officeid order by a.office asc", "inventorylocked", Em, GridView1, Me)
        GridView1.Columns("officeid").Visible = False
        XgridColCurrency({"On Hand", "Prepaid"}, GridView1)
        XgridColWidth({"Office"}, GridView1, 300)
        XgridColWidth({"On Hand", "Prepaid"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"On Hand", "Prepaid"}, GridView1)
    End Sub

   
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
 
    Private Sub cmdUnlock_Click(sender As Object, e As EventArgs) Handles cmdUnlock.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblinventorylocked where officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid").ToString & "' and date_format(cutoff,'%Y-%m') = '" & txtYear.Text & "-" & CDate("1/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM") & "'" : com.ExecuteNonQuery()
            Next
            GridView1.DeleteSelectedRows()
        End If
    End Sub
   
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text & " " & txtMonth.Text & " " & txtYear.Text, GridView1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport("CONSUMABLE INVENTORY SUMMARY", "Consumable inventory summary for the period of " & txtMonth.Text & " " & txtYear.Text, GridView1, Me)
    End Sub

    Private Sub cmdExportdetails_Click(sender As Object, e As EventArgs) Handles cmdExportdetails.Click
        Dim dir As New FolderBrowserDialog()
        If dir.ShowDialog() = DialogResult.OK Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                LoadXgrid("select productname as 'PRODUCT', " _
                               + " categoryname as 'CATEGORY', " _
                               + " Case when prepaid=1 then 'PREPAID' else 'ON HAND' end as 'INVENTORY', " _
                               + " quantity as 'QUANTITY', UNIT, " _
                               + " purchasedprice as 'PURCHASED PRICE',(purchasedprice*QUANTITY) as 'TOTAL',  date_format(lastupdate, '%Y-%m-%d %r') as 'DATE PURCHASED' " _
                               + " from tblinventorylocked where quantity > 0 and officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "officeid").ToString & "' and date_format(cutoff,'%Y-%m') = '" & txtYear.Text & "-" & CDate("1/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM") & "' ", "tblinventorylocked", GridControl1, GridView2, Me)
                GridView2.Columns("INVENTORY").Group()
                XgridColCurrency({"TOTAL"}, GridView2)
                XgridGroupSummaryCurrency({"TOTAL"}, GridView2)
                XgridGeneralSummaryCurrency({"TOTAL"}, GridView2)
                'GridView2.ExpandAllGroups()
                ExportToExcelDirectory(dir.SelectedPath & "\" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Office").ToString & ".xlsx", GridView2)
            Next
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ViewInventoryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInventoryDetailsToolStripMenuItem.Click
        frmInventoryCutoffDetails.txtDescription.Text = StrConv(GridView1.GetFocusedRowCellValue("Office").ToString, vbProperCase) & " inventory cutoff as of " & txtMonth.Text & " " & txtYear.Text
        frmInventoryCutoffDetails.officeid.Text = GridView1.GetFocusedRowCellValue("officeid").ToString
        frmInventoryCutoffDetails.cutoff.Text = txtYear.Text & "-" & CDate("1/" & txtMonth.Text & "/" & txtYear.Text).ToString("MM")
        frmInventoryCutoffDetails.Show(Me)
    End Sub
End Class