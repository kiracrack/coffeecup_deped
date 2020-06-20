Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCurrentDueReceivable
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

 
        End If
        Return ProcessCmdKey
    End Function
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txttitle.Text = Me.Text
        LoadGridviewAppearance(GridView1)
        filter()
        If globalAllowAdd = True Then
            cmdClientTransaction.Visible = True
        Else
            cmdClientTransaction.Visible = False
        End If
        txtdateFrom.EditValue = Format(Now)
    End Sub

    Public Sub filter()
        If txtdateFrom.Text = "" Then Exit Sub
        LoadXgrid("SELECT tblclientaccounts.cifid as 'Client ID', (select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'Client Name',date_format(tblsalesclientchargesitem.datetrn, '%Y-%m-%d') as 'Date', invoiceno as 'Invoice No.', (select itemname from tblglobalproducts where productid=tblsalesclientchargesitem.productid and actived=1) as 'Product',Quantity,sellprice as 'Unit Cost', chargetotal as 'Charges', distotal as 'Discount', Total, " _
                        + " date_format(cast(case when duetype='DAYS' then date_format(tblsalesclientchargesitem.datetrn + interval duevalue day,'%Y-%m-%d') " _
                        + " when duetype='WEEK' then DATE_ADD(tblsalesclientchargesitem.datetrn, INTERVAL ((7+duevalue) - DAYOFWEEK(tblsalesclientchargesitem.datetrn)) DAY) " _
                        + " when duetype='MONTH' then concat(date_format(tblsalesclientchargesitem.datetrn + interval 1 month,'%Y-%m'),'-',duevalue) " _
                        + " end as date),'%Y-%m-%d') as 'Due Date', " _
                        + " datediff('" & ConvertDate(txtdateFrom.Text) & "',date_format(cast(case when duetype='DAYS' then date_format(tblsalesclientchargesitem.datetrn + interval duevalue day,'%Y-%m-%d')  when duetype='WEEK' then DATE_ADD(tblsalesclientchargesitem.datetrn, INTERVAL ((7+duevalue) - DAYOFWEEK(tblsalesclientchargesitem.datetrn)) DAY)  when duetype='MONTH' then concat(date_format(tblsalesclientchargesitem.datetrn + interval 1 month,'%Y-%m'),'-',duevalue)  end as date),'%Y-%m-%d')) as 'Days Overdue' " _
                        + " from tblsalesclientchargesitem inner join tblsalesclientcharges on tblsalesclientchargesitem.batchcode = tblsalesclientcharges.batchcode " _
                        + " inner join tblclientaccounts on tblclientaccounts.cifid = tblsalesclientcharges.accountno where " _
                        + " date_format('" & ConvertDate(txtdateFrom.Text) & "','%Y-%m-%d') >= date_format(cast(case when duetype='DAYS' then date_format(tblsalesclientchargesitem.datetrn + interval duevalue day,'%Y-%m-%d')  when duetype='WEEK' then DATE_ADD(tblsalesclientchargesitem.datetrn, INTERVAL ((7+duevalue) - DAYOFWEEK(tblsalesclientchargesitem.datetrn)) DAY)  when duetype='MONTH' then concat(date_format(tblsalesclientchargesitem.datetrn + interval 1 month,'%Y-%m'),'-',duevalue)  end as date),'%Y-%m-%d') and " _
                        + " enabledue=true and paymentupdated=0 and  tblsalesclientcharges.cancelled=0 order by datediff('" & ConvertDate(txtdateFrom.Text) & "',date_format(cast(case when duetype='DAYS' then date_format(tblsalesclientchargesitem.datetrn + interval duevalue day,'%Y-%m-%d')  when duetype='WEEK' then DATE_ADD(tblsalesclientchargesitem.datetrn, INTERVAL ((7+duevalue) - DAYOFWEEK(tblsalesclientchargesitem.datetrn)) DAY)  when duetype='MONTH' then concat(date_format(tblsalesclientchargesitem.datetrn + interval 1 month,'%Y-%m'),'-',duevalue)  end as date),'%Y-%m-%d')) desc;", "tblsalesclientchargesitem", Em, GridView1, Me)
        GridView1.Columns("Client ID").Visible = False
        GridView1.BestFitColumns()
        GridView1.Columns("Client Name").Width = 250

        XgridColCurrency({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, GridView1)
        XgridColWidth({"Unit Cost", "Quantity", "Charges", "Discount", "Total"}, GridView1, 90)
        XgridColAlign({"Date", "Due Date", "Invoice No.", "Quantity", "Days Overdue"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridGroupSummaryCurrency({"Total"}, GridView1)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim status As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Days Overdue"))
        If status > 30 Then
            e.Appearance.ForeColor = Color.Red
        Else
            e.Appearance.ForeColor = DefaultForeColor
        End If

    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmClientModification.mode.Text = ""
        frmClientModification.id.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientModification.mode.Text = "edit"
        If frmClientModification.Visible = True Then
            frmClientModification.Focus()
        Else
            frmClientModification.Show(Me)
        End If
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("Client ID", "cifid", "tblclientaccounts", GridView1, Me)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
 

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowFindPanel()
    End Sub
 
    Private Sub FormatGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatGridToolStripMenuItem.Click
        frmUserProfile.formatGrid(GridView1)
        frmUserProfile.Show(Me) : frmUserProfile.XtraTabControl1.SelectedTabPage = frmUserProfile.XtraTabPage2
    End Sub

    Private Sub ViewInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmClientProductFilter.cifid.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        If frmClientProductFilter.Visible = True Then
            frmClientProductFilter.Focus()
        Else
            frmClientProductFilter.Show(Me)
        End If
    End Sub

    Private Sub ViewInformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem1.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            'ElseIf GridView1.GetFocusedRowCellValue("Pending Invoices").ToString = "0" Then
            '    XtraMessageBox.Show("There's no Pending Invoices to create billing", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
        End If

        frmBillingStatement.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmBillingStatement.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmBillingStatement.txtClient.Properties.ReadOnly = True
        frmBillingStatement.Show(Me)
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Client ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmStatementOfAccount.mode.Text = "view"
        frmStatementOfAccount.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmStatementOfAccount.txtClient.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmStatementOfAccount.txtClient.Properties.ReadOnly = True
        frmStatementOfAccount.Show(Me)
    End Sub

    Private Sub PaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentTransactionToolStripMenuItem.Click
        If countqry("tblclientaccounts", "walkinaccount=1 and cifid='" & GridView1.GetFocusedRowCellValue("Client ID") & "'") > 0 Then
            XtraMessageBox.Show("Walkin account is not allowed to continue this function", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'If Val(qrysingledata("openbalance", "sum(debit)- sum(credit) as 'openbalance'", "where journalmode='client-accounts' and accountno='" & GridView1.GetFocusedRowCellValue("Client ID").ToString & "' and cancelled=0", "tblglaccountledger")) - Val(qrysingledata("payment", "sum(paymentamount) as 'payment'", "where accountno='" & GridView1.GetFocusedRowCellValue("Client ID").ToString & "' and verified=0 and cancelled=0", "tblpaymenttransactions")) <= 0 Then
        '    XtraMessageBox.Show("Cannot create client's payment when the balance due is zero or less than zero!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        frmClientPayment.LoadClientInfo()
        frmClientPayment.cifid.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientPayment.txtClientAccount.Text = GridView1.GetFocusedRowCellValue("Client Name").ToString
        frmClientPayment.txtClientAccount.Properties.ReadOnly = True
        frmClientPayment.Show(Me)
    End Sub

    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionHistoryToolStripMenuItem.Click
        frmClientTransactionHistory.accountno.Text = GridView1.GetFocusedRowCellValue("Client ID").ToString
        frmClientTransactionHistory.Text = "Transaction History of " & StrConv(GridView1.GetFocusedRowCellValue("Client Name").ToString, VbStrConv.ProperCase)
        frmClientTransactionHistory.Show(Me)
    End Sub

    Private Sub cmdColumnFilter_Click(sender As Object, e As EventArgs) Handles cmdColumnFilter.Click
        Dim colname As String = ""
        Dim I As Integer = 0
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub txtdateFrom_EditValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.EditValueChanged
        filter()
    End Sub
End Class