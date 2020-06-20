Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmApprovingProcess
    Private gridsel As String = ""
    Private cpass As Boolean = False
    Private gridid As String
    Private trckdate As Date

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl2.Collapsed = True Then
                SplitContainerControl2.Collapsed = False
            Else
                SplitContainerControl2.Collapsed = True
            End If
             
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBiilSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(emGrid)

        LoadGridviewAppearance(gv_clientProcess)
        LoadGridviewAppearance(gv_clientUserPosition)

        LoadGridviewAppearance(s_Clienttype)
        LoadGridviewAppearance(s_Maintype)

        loadcompsettings()
        LoadApproverList()
        loadApprover()

        LoadClientProcessList()
        loadUserPosition()

        'loadMainPurchaseType()
        'loadClientPurchaseType()

        SetIcon(Me)
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = appStrip
            Em_client.ContextMenuStrip = ContextMenuStrip1
        Else
            Em.ContextMenuStrip = Nothing
            Em_client.ContextMenuStrip = Nothing
        End If
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
            cmdClientSave.Enabled = True
        Else
            cmdUpdate.Enabled = False
            cmdClientSave.Enabled = False
        End If
    End Sub
     
#Region "Corporate Process"
    Private Sub txtProcessType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProcessType.SelectedValueChanged
        txtMainPurchaseType.Enabled = True
        If txtProcessType.Text = "Requisition Approving Process" Then
            LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype", "tblrequesttype", txtMainPurchaseType, s_Maintype, Me)
            s_Maintype.Columns("POTYPEID").Visible = False
            ckCustomizedCorporate.Enabled = True
            txtMainPurchaseType.Enabled = True
        ElseIf txtProcessType.Text = "Voucher Signatories" Then
            ckCustomizedCorporate.Enabled = False
            txtMainPurchaseType.Enabled = False
        Else
            txtMainPurchaseType.Properties.DataSource = Nothing
            txtMainPurchaseType.Text = ""
            potypemainid.Text = ""
            txtMainPurchaseType.Enabled = False
            ckCustomizedCorporate.Enabled = True
        End If
        LoadApproverList()
    End Sub

    'Public Sub loadMainPurchaseType()
    '    LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype", "tblrequesttype", txtMainPurchaseType, s_Maintype, Me)
    '    s_Maintype.Columns("POTYPEID").Visible = False
    'End Sub

    Private Sub txtMainPurchaseType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMainPurchaseType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMainPurchaseType.Properties.View.FocusedRowHandle.ToString)
        potypemainid.Text = txtMainPurchaseType.Properties.View.GetFocusedRowCellValue("POTYPEID").ToString()
        txtMainPurchaseType.Text = txtMainPurchaseType.Properties.View.GetFocusedRowCellValue("Request Type").ToString()
        LoadApproverList()
    End Sub

    Private Sub ckCustomizedCorporate_CheckedChanged(sender As Object, e As EventArgs) Handles ckCustomizedCorporate.CheckedChanged
        If ckCustomizedCorporate.Checked = True Then
            txtCustomizedCorporate.Enabled = True
            LoadXgridLookupEdit("select officeid, officename as 'Office Name' from tblcompoffice where customcorporateapproval = 1", "tblcompoffice", txtCustomizedCorporate, gridCustomCorporate, Me)
            gridCustomCorporate.Columns("officeid").Visible = False
        Else
            customcorporatecode.Text = ""
            txtCustomizedCorporate.Enabled = False
        End If
        LoadApproverList()
    End Sub

    Private Sub txtCustomizedCorporate_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCustomizedCorporate.EditValueChanging
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCustomizedCorporate.Properties.View.FocusedRowHandle.ToString)
        customcorporatecode.Text = txtCustomizedCorporate.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        LoadApproverList()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadApproverList()
    End Sub

    Public Sub LoadApproverList()
        LoadXgrid("select id, AUTHORIZEDID, APPLEVEL as 'Level', apptitle as 'Approver Title', (Select FULLNAME from tblaccounts where accountid = tblapprovermainprocess.AUTHORIZEDID) as 'Fullname', " _
                            + " (select designation from tblaccounts where accountid = tblapprovermainprocess.AUTHORIZEDID) as 'Designation', finalapp as 'Final Approver' from tblapprovermainprocess where apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "' " & If(txtProcessType.Text = "Requisition Approving Process", " and requestcode='" & potypemainid.Text & "' ", "") & If(ckCustomizedCorporate.Checked = True, "and officeid='" & customcorporatecode.Text & "'", "") & "  and customized=" & ckCustomizedCorporate.CheckState & "  order by APPLEVEL asc", "tblapprovermainprocess", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("AUTHORIZEDID").Visible = False
        XgridColAlign({"Level"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub
    Public Sub loadApprover()
        LoadXgridLookupEdit("select distinct(accountid),fullname as Fullname, designation from tblaccounts inner join tblpermissions on tblaccounts.permission = tblpermissions.percode " _
                                + " where approver = 1 ", "tblaccounts", txtapprover, emGrid, Me)
        emGrid.Columns("accountid").Visible = False
        emGrid.Columns("designation").Visible = False
    End Sub

    Private Sub txtapprover_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapprover.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtapprover.Properties.View.FocusedRowHandle.ToString)
        aid.Text = txtapprover.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtapprover.Text = txtapprover.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
        txtappdesgnation.Text = txtapprover.Properties.View.GetFocusedRowCellValue("designation").ToString()
    End Sub
    Private Sub cmdConfirmsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        If txtapplevel.Text = "" Then
            XtraMessageBox.Show("Please select account level!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtapplevel.Focus()
            Exit Sub
        ElseIf txtapprover.Text = "" Then
            XtraMessageBox.Show("Please select approver!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtapprover.Focus()
            Exit Sub
        ElseIf txtTitle.Text = "" Then
            XtraMessageBox.Show("Please select Approver title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTitle.Focus()
            Exit Sub
        ElseIf ckCustomizedCorporate.Checked = True And txtCustomizedCorporate.Text = "" Then
            XtraMessageBox.Show("Please select custom corporate approving!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCustomizedCorporate.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblapprovermainprocess set apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "', requestcode='" & potypemainid.Text & "', APPLEVEL='" & txtapplevel.Text & "', authorizedid='" & aid.Text & "', apptitle='" & rchar(txtTitle.Text) & "', FINALAPP='" & chfinal.CheckState & "',customized=" & ckCustomizedCorporate.CheckState & ",officeid='" & customcorporatecode.Text & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblapprovermainprocess set apptype='" & LCase(txtProcessType.Text.Replace(" ", "-")) & "', requestcode='" & potypemainid.Text & "', APPLEVEL='" & txtapplevel.Text & "', authorizedid='" & aid.Text & "', apptitle='" & rchar(txtTitle.Text) & "', FINALAPP='" & chfinal.CheckState & "',customized=" & ckCustomizedCorporate.CheckState & ",officeid='" & customcorporatecode.Text & "'" : com.ExecuteNonQuery()
        End If
        LoadApproverList() : cmdCancel.PerformClick()
        XtraMessageBox.Show("Account for approver successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInactive.Click
        Dim Rows() As DataRow : Dim I As Integer : Dim todelete As String = ""
        If XtraMessageBox.Show("Are you sure you want to remove selected approver? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ReDim Rows(GridView1.SelectedRowsCount - 1)
            For I = 0 To GridView1.SelectedRowsCount - 1
                Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                todelete = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString
                com.CommandText = "delete from tblapprovermainprocess where id='" & todelete & "'" : com.ExecuteNonQuery()
            Next
            LoadApproverList()
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        txtapplevel.SelectedIndex = -1
        txtapprover.Properties.DataSource = Nothing
        txtapprover.Text = ""
        loadApprover()

        'txtMainPurchaseType.Properties.DataSource = Nothing
        'txtMainPurchaseType.Text = ""
        'loadMainPurchaseType()
        'potypemainid.Text = ""

        txtappdesgnation.Text = ""
        txtTitle.Text = ""
        mode.Text = ""
        aid.Text = ""
        chfinal.Checked = False
        LoadApproverList()
    End Sub



    Private Sub EditApproverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditApproverToolStripMenuItem.Click
        com.CommandText = "select *, (select description from tblrequesttype where potypeid=tblapprovermainprocess.requestcode) as 'potype', (select fullname from tblaccounts where accountid = tblapprovermainprocess.authorizedid) as 'approver',(select designation from tblaccounts where accountid = tblapprovermainprocess.authorizedid) as 'designation' from tblapprovermainprocess where id='" & GridView1.GetFocusedRowCellValue("id").ToString() & "'" : rst = com.ExecuteReader
        While rst.Read
            id.Text = rst("id").ToString
            txtProcessType.SelectedText = LCase(rst("apptype").ToString.Replace(" ", "-"))
            txtMainPurchaseType.Text = rst("potype").ToString
            potypemainid.Text = rst("requestcode").ToString
            txtapplevel.Text = rst("applevel").ToString
            txtapprover.Text = rst("approver").ToString
            txtappdesgnation.Text = rst("designation").ToString
            txtTitle.Text = rst("apptitle").ToString
            aid.Text = rst("authorizedid").ToString
            chfinal.Checked = rst("FINALAPP")
        End While
        rst.Close()
        mode.Text = "" : mode.Text = "edit"
        SplitContainerControl2.Collapsed = False
    End Sub

#End Region

#Region "Client Process"

    Private Sub txtClient_processType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClient_processType.SelectedValueChanged
        txtClientPurchaseType.Enabled = True
        If txtClient_processType.Text = "Requisition Approving Process" Then
            LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype", "tblrequesttype", txtClientPurchaseType, s_Clienttype, Me)
            s_Clienttype.Columns("POTYPEID").Visible = False
            txtClientPurchaseType.Enabled = True
            ckCustomizedBranch.Enabled = True
        ElseIf txtClient_processType.Text = "Voucher Signatories" Then
            ckCustomizedBranch.Enabled = False
            txtClientPurchaseType.Enabled = False
        Else
            txtClientPurchaseType.Properties.DataSource = Nothing
            txtClientPurchaseType.Text = ""
            potypeclientid.Text = ""
            txtClientPurchaseType.Enabled = False
            ckCustomizedBranch.Enabled = True
        End If
        LoadClientProcessList()
    End Sub

    'Public Sub loadClientPurchaseType()
    '    LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype", "tblrequesttype", txtClientPurchaseType, s_Clienttype, Me)
    '    s_Clienttype.Columns("POTYPEID").Visible = False
    'End Sub

    Private Sub txtPurchaseType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientPurchaseType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtClientPurchaseType.Properties.View.FocusedRowHandle.ToString)
        potypeclientid.Text = txtClientPurchaseType.Properties.View.GetFocusedRowCellValue("POTYPEID").ToString()
        txtClientPurchaseType.Text = txtClientPurchaseType.Properties.View.GetFocusedRowCellValue("Request Type").ToString()
        LoadClientProcessList()
    End Sub
    Private Sub ckCustomizedBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ckCustomizedBranch.CheckedChanged
        If ckCustomizedBranch.Checked = True Then
            txtCustomizedBranch.Enabled = True
            LoadXgridLookupEdit("select officeid, officename as 'Office Name' from tblcompoffice where custombranchapproval = 1", "tblcompoffice", txtCustomizedBranch, gridCustombranch, Me)
            gridCustombranch.Columns("officeid").Visible = False
        Else
            custombranchcode.Text = ""
            txtCustomizedBranch.Enabled = False
        End If
        LoadClientProcessList()
    End Sub

    Private Sub txtCustomizedBranch_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCustomizedBranch.EditValueChanging
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCustomizedBranch.Properties.View.FocusedRowHandle.ToString)
        custombranchcode.Text = txtCustomizedBranch.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        LoadClientProcessList()
    End Sub
    Public Sub LoadClientProcessList()
        LoadXgrid("select id, applevel as 'Level', apptitle as 'Title', (select authDescription from tbluserauthority where authCode = tblapproverclientprocess.authcode) as 'Authorize Approver' ,finalapp as 'Final Approver',requiredattachment as 'Required Attachment' from tblapproverclientprocess where apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "' " & If(txtClient_processType.Text = "Requisition Approving Process", " and requestcode='" & potypeclientid.Text & "'", "") & If(ckCustomizedBranch.Checked = True, "and officeid='" & custombranchcode.Text & "'", "") & " and customized=" & ckCustomizedBranch.CheckState & " order by applevel asc", "tblapproverclientprocess", Em_client, gv_clientProcess, Me)
        gv_clientProcess.Columns("id").Visible = False
        XgridColAlign({"Level"}, gv_clientProcess, DevExpress.Utils.HorzAlignment.Center)
        gv_clientProcess.BestFitColumns()
    End Sub
    Public Sub loadUserPosition()
        LoadXgridLookupEdit("select authcode, authDescription as 'Position' from tbluserauthority", "tbluserauthority", txtUserPosition, gv_clientUserPosition, Me)
        gv_clientUserPosition.Columns("authcode").Visible = False
    End Sub

    Private Sub txtUserPosition_EditValueChanged(sender As Object, e As EventArgs) Handles txtUserPosition.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtUserPosition.Properties.View.FocusedRowHandle.ToString)
        authCode.Text = txtUserPosition.Properties.View.GetFocusedRowCellValue("authcode").ToString()
        txtUserPosition.Text = txtUserPosition.Properties.View.GetFocusedRowCellValue("Position").ToString()
    End Sub
    Private Sub cmdClientSave_Click(sender As Object, e As EventArgs) Handles cmdClientSave.Click
        
        If txtClient_level.Text = "" Then
            XtraMessageBox.Show("Please select account level!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient_level.Focus()
            Exit Sub
        ElseIf txtUserPosition.Text = "" Then
            XtraMessageBox.Show("Please select user position!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserPosition.Focus()
            Exit Sub
        ElseIf txtClient_AppTitle.Text = "" Then
            XtraMessageBox.Show("Please select approver title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient_AppTitle.Focus()
            Exit Sub
        ElseIf ckCustomizedBranch.Checked = True And txtCustomizedBranch.Text = "" Then
            XtraMessageBox.Show("Please select custom office approving!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCustomizedCorporate.Focus()
            Exit Sub
        End If
        If client_mode.Text = "edit" Then
            com.CommandText = "update tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='" & potypeclientid.Text & "', authcode='" & authCode.Text & "',apptitle='" & rchar(txtClient_AppTitle.Text) & "', APPLEVEL='" & txtClient_level.Text & "', FINALAPP=" & ckClient_FinalApprover.CheckState & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='" & custombranchcode.Text & "',requiredattachment=" & ckRequireAttachment.CheckState & " where id='" & client_id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblapproverclientprocess set apptype='" & LCase(txtClient_processType.Text.Replace(" ", "-")) & "',requestcode='" & potypeclientid.Text & "', authcode='" & authCode.Text & "',apptitle='" & rchar(txtClient_AppTitle.Text) & "', APPLEVEL='" & txtClient_level.Text & "', FINALAPP=" & ckClient_FinalApprover.CheckState & ",customized=" & ckCustomizedBranch.CheckState & ",officeid='" & custombranchcode.Text & "',requiredattachment=" & ckRequireAttachment.CheckState & "" : com.ExecuteNonQuery()
        End If
        ClearClientField() : LoadClientProcessList()
        XtraMessageBox.Show("Account for approver successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim Rows() As DataRow : Dim I As Integer : Dim todelete As String = ""
        If XtraMessageBox.Show("Are you sure you want to remove selected item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ReDim Rows(gv_clientProcess.SelectedRowsCount - 1)
            For I = 0 To gv_clientProcess.SelectedRowsCount - 1
                Rows(I) = gv_clientProcess.GetDataRow(gv_clientProcess.GetSelectedRows(I))
                todelete = gv_clientProcess.GetRowCellValue(gv_clientProcess.GetSelectedRows(I), "id").ToString
                com.CommandText = "delete from tblapproverclientprocess where id='" & todelete & "'" : com.ExecuteNonQuery()
            Next
            LoadClientProcessList()
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCoffeecupClientPermission.Visible = True Then
            frmCoffeecupClientPermission.Focus()
        Else
            frmCoffeecupClientPermission.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        com.CommandText = "select *, (select description from tblrequesttype where potypeid=tblapproverclientprocess.requestcode) as 'potype',  " _
            + " (select authDescription from tbluserauthority where authCode = tblapproverclientprocess.authcode) as 'userposition' " _
            + " from tblapproverclientprocess where id='" & gv_clientProcess.GetFocusedRowCellValue("id").ToString() & "'" : rst = com.ExecuteReader
        While rst.Read
            client_id.Text = rst("id").ToString
            txtClient_processType.SelectedText = LCase(rst("apptype").ToString.Replace(" ", "-"))
            txtClientPurchaseType.Text = rst("potype").ToString
            potypeclientid.Text = rst("requestcode").ToString
            txtClient_level.Text = rst("applevel").ToString
            txtUserPosition.Text = rst("userposition").ToString
            txtClient_AppTitle.Text = rst("apptitle").ToString
            authCode.Text = rst("authcode").ToString
            ckClient_FinalApprover.Checked = rst("FINALAPP")
            ckRequireAttachment.Checked = rst("requiredattachment")
        End While
        rst.Close()
        client_mode.Text = "" : client_mode.Text = "edit"
    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ClearClientField()
    End Sub
    Public Sub ClearClientField()
        txtClient_level.SelectedIndex = -1
        txtUserPosition.Properties.DataSource = Nothing
        txtUserPosition.Text = ""
        loadUserPosition()

        'txtClientPurchaseType.Properties.DataSource = Nothing
        'txtClientPurchaseType.Text = ""
        'loadClientPurchaseType()
        'potypeclientid.Text = ""

        txtClient_AppTitle.Text = ""
        client_mode.Text = ""
        authCode.Text = ""
        ckClient_FinalApprover.Checked = False
        LoadClientProcessList()
    End Sub



#End Region

    
   
    Private Sub txtProcessType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProcessType.SelectedIndexChanged

    End Sub

    Private Sub txtClient_processType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClient_processType.SelectedIndexChanged

    End Sub
End Class