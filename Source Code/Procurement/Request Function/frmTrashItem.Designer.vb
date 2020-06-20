<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrashItem
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
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.purchaserid = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtoffice = New DevExpress.XtraEditors.TextEdit()
        Me.lbloffice = New DevExpress.XtraEditors.LabelControl()
        Me.forappid = New DevExpress.XtraEditors.TextEdit()
        Me.txtpotype = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdetails = New DevExpress.XtraEditors.MemoEdit()
        Me.txtRequestby = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesignation = New DevExpress.XtraEditors.TextEdit()
        Me.txtdatereq = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.purchaserid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forappid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatereq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.ItemAppearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdClose.ItemAppearance.Hovered.Options.UseFont = True
        Me.cmdClose.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdClose.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdClose.ItemAppearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdClose.ItemAppearance.Pressed.Options.UseFont = True
        Me.cmdClose.Name = "cmdClose"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(949, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 511)
        Me.barDockControlBottom.Size = New System.Drawing.Size(949, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 491)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(949, 20)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 491)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("b2ec862f-ee6d-4f17-97e1-7b797002210b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(292, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(292, 491)
        Me.DockPanel1.Text = "Purchasing Details"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.purchaserid)
        Me.DockPanel1_Container.Controls.Add(Me.officeid)
        Me.DockPanel1_Container.Controls.Add(Me.txtoffice)
        Me.DockPanel1_Container.Controls.Add(Me.lbloffice)
        Me.DockPanel1_Container.Controls.Add(Me.forappid)
        Me.DockPanel1_Container.Controls.Add(Me.txtpotype)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.txtdetails)
        Me.DockPanel1_Container.Controls.Add(Me.txtRequestby)
        Me.DockPanel1_Container.Controls.Add(Me.txtStatus)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl6)
        Me.DockPanel1_Container.Controls.Add(Me.txtDesignation)
        Me.DockPanel1_Container.Controls.Add(Me.txtdatereq)
        Me.DockPanel1_Container.Controls.Add(Me.pid)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl10)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl8)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(284, 464)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'purchaserid
        '
        Me.purchaserid.Location = New System.Drawing.Point(171, 377)
        Me.purchaserid.Name = "purchaserid"
        Me.purchaserid.Properties.Appearance.Options.UseTextOptions = True
        Me.purchaserid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.purchaserid.Properties.ReadOnly = True
        Me.purchaserid.Size = New System.Drawing.Size(56, 20)
        Me.purchaserid.TabIndex = 550
        Me.purchaserid.Visible = False
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(109, 377)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(56, 20)
        Me.officeid.TabIndex = 549
        Me.officeid.Visible = False
        '
        'txtoffice
        '
        Me.txtoffice.Location = New System.Drawing.Point(96, 34)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.ReadOnly = True
        Me.txtoffice.Size = New System.Drawing.Size(175, 20)
        Me.txtoffice.TabIndex = 560
        '
        'lbloffice
        '
        Me.lbloffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbloffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbloffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbloffice.Location = New System.Drawing.Point(12, 37)
        Me.lbloffice.Name = "lbloffice"
        Me.lbloffice.Size = New System.Drawing.Size(75, 14)
        Me.lbloffice.TabIndex = 559
        '
        'forappid
        '
        Me.forappid.Location = New System.Drawing.Point(47, 377)
        Me.forappid.Name = "forappid"
        Me.forappid.Properties.Appearance.Options.UseTextOptions = True
        Me.forappid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.forappid.Properties.ReadOnly = True
        Me.forappid.Size = New System.Drawing.Size(56, 20)
        Me.forappid.TabIndex = 548
        Me.forappid.Visible = False
        '
        'txtpotype
        '
        Me.txtpotype.Location = New System.Drawing.Point(96, 126)
        Me.txtpotype.Name = "txtpotype"
        Me.txtpotype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtpotype.Properties.Appearance.Options.UseFont = True
        Me.txtpotype.Properties.ReadOnly = True
        Me.txtpotype.Size = New System.Drawing.Size(175, 20)
        Me.txtpotype.TabIndex = 551
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(19, 129)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 550
        Me.LabelControl3.Text = "Request Type"
        '
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(96, 149)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.Properties.Appearance.Options.UseFont = True
        Me.txtdetails.Properties.ReadOnly = True
        Me.txtdetails.Size = New System.Drawing.Size(175, 55)
        Me.txtdetails.TabIndex = 548
        '
        'txtRequestby
        '
        Me.txtRequestby.Location = New System.Drawing.Point(96, 57)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRequestby.Properties.Appearance.Options.UseFont = True
        Me.txtRequestby.Properties.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(175, 20)
        Me.txtRequestby.TabIndex = 541
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(96, 207)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtStatus.Properties.Appearance.Options.UseFont = True
        Me.txtStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(175, 20)
        Me.txtStatus.TabIndex = 547
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl7.Location = New System.Drawing.Point(18, 106)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl7.TabIndex = 542
        Me.LabelControl7.Text = "Date Request"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(55, 210)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 546
        Me.LabelControl1.Text = "Status"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(30, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 540
        Me.LabelControl6.Text = "Request By"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(96, 80)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDesignation.Properties.Appearance.Options.UseFont = True
        Me.txtDesignation.Properties.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(175, 20)
        Me.txtDesignation.TabIndex = 551
        '
        'txtdatereq
        '
        Me.txtdatereq.Location = New System.Drawing.Point(96, 103)
        Me.txtdatereq.Name = "txtdatereq"
        Me.txtdatereq.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatereq.Properties.Appearance.Options.UseFont = True
        Me.txtdatereq.Properties.ReadOnly = True
        Me.txtdatereq.Size = New System.Drawing.Size(175, 20)
        Me.txtdatereq.TabIndex = 543
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(96, 11)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(175, 20)
        Me.pid.TabIndex = 539
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl10.Location = New System.Drawing.Point(24, 83)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl10.TabIndex = 550
        Me.LabelControl10.Text = "Designation"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl8.Location = New System.Drawing.Point(52, 152)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 544
        Me.LabelControl8.Text = "Details"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(27, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 538
        Me.LabelControl5.Text = "Request No"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(292, 20)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(657, 491)
        Me.Em.TabIndex = 333
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayFormatToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(166, 54)
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
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 54)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem1.Text = "Refresh Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "View Appearance"
        '
        'frmTrashItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 511)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmTrashItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Trash Items"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.purchaserid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forappid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpotype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatereq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents txtdetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesignation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdatereq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtpotype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents forappid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtoffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbloffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents purchaserid As DevExpress.XtraEditors.TextEdit
End Class
