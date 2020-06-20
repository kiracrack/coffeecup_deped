<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollDeductionRange
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
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAttendanceSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdedRange = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_DeductionRange = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dedaddcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtRange_from = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRange_to = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtemployeeShare = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmployerShare = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdedRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_DeductionRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRange_from.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRange_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemployeeShare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployerShare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(680, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 312)
        Me.barDockControlBottom.Size = New System.Drawing.Size(680, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 312)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(680, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 312)
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DeleteSelectedToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(155, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem1.Text = "Edit Selected"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'cmdAttendanceSettings
        '
        Me.cmdAttendanceSettings.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttendanceSettings.Appearance.Options.UseFont = True
        Me.cmdAttendanceSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAttendanceSettings.Location = New System.Drawing.Point(45, 238)
        Me.cmdAttendanceSettings.Name = "cmdAttendanceSettings"
        Me.cmdAttendanceSettings.Size = New System.Drawing.Size(147, 27)
        Me.cmdAttendanceSettings.TabIndex = 6
        Me.cmdAttendanceSettings.Text = "Save Range"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(15, 9)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(182, 24)
        Me.LabelControl9.TabIndex = 625
        Me.LabelControl9.Text = "Deduction Range"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(231, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(449, 310)
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
        Me.LabelControl12.Location = New System.Drawing.Point(15, 37)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl12.TabIndex = 733
        Me.LabelControl12.Text = "Select Default Deduction"
        '
        'txtdedRange
        '
        Me.txtdedRange.EnterMoveNextControl = True
        Me.txtdedRange.Location = New System.Drawing.Point(15, 53)
        Me.txtdedRange.MenuManager = Me.BarManager1
        Me.txtdedRange.Name = "txtdedRange"
        Me.txtdedRange.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdedRange.Properties.Appearance.Options.UseFont = True
        Me.txtdedRange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdedRange.Properties.DisplayMember = "Select"
        Me.txtdedRange.Properties.NullText = ""
        Me.txtdedRange.Properties.ValueMember = "Select"
        Me.txtdedRange.Properties.View = Me.gv_DeductionRange
        Me.txtdedRange.Size = New System.Drawing.Size(207, 20)
        Me.txtdedRange.TabIndex = 732
        '
        'gv_DeductionRange
        '
        Me.gv_DeductionRange.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_DeductionRange.Name = "gv_DeductionRange"
        Me.gv_DeductionRange.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_DeductionRange.OptionsView.ShowGroupPanel = False
        '
        'dedaddcode
        '
        Me.dedaddcode.EditValue = ""
        Me.dedaddcode.Location = New System.Drawing.Point(268, 106)
        Me.dedaddcode.Name = "dedaddcode"
        Me.dedaddcode.Properties.Appearance.Options.UseTextOptions = True
        Me.dedaddcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dedaddcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dedaddcode.Properties.ReadOnly = True
        Me.dedaddcode.Size = New System.Drawing.Size(58, 20)
        Me.dedaddcode.TabIndex = 734
        Me.dedaddcode.Visible = False
        '
        'txtRange_from
        '
        Me.txtRange_from.EditValue = ""
        Me.txtRange_from.EnterMoveNextControl = True
        Me.txtRange_from.Location = New System.Drawing.Point(102, 103)
        Me.txtRange_from.Name = "txtRange_from"
        Me.txtRange_from.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRange_from.Properties.Appearance.Options.UseFont = True
        Me.txtRange_from.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRange_from.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRange_from.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRange_from.Properties.Mask.EditMask = "n"
        Me.txtRange_from.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRange_from.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRange_from.Properties.MaxLength = 50
        Me.txtRange_from.Size = New System.Drawing.Size(120, 20)
        Me.txtRange_from.TabIndex = 735
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl44.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl44.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl44.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl44.Location = New System.Drawing.Point(32, 106)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl44.TabIndex = 736
        Me.LabelControl44.Text = "Range from"
        '
        'txtRange_to
        '
        Me.txtRange_to.EditValue = ""
        Me.txtRange_to.EnterMoveNextControl = True
        Me.txtRange_to.Location = New System.Drawing.Point(102, 126)
        Me.txtRange_to.Name = "txtRange_to"
        Me.txtRange_to.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRange_to.Properties.Appearance.Options.UseFont = True
        Me.txtRange_to.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRange_to.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRange_to.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRange_to.Properties.Mask.EditMask = "n"
        Me.txtRange_to.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRange_to.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRange_to.Properties.MaxLength = 50
        Me.txtRange_to.Size = New System.Drawing.Size(120, 20)
        Me.txtRange_to.TabIndex = 737
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(45, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 738
        Me.LabelControl1.Text = "Range to"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(50, 84)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl2.TabIndex = 739
        Me.LabelControl2.Text = "Salary Range Settings"
        '
        'txtemployeeShare
        '
        Me.txtemployeeShare.EditValue = ""
        Me.txtemployeeShare.EnterMoveNextControl = True
        Me.txtemployeeShare.Location = New System.Drawing.Point(102, 172)
        Me.txtemployeeShare.Name = "txtemployeeShare"
        Me.txtemployeeShare.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployeeShare.Properties.Appearance.Options.UseFont = True
        Me.txtemployeeShare.Properties.Appearance.Options.UseTextOptions = True
        Me.txtemployeeShare.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtemployeeShare.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemployeeShare.Properties.Mask.EditMask = "n"
        Me.txtemployeeShare.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtemployeeShare.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtemployeeShare.Properties.MaxLength = 50
        Me.txtemployeeShare.Size = New System.Drawing.Size(120, 20)
        Me.txtemployeeShare.TabIndex = 740
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(11, 175)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl3.TabIndex = 741
        Me.LabelControl3.Text = "Employee Share"
        '
        'txtEmployerShare
        '
        Me.txtEmployerShare.EditValue = ""
        Me.txtEmployerShare.EnterMoveNextControl = True
        Me.txtEmployerShare.Location = New System.Drawing.Point(102, 195)
        Me.txtEmployerShare.Name = "txtEmployerShare"
        Me.txtEmployerShare.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployerShare.Properties.Appearance.Options.UseFont = True
        Me.txtEmployerShare.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmployerShare.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEmployerShare.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployerShare.Properties.Mask.EditMask = "n"
        Me.txtEmployerShare.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEmployerShare.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEmployerShare.Properties.MaxLength = 50
        Me.txtEmployerShare.Size = New System.Drawing.Size(120, 20)
        Me.txtEmployerShare.TabIndex = 742
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(13, 198)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl4.TabIndex = 743
        Me.LabelControl4.Text = "Employer Share"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl5.Location = New System.Drawing.Point(51, 152)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 748
        Me.LabelControl5.Text = "Salary Shares"
        '
        'frmPayrollDeductionRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 312)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtEmployerShare)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtemployeeShare)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtRange_to)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtRange_from)
        Me.Controls.Add(Me.LabelControl44)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtdedRange)
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
        Me.MinimumSize = New System.Drawing.Size(696, 351)
        Me.Name = "frmPayrollDeductionRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction Range"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdedRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_DeductionRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRange_from.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRange_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemployeeShare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployerShare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtdedRange As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_DeductionRange As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dedaddcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRange_from As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRange_to As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtemployeeShare As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmployerShare As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
