<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilUnitConvertion
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
        Me.productid_source = New DevExpress.XtraEditors.TextEdit()
        Me.txtOldQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConvertUnitType = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConvertQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.txtConvertUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentUnitType = New DevExpress.XtraEditors.TextEdit()
        Me.txtCurrentUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConvertProductName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.productid_converted = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuantity_s = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuantity_t = New DevExpress.XtraEditors.TextEdit()
        Me.vendorid = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtNewQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConvertUnitType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConvertQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConvertUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentUnitType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConvertProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_converted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity_s.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity_t.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewQuantity
        '
        Me.txtNewQuantity.EditValue = "0"
        Me.txtNewQuantity.EnterMoveNextControl = True
        Me.txtNewQuantity.Location = New System.Drawing.Point(152, 116)
        Me.txtNewQuantity.Name = "txtNewQuantity"
        Me.txtNewQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtNewQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtNewQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNewQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNewQuantity.Properties.Mask.EditMask = "n4"
        Me.txtNewQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNewQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNewQuantity.Size = New System.Drawing.Size(91, 22)
        Me.txtNewQuantity.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(57, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 15)
        Me.LabelControl3.TabIndex = 339
        Me.LabelControl3.Text = "Convert quantity"
        '
        'productid_source
        '
        Me.productid_source.EditValue = ""
        Me.productid_source.EnterMoveNextControl = True
        Me.productid_source.Location = New System.Drawing.Point(98, 405)
        Me.productid_source.Name = "productid_source"
        Me.productid_source.Properties.ReadOnly = True
        Me.productid_source.Properties.ValidateOnEnterKey = True
        Me.productid_source.Size = New System.Drawing.Size(77, 20)
        Me.productid_source.TabIndex = 534
        Me.productid_source.Visible = False
        '
        'txtOldQuantity
        '
        Me.txtOldQuantity.EditValue = ""
        Me.txtOldQuantity.EnterMoveNextControl = True
        Me.txtOldQuantity.Location = New System.Drawing.Point(409, 93)
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
        Me.officeid.Location = New System.Drawing.Point(17, 405)
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
        Me.LabelControl1.Location = New System.Drawing.Point(96, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl1.TabIndex = 554
        Me.LabelControl1.Text = "Particular"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(152, 66)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(357, 22)
        Me.txtproduct.TabIndex = 553
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(112, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(385, 13)
        Me.LabelControl8.TabIndex = 561
        Me.LabelControl8.Text = "Convert current unit to other unit, quantity depends on unit configuration"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(112, 19)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(113, 19)
        Me.LabelControl9.TabIndex = 560
        Me.LabelControl9.Text = "New Convertion"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(110, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(248, 13)
        Me.LabelControl10.TabIndex = 559
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'txtConvertUnitType
        '
        Me.txtConvertUnitType.Location = New System.Drawing.Point(246, 199)
        Me.txtConvertUnitType.Name = "txtConvertUnitType"
        Me.txtConvertUnitType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConvertUnitType.Properties.Appearance.Options.UseFont = True
        Me.txtConvertUnitType.Properties.ReadOnly = True
        Me.txtConvertUnitType.Size = New System.Drawing.Size(77, 22)
        Me.txtConvertUnitType.TabIndex = 562
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
        Me.cmdUpdate.Location = New System.Drawing.Point(152, 248)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(171, 32)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Proceed Convertion"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(40, 205)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 15)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "Converted Quantity"
        '
        'txtConvertQuantity
        '
        Me.txtConvertQuantity.EditValue = "0"
        Me.txtConvertQuantity.EnterMoveNextControl = True
        Me.txtConvertQuantity.Location = New System.Drawing.Point(152, 199)
        Me.txtConvertQuantity.Name = "txtConvertQuantity"
        Me.txtConvertQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConvertQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConvertQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtConvertQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtConvertQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtConvertQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtConvertQuantity.Properties.Mask.EditMask = "n4"
        Me.txtConvertQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtConvertQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtConvertQuantity.Properties.ReadOnly = True
        Me.txtConvertQuantity.Size = New System.Drawing.Size(91, 22)
        Me.txtConvertQuantity.TabIndex = 1
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(17, 381)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'txtConvertUnitCost
        '
        Me.txtConvertUnitCost.EditValue = "0"
        Me.txtConvertUnitCost.EnterMoveNextControl = True
        Me.txtConvertUnitCost.Location = New System.Drawing.Point(152, 223)
        Me.txtConvertUnitCost.Name = "txtConvertUnitCost"
        Me.txtConvertUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConvertUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConvertUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtConvertUnitCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtConvertUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtConvertUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtConvertUnitCost.Properties.Mask.EditMask = "n"
        Me.txtConvertUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtConvertUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtConvertUnitCost.Properties.ReadOnly = True
        Me.txtConvertUnitCost.Size = New System.Drawing.Size(171, 22)
        Me.txtConvertUnitCost.TabIndex = 628
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(37, 229)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 15)
        Me.LabelControl4.TabIndex = 629
        Me.LabelControl4.Text = "Converted Unit Cost"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(54, 94)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(92, 15)
        Me.LabelControl5.TabIndex = 630
        Me.LabelControl5.Text = "Current Unit Cost"
        '
        'txtCurrentUnitType
        '
        Me.txtCurrentUnitType.Location = New System.Drawing.Point(326, 91)
        Me.txtCurrentUnitType.Name = "txtCurrentUnitType"
        Me.txtCurrentUnitType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrentUnitType.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentUnitType.Properties.ReadOnly = True
        Me.txtCurrentUnitType.Size = New System.Drawing.Size(77, 22)
        Me.txtCurrentUnitType.TabIndex = 632
        '
        'txtCurrentUnitCost
        '
        Me.txtCurrentUnitCost.EditValue = "0"
        Me.txtCurrentUnitCost.EnterMoveNextControl = True
        Me.txtCurrentUnitCost.Location = New System.Drawing.Point(152, 91)
        Me.txtCurrentUnitCost.Name = "txtCurrentUnitCost"
        Me.txtCurrentUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrentUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCurrentUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentUnitCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtCurrentUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCurrentUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCurrentUnitCost.Properties.Mask.EditMask = "n"
        Me.txtCurrentUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCurrentUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCurrentUnitCost.Properties.ReadOnly = True
        Me.txtCurrentUnitCost.Size = New System.Drawing.Size(171, 22)
        Me.txtCurrentUnitCost.TabIndex = 631
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(42, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(104, 15)
        Me.LabelControl6.TabIndex = 634
        Me.LabelControl6.Text = "Convertion Product"
        '
        'txtConvertProductName
        '
        Me.txtConvertProductName.Location = New System.Drawing.Point(152, 174)
        Me.txtConvertProductName.Name = "txtConvertProductName"
        Me.txtConvertProductName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConvertProductName.Properties.Appearance.Options.UseFont = True
        Me.txtConvertProductName.Properties.ReadOnly = True
        Me.txtConvertProductName.Size = New System.Drawing.Size(357, 22)
        Me.txtConvertProductName.TabIndex = 633
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(152, 155)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(270, 13)
        Me.LabelControl7.TabIndex = 635
        Me.LabelControl7.Text = "Product showed below will be add to your inventory"
        '
        'productid_converted
        '
        Me.productid_converted.EditValue = ""
        Me.productid_converted.EnterMoveNextControl = True
        Me.productid_converted.Location = New System.Drawing.Point(181, 405)
        Me.productid_converted.Name = "productid_converted"
        Me.productid_converted.Properties.ReadOnly = True
        Me.productid_converted.Properties.ValidateOnEnterKey = True
        Me.productid_converted.Size = New System.Drawing.Size(77, 20)
        Me.productid_converted.TabIndex = 636
        Me.productid_converted.Visible = False
        '
        'txtQuantity_s
        '
        Me.txtQuantity_s.EditValue = "0"
        Me.txtQuantity_s.EnterMoveNextControl = True
        Me.txtQuantity_s.Location = New System.Drawing.Point(606, 172)
        Me.txtQuantity_s.Name = "txtQuantity_s"
        Me.txtQuantity_s.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity_s.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQuantity_s.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantity_s.TabIndex = 637
        Me.txtQuantity_s.Visible = False
        '
        'txtQuantity_t
        '
        Me.txtQuantity_t.EditValue = "0"
        Me.txtQuantity_t.EnterMoveNextControl = True
        Me.txtQuantity_t.Location = New System.Drawing.Point(606, 202)
        Me.txtQuantity_t.Name = "txtQuantity_t"
        Me.txtQuantity_t.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity_t.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQuantity_t.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantity_t.TabIndex = 638
        Me.txtQuantity_t.Visible = False
        '
        'vendorid
        '
        Me.vendorid.EditValue = ""
        Me.vendorid.EnterMoveNextControl = True
        Me.vendorid.Location = New System.Drawing.Point(492, 92)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Options.UseTextOptions = True
        Me.vendorid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.vendorid.Size = New System.Drawing.Size(77, 20)
        Me.vendorid.TabIndex = 639
        Me.vendorid.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.view_refresh_4
        Me.PanelControl1.Location = New System.Drawing.Point(40, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 558
        '
        'frmUtilUnitConvertion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 299)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.txtQuantity_t)
        Me.Controls.Add(Me.txtQuantity_s)
        Me.Controls.Add(Me.productid_converted)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtConvertProductName)
        Me.Controls.Add(Me.txtCurrentUnitType)
        Me.Controls.Add(Me.txtCurrentUnitCost)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtConvertUnitCost)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtConvertQuantity)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtConvertUnitType)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtOldQuantity)
        Me.Controls.Add(Me.productid_source)
        Me.Controls.Add(Me.txtNewQuantity)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilUnitConvertion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Convertion"
        CType(Me.txtNewQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConvertUnitType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConvertQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConvertUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentUnitType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConvertProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_converted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity_s.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity_t.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid_source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConvertUnitType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConvertQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConvertUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentUnitType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCurrentUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConvertProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid_converted As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuantity_s As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuantity_t As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vendorid As DevExpress.XtraEditors.TextEdit
End Class
