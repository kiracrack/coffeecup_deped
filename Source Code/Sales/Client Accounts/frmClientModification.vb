Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmClientModification
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub clearfields()
        id.Text = getClientid()
        txtCompanyName.Text = ""
        txtadd.Text = ""
        txttell.Text = ""
        mode.Text = ""
    End Sub
    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If mode.Text <> "edit" Then
                If txtCompanyName.Text = "" Then
                    XtraMessageBox.Show("Please enter company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCompanyName.Focus()
                    Exit Sub
                ElseIf countqry("tblclientaccounts", "companyname='" & txtCompanyName.Text & "' and COMPADD='" & StrConv(txtadd.Text, vbProperCase) & "'") <> 0 Then
                    XtraMessageBox.Show("Client already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCompanyName.Focus()
                    Exit Sub
                ElseIf txtadd.Text = "" Then
                    XtraMessageBox.Show("Please enter complete address!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtadd.Focus()
                    Exit Sub
                ElseIf txttell.Text = "" Then
                    XtraMessageBox.Show("Please enter contact number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txttell.Focus()
                    Exit Sub
                End If
                If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    com.CommandText = "insert into tblclientaccounts set cifid='" & id.Text & "',accountfilter='" & filtercode.Text & "',groupcode='" & groupcode.Text & "', COMPANYNAME='" & txtCompanyName.Text & "', COMPADD='" & StrConv(txtadd.Text, vbProperCase) & "', TELEPHONE='" & txttell.Text & "', " & If(CDate(txtBirthdate.EditValue).ToShortDateString = CDate(Now.ToShortDateString), "", " birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ") & " emailadd='" & txtEmail.Text & "',  entryby='" & globaluserid & "',dateentered=current_timestamp,enabledue=" & ckClientDue.CheckState & ",duetype='" & txtDueType.Text & "',duevalue='" & txtDueValue.Text & "', creditlimit=" & ckCrditLimit.CheckState & ", creditlimitamount='" & Val(CC(txtCreditLimit.Text)) & "',skipdiscount=" & ckSkipDiscount.CheckState & ", approved=1, approvedby='" & globaluserid & "',vip='" & ckvip.CheckState & "', vipguestid='" & guestid.Text & "' " : com.ExecuteNonQuery()
                    XtraMessageBox.Show("Client Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Sub
                End If
            Else
                If txtCompanyName.Text = "" Then
                    XtraMessageBox.Show("Please enter company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCompanyName.Focus()
                    Exit Sub
                ElseIf countqry("tblclientaccounts", "companyname='" & txtCompanyName.Text & "' and cifid<>'" & id.Text & "'") <> 0 Then
                    XtraMessageBox.Show("Client already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCompanyName.Focus()
                    Exit Sub
                ElseIf txtadd.Text = "" Then
                    XtraMessageBox.Show("Please enter complete address!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtadd.Focus()
                    Exit Sub
                ElseIf txttell.Text = "" Then
                    XtraMessageBox.Show("Please enter contact number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txttell.Focus()
                    Exit Sub
                End If
                If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    com.CommandText = "update tblclientaccounts set  accountfilter='" & filtercode.Text & "',groupcode='" & groupcode.Text & "', COMPANYNAME='" & txtCompanyName.Text & "', COMPADD='" & StrConv(txtadd.Text, vbProperCase) & "', TELEPHONE='" & txttell.Text & "', " & If(CDate(txtBirthdate.EditValue).ToShortDateString = CDate(Now.ToShortDateString), "", " birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', ") & " emailadd='" & txtEmail.Text & "', entryby='" & globaluserid & "',dateentered=current_timestamp,enabledue=" & ckClientDue.CheckState & ",duetype='" & txtDueType.Text & "',duevalue='" & txtDueValue.Text & "', creditlimit=" & ckCrditLimit.CheckState & ", creditlimitamount='" & Val(CC(txtCreditLimit.Text)) & "',skipdiscount=" & ckSkipDiscount.CheckState & ",vip='" & ckvip.CheckState & "', vipguestid='" & guestid.Text & "' where cifid='" & id.Text & "'" : com.ExecuteNonQuery()
                    XtraMessageBox.Show("Client Successfully Updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Sub
                End If
            End If

            clearfields()
            frmClientManagement.filterClient()
            Me.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Try
            com.CommandText = "select *, (select description from tblclientfiltersettings where code = tblclientaccounts.accountfilter) as 'acctfilter'," _
                                + " (select groupname from tblclientgroup where groupcode = tblclientaccounts.groupcode) as 'acctgroup', " _
                                + " (select fullname from tblhotelguest where guestid=tblclientaccounts.vipguestid) as guest " _
                                + " from tblclientaccounts where cifid='" & id.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtCompanyName.Text = rst("COMPANYNAME").ToString
                txtadd.Text = rst("COMPADD").ToString
                txttell.Text = rst("TELEPHONE").ToString

                If rst("birthdate").ToString <> "" Then
                    txtBirthdate.EditValue = rst("birthdate").ToString
                End If
                txtEmail.Text = rst("emailadd").ToString

                txtClientFilter.Text = rst("acctfilter").ToString
                filtercode.Text = rst("accountfilter").ToString

                txtClientGroup.Text = rst("acctgroup").ToString
                groupcode.Text = rst("groupcode").ToString

                ckClientDue.Checked = rst("enabledue")
                txtDueType.Text = rst("duetype").ToString
                txtDueValue.Text = rst("duevalue").ToString

                ckCrditLimit.Checked = rst("creditlimit")
                txtCreditLimit.Text = rst("creditlimitamount").ToString
                ckvip.Checked = rst("vip")
                txtVIPGuest.Text = rst("guest").ToString
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmClientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtBirthdate.EditValue = CDate(Now.ToShortDateString)
        If mode.Text = "" Then
            id.Text = getClientid()
        End If
        LoadVIPGuest()
        LoadClientFilter()
        LoadClientGroup()
    End Sub

    Public Sub LoadVIPGuest()
        LoadXgridLookupSearch("SELECT guestid, fullname as 'Guest Name' from tblhotelguest where vipguest=1 order by fullname asc", "tblhotelguest", txtVIPGuest, gvVipGuest, Me)
        gvVipGuest.Columns("guestid").Visible = False
    End Sub
    Private Sub txtVIPGuest_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVIPGuest.EditValueChanged
        On Error Resume Next
        guestid.Text = txtVIPGuest.Properties.View.GetFocusedRowCellValue("guestid").ToString()
    End Sub
    Public Sub LoadClientFilter()
        LoadXgridLookupSearch("SELECT code, Description from tblclientfiltersettings order by description asc", "tblclientfiltersettings", txtClientFilter, grid_clientFilter, Me)
        grid_clientFilter.Columns("code").Visible = False
    End Sub

    Private Sub txtClientFilter_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientFilter.EditValueChanged
        On Error Resume Next
        filtercode.Text = txtClientFilter.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Public Sub LoadClientGroup()
        LoadXgridLookupSearch("SELECT groupcode,groupname as 'Group Name' from tblclientgroup  order by groupname asc", "tblclientgroup", txtClientGroup, grid_clientGroup, Me)
        grid_clientGroup.Columns("groupcode").Visible = False
    End Sub

    Private Sub txtClientGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientGroup.EditValueChanged
        On Error Resume Next
        groupcode.Text = txtClientGroup.Properties.View.GetFocusedRowCellValue("groupcode").ToString()
    End Sub
 
    Private Sub ckWalkin_CheckedChanged(sender As Object, e As EventArgs)
        If ckWalkin.Checked = True Then
            ckClientDue.Checked = False
            ckClientDue.Enabled = False
        Else
            ckClientDue.Enabled = True
        End If
    End Sub
    Private Sub txtDueType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDueType.SelectedValueChanged
        If txtDueType.Text = "DAYS" Then
            lblduetpe.Text = "Days Interval"
        ElseIf txtDueType.Text = "WEEK" Then
            lblduetpe.Text = "Day of Week"
        ElseIf txtDueType.Text = "MONTH" Then
            lblduetpe.Text = "Day of Month"
        End If
    End Sub

    Private Sub ckClientDue_CheckedChanged(sender As Object, e As EventArgs) Handles ckClientDue.CheckedChanged
        If ckClientDue.Checked = True Then
            txtDueType.Enabled = True
            txtDueValue.Enabled = True
        Else
            txtDueType.Enabled = False
            txtDueValue.Enabled = False
            txtDueType.SelectedIndex = -1
            txtDueValue.Text = "0"
        End If
    End Sub

    Private Sub ckCrditLimit_CheckedChanged(sender As Object, e As EventArgs) Handles ckCrditLimit.CheckedChanged
        If ckCrditLimit.Checked = True Then
            txtCreditLimit.Properties.ReadOnly = False
        Else
            txtCreditLimit.Properties.ReadOnly = True
            txtCreditLimit.Text = "0"
        End If
    End Sub
 
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        XtraMessageBox.Show("Focus on vip text area and swipe card! or leave blank if not necessary.", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
 
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckvip.CheckedChanged
        If ckvip.Checked = True Then
            txtVIPGuest.Enabled = True
        Else
            txtVIPGuest.Enabled = False
            guestid.Text = ""
        End If
    End Sub
End Class