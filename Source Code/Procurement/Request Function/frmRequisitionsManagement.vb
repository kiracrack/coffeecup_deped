Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.GridColumnSummaryItem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraSplashScreen

Public Class frmRequisitionsManagement
    Private rptsettings As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        ElseIf keyData = (Keys.F5) Then
            menu_Refresh.PerformClick()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionsManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gv_inventory)

        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)

        loadInventoryTo()

        lblOffice.Text = "Select " & GlobalOfficeCaption
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            menu_cancel.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            menu_cancel.Visible = False
            ToolStripSeparator2.Visible = False
        End If

        If LCase(GlobalReportTemplate) = "deped" Then
            cmdUpdateRequisitionStatus.Visible = True
            cmdEditRequest.Visible = True
        Else
            cmdUpdateRequisitionStatus.Visible = False
            cmdEditRequest.Visible = False
        End If

    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Inventory' from tblcompoffice order by officename asc", "tblcompoffice", txtOffice, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterOption()
    End Sub
    Public Sub FilterOption()
        If XtraTabControl1.SelectedTabPage Is tabOffice Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterRequestList("BRANCH")
            menu_action.Visible = False
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterRequestList("CORPORATE")
            menu_action.Visible = True
        End If
    End Sub

    Public Sub FilterRequestList(ByVal lvl As String)
        If lvl = "BRANCH" Then
            LoadXgrid("Select officeid,pid as 'Request No', " _
                + " case when cancelled=1 and disapproved=0 then 'Cancelled' " _
                                          + " when cancelled=0 and disapproved=1 then 'Disapproved' " _
                                          + " when hold=1 then 'On Hold' " _
                                          + " when approvedbranch=0 then 'Pending Branch for Approval' " _
                                          + " else 'Approved' end as 'Status', " _
                + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as '" & GlobalOfficeCaption & "', " _
                + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'Request By' , " _
                + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'Request Type', " _
                + " Priority, " _
                + " ifnull((select sum(quantity) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Item', " _
                + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
                + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                + " '" & UCase(GlobalOfficeCaption) & "' as 'Request Level', " _
                + " Revised as 'Duplicated'," _
                + GlobalStrAttachment _
                + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'Transaction By' " _
                + " from tblrequisitions " _
                + " WHERE corporatelevel=0 " _
                + If(ckPendingRequest.Checked = False, If(ckasof.Checked = True, " and date_format(daterequest,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' ", " and date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "), "") _
                + If(ckPendingRequest.Checked = True, " and approvedbranch=0 and cancelled=0 and disapproved=0 ", " ") _
                + If(ck_AllOffice.Checked = True, "", " and officeid ='" & officeid.Text & "'") _
                + " order by daterequest desc", "tblrequisitions", Em, GridView1, Me)
        Else

            LoadXgrid("Select officeid,pid as 'Request No', " _
              + "case when cancelled=1 and disapproved=0 then 'Cancelled' " _
                                         + " when cancelled=0 and disapproved=1 then 'Disapproved' " _
                                         + " when hold=1 then 'On Hold' " _
                                         + " when approvedbranch=0 then 'Pending Branch for Approval' " _
                                         + " when approvedbranch=1 and approvedcorporate=0 then " & If(LCase(GlobalReportTemplate) = "deped", " (SELECT remarks FROM `tblapprovalhistory` where referenceno=tblrequisitions.pid order by id desc limit 1) ", " 'Pending Corporate Approval' ") & " " _
                                         + " else 'Approved' end as 'Status', " _
               + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as '" & GlobalOfficeCaption & "', " _
               + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'Request By' , " _
               + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'Request Type', " _
               + " Priority, " _
               + " ifnull((select sum(quantity) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Item', " _
               + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
               + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
               + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
               + " 'CORPORATE' as 'Request Level', " _
               + " Revised as 'Duplicated'," _
               + GlobalStrAttachment _
               + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'Transaction By'  " _
               + " from tblrequisitions  " _
               + " WHERE corporatelevel=1 and approvedbranch=1 and received=1  " _
               + If(ckPendingRequest.Checked = False, If(ckasof.Checked = True, " and date_format(daterequest,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' ", " and date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "), "") _
               + If(ckPendingRequest.Checked = True, " and approvedcorporate=0 and cancelled=0 and disapproved=0 ", " ") _
               + If(ck_AllOffice.Checked = True, "", " and officeid ='" & officeid.Text & "'") _
               + " order by daterequest desc", "tblrequisitions", Em, GridView1, Me)
        End If


        If XtraTabControl1.SelectedTabPage Is tabOffice Then
            XgridHideColumn({"Duplicated"}, GridView1)
        End If
        XgridColAlign({"Date Request", "Time Request", "Total Item", "Attachment", "Request Level", "Status", "Priority"}, GridView1, HorzAlignment.Center)
        XgridColCurrency({"Total Amount"}, GridView1)
        SaveFilterColumn(GridView1, Me.Text)
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            If e.Column.Name = "colPriority" Then
                Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Priority"))
                If priority = "High" Then
                    e.Appearance.ForeColor = Color.Orange

                ElseIf priority = "Emergency" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.ForeColor = Color.White
                    'e.Appearance.ForeColor = Color.White
                    ' e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                ElseIf priority = "Normal" Then
                    e.Appearance.ForeColor = Color.Green
                    ' e.Appearance.ForeColor = Color.Black
                ElseIf priority = "Low" Then
                    e.Appearance.ForeColor = Color.Blue
                    ' e.Appearance.ForeColor = Color.White
                    '  e.Appearance.Font = New Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                End If
            End If
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "On Hold" Then
                If e.Column.Name = "colStatus" Then
                    e.Appearance.BackColor = Color.Orange
                End If

            End If
        End If

    End Sub

