<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPayrollResigned
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
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEffectivityDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.txtEffectivityDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEffectivityDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(19, 25)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(101, 20)
        Me.LabelControl13.TabIndex = 710
        Me.LabelControl13.Text = "Effectivity Date"
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
        Me.cmdApprove.Location = New System.Drawing.Point(243, 53)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.Size = New System.Drawing.Size(122, 32)
        Me.cmdApprove.TabIndex = 711
        Me.cmdApprove.Text = "Confirm"
        '
        'txtEffectivityDate
        '
        Me.txtEffectivityDate.EditValue = New Date(2016, 6, 25, 20, 51, 24, 0)
        Me.txtEffectivityDate.Location = New System.Drawing.Point(130, 23)
        Me.txtEffectivityDate.Name = "txtEffectivityDate"
        Me.txtEffectivityDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtEffectivityDate.Properties.Appearance.Options.UseFont = True
        Me.txtEffectivityDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEffectivityDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtEffectivityDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtEffectivityDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEffectivityDate.Size = New System.Drawing.Size(235, 26)
        Me.txtEffectivityDate.TabIndex = 768
        '
        'frmSetPayrollResigned
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 103)
        Me.Controls.Add(Me.txtEffectivityDate)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.LabelControl13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetPayrollResigned"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Resigned Employees"
        CType(Me.txtEffectivityDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEffectivityDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEffectivityDate As DevExpress.XtraEditors.DateEdit
End Class
