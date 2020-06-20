<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCaptureAttendance
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
        Me.txtPayrollCode = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_scheduletype = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCapture = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilePath = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.radSelectAttendance = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radSelectAttendance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeriodFrom
        '
        Me.txtPeriodFrom.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodFrom.Location = New System.Drawing.Point(119, 69)
        Me.txtPeriodFrom.Name = "txtPeriodFrom"
        Me.txtPeriodFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodFrom.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodFrom.Properties.ReadOnly = True
        Me.txtPeriodFrom.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodFrom.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(87, 72)
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
        Me.LabelControl2.Location = New System.Drawing.Point(101, 94)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 771
        Me.LabelControl2.Text = "To"
        '
        'txtPeriodTo
        '
        Me.txtPeriodTo.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodTo.Location = New System.Drawing.Point(119, 91)
        Me.txtPeriodTo.Name = "txtPeriodTo"
        Me.txtPeriodTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodTo.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodTo.Properties.ReadOnly = True
        Me.txtPeriodTo.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodTo.TabIndex = 3
        '
        'txtPayrollCode
        '
        Me.txtPayrollCode.Location = New System.Drawing.Point(119, 19)
        Me.txtPayrollCode.Name = "txtPayrollCode"
        Me.txtPayrollCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayrollCode.Properties.Appearance.Options.UseFont = True
        Me.txtPayrollCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPayrollCode.Properties.DisplayMember = "Payroll Code"
        Me.txtPayrollCode.Properties.NullText = ""
        Me.txtPayrollCode.Properties.ValueMember = "Payroll Code"
        Me.txtPayrollCode.Properties.View = Me.gv_scheduletype
        Me.txtPayrollCode.Size = New System.Drawing.Size(191, 20)
        Me.txtPayrollCode.TabIndex = 0
        '
        'gv_scheduletype
        '
        Me.gv_scheduletype.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_scheduletype.Name = "gv_scheduletype"
        Me.gv_scheduletype.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_scheduletype.OptionsView.ColumnAutoWidth = False
        Me.gv_scheduletype.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(49, 22)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 776
        Me.LabelControl4.Text = "Payroll Code"
        '
        'cmdCapture
        '
        Me.cmdCapture.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCapture.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdCapture.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCapture.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCapture.Appearance.Options.UseBackColor = True
        Me.cmdCapture.Appearance.Options.UseFont = True
        Me.cmdCapture.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCapture.Location = New System.Drawing.Point(119, 214)
        Me.cmdCapture.Name = "cmdCapture"
        Me.cmdCapture.Size = New System.Drawing.Size(122, 32)
        Me.cmdCapture.TabIndex = 5
        Me.cmdCapture.Text = "Confirm Capture"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl5.Location = New System.Drawing.Point(44, 48)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(295, 15)
        Me.LabelControl5.TabIndex = 778
        Me.LabelControl5.Text = "System will capture base on period covered listed below"
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(316, 19)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(58, 20)
        Me.payrollcode.TabIndex = 797
        Me.payrollcode.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(119, 164)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl6.Location = New System.Drawing.Point(29, 167)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl6.TabIndex = 799
        Me.LabelControl6.Text = "Biometric Model"
        '
        'txtFilePath
        '
        Me.txtFilePath.EditValue = ""
        Me.txtFilePath.Location = New System.Drawing.Point(119, 187)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtFilePath.Properties.Appearance.Options.UseFont = True
        Me.txtFilePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFilePath.Properties.ReadOnly = True
        Me.txtFilePath.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFilePath.Size = New System.Drawing.Size(271, 22)
        Me.txtFilePath.TabIndex = 4
        Me.txtFilePath.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(44, 191)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl3.TabIndex = 802
        Me.LabelControl3.Text = "Biometric File"
        '
        'radSelectAttendance
        '
        Me.radSelectAttendance.EditValue = False
        Me.radSelectAttendance.Location = New System.Drawing.Point(115, 115)
        Me.radSelectAttendance.Name = "radSelectAttendance"
        Me.radSelectAttendance.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.radSelectAttendance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSelectAttendance.Properties.Appearance.Options.UseBackColor = True
        Me.radSelectAttendance.Properties.Appearance.Options.UseFont = True
        Me.radSelectAttendance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.radSelectAttendance.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Time Console Attendance"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Biometric Attendance")})
        Me.radSelectAttendance.Size = New System.Drawing.Size(176, 46)
        Me.radSelectAttendance.TabIndex = 803
        '
        'frmPayrollCaptureAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 263)
        Me.Controls.Add(Me.radSelectAttendance)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmdCapture)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtPayrollCode)
        Me.Controls.Add(Me.txtPeriodTo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPeriodFrom)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayrollCaptureAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Attendance"
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_scheduletype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radSelectAttendance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPeriodFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPeriodTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPayrollCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_scheduletype As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCapture As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radSelectAttendance As DevExpress.XtraEditors.RadioGroup
End Class
