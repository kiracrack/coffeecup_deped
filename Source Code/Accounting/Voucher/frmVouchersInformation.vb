Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmVouchersInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmVouchersInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmAPOtherPayables_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tbldisbursementvoucher", "voucherno='" & txtVoucherNo.Text & "'") = 0 Then
            If countqry("tblpurchaseorder", "paymentrefnumber='" & txtVoucherNo.Text & "'") > 0 Or countqry("tbldisbursementexpense", "voucherno='" & txtVoucherNo.Text & "'") > 0 Then
                If XtraMessageBox.Show("System found an voucher transaction not validated save yet! Are you sure you want to cancel voucher?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "UPDATE tblpurchaseorder set  paymentrequested=0,paymentrequestedby='', paymentrefnumber='' where paymentrefnumber='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM tbldisbursementexpense where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadDetails()
    End Sub

    Public Sub LoadDetails()
        txtVoucherDate.EditValue = CDate(Now)
        txtCheckDate.EditValue = CDate(Now)
        LoadGridviewAppearance(gridVendorAccount)
        LoadGridviewAppearance(gv_Office)
        LoadCompany()
        txtVoucherNo.ReadOnly = True

        If mode.Text = "edit" Then
            menuFunctions(False)
            ShowVoucherInformation()
        ElseIf mode.Text = "view" Then
            txtVoucherNo.ReadOnly = True
            ShowVoucherInformation()
            menuFunctions(True)
        Else
            menuFunctions(False)
            GenerateVoucherReference()
            LoadVoucherExpenses()
        End If
    End Sub
    Public Sub GenerateVoucherReference()
        If GlobalEnableVouchernumbersequence = True Then
            txtVoucherNo.ReadOnly = True
            txtVoucherNo.Text = getVourcherNumberSequence()
            com.CommandText = "UPDATE tblgeneralsettings set vouchernosequence='" & txtVoucherNo.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        Else
            txtVoucherNo.ReadOnly = False
        End If
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("SELECT code as compid,companyname as 'Select Company' from tblcompany order by companyname asc", "tblcompany", txtCompany, GridView_company, Me)
        GridView_company.Columns("compid").Visible = False
    End Sub
    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("compid").ToString()
        If companyid.Text <> "" Then
            LoadOffice()
        End If
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where companyid='" & companyid.Text & "'  and deleted=0  order by officename asc", "tblcompoffice", txtOffice, gv_Office, Me)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub menuFunctions(ByVal hide As Boolean)
        If hide = True Then
            cmdAddExpense.Visible = False
            cmdSaveVoucher.Visible = False
            radVoucherType.ReadOnly = True
            txtVoucherDate.ReadOnly = True
            grpDisbursementType.ReadOnly = True
            txtFund.ReadOnly = True
            txtCheckNumber.ReadOnly = True
            txtCheckDate.ReadOnly = True
            txtNote.ReadOnly = True
            txtCompany.ReadOnly = True
            txtOffice.ReadOnly = True
            txtClaimant.ReadOnly = True
            Em.ContextMenuStrip = Nothing
        Else
            cmdAddExpense.Visible = True
            cmdSaveVoucher.Visible = True
            txtFund.ReadOnly = False
            txtCheckNumber.ReadOnly = False
            txtCheckDate.ReadOnly = False
            txtCompany.ReadOnly = False
            txtOffice.ReadOnly = False
            txtNote.ReadOnly = False
            txtVoucherDate.ReadOnly = False
            grpDisbursementType.ReadOnly = False
            radVoucherType.ReadOnly = False
            txtClaimant.ReadOnly = False
            Em.ContextMenuStrip = gridmenustrip
        End If
    End Sub

    Public Sub ShowVoucherInformation()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *,if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as vendor, " _
                        + " (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as office, " _
                        + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as fund from tbldisbursementvoucher where voucherno='" & txtVoucherNo.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If CBool(.Rows(cnt)("directexpense").ToString()) = True Then
                    grpDisbursementType.SelectedIndex = 1
                Else
                    grpDisbursementType.SelectedIndex = 0
                End If
                If CBool(.Rows(cnt)("check")) = True Then
                    radVoucherType.EditValue = "check"
                    txtCheckNumber.Text = .Rows(cnt)("checkno").ToString()
                    txtCheckDate.EditValue = .Rows(cnt)("checkdate").ToString()
                    txtCheckAmount.Text = FormatNumber(Val(.Rows(cnt)("checkamount")), 2)
                    XtraTabControl1.Visible = True
                    LoadSupplier()
                    LoadSourceFund(True)
                ElseIf CBool(.Rows(cnt)("cash")) = True Then
                    radVoucherType.EditValue = "cash"
                    LoadSupplier()
                    LoadSourceFund(False)
                ElseIf CBool(.Rows(cnt)("ca")) = True Then
                    radVoucherType.EditValue = "ca"
                    LoadRequestor()
                    LoadSourceFund(False)
                End If
                companyid.Text = .Rows(cnt)("companyid").ToString()
                txtCompany.Text = .Rows(cnt)("companyid").ToString()
                txtOffice.Text = .Rows(cnt)("office").ToString()
                officeid.Text = .Rows(cnt)("officeid").ToString()
                claimantid.Text = .Rows(cnt)("vendorid").ToString()
                txtClaimant.Text = .Rows(cnt)("vendorid").ToString()
                fundcode.Text = .Rows(cnt)("sourcefund").ToString()
                txtNote.Text = .Rows(cnt)("note").ToString()
                txtFund.Text = .Rows(cnt)("sourcefund").ToString()

                If grpDisbursementType.SelectedIndex = 0 Then
                    tabDetails.PageVisible = True
                ElseIf grpDisbursementType.SelectedIndex = 1 Then
                    tabDetails.PageVisible = False
                End If
            End With
        Next
        LoadVoucherExpenses()
    End Sub

    Public Sub LoadVoucherExpenses()
        'LoadXgrid("select ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', date_format(datetrn,'%Y-%m-%d') as 'Date', invoiceno as 'Invoice No.', TotalAmount as 'Amount',Note from tblpurchaseorder where paymentrefnumber='" & txtVoucherNo.Text & "'", "tblpurchaseorder", Em, GridView1, Me)
        If radVoucherType.EditValue = "ca" Then
            LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', Supplier, Amount, Note from tbldisbursementdetails where voucherno='" & txtVoucherNo.Text & "' order by datetrn asc", "tbldisbursementdetails", Em, GridView1, Me)

        Else
            LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', invoiceno as 'Invoice No.', Amount,Note from tbldisbursementdetails where voucherno='" & txtVoucherNo.Text & "' order by datetrn asc", "tbldisbursementdetails", Em, GridView1, Me)
        End If

        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"PO Number", "Payable Type", "Date", "Invoice No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        'XgridColWidth({"Description"}, GridView1, 200)
        XgridColWidth({"Amount"}, GridView1, 100)
        If GridView1.RowCount > 0 Then
            txtClaimant.Properties.ReadOnly = True
        Else
            txtClaimant.Properties.ReadOnly = False
        End If
        filterOtherExpense()
        txtCheckAmount.Text = FormatNumber(Val(CC(GridView1.Columns("Amount").SummaryText)) + Val(CC(Gridview_OtherExpense.Columns("Amount").SummaryText)), 2)

        filterApprovalLogs()
    End Sub

    Public Sub filterOtherExpense()
        LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', " _
                      + " (select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode and companyid=tbldisbursementexpense.companyid)  as 'Transaction Name', " _
                      + " Remarks, " _
                      + "  Amount " _
                      + " from tbldisbursementexpense  " _
                      + " WHERE voucherno = '" & txtVoucherNo.Text & "' order by datetrn asc", "tbldisbursementexpense", Em_OtherExpense, Gridview_OtherExpense, Me)

        XgridHideColumn({"id"}, Gridview_OtherExpense)
        XgridColCurrency({"Amount"}, Gridview_OtherExpense)
        XgridGeneralSummaryCurrency({"Amount"}, Gridview_OtherExpense)
        Gridview_OtherExpense.Columns("Amount").Width = 120
    End Sub

    Public Sub filterApprovalLogs()
        LoadXgrid("select CONFIRMBY as 'Confirmed by', " _
                      + " Position as 'Position', " _
                      + " Remarks, " _
                      + " CONCAT(UCASE(SUBSTRING(tblapprovalhistory.`status`, 1, 1)),LOWER(SUBSTRING(tblapprovalhistory.`status`, 2)))  as 'Status', " _
                      + " DATECONFIRM as 'Date Confirmed' " _
                      + " from tblapprovalhistory  " _
                      + " WHERE referenceno = '" & txtVoucherNo.Text & "' and appdescription='voucher' order by DATECONFIRM asc", "tblapprovalhistory", Em_ApprovalLog, GridView_ApprovalLog, Me)

        GridView_ApprovalLog.Columns("Remarks").ColumnEdit = MemoEdit
        GridView_ApprovalLog.Columns("Remarks").Width = 200
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles cmdSaveVoucher.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCompany.Focus()
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtClaimant.Text = "" Then
            XtraMessageBox.Show("Please select supplier!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClaimant.Focus()
            Exit Sub
        ElseIf txtFund.Text = "" Then
            XtraMessageBox.Show("Please select fund!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFund.Focus()
            Exit Sub
        ElseIf GlobalGLaccountspayableCode = "" Then
            XtraMessageBox.Show("Disbursement voucher default settings currently not configure! Please contact your system administrator", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf radVoucherType.SelectedIndex = -1 Then
            XtraMessageBox.Show("Please select voucher type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            radVoucherType.Focus()
            Exit Sub
        End If
        'If radVoucherType.EditValue = "check" Then
        '    If txtCheckNumber.Text = "" Then
        '        XtraMessageBox.Show("Please enter check number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        txtCheckNumber.Focus()
        '        Exit Sub
        '    ElseIf txtCheckDate.Text = "" Then
        '        XtraMessageBox.Show("Please enter check date!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        txtCheckDate.Focus()
        '        Exit Sub
        '    End If
        'End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmConfirmedVoucherProcessing.ShowDialog(Me)
        End If
    End Sub

    Public Sub SubmitVoucher(ByVal message As String)
        Dim TransactionType As String = "" : Dim CheckDetails As String = "" : Dim Caption As String = ""
        If radVoucherType.EditValue = "check" Then
            TransactionType = "`check`=1, "
            CheckDetails = ", checkno='" & txtCheckNumber.Text & "', checkdate='" & ConvertDate(txtCheckDate.EditValue) & "', checkamount='" & Val(CC(txtCheckAmount.Text)) & "' "
            Caption = "Check Payment Disbursement"
        ElseIf radVoucherType.EditValue = "cash" Then
            TransactionType = "cash=1, "
            Caption = "Cash Payment Disbursement"
        ElseIf radVoucherType.EditValue = "ca" Then
            TransactionType = "ca=1, "
            Caption = "Cash Advance Disbursement"
        End If

        If mode.Text = "edit" Then
            RecordApprovingHistory("voucher", txtVoucherNo.Text, txtVoucherNo.Text, "revised", rchar(message))
            com.CommandText = "UPDATE tbldisbursementvoucher set voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "',directexpense=" & grpDisbursementType.SelectedIndex & ", companyid='" & companyid.Text & "', officeid='" & officeid.Text & "',itemcode='" & GlobalGLaccountspayableCode & "', vendorid='" & claimantid.Text & "',  " & TransactionType & " amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) + Val(CC(Gridview_OtherExpense.Columns("Amount").SummaryText)) & "',sourcefund='" & fundcode.Text & "', note='" & rchar(txtNote.Text) & "', hold=0, corporatelevel=1, datetrn=current_timestamp, trnby='" & globaluserid & "' " & CheckDetails & " where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
            NextEmailAccountPayableApprover(txtVoucherNo.Text, officeid.Text, Caption, True, "")
            XtraMessageBox.Show("Voucher successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RecordApprovingHistory("voucher", txtVoucherNo.Text, txtVoucherNo.Text, "processed", rchar(message))
            com.CommandText = "insert into tbldisbursementvoucher set voucherno='" & txtVoucherNo.Text & "',voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "',directexpense=" & grpDisbursementType.SelectedIndex & ", companyid='" & companyid.Text & "', officeid='" & officeid.Text & "',itemcode='" & GlobalGLaccountspayableCode & "', vendorid='" & claimantid.Text & "',  " & TransactionType & " amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) + Val(CC(Gridview_OtherExpense.Columns("Amount").SummaryText)) & "',sourcefund='" & fundcode.Text & "', note='" & rchar(txtNote.Text) & "', corporatelevel=1, datetrn=current_timestamp, trnby='" & globaluserid & "' " & CheckDetails : com.ExecuteNonQuery()
            NextEmailAccountPayableApprover(txtVoucherNo.Text, officeid.Text, Caption, True, "")
            XtraMessageBox.Show("Voucher successfully posted and subject for clearing!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadVoucherExpenses()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblpurchaseorder set paymentrequested=0,paymentrequestedby='', paymentrefnumber='',ap=1 where ponumber='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "PO Number").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tbldisbursementdetails where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadVoucherExpenses()
        End If
    End Sub

    Private Sub cmdAddExpense_Click(sender As Object, e As EventArgs) Handles cmdAddExpense.Click
        If txtClaimant.Text = "" Then
            XtraMessageBox.Show("Please select claimant!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClaimant.Focus()
            Exit Sub
        End If
        If grpDisbursementType.SelectedIndex = 1 Then
            frmVoucherOtherExpense.voucherno.Text = txtVoucherNo.Text
            frmVoucherOtherExpense.companyid.Text = companyid.Text
            frmVoucherOtherExpense.ShowDialog(Me)
        Else
            If radVoucherType.EditValue = "ca" Then
                frmVoucherPOSelect.ckAp.Checked = False
            Else
                frmVoucherPOSelect.ckAp.Checked = True
            End If
            frmVoucherPOSelect.mode.Text = radVoucherType.EditValue
            frmVoucherPOSelect.lblSupplier.Text = txtClaimant.Text
            frmVoucherPOSelect.voucherno.Text = txtVoucherNo.Text
            frmVoucherPOSelect.officeid.Text = officeid.Text
            frmVoucherPOSelect.vendorid.Text = claimantid.Text
            frmVoucherPOSelect.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdPrintVoucher_Click(sender As Object, e As EventArgs) Handles cmdPrintVoucher.Click
        If countqry("tbldisbursementvoucher", "voucherno='" & txtVoucherNo.Text & "'") = 0 Then
            XtraMessageBox.Show("Please Save voucher before print!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        PrintDisbursementVoucher(txtVoucherNo.Text, Me, True)
    End Sub

    Private Sub AddPayableItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPayableItemToolStripMenuItem.Click
        cmdAddExpense.PerformClick()
    End Sub

    Private Sub radVoucherType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radVoucherType.SelectedIndexChanged
        If txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        End If
        If radVoucherType.EditValue = "check" Then
            XtraTabControl1.Visible = True
            LoadSourceFund(True)
            LoadSupplier()
        ElseIf radVoucherType.EditValue = "ca" Then
            LoadRequestor()
            LoadSourceFund(False)
        Else
            LoadSupplier()
            LoadSourceFund(False)
            XtraTabControl1.Visible = False
        End If
      
    End Sub

#Region "Load Claimant"
    Public Sub LoadSupplier()
        If grpDisbursementType.SelectedIndex = 1 Then
            LoadXgridLookupSearch("SELECT vendorid as claimantid, companyname as 'Claimant Name' from tblglobalvendor order by companyname asc", "tblglobalvendor", txtClaimant, gridVendorAccount, Me)
        Else
            LoadXgridLookupSearch("SELECT vendorid as claimantid, companyname as 'Claimant Name' from tblglobalvendor where vendorid in (select vendorid from tblpurchaseorder where (paymentrequested=0 or paymentrefnumber='" & txtVoucherNo.Text & "') and cancelled=0) order by companyname asc", "tblglobalvendor", txtClaimant, gridVendorAccount, Me)
        End If
        gridVendorAccount.Columns("claimantid").Visible = False
    End Sub

    Public Sub LoadRequestor()
        LoadXgridLookupSearch("SELECT accountid as claimantid, fullname as 'Claimant Name' from tblaccounts where  coffeecupuser=1 order by fullname asc", "tblaccounts", txtClaimant, gridVendorAccount, Me)
        gridVendorAccount.Columns("claimantid").Visible = False
    End Sub

    Private Sub txtClientAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClaimant.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtClaimant.Properties.View.FocusedRowHandle.ToString)
        claimantid.Text = txtClaimant.Properties.View.GetFocusedRowCellValue("claimantid").ToString()
    End Sub
#End Region

    Public Sub LoadSourceFund(ByVal check As Boolean)
        If check = True Then
            LoadXgridLookupEdit("SELECT bankcode,AccountName from tblbankaccounts where bankaccounts=1", "tblbankaccounts", txtFund, gridFund, Me)
            gridFund.Columns("bankcode").Visible = False
        Else
            LoadXgridLookupEdit("SELECT bankcode,AccountName from tblbankaccounts where cashaccount=1", "tblbankaccounts", txtFund, gridFund, Me)
            gridFund.Columns("bankcode").Visible = False
        End If
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtFund.Properties.View.FocusedRowHandle.ToString)
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("bankcode").ToString()
    End Sub

    Private Sub cmdCheckPrint_Click(sender As Object, e As EventArgs) Handles cmdCheckPrint.Click
        frmPrintCheck.txtCheckPayee.Text = "*** " & txtClaimant.Text & " ***"
        frmPrintCheck.txtAmount.Text = "*** " & txtCheckAmount.Text & " ***"
        frmPrintCheck.txtCheckDate.Text = "*** " & CDate(txtCheckDate.EditValue).ToString("MMMM dd, yyyy") & " ***"
        frmPrintCheck.txtNumberInWords.Text = "*** " & ConvertCurrencyToEnglish(Val(CC(txtCheckAmount.Text))) & " ***"
        frmPrintCheck.ShowDialog(Me)
    End Sub

    Private Sub ViewPurchaseOrderProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchaseOrderProfileToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Description").ToString = "Purchase Order" Then
            frmPurchaseOrderProfile.mode.Text = "po"
        End If
        frmPurchaseOrderProfile.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmPurchaseOrderProfile.Visible = True Then
            frmPurchaseOrderProfile.Focus()
        Else
            frmPurchaseOrderProfile.Show(Me)
        End If
    End Sub

    Private Sub txtVoucherNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtVoucherNo.EditValueChanged
        LoadDetails()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmVoucherOtherExpense.mode.Text = "edit"
        frmVoucherOtherExpense.companyid.Text = companyid.Text
        frmVoucherOtherExpense.trnid.Text = Gridview_OtherExpense.GetFocusedRowCellValue("id").ToString
        frmVoucherOtherExpense.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If txtClaimant.Text = "" Then
            XtraMessageBox.Show("Please select claimant!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClaimant.Focus()
            Exit Sub
        End If
        frmVoucherOtherExpense.voucherno.Text = txtVoucherNo.Text
        frmVoucherOtherExpense.companyid.Text = companyid.Text
        frmVoucherOtherExpense.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview_OtherExpense.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tbldisbursementexpense where id='" & Gridview_OtherExpense.GetRowCellValue(Gridview_OtherExpense.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            filterOtherExpense()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        filterOtherExpense()
    End Sub

    Private Sub grpDisbursementType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grpDisbursementType.SelectedIndexChanged
        If grpDisbursementType.SelectedIndex = 0 Then
            tabDetails.PageVisible = True
        ElseIf grpDisbursementType.SelectedIndex = 1 Then
            tabDetails.PageVisible = False
        End If
    End Sub
End Class