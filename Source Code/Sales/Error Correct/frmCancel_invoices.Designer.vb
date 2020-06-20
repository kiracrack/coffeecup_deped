<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancel_invoices
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
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.invoiceno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentClient = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCashier = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(275, 107)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(155, 30)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "Confirm Cancel"
        '
        'cifid
        '
        Me.cifid.Location = New System.Drawing.Point(459, 84)
        Me.cifid.Name = "cifid"
        Me.cifid.Properties.Appearance.Options.UseTextOptions = True
        Me.cifid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cifid.Properties.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(53, 20)
        Me.cifid.TabIndex = 581
        Me.cifid.Visible = False
        '
        'invoiceno
        '
        Me.invoiceno.EnterMoveNextControl = True
        Me.invoiceno.Location = New System.Drawing.Point(160, 15)
        Me.invoiceno.Name = "invoiceno"
        Me.invoiceno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.invoiceno.Properties.Appearance.Options.UseForeColor = True
        Me.invoiceno.Properties.Appearance.Options.UseTextOptions = True
        Me.invoiceno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.invoiceno.Size = New System.Drawing.Size(105, 20)
        Me.invoiceno.TabIndex = 0
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(66, 18)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl26.TabIndex = 588
        Me.LabelControl26.Text = "Enter Ref Number"
        '
        'txtCurrentClient
        '
        Me.txtCurrentClient.EnterMoveNextControl = True
        Me.txtCurrentClient.Location = New System.Drawing.Point(160, 38)
        Me.txtCurrentClient.Name = "txtCurrentClient"
        Me.txtCurrentClient.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentClient.Properties.Appearance.Options.UseForeColor = True
        Me.txtCurrentClient.Properties.ReadOnly = True
        Me.txtCurrentClient.Size = New System.Drawing.Size(270, 20)
        Me.txtCurrentClient.TabIndex = 589
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(85, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 590
        Me.LabelControl1.Text = "Current Client"
        '
        'batchcode
        '
        Me.batchcode.EnterMoveNextControl = True
        Me.batchcode.Location = New System.Drawing.Point(459, 7)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Properties.Appearance.Options.UseForeColor = True
        Me.batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.batchcode.Size = New System.Drawing.Size(43, 20)
        Me.batchcode.TabIndex = 591
        Me.batchcode.Visible = False
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(459, 58)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCashier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCashier.Properties.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(53, 20)
        Me.txtCashier.TabIndex = 594
        Me.txtCashier.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.EnterMoveNextControl = True
        Me.txtAmount.Location = New System.Drawing.Point(267, 15)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Properties.Appearance.Options.UseForeColor = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(163, 20)
        Me.txtAmount.TabIndex = 595
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(160, 61)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(270, 40)
        Me.txtRemarks.TabIndex = 596
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(111, 63)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 597
        Me.LabelControl4.Text = "Remarks"
        '
        'frmCancel_invoices
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 147)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.txtCurrentClient)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.invoiceno)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cifid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancel_invoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Invoice"
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents invoiceno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentClient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCashier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
