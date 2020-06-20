Imports MySql.Data.MySqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraSplashScreen

Public Class frmGLJournalEntriesSummary
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmGLJournalEntriesSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        LoadCompany()
        FilterJournalTickets()
        If globalApproverPermission = True Or LCase(globaluser) = "root" Then
            cmdUnverified.Visible = True
        Else
            cmdUnverified.Visible = False
        End If
    End Sub
    Public Sub LoadCompany()
        LoadXgridLookupSearch("SELECT code as compid,companyname as 'Select Company' from tblcompany order by companyname asc", "tblcompany", txtCompany, GridView_company, Me)
        GridView_company.Columns("compid").Visible = False
    End Sub
    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("compid").ToString()
        
    End Sub

    Public Sub FilterJournalTickets()
        If companyid.Text = "" Then Exit Sub
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = "and date_format(datetrn,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = "and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear() : dst.Clear()
        LoadXgrid("Select ticketno as 'Ticket No.',  (select officename from tblcompoffice where officeid=tblgljournalentries.officeid) as 'Office', Details, " _
                                        + " (select sum(debitamount) from tblgljournalitems where ticketno=tblgljournalentries.ticketno) as Amount, date_format(datetrn, '%Y-%m-%d') as 'Date Created', " _
                                        + " (select fullname from tblaccounts where accountid=tblgljournalentries.trnby) as 'Created By', " _
                                        + " Cleared, date_format(datecleared, '%Y-%m-%d %r') as 'Date Cleared', clearedby as 'Cleared By', " _
                                        + " Cancelled,date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled',cancelledby as 'Cancelled By'  " _
                                        + " from tblgljournalentries where companyid='" & companyid.Text & "'  " & If(ckPendingRequest.Checked = True, " where (cleared=0 and cancelled=0) ", filterasof) & " order by datetrn desc", "tblgljournalentries", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblgljournalentries")


        XgridColCurrency({"Amount"}, GridView1)
        XgridColAlign({"Account"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
        XgridColAlign({"Ticket No.", "Date Created", "Date Cleared", "Date Created", "Date Cancelled"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterJournalTickets()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        FilterJournalTickets()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdViewItem.PerformClick()
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintGeneralReport(Me.Text, Me.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ReadFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            ckasof.Checked = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
        FilterJournalTickets()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmGLJournalInformation.txtCompany.Text = companyid.Text
        frmGLJournalInformation.companyid.Text = companyid.Text
        frmGLJournalInformation.Show(Me)
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVoucherToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Ticket No.").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Verified") = True Then
            XtraMessageBox.Show("Editing verified Ticket not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Cancelled") = True Then
            XtraMessageBox.Show("Editing cancelled Ticket not allowed", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmGLJournalInformation.mode.Text = "edit"
        frmGLJournalInformation.txtTicketNo.Text = GridView1.GetFocusedRowCellValue("Ticket No.").ToString()
        frmGLJournalInformation.Show(Me)
    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        frmGLJournalInformation.mode.Text = "view"
        frmGLJournalInformation.txtTicketNo.Text = GridView1.GetFocusedRowCellValue("Ticket No.").ToString()
        frmGLJournalInformation.Show(Me)
    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelVoucherToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to cancel this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblgljournalentries set cancelled=1,datecancelled=current_timestamp,cancelledby='" & globalfullname & "' where ticketno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tblglticket where referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "' and journal=1" : com.ExecuteNonQuery()
            Next
            FilterJournalTickets()
            XtraMessageBox.Show("Ticket successfully cancelled", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub UnverifiedVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdUnverified.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblgljournalentries set cleared=0,datecleared=null,clearedby='' where ticketno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tblglticket where referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "' and journal=1" : com.ExecuteNonQuery()
            Next
            FilterJournalTickets()
            XtraMessageBox.Show("Transaction successfully uncleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTicketToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "insert into tblglticket (companyid,officeid,itemcode,itemname,referenceno,remarks,debitamount,creditamount,debit,datetrn,trnby,trnname,journal) " _
                    + " select companyid,officeid,itemcode,itemname,a.ticketno,remarks,debitamount,creditamount,debit,datetrn,trnby,trnname,1 FROM `tblgljournalentries` as a inner join tblgljournalitems as b on a.ticketno=b.ticketno where a.ticketno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblgljournalentries set cleared=1, datecleared=current_timestamp,clearedby='" & globalfullname & "'  where ticketno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Ticket No.").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterJournalTickets()
            XtraMessageBox.Show("Transaction successfully cleared", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class