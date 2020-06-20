<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryConsumables
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUpdateInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAdjustment = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStockout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBalanceForward = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcategory = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.ck_category = New DevExpress.XtraEditors.CheckEdit()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtInventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ck_inventory = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.rc_transfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckStockSequence = New DevExpress.XtraEditors.CheckEdit()
        Me.ck_showzeroquantity = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilterName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckStockSequence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_showzeroquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1028, 470)
        Me.Em.TabIndex = 508
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHistory, Me.cmdUpdateInfo, Me.cmdAdjustment, Me.UnitConverterToolStripMenuItem, Me.cmdRemove, Me.cmdStockout, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 164)
        '
        'cmdHistory
        '
        Me.cmdHistory.Image = Global.Coffeecup.My.Resources.Resources.clipboard_task
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.Size = New System.Drawing.Size(191, 22)
        Me.cmdHistory.Text = "View Inventory Ledger"
        '
        'cmdUpdateInfo
        '
        Me.cmdUpdateInfo.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdUpdateInfo.Name = "cmdUpdateInfo"
        Me.cmdUpdateInfo.Size = New System.Drawing.Size(191, 22)
        Me.cmdUpdateInfo.Text = "Update Inventory Info"
        '
        'cmdAdjustment
        '
        Me.cmdAdjustment.Image = Global.Coffeecup.My.Resources.Resources.report__arrow1
        Me.cmdAdjustment.Name = "cmdAdjustment"
        Me.cmdAdjustment.Size = New System.Drawing.Size(191, 22)
        Me.cmdAdjustment.Text = "Item Adjustment"
        '
        'UnitConverterToolStripMenuItem
        '
        Me.UnitConverterToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.blue_document_convert
        Me.UnitConverterToolStripMenuItem.Name = "UnitConverterToolStripMenuItem"
        Me.UnitConverterToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UnitConverterToolStripMenuItem.Text = "Unit Convertion"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.Coffeecup.My.Resources.Resources.report__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(191, 22)
        Me.cmdRemove.Text = "Remove Inventory"
        '
        'cmdStockout
        '
        Me.cmdStockout.Image = Global.Coffeecup.My.Resources.Resources.inbox_upload
        Me.cmdStockout.Name = "cmdStockout"
        Me.cmdStockout.Size = New System.Drawing.Size(191, 22)
        Me.cmdStockout.Text = "Stock Out Inventory"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Inventory"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarCheckItem1, Me.cmdExportToExcel, Me.BarButtonItem3, Me.BarButtonItem4, Me.cmdBalanceForward})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 10
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdExportToExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBalanceForward, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
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
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Unit Converter"
        Me.BarButtonItem4.Id = 8
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Summary"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdExportToExcel
        '
        Me.cmdExportToExcel.Caption = "Export to Excel"
        Me.cmdExportToExcel.Id = 6
        Me.cmdExportToExcel.Name = "cmdExportToExcel"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Filter Settings"
        Me.BarCheckItem1.Id = 5
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Lock Cut-off Inventory"
        Me.BarButtonItem3.Id = 7
        Me.BarButtonItem3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'cmdBalanceForward
        '
        Me.cmdBalanceForward.Caption = "Balance Forward Inventory"
        Me.cmdBalanceForward.Id = 9
        Me.cmdBalanceForward.Name = "cmdBalanceForward"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 621)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 599)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 599)
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(27, 46)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl9.TabIndex = 513
        Me.LabelControl9.Text = "Select Category"
        '
        'txtcategory
        '
        Me.txtcategory.EditValue = "Select Category"
        Me.txtcategory.Enabled = False
        Me.txtcategory.EnterMoveNextControl = True
        Me.txtcategory.Location = New System.Drawing.Point(116, 42)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.Properties.Appearance.Options.UseFont = True
        Me.txtcategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcategory.Properties.DisplayMember = "DESCRIPTION"
        Me.txtcategory.Properties.NullText = ""
        Me.txtcategory.Properties.ValueMember = "DESCRIPTION"
        Me.txtcategory.Properties.View = Me.GridView2
        Me.txtcategory.Size = New System.Drawing.Size(297, 22)
        Me.txtcategory.TabIndex = 2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(865, 7)
        Me.catid.Name = "catid"
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(73, 20)
        Me.catid.TabIndex = 541
        Me.catid.Visible = False
        '
        'ck_category
        '
        Me.ck_category.EditValue = True
        Me.ck_category.Location = New System.Drawing.Point(420, 43)
        Me.ck_category.Name = "ck_category"
        Me.ck_category.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_category.Properties.Appearance.Options.UseFont = True
        Me.ck_category.Properties.Caption = "View All"
        Me.ck_category.Size = New System.Drawing.Size(80, 19)
        Me.ck_category.TabIndex = 538
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(32, 19)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(77, 13)
        Me.lblOffice.TabIndex = 549
        Me.lblOffice.Text = "Select  Office"
        '
        'txtInventory
        '
        Me.txtInventory.EditValue = ""
        Me.txtInventory.Enabled = False
        Me.txtInventory.Location = New System.Drawing.Point(116, 16)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventory.Properties.Appearance.Options.UseFont = True
        Me.txtInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtInventory.Properties.DisplayMember = "Select Inventory"
        Me.txtInventory.Properties.NullText = ""
        Me.txtInventory.Properties.ValueMember = "Select Inventory"
        Me.txtInventory.Properties.View = Me.gv_inventory
        Me.txtInventory.Size = New System.Drawing.Size(297, 22)
        Me.txtInventory.TabIndex = 1
        '
        'gv_inventory
        '
        Me.gv_inventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_inventory.Name = "gv_inventory"
        Me.gv_inventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_inventory.OptionsView.ShowGroupPanel = False
        '
        'ck_inventory
        '
        Me.ck_inventory.EditValue = True
        Me.ck_inventory.Location = New System.Drawing.Point(420, 17)
        Me.ck_inventory.Name = "ck_inventory"
        Me.ck_inventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_inventory.Properties.Appearance.Options.UseFont = True
        Me.ck_inventory.Properties.Caption = "View All"
        Me.ck_inventory.Size = New System.Drawing.Size(80, 19)
        Me.ck_inventory.TabIndex = 550
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(306, 68)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(107, 30)
        Me.cmdaction.TabIndex = 5
        Me.cmdaction.Text = "Filter Inventory"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(786, 7)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(73, 20)
        Me.officeid.TabIndex = 561
        Me.officeid.Visible = False
        '
        'rc_transfer
        '
        Me.rc_transfer.Image = Global.Coffeecup.My.Resources.Resources.report__arrow1
        Me.rc_transfer.Name = "rc_transfer"
        Me.rc_transfer.Size = New System.Drawing.Size(205, 22)
        Me.rc_transfer.Text = "Transfer Selected Item"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckStockSequence)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_showzeroquantity)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl9)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.catid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtcategory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_category)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtInventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_inventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtFilterName)
        Me.SplitContainerControl1.Panel1.MinSize = 110
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1028, 599)
        Me.SplitContainerControl1.SplitterPosition = 124
        Me.SplitContainerControl1.TabIndex = 591
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckStockSequence
        '
        Me.ckStockSequence.Location = New System.Drawing.Point(115, 70)
        Me.ckStockSequence.Name = "ckStockSequence"
        Me.ckStockSequence.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckStockSequence.Properties.Appearance.Options.UseFont = True
        Me.ckStockSequence.Properties.Caption = "Stock sequence inventory view"
        Me.ckStockSequence.Size = New System.Drawing.Size(185, 19)
        Me.ckStockSequence.TabIndex = 625
        '
        'ck_showzeroquantity
        '
        Me.ck_showzeroquantity.Location = New System.Drawing.Point(115, 89)
        Me.ck_showzeroquantity.Name = "ck_showzeroquantity"
        Me.ck_showzeroquantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_showzeroquantity.Properties.Appearance.Options.UseFont = True
        Me.ck_showzeroquantity.Properties.Caption = "Show zero or negativequantity"
        Me.ck_showzeroquantity.Size = New System.Drawing.Size(184, 19)
        Me.ck_showzeroquantity.TabIndex = 624
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(751, 81)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 15)
        Me.LabelControl1.TabIndex = 587
        Me.LabelControl1.Text = "Search"
        '
        'txtFilterName
        '
        Me.txtFilterName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilterName.Location = New System.Drawing.Point(791, 78)
        Me.txtFilterName.Name = "txtFilterName"
        Me.txtFilterName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterName.Properties.Appearance.Options.UseFont = True
        Me.txtFilterName.Properties.ValidateOnEnterKey = True
        Me.txtFilterName.Size = New System.Drawing.Size(224, 22)
        Me.txtFilterName.TabIndex = 0
        '
        'frmInventoryConsumables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 621)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(776, 481)
        Me.Name = "frmInventoryConsumables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumables Inventory Summary"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckStockSequence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_showzeroquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcategory As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ck_category As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ck_inventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAdjustment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rc_transfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdExportToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ck_showzeroquantity As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtFilterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents UnitConverterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdStockout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckStockSequence As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdUpdateInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBalanceForward As DevExpress.XtraBars.BarButtonItem
End Class
