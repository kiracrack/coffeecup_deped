<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollShiftSettings
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txttotalhours = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAttendanceSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_second_out = New DevExpress.XtraEditors.TimeEdit()
        Me.txt_first_out = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_second_in = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_first_in = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtshifttype = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.ckFlexiBreakTime = New DevExpress.XtraEditors.CheckEdit()
        Me.ckFlexiAllTime = New DevExpress.XtraEditors.CheckEdit()
        Me.ckOnetimeInout = New DevExpress.XtraEditors.CheckEdit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.txttotalhours.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_second_out.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_first_out.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_second_in.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_first_in.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtshifttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckFlexiBreakTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckFlexiAllTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckOnetimeInout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txttotalhours
        '
        Me.txttotalhours.EditValue = ""
        Me.txttotalhours.EnterMoveNextControl = True
        Me.txttotalhours.Location = New System.Drawing.Point(136, 239)
        Me.txttotalhours.Name = "txttotalhours"
        Me.txttotalhours.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalhours.Properties.Appearance.Options.UseFont = True
        Me.txttotalhours.Properties.Appearance.Options.UseTextOptions = True
        Me.txttotalhours.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttotalhours.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotalhours.Properties.Mask.EditMask = "n"
        Me.txttotalhours.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotalhours.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotalhours.Properties.MaxLength = 50
        Me.txttotalhours.Properties.ReadOnly = True
        Me.txttotalhours.Size = New System.Drawing.Size(109, 20)
        Me.txttotalhours.TabIndex = 5
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl63.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl63.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl63.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl63.Location = New System.Drawing.Point(69, 242)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl63.TabIndex = 640
        Me.LabelControl63.Text = "Total Hours"
        '
        'cmdAttendanceSettings
        '
        Me.cmdAttendanceSettings.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttendanceSettings.Appearance.Options.UseFont = True
        Me.cmdAttendanceSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAttendanceSettings.Location = New System.Drawing.Point(98, 324)
        Me.cmdAttendanceSettings.Name = "cmdAttendanceSettings"
        Me.cmdAttendanceSettings.Size = New System.Drawing.Size(147, 27)
        Me.cmdAttendanceSettings.TabIndex = 6
        Me.cmdAttendanceSettings.Text = "Save Settings"
        '
        'LabelControl56
        '
        Me.LabelControl56.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl56.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl56.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl56.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl56.Location = New System.Drawing.Point(82, 218)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl56.TabIndex = 636
        Me.LabelControl56.Text = "Time Out"
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl53.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl53.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl53.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl53.Location = New System.Drawing.Point(82, 129)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl53.TabIndex = 637
        Me.LabelControl53.Text = "Time Out"
        '
        'txt_second_out
        '
        Me.txt_second_out.EditValue = New Date(2013, 9, 30, 0, 0, 0, 0)
        Me.txt_second_out.EnterMoveNextControl = True
        Me.txt_second_out.Location = New System.Drawing.Point(136, 215)
        Me.txt_second_out.Name = "txt_second_out"
        Me.txt_second_out.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_second_out.Properties.Appearance.Options.UseFont = True
        Me.txt_second_out.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_second_out.Properties.Mask.EditMask = "t"
        Me.txt_second_out.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_second_out.Size = New System.Drawing.Size(109, 20)
        Me.txt_second_out.TabIndex = 4
        '
        'txt_first_out
        '
        Me.txt_first_out.EditValue = New Date(2013, 9, 30, 0, 0, 0, 0)
        Me.txt_first_out.EnterMoveNextControl = True
        Me.txt_first_out.Location = New System.Drawing.Point(136, 126)
        Me.txt_first_out.Name = "txt_first_out"
        Me.txt_first_out.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_out.Properties.Appearance.Options.UseFont = True
        Me.txt_first_out.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_first_out.Properties.Mask.EditMask = "t"
        Me.txt_first_out.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_first_out.Size = New System.Drawing.Size(109, 20)
        Me.txt_first_out.TabIndex = 2
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl55.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl55.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl55.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl55.Location = New System.Drawing.Point(92, 195)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl55.TabIndex = 632
        Me.LabelControl55.Text = "Time In"
        '
        'LabelControl52
        '
        Me.LabelControl52.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl52.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl52.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl52.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl52.Location = New System.Drawing.Point(92, 106)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl52.TabIndex = 633
        Me.LabelControl52.Text = "Time In"
        '
        'txt_second_in
        '
        Me.txt_second_in.EditValue = New Date(2013, 9, 30, 0, 0, 0, 0)
        Me.txt_second_in.EnterMoveNextControl = True
        Me.txt_second_in.Location = New System.Drawing.Point(136, 192)
        Me.txt_second_in.Name = "txt_second_in"
        Me.txt_second_in.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_second_in.Properties.Appearance.Options.UseFont = True
        Me.txt_second_in.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_second_in.Properties.Mask.EditMask = "t"
        Me.txt_second_in.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_second_in.Size = New System.Drawing.Size(109, 20)
        Me.txt_second_in.TabIndex = 3
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl54.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl54.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl54.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl54.Location = New System.Drawing.Point(71, 175)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl54.TabIndex = 627
        Me.LabelControl54.Text = "Second Attendance Session"
        '
        'txt_first_in
        '
        Me.txt_first_in.EditValue = New Date(2013, 9, 30, 0, 0, 0, 0)
        Me.txt_first_in.EnterMoveNextControl = True
        Me.txt_first_in.Location = New System.Drawing.Point(136, 103)
        Me.txt_first_in.Name = "txt_first_in"
        Me.txt_first_in.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_in.Properties.Appearance.Options.UseFont = True
        Me.txt_first_in.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_first_in.Properties.Mask.EditMask = "t"
        Me.txt_first_in.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_first_in.Size = New System.Drawing.Size(109, 20)
        Me.txt_first_in.TabIndex = 1
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl51.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl51.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl51.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl51.Location = New System.Drawing.Point(71, 86)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl51.TabIndex = 628
        Me.LabelControl51.Text = "First Attendance Session"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl12.Location = New System.Drawing.Point(49, 44)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl12.TabIndex = 629
        Me.LabelControl12.Text = "Shift Description"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(122, 24)
        Me.LabelControl9.TabIndex = 625
        Me.LabelControl9.Text = "Shift Settings"
        '
        'txtshifttype
        '
        Me.txtshifttype.EnterMoveNextControl = True
        Me.txtshifttype.Location = New System.Drawing.Point(49, 60)
        Me.txtshifttype.Name = "txtshifttype"
        Me.txtshifttype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshifttype.Properties.Appearance.Options.UseFont = True
        Me.txtshifttype.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtshifttype.Size = New System.Drawing.Size(273, 20)
        Me.txtshifttype.TabIndex = 0
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(335, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(575, 394)
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
        Me.code.Location = New System.Drawing.Point(857, 103)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(58, 20)
        Me.code.TabIndex = 650
        Me.code.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(857, 126)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(58, 20)
        Me.mode.TabIndex = 651
        Me.mode.Visible = False
        '
        'ckFlexiBreakTime
        '
        Me.ckFlexiBreakTime.Location = New System.Drawing.Point(136, 149)
        Me.ckFlexiBreakTime.Name = "ckFlexiBreakTime"
        Me.ckFlexiBreakTime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFlexiBreakTime.Properties.Appearance.Options.UseFont = True
        Me.ckFlexiBreakTime.Properties.Caption = "Flexi Break Time"
        Me.ckFlexiBreakTime.Size = New System.Drawing.Size(109, 19)
        Me.ckFlexiBreakTime.TabIndex = 767
        '
        'ckFlexiAllTime
        '
        Me.ckFlexiAllTime.Location = New System.Drawing.Point(136, 263)
        Me.ckFlexiAllTime.Name = "ckFlexiAllTime"
        Me.ckFlexiAllTime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFlexiAllTime.Properties.Appearance.Options.UseFont = True
        Me.ckFlexiAllTime.Properties.Caption = "Flexi All Time"
        Me.ckFlexiAllTime.Size = New System.Drawing.Size(109, 19)
        Me.ckFlexiAllTime.TabIndex = 768
        '
        'ckOnetimeInout
        '
        Me.ckOnetimeInout.Location = New System.Drawing.Point(82, 288)
        Me.ckOnetimeInout.Name = "ckOnetimeInout"
        Me.ckOnetimeInout.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOnetimeInout.Properties.Appearance.Options.UseFont = True
        Me.ckOnetimeInout.Properties.Caption = "One time IN and OUT Attendance"
        Me.ckOnetimeInout.Size = New System.Drawing.Size(193, 19)
        Me.ckOnetimeInout.TabIndex = 769
        '
        'frmPayrollShiftSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 394)
        Me.Controls.Add(Me.ckOnetimeInout)
        Me.Controls.Add(Me.ckFlexiAllTime)
        Me.Controls.Add(Me.ckFlexiBreakTime)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txttotalhours)
        Me.Controls.Add(Me.LabelControl63)
        Me.Controls.Add(Me.cmdAttendanceSettings)
        Me.Controls.Add(Me.LabelControl56)
        Me.Controls.Add(Me.LabelControl53)
        Me.Controls.Add(Me.txt_second_out)
        Me.Controls.Add(Me.txt_first_out)
        Me.Controls.Add(Me.LabelControl55)
        Me.Controls.Add(Me.LabelControl52)
        Me.Controls.Add(Me.txt_second_in)
        Me.Controls.Add(Me.LabelControl54)
        Me.Controls.Add(Me.txt_first_in)
        Me.Controls.Add(Me.LabelControl51)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtshifttype)
        Me.MinimumSize = New System.Drawing.Size(702, 333)
        Me.Name = "frmPayrollShiftSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shift Settings"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.txttotalhours.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_second_out.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_first_out.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_second_in.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_first_in.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtshifttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckFlexiBreakTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckFlexiAllTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckOnetimeInout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txttotalhours As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAttendanceSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_second_out As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txt_first_out As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_second_in As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_first_in As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtshifttype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckFlexiBreakTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckFlexiAllTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckOnetimeInout As DevExpress.XtraEditors.CheckEdit
End Class
