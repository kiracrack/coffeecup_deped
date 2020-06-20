Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins

Public Class frmVendorInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub clearfields()
        id.Text = getvendorid()
        txtCompanyName.Text = ""
        txtadd.Text = ""
        txttell.Text = ""
        txtemail.Text = ""
        txtweb.Text = ""
        txtContactPerson.Text = ""
        txtDesignation.Text = ""
        mode.Text = ""
    End Sub
    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtCompanyName.Text = "" Then
                XtraMessageBox.Show("Please enter company name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            ElseIf countqry("tblglobalvendor", "companyname='" & rchar(txtCompanyName.Text) & "' and vendorid<>'" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Vendor or Supplier already exist!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                If mode.Text = "edit" Then
                    com.CommandText = "update tblglobalvendor set  companyname='" & rchar(txtCompanyName.Text) & "', compadd='" & StrConv(txtadd.Text, vbProperCase) & "', TELEPHONE='" & txttell.Text & "', EMAIL='" & txtemail.Text & "', WEBSITE='" & txtweb.Text & "', CONTPERSON='" & StrConv(txtContactPerson.Text, vbProperCase) & "', DESIGNATION='" & StrConv(txtDesignation.Text, vbProperCase) & "', entryby='" & globaluserid & "', dateentered=current_timestamp where vendorid='" & id.Text & "'"
                    com.ExecuteNonQuery()
                Else
                    com.CommandText = "insert into tblglobalvendor set vendorid='" & id.Text & "', companyname='" & rchar(txtCompanyName.Text) & "', compadd='" & StrConv(txtadd.Text, vbProperCase) & "', TELEPHONE='" & txttell.Text & "', EMAIL='" & LCase(txtemail.Text) & "', WEBSITE='" & LCase(txtweb.Text) & "', CONTPERSON='" & StrConv(txtContactPerson.Text, vbProperCase) & "', DESIGNATION='" & StrConv(txtDesignation.Text, vbProperCase) & "',entryby='" & globaluserid & "', dateentered=current_timestamp"
                    com.ExecuteNonQuery()
                End If
                XtraMessageBox.Show("Supplier/Vendor Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            clearfields()
            frmVendorsManagement.filter()
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
            com.CommandText = "select * from tblglobalvendor where vendorid='" & id.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                id.Text = rst("vendorid").ToString
                txtCompanyName.Text = rst("COMPANYNAME").ToString
                txtadd.Text = rst("compadd").ToString
                txttell.Text = rst("TELEPHONE").ToString
                txtemail.Text = rst("EMAIL").ToString
                txtweb.Text = rst("WEBSITE").ToString
                txtContactPerson.Text = rst("CONTPERSON").ToString
                txtDesignation.Text = rst("DESIGNATION").ToString
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clearfields()
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmVendorInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If mode.Text = "" Then
            id.Text = getvendorid()
        End If
    End Sub
End Class