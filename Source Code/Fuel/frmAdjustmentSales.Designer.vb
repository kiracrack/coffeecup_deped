<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustmentSales
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
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountAdj = New DevExpress.XtraEditors.TextEdit()
        Me.radAdjType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountAdj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radAdjType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(52, 140)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl7.TabIndex = 341
        Me.LabelControl7.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.EnterMoveNextControl = True
        Me.txtRemarks.Location = New System.Drawing.Point(99, 137)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(296, 53)
        Me.txtRemarks.TabIndex = 2
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(16, 205)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(38, 20)
        Me.trnid.TabIndex = 534
        Me.trnid.Visible = False
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(60, 205)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Properties.ValidateOnEnterKey = True
        Me.officeid.Size = New System.Drawing.Size(33, 20)
        Me.officeid.TabIndex = 536
        Me.officeid.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(222, 193)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(173, 32)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Confirm Adjustment"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(38, 114)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "Adjustment"
        '
        'txtAmountAdj
        '
        Me.txtAmountAdj.EditValue = "0"
        Me.txtAmountAdj.EnterMoveNextControl = True
        Me.txtAmountAdj.Location = New System.Drawing.Point(99, 108)
        Me.txtAmountAdj.Name = "txtAmountAdj"
        Me.txtAmountAdj.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtAmountAdj.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmountAdj.Properties.Appearance.Options.UseFont = True
        Me.txtAmountAdj.Properties.Appearance.Options.UseForeColor = True
        Me.txtAmountAdj.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountAdj.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountAdj.Properties.Mask.EditMask = "n"
        Me.txtAmountAdj.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountAdj.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountAdj.Size = New System.Drawing.Size(90, 26)
        Me.txtAmountAdj.TabIndex = 1
        '
        'radAdjType
        '
        Me.radAdjType.EditValue = "increase"
        Me.radAdjType.Location = New System.Drawing.Point(99, 82)
        Me.radAdjType.Name = "radAdjType"
        Me.radAdjType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("increase", "Increase"), New DevExpress.XtraEditors.Controls.RadioGroupItem("rollback", "Rollback")})
        Me.radAdjType.Size = New System.Drawing.Size(170, 22)
        Me.radAdjType.TabIndex = 691
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(11, 86)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl26.TabIndex = 690
        Me.LabelControl26.Text = "Adjustment Type"
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(99, 12)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.View = Me.gridcompoffice
        Me.txtoffice.Size = New System.Drawing.Size(249, 20)
        Me.txtoffice.TabIndex = 692
        '
        'gridcompoffice
        '
        Me.gridcompoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcompoffice.Name = "gridcompoffice"
        Me.gridcompoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcompoffice.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.Location = New System.Drawing.Point(31, 15)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(62, 13)
        Me.lblOffice.TabIndex = 693
        Me.lblOffice.Text = "Inventory of"
        '
        'txtProduct
        '
        Me.txtProduct.EditValue = ""
        Me.txtProduct.Location = New System.Drawing.Point(99, 35)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduct.Properties.NullText = ""
        Me.txtProduct.Properties.View = Me.gridProduct
        Me.txtProduct.Size = New System.Drawing.Size(249, 20)
        Me.txtProduct.TabIndex = 694
        '
        'gridProduct
        '
        Me.gridProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Location = New System.Drawing.Point(56, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 695
        Me.LabelControl3.Text = "Product"
        '
        'txtCurrentCost
        '
        Me.txtCurrentCost.EditValue = "0"
        Me.txtCurrentCost.EnterMoveNextControl = True
        Me.txtCurrentCost.Location = New System.Drawing.Point(99, 59)
        Me.txtCurrentCost.Name = "txtCurrentCost"
        Me.txtCurrentCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCurrentCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCurrentCost.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtCurrentCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCurrentCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCurrentCost.Properties.Mask.EditMask = "n"
        Me.txtCurrentCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCurrentCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCurrentCost.Properties.ReadOnly = True
        Me.txtCurrentCost.Size = New System.Drawing.Size(171, 20)
        Me.txtCurrentCost.TabIndex = 696
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 697
        Me.LabelControl1.Text = "Selling Price"
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(99, 205)
        Me.productid.Name = "productid"
        Me.productid.Properties.ReadOnly = True
        Me.productid.Properties.ValidateOnEnterKey = True
        Me.productid.Size = New System.Drawing.Size(33, 20)
        Me.productid.TabIndex = 698
        Me.productid.Visible = False
        '
        'frmAdjustmentSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 230)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCurrentCost)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.radAdjType)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.txtAmountAdj)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtRemarks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjustmentSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Adjustment"
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountAdj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radAdjType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountAdj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents radAdjType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
End Class
