Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.Utils

Public Class frmBankAccounts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If
        ElseIf keyData = (Keys.Control) + Keys.P Then
            BarButtonItem2.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        LoadXgrid("Select bankcode ,AccountName, (select itemname from tblglitem where itemcode=tblbankaccounts.glitemtag ) as 'GL Tagging', bankaccounts as 'Bank Accounts', cashaccount as 'Cash', posmerchant as 'POS Merchant',enableemailnotification as 'Notify',onlinetransaction as 'Online Transaction' from tblbankaccounts order by AccountName asc", "tblbankaccounts", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridHideColumn({"bankcode"}, GridView1)
        XgridColCurrency({"Beginning Balance"}, GridView1)
        XgridColAlign({"Account Number", "Cash"}, GridView1, Utils.HorzAlignment.Center)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please provide Bank Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtAccountNumber.Text = "" Then
            XtraMessageBox.Show("Please provide Account Number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountNumber.Focus()
            Exit Sub
        ElseIf txtAccountName.Text = "" Then
            XtraMessageBox.Show("Please provide Account Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountName.Focus()
            Exit Sub
        
        ElseIf countqry("tblbankaccounts", "bankcode='" & code.Text & "' and bankcode<>'" & code.Text & "'") > 0 Then
            XtraMessageBox.Show("Duplicate account Code! Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf countqry("tblbankaccounts", "accountnumber='" & txtAccountNumber.Text & "' and bankcode<>'" & code.Text & "'") > 0 Then
            XtraMessageBox.Show("Duplicate account number! Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblbankaccounts set bankcode='" & code.Text & "', accountnumber='" & txtAccountNumber.Text & "',accountname='" & rchar(txtAccountName.Text) & "', glitemtag='" & ItemCode.Text & "', bankaccounts=" & ckBankAccounts.CheckState & ",cashaccount=" & ckCash.CheckState & ",posmerchant=" & ckposmerchant.CheckState & ", enableemailnotification=" & ckEnableEmailNotification.CheckState & ",onlinetransaction=" & ckOnlineTransaction.CheckState & ", datesaved=current_timestamp"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblbankaccounts set accountnumber='" & txtAccountNumber.Text & "', accountname='" & rchar(txtAccountName.Text) & "', glitemtag='" & ItemCode.Text & "', bankaccounts=" & ckBankAccounts.CheckState & ", cashaccount=" & ckCash.CheckState & ", posmerchant=" & ckposmerchant.CheckState & ",   enableemailnotification=" & ckEnableEmailNotification.CheckState & ",onlinetransaction=" & ckOnlineTransaction.CheckState & " where bankcode='" & code.Text & "'"
            com.ExecuteNonQuery()
        End If
        
        clearfields()
        filter()
        XtraMessageBox.Show("Bank Account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearfields()
        code.Text = getcodeid("bankcode", "tblbankaccounts", "100001")
        txtAccountNumber.Text = ""
        txtAccountName.Text = ""
        mode.Text = ""
        If mode.Text = "edit" Then
            code.Properties.ReadOnly = True
        Else
            code.Properties.ReadOnly = False
        End If
        'If countqry("tblbankaccounts", "cashaccount=1") = 0 Then
        '    ckCash.Enabled = True
        'Else
        '    ckCash.Enabled = False
        '    ckCash.Checked = False
        'End If
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *  from tblbankaccounts where bankcode='" & code.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtAccountNumber.Text = rst("accountnumber").ToString
            txtAccountName.Text = rst("accountname").ToString
            ckBankAccounts.Checked = rst("bankaccounts")
            ckCash.Checked = rst("cashaccount")
            ckposmerchant.Checked = rst("posmerchant")
            ckEnableEmailNotification.Checked = rst("enableemailnotification")
            ckOnlineTransaction.Checked = rst("onlinetransaction")
            txtItem.Text = rst("glitemtag").ToString
            ItemCode.Text = rst("glitemtag").ToString
        End While
        rst.Close()

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("bankcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("bankcode").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        clearfields()
        filter()
      
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        LoadItem()
    End Sub
    Public Sub LoadItem()
        LoadXgridLookupSearch("select itemcode,(select companyname from tblcompany where code=tblglitem.companyid) as Company, itemname as 'Item Name' from tblglitem where sl=1", "tblglitem", txtItem, gridItem, Me)
        XgridHideColumn({"itemcode"}, gridItem)
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        ItemCode.Text = txtItem.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If countqry("tblglaccountledger", "accountno='" & GridView1.GetFocusedRowCellValue("bankcode").ToString & "' and cancelled=0 and cleared=1") > 0 Then
            XtraMessageBox.Show("Deleting this account is not allowed! Please cancel all transaction related to this account in order to continue this process.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the account is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblbankaccounts where bankcode='" & GridView1.GetFocusedRowCellValue("bankcode").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblglaccountledger set remarks=concat(remarks, ' (deleted account)') where accountno='" & GridView1.GetFocusedRowCellValue("bankcode").ToString & "'" : com.ExecuteNonQuery()
            filter()
            XtraMessageBox.Show("Account successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class