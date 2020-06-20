Module General_Settings
    Public ReportHeaderImg As Image = Nothing
    Public ReportFooterImg As Image = Nothing
    Public GlobalSystemStartDate As String = ""
    Public GlobalOfficeCaption As String = ""
    Public GlobalFiletypeSupport As String = "All files (*.*)|*.*"
    Public GlobalAllowableAttachSize As Double = 0

    Public AppSinglePrepared As Boolean
    Public AppPreparedId As String
    Public AppPreparedTitle As String
    Public AppPreparedName As String
    Public ApppreparedPosition As String

    Public AppEnableCheckedby As Boolean
    Public AppCheckedId As String
    Public AppCheckedTitle As String
    Public AppCheckedName As String
    Public AppCheckedPosition As String

    Public AppEnableapprovedby As Boolean
    Public AppApprovedId As String
    Public AppApprovedTitle As String
    Public AppApprovedName As String
    Public AppApprovedPosition As String

    Public AppEnableBeginvendor As String
    Public AppBeginvendorName As String
    Public AppBeginvendorId As String

    Public GlobalEnableApprover As Boolean
    Public GlobalEnableImageRaportHeader As Boolean

    'Declaration of email settings
    Public globalEmailNotification As Boolean
    Public globalsmtpHost As String
    Public globalsmtpPort As String
    Public globalsslEnable As String
    Public globalserverEmailAddress As String
    Public globaltargetEmailAddress As String
    Public globalemailPassword As String

    Public GlobalCloudBackup As Boolean
    Public GlobalCloudHost As String
    Public GlobalCloudUser As String
    Public GlobalCloudPassword As String

    Public GlobalEnableStockHouse As Boolean
    Public GlobalEnablebarcode As Boolean
    Public GlobalEnableOfficeReportHeader As Boolean
    Public GlobalEnableCopyright As Boolean
    Public GlobalEnableCffeBatch As Boolean
    Public GlobalStrictAttachment As Boolean
    Public GlobalBackupDir As String

    Public GlobalDirectApprovedPr As Boolean
    Public GlobalDirectApprovedPo As Boolean
    Public GlobalPOExpiry As Integer
    Public Globalenableservertimer As Boolean
    Public GlobalenableProductFilter As Boolean
    Public GlobalProductTemplate As Integer
    Public Globalenablechittransaction As Boolean
    Public Globalenablesaleinvoicenumber As Boolean
    Public Globalprintstatementledgertype As Boolean
    Public Globaldirectponumbersequence As String
    Public GlobalEnableponumbersequence As Boolean
    Public GLobalPoPaymentSequence As Boolean
    Public GlobalEmailNotifySales As Boolean
    Public GlobalEmailNotifyCheckdue As Boolean
    Public GlobalEmailNotifyAttendancelog As Boolean
    Public GLobalEmailNotifyReceivedPOstock As Boolean
    Public GLobalEmailNotifyAutoServices As Boolean
    Public GlobalEmailNotifyBanksLedger As Boolean
    Public GlobalEmailNotifyMonthlySummary As Boolean
    Public GlobalEnableConsumableAdjustment As Boolean
    Public GlobalEnableVouchernumbersequence As Boolean
    Public GlobalFFEmemorandumagreement As String
    Public GlobalEnableClinicsServices As Boolean
    Public GlobalDigitalPaymentApproving As Boolean
    Public GlobalClientStockReceiving As Boolean
    Public GlobalEnableVoucherPaymentPosting As Boolean
    Public Globalallowdisbursepobybatch As Boolean
    Public Globaldefaultdiscountcategory As String
    Public Globalstockouttitle As String
    Public GlobalReportTemplate As String
    Public Globaldefaultroomoccupieddirty As String
    Public GLobalenablepoceosign As Boolean
    Public Globalceoaccountid As String
    Public Globalenableprocurementid As Boolean
    Public Globalprocurementid As String

    Public GlobalGLExpensesCode As String
    Public GlobalGLSalesCode As String
    Public GlobalGLIncomeCode As String
    Public GlobalGLaccountspayableCode As String
    Public GlobalGLARCode As String
    Public GlobalPaymentGLItemCode As String
    Public GLobalGLItemCreditCard As String
    Public GLobalGLItemPurchaseOrder As String
    Public GlobalPaymentDiscountGLItemCode As String
    Public GlobalPOPaymentGLItemCode As String
    Public GlobalPOPaymentDiscountGLItemCode As String
    Public GlobalTaxRate As Double
    Public GlobalBankBegGLItemCode As String
    Public GlobalGLOverages As String
    Public GlobalGLShortages As String
    Public GlobalGLCheckDeposit As String
    Public GlobalGLCheckPayment As String
    Public GlobalGLVoucherCode As String
    Public GLobalGLItemOnlinePayment As String
    Public GLobalEnableElectronicVoucher As Boolean

    'Declaration of POS number encryption
    Public GlobalEnableEncryptNumbers As Boolean
    Public GlobalEncrptVal1 As String
    Public GlobalEncrptVal2 As String
    Public GlobalEncrptVal3 As String
    Public GlobalEncrptVal4 As String
    Public GlobalEncrptVal5 As String
    Public GlobalEncrptVal6 As String
    Public GlobalEncrptVal7 As String
    Public GlobalEncrptVal8 As String
    Public GlobalEncrptVal9 As String
    Public GlobalEncrptVal0 As String

    Public Sub LoadGeneralSettings()
        com.CommandText = "select *, (select fullname from tblaccounts where accountid = tblgeneralsettings.preparedid) as 'preparedby',  (select designation from tblaccounts where accountid = tblgeneralsettings.preparedid) as 'preparedbyposition', " _
                                        + " (select fullname from tblaccounts where accountid = tblgeneralsettings.checkedid) as 'checkedby',(select designation from tblaccounts where accountid = tblgeneralsettings.checkedid) as 'checkedbyposition', " _
                                        + " (select fullname from tblaccounts where accountid = tblgeneralsettings.approvedid) as 'approvedby',(select designation from tblaccounts where accountid = tblgeneralsettings.approvedid) as 'approvedbyposition', " _
                                        + " (select companyname from tblglobalvendor where vendorid = tblgeneralsettings.supplierid) as 'vendor' from tblgeneralsettings  where companycode='" & GlobalOrganizationCode & "'"
        rst = com.ExecuteReader
        While rst.Read
            GlobalEnableCopyright = rst("enablecopyright")
            GlobalSystemStartDate = rst("systemstartdate").ToString
            GlobalOfficeCaption = rst("useofficecaption").ToString
            GlobalEnablebarcode = rst("enableitembarcode").ToString
            GlobalFiletypeSupport = rst("supportfiletype").ToString
            GlobalAllowableAttachSize = rst("allowableattachsize").ToString

            '#AUTHORIZED APPROVER
            AppSinglePrepared = rst("usesingleprepared")
            AppPreparedId = rst("preparedid").ToString
            AppPreparedTitle = rst("preparedtitle").ToString
            AppPreparedName = rst("preparedby").ToString
            ApppreparedPosition = rst("preparedbyposition").ToString

            AppEnableCheckedby = rst("enablechecked")
            AppCheckedId = rst("checkedid").ToString
            AppCheckedTitle = rst("checkedtitle").ToString
            AppCheckedName = rst("checkedby").ToString
            AppCheckedPosition = rst("checkedbyposition").ToString

            AppEnableapprovedby = rst("enableapproved")
            AppApprovedId = rst("approvedid").ToString
            AppApprovedTitle = rst("approvedtitle").ToString
            AppApprovedName = rst("approvedby").ToString
            AppApprovedPosition = rst("approvedbyposition").ToString

            AppEnableBeginvendor = rst("enablebeginsupplier")
            AppBeginvendorName = rst("vendor").ToString
            AppBeginvendorId = rst("supplierid").ToString
            GlobalEnableApprover = rst("enablerequestapprover")
            GlobalEnableImageRaportHeader = rst("enableimageheaderreport")

            'Email settings
            globalEmailNotification = rst("enableemailnotification")
            globalsmtpHost = rst("smtphost").ToString()
            globalsmtpPort = rst("smptport").ToString()
            globalsslEnable = rst("smtpsslenable").ToString()
            globalserverEmailAddress = rst("serveremailaddress").ToString()
            globalemailPassword = DecryptTripleDES(rst("serverpassword").ToString())

            GlobalCloudBackup = rst("enablecloud")
            GlobalCloudHost = rst("cloudhost").ToString
            GlobalCloudUser = rst("clouduser").ToString
            If rst("cloudpass").ToString <> "" Then
                GlobalCloudPassword = DecryptTripleDES(rst("cloudpass").ToString)
            End If

            GlobalEnableStockHouse = rst("enablestockhouse")
            GlobalEnableOfficeReportHeader = rst("enableofficereportheader")
            GlobalEnableCffeBatch = rst("enablecffebatch")
            GlobalStrictAttachment = rst("strictattachments")
            GlobalBackupDir = rst("backupdir").ToString

            GlobalDirectApprovedPr = rst("directapprovedpr")
            GlobalDirectApprovedPo = rst("directapprovedpo")

            GlobalPOExpiry = rst("poexpiry").ToString
            'ZIPFILE_LOCATION = rst("archiveddir").ToString
            Globalenableservertimer = rst("enableservertimer")
            GlobalenableProductFilter = rst("enableproductfilter")

            GlobalProductTemplate = rst("producttemplateserver")
            Globalenablechittransaction = rst("enablechittransaction")
            Globalenablesaleinvoicenumber = rst("enablesaleinvoicenumber")
            Globalprintstatementledgertype = rst("printstatementledgertype")

            If rst("directponumbersequence").ToString = "" Then
                GlobalEnableponumbersequence = False
            Else
                GlobalEnableponumbersequence = True
            End If

            If rst("popaymentsequence").ToString = "" Then
                GLobalPoPaymentSequence = False
            Else
                GLobalPoPaymentSequence = True
            End If

            GlobalEmailNotifySales = rst("emailnotifysales")
            GlobalEmailNotifyCheckdue = rst("emailnotifycheckdue")
            GlobalEmailNotifyAttendancelog = rst("emailnotifyattendancelog")
            GLobalEmailNotifyReceivedPOstock = rst("emailnotifyreceivedpostock")
            GLobalEmailNotifyAutoServices = rst("emailnotifyautoservices")
            GlobalEmailNotifyBanksLedger = rst("emailnotifybanksledger")
            GlobalEmailNotifyMonthlySummary = rst("emailnotifymonthlysummary")
            GlobalEnableConsumableAdjustment = rst("enableconsumableadjustment")

            If rst("vouchernosequence").ToString = "" Then
                GlobalEnableVouchernumbersequence = False
            Else
                GlobalEnableVouchernumbersequence = True
            End If
            GlobalFFEmemorandumagreement = rst("FFEmemorandumagreement").ToString
            GlobalEnableClinicsServices = rst("enableclinicsservices")
            GlobalDigitalPaymentApproving = rst("DigitalPaymentApproving")
            GlobalClientStockReceiving = rst("ClientStockReceiving")
            GlobalEnableVoucherPaymentPosting = rst("EnableVoucherPaymentPosting")
            Globalallowdisbursepobybatch = rst("allowdisbursepobybatch")
            Globaldefaultdiscountcategory = rst("defaultdiscountcategory").ToString
            Globalstockouttitle = rst("stockouttitle").ToString
            GlobalReportTemplate = rst("reporttemplate").ToString
            Globaldefaultroomoccupieddirty = rst("defaultroomoccupieddirty").ToString
            GLobalenablepoceosign = rst("enablepoceosign")
            Globalceoaccountid = rst("ceoaccountid").ToString
            Globalenableprocurementid = rst("enableprocurementid")
            Globalprocurementid = rst("procurementid").ToString
            GLobalEnableElectronicVoucher = rst("enableelectronicvoucher")
        End While
        rst.Close()

        com.CommandText = "select * from tblglsettings where companycode='" & GlobalOrganizationCode & "'" : rst = com.ExecuteReader
        While rst.Read
            GlobalGLExpensesCode = rst("expenseglcode").ToString
            GlobalGLIncomeCode = rst("incomeglcode").ToString
            GlobalGLSalesCode = rst("salescode").ToString
            GlobalGLaccountspayableCode = rst("accountspayable").ToString
            GlobalGLARCode = rst("acctrecievable").ToString
            GlobalPaymentGLItemCode = rst("clientpayment").ToString
            GLobalGLItemCreditCard = rst("creditcard").ToString
            GLobalGLItemPurchaseOrder = rst("popayable").ToString
            GlobalPaymentDiscountGLItemCode = rst("paymentdiscount").ToString
            GlobalPOPaymentGLItemCode = rst("popayment").ToString
            GlobalPOPaymentDiscountGLItemCode = rst("popaymentdiscount").ToString
            GlobalTaxRate = rst("taxrate").ToString
            GlobalBankBegGLItemCode = rst("bankbegcode").ToString
            GlobalGLOverages = rst("overages").ToString
            GlobalGLShortages = rst("shortages").ToString
            GlobalGLCheckDeposit = rst("checkdeposit").ToString
            GlobalGLCheckPayment = rst("checkpayment").ToString
            GlobalGLVoucherCode = rst("voucher").ToString
            GLobalGLItemOnlinePayment = rst("onlinepayment").ToString
        End While
        rst.Close()

        com.CommandText = "select * from tblsalesencryptnumber" : rst = com.ExecuteReader
        While rst.Read
            GlobalEnableEncryptNumbers = rst("enableencrypt")
            GlobalEncrptVal1 = rst("val1").ToString
            GlobalEncrptVal2 = rst("val2").ToString
            GlobalEncrptVal3 = rst("val3").ToString
            GlobalEncrptVal4 = rst("val4").ToString
            GlobalEncrptVal5 = rst("val5").ToString
            GlobalEncrptVal6 = rst("val6").ToString
            GlobalEncrptVal7 = rst("val7").ToString
            GlobalEncrptVal8 = rst("val8").ToString
            GlobalEncrptVal9 = rst("val9").ToString
            GlobalEncrptVal0 = rst("val0").ToString
        End While
        rst.Close()

        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\letterhead.jpg") = True Then
            ReportHeaderImg = Image.FromFile(Application.StartupPath.ToString & "\img\letterhead.jpg")
        End If
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\letterfooter.jpg") = True Then
            ReportFooterImg = Image.FromFile(Application.StartupPath.ToString & "\img\letterfooter.jpg")
        End If
    End Sub

End Module
