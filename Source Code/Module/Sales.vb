Imports MySql.Data.MySqlClient

Module Sales
    Public Function EncrypGridColumnNumbers(ByVal ColumnValue As String, ByVal ColumnName As String) As String
        If GlobalEnableEncryptNumbers = True And EnableModuleSales = True Then
            EncrypGridColumnNumbers = ", replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(cast(format(" & ColumnValue & ",2) as char(200)),'1','" & GlobalEncrptVal1 & "'),'2','" & GlobalEncrptVal2 & "'),'3','" & GlobalEncrptVal3 & "'),'4','" & GlobalEncrptVal4 & "'),'5','" & GlobalEncrptVal5 & "'),'6','" & GlobalEncrptVal6 & "'),'7','" & GlobalEncrptVal7 & "'),'8','" & GlobalEncrptVal8 & "'),'9','" & GlobalEncrptVal9 & "'),'0','" & GlobalEncrptVal0 & "') as '" & ColumnName & "' "
        Else
            EncrypGridColumnNumbers = ""
        End If
        Return EncrypGridColumnNumbers
    End Function

    Public Sub GenerateLXCashiersBlotter(ByVal trnsumcode As String, ByVal form As Windows.Forms.Form)
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0 : Dim TotalCheck As Double = 0 : Dim TotalCard As Double = 0 : Dim TotalOnline As Double = 0 : Dim TotalVoucher As Double = 0 : Dim TotalCTR As Double = 0 : Dim TotalCTA As Double = 0 : Dim TotalComplimentary As Double = 0 : Dim TotalInterOffice As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\CashiersBlotter.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\BLOTTER\" & trnsumcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD CASH REPORT
        Dim cash As Boolean = False : Dim TableCash As String = ""
        Dim table_left As String = "" : Dim table_right As String = ""

        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & trnsumcode & "','');" : com.ExecuteNonQuery()

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tmpconsolidated order by id asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            If CBool(st.Tables(0).Rows(nt)("rptviewleft").ToString()) = True Then
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_left += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_left += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString), 2) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_left += "<tr><td></td><td align='right'><u><b>" & FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2) & "</b></u></td></tr>"
                End If
            Else
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_right += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_right += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString), 2) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_right += "<tr><td></td><td align='right'><u><b>" & FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2) & "</b></u></td></tr>"
                End If
            End If
        Next


        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\img\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[left_transaction]", table_left), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[right_transaction]", table_right), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[trnsumcode]", trnsumcode), False)

        com.CommandText = "select *,date_format(dateclose, '%M %d, %Y %r') as DateClosed, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as cashier,(select designation from tblaccounts where accountid=tblsalessummary.userid) as position,(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as office from tblsalessummary where trncode='" & trnsumcode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashier]", rst("cashier").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datetrn]", rst("dateopen").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashbeg]", FormatNumber(Val(rst("begcash").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash]", FormatNumber(Val(rst("begcash").ToString) + TotalCash, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("office").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(rst("cashier").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(rst("position").ToString)), False)

            If rst("DateClosed").ToString <> "" Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", rst("DateClosed").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", CDate(Now)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
            End If
          
        End While
        rst.Close()
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXCashiersRemittance(ByVal trnsumcode As String, ByVal form As Windows.Forms.Form)
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0 : Dim TotalCheck As Double = 0 : Dim TotalCard As Double = 0 : Dim TotalOnline As Double = 0 : Dim TotalVoucher As Double = 0 : Dim TotalCTR As Double = 0 : Dim TotalCTA As Double = 0 : Dim TotalComplimentary As Double = 0 : Dim TotalInterOffice As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\CashiersRemittance.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\BLOTTER\" & trnsumcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD CASH REPORT
        Dim cash As Boolean = False : Dim TableCash As String = ""
        Dim TablCashHead As String = "" : Dim TableCashRow As String = "" : Dim TableCashFooter As String = ""
        TablCashHead = "<table border='1'> " _
                     + " <tr> " _
                         + " <th style='padding: 10px' colspan='5'>CASH TRANSACTION</th> " _
                     + " </tr> " _
                     + " <tr> " _
                         + " <th>Reference</th> " _
                         + " <th>Guest</th> " _
                         + If(EnableModuleHotel = True, " <th>Folio</th> ", "") _
                         + " <th>Amount</th> " _
                         + " <th>Remarks</th> " _
                     + " </tr> " & Chr(13)

        com.CommandText = "call sp_salesremittance('CASH','" & trnsumcode & "','');" : rst = com.ExecuteReader
        While rst.Read
            TableCashRow += "<tr> " _
                           + " <td align='center'>" & rst("reference").ToString & "</td> " _
                           + " <td >" & rst("guest").ToString & "</td> " _
                           + If(EnableModuleHotel = True, " <td align='center'>" & rst("folio").ToString & "</td> ", "") _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                           + " <td>" & rst("remarks").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            TotalCash = TotalCash + Val(rst("amount").ToString)
        End While
        rst.Close()

        TableCashRow += "<tr> " _
                        + " <td align='right' colspan='3'>Total</td> " _
                        + " <td align='right'>" & FormatNumber(TotalCash, 2) & "</td> " _
                        + " <td></td> " _
                 + " </tr> " & Chr(13)
        TableCashFooter = "</table>"
        TableCash = TablCashHead + TableCashRow + TableCashFooter

        'LOAD CHECK REPORT
        Dim check As Boolean = False : Dim TableCheck As String = ""
        com.CommandText = "call sp_salesremittance('CHECK','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            check = True
        End If
        rst.Close()
        If check = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='7'>CHECK TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Client</th> " _
                             + " <th>Check No</th> " _
                             + " <th>Bank Check</th> " _
                             + " <th>Check Date</th> " _
                             + " <th>Account Name</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CHECK','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("reference").ToString & "</td> " _
                               + " <td >" & rst("client").ToString & "</td> " _
                               + " <td align='center'>" & rst("checkno").ToString & "</td> " _
                               + " <td align='center'>" & rst("bankcheck").ToString & "</td> " _
                               + " <td align='center'>" & rst("checkdate").ToString & "</td> " _
                               + " <td >" & rst("accountname").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCheck = TotalCheck + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='6'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCheck, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCheck = TableHead + TableRow + TableFooter
        End If


        'LOAD CARD REPORT
        Dim card As Boolean = False : Dim TableCard As String = ""
        com.CommandText = "call sp_salesremittance('CARD','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            card = True
        End If
        rst.Close()
        If card = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CARD TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Card Type</th> " _
                             + " <th>Trace No</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CARD','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("carddetails").ToString & "</td> " _
                               + " <td align='center'>" & rst("tracenumber").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td >" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCard = TotalCard + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCard, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCard = TableHead + TableRow + TableFooter
        End If

        'LOAD ONLINE REPORT
        Dim online As Boolean = False : Dim TableOnline As String = ""
        com.CommandText = "call sp_salesremittance('ONLINE','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            online = True
        End If
        rst.Close()
        If online = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>ONLINE TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Guest</th> " _
                             + " <th>Account</th> " _
                             + " <th>Reference No.</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('ONLINE','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='center'>" & rst("account").ToString & "</td> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalOnline = TotalOnline + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='4'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalOnline, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableOnline = TableHead + TableRow + TableFooter
        End If

        'LOAD VOUCHER PAYMENT REPORT
        Dim voucher As Boolean = False : Dim TableVoucher As String = ""
        com.CommandText = "call sp_salesremittance('VOUCHER','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            voucher = True
        End If
        rst.Close()
        If voucher = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>VOUCHER PAYMENT TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Guest</th> " _
                             + " <th>Voucher No.</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('VOUCHER','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='center'>" & rst("voucherno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalVoucher = TotalVoucher + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalVoucher, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableVoucher = TableHead + TableRow + TableFooter
        End If

        'LOAD CTR REPORT
        Dim ctr As Boolean = False : Dim TableCTR As String = ""
        com.CommandText = "call sp_salesremittance('CTR','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            ctr = True
        End If
        rst.Close()
        If ctr = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CHARGE TO ROOM TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th width='100'>Reference</th> " _
                             + " <th>Room Number</th> " _
                             + " <th>Guest</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CTR','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("roomno").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCTR = TotalCTR + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCTR, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCTR = TableHead + TableRow + TableFooter
        End If

        'LOAD CTA REPORT
        Dim cta As Boolean = False : Dim TableCTA As String = ""
        com.CommandText = "call sp_salesremittance('CTA','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            cta = True
        End If
        rst.Close()
        If cta = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CHARGE TO ACCOUNT TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Invoice No.</th> " _
                             + " <th>Account</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CTA','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("account").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCTA = TotalCTA + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCTA, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCTA = TableHead + TableRow + TableFooter
        End If


        'LOAD COMPLIMENTARY REPORT
        Dim complimentary As Boolean = False : Dim TableComplimentary As String = ""
        com.CommandText = "call sp_salesremittance('COMPLIMENTARY','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            complimentary = True
        End If
        rst.Close()
        If complimentary = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='4'>COMPLIMENTARY TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Remarks</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('COMPLIMENTARY','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("batchcode").ToString & "</td> " _
                               + " <td>" & rst("complimentaryremarks").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalComplimentary = TotalComplimentary + Val(rst("total").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td colspan='2' align='right'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalComplimentary, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableComplimentary = TableHead + TableRow + TableFooter
        End If


        'LOAD INTER OFFICE TRANSACTION
        Dim interoffice As Boolean = False : Dim TableInterOffice As String = ""
        com.CommandText = "call sp_salesremittance('IO','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            interoffice = True
        End If
        rst.Close()
        If interoffice = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='6'>INTER OFFICE TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Transaction Name</th> " _
                             + " <th>Details</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('IO','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("trnno").ToString & "</td> " _
                               + " <td>" & rst("itemname").ToString & "</td> " _
                               + " <td>" & rst("due").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalInterOffice = TotalInterOffice + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td colspan='3' align='right'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalInterOffice, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableInterOffice = TableHead + TableRow + TableFooter
        End If

        TableTransaction = If(TableCash.Length > 0, TableCash & "</br>", "") _
                            & If(TableCheck.Length > 0, TableCheck & "</br>", "") _
                            & If(TableCard.Length > 0, TableCard & "</br>", "") _
                            & If(TableOnline.Length > 0, TableOnline & "</br>", "") _
                            & If(TableVoucher.Length > 0, TableVoucher & "</br>", "") _
                            & If(TableCTR.Length > 0, TableCTR & "</br>", "") _
                            & If(TableCTA.Length > 0, TableCTA & "</br>", "") _
                            & If(TableComplimentary.Length > 0, TableComplimentary & "</br>", "") _
                            & If(TableInterOffice.Length > 0, TableInterOffice & "</br>", "")

        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\img\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[trnsumcode]", trnsumcode), False)
        com.CommandText = "select *,date_format(dateclose, '%M %d, %Y %r') as DateClosed, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as cashier,(select designation from tblaccounts where accountid=tblsalessummary.userid) as position,(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as office from tblsalessummary where trncode='" & trnsumcode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashier]", rst("cashier").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datetrn]", rst("dateopen").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashbeg]", FormatNumber(Val(rst("begcash").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash]", FormatNumber(Val(rst("begcash").ToString) + TotalCash, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("office").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(rst("cashier").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(rst("position").ToString)), False)

            If rst("DateClosed").ToString <> "" Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", rst("DateClosed").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", CDate(Now)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
            End If

        End While
        rst.Close()

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub


End Module
