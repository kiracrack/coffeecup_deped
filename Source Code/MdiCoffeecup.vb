'Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Alerter
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class MdiCoffeeCup
    Public DataBook As Excel.Workbook
    Public DS_ChartOfAccount As Excel.Worksheet

    Dim cv As Boolean = False
    Public Property AllowCustomLookAndFeel As Boolean = True
    Dim validateRemote As Boolean = False
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(globaltheme)

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control + Keys.N) Then
            If cmdNewRequest.Visibility = BarItemVisibility.Always Then
                cmdNewRequest.PerformClick()
            End If
        ElseIf keyData = (Keys.Control + Keys.Q) Then
            Me.Close()

        ElseIf keyData = (Keys.Shift + Keys.P) Then
            frmChangeOwnPassword.ShowDialog(Me)

        ElseIf keyData = Keys.F12 Then
            If cmdConsumablesInventory.Visibility = BarItemVisibility.Always Then
                frmInventoryConsumables.Show()
            End If

        ElseIf keyData = Keys.F11 Then
            If cmdItemEntries.Visibility = BarItemVisibility.Always Then
                frmProductManagement.Show()
            End If

        ElseIf keyData = Keys.Shift + Keys.F11 Then
            If cmdNewProduct.Visibility = BarItemVisibility.Always Then
                AddProduct("", Me)
            End If


        ElseIf keyData = Keys.Shift + Keys.F12 Then
            frmSystemOwnerConfirmation.ShowDialog(Me)
            If frmSystemOwnerConfirmation.Authourized = True Then
                AdminModule.ShowDialog()
                frmSystemOwnerConfirmation.Authourized = False
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub mdiProcurement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i

        If SystemRemoted = True Then
            If Remotetype = 1 Then
                frmLogin.Show()
            End If
            ExitSystemVariable()
        Else
            If XtraMessageBox.Show("Are you sure you want to logoff your account " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ExitSystemVariable()
                SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
                frmLogin.Show()
                SplashScreenManager.CloseForm()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MdiCoffeeCup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadIcons() : SetIcon(Me)
        LoadCompanySystemModule()
        AutoExecuteQuery()
    End Sub
    Public Sub AutoExecuteQuery()
        If Globaldefaultroomoccupieddirty <> "" Then
            If countqry("tblcommandexecuter", "commanddate=current_date and commandcode='HOUSEKEEPING'") = 0 Then
                com.CommandText = "UPDATE tblhotelrooms set roomstatus='" & Globaldefaultroomoccupieddirty & "', remarks='FOR CLEANING' where roomid in (select roomid from tblhotelroomtransaction where inhouse=1 and closed=0 and cancelled=0)" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblcommandexecuter set commanddate=current_date,commandcode='HOUSEKEEPING', commandquery='" & rchar(com.CommandText) & "',executed=1,dateexecuted=current_timestamp" : com.ExecuteNonQuery()
            End If
        End If
    End Sub
    Public Sub LoadCompanySystemModule()
        connectServer()
        CheckSystemMaintainance()
        If countqry("tblreminders", "closed=0") > 0 Then
            DockPanel1.Show()
        Else
            DockPanel1.Hide()
        End If
        FilterConversationOption()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinPopupMenu(skinslink)
        DefaultLookAndFeel1.LookAndFeel.SkinName = globaltheme.ToString()
        If LCase(globaluser) = "root" Or LCase(globaluser) = "admin" Then
            Me.cmdReportDeveloper.Enabled = True
        Else
            Me.cmdReportDeveloper.Enabled = False
        End If

        If LCase(globaluser) = "root" Then
            Me.cmdAdminTool.Visibility = BarItemVisibility.Always
        Else
            Me.cmdAdminTool.Visibility = BarItemVisibility.Never
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Archived")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Archived")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Report")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Report")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Requisitions")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Requisitions")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\REPORTS")) = True Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\REPORTS")
        End If
        MainMenu.SelectedPage = rbnProcurement
        cmdMenuPurchasingAbout.Caption = "About " & GlobalSystemName
        Me.Text = GlobalSystemName & " " & compname + " - Login as " & LCase(globaluser) & "@" & LCase(globalfullname)
        CustomizeSystemIcon(GlobalIconFolder)
        NotifyEmail()
    End Sub
    Public Sub ClearTempData()
        com.CommandText = "delete from tblemailnotification where notified=1;" : com.ExecuteNonQuery()
    End Sub
    Public Sub CustomizeSystemIcon(ByVal iconfolder As String)
        On Error Resume Next
        Dim mCurrentItem As BarItem
        For Each currentPage As RibbonPage In Me.MainMenu.Pages
            currentPage.Appearance.Font = New System.Drawing.Font(GlobalPageFontName, GlobalPageFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            For Each currentGroup As RibbonPageGroup In currentPage.Groups
                'currentGroup.Page.Appearance.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                For Each currenLink As BarItemLink In currentGroup.ItemLinks
                    mCurrentItem = currenLink.Item
                    mCurrentItem.LargeGlyph = Nothing
                    If IO.File.Exists(Application.StartupPath.ToString & "\icon\" & iconfolder & "\" & mCurrentItem.Name & ".png") = True Then
                        mCurrentItem.LargeGlyph = Image.FromFile(Application.StartupPath.ToString & "\icon\" & iconfolder & "\" & mCurrentItem.Name & ".png")
                    Else
                        mCurrentItem.LargeGlyph = Image.FromFile(Application.StartupPath.ToString & "\icon\default\" & mCurrentItem.Name & ".png")
                    End If
                    mCurrentItem.ItemAppearance.Disabled.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Hovered.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Normal.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    mCurrentItem.ItemAppearance.Pressed.Font = New System.Drawing.Font(GlobalMenuFontName, GlobalMenuFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Next currenLink
            Next currentGroup
        Next currentPage
        '#other menu
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statDatetime.Caption = "Transaction Date  " & Format(Now, "MMM dd, yyyy hh:mm:ss tt")
        txtServerHost.Caption = "Server Host " & sqlserver
        txtDatabaseVersion.Caption = GlobalDatabaseVersion
        txtAppVersion.Caption = "Application v" & fversion
        If EnableRetainersMode = True Then
            txtExpiration.Visibility = BarItemVisibility.Always
            Dim daysRemaining As Integer = DateDiff(DateInterval.Day, CDate(Now.ToShortDateString), CDate(DecryptTripleDES(SystemExpiryDate)))
            If daysRemaining < 10 Then
                If daysRemaining = 0 Then
                    txtExpiration.Caption = "Your system will expired today. please update your subscription to prevent system locked"
                Else
                    txtExpiration.Caption = "You have " & daysRemaining & " remaining day(s) left before expiration"
                End If
                txtExpiration.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                txtExpiration.ItemAppearance.Normal.ForeColor = Color.Red
            Else
                txtExpiration.Caption = "Your system will expire on " & CDate(DecryptTripleDES(SystemExpiryDate)).ToString("MMMM dd, yyyy")
                txtExpiration.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                txtExpiration.ItemAppearance.Normal.ForeColor = DefaultForeColor
            End If

        Else
            txtExpiration.Visibility = BarItemVisibility.Never
        End If
        If Globalenableservertimer = True Then
            If rbnProcurement.Visible = True Then
                If globalAllowAdd = True Then
                    '#Online Requisition
                    Dim countop As Integer = countqry("tblrequisitions", "corporatelevel=1 and approvedbranch=1 and received=0 and disapproved=0 and cancelled=0")
                    If countop > 0 Then
                        cmdNewOnlineRequisition.Visibility = BarItemVisibility.Always
                        cmdNewOnlineRequisition.Caption = "Online Requisition (" & countop & ")"
                        cmdNewOnlineRequisition.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdNewOnlineRequisition.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdNewOnlineRequisition.Visibility = BarItemVisibility.Never
                        cmdNewOnlineRequisition.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdNewOnlineRequisition.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    '#on hold requisition
                    Dim countonhold As Integer = countqry("tblrequisitions", "corporatelevel=1 and approvedbranch=1 and received=1 and hold=1 and disapproved=0 and cancelled=0")
                    If countonhold > 0 Then
                        cmdonhold.Visibility = BarItemVisibility.Always
                        cmdonhold.Caption = "On Hold Requisition (" & countonhold & ")"
                        cmdonhold.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdonhold.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdonhold.Visibility = BarItemVisibility.Never
                        cmdonhold.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdonhold.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    '#Product for Registration
                    Dim countpro As Integer = countqry("tblproductrequest", "confirmed=0 and cancelled=0")
                    If countpro > 0 Then
                        cmdNewProductRegistration.Visibility = BarItemVisibility.Always
                        cmdNewProductRegistration.Caption = "Product for Registration (" & countpro & ")"
                        cmdNewProductRegistration.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdNewProductRegistration.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdNewProductRegistration.Visibility = BarItemVisibility.Never
                        cmdNewProductRegistration.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdNewProductRegistration.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    '#New Purchase Order

                    Dim countpo As Integer = countqry("tblrequisitions inner join tblrequesttype on tblrequisitions.potypeid = tblrequesttype.potypeid", "corporatelevel=0 and approvedbranch=1 and generatedpo=0 and enablepo=1 and cancelled=0") + countqry("tblrequisitions inner join tblrequesttype on tblrequisitions.potypeid = tblrequesttype.potypeid", "corporatelevel=1 and approvedbranch=1 and approvedcorporate=1 and generatedpo=0 and enablepo=1 and cancelled=0")
                    If countpo > 0 Then
                        cmdGeneratePO.Visibility = BarItemVisibility.Always
                        cmdGeneratePO.Caption = "Purchase Order (" & countpo & ")"
                        cmdGeneratePO.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdGeneratePO.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdGeneratePO.Visibility = BarItemVisibility.Never
                        cmdGeneratePO.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdGeneratePO.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    '#New Payment Request
                    Dim countpayment As Integer = countqry("tblrequisitions inner join tblrequesttype on tblrequisitions.potypeid = tblrequesttype.potypeid", "corporatelevel=0 and approvedbranch=1 and generatedpo=0 and enablepo=0 and cancelled=0") + countqry("tblrequisitions inner join tblrequesttype on tblrequisitions.potypeid = tblrequesttype.potypeid", "corporatelevel=1 and approvedbranch=1 and approvedcorporate=1 and generatedpo=0 and enablepo=0 and cancelled=0")
                    If countpayment > 0 Then
                        cmdGeneratePayment.Visibility = BarItemVisibility.Always
                        cmdGeneratePayment.Caption = "Payment Request (" & countpayment & ")"
                        cmdGeneratePayment.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdGeneratePayment.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdGeneratePayment.Visibility = BarItemVisibility.Never
                        cmdGeneratePayment.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdGeneratePayment.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    '#New Forward PO
                    Dim countforward As Integer = countqry("tblpurchaseorder", "verified=1 and forpo=1 and cancelled=0 and forwarded=0 and delivered=0 and paymentrequested=0")
                    If countforward > 0 Then
                        cmdForwardPO.Visibility = BarItemVisibility.Always
                        cmdForwardPO.Caption = "Approved Purchase Order (" & countforward & ")"
                        cmdForwardPO.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdForwardPO.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdForwardPO.Visibility = BarItemVisibility.Never
                        cmdForwardPO.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdForwardPO.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If

                    ''#PO for Payment
                    'Dim countpoforpayment As Integer = countqry("tblpurchaseorder", "verified=1 and delivered=1 and cancelled=0 and forwarded=1 and corporatelevel=1 and paymentrequested=0")
                    'If countpoforpayment > 0 Then
                    '    cmdPOforPayment.Visibility = BarItemVisibility.Always
                    '    cmdPOforPayment.Caption = "Accounts Payable (" & countpoforpayment & ")"
                    '    cmdPOforPayment.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                    '    cmdPOforPayment.ItemAppearance.Normal.ForeColor = Color.Red
                    'Else
                    '    cmdPOforPayment.Visibility = BarItemVisibility.Never
                    '    cmdPOforPayment.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                    '    cmdPOforPayment.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    'End If

                    '#Approved Payment Request
                    Dim countApprovedPaymentRequest As Integer = countqry("tbldisbursementvoucher", "verified=1 and cleared=0 and cancelled=0")
                    If countApprovedPaymentRequest > 0 Then
                        cmdPaymentApproved.Visibility = BarItemVisibility.Always
                        cmdPaymentApproved.Caption = "Approved Payment (" & countApprovedPaymentRequest & ")"
                        cmdPaymentApproved.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdPaymentApproved.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdPaymentApproved.Visibility = BarItemVisibility.Never
                        cmdPaymentApproved.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdPaymentApproved.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If


                    ''#Close payable
                    'Dim countclosepayable As Integer = countqry("tblpurchaseorder", "verified=1  and cancelled=0 and forwarded=1 and delivered=1 and paymentrequested=1 and paymentupdated=1 and closed=0")
                    'If countclosepayable > 0 Then
                    '    cmdClosedPayable.Visibility = BarItemVisibility.Always
                    '    cmdClosedPayable.Caption = "AP Confirmation (" & countclosepayable & ")"
                    '    cmdClosedPayable.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                    '    cmdClosedPayable.ItemAppearance.Normal.ForeColor = Color.Red
                    'Else
                    '    cmdClosedPayable.Visibility = BarItemVisibility.Never
                    '    cmdClosedPayable.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                    '    cmdClosedPayable.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    'End If
                End If
            End If

            '#FFE Accountable
            
            If countqry("tblpermissionsclearing", "percode='" & globalPermissionAccess & "' and tabname='tabClientCheckClearing'") > 0 Or LCase(globaluser) = "root" Then
                Dim clientCheckClearing As Integer = countqry("tblsaleschecktransaction", "verified=1 and cancelled=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ") + countqry("tblsaleschecktocash", "verified=1 and cancelled=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ")
                If clientCheckClearing > 0 Then
                    If countqry("tblpermissionstemplate", "percode='" & globalPermissionAccess & "' and menus='cmdTransactionClearing'") > 0 Or LCase(globaluser) = "root" Then
                        cmdClientCheckClearing.Visibility = BarItemVisibility.Always
                        cmdClientCheckClearing.Caption = "Client check clearing (" & clientCheckClearing & ")"
                        cmdClientCheckClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdClientCheckClearing.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdClientCheckClearing.Visibility = BarItemVisibility.Never
                        cmdClientCheckClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdClientCheckClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If
                Else
                    cmdClientCheckClearing.Visibility = BarItemVisibility.Never
                    cmdClientCheckClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                    cmdClientCheckClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
                End If
            Else
                cmdClientCheckClearing.Visibility = BarItemVisibility.Never
                cmdClientCheckClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                cmdClientCheckClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
            End If

            If countqry("tblpermissionsclearing", "percode='" & globalPermissionAccess & "' and tabname='tabPaymentCheckClearing'") > 0 Or LCase(globaluser) = "root" Then
                Dim PaymentCheckClearing As Integer = countqry("tblpayablechecktransaction", "verified=1 and cancelled=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ")
                If PaymentCheckClearing > 0 Then
                    If countqry("tblpermissionstemplate", "percode='" & globalPermissionAccess & "' and menus='cmdTransactionClearing'") > 0 Or LCase(globaluser) = "root" Then
                        cmdCheckPaymentClearing.Visibility = BarItemVisibility.Always
                        cmdCheckPaymentClearing.Caption = "Check payment clearing (" & PaymentCheckClearing & ")"
                        cmdCheckPaymentClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                        cmdCheckPaymentClearing.ItemAppearance.Normal.ForeColor = Color.Red
                    Else
                        cmdCheckPaymentClearing.Visibility = BarItemVisibility.Never
                        cmdCheckPaymentClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                        cmdCheckPaymentClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
                    End If
                Else
                    cmdCheckPaymentClearing.Visibility = BarItemVisibility.Never
                    cmdCheckPaymentClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                    cmdCheckPaymentClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
                End If
            Else
                cmdCheckPaymentClearing.Visibility = BarItemVisibility.Never
                cmdCheckPaymentClearing.ItemAppearance.Normal.Font = New Font("Tahoma", 8.25, FontStyle.Regular)
                cmdCheckPaymentClearing.ItemAppearance.Normal.ForeColor = DefaultForeColor
            End If

            CheckSystemMaintainance()
        End If
    End Sub

    Private Sub EmailNotification_Tick(sender As Object, e As EventArgs) Handles EmailNotification.Tick
        NotifyEmail()
    End Sub

    Public Sub NotifyEmail()
        If globalEmailNotification = True Then
            If GlobalEmailNotifyCheckdue = True Then
                If countqry("tblsaleschecktransaction", "verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ") > 0 Or countqry("tblsaleschecktocash", "verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ") > 0 Or countqry("tblpayablechecktransaction", "verified=1 and cancelled=0 and notified=0 and cleared=0 and checkdate<>'0000-00-00' and DATEDIFF(checkdate,current_date) < 1 ") > 0 Then
                    If countqry("tblaccounts", "notifycheckdue=1") > 0 Then
                        SendDueCheckStats()
                    End If
                End If
            End If

            If GlobalEmailNotifyAttendancelog = True Then
                If countqry("tblpayrollattendancelog", "notified=0 and logindate<current_date") > 0 Then
                    If countqry("tblaccounts", "notifyattendancelog=1") > 0 Then
                        SendAttendanceLog()
                    End If
                End If
            End If

            If GlobalEmailNotifyMonthlySummary = True Then
                If countqry("tblsalessummary", "(month(dateopen) < month(current_date) or year(dateopen) < year(current_date)) and notified=0 group by date_format(dateopen,'%Y-%M') order by dateopen asc;") > 0 Then
                    If countqry("tblaccounts", "notifymonthlysummary=1") > 0 Then
                        SendMonthlySummaryReport()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheckSystemMaintainance()
        If SystemRemoted = True Then
            lblRemote.Visibility = BarItemVisibility.Always
            If Remotetype = 0 Then
                remotecountdown = remotecountdown - 1
                lblRemote.Caption = "Your system will shutdown in " & remotecountdown.ToString & " sec(s)"
                If remotecountdown = 0 Then
                    For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                        If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                            My.Application.OpenForms.Item(i).Close()
                        End If
                    Next i
                    Application.Exit()
                End If
            ElseIf Remotetype = 1 Then
                remotecountdown = remotecountdown - 1
                lblRemote.Caption = "Your system will logoff in " & remotecountdown.ToString & " sec(s)"
                If remotecountdown <= 0 Then
                    For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                        If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                            My.Application.OpenForms.Item(i).Close()
                        End If
                    Next i
                    Me.Close()
                End If
            End If
        Else
            lblRemote.Visibility = BarItemVisibility.Never
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdParticularCategory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmProductCategory.Visible = True Then
            frmProductCategory.Focus()
        Else
            frmProductCategory.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdNewProduct_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewProduct.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        AddProduct("direct", Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem97_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdItemEntries.ItemClick
        'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        'If frmProductManagement.Visible = True Then
        '    frmProductManagement.Focus()
        'Else
        '    frmProductManagement.Show(Me)
        'End If
        'SplashScreenManager.CloseForm()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmProductManagement.MdiParent = Me
        frmProductManagement.Show()
        frmProductManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

#Region "Purchases"
    Private Sub BarButtonItem127_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRequestForApproval.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmRequisitionsManagement.MdiParent = Me
        frmRequisitionsManagement.Show()
        frmRequisitionsManagement.Focus()
        frmRequisitionsManagement.FilterOption()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewRequest.ItemClick, cmdMenuNewRequest.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmNewRequest.Visible = True Then
            frmNewRequest.Focus()
        Else
            frmNewRequest.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem128_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSupplierManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmVendorsManagement.MdiParent = Me
        frmVendorsManagement.Show()
        frmVendorsManagement.Focus()
        frmVendorsManagement.filter()
        SplashScreenManager.CloseForm()
    End Sub

#End Region

    Private Sub BarButtonItem295_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuLogout.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdApproverSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmApprovingProcess.Visible = True Then
            frmApprovingProcess.Focus()
        Else
            frmApprovingProcess.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuHelp.ItemClick
        XtraMessageBox.Show("Send email to Winter Bugahod @ Katipunan Bank IT Dept. at Email Add. winterbugahod@yahoo.com ", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuPurchasingAbout.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAbout.Visible = True Then
            frmAbout.Focus()
        Else
            frmAbout.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem10_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRequestCategory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmPOCategory.Visible = True Then
            frmPOCategory.Focus()
        Else
            frmPOCategory.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmStockoutType.Visible = True Then
            frmStockoutType.Focus()
        Else
            frmStockoutType.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdManualInventory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmManualInventoryHistory.MdiParent = Me
        frmManualInventoryHistory.Show()
        frmManualInventoryHistory.Focus()
        frmManualInventoryHistory.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTransferRequestLogs.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransferedRequestList.MdiParent = Me
        frmTransferedRequestList.Show()
        frmTransferedRequestList.Focus()
        frmTransferedRequestList.filter()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdOnlineRequisition.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmOnlineRequisitionList.MdiParent = Me
        frmOnlineRequisitionList.Show()
        frmOnlineRequisitionList.Focus()
        frmOnlineRequisitionList.FilterOption()
        SplashScreenManager.CloseForm()
    End Sub


    'Private Sub timernotification_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timernotification.Tick
    '    If Globalenableservertimer = True Then
    '        If rbnProcurement.Visible = True Then
    '            dst = New DataSet
    '            msda = New MySqlDataAdapter("Select * from tblnotifylist where isnotify=1 and forsync=0", conn)
    '            msda.Fill(dst, 0)
    '            For cnt = 0 To dst.Tables(0).Rows.Count - 1
    '                With (dst.Tables(0))
    '                    ' Show a sample alert window.
    '                    Dim info As AlertInfo = New AlertInfo(.Rows(cnt)("n_title").ToString(), .Rows(cnt)("n_description").ToString())
    '                    AlertControl1.Show(Me, info)
    '                    com.CommandText = "update tblnotifylist set isnotify=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
    '                    If .Rows(cnt)("n_type").ToString() = "chat" Then
    '                        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
    '                            If My.Application.OpenForms.Item(i) Is frmComunicationBox Then
    '                                frmComunicationBox.filterchatbox()
    '                                frmComunicationBox.filterNotifbox()
    '                            End If
    '                        Next i
    '                    End If
    '                End With
    '            Next

    '            If validateRemote = False Then
    '                If countqry("tblsystemcontrol", "userid='ALL' and confirmed=0 and controltype<>2") > 0 Then
    '                    dst = Nothing : dst = New DataSet
    '                    msda = New MySqlDataAdapter("Select *,case when controltype=0 then 'System Shutdown Alert' " _
    '                                                               + " when controltype=1 then 'Logoff Account Alert'  " _
    '                                                               + " when controltype=0 then 'Logoff Account Alert' " _
    '                                                               + " when controltype=3 then 'Message' end as title, " _
    '                                                               + " (select fullname from tblaccounts where accountid = tblsystemcontrol.actionby) as 'aby' from tblsystemcontrol where userid='ALL' and confirmed=0", conn)
    '                    msda.Fill(dst, 0)
    '                    For cnt = 0 To dst.Tables(0).Rows.Count - 1
    '                        With (dst.Tables(0))
    '                            Dim info As AlertInfo = New AlertInfo(.Rows(cnt)("title").ToString(), .Rows(cnt)("message").ToString() & "..." & Environment.NewLine & Environment.NewLine & "By: " & StrConv(.Rows(cnt)("aby").ToString(), vbProperCase))
    '                            Remotetype = .Rows(cnt)("controltype").ToString()
    '                            remotecountdown = .Rows(cnt)("countdown").ToString()
    '                            AlertControl1.Show(Me, info)
    '                            If Remotetype = 0 Or Remotetype = 1 Then
    '                                SystemRemoted = True
    '                                validateRemote = True
    '                            End If
    '                            validateRemote = True
    '                            If globaluserid <> .Rows(cnt)("actionby").ToString() Then
    '                                XtraMessageBox.Show(.Rows(cnt)("message").ToString() & "..." & Environment.NewLine & Environment.NewLine & "By: " & StrConv(.Rows(cnt)("aby").ToString(), vbProperCase), .Rows(cnt)("title").ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                            End If
    '                        End With
    '                    Next
    '                Else
    '                    If countqry("tblsystemcontrol", "userid='" & globaluserid & "' and confirmed=0 and controltype<>2") > 0 Then
    '                        dst = Nothing : dst = New DataSet
    '                        msda = New MySqlDataAdapter("Select *,case when controltype=0 then 'System Shutdown Alert' " _
    '                                                               + " when controltype=1 then 'Logoff Account Alert'  " _
    '                                                               + " when controltype=0 then 'Logoff Account Alert' " _
    '                                                               + " when controltype=3 then 'Message' end as title, " _
    '                                                               + " (select fullname from tblaccounts where accountid = tblsystemcontrol.actionby) as 'aby' " _
    '                                                               + " from tblsystemcontrol where userid='" & globaluserid & "' and confirmed=0", conn)
    '                        msda.Fill(dst, 0)
    '                        For cnt = 0 To dst.Tables(0).Rows.Count - 1
    '                            With (dst.Tables(0))
    '                                Dim info As AlertInfo = New AlertInfo(.Rows(cnt)("title").ToString(), .Rows(cnt)("message").ToString() & "..." & Environment.NewLine & Environment.NewLine & "By: " & StrConv(.Rows(cnt)("aby").ToString(), vbProperCase))
    '                                Remotetype = .Rows(cnt)("controltype").ToString()
    '                                remotecountdown = .Rows(cnt)("countdown").ToString()
    '                                AlertControl1.Show(Me, info)
    '                                com.CommandText = "update tblsystemcontrol set confirmed=1 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
    '                                If Remotetype = 0 Or Remotetype = 1 Then
    '                                    SystemRemoted = True
    '                                End If
    '                                validateRemote = True
    '                                If globaluserid <> .Rows(cnt)("actionby").ToString() Then
    '                                    XtraMessageBox.Show(.Rows(cnt)("message").ToString() & "..." & Environment.NewLine & Environment.NewLine & "By: " & StrConv(.Rows(cnt)("aby").ToString(), vbProperCase), .Rows(cnt)("title").ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                                End If
    '                            End With
    '                        Next
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUserAccountManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUsersAccounts.MdiParent = Me
        frmUsersAccounts.Show()
        frmUsersAccounts.Focus()
        frmUsersAccounts.filteruser()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCorporateProfileSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCompanySettings.Visible = True Then
            frmCompanySettings.Focus()
        Else
            frmCompanySettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCorporateDivision.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmCompOffice.MdiParent = Me
        frmCompOffice.Show()
        frmCompOffice.Focus()
        frmCompOffice.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem25_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdLoginAppearance.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAppearance.Visible = True Then
            frmAppearance.Focus()
        Else
            frmAppearance.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGeneralSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmGeneralSettings.Visible = True Then
            frmGeneralSettings.Focus()
        Else
            frmGeneralSettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub iExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub skinslink_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles skinslink.ItemClick
        Dim subMenu As BarSubItem = TryCast(e.Item, BarSubItem)
        If Not subMenu Is Nothing Then Return
        XtraMessageBox.Show("Item '" & e.Item.Caption & "' has been clicked")
    End Sub

    Private Sub skinslink_ItemPress(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles skinslink.ItemPress
        Dim currentSkin = CommonSkins.GetSkin(UserLookAndFeel.Default)
    End Sub

    Private Sub BarButtonItem31_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMenuExit.ItemClick
        Dim gdt As String = GlobalDateTime()
        If XtraMessageBox.Show("Are you sure you want to exit system " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbllogin set outtime='" & gdt & "'  where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
            End
        End If
    End Sub


    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdStockoutType.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmStockoutType.Visible = True Then
            frmStockoutType.Focus()
        Else
            frmStockoutType.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem15_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdReportSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmReportSettings.Visible = True Then
            frmReportSettings.Focus()
        Else
            frmReportSettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem37_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdConsumablesInventory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmInventoryConsumables.MdiParent = Me
        frmInventoryConsumables.Show()
        frmInventoryConsumables.Focus()
        'frmInventoryConsumables.filterInventory()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem38_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdCFFEInventory.ItemClick
        If LCase(GlobalReportTemplate) = "deped" Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmDepedFFESummary.MdiParent = Me
            frmDepedFFESummary.Show()
            frmDepedFFESummary.Focus()
            SplashScreenManager.CloseForm()
        Else
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmInventoryFFESummary.MdiParent = Me
            frmInventoryFFESummary.Show()
            frmInventoryFFESummary.Focus()
            SplashScreenManager.CloseForm()
        End If
    End Sub


    Private Sub BarButtonItem39_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMyUserProfile.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmUserProfile.Visible = True Then
            frmUserProfile.Focus()
        Else
            frmUserProfile.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem41_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdItemRegistration.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmProductRequestList.MdiParent = Me
        frmProductRequestList.Show()
        frmProductRequestList.Focus()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem46_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdNewTransferRequest.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransferNew.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem47_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTransferedInventory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransferedItems.MdiParent = Me
        frmTransferedItems.Show()
        frmTransferedItems.Focus()
        frmTransferedItems.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdMenuAccountProfile.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUserProfile.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem49_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdStockOutTransaction.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStockoutDepedItemSummary.MdiParent = Me
        frmStockoutDepedItemSummary.Show()
        frmStockoutDepedItemSummary.Focus()
        frmStockoutDepedItemSummary.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem50_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSystemUserLogs.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUserLogs.MdiParent = Me
        frmUserLogs.Show()
        frmUserLogs.Focus()
        SplashScreenManager.CloseForm()
    End Sub



    Private Sub BarButtonItem44_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAssetsAndDepreciation.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAssetsDepreciation.Visible = True Then
            frmAssetsDepreciation.Focus()
        Else
            frmAssetsDepreciation.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    

    Private Sub BarButtonItem58_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdStockHouse.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmStockHouse.Visible = True Then
            frmStockHouse.Focus()
        Else
            frmStockHouse.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles cmdWhatsNew.ItemClick
        Dim whats_new_location As String = Application.StartupPath.ToString & "\WhatsNew.rtf"
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(whats_new_location)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub

    Private Sub cmdUserPermissionTemplate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUserPermissionTemplate.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCoffeecupServerPermission.Visible = True Then
            frmCoffeecupServerPermission.Focus()
        Else
            frmCoffeecupServerPermission.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick_3(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdvanceSearch.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmAdvanceSearch.MdiParent = Me
        frmAdvanceSearch.Show()
        frmAdvanceSearch.Focus()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub cmdCoffeeCupClient_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCoffeeCupClient.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCoffeecupClient.Visible = True Then
            frmCoffeecupClient.Focus()
        Else
            frmCoffeecupClient.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles cmdComunicationBox.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmComunicationBox.Visible = True Then
            frmComunicationBox.Focus()
        Else
            frmComunicationBox.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub
 
    Private Sub cmdRestoreDatabase_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRestoreDatabase.ItemClick
        If XtraMessageBox.Show("Are you sure you want to restore Database?" & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sqlpath As String = "" : Dim detailsFile As StreamWriter = Nothing
            Dim tempenfile As String = Now.ToString("hh:mm:ss").ToString.Replace(":", "")
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                .Filter = "Backup data files (*.data)|*.data|All files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    'Display the file contents in the TextBox
                    sqlpath = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try
            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing

            If sqlpath <> "" Then
                SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
                'detailsFile = Nothing
                'detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\" & tempenfile, True)
                'detailsFile.WriteLine(DecryptTripleDES(ReadFile(sqlpath)))
                'detailsFile.Close()

                'Dim mb As MySqlBackup = New MySqlBackup(conString)
                'mb.EnableEncryption = True
                'mb.EncryptionKey = "12kira34"
                '' mb.Import(System.IO.Path.GetTempPath() & "\" & tempenfile)
                'mb.Import(sqlpath)
                SplashScreenManager.CloseForm()

                XtraMessageBox.Show("Database successfully restored", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                System.IO.File.Delete(System.IO.Path.GetTempPath() & "\" & tempenfile)
            End If
        End If
    End Sub

    Private Sub cmdChangeUser_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdChangeUser.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmChangeUser.Visible = True Then
            frmChangeUser.Focus()
        Else
            frmChangeUser.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdSystemControl_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSystemControl.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmSystemControl.Visible = True Then
            frmSystemControl.Focus()
        Else
            frmSystemControl.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdUserPosition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUserAuthority.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCoffeecupClientPermission.Visible = True Then
            frmCoffeecupClientPermission.Focus()
        Else
            frmCoffeecupClientPermission.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdBankAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBankAccounts.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmBankAccounts.Visible = True Then
            frmBankAccounts.Focus()
        Else
            frmBankAccounts.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub cmdClientAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdClientAccounts.ItemClick

        frmClientManagement.MdiParent = Me
        frmClientManagement.Show()
        frmClientManagement.Focus()

    End Sub

    
    Private Sub BarButtonItem3_ItemClick_2(sender As Object, e As ItemClickEventArgs) Handles cmdGLItem.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmGLChartofAccounts.Visible = True Then
            frmGLChartofAccounts.Focus()
        Else
            frmGLChartofAccounts.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPumpSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPumpSettings.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmPumpSettings.Visible = True Then
            frmPumpSettings.Focus()
        Else
            frmPumpSettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPumpReading_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSetPumpReading.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmSetPumpReading.Visible = True Then
            frmSetPumpReading.Focus()
        Else
            frmSetPumpReading.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPumpReading_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles cmdPumpReading.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPumpReading.MdiParent = Me
        frmPumpReading.Show()
        frmPumpReading.Focus()
        SplashScreenManager.CloseForm()
    End Sub

 
    Private Sub BarButtonItem4_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles cmdFuelInventory.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmFuelTransactionLedger.MdiParent = Me
        frmFuelTransactionLedger.Show()
        frmFuelTransactionLedger.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdProductAdjustment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductAdjustment.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAdjustmentSales.Visible = True Then
            frmAdjustmentSales.Focus()
        Else
            frmAdjustmentSales.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdReportGenerator_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdReportGenerator.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReportGenerator.MdiParent = Me
        frmReportGenerator.Show()
        frmReportGenerator.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdReportDeveloper_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdReportDeveloper.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmReportDeveloper.Visible = True Then
            frmReportDeveloper.Focus()
        Else
            frmReportDeveloper.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdUserBlotter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCashiersBlotter.ItemClick

        frmCashiersBlotter.MdiParent = Me
        frmCashiersBlotter.Show()
        frmCashiersBlotter.Focus()

    End Sub

    Private Sub cmdAccountReceivable_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdStatementOfAccount.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStatementOfAccount.MdiParent = Me
        frmStatementOfAccount.Show()
        frmStatementOfAccount.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    'Private Sub cmdDepositTransactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDepositTransactions.ItemClick
    '    SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
    '    If frmDepositTransaction.Visible = True Then
    '        frmDepositTransaction.Focus()
    '    Else
    '        frmDepositTransaction.Show(Me)
    '    End If
    '    SplashScreenManager.CloseForm()
    'End Sub

    Private Sub cmdProductDiscount_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductDiscount.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmProductDiscount.Visible = True Then
            frmProductDiscount.Focus()
        Else
            frmProductDiscount.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdSalesTransaction_ItemClick(sender As Object, e As ItemClickEventArgs)

    End Sub

    Private Sub cmdSalesTransactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSalesTransactions.ItemClick

        frmSalesTransaction.MdiParent = Me
        frmSalesTransaction.Show()
        frmSalesTransaction.Focus()

    End Sub

    Private Sub cmdJournalEntry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdJournalEntry.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmAccountJournalEntry.Visible = True Then
            frmAccountJournalEntry.Focus()
        Else
            frmAccountJournalEntry.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdStatementofAccount_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBillingStatement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmBillingStatement.MdiParent = Me
        frmBillingStatement.Show()
        frmBillingStatement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

 

    Private Sub cmdTransactionClearing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTransactionClearing.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransactionClearing.MdiParent = Me
        frmTransactionClearing.Show()
        frmTransactionClearing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdAccountLedger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountLedger.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmBankAccountStatement.MdiParent = Me
        frmBankAccountStatement.Show()
        frmBankAccountStatement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub cmdCurrentDue_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCurrentDue.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmCurrentDueReceivable.MdiParent = Me
        frmCurrentDueReceivable.Show()
        frmCurrentDueReceivable.Focus()
        SplashScreenManager.CloseForm()
    End Sub



    Private Sub cmdProcessPurchaseOrder_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProcessPurchaseOrder.ItemClick
        frmRequestProcessing.processtype.Text = "po"
        frmRequestProcessing.Show(Me)
    End Sub

    Private Sub cmdProcessPaymentRequest_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProcessPaymentRequest.ItemClick
        frmRequestProcessing.processtype.Text = "pr"
        frmRequestProcessing.Show(Me)
    End Sub


    Private Sub cmdProductFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductFilter.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmProductFilter.Show(Me)
        SplashScreenManager.CloseForm()

    End Sub

    'Private Sub cmdIncomeStatement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdIncomeStatement.ItemClick
    '    frmIncomeStatement.MdiParent = Me
    '    frmIncomeStatement.Show()
    '    frmIncomeStatement.Focus()
    'End Sub

    Private Sub BarButtonItem3_ItemClick_3(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmForwardPO.Show(Me)
    End Sub

    Private Sub BarButtonItem2_ItemClick_2(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmAPPaymentApproved.Show(Me)
    End Sub

    Private Sub cmdGeneratePO_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdGeneratePO.ItemClick
        frmRequestProcessing.processtype.Text = "po"
        frmRequestProcessing.Show(Me)
    End Sub

    Private Sub cmdGeneratePayment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdGeneratePayment.ItemClick
        frmRequestProcessing.processtype.Text = "pr"
        frmRequestProcessing.Show(Me)
    End Sub

    Private Sub cmdForwardPO_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdForwardPO.ItemClick
        frmForwardPO.Show(Me)
    End Sub

    Private Sub cmdPOforPayment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPOforPayment.ItemClick
        If Globalallowdisbursepobybatch = True Then

        Else
            frmForDisbursmentRequest.Show(Me)
        End If
    End Sub

    Private Sub cmdAcountsPayable_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPaymentOrder.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPaymentOrder.MdiParent = Me
        frmPaymentOrder.Show()
        frmPaymentOrder.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdNewOnlineRequisition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdNewOnlineRequisition.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmOnlineRequisitionList.MdiParent = Me
        frmOnlineRequisitionList.Show()
        frmOnlineRequisitionList.Focus()
        frmOnlineRequisitionList.FilterOption()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdNewProductRegistration_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdNewProductRegistration.ItemClick
        frmProductRequestList.MdiParent = Me
        frmProductRequestList.Show()
        frmProductRequestList.Focus()
    End Sub

    Private Sub cmdTablesAndCottages_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTablesAndCottages.ItemClick
        frmHotelTablesAndCottages.Show(Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmSudgestionBox.Show(Me)
    End Sub

    Private Sub cmdUpdateChartofAccounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUpdateChartofAccounts.ItemClick
        frmGLCaptureChartofAccount.ShowDialog(Me)
    End Sub

    Private Sub cmdBillingGenerator_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBillingGenerator.ItemClick

        If frmBillingGenerator.Visible = True Then
            frmBillingGenerator.Focus()
        Else
            frmBillingGenerator.Show(Me)
        End If

    End Sub

    Private Sub cmdCancelClientTransaction_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCancelClientTransaction.ItemClick

        If frmCancel_invoices.Visible = True Then
            frmCancel_invoices.Focus()
        Else
            frmCancel_invoices.Show(Me)
        End If

    End Sub

    Private Sub cmdHotelRoomManagement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdHotelRoomManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmHotelRoomManagement.MdiParent = Me
        frmHotelRoomManagement.Show()
        frmHotelRoomManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdTransactionCode_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTransactionCode.ItemClick
        If frmTransactionCode.Visible = True Then
            frmTransactionCode.Focus()
        Else
            frmTransactionCode.Show(Me)
        End If
    End Sub

#Region "Conversation"
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterConversationOption()
    End Sub
    Public Sub FilterConversationOption()
        If XtraTabControl1.SelectedTabPage Is tabOpen Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterConversation(False)
            CloseReminderToolStripMenuItem.Visible = True
        Else
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterConversation(True)
            CloseReminderToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Sub FilterConversation(ByVal close As Boolean)
        LoadGridviewAppearance(GridView1)
        LoadXgrid("Select code, Title from tblreminders where closed=" & close & " order by datecreated desc", "tblreminders", Em, GridView1, Me)

        GridView1.Columns("code").Visible = False
        GridView1.MoveLast()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterConversationOption()
    End Sub
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If XtraTabControl1.SelectedTabPage Is tabOpen Then
            frmReminderHistory.txtMessage.Enabled = True
            frmReminderHistory.cmdaction.Enabled = True
        Else
            frmReminderHistory.txtMessage.Enabled = False
            frmReminderHistory.cmdaction.Enabled = False
        End If
        frmReminderHistory.code.Text = GridView1.GetFocusedRowCellValue("code").ToString
        frmReminderHistory.ShowDialog(Me)
    End Sub

    Private Sub CloseReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseReminderToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblreminders set closed=1 where code='" & GridView1.GetFocusedRowCellValue("code").ToString & "'" : com.ExecuteNonQuery()
            FilterConversationOption()
        End If
    End Sub
#End Region

    Private Sub cmdEmployeeList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmployeeList.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPayrollEmployeeManagement.MdiParent = Me
        frmPayrollEmployeeManagement.Show()
        frmPayrollEmployeeManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdEmployeeRegistration_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmployeeRegistration.ItemClick
        If frmPayrollEmployeeInformation.Visible = True Then
            frmPayrollEmployeeInformation.Focus()
        Else
            frmPayrollEmployeeInformation.Show(Me)
        End If
    End Sub

    Private Sub cmdEmployeePosition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmployeePosition.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPayrollEmplyeePosition.MdiParent = Me
        frmPayrollEmplyeePosition.Show()
        frmPayrollEmplyeePosition.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdEmployeeType_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmployeeType.ItemClick
        If frmPayrollEmployeeStatus.Visible = True Then
            frmPayrollEmployeeStatus.Focus()
        Else
            frmPayrollEmployeeStatus.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollSettings.ItemClick
        If frmPayrollSettings.Visible = True Then
            frmPayrollSettings.Focus()
        Else
            frmPayrollSettings.Show(Me)
        End If
    End Sub

    Private Sub cmdShitSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdShitSettings.ItemClick
        If frmPayrollShiftSettings.Visible = True Then
            frmPayrollShiftSettings.Focus()
        Else
            frmPayrollShiftSettings.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If frmDatabaseRepair.Visible = True Then
            frmDatabaseRepair.Focus()
        Else
            frmDatabaseRepair.Show(Me)
        End If
    End Sub

    Private Sub cmdDeductionRange_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDeductionRange.ItemClick
        If frmPayrollDeductionRange.Visible = True Then
            frmPayrollDeductionRange.Focus()
        Else
            frmPayrollDeductionRange.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollDeductions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollDeductions.ItemClick
        frmPayrollDedAddType.deduction.Text = "1"
        If frmPayrollDedAddType.Visible = True Then
            frmPayrollDedAddType.Focus()
        Else
            frmPayrollDedAddType.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollAdditional_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollAdditional.ItemClick
        frmPayrollDedAddType.deduction.Text = "0"
        If frmPayrollDedAddType.Visible = True Then
            frmPayrollDedAddType.Focus()
        Else
            frmPayrollDedAddType.Show(Me)
        End If
    End Sub

    Private Sub cmdAutoaddAdditionals_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAutoaddAdditionals.ItemClick
        If frmPayrollAutoAddAllowances.Visible = True Then
            frmPayrollAutoAddAllowances.Focus()
        Else
            frmPayrollAutoAddAllowances.Show(Me)
        End If
    End Sub

    Private Sub cmdAdditionalDeductions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAdditionalDeductions.ItemClick
        If frmPayrollAutoAddDeductions.Visible = True Then
            frmPayrollAutoAddDeductions.Focus()
        Else
            frmPayrollAutoAddDeductions.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollSchedule_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollSchedule.ItemClick
        If frmPayrollScheduleType.Visible = True Then
            frmPayrollScheduleType.Focus()
        Else
            frmPayrollScheduleType.Show(Me)
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub cmdPayrollHolidays_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollHolidays.ItemClick
        If frmPayrollHoliday.Visible = True Then
            frmPayrollHoliday.Focus()
        Else
            frmPayrollHoliday.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollPeriod_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollPeriod.ItemClick
        If frmPayrollPeriod.Visible = True Then
            frmPayrollPeriod.Focus()
        Else
            frmPayrollPeriod.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollCaptureBiometric_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollCaptureBiometric.ItemClick
        If frmPayrollCaptureAttendance.Visible = True Then
            frmPayrollCaptureAttendance.Focus()
        Else
            frmPayrollCaptureAttendance.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollProcessing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollProcessing.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPayrollProcessing.MdiParent = Me
        frmPayrollProcessing.Show()
        frmPayrollProcessing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdAddonsAndDeductions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAddonsAndDeductions.ItemClick
        If frmPayrollAddingDedadd.Visible = True Then
            frmPayrollAddingDedadd.Focus()
        Else
            frmPayrollAddingDedadd.Show(Me)
        End If
    End Sub

    Private Sub cmdAttendanceConsole_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAttendanceConsole.ItemClick
        If frmPayrollAttendanceConsole.Visible = True Then
            frmPayrollAttendanceConsole.Focus()
        Else
            frmPayrollAttendanceConsole.Show(Me)
        End If
    End Sub

    Private Sub cmdPayrollSummary_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPayrollSummary.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPayrollSummary.MdiParent = Me
        frmPayrollSummary.Show()
        frmPayrollSummary.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdRemittances_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRemittances.ItemClick
        XtraMessageBox.Show("Remittance template not yet uploaded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

   
    
    Private Sub cmdClientCheckClearing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdClientCheckClearing.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransactionClearing.MdiParent = Me
        frmTransactionClearing.Show()
        frmTransactionClearing.Focus()
        frmTransactionClearing.XtraTabControl1.SelectedTabPage = frmTransactionClearing.tabClientCheckClearing
        SplashScreenManager.CloseForm()
    End Sub

    'Private Sub cmdCheckPaymentClearing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCheckPaymentClearing.ItemClick
    '    SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
    '    frmTransactionClearing.MdiParent = Me
    '    frmTransactionClearing.Show()
    '    frmTransactionClearing.Focus()
    '    frmTransactionClearing.XtraTabControl1.SelectedTabPage = frmTransactionClearing.tabPaymentCheckClearing
    '    SplashScreenManager.CloseForm()
    'End Sub
 
 
    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdJournalEntries.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmGLJournalEntriesSummary.MdiParent = Me
        frmGLJournalEntriesSummary.Show()
        frmGLJournalEntriesSummary.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdGeneralLedger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountingTicket.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmGLAccountingTickets.MdiParent = Me
        frmGLAccountingTickets.Show()
        frmGLAccountingTickets.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdConsumableCutoff_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdConsumableCutoff.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmInventoryCutoffSummary.MdiParent = Me
        frmInventoryCutoffSummary.Show()
        frmInventoryCutoffSummary.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdClosedPayable_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdClosedPayable.ItemClick
        If frmConfirmClosedPayables.Visible = True Then
            frmConfirmClosedPayables.Focus()
        Else
            frmConfirmClosedPayables.Show(Me)
        End If
    End Sub

    Private Sub cmdUnconfiguredProductAssets_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUnconfiguredProductAssets.ItemClick
        cmdItemEntries.PerformClick()
    End Sub

    Private Sub cmdUnconfiguredDepreciation_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUnconfiguredDepreciation.ItemClick
        cmdAssetsAndDepreciation.PerformClick()
    End Sub

    Private Sub txtExpiration_ItemClick(sender As Object, e As ItemClickEventArgs) Handles txtExpiration.ItemClick
        frmActivateNewExpiration.ShowDialog(Me)
    End Sub
     Private Sub BarButtonItem9_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        frmActivateEngine.ShowDialog(Me)
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdMenuMaker.ItemClick
        frmProductMenuMaker.Show(Me)
    End Sub

    Private Sub BarButtonItem10_ItemClick_2(sender As Object, e As ItemClickEventArgs) Handles cmdUnitConverter.ItemClick
        frmUtilUnitConverterInfo.Show(Me)
    End Sub

    Private Sub BarButtonItem10_ItemClick_3(sender As Object, e As ItemClickEventArgs) Handles cmdCardType.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmCardPaymentType.Visible = True Then
            frmCardPaymentType.Focus()
        Else
            frmCardPaymentType.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

     

    Private Sub cmdPaymentApproved_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPaymentApproved.ItemClick
        If GlobalEnableVoucherPaymentPosting = True Then
           
        Else
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            If frmAPPaymentApproved.Visible = True Then
                frmAPPaymentApproved.Focus()
            Else
                frmAPPaymentApproved.Show(Me)
            End If
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub cmdFFEAccountable_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdFFEAccountable.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmFFEGenerateAccountablePDF.Visible = True Then
            frmFFEGenerateAccountablePDF.Focus()
        Else
            frmFFEGenerateAccountablePDF.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdVipCard_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdVipCard.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmHotelVipCard.Visible = True Then
            frmHotelVipCard.Focus()
        Else
            frmHotelVipCard.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    
    Private Sub cmdGuestManagement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdGuestManagement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmHotelGuestManagement.MdiParent = Me
        frmHotelGuestManagement.Show()
        frmHotelGuestManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    
    Private Sub cmdErrorCorrect_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdErrorCorrect.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmErrorCorrect_invoices.Visible = True Then
            frmErrorCorrect_invoices.Focus()
        Else
            frmErrorCorrect_invoices.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdProductSalesReport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductSalesReport.ItemClick
        frmSalesProductTransaction.MdiParent = Me
        frmSalesProductTransaction.Show()
        frmSalesProductTransaction.Focus()
    End Sub

    Private Sub cmdRoomDiscount_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRoomDiscount.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmHotelRoomDiscount.Visible = True Then
            frmHotelRoomDiscount.Focus()
        Else
            frmHotelRoomDiscount.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdQueuing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdQueuing.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmQueueingSettings.Visible = True Then
            frmQueueingSettings.Focus()
        Else
            frmQueueingSettings.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

 
    Private Sub cmdDatabaseRepair_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDatabaseRepair.ItemClick
        If frmDatabaseRepair.Visible = True Then
            frmDatabaseRepair.Focus()
        Else
            frmDatabaseRepair.Show(Me)
        End If
    End Sub

    Private Sub cmdBackupDatabase_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBackupDatabase.ItemClick
        If frmBackupTool.Visible = True Then
            frmBackupTool.Focus()
        Else
            frmBackupTool.Show(Me)
        End If
    End Sub

    Private Sub cmdInterOfficeSales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdInterOfficeSales.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmHotelInterOfficeTransaction.MdiParent = Me
        frmHotelInterOfficeTransaction.Show()
        frmHotelInterOfficeTransaction.Focus()
        SplashScreenManager.CloseForm()
    End Sub
 
    Private Sub cmdHotelRoomFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdHotelRoomFilter.ItemClick
        If frmHotelRoomFilters.Visible = True Then
            frmHotelRoomFilters.Focus()
        Else
            frmHotelRoomFilters.Show(Me)
        End If
    End Sub

    Private Sub cmdDueFromCorporateOffice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDueFromCorporateOffice.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSalesDueFromCorporateOfficeTransaction.MdiParent = Me
        frmSalesDueFromCorporateOfficeTransaction.Show()
        frmSalesDueFromCorporateOfficeTransaction.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdHotelManagement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdHotelManagement.ItemClick
        XtraMessageBox.Show("Function not yet available due to client version not yet done!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        'frmHotelManagement.MdiParent = Me
        'frmHotelManagement.Show()
        'frmHotelManagement.Focus()
        'SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdClinicServices_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdClinicServices.ItemClick
        If frmClinics.Visible = True Then
            frmClinics.Focus()
        Else
            frmClinics.Show(Me)
        End If
    End Sub

    Private Sub cmdRoomStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRoomStatus.ItemClick
        If frmHotelRoomStatus.Visible = True Then
            frmHotelRoomStatus.Focus()
        Else
            frmHotelRoomStatus.Show(Me)
        End If
    End Sub

    Private Sub cmdServiceMenuMaker_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdServiceMenuMaker.ItemClick
        If frmProductServiceMenuMaker.Visible = True Then
            frmProductServiceMenuMaker.Focus()
        Else
            frmProductServiceMenuMaker.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem10_ItemClick_4(sender As Object, e As ItemClickEventArgs) Handles cmdStockoutBatch.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStockoutDepedSummary.MdiParent = Me
        frmStockoutDepedSummary.Show()
        frmStockoutDepedSummary.Focus()
        frmStockoutDepedSummary.FilterStockoutSummary()
        SplashScreenManager.CloseForm()
    End Sub

    
    Private Sub cmdSwitchConnection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSwitchConnection.ItemClick
        frmClientConnetions.Show(Me)
    End Sub

    Private Sub cmdDepartments_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDepartments.ItemClick
        If frmPayrollDepartments.Visible = True Then
            frmPayrollDepartments.Focus()
        Else
            frmPayrollDepartments.Show(Me)
        End If
    End Sub

    Private Sub cmdRealtimeAudit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdRealtimeAudit.ItemClick
        frmCashiersRealtimeAudit.MdiParent = Me
        frmCashiersRealtimeAudit.Show()
        frmCashiersRealtimeAudit.Focus()
    End Sub

    Private Sub cmdAttendanceFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAttendanceFilter.ItemClick
        If frmAttendanceFilter.Visible = True Then
            frmAttendanceFilter.Focus()
        Else
            frmAttendanceFilter.Show(Me)
        End If
    End Sub

    Private Sub cmdEmployeeLevel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmployeeLevel.ItemClick
        If frmPayrollLevel.Visible = True Then
            frmPayrollLevel.Focus()
        Else
            frmPayrollLevel.Show(Me)
        End If
    End Sub

    Private Sub cmdHotelSalesReport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdHotelSalesReport.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmHotelBreakdownSales.MdiParent = Me
        frmHotelBreakdownSales.Show()
        frmHotelBreakdownSales.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdGLAccountFilter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdGLAccountFilter.ItemClick
        If frmGLAccountsFilter.Visible = True Then
            frmGLAccountsFilter.Focus()
        Else
            frmGLAccountsFilter.Show(Me)
        End If
    End Sub

    'Private Sub cmdDailyTransaction_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDailyAccountingReports.ItemClick
    '    SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
    '    frmDailyAccountingReports.MdiParent = Me
    '    frmDailyAccountingReports.Show()
    '    frmDailyAccountingReports.Focus()
    '    SplashScreenManager.CloseForm()
    'End Sub

    'Private Sub cmdDailyTransactionReports_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDailyTransactionReports.ItemClick
    '    SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
    '    frmDailyTransactionReports.MdiParent = Me
    '    frmDailyTransactionReports.Show()
    '    frmDailyTransactionReports.Focus()
    '    SplashScreenManager.CloseForm()
    'End Sub

    Private Sub cmdonhold_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdonhold.ItemClick
        cmdRequestForApproval.PerformClick()
    End Sub

    Private Sub cmdReceivingReport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdReceivingReport.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReceivingReport.MdiParent = Me
        frmReceivingReport.Show()
        frmReceivingReport.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdProductCharges_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProductCharges.ItemClick
        If frmProductCharges.Visible = True Then
            frmProductCharges.Focus()
        Else
            frmProductCharges.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem11_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles cmdAssetsSettings.ItemClick
        frmAssetsDepreciation.ShowDialog(Me)
    End Sub
 
    Private Sub cmdCreateVoucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCreateVoucher.ItemClick
        frmVouchersInformation.Show()
    End Sub

    Private Sub cmdDisbursermentVoucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDisbursermentVoucher.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmVoucherSummary.MdiParent = Me
        frmVoucherSummary.Show()
        frmVoucherSummary.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPurchaseOrder_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPurchaseOrder.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPurchaseOrder.MdiParent = Me
        frmPurchaseOrder.Show()
        frmPurchaseOrder.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdUnliquidatedCashAdvance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUnliquidatedCashAdvance.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUnliquidatedCashAdvance.MdiParent = Me
        frmUnliquidatedCashAdvance.Show()
        frmUnliquidatedCashAdvance.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdAccountJournal_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountJournal.ItemClick
        If frmAccountJournalEntry.Visible = True Then
            frmAccountJournalEntry.Focus()
        Else
            frmAccountJournalEntry.Show(Me)
        End If
    End Sub

    Private Sub BarButtonItem11_ItemClick_2(sender As Object, e As ItemClickEventArgs) Handles cmdAccountPayable.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmAPAccountPayableManagement.MdiParent = Me
        frmAPAccountPayableManagement.Show()
        frmAPAccountPayableManagement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdTransactionTragging_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTransactionTragging.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmGLAccountingSetup.MdiParent = Me
        frmGLAccountingSetup.Show()
        frmGLAccountingSetup.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdDailyTransactionReports_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdDailyTransactionReports.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmGLAccountReportsGenerator.MdiParent = Me
        frmGLAccountReportsGenerator.Show()
        frmGLAccountReportsGenerator.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdAccountGroupTagging_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdAccountGroupTagging.ItemClick
        If frmTAGDetails.Visible = True Then
            frmTAGDetails.Focus()
        Else
            frmTAGDetails.Show(Me)
        End If
    End Sub

    Private Sub cmdBalanceForward_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBalanceForward.ItemClick
        If frmBalanceForward.Visible = True Then
            frmBalanceForward.Focus()
        Else
            frmBalanceForward.Show(Me)
        End If
    End Sub

    Private Sub cmdTrialBalance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTrialBalance.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTrialBalance.MdiParent = Me
        frmTrialBalance.Show()
        frmTrialBalance.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdIncomeStatement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdIncomeStatement.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmIncomeStatement.MdiParent = Me
        frmIncomeStatement.Show()
        frmIncomeStatement.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdProofsheet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProofsheet.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmBalanceSheet.MdiParent = Me
        frmBalanceSheet.Show()
        frmBalanceSheet.Focus()
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub cmdCheckClearing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCheckClearing.ItemClick
        For Each tb In frmTransactionClearing.XtraTabControl1.TabPages
            If tb Is frmTransactionClearing.tabClientCheckClearing Or tb Is frmTransactionClearing.tabPaymentCheckClearing Then
                tb.PageVisible = True
            Else
                tb.PageVisible = False
            End If
        Next
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransactionClearing.MdiParent = Me
        frmTransactionClearing.Show()
        frmTransactionClearing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdCreditCardClearing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCreditCardClearing.ItemClick
        For Each tb In frmTransactionClearing.XtraTabControl1.TabPages
            If tb Is frmTransactionClearing.tabCreditCard Then
                tb.PageVisible = True
            Else
                tb.PageVisible = False
            End If
        Next
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmTransactionClearing.MdiParent = Me
        frmTransactionClearing.Show()
        frmTransactionClearing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPulloutRecord_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPulloutRecord.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmPulloutRecords.MdiParent = Me
        frmPulloutRecords.Show()
        frmPulloutRecords.Focus()
        SplashScreenManager.CloseForm()
    End Sub
End Class