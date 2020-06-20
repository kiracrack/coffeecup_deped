Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptVoucher
    Private Sub rptApprovedPO_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
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


        txtpreparedName.Text = globalfullname
        txtPreparedPosition.Text = globaldesignation

        If AppSinglePrepared = True Then
            txtPreparedTitle.Text = AppPreparedTitle
            txtpreparedName.Text = AppPreparedName
            txtPreparedPosition.Text = ApppreparedPosition
        End If
       
        If GlobalEnableCopyright = True Then
            txtCopyright.Visible = True
        Else
            txtCopyright.Visible = False
        End If
    End Sub
End Class