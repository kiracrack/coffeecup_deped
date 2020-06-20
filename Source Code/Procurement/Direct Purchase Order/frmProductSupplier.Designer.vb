<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductSupplier
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
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtofficename = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcost = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProductName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdAddVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.itemid = New DevExpress.XtraEditors.ButtonEdit()
        Me.vendorid = New DevExpress.XtraEditors.ButtonEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtofficename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl11.Location = New System.Drawing.Point(135, 78)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 540
        Me.LabelControl11.Text = "Select Supplier"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(110, 55)
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
        Me.txtofficename.Location = New System.Drawing.Point(217, 52)
        Me.txtofficename.Name = "txtofficename"
        Me.txtofficename.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtofficename.Properties.NullText = ""
        Me.txtofficename.Properties.View = Me.gridcompoffice
        Me.txtofficename.Size = New System.Drawing.Size(253, 20)
        Me.txtofficename.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(139, 102)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl2.TabIndex = 546
        Me.LabelControl2.Text = "Product Name"
        '
        'txtcost
        '
        Me.txtcost.EditValue = "0.00"
        Me.txtcost.Location = New System.Drawing.Point(290, 124)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtcost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.txtcost.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtcost.Properties.Appearance.Options.UseBackColor = True
        Me.txtcost.Properties.Appearance.Options.UseFont = True
        Me.txtcost.Properties.Appearance.Options.UseForeColor = True
        Me.txtcost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtcost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtcost.Properties.Mask.EditMask = "n"
        Me.txtcost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcost.Size = New System.Drawing.Size(109, 24)
        Me.txtcost.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Location = New System.Drawing.Point(290, 153)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(180, 30)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save Product Supplier"
        '
        'txtProductName
        '
        Me.txtProductName.EditValue = ""
        Me.txtProductName.EnterMoveNextControl = True
        Me.txtProductName.Location = New System.Drawing.Point(217, 99)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProductName.Properties.DisplayMember = "Product Name"
        Me.txtProductName.Properties.NullText = ""
        Me.txtProductName.Properties.ValueMember = "Product Name"
        Me.txtProductName.Properties.View = Me.gridProduct
        Me.txtProductName.Size = New System.Drawing.Size(253, 20)
        Me.txtProductName.TabIndex = 556
        '
        'gridProduct
        '
        Me.gridProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridProduct.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(94, 129)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(188, 13)
        Me.LabelControl4.TabIndex = 555
        Me.LabelControl4.Text = "How much this item they are selling?"
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = ""
        Me.txtSupplier.EnterMoveNextControl = True
        Me.txtSupplier.Location = New System.Drawing.Point(217, 75)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplier.Properties.DisplayMember = "Supplier"
        Me.txtSupplier.Properties.NullText = ""
        Me.txtSupplier.Properties.ValueMember = "Supplier"
        Me.txtSupplier.Properties.View = Me.gridSupplier
        Me.txtSupplier.Size = New System.Drawing.Size(253, 20)
        Me.txtSupplier.TabIndex = 1
        '
        'gridSupplier
        '
        Me.gridSupplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridSupplier.OptionsView.ShowGroupPanel = False
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(401, 124)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(69, 24)
        Me.txtunit.TabIndex = 2
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdAddVendor})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAddVendor, True)})
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
        Me.barDockControlTop.Size = New System.Drawing.Size(498, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 208)
        Me.barDockControlBottom.Size = New System.Drawing.Size(498, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 186)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(498, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 186)
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(52, 99)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(54, 20)
        Me.officeid.TabIndex = 551
        Me.officeid.Visible = False
        '
        'itemid
        '
        Me.itemid.EditValue = ""
        Me.itemid.Location = New System.Drawing.Point(34, 141)
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
        'vendorid
        '
        Me.vendorid.EditValue = ""
        Me.vendorid.Location = New System.Drawing.Point(73, 161)
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
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(192, 230)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(38, 20)
        Me.id.TabIndex = 553
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(143, 230)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 557
        Me.mode.Visible = False
        '
        'frmProductSupplier
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 208)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.txtofficename)
        Me.Controls.Add(Me.itemid)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Supplier Tool"
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtofficename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtofficename As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vendorid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents itemid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
End Class
