Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils

Public Class frmCashiersTransactionClearing
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        FilterOption()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub
    Public Sub FilterOption()
        ViewAttachmentToolStripMenuItem.Visible = False
        If XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
            Em.Parent = tabKeyAccounts
            LoadKeyAccounts()

        ElseIf XtraTabControl1.SelectedTabPage Is tabExpenses Then
            Em.Parent = tabExpenses
            LoadSalesExpense()
            ViewAttachmentToolStripMenuItem.Visible = True

        ElseIf XtraTabControl1.SelectedTabPage Is tabCheck Then
            Em.Parent = tabCheck
            LoadCheckTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCreditCard Then
            Em.Parent = tabCreditCard
            LoadCardTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabBankPayment Then
            Em.Parent = tabBankPayment
            LoadBankPaymentTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabCashChange Then
            Em.Parent = tabCashChange
            LoadCashChangeTransaction()

        ElseIf XtraTabControl1.SelectedTabPage Is tabAccountJournal Then
            Em.Parent = tabAccountJournal
            LoadAccountJournal()
            ViewAttachmentToolStripMenuItem.Visible = True

        ElseIf XtraTabControl1.SelectedTabPage Is tabClientJournal Then
            Em.Parent = tabClientJournal
            LoadClientJournal()
            ViewAttachmentToolStripMenuItem.Visible = True

        End If
        CheckTransactionForclearing()
    End Sub

    Public Sub CheckTransactionForclearing()
        If countqry("tblsalesclientcharges", "verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdKeyAccounts.Appearance.ForeColor = Color.Red
        Else
            cmdKeyAccounts.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsaleschecktransaction", " verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdCheckTransaction.Appearance.ForeColor = Color.Red
        Else
            cmdCheckTransaction.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsalescardtransaction", "firstclearing=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdCreditCard.Appearance.ForeColor = Color.Red
        Else
            cmdCreditCard.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsaleschecktocash", "verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdEncashment.Appearance.ForeColor = Color.Red
        Else
            cmdEncashment.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsalesdepositpaymenttransaction", "verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdBanksPayment.Appearance.ForeColor = Color.Red
        Else
            cmdBanksPayment.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblexpenses", "verified=0 and cancelled=0 and duefromcode='" & trnsumcode.Text & "'") > 0 Then
            cmdExpense.Appearance.ForeColor = Color.Red
        Else
            cmdExpense.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsalesaccounttransaction", "verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdClientJournal.Appearance.ForeColor = Color.Red
        Else
            cmdClientJournal.Appearance.ForeColor = DefaultForeColor
        End If
        If countqry("tblsalesaccountjournal", "verified=0 and cancelled=0 and trnsumcode='" & trnsumcode.Text & "'") > 0 Then
            cmdAccountJournal.Appearance.ForeColor = Color.Red
        Else
            cmdAccountJournal.Appearance.ForeColor = DefaultForeColor
        End If
        
    End Sub

    Public Sub LoadKeyAccounts()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select trnid, (select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'Client',batchcode as 'Batch Code', invoiceno as 'Invoice No.', amount as 'Total Amount', datetrn as 'Date Transaction'  from tblsalesclientcharges where cancelled=0 and verified=0 and trnsumcode='" & trnsumcode.Text & "' ", "tblsalesclientcharges", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblsalesclientcharges")

        msda = New MySqlDataAdapter("select  batchcode as 'Batch Code', productname as 'Particular' ,Quantity, Unit,sellprice as 'Unit Price', distotal as 'Discount',chargetotal as 'Charges', subtotal as 'Sub Total',total as 'Total' from tblsalestransaction where trnsumcode='" & trnsumcode.Text & "' and onhold=0 and cancelled=0 and void=0", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblsalestransaction")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblsalesclientcharges").Columns("Batch Code")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblsalestransaction").Columns("Batch Code")

        dst.Relations.Add("Transaction Details", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("Transaction Details", BandgridView)

        Em.DataSource = dst.Tables("tblsalesclientcharges")

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Batch Code", "Invoice No.", "Date Transaction"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Amount"}, GridView1)

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblsalestransaction"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"Batch Code"}, BandgridView)
        XgridColCurrency({"Quantity", "Discount", "Charges", "Sub Total", "Total"}, BandgridView)
        XgridColAlign({"Unit", "Quantity"}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Sub Total", "Total"}, BandgridView)
    End Sub

    Public Sub LoadSalesExpense()
        LoadXgrid("select id as trnid, (select itemname from tblglitem where itemcode = tblexpenses.glitemcode) as 'Description', Remarks, Amount, datetrn as 'Date Transaction' from tblexpenses where cancelled=0 and verified=0 and duefromcode='" & trnsumcode.Text & "' ", "tblexpenses", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadCheckTransaction()
        LoadXgrid("select trnid,(select companyname from tblclientaccounts where cifid = accountno) as 'Client',checkno as 'Check Number', checkdetails as 'Check Details', Remarks, Amount, datetrn as 'Date Transaction' from tblsaleschecktransaction where cancelled=0 and verified=0 and trnsumcode='" & trnsumcode.Text & "' ", "tblsaleschecktransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Check Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadCardTransaction()
        LoadXgrid("select trnid,(select companyname from tblclientaccounts where cifid = accountno) as 'Client',tracenumber as 'Trace Number', (select accountname from tblbankaccounts where bankcode = bankaccount) as 'Account Account', Remarks, Amount, datetrn as 'Date Transaction' from tblsalescardtransaction where cancelled=0 and firstclearing=0 and trnsumcode='" & trnsumcode.Text & "' ", "tblsalescardtransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Trace Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadBankPaymentTransaction()
        LoadXgrid("select trnid, (select accountname from tblbankaccounts where bankcode = bankaccount) as 'Account Account', referenceno as 'Reference Number', Amount, datetrn as 'Date Transaction' from tblsalesdepositpaymenttransaction where cancelled=0 and verified=0 and trnsumcode='" & trnsumcode.Text & "' ", "tblsalesdepositpaymenttransaction", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Reference Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadCashChangeTransaction()
        LoadXgrid("select id as 'trnid', checknumber as 'Check Number',issuerbank as 'Issuer Bank', companyname as 'Company Name', date_format(checkdate,'%Y-%m-%d') as 'Check Date', Amount, Remarks,  datetrn as 'Date Post' from tblsaleschecktocash where trnsumcode = '" & trnsumcode.Text & "' and cancelled=0 and verified=0", "tblsaleschecktocash", Em, GridView1, Me)

        XgridHideColumn({"trnid"}, GridView1)
        XgridColAlign({"Check Number", "Check Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
    End Sub

    Public Sub LoadAccountJournal()
        LoadXgrid("select id as 'trnid', (select accountname from tblbankaccounts where bankcode = tblsalesaccountjournal.accountno) as 'Account Name', Remarks, Debit, Credit,  datetrn as 'Date Post', case when affectcash = 1 then 'Yes' else 'No' end as 'Affect Cash' from tblsalesaccountjournal where trnsumcode = '" & trnsumcode.Text & "' and cancelled=0 and verified=0", "tblsalesaccountjournal", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
    End Sub
    Public Sub LoadClientJournal()
        LoadXgrid("select id as 'trnid', (select companyname from tblclientaccounts where cifid = tblsalesaccounttransaction.accountno) as 'Client', Remarks, Debit, Credit, datetrn as 'Date Post', case when affectcash = 1 then 'Yes' else 'No' end as 'Affect Cash' from tblsalesaccounttransaction where trnsumcode = '" & trnsumcode.Text & "' and cancelled=0 and verified=0", "tblsalesaccounttransaction", Em, GridView1, Me)
        XgridHideColumn({"trnid"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
    End Sub
    
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If CheckSelectedRow("trnid", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to clear selected transaction? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim I As Integer = 0
                For I = 0 To GridView1.SelectedRowsCount - 1
                    If XtraTabControl1.SelectedTabPage Is tabKeyAccounts Then
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + " select 'client-accounts',accountno,invoiceno,glitemcode,remarks,amount,0,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesclientcharges where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                        com.CommandText = "update tblsalesclientcharges set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    ElseIf XtraTabControl1.SelectedTabPage Is tabExpenses Then
                        com.CommandText = "update tblexpenses set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabCheck Then
                        com.CommandText = "update tblsaleschecktransaction set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabCreditCard Then
                        com.CommandText = "update tblsalescardtransaction set firstclearing=1 where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabBankPayment Then
                        com.CommandText = "update tblsalesdepositpaymenttransaction set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabCashChange Then
                        com.CommandText = "update tblsaleschecktocash set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabAccountJournal Then
                        com.CommandText = "update tblsalesaccountjournal set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + " select 'bank-accounts',accountno,'',itemcode,remarks,debit,credit,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesaccountjournal where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                    ElseIf XtraTabControl1.SelectedTabPage Is tabClientJournal Then
                        com.CommandText = "update tblsalesaccounttransaction set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                        com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + " select 'client-accounts',accountno,'',itemcode,remarks,debit,credit,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesaccounttransaction where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()

                   
                    End If
                Next
                FilterOption()
                XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterOption()
    End Sub

    Private Sub ViewAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttachmentToolStripMenuItem.Click
        ViewAttachmentPackage_Database({GridView1.GetFocusedRowCellValue("trnid").ToString}, "")
    End Sub


#Region "MENU"
    Private Sub cmdKeyAccounts_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdKeyAccounts.LinkClicked
        XtraTabControl1.SelectedTabPage = tabKeyAccounts
    End Sub
    Private Sub cmdExpense_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdExpense.LinkClicked
        XtraTabControl1.SelectedTabPage = tabExpenses
    End Sub

    Private Sub cmdCheckTransaction_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCheckTransaction.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCheck
    End Sub

    Private Sub cmdCreditCard_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdCreditCard.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCreditCard
    End Sub

    Private Sub cmdBanksPayment_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdBanksPayment.LinkClicked
        XtraTabControl1.SelectedTabPage = tabBankPayment
    End Sub

    Private Sub cmdEncashment_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdEncashment.LinkClicked
        XtraTabControl1.SelectedTabPage = tabCashChange
    End Sub

    Private Sub cmdAccountJournal_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountJournal.LinkClicked
        XtraTabControl1.SelectedTabPage = tabAccountJournal
    End Sub

    Private Sub cmdClientJournal_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdClientJournal.LinkClicked
        XtraTabControl1.SelectedTabPage = tabClientJournal
    End Sub

   
#End Region
 
End Class