Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Public Class frmTransactionClearing
    Private BandgridView As GridView
    Dim PageCurrentlyOnLoad As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)

        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            CancelledTrnsactionToolStripMenuItem.Visible = True
        Else
            CancelledTrnsactionToolStripMenuItem.Visible = False
        End If
        PageCurrentlyOnLoad = True
        If LCase(globaluser) <> "root" Then
            For Each tb In XtraTabControl1.TabPages
                tb.PageVisible = False
            Next
            com.CommandText = "select * from tblpermissionsclearing where percode='" & globalPermissionAccess & "'" : rst = com.ExecuteReader
            While rst.Read
                For Each tb In XtraTabControl1.TabPages
                    If tb.Name = rst("tabname").ToString Then
                        tb.PageVisible = True
                    End If
                Next
            End While
            rst.Close()
        End If
        PageCurrentlyOnLoad = False
        FilterOption()
        If GlobalDigitalPaymentApproving = True Then
            tabVoucherRequest.PageVisible = False
        Else
            tabVoucherRequest.PageVisible = True
        End If
        If GlobalClientStockReceiving = True Then
            tabPurchaseOrderTransaction.PageVisible = False
        Else
            tabPurchaseOrderTransaction.PageVisible = True
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If PageCurrentlyOnLoad = True Then Exit Sub
        FilterOption()
    End Sub
    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabJournalEntries Then
            Em.Parent = tabJournalEntries
            LoadJournalEntries()
            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                CancelledTrnsactionToolStripMenuItem.Visible = True
            Else
                CancelledTrnsactionToolStripMenuItem.Visible = False
            End If
        ElseIf XtraTabControl1.SelectedTabPage Is tabOtherTransaction Then
            Em.Parent = tabOtherTransaction
            LoadOtherTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabAccountJournal Then
            Em.Parent = tabAccountJournal
            LoadAccountsJournal()
            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                CancelledTrnsactionToolStripMenuItem.Visible = True
            Else
                CancelledTrnsactionToolStripMenuItem.Visible = False
            End If

        ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccountsPayments Then
            Em.Parent = tabKeyAccountsPayments
            LoadKeyaccountPayment()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabClientCheckClearing Then
            Em.Parent = tabClientCheckClearing
            LoadCheckTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabPaymentCheckClearing Then
            Em.Parent = tabPaymentCheckClearing
            LoadCheckingAccountTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderPayment Then
            Em.Parent = tabPurchaseOrderPayment
            LoadPurchaseOrderPayment()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabCreditCard Then
            Em.Parent = tabCreditCard
            LoadCardTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabOnlinePayment Then
            Em.Parent = tabOnlinePayment
            LoadOnlineTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabDepositTransactions Then
            Em.Parent = tabDepositTransactions
            LoadDepositTransaction()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderTransaction Then
            Em.Parent = tabPurchaseOrderTransaction
            LoadPurchaseOrder()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabVoucherRequest Then
            Em.Parent = tabVoucherRequest
            LoadVouchersRequest()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        ElseIf XtraTabControl1.SelectedTabPage Is tabPaymentVoucher Then
            Em.Parent = tabPaymentVoucher
            LoadPaymentVoucher()
            CancelledTrnsactionToolStripMenuItem.Visible = False
        End If
    End Sub
    Public Sub LoadOtherTransaction()
        LoadXgrid("select trnid, Remarks, if(Debit=0,Credit,debit) as Amount, datetrn as 'Date Transaction',(select fullname from tblaccounts where accountid=tblglaccountledger.trnby) as 'Transaction By' from tblglaccountledger where cleared=0 and itemcode=''", "tblglaccountledger", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub


    Public Sub LoadJournalEntries()
        LoadXgrid("select trnid, (select itemname from tbltransactioncode where itemcode=tblglaccountledger.itemcode) as 'Description',Debit,Credit,Remarks,datetrn as 'Date Transaction',(select fullname from tblaccounts where accountid=tblglaccountledger.trnby) as 'Transaction By' from tblglaccountledger where cleared=0 and itemcode<>''", "tblglaccountledger", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Debit", "Credit"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
    End Sub

    Public Sub LoadAccountsJournal()
        LoadXgrid("select trnid, (select itemname from tbltransactioncode where itemcode = tblglaccountledger.itemcode) as 'Transaction Details', " _
                  + " case when journalmode='client-accounts' then (select companyname from tblclientaccounts where cifid = tblglaccountledger.accountno) " _
                  + " when journalmode='bank-accounts' then (select accountname from tblbankaccounts where bankcode = tblglaccountledger.accountno) " _
                  + " when journalmode='payable-accounts' then (select companyname from tblglobalvendor where vendorid = tblglaccountledger.accountno) end as 'Account Name', " _
                  + " Remarks, Debit,Credit,datetrn as 'Date Transaction', (select fullname from tblaccounts where accountid=tblglaccountledger.trnby) as 'Trnsaction By' from tblglaccountledger where cleared=0 and cancelled=0 order by datetrn asc", "tblglaccountledger", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Debit", "Credit"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
    End Sub

    Public Sub LoadKeyaccountPayment()
        On Error Resume Next
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select trnid,(select companyname from tblclientaccounts where cifid = accountno) as 'Client',ucase(paymenttype) as 'Payment Type', totalamount as 'Total Amount', paymentamount as 'Payment Amount', Discount, Variance, Note, datetrn as 'Date Transaction',(select fullname from tblaccounts where accountid = tblpaymenttransactions.trnby) as 'Transaction By' from tblpaymenttransactions where transactiontype<>'payables' and verified=0 and cancelled=0 order by datetrn asc", "tblpaymenttransactions", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpaymenttransactions")

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Payment Type"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Amount", "Payment Amount", "Discount", "Variance"}, GridView1)

        XgridColWidth({"Total Amount", "Payment Amount"}, GridView1, 120)
        XgridColWidth({"Discount", "Variance"}, GridView1, 100)
        XgridGeneralSummaryCurrency({"Total Amount", "Payment Amount", "Discount", "Variance"}, GridView1)

        msda = New MySqlDataAdapter("select paymentrefnumber as 'trnid',date_format(datetrn,'%Y-%m-%d') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' , Amount  from tblsalesclientcharges where paymentupdated=1 union " _
                                    + " select paymentrefnumber as 'trnid',date_format(datetrn,'%Y-%m-%d') as 'Date', 'other-trnsaction', '-' , debit  from tblsalesaccounttransaction where paymentupdated=1 ", conn)
        msda.Fill(dst, "tblsalesclientcharges")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblpaymenttransactions").Columns("trnid")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblsalesclientcharges").Columns("trnid")

        dst.Relations.Add("Invoices", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("Invoices", BandgridView)

        Em.DataSource = dst.Tables("tblpaymenttransactions")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblsalesclientcharges"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"trnid"}, BandgridView)
        XgridColCurrency({"Amount"}, BandgridView)
        XgridColAlign({"Order Number", "Invoice No."}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, BandgridView)
    End Sub

    Public Sub LoadCheckTransaction()
        LoadXgrid("select * from (select checkdate, trnid,'no' as 'nonpayment', (select companyname from tblclientaccounts where cifid = accountno) as 'Client',checkno as 'Check Number', checkdetails as 'Bank Check', Remarks as 'Company Name',if(checkdate='0000-00-00','-',date_format(checkdate,'%Y-%m-%d')) as 'Check Date', Amount,if(checkdate='0000-00-00','-',if(DATEDIFF(checkdate,current_date)<0,'past due',if(DATEDIFF(checkdate,current_date)=0,'due today',concat(DATEDIFF(checkdate,current_date),' day(s)')))) as 'Days before due' , datetrn as 'Date Transaction' from tblsaleschecktransaction where cancelled=0 and verified=1 and cleared=0 union all " _
                  + " select checkdate,id as trnid, 'yes', 'check encashment', checknumber,issuerbank,companyname,if(checkdate='0000-00-00','-',date_format(checkdate,'%Y-%m-%d')),amount,if(checkdate='0000-00-00','-',if(DATEDIFF(checkdate,current_date)<0,'past due',if(DATEDIFF(checkdate,current_date)=0,'due today',concat(DATEDIFF(checkdate,current_date),' day(s)')))),datetrn from tblsaleschecktocash where cancelled=0 and verified=1 and cleared=0) as s order by checkdate asc", "tblsaleschecktransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid", "nonpayment", "checkdate"}, GridView1)
        XgridColAlign({"Check Number", "Check Date", "Days before due"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Amount"}, GridView1, 120)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadCheckingAccountTransaction()
        LoadXgrid("select trnid,(select companyname from tblglobalvendor where vendorid = accountno) as 'Supplier',checkno as 'Check Number', checkdetails as 'Bank Check', Remarks as 'Account Name',if(checkdate='0000-00-00','-',date_format(checkdate,'%Y-%m-%d')) as 'Check Date', Amount,if(checkdate='0000-00-00','-',if(DATEDIFF(checkdate,current_date)<0,'past due',if(DATEDIFF(checkdate,current_date)=0,'due today',concat(DATEDIFF(checkdate,current_date),' day(s)')))) as 'Days before due' , datetrn as 'Date Transaction' from tblpayablechecktransaction where cancelled=0 and verified=1 and cleared=0  order by checkdate asc", "tblpayablechecktransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Check Number", "Check Date", "Days before due"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Amount"}, GridView1, 120)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadPurchaseOrderPayment()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select voucherno as trnid, voucherno as 'Voucher No.', (select lcase(companyname) from tblglobalvendor where vendorid = accountno) as 'Supplier',Ucase(paymenttype) as 'Payment Type', totalamount as 'Total Amount', Discount, PaymentAmount,Variance, Note, datetrn as 'Date Transaction',(select fullname from tblaccounts where accountid = tblpayabletransactions.trnby) as 'Transaction By' from tblpayabletransactions where verified=0 and cancelled=0 order by datetrn asc", "tblpayabletransactions", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpayabletransactions")


        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Payment Type"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Amount", "Discount", "PaymentAmount", "Variance"}, GridView1)

        XgridColWidth({"Total Amount", "Discount", "PaymentAmount", "Variance"}, GridView1, 100)
        XgridGeneralSummaryCurrency({"Total Amount", "Discount", "PaymentAmount", "Variance"}, GridView1)

        msda = New MySqlDataAdapter("select paymentrefnumber as 'trnid',date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', invoiceno as 'Invoice No.' , totalAmount as 'Amount'  from tblpurchaseorder where paymentupdated=1", conn)
        msda.Fill(dst, "tblpurchaseorder")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblpayabletransactions").Columns("trnid")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblpurchaseorder").Columns("trnid")

        dst.Relations.Add("Purchase Order", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("Purchase Order", BandgridView)

        Em.DataSource = dst.Tables("tblpayabletransactions")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblpurchaseorder"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"trnid"}, BandgridView)
        XgridColCurrency({"Amount"}, BandgridView)
        XgridColAlign({"PO Number", "Invoice No."}, BandgridView, HorzAlignment.Center)
        XgridColWidth({"Amount"}, BandgridView, 120)
        XgridGeneralSummaryCurrency({"Amount"}, BandgridView)

    End Sub

    Public Sub LoadCardTransaction()
        LoadXgrid("select trnid,(select companyname from tblclientaccounts where cifid = accountno) as 'Client',tracenumber as 'Trace Number', (select accountname from tblbankaccounts where bankcode = bankaccount) as 'Bank Account', Remarks, Amount, datetrn as 'Date Transaction' from tblsalescardtransaction where verified=0  and cancelled=0", "tblsalescardtransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Trace Number"}, GridView1, HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadOnlineTransaction()
        LoadXgrid("select trnid,batchcode as 'Transaction Ref.', (select accountname from tblbankaccounts where bankcode = bankaccount) as 'Account', referenceno as 'Payment Reference', Amount, datetrn as 'Date Transaction',(select fullname from tblaccounts where accountid=tblsalesdepositpaymenttransaction.trnby) as 'Transaction by' from tblsalesdepositpaymenttransaction where verified=1 and cleared=0  and cancelled=0", "tblsalesdepositpaymenttransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Transaction Ref.", "Payment Reference"}, GridView1, HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridColWidth({"Amount"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadDepositTransaction()
        LoadXgrid("select trnid,(select itemname from tbltransactioncode where itemcode=tblsalesdeposittransaction.itemcode) as 'Description', (select accountname from tblbankaccounts where bankcode=tblsalesdeposittransaction.bankdeposited) as 'Deposit to', " _
                  + "  amountdeposited as 'Total Amount', referenceno as 'Reference No.', Remarks,  datetrn as 'Date Post',(select fullname from tblaccounts where accountid = tblsalesdeposittransaction.trnby) as 'Post By' from tblsalesdeposittransaction where cancelled=0 and verified=0", "tblsalesdeposittransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColWidth({"Total Amount"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
    End Sub

    Public Sub LoadPurchaseOrder()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select cast(ponumber as char(50)) as 'trnid', ponumber as 'PO Number', (select companyname from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', subtotal as 'Total Amount', date_format(datetrn,'%Y-%m-%d')  as 'Date Transaction' from  tblpurchaseorder where verified=0 and cancelled=0 order by datetrn asc", "tblpurchaseorder", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblpurchaseorder")

        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"PO Number"}, GridView1, HorzAlignment.Center)

        XgridColWidth({"Total Amount"}, GridView1, 120)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
        GridView1.Columns("trnid").Visible = False

        msda = New MySqlDataAdapter("select ponumber as 'trnid', itemname as 'Product',  Quantity, Unit, cost as 'Unit Cost',Total, Remarks  from tblpurchaseorderitem where ponumber in (select ponumber from tblpurchaseorder where verified=0 and cancelled=0 ) ", conn)
        msda.Fill(dst, "tblpurchaseorderitem")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblpurchaseorder").Columns("trnid")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblpurchaseorderitem").Columns("trnid")

        dst.Relations.Add("PurchaseDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("PurchaseDetails", BandgridView)

        Em.DataSource = dst.Tables("tblpurchaseorder")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblpurchaseorderitem"))
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"trnid"}, BandgridView)
        XgridColCurrency({"Unit Cost", "Total"}, BandgridView)
        XgridColAlign({"Quantity", "Unit"}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, BandgridView)
        BandgridView.Columns("Product").Width = 500
    End Sub

    Public Sub LoadVouchersRequest()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select voucherno as trnid, voucherno as 'Voucher No.', (select companyname from tblglobalvendor where vendorid=tblvouchers.payto) as 'Pay To', Description,VoucherType, amount as TotalAmount, " _
                                        + " if(creditaccount='','None',(select accountname from tblbankaccounts where bankcode=tblvouchers.creditaccount)) as 'Credit Account', (select fullname from tblaccounts where accountid=tblvouchers.trnby) as 'Created By',date_format(datetrn, '%Y-%m-%d %r') as 'Date Created'  from tblvouchers  Where verified=0 and cancelled=0 order by datetrn desc", "tblvouchers", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblvouchers")

        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"TotalAmount"}, GridView1)
        XgridColAlign({"Voucher No.", "VoucherType", "Date Created"}, GridView1, HorzAlignment.Center)


        msda = New MySqlDataAdapter("select voucherno as trnid, voucherno as 'Voucher No.', ifnull((select itemname from tblglitem where itemcode=tblvouchersdetail.itemcode),(select itemname from tbltransactioncode where itemcode=tblvouchersdetail.itemcode)) as 'Item Name', Debit,Credit, Remarks from tblvouchersdetail", conn)
        msda.Fill(dst, "tblvouchersdetail")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblvouchers").Columns("Voucher No.")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblvouchersdetail").Columns("Voucher No.")

        dst.Relations.Add("VoucherDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("VoucherDetails", BandgridView)

        Em.DataSource = dst.Tables("tblvouchers")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblvouchersdetail"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"Voucher No.", "trnid"}, BandgridView)
        XgridColCurrency({"Debit", "Credit"}, BandgridView)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, BandgridView)
        XgridColWidth({"Item Name", "Remarks"}, BandgridView, 300)
    End Sub
    Public Sub LoadPaymentVoucher()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("Select voucherno as trnid, officeid, voucherno as 'Voucher No.', (select companyname from tblglobalvendor where vendorid=tblvouchers.payto) as 'Pay To', Description,VoucherType as PaymentType, amount as TotalAmount, " _
                                        + " if(creditaccount='','CHECK',(select accountname from tblbankaccounts where bankcode=tblvouchers.creditaccount)) as 'Credit Account',  (select fullname from tblaccounts where accountid=tblvouchers.trnby) as 'Created By', date_format(datetrn, '%Y-%m-%d %r') as 'Date Created', " _
                                        + " (select fullname from tblaccounts where accountid=tblvouchers.paidby) as 'Payment Posted by',date_format(datepaid, '%Y-%m-%d %r') as 'Date Payment Posted'  from tblvouchers  Where verified=1 and paid=1 and cleared=0 and cancelled=0 order by datetrn desc", "tblvouchers", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblvouchers")

        XgridHideColumn({"trnid", "officeid"}, GridView1)
        XgridColCurrency({"TotalAmount"}, GridView1)
        XgridColAlign({"Voucher No.", "PaymentType", "Credit Account", "Date Created", "Date Payment Posted"}, GridView1, HorzAlignment.Center)

        msda = New MySqlDataAdapter("select tblpayablechecktransaction.voucherno as 'Voucher No.',(select accountname from tblbankaccounts where bankcode=tblpayablechecktransaction.checkingaccount) as CheckingAccount, checkno as 'Check No.', checkdetails as 'Bank Name',CheckDate, tblpayablechecktransaction.Amount from tblpayablechecktransaction inner join tblvouchers on tblpayablechecktransaction.voucherno = tblvouchers.voucherno where tblpayablechecktransaction.cancelled=0 and tblpayablechecktransaction.verified=0 and tblvouchers.cancelled=0 and tblvouchers.verified=1 and paid=1 and tblvouchers.cleared=0", conn)
        msda.Fill(dst, "tblpayablechecktransaction")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblvouchers").Columns("Voucher No.")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblpayablechecktransaction").Columns("Voucher No.")

        dst.Relations.Add("CheckPayment", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("CheckPayment", BandgridView)

        Em.DataSource = dst.Tables("tblvouchers")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblpayablechecktransaction"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"Voucher No."}, BandgridView)
        XgridColCurrency({"Amount"}, BandgridView)
        XgridColAlign({"Check No.", "Bank Name", "CheckDate"}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, BandgridView)
    End Sub

    Private Sub cmdClearing_Click(sender As Object, e As EventArgs) Handles cmdClearing.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraTabControl1.SelectedTabPage Is tabJournalEntries Then
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblglaccountledger set cleared=1, clearedby='" & globalfullname & "', datecleared=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabAccountJournal Then
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblglaccountledger set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccountsPayments Then
                If GlobalPaymentGLItemCode = "" Then
                    XtraMessageBox.Show("Global Payment GL Item not set! please set your default client payment GL settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpaymenttransactions set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsaleschecktransaction set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnsumcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + "select 'client-accounts',accountno,trnid,'" & GlobalPaymentGLItemCode & "', note, 0, paymentamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblpaymenttransactions where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabOtherTransaction Then
                frmVerifiedOtherTransaction.ShowDialog(Me)

            ElseIf XtraTabControl1.SelectedTabPage Is tabClientCheckClearing Then
                frmVerifiedCheckDeposit.ShowDialog(Me)

            ElseIf XtraTabControl1.SelectedTabPage Is tabPaymentCheckClearing Then
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpayablechecktransaction set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + "select 'bank-accounts',checkingaccount,referenceno,'" & GlobalGLCheckPayment & "', concat('#',checkno,' ', (select lcase(companyname) from tblglobalvendor where vendorid = accountno)), 0,amount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblpayablechecktransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderPayment Then
                If GlobalPOPaymentGLItemCode = "" Then
                    XtraMessageBox.Show("Global Payment GL Item for Purchase Order not set!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpayabletransactions set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Payment Type").ToString = "CHECK" Then
                            com.CommandText = "update tblpayablechecktransaction set verified=1, verifiedby='" & globaluserid & "',dateverified=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                           + "select 'bank-accounts',depositto,voucherno,'" & GlobalPOPaymentGLItemCode & "', note, 0, paymentamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblpayabletransactions where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        End If
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                          + "select 'payable-accounts',accountno,voucherno,'" & GlobalPOPaymentGLItemCode & "', note, 0, paymentamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblpayabletransactions where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblvouchers set paid=1, datepaid=current_timestamp,paidby='" & globaluserid & "',cleared=1,datecleared=current_timestamp,clearedby='" & globaluserid & "' where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabCreditCard Then
                Dim totalAmount As Double = 0
                If GLobalGLItemCreditCard = "" Then
                    XtraMessageBox.Show("Global Credit Card GL Item not set! please set your default Credit Card GL settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Dim I As Integer = 0
                For I = 0 To GridView1.SelectedRowsCount - 1
                    totalAmount = totalAmount + Val(CC(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Amount").ToString))
                Next
                frmVerifiedCreditCard.txtTotalCreditCardAmount.Text = totalAmount
                frmVerifiedCreditCard.ShowDialog(Me)

            ElseIf XtraTabControl1.SelectedTabPage Is tabOnlinePayment Then
                If GLobalGLItemOnlinePayment = "" Then
                    XtraMessageBox.Show("Global Online Payment transaction Item not set! please set your default online payment item settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblsalesdepositpaymenttransaction set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + "select 'bank-accounts',bankaccount,trnid,'" & GLobalGLItemOnlinePayment & "', concat('TrnRef#',batchcode), amount,0,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesdepositpaymenttransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            ElseIf XtraTabControl1.SelectedTabPage Is tabDepositTransactions Then
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblsalesdeposittransaction set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + "select 'bank-accounts',bankdeposited,referenceno,itemcode, remarks, 0,amountdeposited,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesdeposittransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderTransaction Then
                If GLobalGLItemPurchaseOrder = "" Then
                    XtraMessageBox.Show("Global Accounts Payable for Purchase Order GL Item not set! please set your default settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If GridView1.SelectedRowsCount > 1 Then
                    XtraMessageBox.Show("Multi selection of purchase order is not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                frmVerifiedPurchaseOrder.txtSupplier.Text = GridView1.GetFocusedRowCellValue("Supplier").ToString
                frmVerifiedPurchaseOrder.txtTotalAmount.Text = GridView1.GetFocusedRowCellValue("Total Amount").ToString
                frmVerifiedPurchaseOrder.ShowDialog(Me)

            ElseIf XtraTabControl1.SelectedTabPage Is tabVoucherRequest Then
                If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblvouchers set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf XtraTabControl1.SelectedTabPage Is tabPaymentVoucher Then
                If GlobalGLVoucherCode = "" Then
                    XtraMessageBox.Show("Global Voucher GL Item not set! please set your default settings", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                frmVerifiedVoucherConfirmation.ShowDialog(Me)
            End If
        End If
    End Sub

    Public Sub validatingOtherTransaction(ByVal itemcode As String, ByVal bankaccount As String)
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblglaccountledger set accountno='" & bankaccount & "',itemcode='" & itemcode & "', cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterOption()
        XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub validatingcheckdeposit(ByVal bankaccount As String)
        Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "nonpayment").ToString = "yes" Then
                com.CommandText = "update tblsaleschecktocash set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp,depositto='" & bankaccount & "' where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                    + "select 'bank-accounts','" & bankaccount & "',trnsumcode,'" & GlobalGLCheckDeposit & "', concat('#',checknumber,' ', lcase(issuerbank),' ',lcase(companyname),' ',lcase(remarks)), 0,amount,datetrn,userid,1,'" & globaluserid & "',current_timestamp from tblsaleschecktocash where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblsaleschecktransaction set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp,depositto='" & bankaccount & "' where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                    + "select 'bank-accounts','" & bankaccount & "',referenceno,'" & GlobalGLCheckDeposit & "', concat('#',checkno,' ', lcase(checkdetails),' ',lcase(remarks)), 0,amount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsaleschecktransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            End If
        Next
        FilterOption()
        XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ValidatingCreditCard(ByVal rate As Double, ByRef amount As Double)
        If GridView1.SelectedRowsCount > 0 Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblsalescardtransaction set verifiedamount=amount-((" & rate & "/100)*amount), deductedrate='" & rate & "',verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "' where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                           + "select 'bank-accounts',bankaccount,tracenumber,'" & GLobalGLItemCreditCard & "', remarks, 0, verifiedamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalescardtransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
        Else
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblsalescardtransaction set verifiedamount='" & amount & "', deductedrate='" & rate & "',verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "' where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                   + "select 'bank-accounts',bankaccount,tracenumber,'" & GLobalGLItemCreditCard & "', remarks, 0, verifiedamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalescardtransaction where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Next
        End If
        FilterOption()
        XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ValidatingPurchaseOrder(ByVal invoicenumber As String, ByVal vat As Double, ByVal charges As Double, ByVal discount As Double, ByRef verifiedAmount As Double)
        dst = New DataSet
        msda = New MySqlDataAdapter("Select *,(select invoiceno from tblpurchaseorder where ponumber=tblpurchaseorderitem.ponumber) as invoice from tblpurchaseorderitem where ponumber='" & GridView1.GetFocusedRowCellValue("trnid").ToString & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                UpdateInventory("Purchase order", GridView1.GetFocusedRowCellValue("trnid").ToString, .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("cost").ToString())), "Purchase Order #" + GridView1.GetFocusedRowCellValue("trnid").ToString, "", .Rows(cnt)("invoice").ToString(), Now)
                com.CommandText = "update tblpurchaseorderitem set delivered=1, datedelivered=current_timestamp where trnid='" & .Rows(cnt)("trnid").ToString() & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblglobalproducts set purchasedprice='" & Val(CC(.Rows(cnt)("cost").ToString())) & "' where productid='" & .Rows(cnt)("productid").ToString() & "'" : com.ExecuteNonQuery()
            End With
        Next

        com.CommandText = "update tblpurchaseorder set invoiceno='" & invoicenumber & "', vat='" & vat & "', charges='" & charges & "', discount='" & discount & "',totalamount='" & verifiedAmount & "', verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "',delivered=1,datedelivered=current_timestamp,receivedby='" & globaluserid & "', paymentrequested=1, paymentrequestedby='" & globaluserid & "' where ponumber='" & GridView1.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                        + "select 'payable-accounts',vendorid,ponumber,'" & GLobalGLItemPurchaseOrder & "', note, '" & verifiedAmount & "', 0,current_timestamp,createby,1,'" & globaluserid & "',current_timestamp from tblpurchaseorder where ponumber='" & GridView1.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
        If GLobalEmailNotifyReceivedPOstock = True Then
            SendReceivedPOStock(GridView1.GetFocusedRowCellValue("trnid").ToString)
        End If

        FilterOption()
        XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub validatingVoucherPayment(ByVal receivername As String)
       Dim I As Integer = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            If LCase(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PaymentType").ToString) = "check" Then
                com.CommandText = "update tblpayablechecktransaction set verified=1, verifiedby='" & globaluserid & "',dateverified=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                              + "select 'bank-accounts',creditaccount,voucherno,'" & GlobalGLVoucherCode & "', description, 0, amount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblvouchers where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
            End If
            com.CommandText = "update tblvouchers set cleared=1, clearedby='" & globaluserid & "', datecleared=current_timestamp, receivedby='" & rchar(receivername) & "' where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterOption()
        XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
    End Sub

    Private Sub CancelledTrnsactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelledTrnsactionToolStripMenuItem.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraTabControl1.SelectedTabPage Is tabJournalEntries Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblglticket set cancelled=1, cancelledby='" & globalfullname & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabAccountJournal Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblglaccountledger set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabKeyAccountsPayments Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpaymenttransactions set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsalesclientcharges set paymentupdated=0, paymentrefnumber='' where paymentrefnumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsaleschecktransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnsumcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderPayment Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpayabletransactions set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblpurchaseorder set paymentupdated=0, paymentrefnumber='' where paymentrefnumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsaleschecktransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnsumcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabCreditCard Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblsalescardtransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf XtraTabControl1.SelectedTabPage Is tabDepositTransactions Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblsalesdeposittransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf XtraTabControl1.SelectedTabPage Is tabPurchaseOrderTransaction Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblpurchaseorder set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where ponumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf XtraTabControl1.SelectedTabPage Is tabVoucherRequest Then
                If XtraMessageBox.Show("Are you sure you want to cancel selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim I As Integer = 0
                    For I = 0 To GridView1.SelectedRowsCount - 1
                        com.CommandText = "update tblvouchers set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblpayablechecktransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where voucherno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    Next
                    FilterOption()
                    XtraMessageBox.Show("Transaction successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PrintGeneralReport(Me.Text, XtraTabControl1.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub
End Class