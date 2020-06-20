<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMenuMaker
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
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridMenuProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSourceProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.productid_source = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.productid_item = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckEnableInventory = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.txtTotalCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ckStrictInventory = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.txtItemMenu = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItemMenu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.gridMenuProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourceProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckEnableInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStrictInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(112, 93)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl11.TabIndex = 540
        Me.LabelControl11.Text = "Add item to menu"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(64, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(140, 15)
        Me.LabelControl1.TabIndex = 543
        Me.LabelControl1.Text = "Select Main Menu Product"
        '
        'gridMenuProduct
        '
        Me.gridMenuProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMenuProduct.Name = "gridMenuProduct"
        Me.gridMenuProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMenuProduct.OptionsView.ShowGroupPanel = False
        '
        'txtSourceProduct
        '
        Me.txtSourceProduct.EditValue = ""
        Me.txtSourceProduct.EnterMoveNextControl = True
        Me.txtSourceProduct.Location = New System.Drawing.Point(211, 64)
        Me.txtSourceProduct.Name = "txtSourceProduct"
        Me.txtSourceProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSourceProduct.Properties.Appearance.Options.UseFont = True
        Me.txtSourceProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSourceProduct.Properties.DisplayMember = "Menu Product"
        Me.txtSourceProduct.Properties.NullText = ""
        Me.txtSourceProduct.Properties.ValueMember = "Menu Product"
        Me.txtSourceProduct.Properties.View = Me.gridMenuProduct
        Me.txtSourceProduct.Size = New System.Drawing.Size(253, 22)
        Me.txtSourceProduct.TabIndex = 0
        '
        'productid_source
        '
        Me.productid_source.EditValue = ""
        Me.productid_source.Location = New System.Drawing.Point(470, 64)
        Me.productid_source.Name = "productid_source"
        Me.productid_source.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.productid_source.Properties.Appearance.Options.UseFont = True
        Me.productid_source.Properties.Appearance.Options.UseTextOptions = True
        Me.productid_source.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid_source.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.productid_source.Properties.Mask.BeepOnError = True
        Me.productid_source.Properties.ReadOnly = True
        Me.productid_source.Size = New System.Drawing.Size(33, 22)
        Me.productid_source.TabIndex = 544
        Me.productid_source.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = "0.00"
        Me.txtQuantity.Location = New System.Drawing.Point(211, 113)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQuantity.Properties.Mask.EditMask = "n"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(109, 26)
        Me.txtQuantity.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(211, 203)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(183, 30)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Confirm add item to menu"
        '
        'productid_item
        '
        Me.productid_item.EnterMoveNextControl = True
        Me.productid_item.Location = New System.Drawing.Point(470, 90)
        Me.productid_item.Name = "productid_item"
        Me.productid_item.Size = New System.Drawing.Size(33, 20)
        Me.productid_item.TabIndex = 552
        Me.productid_item.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckEnableInventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTotalCost)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtUnitCost)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckStrictInventory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtQuantity)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid_item)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid_source)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl11)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSourceProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtItemMenu)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtunit)
        Me.SplitContainerControl1.Panel1.MinSize = 150
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(612, 570)
        Me.SplitContainerControl1.SplitterPosition = 247
        Me.SplitContainerControl1.TabIndex = 553
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckEnableInventory
        '
        Me.ckEnableInventory.Location = New System.Drawing.Point(211, 19)
        Me.ckEnableInventory.MenuManager = Me.BarManager1
        Me.ckEnableInventory.Name = "ckEnableInventory"
        Me.ckEnableInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckEnableInventory.Properties.Appearance.Options.UseFont = True
        Me.ckEnableInventory.Properties.Caption = "Enable Inventory Lookup"
        Me.ckEnableInventory.Size = New System.Drawing.Size(253, 19)
        Me.ckEnableInventory.TabIndex = 561
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 4
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(612, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 570)
        Me.barDockControlBottom.Size = New System.Drawing.Size(612, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 570)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(612, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 570)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.EditValue = "0"
        Me.txtTotalCost.EnterMoveNextControl = True
        Me.txtTotalCost.Location = New System.Drawing.Point(211, 172)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtTotalCost.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCost.Properties.Mask.EditMask = "n"
        Me.txtTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCost.Properties.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(183, 26)
        Me.txtTotalCost.TabIndex = 560
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(153, 178)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 559
        Me.LabelControl3.Text = "Total Cost"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0"
        Me.txtUnitCost.EnterMoveNextControl = True
        Me.txtUnitCost.Location = New System.Drawing.Point(211, 143)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(183, 26)
        Me.txtUnitCost.TabIndex = 558
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(125, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl2.TabIndex = 557
        Me.LabelControl2.Text = "Initial unit Cost"
        '
        'ckStrictInventory
        '
        Me.ckStrictInventory.Location = New System.Drawing.Point(211, 39)
        Me.ckStrictInventory.MenuManager = Me.BarManager1
        Me.ckStrictInventory.Name = "ckStrictInventory"
        Me.ckStrictInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckStrictInventory.Properties.Appearance.Options.UseFont = True
        Me.ckStrictInventory.Properties.Caption = "Strict menu maker inventory requirements"
        Me.ckStrictInventory.Size = New System.Drawing.Size(253, 19)
        Me.ckStrictInventory.TabIndex = 556
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(78, 118)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl4.TabIndex = 555
        Me.LabelControl4.Text = "Quantity to be deducted"
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(470, 116)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 553
        Me.id.Visible = False
        '
        'txtItemMenu
        '
        Me.txtItemMenu.EditValue = ""
        Me.txtItemMenu.EnterMoveNextControl = True
        Me.txtItemMenu.Location = New System.Drawing.Point(211, 90)
        Me.txtItemMenu.Name = "txtItemMenu"
        Me.txtItemMenu.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemMenu.Properties.Appearance.Options.UseFont = True
        Me.txtItemMenu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemMenu.Properties.DisplayMember = "Item Menu"
        Me.txtItemMenu.Properties.NullText = ""
        Me.txtItemMenu.Properties.ValueMember = "Item Menu"
        Me.txtItemMenu.Properties.View = Me.gridItemMenu
        Me.txtItemMenu.Size = New System.Drawing.Size(253, 20)
        Me.txtItemMenu.TabIndex = 1
        '
        'gridItemMenu
        '
        Me.gridItemMenu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItemMenu.Name = "gridItemMenu"
        Me.gridItemMenu.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItemMenu.OptionsView.ShowGroupPanel = False
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(325, 114)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(69, 26)
        Me.txtunit.TabIndex = 2
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(612, 318)
        Me.Em.TabIndex = 4
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRemove, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(166, 76)
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(165, 22)
        Me.cmdRemove.Text = "Remove Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'frmProductMenuMaker
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 570)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmProductMenuMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Menu Maker"
        CType(Me.gridMenuProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourceProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckEnableInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStrictInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridMenuProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSourceProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents productid_source As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents productid_item As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItemMenu As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItemMenu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckStrictInventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckEnableInventory As DevExpress.XtraEditors.CheckEdit
End Class
