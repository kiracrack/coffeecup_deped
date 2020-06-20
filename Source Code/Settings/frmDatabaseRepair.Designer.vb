<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseRepair
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
        Me.cmdFinish = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReportForm = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.reportid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportid
        '
        Me.reportid.EditValue = ""
        Me.reportid.EnterMoveNextControl = True
        Me.reportid.Location = New System.Drawing.Point(51, 307)
        Me.reportid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.reportid.Name = "reportid"
        Me.reportid.Properties.ReadOnly = True
        Me.reportid.Properties.ValidateOnEnterKey = True
        Me.reportid.Size = New System.Drawing.Size(80, 20)
        Me.reportid.TabIndex = 543
        Me.reportid.Visible = False
        '
        'cmdFinish
        '
        Me.cmdFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdFinish.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdFinish.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdFinish.Appearance.Options.UseBackColor = True
        Me.cmdFinish.Appearance.Options.UseFont = True
        Me.cmdFinish.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdFinish.Location = New System.Drawing.Point(119, 67)
        Me.cmdFinish.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(161, 39)
        Me.cmdFinish.TabIndex = 4
        Me.cmdFinish.Text = "Start Repair"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl34.Location = New System.Drawing.Point(108, 14)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(183, 17)
        Me.LabelControl34.TabIndex = 551
        Me.LabelControl34.Text = "Select database to start repair.."
        '
        'txtReportForm
        '
        Me.txtReportForm.EditValue = ""
        Me.txtReportForm.Location = New System.Drawing.Point(69, 35)
        Me.txtReportForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReportForm.Name = "txtReportForm"
        Me.txtReportForm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportForm.Properties.Appearance.Options.UseFont = True
        Me.txtReportForm.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtReportForm.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtReportForm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReportForm.Properties.PopupSizeable = True
        Me.txtReportForm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtReportForm.Size = New System.Drawing.Size(261, 28)
        Me.txtReportForm.TabIndex = 0
        '
        'frmDatabaseRepair
        '
        Me.AcceptButton = Me.cmdFinish
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 119)
        Me.Controls.Add(Me.LabelControl34)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.reportid)
        Me.Controls.Add(Me.txtReportForm)
        Me.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Repair"
        CType(Me.reportid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReportForm As DevExpress.XtraEditors.ComboBoxEdit
End Class
