<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollPeriod
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
        Me.txtPeriodFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPeriodTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtScheduleType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_scheduletype = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.ckComputeAttendance = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCaptureRemaining = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScheduleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckComputeAttendance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeriodFrom
        '
        Me.txtPeriodFrom.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodFrom.Location = New System.Drawing.Point(119, 109)
        Me.txtPeriodFrom.Name = "txtPeriodFrom"
        Me.txtPeriodFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodFrom.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodFrom.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodFrom.TabIndex = 767
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(87, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 770
        Me.LabelControl1.Text = "From"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(101, 135)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 771
        Me.LabelControl2.Text = "To"
        '
        'txtPeriodTo
        '
        Me.txtPeriodTo.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodTo.Location = New System.Drawing.Point(119, 132)
        Me.txtPeriodTo.Name = "txtPeriodTo"
        Me.txtPeriodTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodTo.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodTo.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodTo.TabIndex = 772
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(53, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 774
        Me.LabelControl3.Text = "Payroll Type"
        '
        'txtScheduleType
        '
        Me.txtScheduleType.Location = New System.Drawing.Point(119, 38)
        Me.txtScheduleType.Name = "txtScheduleType"
        Me.txtScheduleType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScheduleType.Properties.Appearance.Options.UseFont = True
        Me.txtScheduleType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtScheduleType.Properties.DisplayMember = "Select"
        Me.txtScheduleType.Properties.NullText = ""
        Me.txtScheduleType.Properties.ValueMember = "Select"
        Me.txtScheduleType.Properties.View = Me.gv_scheduletype
        Me.txtScheduleType.Size = New System.Drawing.Size(191, 20)
        Me.txtScheduleType.TabIndex = 773
        '
        'gv_scheduletype
        '
        Me.gv_scheduletype.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_scheduletype.Name = "gv_scheduletype"
        Me.gv_scheduletype.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_scheduletype.OptionsView.ShowGroupPanel = False
        '
        'payrollcode
        '
        Me.payrollcode.EditValue = "105P2016-1201-1215"
        Me.payrollcode.Location = New System.Drawing.Point(119, 15)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.payrollcode.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.payrollcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payrollcode.Properties.Appearance.Options.UseBackColor = True
        Me.payrollcode.Properties.Appearance.Options.UseFont = True
        Me.payrollcode.Properties.Appearance.Options.UseTextOptions = True
        Me.payrollcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.payrollcode.Properties.ReadOnly = True
        Me.payrollcode.Size = New System.Drawing.Size(191, 20)
        Me.payrollcode.TabIndex = 775
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(29, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 776
        Me.LabelControl4.Text = "Generated Code"
        '
        'cmdCreate
        '
        Me.cmdCreate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCreate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdCreate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCreate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCreate.Appearance.Options.UseBackColor = True
        Me.cmdCreate.Appearance.Options.UseFont = True
        Me.cmdCreate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCreate.Location = New System.Drawing.Point(119, 180)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(122, 32)
        Me.cmdCreate.TabIndex = 777
        Me.cmdCreate.Text = "Confirm Create"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl5.Location = New System.Drawing.Point(53, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(148, 15)
        Me.LabelControl5.TabIndex = 778
        Me.LabelControl5.Text = "Please select period covered"
        '
        'schedulecode
        '
        Me.schedulecode.Location = New System.Drawing.Point(316, 41)
        Me.schedulecode.Name = "schedulecode"
        Me.schedulecode.Size = New System.Drawing.Size(58, 20)
        Me.schedulecode.TabIndex = 797
        Me.schedulecode.Visible = False
        '
        'ckComputeAttendance
        '
        Me.ckComputeAttendance.Location = New System.Drawing.Point(119, 60)
        Me.ckComputeAttendance.Name = "ckComputeAttendance"
        Me.ckComputeAttendance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckComputeAttendance.Properties.Appearance.Options.UseFont = True
        Me.ckComputeAttendance.Properties.Caption = "Compute Attendance"
        Me.ckComputeAttendance.Properties.ReadOnly = True
        Me.ckComputeAttendance.Size = New System.Drawing.Size(128, 19)
        Me.ckComputeAttendance.TabIndex = 798
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(119, 156)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl6.Location = New System.Drawing.Point(70, 159)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl6.TabIndex = 799
        Me.LabelControl6.Text = "Remarks"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCancel.Appearance.Options.UseBackColor = True
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Appearance.Options.UseForeColor = True
        Me.cmdCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCancel.Location = New System.Drawing.Point(245, 180)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(145, 32)
        Me.cmdCancel.TabIndex = 800
        Me.cmdCancel.Text = "Cancel Payroll"
        Me.cmdCancel.Visible = False
        '
        'cmdCaptureRemaining
        '
        Me.cmdCaptureRemaining.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCaptureRemaining.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCaptureRemaining.Appearance.Options.UseFont = True
        Me.cmdCaptureRemaining.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCaptureRemaining.Location = New System.Drawing.Point(247, 110)
        Me.cmdCaptureRemaining.Name = "cmdCaptureRemaining"
        Me.cmdCaptureRemaining.Size = New System.Drawing.Size(143, 41)
        Me.cmdCaptureRemaining.TabIndex = 801
        Me.cmdCaptureRemaining.Text = "Capture Remaining"
        '
        'frmPayrollPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 230)
        Me.Controls.Add(Me.cmdCaptureRemaining)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.ckComputeAttendance)
        Me.Controls.Add(Me.schedulecode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtScheduleType)
        Me.Controls.Add(Me.txtPeriodTo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPeriodFrom)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayrollPeriod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Payroll Period"
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScheduleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckComputeAttendance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPeriodFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPeriodTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtScheduleType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_scheduletype As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents schedulecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckComputeAttendance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCaptureRemaining As DevExpress.XtraEditors.SimpleButton
End Class
