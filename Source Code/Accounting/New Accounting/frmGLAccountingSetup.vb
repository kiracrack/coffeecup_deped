Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.IO

Public Class frmGLAccountingSetup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F1 Then

        ElseIf keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPumpReading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCompany()
        LoadGroup()
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

    Public Sub LoadGroup()
        LoadXgridLookupSearch("select id, description as 'Select' from tblgltransactiongroup", "tblgltransactiongroup", txtGroup, gvGroup, Me)
        gvGroup.Columns("id").Visible = False
    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtGroup.Properties.View.FocusedRowHandle.ToString)
        groupid.Text = txtGroup.Properties.View.GetFocusedRowCellValue("id").ToString()
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
        ShowDetupDetails()
    End Sub

    Public Sub ShowDetupDetails()
        If txtGroup.Text = "" Or txtItem.Text = "" Then
            cmdTag.Enabled = False
        Else
            cmdTag.Enabled = True
        End If
        If groupid.Text = "" Or itemid.Text = "" Then Exit Sub
        LoadXgrid("call sp_acct_setup(" & companyid.Text & "," & groupid.Text & "," & itemid.Text & ")", "call sp_acct_setup(" & companyid.Text & "," & groupid.Text & "," & itemid.Text & ")", Em, GridView1, Me)
        XgridHideColumn({"id", "debitcode", "creditcode", "debitaccounttag", "creditaccounttag"}, GridView1)
        GridView1.BestFitColumns()
    End Sub

    Public Function UpdateCompany(ByVal CompanyCode As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblgltransactiontagging set companyid='" & CompanyCode & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowDetupDetails()
    End Function

    Public Function UpdateTransactionName(ByVal itemcode As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblgltransactiontagging set itemid='" & itemcode & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowDetupDetails()
    End Function


    Public Function UpdateAccountTitle(ByVal CreditAccount As Boolean, ByVal creditcode As String, ByVal DebitAccount As Boolean, ByVal debitcode As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblgltransactiontagging set creditaccounttag=" & CreditAccount & ",creditcode='" & creditcode & "',debitaccounttag=" & DebitAccount & ",debitcode='" & debitcode & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
    End Function

    Public Function UpdateAccountTitleCation(ByVal debitcode As String, ByVal creditcode As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Debit Account Title", debitcode)
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Credit Account Title", creditcode)
        Next
    End Function

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblgltransactiontagging where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            ShowDetupDetails()
            XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdTransactionGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTransactionGroup.ItemClick
        frmTransactionGroup.ShowDialog(Me)
        LoadGroup()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdTransactionName_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTransactionName.ItemClick
        frmTransactionName.ShowDialog(Me)
        SelectTransactionItem()
    End Sub

    Private Sub cmdTag_Click(sender As Object, e As EventArgs) Handles cmdTag.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        ElseIf txtGroup.Text = "" Then
            XtraMessageBox.Show("Please transaction group name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGroup.Focus()
            Exit Sub
        ElseIf txtItem.Text = "" Then
            XtraMessageBox.Show("Please transaction name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItem.Focus()
            Exit Sub
        End If
        frmGLBrowseSourceTable.ckAccount.Checked = False
        frmGLBrowseSourceTable.companyid.Text = companyid.Text
        frmGLBrowseSourceTable.groupid.Text = groupid.Text
        frmGLBrowseSourceTable.itemid.Text = itemid.Text
        frmGLBrowseSourceTable.Show(Me)
    End Sub
     
     
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowDetupDetails()
    End Sub

    Private Sub TagAccountTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAccountTitleToolStripMenuItem.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        ElseIf txtGroup.Text = "" Then
            XtraMessageBox.Show("Please transaction group name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGroup.Focus()
            Exit Sub
        ElseIf txtItem.Text = "" Then
            XtraMessageBox.Show("Please transaction name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItem.Focus()
            Exit Sub
        End If
        frmUpdateGLAccountTitle.companyid.Text = companyid.Text
        frmUpdateGLAccountTitle.ckCreditGroup.Checked = CBool(GridView1.GetFocusedRowCellValue("creditaccounttag").ToString)
        frmUpdateGLAccountTitle.ckDebitGroup.Checked = CBool(GridView1.GetFocusedRowCellValue("debitaccounttag").ToString)
        frmUpdateGLAccountTitle.LoadGLCreditAccountTitle()
        frmUpdateGLAccountTitle.LoadGLDebitAccountTitle()
        frmUpdateGLAccountTitle.debit.Text = GridView1.GetFocusedRowCellValue("debitcode").ToString
        frmUpdateGLAccountTitle.txtDebitAccount.Text = GridView1.GetFocusedRowCellValue("debitcode").ToString
        frmUpdateGLAccountTitle.credit.Text = GridView1.GetFocusedRowCellValue("creditcode").ToString
        frmUpdateGLAccountTitle.txtCreditAccount.Text = GridView1.GetFocusedRowCellValue("creditcode").ToString
        frmUpdateGLAccountTitle.Show(Me)
    End Sub

    Private Sub TransferCompanyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferCompanyNameToolStripMenuItem.Click
        frmGLTagChangeCompany.Show(Me)
    End Sub

    Private Sub TransferTransactionNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferTransactionNameToolStripMenuItem.Click
        frmGLTagChangeTransactionName.groupid.Text = groupid.Text
        frmGLTagChangeTransactionName.Show(Me)
    End Sub
End Class