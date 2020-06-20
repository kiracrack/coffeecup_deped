<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProceedNewRequest
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.menuclose = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.cmdadd = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdfinish = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.potypeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisbursement = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtoffice = New DevExpress.XtraEditors.TextEdit()
        Me.txtRequestby = New DevExpress.XtraEditors.TextEdit()
        Me.txtpotype = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtdetails = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdatereq = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesignation = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potypeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisbursement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatereq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(340, 20)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(688, 474)
        Me.Em.TabIndex = 331
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditQuantityToolStripMenuItem, Me.SetSupplierToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(182, 98)
        '
        'EditQuantityToolStripMenuItem
        '
        Me.EditQuantityToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit_3
        Me.EditQuantityToolStripMenuItem.Name = "EditQuantityToolStripMenuItem"
        Me.EditQuantityToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EditQuantityToolStripMenuItem.Text = "Edit Quantity"
        '
        'SetSupplierToolStripMenuItem
        '
        Me.SetSupplierToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.truck__pencil
        Me.SetSupplierToolStripMenuItem.Name = "SetSupplierToolStripMenuItem"
        Me.SetSupplierToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SetSupplierToolStripMenuItem.Text = "Set Product Supplier"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.blog__minus
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.menuclose, Me.cmdadd, Me.cmdPrint, Me.cmdfinish})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(296, 153)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuclose), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdadd, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdfinish, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menu"
        '
        'menuclose
        '
        Me.menuclose.Caption = "&Close Window (F4)"
        Me.menuclose.Id = 1
        Me.menuclose.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.menuclose.ItemAppearance.Normal.Options.UseFont = True
        Me.menuclose.Name = "menuclose"
        '
        'cmdadd
        '
        Me.cmdadd.Caption = "&Search Particular for Request (F5)"
        Me.cmdadd.Id = 3
        Me.cmdadd.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdadd.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdadd.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdadd.ItemAppearance.Normal.Options.UseForeColor = True
        Me.cmdadd.Name = "cmdadd"
        '
        'cmdfinish
        '
        Me.cmdfinish.Caption = "&Finish && Sent Approval (F6)"
        Me.cmdfinish.Id = 6
        Me.cmdfinish.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdfinish.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green
        Me.cmdfinish.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdfinish.ItemAppearance.Normal.Options.UseForeColor = True
        Me.cmdfinish.Name = "cmdfinish"
        '
        'cmdPrint
        '
        Me.cmdPrint.Caption = "&Print Current Request. (F7)"
        Me.cmdPrint.Id = 5
        Me.cmdPrint.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPrint.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdPrint.Name = "cmdPrint"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 494)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 474)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 20)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.FloatVertical = True
        Me.DockPanel1.ID = New System.Guid("08fc2c1e-51d9-42e5-a235-54ed65c21ef3")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(340, 165)
        Me.DockPanel1.Size = New System.Drawing.Size(340, 474)
        Me.DockPanel1.Text = "Purchase Request Details"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.mode)
        Me.DockPanel1_Container.Controls.Add(Me.officeid)
        Me.DockPanel1_Container.Controls.Add(Me.potypeid)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl9)
        Me.DockPanel1_Container.Controls.Add(Me.txtDisbursement)
        Me.DockPanel1_Container.Controls.Add(Me.pid)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.txtoffice)
        Me.DockPanel1_Container.Controls.Add(Me.txtRequestby)
        Me.DockPanel1_Container.Controls.Add(Me.txtpotype)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl6)
        Me.DockPanel1_Container.Controls.Add(Me.lblOffice)
        Me.DockPanel1_Container.Controls.Add(Me.txtdetails)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl10)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.txtdatereq)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl8)
        Me.DockPanel1_Container.Controls.Add(Me.txtDesignation)
        Me.DockPanel1_Container.Controls.Add(Me.PanelControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(332, 447)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(174, 293)
        Me.mode.Name = "mode"
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(42, 20)
        Me.mode.TabIndex = 557
        Me.mode.Visible = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(222, 293)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(42, 20)
        Me.officeid.TabIndex = 556
        Me.officeid.Visible = False
        '
        'potypeid
        '
        Me.potypeid.Location = New System.Drawing.Point(270, 293)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.Properties.ReadOnly = True
        Me.potypeid.Size = New System.Drawing.Size(51, 20)
        Me.potypeid.TabIndex = 559
        Me.potypeid.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(13, 170)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl1.TabIndex = 521
        Me.LabelControl1.Text = "Approving Level"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(88, 23)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(134, 19)
        Me.LabelControl9.TabIndex = 559
        Me.LabelControl9.Text = "New Request Form"
        '
        'txtDisbursement
        '
        Me.txtDisbursement.Location = New System.Drawing.Point(105, 167)
        Me.txtDisbursement.Name = "txtDisbursement"
        Me.txtDisbursement.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDisbursement.Properties.Appearance.Options.UseFont = True
        Me.txtDisbursement.Properties.ReadOnly = True
        Me.txtDisbursement.Size = New System.Drawing.Size(216, 20)
        Me.txtDisbursement.TabIndex = 522
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(105, 51)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.pid.Properties.Appearance.Options.UseBackColor = True
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseForeColor = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(216, 20)
        Me.pid.TabIndex = 512
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(88, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(218, 13)
        Me.LabelControl4.TabIndex = 558
        Me.LabelControl4.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtoffice
        '
        Me.txtoffice.Location = New System.Drawing.Point(105, 75)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.ReadOnly = True
        Me.txtoffice.Size = New System.Drawing.Size(216, 20)
        Me.txtoffice.TabIndex = 558
        '
        'txtRequestby
        '
        Me.txtRequestby.Location = New System.Drawing.Point(105, 98)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRequestby.Properties.Appearance.Options.UseFont = True
        Me.txtRequestby.Properties.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(216, 20)
        Me.txtRequestby.TabIndex = 518
        '
        'txtpotype
        '
        Me.txtpotype.Location = New System.Drawing.Point(105, 190)
        Me.txtpotype.Name = "txtpotype"
        Me.txtpotype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtpotype.Properties.Appearance.Options.UseFont = True
        Me.txtpotype.Properties.ReadOnly = True
        Me.txtpotype.Size = New System.Drawing.Size(216, 20)
        Me.txtpotype.TabIndex = 553
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(38, 101)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 517
        Me.LabelControl6.Text = "Request By"
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(20, 78)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(75, 14)
        Me.lblOffice.TabIndex = 557
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(105, 213)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.Properties.Appearance.Options.UseFont = True
        Me.txtdetails.Properties.ReadOnly = True
        Me.txtdetails.Size = New System.Drawing.Size(216, 74)
        Me.txtdetails.TabIndex = 524
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(27, 193)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 552
        Me.LabelControl3.Text = "Request Type"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl7.Location = New System.Drawing.Point(26, 147)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl7.TabIndex = 519
        Me.LabelControl7.Text = "Date Request"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl10.Location = New System.Drawing.Point(32, 124)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl10.TabIndex = 526
        Me.LabelControl10.Text = "Designation"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(35, 54)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 510
        Me.LabelControl5.Text = "Request No"
        '
        'txtdatereq
        '
        Me.txtdatereq.Location = New System.Drawing.Point(105, 144)
        Me.txtdatereq.Name = "txtdatereq"
        Me.txtdatereq.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatereq.Properties.Appearance.Options.UseFont = True
        Me.txtdatereq.Properties.ReadOnly = True
        Me.txtdatereq.Size = New System.Drawing.Size(216, 20)
        Me.txtdatereq.TabIndex = 520
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl8.Location = New System.Drawing.Point(60, 216)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 523
        Me.LabelControl8.Text = "Details"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(105, 121)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDesignation.Properties.Appearance.Options.UseFont = True
        Me.txtDesignation.Properties.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(216, 20)
        Me.txtDesignation.TabIndex = 527
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.accessories_text_editor_2
        Me.PanelControl1.Location = New System.Drawing.Point(23, -5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 557
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
        'frmProceedNewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 494)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmProceedNewRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potypeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisbursement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatereq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdatereq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDesignation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents menuclose As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdadd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdfinish As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EditQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtpotype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtoffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisbursement As DevExpress.XtraEditors.TextEdit
    Friend WithEvents potypeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SetSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
