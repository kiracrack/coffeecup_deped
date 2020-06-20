<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectPurchaseOrderItemSelect
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
        Me.ponumber = New DevExpress.XtraEditors.TextEdit()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.proid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.tempCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtremarks = New DevExpress.XtraEditors.MemoEdit()
        Me.inventoryid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.txtItemname = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(269, 53)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 17)
        Me.LabelControl6.TabIndex = 382
        Me.LabelControl6.Text = "Quantity"
        '
        'txtquan
        '
        Me.txtquan.EditValue = "1"
        Me.txtquan.EnterMoveNextControl = True
        Me.txtquan.Location = New System.Drawing.Point(326, 50)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtquan.Properties.Appearance.Options.UseFont = True
        Me.txtquan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtquan.Properties.Mask.EditMask = "n"
        Me.txtquan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtquan.Size = New System.Drawing.Size(100, 24)
        Me.txtquan.TabIndex = 0
        '
        'txttotal
        '
        Me.txttotal.EditValue = "0.00"
        Me.txttotal.Location = New System.Drawing.Point(326, 102)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txttotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Properties.Appearance.Options.UseBackColor = True
        Me.txttotal.Properties.Appearance.Options.UseFont = True
        Me.txttotal.Properties.Appearance.Options.UseForeColor = True
        Me.txttotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txttotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttotal.Properties.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(182, 24)
        Me.txttotal.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(252, 105)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 18)
        Me.LabelControl2.TabIndex = 387
        Me.LabelControl2.Text = "Sub Total"
        '
        'txtsti
        '
        Me.txtsti.EditValue = "0.00"
        Me.txtsti.Location = New System.Drawing.Point(326, 76)
        Me.txtsti.Name = "txtsti"
        Me.txtsti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtsti.Properties.Appearance.Options.UseFont = True
        Me.txtsti.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsti.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtsti.Properties.Mask.EditMask = "n"
        Me.txtsti.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtsti.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtsti.Size = New System.Drawing.Size(182, 24)
        Me.txtsti.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(265, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 17)
        Me.LabelControl1.TabIndex = 386
        Me.LabelControl1.Text = "Unit Price"
        '
        'ponumber
        '
        Me.ponumber.Location = New System.Drawing.Point(248, 350)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.Properties.Appearance.Options.UseTextOptions = True
        Me.ponumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ponumber.Size = New System.Drawing.Size(78, 20)
        Me.ponumber.TabIndex = 513
        '
        'vendorid
        '
        Me.vendorid.EditValue = ""
        Me.vendorid.EnterMoveNextControl = True
        Me.vendorid.Location = New System.Drawing.Point(416, 350)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.ReadOnly = True
        Me.vendorid.Properties.ValidateOnEnterKey = True
        Me.vendorid.Size = New System.Drawing.Size(77, 20)
        Me.vendorid.TabIndex = 543
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(332, 350)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(77, 20)
        Me.id.TabIndex = 539
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(164, 376)
        Me.catid.Name = "catid"
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(78, 20)
        Me.catid.TabIndex = 541
        '
        'proid
        '
        Me.proid.EnterMoveNextControl = True
        Me.proid.Location = New System.Drawing.Point(165, 350)
        Me.proid.Name = "proid"
        Me.proid.Size = New System.Drawing.Size(77, 20)
        Me.proid.TabIndex = 540
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(332, 376)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(77, 20)
        Me.mode.TabIndex = 544
        '
        'trnid
        '
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(415, 376)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 545
        '
        'tempCost
        '
        Me.tempCost.EditValue = ""
        Me.tempCost.Location = New System.Drawing.Point(248, 376)
        Me.tempCost.Name = "tempCost"
        Me.tempCost.Properties.Appearance.Options.UseTextOptions = True
        Me.tempCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tempCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tempCost.Size = New System.Drawing.Size(78, 20)
        Me.tempCost.TabIndex = 550
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(128, 130)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtremarks.Properties.Appearance.Options.UseFont = True
        Me.txtremarks.Properties.NullText = "Remarks (Optional)"
        Me.txtremarks.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtremarks.Properties.ShowNullValuePromptWhenFocused = True
        Me.txtremarks.Size = New System.Drawing.Size(380, 51)
        Me.txtremarks.TabIndex = 4
        '
        'inventoryid
        '
        Me.inventoryid.Location = New System.Drawing.Point(97, 347)
        Me.inventoryid.Name = "inventoryid"
        Me.inventoryid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.inventoryid.Properties.Appearance.Options.UseFont = True
        Me.inventoryid.Properties.ReadOnly = True
        Me.inventoryid.Size = New System.Drawing.Size(62, 24)
        Me.inventoryid.TabIndex = 562
        Me.inventoryid.Visible = False
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
        Me.cmdaction.Location = New System.Drawing.Point(232, 185)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(276, 30)
        Me.cmdaction.TabIndex = 558
        Me.cmdaction.Text = "Confirm Add to Current Purchase Order"
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(415, 324)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(77, 20)
        Me.officeid.TabIndex = 553
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(428, 50)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtunit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(80, 24)
        Me.txtunit.TabIndex = 100
        '
        'txtItemname
        '
        Me.txtItemname.Location = New System.Drawing.Point(56, 21)
        Me.txtItemname.Name = "txtItemname"
        Me.txtItemname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtItemname.Properties.Appearance.Options.UseFont = True
        Me.txtItemname.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItemname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItemname.Properties.ReadOnly = True
        Me.txtItemname.Size = New System.Drawing.Size(452, 26)
        Me.txtItemname.TabIndex = 563
        '
        'frmDirectPurchaseOrderItemSelect
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 238)
        Me.Controls.Add(Me.inventoryid)
        Me.Controls.Add(Me.txtItemname)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.tempCost)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.txtsti)
        Me.Controls.Add(Me.proid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.ponumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDirectPurchaseOrderItemSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Confirmation"
        Me.TopMost = True
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ponumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ponumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents proid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tempCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtremarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents inventoryid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemname As DevExpress.XtraEditors.TextEdit
End Class
