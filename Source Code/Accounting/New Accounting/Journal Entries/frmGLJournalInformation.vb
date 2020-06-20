Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmGLJournalInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmGLJournalInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblgljournalentries", "ticketno='" & txtTicketNo.Text & "'") = 0 Then
            If countqry("tblgljournalitems", "ticketno='" & txtTicketNo.Text & "'") > 0 Then
                If XtraMessageBox.Show("System found an ticket transaction not validated yet! Are you sure you want to cancel ticket item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "DELETE from tblgljournalitems where ticketno='" & txtTicketNo.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtTrndate.EditValue = CDate(Now)
        LoadCompany()
        If companyid.Text <> "" Then
            LoadOffice()
        End If
        txtTicketNo.ReadOnly = True
        If mode.Text = "edit" Then
            menuFunctions(False)
            ShowTicketInformation()
        ElseIf mode.Text = "view" Then
            txtTicketNo.ReadOnly = True
            ShowTicketInformation()
            menuFunctions(True)
        Else
            menuFunctions(False)
            GenerateTicketReference()
            LoadTickets()
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
            txtTrndate.ReadOnly = True
            txtDetails.ReadOnly = True
            txtCompany.ReadOnly = True
            txtOffice.ReadOnly = True
            Em.ContextMenuStrip = Nothing
        Else
            cmdAddExpense.Visible = True
            cmdSaveVoucher.Visible = True
            txtCompany.ReadOnly = False
            txtOffice.ReadOnly = False
            txtDetails.ReadOnly = False
            txtTrndate.ReadOnly = False
            Em.ContextMenuStrip = gridmenustrip
        End If
    End Sub

    Public Sub ShowTicketInformation()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *  from tblgljournalentries where ticketno='" & txtTicketNo.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                companyid.Text = .Rows(cnt)("companyid").ToString
                txtCompany.Text = .Rows(cnt)("companyid").ToString
                txtOffice.Text = .Rows(cnt)("officeid").ToString
                officeid.Text = .Rows(cnt)("officeid").ToString
                txtDetails.Text = .Rows(cnt)("details").ToString
            End With
        Next
        LoadTickets()
    End Sub

    Public Sub GenerateTicketReference()
        txtTicketNo.ReadOnly = True
        txtTicketNo.Text = getTicketNumberSequence()
        com.CommandText = "UPDATE tblglsettings set ticketsequence='" & txtTicketNo.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
    End Sub

    Public Sub LoadTickets()
        LoadXgrid("select id, itemname as 'Item Name', Debitamount as Debit, Creditamount as Credit, Remarks  from tblgljournalitems where ticketno='" & txtTicketNo.Text & "'", "tblgljournalitems", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Debit", "Credit"}, GridView1, 100)
    End Sub


    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles cmdSaveVoucher.Click
        If txtOffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtDetails.Text = "" Then
            XtraMessageBox.Show("Please enter ticket details!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        ElseIf Val(CC(GridView1.Columns("Debit").SummaryItem.SummaryValue)) <> Val(CC(GridView1.Columns("Credit").SummaryItem.SummaryValue)) Then
            XtraMessageBox.Show("Total debit and total credit not match!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblgljournalentries set companyid='" & companyid.Text & "', officeid='" & officeid.Text & "', details='" & rchar(txtDetails.Text) & "', datetrn=concat('" & ConvertDate(txtTrndate.Text) & "',' ',current_time), trnby='" & globaluserid & "', trnname='" & globalfullname & "' where ticketno='" & txtTicketNo.Text & "'" : com.ExecuteNonQuery()
                'RecordApprovingHistory("ticket request", txtTicketNo.Text, txtTicketNo.Text, "processed", rchar(txtDetails.Text))
                XtraMessageBox.Show("Ticket successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'RecordApprovingHistory("ticket request", txtTicketNo.Text, txtTicketNo.Text, "revised", rchar(txtDetails.Text))
                com.CommandText = "insert into tblgljournalentries set ticketno='" & txtTicketNo.Text & "', companyid='" & companyid.Text & "', officeid='" & officeid.Text & "',  details='" & rchar(txtDetails.Text) & "', datetrn=concat('" & ConvertDate(txtTrndate.Text) & "',' ',current_time),trnby='" & globaluserid & "',trnname='" & globalfullname & "'" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Ticket successfully posted and subject for clearing!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTickets()
    End Sub

    Private Sub EditExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditExpenseToolStripMenuItem.Click
        frmGLJournalDetails.mode.Text = "edit"
        frmGLJournalDetails.companyid.Text = companyid.Text
        frmGLJournalDetails.id.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE from tblgljournalitems where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadTickets()
            XtraMessageBox.Show("Selected item successfully removed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdAddExpense_Click(sender As Object, e As EventArgs) Handles cmdAddExpense.Click
        If txtDetails.Text = "" Then
            XtraMessageBox.Show("Please enter Ticket Details!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmGLJournalDetails.txtTicketNo.Text = txtTicketNo.Text
        frmGLJournalDetails.companyid.Text = companyid.Text
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub cmdPrintVoucher_Click(sender As Object, e As EventArgs) Handles cmdPrintVoucher.Click
        If GlobalDigitalPaymentApproving = True Then
            Dim report As New rptAccountsPayable()
            report.txtPayableTitle.Text = "ACCOUNTING TICKET"
            report.XrBarCode1.Text = txtTicketNo.Text
            report.txtOfficename.Text = txtOffice.Text
            report.txtVendorSuplier.Text = txtDetails.Text
            report.voucherno.Text = txtTicketNo.Text
            report.txtAmount.Text = "TOTAL AMOUNT: " & GridView1.Columns("Debit").SummaryText
            report.txtCheckDate.Text = "Date: " & Format(CDate(txtTrndate.EditValue), "MMMM dd, yyyy")
            report.txtAmountInWords.Text = UCase(ConvertCurrencyToEnglish(GridView1.Columns("Debit").SummaryItem.SummaryValue))
            report.PaperKind = System.Drawing.Printing.PaperKind.Letter
            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))
            report.ShowRibbonPreviewDialog()
        Else
            Dim report As New rptVoucher()
            report.txtVoucherNo.Text = txtTicketNo.Text
            report.txtVoucherDate.Text = txtTrndate.Text
            report.txtVoucherType.Text = "ACCOUNTING TICKET"
            report.txtTotalAmount.Text = FormatNumber(GridView1.Columns("Debit").SummaryItem.SummaryValue, 2)
            report.txtDetails.Text = txtDetails.Text
            report.txtAmountInWords.Text = UCase(ConvertCurrencyToEnglish(GridView1.Columns("Debit").SummaryItem.SummaryValue))
            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em))
            report.ShowRibbonPreviewDialog()
        End If

    End Sub

 
  
End Class