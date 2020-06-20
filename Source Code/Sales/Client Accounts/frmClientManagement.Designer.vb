<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientManagement
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetClientFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetClientGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdProductFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdClientTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewInformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUnblock = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBarAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdClientAcctFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdClientFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdClientGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientGroup = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.groupcode = New DevExpress.XtraEditors.TextEdit()
        Me.ckViewAll = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_showzero = New DevExpress.XtraEditors.CheckEdit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_showzero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.ClientFunctionToolStripMenuItem, Me.cmdClientTransaction, Me.ClientFunctionsToolStripMenuItem, Me.cmdDelete, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdColumnFilter, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(187, 186)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(186, 22)
        Me.cmdEdit.Text = "Edit Client"
        '
        'ClientFunctionToolStripMenuItem
        '
        Me.ClientFunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetClientFilter, Me.cmdSetClientGroup, Me.cmdProductFilter})
        Me.ClientFunctionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.user__arrow1
        Me.ClientFunctionToolStripMenuItem.Name = "ClientFunctionToolStripMenuItem"
        Me.ClientFunctionToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClientFunctionToolStripMenuItem.Text = "Set Client Policy"
        '
        'cmdSetClientFilter
        '
        Me.cmdSetClientFilter.Image = Global.Coffeecup.My.Resources.Resources.User_Program_Group2
        Me.cmdSetClientFilter.Name = "cmdSetClientFilter"
        Me.cmdSetClientFilter.Size = New System.Drawing.Size(164, 22)
        Me.cmdSetClientFilter.Text = "Set Client Filter"
        '
        'cmdSetClientGroup
        '
        Me.cmdSetClientGroup.Image = Global.Coffeecup.My.Resources.Resources.users
        Me.cmdSetClientGroup.Name = "cmdSetClientGroup"
        Me.cmdSetClientGroup.Size = New System.Drawing.Size(164, 22)
        Me.cmdSetClientGroup.Text = "Set Client Group"
        '
        'cmdProductFilter
        '
        Me.cmdProductFilter.Image = Global.Coffeecup.My.Resources.Resources.notebook_sticky_note
        Me.cmdProductFilter.Name = "cmdProductFilter"
        Me.cmdProductFilter.Size = New System.Drawing.Size(164, 22)
        Me.cmdProductFilter.Text = "Set Product Filter"
        '
        'cmdClientTransaction
        '
        Me.cmdClientTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewInformationToolStripMenuItem1, Me.StatementOfAccountToolStripMenuItem, Me.TransactionHistoryToolStripMenuItem, Me.PaymentTransactionToolStripMenuItem, Me.ToolStripSeparator2, Me.UpdateInvoicesToolStripMenuItem})
        Me.cmdClientTransaction.Image = Global.Coffeecup.My.Resources.Resources.book_open_next
        Me.cmdClientTransaction.Name = "cmdClientTransaction"
        Me.cmdClientTransaction.Size = New System.Drawing.Size(186, 22)
        Me.cmdClientTransaction.Text = "Client Transaction"
        '
        'ViewInformationToolStripMenuItem1
        '
        Me.ViewInformationToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.blogs_stack
        Me.ViewInformationToolStripMenuItem1.Name = "ViewInformationToolStripMenuItem1"
        Me.ViewInformationToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.ViewInformationToolStripMenuItem1.Text = "Billing Statement"
        '
        'StatementOfAccountToolStripMenuItem
        '
        Me.StatementOfAccountToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.calculator__arrow
        Me.StatementOfAccountToolStripMenuItem.Name = "StatementOfAccountToolStripMenuItem"
        Me.StatementOfAccountToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.StatementOfAccountToolStripMenuItem.Text = "Statement of Account"
        '
        'TransactionHistoryToolStripMenuItem
        '
        Me.TransactionHistoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.book_open_list
        Me.TransactionHistoryToolStripMenuItem.Name = "TransactionHistoryToolStripMenuItem"
        Me.TransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TransactionHistoryToolStripMenuItem.Text = "Transaction History"
        '
        'PaymentTransactionToolStripMenuItem
        '
        Me.PaymentTransactionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.money_coin1
        Me.PaymentTransactionToolStripMenuItem.Name = "PaymentTransactionToolStripMenuItem"
        Me.PaymentTransactionToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PaymentTransactionToolStripMenuItem.Text = "Payment History"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'UpdateInvoicesToolStripMenuItem
        '
        Me.UpdateInvoicesToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.dialog_ok_4
        Me.UpdateInvoicesToolStripMenuItem.Name = "UpdateInvoicesToolStripMenuItem"
        Me.UpdateInvoicesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UpdateInvoicesToolStripMenuItem.Text = "Update Invoices as Paid"
        '
        'ClientFunctionsToolStripMenuItem
        '
        Me.ClientFunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBlock, Me.cmdUnblock})
        Me.ClientFunctionsToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.exclamation_red_frame
        Me.ClientFunctionsToolStripMenuItem.Name = "ClientFunctionsToolStripMenuItem"
        Me.ClientFunctionsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClientFunctionsToolStripMenuItem.Text = "Client Block/Unblock"
        '
        'cmdBlock
        '
        Me.cmdBlock.Image = Global.Coffeecup.My.Resources.Resources.xfn_sweetheart
        Me.cmdBlock.Name = "cmdBlock"
        Me.cmdBlock.Size = New System.Drawing.Size(137, 22)
        Me.cmdBlock.Text = "Block Client"
        '
        'cmdUnblock
        '
        Me.cmdUnblock.Image = Global.Coffeecup.My.Resources.Resources.xfn_friend_met
        Me.cmdUnblock.Name = "cmdUnblock"
        Me.cmdUnblock.Size = New System.Drawing.Size(137, 22)
        Me.cmdUnblock.Text = "Unblocked"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.user__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(186, 22)
        Me.cmdDelete.Text = "Remove Accounts"
        Me.cmdDelete.Visible = False
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'cmdColumnFilter
        '
        Me.cmdColumnFilter.Image = Global.Coffeecup.My.Resources.Resources.tables_stacks
        Me.cmdColumnFilter.Name = "cmdColumnFilter"
        Me.cmdColumnFilter.Size = New System.Drawing.Size(186, 22)
        Me.cmdColumnFilter.Text = "Edit Column Display"
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(1, 91)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(1027, 472)
        Me.Em.TabIndex = 5
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.cmdBarAdd, Me.BarButtonItem2, Me.BarButtonItem3, Me.cmdClientFilter, Me.cmdClientGroup, Me.cmdClientAcctFilter, Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar3
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar3.BarAppearance.Normal.Options.UseFont = True
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBarAdd, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClientAcctFilter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClientFilter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClientGroup, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 3"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Close Window"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdBarAdd
        '
        Me.cmdBarAdd.Caption = "&Create New Client Account"
        Me.cmdBarAdd.Id = 3
        Me.cmdBarAdd.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdBarAdd.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBarAdd.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdBarAdd.ItemAppearance.Normal.Options.UseForeColor = True
        Me.cmdBarAdd.Name = "cmdBarAdd"
        '
        'cmdClientAcctFilter
        '
        Me.cmdClientAcctFilter.Caption = "Client Account's Filter"
        Me.cmdClientAcctFilter.Id = 8
        Me.cmdClientAcctFilter.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdClientAcctFilter.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdClientAcctFilter.Name = "cmdClientAcctFilter"
        '
        'cmdClientFilter
        '
        Me.cmdClientFilter.Caption = "Filter Settings"
        Me.cmdClientFilter.Id = 6
        Me.cmdClientFilter.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdClientFilter.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdClientFilter.Name = "cmdClientFilter"
        '
        'cmdClientGroup
        '
        Me.cmdClientGroup.Caption = "Client Group"
        Me.cmdClientGroup.Id = 7
        Me.cmdClientGroup.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdClientGroup.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdClientGroup.Name = "cmdClientGroup"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&Show Search Panel"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ItemAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem3.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem3.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem3.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem3.ItemInMenuAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem3.ItemInMenuAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem3.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem3.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Export to Excel"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.ItemAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem1.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem1.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarButtonItem1.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 564)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 540)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 540)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(32, 39)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(85, 20)
        Me.LabelControl13.TabIndex = 707
        Me.LabelControl13.Text = "Select Group"
        '
        'txtClientGroup
        '
        Me.txtClientGroup.EditValue = ""
        Me.txtClientGroup.Location = New System.Drawing.Point(125, 37)
        Me.txtClientGroup.Name = "txtClientGroup"
        Me.txtClientGroup.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientGroup.Properties.Appearance.Options.UseFont = True
        Me.txtClientGroup.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtClientGroup.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtClientGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClientGroup.Properties.PopupSizeable = True
        Me.txtClientGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtClientGroup.Size = New System.Drawing.Size(298, 26)
        Me.txtClientGroup.TabIndex = 708
        '
        'groupcode
        '
        Me.groupcode.EnterMoveNextControl = True
        Me.groupcode.Location = New System.Drawing.Point(277, 272)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Size = New System.Drawing.Size(60, 20)
        Me.groupcode.TabIndex = 710
        Me.groupcode.Visible = False
        '
        'ckViewAll
        '
        Me.ckViewAll.Location = New System.Drawing.Point(427, 38)
        Me.ckViewAll.Name = "ckViewAll"
        Me.ckViewAll.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAll.Properties.Appearance.Options.UseFont = True
        Me.ckViewAll.Properties.Caption = "View all clients"
        Me.ckViewAll.Size = New System.Drawing.Size(153, 24)
        Me.ckViewAll.TabIndex = 716
        '
        'ck_showzero
        '
        Me.ck_showzero.EditValue = True
        Me.ck_showzero.Location = New System.Drawing.Point(125, 66)
        Me.ck_showzero.Name = "ck_showzero"
        Me.ck_showzero.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_showzero.Properties.Appearance.Options.UseFont = True
        Me.ck_showzero.Properties.Caption = "Show zero balance"
        Me.ck_showzero.Size = New System.Drawing.Size(185, 19)
        Me.ck_showzero.TabIndex = 722
        '
        'frmClientManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 564)
        Me.Controls.Add(Me.ck_showzero)
        Me.Controls.Add(Me.ckViewAll)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtClientGroup)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmClientManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Account Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_showzero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmdBarAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmdClientTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewInformationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransactionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInvoicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClientFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdColumnFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClientGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientGroup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents groupcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdClientAcctFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckViewAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck_showzero As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClientFunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetClientGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientFunctionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetClientFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdProductFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBlock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUnblock As System.Windows.Forms.ToolStripMenuItem
End Class
