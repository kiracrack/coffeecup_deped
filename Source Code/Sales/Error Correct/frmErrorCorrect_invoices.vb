Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmErrorCorrect_invoices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmApprovalChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadClientInfo()
    End Sub
    Public Sub LoadClientInfo()
        LoadXgridLookupSearch("SELECT cifid, companyname as 'Client' from tblclientaccounts where walkinaccount=0 order by companyname asc", "tblclientaccounts", txtClient, gridClient, Me)
        gridClient.Columns("cifid").Visible = False
    End Sub
    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If countqry("tblsalesclientcharges", "invoiceno='" & rchar(invoiceno.Text) & "' and verified=1 and cancelled=0") = 0 Then
            XtraMessageBox.Show("Please enter correct invoice number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            invoiceno.Focus()
            Exit Sub

        ElseIf invoiceno.Text <> txtNewInvoiceNumber.Text Then
            If countqry("tblsalesclientcharges", "invoiceno='" & rchar(txtNewInvoiceNumber.Text) & "' and cancelled=0") > 0 Then
                XtraMessageBox.Show("Inputed invoice number is already exist!" & Environment.NewLine & Environment.NewLine _
                                        + "Invoice#: " & qrysingledata("invoiceno", "invoiceno", "where invoiceno='" & rchar(txtNewInvoiceNumber.Text) & "'", "tblsalesclientcharges") & Environment.NewLine & "Client Name: " & qrysingledata("clientname", "(select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'clientname' ", "where invoiceno='" & rchar(txtNewInvoiceNumber.Text) & "'", "tblsalesclientcharges") & Environment.NewLine & "Amount: " & qrysingledata("amount", "amount", "where invoiceno='" & rchar(txtNewInvoiceNumber.Text) & "'", "tblsalesclientcharges"), compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewInvoiceNumber.Focus()
                Exit Sub
            End If
          
        ElseIf txtClient.Text = "" Then
            XtraMessageBox.Show("Please select correct client!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient.Focus()
            Exit Sub
       
        End If
        If XtraMessageBox.Show("Are you sure you want to continue correct transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblsalesbatch set cifid='" & cifid.Text & "' where id='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalestransaction set cifid='" & cifid.Text & "' where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalesclientcharges set accountno='" & cifid.Text & "',invoiceno='" & txtNewInvoiceNumber.Text & "' where invoiceno='" & invoiceno.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblglaccountledger set accountno='" & cifid.Text & "',referenceno='" & txtNewInvoiceNumber.Text & "' where referenceno='" & invoiceno.Text & "' and journalmode='client-accounts'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblsaleserrorcorrect set errortype='invoices', errorref='Invoice#: " & invoiceno.Text & " - " & txtCurrentClient.Text & Chr(13) & "Total Amount: " & txtAmount.Text & Chr(13) & "Corrected#: " & txtNewInvoiceNumber.Text & "-" & txtClient.Text & "', remarks='" & rchar(txtRemarks.Text) & "',cashier='" & txtCashier.Text & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Invoice successfully corrected", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClient.EditValueChanged
        On Error Resume Next
        cifid.Text = txtClient.Properties.View.GetFocusedRowCellValue("cifid").ToString()
    End Sub

    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles invoiceno.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("tblsalesclientcharges", "invoiceno='" & rchar(invoiceno.Text) & "' and verified=1 and cancelled=0") > 0 Then
                txtCurrentClient.Text = qrysingledata("fullname", "(select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'fullname'", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtCashier.Text = qrysingledata("trnby", "trnby", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtAmount.Text = FormatNumber(Val(qrysingledata("amount", "amount", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")), 2)
                batchcode.Text = qrysingledata("batchcode", "batchcode", "where invoiceno='" & invoiceno.Text & "'  and cancelled=0", "tblsalesclientcharges")
                txtClient.Focus()
            Else
                XtraMessageBox.Show("Invoice number not found! Please try again", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                invoiceno.SelectAll()
                invoiceno.Focus()
            End If
        End If
    End Sub
End Class