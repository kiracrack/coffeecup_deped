Imports System.IO
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class rptPurchaseRequest
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
        XrBarCode1.Text = pid.Text
        If txtpurchasetype.Text = "TRANSFER ITEM REQUEST" Then
            TransferRequest()
        Else
            LoadApproverDetails()
        End If


        txtNote.Text = "NOTE: This report and the signatures contained herein are generated electronically. All signatures are official and carry the full authority of the person(s) indicated"

        '#Show Copyright footer
        If GlobalEnableCopyright = True Then
            txtCopyright.Visible = True
        Else
            txtCopyright.Visible = False
        End If
        txtCopyright.Text = GlobalCopyrightName
    End Sub

    Public Sub LoadApproverDetails()
        ClearSignatories()

        'Preparedby
        Dim Preparedby As String = qrysingledata("trnby", "trnby", "tblrequisitions where pid='" & pid.Text & "'")
        com.CommandText = "select * from tblaccounts where accountid='" & Preparedby & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory1.Text = rst("fullname").ToString
            txtPosition1.Text = rst("designation").ToString
        End While
        rst.Close()
        ShowReportSignature(Preparedby, XrPictureBox1)

        If countqry("information_schema.tables", "table_schema='coffeecup_reports' and table_name='tblrequisition" & globaluser & "'") > 0 Then
            com.CommandText = "DROP TABLE coffeecup_reports.tblrequisition" & globaluser & "" : com.ExecuteNonQuery()
            com.CommandText = "CREATE TABLE `coffeecup_reports`.`tblrequisition" & globaluser & "` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `rptuserid` TEXT,  `rpttitle` TEXT,  `rptapprovername` TEXT,  `rptposition` TEXT,  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()
        Else
            com.CommandText = "CREATE TABLE `coffeecup_reports`.`tblrequisition" & globaluser & "` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `rptuserid` TEXT,  `rpttitle` TEXT,  `rptapprovername` TEXT,  `rptposition` TEXT,  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()
        End If

        dst = New DataSet : Dim createsec As Integer = 1
        msda = New MySqlDataAdapter("select * from tblapprovalhistory where referenceno='" & pid.Text & "'  and applevel<>'-' and status='approved'", conn)
        msda.Fill(dst, 0)
        For cnts = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "insert into  `coffeecup_reports`.`tblrequisition" & globaluser & "` set id='" & createsec & "', rptuserid='" & .Rows(cnts)("confirmid").ToString() & "', rpttitle='" & .Rows(cnts)("apptitle").ToString() & "',rptapprovername='" & .Rows(cnts)("confirmby").ToString() & "',rptposition='" & .Rows(cnts)("position").ToString() & "'" : com.ExecuteNonQuery()
            End With
            createsec = createsec + 1
        Next

        Dim cntApprover As Integer = countrecord("`coffeecup_reports`.`tblrequisition" & globaluser & "`")
        If cntApprover > 0 Then
            Dim cnt As Integer = 1
            Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3, txtTitle4, txtTitle5, txtTitle6}
            For Each cont As XRLabel In ctrTitle
                cont.Visible = True
                cont.Text = qrysingledata("rpttitle", "rpttitle", "where id='" & cnt & "'", "`coffeecup_reports`.`tblrequisition" & globaluser & "`")
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
                cont.Text = qrysingledata("rptapprovername", "rptapprovername", "where id='" & cnt3 & "'", "`coffeecup_reports`.`tblrequisition" & globaluser & "`")
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
                cont.Text = qrysingledata("rptposition", "rptposition", "where id='" & cnt4 & "'", "`coffeecup_reports`.`tblrequisition" & globaluser & "`")
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
                ShowReportSignature(qrysingledata("rptuserid", "rptuserid", "where id='" & cnt5 & "'", "`coffeecup_reports`.`tblrequisition" & globaluser & "`"), cont)
                If cnt5 = cntApprover Then
                    Exit For
                End If
                cnt5 = cnt5 + 1
            Next
        End If

    End Sub

    Public Sub TransferRequest()
        ClearSignatories()
        txtTitle4.Text = "Received By:"
        txtSignatory4.Text = txtRequestby.Text
        txtPosition4.Text = txtdesignation.Text

        txtTitle4.Visible = True
        txtSignatory4.Visible = True
        txtPosition4.Visible = True
        txtLine4.Visible = True

        If AppSinglePrepared = True Then
            txtTitle1.Text = AppPreparedTitle
            txtSignatory1.Text = AppPreparedName
            txtPosition1.Text = ApppreparedPosition

            txtTitle1.Visible = True
            txtSignatory1.Visible = True
            txtPosition1.Visible = True
            txtLine1.Visible = True
        End If

        If AppEnableCheckedby = True Then
            txtTitle2.Text = AppCheckedTitle
            txtSignatory2.Text = AppCheckedName
            txtPosition2.Text = AppCheckedPosition

            txtTitle2.Visible = True
            txtSignatory2.Visible = True
            txtPosition2.Visible = True
            txtLine2.Visible = True
        Else
            txtLine2.Visible = False
        End If

        If AppEnableapprovedby = True Then
            txtTitle3.Text = AppApprovedTitle
            txtSignatory3.Text = AppApprovedName
            txtPosition3.Text = AppApprovedPosition

            txtTitle3.Visible = True
            txtSignatory3.Visible = True
            txtPosition3.Visible = True
            txtLine3.Visible = True
        Else
            txtLine3.Visible = False
        End If
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