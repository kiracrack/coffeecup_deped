Module Procurement
    Public Sub PrintDisbursementVoucher(ByVal vouchercode As String, ByVal form As Form, ByVal PrintFile As Boolean)
        Dim TableRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementVoucherTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\VOUCHER\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim supplierid As String = "" : Dim ca As Boolean = False : Dim note As String = "" : Dim approved As Boolean = False
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\img\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGeneral()), False)
        com.CommandText = "select *,(select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company',(select digitalsign from tblaccounts where accountid=tbldisbursementvoucher.trnby) as signature, date_format(voucherdate,'%M %d, %Y') as trndate,(select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as fund, (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as vendor from tbldisbursementvoucher where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("vendorid").ToString : ca = CBool(rst("ca").ToString) : note = rst("note").ToString : approved = CBool(rst("verified"))
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[check_payment]", If(CBool(rst("check").ToString) = True, "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash_payment]", If(CBool(rst("cash").ToString) = True, "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash_advance]", If(CBool(rst("ca").ToString) = True, "checked='yes'", "")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkno]", If(CBool(rst("check").ToString) = True, rst("checkno").ToString, "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[bankname]", If(CBool(rst("check").ToString) = True, rst("fund").ToString, "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkdate]", If(CBool(rst("check").ToString) = True, rst("checkdate").ToString, "")), False)

            'Prepared Signatories
            picbox.Image = Nothing
            ConvertDatabaseImage("signature", picbox)
            If Not picbox.Image Is Nothing Then
                If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png") = True Then
                    System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png")
                End If
                picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png", System.Drawing.Imaging.ImageFormat.Png)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedsig]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & globaluserid & ".png' style='width: 200px;'>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedsig]", "<br/><br/><br/>"), False)
            End If

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(globalfullname)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedposition]", StrConv(globaldesignation, VbStrConv.ProperCase)), False)

        End While
        rst.Close()

        'supplier
        If ca = True Then
            com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("fullname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("office").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliertitle]", "Department"), False)
            End While
            rst.Close()
        Else
            com.CommandText = "select * from tblglobalvendor where vendorid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("companyname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("compadd").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliertitle]", "Address"), False)
            End While
            rst.Close()
        End If


        'Voucher Item
        TableRow = "" : Dim total As Double = 0 : Dim cnt As Integer = 0
        TableRow += "<tr> " _
                    + " <td style='padding: 5px' align='center' width='15%'><b>Date</b></td> " _
                    + If(ca = True, "<td style='padding: 5px' align='center' ><b>Supplier</b></td>", "") _
                    + " <td style='padding: 5px' align='center' width='15%'><b>PO Number</b></td> " _
                    + " <td style='padding: 5px' align='center' ><b>Note</b></td> " _
                    + If(ca = True, "", "<td style='padding: 5px' align='center' width='15%'><b>Invoice No</b></td>") _
                    + " <td style='padding: 5px' align='right'  width='18%'><b>Amount</b></td> " _
                + " </tr>"
        com.CommandText = "select Supplier, ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', date_format(datetrn,'%Y-%m-%d') as 'Date', invoiceno, amount,Note from tbldisbursementdetails where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("date").ToString & "</td> " _
                           + If(ca = True, "<td style='padding: 5px'>" & StrConv(rst("Supplier").ToString, VbStrConv.ProperCase) & "</td>", "") _
                           + " <td align='center'>" & rst("PO Number").ToString & "</td> " _
                           + " <td>" & rst("Note").ToString & "</td> " _
                            + If(ca = True, "", "<td align='center'>" & rst("invoiceno").ToString & "</td>") _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("amount").ToString)
            cnt += 1
        End While
        rst.Close()

        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode and companyid=tbldisbursementexpense.companyid) as item from tbldisbursementexpense where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center' style='padding: 5px' >" & rst("date").ToString & "</td> " _
                           + " <td colspan='3'>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("amount").ToString)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 6 - cnt
            TableRow += "<tr> " _
                         + " <td style='padding: 5px' >&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next
        TableRow += "<tr> " _
                       + " <td colspan='4' style='padding:5px'><span style='vertical-align: top; float:left; font-size: 12px;'>Amount in words:</span><br/><b>" & StrConv(ConvertCurrencyToEnglish(total), VbStrConv.Uppercase) & "</b></td> " _
                       + " <td align='right' style='padding:5px; font-weight:bold;font-size: 14px;'>" & FormatNumber(total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        If note.Length > 5 Then
            TableRow += "<tr> " _
                      + " <td colspan='5' style='padding:5px'>NOTE: " & note & "</td> " _
                + " </tr> " & Chr(13)
        End If

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)

        'Prepared Signatories
        If GLobalEnableElectronicVoucher = True Then
            'fill the signatory name
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name,(select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where authorizedid not in (select confirmid FROM `tblapprovalhistory` where referenceno='" & vouchercode & "' and approvaltype='voucher' and applevel<>'-') and apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", UCase(rst("name").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()

            'fill the approved name
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.confirmid) as signature, confirmby as name,position FROM `tblapprovalhistory` as a where referenceno='" & vouchercode & "' and approvaltype='voucher' and applevel<>'-' and status='approved' order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                picbox.Image = Nothing
                ConvertDatabaseImage("signature", picbox)
                If Not picbox.Image Is Nothing Then
                    If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png") = True Then
                        System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png")
                    End If
                    picbox.Image = CropImageHeight(picbox.Image)
                    picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & rst("confirmid").ToString & ".png' style='width: 200px;'>"), False)
                Else
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                End If

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", UCase(rst("name").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()
        Else
            com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name,(select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
            While rst.Read
                picbox.Image = Nothing
                ConvertDatabaseImage("signature", picbox)
                If Not picbox.Image Is Nothing Then
                    If approved = True Then
                        If System.IO.File.Exists(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png") = True Then
                            System.IO.File.Delete(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png")
                        End If
                        picbox.Image = CropImageHeight(picbox.Image)
                        picbox.Image.Save(Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
                        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<img src='" & Application.StartupPath.ToString & "\Templates\" & rst("authorizedid").ToString & ".png' style='width: 200px;'>"), False)
                    Else
                        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                    End If
                Else
                    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approversig" & rst("level").ToString & "]", "<br/><br/><br/>"), False)
                End If

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", UCase(rst("name").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
            End While
            rst.Close()
        End If
        If PrintFile = True Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        Else
            SavePDFCopy(SaveLocation, Application.StartupPath.ToString & "\Transaction\VOUCHER\Voucher " & vouchercode & ".pdf")
        End If
    End Sub
    Public Function CropImageHeight(ByVal img As Image) As Image
        CropImageHeight = Nothing
        If Not img Is Nothing Then
            Dim hg As Integer = 60
            Dim CropRect As New Rectangle(0, (img.Height / 2) - (hg / 2), 200, hg)
            Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
            Using grp = Graphics.FromImage(CropImage)
                grp.DrawImage(img, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
            End Using
            CropImageHeight = CropImage
        End If
        Return CropImageHeight
    End Function

   
    Public Function SavePDFCopy(ByVal htmlfile As String, ByVal PDFfile As String)
        Dim htmlToPdf = New NReco.PdfGenerator.HtmlToPdfConverter()
        htmlToPdf.Zoom = 2
        htmlToPdf.GeneratePdfFromFile(htmlfile, Nothing, PDFfile)
        Return True
    End Function
End Module
