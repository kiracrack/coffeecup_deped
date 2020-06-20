Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmUpdateGLAccountTitle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUpdateGLProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGLCreditAccountTitle()
        LoadGLDebitAccountTitle()
    End Sub

    Private Sub ckCreditGroup_CheckedChanged(sender As Object, e As EventArgs) Handles ckCreditGroup.CheckedChanged
        LoadGLCreditAccountTitle()
    End Sub

    Private Sub ckDebitGroup_CheckedChanged(sender As Object, e As EventArgs) Handles ckDebitGroup.CheckedChanged
        LoadGLDebitAccountTitle()
    End Sub

    Public Sub LoadGLCreditAccountTitle()
        If ckCreditGroup.Checked = True Then
            LoadXgridLookupSearch("select id as ItemCode, description as 'Item Name' from tblgltaggingaccountgroup", "tblgltaggingaccountgroup", txtCreditAccount, gridview_credit, Me)
        Else
            LoadXgridLookupSearch("select ItemCode, itemname as 'Item Name' from tblglitem where companyid='" & companyid.Text & "' and sl=1", "tblglitem", txtCreditAccount, gridview_credit, Me)
        End If
        XgridColWidth({"ItemCode"}, gridview_credit, 100)
        XgridColAlign({"ItemCode"}, gridview_credit, HorzAlignment.Center)
    End Sub

    Public Sub LoadGLDebitAccountTitle()
        If ckDebitGroup.Checked = True Then
            LoadXgridLookupSearch("select id as ItemCode, description as 'Item Name' from tblgltaggingaccountgroup", "tblgltaggingaccountgroup", txtDebitAccount, gridview_debit, Me)
        Else
            LoadXgridLookupSearch("select ItemCode, itemname as 'Item Name' from tblglitem where companyid='" & companyid.Text & "' and sl=1", "tblglitem", txtDebitAccount, gridview_debit, Me)
        End If
        XgridColWidth({"ItemCode"}, gridview_debit, 100)
        XgridColAlign({"ItemCode"}, gridview_debit, HorzAlignment.Center)
    End Sub

    Private Sub txtGLRevenue_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebitAccount.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtDebitAccount.Properties.View.FocusedRowHandle.ToString)
        debit.Text = txtDebitAccount.Properties.View.GetFocusedRowCellValue("ItemCode").ToString()
    End Sub
    Private Sub txtGLCostofGoods_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCreditAccount.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCreditAccount.Properties.View.FocusedRowHandle.ToString)
        credit.Text = txtCreditAccount.Properties.View.GetFocusedRowCellValue("ItemCode").ToString()
    End Sub
    
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        frmGLAccountingSetup.UpdateAccountTitle(ckCreditGroup.CheckState, credit.Text, ckDebitGroup.CheckState, debit.Text)
        frmGLAccountingSetup.UpdateAccountTitleCation(txtDebitAccount.Text, txtCreditAccount.Text)
        Me.Close()
    End Sub

   
End Class

