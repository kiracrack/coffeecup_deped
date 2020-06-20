<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepedFFESummary
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
        Me.EditEquimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSequenceNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PulloutItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintStickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProductBatchingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrintCustodian = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPAR = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtInventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ck_inventory = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.rc_transfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckTemplate = New DevExpress.XtraEditors.CheckEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.txtProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ckProduct = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTemplate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtaccountableid = New DevExpress.XtraEditors.TextEdit()
        Me.txtaccountablePerson = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAccountable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ckAccountable = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdPrintPropertyCard = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtaccountableid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtaccountablePerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAccountable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAccountable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1235, 440)
        Me.Em.TabIndex = 508
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEquimentToolStripMenuItem, Me.SetSequenceNoToolStripMenuItem, Me.PulloutItemToolStripMenuItem, Me.PrintStickerToolStripMenuItem, Me.UpdateProductBatchingToolStripMenuItem, Me.DeleteEquipmentToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(216, 164)
        '
        'EditEquimentToolStripMenuItem
        '
        Me.EditEquimentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.EditEquimentToolStripMenuItem.Name = "EditEquimentToolStripMenuItem"
        Me.EditEquimentToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EditEquimentToolStripMenuItem.Text = "Edit Equipment"
        '
        'SetSequenceNoToolStripMenuItem
        '
        Me.SetSequenceNoToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit_list_order
        Me.SetSequenceNoToolStripMenuItem.Name = "SetSequenceNoToolStripMenuItem"
        Me.SetSequenceNoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SetSequenceNoToolStripMenuItem.Text = "Set Sequence No"
        '
        'PulloutItemToolStripMenuItem
        '
        Me.PulloutItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_curve
        Me.PulloutItemToolStripMenuItem.Name = "PulloutItemToolStripMenuItem"
        Me.PulloutItemToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.PulloutItemToolStripMenuItem.Text = "Pullout Equipment"
        '
        'PrintStickerToolStripMenuItem
        '
        Me.PrintStickerToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.Printer__2_
        Me.PrintStickerToolStripMenuItem.Name = "PrintStickerToolStripMenuItem"
        Me.PrintStickerToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.PrintStickerToolStripMenuItem.Text = "Print Inventory Sticker"
        '
        'UpdateProductBatchingToolStripMenuItem
        '
        Me.UpdateProductBatchingToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit_copy_3
        Me.UpdateProductBatchingToolStripMenuItem.Name = "UpdateProductBatchingToolStripMenuItem"
        Me.UpdateProductBatchingToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.UpdateProductBatchingToolStripMenuItem.Text = "Update Product Batching"
        '
        'DeleteEquipmentToolStripMenuItem
        '
        Me.DeleteEquipmentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.cross
        Me.DeleteEquipmentToolStripMenuItem.Name = "DeleteEquipmentToolStripMenuItem"
        Me.DeleteEquipmentToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.DeleteEquipmentToolStripMenuItem.Text = "Delete Selected Equipment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(212, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdPrintCustodian, Me.BarButtonItem4, Me.cmdPAR, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem5, Me.cmdPrintPropertyCard})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 11
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrintCustodian, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPAR, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrintPropertyCard, True)})
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
        Me.BarButtonItem4.Caption = "Upload New Equipment"
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export to Excel"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Inventory List"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdPrintCustodian
        '
        Me.cmdPrintCustodian.Caption = "Print Custodian Slip (ICS)"
        Me.cmdPrintCustodian.Id = 2
        Me.cmdPrintCustodian.Name = "cmdPrintCustodian"
        Me.cmdPrintCustodian.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdPAR
        '
        Me.cmdPAR.Caption = "Print Property Ackwnoledgement Receipt (PAR)"
        Me.cmdPAR.Id = 6
        Me.cmdPAR.Name = "cmdPAR"
        Me.cmdPAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Print Physical Count Report"
        Me.BarButtonItem5.Id = 9
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1235, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 621)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1235, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 599)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1235, 22)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 599)
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(867, 14)
        Me.catid.Name = "catid"
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(73, 20)
        Me.catid.TabIndex = 541
        Me.catid.Visible = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.Options.UseFont = True
        Me.lblOffice.Appearance.Options.UseTextOptions = True
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(41, 17)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(82, 13)
        Me.lblOffice.TabIndex = 549
        Me.lblOffice.Text = "Select Office"
        '
        'txtInventory
        '
        Me.txtInventory.EditValue = ""
        Me.txtInventory.Enabled = False
        Me.txtInventory.Location = New System.Drawing.Point(130, 14)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventory.Properties.Appearance.Options.UseFont = True
        Me.txtInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtInventory.Properties.DisplayMember = "Select Office"
        Me.txtInventory.Properties.NullText = ""
        Me.txtInventory.Properties.PopupView = Me.gv_inventory
        Me.txtInventory.Properties.ValueMember = "Select Office"
        Me.txtInventory.Size = New System.Drawing.Size(297, 20)
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
        Me.ck_inventory.Location = New System.Drawing.Point(431, 15)
        Me.ck_inventory.Name = "ck_inventory"
        Me.ck_inventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_inventory.Properties.Appearance.Options.UseFont = True
        Me.ck_inventory.Properties.Caption = "View All"
        Me.ck_inventory.Size = New System.Drawing.Size(80, 19)
        Me.ck_inventory.TabIndex = 550
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(286, 107)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(141, 30)
        Me.cmdaction.TabIndex = 5
        Me.cmdaction.Text = "Show Report"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(867, 40)
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckTemplate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTemplate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtaccountableid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtaccountablePerson)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAccountable)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.catid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtInventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_inventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.MinSize = 120
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1235, 599)
        Me.SplitContainerControl1.SplitterPosition = 154
        Me.SplitContainerControl1.TabIndex = 590
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckTemplate
        '
        Me.ckTemplate.EditValue = True
        Me.ckTemplate.Location = New System.Drawing.Point(431, 82)
        Me.ckTemplate.Name = "ckTemplate"
        Me.ckTemplate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckTemplate.Properties.Appearance.Options.UseFont = True
        Me.ckTemplate.Properties.Caption = "View All"
        Me.ckTemplate.Size = New System.Drawing.Size(80, 19)
        Me.ckTemplate.TabIndex = 590
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(788, 66)
        Me.productid.Name = "productid"
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(73, 20)
        Me.productid.TabIndex = 589
        Me.productid.Visible = False
        '
        'txtProduct
        '
        Me.txtProduct.EditValue = ""
        Me.txtProduct.Enabled = False
        Me.txtProduct.Location = New System.Drawing.Point(130, 60)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Properties.Appearance.Options.UseFont = True
        Me.txtProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduct.Properties.DisplayMember = "Select"
        Me.txtProduct.Properties.NullText = ""
        Me.txtProduct.Properties.PopupView = Me.gridProduct
        Me.txtProduct.Properties.ValueMember = "code"
        Me.txtProduct.Size = New System.Drawing.Size(297, 20)
        Me.txtProduct.TabIndex = 586
        '
        'gridProduct
        '
        Me.gridProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(22, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl2.TabIndex = 587
        Me.LabelControl2.Text = "Product Name"
        '
        'ckProduct
        '
        Me.ckProduct.EditValue = True
        Me.ckProduct.Location = New System.Drawing.Point(431, 61)
        Me.ckProduct.Name = "ckProduct"
        Me.ckProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckProduct.Properties.Appearance.Options.UseFont = True
        Me.ckProduct.Properties.Caption = "View All"
        Me.ckProduct.Size = New System.Drawing.Size(80, 19)
        Me.ckProduct.TabIndex = 588
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(22, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl4.TabIndex = 585
        Me.LabelControl4.Text = "Template"
        '
        'txtTemplate
        '
        Me.txtTemplate.Enabled = False
        Me.txtTemplate.Location = New System.Drawing.Point(130, 83)
        Me.txtTemplate.MenuManager = Me.BarManager1
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTemplate.Properties.Appearance.Options.UseFont = True
        Me.txtTemplate.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTemplate.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTemplate.Properties.Items.AddRange(New Object() {"Inventory Custodian Slip (ICS)", "Property Acknowledgement Receipt (PAR)"})
        Me.txtTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTemplate.Size = New System.Drawing.Size(297, 20)
        Me.txtTemplate.TabIndex = 584
        '
        'txtaccountableid
        '
        Me.txtaccountableid.Location = New System.Drawing.Point(788, 40)
        Me.txtaccountableid.Name = "txtaccountableid"
        Me.txtaccountableid.Properties.ReadOnly = True
        Me.txtaccountableid.Size = New System.Drawing.Size(73, 20)
        Me.txtaccountableid.TabIndex = 583
        Me.txtaccountableid.Visible = False
        '
        'txtaccountablePerson
        '
        Me.txtaccountablePerson.EditValue = ""
        Me.txtaccountablePerson.Enabled = False
        Me.txtaccountablePerson.Location = New System.Drawing.Point(130, 37)
        Me.txtaccountablePerson.Name = "txtaccountablePerson"
        Me.txtaccountablePerson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccountablePerson.Properties.Appearance.Options.UseFont = True
        Me.txtaccountablePerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtaccountablePerson.Properties.DisplayMember = "Select"
        Me.txtaccountablePerson.Properties.NullText = ""
        Me.txtaccountablePerson.Properties.PopupView = Me.gridAccountable
        Me.txtaccountablePerson.Properties.ValueMember = "code"
        Me.txtaccountablePerson.Size = New System.Drawing.Size(297, 20)
        Me.txtaccountablePerson.TabIndex = 580
        '
        'gridAccountable
        '
        Me.gridAccountable.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAccountable.Name = "gridAccountable"
        Me.gridAccountable.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAccountable.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(22, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl1.TabIndex = 581
        Me.LabelControl1.Text = "Filter Accountable"
        '
        'ckAccountable
        '
        Me.ckAccountable.EditValue = True
        Me.ckAccountable.Location = New System.Drawing.Point(431, 38)
        Me.ckAccountable.Name = "ckAccountable"
        Me.ckAccountable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAccountable.Properties.Appearance.Options.UseFont = True
        Me.ckAccountable.Properties.Caption = "View All"
        Me.ckAccountable.Size = New System.Drawing.Size(80, 19)
        Me.ckAccountable.TabIndex = 582
        '
        'cmdPrintPropertyCard
        '
        Me.cmdPrintPropertyCard.Caption = "Print Property Card"
        Me.cmdPrintPropertyCard.Id = 10
        Me.cmdPrintPropertyCard.Name = "cmdPrintPropertyCard"
        Me.cmdPrintPropertyCard.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'frmDepedFFESummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 621)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmDepedFFESummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office Equipment Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_inventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtaccountableid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtaccountablePerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAccountable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAccountable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrintCustodian As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ck_inventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rc_transfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EditEquimentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtaccountablePerson As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAccountable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckAccountable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtaccountableid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintStickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPAR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtTemplate As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PulloutItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckProduct As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckTemplate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SetSequenceNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateProductBatchingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintPropertyCard As DevExpress.XtraBars.BarButtonItem
End Class
