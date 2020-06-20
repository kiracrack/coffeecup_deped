<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPayrollShift
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
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtPosition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdApprove = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(135, 53)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(53, 20)
        Me.code.TabIndex = 580
        Me.code.Visible = False
        '
        'txtPosition
        '
        Me.txtPosition.EditValue = ""
        Me.txtPosition.Location = New System.Drawing.Point(135, 21)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Properties.Appearance.Options.UseFont = True
        Me.txtPosition.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtPosition.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPosition.Properties.PopupSizeable = True
        Me.txtPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPosition.Size = New System.Drawing.Size(256, 26)
        Me.txtPosition.TabIndex = 709
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(19, 24)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(110, 20)
        Me.LabelControl13.TabIndex = 710
        Me.LabelControl13.Text = "Select Shift Type"
        '
        'cmdApprove
        '
        Me.cmdApprove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdApprove.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdApprove.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmdApprove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdApprove.Appearance.Options.UseBackColor = True
        Me.cmdApprove.Appearance.Options.UseFont = True
        Me.cmdApprove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdApprove.Location = New System.Drawing.Point(269, 51)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.Size = New System.Drawing.Size(122, 32)
        Me.cmdApprove.TabIndex = 711
        Me.cmdApprove.Text = "Confirm"
        '
        'frmSetPayrollShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 99)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetPayrollShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Shift"
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPosition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdApprove As DevExpress.XtraEditors.SimpleButton
End Class
