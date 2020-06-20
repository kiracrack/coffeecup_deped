<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollSummary
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
        Me.cmdPrintPayroll = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportSummary = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportDeduction = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportAdditional = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(1, 67)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(872, 357)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ViewDeductionToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(183, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.Time_Normal
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "View Attendance"
        '
        'ViewDeductionToolStripMenuItem
        '
        Me.ViewDeductionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.ViewDeductionToolStripMenuItem.Name = "ViewDeductionToolStripMenuItem"
        Me.ViewDeductionToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ViewDeductionToolStripMenuItem.Text = "View Current Payslip"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(182, 22)
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
        Me.LabelControl3.Location = New System.Drawing.Point(23, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 20)
        Me.LabelControl3.TabIndex = 724
        Me.LabelControl3.Text = "Payroll Code"
        '
        'txtPayrollCode
        '
        Me.txtPayrollCode.Location = New System.Drawing.Point(113, 32)
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
        Me.cmdLoadData.Location = New System.Drawing.Point(392, 32)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(99, 26)
        Me.cmdLoadData.TabIndex = 726
        Me.cmdLoadData.Text = "Load Summary"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus, Me.BarButtonItem1, Me.cmdPrintPayroll, Me.cmdExportDeduction, Me.cmdExportAdditional, Me.cmdExportSummary})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 11
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrintPayroll, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdExportSummary, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdExportDeduction, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdExportAdditional, True)})
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
        'cmdPrintPayroll
        '
        Me.cmdPrintPayroll.Caption = "Print Payroll Summary"
        Me.cmdPrintPayroll.Id = 7
        Me.cmdPrintPayroll.Name = "cmdPrintPayroll"
        '
        'cmdExportSummary
        '
        Me.cmdExportSummary.Caption = "Export Summary to Excel"
        Me.cmdExportSummary.Id = 10
        Me.cmdExportSummary.Name = "cmdExportSummary"
        '
        'cmdExportDeduction
        '
        Me.cmdExportDeduction.Caption = "Export Deduction List"
        Me.cmdExportDeduction.Id = 8
        Me.cmdExportDeduction.Name = "cmdExportDeduction"
        '
        'cmdExportAdditional
        '
        Me.cmdExportAdditional.Caption = "Export Additional List"
        Me.cmdExportAdditional.Id = 9
        Me.cmdExportAdditional.Name = "cmdExportAdditional"
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
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Location = New System.Drawing.Point(317, 152)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(282, 209)
        Me.GridControl1.TabIndex = 808
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
        'frmPayrollSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 424)
        Me.Controls.Add(Me.GridControl1)
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
        Me.Name = "frmPayrollSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Summary"
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
    Friend WithEvents cmdPrintPayroll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportDeduction As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportAdditional As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportSummary As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
