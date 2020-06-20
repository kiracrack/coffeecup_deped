Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module MailService
    Public Function FormattingEmailBody(ByVal value As String) As String
        value = value.Replace(vbCrLf, "<br/>")
        value = value.Replace(vbCr, "")
        value = value.Replace("Ñ", "&Ntilde;")
        value = value.Replace("ñ", "&ntilde;")
        value = value.Replace("  -  ", "&nbsp; &nbsp; - &nbsp; &nbsp;")
        Return value
    End Function

    Public Function getEmailAccount(ByVal userid As String) As String
        getEmailAccount = qrysingledata("emailaddress", "emailaddress", "where accountid='" & userid & "'", "tblaccounts")
        Return getEmailAccount
    End Function

    Public Function getOfficeEmail(ByVal officeid As String) As String
        getOfficeEmail = qrysingledata("officeemail", "officeemail", "where officeid='" & officeid & "'", "tblcompoffice")
        Return getOfficeEmail
    End Function

    Public Sub InsertEmailNotification(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String, ByVal CommandQuery As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(FormattingEmailBody(emailbody + "<br/><br/><b>" + globalfullname + "</b><br/>" + globaldesignation + "<br/>" + globalEmailaddress + "<br/><br/>" _
                                + "<em color=""grey"">*This is a coffeecup system generated email and use for notification only. To view full transaction, please login on coffeecup system. thank you*</em>")) & "'" : com.ExecuteNonQuery()
        End If
        If CommandQuery <> "" Then
            com.CommandText = CommandQuery : com.ExecuteNonQuery()
        End If
    End Sub

#Region "E M A I L   T E M P L A T E"

    Public Function FormatingEmailRequisition(ByVal pid As String, ByVal RequestTitle As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailRequisition = ""
        com.CommandText = "select *, " _
                    + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as 'office', " _
                    + " (select fullname from tblaccounts where accountid = tblrequisitions.requestby) as 'requester' , " _
                    + " (select DESCRIPTION from tblrequesttype where potypeid=tblrequisitions.potypeid) as 'RequestType', " _
                    + " date_format(DATEREQUEST,'%Y-%m-%d %r') as 'DateRequest', " _
                    + " case when corporatelevel=1 then 'CORPORATE LEVEL' else 'BRANCH LEVEL ' end as 'approvinglevel', " _
                    + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'TotalAmount' " _
                    + " from tblrequisitions where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            FormatingEmailRequisition = "Requisition #: " & rst("pid").ToString _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Request By: " & rst("requester").ToString _
                           + "<br/>Request Type: " & rst("RequestType").ToString _
                           + "<br/>Date Request: " & rst("DateRequest").ToString _
                           + "<br/>Approving Level: " & rst("approvinglevel").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("TotalAmount").ToString, 2) _
                           + "<br/>Request Justification: " & rst("details").ToString _
                           + "<br/>" _
                           + "<br/>Transaction Details: " & RequestTitle & "" _
                           + "<br/>Reference #: " & rst("trnrefno").ToString & "" _
                           + "<br/><br/>"
        End While
        rst.Close()

        FormatingEmailRequisition += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Particular</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Category</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Quantity</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Unit</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Unit Cost</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Total Cost</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Remarks</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Vendor</th> " _
                                        + " </tr>"

        com.CommandText = "Select  *, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("Particular").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("Category").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("QUANTITY").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("UNIT").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("COST").ToString, 2) & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("TOTAL").ToString, 2) & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("Remarks").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("Vendor").ToString & "</td> " _
                                       + " </tr>"
        End While
        rst.Close()
        FormatingEmailRequisition += rowRowTable + "</table>"
        Return FormatingEmailRequisition
    End Function

    Public Function FormatingEmailPurchaseOrder(ByVal ponumber As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailPurchaseOrder = ""

        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblpurchaseorder.officeid ) as 'office', " _
                                 + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                                 + " (select sum(total) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber) as 'Total' " _
                                 + " from tblpurchaseorder where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
        While rst.Read
            FormatingEmailPurchaseOrder = "<br/>PO NUmber: " & ponumber _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Supplier: " & rst("Supplier").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("Total").ToString, 2) _
                           + "<br/>" _
                           + "<br/>Request Reference #: " & rst("requestref").ToString _
                           + "<br/><br/>"
        End While
        rst.Close()

        FormatingEmailPurchaseOrder += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Particular</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Category</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Quantity</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Unit</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Unit Cost</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Total Cost</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Remarks</th> " _
                                        + " </tr>"

        com.CommandText = "Select *,(select description from tblprocategory where CATID = tblpurchaseorderitem.catid) as category from tblpurchaseorderitem where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("itemname").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("category").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("quantity").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("unit").ToString & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                                           + " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & rst("remarks").ToString & "</td> " _
                                       + " </tr>"
        End While
        rst.Close()
        FormatingEmailPurchaseOrder += rowRowTable + "</table>"
        Return FormatingEmailPurchaseOrder
    End Function

    Public Function FormatingEmailAccountsPayable(ByVal voucherno As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailAccountsPayable = ""
        Dim ca As Boolean = False
        com.CommandText = "select *,(select officename from tblcompoffice where officeid =tbldisbursementvoucher.officeid ) as 'office', " _
                                 + " if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Supplier', " _
                                 + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as fund " _
                                 + " from tbldisbursementvoucher where voucherno='" & voucherno & "'" : rst = com.ExecuteReader
        While rst.Read
            ca = CBool(rst("ca"))
            FormatingEmailAccountsPayable = "<br/>Request No: " & voucherno _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Claimant: " & rst("Supplier").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("amount").ToString, 2) _
                           + "<br/>Source of Fund: " & rst("fund").ToString _
                           + "<br/>Note: " & rst("note").ToString _
                           + "<br/><br/>"
        End While
        rst.Close()
        FormatingEmailAccountsPayable += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Date</th> " _
                                            + If(ca = True, " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Supplier</th> ", "") _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>PO Number</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Note</th> " _
                                            + If(ca = True, "", " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Invoice No.</th> ") _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Amount</th> " _
                                        + " </tr>"
        Dim Total As Double = 0
        com.CommandText = "select *, date_format(datetrn,'%Y-%m-%d') as 'Date' from tbldisbursementdetails where voucherno='" & voucherno & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("Date").ToString & "</td> " _
                                + If(ca = True, " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & StrConv(rst("supplier").ToString, VbStrConv.ProperCase) & "</td> ", "") _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("ponumber").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px; width: 300px'>" & rst("note").ToString & "</td> " _
                                + If(ca = True, "", " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("invoiceno").ToString & "</td> ") _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + " </tr>"
            Total = Total + Val(rst("amount").ToString)
        End While
        rst.Close()
        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode and companyid=tbldisbursementexpense.companyid) as item from tbldisbursementexpense where voucherno='" & voucherno & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("Date").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px; width: 300px' colspan='3'>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + " </tr>"
            Total = Total + Val(rst("amount").ToString)
        End While
        rst.Close()

        rowRowTable += "<tr> " _
                              + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right' colspan='4'>TOTAL</td> " _
                              + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(Total, 2) & "</td> " _
                      + " </tr>"
        FormatingEmailAccountsPayable += rowRowTable + "</table>"
        Return FormatingEmailAccountsPayable
    End Function
    Public Function SendDueCheckStats()
        Dim SalesReports As String = ""
        'FormatingEmailRequisition = "<head><style>table, th, td { border: 1px solid black;} </style></head>"
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where notifycheckdue=1", "tblaccounts")
        If EmailList.Length > 1 Then
            SalesReports = ""
            SalesReports = "Hello Admin; " _
                      + "<br/><br/>Reminding you that all check transaction of " & compname _
                      + " listed below will be due.." _
                      + "<br/><br/>"

            SalesReports += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                     + " <tr> " _
                                                          + " <th style='padding: 0 5px' colspan='7'>Check transaction</th> " _
                                                     + " </tr>" _
                                                     + " <tr> " _
                                                          + " <th style='padding: 0 5px'>Check Type</th> " _
                                                          + " <th style='padding: 0 5px'>Payee/Payor</th> " _
                                                          + " <th style='padding: 0 5px'>Check Number</th> " _
                                                          + " <th style='padding: 0 5px'>Issuer Bank</th> " _
                                                          + " <th style='padding: 0 5px'>Account Name</th> " _
                                                          + " <th style='padding: 0 5px'>Due Date</th> " _
                                                          + " <th style='padding: 0 5px'>Amount</th> " _
                                                     + " </tr>"
            Dim TableRowValue As String = "" : Dim TotalAmount As Double = 0
            dst = New DataSet
            msda = New MySqlDataAdapter("select 'Check receivable' as 'checktype',(select lcase(companyname) from tblclientaccounts where cifid = accountno)  as 'PayeePayor',checkno, checkdetails as 'issuerbank', Remarks as 'accountname',date_format(checkdate,'%Y-%m-%d') as 'CheckDate', Amount from tblsaleschecktransaction where verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 union all " _
                                     + " select 'Check receivable','Check Encashment', checknumber,issuerbank,companyname,if(checkdate='0000-00-00','-',date_format(checkdate,'%Y-%m-%d')),amount from tblsaleschecktocash where verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 union all " _
                                     + " select 'Check payment',(select lcase(companyname) from tblglobalvendor where vendorid = accountno),checkno, checkdetails, Remarks, date_format(checkdate,'%Y-%m-%d'), Amount from tblpayablechecktransaction where verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ;", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    TableRowValue += "<tr> " _
                                                + " <td style='padding: 0 5px'>" & .Rows(cnt)("checktype").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px'>" & .Rows(cnt)("PayeePayor").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & .Rows(cnt)("checkno").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & .Rows(cnt)("issuerbank").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & .Rows(cnt)("accountname").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & .Rows(cnt)("CheckDate").ToString() & "</td> " _
                                                + " <td style='padding: 0 5px' align='right'>" & FormatNumber(.Rows(cnt)("Amount").ToString(), 2) & "</td> " _
                                     + " </tr> "
                    TotalAmount = TotalAmount + Val(.Rows(cnt)("Amount").ToString())
                End With
            Next
            TableRowValue += "<tr><td style='padding: 0 5px' colspan='6' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(TotalAmount, 2) & "</td></tr> "
            SalesReports += TableRowValue & "</table><br/><em>NOTE: please use desktop mode to maximized table view..</em><br/>"
            InsertEmailNotification("CHECK", EmailList, "Coffeecup Check Reminder ", SalesReports, "UPDATE tblsaleschecktransaction set notified=1 where cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1; UPDATE tblsaleschecktocash set notified=1 where cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1; UPDATE tblpayablechecktransaction set notified=1 where cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1;")
        End If
        Return True
    End Function

    Public Function SendAttendanceLog()
        Dim HtmlBody As String = ""
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where notifyattendancelog=1", "tblaccounts")
        Dim TableRowValue As String = ""

        dst = New DataSet
        msda = New MySqlDataAdapter("select distinct(date_format(logindate,'%Y-%m-%d')) as dateattendance from tblpayrollattendancelog where notified=0 and logindate<current_date", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                HtmlBody = ""
                HtmlBody = "Hello Admin; " _
                         + "<br/><br/>These are the list of employees of " & compname & " who are logging in for attendance  on " & CDate(.Rows(cnt)("dateattendance").ToString()).ToString("MMMM dd, yyyy") & " with a total of " & qrysingledata("ttl", "count(*) as ttl", "tblpayrollattendancelog where notified=0 and logindate='" & .Rows(cnt)("dateattendance").ToString() & "'") & "  employees  " _
                         + "<br/><br/>"


                Dim office As String = ""
                com.CommandText = "select officeid,(select ucase(officename) as office from tblcompoffice where officeid=tblpayrollattendancelog.officeid) as Office from tblpayrollattendancelog where notified=0 and logindate='" & .Rows(cnt)("dateattendance").ToString() & "' group by officeid order by (select ucase(officename) from tblcompoffice where officeid=tblpayrollattendancelog.officeid) asc;" : rst = com.ExecuteReader
                While rst.Read
                    office += rst("officeid").ToString & ","
                End While
                rst.Close()
                If office.Length > 0 Then
                    office = office.Remove(office.Length - 1, 1)
                End If


                For Each word In office.Split(New Char() {","c})
                    Dim attendanceBody As String = "" : Dim attendanceRow As String = ""
                    Dim no As Integer = 1
                    attendanceBody += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                        + " <tr> " _
                                                             + " <th style='padding: 0 5px' colspan='9'>" & qrysingledata("officename", "officename", "tblcompoffice where officeid='" & word & "'") & "</th> " _
                                                        + " </tr>" _
                                                        + " <tr> " _
                                                             + " <th style='padding: 0 5px'>No.</th> " _
                                                             + " <th style='padding: 0 5px'>Employee Name</th> " _
                                                             + " <th style='padding: 0 5px'>Morning In</th> " _
                                                             + " <th style='padding: 0 5px'>Morning Out</th> " _
                                                             + " <th style='padding: 0 5px'>Noon In</th> " _
                                                             + " <th style='padding: 0 5px'>Noon Out</th> " _
                                                             + " <th style='padding: 0 5px'>Overtime In</th> " _
                                                             + " <th style='padding: 0 5px'>Overtime Out</th> " _
                                                        + " </tr>"
                    com.CommandText = "select *, (select fullname from tblemployees where employeeid =tblpayrollattendancelog.employeeid) as employeename, " _
                            + " date_format(1st_timein,'%r') as 'MorningIN', date_format(1st_timeout,'%r') as 'MorningOut', " _
                            + " date_format(2nd_timein,'%r') as 'AfternoonIN', date_format(2nd_timeout,'%r') as 'AfternoonOut', " _
                            + " date_format(3rd_timein,'%r') as 'OvertimeIN', date_format(3rd_timeout,'%r') as 'OvertimeOUT' from tblpayrollattendancelog where officeid='" & word & "' and notified=0 and logindate='" & .Rows(cnt)("dateattendance").ToString() & "' order by (select fullname from tblemployees where employeeid =tblpayrollattendancelog.employeeid) asc" : rst = com.ExecuteReader
                    While rst.Read
                        attendanceRow += "<tr> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & no & "</td> " _
                                                    + " <td style='padding: 0 5px'>" & rst("employeename").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("MorningIN").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("MorningOut").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("AfternoonIN").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("AfternoonOut").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("OvertimeIN").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("OvertimeOUT").ToString & "</td> " _
                                         + " </tr> "
                        no = no + 1
                    End While
                    rst.Close()
                    attendanceBody += attendanceRow & "</table><br/>"
                    HtmlBody += attendanceBody
                Next


                InsertEmailNotification("ATTENDANCE", EmailList, "Coffeecup Attendance Log " & .Rows(cnt)("dateattendance").ToString(), HtmlBody, "UPDATE tblpayrollattendancelog set notified=1 where notified=0 and logindate='" & .Rows(cnt)("dateattendance").ToString() & "'")
            End With
        Next
       
        Return True
    End Function

    Public Function SendPurchaseOrderForapproval(ByVal ponumber As String, ByVal note As String)
        Dim HtmlBody As String = ""
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where notifyreceivedpostock=1", "tblaccounts")
        Dim TableRowValue As String = ""
        dst = New DataSet
        msda = New MySqlDataAdapter("select *,(select companyname from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'vendor' from tblpurchaseorder where ponumber='" & ponumber & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                HtmlBody = ""
                HtmlBody = "PO Number #: " & .Rows(cnt)("ponumber").ToString() _
                       + "<br/>Supplier: " & .Rows(cnt)("vendor").ToString() _
                       + "<br/><br/>"

                HtmlBody += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                         + " <tr> " _
                                                              + " <th style='padding: 0 5px' colspan='6'>Purchase Order Details</th> " _
                                                         + " </tr>" _
                                                         + " <tr> " _
                                                              + " <th style='padding: 0 5px'>Product</th> " _
                                                              + " <th style='padding: 0 5px'>Quantity</th> " _
                                                              + " <th style='padding: 0 5px'>Unit</th> " _
                                                              + " <th style='padding: 0 5px'>Unit Cost</th> " _
                                                              + " <th style='padding: 0 5px'>Total</th> " _
                                                              + " <th style='padding: 0 5px'>Remarks</th> " _
                                                         + " </tr>"
                Dim TotalTransaction As Double = 0
                com.CommandText = "select  itemname,  Quantity, Unit, cost, Total, Remarks  from tblpurchaseorderitem where ponumber='" & .Rows(cnt)("ponumber").ToString() & "'" : rst = com.ExecuteReader
                While rst.Read
                    TableRowValue += "<tr> " _
                                                + " <td style='padding: 0 5px'>" & rst("itemname").ToString & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & rst("Quantity").ToString & "</td> " _
                                                + " <td style='padding: 0 5px' align='center'>" & rst("Unit").ToString & "</td> " _
                                                + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                                                + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("Total").ToString, 2) & "</td> " _
                                                + " <td style='padding: 0 5px'>" & rst("Remarks").ToString & "</td> " _
                                     + " </tr> "
                    TotalTransaction = TotalTransaction + Val(rst("Total").ToString)
                End While
                rst.Close()
                TableRowValue += "<tr><td style='padding: 0 5px' colspan='4' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(TotalTransaction, 2) & "</td><td style='padding: 0 5px' align='right'></td></tr> "
                HtmlBody += TableRowValue & "</table><br/><br/>"
                HtmlBody += note

                InsertEmailNotification("PO", EmailList, "Purchase Order for Approval PO#" & .Rows(cnt)("ponumber").ToString(), HtmlBody, "")
            End With
        Next
        Return True
    End Function

    Public Function SendReceivedPOStock(ByVal ponumber As String)
        Dim HtmlBody As String = ""
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where notifyreceivedpostock=1", "tblaccounts")
        Dim TableRowValue As String = ""
        If EmailList.Length > 1 Then
            dst = New DataSet
            msda = New MySqlDataAdapter("select *,(select companyname from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'vendor' from tblpurchaseorder where ponumber='" & ponumber & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    HtmlBody = ""
                    HtmlBody = "PO Number #: " & .Rows(cnt)("ponumber").ToString() _
                              + "<br/>Supplier: " & .Rows(cnt)("vendor").ToString() _
                              + "<br/>Date Received: " & CDate(Now.ToShortDateString).ToString("MMMM dd, yyyy") _
                              + "<br/><br/>Invoice #: " & .Rows(cnt)("invoiceno").ToString() _
                              + "<br/>Charges: " & FormatNumber(.Rows(cnt)("charges").ToString(), 2) _
                              + "<br/>Discount: " & FormatNumber(.Rows(cnt)("discount").ToString(), 2) _
                              + "<br/>Total Amount Due: " & FormatNumber(.Rows(cnt)("totalamount").ToString(), 2) _
                              + "<br/><br/>"

                    HtmlBody += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px' colspan='6'>Stock received item</th> " _
                                                             + " </tr>" _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px'>Product</th> " _
                                                                  + " <th style='padding: 0 5px'>Quantity</th> " _
                                                                  + " <th style='padding: 0 5px'>Unit</th> " _
                                                                  + " <th style='padding: 0 5px'>Unit Cost</th> " _
                                                                  + " <th style='padding: 0 5px'>Total</th> " _
                                                                  + " <th style='padding: 0 5px'>Remarks</th> " _
                                                             + " </tr>"
                    Dim TotalTransaction As Double = 0
                    com.CommandText = "select  itemname,  Quantity, Unit, cost, Total, Remarks  from tblpurchaseorderitem where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
                    While rst.Read
                        TableRowValue += "<tr> " _
                                                    + " <td style='padding: 0 5px'>" & rst("itemname").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("Quantity").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("Unit").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                                                    + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("Total").ToString, 2) & "</td> " _
                                                    + " <td style='padding: 0 5px'>" & rst("Remarks").ToString & "</td> " _
                                         + " </tr> "
                        TotalTransaction = TotalTransaction + Val(rst("Total").ToString)
                    End While
                    rst.Close()
                    TableRowValue += "<tr><td style='padding: 0 5px' colspan='4' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(TotalTransaction, 2) & "</td><td style='padding: 0 5px' align='right'></td></tr> "
                    HtmlBody += TableRowValue & "</table><br/><br/>"

                    InsertEmailNotification("PO", EmailList, "Stock Received from PO# " & .Rows(cnt)("ponumber").ToString() & " " & StrConv(.Rows(cnt)("vendor").ToString(), vbProperCase), HtmlBody, "")
                End With
            Next
        End If
        Return True
    End Function

   
    Public Function SendMonthlySummaryReport()
        Dim HtmlBody As String = "" : Dim TableHeader As String = "" : Dim TableRowValue As String = "" : Dim TableFooter As String = "" : Dim total As Double = 0
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where notifymonthlysummary=1", "tblaccounts")

        If EmailList.Length > 1 Then
            dst = New DataSet
            msda = New MySqlDataAdapter("SELECT date_format(dateopen,'%Y-%m') as 'datefilter', concat('Monthly Summary Report - ', date_format(dateopen,'%M %Y')) as 'Report'  FROM `tblsalessummary` where (month(dateopen) < month(current_date) or year(dateopen) < year(current_date)) and notified=0 and concat('Monthly Summary Report - ', date_format(dateopen,'%M %Y')) not in (select `subject` from tblemailnotification) group by date_format(dateopen,'%Y-%M') order by dateopen asc ", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    HtmlBody = ""
                    HtmlBody = "Hello Admin; " _
                             + "<br/><br/>System generated " & StrConv(.Rows(cnt)("Report").ToString(), vbProperCase) _
                             + "<br/><br/>"

                    'generate monthly income statement
                    TableHeader = "" : TableRowValue = "" : TableFooter = ""
                    TableHeader = "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px' colspan='2'>MONTHLY SUMMARY REPORT</th> " _
                                                             + " </tr>" _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px'>Description</th> " _
                                                                  + " <th style='padding: 0 5px'>Total</th> " _
                                                             + " </tr>"

                    com.CommandText = "call sp_monthlysummary('INCOME STATEMENT','" & .Rows(cnt)("datefilter").ToString() & "')" : rst = com.ExecuteReader
                    While rst.Read
                        TableRowValue += "<tr> " _
                                                    + " <td style='padding: 0 5px'>" & rst("Description").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='right'>" & FormatNumber(Val(rst("Total").ToString), 2) & "</td> " _
                                     + " </tr> "
                    End While
                    rst.Close()
                    TableFooter = "</table><br/><br/>"
                    HtmlBody += TableHeader + TableRowValue + TableFooter

                    'generate client accounts summary
                    TableHeader = "" : TableRowValue = "" : TableFooter = "" : total = 0
                    TableHeader = "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px' colspan='3'>ACCOUNTS RECEIVABLE SUMMARY</th> " _
                                                             + " </tr>" _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px'>Company Name</th> " _
                                                                  + " <th style='padding: 0 5px'>Pending Invoice</th> " _
                                                                  + " <th style='padding: 0 5px'>Balance</th> " _
                                                             + " </tr>"

                    com.CommandText = "call sp_monthlysummary('CLIENT ACCOUNT','" & .Rows(cnt)("datefilter").ToString() & "')" : rst = com.ExecuteReader
                    While rst.Read
                        TableRowValue += "<tr> " _
                                                    + " <td style='padding: 0 5px'>" & rst("companyname").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("invoice").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("balance").ToString, 2) & "</td> " _
                                     + " </tr> "
                        total = total + Val(rst("balance").ToString)
                    End While
                    rst.Close()
                    TableFooter = "<tr> " _
                                                    + " <td style='padding: 0 5px' colspan='2'><strong>TOTAL</strong></td> " _
                                                    + " <td style='padding: 0 5px' align='right'><strong>" & FormatNumber(total, 2) & "</strong></td> " _
                                     + " </tr></table><br/><br/> "
                    HtmlBody += TableHeader + TableRowValue + TableFooter

                    'generate payable accounts summary
                    TableHeader = "" : TableRowValue = "" : TableFooter = "" : total = 0
                    TableHeader = "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px' colspan='3'>ACCOUNTS PAYABLE SUMMARY</th> " _
                                                             + " </tr>" _
                                                             + " <tr> " _
                                                                  + " <th style='padding: 0 5px'>Company Name</th> " _
                                                                  + " <th style='padding: 0 5px'>Pending PO</th> " _
                                                                  + " <th style='padding: 0 5px'>Balance</th> " _
                                                             + " </tr>"

                    com.CommandText = "call sp_monthlysummary('PAYABLE ACCOUNT','" & .Rows(cnt)("datefilter").ToString() & "')" : rst = com.ExecuteReader
                    While rst.Read
                        TableRowValue += "<tr> " _
                                                    + " <td style='padding: 0 5px'>" & rst("companyname").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='center'>" & rst("po").ToString & "</td> " _
                                                    + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("balance").ToString, 2) & "</td> " _
                                     + " </tr> "
                        total = total + Val(rst("balance").ToString)
                    End While
                    rst.Close()
                    TableFooter = "<tr> " _
                                                    + " <td style='padding: 0 5px' colspan='2'><strong>TOTAL</strong></td> " _
                                                    + " <td style='padding: 0 5px' align='right'><strong>" & FormatNumber(total, 2) & "</strong></td> " _
                                     + " </tr></table><br/><br/> "
                    HtmlBody += TableHeader + TableRowValue + TableFooter

                    InsertEmailNotification("SUMMARY", EmailList, StrConv(.Rows(cnt)("Report").ToString(), vbProperCase), HtmlBody, "UPDATE tblsalessummary set notified=1 where (month(dateopen) < month(current_date) or year(dateopen) < year(current_date)) and notified=0;")
                End With
            Next
        End If
       
        Return True
    End Function

    Public Function SendSystemUpdateNotification(ByVal version As String, ByVal updateDescription As String)
        Dim HtmlBody As String = "" : Dim TableHeader As String = "" : Dim TableRowValue As String = "" : Dim TableFooter As String = "" : Dim total As Double = 0
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where emailaddress like '%@%' and deleted=0", "tblaccounts")

        If EmailList.Length > 1 And updateDescription.Length > 5 Then
            HtmlBody = "Hello Admin; " _
                     + "<br/><br/>Your coffeecup system has been updated to version v" & version & "." _
                     + "<br/><br/><strong>v" & version & " update logs: </strong> " _
                     + "<br/> " & updateDescription
            InsertEmailNotification("UPDATE", EmailList, "New System Update v" & version, HtmlBody, "")
        End If
        Return True
    End Function

    Public Function SendSystemActivationStatus(ByVal macaddress As String, ByVal DateExpiration As String)
        Dim HtmlBody As String = "" : Dim TableHeader As String = "" : Dim TableRowValue As String = "" : Dim TableFooter As String = "" : Dim total As Double = 0
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where emailaddress like '%@%' and deleted=0", "tblaccounts")

        If EmailList.Length > 1 Then
            HtmlBody = "Hello Admin; " _
                     + "<br/><br/>Congratulation! your coffeecup system has been activated!" _
                     + "<br/><br/>Company Name:  " & compname _
                     + "<br/>Machine No:  " & macaddress _
                     + "<br/>Date Expiry:  " & DateExpiration

            InsertEmailNotification("Activated " & DateExpiration, EmailList, "System is Activated (" & macaddress & ")", HtmlBody, "")
        End If
        Return True
    End Function

    Public Function SendSystemExpired(ByVal macaddress As String, ByVal DateExpired As String)
        Dim HtmlBody As String = "" : Dim TableHeader As String = "" : Dim TableRowValue As String = "" : Dim TableFooter As String = "" : Dim total As Double = 0
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "where emailaddress like '%@%' and deleted=0", "tblaccounts")

        If EmailList.Length > 1 Then
            HtmlBody = "Hello Admin; " _
                     + "<br/><br/>Your system was expired!" _
                     + "<br/><br/>Company Name:  " & compname _
                     + "<br/>Machine No:  " & macaddress _
                     + "<br/>Date Expired:  " & DateExpired _
                     + "<br/><br/>To continue your subscription please contact your system administrator at: " _
                     + "<br/>Cellphone #: +639174519772 " _
                     + "<br/>Email: <a href=""mailto:winterbugahod@yahoo.com"">winterbugahod@yahoo.com</a>" _
                     + "<br/>Facebook: <a href=""https://facebook.com/kiracrack"">Winter Sevilla Bugahod</a>"
            If countqry("tblemailnotification", "trntype='Expired " & DateExpired & "'") = 0 Then
                InsertEmailNotification("Expired " & DateExpired, EmailList, "System is Expired (" & macaddress & ")", HtmlBody, "")
            End If
        End If
        Return True
    End Function

#End Region


End Module
