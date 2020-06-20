<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSettings
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
        Me.reportid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdFinish = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPaperKind = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckorientation = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReportForm = New DevExpress.XtraEditors.TextEdit()
        Me.txtReportTitle = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.reportid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaperKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckorientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportid
        '
        Me.reportid.EditValue = ""
        Me.reportid.EnterMoveNextControl = True
        Me.reportid.Location = New System.Drawing.Point(44, 210)
        Me.reportid.Name = "reportid"
        Me.reportid.Properties.ReadOnly = True
        Me.reportid.Properties.ValidateOnEnterKey = True
        Me.reportid.Size = New System.Drawing.Size(69, 20)
        Me.reportid.TabIndex = 543
        Me.reportid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(27, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl4.TabIndex = 544
        Me.LabelControl4.Text = "Default Paperkind"
        '
        'cmdFinish
        '
        Me.cmdFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdFinish.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdFinish.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdFinish.Appearance.Options.UseBackColor = True
        Me.cmdFinish.Appearance.Options.UseFont = True
        Me.cmdFinish.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdFinish.Location = New System.Drawing.Point(128, 83)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(179, 27)
        Me.cmdFinish.TabIndex = 4
        Me.cmdFinish.Text = "Save report settings"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(60, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 549
        Me.LabelControl1.Text = "Orientation"
        '
        'txtPaperKind
        '
        Me.txtPaperKind.EditValue = ""
        Me.txtPaperKind.Location = New System.Drawing.Point(128, 36)
        Me.txtPaperKind.Name = "txtPaperKind"
        Me.txtPaperKind.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtPaperKind.Properties.Appearance.Options.UseFont = True
        Me.txtPaperKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPaperKind.Properties.Items.AddRange(New Object() {"Letter", "Legal", "Wide For Export"})
        Me.txtPaperKind.Properties.PopupSizeable = True
        Me.txtPaperKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPaperKind.Size = New System.Drawing.Size(138, 22)
        Me.txtPaperKind.TabIndex = 2
        Me.txtPaperKind.ToolTip = "Shortcut Key (F11)"
        '
        'ckorientation
        '
        Me.ckorientation.Location = New System.Drawing.Point(127, 60)
        Me.ckorientation.Name = "ckorientation"
        Me.ckorientation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ckorientation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckorientation.Properties.Appearance.Options.UseBackColor = True
        Me.ckorientation.Properties.Appearance.Options.UseFont = True
        Me.ckorientation.Properties.AutoHeight = False
        Me.ckorientation.Properties.Caption = "Landscape"
        Me.ckorientation.Size = New System.Drawing.Size(140, 19)
        Me.ckorientation.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(61, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 552
        Me.LabelControl2.Text = "Report Title"
        '
        'txtReportForm
        '
        Me.txtReportForm.EditValue = ""
        Me.txtReportForm.Location = New System.Drawing.Point(12, 150)
        Me.txtReportForm.Name = "txtReportForm"
        Me.txtReportForm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportForm.Properties.Appearance.Options.UseFont = True
        Me.txtReportForm.Size = New System.Drawing.Size(77, 20)
        Me.txtReportForm.TabIndex = 0
        Me.txtReportForm.Visible = False
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Location = New System.Drawing.Point(128, 11)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReportTitle.Properties.Appearance.Options.UseFont = True
        Me.txtReportTitle.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReportTitle.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtReportTitle.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReportTitle.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtReportTitle.Properties.AppearanceFocused.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReportTitle.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtReportTitle.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReportTitle.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtReportTitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReportTitle.Properties.CaseSensitiveSearch = True
        Me.txtReportTitle.Properties.HideSelection = False
        Me.txtReportTitle.Properties.ImmediatePopup = True
        Me.txtReportTitle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtReportTitle.Size = New System.Drawing.Size(303, 22)
        Me.txtReportTitle.TabIndex = 1
        '
        'frmReportSettings
        '
        Me.AcceptButton = Me.cmdFinish
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 121)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.reportid)
        Me.Controls.Add(Me.txtPaperKind)
        Me.Controls.Add(Me.ckorientation)
        Me.Controls.Add(Me.txtReportForm)
        Me.Controls.Add(Me.txtReportTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReportSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report printing Settings"
        CType(Me.reportid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaperKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckorientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPaperKind As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckorientation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReportForm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReportTitle As DevExpress.XtraEditors.ComboBoxEdit
End Class
