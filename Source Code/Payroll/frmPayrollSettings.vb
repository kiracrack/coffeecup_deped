Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPayrollSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadtax() : loadgsis() : loadpagibig() : loadphilhealth() : loadSavings()
        LoadSettings()
        LoadGridviewAppearance(gv_defaulttax)
        LoadGridviewAppearance(gv_defaultpagibig)
        LoadGridviewAppearance(gv_defaultphilhealth)
        LoadGridviewAppearance(gv_defaultGsis)
        LoadGridviewAppearance(gv_defaultSavings)
    End Sub

#Region "DEDUCTION"
    Public Sub loadtax()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction=1", "tblpayrolldedaddtype", txtdefaulttax, gv_defaulttax, Me)
        gv_defaulttax.Columns("code").Visible = False
    End Sub
    Private Sub txtdefaulttax_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefaulttax.EditValueChanged
        On Error Resume Next
        taxcode.Text = txtdefaulttax.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadgsis()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction=1", "tblpayrolldedaddtype", txtdefaultgsis, gv_defaultGsis, Me)
        gv_defaultGsis.Columns("code").Visible = False
    End Sub
    Private Sub txtdefaultgsis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefaultgsis.EditValueChanged
        On Error Resume Next
        gsiscode.Text = txtdefaultgsis.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadpagibig()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction=1", "tblpayrolldedaddtype", txtdefaultpagibig, gv_defaultpagibig, Me)
        gv_defaultpagibig.Columns("code").Visible = False
    End Sub
    Private Sub txtdefaultpagibig_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefaultpagibig.EditValueChanged
        On Error Resume Next
        pagibigcode.Text = txtdefaultpagibig.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadphilhealth()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction=1", "tblpayrolldedaddtype", txtdefaultphilhealth, gv_defaultphilhealth, Me)
        gv_defaultphilhealth.Columns("code").Visible = False
    End Sub
    Private Sub txtdefaultphilhealth_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefaultphilhealth.EditValueChanged
        On Error Resume Next
        philhealthcode.Text = txtdefaultphilhealth.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
    Public Sub loadSavings()
        LoadXgridLookupEdit("select code, description as 'Select' from tblpayrolldedaddtype where deduction=1", "tblpayrolldedaddtype", txtDefaultSavings, gv_defaultSavings, Me)
        gv_defaultSavings.Columns("code").Visible = False
    End Sub
    Private Sub txtDefaultSavings_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDefaultSavings.EditValueChanged
        On Error Resume Next
        savingscode.Text = txtDefaultSavings.Properties.View.GetFocusedRowCellValue("code").ToString
    End Sub
#End Region

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        XtraTabControl1.SelectedTabPage = tabDeductions
    End Sub
     
    Public Sub LoadSettings()
        com.CommandText = "select *,(select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaulttax) as 'tax', " _
                            + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsss) as 'sss', " _
                            + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultpagibig) as 'pagibig', " _
                            + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultphilhealth) as 'philhealth', " _
                            + " (select description from tblpayrolldedaddtype where code = tblpayrollsettings.defaultsavings) as 'savings' " _
                            + " from tblpayrollsettings where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader
        While rst.Read
            taxcode.Text = rst("defaulttax").ToString
            txtdefaulttax.Text = rst("tax").ToString
            txtTaxSched.Text = rst("taxsched").ToString

            gsiscode.Text = rst("defaultsss").ToString
            txtdefaultgsis.Text = rst("sss").ToString
            txtSSSSched.Text = rst("ssssched").ToString

            pagibigcode.Text = rst("defaultpagibig").ToString
            txtdefaultpagibig.Text = rst("pagibig").ToString
            txtPagibigSched.Text = rst("pagibigsched").ToString

            philhealthcode.Text = rst("defaultphilhealth").ToString
            txtdefaultphilhealth.Text = rst("philhealth").ToString
            txtPhilHealthSched.Text = rst("philhealthsched").ToString

            savingscode.Text = rst("defaultsavings").ToString
            txtDefaultSavings.Text = rst("savings").ToString
            txtSavingsSched.Text = rst("savingssched").ToString

            txtdailyratecomputation.Text = rst("totalworkingdays").ToString
            txthourlyratecomputation.Text = rst("totalworkinghours").ToString
            txtTotalWorksaMins.Text = rst("totalworkingmins").ToString

        End While
        rst.Close()
    End Sub


    Private Sub cdmSaveDeduction_Click(sender As Object, e As EventArgs) Handles cdmSaveDeduction.Click
        If countrecord("tblpayrollsettings") = 0 Then
            com.CommandText = "insert into tblpayrollsettings set companycode='" & GlobalOrganizationCode & "', " _
                            + " defaulttax='" & taxcode.Text & "', " _
                            + " taxsched='" & txtTaxSched.Text & "', " _
                            + " defaultsss='" & gsiscode.Text & "', " _
                            + " ssssched='" & txtSSSSched.Text & "', " _
                            + " defaultpagibig='" & pagibigcode.Text & "', " _
                            + " pagibigsched='" & txtPagibigSched.Text & "', " _
                            + " defaultphilhealth='" & philhealthcode.Text & "', " _
                            + " philhealthsched='" & txtPhilHealthSched.Text & "', " _
                            + " defaultsavings='" & savingscode.Text & "', " _
                            + " savingssched='" & txtSavingsSched.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblpayrollsettings set " _
                            + " defaulttax='" & taxcode.Text & "', " _
                            + " taxsched='" & txtTaxSched.Text & "', " _
                            + " defaultsss='" & gsiscode.Text & "', " _
                            + " ssssched='" & txtSSSSched.Text & "', " _
                            + " defaultpagibig='" & pagibigcode.Text & "', " _
                            + " pagibigsched='" & txtPagibigSched.Text & "', " _
                            + " defaultphilhealth='" & philhealthcode.Text & "', " _
                            + " philhealthsched='" & txtPhilHealthSched.Text & "', " _
                            + " defaultsavings='" & savingscode.Text & "', " _
                            + " savingssched='" & txtSavingsSched.Text & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        End If
        loadGeneralPayrollSettings()
        XtraMessageBox.Show("Settings successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If countrecord("tblpayrollsettings") = 0 Then
            com.CommandText = "insert into tblpayrollsettings set companycode='" & GlobalOrganizationCode & "', taxpercent='" & txtTaxPercent.Text & "', " _
                            + " totalworkingdays='" & Val(CC(txtdailyratecomputation.Text)) & "', totalworkinghours='" & Val(CC(txthourlyratecomputation.Text)) & "',totalworkingmins='" & Val(CC(txtTotalWorksaMins.Text)) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblpayrollsettings set taxpercent='" & txtTaxPercent.Text & "', " _
                            + " totalworkingdays='" & Val(CC(txtdailyratecomputation.Text)) & "', totalworkinghours='" & Val(CC(txthourlyratecomputation.Text)) & "',totalworkingmins='" & Val(CC(txtTotalWorksaMins.Text)) & "' where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        End If
        loadGeneralPayrollSettings()
        XtraMessageBox.Show("Settings successfuly saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        XtraTabControl1.SelectedTabPage = tabGeneralSettings
    End Sub

     
    Private Sub txthourlyratecomputation_EditValueChanged(sender As Object, e As EventArgs) Handles txthourlyratecomputation.EditValueChanged
        txtTotalWorksaMins.Text = Val(CC(txthourlyratecomputation.Text)) * 60
    End Sub
End Class