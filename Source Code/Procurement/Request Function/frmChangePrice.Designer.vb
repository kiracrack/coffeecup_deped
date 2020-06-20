<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePrice
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
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0.00"
        Me.txtUnitCost.Location = New System.Drawing.Point(165, 53)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(169, 26)
        Me.txtUnitCost.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(96, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 20)
        Me.LabelControl1.TabIndex = 386
        Me.LabelControl1.Text = "Unit Price"
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(203, 85)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(131, 30)
        Me.cmdaction.TabIndex = 2
        Me.cmdaction.Text = "Update"
        '
        'trnid
        '
        Me.trnid.Location = New System.Drawing.Point(41, 159)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(62, 20)
        Me.trnid.TabIndex = 562
        Me.trnid.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(103, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 20)
        Me.LabelControl2.TabIndex = 566
        Me.LabelControl2.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = "0.00"
        Me.txtQuantity.Location = New System.Drawing.Point(165, 24)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQuantity.Properties.Mask.EditMask = "n"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(169, 26)
        Me.txtQuantity.TabIndex = 0
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(109, 159)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(62, 20)
        Me.pid.TabIndex = 567
        Me.pid.Visible = False
        '
        'frmChangePrice
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 129)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUnitCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Item"
        Me.TopMost = True
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
End Class
