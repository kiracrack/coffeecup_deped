Imports System.IO

Module Printing
    Public Sub CreateHTMLReportTemplate(ByVal filename As String)
        Dim saveLocation As String = Application.StartupPath.ToString & "\Templates\" & filename
        com.CommandText = "select * from tblreporthtmltemplate where filename='" & filename & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(saveLocation) = True Then
                System.IO.File.Delete(saveLocation)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(saveLocation, True)
            detailsFile.WriteLine(rst("htmltemplate").ToString)
            detailsFile.Close()
        End While
        rst.Close()
    End Sub
    Public Function PrintSetupHeader() As String
        PrintSetupHeader += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "
        PrintSetupHeader += "<p align='right'><strong>" & UCase(globaloffice) & "</strong></br>"

        Return PrintSetupHeader
    End Function

    Public Function PrintSetupHeaderGeneral()
        PrintSetupHeaderGeneral = ""
        PrintSetupHeaderGeneral += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "

        Return PrintSetupHeaderGeneral
    End Function

    Public Sub PrintViaInternetExplorer(ByVal location As String, ByVal form As Windows.Forms.Form)
        Try
            System.Diagnostics.Process.Start(location)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GenerateLXGuestStatement(ByVal folioid As String, ByVal form As Windows.Forms.Form)
        Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        CreateHTMLReportTemplate("HotelStatementOfAccount.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelStatementOfAccount.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\FOLIO\" & folioid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = "SELECT a.trnid, " _
                        + " date_format(a.datetrn, '%Y-%m-%d') as 'datetrn', " _
                        + " (select officename from tblcompoffice where officeid = a.officeid) as 'chargefrom', " _
                        + " if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),a.remarks) as 'remarks'," _
                        + " a.referenceno  as 'refno', " _
                        + " if(appliedcoupon=1,0,a.debit) as 'debit', " _
                        + " a.credit as 'credit', " _
                        + " (SELECT SUM(COALESCE(if(appliedcoupon=1,0,debit),0) - COALESCE(credit,0)) FROM tblhoteltransaction as b WHERE b.trnid <= a.trnid and b.folioid='" & folioid & "' and b.cancelled=0) AS 'balance' " _
                        + " FROM `tblhoteltransaction` as a where folioid='" & folioid & "' and a.cancelled=0 order by a.trnid asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("datetrn").ToString & "</td> " _
                           + " <td align='left'>" & rst("chargefrom").ToString & "</td> " _
                           + " <td align='left'>" & StrConv(rst("remarks").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("refno").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("debit").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("credit").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("balance").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Total = rst("balance")
        End While
        rst.Close()


        TableRow += "<tr> " _
                        + " <td align='right' colspan='6'>BALANCE</td> " _
                        + " <td align='right'>" & FormatNumber(Total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        TableTransaction = TableRow
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString & "\img\logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "STATEMENT OF ACCOUNT"), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        com.CommandText = "select *,(select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomno', " _
                                + " (select description from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomdescription', " _
                                + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'Guest', " _
                                + " (select address from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'address', " _
                                + " (select description from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomno' from tblhotelroomtransaction where folioid='" & folioid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", rst("Guest").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room no]", rst("roomno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room type]", UCase(rst("roomdescription").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[details]", "Adult " & rst("noadults").ToString & " Child " & rst("nochild").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkin]", rst("datecheckin").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkout]", rst("datecheckout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[balance]", FormatNumber(Total)), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), Form)
    End Sub

    Public Sub PrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)
     

        If AppSinglePrepared = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(AppPreparedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(ApppreparedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)
        End If
        If AppEnableCheckedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(AppCheckedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(AppCheckedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", "Signature Over Printed Name"), False)
        End If
        If AppEnableapprovedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(AppApprovedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(AppApprovedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", "Signature Over Printed Name"), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' width='100%' style='margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "DROP temporary table if exists temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE  temptableprinting (  `columnname` varchar(100) NOT NULL, `colindex` double NOT NULL, `colwidth` double NOT NULL default 0) ENGINE=memory;" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into temptableprinting set columnname='" & gv.Columns(I).FieldName & "',colindex='" & gv.Columns(I).VisibleIndex & "', colwidth='" & gv.Columns(I).Width & "'" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 Then
                    columnSize = " width='350' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>")

                rowRowTableData += "<td " & colalignment & columnSize & ">" & CellData & "</td> "
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns

                If col.Name = "colbold" Then

                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "bold").ToString) = True Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next

        SetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + "</table>"
        Return SetupTheGridviewPrinter
    End Function

    Public Sub PrintDatagridviewGL(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", ReportTitle), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ""), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinterGL(TableTitle, True, gv)), False)


        If AppSinglePrepared = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(AppPreparedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(ApppreparedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)
        End If
        If AppEnableCheckedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(AppCheckedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(AppCheckedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", "Signature Over Printed Name"), False)
        End If
        If AppEnableapprovedby = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(AppApprovedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(AppApprovedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", "_________________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", "Signature Over Printed Name"), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinterGL(ByVal TableTitle As String, ByVal replaceSpaceCharacter As Boolean, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' " & If(width < 700, "style='width:700px'", "width='100%'") & " style='margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "DROP temporary table if exists temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE  temptableprinting (  `columnname` varchar(100) NOT NULL, `colindex` double NOT NULL, `colwidth` double NOT NULL default 0) ENGINE=memory;" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into temptableprinting set columnname='" & gv.Columns(I).FieldName & "',colindex='" & gv.Columns(I).VisibleIndex & "', colwidth='" & gv.Columns(I).Width & "'" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 And replaceSpaceCharacter = False Then
                    columnSize = " width='350' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>")
                Dim spaces As String = getWhiteSpaces(CellData)

                If replaceSpaceCharacter = True Then
                    Dim newCellData As String = SplitLongString(CellData, spaces)
                    rowRowTableData += "<td " & colalignment & columnSize & ">" & If(newCellData = "0.00", "", newCellData.Replace(" ", "&nbsp;")) & "</td> "
                Else
                    rowRowTableData += "<td " & colalignment & columnSize & ">" & If(CellData = "0.00", "", CellData) & "</td> "
                End If
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns
                If col.Name = "colsl" Then
                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "sl").ToString) = False Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next
        Dim SummaryRow As String = "" : Dim SummaryColumn As String = ""
        If gv.OptionsView.ShowFooter = True Then
            For Each col In gv.Columns
                If col.Visible = True Then
                    SummaryColumn += "<td align='center'>" & col.SummaryText & "</td>"
                End If

            Next
        End If
        SummaryRow = "<tr style='font-weight:bold'>" & SummaryColumn & "</tr>"
        SetupTheGridviewPrinterGL = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return SetupTheGridviewPrinterGL
    End Function

    Public Function getWhiteSpaces(ByVal CellData As String) As String
        Dim cnt As Integer = 0 : Dim spaces As String = ""
        For Each q In CellData
            If q = " " Then
                cnt += 1
            ElseIf q <> " " And cnt > 5 Then
                For x = 0 To cnt - 1
                    spaces += " "
                Next
                Exit For
            End If
        Next
        Return spaces
    End Function

    Public Function SplitLongString(ByVal CellData As String, ByVal spaces As String)
        Dim newCellData As String = ""
        If CellData.Length > 120 Then
            Dim cn As Integer = 0 : Dim word As String = ""
            For Each q In CellData
                word += q
                If cn > 120 Then
                    If q = " " Then
                        Exit For
                    End If
                End If
                cn += 1
            Next
            newCellData = word
            If CellData.Replace(word, "").Length > 0 Then
                newCellData += "<br/>" & spaces & CellData.Replace(word, "")
            End If
        Else
            newCellData = CellData
        End If
        Return newCellData
    End Function

    Public Sub PrintLXReceipt(ByVal location As String, ByVal form As Windows.Forms.Form)
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = location
        Try
            Process.Start(printProcess)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module