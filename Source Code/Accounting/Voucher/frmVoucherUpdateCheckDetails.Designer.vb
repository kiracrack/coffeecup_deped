<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherUpdateCheckDetails
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCheckPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCheckAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClaimant = New DevExpress.XtraEditors.TextEdit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClaimant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Appearance.Options.UseForeColor = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(230, 138)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 30)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Confirm Save"
        '
        'voucherno
        '
        Me.voucherno.Location = New System.Drawing.Point(75, 212)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(55, 20)
        Me.voucherno.TabIndex = 590
        Me.voucherno.Visible = False
        '
        'itemcode
        '
        Me.itemcode.EnterMoveNextControl = True
        Me.itemcode.Location = New System.Drawing.Point(136, 212)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Size = New System.Drawing.Size(50, 20)
        Me.itemcode.TabIndex = 746
        Me.itemcode.Visible = False
        '
        'cmdCheckPrint
        '
        Me.cmdCheckPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdCheckPrint.Appearance.Options.UseFont = True
        Me.cmdCheckPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.cmdCheckPrint.Location = New System.Drawing.Point(72, 137)
        Me.cmdCheckPrint.Name = "cmdCheckPrint"
        Me.cmdCheckPrint.Size = New System.Drawing.Size(153, 30)
        Me.cmdCheckPrint.TabIndex = 753
        Me.cmdCheckPrint.Text = "Print Check"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(88, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 15)
        Me.LabelControl5.TabIndex = 752
        Me.LabelControl5.Text = "Check Date"
        '
        'txtCheckDate
        '
        Me.txtCheckDate.EditValue = New Date(CType(0, Long))
        Me.txtCheckDate.EnterMoveNextControl = True
        Me.txtCheckDate.Location = New System.Drawing.Point(156, 71)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtCheckDate.Properties.Appearance.Options.UseFont = True
        Me.txtCheckDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCheckDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtCheckDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckDate.Size = New System.Drawing.Size(245, 26)
        Me.txtCheckDate.TabIndex = 748
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.EditValue = "0.00"
        Me.txtCheckAmount.Location = New System.Drawing.Point(156, 100)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckAmount.Properties.Appearance.Options.UseFont = True
        Me.txtCheckAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCheckAmount.Properties.Mask.EditMask = "n"
        Me.txtCheckAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckAmount.Properties.ReadOnly = True
        Me.txtCheckAmount.Size = New System.Drawing.Size(154, 26)
        Me.txtCheckAmount.TabIndex = 749
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(104, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl4.TabIndex = 751
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(93, 49)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 15)
        Me.LabelControl6.TabIndex = 750
        Me.LabelControl6.Text = "Check No."
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.EditValue = ""
        Me.txtCheckNumber.Location = New System.Drawing.Point(156, 44)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNumber.Properties.Appearance.Options.UseFont = True
        Me.txtCheckNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCheckNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckNumber.Size = New System.Drawing.Size(153, 24)
        Me.txtCheckNumber.TabIndex = 747
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(51, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 15)
        Me.LabelControl1.TabIndex = 755
        Me.LabelControl1.Text = "Name of Claimant"
        '
        'txtClaimant
        '
        Me.txtClaimant.EditValue = ""
        Me.txtClaimant.Location = New System.Drawing.Point(156, 16)
        Me.txtClaimant.Name = "txtClaimant"
        Me.txtClaimant.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimant.Properties.Appearance.Options.UseFont = True
        Me.txtClaimant.Properties.Appearance.Options.UseTextOptions = True
        Me.txtClaimant.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtClaimant.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClaimant.Properties.ReadOnly = True
        Me.txtClaimant.Size = New System.Drawing.Size(245, 24)
        Me.txtClaimant.TabIndex = 754
        '
        'frmVoucherUpdateCheckDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 187)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtClaimant)
        Me.Controls.Add(Me.cmdCheckPrint)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtCheckDate)
        Me.Controls.Add(Me.txtCheckAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtCheckNumber)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherUpdateCheckDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Check Details"
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClaimant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCheckPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCheckAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClaimant As DevExpress.XtraEditors.TextEdit
End Class
