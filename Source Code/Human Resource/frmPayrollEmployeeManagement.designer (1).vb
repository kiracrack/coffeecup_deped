<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollEmployeeManagement
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtpapertype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdoreintation = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txttitle = New DevExpress.XtraEditors.TextEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSetEmployeeType = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_EmployeeType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.typecode = New DevExpress.XtraEditors.TextEdit()
        Me.ckViewAllType = New DevExpress.XtraEditors.CheckEdit()
        Me.ckViewAllOffice = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.grid_office = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerLeft.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txtpapertype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
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
        Me.cmdClose.Name = "cmdClose"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(873, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 424)
        Me.barDockControlBottom.Size = New System.Drawing.Size(873, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 402)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(873, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 402)
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 22)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(19, 402)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("71bb1809-9469-46e3-a0f5-c78c7c306499")
        Me.DockPanel1.Location = New System.Drawing.Point(19, 22)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(238, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(238, 402)
        Me.DockPanel1.Text = "Report Settings"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.txtpapertype)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl4)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.txttitle)
        Me.DockPanel1_Container.Controls.Add(Me.cmdPrint)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(230, 375)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 134)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 626
        Me.LabelControl1.Text = "Paper Size"
        '
        'txtpapertype
        '
        Me.txtpapertype.EditValue = "Letter"
        Me.txtpapertype.Location = New System.Drawing.Point(71, 131)
        Me.txtpapertype.MenuManager = Me.BarManager1
        Me.txtpapertype.Name = "txtpapertype"
        Me.txtpapertype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtpapertype.Properties.Items.AddRange(New Object() {"Letter", "Legal"})
        Me.txtpapertype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtpapertype.Size = New System.Drawing.Size(150, 20)
        Me.txtpapertype.TabIndex = 612
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdoreintation)
        Me.GroupControl4.Location = New System.Drawing.Point(11, 50)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(212, 75)
        Me.GroupControl4.TabIndex = 614
        Me.GroupControl4.Text = "Orientation"
        '
        'rdoreintation
        '
        Me.rdoreintation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoreintation.EditValue = False
        Me.rdoreintation.Location = New System.Drawing.Point(2, 20)
        Me.rdoreintation.Name = "rdoreintation"
        Me.rdoreintation.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Portrait"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Landscape")})
        Me.rdoreintation.Size = New System.Drawing.Size(208, 53)
        Me.rdoreintation.TabIndex = 391
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 610
        Me.LabelControl2.Text = "Report Title"
        '
        'txttitle
        '
        Me.txttitle.EnterMoveNextControl = True
        Me.txttitle.Location = New System.Drawing.Point(9, 25)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(212, 20)
        Me.txttitle.TabIndex = 609
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(71, 157)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(150, 29)
        Me.cmdPrint.TabIndex = 611
        Me.cmdPrint.Text = "Print Report"
        '
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(19, 89)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(854, 335)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UpdateRecordToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem1.Text = "Edit Employee"
        '
        'UpdateRecordToolStripMenuItem
        '
        Me.UpdateRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetCompany, Me.cmdSetEmployeeType, Me.cmdSetPosition})
        Me.UpdateRecordToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.User__3_
        Me.UpdateRecordToolStripMenuItem.Name = "UpdateRecordToolStripMenuItem"
        Me.UpdateRecordToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.UpdateRecordToolStripMenuItem.Text = "Update Employee Status"
        '
        'cmdSetCompany
        '
        Me.cmdSetCompany.Image = Global.Coffeecup.My.Resources.Resources.building__arrow
        Me.cmdSetCompany.Name = "cmdSetCompany"
        Me.cmdSetCompany.Size = New System.Drawing.Size(158, 22)
        Me.cmdSetCompany.Text = "Change Office"
        '
        'cmdSetPosition
        '
        Me.cmdSetPosition.Image = Global.Coffeecup.My.Resources.Resources.card_address1
        Me.cmdSetPosition.Name = "cmdSetPosition"
        Me.cmdSetPosition.Size = New System.Drawing.Size(158, 22)
        Me.cmdSetPosition.Text = "Update Position"
        '
        'cmdSetEmployeeType
        '
        Me.cmdSetEmployeeType.Image = Global.Coffeecup.My.Resources.Resources.user_business_gray
        Me.cmdSetEmployeeType.Name = "cmdSetEmployeeType"
        Me.cmdSetEmployeeType.Size = New System.Drawing.Size(158, 22)
        Me.cmdSetEmployeeType.Text = "Employee Type"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(199, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsSelection.MultiSelect = True
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl13.Location = New System.Drawing.Point(31, 61)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(81, 15)
        Me.LabelControl13.TabIndex = 709
        Me.LabelControl13.Text = "Employee Type"
        '
        'txtEmployeeType
        '
        Me.txtEmployeeType.Location = New System.Drawing.Point(118, 58)
        Me.txtEmployeeType.MenuManager = Me.BarManager1
        Me.txtEmployeeType.Name = "txtEmployeeType"
        Me.txtEmployeeType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtEmployeeType.Properties.Appearance.Options.UseFont = True
        Me.txtEmployeeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEmployeeType.Properties.DisplayMember = "Select"
        Me.txtEmployeeType.Properties.NullText = ""
        Me.txtEmployeeType.Properties.ValueMember = "Select"
        Me.txtEmployeeType.Properties.View = Me.gv_EmployeeType
        Me.txtEmployeeType.Size = New System.Drawing.Size(258, 22)
        Me.txtEmployeeType.TabIndex = 710
        '
        'gv_EmployeeType
        '
        Me.gv_EmployeeType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_EmployeeType.Name = "gv_EmployeeType"
        Me.gv_EmployeeType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_EmployeeType.OptionsView.ShowGroupPanel = False
        '
        'typecode
        '
        Me.typecode.EnterMoveNextControl = True
        Me.typecode.Location = New System.Drawing.Point(487, 65)
        Me.typecode.Name = "typecode"
        Me.typecode.Size = New System.Drawing.Size(57, 20)
        Me.typecode.TabIndex = 717
        Me.typecode.Visible = False
        '
        'ckViewAllType
        '
        Me.ckViewAllType.Location = New System.Drawing.Point(382, 60)
        Me.ckViewAllType.MenuManager = Me.BarManager1
        Me.ckViewAllType.Name = "ckViewAllType"
        Me.ckViewAllType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAllType.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllType.Properties.Caption = "View All"
        Me.ckViewAllType.Size = New System.Drawing.Size(83, 19)
        Me.ckViewAllType.TabIndex = 718
        '
        'ckViewAllOffice
        '
        Me.ckViewAllOffice.Location = New System.Drawing.Point(382, 35)
        Me.ckViewAllOffice.MenuManager = Me.BarManager1
        Me.ckViewAllOffice.Name = "ckViewAllOffice"
        Me.ckViewAllOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewAllOffice.Properties.Appearance.Options.UseFont = True
        Me.ckViewAllOffice.Properties.Caption = "View All"
        Me.ckViewAllOffice.Size = New System.Drawing.Size(83, 19)
        Me.ckViewAllOffice.TabIndex = 726
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(46, 36)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 15)
        Me.LabelControl3.TabIndex = 724
        Me.LabelControl3.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(118, 33)
        Me.txtOffice.MenuManager = Me.BarManager1
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.ValueMember = "Select"
        Me.txtOffice.Properties.View = Me.grid_office
        Me.txtOffice.Size = New System.Drawing.Size(258, 22)
        Me.txtOffice.TabIndex = 725
        '
        'grid_office
        '
        Me.grid_office.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_office.Name = "grid_office"
        Me.grid_office.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_office.OptionsView.ShowGroupPanel = False
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(487, 39)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(57, 20)
        Me.officeid.TabIndex = 732
        Me.officeid.Visible = False
        '
        'frmPayrollEmployeeManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 424)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.ckViewAllOffice)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ckViewAllType)
        Me.Controls.Add(Me.typecode)
        Me.Controls.Add(Me.txtEmployeeType)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayrollEmployeeManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerLeft.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.txtpapertype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewAllOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lblstatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdoreintation As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpapertype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_EmployeeType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents typecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckViewAllType As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckViewAllOffice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents grid_office As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UpdateRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetEmployeeType As System.Windows.Forms.ToolStripMenuItem
End Class
