<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuantitySelect
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
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtquan = New DevExpress.XtraEditors.TextEdit()
        Me.txttotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsti = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pid = New DevExpress.XtraEditors.TextEdit()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.proid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.tempCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ffecode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ckAllocated = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.txtInventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtVendor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_vendor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllocated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(228, 74)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 20)
        Me.LabelControl6.TabIndex = 382
        Me.LabelControl6.Text = "Quantity"
        '
        'txtquan
        '
        Me.txtquan.EditValue = "1"
        Me.txtquan.EnterMoveNextControl = True
        Me.txtquan.Location = New System.Drawing.Point(291, 71)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtquan.Properties.Appearance.Options.UseFont = True
        Me.txtquan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtquan.Properties.Mask.EditMask = "n"
        Me.txtquan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtquan.Size = New System.Drawing.Size(101, 26)
        Me.txtquan.TabIndex = 1
        '
        'txttotal
        '
        Me.txttotal.EditValue = "0.00"
        Me.txttotal.Location = New System.Drawing.Point(291, 129)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txttotal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txttotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Properties.Appearance.Options.UseBackColor = True
        Me.txttotal.Properties.Appearance.Options.UseFont = True
        Me.txttotal.Properties.Appearance.Options.UseForeColor = True
        Me.txttotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txttotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttotal.Properties.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(215, 26)
        Me.txttotal.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(221, 132)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 20)
        Me.LabelControl2.TabIndex = 387
        Me.LabelControl2.Text = "Sub Total"
        '
        'txtsti
        '
        Me.txtsti.EditValue = "0.00"
        Me.txtsti.Location = New System.Drawing.Point(291, 100)
        Me.txtsti.Name = "txtsti"
        Me.txtsti.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtsti.Properties.Appearance.Options.UseFont = True
        Me.txtsti.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsti.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtsti.Properties.Mask.EditMask = "n"
        Me.txtsti.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtsti.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtsti.Size = New System.Drawing.Size(215, 26)
        Me.txtsti.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(221, 103)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 20)
        Me.LabelControl1.TabIndex = 386
        Me.LabelControl1.Text = "Unit Price"
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(230, 486)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Appearance.Options.UseTextOptions = True
        Me.pid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pid.Size = New System.Drawing.Size(78, 20)
        Me.pid.TabIndex = 513
        '
        'vendorid
        '
        Me.vendorid.EditValue = ""
        Me.vendorid.EnterMoveNextControl = True
        Me.vendorid.Location = New System.Drawing.Point(398, 486)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.vendorid.Properties.Appearance.Options.UseFont = True
        Me.vendorid.Properties.ReadOnly = True
        Me.vendorid.Properties.ValidateOnEnterKey = True
        Me.vendorid.Size = New System.Drawing.Size(77, 20)
        Me.vendorid.TabIndex = 543
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(314, 486)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(77, 20)
        Me.id.TabIndex = 539
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(146, 512)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(78, 20)
        Me.catid.TabIndex = 541
        '
        'proid
        '
        Me.proid.EnterMoveNextControl = True
        Me.proid.Location = New System.Drawing.Point(147, 486)
        Me.proid.Name = "proid"
        Me.proid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.proid.Properties.Appearance.Options.UseFont = True
        Me.proid.Size = New System.Drawing.Size(77, 20)
        Me.proid.TabIndex = 540
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(314, 512)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(77, 20)
        Me.mode.TabIndex = 544
        '
        'trnid
        '
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(397, 512)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 545
        '
        'tempCost
        '
        Me.tempCost.EditValue = ""
        Me.tempCost.Location = New System.Drawing.Point(230, 512)
        Me.tempCost.Name = "tempCost"
        Me.tempCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tempCost.Properties.Appearance.Options.UseFont = True
        Me.tempCost.Properties.Appearance.Options.UseTextOptions = True
        Me.tempCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tempCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tempCost.Size = New System.Drawing.Size(78, 20)
        Me.tempCost.TabIndex = 550
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(163, 15)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(343, 26)
        Me.txtproduct.TabIndex = 551
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(106, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl3.TabIndex = 552
        Me.LabelControl3.Text = "Particular"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(163, 208)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Size = New System.Drawing.Size(343, 57)
        Me.txtremarks.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(67, 210)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl5.TabIndex = 387
        Me.LabelControl5.Text = "Remarks/Purpose"
        '
        'ffecode
        '
        Me.ffecode.Location = New System.Drawing.Point(329, 460)
        Me.ffecode.Name = "ffecode"
        Me.ffecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ffecode.Properties.Appearance.Options.UseFont = True
        Me.ffecode.Properties.ReadOnly = True
        Me.ffecode.Size = New System.Drawing.Size(62, 20)
        Me.ffecode.TabIndex = 562
        Me.ffecode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(47, 189)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl4.TabIndex = 561
        Me.LabelControl4.Text = "Select CFFE Inventory"
        '
        'ckAllocated
        '
        Me.ckAllocated.Location = New System.Drawing.Point(162, 164)
        Me.ckAllocated.Name = "ckAllocated"
        Me.ckAllocated.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckAllocated.Properties.Appearance.Options.UseFont = True
        Me.ckAllocated.Properties.Caption = "Allocate FFE Expense "
        Me.ckAllocated.Size = New System.Drawing.Size(263, 19)
        Me.ckAllocated.TabIndex = 559
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
        Me.cmdaction.Location = New System.Drawing.Point(163, 271)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(199, 30)
        Me.cmdaction.TabIndex = 558
        Me.cmdaction.Text = "Confirm Add to Current Request"
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(397, 460)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(77, 20)
        Me.officeid.TabIndex = 553
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(395, 71)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtunit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(111, 26)
        Me.txtunit.TabIndex = 100
        '
        'txtInventory
        '
        Me.txtInventory.EditValue = ""
        Me.txtInventory.Location = New System.Drawing.Point(163, 185)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInventory.Properties.Appearance.Options.UseFont = True
        Me.txtInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtInventory.Properties.DisplayMember = "Select Item"
        Me.txtInventory.Properties.NullText = ""
        Me.txtInventory.Properties.ReadOnly = True
        Me.txtInventory.Properties.ValueMember = "Select Item"
        Me.txtInventory.Properties.View = Me.g_product
        Me.txtInventory.Size = New System.Drawing.Size(343, 20)
        Me.txtInventory.TabIndex = 560
        '
        'g_product
        '
        Me.g_product.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_product.Name = "g_product"
        Me.g_product.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_product.OptionsView.ShowGroupPanel = False
        '
        'txtVendor
        '
        Me.txtVendor.EditValue = ""
        Me.txtVendor.Location = New System.Drawing.Point(163, 45)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendor.Properties.Appearance.Options.UseFont = True
        Me.txtVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVendor.Properties.DisplayMember = "Vendor/Supplier"
        Me.txtVendor.Properties.NullText = ""
        Me.txtVendor.Properties.ValueMember = "Vendor/Supplier"
        Me.txtVendor.Properties.View = Me.g_vendor
        Me.txtVendor.Size = New System.Drawing.Size(343, 22)
        Me.txtVendor.TabIndex = 0
        '
        'g_vendor
        '
        Me.g_vendor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_vendor.Name = "g_vendor"
        Me.g_vendor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_vendor.OptionsView.ShowGroupPanel = False
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(20, 48)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(137, 15)
        Me.HyperlinkLabelControl1.TabIndex = 563
        Me.HyperlinkLabelControl1.Text = "Select Supplier (Add New)"
        '
        'frmQuantitySelect
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 311)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.ffecode)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.ckAllocated)
        Me.Controls.Add(Me.txtInventory)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tempCost)
        Me.Controls.Add(Me.txtsti)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.proid)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtVendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuantitySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Supplier or Vendor"
        Me.TopMost = True
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllocated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_vendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents proid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tempCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckAllocated As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ffecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtVendor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_vendor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
End Class
