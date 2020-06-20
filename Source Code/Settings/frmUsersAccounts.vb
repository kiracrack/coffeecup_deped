Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmUsersAccounts

    Private gridsel As String = ""
    Private cpass As Boolean = False
    Private gridid As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()

        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If

        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub frmUsersAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridkb)
        LoadGridviewAppearance(txtofficeView)
        LoadGridviewAppearance(gv_permission)
        LoadGridviewAppearance(gv_clientUserPosition)
        txtuserid.Text = getuserid()
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        loadOffice()
        filteruser()

        If compkb = "1" Then
            com.CommandText = "CREATE TABLE IF NOT EXISTS `tblkbemployees` (  `Number` int(10) unsigned NOT NULL AUTO_INCREMENT,  `emp_id` varchar(20) CHARACTER SET latin1 NOT NULL,  `fullname` varchar(102) CHARACTER SET latin1 DEFAULT NULL,  `com_company` varchar(50) CHARACTER SET latin1 DEFAULT NULL,  `com_branch` varchar(50) CHARACTER SET latin1 DEFAULT NULL,  `com_department` varchar(50) CHARACTER SET latin1 DEFAULT NULL,  `com_position` varchar(50) CHARACTER SET latin1 DEFAULT NULL,  PRIMARY KEY (`Number`)) ENGINE=InnoDB AUTO_INCREMENT=1024 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
            LoadKBEmployees()
            txtfullname.Visible = False
            txtKBemployee.Visible = True
            'txtdesignation.Properties.ReadOnly = True
            'txtoffice.Properties.ReadOnly = True
            txtusername.Properties.ReadOnly = True
            BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else

            txtfullname.Visible = True
            txtKBemployee.Visible = False
            'txtdesignation.Properties.ReadOnly = False
            'txtoffice.Properties.ReadOnly = False
            txtusername.Properties.ReadOnly = False
            BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If globalEmailNotification = True Then
            cmdEmailNotification.Visible = True
        Else
            cmdEmailNotification.Visible = False
        End If
        LoadPermission()
        loadUserPosition()
        lblOffie.Text = GlobalOfficeCaption
        VerifyPermission()
    End Sub
    Public Sub loadUserPosition()
        LoadXgridLookupSearch("select authcode, authDescription as 'Position' from tbluserauthority order by authDescription asc", "tbluserauthority", txtClientPermission, gv_clientUserPosition, Me)
        gv_clientUserPosition.Columns("authcode").Visible = False
    End Sub

    Private Sub txtUserPosition_EditValueChanged(sender As Object, e As EventArgs) Handles txtClientPermission.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtClientPermission.Properties.View.FocusedRowHandle.ToString)
        authCode.Text = txtClientPermission.Properties.View.GetFocusedRowCellValue("authcode").ToString()
    End Sub
    Public Sub VerifyPermission()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSaveButton.Visible = True
        Else
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSaveButton.Visible = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
            cmdRemovePermission.Visible = True
        Else
            cmdEdit.Visible = False
            cmdRemovePermission.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        If globalAllowAdd = True Or globalAllowEdit = True Or globalAllowDelete = True Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
    End Sub
    Public Sub LoadPermission()
        LoadXgridLookupSearch("SELECT percode,permission as 'Select Permission' from tblpermissions order by permission asc", "tblpermissions", txtServerPermission, gv_permission, Me)
        gv_permission.Columns("percode").Visible = False
    End Sub
    Private Sub txtpermission_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerPermission.EditValueChanged
        On Error Resume Next
        percode.Text = txtServerPermission.Properties.View.GetFocusedRowCellValue("percode").ToString()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Public Sub LoadKBEmployees()
        LoadXgridLookupSearch("select distinct(emp_id), emp_id as 'Employee ID', Fullname, com_position as 'Designation',com_branch as '" & GlobalOfficeCaption & "'  from tblkbemployees " _
                                                + " left join tblcompoffice on tblcompoffice.officename like CONCAT('%',tblkbemployees.com_branch,'%') " _
                                                + " order by fullname", "tblkbemployees", txtKBemployee, gridkb, Me)
        gridkb.Columns("Employee ID").Visible = False
        gridkb.Columns("emp_id").Visible = False
        gridkb.Columns("Designation").Visible = False
    End Sub
    Private Sub txtKBEmployees_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKBemployee.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtKBemployee.Properties.View.FocusedRowHandle.ToString)
        kbid.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue("Employee ID").ToString()
        txtusername.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue("Employee ID").ToString()
        txtKBemployee.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
        txtfullname.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
        txtdesignation.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue("Designation").ToString()
        txtoffice.Text = txtKBemployee.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString()
    End Sub

    Public Sub loadOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtoffice, txtofficeView, Me)
        txtofficeView.Columns("officeid").Visible = False
    End Sub
    Private Sub txtoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        filteruser()
        clearaccount()
    End Sub
    Public Sub filteruser()
        Dim gladmin As String = ""
        If LCase(globaluser) = "root" Then
            gladmin = " where deleted=0 "
        Else
            gladmin = " where username<>'ROOT' and deleted=0 "
        End If
        LoadXgrid("Select accountid as 'Account ID'," _
                                    + " username as 'Username'," _
                                    + " fullname as 'Fullname', " _
                                    + " designation as 'Position', " _
                                    + " (select officename from tblcompoffice where officeid = tblaccounts.officeid) as '" & GlobalOfficeCaption & "', " _
                                    + " emailaddress as 'Email Address'," _
                                    + " ifnull((select permission from tblpermissions where percode=tblaccounts.permission),'')  as 'Server Permission', " _
                                    + " coffeecupuser as 'Client User', (select authDescription from tbluserauthority where authcode = tblaccounts.coffeecupposition) as 'Client Permission', " _
                                    + " date_format(datereg, '%Y-%m-%d %r') as 'Registered' " _
                                    + " from tblaccounts " & gladmin _
                                    + " order by fullname asc", "tblaccounts", Em, GridView1, Me)

        XgridColAlign({"Account ID", "Username", "Client User"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridHideColumn({"Client User"}, GridView1)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveMenu.ItemClick
        If txtfullname.Text = "" Then
            XtraMessageBox.Show("Please enter fullname!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtdesignation.Text = "" Then
            XtraMessageBox.Show("Please select designation!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtoffice.Text = "" Then
            XtraMessageBox.Show("Please Select " & GlobalOfficeCaption & "!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            XtraMessageBox.Show("Please enter username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "fullname = '" & txtfullname.Text & "'") <> 0 And mode.Text = "" Then
            XtraMessageBox.Show("Account name already exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        End If

        Dim passqry As String = ""
        If mode.Text = "edit" Then
            If cpass = True Then
                If txtpassword.Text = "" Then
                    XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword.Focus()
                    Exit Sub
                ElseIf txtverify.Text = "" Then
                    XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtverify.Focus()
                    Exit Sub
                ElseIf txtpassword.Text <> txtverify.Text Then
                    XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword.Text = ""
                    txtverify.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                End If
                passqry = " password='" & EncryptTripleDES(UCase(txtusername.Text) + txtverify.Text) & "', webpassword=DES_ENCRYPT('" & txtusername.Text + txtverify.Text & "','kira'),"
            Else
                passqry = ""
            End If
            If XtraMessageBox.Show("Are you sure you want update user account of " & txtfullname.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblaccounts set fullname = '" & txtfullname.Text & "', " _
                                 + " designation='" & txtdesignation.Text & "', " _
                                 + " officeid='" & officeid.Text & "', " _
                                 + " emailaddress = '" & txtEmail.Text & "', " _
                                 + " username='" & txtusername.Text & "', " _
                                 + passqry _
                                 + " permission = '" & percode.Text & "',coffeecupuser=" & ckClientUser.CheckState & ",coffeecupposition='" & authCode.Text & "' where accountid='" & txtuserid.Text & "' "
            Else
                Exit Sub
            End If
        Else
            If txtpassword.Text = "" Then
                XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Focus()
                Exit Sub
            ElseIf txtverify.Text = "" Then
                XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtverify.Focus()
                Exit Sub
            ElseIf txtpassword.Text <> txtverify.Text Then
                XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Text = ""
                txtverify.Text = ""
                txtpassword.Focus()
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want create user account of " & txtfullname.Text & " ? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "insert into tblaccounts set accountid='" & txtuserid.Text & "', fullname = '" & txtfullname.Text & "', " _
                                                + " designation='" & txtdesignation.Text & "', " _
                                                + " officeid='" & officeid.Text & "', " _
                                                + " username='" & txtusername.Text & "', " _
                                                + " password='" & EncryptTripleDES(UCase(txtusername.Text) + txtverify.Text) & "', " _
                                                + " webpassword=DES_ENCRYPT('" & txtusername.Text + txtverify.Text & "','kira'), " _
                                                + " emailaddress = '" & txtEmail.Text & "', " _
                                                + " permission = '" & percode.Text & "',coffeecupuser=" & ckClientUser.CheckState & ",coffeecupposition='" & authCode.Text & "', datereg='" & GlobalDateTime() & "'"
            Else
                Exit Sub
            End If
        End If
        com.ExecuteNonQuery()
        If ckClientUser.Checked = True Then
            com.CommandText = "update tblaccountaccess set defaultaccess=0 where userid='" & txtuserid.Text & "'" : com.ExecuteNonQuery()
            If countqry("tblaccountaccess", "userid='" & txtuserid.Text & "' and permission='" & authCode.Text & "'") > 0 Then
                com.CommandText = "update tblaccountaccess set defaultaccess=1 where userid='" & txtuserid.Text & "' and permission='" & authCode.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblaccountaccess set userid='" & txtuserid.Text & "', permission='" & authCode.Text & "',defaultaccess=1" : com.ExecuteNonQuery()
            End If
        End If
        UpdateImage("accountid='" & txtuserid.Text & "'", "digitalsign", "tblaccounts", signature, Me)
        txtuserid.Text = getuserid()
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        loadOffice()
        filteruser()

        If compkb = "1" Then
            LoadKBEmployees()
            txtfullname.Visible = False
            txtKBemployee.Visible = True
            'txtdesignation.Properties.ReadOnly = True
            'txtoffice.Properties.ReadOnly = True
            txtusername.Properties.ReadOnly = True
            BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else

            txtfullname.Visible = True
            txtKBemployee.Visible = False
            'txtdesignation.Properties.ReadOnly = False
            'txtoffice.Properties.ReadOnly = False
            txtusername.Properties.ReadOnly = False
            BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        lblOffie.Text = GlobalOfficeCaption
        clearaccount()
        VerifyPermission()
        LoadPermission()
        XtraMessageBox.Show("User successfully save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        cpass = False

    End Sub
    Public Sub clearaccount()

        txtKBemployee.Properties.DataSource = Nothing
        txtKBemployee.Text = ""

        txtfullname.Text = ""
        txtusername.Text = ""
        txtoffice.Text = ""
        txtpassword.Text = ""
        txtverify.Text = ""
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1

        txtoffice.Properties.DataSource = Nothing
        txtoffice.Text = ""
        officeid.Text = ""
        loadOffice()
        txtuserid.Text = getuserid()

        txtServerPermission.Properties.DataSource = Nothing
        txtServerPermission.Text = ""
        percode.Text = ""

        'CheckEdit1.Enabled = False
        txtClientPermission.Properties.DataSource = Nothing
        txtClientPermission.Text = ""
        authCode.Text = ""
        loadUserPosition()

        mode.Text = ""
        signature.Image = Nothing

        cpass = False
        txtpassword.Properties.ReadOnly = False
        txtverify.Properties.ReadOnly = False

        If compkb = "1" Then
            LoadKBEmployees()
            txtfullname.Visible = False
            txtKBemployee.Visible = True
            txtdesignation.Properties.ReadOnly = True
            'txtoffice.Properties.ReadOnly = True
            txtusername.Properties.ReadOnly = True

        Else

            txtfullname.Visible = True
            txtKBemployee.Visible = False
            txtdesignation.Properties.ReadOnly = False
            'txtoffice.Properties.ReadOnly = False
            txtusername.Properties.ReadOnly = False
        End If
        If mode.Text = "edit" Then
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSaveButton.Visible = True
        Else
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSaveButton.Visible = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing
        cpass = False
        txtpassword.Properties.ReadOnly = True
        txtverify.Properties.ReadOnly = True
        txtfullname.Visible = True
        txtKBemployee.Visible = False
        txtdesignation.Properties.ReadOnly = False
        txtoffice.Properties.ReadOnly = False
        txtusername.Properties.ReadOnly = False
        Dim tempoffice As String = "" : Dim tempUserPosition As String = "" : Dim tempEnableClientUser As Boolean = False
        com.CommandText = "select * from tblaccounts where accountid='" & gridid & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtuserid.Text = rst("accountid").ToString
            txtfullname.Text = rst("fullname").ToString
            txtoffice.Text = rst("officeid").ToString
            txtdesignation.Text = rst("designation").ToString
            txtusername.Text = rst("username").ToString
            txtEmail.Text = rst("emailaddress").ToString
            percode.Text = rst("permission").ToString
            officeid.Text = rst("officeid").ToString
            tempoffice = rst("officeid").ToString
            tempEnableClientUser = rst("coffeecupuser")
            authCode.Text = rst("coffeecupposition").ToString
            txtServerPermission.Text = rst("permission").ToString
            txtClientPermission.EditValue = rst("coffeecupposition").ToString
            If rst("digitalsign").ToString <> "" Then
                imgBytes = CType(rst("digitalsign"), Byte())
                'Read the byte array into a MemoryStream
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)

                'Create the new Image from the stream
                img = Image.FromStream(stream)

                'Now add the image to the table
                signature.Image = img
            End If

        End While
        rst.Close()
        txtoffice.Text = tempoffice
        ckClientUser.Checked = tempEnableClientUser

        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
        If mode.Text = "edit" Then
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdSaveButton.Visible = True
        Else
            cmdSaveMenu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSaveButton.Visible = False
        End If
    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles signature.Validating
        resizesignature()
    End Sub
    Public Sub resizesignature()
        If signature.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(signature.Image)
        signature.Image = Original

        Dim m As Int32 = 200
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        signature.Image = Thumb
    End Sub
    Public Sub getcolidpack()
        On Error Resume Next
        Dim Rows() As DataRow : Dim I As Integer
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        For I = 0 To GridView1.SelectedRowsCount - 1
            gridid = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID")
        Next
    End Sub

    Private Sub packgrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        getcolidpack()
    End Sub

    Private Sub packgrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        getcolidpack()
    End Sub
    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        frmChangePassword.userid.Text = GridView1.GetFocusedRowCellValue("Account ID").ToString()
        frmChangePassword.txtFullname.Text = GridView1.GetFocusedRowCellValue("Username").ToString()
        frmChangePassword.Show(Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        clearaccount()
        VerifyPermission()
        LoadPermission()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmPrmtEmployees.Show(Me)
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        cmdSaveMenu.PerformClick()
    End Sub

    Private Sub RemoveUserPermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRemovePermission.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove user account permission of " & GridView1.GetFocusedRowCellValue("Fullname").ToString() & " ? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblaccounts set permission=null where accountid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID") & "' " : com.ExecuteNonQuery()
            Next

            filteruser()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckClientUser.CheckedChanged
        If ckClientUser.Checked = True Then
            txtClientPermission.Enabled = True
        Else
            txtClientPermission.Properties.DataSource = Nothing
            txtClientPermission.Text = ""
            authCode.Text = ""
            loadUserPosition()
            txtClientPermission.Enabled = False
        End If
    End Sub

    Private Sub UserAccountAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccountAccessToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("Client User").ToString()) = False Then
            XtraMessageBox.Show("Please activate coffeecup client user to continue this process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmCoffeecupClientAccess.userid.Text = GridView1.GetFocusedRowCellValue("Account ID").ToString()
        frmCoffeecupClientAccess.Text = "Access for " & GridView1.GetFocusedRowCellValue("Fullname").ToString()
        frmCoffeecupClientAccess.Show(Me)
    End Sub

    'Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
    '    frmEmployeeInformation.linkedAccount.Text = GridView1.GetFocusedRowCellValue("Account ID").ToString()
    '    frmEmployeeInformation.Show(Me)
    'End Sub

    Private Sub cmdEmailNotification_Click(sender As Object, e As EventArgs) Handles cmdEmailNotification.Click
        If GridView1.GetFocusedRowCellValue("Email Address").ToString() = "" Then
            XtraMessageBox.Show("Please update email address first!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmUsersAccountEmailNotification.txtFullname.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString()
        frmUsersAccountEmailNotification.accountid.Text = GridView1.GetFocusedRowCellValue("Account ID").ToString()
        frmUsersAccountEmailNotification.ShowDialog(Me)
    End Sub

    Private Sub DeleteAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountsToolStripMenuItem.Click
        frmBlockedAccounts.Show(Me)
    End Sub

    Public Function BlockedAccounts(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblaccounts set deleted=1, datedeleted=current_timestamp, deletedby='" & globalfullname & "',deletedreason='" & rchar(reason) & "' where accountid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID") & "' " : com.ExecuteNonQuery()
            If countqry("tblinventoryffe", "acctablepersonid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID") & "' and disposed=0") > 0 Then
                com.CommandText = "UPDATE tblinventoryffe set flaged=1, flagedreason='Accountability status changed! " & LCase(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Fullname")) & " was " & reason & "' where acctablepersonid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID") & "'" : com.ExecuteNonQuery()
            End If
        Next
        filteruser()
        XtraMessageBox.Show("Selected Accounts successfully blocked or Removed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function
End Class