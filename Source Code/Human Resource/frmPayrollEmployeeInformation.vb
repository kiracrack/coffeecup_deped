Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmPayrollEmployeeInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadUseraccounts()
        loadAssignedOffice()
        loadEmployeeType()
        loadEmployeePosition()
        loadBankTable()
        loadBankAccounts()
        LoadClientAccounts()
        LoadDeductionTable()
        LoadScheduleDedType()
        loadDeductionsSchedule()

        LoadScheduleAddType()
        LoadAddtionalTable()
        loadAdditionalSchedule()
        LoadShiftOption()

        LoadGridviewAppearance(gv_assignoffice)
        LoadGridviewAppearance(gv_EmployeeType)
        LoadGridviewAppearance(gv_rate)
        LoadGridviewAppearance(gv_BankName)
        LoadGridviewAppearance(gv_bankaccounts)
        LoadGridviewAppearance(grid_useraccess)
        LoadGridviewAppearance(grid_linkClientAccount)
        LoadGridviewAppearance(gv_deduction)
        LoadGridviewAppearance(gv_additionals)
        LoadGridviewAppearance(gv_scheduletype)
        LoadGridviewAppearance(gv_additionalSched)
        LoadGridviewAppearance(grid_shiftsettings)

        LoadToComboBox("nationality", "tblemployees", txtnationality, True)
        LoadToComboBox("religion", "tblemployees", txtreligion, True)
        LoadToComboBox("civilstatus", "tblemployees", txtCivilStatus, True)

        LoadToComboBox("per_add_brgy", "tblemployees", txtPer_Add_Brgy, True)
        LoadToComboBox("per_add_city", "tblemployees", txtPer_Add_City, True)
        LoadToComboBox("per_add_prov", "tblemployees", txtPer_Add_Prov, True)

        LoadToComboBox("cur_add_brgy", "tblemployees", txtCur_Add_Brgy, True)
        LoadToComboBox("cur_add_city", "tblemployees", txtCur_Add_City, True)
        LoadToComboBox("cur_add_prov", "tblemployees", txtCur_Add_Prov, True)

        LoadToComboBox("position", "tblemployees", txtPosition, True)

        txtSchedDedStartingDate.EditValue = Now
        txtSchedDedDateMaturity.EditValue = Now
        txtAddSchedStartDate.EditValue = Now
        txtAddSchedDateMaturity.EditValue = Now

        ValidateProfile()
        If mode.Text = "edit" Then
            showInformation(txtEmployeeid.Text)
        Else
            If GLobalEmployeeSequence = True Then
                txtEmployeeid.ReadOnly = True
                txtEmployeeid.Text = getEmployeeIDSequence()
                com.CommandText = "UPDATE tblpayrollsettings set employeeidsequence='" & txtEmployeeid.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
            Else
                txtEmployeeid.ReadOnly = False
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Public Sub LoadUseraccounts()
        LoadXgridLookupSearch("select accountid as code, fullname as 'Select' from tblaccounts order by fullname", "tblaccounts", txtUserAccount, grid_useraccess, Me)
        grid_useraccess.Columns("code").Visible = False
    End Sub
    Private Sub txtUserAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserAccount.EditValueChanged
        On Error Resume Next
        userid.Text = txtUserAccount.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub LoadClientAccounts()
        LoadXgridLookupSearch("select cifid as code, companyname as 'Select' from tblclientaccounts order by companyname", "tblclientaccounts", txtLinkClientAccount, grid_linkClientAccount, Me)
        grid_linkClientAccount.Columns("code").Visible = False
    End Sub
    Private Sub txtLinkClientAccount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLinkClientAccount.EditValueChanged
        On Error Resume Next
        cifid.Text = txtLinkClientAccount.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadAssignedOffice()
        LoadXgridLookupSearch("select officeid as code, officename as 'Select' from tblcompoffice order by officename", "tblcompoffice", txtAssignOffice, gv_assignoffice, Me)
        gv_assignoffice.Columns("code").Visible = False
    End Sub
    Private Sub txtAssignOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAssignOffice.EditValueChanged
        On Error Resume Next
        txtOfficeid.Text = txtAssignOffice.Properties.View.GetFocusedRowCellValue("code").ToString
        LoadXgridLookupSearch("select depid as code, departmentname as 'Select' from tblcompdepartments where officeid='" & txtOfficeid.Text & "' order by departmentname", "tblcompdepartments", txtDepartment, gv_department, Me)
        gv_department.Columns("code").Visible = False

    End Sub

    Private Sub txtDepartment_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartment.EditValueChanged
        On Error Resume Next
        depid.Text = txtDepartment.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub loadEmployeeType()
        LoadXgridLookupEdit("select code, description as 'Select' from tblemployeetype order by description", "tblemployeetype", txtEmployeeType, gv_EmployeeType, Me)
        gv_EmployeeType.Columns("code").Visible = False
    End Sub
    Private Sub txtEmployeeType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeType.EditValueChanged
        On Error Resume Next
        txtEmployeetypecode.Text = txtEmployeeType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadEmployeePosition()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrollbasicrate order by description", "tblpayrollbasicrate", txtBasicRate, gv_rate, Me)
        gv_rate.Columns("code").Visible = False
    End Sub
    Private Sub txtPosition_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBasicRate.EditValueChanged
        On Error Resume Next
        txtPositioncode.Text = txtBasicRate.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub LoadShiftOption()
        LoadXgridLookupEdit("select shiftcode, totalhours, Description as 'Select' from tblpayrollshiftsettings", "tblpayrollshiftsettings", txtshifttype, grid_shiftsettings, Me)
        grid_shiftsettings.Columns("shiftcode").Visible = False
        grid_shiftsettings.Columns("totalhours").Visible = False
    End Sub
    Private Sub txtshifttype_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtshifttype.EditValueChanged
        On Error Resume Next
        shiftcode.Text = txtshifttype.Properties.View.GetFocusedRowCellValue("shiftcode").ToString
    End Sub

