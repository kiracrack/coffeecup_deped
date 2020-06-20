<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollAutoAddAllowances
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdActiveInactive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAttendanceSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdditional = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_Deduction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dedaddcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.lblsubject = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployeeType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_EmployeeType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.employeetypecode = New DevExpress.XtraEditors.TextEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.txtScheduleType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_scheduletype = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdditional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Deduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeetypecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScheduleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem4})
        Me.BarManager1.MaxItemId = 6
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(662, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 280)
        Me.barDockControlBottom.Size = New System.Drawing.Size(662, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 280)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(662, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 280)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Help"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.cmdActiveInactive, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem1.Text = "Edit Selected"
        '
        'cmdActiveInactive
        '
        Me.cmdActiveInactive.Image = Global.Coffeecup.My.Resources.Resources.layers_arrange
        Me.cmdActiveInactive.Name = "cmdActiveInactive"
        Me.cmdActiveInactive.Size = New System.Drawing.Size(153, 22)
        Me.cmdActiveInactive.Text = "Active/Inactive"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(150, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'cmdAttendanceSettings
        '
        Me.cmdAttendanceSettings.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttendanceSettings.Appearance.Options.UseFont = True
        Me.cmdAttendanceSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAttendanceSettings.Location = New System.Drawing.Point(113, 214)
        Me.cmdAttendanceSettings.Name = "cmdAttendanceSettings"
        Me.cmdAttendanceSettings.Size = New System.Drawing.Size(120, 27)
        Me.cmdAttendanceSettings.TabIndex = 4
        Me.cmdAttendanceSettings.Text = "Save"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(224, 24)
        Me.LabelControl9.TabIndex = 625
        Me.LabelControl9.Text = "Auto Add Allowances"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Right
        Me.Em.Location = New System.Drawing.Point(240, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(422, 280)
        Me.Em.TabIndex = 645
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsCustomization.AllowGroup = False
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(268, 59)
        Me.code.MenuManager = Me.BarManager1
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(58, 20)
        Me.code.TabIndex = 650
        Me.code.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(268, 82)
        Me.mode.MenuManager = Me.BarManager1
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(58, 20)
        Me.mode.TabIndex = 651
        Me.mode.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl12.Location = New System.Drawing.Point(10, 108)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl12.TabIndex = 733
        Me.LabelControl12.Text = "Select Default Additional"
        '
        'txtAdditional
        '
        Me.txtAdditional.EnterMoveNextControl = True
        Me.txtAdditional.Location = New System.Drawing.Point(10, 122)
        Me.txtAdditional.MenuManager = Me.BarManager1
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditional.Properties.Appearance.Options.UseFont = True
        Me.txtAdditional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAdditional.Properties.DisplayMember = "Select"
        Me.txtAdditional.Properties.NullText = ""
        Me.txtAdditional.Properties.ValueMember = "Select"
        Me.txtAdditional.Properties.View = Me.gv_Deduction
        Me.txtAdditional.Size = New System.Drawing.Size(223, 20)
        Me.txtAdditional.TabIndex = 1
        '
        'gv_Deduction
        '
        Me.gv_Deduction.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_Deduction.Name = "gv_Deduction"
        Me.gv_Deduction.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_Deduction.OptionsView.ShowGroupPanel = False
        '
        'dedaddcode
        '
        Me.dedaddcode.EditValue = ""
        Me.dedaddcode.Location = New System.Drawing.Point(268, 105)
        Me.dedaddcode.Name = "dedaddcode"
        Me.dedaddcode.Properties.Appearance.Options.UseTextOptions = True
        Me.dedaddcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dedaddcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dedaddcode.Properties.ReadOnly = True
        Me.dedaddcode.Size = New System.Drawing.Size(58, 20)
        Me.dedaddcode.TabIndex = 734
        Me.dedaddcode.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.EnterMoveNextControl = True
        Me.txtAmount.Location = New System.Drawing.Point(113, 189)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.MaxLength = 50
        Me.txtAmount.Size = New System.Drawing.Size(120, 20)
        Me.txtAmount.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(66, 192)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 743
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl61.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl61.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl61.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl61.Location = New System.Drawing.Point(10, 148)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl61.TabIndex = 748
        Me.LabelControl61.Text = "Additional Schedule"
        '
        'lblsubject
        '
        Me.lblsubject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubject.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblsubject.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblsubject.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblsubject.Location = New System.Drawing.Point(10, 68)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(136, 13)
        Me.lblsubject.TabIndex = 751
        Me.lblsubject.Text = "Subject to (Employee Type)"
        '
        'txtEmployeeType
        '
        Me.txtEmployeeType.Location = New System.Drawing.Point(10, 83)
        Me.txtEmployeeType.MenuManager = Me.BarManager1
        Me.txtEmployeeType.Name = "txtEmployeeType"
        Me.txtEmployeeType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeType.Properties.Appearance.Options.UseFont = True
        Me.txtEmployeeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEmployeeType.Properties.DisplayMember = "Select"
        Me.txtEmployeeType.Properties.NullText = ""
        Me.txtEmployeeType.Properties.ValueMember = "Select"
        Me.txtEmployeeType.Properties.View = Me.gv_EmployeeType
        Me.txtEmployeeType.Size = New System.Drawing.Size(223, 20)
        Me.txtEmployeeType.TabIndex = 0
        '
        'gv_EmployeeType
        '
        Me.gv_EmployeeType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_EmployeeType.Name = "gv_EmployeeType"
        Me.gv_EmployeeType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_EmployeeType.OptionsView.ShowGroupPanel = False
        '
        'employeetypecode
        '
        Me.employeetypecode.EditValue = ""
        Me.employeetypecode.Location = New System.Drawing.Point(268, 128)
        Me.employeetypecode.Name = "employeetypecode"
        Me.employeetypecode.Properties.Appearance.Options.UseTextOptions = True
        Me.employeetypecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.employeetypecode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.employeetypecode.Properties.ReadOnly = True
        Me.employeetypecode.Size = New System.Drawing.Size(58, 20)
        Me.employeetypecode.TabIndex = 757
        Me.employeetypecode.Visible = False
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 0.0!
        Me.RadioGroup1.Location = New System.Drawing.Point(10, 39)
        Me.RadioGroup1.MenuManager = Me.BarManager1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Employee Type", "Employee Type"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Employee Position", "Employee Position")})
        Me.RadioGroup1.Size = New System.Drawing.Size(218, 23)
        Me.RadioGroup1.TabIndex = 758
        '
        'schedulecode
        '
        Me.schedulecode.Location = New System.Drawing.Point(268, 154)
        Me.schedulecode.Name = "schedulecode"
        Me.schedulecode.Size = New System.Drawing.Size(58, 20)
        Me.schedulecode.TabIndex = 799
        Me.schedulecode.Visible = False
        '
        'txtScheduleType
        '
        Me.txtScheduleType.Location = New System.Drawing.Point(10, 163)
        Me.txtScheduleType.Name = "txtScheduleType"
        Me.txtScheduleType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScheduleType.Properties.Appearance.Options.UseFont = True
        Me.txtScheduleType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtScheduleType.Properties.DisplayMember = "Select"
        Me.txtScheduleType.Properties.NullText = ""
        Me.txtScheduleType.Properties.ValueMember = "Select"
        Me.txtScheduleType.Properties.View = Me.gv_scheduletype
        Me.txtScheduleType.Size = New System.Drawing.Size(224, 20)
        Me.txtScheduleType.TabIndex = 797
        '
        'gv_scheduletype
        '
        Me.gv_scheduletype.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_scheduletype.Name = "gv_scheduletype"
        Me.gv_scheduletype.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_scheduletype.OptionsView.ShowGroupPanel = False
        '
        'frmPayrollAutoAddAllowances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 280)
        Me.Controls.Add(Me.schedulecode)
        Me.Controls.Add(Me.txtScheduleType)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.employeetypecode)
        Me.Controls.Add(Me.txtEmployeeType)
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.LabelControl61)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.dedaddcode)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdAttendanceSettings)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPayrollAutoAddAllowances"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto add Allowances"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdditional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Deduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_EmployeeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeetypecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScheduleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAttendanceSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdditional As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_Deduction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dedaddcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsubject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployeeType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_EmployeeType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents employeetypecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdActiveInactive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents schedulecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtScheduleType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_scheduletype As DevExpress.XtraGrid.Views.Grid.GridView
End Class
