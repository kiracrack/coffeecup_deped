<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollProcessing
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDeductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPayrollCode = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_scheduletype = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdLoadData = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLevel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.emplevel = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateFrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateTo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emplevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(1, 103)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(872, 321)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ViewDeductionToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.tick
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem1.Text = "Approve Attendance"
        '
        'ViewDeductionToolStripMenuItem
        '
        Me.ViewDeductionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.ViewDeductionToolStripMenuItem.Name = "ViewDeductionToolStripMenuItem"
        Me.ViewDeductionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ViewDeductionToolStripMenuItem.Text = "View Current Payslip"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.CopyToClipboardWithColumnHeaders = False
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsSelection.MultiSelect = True
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(21, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 20)
        Me.LabelControl3.TabIndex = 724
        Me.LabelControl3.Text = "Payroll Code"
        '
        'txtPayrollCode
        '
        Me.txtPayrollCode.Location = New System.Drawing.Point(113, 37)
        Me.txtPayrollCode.Name = "txtPayrollCode"
        Me.txtPayrollCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtPayrollCode.Properties.Appearance.Options.UseFont = True
        Me.txtPayrollCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPayrollCode.Properties.DisplayMember = "Payroll Code"
        Me.txtPayrollCode.Properties.NullText = ""
        Me.txtPayrollCode.Properties.ValueMember = "Payroll Code"
        Me.txtPayrollCode.Properties.View = Me.gv_scheduletype
        Me.txtPayrollCode.Size = New System.Drawing.Size(275, 26)
        Me.txtPayrollCode.TabIndex = 725
        '
        'gv_scheduletype
        '
        Me.gv_scheduletype.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_scheduletype.Name = "gv_scheduletype"
        Me.gv_scheduletype.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_scheduletype.OptionsView.ColumnAutoWidth = False
        Me.gv_scheduletype.OptionsView.ShowGroupPanel = False
        '
        'cmdLoadData
        '
        Me.cmdLoadData.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLoadData.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdLoadData.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdLoadData.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdLoadData.Appearance.Options.UseBackColor = True
        Me.cmdLoadData.Appearance.Options.UseFont = True
        Me.cmdLoadData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdLoadData.Location = New System.Drawing.Point(392, 37)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(99, 26)
        Me.cmdLoadData.TabIndex = 726
        Me.cmdLoadData.Text = "Load Payroll"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 12
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True)})
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
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export Summary to Excel"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Export Deduction List"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Export Additional List"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Print Payroll"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
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
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Payroll Summary"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export Summary to Excel"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(739, 77)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(58, 20)
        Me.payrollcode.TabIndex = 798
        Me.payrollcode.Visible = False
        '
        'schedulecode
        '
        Me.schedulecode.Location = New System.Drawing.Point(803, 77)
        Me.schedulecode.Name = "schedulecode"
        Me.schedulecode.Size = New System.Drawing.Size(58, 20)
        Me.schedulecode.TabIndex = 803
        Me.schedulecode.Visible = False
        '
        'cmdApprove
        '
        Me.cmdApprove.Appearance.BackColor = System.Drawing.Color.Lime
        Me.cmdApprove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdApprove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdApprove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdApprove.Appearance.Options.UseBackColor = True
        Me.cmdApprove.Appearance.Options.UseFont = True
        Me.cmdApprove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdApprove.Location = New System.Drawing.Point(495, 37)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.Size = New System.Drawing.Size(117, 26)
        Me.cmdApprove.TabIndex = 808
        Me.cmdApprove.Text = "Approve Payroll"
        Me.cmdApprove.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Location = New System.Drawing.Point(158, 175)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(282, 209)
        Me.GridControl1.TabIndex = 813
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl1.Visible = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.CopyToClipboardWithColumnHeaders = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(27, 69)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(78, 20)
        Me.LabelControl13.TabIndex = 819
        Me.LabelControl13.Text = "Select Level"
        '
        'txtLevel
        '
        Me.txtLevel.EditValue = ""
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(113, 66)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Properties.Appearance.Options.UseFont = True
        Me.txtLevel.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtLevel.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLevel.Properties.PopupSizeable = True
        Me.txtLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtLevel.Size = New System.Drawing.Size(185, 26)
        Me.txtLevel.TabIndex = 818
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(304, 67)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "View All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 24)
        Me.CheckEdit1.TabIndex = 820
        '
        'emplevel
        '
        Me.emplevel.Location = New System.Drawing.Point(675, 77)
        Me.emplevel.Name = "emplevel"
        Me.emplevel.Size = New System.Drawing.Size(58, 20)
        Me.emplevel.TabIndex = 821
        Me.emplevel.Visible = False
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(711, 113)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(58, 20)
        Me.txtDateFrom.TabIndex = 826
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(775, 113)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(58, 20)
        Me.txtDateTo.TabIndex = 827
        Me.txtDateTo.Visible = False
        '
        'frmPayrollProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 424)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.emplevel)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.schedulecode)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.cmdLoadData)
        Me.Controls.Add(Me.txtPayrollCode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayrollProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Processing"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emplevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPayrollCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_scheduletype As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdLoadData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblstatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents schedulecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ViewDeductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLevel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents emplevel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.TextEdit
End Class
