Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomRateBreakdown
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomRateBreakdown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadBreakdown()
     
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Em.Parent = XtraTabControl1.SelectedTabPage
        If frmHotelRoomRateBreakdownAddItem.Visible = True Then
            frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = XtraTabControl1.SelectedTabPage.Name
        End If
        LoadBreakdown()
    End Sub

    Public Sub LoadBreakdown()
        LoadXgrid("select id, itemname as 'Item Name', Amount from tblhotelratesbreakdown where roomtype='" & roomtype.Text & "' and dayrate='" & txtDayrate.SelectedIndex & "' and ratecode='" & ratecode.Text & "' and breakdowntype='" & XtraTabControl1.SelectedTabPage.Name & "'", "tblhotelratesbreakdown", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        XgridColWidth({"Item Name"}, GridView1, 200)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadBreakdown()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        frmHotelRoomRateBreakdownAddItem.roomtype.Text = roomtype.Text
        frmHotelRoomRateBreakdownAddItem.ratecode.Text = ratecode.Text
        frmHotelRoomRateBreakdownAddItem.dayno.Text = txtDayrate.SelectedIndex
        frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = XtraTabControl1.SelectedTabPage.Name
        frmHotelRoomRateBreakdownAddItem.Show(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to removed selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblhotelratesbreakdown where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadBreakdown()
        End If
    End Sub
 
    Private Sub txtDayrate_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDayrate.SelectedValueChanged
        LoadBreakdown()
    End Sub
End Class