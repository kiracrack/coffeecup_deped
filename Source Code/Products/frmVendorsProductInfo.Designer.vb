<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendorsProductInfo
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
        Me.vendorid = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtofficename = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.itemid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtitemname = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcost = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.txtVendor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_Vendor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdAddVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtofficename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtitemname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vendorid
        '
        Me.vendorid.EditValue = ""
        Me.vendorid.Location = New System.Drawing.Point(329, 169)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.vendorid.Properties.Appearance.Options.UseFont = True
        Me.vendorid.Properties.Appearance.Options.UseTextOptions = True
        Me.vendorid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vendorid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.vendorid.Properties.Mask.BeepOnError = True
        Me.vendorid.Properties.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(33, 22)
        Me.vendorid.TabIndex = 541
        Me.vendorid.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(256, 59)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl11.TabIndex = 540
        Me.LabelControl11.Text = "Add this item to"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(237, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl1.TabIndex = 543
        Me.LabelControl1.Text = "Register supplier to"
        '
        'gridcompoffice
        '
        Me.gridcompoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcompoffice.Name = "gridcompoffice"
        Me.gridcompoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcompoffice.OptionsView.ShowGroupPanel = False
        '
        'txtofficename
        '
        Me.txtofficename.EditValue = ""
        Me.txtofficename.EnterMoveNextControl = True
        Me.txtofficename.Location = New System.Drawing.Point(345, 33)
        Me.txtofficename.Name = "txtofficename"
        Me.txtofficename.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtofficename.Properties.Appearance.Options.UseFont = True
        Me.txtofficename.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtofficename.Properties.DisplayMember = "Supplier"
        Me.txtofficename.Properties.NullText = ""
        Me.txtofficename.Properties.ValueMember = "Supplier"
        Me.txtofficename.Properties.View = Me.gridcompoffice
        Me.txtofficename.Size = New System.Drawing.Size(253, 20)
        Me.txtofficename.TabIndex = 0
        '
        'itemid
        '
        Me.itemid.EditValue = ""
        Me.itemid.Location = New System.Drawing.Point(290, 169)
        Me.itemid.Name = "itemid"
        Me.itemid.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.itemid.Properties.Appearance.Options.UseFont = True
        Me.itemid.Properties.Appearance.Options.UseTextOptions = True
        Me.itemid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.itemid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.itemid.Properties.Mask.BeepOnError = True
        Me.itemid.Properties.ReadOnly = True
        Me.itemid.Size = New System.Drawing.Size(33, 22)
        Me.itemid.TabIndex = 544
        Me.itemid.Visible = False
        '
        'txtitemname
        '
        Me.txtitemname.EditValue = ""
        Me.txtitemname.Location = New System.Drawing.Point(345, 8)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.Properties.Appearance.Options.UseFont = True
        Me.txtitemname.Properties.Appearance.Options.UseTextOptions = True
        Me.txtitemname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtitemname.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtitemname.Properties.Mask.BeepOnError = True
        Me.txtitemname.Properties.ReadOnly = True
        Me.txtitemname.Size = New System.Drawing.Size(253, 20)
        Me.txtitemname.TabIndex = 545
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(234, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 546
        Me.LabelControl2.Text = "Particular item name"
        '
        'txtcost
        '
        Me.txtcost.EditValue = "0.00"
        Me.txtcost.Location = New System.Drawing.Point(417, 80)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtcost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtcost.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtcost.Properties.Appearance.Options.UseBackColor = True
        Me.txtcost.Properties.Appearance.Options.UseFont = True
        Me.txtcost.Properties.Appearance.Options.UseForeColor = True
        Me.txtcost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtcost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtcost.Properties.Mask.EditMask = "n"
        Me.txtcost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcost.Size = New System.Drawing.Size(109, 26)
        Me.txtcost.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(417, 112)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(180, 30)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save Item Supplier"
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(231, 171)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(54, 20)
        Me.officeid.TabIndex = 551
        Me.officeid.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(187, 171)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 552
        Me.mode.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.vendorid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtcost)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.mode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.itemid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtitemname)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl11)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtofficename)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtVendor)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtunit)
        Me.SplitContainerControl1.Panel1.MinSize = 150
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(612, 432)
        Me.SplitContainerControl1.SplitterPosition = 150
        Me.SplitContainerControl1.TabIndex = 553
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(221, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(188, 13)
        Me.LabelControl4.TabIndex = 555
        Me.LabelControl4.Text = "How much this item they are selling?"
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(140, 171)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 553
        Me.id.Visible = False
        '
        'txtVendor
        '
        Me.txtVendor.EditValue = ""
        Me.txtVendor.EnterMoveNextControl = True
        Me.txtVendor.Location = New System.Drawing.Point(345, 56)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendor.Properties.Appearance.Options.UseFont = True
        Me.txtVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVendor.Properties.DisplayMember = "Supplier"
        Me.txtVendor.Properties.NullText = ""
        Me.txtVendor.Properties.ValueMember = "Supplier"
        Me.txtVendor.Properties.View = Me.g_Vendor
        Me.txtVendor.Size = New System.Drawing.Size(253, 20)
        Me.txtVendor.TabIndex = 1
        '
        'g_Vendor
        '
        Me.g_Vendor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_Vendor.Name = "g_Vendor"
        Me.g_Vendor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_Vendor.OptionsView.ShowGroupPanel = False
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(528, 80)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(69, 26)
        Me.txtunit.TabIndex = 2
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(612, 277)
        Me.Em.TabIndex = 4
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdRemove, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(166, 98)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.building__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(165, 22)
        Me.cmdEdit.Text = "Edit Vendor"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.Coffeecup.My.Resources.Resources.building__minus
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(165, 22)
        Me.cmdRemove.Text = "Remove Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdAddVendor, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAddVendor, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdAddVendor
        '
        Me.cmdAddVendor.Caption = "&If supplier or vendor doesn't exists! Please add new here"
        Me.cmdAddVendor.Id = 2
        Me.cmdAddVendor.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddVendor.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAddVendor.ItemAppearance.Normal.Options.UseFont = True
        Me.cmdAddVendor.ItemAppearance.Normal.Options.UseForeColor = True
        Me.cmdAddVendor.Name = "cmdAddVendor"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(612, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 454)
        Me.barDockControlBottom.Size = New System.Drawing.Size(612, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 432)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(612, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 432)
        '
        'frmVendorsProductInfo
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 454)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmVendorsProductInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particular Item Supplier or Vendor"
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtofficename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtitemname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vendorid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtofficename As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents itemid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtitemname As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtVendor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_Vendor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
