<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifiedVoucherConfirmation
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
        Me.dueid = New DevExpress.XtraEditors.TextEdit()
        Me.txtReceiverName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiverName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(122, 60)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(150, 30)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Confirm Cleared"
        '
        'dueid
        '
        Me.dueid.Location = New System.Drawing.Point(535, 98)
        Me.dueid.Name = "dueid"
        Me.dueid.Properties.Appearance.Options.UseTextOptions = True
        Me.dueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dueid.Properties.ReadOnly = True
        Me.dueid.Size = New System.Drawing.Size(62, 20)
        Me.dueid.TabIndex = 581
        '
        'txtReceiverName
        '
        Me.txtReceiverName.Location = New System.Drawing.Point(53, 34)
        Me.txtReceiverName.Name = "txtReceiverName"
        Me.txtReceiverName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtReceiverName.Properties.Appearance.Options.UseFont = True
        Me.txtReceiverName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtReceiverName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtReceiverName.Size = New System.Drawing.Size(288, 20)
        Me.txtReceiverName.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(123, 14)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(149, 14)
        Me.LabelControl4.TabIndex = 717
        Me.LabelControl4.Text = "Please enter receiver name"
        '
        'frmVerifiedVoucherConfirmation
        '
        Me.AcceptButton = Me.cmdOk
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 107)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtReceiverName)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dueid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerifiedVoucherConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Confirmation"
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiverName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReceiverName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
