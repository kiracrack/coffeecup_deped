Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmHotelRoomRateBreakdownAddItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelBreakdownAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(gridPackageItem)
        LoadItemPackage()
    End Sub
    Public Sub LoadItemPackage()
        LoadXgridLookupSearch("select itemcode, description as 'Item Name' from tblhotelpackageitem order by description asc ", "tblhotelpackageitem", txtitemname, gridPackageItem, Me)
        gridPackageItem.Columns("itemcode").Visible = False
    End Sub
    Private Sub txtitemname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemname.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtitemname.Properties.View.FocusedRowHandle.ToString)
        itemcode.Text = txtitemname.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        txtAmount.Focus()
    End Sub
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        com.CommandText = "insert into tblhotelratesbreakdown set roomtype='" & roomtype.Text & "',dayrate='" & dayno.Text & "', ratecode='" & ratecode.Text & "', breakdowntype='" & breakdowntype.Text & "', itemcode='" & itemcode.Text & "', itemname='" & rchar(txtitemname.Text) & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
        frmHotelRoomRateBreakdown.LoadBreakdown()
        txtAmount.Text = "0.00"
        txtitemname.Focus()

    End Sub
End Class