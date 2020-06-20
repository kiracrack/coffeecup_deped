<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilAdjustment
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
        Me.txtNewQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.txtOldQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtStock = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNewUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtOldUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtNewQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewQuantity
        '
        Me.txtNewQuantity.EditValue = "0"
        Me.txtNewQuantity.EnterMoveNextControl = True
        Me.txtNewQuantity.Location = New System.Drawing.Point(111, 114)
        Me.txtNewQuantity.Name = "txtNewQuantity"
        Me.txtNewQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtNewQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNewQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNewQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNewQuantity.Properties.Mask.EditMask = "n"
        Me.txtNewQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNewQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNewQuantity.Size = New System.Drawing.Size(91, 26)
        Me.txtNewQuantity.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(18, 117)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 20)
        Me.LabelControl3.TabIndex = 339
        Me.LabelControl3.Text = "Adj. Quantity"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(59, 178)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 15)
        Me.LabelControl7.TabIndex = 341
        Me.LabelControl7.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.EnterMoveNextControl = True
        Me.txtRemarks.Location = New System.Drawing.Point(111, 174)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(296, 53)
        Me.txtRemarks.TabIndex = 2
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(93, 307)
        Me.productid.Name = "productid"
        Me.productid.Properties.ReadOnly = True
        Me.productid.Properties.ValidateOnEnterKey = True
        Me.productid.Size = New System.Drawing.Size(77, 20)
        Me.productid.TabIndex = 534
        Me.productid.Visible = False
        '
        'txtOldQuantity
        '
        Me.txtOldQuantity.EditValue = ""
        Me.txtOldQuantity.EnterMoveNextControl = True
        Me.txtOldQuantity.Location = New System.Drawing.Point(173, 307)
        Me.txtOldQuantity.Name = "txtOldQuantity"
        Me.txtOldQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOldQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOldQuantity.Size = New System.Drawing.Size(77, 20)
        Me.txtOldQuantity.TabIndex = 535
        Me.txtOldQuantity.Visible = False
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(12, 307)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Properties.ValidateOnEnterKey = True
        Me.officeid.Size = New System.Drawing.Size(77, 20)
        Me.officeid.TabIndex = 536
        Me.officeid.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(54, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl1.TabIndex = 554
        Me.LabelControl1.Text = "Particular"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(111, 64)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(249, 22)
        Me.txtproduct.TabIndex = 553
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(25, 93)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(79, 13)
        Me.lblOffice.TabIndex = 556
        Me.lblOffice.Text = "Current Office"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(111, 89)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Properties.Appearance.Options.UseFont = True
        Me.txtStock.Properties.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(249, 22)
        Me.txtStock.TabIndex = 555
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(93, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(254, 13)
        Me.LabelControl8.TabIndex = 561
        Me.LabelControl8.Text = "This form is allow user to adjust current inventory"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(93, 19)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(118, 19)
        Me.LabelControl9.TabIndex = 560
        Me.LabelControl9.Text = "New Adjustment"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(91, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(248, 13)
        Me.LabelControl10.TabIndex = 559
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(205, 114)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(77, 26)
        Me.txtunit.TabIndex = 562
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(234, 232)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(173, 32)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Confirm Adjustment"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(55, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "Unit Cost"
        '
        'txtNewUnitCost
        '
        Me.txtNewUnitCost.EditValue = "0"
        Me.txtNewUnitCost.EnterMoveNextControl = True
        Me.txtNewUnitCost.Location = New System.Drawing.Point(111, 144)
        Me.txtNewUnitCost.Name = "txtNewUnitCost"
        Me.txtNewUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNewUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtNewUnitCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtNewUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNewUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNewUnitCost.Properties.Mask.EditMask = "n"
        Me.txtNewUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNewUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNewUnitCost.Size = New System.Drawing.Size(171, 26)
        Me.txtNewUnitCost.TabIndex = 1
        '
        'txtOldUnitCost
        '
        Me.txtOldUnitCost.EditValue = ""
        Me.txtOldUnitCost.EnterMoveNextControl = True
        Me.txtOldUnitCost.Location = New System.Drawing.Point(254, 307)
        Me.txtOldUnitCost.Name = "txtOldUnitCost"
        Me.txtOldUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOldUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOldUnitCost.Size = New System.Drawing.Size(77, 20)
        Me.txtOldUnitCost.TabIndex = 626
        Me.txtOldUnitCost.Visible = False
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(12, 283)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.document_delete_48
        Me.PanelControl1.Location = New System.Drawing.Point(21, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 558
        '
        'frmUtilAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 285)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtOldUnitCost)
        Me.Controls.Add(Me.txtNewUnitCost)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtOldQuantity)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtNewQuantity)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjustment Report"
        CType(Me.txtNewQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNewUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
End Class