#Region "MENU SETTINGS"

    Private Sub navDeductionSched_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navDeductionSched.LinkClicked
        tabNavPayrollSettings.SelectedTabPage = tabDeductionSched
    End Sub

    Private Sub navAdditionalSched_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navAdditionalSched.LinkClicked
        tabNavPayrollSettings.SelectedTabPage = tabAdditionalSched
    End Sub

    Private Sub navEmploymentDetails_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navEmploymentDetails.LinkClicked
        tabNavPayrollSettings.SelectedTabPage = tabEmploymentDetails
    End Sub

    Private Sub navPayoutType_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navPayoutType.LinkClicked
        tabNavPayrollSettings.SelectedTabPage = tabPayoutType
    End Sub

#End Region

    Private Sub ckEnableContractPeriod_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableContractPeriod.CheckedChanged
        If ckEnableContractPeriod.Checked = True Then
            txtContractstartdate.Enabled = True
            txtContractenddate.Enabled = True
        Else
            txtContractstartdate.Enabled = False
            txtContractenddate.Enabled = False
            txtContractstartdate.Text = ""
            txtContractenddate.Text = ""
        End If
    End Sub

#Region "BANK ACCOUNTS"
    Private Sub radPayoutType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radPayoutType.SelectedIndexChanged
        If radPayoutType.SelectedIndex = 0 Then
            txtAccountNumber.Enabled = False
            txtBankName.Enabled = False
            'If mode.Text = "edit" Then
            '    cmdaddBank.Enabled = True
            'Else
            '    cmdaddBank.Enabled = False
            'End If
        Else
            txtAccountNumber.Enabled = True
            txtBankName.Enabled = True
        End If
    End Sub

    Private Sub cmdaddBank_Click(sender As Object, e As EventArgs) Handles cmdaddBank.Click
        If txtEmployeeid.Text = "" Then
            XtraMessageBox.Show("Please enter employee id number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeType.Focus()
            Exit Sub
        ElseIf txtAccountNumber.Text = "" Then
            XtraMessageBox.Show("Please enter bank account number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountNumber.Focus()
            Exit Sub
        ElseIf txtBankName.Text = "" Then
            XtraMessageBox.Show("Please select bank name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBankName.Focus()
            Exit Sub
        End If
        If radPayoutType.SelectedIndex = 0 Then
            com.CommandText = "update tblemployees set payouttype=0 where employeeid='" & txtEmployeeid.Text & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Payout type successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "update tblemployees set payouttype=1 where employeeid='" & txtEmployeeid.Text & "'" : com.ExecuteNonQuery()
            If mode_bank.Text <> "edit" Then
                com.CommandText = "insert into tblpayrollpayoutaccounts set employeeid='" & txtEmployeeid.Text & "', cardnumber='" & txtAccountNumber.Text & "', bankcode='" & bankcode.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblpayrollpayoutaccounts set employeeid='" & txtEmployeeid.Text & "', cardnumber='" & txtAccountNumber.Text & "', bankcode='" & bankcode.Text & "' where id='" & id_bank.Text & "'" : com.ExecuteNonQuery()
            End If
            XtraMessageBox.Show("Bank account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtAccountNumber.Text = ""
        txtBankName.Properties.DataSource = Nothing
        txtBankName.Text = ""
        bankcode.Text = ""
        mode_bank.Text = ""
        loadBankTable()
        loadBankAccounts()
    End Sub
    Public Sub ShowBankInfo()
        com.CommandText = "select *,(select bankname from tblpayrollpayoutbanks where tblpayrollpayoutbanks.bankcode = tblpayrollpayoutaccounts.bankcode) as 'bank' from tblpayrollpayoutaccounts where id='" & id_bank.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtAccountNumber.Text = rst("cardnumber").ToString
            txtBankName.Text = rst("bank").ToString
            bankcode.Text = rst("bankcode").ToString
        End While
        rst.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        radPayoutType.SelectedIndex = 1
        id_bank.Text = gv_bankaccounts.GetFocusedRowCellValue("id").ToString : mode_bank.Text = ""
        ShowBankInfo() : mode_bank.Text = "edit"
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        loadBankAccounts()
    End Sub

    Public Sub loadBankTable()
        LoadXgridLookupEdit("select bankcode, bankname 'Select' from tblpayrollpayoutbanks order by bankname", "tblpayrollpayoutbanks", txtBankName, gv_BankName, Me)
        gv_BankName.Columns("bankcode").Visible = False
    End Sub
    Private Sub txtBankName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankName.EditValueChanged
        On Error Resume Next
        bankcode.Text = txtBankName.Properties.View.GetFocusedRowCellValue("bankcode").ToString
    End Sub

    Public Sub loadBankAccounts()
        LoadXgrid("select id, cardnumber as 'Account Number', (select bankname from tblpayrollpayoutbanks where bankcode = tblpayrollpayoutaccounts.bankcode) as 'Bank Name',case when usedefault=1 then 'Default' else '-' end as 'Default' from tblpayrollpayoutaccounts where employeeid='" & txtEmployeeid.Text & "'", "tblpayrollpayoutaccounts", Em, gv_bankaccounts, Me)
        gv_bankaccounts.Columns("id").Visible = False
        gv_bankaccounts.Columns("Account Number").Width = 100
        XgridColAlign({"Default"}, gv_bankaccounts, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Private Sub gv_bankaccounts_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gv_bankaccounts.RowCellStyle
        Dim View As GridView = sender
        'e.Appearance.BackColor2 = Color.LightCyan
        If gen_filterappearance = True Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Default"))
            If status = "Default" Then
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub ActiveInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdSetDefault.Click
        If CheckSelectedRow("id", gv_bankaccounts) = True Then
            If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblpayrollpayoutaccounts set usedefault=0 where employeeid='" & txtEmployeeid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblpayrollpayoutaccounts set usedefault=1 where id='" & gv_bankaccounts.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
                loadBankAccounts()
            End If
        End If
    End Sub

    Private Sub Em_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        MenuFilter()
    End Sub

    Private Sub Em_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        MenuFilter()
    End Sub

    Private Sub Em_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.Move
        MenuFilter()
    End Sub

    Public Sub MenuFilter()
        On Error Resume Next
        If gv_bankaccounts.GetFocusedRowCellValue("Default").ToString = "Default" Then
            cmdSetDefault.Enabled = False
        Else
            cmdSetDefault.Enabled = True
        End If
    End Sub

#End Region

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles cmdSaveInfo.Click
        Dim query As String = " lastname='" & rchar(txtlastname.Text) & "', " _
                               + " firstname='" & rchar(txtFistname.Text) & "', " _
                               + " middlename='" & rchar(txtmiddlename.Text) & "', " _
                               + " fullname='" & rchar(txtfullname.Text) & "', " _
                               + " extname='" & rchar(txtExtname.Text) & "', " _
                               + " nickname='" & rchar(txtnickname.Text) & "', " _
                               + If(txtBirthdate.Text <> "", "birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ", "") & " " _
                               + " birthplace='" & rchar(txtbirthplace.Text) & "', " _
                               + " nationality='" & rchar(txtnationality.Text) & "', " _
                               + " religion='" & rchar(txtreligion.Text) & "', " _
                               + " civilstatus='" & rchar(txtCivilStatus.Text) & "', " _
                               + " profilelink='" & rchar(txtprofilelink.Text) & "', " _
                               + " per_add_brgy='" & rchar(txtPer_Add_Brgy.Text) & "', " _
                               + " per_add_city='" & rchar(txtPer_Add_City.Text) & "', " _
                               + " per_add_prov='" & rchar(txtPer_Add_Prov.Text) & "', " _
                               + " cur_add_brgy='" & rchar(txtCur_Add_Brgy.Text) & "', " _
                               + " cur_add_city='" & rchar(txtCur_Add_City.Text) & "', " _
                               + " cur_add_prov='" & rchar(txtCur_Add_Prov.Text) & "', " _
                               + " contactnumber='" & txtContactnumber.Text & "', " _
                               + " homenumber='" & txthomenumber.Text & "', " _
                               + " emailaddress='" & txtemailaddress.Text & "', " _
                               + " inc_cont_person='" & rchar(txtInc_Cont_Person.Text) & "', " _
                               + " inc_cont_number='" & rchar(txtInc_Cont_Number.Text) & "', " _
                               + " inc_cont_address='" & rchar(txtInc_Cont_Address.Text) & "', " _
                               + " biometricid='" & txtBiometricID.Text & "', " _
                               + " linkuserid='" & userid.Text & "', " _
                               + " linkclientid='" & cifid.Text & "' "

        If countqry("tblemployees", "employeeid='" & txtEmployeeid.Text & "'") = 0 Then
            com.CommandText = "INSERT INTO tblemployees set employeeid='" & txtEmployeeid.Text & "', " & query & ", dateregistered=current_timestamp; " : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblemployees set " & query & " where employeeid='" & txtEmployeeid.Text & "' " : com.ExecuteNonQuery()
        End If

        If countqry("filedir.tblemployeepic", "employeeid='" & txtEmployeeid.Text & "'") = 0 Then
            com.CommandText = "INSERT INTO filedir.tblemployeepic set employeeid='" & txtEmployeeid.Text & "'" : com.ExecuteNonQuery()
        End If

        UpdateImage("employeeid='" & txtEmployeeid.Text & "'", "img", "filedir.tblemployeepic", ProfilePic, Me)
        ValidateProfile()
        XtraMessageBox.Show("Employee successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub showInformation(ByVal id As String)
        Try
            Dim officename As String = "" : Dim departmentname As String = ""
            com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblemployees.officeid) as 'officename', " _
                              + " (select departmentname from tblcompdepartments where depid = tblemployees.depid) as 'department', " _
                              + " (select description from tblemployeetype where code = tblemployees.employeetypecode) as 'employeetype', " _
                              + " (select description from tblpayrollbasicrate where code = tblemployees.positioncode) as 'rate', " _
                              + " (select fullname from tblemployees as a where a.employeeid = tblemployees.approvedby) as 'statusapprovedbyname'," _
                              + " (select fullname from tblaccounts where accountid=tblemployees.linkuserid) as 'useraccount', " _
                              + " (select description from tblpayrollshiftsettings where shiftcode=tblemployees.shiftcode) as 'shift'," _
                              + " (select companyname from tblclientaccounts where cifid=tblemployees.linkclientid) as 'clientaccount', " _
                              + " (select img from filedir.tblemployeepic where employeeid=tblemployees.employeeid) as img from tblemployees where employeeid='" & id & "'" : rst = com.ExecuteReader
            While rst.Read
                txtlastname.Text = rst("lastname").ToString
                txtFistname.Text = rst("firstname").ToString
                txtmiddlename.Text = rst("middlename").ToString
                txtfullname.Text = rst("fullname").ToString
                txtExtname.Text = rst("extname").ToString
                txtnickname.Text = rst("nickname").ToString
                txtBirthdate.EditValue = If(rst("birthdate").ToString = "", "", CDate(rst("birthdate").ToString))
                txtbirthplace.Text = rst("birthplace").ToString
                txtnationality.Text = rst("nationality").ToString
                txtreligion.Text = rst("religion").ToString
                txtCivilStatus.Text = rst("civilstatus").ToString
                txtprofilelink.Text = rst("profilelink").ToString
                txtPer_Add_Brgy.Text = rst("per_add_brgy").ToString
                txtPer_Add_City.Text = rst("per_add_city").ToString
                txtPer_Add_Prov.Text = rst("per_add_prov").ToString
                txtCur_Add_Brgy.Text = rst("cur_add_brgy").ToString
                txtCur_Add_City.Text = rst("cur_add_city").ToString
                txtCur_Add_Prov.Text = rst("cur_add_prov").ToString
                txtContactnumber.Text = rst("contactnumber").ToString
                txthomenumber.Text = rst("homenumber").ToString
                txtemailaddress.Text = rst("emailaddress").ToString
                txtInc_Cont_Person.Text = rst("inc_cont_person").ToString
                txtInc_Cont_Number.Text = rst("inc_cont_number").ToString
                txtInc_Cont_Address.Text = rst("inc_cont_address").ToString

                txtBiometricID.Text = rst("biometricid").ToString
                txtUserAccount.Text = rst("useraccount").ToString
                userid.Text = rst("linkuserid").ToString
                txtLinkClientAccount.Text = rst("clientaccount").ToString
                cifid.Text = rst("linkclientid").ToString

                officename = rst("officename").ToString
                txtOfficeid.Text = rst("officeid").ToString
                departmentname = rst("department").ToString
                depid.Text = rst("depid").ToString


                txtEmployeeType.Text = rst("employeetype").ToString
                txtEmployeetypecode.Text = rst("employeetypecode").ToString
                txtPosition.Text = rst("position").ToString
                txtBasicRate.Text = rst("rate").ToString
                txtPositioncode.Text = rst("positioncode").ToString
                txtshifttype.Text = rst("shift").ToString
                shiftcode.Text = rst("shiftcode").ToString
                ckEnableContractPeriod.Checked = rst("contractperiod")
                txtContractstartdate.EditValue = If(rst("contractstartdate").ToString = "", "", CDate(rst("contractstartdate").ToString))
                txtContractenddate.EditValue = If(rst("contractenddate").ToString = "", "", CDate(rst("contractenddate").ToString))
                txtdatehired.EditValue = If(rst("datehired").ToString = "", "", CDate(rst("datehired").ToString))
                txtDateRegular.EditValue = If(rst("dateregular").ToString = "", "", CDate(rst("dateregular").ToString))

                If rst("img").ToString <> "" Then
                    imgBytes = CType(rst("img"), Byte())
                    stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                    img = Image.FromStream(stream)
                    ProfilePic.Image = img
                End If

            End While
            rst.Close()
            txtAssignOffice.Text = officename
            txtDepartment.Text = departmentname
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ValidateProfile()
        If countqry("tblemployees", "employeeid='" & txtEmployeeid.Text & "'") <> 0 Then
            tabPayrollSetting.PageVisible = True
            txtEmployeeid.Enabled = False
        Else
            tabPayrollSetting.PageVisible = False
            txtEmployeeid.Enabled = True
        End If
    End Sub

    Private Sub txtlastname_EditValueChanged(sender As Object, e As EventArgs) Handles txtlastname.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtFistname_EditValueChanged(sender As Object, e As EventArgs) Handles txtFistname.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtmiddlename_EditValueChanged(sender As Object, e As EventArgs) Handles txtmiddlename.EditValueChanged
        getFullname()
    End Sub

    Private Sub txtExtname_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtname.EditValueChanged
        getFullname()
    End Sub
    Public Sub getFullname()
        Dim midlename As String = "" : Dim extentionname As String = ""
        If txtmiddlename.Text <> "" Then
            midlename = " " & txtmiddlename.Text
        Else
            midlename = ""
        End If
        If txtExtname.Text <> "" Then
            extentionname = " " & txtExtname.Text
        Else
            extentionname = ""
        End If
        If txtlastname.Text <> "" And txtFistname.Text <> "" Then
            txtfullname.Text = txtlastname.Text & ", " & txtFistname.Text & midlename & extentionname
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim ContractDate As String = "" : Dim DateRegular As String = ""
        If txtOfficeid.Text = "" Then
            MessageBox.Show("Please enter Office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeid.Focus()
            Exit Sub
        ElseIf txtEmployeetypecode.Text = "" Then
            MessageBox.Show("Please enter Employee Type !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeetypecode.Focus()
            Exit Sub
        ElseIf txtPositioncode.Text = "" Then
            MessageBox.Show("Please enter Position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPositioncode.Focus()
            Exit Sub
        ElseIf txtshifttype.Text = "" Then
            MessageBox.Show("Please select shift type!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtshifttype.Focus()
            Exit Sub
        ElseIf txtdatehired.Text = "" Then
            MessageBox.Show("Please enter Date Hired!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdatehired.Focus()
            Exit Sub
        End If
        If ckEnableContractPeriod.Checked = True Then
            If txtContractstartdate.Text = "" Then
                MessageBox.Show("Please enter Contract Start Date!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtContractstartdate.Focus()
                Exit Sub
            ElseIf txtContractenddate.Text = "" Then
                MessageBox.Show("Please enter Contract End Date!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtContractenddate.Focus()
                Exit Sub
            End If
            ContractDate = ", contractstartdate='" & ConvertDate(txtContractstartdate.Text) & "', contractenddate='" & ConvertDate(txtContractenddate.Text) & "'"
        Else
            ContractDate = ""
        End If

        If txtDateRegular.Text = "" Then
            DateRegular = ""
        Else
            DateRegular = ", dateregular='" & ConvertDate(txtDateRegular.Text) & "'"
        End If
        com.CommandText = "UPDATE tblemployees set officeid='" & txtOfficeid.Text & "', " _
                               + " depid='" & depid.Text & "', " _
                               + " employeetypecode='" & txtEmployeetypecode.Text & "', " _
                               + " `position`='" & rchar(txtPosition.Text) & "', " _
                               + " positioncode='" & txtPositioncode.Text & "', " _
                               + " shiftcode='" & shiftcode.Text & "', " _
                               + " contractperiod='" & ckEnableContractPeriod.CheckState & "', " _
                               + " datehired='" & ConvertDate(txtdatehired.Text) & "' " _
                               + ContractDate & DateRegular _
                               + " where employeeid='" & txtEmployeeid.Text & "'" : com.ExecuteNonQuery()
        XtraMessageBox.Show("Record successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProfilePic.Validating
        resizesignature()
    End Sub

    Public Sub resizesignature()
        If ProfilePic.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(ProfilePic.Image)
        ProfilePic.Image = Original

        Dim m As Int32 = 400
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        ProfilePic.Image = Thumb
    End Sub


#Region "DEDUCTION SCHEDULE"
    Public Sub LoadScheduleDedType()
        LoadXgridLookupEdit("select code, Description as 'Select' from tblpayrollschedule", "tblpayrollschedule", txtScheduleType, gv_scheduletype, Me)
        gv_scheduletype.Columns("code").Visible = False
    End Sub
    Private Sub txtPayoutSchedule_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScheduleType.EditValueChanged
        On Error Resume Next
        schedulecode.Text = txtScheduleType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadDeductionsSchedule()
        LoadXgrid("select id, (select description from tblpayrolldedaddtype where code =tblpayrolldedaddschedule.dedaddcode) as 'Deduction Type', (select description from tblpayrollschedule where code=tblpayrolldedaddschedule.schedule) as 'Schedule',Amount, fixamount as 'Fix Amount', date_format(startingdate,'%Y-%m-%d') as 'Starting Date', Maturity,if(Maturity=0,'-',datematurity) as 'Date Maturity',if(active=1,'Actived','Inactived')  as 'Status' from tblpayrolldedaddschedule where deduction=1 and employeeid='" & txtEmployeeid.Text & "'", "tblpayrolldedaddschedule", gridDeductions, gv_deduction, Me)
        gv_deduction.Columns("id").Visible = False
        XgridColAlign({"Schedule", "Starting Date", "Date Maturity", "Status"}, gv_deduction, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, gv_deduction)
    End Sub
    Public Sub LoadDeductionTable()
        LoadXgridLookupSearch("select code, description as 'Select' from tblpayrolldedaddtype inner join tblpayrollsettings on deduction =1 and tblpayrolldedaddtype.code not in (tblpayrollsettings.defaultsss,tblpayrollsettings.defaultpagibig,tblpayrollsettings.defaultphilhealth,tblpayrollsettings.defaulttax,tblpayrollsettings.defaultsavings) order by description asc;", "tblpayrolldedaddtype", txtDeductionType, gv_deductionType, Me)
        gv_deductionType.Columns("code").Visible = False
    End Sub
    Private Sub txtDeductionType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeductionType.EditValueChanged
        On Error Resume Next
        scheddedcode.Text = txtDeductionType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        scheddedid.Text = gv_deduction.GetFocusedRowCellValue("id").ToString : scheddedmode.Text = ""
        ShowDeductionSchedInfo() : scheddedmode.Text = "edit"
    End Sub
    Public Sub ShowDeductionSchedInfo()
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code =tblpayrolldedaddschedule.dedaddcode) as 'deductions',(select description from tblpayrollschedule where code=tblpayrolldedaddschedule.schedule) as 'sched' from tblpayrolldedaddschedule where id='" & scheddedid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            scheddedcode.Text = rst("dedaddcode").ToString
            txtDeductionType.Text = rst("deductions").ToString
            schedulecode.Text = rst("schedule").ToString
            txtScheduleType.Text = rst("sched").ToString
            txtSchedDedAmount.Text = rst("amount").ToString
            ckDedFixAmount.Checked = rst("fixamount")
            txtSchedDedStartingDate.EditValue = CDate(rst("startingdate").ToString)
            ckSchedDedMaturity.Checked = rst("maturity")
            txtSchedDedDateMaturity.EditValue = CDate(rst("datematurity").ToString)
        End While
        rst.Close()
    End Sub
    Private Sub cmdDeductionSched_Click(sender As Object, e As EventArgs) Handles cmdDeductionSched.Click
        If txtDeductionType.Text = "" Then
            XtraMessageBox.Show("Please select deduction type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDeductionType.Focus()
            Exit Sub
        ElseIf txtScheduleType.Text = "" Then
            XtraMessageBox.Show("Please select schedule!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtScheduleType.Focus()
            Exit Sub
        ElseIf Val(CC(txtSchedDedAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter proper deduction amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchedDedAmount.Focus()
            Exit Sub
        ElseIf countqry("tblpayrolldedaddschedule", "dedaddcode='" & scheddedcode.Text & "' and id<>'" & scheddedid.Text & "' and employeeid='" & txtEmployeeid.Text & "'") > 0 Then
            XtraMessageBox.Show("Deduction already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDeductionType.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim query As String = "employeeid='" & txtEmployeeid.Text & "', " _
                         + " dedaddcode='" & scheddedcode.Text & "', " _
                         + " deduction=1, " _
                         + " schedule = '" & schedulecode.Text & "', " _
                         + " amount='" & Val(CC(txtSchedDedAmount.Text)) & "', " _
                         + " fixamount='" & ckDedFixAmount.CheckState & "', " _
                         + " startingdate='" & ConvertDate(txtSchedDedStartingDate.EditValue) & "', " _
                         + " maturity='" & ckSchedDedMaturity.CheckState & "', " _
                         + " datematurity='" & ConvertDate(txtSchedDedDateMaturity.EditValue) & "' "

            If scheddedmode.Text = "edit" Then
                com.CommandText = "UPDATE tblpayrolldedaddschedule SET " & query & " where id='" & scheddedid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO tblpayrolldedaddschedule SET " & query & "" : com.ExecuteNonQuery()
            End If
            loadDeductionsSchedule() : scheddedmode.Text = "" : scheddedid.Text = ""
            XtraMessageBox.Show("Deduction successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ckSchedDedMaturity_CheckedChanged(sender As Object, e As EventArgs) Handles ckSchedDedMaturity.CheckedChanged
        If ckSchedDedMaturity.Checked = True Then
            txtSchedDedDateMaturity.Enabled = True
        Else
            txtSchedDedDateMaturity.Enabled = False
        End If
    End Sub

    Private Sub gridDeductions_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridDeductions.MouseDown
        SchedDedMenuFilter()
    End Sub

    Private Sub gridDeductions_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridDeductions.MouseUp
        SchedDedMenuFilter()
    End Sub

    Private Sub gridDeductions_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDeductions.Move
        SchedDedMenuFilter()
    End Sub

    Public Sub SchedDedMenuFilter()
        On Error Resume Next
        If gv_deduction.GetFocusedRowCellValue("Status").ToString = "Actived" Then
            txtScheddedSetActive.Text = "Make Inactive"
        Else
            txtScheddedSetActive.Text = "Make Active"
        End If
    End Sub

    Private Sub txtScheddedSetActive_Click(sender As Object, e As EventArgs) Handles txtScheddedSetActive.Click
        If CheckSelectedRow("Deduction Type", gv_deduction) = True Then
            If gv_deduction.GetFocusedRowCellValue("Status").ToString = "Actived" Then
                com.CommandText = "update tblpayrolldedaddschedule set active=0 where id='" & gv_deduction.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblpayrolldedaddschedule set active=1 where id='" & gv_deduction.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            End If
            loadDeductionsSchedule()
        End If
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        loadDeductionsSchedule()
    End Sub
#End Region

#Region "ADDITIONAL SCHEDULE"

    Public Sub loadAdditionalSchedule()
        LoadXgrid("select id, (select description from tblpayrolldedaddtype where code =tblpayrolldedaddschedule.dedaddcode) as 'Additional Type', (select description from tblpayrollschedule where code=tblpayrolldedaddschedule.schedule) as 'Schedule',Amount, fixamount as 'Fix Amount', date_format(startingdate,'%Y-%m-%d') as 'Starting Date', Maturity,if(Maturity=0,'-',datematurity) as 'Date Maturity',if(active=1,'Actived','Inactived')  as 'Status' from tblpayrolldedaddschedule where deduction=0 and employeeid='" & txtEmployeeid.Text & "'", "tblpayrolldedaddschedule", gridAdditionals, gv_additionals, Me)
        gv_additionals.Columns("id").Visible = False
        XgridColAlign({"Schedule", "Starting Date", "Date Maturity", "Status"}, gv_additionals, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, gv_additionals)
    End Sub
    Public Sub LoadAddtionalTable()
        LoadXgridLookupSearch("select code, description as 'Select' from tblpayrolldedaddtype  where deduction=0 order by description asc;", "tblpayrolldedaddtype", txtAdditionalType, gv_AdditionalType, Me)
        gv_AdditionalType.Columns("code").Visible = False
    End Sub
    Private Sub txtAdditionalType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditionalType.EditValueChanged
        On Error Resume Next
        addtionalcode.Text = txtAdditionalType.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub

    Public Sub LoadScheduleAddType()
        LoadXgridLookupEdit("select code, Description as 'Select' from tblpayrollschedule", "tblpayrollschedule", txtAdditionalSched, gv_additionalSched, Me)
        gv_additionalSched.Columns("code").Visible = False
    End Sub
    Private Sub txtAddScheduleType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditionalSched.EditValueChanged
        On Error Resume Next
        addschedulecode.Text = txtAdditionalSched.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Private Sub cmdAddSchedEdit_Click(sender As Object, e As EventArgs) Handles cmdAddSchedEdit.Click
        addschedid.Text = gv_additionals.GetFocusedRowCellValue("id").ToString : addschedmode.Text = ""
        ShowAdditionalSchedInfo() : addschedmode.Text = "edit"
    End Sub
    Public Sub ShowAdditionalSchedInfo()
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code =tblpayrolldedaddschedule.dedaddcode) as 'additions',(select description from tblpayrollschedule where code=tblpayrolldedaddschedule.schedule) as 'sched' from tblpayrolldedaddschedule where id='" & addschedid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            addtionalcode.Text = rst("dedaddcode").ToString
            txtAdditionalType.Text = rst("additions").ToString
            txtAdditionalSched.Text = rst("sched").ToString
            addschedulecode.Text = rst("schedule").ToString
            txtaddschedAmount.Text = rst("amount").ToString
            ckaddSchedFixAmount.Checked = rst("fixamount")
            txtAddSchedStartDate.EditValue = CDate(rst("startingdate").ToString)
            ckAddSchedMaturity.Checked = rst("maturity")
            txtAddSchedDateMaturity.EditValue = CDate(rst("datematurity").ToString)
        End While
        rst.Close()
    End Sub
    Private Sub cmdAdditionalSched_Click(sender As Object, e As EventArgs) Handles cmdAdditionalSched.Click
        If txtAdditionalType.Text = "" Then
            XtraMessageBox.Show("Please select addional type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdditionalType.Focus()
            Exit Sub
        ElseIf txtAdditionalSched.Text = "" Then
            XtraMessageBox.Show("Please select schedule!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdditionalSched.Focus()
            Exit Sub
        ElseIf Val(CC(txtaddschedAmount.Text)) <= 0 Then
            XtraMessageBox.Show("Please enter proper additional amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtaddschedAmount.Focus()
            Exit Sub
        ElseIf countqry("tblpayrolldedaddschedule", "dedaddcode='" & addtionalcode.Text & "' and id<>'" & addschedid.Text & "' and employeeid='" & txtEmployeeid.Text & "'") > 0 Then
            XtraMessageBox.Show("Additional already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdditionalType.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim query As String = "employeeid='" & txtEmployeeid.Text & "', " _
                         + " dedaddcode='" & addtionalcode.Text & "', " _
                         + " deduction=0, " _
                         + " schedule = '" & addschedulecode.Text & "', " _
                         + " amount='" & Val(CC(txtaddschedAmount.Text)) & "', " _
                         + " fixamount='" & ckaddSchedFixAmount.CheckState & "', " _
                         + " startingdate='" & ConvertDate(txtAddSchedStartDate.EditValue) & "', " _
                         + " maturity='" & ckAddSchedMaturity.CheckState & "', " _
                         + " datematurity='" & ConvertDate(txtAddSchedDateMaturity.EditValue) & "' "

            If addschedmode.Text = "edit" Then
                com.CommandText = "UPDATE tblpayrolldedaddschedule SET " & query & " where id='" & addschedid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO tblpayrolldedaddschedule SET " & query & "" : com.ExecuteNonQuery()
            End If
            loadAdditionalSchedule() : addschedmode.Text = "" : addschedid.Text = ""
            XtraMessageBox.Show("Additinal successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ckAddSchedMaturity_CheckedChanged(sender As Object, e As EventArgs) Handles ckAddSchedMaturity.CheckedChanged
        If ckAddSchedMaturity.Checked = True Then
            txtAddSchedDateMaturity.Enabled = True
        Else
            txtAddSchedDateMaturity.Enabled = False
        End If
    End Sub

    Private Sub gridAdditionals_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridAdditionals.MouseDown
        SchedAddMenuFilter()
    End Sub

    Private Sub gridAdditionals_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridAdditionals.MouseUp
        SchedAddMenuFilter()
    End Sub

    Private Sub gridAdditionals_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAdditionals.Move
        SchedAddMenuFilter()
    End Sub

    Public Sub SchedAddMenuFilter()
        On Error Resume Next
        If gv_additionals.GetFocusedRowCellValue("Status").ToString = "Actived" Then
            txtSchedAddSetActive.Text = "Make Inactive"
        Else
            txtSchedAddSetActive.Text = "Make Active"
        End If
    End Sub

    Private Sub txtSchedAddSetActive_Click(sender As Object, e As EventArgs) Handles txtSchedAddSetActive.Click
        If CheckSelectedRow("Additional Type", gv_additionals) = True Then
            If gv_additionals.GetFocusedRowCellValue("Status").ToString = "Actived" Then
                com.CommandText = "update tblpayrolldedaddschedule set active=0 where id='" & gv_additionals.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblpayrolldedaddschedule set active=1 where id='" & gv_additionals.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            End If
            loadAdditionalSchedule()
        End If
    End Sub
    Private Sub cmdAddrefresh_Click(sender As Object, e As EventArgs) Handles cmdAddrefresh.Click
        loadAdditionalSchedule()
    End Sub
#End Region

End Class