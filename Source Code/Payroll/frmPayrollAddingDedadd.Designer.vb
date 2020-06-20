<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollAddingDedadd
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
        Me.cmdActiveInactive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAttendanceSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.employeeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblsubject = New DevExpress.XtraEditors.LabelControl()
        Me.radDedAdd = New DevExpress.XtraEditors.RadioGroup()
        Me.dedaddcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.txtEmployee = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_employee = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gv_dedAddType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDedAddType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPayrollCode = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gv_payrollcode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDateTransaction = New DevExpress.XtraEditors.DateEdit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDedAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_dedAddType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDedAddType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_payrollcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTransaction.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTransaction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdActiveInactive, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 54)
        '
        'cmdActiveInactive
        '
        Me.cmdActiveInactive.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdActiveInactive.Name = "cmdActiveInactive"
        Me.cmdActiveInactive.Size = New System.Drawing.Size(164, 22)
        Me.cmdActiveInactive.Text = "Remove Selected"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'cmdAttendanceSettings
        '
        Me.cmdAttendanceSettings.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttendanceSettings.Appearance.Options.UseFont = True
        Me.cmdAttendanceSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAttendanceSettings.Location = New System.Drawing.Point(100, 287)
        Me.cmdAttendanceSettings.Name = "cmdAttendanceSettings"
        Me.cmdAttendanceSettings.Size = New System.Drawing.Size(135, 27)
        Me.cmdAttendanceSettings.TabIndex = 5
        Me.cmdAttendanceSettings.Text = "Save"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.lblTitle.Location = New System.Drawing.Point(11, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(165, 24)
        Me.lblTitle.TabIndex = 625
        Me.lblTitle.Text = "Add Deductions"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Location = New System.Drawing.Point(246, 1)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(920, 520)
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
        'employeeid
        '
        Me.employeeid.Location = New System.Drawing.Point(11, 333)
        Me.employeeid.Name = "employeeid"
        Me.employeeid.Size = New System.Drawing.Size(58, 20)
        Me.employeeid.TabIndex = 650
        Me.employeeid.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl12.Location = New System.Drawing.Point(12, 109)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl12.TabIndex = 733
        Me.LabelControl12.Text = "Select Employee"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.EnterMoveNextControl = True
        Me.txtAmount.Location = New System.Drawing.Point(100, 257)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.MaxLength = 50
        Me.txtAmount.Size = New System.Drawing.Size(135, 26)
        Me.txtAmount.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(44, 260)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl4.TabIndex = 743
        Me.LabelControl4.Text = "Amount"
        '
        'lblsubject
        '
        Me.lblsubject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubject.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblsubject.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblsubject.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblsubject.Location = New System.Drawing.Point(12, 147)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(113, 13)
        Me.lblsubject.TabIndex = 751
        Me.lblsubject.Text = "Select Deduction Type"
        '
        'radDedAdd
        '
        Me.radDedAdd.EditValue = True
        Me.radDedAdd.Location = New System.Drawing.Point(8, 84)
        Me.radDedAdd.Name = "radDedAdd"
        Me.radDedAdd.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.radDedAdd.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDedAdd.Properties.Appearance.Options.UseBackColor = True
        Me.radDedAdd.Properties.Appearance.Options.UseFont = True
        Me.radDedAdd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.radDedAdd.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Deduction"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Additional")})
        Me.radDedAdd.Size = New System.Drawing.Size(178, 23)
        Me.radDedAdd.TabIndex = 758
        '
        'dedaddcode
        '
        Me.dedaddcode.Location = New System.Drawing.Point(11, 359)
        Me.dedaddcode.Name = "dedaddcode"
        Me.dedaddcode.Size = New System.Drawing.Size(58, 20)
        Me.dedaddcode.TabIndex = 801
        Me.dedaddcode.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = "Remarks.."
        Me.txtRemarks.Location = New System.Drawing.Point(12, 186)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(223, 43)
        Me.txtRemarks.TabIndex = 3
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(12, 124)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Properties.Appearance.Options.UseFont = True
        Me.txtEmployee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEmployee.Properties.DisplayMember = "Select"
        Me.txtEmployee.Properties.NullText = ""
        Me.txtEmployee.Properties.ValueMember = "Select"
        Me.txtEmployee.Properties.View = Me.gv_employee
        Me.txtEmployee.Size = New System.Drawing.Size(223, 20)
        Me.txtEmployee.TabIndex = 1
        '
        'gv_employee
        '
        Me.gv_employee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_employee.Name = "gv_employee"
        Me.gv_employee.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_employee.OptionsView.ShowGroupPanel = False
        '
        'gv_dedAddType
        '
        Me.gv_dedAddType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_dedAddType.Name = "gv_dedAddType"
        Me.gv_dedAddType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_dedAddType.OptionsView.ShowGroupPanel = False
        '
        'txtDedAddType
        '
        Me.txtDedAddType.Location = New System.Drawing.Point(12, 163)
        Me.txtDedAddType.Name = "txtDedAddType"
        Me.txtDedAddType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDedAddType.Properties.Appearance.Options.UseFont = True
        Me.txtDedAddType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDedAddType.Properties.DisplayMember = "Select"
        Me.txtDedAddType.Properties.NullText = ""
        Me.txtDedAddType.Properties.ValueMember = "Select"
        Me.txtDedAddType.Properties.View = Me.gv_dedAddType
        Me.txtDedAddType.Size = New System.Drawing.Size(223, 20)
        Me.txtDedAddType.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(15, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl1.TabIndex = 803
        Me.LabelControl1.Text = "Select Payroll Code"
        '
        'txtPayrollCode
        '
        Me.txtPayrollCode.Location = New System.Drawing.Point(12, 59)
        Me.txtPayrollCode.Name = "txtPayrollCode"
        Me.txtPayrollCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayrollCode.Properties.Appearance.Options.UseFont = True
        Me.txtPayrollCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPayrollCode.Properties.DisplayMember = "Payroll Code"
        Me.txtPayrollCode.Properties.NullText = ""
        Me.txtPayrollCode.Properties.ValueMember = "Payroll Code"
        Me.txtPayrollCode.Properties.View = Me.gv_payrollcode
        Me.txtPayrollCode.Size = New System.Drawing.Size(223, 20)
        Me.txtPayrollCode.TabIndex = 0
        '
        'gv_payrollcode
        '
        Me.gv_payrollcode.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_payrollcode.Name = "gv_payrollcode"
        Me.gv_payrollcode.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_payrollcode.OptionsView.ColumnAutoWidth = False
        Me.gv_payrollcode.OptionsView.ShowGroupPanel = False
        '
        'txtDateTransaction
        '
        Me.txtDateTransaction.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtDateTransaction.Location = New System.Drawing.Point(12, 233)
        Me.txtDateTransaction.Name = "txtDateTransaction"
        Me.txtDateTransaction.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTransaction.Properties.Appearance.Options.UseFont = True
        Me.txtDateTransaction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTransaction.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTransaction.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTransaction.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTransaction.Size = New System.Drawing.Size(223, 20)
        Me.txtDateTransaction.TabIndex = 804
        '
        'frmPayrollAddingDedadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 521)
        Me.Controls.Add(Me.txtDateTransaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPayrollCode)
        Me.Controls.Add(Me.dedaddcode)
        Me.Controls.Add(Me.txtDedAddType)
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.employeeid)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdAttendanceSettings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.radDedAdd)
        Me.Name = "frmPayrollAddingDedadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Deduction and Additional "
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDedAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedaddcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_dedAddType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDedAddType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayrollCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_payrollcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTransaction.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTransaction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAttendanceSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents employeeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsubject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radDedAdd As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdActiveInactive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dedaddcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtEmployee As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_employee As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gv_dedAddType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDedAddType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPayrollCode As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gv_payrollcode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDateTransaction As DevExpress.XtraEditors.DateEdit
End Class
