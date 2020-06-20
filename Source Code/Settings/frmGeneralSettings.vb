Imports DevExpress.XtraEditors
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmGeneralSettings
    Public grid As DevExpress.XtraGrid.Views.Grid.GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGeneralSettingsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gv_Prepared)
        LoadGridviewAppearance(gv_Checked)
        LoadGridviewAppearance(gv_Approved)
        LoadGridviewAppearance(gv_inventory)
        txtfrmdate.EditValue = Now
        loadPOInfo()
        loadPrepared()
        loadChecked()
        loadApproved()
        loadBeginningSupplier()
        loadItemLocker()
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdSaveGeneral.Visible = True
            cmdSaveReport.Visible = True
            cmdSaveEmail.Visible = True
            cmdSaveCloud.Visible = True
        Else
            cmdSaveGeneral.Visible = False
            cmdSaveReport.Visible = False
            cmdSaveEmail.Visible = False
            cmdSaveCloud.Visible = False
        End If
    End Sub

    Public Sub loadBeginningSupplier()
        LoadXgridLookupSearch("SELECT vendorid,companyname as 'Select' from tblglobalvendor order by companyname asc", "tblglobalvendor", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("vendorid").Visible = False
    End Sub

    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        supplierid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("vendorid").ToString()
    End Sub

    Public Sub loadPOInfo()
        Try
            com.CommandText = "select *, (select fullname from tblaccounts where accountid = tblgeneralsettings.preparedid) as 'preparedby',  (select designation from tblaccounts where accountid = tblgeneralsettings.preparedid) as 'preparedbyposition', " _
                                        + " (select fullname from tblaccounts where accountid = tblgeneralsettings.checkedid) as 'checkedby',(select designation from tblaccounts where accountid = tblgeneralsettings.checkedid) as 'checkedbyposition', " _
                                        + " (select fullname from tblaccounts where accountid = tblgeneralsettings.approvedid) as 'approvedby',(select designation from tblaccounts where accountid = tblgeneralsettings.approvedid) as 'approvedbyposition', " _
                                        + " (select companyname from tblglobalvendor where vendorid = tblgeneralsettings.supplierid) as 'vendor' from tblgeneralsettings  where companycode='" & GlobalOrganizationCode & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtfrmdate.EditValue = CDate(rst("systemstartdate").ToString)
                txtUseOfficeAs.Text = rst("useofficecaption").ToString
                txtfiletypesupport.Text = rst("supportfiletype").ToString
                txtFileMB.Text = (Val(CC(rst("allowableattachsize").ToString)) / 1024) / 1024

                '#AUTHORIZED APPROVER
                ckSinglePrepared.Checked = rst("usesingleprepared")
                txtPreparedTitle.Text = rst("preparedtitle").ToString
                txtPreparedName.Text = rst("preparedby").ToString
                txtpreparedPosition.Text = rst("preparedbyposition").ToString
                codePrepared.Text = rst("preparedid").ToString

                ckEnableCheckedby.Checked = rst("enablechecked")
                txtCheckedTitle.Text = rst("checkedtitle").ToString
                txtCheckedName.Text = rst("checkedby").ToString
                txtCheckedPosition.Text = rst("checkedbyposition").ToString
                codeChecked.Text = rst("checkedid").ToString

                ckEnableapprovedby.Checked = rst("enableapproved")
                txtApprovedTitle.Text = rst("approvedtitle").ToString
                txtApprovedName.Text = rst("approvedby").ToString
                txtApprovedPosition.Text = rst("approvedbyposition").ToString
                codeApproved.Text = rst("approvedid").ToString

                txtInventory.Text = rst("vendor").ToString
                supplierid.Text = rst("supplierid").ToString
                ckBeginSupplier.Checked = rst("enablebeginsupplier")
                ckenablerequestapprover.Checked = rst("enablerequestapprover")
                ckEnableHeaderReport.Checked = rst("enableimageheaderreport")

                ckEnableEmailNotification.Checked = rst("enableemailnotification")
                txtSmtpHost.Text = rst("smtphost").ToString
                txtSmtpPort.Text = rst("smptport").ToString
                ckssl.Checked = rst("smtpsslenable")

                txtServerEmail.Text = rst("serveremailaddress").ToString

                If rst("serverpassword").ToString <> "" Then
                    txtServerPassword.Text = DecryptTripleDES(rst("serverpassword").ToString)
                End If

                ckEnableCloud.Checked = rst("enablecloud")
                txtCloudHost.Text = rst("cloudhost").ToString
                txtCloudUser.Text = rst("clouduser").ToString
                If rst("cloudpass").ToString <> "" Then
                    txtCloudPassword.Text = DecryptTripleDES(rst("cloudpass").ToString)
                End If
                ckEnableOfficeReportHeader.Checked = rst("enableofficereportheader")
                ckStockhouse.Checked = rst("enablestockhouse")
                ckEnableCffeBatch.Checked = rst("enablecffebatch")
                ckStrickAttachment.Checked = rst("strictattachments")
                txtFilePath.Text = rst("backupdir").ToString
                txtFileArchiveDir.Text = rst("archiveddir").ToString

                ckDirectApprovedPr.Checked = rst("directapprovedpr")
                ckDirectApprovedPo.Checked = rst("directapprovedpo")

            End While
            rst.Close()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "PO SETTINGS"

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveGeneral.Click
        If txtfrmdate.Text = "" Then
            XtraMessageBox.Show("Please set system start date!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfrmdate.Focus()
            Exit Sub
        ElseIf ckBeginSupplier.Checked = True And txtInventory.Text = "" Then
            XtraMessageBox.Show("Please select Vendor/Supplier", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInventory.Focus()
            Exit Sub
        End If
        UpdateGeneralSettings()
    End Sub
#End Region

#Region "APPROVER"
    Public Sub loadPrepared()
        LoadXgridLookupSearch("select distinct(accountid),fullname as 'Select', designation from tblaccounts inner join tblpermissions on tblaccounts.permission = tblpermissions.percode where approver = 1 ", "tblaccounts", txtPreparedName, gv_Prepared, Me)
        gv_Prepared.Columns("accountid").Visible = False
        gv_Prepared.Columns("designation").Visible = False
    End Sub
    Private Sub txtapprover_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreparedName.EditValueChanged
        On Error Resume Next
        codePrepared.Text = txtPreparedName.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtpreparedPosition.Text = txtPreparedName.Properties.View.GetFocusedRowCellValue("designation").ToString()
    End Sub

    Public Sub loadChecked()
        LoadXgridLookupSearch("select distinct(accountid),fullname as 'Select', designation from tblaccounts inner join tblpermissions on tblaccounts.permission = tblpermissions.percode where approver = 1 ", "tblaccounts", txtCheckedName, gv_Checked, Me)
        gv_Checked.Columns("accountid").Visible = False
        gv_Checked.Columns("designation").Visible = False
    End Sub
    Private Sub txtCheckedName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCheckedName.EditValueChanged
        On Error Resume Next
        codeChecked.Text = txtCheckedName.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtCheckedPosition.Text = txtCheckedName.Properties.View.GetFocusedRowCellValue("designation").ToString()
    End Sub

    Public Sub loadApproved()
        LoadXgridLookupSearch("select distinct(accountid),fullname as 'Select', designation from tblaccounts inner join tblpermissions on tblaccounts.permission = tblpermissions.percode where approver = 1 ", "tblaccounts", txtApprovedName, gv_Approved, Me)
        gv_Approved.Columns("accountid").Visible = False
        gv_Approved.Columns("designation").Visible = False
    End Sub
    Private Sub txtApprovedName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApprovedName.EditValueChanged
        On Error Resume Next
        codeApproved.Text = txtApprovedName.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtApprovedPosition.Text = txtApprovedName.Properties.View.GetFocusedRowCellValue("designation").ToString()
    End Sub

    Private Sub ckSinglePrepared_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckSinglePrepared.CheckedChanged
        If ckSinglePrepared.Checked = True Then
            txtPreparedTitle.Enabled = True
            txtPreparedName.Enabled = True
            txtpreparedPosition.Enabled = True
        Else
            txtPreparedTitle.Enabled = False
            txtPreparedName.Enabled = False
            txtpreparedPosition.Enabled = False
        End If
    End Sub

    Private Sub ckEnableCheckedby_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckEnableCheckedby.CheckedChanged
        If ckEnableCheckedby.Checked = True Then
            txtCheckedTitle.Enabled = True
            txtCheckedName.Enabled = True
            txtCheckedPosition.Enabled = True
        Else
            txtCheckedTitle.Enabled = False
            txtCheckedName.Enabled = False
            txtCheckedPosition.Enabled = False
        End If
    End Sub

    Private Sub ckApprovedTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckEnableapprovedby.CheckedChanged
        If ckEnableapprovedby.Checked = True Then
            txtApprovedTitle.Enabled = True
            txtApprovedName.Enabled = True
            txtApprovedPosition.Enabled = True
        Else
            txtApprovedTitle.Enabled = False
            txtApprovedName.Enabled = False
            txtApprovedPosition.Enabled = False
        End If
    End Sub
#End Region

#Region "ITEM LOCKER"
    Public Sub loadItemLocker()
        com.CommandText = "select * from tblgeneralsettings  where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader
        While rst.Read
            ckBillingsAndPayables.Checked = rst("enablelockbillings")
            txtBillingsandPayables.Text = UCase(rst("locktypebillings").ToString)

            ckConsumable.Checked = rst("enablelockconsumable")
            txtConsumables.Text = UCase(rst("locktypeconsumable").ToString)

            ckcffe.Checked = rst("enablelockcffe")
            txtCffe.Text = UCase(rst("locktypecffe").ToString)
        End While
        rst.Close()
    End Sub
    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateGeneralSettings()
    End Sub

    Private Sub ckBillingsAndPayables_CheckedChanged(sender As Object, e As EventArgs) Handles ckBillingsAndPayables.CheckedChanged
        If ckBillingsAndPayables.Checked = True Then
            txtBillingsandPayables.Enabled = True
        Else
            txtBillingsandPayables.Enabled = False
            txtBillingsandPayables.SelectedIndex = -1
        End If
    End Sub

    Private Sub ckConsumable_CheckedChanged(sender As Object, e As EventArgs) Handles ckConsumable.CheckedChanged
        If ckConsumable.Checked = True Then
            txtConsumables.Enabled = True
        Else
            txtConsumables.Enabled = False
            txtConsumables.SelectedIndex = -1
        End If
    End Sub

    Private Sub ckcffe_CheckedChanged(sender As Object, e As EventArgs) Handles ckcffe.CheckedChanged
        If ckcffe.Checked = True Then
            txtCffe.Enabled = True
        Else
            txtCffe.Enabled = False
            txtCffe.SelectedIndex = -1
        End If
    End Sub
#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveReport.Click
        If ckSinglePrepared.Checked = True And txtPreparedTitle.Text = "" Then
            XtraMessageBox.Show("Please enter custom prepared by title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPreparedTitle.Focus()
            Exit Sub
        ElseIf ckSinglePrepared.Checked = True And txtPreparedName.Text = "" Then
            XtraMessageBox.Show("Please select prepared name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPreparedTitle.Focus()
            Exit Sub
        ElseIf ckEnableCheckedby.Checked = True And txtCheckedTitle.Text = "" Then
            XtraMessageBox.Show("Please enter custom checked by title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckedTitle.Focus()
            Exit Sub
        ElseIf ckEnableCheckedby.Checked = True And txtCheckedName.Text = "" Then
            XtraMessageBox.Show("Please select checked name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckedTitle.Focus()
            Exit Sub
        ElseIf ckEnableapprovedby.Checked = True And txtApprovedTitle.Text = "" Then
            XtraMessageBox.Show("Please enter custom approved by title!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtApprovedTitle.Focus()
            Exit Sub
        ElseIf ckEnableapprovedby.Checked = True And txtApprovedName.Text = "" Then
            XtraMessageBox.Show("Please select approved name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtApprovedTitle.Focus()
            Exit Sub
        End If
        UpdateGeneralSettings()
    End Sub

    Private Sub ckBeginSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckBeginSupplier.CheckedChanged
        If ckBeginSupplier.Checked = True Then
            txtInventory.Enabled = True

        Else
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
            loadBeginningSupplier()
            txtInventory.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdSaveEmail.Click
        If ckEnableEmailNotification.Checked = True Then
            If txtSmtpHost.Text = "" Then
                XtraMessageBox.Show("Please enter SMTP host", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSmtpHost.Focus()
                Exit Sub
            ElseIf txtSmtpPort.Text = "" Then
                XtraMessageBox.Show("Please enter SMTP Port", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSmtpPort.Focus()
                Exit Sub
            ElseIf txtServerEmail.Text = "" Then
                XtraMessageBox.Show("Please enter server email address", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtServerEmail.Focus()
                Exit Sub
            ElseIf txtServerPassword.Text = "" Then
                XtraMessageBox.Show("Please enter server password", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtServerPassword.Focus()
                Exit Sub
            End If
        End If
        UpdateGeneralSettings()
    End Sub

    Private Sub ckEnableEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableEmailNotification.CheckedChanged
        If ckEnableEmailNotification.Checked = True Then
            txtSmtpHost.Properties.ReadOnly = False
            txtSmtpPort.Properties.ReadOnly = False
            ckssl.Properties.ReadOnly = False
            txtServerEmail.Properties.ReadOnly = False
            txtServerPassword.Properties.ReadOnly = False
        Else
            txtSmtpHost.Properties.ReadOnly = True
            txtServerEmail.Properties.ReadOnly = True
            txtSmtpPort.Properties.ReadOnly = True
            ckssl.Properties.ReadOnly = True
            txtServerPassword.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ckEnableCloud_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableCloud.CheckedChanged
        If ckEnableCloud.Checked = True Then
            txtCloudHost.Properties.ReadOnly = False
            txtCloudUser.Properties.ReadOnly = False
            txtCloudPassword.Properties.ReadOnly = False
        Else
            txtCloudHost.Properties.ReadOnly = True
            txtCloudUser.Properties.ReadOnly = True
            txtCloudPassword.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub cmdCloud_Click(sender As Object, e As EventArgs) Handles cmdSaveCloud.Click
        If ckEnableCloud.Checked = True Then
            If txtCloudHost.Text = "" Then
                XtraMessageBox.Show("Please enter cloud host", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCloudHost.Focus()
                Exit Sub
            ElseIf txtCloudUser.Text = "" Then
                XtraMessageBox.Show("Please enter cloud username", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCloudUser.Focus()
                Exit Sub
            ElseIf txtCloudPassword.Text = "" Then
                XtraMessageBox.Show("Please enter cloud password", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCloudPassword.Focus()
                Exit Sub
            End If
        End If

        UpdateGeneralSettings()
    End Sub

    Private Sub txtFileMB_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileMB.EditValueChanged
        txtFileKB.Text = Val(CC(txtFileMB.Text)) * 1024
    End Sub


    Private Sub txtFilePath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFilePath.ButtonClick
        Dim fbd As New System.Windows.Forms.FolderBrowserDialog
        If fbd.ShowDialog() = DialogResult.OK Then
            txtFilePath.Text = fbd.SelectedPath
        End If
    End Sub

 
   
    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFileArchiveDir.ButtonClick
        Dim fbd As New System.Windows.Forms.FolderBrowserDialog
        If fbd.ShowDialog() = DialogResult.OK Then
            txtFileArchiveDir.Text = fbd.SelectedPath
        End If
    End Sub

    Public Sub UpdateGeneralSettings()
        If XtraMessageBox.Show("This action is required an administrative permission! are you wish to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tblgeneralsettings", "companycode='" & GlobalOrganizationCode & "'") = 0 Then
                com.CommandText = "INSERT into tblgeneralsettings set " _
                        + " companycode='" & GlobalOrganizationCode & "', " _
                        + " systemstartdate='" & ConvertDate(txtfrmdate.Text) & "', " _
                        + " useofficecaption='" & rchar(txtUseOfficeAs.Text) & "', " _
                        + " enableofficereportheader=" & ckEnableOfficeReportHeader.CheckState & ", " _
                        + " supportfiletype='" & rchar(txtfiletypesupport.Text) & "', " _
                        + " allowableattachsize='" & Val(CC(txtFileKB.Text)) * 1024 & "', " _
                        + " enablebeginsupplier=" & ckBeginSupplier.CheckState & ", " _
                        + " supplierid='" & supplierid.Text & "', " _
                        + " enablerequestapprover=" & ckenablerequestapprover.CheckState & ", " _
                        + " enableimageheaderreport='" & ckEnableHeaderReport.CheckState & "', " _
                        + " enablestockhouse=" & ckStockhouse.CheckState & ", " _
                        + " enablecffebatch=" & ckEnableCffeBatch.CheckState & ", " _
                        + " strictattachments=" & ckStrickAttachment.CheckState & ", " _
                        + " backupdir='" & rchar(txtFilePath.Text) & "', " _
                        + " archiveddir='" & rchar(txtFileArchiveDir.Text) & "', " _
                        + " directapprovedpr=" & ckDirectApprovedPr.CheckState & ", " _
                        + " directapprovedpo=" & ckDirectApprovedPo.CheckState & ", " _
                        + " usesingleprepared='" & ckSinglePrepared.CheckState & "', " _
                        + " preparedtitle='" & txtPreparedTitle.Text & "', " _
                        + " preparedid='" & codePrepared.Text & "', " _
                        + " enablechecked='" & ckEnableCheckedby.CheckState & "', " _
                        + " checkedtitle='" & txtCheckedTitle.Text & "', " _
                        + " checkedid='" & codeChecked.Text & "', " _
                        + " enableapproved='" & ckEnableapprovedby.CheckState & "', " _
                        + " approvedtitle='" & txtApprovedTitle.Text & "', " _
                        + " approvedid='" & codeApproved.Text & "', " _
                        + " enablelockbillings=" & ckBillingsAndPayables.CheckState & ",  " _
                        + " locktypebillings='" & txtBillingsandPayables.Text & "', " _
                        + " enablelockconsumable=" & ckConsumable.CheckState & ", " _
                        + " locktypeconsumable='" & txtConsumables.Text & "', " _
                        + " enablelockcffe=" & ckcffe.CheckState & ", " _
                        + " locktypecffe='" & txtCffe.Text & "', " _
                        + " enableemailnotification='" & ckEnableEmailNotification.CheckState & "', " _
                        + " smtphost='" & txtSmtpHost.Text & "', " _
                        + " serveremailaddress='" & txtServerEmail.Text & "', " _
                        + " serverpassword='" & EncryptTripleDES(txtServerPassword.Text) & "', " _
                        + " smptport='" & txtSmtpPort.Text & "', " _
                        + " smtpsslenable=" & ckssl.CheckState & ", " _
                        + " enablecloud='" & ckEnableCloud.CheckState & "', " _
                        + " cloudhost='" & txtCloudHost.Text & "', " _
                        + " clouduser='" & txtCloudUser.Text & "', " _
                        + " cloudpass='" & EncryptTripleDES(txtCloudPassword.Text) & "'"
                com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblgeneralsettings set " _
                       + " useofficecaption='" & rchar(txtUseOfficeAs.Text) & "', " _
                       + " enableofficereportheader=" & ckEnableOfficeReportHeader.CheckState & ", " _
                       + " supportfiletype='" & rchar(txtfiletypesupport.Text) & "', " _
                       + " allowableattachsize='" & Val(CC(txtFileKB.Text)) * 1024 & "', " _
                       + " enablebeginsupplier=" & ckBeginSupplier.CheckState & ", " _
                       + " supplierid='" & supplierid.Text & "', " _
                       + " enablerequestapprover=" & ckenablerequestapprover.CheckState & ", " _
                       + " enableimageheaderreport='" & ckEnableHeaderReport.CheckState & "', " _
                       + " enablestockhouse=" & ckStockhouse.CheckState & ", " _
                       + " enablecffebatch=" & ckEnableCffeBatch.CheckState & ", " _
                       + " strictattachments=" & ckStrickAttachment.CheckState & ", " _
                       + " backupdir='" & rchar(txtFilePath.Text) & "', " _
                       + " archiveddir='" & rchar(txtFileArchiveDir.Text) & "', " _
                       + " directapprovedpr=" & ckDirectApprovedPr.CheckState & ", " _
                       + " directapprovedpo=" & ckDirectApprovedPo.CheckState & ", " _
                       + " usesingleprepared='" & ckSinglePrepared.CheckState & "', " _
                       + " preparedtitle='" & txtPreparedTitle.Text & "', " _
                       + " preparedid='" & codePrepared.Text & "', " _
                       + " enablechecked='" & ckEnableCheckedby.CheckState & "', " _
                       + " checkedtitle='" & txtCheckedTitle.Text & "', " _
                       + " checkedid='" & codeChecked.Text & "', " _
                       + " enableapproved='" & ckEnableapprovedby.CheckState & "', " _
                       + " approvedtitle='" & txtApprovedTitle.Text & "', " _
                       + " approvedid='" & codeApproved.Text & "', " _
                       + " enablelockbillings=" & ckBillingsAndPayables.CheckState & ",  " _
                       + " locktypebillings='" & txtBillingsandPayables.Text & "', " _
                       + " enablelockconsumable=" & ckConsumable.CheckState & ", " _
                       + " locktypeconsumable='" & txtConsumables.Text & "', " _
                       + " enablelockcffe=" & ckcffe.CheckState & ", " _
                       + " locktypecffe='" & txtCffe.Text & "', " _
                       + " enableemailnotification='" & ckEnableEmailNotification.CheckState & "', " _
                       + " smtphost='" & txtSmtpHost.Text & "', " _
                       + " serveremailaddress='" & txtServerEmail.Text & "', " _
                       + " serverpassword='" & EncryptTripleDES(txtServerPassword.Text) & "', " _
                       + " smptport='" & txtSmtpPort.Text & "', " _
                       + " smtpsslenable=" & ckssl.CheckState & ", " _
                       + " enablecloud='" & ckEnableCloud.CheckState & "', " _
                       + " cloudhost='" & txtCloudHost.Text & "', " _
                       + " clouduser='" & txtCloudUser.Text & "', " _
                       + " cloudpass='" & EncryptTripleDES(txtCloudPassword.Text) & "' where companycode='" & GlobalOrganizationCode & "'"
                com.ExecuteNonQuery()
            End If
            LoadGeneralSettings()
            XtraMessageBox.Show("Your settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class