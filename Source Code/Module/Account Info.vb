Imports DevExpress.XtraGrid.Design
Imports System.IO

Module Account_Info

    Public globalfullname As String
    Public globaldesignation As String
    Public globalEmailaddress As String
    Public globalPermissionAccess As String

    Public globalofficeid As String
    Public globaloffice As String
    Public globaluserid As String
    Public globalpass As String
    Public globaluser As String
    Public logtry As String
    Public globallogin As Boolean
    Public globalusersign As Image = Nothing
    Public GlobalIconFolder As String
    Public GlobalMenuFontName As String
    Public GlobalMenuFontSize As Double
    Public GlobalPageFontName As String
    Public GlobalPageFontSize As Double

    Public globalApproverPermission As Boolean
    Public globalAllowAdd As Boolean
    Public globalAllowEdit As Boolean
    Public globalAllowDelete As Boolean

    Public gen_enablle_features As Boolean
    Public gen_fontfamily As String
    Public gen_forecolor As String
    Public gen_FontSize As Single
    Public gen_schemestyle As String
    Public gen_paintstyle As String
    Public gen_header_bold As Boolean
    Public gen_main_bold As Boolean
    Public gen_footer_bold As Boolean
    Public gen_evenrowenable As Boolean
    Public gen_ShowHorzLines As Boolean
    Public gen_ShowVertLines As Boolean
    Public gen_indicatorline As Boolean
    Public gen_filterappearance As Boolean
     
    Public Sub loadglobaluser()
        globalusersign = Nothing
        com.CommandText = "SELECT *,(select officename from tblcompoffice where officeid = tblaccounts.officeid) as '" & GlobalOfficeCaption & "'  from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader()
        While rst.Read()
            globaluser = rst("username").ToString
            globalfullname = rst("fullname").ToString
            globaldesignation = rst("designation").ToString
            globalEmailaddress = rst("emailaddress").ToString
            globalPermissionAccess = rst("permission").ToString
            globaltheme = rst("theme").ToString
            globalofficeid = rst("officeid").ToString
            globaloffice = rst(GlobalOfficeCaption).ToString
            GlobalIconFolder = rst("iconfolder").ToString
            GlobalMenuFontName = rst("menufontname").ToString
            GlobalMenuFontSize = rst("menufontsize").ToString
            GlobalPageFontName = rst("pagefontname").ToString
            GlobalPageFontSize = rst("pagefontsize").ToString

            If GlobalIconFolder = "" Then
                GlobalIconFolder = "default"
            End If
            If globaltheme = "" Then
                globaltheme = "Visual Studio 2013 Dark"
            End If

            If rst("digitalsign").ToString <> "" Then
                imgBytes = CType(rst("digitalsign"), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                globalusersign = Image.FromStream(stream)
            End If
        End While
        rst.Close()

        If LCase(globaluser) = "root" Then
            globalAllowAdd = True
            globalAllowEdit = True
            globalAllowDelete = True
        Else
            com.CommandText = "select * from tblpermissions where percode='" & globalPermissionAccess & "'" : rst = com.ExecuteReader
            While rst.Read
                globalApproverPermission = rst("approver")
                globalAllowAdd = rst("allowadd")
                globalAllowEdit = rst("allowedit")
                globalAllowDelete = rst("allowdelete")
            End While
            rst.Close()
        End If

        LoadUserGridAppearance()
    End Sub
    Public Sub LoadUserGridAppearance()
        If countqry("tblgridsettings", "userid='" & globaluserid & "'") = 0 Then
            gen_enablle_features = False
        Else
            com.CommandText = "select * from tblgridsettings where userid='" & globaluserid & "'" : rst = com.ExecuteReader
            While rst.Read
                gen_enablle_features = rst("grid_enableappearance")
                gen_fontfamily = rst("grid_fontfamily").ToString
                gen_forecolor = rst("grid_forntcolor").ToString
                gen_FontSize = rst("grid_fontsize").ToString
                gen_schemestyle = rst("grid_schemestyle").ToString
                gen_paintstyle = rst("grid_paintstyle").ToString
                gen_header_bold = rst("grid_header_bold")
                gen_main_bold = rst("grid_main_bold")
                gen_footer_bold = rst("grid_footer_bold")
                gen_evenrowenable = rst("grid_evenrowenable")
                gen_ShowHorzLines = rst("grid_ShowHorzLines")
                gen_ShowVertLines = rst("grid_ShowVertLines")
                gen_indicatorline = rst("grid_indicatorline")
                gen_filterappearance = rst("grid_filterappearance")
            End While
            rst.Close()
        End If
    End Sub
    Public Function LoadGridviewAppearance(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim gvScheme As XAppearances = New XAppearances(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        xgrid.OptionsSelection.EnableAppearanceFocusedCell = False
        If gen_enablle_features = True Then
            gvScheme.LoadScheme(gen_schemestyle, xgrid)
            xgrid.PaintStyleName = gen_paintstyle
            If gen_indicatorline = True Then
                xgrid.OptionsView.ShowIndicator = True
            Else
                xgrid.OptionsView.ShowIndicator = False
            End If

            If gen_evenrowenable = True Then
                xgrid.OptionsView.EnableAppearanceEvenRow = True
                xgrid.OptionsView.EnableAppearanceOddRow = True
            Else
                xgrid.OptionsView.EnableAppearanceEvenRow = False
                xgrid.OptionsView.EnableAppearanceOddRow = False
            End If

            If gen_ShowHorzLines = True Then
                xgrid.OptionsView.ShowHorzLines = True
            Else
                xgrid.OptionsView.ShowHorzLines = False
            End If

            If gen_ShowVertLines = True Then
                xgrid.OptionsView.ShowVertLines = True
            Else
                xgrid.OptionsView.ShowVertLines = False
            End If
            If gen_header_bold = True Then
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If gen_main_bold = True Then
                xgrid.Appearance.Row.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.Row.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If gen_footer_bold = True Then
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(gen_fontfamily, gen_FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            xgrid.Appearance.HeaderPanel.ForeColor = Color.FromName(gen_forecolor)
            xgrid.Appearance.Row.ForeColor = Color.FromName(gen_forecolor)
            xgrid.Appearance.FooterPanel.ForeColor = Color.FromName(gen_forecolor)
            xgrid.Appearance.GroupFooter.ForeColor = Color.FromName(gen_forecolor)
        Else
            gvScheme.LoadScheme("Default", xgrid)
            xgrid.PaintStyleName = "Default"
        End If
        Return xgrid
    End Function

    Public Sub ExitSystemVariable()
        com.CommandText = "update tbllogin set outtime=current_timestamp  where userid='" & globaluserid & "' and outtime is null" : com.ExecuteNonQuery()
        com.CommandText = "update tblsystemcontrol set confirmed=1 where userid='ALL'" : com.ExecuteNonQuery()

        'User settings
        globalfullname = ""
        globaldesignation = ""
        globalEmailaddress = ""
        globalPermissionAccess = ""
        globaltheme = "Visual Studio 2013 Dark"
        globalofficeid = ""
        globaloffice = ""
        globaluserid = ""
        globalpass = ""
        globaluser = ""
        logtry = ""
        GlobalMenuFontName = "Segoe UI"
        GlobalMenuFontSize = 8.25
        GlobalPageFontName = "Segoe UI"
        GlobalPageFontSize = 9.25
        globallogin = False
        globalusersign = Nothing
        GlobalIconFolder = "default"
        globalApproverPermission = False
        globalAllowAdd = False
        globalAllowEdit = False
        globalAllowDelete = False
        SystemRemoted = False
        GlobalEnableponumbersequence = False
        GLobalPoPaymentSequence = False
        GlobalSystemStartDate = ""
        GlobalOfficeCaption = ""
        GlobalFiletypeSupport = "All files (*.*)|*.*"
        GlobalAllowableAttachSize = 0
        AppSinglePrepared = False
        AppPreparedId = ""
        AppPreparedTitle = ""
        AppPreparedName = ""
        ApppreparedPosition = ""
        AppEnableCheckedby = False
        AppCheckedId = ""
        AppCheckedTitle = ""
        AppCheckedName = ""
        AppCheckedPosition = ""
        AppEnableapprovedby = False
        AppApprovedId = ""
        AppApprovedTitle = ""
        AppApprovedName = ""
        AppApprovedPosition = ""
        AppEnableBeginvendor = ""
        AppBeginvendorName = ""
        AppBeginvendorId = ""
        GlobalEnableApprover = False
        GlobalEnableImageRaportHeader = False
        Globaldefaultdiscountcategory = ""
        GlobalReportTemplate = "default"
        Globaldefaultroomoccupieddirty = ""

        'Declaration of email settings
        globalEmailNotification = False
        globalsmtpHost = ""
        globalsmtpPort = ""
        globalsslEnable = ""
        globalserverEmailAddress = ""
        globaltargetEmailAddress = ""
        globalemailPassword = ""

        'Email Settings
        GlobalCloudBackup = False
        GlobalCloudHost = ""
        GlobalCloudUser = ""
        GlobalCloudPassword = ""


        GlobalEnableStockHouse = False
        GlobalEnablebarcode = False
        GlobalEnableOfficeReportHeader = False
        GlobalEnableCopyright = False
        GlobalEnableCffeBatch = False
        GlobalStrictAttachment = False
        GlobalBackupDir = ""

        'PO Settings
        GlobalDirectApprovedPr = False
        GlobalDirectApprovedPo = False
        GlobalPOExpiry = 0
        Globalenableservertimer = False
        GlobalenableProductFilter = False
        GlobalProductTemplate = 0
        Globalenablechittransaction = False
        Globalenablesaleinvoicenumber = False
        Globalprintstatementledgertype = False
        Globaldirectponumbersequence = ""
        GlobalEnableponumbersequence = False
        GLobalPoPaymentSequence = False
        GlobalEmailNotifySales = False
        GlobalEmailNotifyCheckdue = False

        'GL Expense
        GlobalGLExpensesCode = ""
        GlobalGLSalesCode = ""
        GlobalGLIncomeCode = ""
        GlobalGLARCode = ""
        GlobalPaymentGLItemCode = ""
        GLobalGLItemCreditCard = ""
        GLobalGLItemPurchaseOrder = ""
        GlobalPaymentDiscountGLItemCode = ""
        GlobalPOPaymentGLItemCode = ""
        GlobalPOPaymentDiscountGLItemCode = ""
        GlobalTaxRate = 0
        GlobalBankBegGLItemCode = ""
        GlobalGLOverages = ""
        GlobalGLShortages = ""

        EnableModuleProcurement = False
        EnableModuleInventory = False
        EnableModuleSales = False
        EnableModuleFuel = False
        EnableAccounting = False
        EnableModuleHR = False
        EnableModulePayroll = False
        EnableModuleReportGen = False
        EnableModuleHotel = False
        GlobalNumberOfPOS = 0
        GlobalNumberOfDevision = 0
        EnableRetainersMode = False

        SystemEngineCode = ""
        SystemModule = ""
        SystemDate = ""
        SystemExpiryDate = ""
    End Sub

End Module
