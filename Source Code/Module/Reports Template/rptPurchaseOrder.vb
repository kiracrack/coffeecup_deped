Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptPurchaseOrder
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

        'PROCUREMENT OFFICER
        Dim procurementid As String = ""
        If Globalenableprocurementid = True Then
            procurementid = Globalprocurementid
        Else
            procurementid = qrysingledata("createby", "createby", "tblpurchaseorder where ponumber='" & txtPONumber.Text & "'")
        End If

        com.CommandText = "select * from tblaccounts where accountid='" & procurementid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory1.Text = rst("fullname").ToString
            txtPosition1.Text = rst("designation").ToString
        End While
        rst.Close()
        ShowReportSignature(procurementid, XrPictureBox1)

       
       
        ClearSignatories()
       
        Dim cntApprover As Integer = countqry("tblapprovalhistory", "referenceno='" & txtPONumber.Text & "' and applevel<>'-' and appdescription='purchase order' and applevel<>'-' and appdescription='purchase order'")
        If cntApprover > 0 Then
            Dim cnt As Integer = 1
            Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3, txtTitle4, txtTitle5, txtTitle6}
            For Each cont As XRLabel In ctrTitle
                cont.Visible = True
                cont.Text = qrysingledata("apptitle", "apptitle", "where left(applevel,1) = '" & cnt & "' and referenceno='" & txtPONumber.Text & "' and applevel<>'-' and appdescription='purchase order'", "tblapprovalhistory")
                If cnt = cntApprover Then
                    Exit For
                End If
                cnt = cnt + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt2 As Integer = 1
            Dim ctrLine() As DevExpress.XtraReports.UI.XRLine = {txtLine2, txtLine3, txtLine4, txtLine5, txtLine6}
            For Each cont As XRLine In ctrLine
                cont.Visible = True
                If cnt2 = cntApprover Then
                    Exit For
                End If
                cnt2 = cnt2 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt3 As Integer = 1
            Dim ctrSignatory() As DevExpress.XtraReports.UI.XRLabel = {txtSignatory2, txtSignatory3, txtSignatory4, txtSignatory5, txtSignatory6}
            For Each cont As XRLabel In ctrSignatory
                cont.Visible = True
                cont.Text = qrysingledata("confirmby", "confirmby", "where left(applevel,1) = '" & cnt3 & "' and  referenceno='" & txtPONumber.Text & "' and applevel<>'-' and appdescription='purchase order'", "tblapprovalhistory")
                If cnt3 = cntApprover Then
                    Exit For
                End If
                cnt3 = cnt3 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt4 As Integer = 1
            Dim ctrPosition() As DevExpress.XtraReports.UI.XRLabel = {txtPosition2, txtPosition3, txtPosition4, txtPosition5, txtPosition6}
            For Each cont As XRLabel In ctrPosition
                cont.Visible = True
                cont.Text = UCase(qrysingledata("position", "position", "where left(applevel,1) = '" & cnt4 & "'  and  referenceno='" & txtPONumber.Text & "' and applevel<>'-' and appdescription='purchase order'", "tblapprovalhistory"))
                If cnt4 = cntApprover Then
                    Exit For
                End If
                cnt4 = cnt4 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt5 As Integer = 1
            Dim ctrPicture() As DevExpress.XtraReports.UI.XRPictureBox = {XrPictureBox2, XrPictureBox3, XrPictureBox4, XrPictureBox5, XrPictureBox6}
            For Each cont As XRPictureBox In ctrPicture
                cont.Visible = True
                cont.Image = Nothing
                ShowReportSignature(qrysingledata("confirmid", "confirmid", "where left(applevel,1) = '" & cnt5 & "'  and  referenceno='" & txtPONumber.Text & "' and applevel<>'-' and appdescription='purchase order'", "tblapprovalhistory"), cont)
                If cnt5 = cntApprover Then
                    Exit For
                End If
                cnt5 = cnt5 + 1
            Next
        End If

        'CEO
        If GLobalenablepoceosign = True Then
            Dim ceofullname As String = "" : Dim ceoposition As String = ""
            com.CommandText = "select * from tblaccounts where accountid='" & Globalceoaccountid & "'" : rst = com.ExecuteReader
            While rst.Read
                ceofullname = rst("fullname").ToString
                ceoposition = rst("designation").ToString
            End While
            rst.Close()

            If (cntApprover + 1) = 2 Then
                txtLine3.Visible = True
                txtTitle3.Text = "Noted By" : txtTitle3.Visible = True
                txtSignatory3.Text = ceofullname : txtSignatory3.Visible = True
                txtPosition3.Text = ceoposition : txtPosition3.Visible = True
                ShowReportSignature(Globalceoaccountid, XrPictureBox3) : XrPictureBox3.Visible = True
            ElseIf (cntApprover + 1) = 3 Then
                txtLine4.Visible = True
                txtTitle4.Text = "Noted By" : txtTitle4.Visible = True
                txtSignatory4.Text = ceofullname : txtSignatory4.Visible = True
                txtPosition4.Text = ceoposition : txtPosition4.Visible = True
                ShowReportSignature(Globalceoaccountid, XrPictureBox4) : XrPictureBox4.Visible = True
            ElseIf (cntApprover + 1) = 4 Then
                txtLine5.Visible = True
                txtTitle5.Text = "Noted By" : txtTitle5.Visible = True
                txtSignatory5.Text = ceofullname : txtSignatory5.Visible = True
                txtPosition5.Text = ceoposition : txtPosition5.Visible = True
                ShowReportSignature(Globalceoaccountid, XrPictureBox5) : XrPictureBox5.Visible = True
            ElseIf (cntApprover + 1) = 5 Then
                txtLine6.Visible = True
                txtTitle6.Text = "Noted By" : txtTitle6.Visible = True
                txtSignatory6.Text = ceofullname : txtSignatory6.Visible = True
                txtPosition6.Text = ceoposition : txtPosition6.Visible = True
                ShowReportSignature(Globalceoaccountid, XrPictureBox6) : XrPictureBox6.Visible = True
            End If
        End If

        txtNote.Text = "NOTE: This report and the signatures contained herein are generated electronically. All signatures are official and carry the full authority of the person(s) indicated"
        If GlobalEnableCopyright = True Then
            txtCopyright.Visible = True
        Else
            txtCopyright.Visible = False
        End If
        txtCopyright.Text = GlobalCopyrightName
    End Sub
    Public Sub ClearSignatories()
        Dim ctrPicture() As DevExpress.XtraReports.UI.XRPictureBox = {XrPictureBox2, XrPictureBox3, XrPictureBox4, XrPictureBox5, XrPictureBox6}
        For Each cont As XRPictureBox In ctrPicture
            cont.Image = Nothing
        Next

        Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3, txtTitle4, txtTitle5, txtTitle6}
        For Each cont As XRLabel In ctrTitle
            cont.Text = ""
        Next

        Dim ctrSignatory() As DevExpress.XtraReports.UI.XRLabel = {txtSignatory2, txtSignatory3, txtSignatory4, txtSignatory5, txtSignatory6}
        For Each cont As XRLabel In ctrSignatory
            cont.Text = ""
        Next

        Dim ctrPosition() As DevExpress.XtraReports.UI.XRLabel = {txtPosition2, txtPosition3, txtPosition4, txtPosition5, txtPosition6}
        For Each cont As XRLabel In ctrPosition
            cont.Text = ""
        Next

        Dim ctrLine() As DevExpress.XtraReports.UI.XRLine = {txtLine2, txtLine3, txtLine4, txtLine5, txtLine6}
        For Each cont As XRLine In ctrLine
            cont.Visible = False
        Next
 
    End Sub
End Class