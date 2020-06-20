Imports MySql.Data.MySqlClient

Module DepedTemplate
    Public Sub GenerateStockoutDepedTemplate(ByVal office As String, ByVal officecode As String, ByVal txtbatchcode As String, ByVal daterequest As Date, ByVal requestby As String, ByVal remarks As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("StockoutDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\StockoutDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\STOCKOUT\" & txtbatchcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 29
        com.CommandText = "Select *, (select ITEMNAME from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'productname',(select stockref from tblinventory where trnid  = tblstockoutitem.refcode) as stockref, " _
            + " (select quantity from tblinventory where trnid  = tblstockoutitem.refcode) as 'remainingquantity' from tblstockoutitem where batchcode='" & txtbatchcode & "' " : rst = com.ExecuteReader
        details = "<table border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                    + " <td colspan='3' align='center'><font size='4'>REQUISITION</font></td> " _
                    + " <td colspan='3' align='center'>Stock Available</td> " _
                    + " <td colspan='2' align='center'>Issue</td>" _
                    + " </tr>"
        details += "<tr> " _
                           + " <th align='center'>Stock #</td> " _
                           + " <th align='center'>Unit</td> " _
                           + " <th align='left'>DESCRIPTION</td> " _
                           + " <th align='center'>Quantity</td> " _
                           + " <th align='center'>YES</td> " _
                           + " <th align='center'>NO</td> " _
                           + " <th align='center'>Quantity</td> " _
                           + " <th align='right'>PRICE</td> " _
                     + " </tr> " & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("stockref").ToString & "</td> " _
                           + " <td align='left'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='left'>" & StrConv(rst("productname").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("remainingquantity").ToString & "</td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()
        TableRow += "<tr> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>*** NOTHING FOLLOWS ***</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                       + " <td align='center'>&nbsp;</td> " _
                 + " </tr> " & Chr(13)
        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        Dim Purpose As String = ""
        Purpose += "<tr> " _
                           + " <td align='left' colspan='8'>PURPOSE : " & remarks & " </td> " _
                     + " </tr> " & Chr(13)

        TableTransaction = details + TableRow + extraRow + Purpose
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", office), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[centercode]", officecode), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[risno]", Now.ToString("yyyy-MM").ToString & "-" & txtbatchcode), False)

        com.CommandText = "select * from tblaccounts where accountid='" & requestby & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestby]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestbyposition]", UCase(rst("designation").ToString)), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[issuedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[issuedbyposition]", UCase(AppApprovedPosition)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[daterequest]", CDate(daterequest).ToString("MMMM dd, yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateprint]", CDate(Now).ToString("MMMM dd, yyyy")), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateInventoryDepedTemplate(ByVal datereport As String, ByVal query As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InventoryDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = query : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:950px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center' rowspan='2'>ARTICLE</th> " _
                           + " <th align='center' rowspan='2'>DESCRIPTION</th> " _
                           + " <th align='center' rowspan='2'>STOCK</br>NUMBER</th> " _
                           + " <th align='center' rowspan='2'>UNIT OF</br>MEASURE</th> " _
                           + " <th align='center' rowspan='2'>UNIT</br>VALUE</td> " _
                           + " <th align='center'>BALANCE</br>PER CARD</th> " _
                           + " <th align='center'>ON HAND</br>PER COUNT</th> " _
                           + " <th align='center' colspan='2'>SHORTAGE/OVERAGES</th> " _
                           + " <th align='center' rowspan='2'>REMARKS</th> " _
                     + " </tr> " & Chr(13)
        details += "<tr> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>Quantity</th> " _
                         + " <th align='center'>Value</th> " _
                   + " </tr> " & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                          + " <td align='center'  width='300'>" & StrConv(rst("subcatname").ToString, vbProperCase) & "</td> " _
                          + " <td align='left'  width='300'>" & StrConv(rst("productname").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("stockref").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center' width='200'>Unused office supplies</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date report]", CDate(datereport).ToString("MMMM dd, yyyy")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateOfficeEquipmentDepedTemplate(ByVal datereport As String, ByVal categoryname As String, ByVal query As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\EquipmentDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\EQUIPMENT\" & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = query : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width=100%; max-width:1250px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center' rowspan='2'>ARTICLE</th> " _
                           + " <th align='center' rowspan='2'>DESCRIPTION</th> " _
                           + " <th align='center' rowspan='2'>PROPERTY</br>NUMBER</th> " _
                           + " <th align='center' rowspan='2'>UNIT OF</br>MEASURE</th> " _
                           + " <th align='center' rowspan='2'>UNIT</br>VALUE</td> " _
                           + " <th align='center'>BALANCE</br>PER CARD</th> " _
                           + " <th align='center'>ON HAND</br>PER COUNT</th> " _
                           + " <th align='center' colspan='2'>SHORTAGE/OVERAGES</th> " _
                           + " <th align='center' colspan='3'>REMARKS</th> " _
                     + " </tr> " & Chr(13)
        details += "<tr> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>Quantity</th> " _
                         + " <th align='center'>Value</th> " _
                         + " <th align='center'>Location</th> " _
                         + " <th align='center'>Accountable</th> " _
                         + " <th align='center'>Date Issue</th> " _
                   + " </tr> " & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                          + " <td align='center'>" & StrConv(rst("subcatname").ToString, vbProperCase) & "</td> " _
                          + " <td align='left'>" & StrConv(rst("productname").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("propertyno").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("totalcost").ToString, 2) & "</td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'>" & rst("officename").ToString & "</td> " _
                           + " <td align='center'>" & rst("acctperson").ToString & "</td> " _
                           + " <td align='center'>" & If(rst("tdacc").ToString = "0001-01-01", "-", rst("tdacc").ToString) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date report]", CDate(datereport).ToString("MMMM dd, yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[categoryname]", categoryname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateByOfficeEquipmentDepedTemplate(ByVal ReportByALL As Boolean, ByVal ics As Boolean, ByVal datereport As String, ByVal categoryName As String, ByVal officeid As String, ByVal query As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\EquipmentDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\EQUIPMENT\" & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 5
        Dim category As String = "" : Dim productid As String = "" : Dim model As String = "" : Dim unitcost As Double = 0 : Dim propertyno As String = ""

        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter(query, conn)
        msda.Fill(dst, 0)

        details = "<table id='tbl' border='1' style='width=100%; max-width:1250px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center' rowspan='2'>ARTICLE</th> " _
                           + " <th align='center' rowspan='2'>DESCRIPTION</th> " _
                           + " <th align='center' rowspan='2'>PROPERTY</br>NUMBER</th> " _
                           + " <th align='center' rowspan='2'>UNIT OF</br>MEASURE</th> " _
                           + " <th align='center' rowspan='2'>UNIT</br>VALUE</td> " _
                           + " <th align='center'>BALANCE</br>PER CARD</th> " _
                           + " <th align='center'>ON HAND</br>PER COUNT</th> " _
                           + " <th align='center' colspan='2'>SHORTAGE/OVERAGES</th> " _
                           + " <th align='center' rowspan='2'>REMARKS</th> " _
                     + " </tr> " & Chr(13)
        details += "<tr> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>(Quantity)</th> " _
                         + " <th align='center'>Quantity</th> " _
                         + " <th align='center'>Value</th> " _
                   + " </tr> " & Chr(13)

        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If ReportByALL = True Then
                    If .Rows(cnt)("category").ToString = category Then

                    Else
                        TableRow += "<tr> " _
                          + " <td align='center'>&nbsp;</td> " _
                           + " <td align='left' colspan='9' style='padding:10px 0px 10px 10px '><strong><font size='2'><u>" & .Rows(cnt)("category").ToString & "</u></font></strong></td> " _
                      + " </tr> " & Chr(13)
                        category = .Rows(cnt)("category").ToString
                    End If
                    If .Rows(cnt)("productid").ToString = productid Then
                        If .Rows(cnt)("model").ToString = model And .Rows(cnt)("unitcost").ToString = unitcost And .Rows(cnt)("propertyno").ToString = propertyno Then
                            TableRow += "<tr> " _
                                  + " <td align='center'></td> " _
                                  + " <td align='left' width='200'></td> " _
                                   + " <td align='center'>" & .Rows(cnt)("propertynumber").ToString & "</td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='right'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Aquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                             + " </tr> " & Chr(13)
                        Else
                            TableRow += "<tr> " _
                                  + " <td align='center'></td> " _
                                  + " <td align='left' width='200'>" & .Rows(cnt)("model").ToString & "</td> " _
                                    + " <td align='center'>" & .Rows(cnt)("propertynumber").ToString & "</td> " _
                                    + " <td align='center'>" & .Rows(cnt)("Unit").ToString & "</td> " _
                                    + " <td align='right'>" & FormatNumber(.Rows(cnt)("totalcost").ToString, 2) & "</td> " _
                                    + " <td align='center'>" & qrysingledata("ttlquantity", "sum(quantity) as ttlquantity", "tblofficeequipment where productid='" & .Rows(cnt)("productid").ToString & "' and unitcost='" & .Rows(cnt)("unitcost").ToString & "' and modelid='" & .Rows(cnt)("modelid").ToString & "' and propertyno='" & .Rows(cnt)("propertyno").ToString & "' " & If(ics = True, " and unitcost<15000", " and unitcost>=15000")) & "</td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'></td> " _
                                   + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Aquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                             + " </tr> " & Chr(13)
                            model = .Rows(cnt)("model").ToString
                            unitcost = .Rows(cnt)("unitcost").ToString
                            propertyno = .Rows(cnt)("propertyno").ToString
                        End If

                    Else
                        TableRow += "<tr> " _
                           + " <td align='center'>" & StrConv(.Rows(cnt)("subcatname").ToString, vbProperCase) & "</td> " _
                           + " <td align='left' width='200'><b>" & StrConv(.Rows(cnt)("productname").ToString, vbUpperCase) & "<br/>" & .Rows(cnt)("model").ToString & "</b></td> " _
                            + " <td align='center'>" & .Rows(cnt)("propertynumber").ToString & "</td> " _
                            + " <td align='center'>" & .Rows(cnt)("Unit").ToString & "</td> " _
                            + " <td align='right'>" & FormatNumber(.Rows(cnt)("totalcost").ToString, 2) & "</td> " _
                            + " <td align='center'>" & qrysingledata("ttlquantity", "sum(quantity) as ttlquantity", "tblofficeequipment where productid='" & .Rows(cnt)("productid").ToString & "'and unitcost='" & .Rows(cnt)("unitcost").ToString & "' and modelid='" & .Rows(cnt)("modelid").ToString & "' and propertyno='" & .Rows(cnt)("propertyno").ToString & "' " & If(ics = True, " and unitcost<15000", " and unitcost>=15000")) & "</td> " _
                            + " <td align='center'></td> " _
                            + " <td align='center'></td> " _
                            + " <td align='center'></td> " _
                            + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Acquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                      + " </tr> " & Chr(13)

                        productid = .Rows(cnt)("productid").ToString
                        model = .Rows(cnt)("model").ToString
                        unitcost = .Rows(cnt)("unitcost").ToString
                        propertyno = .Rows(cnt)("propertyno").ToString
                    End If


                    'TableRow += "<tr> " _
                    '            + " <td align='center'>" & StrConv(.Rows(cnt)("subcatname").ToString, vbProperCase) & "</td> " _
                    '            + " <td align='left' width='200'><b>" & StrConv(.Rows(cnt)("productname").ToString, vbUpperCase) & "</b>" _
                    '            + If(.Rows(cnt)("model").ToString = "", "", " <br/>MODEL: " & .Rows(cnt)("model").ToString) _
                    '            + If(.Rows(cnt)("serialnumber").ToString = "", "", " <br/>SERIAL:" & .Rows(cnt)("serialnumber").ToString) _
                    '            + If(.Rows(cnt)("productdetails").ToString = "" Or .Rows(cnt)("productdetails").ToString = vbCrLf Or .Rows(cnt)("productdetails").ToString = Chr(13), "", "<br/>" & .Rows(cnt)("productdetails").ToString.Replace(Chr(13), "<br/>").Replace(vbCrLf, "<br/>")) & "</td> " _
                    '             + " <td align='center'>" & .Rows(cnt)("propertynumber").ToString & "</td> " _
                    '             + " <td align='center'>" & .Rows(cnt)("Unit").ToString & "</td> " _
                    '             + " <td align='right'>" & FormatNumber(.Rows(cnt)("totalcost").ToString, 2) & "</td> " _
                    '             + " <td align='center'>" & .Rows(cnt)("quantity").ToString & "</td> " _
                    '             + " <td align='center'></td> " _
                    '             + " <td align='center'></td> " _
                    '             + " <td align='center'></td> " _
                    '             + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Acquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                    '       + " </tr> " & Chr(13)
                Else
                    If .Rows(cnt)("category").ToString = category Then

                    Else
                        TableRow += "<tr> " _
                          + " <td align='center'>&nbsp;</td> " _
                           + " <td align='left' colspan='9' style='padding:10px 0px 10px 10px '><strong><font size='2'><u>" & .Rows(cnt)("category").ToString & "</u></font></strong></td> " _
                      + " </tr> " & Chr(13)
                        category = .Rows(cnt)("category").ToString
                    End If
                    TableRow += "<tr> " _
                                + " <td align='center'>" & StrConv(.Rows(cnt)("subcatname").ToString, vbProperCase) & "</td> " _
                                + " <td align='left' width='200'><b>" & StrConv(.Rows(cnt)("productname").ToString, vbUpperCase) & "</b>" _
                                + If(.Rows(cnt)("model").ToString = "", "", " <br/>MODEL: " & .Rows(cnt)("model").ToString) _
                                + If(.Rows(cnt)("serialnumber").ToString = "", "", " <br/>SERIAL:" & .Rows(cnt)("serialnumber").ToString) _
                                + If(.Rows(cnt)("productdetails").ToString = "" Or .Rows(cnt)("productdetails").ToString = vbCrLf Or .Rows(cnt)("productdetails").ToString = Chr(13), "", "<br/>" & .Rows(cnt)("productdetails").ToString.Replace(Chr(13), "<br/>").Replace(vbCrLf, "<br/>")) & "</td> " _
                                 + " <td align='center'>" & .Rows(cnt)("propertynumber").ToString & "</td> " _
                                 + " <td align='center'>" & .Rows(cnt)("Unit").ToString & "</td> " _
                                 + " <td align='right'>" & FormatNumber(.Rows(cnt)("totalcost").ToString, 2) & "</td> " _
                                 + " <td align='center'>" & .Rows(cnt)("quantity").ToString & "</td> " _
                                 + " <td align='center'></td> " _
                                 + " <td align='center'></td> " _
                                 + " <td align='center'></td> " _
                                 + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Acquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                           + " </tr> " & Chr(13)
                End If

                ' + " <td align='center'>Div. Property Issued to " & .Rows(cnt)("acctperson").ToString & If(.Rows(cnt)("tdacc").ToString = "0001-01-01", "", "<br/>Date Aquired By: " & CDate(.Rows(cnt)("tdacc").ToString).ToString("MMMM dd, yyyy")) & If(.Rows(cnt)("unitstatus").ToString = "", "", " (" & .Rows(cnt)("unitstatus").ToString & ")") & "</td> " _
                totalrow = totalrow - 1
            End With
        Next

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        If ReportByALL = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reporttitle]", "SUMMARY REPORT ON PHYSICAL COUNT OF PROPERTY, PLANT AND EQUIPMENT " & If(ics = True, " - ICS", " - PAR")), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reporttitle]", "REPORT ON PHYSICAL COUNT OF PROPERTY, PLANT AND EQUIPMENT" & If(ics = True, " - ICS", " - PAR")), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date report]", datereport), False)

        If ReportByALL = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reporttype]", "PREPARED"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[propertytype]", categoryName), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reporttype]", "CONFORME"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[propertytype]", "Type of Property, Plant and Equipment"), False)
            com.CommandText = "select (select fullname from tblaccounts where accountid=tblcompoffice.officerid) as officer,(select designation from tblaccounts where accountid=tblcompoffice.officerid) as position  from tblcompoffice where officeid='" & officeid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(rst("officer").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(rst("position").ToString)), False)
            End While
            rst.Close()
        End If
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateStockCard(ByVal officeid As String, ByVal itemid As String, ByVal itemname As String, ByVal stockno As String, ByVal date_from As String, ByVal date_to As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        ' CreateHTMLReportTemplate("InventoryLedgerDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InventoryLedgerDepedTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(itemid) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 50
        com.CommandText = "select a.*, date_format(a.datetrn, '%Y-%m-%d') as 'datetrans', " _
                        + " a.remarks as 'Remarks', " _
                        + " a.debit as 'StockIn', " _
                        + " a.credit as 'StockOut', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblinventoryledger as b " _
                        + " WHERE b.id <= a.id and b.officeid=a.officeid and b.productid=a.productid) AS 'Balance',trntype as 'Transaction Type', trnby as 'Transaction By', " _
                        + " ifnull((select officename from tblcompoffice where officeid=a.reqoffice),(select companyname from tblglobalvendor where vendorid=a.reqoffice)) as 'RequestingParty' " _
                        + " FROM tblinventoryledger as a where a.officeid='" & officeid & "' and a.productid='" & itemid & "' and date_format(a.datetrn, '%Y-%m-%d') between '" & date_from & "' and '" & date_to & "' order by a.id asc" : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse; font-size:7px'>  "
        details += "<tr> " _
                           + " <th align='center'>DATE<br/>RECEIVED<br/>OR ISSUED</th> " _
                           + " <th align='center'>DELIVERY<br/>RECEIPT NO./<br/>INVOICE NO.</th> " _
                           + " <th align='center'>SICR NO./<br/>P.O. NO.</th> " _
                           + " <th align='center'>FROM WHOM RECEIVED OR<br/>TO WHOM ISSUED</td> " _
                           + " <th align='center'>QUANTITY<br/>RECEIVED</th> " _
                           + " <th align='center'>QUANTITY<br/>ISSUED</th> " _
                           + " <th align='center'>QUANTITY<br/>ON HAND</th> " _
                           + " <th align='center'>PRICE PER<br/>P.O./P.L.</th> " _
                           + " <th align='center'>REMARKS</th> " _
                     + " </tr> " & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("datetrans").ToString & "</td> " _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                           + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                           + " <td align='center'>" & rst("RequestingParty").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockIn").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockOut").ToString & "</td> " _
                           + " <td align='center'>" & rst("Balance").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                           + " <td>" & rst("remarks").ToString & "</td> " _
                        + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        extraRow += "<tr> " _
                           + " <td align='center' colspan='4'>BALANCE CARRIED FORWARD</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                            + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        com.CommandText = "select *, sum(quantity) as quan,(select officename from tblcompoffice where officeid=tblinventory.officeid) as office from tblinventory where officeid='" & officeid & "' and productid='" & itemid & "' and quantity>0 group by productid" : rst = com.ExecuteReader
        While rst.Read

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[unit]", UCase(rst("unit").ToString)), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[productname]", UCase(itemname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stockno]", stockno), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateDepedRSMITemplate(ByVal datereport As String, ByVal filterasof As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("DepedRSMI.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DepedRSMI.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\DepedRSMI " & RemoveSpecialCharacter(datereport) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = "select *,  concat(date_format(datestockout,'%Y-%m'),'-',tblstockoutbatch.batchcode) as 'ris', (select initialcode from tblcompoffice where officeid=tblstockoutitem.allocatedofficeid) as 'CenterCode',(select stockref from tblinventory where trnid=tblstockoutitem.refcode) as 'StockNo', " _
            + " (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'ITEM',Unit,quantity, purchasedprice,purchasedprice*quantity as 'Amount'  from tblstockoutitem inner join tblstockoutbatch on tblstockoutbatch.batchcode = tblstockoutitem.batchcode " & filterasof & " and cancelled=0 order by datestockout asc" : rst = com.ExecuteReader
        details = "<table id='tbl' border='1' style='width:700px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'>  "
        details += "<tr> " _
                           + " <th align='center' width='75'>RIS No.</th> " _
                           + " <th align='center'>Responsibility /<br/>Center Code</th> " _
                           + " <th align='center'>Stock</br>No.</th> " _
                           + " <th align='center'>ITEM</td> " _
                           + " <th align='center'>Unit</th> " _
                           + " <th align='center'>Qty</br>Issued</th> " _
                           + " <th align='center'>Unit Cost</th> " _
                           + " <th align='center'>Amount</th> " _
                     + " </tr> " & Chr(13)

        While rst.Read
            TableRow += "<tr> " _
                          + " <td align='center'>" & StrConv(rst("ris").ToString, vbProperCase) & "</td> " _
                           + " <td align='center'>" & rst("CenterCode").ToString & "</td> " _
                           + " <td align='center'>" & rst("StockNo").ToString & "</td> " _
                           + " <td align='left'>" & rst("ITEM").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()

        'For I = 0 To totalrow
        '    extraRow += "<tr> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '                   + " <td align='center'>&nbsp;</td> " _
        '             + " </tr> " & Chr(13)
        'Next



        Dim details2 As String = ""
        Dim details3 As String = ""
        Dim TableRow2 As String = ""
        details2 += "<tr style='font-size:15px; padding: 10px;'> " _
                           + " <td align='center' colspan='2' style=' padding: 10px;'><strong>RECAPITULATION</strong></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center'></td> " _
                           + " <td align='center' colspan='2'><strong>RECAPITULATION</strong></td> " _
                     + " </tr> " & Chr(13)
        details2 += "<tr> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'><strong>STOCK NO.</strong></td> " _
                   + " <td align='center'><strong>QUANTITY</strong></td> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'></td> " _
                   + " <td align='center'><strong>UNIT</br>COST</strong></td> " _
                   + " <td align='center'><strong>TOTAL COST</strong></td> " _
                   + " <td align='center'><strong>ACCOUNT COST</strong></td> " _
             + " </tr> " & Chr(13)
        com.CommandText = "select (select stockref from tblinventory where trnid=tblstockoutitem.refcode) as 'StockNo',(select itemname from tblglobalproducts where productid=tblstockoutitem.productid) as 'ITEM',Unit, sum(quantity) as qty, purchasedprice,purchasedprice*sum(quantity) as 'Amount'  from tblstockoutitem inner join tblstockoutbatch on tblstockoutbatch.batchcode = tblstockoutitem.batchcode " & filterasof & " group by productid, purchasedprice order by (select itemname from tblglobalproducts where productid=tblstockoutitem.productid) asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow2 += "<tr> " _
                          + " <td align='center'></td> " _
                           + " <td align='center'>" & rst("StockNo").ToString & "</td> " _
                           + " <td align='center'>" & rst("qty").ToString & "</td> " _
                           + " <td align='left'>" & rst("ITEM").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("purchasedprice").ToString, 2) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
                           + " <td align='center'></td> " _
                     + " </tr> " & Chr(13)
        End While
        rst.Close()

        details3 += "<tr> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='left'><strong>BALANCE FORWARDED</strong></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
                 + " <td align='center'></td> " _
           + " </tr> " & Chr(13)
        details3 += "<tr style='font-size:15px; padding: 10px;'> " _
                + " <td align='center' colspan='4'>I HEREBY CERTIFY TO THE CORRECTNESS OF THE ABOVE INFORMATION.</td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
                + " <td align='center'></td> " _
          + " </tr> " & Chr(13)

        details3 += "<tr style='font-size:15px; padding: 10px;'> " _
               + " <td align='center' colspan='5'></br></br><u><b>NARLYN Z. MENDOZA</b></u> </br> Administrative Officer IV</td> " _
               + " <td align='center' colspan='3'>POSTED BY DATE: </br></br>________________________</br>ACCOUNTING CLERK</td> " _
         + " </tr> " & Chr(13)

        TableTransaction = details + TableRow + details2 + TableRow2 + details3 + "</table>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(datereport).ToString("MMMM, yyyy")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedby]", UCase(AppApprovedName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvedbyposition]", UCase(AppApprovedPosition)), False)


        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateInventoryCustodianSlip(ByVal accountable As String, ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal generateid As Boolean, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\InventoryCustodianSlip.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(accountable) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim ffeid As String = ""
        For I = 0 To grid.SelectedRowsCount - 1
            ffeid += " id='" & grid.GetRowCellValue(grid.GetSelectedRows(I), "Entry Code").ToString & "' or "
        Next

        If generateid = True Then
            Dim vno As String = getSeriesNo("ICS", Now.Year.ToString, "tbldepedics")
            Dim controlno = Now.Year.ToString & "-" & vno
            Dim seriesno = vno
            com.CommandText = "insert into tbldepedics set template='ICS', yeartrn='" & Now.Year.ToString & "', seriesno='" & seriesno & "', controlno='" & controlno & "', dateissue=current_date" : com.ExecuteNonQuery()
            com.CommandText = "update tblofficeequipment set issuereference='ICS " & controlno & "' where accountable='" & accountable & "' and unitcost <=15000 and " & ffeid.Remove(ffeid.Length - 3, 3) : com.ExecuteNonQuery()
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[icsno]", controlno), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now).ToString("MM/dd/yyyy")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[icsno]", ""), False)
        End If

        Dim totalrow As Integer = 22
        com.CommandText = "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as 'propertynumber',(select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as model  from tblofficeequipment where accountable='" & accountable & "' and unitcost <=15000 and " & ffeid.Remove(ffeid.Length - 3, 3) : rst = com.ExecuteReader
        details = " <table style='width:100%; margin:3px 0; border: 1px solid;' >  "
        details += "<tr><TH rowspan='2'>Quantity <TH rowspan='2'>Unit<TH colspan='2'>Amount <TH rowspan='2'>DESCRIPTION<TH rowspan='2'>Inventory Item.No. <TH  rowspan='2'> Estimated Useful Life</tr><TR><TH>Unit cost<TH>Total Cost<tr>" & Chr(13)

        While rst.Read
            TableRow += "<tr> " _
                            + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                            + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("unitcost").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("totalcost").ToString, 2) & "</td> " _
                           + " <td><b><u>" & UCase(rst("Productname").ToString) & "</u></b></br>Model: " & rst("model").ToString & "</br>Serial #: " & rst("serialnumber").ToString & "</br>" & rst("productdetails").ToString.Replace(vbCrLf, "</br>") & "</td> " _
                           + " <td align='center'>" & rst("propertynumber").ToString & "</td> " _
                           + " <td align='center'>" & rst("estimatedlife").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()
        extraRow += "<tr> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>***NOTHING FOLLOWS***</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                    + " </tr> " & Chr(13)
        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & accountable & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[entity]", UCase(rst("office").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[acctname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[acctposition]", rst("designation").ToString), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now).ToString("MM/dd/yyyy")), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GeneratePulloutSlip(ByVal trncode As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DepedPulloutslip.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(trncode) & "-pullout.html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 4
        Dim cnt As Integer = 1
        details = " <table id='tblitem' border='0' id='tabl_sub' width='100%' cellspacing='0' cellpadding='0'>"
        details += "<tr style='font-weight: bold;' align='center'><td>S/N</td><td>QTY</td><td>UOM</td><td>ITEM(S)</td><td>REASON</td><td>REMARKS</td></tr>" & Chr(13)
        com.CommandText = "select * from tblofficeequipmentpulloutitem where trncode='" & trncode & "'" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                            + " <td align='center'>" & cnt & "</td> " _
                            + " <td align='center'>" & rst("qty").ToString & "</td> " _
                            + " <td align='center'>" & rst("unit").ToString & "</td> " _
                            + " <td>" & UCase(rst("itemname").ToString) & "</td> " _
                            + " <td>" & UCase(rst("reason").ToString) & "</td> " _
                            + " <td>" & UCase(rst("remarks").ToString) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
            cnt += 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow + "</table>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblofficeequipmentpullout.borrower) as borrowername, " _
                        + " (select (select officename from tblcompoffice where officeid=tblaccounts.officeid) from tblaccounts where accountid=tblofficeequipmentpullout.borrower) as borroweroffice, " _
                        + " (select fullname from tblaccounts where accountid=tblofficeequipmentpullout.trnby) as trnname," _
                        + " concat(date_format(dateborrowed,'%M %d, %Y'),' ',date_format(timeborrowed,'%r')) as dtb, " _
                        + " date_format(datereturned,'%M %d, %Y') dtr from tblofficeequipmentpullout where trncode='" & trncode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateborrowed]", UCase(rst("dtb").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datereturned]", UCase(rst("dtr").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[borrower]", UCase(rst("borrowername").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[trnby]", UCase(rst("trnname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", UCase(rst("borroweroffice").ToString)), False)
        End While
        rst.Close()
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateReturedItem(ByVal trncode As String, ByVal queryitem As String, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DepedReturnCertificate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(trncode) & "-return.html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 4
        Dim cnt As Integer = 1
        details = " <table id='tblitem' border='0' id='tabl_sub' width='100%' cellspacing='0' cellpadding='0'>"
        details += "<tr style='font-weight: bold;' align='center'><td>DESRIPTION<br/>OF ITEMS</td><td>DATE<br/>RETURNED</td><td>QUANTITY</td><td>S/N AND<br/>MODEL #</td><td>REMARKS/<br/>STATUS</td></tr>" & Chr(13)
        com.CommandText = "select * from tblofficeequipmentpulloutitem as a inner join tblofficeequipment as b on a.trnid=b.id where trncode='" & trncode & "' and (" & queryitem & ")" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                            + " <td>" & UCase(rst("itemname").ToString) & "</td> " _
                            + " <td align='center'>" & CDate(Now).ToString("MMMM dd, yyyy") & "</td> " _
                            + " <td align='center'>" & rst("qty").ToString & "</td> " _
                            + " <td>" & rst("productdetails").ToString.Replace(vbCrLf, "<br/>") & "</td> " _
                            + " <td>" & UCase(rst("reason").ToString) & " " & UCase(rst("remarks").ToString) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
            cnt += 1
        End While
        rst.Close()

        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow + "</table>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblofficeequipmentpullout.borrower) as borrowername, " _
                        + " (select (select officename from tblcompoffice where officeid=tblaccounts.officeid) from tblaccounts where accountid=tblofficeequipmentpullout.borrower) as borroweroffice, " _
                        + " (select fullname from tblaccounts where accountid=tblofficeequipmentpullout.trnby) as trnname," _
                        + " (select designation from tblaccounts where accountid=tblofficeequipmentpullout.trnby) as designation," _
                        + " concat(date_format(dateborrowed,'%M %d, %Y'),' ',date_format(timeborrowed,'%r')) as dtb, " _
                        + " date_format(datereturned,'%M %d, %Y') dtr from tblofficeequipmentpullout where trncode='" & trncode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[day]", addsuffix(CInt(Now.Day))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[month]", CDate(Now).ToString("MMMM")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[year]", CDate(Now).ToString("yyyy")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[borrower]", UCase(rst("borrowername").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[receivedby]", UCase(rst("trnname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position]", UCase(rst("designation").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", UCase(rst("borroweroffice").ToString)), False)
        End While
        rst.Close()
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GeneratePropertyAcknowledgementReceipt(ByVal accountable As String, ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal generateid As Boolean, ByVal form As Windows.Forms.Form)
        Dim details As String = "" : Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\PropertyAcknowledgementReceipt.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\" & RemoveSpecialCharacter(accountable) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim ffeid As String = ""
        For I = 0 To grid.SelectedRowsCount - 1
            ffeid += " id='" & grid.GetRowCellValue(grid.GetSelectedRows(I), "Entry Code").ToString & "' or "
        Next

        If generateid = True Then
            Dim vno As String = getSeriesNo("PAR", Now.Year.ToString, "tbldepedics")
            Dim controlno As String = Now.Year.ToString & "-" & vno
            Dim seriesno = vno
            com.CommandText = "insert into tbldepedics set template='PAR', yeartrn='" & Now.Year.ToString & "', seriesno='" & seriesno & "', controlno='" & controlno & "', dateissue=current_date" : com.ExecuteNonQuery()
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[parno]", controlno), False)
            com.CommandText = "update tblofficeequipment set issuereference='PAR " & controlno & "' where accountable='" & accountable & "' and unitcost >15000 and " & ffeid.Remove(ffeid.Length - 3, 3) : com.ExecuteNonQuery()
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[parno]", ""), False)
        End If

        Dim totalrow As Integer = 22
        com.CommandText = "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as 'propertynumber',(select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as model from tblofficeequipment where accountable='" & accountable & "' and unitcost >15000 and " & ffeid.Remove(ffeid.Length - 3, 3) : rst = com.ExecuteReader
        details = " <table style='width:100%; margin:3px 0; border: 1px solid;' >  "
        details += "<tr><th>Quantity</th>" _
                    + " <th>Unit</th>" _
                    + " <th>Description</th>" _
                    + " <th>Property</br>Number</th>" _
                    + " <th>Date</br>Acquired</th>" _
                    + " <th>Amount</th><tr>" & Chr(13)
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'>" & rst("Unit").ToString & "</td> " _
                           + " <td><b><u>" & UCase(rst("Productname").ToString) & "</u></b></br>Model: " & rst("model").ToString & "</br>Serial #: " & rst("serialnumber").ToString & "</br>" & rst("productdetails").ToString.Replace(vbCrLf, "</br>") & "</td> " _
                           + " <td align='center'>" & rst("propertynumber").ToString & "</td> " _
                           + " <td align='center'>" & rst("dateacquired").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("totalcost").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            totalrow = totalrow - 1
        End While
        rst.Close()


        extraRow += "<tr> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>***NOTHING FOLLOWS***</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                    + " </tr> " & Chr(13)
        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = details + TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & accountable & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[entity]", UCase(rst("office").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[acctname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[acctposition]", rst("designation").ToString), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now).ToString("MM/dd/yyyy")), False)
       
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub


    Public Sub GeneratePropertyCard(ByVal productid As String, ByVal productname As String, ByVal category As String, ByVal templatecode As String, ByVal form As Windows.Forms.Form)
        Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0 : Dim extraRow As String = ""
        'CreateHTMLReportTemplate("InventoryDepedTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\PropertyCard.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVENTORY\property-" & productid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim totalrow As Integer = 22
        com.CommandText = "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as 'propertynumber', (select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as office from tblofficeequipment where productid='" & productid & "'" : rst = com.ExecuteReader
        While rst.Read

            TableRow += "<tr align='center'> " _
                            + " <td>" & rst("dateacquired").ToString & "</td> " _
                            + " <td>" & rst("issuereference").ToString & "</td> " _
                            + " <td>" + rst("quantity").ToString + "</td> " _
                            + " <td>" + rst("quantity").ToString + "</td> " _
                            + " <td align='left'>" + rst("office").ToString + "</td> " _
                            + " <td>0</td> " _
                            + " <td align='right'>" & FormatNumber(rst("totalcost").ToString, 2) & "</td> " _
                            + " <td>" & rst("propertynumber").ToString & "</td> " _
                      + "</tr> "

            totalrow = totalrow - 1
        End While
        rst.Close()
        extraRow += "<tr> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center' colspan='3'>***NOTHING FOLLOWS***</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                          + " <td align='center'>&nbsp;</td> " _
                    + " </tr> " & Chr(13)
        For I = 0 To totalrow
            extraRow += "<tr> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                           + " <td align='center'>&nbsp;</td> " _
                     + " </tr> " & Chr(13)
        Next
        TableTransaction = TableRow + extraRow
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[productid]", productid), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[productname]", productname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[category]", category), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[template]", templatecode), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub


    Public Function getSeriesNo(ByVal template As String, ByVal year As String, ByVal table As String)
        Dim strng As Integer = 1 : Dim newNumber As String = "" : Dim NumberLen As Integer = 3
        com.CommandText = "select seriesno from " & table & " where template='" & template & "' and yeartrn='" & year & "' and cancelled=0 order by seriesno desc limit 1" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 10 Then
                newNumber = "0000000000" & strng
            ElseIf a = 9 Then
                newNumber = "000000000" & strng
            ElseIf a = 8 Then
                newNumber = "00000000" & strng
            ElseIf a = 7 Then
                newNumber = "0000000" & strng
            ElseIf a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        Return newNumber
    End Function


End Module
