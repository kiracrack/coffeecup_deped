Imports System.IO

Public Class rptInventorySummary
    Private Sub rptInventorySummary_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If GlobalEnableImageRaportHeader = True Then
            logo.Visible = True
        Else
            logo.Visible = False
            txtCompanyName.Text = compname
            txtCompanyAddress.Text = compadd
            txtCompanyNumber.Text = compnumber

            If Me.Landscape = True Then
                txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Else
                txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            End If
        End If
        If officeid.Text <> "" Then
            com.CommandText = "select *,(select fullname from tblaccounts where accountid = tblcompoffice.officerid) as 'officer', (select designation from tblaccounts where accountid = tblcompoffice.officerid) as 'designation'  from tblcompoffice where officeid='" & officeid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtoffice.Text = rst("officename").ToString
                txtOfficer.Text = rst("officer").ToString
                txtdesignation.Text = StrConv(rst("designation").ToString, vbProperCase)
            End While
            rst.Close()
        Else
            txtoffice.Text = "ALL " & UCase(GlobalOfficeCaption)
            txtOfficer.Text = UCase(compname)
            txtdesignation.Text = compname
        End If
        lblOffice.Text = UCase(GlobalOfficeCaption) & ":"
        txtpreparedName.Text = globalfullname
        txtPreparedPosition.Text = globaldesignation

        If AppSinglePrepared = True Then
            txtPreparedTitle.Text = AppPreparedTitle
            txtpreparedName.Text = AppPreparedName
            txtPreparedPosition.Text = ApppreparedPosition
        End If
        If AppEnableCheckedby = True Then
            lineChecked.Visible = True
            txtCheckedTitle.Text = AppCheckedTitle
            txtCheckedName.Text = AppCheckedName
            txtCheckedPosition.Text = AppCheckedPosition
        Else
            lineChecked.Visible = False
        End If
        If AppEnableapprovedby = True Then
            lineApproved.Visible = True
            txtApprovedTitle.Text = AppApprovedTitle
            txtApprovedName.Text = AppApprovedName
            txtApprovedPosition.Text = AppApprovedPosition
        Else
            lineApproved.Visible = False
        End If

        If Me.Landscape = True Then
            lineApproved.Location = New Point(lineChecked.Location.X + 400, lineChecked.Location.Y)
            txtApprovedTitle.Location = New Point(txtCheckedTitle.Location.X + 400, txtCheckedTitle.Location.Y)
            txtApprovedName.Location = New Point(txtCheckedName.Location.X + 400, txtCheckedName.Location.Y)
            txtApprovedPosition.Location = New Point(txtCheckedPosition.Location.X + 400, txtCheckedPosition.Location.Y)
        End If

        txtCopyright.Text = GlobalCopyrightName
    End Sub
End Class