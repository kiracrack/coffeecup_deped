Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptBillingStatement
    Private Sub rptApprovedPO_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If GlobalEnableImageRaportHeader = True Then
            logo.Visible = True
        Else
            logo.Visible = False
            txtCompanyName.Text = UCase(compname)
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

        txtTitle1.Text = "PREPARED BY:"
        txtSignatory1.Text = UCase(globalfullname)
        txtPosition1.Text = globaldesignation

        txtTitle2.Text = UCase(AppApprovedTitle)
        txtSignatory2.Text = UCase(AppApprovedName)
        txtPosition2.Text = AppApprovedPosition

        If GlobalEnableCopyright = True Then
            txtCopyright.Visible = True
        Else
            txtCopyright.Visible = False
        End If
    End Sub
End Class