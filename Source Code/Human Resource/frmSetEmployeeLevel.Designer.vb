<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetEmployeeLevel
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
        Me.positioncode = New DevExpress.XtraEditors.TextEdit()
        Me.txtLevel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdApprove = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.positioncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'positioncode
        '
        Me.positioncode.Location = New System.Drawing.Point(135, 53)
        Me.positioncode.Name = "positioncode"
        Me.positioncode.Properties.Appearance.Options.UseTextOptions = True
        Me.positioncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.positioncode.Properties.ReadOnly = True
        Me.positioncode.Size = New System.Drawing.Size(53, 20)
        Me.positioncode.TabIndex = 580
        Me.positioncode.Visible = False
        '
        'txtLevel
        '
        Me.txtLevel.EditValue = ""
        Me.txtLevel.Location = New System.Drawing.Point(135, 21)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Properties.Appearance.Options.UseFont = True
        Me.txtLevel.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtLevel.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLevel.Properties.PopupSizeable = True
        Me.txtLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtLevel.Size = New System.Drawing.Size(256, 26)
        Me.txtLevel.TabIndex = 709
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(51, 24)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(78, 20)
        Me.LabelControl13.TabIndex = 710
        Me.LabelControl13.Text = "Select Level"
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
        'frmSetEmployeeLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 99)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.positioncode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetEmployeeLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Employee Level"
        CType(Me.positioncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents positioncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLevel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdApprove As DevExpress.XtraEditors.SimpleButton
End Class
