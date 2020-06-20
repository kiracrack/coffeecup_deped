Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCompanySettings
#Region "COMPANY SETTINGS"
    Dim loads As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmCompanySettings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        loads = False
    End Sub
    Private Sub frmCompanySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loads = True
        If mode.Text = "new" Then
            txtCompanyCode.Properties.ReadOnly = False
        Else
            txtCompanyCode.Properties.ReadOnly = True
            showInfo()
        End If

        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If EnableModuleSales = True Then
            tabIdentity.PageVisible = True
        Else
            tabIdentity.PageVisible = False
        End If
    End Sub

    Public Sub showInfo()
        Try
            txtCompanyCode.Text = GlobalOrganizationCode
            txtinitialcode.Text = compinitialcode
            txtcomp.Text = compname
            txtadd.Text = compadd
            txttell.Text = compnumber
            txtemail.Text = compemail
            txtweb.Text = compwebsite
            txtofficer.Text = CompAproveName
            txtOfficerDesignation.Text = compApproveDesig
            piclogo.Image = complogo
            offsignature.Image = compapproversign

            com.CommandText = "select * from tblcompanysettings where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader
            While rst.Read
                txtTinNumber.Text = rst("tinnumber").ToString
                txtPermitNumber.Text = rst("permitnumber").ToString
                txtMiNumber.Text = rst("minumber").ToString
                txtSerialNumber.Text = rst("snumber").ToString

                txtVat.Text = rst("vatpercentage").ToString
                ckVatAddtoTotal.Checked = rst("addvattotal")

                txtServiceCharge.Text = rst("svchargepercentage").ToString
                ckSVAddtoTotal.Checked = rst("addsvtotal")

                txtReceiptType.Text = rst("posreceipttype").ToString
                txtLogoUrl.Text = rst("logourl").ToString
            End While
            rst.Close()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub offsignature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles offsignature.Validating
        If offsignature.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(offsignature.Image)
        offsignature.Image = Original

        Dim m As Int32 = 200
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        offsignature.Image = Thumb
    End Sub
    Private Sub piclogo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles piclogo.Validating
        ResizeImage(piclogo, 160, Me)
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSave.ItemClick
        ResizeImage(piclogo, 160, Me)
        Try
            If mode.Text = "new" Then
                com.CommandText = "insert into tblcompanysettings set systemmodule='" & txtModule.Text & "', companycode='" & txtCompanyCode.Text & "', initialcode='" & txtinitialcode.Text & "', companyname='" & StrConv(txtcomp.Text, vbProperCase) & "', compadd='" & StrConv(txtadd.Text, vbProperCase) & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logourl='" & txtLogoUrl.Text & "', chiefoff='" & StrConv(txtofficer.Text, vbProperCase) & "', designation='" & StrConv(txtOfficerDesignation.Text, vbProperCase) & "',tinnumber='" & txtTinNumber.Text & "', permitnumber='" & txtPermitNumber.Text & "', minumber='" & txtMiNumber.Text & "', snumber='" & txtSerialNumber.Text & "',vatpercentage='" & txtVat.Text & "', addvattotal=" & ckVatAddtoTotal.CheckState & ", svchargepercentage='" & txtServiceCharge.Text & "',addsvtotal=" & ckSVAddtoTotal.CheckState & ", posreceipttype='" & rchar(txtReceiptType.Text) & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblcompanysettings set initialcode='" & txtinitialcode.Text & "', companyname='" & StrConv(txtcomp.Text, vbProperCase) & "', compadd='" & StrConv(txtadd.Text, vbProperCase) & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logourl='" & txtLogoUrl.Text & "', chiefoff='" & StrConv(txtofficer.Text, vbProperCase) & "', designation='" & StrConv(txtOfficerDesignation.Text, vbProperCase) & "',tinnumber='" & txtTinNumber.Text & "', permitnumber='" & txtPermitNumber.Text & "', minumber='" & txtMiNumber.Text & "', snumber='" & txtSerialNumber.Text & "',vatpercentage='" & txtVat.Text & "', addvattotal=" & ckVatAddtoTotal.CheckState & ", svchargepercentage='" & txtServiceCharge.Text & "',addsvtotal=" & ckSVAddtoTotal.CheckState & ", posreceipttype='" & rchar(txtReceiptType.Text) & "' where companycode='" & txtCompanyCode.Text & "'" : com.ExecuteNonQuery()
            End If

            UpdateImage("companycode='" & txtCompanyCode.Text & "' and companycode='" & txtCompanyCode.Text & "'", "logo", "tblcompanysettings", piclogo, Me)
            UpdateImage("companycode='" & txtCompanyCode.Text & "' and companycode='" & txtCompanyCode.Text & "'", "digitalsign", "tblcompanysettings", offsignature, Me)

            XtraMessageBox.Show("Setting Successfully Updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadcompsettings()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        cmdSave.PerformClick()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cmdSave.PerformClick()
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmResetDatabase.ShowDialog(Me)
    End Sub
End Class