Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmCompOfficeInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtInitialCode.Text = "" Then
            XtraMessageBox.Show("Please provide " & GlobalOfficeCaption & " Initial Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInitialCode.Focus()
            Exit Sub
        ElseIf txtShortName.Text = "" Then
            XtraMessageBox.Show("Please provide " & GlobalOfficeCaption & " short name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtShortName.Focus()
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            XtraMessageBox.Show("Please provide " & GlobalOfficeCaption & " Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
       
        End If
 
        If mode.Text <> "edit" Then
            If countqry("tblcompoffice", "officeid='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate office ID! Please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            
            ElseIf countqry("tblcompoffice", "officename='" & txtCompanyName.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate " & GlobalOfficeCaption & " Name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            ElseIf countqry("tblcompoffice", "shortname='" & txtShortName.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate " & GlobalOfficeCaption & " short name! please use unique one.", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtShortName.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblcompoffice set companyid='" & companyid.Text & "', officeid='" & id.Text & "', initialcode='" & rchar(Trim(txtInitialCode.Text)) & "', officename='" & txtCompanyName.Text & "',shortname='" & rchar(Trim(txtShortName.Text)) & "',address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "',corporateoffice=" & ckTagCorporateOffice.CheckState & ", allowbeggininginventory=" & ckManual.CheckState & ",allowmanualconsumableinventory=" & ckAllowManageConsumableOtherOffice.CheckState & ", allowmanualffeinventory=" & ckManualFFE.CheckState & ", custombranchapproval=" & ckBranchApproval.CheckState & ",customcorporateapproval=" & ckCorporateApproval.CheckState & ",ishotel='" & ckHotel.CheckState & "',enableoperation=" & ckENableOperation.CheckState & ",allowmanageffeotheroffice=" & ckAllowManageFFeOtherOffice.CheckState & ",allowcreaterequestforotheroffice=" & ckAllowCreateRequestOtherOffice.CheckState & ", enableinventory=" & ckEnableInventory.CheckState & ",allowreceivedpurchases=" & ckAllowReceivedPurchases.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblcompoffice set companyid='" & companyid.Text & "', initialcode='" & rchar(Trim(txtInitialCode.Text)) & "', officename='" & txtCompanyName.Text & "',shortname='" & rchar(Trim(txtShortName.Text)) & "', address='" & rchar(txtAddress.Text) & "', contactnumber='" & txtContactNumber.Text & "', officeemail='" & txtEmailAddress.Text & "',officerid='" & userid.Text & "',corporateoffice=" & ckTagCorporateOffice.CheckState & ", allowbeggininginventory=" & ckManual.CheckState & ",allowmanualconsumableinventory=" & ckAllowManageConsumableOtherOffice.CheckState & ", allowmanualffeinventory=" & ckManualFFE.CheckState & ", custombranchapproval=" & ckBranchApproval.CheckState & ",customcorporateapproval=" & ckCorporateApproval.CheckState & ",ishotel='" & ckHotel.CheckState & "',enableoperation=" & ckENableOperation.CheckState & ",allowmanageffeotheroffice=" & ckAllowManageFFeOtherOffice.CheckState & ",allowcreaterequestforotheroffice=" & ckAllowCreateRequestOtherOffice.CheckState & ", enableinventory=" & ckEnableInventory.CheckState & ",allowreceivedpurchases=" & ckAllowReceivedPurchases.CheckState & " where officeid='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
       
        clearfields()
        frmCompOffice.filter()
        XtraMessageBox.Show("Office successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim GlobalNumberOfDevision As Integer = 0
        Dim m_procurement As String = ""
        Dim InfoFile As String = ""
        If System.IO.File.Exists(Application.StartupPath.ToString & "\System.config") Then
            If System.IO.File.Exists(System_config) Then
                InfoFile = DecryptTripleDES(ReadFile(System_config))
                For Each strLine As String In InfoFile.Split(vbCrLf)
                    Dim word As String() = strLine.Split("=")
                    If word(0) = "division" Then
                        GlobalNumberOfDevision = word(1)
                    End If
                Next
            End If
        Else
            GlobalNumberOfDevision = 1
        End If
        If GlobalNumberOfDevision > 0 Then
            If countrecord("tblcompoffice") >= GlobalNumberOfDevision Then
                Me.Close()
            End If
        End If
    End Sub
    Public Sub LoadCompany()
        LoadXgridLookupSearch("select Code, Companyname as Company from tblcompany", "tblcompany", txtCompany, gvCompany, Me)
        XgridColAlign({"Code"}, gvCompany, Utils.HorzAlignment.Center)
        gvCompany.Columns("Code").Width = 70
    End Sub

    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCompany.Properties.View.FocusedRowHandle.ToString)
        companyid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("Code").ToString()
    End Sub

    Public Sub loadOfficer()
        LoadXgridLookupSearch("select accountid, Fullname from tblaccounts where username<>'ROOT'", "tblaccounts", txtOfficerIncharge, s_grid, Me)
        s_grid.Columns("accountid").Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOfficerIncharge.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOfficerIncharge.Properties.View.FocusedRowHandle.ToString)
        userid.Text = txtOfficerIncharge.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        txtOfficerIncharge.Text = txtOfficerIncharge.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub

    Public Sub clearfields()
        id.Text = getofficeid()
        txtInitialCode.Text = ""
        txtShortName.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
        txtOfficerIncharge.Properties.DataSource = Nothing
        txtOfficerIncharge.Text = ""
        loadOfficer()
        ckTagCorporateOffice.Checked = False
        ckManual.Checked = False
        ckManualFFE.Checked = False
        ckAllowManageConsumableOtherOffice.Checked = False
        ckBranchApproval.Checked = False
        ckCorporateApproval.Checked = False
        ckAllowManageConsumableOtherOffice.Checked = False
        ckAllowManageFFeOtherOffice.Checked = False
        ckAllowCreateRequestOtherOffice.Checked = False
        ckEnableInventory.Checked = False
        ckAllowReceivedPurchases.Checked = False
        userid.Text = ""
        mode.Text = ""
       
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select *,(select companyname from tblcompany where code=tblcompoffice.companyid) as company,(select fullname from tblaccounts where accountid = tblcompoffice.officerid) as 'officer' from tblcompoffice where officeid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            companyid.Text = rst("companyid").ToString
            txtCompany.Text = rst("company").ToString
            txtInitialCode.Text = rst("initialcode").ToString
            txtShortName.Text = rst("shortname").ToString
            txtCompanyName.Text = rst("officename").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmailAddress.Text = rst("officeemail").ToString
            txtOfficerIncharge.Text = rst("officer").ToString
            ckTagCorporateOffice.Checked = rst("corporateoffice")
            userid.Text = rst("officerid").ToString
            ckManual.Checked = rst("allowbeggininginventory")
            ckManualFFE.Checked = rst("allowmanualffeinventory")
            ckAllowCreateRequestOtherOffice.Checked = rst("allowcreaterequestforotheroffice")
            ckBranchApproval.Checked = rst("custombranchapproval")
            ckCorporateApproval.Checked = rst("customcorporateapproval")
            ckHotel.Checked = rst("ishotel")
            ckENableOperation.Checked = rst("enableoperation")
            ckAllowManageConsumableOtherOffice.Checked = rst("allowmanualconsumableinventory")
            ckAllowManageFFeOtherOffice.Checked = rst("allowmanageffeotheroffice")
            ckEnableInventory.Checked = rst("enableinventory")
            ckAllowReceivedPurchases.Checked = rst("allowreceivedpurchases")
        End While
        rst.Close()
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(s_grid)
        LoadCompany()
        loadOfficer()
        Me.Text = GlobalOfficeCaption & " Entries"
        lbloffice.Text = GlobalOfficeCaption & " Name*"
        lblOfficeid.Text = GlobalOfficeCaption & " Code*"
        cmdSave.Text = "Save " & GlobalOfficeCaption

        If mode.Text <> "edit" Then
            id.Text = getofficeid()
        End If

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Enabled = True
        Else
            cmdRemove.Enabled = False
        End If
        If EnableModuleHotel = True Then
            ckHotel.Visible = True
        Else
            ckHotel.Visible = False
        End If

   
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub cmdUpdateAccountable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateAccountable.Click
        Me.Close()
    End Sub


    Private Sub LabelControl6_Click(sender As Object, e As EventArgs) Handles LabelControl6.Click

    End Sub
End Class