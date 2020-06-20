<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifiedPurchaseOrder
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
        Me.txtVerifiedAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCharges = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVat = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtVerifiedAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCharges.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(308, 199)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(159, 30)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "Verify purchase order"
        '
        'txtVerifiedAmount
        '
        Me.txtVerifiedAmount.EditValue = "0.00"
        Me.txtVerifiedAmount.Location = New System.Drawing.Point(308, 169)
        Me.txtVerifiedAmount.Name = "txtVerifiedAmount"
        Me.txtVerifiedAmount.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtVerifiedAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtVerifiedAmount.Properties.Appearance.Options.UseBackColor = True
        Me.txtVerifiedAmount.Properties.Appearance.Options.UseFont = True
        Me.txtVerifiedAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVerifiedAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVerifiedAmount.Properties.Mask.EditMask = "n"
        Me.txtVerifiedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVerifiedAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVerifiedAmount.Properties.ReadOnly = True
        Me.txtVerifiedAmount.Size = New System.Drawing.Size(159, 26)
        Me.txtVerifiedAmount.TabIndex = 100
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(222, 172)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl4.TabIndex = 633
        Me.LabelControl4.Text = "Verified Total"
        '
        'txtCharges
        '
        Me.txtCharges.EditValue = "0.00"
        Me.txtCharges.Location = New System.Drawing.Point(308, 119)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtCharges.Properties.Appearance.Options.UseFont = True
        Me.txtCharges.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCharges.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCharges.Properties.Mask.EditMask = "n"
        Me.txtCharges.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCharges.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCharges.Size = New System.Drawing.Size(159, 22)
        Me.txtCharges.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(259, 122)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 15)
        Me.LabelControl1.TabIndex = 635
        Me.LabelControl1.Text = "Charges"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(255, 147)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 15)
        Me.LabelControl2.TabIndex = 637
        Me.LabelControl2.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.EditValue = "0.00"
        Me.txtDiscount.Location = New System.Drawing.Point(308, 144)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDiscount.Properties.Appearance.Options.UseFont = True
        Me.txtDiscount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDiscount.Properties.Mask.EditMask = "n"
        Me.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount.Size = New System.Drawing.Size(159, 22)
        Me.txtDiscount.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(228, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl3.TabIndex = 639
        Me.LabelControl3.Text = "Total Amount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.EditValue = "0.00"
        Me.txtTotalAmount.Location = New System.Drawing.Point(308, 68)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Properties.Appearance.Options.UseFont = True
        Me.txtTotalAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAmount.Properties.Mask.EditMask = "n"
        Me.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalAmount.Properties.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(159, 22)
        Me.txtTotalAmount.TabIndex = 638
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = ""
        Me.txtSupplier.Location = New System.Drawing.Point(130, 13)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSupplier.Properties.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(337, 26)
        Me.txtSupplier.TabIndex = 640
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(68, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 20)
        Me.LabelControl5.TabIndex = 641
        Me.LabelControl5.Text = "Supplier"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.EditValue = ""
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(308, 43)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtInvoiceNumber.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvoiceNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtInvoiceNumber.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(159, 22)
        Me.txtInvoiceNumber.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(215, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(86, 15)
        Me.LabelControl6.TabIndex = 643
        Me.LabelControl6.Text = "Invoice Number"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl7.Location = New System.Drawing.Point(280, 96)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(22, 15)
        Me.LabelControl7.TabIndex = 645
        Me.LabelControl7.Text = "VAT"
        '
        'txtVat
        '
        Me.txtVat.EditValue = "0.00"
        Me.txtVat.Location = New System.Drawing.Point(308, 93)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtVat.Properties.Appearance.Options.UseFont = True
        Me.txtVat.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVat.Properties.Mask.EditMask = "n"
        Me.txtVat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVat.Size = New System.Drawing.Size(159, 22)
        Me.txtVat.TabIndex = 1
        '
        'frmVerifiedPurchaseOrder
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 246)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtVerifiedAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerifiedPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify Purchase Order"
        CType(Me.txtVerifiedAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCharges.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtVerifiedAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCharges As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVat As DevExpress.XtraEditors.TextEdit
End Class
