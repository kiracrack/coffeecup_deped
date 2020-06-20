<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductManagement
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddSupplierForItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetProductCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSubProductCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFFEAssetTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPriceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBarAddNew = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBarAddSupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdFFEassetType = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtprocat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.combogrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckFFE = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtfilter = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckFFE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(940, 435)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddSupplierForItem, Me.cmdEdit, Me.SetProductCategoryToolStripMenuItem, Me.SetSubProductCategoryToolStripMenuItem, Me.SetFFEAssetTypeToolStripMenuItem, Me.cmdRemove, Me.ViewPriceListToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(216, 186)
        '
        'cmdAddSupplierForItem
        '
        Me.cmdAddSupplierForItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddSupplierForItem.Image = Global.Coffeecup.My.Resources.Resources.building__arrow
        Me.cmdAddSupplierForItem.Name = "cmdAddSupplierForItem"
        Me.cmdAddSupplierForItem.Size = New System.Drawing.Size(215, 22)
        Me.cmdAddSupplierForItem.Text = "Add supplier for this item"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.server__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(215, 22)
        Me.cmdEdit.Text = "Edit Product Item"
        '
        'SetProductCategoryToolStripMenuItem
        '
        Me.SetProductCategoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.category1
        Me.SetProductCategoryToolStripMenuItem.Name = "SetProductCategoryToolStripMenuItem"
        Me.SetProductCategoryToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SetProductCategoryToolStripMenuItem.Text = "Set Category"
        '
        'SetSubProductCategoryToolStripMenuItem
        '
        Me.SetSubProductCategoryToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit_copy_3
        Me.SetSubProductCategoryToolStripMenuItem.Name = "SetSubProductCategoryToolStripMenuItem"
        Me.SetSubProductCategoryToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SetSubProductCategoryToolStripMenuItem.Text = "Set Product Article"
        '
        'SetFFEAssetTypeToolStripMenuItem
        '
        Me.SetFFEAssetTypeToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.book_bookmark1
        Me.SetFFEAssetTypeToolStripMenuItem.Name = "SetFFEAssetTypeToolStripMenuItem"
        Me.SetFFEAssetTypeToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SetFFEAssetTypeToolStripMenuItem.Text = "Set Product Asset Type"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.Coffeecup.My.Resources.Resources.server__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(215, 22)
        Me.cmdRemove.Text = "Remove Product Item"
        '
        'ViewPriceListToolStripMenuItem
        '
        Me.ViewPriceListToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.documentation1
        Me.ViewPriceListToolStripMenuItem.Name = "ViewPriceListToolStripMenuItem"
        Me.ViewPriceListToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ViewPriceListToolStripMenuItem.Text = "View Product Price List"
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
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.BarButtonItem1, Me.cmdBarAddSupplier, Me.cmdBarAddNew, Me.BarButtonItem2, Me.cmdFFEassetType, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.BarAppearance.Disabled.Options.UseFont = True
        Me.Bar1.BarAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Bar1.BarAppearance.Hovered.Options.UseFont = True
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Bar1.BarAppearance.Pressed.Options.UseFont = True
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBarAddNew, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBarAddSupplier, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdFFEassetType, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Print Report"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdBarAddNew
        '
        Me.cmdBarAddNew.Caption = "&Add new particular item here"
        Me.cmdBarAddNew.Id = 6
        Me.cmdBarAddNew.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBarAddNew.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBarAddNew.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdBarAddNew.ItemAppearance.Normal.Options.UseForeColor = True
        Me.cmdBarAddNew.Name = "cmdBarAddNew"
        '
        'cmdBarAddSupplier
        '
        Me.cmdBarAddSupplier.Caption = "Product Article"
        Me.cmdBarAddSupplier.Id = 5
        Me.cmdBarAddSupplier.Name = "cmdBarAddSupplier"
        '
        'cmdFFEassetType
        '
        Me.cmdFFEassetType.Caption = "FEE Asset Type Management"
        Me.cmdFFEassetType.Id = 9
        Me.cmdFFEassetType.Name = "cmdFFEassetType"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Column Settings"
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(946, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 530)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(946, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 510)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(946, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 510)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtprocat)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckFFE)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtfilter)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.catid)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(940, 482)
        Me.SplitContainerControl1.SplitterPosition = 42
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtprocat
        '
        Me.txtprocat.EditValue = ""
        Me.txtprocat.Location = New System.Drawing.Point(444, 11)
        Me.txtprocat.Name = "txtprocat"
        Me.txtprocat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprocat.Properties.Appearance.Options.UseFont = True
        Me.txtprocat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprocat.Properties.DisplayMember = "Select Category"
        Me.txtprocat.Properties.NullText = ""
        Me.txtprocat.Properties.PopupView = Me.combogrid
        Me.txtprocat.Properties.ValueMember = "catid"
        Me.txtprocat.Size = New System.Drawing.Size(236, 24)
        Me.txtprocat.TabIndex = 5
        '
        'combogrid
        '
        Me.combogrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.combogrid.Name = "combogrid"
        Me.combogrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.combogrid.OptionsView.ShowGroupPanel = False
        '
        'ckFFE
        '
        Me.ckFFE.Location = New System.Drawing.Point(779, 13)
        Me.ckFFE.MenuManager = Me.BarManager1
        Me.ckFFE.Name = "ckFFE"
        Me.ckFFE.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFFE.Properties.Appearance.Options.UseFont = True
        Me.ckFFE.Properties.Caption = "FFE"
        Me.ckFFE.Size = New System.Drawing.Size(50, 19)
        Me.ckFFE.TabIndex = 4
        Me.ckFFE.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(686, 14)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "All Category"
        Me.CheckEdit1.Size = New System.Drawing.Size(87, 19)
        Me.CheckEdit1.TabIndex = 2
        '
        'txtfilter
        '
        Me.txtfilter.Location = New System.Drawing.Point(4, 11)
        Me.txtfilter.MenuManager = Me.BarManager1
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilter.Properties.Appearance.Options.UseFont = True
        Me.txtfilter.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfilter.Size = New System.Drawing.Size(435, 24)
        Me.txtfilter.TabIndex = 1
        '
        'catid
        '
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(686, 56)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(33, 20)
        Me.catid.TabIndex = 709
        Me.catid.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 20)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(946, 510)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.SplitContainerControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(940, 482)
        Me.XtraTabPage1.Text = "Search Particular filter by (Item Code, Item Name, Category)"
        '
        'frmProductManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 530)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmProductManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Management"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtprocat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combogrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckFFE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAddSupplierForItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtfilter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdBarAddSupplier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdBarAddNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckFFE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewPriceListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetFFEAssetTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdFFEassetType As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SetProductCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetSubProductCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtprocat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents combogrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
End Class