#Region "GET COLUNM ID"

    Public Sub CheckRequest()
        On Error Resume Next
        If CBool(GridView1.GetFocusedRowCellValue("Duplicated").ToString) = True Then
            menu_edit.Text = "Revise Duplicate Request"
        Else
            menu_edit.Text = "Duplicate and Revise Request"
        End If
    End Sub

    Private Sub Bm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        CheckRequest()
    End Sub
    Private Sub Bm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        CheckRequest()
    End Sub
#End Region

    Private Sub EditPOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_edit.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() <> "On Hold" Then
            XtraMessageBox.Show("Only on-hold request can be revise!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If CheckSelectedRow("Request No", GridView1) = True Then
            If XtraMessageBox.Show("Are you sure you want to " & menu_edit.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
                frmProceedNewRequest.Close()
                frmProceedNewRequest.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString
                com.CommandText = "update tblrequisitions set revised=1 where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()
                frmProceedNewRequest.Text = "Request for " + GridView1.GetFocusedRowCellValue("Request By").ToString
                frmProceedNewRequest.mode.Text = "edit"
                frmProceedNewRequest.MdiParent = MdiCoffeeCup
                frmProceedNewRequest.Show()
                frmProceedNewRequest.Focus()
                SplashScreenManager.CloseForm()
            End If
        End If
    End Sub


    Private Sub cmdCancelrequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_cancel.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "Approved" Then
            XtraMessageBox.Show("Cancelling approved request is not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Status").ToString() = "Disapproved" Then
            XtraMessageBox.Show("Cancelling disapproved request is not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("Status").ToString() = "Cancelled" Then
            XtraMessageBox.Show("Request already cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmCancelRequestOption.mode.Text = "requisition"
        frmCancelRequestOption.ShowDialog(Me)
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        Me.Close()
    End Sub

    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub ck_inventory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_AllOffice.CheckedChanged
        If ck_AllOffice.Checked = True Then
            txtOffice.Enabled = False
            txtOffice.Properties.DataSource = False
            txtOffice.Text = ""
        Else
            loadInventoryTo()
            txtOffice.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        FilterOption()
    End Sub


    Private Sub ViewAttachmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAttachment.Click
        frmDBFileViewer.trncode.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
        frmDBFileViewer.Show(Me)
    End Sub

    Private Sub SetAttachmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAttachmentToolStripMenuItem1.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            frmDBFileUploader.trncode.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
            frmDBFileUploader.Show(Me)
        End If
    End Sub

    Private Sub menu_Refresh_Click(sender As Object, e As EventArgs) Handles menu_Refresh.Click
        FilterOption()
    End Sub

    Public Function CancelSelectedRequest(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblrequisitions set cancelled=1,datecancelled=current_timestamp where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                      + " SELECT potypeid,'requisition',pid,pid,'cancelled','" & rchar(reason) & "','Procurement','-','" & globaluserid & "','" & globalfullname & "','" & globaldesignation & "',current_timestamp,1 FROM tblrequisitions where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
        Next
        FilterOption()
        XtraMessageBox.Show("Request successfully cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return 0
    End Function

    Private Sub ExtractAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractAttachmentToolStripMenuItem.Click
        If CheckSelectedRow("Request No", GridView1) = True Then
            ViewAttachmentPackage_Database({GridView1.GetFocusedRowCellValue("Request No").ToString()}, "")
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(Me.Text, XtraTabControl1.SelectedTabPage.Text, GridView1, Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        frmRequestProfile.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
        frmRequestProfile.Show(Me)
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        ViewProfileToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ckPendingRequest_CheckedChanged(sender As Object, e As EventArgs) Handles ckPendingRequest.CheckedChanged
        If ckPendingRequest.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
            ckasof.Enabled = False
            cmdCancelLastApprovingAction.Visible = False
            ckasof.Checked = False
        Else
            If globalAllowDelete = True Or LCase(globaluser) = "root" Then
                cmdCancelLastApprovingAction.Visible = True
            Else
                cmdCancelLastApprovingAction.Visible = False
            End If
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
            ckasof.Enabled = True
        End If
            FilterOption()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub
   
    Public Function CancelRequestApprovingHistory(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            If XtraTabControl1.SelectedTabPage Is tabOffice Then
                com.CommandText = "update tblrequisitions set approvedbranch=0 where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblapprovalhistory set applevel='-',finalapprover=0 where referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "' and finalapprover=1 and corporateapproval=0" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                     + " SELECT potypeid,'requisition',pid, pid,'Corrected','Cancel last approving action: " & rchar(reason) & "','Procurement','-','" & globaluserid & "','" & globalfullname & "','" & globaldesignation & "',current_timestamp,0 FROM tblrequisitions where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblrequisitions set approvedcorporate=0 where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblapprovalhistory set applevel='-',finalapprover=0 where referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "' and finalapprover=1 and corporateapproval=1" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                     + " SELECT potypeid,'requisition',pid, pid,'Corrected','Cancel last approving action: " & rchar(reason) & "','Procurement','-','" & globaluserid & "','" & globalfullname & "','" & globaldesignation & "',current_timestamp,0 FROM tblrequisitions where pid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Request No").ToString & "'" : com.ExecuteNonQuery()
            End If
        Next
        FilterOption()
        XtraMessageBox.Show("Request successfully cancelled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return 0
    End Function

    Private Sub CancelLastApprovingActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancelLastApprovingAction.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "Approved" Then
            frmCancelRequestOption.mode.Text = "requestapprovalhistory"
            frmCancelRequestOption.ShowDialog(Me)
        Else
            XtraMessageBox.Show("Only mistakenly approved can only be cancel the last approving action! " & Environment.NewLine & "or else next approver can put on hold the request if incase for revision", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdUpdateRequisitionStatus_Click(sender As Object, e As EventArgs) Handles cmdUpdateRequisitionStatus.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "Approved" Then
            XtraMessageBox.Show("Request already approved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmDepEdUpdateRequestStatus.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString()
        frmDepEdUpdateRequestStatus.Show(Me)
    End Sub

    Private Sub cmdEditRequest_Click(sender As Object, e As EventArgs) Handles cmdEditRequest.Click
        If GridView1.GetFocusedRowCellValue("Status").ToString() = "Approved" Then
            XtraMessageBox.Show("Request already approved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmProceedNewRequest.Close()
            frmProceedNewRequest.pid.Text = GridView1.GetFocusedRowCellValue("Request No").ToString
            com.CommandText = "update tblrequisitions set revised=1 where pid='" & GridView1.GetFocusedRowCellValue("Request No").ToString & "'" : com.ExecuteNonQuery()
            frmProceedNewRequest.Text = "Request for " + GridView1.GetFocusedRowCellValue("Request By").ToString
            frmProceedNewRequest.mode.Text = "edit"
            frmProceedNewRequest.MdiParent = MdiCoffeeCup
            frmProceedNewRequest.Show()
            frmProceedNewRequest.Focus()
            SplashScreenManager.CloseForm()
        End If
    End Sub
End Class