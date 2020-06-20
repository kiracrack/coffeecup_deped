<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductDirect2
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
        Me.productid = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtitem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSellingPrice = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveParticular = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchasePrice = New DevExpress.XtraEditors.TextEdit()
        Me.ckServiceCharge = New DevExpress.XtraEditors.CheckEdit()
        Me.ckVatEnable = New DevExpress.XtraEditors.CheckEdit()
        Me.catid = New DevExpress.XtraEditors.ButtonEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchasePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckServiceCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckVatEnable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(148, 63)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.productid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.productid.Properties.Appearance.Options.UseBackColor = True
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseForeColor = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.productid.Properties.Mask.BeepOnError = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(184, 22)
        Me.productid.TabIndex = 100
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl17.Location = New System.Drawing.Point(38, 95)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(102, 16)
        Me.LabelControl17.TabIndex = 524
        Me.LabelControl17.Text = "Particular Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(78, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl2.TabIndex = 527
        Me.LabelControl2.Text = "Item Code"
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(148, 91)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.txtitem.Properties.Appearance.Options.UseFont = True
        Me.txtitem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtitem.Size = New System.Drawing.Size(289, 24)
        Me.txtitem.TabIndex = 4545
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(148, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(239, 13)
        Me.LabelControl7.TabIndex = 556
        Me.LabelControl7.Text = "This form is allow user add and edit particular item"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(148, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(181, 19)
        Me.LabelControl5.TabIndex = 555
        Me.LabelControl5.Text = "Product Item Information"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(146, 39)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(287, 16)
        Me.LabelControl8.TabIndex = 554
        Me.LabelControl8.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl11.Location = New System.Drawing.Point(70, 175)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(70, 17)
        Me.LabelControl11.TabIndex = 413
        Me.LabelControl11.Text = "Selling Price"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.EditValue = "0"
        Me.txtSellingPrice.Location = New System.Drawing.Point(148, 172)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtSellingPrice.Properties.Appearance.Options.UseFont = True
        Me.txtSellingPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSellingPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSellingPrice.Properties.Mask.EditMask = "n"
        Me.txtSellingPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSellingPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSellingPrice.Size = New System.Drawing.Size(209, 24)
        Me.txtSellingPrice.TabIndex = 0
        '
        'cmdSaveParticular
        '
        Me.cmdSaveParticular.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveParticular.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveParticular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveParticular.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSaveParticular.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveParticular.Appearance.Options.UseBackColor = True
        Me.cmdSaveParticular.Appearance.Options.UseFont = True
        Me.cmdSaveParticular.Appearance.Options.UseForeColor = True
        Me.cmdSaveParticular.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveParticular.Location = New System.Drawing.Point(146, 257)
        Me.cmdSaveParticular.Name = "cmdSaveParticular"
        Me.cmdSaveParticular.Size = New System.Drawing.Size(209, 29)
        Me.cmdSaveParticular.TabIndex = 3
        Me.cmdSaveParticular.Text = "Save Product Information"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(84, 121)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl3.TabIndex = 633
        Me.LabelControl3.Text = "Item Unit"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(148, 118)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUnit.Size = New System.Drawing.Size(102, 24)
        Me.txtUnit.TabIndex = 1212
        Me.txtUnit.ToolTip = "Shortcut Key (F11)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(51, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl1.TabIndex = 641
        Me.LabelControl1.Text = "Purchase Price"
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.EditValue = "0"
        Me.txtPurchasePrice.Location = New System.Drawing.Point(148, 145)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtPurchasePrice.Properties.Appearance.Options.UseFont = True
        Me.txtPurchasePrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPurchasePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPurchasePrice.Properties.Mask.EditMask = "n"
        Me.txtPurchasePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchasePrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPurchasePrice.Size = New System.Drawing.Size(209, 24)
        Me.txtPurchasePrice.TabIndex = 121212
        '
        'ckServiceCharge
        '
        Me.ckServiceCharge.EditValue = True
        Me.ckServiceCharge.Location = New System.Drawing.Point(148, 226)
        Me.ckServiceCharge.Name = "ckServiceCharge"
        Me.ckServiceCharge.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.ckServiceCharge.Properties.Appearance.Options.UseFont = True
        Me.ckServiceCharge.Properties.Caption = "Service Charge Item"
        Me.ckServiceCharge.Size = New System.Drawing.Size(142, 23)
        Me.ckServiceCharge.TabIndex = 2
        '
        'ckVatEnable
        '
        Me.ckVatEnable.EditValue = True
        Me.ckVatEnable.Location = New System.Drawing.Point(148, 202)
        Me.ckVatEnable.Name = "ckVatEnable"
        Me.ckVatEnable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.ckVatEnable.Properties.Appearance.Options.UseFont = True
        Me.ckVatEnable.Properties.Caption = "Vatable Item"
        Me.ckVatEnable.Size = New System.Drawing.Size(142, 23)
        Me.ckVatEnable.TabIndex = 1
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(434, 225)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.catid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseForeColor = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.catid.Properties.Mask.BeepOnError = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(51, 22)
        Me.catid.TabIndex = 121213
        Me.catid.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.product_icon1
        Me.PanelControl1.Location = New System.Drawing.Point(76, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 553
        '
        'frmProductDirect2
        '
        Me.AcceptButton = Me.cmdSaveParticular
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 299)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.ckServiceCharge)
        Me.Controls.Add(Me.ckVatEnable)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.cmdSaveParticular)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txtitem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductDirect2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Item Information"
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchasePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckServiceCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckVatEnable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtitem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSellingPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveParticular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchasePrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckServiceCharge As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckVatEnable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents catid As DevExpress.XtraEditors.ButtonEdit
End Class
