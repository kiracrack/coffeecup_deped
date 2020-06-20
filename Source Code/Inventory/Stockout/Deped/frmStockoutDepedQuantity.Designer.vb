<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutDepedQuantity
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
        Me.txtquantity = New DevExpress.XtraEditors.TextEdit()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAction = New DevExpress.XtraEditors.SimpleButton()
        Me.ckAllocated = New DevExpress.XtraEditors.CheckEdit()
        Me.alllocatedofficeid = New DevExpress.XtraEditors.TextEdit()
        Me.stockid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.purchasedprice = New DevExpress.XtraEditors.TextEdit()
        Me.batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAvailableQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateStockout = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllocated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alllocatedofficeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchasedprice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStockout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtquantity
        '
        Me.txtquantity.EditValue = "0"
        Me.txtquantity.Location = New System.Drawing.Point(300, 68)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtquantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtquantity.Properties.Appearance.Options.UseFont = True
        Me.txtquantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtquantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquantity.Size = New System.Drawing.Size(116, 26)
        Me.txtquantity.TabIndex = 0
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(139, 13)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(277, 22)
        Me.txtproduct.TabIndex = 557
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(243, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl4.TabIndex = 556
        Me.LabelControl4.Text = "Item Unit"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(202, 71)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl6.TabIndex = 555
        Me.LabelControl6.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(300, 98)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(116, 22)
        Me.txtunit.TabIndex = 554
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(83, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 558
        Me.LabelControl1.Text = "Particular"
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(18, 351)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.officeid.Size = New System.Drawing.Size(41, 20)
        Me.officeid.TabIndex = 563
        Me.officeid.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(85, 180)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl11.TabIndex = 575
        Me.LabelControl11.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(137, 178)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(277, 45)
        Me.txtRemarks.TabIndex = 3
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(65, 351)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.catid.Size = New System.Drawing.Size(41, 20)
        Me.catid.TabIndex = 580
        Me.catid.Visible = False
        '
        'cmdAction
        '
        Me.cmdAction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdAction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAction.Appearance.Options.UseBackColor = True
        Me.cmdAction.Appearance.Options.UseFont = True
        Me.cmdAction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAction.Location = New System.Drawing.Point(247, 227)
        Me.cmdAction.Name = "cmdAction"
        Me.cmdAction.Size = New System.Drawing.Size(167, 32)
        Me.cmdAction.TabIndex = 4
        Me.cmdAction.Text = "Confirm"
        '
        'ckAllocated
        '
        Me.ckAllocated.Location = New System.Drawing.Point(137, 157)
        Me.ckAllocated.Name = "ckAllocated"
        Me.ckAllocated.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllocated.Properties.Appearance.Options.UseFont = True
        Me.ckAllocated.Properties.Caption = "Allocated Stockout"
        Me.ckAllocated.Size = New System.Drawing.Size(279, 19)
        Me.ckAllocated.TabIndex = 604
        '
        'alllocatedofficeid
        '
        Me.alllocatedofficeid.EditValue = ""
        Me.alllocatedofficeid.EnterMoveNextControl = True
        Me.alllocatedofficeid.Location = New System.Drawing.Point(89, 325)
        Me.alllocatedofficeid.Name = "alllocatedofficeid"
        Me.alllocatedofficeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alllocatedofficeid.Properties.Appearance.Options.UseFont = True
        Me.alllocatedofficeid.Properties.Appearance.Options.UseTextOptions = True
        Me.alllocatedofficeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.alllocatedofficeid.Size = New System.Drawing.Size(41, 20)
        Me.alllocatedofficeid.TabIndex = 607
        Me.alllocatedofficeid.Visible = False
        '
        'stockid
        '
        Me.stockid.EditValue = ""
        Me.stockid.EnterMoveNextControl = True
        Me.stockid.Location = New System.Drawing.Point(110, 382)
        Me.stockid.Name = "stockid"
        Me.stockid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockid.Properties.Appearance.Options.UseFont = True
        Me.stockid.Properties.Appearance.Options.UseTextOptions = True
        Me.stockid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.stockid.Size = New System.Drawing.Size(41, 20)
        Me.stockid.TabIndex = 608
        Me.stockid.Visible = False
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(63, 382)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.productid.Size = New System.Drawing.Size(41, 20)
        Me.productid.TabIndex = 609
        Me.productid.Visible = False
        '
        'purchasedprice
        '
        Me.purchasedprice.EditValue = ""
        Me.purchasedprice.EnterMoveNextControl = True
        Me.purchasedprice.Location = New System.Drawing.Point(29, 325)
        Me.purchasedprice.Name = "purchasedprice"
        Me.purchasedprice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasedprice.Properties.Appearance.Options.UseFont = True
        Me.purchasedprice.Properties.Appearance.Options.UseTextOptions = True
        Me.purchasedprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.purchasedprice.Size = New System.Drawing.Size(41, 20)
        Me.purchasedprice.TabIndex = 610
        Me.purchasedprice.Visible = False
        '
        'batchcode
        '
        Me.batchcode.EditValue = ""
        Me.batchcode.EnterMoveNextControl = True
        Me.batchcode.Location = New System.Drawing.Point(18, 408)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchcode.Properties.Appearance.Options.UseFont = True
        Me.batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.batchcode.Size = New System.Drawing.Size(41, 20)
        Me.batchcode.TabIndex = 611
        Me.batchcode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(180, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 19)
        Me.LabelControl2.TabIndex = 613
        Me.LabelControl2.Text = "Available Quantity"
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.EditValue = "0"
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(300, 39)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvailableQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAvailableQuantity.Properties.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(116, 26)
        Me.txtAvailableQuantity.TabIndex = 612
        '
        'txtDateStockout
        '
        Me.txtDateStockout.EditValue = New Date(CType(0, Long))
        Me.txtDateStockout.EnterMoveNextControl = True
        Me.txtDateStockout.Location = New System.Drawing.Point(267, 126)
        Me.txtDateStockout.Name = "txtDateStockout"
        Me.txtDateStockout.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateStockout.Properties.Appearance.Options.UseFont = True
        Me.txtDateStockout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateStockout.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateStockout.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateStockout.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateStockout.Size = New System.Drawing.Size(149, 20)
        Me.txtDateStockout.TabIndex = 614
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(188, 129)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 615
        Me.LabelControl3.Text = "Stockout Date"
        '
        'frmStockoutBatchQuantity
        '
        Me.AcceptButton = Me.cmdAction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 275)
        Me.Controls.Add(Me.txtDateStockout)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.purchasedprice)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.stockid)
        Me.Controls.Add(Me.alllocatedofficeid)
        Me.Controls.Add(Me.ckAllocated)
        Me.Controls.Add(Me.cmdAction)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtunit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockoutBatchQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Quantity"
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllocated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alllocatedofficeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchasedprice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStockout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckAllocated As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents alllocatedofficeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents purchasedprice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAvailableQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDateStockout As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
