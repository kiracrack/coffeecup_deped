Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTAGUpdateAccountTitle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTAGUpdateAccountTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadCompany()
        LoadAccountTitle()
    End Sub
    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
        If txtCompany.Text <> "" Then
            LoadAccountTitle()
        End If
    End Sub

    Public Sub LoadAccountTitle()
        LoadXgridLookupSearch("select ItemCode, itemname as 'Item Name' from tblglitem where companyid='" & companyid.Text & "' and sl=1", "tblglitem", txtCreditAccount, gridview_credit, Me)
        XgridColWidth({"ItemCode"}, gridview_credit, 100)
        XgridColAlign({"ItemCode"}, gridview_credit, HorzAlignment.Center)
    End Sub
  

    Private Sub txtCreditAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCreditAccount.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCreditAccount.Properties.View.FocusedRowHandle.ToString)
        itemcode.Text = txtCreditAccount.Properties.View.GetFocusedRowCellValue("ItemCode").ToString()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        frmTAGDetails.UpdateAccountTitle(itemcode.Text, companyid.Text)
        frmTAGDetails.UpdateAccountTitleCation(txtCreditAccount.Text)
        'Me.Close()
    End Sub


End Class

