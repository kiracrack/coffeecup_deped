<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelManagement
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
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txttodate = New DevExpress.XtraEditors.DateEdit()
        Me.txtfrmdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtHotel = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridHotel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckasof = New DevExpress.XtraEditors.CheckEdit()
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsearch = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabInhouseWalkinList = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabVipGuestList = New DevExpress.XtraTab.XtraTabPage()
        Me.tabReservationList = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCheckedOutList = New DevExpress.XtraTab.XtraTabPage()
        Me.cms.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabInhouseWalkinList.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.ToolStripSeparator1, Me.menu_Refresh})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(219, 54)
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources._164
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Statement of Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
        '
        'menu_Refresh
        '
        Me.menu_Refresh.ForeColor = System.Drawing.Color.Black
        Me.menu_Refresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.menu_Refresh.Name = "menu_Refresh"
        Me.menu_Refresh.Size = New System.Drawing.Size(218, 22)
        Me.menu_Refresh.Text = "Refresh Data"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarCheckItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "&Close Window"
        Me.BarCheckItem1.Id = 0
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Report"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Column Settings"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1077, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 551)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1077, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 529)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1077, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 529)
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
        Me.cmdaction.Location = New System.Drawing.Point(243, 60)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(141, 30)
        Me.cmdaction.TabIndex = 578
        Me.cmdaction.Text = "Filter Search"
        '
        'txttodate
        '
        Me.txttodate.EditValue = New Date(CType(0, Long))
        Me.txttodate.Enabled = False
        Me.txttodate.EnterMoveNextControl = True
        Me.txttodate.Location = New System.Drawing.Point(243, 35)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodate.Properties.Appearance.Options.UseFont = True
        Me.txttodate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttodate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txttodate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txttodate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttodate.Size = New System.Drawing.Size(141, 20)
        Me.txttodate.TabIndex = 577
        '
        'txtfrmdate
        '
        Me.txtfrmdate.EditValue = New Date(CType(0, Long))
        Me.txtfrmdate.Enabled = False
        Me.txtfrmdate.EnterMoveNextControl = True
        Me.txtfrmdate.Location = New System.Drawing.Point(87, 35)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrmdate.Properties.Appearance.Options.UseFont = True
        Me.txtfrmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfrmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtfrmdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtfrmdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtfrmdate.Size = New System.Drawing.Size(141, 20)
        Me.txtfrmdate.TabIndex = 576
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(55, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl4.TabIndex = 583
        Me.LabelControl4.Text = "From"
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(9, 14)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(72, 13)
        Me.lblOffice.TabIndex = 581
        Me.lblOffice.Text = "Select Hotel"
        '
        'txtHotel
        '
        Me.txtHotel.EditValue = ""
        Me.txtHotel.Location = New System.Drawing.Point(87, 11)
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHotel.Properties.Appearance.Options.UseFont = True
        Me.txtHotel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHotel.Properties.DisplayMember = "Hotel"
        Me.txtHotel.Properties.NullText = ""
        Me.txtHotel.Properties.ValueMember = "Hotel"
        Me.txtHotel.Properties.View = Me.gridHotel
        Me.txtHotel.Size = New System.Drawing.Size(297, 20)
        Me.txtHotel.TabIndex = 574
        '
        'gridHotel
        '
        Me.gridHotel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridHotel.Name = "gridHotel"
        Me.gridHotel.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridHotel.OptionsView.ShowGroupPanel = False
        '
        'ckasof
        '
        Me.ckasof.Enabled = False
        Me.ckasof.Location = New System.Drawing.Point(85, 58)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckasof.Properties.Appearance.Options.UseFont = True
        Me.ckasof.Properties.Caption = "use report as of"
        Me.ckasof.Size = New System.Drawing.Size(135, 19)
        Me.ckasof.TabIndex = 589
        '
        'hotelcif
        '
        Me.hotelcif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hotelcif.Location = New System.Drawing.Point(507, 10)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Size = New System.Drawing.Size(83, 21)
        Me.hotelcif.TabIndex = 508
        Me.hotelcif.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtsearch)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckasof)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.hotelcif)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txttodate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtHotel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtfrmdate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.MinSize = 100
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1077, 529)
        Me.SplitContainerControl1.TabIndex = 595
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(790, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 700
        Me.LabelControl1.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Location = New System.Drawing.Point(829, 68)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Properties.Appearance.Options.UseFont = True
        Me.txtsearch.Size = New System.Drawing.Size(236, 22)
        Me.txtsearch.TabIndex = 699
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabInhouseWalkinList
        Me.XtraTabControl1.Size = New System.Drawing.Size(1077, 424)
        Me.XtraTabControl1.TabIndex = 323
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInhouseWalkinList, Me.tabVipGuestList, Me.tabReservationList, Me.tabCheckedOutList})
        '
        'tabInhouseWalkinList
        '
        Me.tabInhouseWalkinList.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabInhouseWalkinList.Appearance.Header.Options.UseFont = True
        Me.tabInhouseWalkinList.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabInhouseWalkinList.Appearance.HeaderActive.Options.UseFont = True
        Me.tabInhouseWalkinList.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabInhouseWalkinList.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabInhouseWalkinList.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabInhouseWalkinList.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabInhouseWalkinList.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabInhouseWalkinList.Appearance.PageClient.Options.UseFont = True
        Me.tabInhouseWalkinList.Controls.Add(Me.Em)
        Me.tabInhouseWalkinList.Name = "tabInhouseWalkinList"
        Me.tabInhouseWalkinList.Size = New System.Drawing.Size(1071, 394)
        Me.tabInhouseWalkinList.Text = "In-house Walk-in Guest"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1071, 394)
        Me.Em.TabIndex = 322
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'tabVipGuestList
        '
        Me.tabVipGuestList.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabVipGuestList.Appearance.Header.Options.UseFont = True
        Me.tabVipGuestList.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabVipGuestList.Appearance.HeaderActive.Options.UseFont = True
        Me.tabVipGuestList.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabVipGuestList.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabVipGuestList.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabVipGuestList.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabVipGuestList.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabVipGuestList.Appearance.PageClient.Options.UseFont = True
        Me.tabVipGuestList.Name = "tabVipGuestList"
        Me.tabVipGuestList.Size = New System.Drawing.Size(1071, 394)
        Me.tabVipGuestList.Text = "VIP Guest Check-in List"
        '
        'tabReservationList
        '
        Me.tabReservationList.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReservationList.Appearance.Header.Options.UseFont = True
        Me.tabReservationList.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReservationList.Appearance.HeaderActive.Options.UseFont = True
        Me.tabReservationList.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReservationList.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabReservationList.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReservationList.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabReservationList.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReservationList.Appearance.PageClient.Options.UseFont = True
        Me.tabReservationList.Name = "tabReservationList"
        Me.tabReservationList.Size = New System.Drawing.Size(1071, 394)
        Me.tabReservationList.Text = "Reservation List"
        '
        'tabCheckedOutList
        '
        Me.tabCheckedOutList.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCheckedOutList.Appearance.Header.Options.UseFont = True
        Me.tabCheckedOutList.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCheckedOutList.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCheckedOutList.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCheckedOutList.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCheckedOutList.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCheckedOutList.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCheckedOutList.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCheckedOutList.Appearance.PageClient.Options.UseFont = True
        Me.tabCheckedOutList.Name = "tabCheckedOutList"
        Me.tabCheckedOutList.Size = New System.Drawing.Size(1071, 394)
        Me.tabCheckedOutList.Text = "Check-out Guest"
        '
        'frmHotelManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 551)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmHotelManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cms.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabInhouseWalkinList.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menu_Refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttodate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtfrmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHotel As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridHotel As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckasof As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabVipGuestList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabInhouseWalkinList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabReservationList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCheckedOutList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsearch As DevExpress.XtraEditors.TextEdit
End Class
