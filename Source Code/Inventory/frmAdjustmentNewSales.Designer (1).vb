<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustmentNewSales
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
        Me.txtquan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.currquant = New DevExpress.XtraEditors.TextEdit()
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
        Me.txtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.currPruchasePrice = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.txtSellingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.currsellcost = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currquant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currPruchasePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currsellcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtquan
        '
        Me.txtquan.EditValue = "0"
        Me.txtquan.EnterMoveNextControl = True
        Me.txtquan.Location = New System.Drawing.Point(95, 111)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtquan.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtquan.Properties.Appearance.Options.UseBackColor = True
        Me.txtquan.Properties.Appearance.Options.UseFont = True
        Me.txtquan.Properties.Appearance.Options.UseForeColor = True
        Me.txtquan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtquan.Properties.Mask.EditMask = "n"
        Me.txtquan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtquan.Size = New System.Drawing.Size(155, 26)
        Me.txtquan.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 339
        Me.LabelControl3.Text = "Adj. Quantity"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(48, 202)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl7.TabIndex = 341
        Me.LabelControl7.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.EnterMoveNextControl = True
        Me.txtRemarks.Location = New System.Drawing.Point(95, 199)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(310, 53)
        Me.txtRemarks.TabIndex = 3
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(93, 370)
        Me.productid.Name = "productid"
        Me.productid.Properties.ReadOnly = True
        Me.productid.Properties.ValidateOnEnterKey = True
        Me.productid.Size = New System.Drawing.Size(77, 20)
        Me.productid.TabIndex = 534
        Me.productid.Visible = False
        '
        'currquant
        '
        Me.currquant.EditValue = ""
        Me.currquant.EnterMoveNextControl = True
        Me.currquant.Location = New System.Drawing.Point(173, 370)
        Me.currquant.Name = "currquant"
        Me.currquant.Properties.Appearance.Options.UseTextOptions = True
        Me.currquant.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.currquant.Size = New System.Drawing.Size(77, 20)
        Me.currquant.TabIndex = 535
        Me.currquant.Visible = False
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(12, 370)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Properties.ValidateOnEnterKey = True
        Me.officeid.Size = New System.Drawing.Size(77, 20)
        Me.officeid.TabIndex = 536
        Me.officeid.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(34, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl1.TabIndex = 554
        Me.LabelControl1.Text = "Particular"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(95, 59)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(310, 26)
        Me.txtproduct.TabIndex = 553
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(10, 91)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(79, 13)
        Me.lblOffice.TabIndex = 556
        Me.lblOffice.Text = "Current Office"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(95, 88)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Properties.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(249, 20)
        Me.txtStock.TabIndex = 555
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(238, 13)
        Me.LabelControl8.TabIndex = 561
        Me.LabelControl8.Text = "This form is allow user to adjust current inventory"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(118, 19)
        Me.LabelControl9.TabIndex = 560
        Me.LabelControl9.Text = "New Adjustment"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(10, 40)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(248, 13)
        Me.LabelControl10.TabIndex = 559
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(254, 111)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(90, 26)
        Me.txtunit.TabIndex = 562
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(232, 258)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(173, 32)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Confirm Adjustment"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 148)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "Purchased Cost"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.EditValue = "0"
        Me.txtUnitCost.EnterMoveNextControl = True
        Me.txtUnitCost.Location = New System.Drawing.Point(95, 140)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtUnitCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnitCost.Properties.Mask.EditMask = "n"
        Me.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUnitCost.Size = New System.Drawing.Size(155, 26)
        Me.txtUnitCost.TabIndex = 1
        '
        'currPruchasePrice
        '
        Me.currPruchasePrice.EditValue = ""
        Me.currPruchasePrice.EnterMoveNextControl = True
        Me.currPruchasePrice.Location = New System.Drawing.Point(254, 370)
        Me.currPruchasePrice.Name = "currPruchasePrice"
        Me.currPruchasePrice.Properties.Appearance.Options.UseTextOptions = True
        Me.currPruchasePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.currPruchasePrice.Size = New System.Drawing.Size(77, 20)
        Me.currPruchasePrice.TabIndex = 626
        Me.currPruchasePrice.Visible = False
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(12, 344)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'txtSellingCost
        '
        Me.txtSellingCost.EditValue = "0"
        Me.txtSellingCost.EnterMoveNextControl = True
        Me.txtSellingCost.Location = New System.Drawing.Point(95, 169)
        Me.txtSellingCost.Name = "txtSellingCost"
        Me.txtSellingCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSellingCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSellingCost.Properties.Appearance.Options.UseFont = True
        Me.txtSellingCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtSellingCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSellingCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSellingCost.Properties.Mask.EditMask = "n"
        Me.txtSellingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSellingCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSellingCost.Size = New System.Drawing.Size(155, 26)
        Me.txtSellingCost.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(34, 177)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 629
        Me.LabelControl4.Text = "Selling Cost"
        '
        'currsellcost
        '
        Me.currsellcost.EditValue = ""
        Me.currsellcost.EnterMoveNextControl = True
        Me.currsellcost.Location = New System.Drawing.Point(254, 396)
        Me.currsellcost.Name = "currsellcost"
        Me.currsellcost.Properties.Appearance.Options.UseTextOptions = True
        Me.currsellcost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.currsellcost.Size = New System.Drawing.Size(77, 20)
        Me.currsellcost.TabIndex = 630
        Me.currsellcost.Visible = False
        '
        'frmAdjustmentNewSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 302)
        Me.Controls.Add(Me.currsellcost)
        Me.Controls.Add(Me.txtSellingCost)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.currPruchasePrice)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.currquant)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjustmentNewSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Adjustment"
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currquant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currPruchasePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currsellcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents currquant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents currPruchasePrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSellingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents currsellcost As DevExpress.XtraEditors.TextEdit
End Class
