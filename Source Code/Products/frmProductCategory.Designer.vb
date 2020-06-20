<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCategory
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarLargeButtonItem2 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtdesc = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdShowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ckRequestFilter = New DevExpress.XtraEditors.CheckEdit()
        Me.ckPrepaid = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.s_type = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.ckpooption = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabInformation = New DevExpress.XtraTab.XtraTabPage()
        Me.tabImage = New DevExpress.XtraTab.XtraTabPage()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.potypeid = New DevExpress.XtraEditors.ButtonEdit()
        Me.mode = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSequenceOrder = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckRequestFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckPrepaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabInformation.SuspendLayout()
        Me.tabImage.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potypeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSequenceOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem2, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 8.25!)
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
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarLargeButtonItem2
        '
        Me.BarLargeButtonItem2.Caption = "&Close Window"
        Me.BarLargeButtonItem2.Id = 1
        Me.BarLargeButtonItem2.Name = "BarLargeButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print Report"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1001, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 470)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1001, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 450)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1001, 20)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 450)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(194, 15)
        Me.LabelControl1.TabIndex = 384
        Me.LabelControl1.Text = "Particular Item Category Information"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(16, 34)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(67, 22)
        Me.id.TabIndex = 381
        '
        'txtdesc
        '
        Me.txtdesc.EditValue = ""
        Me.txtdesc.Location = New System.Drawing.Point(86, 34)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Properties.Appearance.Options.UseFont = True
        Me.txtdesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Size = New System.Drawing.Size(308, 22)
        Me.txtdesc.TabIndex = 0
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Em.Size = New System.Drawing.Size(590, 416)
        Me.Em.TabIndex = 2
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdShowItem, Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(146, 98)
        '
        'cmdShowItem
        '
        Me.cmdShowItem.Image = Global.Coffeecup.My.Resources.Resources.book_open_next
        Me.cmdShowItem.Name = "cmdShowItem"
        Me.cmdShowItem.Size = New System.Drawing.Size(145, 22)
        Me.cmdShowItem.Text = "Show Items"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(145, 22)
        Me.cmdEdit.Text = "Edit Category"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(145, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1001, 20)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 450)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSequenceOrder)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckRequestFilter)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckPrepaid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtRequestType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdUpdate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckpooption)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtdesc)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDetails)
        Me.SplitContainerControl1.Panel1.MinSize = 170
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.potypeid)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.mode)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1001, 450)
        Me.SplitContainerControl1.SplitterPosition = 400
        Me.SplitContainerControl1.TabIndex = 386
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(16, 150)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(111, 15)
        Me.LabelControl3.TabIndex = 694
        Me.LabelControl3.Text = "Category Description"
        '
        'ckRequestFilter
        '
        Me.ckRequestFilter.Location = New System.Drawing.Point(16, 244)
        Me.ckRequestFilter.MenuManager = Me.BarManager1
        Me.ckRequestFilter.Name = "ckRequestFilter"
        Me.ckRequestFilter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckRequestFilter.Properties.Appearance.Options.UseFont = True
        Me.ckRequestFilter.Properties.Caption = "Enable Request Filter"
        Me.ckRequestFilter.Size = New System.Drawing.Size(173, 19)
        Me.ckRequestFilter.TabIndex = 692
        '
        'ckPrepaid
        '
        Me.ckPrepaid.Location = New System.Drawing.Point(16, 223)
        Me.ckPrepaid.MenuManager = Me.BarManager1
        Me.ckPrepaid.Name = "ckPrepaid"
        Me.ckPrepaid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPrepaid.Properties.Appearance.Options.UseFont = True
        Me.ckPrepaid.Properties.Caption = "Prepaid Expense Inventory"
        Me.ckPrepaid.Size = New System.Drawing.Size(173, 19)
        Me.ckPrepaid.TabIndex = 691
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 15)
        Me.LabelControl2.TabIndex = 690
        Me.LabelControl2.Text = "Category Type"
        '
        'txtRequestType
        '
        Me.txtRequestType.EditValue = ""
        Me.txtRequestType.Enabled = False
        Me.txtRequestType.Location = New System.Drawing.Point(16, 264)
        Me.txtRequestType.Name = "txtRequestType"
        Me.txtRequestType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestType.Properties.Appearance.Options.UseFont = True
        Me.txtRequestType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtRequestType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequestType.Properties.DisplayMember = "Request Type"
        Me.txtRequestType.Properties.ImmediatePopup = True
        Me.txtRequestType.Properties.NullText = ""
        Me.txtRequestType.Properties.PopupView = Me.s_type
        Me.txtRequestType.Properties.ValueMember = "Request Type"
        Me.txtRequestType.Size = New System.Drawing.Size(264, 22)
        Me.txtRequestType.TabIndex = 624
        '
        's_type
        '
        Me.s_type.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_type.Name = "s_type"
        Me.s_type.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_type.OptionsView.ShowGroupPanel = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(16, 318)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(165, 32)
        Me.cmdUpdate.TabIndex = 623
        Me.cmdUpdate.Text = "&Save Category"
        '
        'ckpooption
        '
        Me.ckpooption.Location = New System.Drawing.Point(16, 75)
        Me.ckpooption.Name = "ckpooption"
        Me.ckpooption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckpooption.Properties.Appearance.Options.UseFont = True
        Me.ckpooption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Non-Inventory Item (i.e Services, Billings and Payables)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Consumables Inventory"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Company Furniture’s, Fixtures and Equipment’s ")})
        Me.ckpooption.Size = New System.Drawing.Size(378, 69)
        Me.ckpooption.TabIndex = 383
        '
        'txtDetails
        '
        Me.txtDetails.EditValue = ""
        Me.txtDetails.Location = New System.Drawing.Point(16, 169)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Properties.Appearance.Options.UseFont = True
        Me.txtDetails.Size = New System.Drawing.Size(378, 50)
        Me.txtDetails.TabIndex = 693
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabInformation
        Me.XtraTabControl1.Size = New System.Drawing.Size(596, 450)
        Me.XtraTabControl1.TabIndex = 712
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInformation, Me.tabImage})
        '
        'tabInformation
        '
        Me.tabInformation.Controls.Add(Me.Em)
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Size = New System.Drawing.Size(590, 416)
        Me.tabInformation.Text = "Product Category List"
        '
        'tabImage
        '
        Me.tabImage.Controls.Add(Me.PictureEdit1)
        Me.tabImage.Name = "tabImage"
        Me.tabImage.Size = New System.Drawing.Size(590, 416)
        Me.tabImage.Text = "Product Featured Image"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(590, 416)
        Me.PictureEdit1.TabIndex = 0
        '
        'potypeid
        '
        Me.potypeid.EditValue = ""
        Me.potypeid.Location = New System.Drawing.Point(199, 218)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.potypeid.Properties.Appearance.Options.UseFont = True
        Me.potypeid.Properties.Appearance.Options.UseTextOptions = True
        Me.potypeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.potypeid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.potypeid.Properties.Mask.BeepOnError = True
        Me.potypeid.Size = New System.Drawing.Size(64, 22)
        Me.potypeid.TabIndex = 382
        Me.potypeid.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(129, 217)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.mode.Properties.Mask.BeepOnError = True
        Me.mode.Size = New System.Drawing.Size(64, 22)
        Me.mode.TabIndex = 382
        Me.mode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(89, 293)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl4.TabIndex = 695
        Me.LabelControl4.Text = "Sequence Order"
        '
        'txtSequenceOrder
        '
        Me.txtSequenceOrder.EditValue = ""
        Me.txtSequenceOrder.Location = New System.Drawing.Point(16, 290)
        Me.txtSequenceOrder.Name = "txtSequenceOrder"
        Me.txtSequenceOrder.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequenceOrder.Properties.Appearance.Options.UseFont = True
        Me.txtSequenceOrder.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSequenceOrder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSequenceOrder.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtSequenceOrder.Properties.Mask.BeepOnError = True
        Me.txtSequenceOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSequenceOrder.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSequenceOrder.Size = New System.Drawing.Size(67, 22)
        Me.txtSequenceOrder.TabIndex = 696
        '
        'frmProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 470)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(368, 374)
        Me.Name = "frmProductCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Category"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckRequestFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckPrepaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabImage.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potypeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSequenceOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem2 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents txtdesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents mode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ckpooption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRequestType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents s_type As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents potypeid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckPrepaid As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckRequestFilter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdShowItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabInformation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabImage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSequenceOrder As DevExpress.XtraEditors.ButtonEdit
End Class
