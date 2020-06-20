<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollAttendanceConsole
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
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDay = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.pic_morning_1 = New DevExpress.XtraEditors.PictureEdit()
        Me.pic_morning_2 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pic_afternoon_2 = New DevExpress.XtraEditors.PictureEdit()
        Me.pic_afternoon_1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.pic_overtime_2 = New DevExpress.XtraEditors.PictureEdit()
        Me.pic_overtime_1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ckViewPicture = New DevExpress.XtraEditors.CheckEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_morning_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_morning_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_afternoon_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_afternoon_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_overtime_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_overtime_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckViewPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl12.Location = New System.Drawing.Point(7, 39)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(197, 13)
        Me.LabelControl12.TabIndex = 629
        Me.LabelControl12.Text = "Please select date to view attendance.."
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(7, 6)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(216, 24)
        Me.LabelControl9.TabIndex = 625
        Me.LabelControl9.Text = "Attendance Console"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(857, 377)
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
        'txtYear
        '
        Me.txtYear.EditValue = "Year"
        Me.txtYear.Location = New System.Drawing.Point(7, 58)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Properties.Appearance.Options.UseFont = True
        Me.txtYear.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtYear.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtYear.Properties.PopupSizeable = True
        Me.txtYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtYear.Size = New System.Drawing.Size(105, 26)
        Me.txtYear.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.EditValue = "Month"
        Me.txtMonth.Location = New System.Drawing.Point(116, 58)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Properties.Appearance.Options.UseFont = True
        Me.txtMonth.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtMonth.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMonth.Properties.PopupSizeable = True
        Me.txtMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtMonth.Size = New System.Drawing.Size(220, 26)
        Me.txtMonth.TabIndex = 1
        '
        'txtDay
        '
        Me.txtDay.EditValue = "Day"
        Me.txtDay.Location = New System.Drawing.Point(342, 58)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Properties.Appearance.Options.UseFont = True
        Me.txtDay.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDay.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtDay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDay.Properties.PopupSizeable = True
        Me.txtDay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDay.Size = New System.Drawing.Size(78, 26)
        Me.txtDay.TabIndex = 2
        '
        'pic_morning_1
        '
        Me.pic_morning_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_morning_1.Location = New System.Drawing.Point(-219, 32)
        Me.pic_morning_1.Name = "pic_morning_1"
        Me.pic_morning_1.Properties.ReadOnly = True
        Me.pic_morning_1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_morning_1.Size = New System.Drawing.Size(100, 86)
        Me.pic_morning_1.TabIndex = 773
        '
        'pic_morning_2
        '
        Me.pic_morning_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_morning_2.Location = New System.Drawing.Point(-113, 32)
        Me.pic_morning_2.Name = "pic_morning_2"
        Me.pic_morning_2.Properties.ReadOnly = True
        Me.pic_morning_2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_morning_2.Size = New System.Drawing.Size(100, 86)
        Me.pic_morning_2.TabIndex = 774
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(-219, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(206, 25)
        Me.LabelControl1.TabIndex = 775
        Me.LabelControl1.Text = "Morning Session"
        '
        'pic_afternoon_2
        '
        Me.pic_afternoon_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_afternoon_2.Location = New System.Drawing.Point(-113, 154)
        Me.pic_afternoon_2.Name = "pic_afternoon_2"
        Me.pic_afternoon_2.Properties.ReadOnly = True
        Me.pic_afternoon_2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_afternoon_2.Size = New System.Drawing.Size(100, 86)
        Me.pic_afternoon_2.TabIndex = 777
        '
        'pic_afternoon_1
        '
        Me.pic_afternoon_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_afternoon_1.Location = New System.Drawing.Point(-219, 154)
        Me.pic_afternoon_1.Name = "pic_afternoon_1"
        Me.pic_afternoon_1.Properties.ReadOnly = True
        Me.pic_afternoon_1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_afternoon_1.Size = New System.Drawing.Size(100, 86)
        Me.pic_afternoon_1.TabIndex = 776
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(-219, 128)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(206, 25)
        Me.LabelControl2.TabIndex = 778
        Me.LabelControl2.Text = "Afternoon Session"
        '
        'pic_overtime_2
        '
        Me.pic_overtime_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_overtime_2.Location = New System.Drawing.Point(-113, 276)
        Me.pic_overtime_2.Name = "pic_overtime_2"
        Me.pic_overtime_2.Properties.ReadOnly = True
        Me.pic_overtime_2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_overtime_2.Size = New System.Drawing.Size(100, 86)
        Me.pic_overtime_2.TabIndex = 780
        '
        'pic_overtime_1
        '
        Me.pic_overtime_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_overtime_1.Location = New System.Drawing.Point(-219, 276)
        Me.pic_overtime_1.Name = "pic_overtime_1"
        Me.pic_overtime_1.Properties.ReadOnly = True
        Me.pic_overtime_1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_overtime_1.Size = New System.Drawing.Size(100, 86)
        Me.pic_overtime_1.TabIndex = 779
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(-219, 250)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(206, 25)
        Me.LabelControl3.TabIndex = 781
        Me.LabelControl3.Text = "Overtime Session"
        '
        'ckViewPicture
        '
        Me.ckViewPicture.Location = New System.Drawing.Point(425, 61)
        Me.ckViewPicture.Name = "ckViewPicture"
        Me.ckViewPicture.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckViewPicture.Properties.Appearance.Options.UseFont = True
        Me.ckViewPicture.Properties.Caption = "View Picture"
        Me.ckViewPicture.Size = New System.Drawing.Size(107, 19)
        Me.ckViewPicture.TabIndex = 799
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Collapsed = True
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(7, 90)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_morning_1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_overtime_2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_morning_2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_overtime_1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_afternoon_1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pic_afternoon_2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(862, 377)
        Me.SplitContainerControl1.SplitterPosition = 230
        Me.SplitContainerControl1.TabIndex = 800
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'frmPayrollAttendanceConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 478)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ckViewPicture)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayrollAttendanceConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Console"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_morning_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_morning_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_afternoon_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_afternoon_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_overtime_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_overtime_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckViewPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDay As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pic_morning_1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pic_morning_2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pic_afternoon_2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pic_afternoon_1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pic_overtime_2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pic_overtime_1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckViewPicture As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
End Class
