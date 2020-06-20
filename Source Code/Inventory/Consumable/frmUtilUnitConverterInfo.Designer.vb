<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilUnitConverterInfo
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
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridMenuProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSourceProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.productid_source = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtTargetQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.productid_item = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckAutoCorvert = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSourceUnitType = New DevExpress.XtraEditors.TextEdit()
        Me.txtSourceQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.txtConvertionProduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItemMenu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTargetUnitType = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditConvetionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.gridMenuProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourceProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTargetQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid_item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckAutoCorvert.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourceUnitType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourceQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConvertionProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTargetUnitType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(69, 105)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl11.TabIndex = 540
        Me.LabelControl11.Text = "Select Convertion Product"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(87, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(115, 15)
        Me.LabelControl1.TabIndex = 543
        Me.LabelControl1.Text = "Select Source Product"
        '
        'gridMenuProduct
        '
        Me.gridMenuProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMenuProduct.Name = "gridMenuProduct"
        Me.gridMenuProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMenuProduct.OptionsView.ShowGroupPanel = False
        '
        'txtSourceProduct
        '
        Me.txtSourceProduct.EditValue = ""
        Me.txtSourceProduct.EnterMoveNextControl = True
        Me.txtSourceProduct.Location = New System.Drawing.Point(208, 15)
        Me.txtSourceProduct.Name = "txtSourceProduct"
        Me.txtSourceProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSourceProduct.Properties.Appearance.Options.UseFont = True
        Me.txtSourceProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSourceProduct.Properties.DisplayMember = "Source Product"
        Me.txtSourceProduct.Properties.NullText = ""
        Me.txtSourceProduct.Properties.ValueMember = "Source Product"
        Me.txtSourceProduct.Properties.View = Me.gridMenuProduct
        Me.txtSourceProduct.Size = New System.Drawing.Size(253, 22)
        Me.txtSourceProduct.TabIndex = 0
        '
        'productid_source
        '
        Me.productid_source.EditValue = ""
        Me.productid_source.Location = New System.Drawing.Point(467, 15)
        Me.productid_source.Name = "productid_source"
        Me.productid_source.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.productid_source.Properties.Appearance.Options.UseFont = True
        Me.productid_source.Properties.Appearance.Options.UseTextOptions = True
        Me.productid_source.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid_source.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.productid_source.Properties.Mask.BeepOnError = True
        Me.productid_source.Properties.ReadOnly = True
        Me.productid_source.Size = New System.Drawing.Size(33, 22)
        Me.productid_source.TabIndex = 544
        Me.productid_source.Visible = False
        '
        'txtTargetQuantity
        '
        Me.txtTargetQuantity.EditValue = "0.00"
        Me.txtTargetQuantity.Location = New System.Drawing.Point(208, 126)
        Me.txtTargetQuantity.Name = "txtTargetQuantity"
        Me.txtTargetQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtTargetQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTargetQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTargetQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtTargetQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtTargetQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtTargetQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTargetQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTargetQuantity.Properties.Mask.EditMask = "n4"
        Me.txtTargetQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTargetQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTargetQuantity.Size = New System.Drawing.Size(109, 22)
        Me.txtTargetQuantity.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(208, 177)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(191, 30)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Add Convertion"
        '
        'productid_item
        '
        Me.productid_item.EnterMoveNextControl = True
        Me.productid_item.Location = New System.Drawing.Point(467, 102)
        Me.productid_item.Name = "productid_item"
        Me.productid_item.Size = New System.Drawing.Size(33, 20)
        Me.productid_item.TabIndex = 552
        Me.productid_item.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckAutoCorvert)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSourceUnitType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSourceQuantity)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTargetQuantity)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid_item)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.productid_source)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl11)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtSourceProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtConvertionProduct)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTargetUnitType)
        Me.SplitContainerControl1.Panel1.MinSize = 150
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(817, 562)
        Me.SplitContainerControl1.SplitterPosition = 226
        Me.SplitContainerControl1.TabIndex = 553
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckAutoCorvert
        '
        Me.ckAutoCorvert.Location = New System.Drawing.Point(208, 154)
        Me.ckAutoCorvert.MenuManager = Me.BarManager1
        Me.ckAutoCorvert.Name = "ckAutoCorvert"
        Me.ckAutoCorvert.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAutoCorvert.Properties.Appearance.Options.UseFont = True
        Me.ckAutoCorvert.Properties.Caption = "Execute auto convert upon received from supplier"
        Me.ckAutoCorvert.Size = New System.Drawing.Size(292, 19)
        Me.ckAutoCorvert.TabIndex = 637
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 4
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(817, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 562)
        Me.barDockControlBottom.Size = New System.Drawing.Size(817, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 562)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(817, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(208, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(206, 15)
        Me.LabelControl2.TabIndex = 636
        Me.LabelControl2.Text = "Target convertion from source product"
        '
        'txtSourceUnitType
        '
        Me.txtSourceUnitType.Location = New System.Drawing.Point(322, 41)
        Me.txtSourceUnitType.Name = "txtSourceUnitType"
        Me.txtSourceUnitType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSourceUnitType.Properties.Appearance.Options.UseFont = True
        Me.txtSourceUnitType.Properties.ReadOnly = True
        Me.txtSourceUnitType.Size = New System.Drawing.Size(77, 22)
        Me.txtSourceUnitType.TabIndex = 635
        '
        'txtSourceQuantity
        '
        Me.txtSourceQuantity.EditValue = "0"
        Me.txtSourceQuantity.EnterMoveNextControl = True
        Me.txtSourceQuantity.Location = New System.Drawing.Point(208, 41)
        Me.txtSourceQuantity.Name = "txtSourceQuantity"
        Me.txtSourceQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtSourceQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSourceQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSourceQuantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtSourceQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtSourceQuantity.Properties.Appearance.Options.UseForeColor = True
        Me.txtSourceQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSourceQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSourceQuantity.Properties.Mask.EditMask = "n4"
        Me.txtSourceQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSourceQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSourceQuantity.Size = New System.Drawing.Size(109, 22)
        Me.txtSourceQuantity.TabIndex = 633
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(119, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 15)
        Me.LabelControl3.TabIndex = 634
        Me.LabelControl3.Text = "Source quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(73, 129)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl4.TabIndex = 555
        Me.LabelControl4.Text = "Total Quantity to Convert"
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(140, 174)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 553
        Me.id.Visible = False
        '
        'txtConvertionProduct
        '
        Me.txtConvertionProduct.EditValue = ""
        Me.txtConvertionProduct.EnterMoveNextControl = True
        Me.txtConvertionProduct.Location = New System.Drawing.Point(208, 102)
        Me.txtConvertionProduct.Name = "txtConvertionProduct"
        Me.txtConvertionProduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvertionProduct.Properties.Appearance.Options.UseFont = True
        Me.txtConvertionProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtConvertionProduct.Properties.DisplayMember = "Target Product"
        Me.txtConvertionProduct.Properties.NullText = ""
        Me.txtConvertionProduct.Properties.ValueMember = "Target Product"
        Me.txtConvertionProduct.Properties.View = Me.gridItemMenu
        Me.txtConvertionProduct.Size = New System.Drawing.Size(253, 20)
        Me.txtConvertionProduct.TabIndex = 1
        '
        'gridItemMenu
        '
        Me.gridItemMenu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItemMenu.Name = "gridItemMenu"
        Me.gridItemMenu.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItemMenu.OptionsView.ShowGroupPanel = False
        '
        'txtTargetUnitType
        '
        Me.txtTargetUnitType.Location = New System.Drawing.Point(322, 126)
        Me.txtTargetUnitType.Name = "txtTargetUnitType"
        Me.txtTargetUnitType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTargetUnitType.Properties.Appearance.Options.UseFont = True
        Me.txtTargetUnitType.Properties.ReadOnly = True
        Me.txtTargetUnitType.Size = New System.Drawing.Size(77, 22)
        Me.txtTargetUnitType.TabIndex = 2
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(817, 331)
        Me.Em.TabIndex = 4
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditConvetionToolStripMenuItem, Me.cmdRemove, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(180, 98)
        '
        'EditConvetionToolStripMenuItem
        '
        Me.EditConvetionToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.EditConvetionToolStripMenuItem.Name = "EditConvetionToolStripMenuItem"
        Me.EditConvetionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditConvetionToolStripMenuItem.Text = "Edit Convertion"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(179, 22)
        Me.cmdRemove.Text = "Remove Convertion"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'frmUtilUnitConverterInfo
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 562)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmUtilUnitConverterInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Converter"
        CType(Me.gridMenuProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourceProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTargetQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid_item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckAutoCorvert.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourceUnitType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourceQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConvertionProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTargetUnitType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridMenuProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSourceProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents productid_source As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtTargetQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents productid_item As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConvertionProduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItemMenu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTargetUnitType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSourceUnitType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSourceQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EditConvetionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckAutoCorvert As DevExpress.XtraEditors.CheckEdit
End Class
