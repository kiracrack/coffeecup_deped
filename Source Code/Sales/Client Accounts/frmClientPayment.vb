Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmClientPayment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        Dim firstDayofMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)

        If cifid.Text <> "" Then
            If countqry("tblsalesclientcharges", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Or countqry("tblsalesaccounttransaction", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
                txtdateFrom.EditValue = CDate(qrysingledata("dt", "ifnull(date_format(datetrn,'%Y,%m,%d'),current_timestamp) as dt", "where accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0 union " _
                                                            + " select ifnull(date_format(datetrn,'%Y,%m,%d'),current_timestamp) as dt  from tblsalesaccounttransaction where accountno='" & cifid.Text & "' and debit> 0 and paymentupdated=0 and verified=1 and cancelled=0 order by dt asc limit 1", "tblsalesclientcharges"))
            Else
                txtdateFrom.EditValue = Now
            End If
        Else
            txtdateFrom.EditValue = Now
        End If
        LoadClientInfo()

        txtDateTo.EditValue = Format(Now)
        ListView1.View = View.Details
        ListView1.Columns.Add("Date", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("trnid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Order Number", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Invoice No.", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Amount", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("trntype", -2, HorizontalAlignment.Left)
        ListView1.Columns(1).Width = 0
        ListView1.Columns(0).Width = 90
        ListView1.Columns(2).Width = 90
        ListView1.Columns(4).Width = 120
        ListView1.Columns(5).Width = 0

        LoadInvoices()
        LoadBankAccounts()
        loadDepositTo()
    End Sub
    Public Sub loadDepositTo()
        LoadXgridLookupEdit("select bankcode, concat(bankname,' (',accountname,')') as 'Account Name'  " _
                           + " from tblbankaccounts", "tblbankaccounts", txtDepositTo, gridDepositTo, Me)

        gridDepositTo.Columns("bankcode").Visible = False
        gridDepositTo.SelectRow(1)
    End Sub

    Private Sub txtDueFrom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepositTo.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtDepositTo.Properties.View.FocusedRowHandle.ToString)
        depositID.Text = txtDepositTo.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        txtDepositTo.Text = txtDepositTo.Properties.View.GetFocusedRowCellValue("Account Name").ToString()
    End Sub

    Public Sub LoadClientInfo()
        LoadXgridLookupSearch("SELECT cifid, companyname as 'Client' from tblclientaccounts where walkinaccount=0 order by companyname asc", "tblclientaccounts", txtClientAccount, gridClientAccount, Me)
        gridClientAccount.Columns("cifid").Visible = False
    End Sub

    Private Sub txtClientAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientAccount.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtClientAccount.Properties.View.FocusedRowHandle.ToString)
        cifid.Text = txtClientAccount.Properties.View.GetFocusedRowCellValue("cifid").ToString()
        txtClientAccount.Text = txtClientAccount.Properties.View.GetFocusedRowCellValue("Client").ToString()
        LoadInvoices()
    End Sub

    Public Sub LoadBankAccounts()
        LoadXgridLookupSearch("SELECT bankcode, bankname as 'Bank Name' from tblbankaccounts order by bankname asc", "tblbankaccounts", txtBankAccounts, gridBankAccount, Me)
        gridBankAccount.Columns("bankcode").Visible = False
    End Sub

    Private Sub txtBankAccounts_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankAccounts.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtBankAccounts.Properties.View.FocusedRowHandle.ToString)
        banknumber.Text = txtBankAccounts.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
        txtBankAccounts.Text = txtBankAccounts.Properties.View.GetFocusedRowCellValue("Bank Name").ToString()
    End Sub


    Public Sub LoadInvoices()
        ListView1.Items.Clear()
        com.CommandText = "select 'Invoice' as 'trntype', datetrn as dt, trnid,date_format(datetrn,'%Y-%m-%d') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' , Amount  from tblsalesclientcharges where accountno='" & cifid.Text & "' and paymentupdated=0 and verified=1 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' union " _
            + " select 'Other', datetrn as dt,id as trnid, date_format(datetrn,'%Y-%m-%d'), 'other-trnsaction','-',debit from tblsalesaccounttransaction where accountno='" & cifid.Text & "' and debit> 0 and paymentupdated=0 and verified=1 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' order by dt asc " : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("Date").ToString, 0)
            item1.SubItems.Add(rst("trnid").ToString)
            item1.SubItems.Add(rst("Order Number").ToString)
            item1.SubItems.Add(rst("Invoice No.").ToString)
            item1.SubItems.Add(FormatNumber(rst("Amount").ToString, 2))
            item1.SubItems.Add(rst("trntype").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
        txtAmountTender.Text = "0"
        If countqry("tblsalesclientcharges", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Or countqry("tblsalesaccounttransaction", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
            lblbalance.Text = "Total Amount"
            Me.Size = New Size(840, 501)
        Else
            txtAmount.Text = Val(qrysingledata("openbalance", "sum(debit)- sum(credit) as 'openbalance'", "where journalmode='client-accounts' and accountno='" & cifid.Text & "' and cancelled=0", "tblglaccountledger")) - Val(qrysingledata("payment", "sum(paymentamount) as 'payment'", "where accountno='" & cifid.Text & "' and verified=0 and cancelled=0", "tblpaymenttransactions"))
            lblbalance.Text = "Open Balance"
            Me.Size = New Size(332, 501)
        End If
        'If ListView1.Items.Count = 0 Then

        'Else
        '    lblbalance.Text = "Total Amount"
        '    Me.Size = New Size(840, 485)
        'End If
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtClientAccount.Text = "" Then
            XtraMessageBox.Show("Please Select client!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClientAccount.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmountTender.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter proper amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmountTender.Focus()
            Exit Sub
        ElseIf GlobalPaymentGLItemCode = "" Then
            XtraMessageBox.Show("Global Payment GL Item not set! please set your default client payment GL settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf ckDiscount.Checked = True And GlobalPaymentDiscountGLItemCode = "" Then
            XtraMessageBox.Show("Global Payment Discount GL Item not set! please set your default client payment discount GL settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Val(CC(txtAmount.Text)) = 0 Then
            If XtraMessageBox.Show("You are about to post payment with zero oustanding balance?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                Exit Sub
            End If
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim PaymentTrnID As String = getdateid() : Dim paymentmode As String = ""
            If radPaymentType.EditValue = "cash" Then
                paymentmode = "cash"

            ElseIf radPaymentType.EditValue = "check" Then
                paymentmode = "check"
                com.CommandText = "insert into tblsaleschecktransaction set trnsumcode='" & PaymentTrnID & "', accountno='" & cifid.Text & "', referenceno='', checkno='" & txtReferenceNumber.Text & "', checkdetails='" & txtDetails.Text & "', remarks='" & rchar(txtNote.Text) & "', amount='" & Val(CC(txtAmountTender.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            ElseIf radPaymentType.EditValue = "card" Then
                paymentmode = "card"
                com.CommandText = "insert into tblsalescardtransaction set trnsumcode='" & PaymentTrnID & "', accountno='" & cifid.Text & "',referenceno='',tracenumber='" & txtReferenceNumber.Text & "',bankaccount='" & banknumber.Text & "',remarks='" & rchar(txtNote.Text) & "',amount='" & Val(CC(txtAmountTender.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Else
                paymentmode = "cash"
            End If
            com.CommandText = "insert into tblpaymenttransactions set trnid='" & PaymentTrnID & "', transactiontype='sales', accountno='" & cifid.Text & "', paymenttype='" & paymentmode & "', totalamount='" & Val(CC(txtAmount.Text)) & "', paymentamount='" & Val(CC(txtAmountTender.Text)) & "',discount='" & Val(CC(txtDiscount.Text)) & "', variance='" & Val(CC(txtVariance.Text)) & "', note='" & rchar(txtNote.Text) & "',depositto='" & depositID.Text & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblsalesdeposittransaction set itemcode='" & GlobalPaymentGLItemCode & "', " _
                       + " totalcheck='0', " _
                       + " totalcash='0', " _
                       + " totalcoins='0', " _
                       + " amountdeposited='" & Val(CC(txtAmountTender.Text)) & "', " _
                       + " bankdeposited='" & depositID.Text & "', " _
                       + " referenceno='" & txtReferenceNumber.Text & "', " _
                       + " remarks='" & txtClientAccount.Text & " " & rchar(txtNote.Text) & "', " _
                       + " datetrn=current_timestamp, " _
                       + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            If ckDiscount.Checked = True Then
                com.CommandText = "insert into tblglaccountledger set journalmode='client-accounts',accountno='" & cifid.Text & "',referenceno='" & PaymentTrnID & "',itemcode='" & GlobalPaymentDiscountGLItemCode & "',remarks='" & rchar(txtDiscountRemarks.Text) & "',debit=0,credit='" & Val(CC(txtDiscount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            For Each itm As ListViewItem In ListView1.CheckedItems
                If itm.SubItems(5).Text = "Invoice" Then
                    com.CommandText = "update tblsalesclientcharges set paymentupdated=1, paymentrefnumber='" & PaymentTrnID & "' where trnid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblsalesaccounttransaction set paymentupdated=1, paymentrefnumber='" & PaymentTrnID & "' where id='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                End If
            Next
            XtraMessageBox.Show("Payment successfully posted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If txtClientAccount.Properties.ReadOnly = True Then
                Me.Close()
            End If
            radPaymentType.EditValue = "cash" : txtAmountTender.Text = "0" : txtNote.Text = "" : txtReferenceNumber.Text = "" : txtDetails.Text = "" : LoadInvoices()
        End If
    End Sub

    Private Sub txtdateFrom_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged, txtDateTo.EditValueChanged
        LoadInvoices()
    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        ' On Error Resume Next
        Dim totalAmount As Double = 0
        For Each itm As ListViewItem In ListView1.Items
            If itm.Checked Then
                totalAmount = totalAmount + Val(CC(itm.SubItems(4).Text))
            End If
        Next
        txtAmount.Text = FormatNumber(totalAmount, 2)
        txtAmountTender.Text = FormatNumber(totalAmount, 2)
    End Sub

    Public Sub SelectPaymentType()
        If radPaymentType.EditValue = "cash" Then
            lblReference.Text = "Reference Number"
            lblRemarks.Text = "Payment Remarks"
            txtDetails.BringToFront()

        ElseIf radPaymentType.EditValue = "check" Then
            lblReference.Text = "Check Number"
            lblRemarks.Text = "Check holder name"
            txtDetails.BringToFront()

        ElseIf radPaymentType.EditValue = "card" Then
            lblReference.Text = "Trace Number"
            lblRemarks.Text = "Card holder name"
            txtDetails.SendToBack()

        End If
        txtReferenceNumber.Text = ""
        txtDetails.Text = ""
    End Sub

    Private Sub radPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radPaymentType.SelectedIndexChanged
        SelectPaymentType()
    End Sub

    Private Sub txtPaymentAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountTender.EditValueChanged, txtAmount.EditValueChanged, txtDiscount.EditValueChanged
        Dim ttlamount As Double = Val(CC(txtAmount.Text)) : Dim payamount As Double = Val(CC(txtAmountTender.Text)) : Dim discount As Double = Val(CC(txtDiscount.Text))
        txtVariance.Text = (payamount + discount) - ttlamount
        If Val(CC(txtVariance.Text)) < 0 Then
            txtVariance.BackColor = Color.Red
            txtVariance.ForeColor = Color.White

        ElseIf Val(CC(txtVariance.Text)) > 0 Then
            txtVariance.BackColor = Color.Green
            txtVariance.ForeColor = Color.Black
        Else
            txtVariance.BackColor = Color.White
            txtVariance.ForeColor = Color.Black
        End If
    End Sub

  
    Private Sub ckDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles ckDiscount.CheckedChanged
        If ckDiscount.Checked = True Then
            txtDiscount.Properties.ReadOnly = False
        Else
            txtDiscount.Properties.ReadOnly = True
            txtDiscount.Text = "0"
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub
End Class