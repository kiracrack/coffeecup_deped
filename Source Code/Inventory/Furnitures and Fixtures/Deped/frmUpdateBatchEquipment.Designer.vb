<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateBatchEquipment
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
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotalSelected = New DevExpress.XtraEditors.TextEdit()
        Me.modelcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtModel = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridModel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdAddItem = New DevExpress.XtraEditors.SimpleButton()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProductItemName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.subcatid = New DevExpress.XtraEditors.TextEdit()
        Me.codename = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtTotalSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subcatid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(270, 94)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(133, 38)
        Me.cmdaction.TabIndex = 631
        Me.cmdaction.Text = "&Confirm Update"
        '
        'txtTotalSelected
        '
        Me.txtTotalSelected.EditValue = ""
        Me.txtTotalSelected.Location = New System.Drawing.Point(385, 265)
        Me.txtTotalSelected.Name = "txtTotalSelected"
        Me.txtTotalSelected.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSelected.Properties.Appearance.Options.UseFont = True
        Me.txtTotalSelected.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalSelected.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalSelected.Properties.Mask.EditMask = "n"
        Me.txtTotalSelected.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSelected.Properties.ReadOnly = True
        Me.txtTotalSelected.Size = New System.Drawing.Size(46, 24)
        Me.txtTotalSelected.TabIndex = 632
        Me.txtTotalSelected.Visible = False
        '
        'modelcode
        '
        Me.modelcode.Location = New System.Drawing.Point(511, 65)
        Me.modelcode.Name = "modelcode"
        Me.modelcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelcode.Properties.Appearance.Options.UseFont = True
        Me.modelcode.Properties.ReadOnly = True
        Me.modelcode.Size = New System.Drawing.Size(44, 24)
        Me.modelcode.TabIndex = 688
        Me.modelcode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(101, 67)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 17)
        Me.LabelControl8.TabIndex = 687
        Me.LabelControl8.Text = "Model"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.newspaper__plus
        Me.SimpleButton2.Location = New System.Drawing.Point(406, 66)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 20)
        Me.SimpleButton2.TabIndex = 686
        Me.SimpleButton2.ToolTip = "Add New Particular"
        '
        'txtModel
        '
        Me.txtModel.EditValue = ""
        Me.txtModel.EnterMoveNextControl = True
        Me.txtModel.Location = New System.Drawing.Point(146, 64)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Properties.Appearance.Options.UseFont = True
        Me.txtModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtModel.Properties.DisplayMember = "Model"
        Me.txtModel.Properties.NullText = ""
        Me.txtModel.Properties.PopupFormMinSize = New System.Drawing.Size(500, 500)
        Me.txtModel.Properties.PopupFormSize = New System.Drawing.Size(500, 500)
        Me.txtModel.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtModel.Properties.PopupView = Me.gridModel
        Me.txtModel.Properties.ValueMember = "code"
        Me.txtModel.Size = New System.Drawing.Size(257, 24)
        Me.txtModel.TabIndex = 682
        '
        'gridModel
        '
        Me.gridModel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridModel.Name = "gridModel"
        Me.gridModel.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridModel.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.gridModel.OptionsFind.ClearFindOnClose = False
        Me.gridModel.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.gridModel.OptionsFind.SearchInPreview = True
        Me.gridModel.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridModel.OptionsView.ShowGroupPanel = False
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddItem.Appearance.Options.UseFont = True
        Me.cmdAddItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddItem.ImageOptions.Image = Global.Coffeecup.My.Resources.Resources.newspaper__plus
        Me.cmdAddItem.Location = New System.Drawing.Point(406, 39)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(24, 20)
        Me.cmdAddItem.TabIndex = 685
        Me.cmdAddItem.ToolTip = "Add New Particular"
        '
        'productid
        '
        Me.productid.Location = New System.Drawing.Point(511, 35)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(44, 24)
        Me.productid.TabIndex = 684
        Me.productid.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(37, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(102, 17)
        Me.LabelControl9.TabIndex = 683
        Me.LabelControl9.Text = "Select Item Name"
        '
        'txtProductItemName
        '
        Me.txtProductItemName.EditValue = ""
        Me.txtProductItemName.EnterMoveNextControl = True
        Me.txtProductItemName.Location = New System.Drawing.Point(146, 37)
        Me.txtProductItemName.Name = "txtProductItemName"
        Me.txtProductItemName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductItemName.Properties.Appearance.Options.UseFont = True
        Me.txtProductItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProductItemName.Properties.DisplayMember = "Select Product"
        Me.txtProductItemName.Properties.NullText = ""
        Me.txtProductItemName.Properties.PopupFormMinSize = New System.Drawing.Size(500, 500)
        Me.txtProductItemName.Properties.PopupFormSize = New System.Drawing.Size(500, 500)
        Me.txtProductItemName.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtProductItemName.Properties.PopupView = Me.g_product
        Me.txtProductItemName.Properties.ValueMember = "Select Product"
        Me.txtProductItemName.Size = New System.Drawing.Size(257, 24)
        Me.txtProductItemName.TabIndex = 681
        '
        'g_product
        '
        Me.g_product.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_product.Name = "g_product"
        Me.g_product.OptionsBehavior.AllowIncrementalSearch = True
        Me.g_product.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.g_product.OptionsFind.ClearFindOnClose = False
        Me.g_product.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.g_product.OptionsFind.SearchInPreview = True
        Me.g_product.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_product.OptionsView.ColumnAutoWidth = False
        Me.g_product.OptionsView.ShowGroupPanel = False
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(599, 39)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(44, 24)
        Me.txtUnit.TabIndex = 689
        Me.txtUnit.Visible = False
        '
        'catid
        '
        Me.catid.Location = New System.Drawing.Point(599, 69)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(44, 24)
        Me.catid.TabIndex = 690
        Me.catid.Visible = False
        '
        'subcatid
        '
        Me.subcatid.Location = New System.Drawing.Point(599, 99)
        Me.subcatid.Name = "subcatid"
        Me.subcatid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subcatid.Properties.Appearance.Options.UseFont = True
        Me.subcatid.Properties.ReadOnly = True
        Me.subcatid.Size = New System.Drawing.Size(44, 24)
        Me.subcatid.TabIndex = 691
        Me.subcatid.Visible = False
        '
        'codename
        '
        Me.codename.Location = New System.Drawing.Point(599, 129)
        Me.codename.Name = "codename"
        Me.codename.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codename.Properties.Appearance.Options.UseFont = True
        Me.codename.Properties.ReadOnly = True
        Me.codename.Size = New System.Drawing.Size(44, 24)
        Me.codename.TabIndex = 692
        Me.codename.Visible = False
        '
        'frmUpdateBatchEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 162)
        Me.Controls.Add(Me.codename)
        Me.Controls.Add(Me.subcatid)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.modelcode)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtProductItemName)
        Me.Controls.Add(Me.txtTotalSelected)
        Me.Controls.Add(Me.cmdaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateBatchEquipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Updater"
        Me.TopMost = True
        CType(Me.txtTotalSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subcatid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalSelected As DevExpress.XtraEditors.TextEdit
    Friend WithEvents modelcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtModel As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridModel As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAddItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductItemName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents subcatid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents codename As DevExpress.XtraEditors.TextEdit
End Class
