Imports MySql.Data.MySqlClient

Module Inventory
    Public Function UpdateInventory(ByVal trntype As String, ByVal ponumber As String, ByVal officeid As String, ByVal vendorid As String, ByVal stockhouseid As String, ByVal productid As String, ByVal quantity As Double, ByVal purchaseprice As Double, ByVal remarks As String, ByVal refnumber As String, ByVal invoice As String, ByVal datepurchase As Date)
        Dim inventoryMode As String = "" : Dim catid As String = "" : Dim categoryname As String = "" : Dim subcatid As String = "" : Dim subcategoryname As String = "" : Dim productname As String = "" : Dim prepaid As Boolean : Dim unit As String = "" : Dim calcsellrate As Double = 0 : Dim sellingprice As Double = 0
        com.CommandText = "select *,(select description from tblprocategory where catid = tblglobalproducts.catid) as category, " _
            + " (select description from tblprosubcategory where subcatid=tblglobalproducts.subcatid) as subcategory, " _
            + " (select prepaid from tblprocategory where catid = tblglobalproducts.catid) as prepaid from tblglobalproducts where productid='" & productid & "'" : rst = com.ExecuteReader()
        While rst.Read
            catid = rst("catid").ToString
            categoryname = rst("category").ToString
            subcatid = rst("subcatid").ToString
            subcategoryname = rst("subcategory").ToString
            productname = rst("itemname").ToString + If(rst("partnumber").ToString = "", "", " " + rst("partnumber").ToString)
            unit = rst("unit").ToString
            calcsellrate = Val(rst("calcsellrate").ToString)
            sellingprice = Val(rst("sellingprice").ToString)
            prepaid = rst("prepaid")
        End While
        rst.Close()

        If CBool(qrysingledata("consumable", "consumable", "tblprocategory where catid='" & catid & "'")) = True Then
            'consumable inventory
            inventoryMode = qrysingledata("inventorymethod", "inventorymethod", "tblcompoffice where officeid='" & officeid & "'")
            If inventoryMode = "lifo" Then
                If countqry("tblinventory", "productid='" & productid & "' and officeid='" & officeid & "'") > 0 Then
                    UpdateConsumableInventory(trntype, ponumber, officeid, stockhouseid, catid, categoryname, subcatid, subcategoryname, productid, productname, prepaid, quantity, unit, purchaseprice, calcsellrate, sellingprice, remarks, officeid, refnumber, invoice, datepurchase)
                Else
                    InsertConsumableInventory(trntype, ponumber, officeid, stockhouseid, catid, categoryname, subcatid, subcategoryname, productid, productname, prepaid, quantity, unit, purchaseprice, calcsellrate, sellingprice, remarks, vendorid, refnumber, invoice, datepurchase)
                End If
            ElseIf inventoryMode = "fifo" Then
                InsertConsumableInventory(trntype, ponumber, officeid, stockhouseid, catid, categoryname, subcatid, subcategoryname, productid, productname, prepaid, quantity, unit, purchaseprice, calcsellrate, sellingprice, remarks, vendorid, refnumber, invoice, datepurchase)
            End If
            com.CommandText = "update tblitemvendor set procost='" & purchaseprice & "',lastupdate=current_timestamp where itemid='" & productid & "' and vendorid = '" & vendorid & "' and officeid='" & officeid & "'" : com.ExecuteNonQuery()
        End If
        Return True
    End Function

    Public Function UpdateFFEInventory(ByVal mode As String, ByVal ffecodeEdit As String, ByVal reference As String, ByVal officeid As String, ByVal stockhouseid As String, ByVal vendorid As String, ByVal productid As String, ByVal quantity As Double, ByVal purchaseprice As Double, ByVal datepurchase As String, ByVal warranty As Boolean, ByVal datewarranty As String, ByVal manualdepreciation As Boolean, ByVal bookvalue As Double, ByVal monthlydep As Double, ByVal deplastupdate As String, ByVal accountableperson As String, ByVal accountablenote As String, ByVal dateissue As String, ByVal flaged As Boolean, ByVal flagedreason As String, ByVal blocked As Boolean, ByVal ffedetails As DataGridView)
        Dim FFEQuery As String = "" : Dim FFEcode As String = "" : Dim catid As String = "" : Dim categoryname As String = "" : Dim productname As String = "" : Dim unit As String = "" : Dim ffetype As String = ""
        com.CommandText = "select *,(select description from tblprocategory where catid = tblglobalproducts.catid) as category from tblglobalproducts where productid='" & productid & "'" : rst = com.ExecuteReader()
        While rst.Read
            catid = rst("catid").ToString
            categoryname = rst("category").ToString
            productname = rst("itemname").ToString + If(rst("partnumber").ToString = "", "", " " + rst("partnumber").ToString)
            unit = rst("unit").ToString
            ffetype = rst("ffetype").ToString
        End While
        rst.Close()

        If mode = "new" Then
            FFEcode = getInventoryFFECodeSequence()
        Else
            FFEcode = ffecodeEdit
        End If
        FFEQuery = "ffecode='" & FFEcode & "', " _
                        + " ffetype='" & ffetype & "', " _
                        + " reference='" & reference & "', " _
                        + " officeid='" & officeid & "', " _
                        + " stockhouseid='" & stockhouseid & "', " _
                        + " productid='" & productid & "', " _
                        + " productname='" & rchar(productname) & "', " _
                        + " catid='" & catid & "', " _
                        + " categoryname='" & rchar(categoryname) & "', " _
                        + " quantity='" & Val(CC(quantity)) & "', " _
                        + " unit='" & unit & "', " _
                        + " unitcost='" & Val(purchaseprice) & "', " _
                        + " totalamount='" & Val(purchaseprice) * Val(quantity) & "', " _
                        + " vendorid='" & vendorid & "', " _
                        + " datepurchased=" & If(datepurchase = "", "current_date", "'" & datepurchase & "'") & "," _
                        + " warranty=" & warranty & ", " _
                        + " warrantydate=" & If(warranty = True And datewarranty <> "", "'" & datewarranty & "'", "null") & ", " _
                        + " manualdepreciation=" & manualdepreciation & ", " _
                        + " bookvalue='" & If(manualdepreciation = True, Val(bookvalue), "0") & "', " _
                        + " monthlydepreciation='" & If(manualdepreciation = True, Val(monthlydep), "0") & "', " _
                        + " lastdepreciationdate=" & If(manualdepreciation = True, "'" & ConvertDate(deplastupdate) & "'", "null") & ", " _
                        + " acctablepersonid='" & accountableperson & "', " _
                        + " acctableperson='" & qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'") & "', " _
                        + " acctdateissued=" & If(accountableperson <> "", "'" & dateissue & "'", "null") & ", " _
                        + " flaged=" & flaged & ", " _
                        + " flagedreason='" & rchar(flagedreason) & "', " _
                        + " blocked=" & blocked & ""

        If mode = "new" Then
            com.CommandText = "INSERT INTO tblinventoryffe SET " & FFEQuery & ", trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            LogFFEHistory(FFEcode, "added new inventory via manual entry")
        Else
            com.CommandText = "UPDATE tblinventoryffe SET " & FFEQuery & " where ffecode='" & FFEcode & "'" : com.ExecuteNonQuery()
            LogFFEHistory(FFEcode, "update inventory via manual entry")
        End If

        'Accountable Person Settings
        If accountableperson <> "" Then
            If mode = "new" Then
                com.CommandText = "insert into tblinventoryffeaccountable set ffecode='" & FFEcode & "', acctableperson='" & accountableperson & "',accountname='" & qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'") & "', dateissued='" & dateissue & "', note='" & accountablenote & "', iscurrent=1,issueby='" & globaluserid & "'" : com.ExecuteNonQuery()
                LogFFEHistory(FFEcode, "added accountable person " & StrConv(qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'"), vbProperCase) & " date issued on " & CDate(dateissue).ToString("MMMM dd, yyyy") & If(accountablenote.Length > 0, " - " & accountablenote, ""))
                'Else
                '    If countqry("tblinventoryffeaccountable", " ffecode='" & FFEcode & "' and iscurrent=1") = 0 Then
                '        com.CommandText = "insert into tblinventoryffeaccountable set ffecode='" & FFEcode & "', acctableperson='" & accountableperson & "',accountname='" & qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'") & "', dateissued='" & dateissue & "', note='" & accountablenote & "', iscurrent=1,issueby='" & globaluserid & "'" : com.ExecuteNonQuery()
                '        LogFFEHistory(FFEcode, "added accountable person " & StrConv(qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'"), vbProperCase) & " date issued on " & CDate(dateissue).ToString("MMMM dd, yyyy") & If(accountablenote.Length > 0, " - " & accountablenote, ""))
                '    Else
                '        com.CommandText = "UPDATE tblinventoryffeaccountable set acctableperson='" & accountableperson & "',accountname='" & qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'") & "', dateissued='" & dateissue & "', note='" & accountablenote & "', issueby='" & globaluserid & "' where ffecode='" & FFEcode & "' and iscurrent=1" : com.ExecuteNonQuery()
                '        LogFFEHistory(FFEcode, "update accountable person " & StrConv(qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & accountableperson & "'"), vbProperCase) & " date issued on " & CDate(dateissue).ToString("MMMM dd, yyyy") & If(accountablenote.Length > 0, " - " & accountablenote, ""))
                '    End If
            End If
        End If


        If mode = "new" And countqry("tblglobalproducts", "productid='" & productid & "' and ffetype=''") > 0 Then
            com.CommandText = "UPDATE tblglobalproducts set ffetype='" & ffetype & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
        End If

        'update ffe other details
        Dim otherdetails As String = ""
        If Not ffedetails Is Nothing Then
            Dim UpdateDetails As Boolean = False
            For Each all As DataGridViewRow In ffedetails.Rows
                If all.Cells("Value").Value <> "" Then
                    UpdateDetails = True
                End If
            Next
            If UpdateDetails = True Then
                com.CommandText = "DELETE from tblinventoryffedetails where ffecode='" & FFEcode & "'" : com.ExecuteNonQuery()
                For Each rw As DataGridViewRow In ffedetails.Rows
                    If Not rw.Cells("Description").Value Is Nothing Then
                        com.CommandText = "insert into tblinventoryffedetails set productid='" & productid & "', ffecode='" & FFEcode & "',ffetype='" & ffetype & "',sortorder=" & rw.Cells("sortorder").Value.ToString & ", fieldname='" & rchar(rw.Cells("fieldname").Value.ToString) & "', description='" & rchar(rw.Cells("Description").Value.ToString) & "', value='" & rchar(rw.Cells("Value").Value.ToString) & "',required=" & CBool(rw.Cells("required").Value.ToString) & "" : com.ExecuteNonQuery()
                    End If
                    otherdetails = otherdetails + rchar(rw.Cells("Description").Value.ToString) + ": " + rchar(rw.Cells("Value").Value.ToString) + Chr(13)
                Next
                LogFFEHistory(FFEcode, "update ffe other details " & Chr(13) + Chr(13) + otherdetails)
            End If
        End If
    End Function

    Public Function UpdateDepreciationInventory(ByVal officeid As String)
        Dim dst As New DataSet
        msda = New MySqlDataAdapter("Select *,timestampdiff(month, datepurchased, current_date) as 'AsMonth', " _
                                            + " format(PERIOD_DIFF(date_format(current_date,'%Y%m'),date_format(datepurchased,'%Y%m'))/12,1) as `AsYear`, " _
                                            + " timestampdiff(month, lastdepreciationdate, current_date) as 'manualmonthdelay' " _
                                            + " from tblinventoryffe inner join tbldeprecitionofassets on tblinventoryffe.catid=tbldeprecitionofassets.catid and  tblinventoryffe.ffetype=tbldeprecitionofassets.ffetype where (month(lastdepreciationdate) < month(current_date) or year(lastdepreciationdate) < year(current_date) or lastdepreciationdate is null) and officeid='" & officeid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If CBool(.Rows(cnt)("manualdepreciation").ToString()) = True Then
                    com.CommandText = "update tblinventoryffe set age='-', bookvalue=" & Val(CC(DepreciationManual(.Rows(cnt)("bookvalue").ToString(), .Rows(cnt)("monthlydepreciation").ToString(), .Rows(cnt)("manualmonthdelay").ToString()))) & ",lastdepreciationdate=current_date   where ffecode='" & .Rows(cnt)("ffecode").ToString() & "'" : com.ExecuteNonQuery()
                Else
                    If .Rows(cnt)("depmode").ToString() = "0" Then
                        com.CommandText = "update tblinventoryffe set age='" & .Rows(cnt)("AsYear").ToString() & " Year(s)', bookvalue=" & Val(CC(DepreciationReduce(.Rows(cnt)("total").ToString(), .Rows(cnt)("AsYear").ToString(), .Rows(cnt)("depvalue").ToString()))) & ",lastdepreciationdate=current_date  where ffecode='" & .Rows(cnt)("ffecode").ToString() & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "update tblinventoryffe set age='" & .Rows(cnt)("AsMonth").ToString() & " Month(s)', bookvalue=" & Val(CC(DepreciationStraight(.Rows(cnt)("totalamount").ToString(), .Rows(cnt)("AsMonth").ToString(), .Rows(cnt)("depvalue").ToString()))) & ",monthlydepreciation='" & .Rows(cnt)("totalamount").ToString() / (.Rows(cnt)("depvalue").ToString() * 12) & "', lastdepreciationdate=current_date where ffecode='" & .Rows(cnt)("ffecode").ToString() & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End With
        Next
    End Function

    Public Function DepreciationReduce(ByVal unitcost As Double, ByVal age As Double, ByVal rate As Double) As Double
        DepreciationReduce = unitcost
        For I = 0 To age - 1
            Dim year1depn = DepreciationReduce * (rate / 100)
            DepreciationReduce = DepreciationReduce - year1depn
        Next
        Return DepreciationReduce
    End Function

    Public Function DepreciationStraight(ByVal unitcost As Double, ByVal age As Double, ByVal NumberOfYears As Double) As Double
        Dim value As Double = 0 : Dim bookValue As Double = 0
        If NumberOfYears > 0 Then
            Dim devidedRate = unitcost / (NumberOfYears * 12)
            DepreciationStraight = 0
            Dim asMonth As Double = age
            For I = 0 To asMonth - 1
                DepreciationStraight = DepreciationStraight + devidedRate
            Next
            value = unitcost - DepreciationStraight
            If value > 0 Then
                bookValue = value
            Else
                bookValue = 1
            End If
        Else
            bookValue = 0
        End If
        Return bookValue
    End Function

    Public Function DepreciationManual(ByVal bookedvalue As Double, ByVal monthlydep As Double, ByVal manualmonthdelay As Double) As Double
        Dim newBookedValue As Double = 0
        Dim totaldepreciate As Double = 0
        For I = 0 To manualmonthdelay - 1
            totaldepreciate = totaldepreciate + monthlydep
        Next
        If bookedvalue > totaldepreciate Then
            newBookedValue = bookedvalue - totaldepreciate
        Else
            newBookedValue = 1
        End If
        Return newBookedValue
    End Function

    Public Function InsertConsumableInventory(ByVal trntype As String, ByVal stockref As String, ByVal officeid As String, ByVal stockhouseid As String, ByVal catid As String, ByVal categoryname As String, ByVal subcatid As String, ByVal subcategoryname As String, ByVal productid As String, ByVal productname As String, ByVal prepaid As Boolean, ByVal quantity As Double, ByVal unit As String, ByVal purchaseprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal remarks As String, ByVal reqoffice As String, ByVal refnumber As String, ByVal invoice As String, ByVal dateinventory As Date)
        com.CommandText = "INSERT INTO `tblinventory` set officeid='" & officeid & "', stockref='" & stockref & "', " _
                                + " stockhouseid='" & If(stockhouseid = "", "default", stockhouseid) & "', " _
                                + " catid='" & catid & "', " _
                                + " categoryname='" & rchar(categoryname) & "', " _
                                + " subcatid='" & subcatid & "', " _
                                + " subcatname='" & rchar(subcategoryname) & "', " _
                                + " productid='" & productid & "', " _
                                + " productname ='" & rchar(productname) & "', " _
                                + " prepaid=" & prepaid & ", " _
                                + " quantity='" & quantity & "', " _
                                + " unit='" & unit & "', " _
                                + " purchasedprice='" & purchaseprice & "', " _
                                + " calcsellrate='" & calcsellrate & "', " _
                                + " sellingprice='" & sellingprice & "', " _
                                + " lastupdate='" & ConvertDate(dateinventory) & "', " _
                                + " lasttrnby='" & globaluserid & "', " _
                                + " dateinventory='" & ConvertDate(dateinventory) & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblglobalproducts set purchasedprice='" & purchaseprice & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
        LogInventoryLedger(trntype, officeid, productid, quantity, 0, purchaseprice, remarks, reqoffice, refnumber, invoice, dateinventory)
        Return True
    End Function

    Public Function UpdateConsumableInventory(ByVal trntype As String, ByVal stockref As String, ByVal officeid As String, ByVal stockhouseid As String, ByVal catid As String, ByVal categoryname As String, ByVal subcatid As String, ByVal subcategoryname As String, ByVal productid As String, ByVal productname As String, ByVal prepaid As Boolean, ByVal quantity As Double, ByVal unit As String, ByVal purchaseprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal remarks As String, ByVal reqoffice As String, ByVal refnumber As String, ByVal invoice As String, ByVal dateinventory As Date)
        com.CommandText = "UPDATE `tblinventory` set  stockref='" & stockref & "', " _
                                + " catid='" & catid & "', " _
                                + " categoryname='" & rchar(categoryname) & "', " _
                                + " subcatid='" & subcatid & "', " _
                                + " subcatname='" & rchar(subcategoryname) & "', " _
                                + " productid='" & productid & "', " _
                                + " productname ='" & rchar(productname) & "', " _
                                + " prepaid=" & prepaid & ", " _
                                + " quantity=quantity+" & quantity & ", " _
                                + " unit='" & unit & "', " _
                                + " purchasedprice='" & purchaseprice & "', " _
                                + " calcsellrate='" & calcsellrate & "', " _
                                + " sellingprice='" & sellingprice & "', " _
                                + " lastupdate='" & ConvertDate(dateinventory) & "', " _
                                + " lasttrnby='" & globaluserid & "' " _
                                + " where productid='" & productid & "' and officeid='" & officeid & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblglobalproducts set purchasedprice='" & purchaseprice & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
        LogInventoryLedger(trntype, officeid, productid, quantity, 0, purchaseprice, remarks, reqoffice, refnumber, invoice, dateinventory)
        Return True
    End Function

    Public Function StockoutInventory(ByVal trntype As String, ByVal trnid As String, ByVal officeid As String, ByVal productid As String, ByVal quantity As Double, ByVal unitcost As Double, ByVal remarks As String, ByVal reqoffice As String, ByVal refnumber As String, ByVal invoice As String, ByVal dateinventory As Date)
        com.CommandText = "update tblinventory set quantity=quantity-" & quantity & " where trnid='" & trnid & "'" : com.ExecuteNonQuery()
        LogInventoryLedger(trntype, officeid, productid, 0, quantity, unitcost, remarks, reqoffice, refnumber, invoice, dateinventory)
        Return True
    End Function

    Public Function StockinInventory(ByVal trntype As String, ByVal trnid As String, ByVal officeid As String, ByVal productid As String, ByVal quantity As Double, ByVal unitcost As Double, ByVal remarks As String, ByVal reqoffice As String, ByVal refnumber As String, ByVal invoice As String, ByVal dateinventory As Date)
        com.CommandText = "update tblinventory set quantity=quantity+" & quantity & " where trnid='" & trnid & "'" : com.ExecuteNonQuery()
        LogInventoryLedger(trntype, officeid, productid, quantity, 0, unitcost, remarks, reqoffice, refnumber, invoice, dateinventory)
        Return True
    End Function

    Public Function GetFirstInFirstOutUnitCost(ByVal officeid As String, ByVal productid As String, ByVal quantity As Double) As Array
        Dim GetResultValue(2) As String
        GetResultValue(0) = "Winter"
        GetResultValue(1) = "Bugahod"
        Return GetResultValue
    End Function

    Public Function LogInventoryLedger(ByVal trntype As String, ByVal officeid As String, ByVal productid As String, ByVal debit As Double, ByVal credit As Double, ByVal unitcost As Double, ByVal remarks As String, ByVal reqoffice As String, ByVal refnumber As String, ByVal invoice As String, ByVal dateinventory As Date)
        com.CommandText = "insert into tblinventoryledger set officeid='" & officeid & "', productid='" & productid & "', trntype='" & trntype & "', debit=" & debit & ",credit=" & credit & ",cost=" & unitcost & ", remarks='" & rchar(remarks) & "',reqoffice='" & reqoffice & "',referenceno='" & refnumber & "',invoiceno='" & invoice & "', datetrn='" & ConvertDateTime(dateinventory) & "', trnby='" & StrConv(globalfullname, vbProperCase) & "'" : com.ExecuteNonQuery()
        Return True
    End Function

    Public Function LogFFEHistory(ByVal ffecode As String, ByVal remarks As String)
        com.CommandText = "insert into tblinventoryffehistory set ffecode='" & ffecode & "', remarks='" & rchar(remarks) & "', datetrn=current_timestamp, trnby='" & StrConv(globalfullname, vbProperCase) & "'" : com.ExecuteNonQuery()
        Return True
    End Function
    Public Function getInventoryFFECodeSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select cffecodesequence from tblgeneralsettings where companycode='" & GlobalOrganizationCode & "' " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("cffecodesequence").ToString.Length
            strng = Val(rst("cffecodesequence").ToString) + 1
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
        com.CommandText = "update tblgeneralsettings set cffecodesequence='" & newNumber & "'  where companycode='" & GlobalOrganizationCode & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function UpdateInventoryInfo(ByVal productid As String, ByVal productname As String, ByVal codename As String, ByVal catid As String, ByVal subcatid As String, ByVal unit As String, ByVal sellingprice As Double)
        Dim GetCategoryname As String = qrysingledata("description", "description", "tblprocategory where catid='" & catid & "'")
        Dim GetSubCategoryname As String = qrysingledata("description", "description", "tblprosubcategory where subcatid='" & subcatid & "'")

        com.CommandText = "update tblinventory set productname='" & rchar(productname) & "', catid='" & catid & "',subcatid='" & subcatid & "',subcatname='" & GetSubCategoryname & "', categoryname='" & rchar(GetCategoryname) & "', unit='" & unit & "', sellingprice=" & sellingprice & "  where productid='" & productid & "' and quantity > 0 " : com.ExecuteNonQuery()
        com.CommandText = "update tblofficeequipment set productname='" & rchar(productname) & "', codename='" & codename & "', catid='" & catid & "',subcatid='" & subcatid & "', unit='" & unit & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblpurchaseorderitem set itemname='" & rchar(productname) & "', catid='" & catid & "' where productid='" & productid & "' and delivered = 0 " : com.ExecuteNonQuery()
    End Function

    Public Function UpdateProductImage(ByVal productid As String, img As DevExpress.XtraEditors.PictureEdit, form As DevExpress.XtraEditors.XtraForm)
        UpdateImage("productid='" & productid & "'", "imgdata", "filedir.tblproductimage", img, form)
    End Function


    Public Function PrintFFeMR(ByVal ffecode As String, ByVal form As Form)
        Dim reportBody As String = "" : Dim rowRowTable As String = "" : Dim RowFooter As String = ""

        Dim AccountablePerson As String = "" : Dim accountableOfficename As String = "" : Dim DateIssue As Date = Nothing : Dim issuecode As String = "" : Dim IssueNote As String = "" : Dim DateRecorded As String = "" : Dim RecordedBy As String = ""
        Dim office As String = "" : Dim ProductName As String = "" : Dim Category As String = "" : Dim FFEType As String = "" : Dim Quantity As Integer = 0 : Dim UnitCost As Double = 0 : Dim Total As Double = 0 : Dim UnitType As String = ""
        Dim bookvalue As Double = 0 : Dim monthlydepreciation As Double = 0 : Dim depreciationLastUpdate As String = ""

        com.CommandText = "call sp_feeprofile('PROFILE','" & ffecode & "')" : rst = com.ExecuteReader
        While rst.Read
            office = rst("office").ToString
            DateRecorded = rst("datetrn").ToString
            RecordedBy = rst("recby").ToString
            AccountablePerson = rst("acctableperson").ToString
            accountableOfficename = rst("accountableOfficename").ToString
            DateIssue = rst("acctdateissued").ToString
            IssueNote = rst("IssueNote").ToString
            issuecode = rst("issuecode").ToString
            ProductName = rst("productname").ToString
            Category = rst("categoryname").ToString
            FFEType = rst("ffetypes").ToString
            Quantity = rst("quantity").ToString
            UnitCost = rst("UnitCost").ToString
            Total = rst("totalamount").ToString
            UnitType = rst("unit").ToString

            bookvalue = rst("bookvalue").ToString
            monthlydepreciation = rst("monthlydepreciation").ToString
            depreciationLastUpdate = rst("lastdepreciationdate").ToString
        End While
        rst.Close()

        CreateHTMLReportTemplate("AssetProfile.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\AssetProfile.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\FFE " & ffecode & " - " & rchar(ProductName) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)

        reportBody += "<table border='1' cellpadding='3' cellspacing='0' style='border-collapse:collapse;'> " _
                                     + " <tr> " _
                                         + " <td width='233'>FFE CODE</td> " _
                                         + " <td width='233'>DATE RECORDED</td> " _
                                         + " <td>RECORDED BY</td> " _
                                     + " </tr> " _
                                     + " <tr> " _
                                         + " <td style='padding: 4px' align='center' width='233'><b>" & ffecode & "</b></td> " _
                                         + " <td style='padding: 4px' align='center' width='233'><b>" & CDate(DateRecorded).ToString("MMMM dd, yyyy") & "</b></td> " _
                                         + " <td style='padding: 4px' align='center'><b>" & RecordedBy & "</b></td> " _
                                     + " </tr> "
        reportBody += "</table><br/>"

        reportBody += "<b>DESCRIPTION OF EQUIPMENT</b><br/>"
        reportBody += "<table border='1' cellpadding='3' cellspacing='0' style='border-collapse:collapse;'> " _
                                + " <tr> " _
                                       + " <td colspan='2'>ITEM NAME</td> " _
                                       + " <td>UNIT CATEGORY</td> " _
                                       + " <td>ASSET TYPE</td> " _
                                   + " </tr> " _
                                    + " <tr> " _
                                       + " <td style='padding: 4px' colspan='2' align='center'><b>" & ProductName & "</b></td> " _
                                       + " <td style='padding: 4px' align='center'><b>" & Category & "</b></td> " _
                                       + " <td style='padding: 4px' align='center'><b>" & FFEType & "</b></td> " _
                                   + " </tr> " _
                                   + " <tr> " _
                                       + " <td width='175'>QUANTITY</td> " _
                                       + " <td width='175'>UNIT COST</td> " _
                                       + " <td width='175'>TOTAL</td> " _
                                       + " <td width='175'>UNIT TYPE</td> " _
                                   + " </tr> " _
                                   + " <tr> " _
                                       + " <td style='padding: 4px' align='center' width='175'><b>" & Quantity & "</b></td> " _
                                       + " <td style='padding: 4px' align='center' width='175'><b>" & FormatNumber(UnitCost, 2) & "</b></td> " _
                                       + " <td style='padding: 4px' align='center' width='175'><b>" & FormatNumber(Total, 2) & "</b></td> " _
                                       + " <td style='padding: 4px' align='center' width='175'><b>" & UnitType & "</b></td> " _
                                   + " </tr> "
        reportBody += "</table><br/>"

        reportBody += "<b>OTHER DETAILS</b><br/>"
        reportBody += "<table border='1' cellpadding='3' cellspacing='0' style='border-collapse:collapse;'> "
        com.CommandText = "call sp_feeprofile('DETAILS','" & ffecode & "')" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                        + " <td style='padding: 4px' >" & rst("description").ToString & "</td> " _
                        + " <td style='padding: 4px' align='center'>" & rst("value").ToString & "</td> " _
                + " </tr>"
        End While
        rst.Close()
        reportBody += rowRowTable + "</table><br/>"

        reportBody += "<b>ACCOUNTABILITY ASSETS</b><br/>"
        reportBody += "<table border='1' cellpadding='3' cellspacing='0' style='border-collapse:collapse;'> " _
                                  + " <tr> " _
                                      + " <td  width='233'>ACCOUNTABLE PERSON</td> " _
                                      + " <td width='233'>DEPARTMENT/OFFICE</td> " _
                                      + " <td>DATE ISSUED</td> " _
                                  + " </tr> " _
                                   + " <tr> " _
                                      + " <td style='padding: 4px' align='center' width='233'><b>" & AccountablePerson & "</b></td> " _
                                      + " <td style='padding: 4px' align='center' width='233'><b>" & accountableOfficename & "</b></td> " _
                                      + " <td style='padding: 4px' align='center'><b>" & DateIssue & "</b></td> " _
                                  + " </tr> "
        reportBody += "</table><br/>"

        reportBody += "<b>DEPRECIATION OF ASSETS</b><br/>"
        reportBody += "<table border='1' cellpadding='3' cellspacing='0' style='border-collapse:collapse;'> " _
                                  + " <tr> " _
                                      + " <td width='233'>BOOK VALUE</td> " _
                                      + " <td width='233'>MONTHLY DEPRECIATION</td> " _
                                      + " <td>LAST DEPRECIATION DATE </td> " _
                                  + " </tr> " _
                                   + " <tr> " _
                                      + " <td style='padding: 4px' align='center' width='233'>" & FormatNumber(bookvalue, 2) & "</td> " _
                                      + " <td style='padding: 4px' align='center' width='233'>" & FormatNumber(monthlydepreciation, 2) & "</td> " _
                                      + " <td style='padding: 4px' align='center'>" & depreciationLastUpdate & "</td> " _
                                  + " </tr> "
        reportBody += "</table><br/>"


        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", reportBody), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", IssueNote), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globaldesignation)), False)
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        Return 0
    End Function

    'Inventory script
    'UpdateInventory("Purchase order", GridView1.GetFocusedRowCellValue("trnid").ToString, .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("cost").ToString())), "Purchase Order #" + GridView1.GetFocusedRowCellValue("trnid").ToString)
    'StockoutInventory("Inventory Stockout", id.Text, officeid.Text, productid, Val(CC(txtquantity.Text)), txtRemarks.Text)
End Module
