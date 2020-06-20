<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientProductFilter
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabSpecialPrice = New DevExpress.XtraTab.XtraTabPage()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.mode_Special = New DevExpress.XtraEditors.TextEdit()
        Me.trnid_special = New DevExpress.XtraEditors.TextEdit()
        Me.productid_special = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount_Special = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSpecial = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProduct_Special = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct_special = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.em_special = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit_special = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove_special = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabSpecialPrice.SuspendLayout()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode_Special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid_special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount_Special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduct_Special.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct_special, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.em_special, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabSpecialPrice
        Me.XtraTabControl1.Size = New System.Drawing.Size(739, 525)
        Me.XtraTabControl1.TabIndex = 608
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSpecialPrice})
        '
        'tabSpecialPrice
        '
        Me.tabSpecialPrice.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabSpecialPrice.Appearance.Header.Options.UseFont = True
        Me.tabSpecialPrice.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabSpecialPrice.Appearance.HeaderActive.Options.UseFont = True
        Me.tabSpecialPrice.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabSpecialPrice.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabSpecialPrice.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabSpecialPrice.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabSpecialPrice.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabSpecialPrice.Appearance.PageClient.Options.UseFont = True
        Me.tabSpecialPrice.Controls.Add(Me.cifid)
        Me.tabSpecialPrice.Controls.Add(Me.mode_Special)
        Me.tabSpecialPrice.Controls.Add(Me.trnid_special)
        Me.tabSpecialPrice.Controls.Add(Me.productid_special)
        Me.tabSpecialPrice.Controls.Add(Me.CheckEdit1)
        Me.tabSpecialPrice.Controls.Add(Me.LabelControl14)
        Me.tabSpecialPrice.Controls.Add(Me.LabelControl15)
        Me.tabSpecialPrice.Controls.Add(Me.txtAmount_Special)
        Me.tabSpecialPrice.Controls.Add(Me.cmdSpecial)
        Me.tabSpecialPrice.Controls.Add(Me.LabelControl16)
        Me.tabSpecialPrice.Controls.Add(Me.txtProduct_Special)
        Me.tabSpecialPrice.Controls.Add(Me.em_special)
        Me.tabSpecialPrice.Name = "tabSpecialPrice"
        Me.tabSpecialPrice.Size = New System.Drawing.Size(733, 495)
        Me.tabSpecialPrice.Text = "Client Product Special Price"
        '
        'cifid
        '
        Me.cifid.EditValue = ""
        Me.cifid.Location = New System.Drawing.Point(566, 70)
        Me.cifid.Name = "cifid"
        Me.cifid.Properties.Appearance.Options.UseTextOptions = True
        Me.cifid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cifid.Size = New System.Drawing.Size(53, 20)
        Me.cifid.TabIndex = 714
        Me.cifid.Visible = False
        '
        'mode_Special
        '
        Me.mode_Special.EnterMoveNextControl = True
        Me.mode_Special.Location = New System.Drawing.Point(167, 137)
        Me.mode_Special.Name = "mode_Special"
        Me.mode_Special.Size = New System.Drawing.Size(38, 20)
        Me.mode_Special.TabIndex = 713
        Me.mode_Special.Visible = False
        '
        'trnid_special
        '
        Me.trnid_special.EditValue = ""
        Me.trnid_special.Location = New System.Drawing.Point(339, 194)
        Me.trnid_special.Name = "trnid_special"
        Me.trnid_special.Properties.Appearance.Options.UseTextOptions = True
        Me.trnid_special.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.trnid_special.Size = New System.Drawing.Size(53, 20)
        Me.trnid_special.TabIndex = 712
        Me.trnid_special.Visible = False
        '
        'productid_special
        '
        Me.productid_special.EditValue = ""
        Me.productid_special.Location = New System.Drawing.Point(398, 194)
        Me.productid_special.Name = "productid_special"
        Me.productid_special.Properties.Appearance.Options.UseTextOptions = True
        Me.productid_special.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid_special.Size = New System.Drawing.Size(53, 20)
        Me.productid_special.TabIndex = 711
        Me.productid_special.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckEdit1.Location = New System.Drawing.Point(292, 10)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Enable Product Special Price"
        Me.CheckEdit1.Size = New System.Drawing.Size(236, 19)
        Me.CheckEdit1.TabIndex = 710
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl14.Location = New System.Drawing.Point(410, 60)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl14.TabIndex = 709
        Me.LabelControl14.Text = "/ Quantity"
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl15.Location = New System.Drawing.Point(243, 60)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl15.TabIndex = 708
        Me.LabelControl15.Text = "Amount"
        '
        'txtAmount_Special
        '
        Me.txtAmount_Special.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmount_Special.EditValue = ""
        Me.txtAmount_Special.Enabled = False
        Me.txtAmount_Special.Location = New System.Drawing.Point(294, 57)
        Me.txtAmount_Special.Name = "txtAmount_Special"
        Me.txtAmount_Special.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount_Special.Properties.Appearance.Options.UseFont = True
        Me.txtAmount_Special.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount_Special.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAmount_Special.Properties.Mask.EditMask = "n"
        Me.txtAmount_Special.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount_Special.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount_Special.Size = New System.Drawing.Size(110, 22)
        Me.txtAmount_Special.TabIndex = 704
        '
        'cmdSpecial
        '
        Me.cmdSpecial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSpecial.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSpecial.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSpecial.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSpecial.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSpecial.Appearance.Options.UseBackColor = True
        Me.cmdSpecial.Appearance.Options.UseFont = True
        Me.cmdSpecial.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSpecial.Enabled = False
        Me.cmdSpecial.Location = New System.Drawing.Point(294, 83)
        Me.cmdSpecial.Name = "cmdSpecial"
        Me.cmdSpecial.Size = New System.Drawing.Size(110, 30)
        Me.cmdSpecial.TabIndex = 707
        Me.cmdSpecial.Text = "Save"
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl16.Location = New System.Drawing.Point(211, 34)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(76, 15)
        Me.LabelControl16.TabIndex = 706
        Me.LabelControl16.Text = "Select Product"
        '
        'txtProduct_Special
        '
        Me.txtProduct_Special.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProduct_Special.EditValue = ""
        Me.txtProduct_Special.Enabled = False
        Me.txtProduct_Special.Location = New System.Drawing.Point(294, 31)
        Me.txtProduct_Special.Name = "txtProduct_Special"
        Me.txtProduct_Special.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProduct_Special.Properties.Appearance.Options.UseFont = True
        Me.txtProduct_Special.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduct_Special.Properties.DisplayMember = "Product Name"
        Me.txtProduct_Special.Properties.NullText = ""
        Me.txtProduct_Special.Properties.ValueMember = "Product Name"
        Me.txtProduct_Special.Properties.View = Me.gridProduct_special
        Me.txtProduct_Special.Size = New System.Drawing.Size(225, 22)
        Me.txtProduct_Special.TabIndex = 703
        '
        'gridProduct_special
        '
        Me.gridProduct_special.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct_special.Name = "gridProduct_special"
        Me.gridProduct_special.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct_special.OptionsView.ShowGroupPanel = False
        '
        'em_special
        '
        Me.em_special.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.em_special.ContextMenuStrip = Me.ContextMenuStrip2
        GridLevelNode2.RelationName = "Level1"
        Me.em_special.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.em_special.Location = New System.Drawing.Point(5, 126)
        Me.em_special.MainView = Me.GridView3
        Me.em_special.Name = "em_special"
        Me.em_special.Size = New System.Drawing.Size(725, 366)
        Me.em_special.TabIndex = 705
        Me.em_special.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit_special, Me.cmdRemove_special})
        Me.ContextMenuStrip2.Name = "gridmenustrip"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(187, 48)
        '
        'cmdEdit_special
        '
        Me.cmdEdit_special.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit_special.Name = "cmdEdit_special"
        Me.cmdEdit_special.Size = New System.Drawing.Size(186, 22)
        Me.cmdEdit_special.Text = "Edit Special Price"
        '
        'cmdRemove_special
        '
        Me.cmdRemove_special.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdRemove_special.Name = "cmdRemove_special"
        Me.cmdRemove_special.Size = New System.Drawing.Size(186, 22)
        Me.cmdRemove_special.Text = "Remove Special Price"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.em_special
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'frmClientProductFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 525)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.MinimumSize = New System.Drawing.Size(755, 564)
        Me.Name = "frmClientProductFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Product Filter"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabSpecialPrice.ResumeLayout(False)
        Me.tabSpecialPrice.PerformLayout()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode_Special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid_special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount_Special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduct_Special.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct_special, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.em_special, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSpecialPrice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount_Special As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSpecial As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduct_Special As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct_special As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents em_special As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit_special As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove_special As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mode_Special As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid_special As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid_special As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
End Class
