<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashiersTransactionClearing
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashiersTransactionClearing))
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabKeyAccounts = New DevExpress.XtraTab.XtraTabPage()
        Me.trnsumcode = New DevExpress.XtraEditors.TextEdit()
        Me.tabExpenses = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCheck = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCreditCard = New DevExpress.XtraTab.XtraTabPage()
        Me.tabBankPayment = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCashChange = New DevExpress.XtraTab.XtraTabPage()
        Me.tabAccountJournal = New DevExpress.XtraTab.XtraTabPage()
        Me.tabClientJournal = New DevExpress.XtraTab.XtraTabPage()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdKeyAccounts = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdExpense = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdCheckTransaction = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdCreditCard = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdBanksPayment = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdEncashment = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAccountJournal = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdClientJournal = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabKeyAccounts.SuspendLayout()
        CType(Me.trnsumcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        GridLevelNode2.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(677, 594)
        Me.Em.TabIndex = 650
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.ViewAttachmentToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(178, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.games_endturn
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(177, 22)
        Me.cmdEdit.Text = "Cleared Transaction"
        '
        'ViewAttachmentToolStripMenuItem
        '
        Me.ViewAttachmentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow
        Me.ViewAttachmentToolStripMenuItem.Name = "ViewAttachmentToolStripMenuItem"
        Me.ViewAttachmentToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ViewAttachmentToolStripMenuItem.Text = "View Attachment"
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
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.PageClient.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.XtraTabControl1.AppearancePage.PageClient.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(247, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabKeyAccounts
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.Size = New System.Drawing.Size(683, 600)
        Me.XtraTabControl1.TabIndex = 651
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabKeyAccounts, Me.tabExpenses, Me.tabCheck, Me.tabCreditCard, Me.tabBankPayment, Me.tabCashChange, Me.tabAccountJournal, Me.tabClientJournal})
        '
        'tabKeyAccounts
        '
        Me.tabKeyAccounts.Controls.Add(Me.trnsumcode)
        Me.tabKeyAccounts.Controls.Add(Me.Em)
        Me.tabKeyAccounts.Name = "tabKeyAccounts"
        Me.tabKeyAccounts.Size = New System.Drawing.Size(677, 594)
        Me.tabKeyAccounts.Text = "Key Accounts Transaction"
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
        'tabExpenses
        '
        Me.tabExpenses.Name = "tabExpenses"
        Me.tabExpenses.Size = New System.Drawing.Size(677, 594)
        Me.tabExpenses.Text = "Expenses Transaction"
        '
        'tabCheck
        '
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(677, 594)
        Me.tabCheck.Text = "Check Transaction"
        '
        'tabCreditCard
        '
        Me.tabCreditCard.Name = "tabCreditCard"
        Me.tabCreditCard.Size = New System.Drawing.Size(677, 594)
        Me.tabCreditCard.Text = "Credit Card Transaction"
        '
        'tabBankPayment
        '
        Me.tabBankPayment.Name = "tabBankPayment"
        Me.tabBankPayment.Size = New System.Drawing.Size(677, 594)
        Me.tabBankPayment.Text = "Bank Payment Transaction"
        '
        'tabCashChange
        '
        Me.tabCashChange.Name = "tabCashChange"
        Me.tabCashChange.Size = New System.Drawing.Size(677, 594)
        Me.tabCashChange.Text = "Cash Change Transaction"
        '
        'tabAccountJournal
        '
        Me.tabAccountJournal.Name = "tabAccountJournal"
        Me.tabAccountJournal.Size = New System.Drawing.Size(677, 594)
        Me.tabAccountJournal.Text = "Account Journal Entries"
        '
        'tabClientJournal
        '
        Me.tabClientJournal.Name = "tabClientJournal"
        Me.tabClientJournal.Size = New System.Drawing.Size(677, 594)
        Me.tabClientJournal.Text = "Client Journal Entries"
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup5
        Me.NavBarControl2.AllowDrop = False
        Me.NavBarControl2.Appearance.GroupHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.GroupHeaderActive.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.GroupHeaderHotTracked.Options.UseFont = True
        Me.NavBarControl2.Appearance.GroupHeaderPressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.GroupHeaderPressed.Options.UseFont = True
        Me.NavBarControl2.Appearance.Item.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.Item.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemActive.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.ItemActive.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemHotTracked.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NavBarControl2.Appearance.ItemHotTracked.Options.UseFont = True
        Me.NavBarControl2.Appearance.ItemPressed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl2.Appearance.ItemPressed.Options.UseFont = True
        Me.NavBarControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup5})
        Me.NavBarControl2.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdKeyAccounts, Me.cmdExpense, Me.cmdCheckTransaction, Me.cmdCreditCard, Me.cmdBanksPayment, Me.cmdEncashment, Me.cmdAccountJournal, Me.cmdClientJournal})
        Me.NavBarControl2.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsLayout.StoreAppearance = True
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 247
        Me.NavBarControl2.Size = New System.Drawing.Size(247, 600)
        Me.NavBarControl2.TabIndex = 652
        Me.NavBarControl2.Text = "NavBarControl2"
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Caption = "Clearing Menu"
        Me.NavBarGroup5.Expanded = True
        Me.NavBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdKeyAccounts), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdExpense), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdCheckTransaction), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdCreditCard), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdBanksPayment), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdEncashment), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAccountJournal), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdClientJournal)})
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'cmdKeyAccounts
        '
        Me.cmdKeyAccounts.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdKeyAccounts.Appearance.Options.UseFont = True
        Me.cmdKeyAccounts.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdKeyAccounts.AppearanceDisabled.Options.UseFont = True
        Me.cmdKeyAccounts.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdKeyAccounts.AppearanceHotTracked.Options.UseFont = True
        Me.cmdKeyAccounts.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdKeyAccounts.AppearancePressed.Options.UseFont = True
        Me.cmdKeyAccounts.Caption = "Client Accounts Transaction"
        Me.cmdKeyAccounts.Name = "cmdKeyAccounts"
        Me.cmdKeyAccounts.SmallImage = CType(resources.GetObject("cmdKeyAccounts.SmallImage"), System.Drawing.Image)
        '
        'cmdExpense
        '
        Me.cmdExpense.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdExpense.Appearance.Options.UseFont = True
        Me.cmdExpense.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdExpense.AppearanceDisabled.Options.UseFont = True
        Me.cmdExpense.AppearanceHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdExpense.AppearanceHotTracked.Options.UseFont = True
        Me.cmdExpense.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdExpense.AppearancePressed.Options.UseFont = True
        Me.cmdExpense.Caption = "Expense Transaction"
        Me.cmdExpense.Name = "cmdExpense"
        Me.cmdExpense.SmallImage = CType(resources.GetObject("cmdExpense.SmallImage"), System.Drawing.Image)
        '
        'cmdCheckTransaction
        '
        Me.cmdCheckTransaction.Caption = "Check Transaction"
        Me.cmdCheckTransaction.Name = "cmdCheckTransaction"
        Me.cmdCheckTransaction.SmallImage = CType(resources.GetObject("cmdCheckTransaction.SmallImage"), System.Drawing.Image)
        '
        'cmdCreditCard
        '
        Me.cmdCreditCard.Caption = "Credit Card Transaction"
        Me.cmdCreditCard.Name = "cmdCreditCard"
        Me.cmdCreditCard.SmallImage = CType(resources.GetObject("cmdCreditCard.SmallImage"), System.Drawing.Image)
        '
        'cmdBanksPayment
        '
        Me.cmdBanksPayment.Caption = "Online Payments Transaction"
        Me.cmdBanksPayment.Name = "cmdBanksPayment"
        Me.cmdBanksPayment.SmallImage = CType(resources.GetObject("cmdBanksPayment.SmallImage"), System.Drawing.Image)
        '
        'cmdEncashment
        '
        Me.cmdEncashment.Caption = "Check Encashment Transaction"
        Me.cmdEncashment.Name = "cmdEncashment"
        Me.cmdEncashment.SmallImage = CType(resources.GetObject("cmdEncashment.SmallImage"), System.Drawing.Image)
        '
        'cmdAccountJournal
        '
        Me.cmdAccountJournal.Caption = "Account Journal Transaction"
        Me.cmdAccountJournal.Name = "cmdAccountJournal"
        Me.cmdAccountJournal.SmallImage = CType(resources.GetObject("cmdAccountJournal.SmallImage"), System.Drawing.Image)
        '
        'cmdClientJournal
        '
        Me.cmdClientJournal.Caption = "Client Journal Transaction"
        Me.cmdClientJournal.Name = "cmdClientJournal"
        Me.cmdClientJournal.SmallImage = CType(resources.GetObject("cmdClientJournal.SmallImage"), System.Drawing.Image)
        '
        'frmCashiersTransactionClearing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 600)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Name = "frmCashiersTransactionClearing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier's Transaction Clearing"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabKeyAccounts.ResumeLayout(False)
        CType(Me.trnsumcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabKeyAccounts As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCreditCard As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCashChange As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabClientJournal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents trnsumcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabExpenses As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ViewAttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabBankPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabAccountJournal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents cmdKeyAccounts As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdExpense As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdCheckTransaction As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdCreditCard As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdBanksPayment As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdEncashment As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdAccountJournal As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdClientJournal As DevExpress.XtraNavBar.NavBarItem
End Class
