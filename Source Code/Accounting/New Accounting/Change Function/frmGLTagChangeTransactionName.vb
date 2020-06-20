Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGLTagChangeTransactionName
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUpdateGLProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        SelectTransactionItem()
    End Sub
    Public Sub SelectTransactionItem()
        LoadXgridLookupSearch("SELECT id, Description as 'Select' from tblgltransactionname where groupid='" & groupid.Text & "'", "tblgltransactionname", txtItem, gridItem, Me)
        XgridHideColumn({"id"}, gridItem)
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        itemid.Text = txtItem.Properties.View.GetFocusedRowCellValue("id").ToString()

    End Sub

    Private Sub cmdSaveVoucher_Click(sender As Object, e As EventArgs) Handles cmdSaveVoucher.Click
        If txtItem.Text = "" Then
            XtraMessageBox.Show("Please transaction name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItem.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmGLAccountingSetup.UpdateTransactionName(itemid.Text)
        End If
    End Sub
End Class

