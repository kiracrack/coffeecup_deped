Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmAccountJournalEntry
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLPump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGLItem()
        loadAccounts()
        LoadGridviewAppearance(gridDueFrom)
        LoadGridviewAppearance(gridItem)
        txtTrndate.EditValue = Now
    End Sub

    Public Sub loadBankAccounts()
        LoadXgridLookupSearch("select bankcode, accountname as 'Account Name'  " _
                           + " from tblbankaccounts order by accountname asc ", "tblbankaccounts", txtDueFrom, gridDueFrom, Me)

        gridDueFrom.Columns("bankcode").Visible = False
        gridDueFrom.SelectRow(1)
    End Sub
    Public Sub loadVendorAccounts()
        LoadXgridLookupSearch("select vendorid, companyname as 'Account Name'  " _
                           + " from tblglobalvendor order by companyname asc ", "tblglobalvendor", txtDueFrom, gridDueFrom, Me)

        gridDueFrom.Columns("vendorid").Visible = False
        gridDueFrom.SelectRow(1)
    End Sub

    Public Sub LoadClientInfo()
        LoadXgridLookupSearch("SELECT cifid, companyname as 'Account Name' from tblclientaccounts where walkinaccount=0 and deleted=0 order by companyname asc", "tblclientaccounts", txtDueFrom, gridDueFrom, Me)
        gridDueFrom.Columns("cifid").Visible = False
    End Sub

    Private Sub txtDueFrom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDueFrom.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtDueFrom.Properties.View.FocusedRowHandle.ToString)
        If RadioGroup1.EditValue = "client" Then
            dueid.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("cifid").ToString()
            txtDueFrom.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
        ElseIf RadioGroup1.EditValue = "bank" Then
            dueid.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
            txtDueFrom.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
        ElseIf RadioGroup1.EditValue = "vendor" Then
            dueid.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
            txtDueFrom.Text = txtDueFrom.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
        End If

    End Sub

    Public Sub LoadGLItem()
        LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tbltransactioncode order by itemname asc", "tbltransactioncode", txtItem, gridItem, Me)
        gridItem.Columns("itemcode").Visible = False
    End Sub

    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        itemcode.Text = txtItem.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        txtItem.Text = txtItem.Properties.View.GetFocusedRowCellValue("Item Name").ToString()
    End Sub


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtItem.Text = "" Then
            XtraMessageBox.Show("Please Select Item Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Exit Sub
        ElseIf txtDueFrom.Text = "" Then
            XtraMessageBox.Show("Please Select Accounts!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDueFrom.Focus()
            Exit Sub
        ElseIf Val(CC(txtDebit.Text)) <= 0 And Val(CC(txtCredit.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter amount either debit or credit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDueFrom.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            XtraMessageBox.Show("Please enter remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDueFrom.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If RadioGroup1.EditValue = "client" Then
                com.CommandText = "insert into tblglaccountledger set journalmode='client-accounts',  accountno='" & dueid.Text & "', referenceno='" & txtReferenceNumber.Text & "', itemcode='" & itemcode.Text & "',remarks='" & rchar(txtRemarks.Text) & "',debit='" & Val(CC(txtDebit.Text)) & "',credit='" & Val(CC(txtCredit.Text)) & "', trnby='" & globaluserid & "',datetrn=concat('" & ConvertDate(txtTrndate.Text) & "', ' ', current_time)" : com.ExecuteNonQuery()
            ElseIf RadioGroup1.EditValue = "bank" Then
                com.CommandText = "insert into tblglaccountledger set journalmode='bank-accounts',  accountno='" & dueid.Text & "', referenceno='" & txtReferenceNumber.Text & "', itemcode='" & itemcode.Text & "',remarks='" & rchar(txtRemarks.Text) & "',debit='" & Val(CC(txtDebit.Text)) & "',credit='" & Val(CC(txtCredit.Text)) & "', trnby='" & globaluserid & "',datetrn=concat('" & ConvertDate(txtTrndate.Text) & "', ' ', current_time)" : com.ExecuteNonQuery()
            ElseIf RadioGroup1.EditValue = "vendor" Then
                com.CommandText = "insert into tblglaccountledger set journalmode='payable-accounts',  accountno='" & dueid.Text & "', referenceno='" & txtReferenceNumber.Text & "', itemcode='" & itemcode.Text & "',remarks='" & rchar(txtRemarks.Text) & "',debit='" & Val(CC(txtDebit.Text)) & "',credit='" & Val(CC(txtCredit.Text)) & "', trnby='" & globaluserid & "',datetrn=concat('" & ConvertDate(txtTrndate.Text) & "', ' ', current_time)" : com.ExecuteNonQuery()
            End If
            txtCredit.Text = "0.00"
            txtDebit.Text = "0.00"
            XtraMessageBox.Show("Journal successfully save and subject for clearing!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtDebit_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebit.EditValueChanged
        If Val(CC(txtDebit.Text)) > 0 Then
            txtCredit.Properties.ReadOnly = True
            txtCredit.Text = "0"
        Else
            txtCredit.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtCredit_EditValueChanged(sender As Object, e As EventArgs) Handles txtCredit.EditValueChanged
        If Val(CC(txtCredit.Text)) > 0 Then
            txtDebit.Properties.ReadOnly = True
            txtDebit.Text = "0"
        Else
            txtDebit.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        loadAccounts()
    End Sub
    Public Sub loadAccounts()
        If RadioGroup1.EditValue = "client" Then
            LoadClientInfo()
        ElseIf RadioGroup1.EditValue = "bank" Then
            loadBankAccounts()
        ElseIf RadioGroup1.EditValue = "vendor" Then
            loadVendorAccounts()

        End If
    End Sub
End Class