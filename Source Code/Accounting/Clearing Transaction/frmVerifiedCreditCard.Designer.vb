<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifiedCreditCard
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
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotalCreditCardAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dueid = New DevExpress.XtraEditors.TextEdit()
        Me.txtrate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVerifiedAmount = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtTotalCreditCardAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVerifiedAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(167, 119)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(132, 30)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Verify"
        '
        'txtTotalCreditCardAmount
        '
        Me.txtTotalCreditCardAmount.EditValue = "0.00"
        Me.txtTotalCreditCardAmount.Location = New System.Drawing.Point(70, 33)
        Me.txtTotalCreditCardAmount.Name = "txtTotalCreditCardAmount"
        Me.txtTotalCreditCardAmount.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalCreditCardAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtTotalCreditCardAmount.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCreditCardAmount.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCreditCardAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCreditCardAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCreditCardAmount.Properties.Mask.EditMask = "n"
        Me.txtTotalCreditCardAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCreditCardAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCreditCardAmount.Size = New System.Drawing.Size(229, 24)
        Me.txtTotalCreditCardAmount.TabIndex = 100
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(88, 10)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(211, 17)
        Me.LabelControl4.TabIndex = 633
        Me.LabelControl4.Text = "Total Selected Credit Card Amount"
        '
        'dueid
        '
        Me.dueid.Location = New System.Drawing.Point(459, 85)
        Me.dueid.Name = "dueid"
        Me.dueid.Properties.Appearance.Options.UseTextOptions = True
        Me.dueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dueid.Properties.ReadOnly = True
        Me.dueid.Size = New System.Drawing.Size(53, 20)
        Me.dueid.TabIndex = 581
        '
        'txtrate
        '
        Me.txtrate.EditValue = "0.00"
        Me.txtrate.Location = New System.Drawing.Point(167, 62)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtrate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtrate.Properties.Mask.EditMask = "n"
        Me.txtrate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtrate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtrate.Size = New System.Drawing.Size(132, 24)
        Me.txtrate.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(90, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 635
        Me.LabelControl1.Text = "Deducted Rate"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(86, 94)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 637
        Me.LabelControl2.Text = "Verified Amount"
        '
        'txtVerifiedAmount
        '
        Me.txtVerifiedAmount.EditValue = "0.00"
        Me.txtVerifiedAmount.Location = New System.Drawing.Point(167, 89)
        Me.txtVerifiedAmount.Name = "txtVerifiedAmount"
        Me.txtVerifiedAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtVerifiedAmount.Properties.Appearance.Options.UseFont = True
        Me.txtVerifiedAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVerifiedAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVerifiedAmount.Properties.Mask.EditMask = "n"
        Me.txtVerifiedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVerifiedAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVerifiedAmount.Size = New System.Drawing.Size(132, 24)
        Me.txtVerifiedAmount.TabIndex = 1
        '
        'frmVerifiedCreditCard
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 161)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtVerifiedAmount)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.txtTotalCreditCardAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dueid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerifiedCreditCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify Credit Card"
        CType(Me.txtTotalCreditCardAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVerifiedAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalCreditCardAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVerifiedAmount As DevExpress.XtraEditors.TextEdit
End Class
