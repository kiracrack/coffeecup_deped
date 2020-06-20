<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCharges
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
        Me.tabCharges = New DevExpress.XtraTab.XtraTabPage()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.radChargesType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChargesRate = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveCharges = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCategory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_charges = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit_charges = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete_charges = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabCharges.SuspendLayout()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radChargesType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargesRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Gridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabControl1.SelectedTabPage = Me.tabCharges
        Me.XtraTabControl1.Size = New System.Drawing.Size(739, 525)
        Me.XtraTabControl1.TabIndex = 608
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCharges})
        '
        'tabCharges
        '
        Me.tabCharges.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.Header.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCharges.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCharges.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCharges.Appearance.PageClient.Options.UseFont = True
        Me.tabCharges.Controls.Add(Me.id)
        Me.tabCharges.Controls.Add(Me.mode)
        Me.tabCharges.Controls.Add(Me.LabelControl8)
        Me.tabCharges.Controls.Add(Me.radChargesType)
        Me.tabCharges.Controls.Add(Me.LabelControl9)
        Me.tabCharges.Controls.Add(Me.LabelControl11)
        Me.tabCharges.Controls.Add(Me.txtChargesRate)
        Me.tabCharges.Controls.Add(Me.cmdSaveCharges)
        Me.tabCharges.Controls.Add(Me.LabelControl12)
        Me.tabCharges.Controls.Add(Me.txtCategory)
        Me.tabCharges.Controls.Add(Me.Em_charges)
        Me.tabCharges.Controls.Add(Me.catid)
        Me.tabCharges.Name = "tabCharges"
        Me.tabCharges.Size = New System.Drawing.Size(733, 495)
        Me.tabCharges.Text = "Client Product Charges"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(673, 68)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Size = New System.Drawing.Size(53, 20)
        Me.id.TabIndex = 704
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(673, 42)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Size = New System.Drawing.Size(53, 20)
        Me.mode.TabIndex = 703
        Me.mode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl8.Location = New System.Drawing.Point(216, 42)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 15)
        Me.LabelControl8.TabIndex = 702
        Me.LabelControl8.Text = "Charges Type"
        '
        'radChargesType
        '
        Me.radChargesType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radChargesType.EditValue = "amount"
        Me.radChargesType.Location = New System.Drawing.Point(297, 38)
        Me.radChargesType.Name = "radChargesType"
        Me.radChargesType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radChargesType.Properties.Appearance.Options.UseFont = True
        Me.radChargesType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("amount", "Amount"), New DevExpress.XtraEditors.Controls.RadioGroupItem("percent", "Percent")})
        Me.radChargesType.Size = New System.Drawing.Size(206, 24)
        Me.radChargesType.TabIndex = 701
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(412, 69)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl9.TabIndex = 700
        Me.LabelControl9.Text = "/ Quantity"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl11.Location = New System.Drawing.Point(219, 70)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(69, 15)
        Me.LabelControl11.TabIndex = 698
        Me.LabelControl11.Text = "Charges Rate"
        '
        'txtChargesRate
        '
        Me.txtChargesRate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtChargesRate.EditValue = ""
        Me.txtChargesRate.Location = New System.Drawing.Point(297, 65)
        Me.txtChargesRate.Name = "txtChargesRate"
        Me.txtChargesRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChargesRate.Properties.Appearance.Options.UseFont = True
        Me.txtChargesRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtChargesRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtChargesRate.Properties.Mask.EditMask = "n"
        Me.txtChargesRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtChargesRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtChargesRate.Size = New System.Drawing.Size(110, 22)
        Me.txtChargesRate.TabIndex = 693
        '
        'cmdSaveCharges
        '
        Me.cmdSaveCharges.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSaveCharges.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveCharges.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveCharges.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSaveCharges.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveCharges.Appearance.Options.UseBackColor = True
        Me.cmdSaveCharges.Appearance.Options.UseFont = True
        Me.cmdSaveCharges.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveCharges.Location = New System.Drawing.Point(297, 91)
        Me.cmdSaveCharges.Name = "cmdSaveCharges"
        Me.cmdSaveCharges.Size = New System.Drawing.Size(110, 30)
        Me.cmdSaveCharges.TabIndex = 697
        Me.cmdSaveCharges.Text = "Save"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl12.Location = New System.Drawing.Point(206, 16)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(82, 15)
        Me.LabelControl12.TabIndex = 695
        Me.LabelControl12.Text = "Select Category"
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCategory.EditValue = ""
        Me.txtCategory.Location = New System.Drawing.Point(297, 13)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCategory.Properties.DisplayMember = "Description"
        Me.txtCategory.Properties.NullText = ""
        Me.txtCategory.Properties.ValueMember = "Description"
        Me.txtCategory.Properties.View = Me.gridCategory
        Me.txtCategory.Size = New System.Drawing.Size(206, 22)
        Me.txtCategory.TabIndex = 692
        '
        'gridCategory
        '
        Me.gridCategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCategory.Name = "gridCategory"
        Me.gridCategory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCategory.OptionsView.ShowGroupPanel = False
        '
        'Em_charges
        '
        Me.Em_charges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_charges.ContextMenuStrip = Me.ContextMenuStrip1
        GridLevelNode2.RelationName = "Level1"
        Me.Em_charges.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em_charges.Location = New System.Drawing.Point(5, 127)
        Me.Em_charges.MainView = Me.Gridview2
        Me.Em_charges.Name = "Em_charges"
        Me.Em_charges.Size = New System.Drawing.Size(725, 365)
        Me.Em_charges.TabIndex = 694
        Me.Em_charges.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit_charges, Me.cmdDelete_charges, Me.EnableDisableToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshListToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 98)
        '
        'cmdEdit_charges
        '
        Me.cmdEdit_charges.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit_charges.Name = "cmdEdit_charges"
        Me.cmdEdit_charges.Size = New System.Drawing.Size(163, 22)
        Me.cmdEdit_charges.Text = "Edit Charges"
        '
        'cmdDelete_charges
        '
        Me.cmdDelete_charges.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete_charges.Name = "cmdDelete_charges"
        Me.cmdDelete_charges.Size = New System.Drawing.Size(163, 22)
        Me.cmdDelete_charges.Text = "Remove Charges"
        '
        'EnableDisableToolStripMenuItem
        '
        Me.EnableDisableToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources._151
        Me.EnableDisableToolStripMenuItem.Name = "EnableDisableToolStripMenuItem"
        Me.EnableDisableToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EnableDisableToolStripMenuItem.Text = "Enable/Disable"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'RefreshListToolStripMenuItem
        '
        Me.RefreshListToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshListToolStripMenuItem.Name = "RefreshListToolStripMenuItem"
        Me.RefreshListToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RefreshListToolStripMenuItem.Text = "Refresh List"
        '
        'Gridview2
        '
        Me.Gridview2.GridControl = Me.Em_charges
        Me.Gridview2.Name = "Gridview2"
        Me.Gridview2.OptionsBehavior.Editable = False
        Me.Gridview2.OptionsSelection.MultiSelect = True
        Me.Gridview2.OptionsView.ShowGroupPanel = False
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.Location = New System.Drawing.Point(673, 14)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.catid.Size = New System.Drawing.Size(53, 20)
        Me.catid.TabIndex = 696
        Me.catid.Visible = False
        '
        'frmProductCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 525)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.MinimumSize = New System.Drawing.Size(755, 564)
        Me.Name = "frmProductCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Charges"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabCharges.ResumeLayout(False)
        Me.tabCharges.PerformLayout()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radChargesType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargesRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Gridview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCharges As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radChargesType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChargesRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveCharges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCategory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_charges As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit_charges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete_charges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gridview2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EnableDisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
