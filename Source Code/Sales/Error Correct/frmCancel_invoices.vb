Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCancel_invoices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
    End Sub
   
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If countqry("tblsalesclientcharges", "invoiceno='" & rchar(invoiceno.Text) & "' and cancelled=0") = 0 Then
            XtraMessageBox.Show("Please enter correct Ref number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            invoiceno.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue correct transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblsalesclientcharges set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where invoiceno='" & invoiceno.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblglaccountledger set cancelled=1,cancelledby='" & globaluserid & "', datecancelled=current_timestamp where referenceno='" & invoiceno.Text & "' and journalmode='client-accounts'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblsaleserrorcorrect set errortype='Cancelled', errorref='Invoice#: " & invoiceno.Text & " - " & txtCurrentClient.Text & Chr(13) & "Total Amount: " & txtAmount.Text & Chr(13) & "', remarks='" & rchar(txtRemarks.Text) & "',cashier='" & txtCashier.Text & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Invoice successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
 
    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles invoiceno.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("tblsalesclientcharges", "invoiceno='" & rchar(invoiceno.Text) & "' and verified=1 and cancelled=0") > 0 Then
                txtCurrentClient.Text = qrysingledata("fullname", "(select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'fullname'", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtCashier.Text = qrysingledata("trnby", "trnby", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtAmount.Text = FormatNumber(Val(qrysingledata("amount", "amount", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")), 2)
                batchcode.Text = qrysingledata("batchcode", "batchcode", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtRemarks.Focus()
            Else
                XtraMessageBox.Show("Invoice number not found! Please try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                invoiceno.SelectAll()
                invoiceno.Focus()
            End If
        End If
    End Sub
End Class