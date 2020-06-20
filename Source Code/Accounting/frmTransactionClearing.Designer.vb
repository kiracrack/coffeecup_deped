<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionClearing
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdClearing = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelledTrnsactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabJournalEntries = New DevExpress.XtraTab.XtraTabPage()
        Me.tabOtherTransaction = New DevExpress.XtraTab.XtraTabPage()
        Me.tabAccountJournal = New DevExpress.XtraTab.XtraTabPage()
        Me.trnsumcode = New DevExpress.XtraEditors.TextEdit()
        Me.tabKeyAccountsPayments = New DevExpress.XtraTab.XtraTabPage()
        Me.tabClientCheckClearing = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPaymentCheckClearing = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCreditCard = New DevExpress.XtraTab.XtraTabPage()
        Me.tabOnlinePayment = New DevExpress.XtraTab.XtraTabPage()
        Me.tabDepositTransactions = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPurchaseOrderTransaction = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPurchaseOrderPayment = New DevExpress.XtraTab.XtraTabPage()
        Me.tabVoucherRequest = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPaymentVoucher = New DevExpress.XtraTab.XtraTabPage()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabJournalEntries.SuspendLayout()
        Me.tabAccountJournal.SuspendLayout()
        CType(Me.trnsumcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1022, 410)
        Me.Em.TabIndex = 650
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClearing, Me.CancelledTrnsactionToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(178, 76)
        '
        'cmdClearing
        '
        Me.cmdClearing.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearing.Image = Global.Coffeecup.My.Resources.Resources.games_endturn
        Me.cmdClearing.Name = "cmdClearing"
        Me.cmdClearing.Size = New System.Drawing.Size(177, 22)
        Me.cmdClearing.Text = "Cleared Transaction"
        '
        'CancelledTrnsactionToolStripMenuItem
        '
        Me.CancelledTrnsactionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.cross1
        Me.CancelledTrnsactionToolStripMenuItem.Name = "CancelledTrnsactionToolStripMenuItem"
        Me.CancelledTrnsactionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CancelledTrnsactionToolStripMenuItem.Text = "Cancel Transaction"
        Me.CancelledTrnsactionToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 22)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.PaintStyleName = "Skin"
        Me.XtraTabControl1.SelectedTabPage = Me.tabJournalEntries
        Me.XtraTabControl1.Size = New System.Drawing.Size(1028, 442)
        Me.XtraTabControl1.TabIndex = 651
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabJournalEntries, Me.tabOtherTransaction, Me.tabAccountJournal, Me.tabKeyAccountsPayments, Me.tabClientCheckClearing, Me.tabPaymentCheckClearing, Me.tabCreditCard, Me.tabOnlinePayment, Me.tabDepositTransactions, Me.tabPurchaseOrderTransaction, Me.tabPurchaseOrderPayment, Me.tabVoucherRequest, Me.tabPaymentVoucher})
        '
        'tabJournalEntries
        '
        Me.tabJournalEntries.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabJournalEntries.Appearance.Header.Options.UseFont = True
        Me.tabJournalEntries.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabJournalEntries.Appearance.HeaderActive.Options.UseFont = True
        Me.tabJournalEntries.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabJournalEntries.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabJournalEntries.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabJournalEntries.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabJournalEntries.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabJournalEntries.Appearance.PageClient.Options.UseFont = True
        Me.tabJournalEntries.Controls.Add(Me.Em)
        Me.tabJournalEntries.Name = "tabJournalEntries"
        Me.tabJournalEntries.Size = New System.Drawing.Size(1022, 410)
        Me.tabJournalEntries.Text = "Account Journal"
        '
        'tabOtherTransaction
        '
        Me.tabOtherTransaction.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOtherTransaction.Appearance.Header.Options.UseFont = True
        Me.tabOtherTransaction.Name = "tabOtherTransaction"
        Me.tabOtherTransaction.Size = New System.Drawing.Size(1258, 410)
        Me.tabOtherTransaction.Text = "Other Transaction"
        '
        'tabAccountJournal
        '
        Me.tabAccountJournal.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabAccountJournal.Appearance.Header.Options.UseFont = True
        Me.tabAccountJournal.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabAccountJournal.Appearance.HeaderActive.Options.UseFont = True
        Me.tabAccountJournal.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabAccountJournal.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabAccountJournal.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabAccountJournal.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabAccountJournal.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabAccountJournal.Appearance.PageClient.Options.UseFont = True
        Me.tabAccountJournal.Controls.Add(Me.trnsumcode)
        Me.tabAccountJournal.Name = "tabAccountJournal"
        Me.tabAccountJournal.Size = New System.Drawing.Size(1258, 410)
        Me.tabAccountJournal.Text = "Client Accounts Transaction"
        '
        'trnsumcode
        '
        Me.trnsumcode.Location = New System.Drawing.Point(338, 121)
        Me.trnsumcode.Name = "trnsumcode"
        Me.trnsumcode.Properties.Appearance.Options.UseTextOptions = True
        Me.trnsumcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnsumcode.Properties.ReadOnly = True
        Me.trnsumcode.Size = New System.Drawing.Size(53, 20)
        Me.trnsumcode.TabIndex = 671
        Me.trnsumcode.Visible = False
        '
        'tabKeyAccountsPayments
        '
        Me.tabKeyAccountsPayments.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabKeyAccountsPayments.Appearance.Header.Options.UseFont = True
        Me.tabKeyAccountsPayments.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabKeyAccountsPayments.Appearance.HeaderActive.Options.UseFont = True
        Me.tabKeyAccountsPayments.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabKeyAccountsPayments.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabKeyAccountsPayments.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabKeyAccountsPayments.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabKeyAccountsPayments.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabKeyAccountsPayments.Appearance.PageClient.Options.UseFont = True
        Me.tabKeyAccountsPayments.Name = "tabKeyAccountsPayments"
        Me.tabKeyAccountsPayments.Size = New System.Drawing.Size(1258, 410)
        Me.tabKeyAccountsPayments.Text = "Client Payment"
        '
        'tabClientCheckClearing
        '
        Me.tabClientCheckClearing.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabClientCheckClearing.Appearance.Header.Options.UseFont = True
        Me.tabClientCheckClearing.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabClientCheckClearing.Appearance.HeaderActive.Options.UseFont = True
        Me.tabClientCheckClearing.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabClientCheckClearing.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabClientCheckClearing.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabClientCheckClearing.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabClientCheckClearing.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabClientCheckClearing.Appearance.PageClient.Options.UseFont = True
        Me.tabClientCheckClearing.Name = "tabClientCheckClearing"
        Me.tabClientCheckClearing.Size = New System.Drawing.Size(1258, 410)
        Me.tabClientCheckClearing.Text = "Client Check"
        '
        'tabPaymentCheckClearing
        '
        Me.tabPaymentCheckClearing.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentCheckClearing.Appearance.Header.Options.UseFont = True
        Me.tabPaymentCheckClearing.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentCheckClearing.Appearance.HeaderActive.Options.UseFont = True
        Me.tabPaymentCheckClearing.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentCheckClearing.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabPaymentCheckClearing.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentCheckClearing.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabPaymentCheckClearing.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentCheckClearing.Appearance.PageClient.Options.UseFont = True
        Me.tabPaymentCheckClearing.Name = "tabPaymentCheckClearing"
        Me.tabPaymentCheckClearing.Size = New System.Drawing.Size(1258, 410)
        Me.tabPaymentCheckClearing.Text = "Payment Check"
        '
        'tabCreditCard
        '
        Me.tabCreditCard.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabCreditCard.Appearance.Header.Options.UseFont = True
        Me.tabCreditCard.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabCreditCard.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCreditCard.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabCreditCard.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCreditCard.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabCreditCard.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCreditCard.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabCreditCard.Appearance.PageClient.Options.UseFont = True
        Me.tabCreditCard.Name = "tabCreditCard"
        Me.tabCreditCard.Size = New System.Drawing.Size(1258, 410)
        Me.tabCreditCard.Text = "Credit Card"
        '
        'tabOnlinePayment
        '
        Me.tabOnlinePayment.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOnlinePayment.Appearance.Header.Options.UseFont = True
        Me.tabOnlinePayment.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOnlinePayment.Appearance.HeaderActive.Options.UseFont = True
        Me.tabOnlinePayment.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOnlinePayment.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabOnlinePayment.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOnlinePayment.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabOnlinePayment.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabOnlinePayment.Appearance.PageClient.Options.UseFont = True
        Me.tabOnlinePayment.Name = "tabOnlinePayment"
        Me.tabOnlinePayment.Size = New System.Drawing.Size(1258, 410)
        Me.tabOnlinePayment.Text = "Online Payment"
        '
        'tabDepositTransactions
        '
        Me.tabDepositTransactions.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabDepositTransactions.Appearance.Header.Options.UseFont = True
        Me.tabDepositTransactions.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabDepositTransactions.Appearance.HeaderActive.Options.UseFont = True
        Me.tabDepositTransactions.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabDepositTransactions.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabDepositTransactions.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabDepositTransactions.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabDepositTransactions.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabDepositTransactions.Appearance.PageClient.Options.UseFont = True
        Me.tabDepositTransactions.Name = "tabDepositTransactions"
        Me.tabDepositTransactions.Size = New System.Drawing.Size(1258, 410)
        Me.tabDepositTransactions.Text = "Sales Deposit"
        '
        'tabPurchaseOrderTransaction
        '
        Me.tabPurchaseOrderTransaction.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderTransaction.Appearance.Header.Options.UseFont = True
        Me.tabPurchaseOrderTransaction.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderTransaction.Appearance.HeaderActive.Options.UseFont = True
        Me.tabPurchaseOrderTransaction.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderTransaction.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabPurchaseOrderTransaction.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderTransaction.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabPurchaseOrderTransaction.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderTransaction.Appearance.PageClient.Options.UseFont = True
        Me.tabPurchaseOrderTransaction.Name = "tabPurchaseOrderTransaction"
        Me.tabPurchaseOrderTransaction.Size = New System.Drawing.Size(1258, 410)
        Me.tabPurchaseOrderTransaction.Text = "Purchase Order"
        '
        'tabPurchaseOrderPayment
        '
        Me.tabPurchaseOrderPayment.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderPayment.Appearance.Header.Options.UseFont = True
        Me.tabPurchaseOrderPayment.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderPayment.Appearance.HeaderActive.Options.UseFont = True
        Me.tabPurchaseOrderPayment.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderPayment.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabPurchaseOrderPayment.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderPayment.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabPurchaseOrderPayment.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPurchaseOrderPayment.Appearance.PageClient.Options.UseFont = True
        Me.tabPurchaseOrderPayment.Name = "tabPurchaseOrderPayment"
        Me.tabPurchaseOrderPayment.Size = New System.Drawing.Size(1258, 410)
        Me.tabPurchaseOrderPayment.Text = "PO Payment"
        '
        'tabVoucherRequest
        '
        Me.tabVoucherRequest.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabVoucherRequest.Appearance.Header.Options.UseFont = True
        Me.tabVoucherRequest.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabVoucherRequest.Appearance.HeaderActive.Options.UseFont = True
        Me.tabVoucherRequest.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabVoucherRequest.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabVoucherRequest.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabVoucherRequest.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabVoucherRequest.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabVoucherRequest.Appearance.PageClient.Options.UseFont = True
        Me.tabVoucherRequest.Name = "tabVoucherRequest"
        Me.tabVoucherRequest.Size = New System.Drawing.Size(1258, 410)
        Me.tabVoucherRequest.Text = "Vouchers Request"
        '
        'tabPaymentVoucher
        '
        Me.tabPaymentVoucher.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentVoucher.Appearance.Header.Options.UseFont = True
        Me.tabPaymentVoucher.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentVoucher.Appearance.HeaderActive.Options.UseFont = True
        Me.tabPaymentVoucher.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentVoucher.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabPaymentVoucher.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentVoucher.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabPaymentVoucher.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentVoucher.Appearance.PageClient.Options.UseFont = True
        Me.tabPaymentVoucher.Name = "tabPaymentVoucher"
        Me.tabPaymentVoucher.Size = New System.Drawing.Size(1258, 410)
        Me.tabPaymentVoucher.Text = "Payment Voucher"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export to Excel"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 464)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 442)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 442)
        '
        'frmTransactionClearing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 464)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTransactionClearing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Transaction Clearing"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabJournalEntries.ResumeLayout(False)
        Me.tabAccountJournal.ResumeLayout(False)
        CType(Me.trnsumcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdClearing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabAccountJournal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabKeyAccountsPayments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCreditCard As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents trnsumcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelledTrnsactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabDepositTransactions As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents tabPurchaseOrderTransaction As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPurchaseOrderPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabVoucherRequest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabClientCheckClearing As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPaymentCheckClearing As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabJournalEntries As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPaymentVoucher As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabOnlinePayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabOtherTransaction As DevExpress.XtraTab.XtraTabPage
End Class
