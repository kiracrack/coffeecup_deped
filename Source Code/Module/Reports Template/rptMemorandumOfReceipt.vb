Imports System.IO


Public Class rptMemorandumOfReceipt
    Private Sub rptSingleReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If ReportHeaderImg Is Nothing Then
            imgReportHeader.Visible = False
            txtCompanyName.Text = compname
            txtCompanyAddress.Text = compadd
            txtCompanyNumber.Text = compnumber
        Else
            imgReportHeader.Visible = True
            imgReportHeader.Image = ReportHeaderImg
        End If

        If ReportFooterImg Is Nothing Then
            imgReportFooter.Visible = False
        Else
            imgReportFooter.Visible = True
            imgReportFooter.Image = ReportFooterImg
        End If

        If Me.Landscape = True Then
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Else
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        End If

        txtMemorandumLetter.Text = GlobalFFEmemorandumagreement
        Dim issuebysig As String = ""
        Dim issuetosig As String = ""
        com.CommandText = "SELECT a.*, b.*, b.acctableperson as acctableid, date_format(b.dateissued,'%M %d, %Y') as dtissued, (select description from tblinventoryffetype where code=a.ffetype) as ffetypes, " _
            + " (select officename from tblcompoffice where officeid=a.officeid) as office, (select fullname from tblaccounts where accountid=b.issueby) as issuedby, " _
            + " (select (select officename from tblcompoffice where officeid=tblaccounts.officeid) from tblaccounts where accountid=b.issueby) as issuebyoffice, " _
            + " (select (select officename from tblcompoffice where officeid=tblaccounts.officeid) from tblaccounts where accountid=b.acctableperson) as issuetooffice FROM `tblinventoryffe` as a inner join tblinventoryffeaccountable as b on a.ffecode=b.ffecode where b.id='" & txtIssueCode.Text & "';" : rst = com.ExecuteReader
        While rst.Read
            ffecode.Text = rst("ffecode").ToString
            txtDepartment.Text = rst("office").ToString
            txtDateIssue.Text = rst("dtissued").ToString
            txtIssueBy.Text = rst("issuedby").ToString
            txtIssueByDepartment.Text = rst("issuebyoffice").ToString
            issuebysig = rst("issueby").ToString

            txtIssueTo.Text = rst("accountname").ToString
            txtIssueToDepartment.Text = rst("issuetooffice").ToString
            issuetosig = rst("acctableid").ToString

            txtItemName.Text = rst("productname").ToString
            txtCategory.Text = rst("ffetypes").ToString
            txtQuantity.Text = rst("quantity").ToString
            txtCost.Text = FormatNumber(rst("totalamount").ToString, 2)
            txtRemarks.Text = rst("note").ToString
        End While
        rst.Close()
        ShowReportSignature(issuebysig, signature_issueby)
        ShowReportSignature(issuetosig, signature_issueto)


        txtpreparedName.Text = globalfullname
        txtPreparedPosition.Text = globaldesignation
        txtCopyright.Text = GlobalCopyrightName

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

        txtCopyright.Text = GlobalCopyrightName
    End Sub
End Class