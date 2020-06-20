Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmChangeProductSupplier

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gridVendor)
        loadVendors()
    End Sub

    Public Sub loadVendors()
        LoadXgridLookupSearch("SELECT vendorid,companyname as 'Vendor' from tblglobalvendor order by  companyname asc", "tblglobalvendor", txtVendor, gridVendor, Me)
        txtVendor.Properties.PopupFormSize = New Size(480, 350)
        gridVendor.Columns("vendorid").Visible = False
    End Sub
    Private Sub txtsuplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVendor.Properties.View.FocusedRowHandle.ToString)
        vendorid.Text = txtVendor.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtVendor.Text = "" Then
            XtraMessageBox.Show("Please select vendor!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVendor.Focus()
            Exit Sub
        End If
        If mode.Text = "online" Then
            frmRequisitionsItems.UpdateSupplier(vendorid.Text)
        ElseIf mode.Text = "new" Then
            frmProceedNewRequest.UpdateSupplier(vendorid.Text)
        ElseIf mode.Text = "po" Then
            frmPurchaseOrder.ChangeSupplier(vendorid.Text)
        End If
        Me.Close()
    End Sub
End Class