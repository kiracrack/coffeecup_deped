Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmNewRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmNewPurchaser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmNewPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gridcompoffice)
        LoadGridviewAppearance(s_grid)
        LoadGridviewAppearance(s_type)
        clearfields()
        loadPurchaseType()
        txtdtrequest.EditValue = Format(Now, "MMMM dd, yyyy")
        loadCompOffice()
        loadRequester()
        Me.Text = "Request Form by " & strConvert(globalfullname)
        txtposition.Caption = StrConv(globaldesignation, vbProperCase)
        lblOffice.Text = "Select " & GlobalOfficeCaption
        ' ckapprovinglevel.Text = GlobalOfficeCaption & " Disbursement"
    End Sub

    Public Sub loadCompOffice()
        LoadXgridLookupSearch("select officeid, officename as '" & GlobalOfficeCaption & "' from tblcompoffice where enableoperation=1 order by officename", "tblcompoffice", txtoffice, gridcompoffice, Me)
        gridcompoffice.Columns("officeid").Visible = False
        Me.txtoffice.Properties.DisplayMember = GlobalOfficeCaption
        Me.txtoffice.Properties.ValueMember = GlobalOfficeCaption
    End Sub

    Private Sub txtcompoffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtoffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtoffice.Properties.View.GetFocusedRowCellValue("officeid").ToString
        txtoffice.Text = txtoffice.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString
    End Sub


    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        Dim todate As Date = Format(Now.ToShortDateString)
        If txtoffice.Text = "" Then
            XtraMessageBox.Show("Please select office!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub

        ElseIf txtrequestby.Text = "" Then
            XtraMessageBox.Show("Requestor missing entry, Please select Requestor on the list!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtrequestby.Focus()
            Exit Sub

        ElseIf txtPurchaseType.Text = "" Then
            XtraMessageBox.Show("Please select Request type!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPurchaseType.Focus()
            Exit Sub
        End If

        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        Dim seq As Integer = 0 : Dim newpoid As String = ""
        If Val(qrysingledata("p", "CONVERT(SUBSTRING_INDEX( `pid` , '-', -1 ),UNSIGNED INTEGER) AS p", " order by p desc limit 1;", "tblrequisitions")) = 0 Then
            seq = countrecord("tblrequisitions") + 1
        Else
            seq = Val(qrysingledata("p", "CONVERT(SUBSTRING_INDEX( `pid` , '-', -1 ),UNSIGNED INTEGER) AS p", " order by p desc limit 1;", "tblrequisitions")) + 1
        End If
        newpoid = getGlobalRequestid("R" & globaluserid, seq)
        com.CommandText = "insert into tblrequisitions set pid='" & newpoid & "', " _
                           + " requestby=" & rid.Text & ", " _
                           + " officeid='" & officeid.Text & "'," _
                           + " potypeid='" & potypeid.Text & "', " _
                           + " priority='" & txtPriority.Text & "',  " _
                           + " details='" & rchar(txtdetails.Text) & "', " _
                           + " trnby=" & globaluserid & ", " _
                           + " corporatelevel=1, " _
                           + " approvedbranch=1, " _
                           + " received=1, " _
                           + " hold=1, " _
                           + " daterequest='" & ConvertDateTime(txtdtrequest.Text & " " & Format(Now.ToShortTimeString)) & "', " _
                           + " trnrefno='manual-requisition'" : com.ExecuteNonQuery()

        frmProceedNewRequest.pid.Text = newpoid
        clearfields()
        Me.Close()
        frmProceedNewRequest.MdiParent = MdiCoffeeCup
        frmProceedNewRequest.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub clearfields()
        txtdtrequest.EditValue = Format(Now, "MMMM dd, yyyy")
        txtoffice.Properties.DataSource = Nothing
        txtoffice.Text = ""
        officeid.Text = ""
        loadCompOffice()

        txtPurchaseType.Properties.DataSource = Nothing
        txtPurchaseType.Text = ""
        potypeid.Text = ""
        loadPurchaseType()

        txtrequestby.Properties.DataSource = Nothing
        txtrequestby.Text = ""
        rid.Text = ""
        txtdetails.Text = ""
    End Sub

    Public Sub loadRequester()
        LoadXgridLookupSearch("select accountid as ID, Fullname, (select officename from tblcompoffice where officeid = tblaccounts.officeid) as '" & GlobalOfficeCaption & "' from tblaccounts where username<>'ROOT' and deleted=0 order by fullname asc", "tblaccounts", txtrequestby, s_grid, Me)
        s_grid.Columns("ID").Visible = False
        s_grid.Columns(GlobalOfficeCaption).Visible = False
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrequestby.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtrequestby.Properties.View.FocusedRowHandle.ToString)
        rid.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("ID").ToString()
        txtrequestby.Text = txtrequestby.Properties.View.GetFocusedRowCellValue("Fullname").ToString()
    End Sub

  
    Public Sub loadPurchaseType()
        LoadXgridLookupEdit("select POTYPEID,DESCRIPTION as 'Request Type' from tblrequesttype " & If(GlobalDirectApprovedPr = False, " where POTYPEID in (select distinct requestcode from tblapprovermainprocess)", ""), "tblrequesttype", txtPurchaseType, s_type, Me)
        s_type.Columns("POTYPEID").Visible = False
    End Sub

    Private Sub txtPurchaseType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPurchaseType.Properties.View.FocusedRowHandle.ToString)
        potypeid.Text = txtPurchaseType.Properties.View.GetFocusedRowCellValue("POTYPEID").ToString()
        txtPurchaseType.Text = txtPurchaseType.Properties.View.GetFocusedRowCellValue("Request Type").ToString()
    End Sub

   
End Class