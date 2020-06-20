Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGLTagChangeCompany
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUpdateGLProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadCompany()
    End Sub
    Public Sub LoadCompany()
        LoadXgridLookupSearch("select code, Companyname as 'Select Company' from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        gvCompany.Columns("code").Visible = False
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdSaveVoucher_Click(sender As Object, e As EventArgs) Handles cmdSaveVoucher.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmGLAccountingSetup.UpdateCompany(companyid.Text)
        End If
    End Sub
End Class

