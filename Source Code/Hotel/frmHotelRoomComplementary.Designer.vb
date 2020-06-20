<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomComplementary
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit_special = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove_special = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rid = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(128, 64)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(94, 26)
        Me.cmdSave.TabIndex = 718
        Me.cmdSave.Text = "Save"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(69, 68)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(33, 20)
        Me.mode.TabIndex = 724
        Me.mode.Visible = False
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.Location = New System.Drawing.Point(264, 133)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Options.UseTextOptions = True
        Me.trnid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnid.Size = New System.Drawing.Size(45, 20)
        Me.trnid.TabIndex = 723
        Me.trnid.Visible = False
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.Location = New System.Drawing.Point(315, 133)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Size = New System.Drawing.Size(45, 20)
        Me.productid.TabIndex = 722
        Me.productid.Visible = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl15.Location = New System.Drawing.Point(74, 40)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(46, 15)
        Me.LabelControl15.TabIndex = 719
        Me.LabelControl15.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = ""
        Me.txtQuantity.Location = New System.Drawing.Point(128, 39)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQuantity.Properties.Mask.EditMask = "n"
        Me.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQuantity.Size = New System.Drawing.Size(94, 22)
        Me.txtQuantity.TabIndex = 715
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl16.Location = New System.Drawing.Point(44, 16)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(76, 15)
        Me.LabelControl16.TabIndex = 717
        Me.LabelControl16.Text = "Select Product"
        '
        'txtProduct
        '
        Me.txtProduct.EditValue = ""
        Me.txtProduct.Location = New System.Drawing.Point(128, 14)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtProduct.Properties.Appearance.Options.UseFont = True
        Me.txtProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduct.Properties.DisplayMember = "Product Name"
        Me.txtProduct.Properties.NullText = ""
        Me.txtProduct.Properties.ValueMember = "Product Name"
        Me.txtProduct.Properties.View = Me.gridProduct
        Me.txtProduct.Size = New System.Drawing.Size(305, 22)
        Me.txtProduct.TabIndex = 714
        '
        'gridProduct
        '
        Me.gridProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct.OptionsView.ShowGroupPanel = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip2
        GridLevelNode2.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em.Location = New System.Drawing.Point(10, 107)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(499, 305)
        Me.Em.TabIndex = 716
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit_special, Me.cmdRemove_special})
        Me.ContextMenuStrip2.Name = "gridmenustrip"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(174, 48)
        '
        'cmdEdit_special
        '
        Me.cmdEdit_special.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit_special.Name = "cmdEdit_special"
        Me.cmdEdit_special.Size = New System.Drawing.Size(173, 22)
        Me.cmdEdit_special.Text = "Edit Amenities"
        '
        'cmdRemove_special
        '
        Me.cmdRemove_special.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdRemove_special.Name = "cmdRemove_special"
        Me.cmdRemove_special.Size = New System.Drawing.Size(173, 22)
        Me.cmdRemove_special.Text = "Remove Amenities"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'rid
        '
        Me.rid.EditValue = ""
        Me.rid.Location = New System.Drawing.Point(201, 188)
        Me.rid.Name = "rid"
        Me.rid.Properties.Appearance.Options.UseTextOptions = True
        Me.rid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rid.Size = New System.Drawing.Size(45, 20)
        Me.rid.TabIndex = 725
        Me.rid.Visible = False
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(225, 39)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnit.Properties.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(63, 22)
        Me.txtUnit.TabIndex = 726
        '
        'frmHotelRoomComplementary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(520, 422)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.rid)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtQuantity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MdiChildCaptionFormatString = ""
        Me.MinimumSize = New System.Drawing.Size(536, 461)
        Me.Name = "frmHotelRoomComplementary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Complementary"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit_special As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove_special As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
End Class
