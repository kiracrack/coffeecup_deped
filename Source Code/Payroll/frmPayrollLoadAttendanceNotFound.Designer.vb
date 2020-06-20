<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollLoadAttendanceNotFound
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
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.schedulecode = New DevExpress.XtraEditors.TextEdit()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPeriodTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPeriodFrom = New DevExpress.XtraEditors.DateEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblDescription.Location = New System.Drawing.Point(43, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(236, 13)
        Me.lblDescription.TabIndex = 629
        Me.lblDescription.Text = "Listed all employess has no attendance record"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(0, 57)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(323, 297)
        Me.Em.TabIndex = 645
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsCustomization.AllowGroup = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'cmdCreate
        '
        Me.cmdCreate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCreate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCreate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdCreate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCreate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCreate.Appearance.Options.UseBackColor = True
        Me.cmdCreate.Appearance.Options.UseFont = True
        Me.cmdCreate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCreate.Location = New System.Drawing.Point(0, 355)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(323, 32)
        Me.cmdCreate.TabIndex = 778
        Me.cmdCreate.Text = "Create system generated attendance"
        '
        'schedulecode
        '
        Me.schedulecode.Location = New System.Drawing.Point(185, 145)
        Me.schedulecode.Name = "schedulecode"
        Me.schedulecode.Size = New System.Drawing.Size(58, 20)
        Me.schedulecode.TabIndex = 805
        Me.schedulecode.Visible = False
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(121, 145)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(58, 20)
        Me.payrollcode.TabIndex = 804
        Me.payrollcode.Visible = False
        '
        'txtPeriodTo
        '
        Me.txtPeriodTo.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodTo.Location = New System.Drawing.Point(185, 27)
        Me.txtPeriodTo.Name = "txtPeriodTo"
        Me.txtPeriodTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodTo.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodTo.Properties.ReadOnly = True
        Me.txtPeriodTo.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodTo.TabIndex = 807
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(168, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 809
        Me.LabelControl2.Text = "To"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(8, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 808
        Me.LabelControl1.Text = "From"
        '
        'txtPeriodFrom
        '
        Me.txtPeriodFrom.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtPeriodFrom.Location = New System.Drawing.Point(40, 27)
        Me.txtPeriodFrom.Name = "txtPeriodFrom"
        Me.txtPeriodFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodFrom.Properties.Appearance.Options.UseFont = True
        Me.txtPeriodFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPeriodFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriodFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtPeriodFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPeriodFrom.Properties.ReadOnly = True
        Me.txtPeriodFrom.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodFrom.TabIndex = 806
        '
        'frmPayrollLoadAttendanceNotFound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 391)
        Me.Controls.Add(Me.txtPeriodTo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPeriodFrom)
        Me.Controls.Add(Me.schedulecode)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Em)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayrollLoadAttendanceNotFound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee's Attendance not found"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents schedulecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPeriodTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPeriodFrom As DevExpress.XtraEditors.DateEdit
End Class
