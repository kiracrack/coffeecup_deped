<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomRate1
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
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRoomType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridRoomType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakdownConfigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.typecode = New DevExpress.XtraEditors.TextEdit()
        Me.hotelcif = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.packageadult = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdultPackage = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridAdult = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtChildPackage = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridChild = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtExtraPerson = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridExtraperson = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckEntraperson = New DevExpress.XtraEditors.CheckEdit()
        Me.ckChild = New DevExpress.XtraEditors.CheckEdit()
        Me.packagechild = New DevExpress.XtraEditors.TextEdit()
        Me.packageExtraperson = New DevExpress.XtraEditors.TextEdit()
        Me.ckActived = New DevExpress.XtraEditors.CheckEdit()
        Me.ckEnableExtraNight = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExtraNight = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridExtraNight = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.extraNight = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRoomType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.packageadult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultPackage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChildPackage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExtraperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEntraperson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckChild.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.packagechild.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.packageExtraperson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableExtraNight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraNight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridExtraNight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extraNight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(570, 270)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseForeColor = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(43, 22)
        Me.mode.TabIndex = 100
        Me.mode.Visible = False
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
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(357, 193)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(107, 26)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        '
        'txtRoomType
        '
        Me.txtRoomType.EditValue = ""
        Me.txtRoomType.EnterMoveNextControl = True
        Me.txtRoomType.Location = New System.Drawing.Point(357, 15)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomType.Properties.Appearance.Options.UseFont = True
        Me.txtRoomType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRoomType.Properties.DisplayMember = "Description"
        Me.txtRoomType.Properties.ImmediatePopup = True
        Me.txtRoomType.Properties.NullText = ""
        Me.txtRoomType.Properties.ValueMember = "Description"
        Me.txtRoomType.Properties.View = Me.gridRoomType
        Me.txtRoomType.Size = New System.Drawing.Size(226, 22)
        Me.txtRoomType.TabIndex = 0
        '
        'gridRoomType
        '
        Me.gridRoomType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRoomType.Name = "gridRoomType"
        Me.gridRoomType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRoomType.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(289, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 15)
        Me.LabelControl1.TabIndex = 688
        Me.LabelControl1.Text = "Room Type"
        '
        'id
        '
        Me.id.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(622, 270)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Properties.Appearance.Options.UseForeColor = True
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(43, 22)
        Me.id.TabIndex = 689
        Me.id.Visible = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode2.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em.Location = New System.Drawing.Point(5, 240)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(868, 377)
        Me.Em.TabIndex = 697
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.BreakdownConfigationToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(181, 98)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(180, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(180, 22)
        Me.cmdDelete.Text = "Remove Selected"
        '
        'BreakdownConfigationToolStripMenuItem
        '
        Me.BreakdownConfigationToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.blogs_stack
        Me.BreakdownConfigationToolStripMenuItem.Name = "BreakdownConfigationToolStripMenuItem"
        Me.BreakdownConfigationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BreakdownConfigationToolStripMenuItem.Text = "Package Breakdown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'typecode
        '
        Me.typecode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.typecode.EnterMoveNextControl = True
        Me.typecode.Location = New System.Drawing.Point(521, 270)
        Me.typecode.Name = "typecode"
        Me.typecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.typecode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.typecode.Properties.Appearance.Options.UseFont = True
        Me.typecode.Properties.Appearance.Options.UseForeColor = True
        Me.typecode.Properties.Appearance.Options.UseTextOptions = True
        Me.typecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.typecode.Properties.ReadOnly = True
        Me.typecode.Size = New System.Drawing.Size(43, 22)
        Me.typecode.TabIndex = 698
        Me.typecode.Visible = False
        '
        'hotelcif
        '
        Me.hotelcif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.hotelcif.EnterMoveNextControl = True
        Me.hotelcif.Location = New System.Drawing.Point(472, 270)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcif.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.hotelcif.Properties.Appearance.Options.UseFont = True
        Me.hotelcif.Properties.Appearance.Options.UseForeColor = True
        Me.hotelcif.Properties.Appearance.Options.UseTextOptions = True
        Me.hotelcif.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.hotelcif.Properties.ReadOnly = True
        Me.hotelcif.Size = New System.Drawing.Size(43, 22)
        Me.hotelcif.TabIndex = 702
        Me.hotelcif.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(357, 65)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Size = New System.Drawing.Size(107, 22)
        Me.txtAmount.TabIndex = 703
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(294, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 704
        Me.LabelControl2.Text = "Room Rate"
        '
        'packageadult
        '
        Me.packageadult.EnterMoveNextControl = True
        Me.packageadult.Location = New System.Drawing.Point(589, 40)
        Me.packageadult.Name = "packageadult"
        Me.packageadult.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.packageadult.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.packageadult.Properties.Appearance.Options.UseFont = True
        Me.packageadult.Properties.Appearance.Options.UseForeColor = True
        Me.packageadult.Properties.Appearance.Options.UseTextOptions = True
        Me.packageadult.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.packageadult.Properties.ReadOnly = True
        Me.packageadult.Size = New System.Drawing.Size(43, 22)
        Me.packageadult.TabIndex = 708
        Me.packageadult.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(468, 69)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 15)
        Me.LabelControl4.TabIndex = 709
        Me.LabelControl4.Text = "Per Pax"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(245, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 15)
        Me.LabelControl5.TabIndex = 711
        Me.LabelControl5.Text = "Room Rate Package"
        '
        'txtAdultPackage
        '
        Me.txtAdultPackage.EditValue = ""
        Me.txtAdultPackage.Location = New System.Drawing.Point(357, 40)
        Me.txtAdultPackage.Name = "txtAdultPackage"
        Me.txtAdultPackage.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdultPackage.Properties.Appearance.Options.UseFont = True
        Me.txtAdultPackage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAdultPackage.Properties.DisplayMember = "Item Name"
        Me.txtAdultPackage.Properties.NullText = ""
        Me.txtAdultPackage.Properties.ValueMember = "Item Name"
        Me.txtAdultPackage.Properties.View = Me.gridAdult
        Me.txtAdultPackage.Size = New System.Drawing.Size(226, 22)
        Me.txtAdultPackage.TabIndex = 710
        '
        'gridAdult
        '
        Me.gridAdult.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridAdult.Name = "gridAdult"
        Me.gridAdult.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridAdult.OptionsView.ShowGroupPanel = False
        '
        'txtChildPackage
        '
        Me.txtChildPackage.EditValue = ""
        Me.txtChildPackage.Enabled = False
        Me.txtChildPackage.Location = New System.Drawing.Point(357, 115)
        Me.txtChildPackage.Name = "txtChildPackage"
        Me.txtChildPackage.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChildPackage.Properties.Appearance.Options.UseFont = True
        Me.txtChildPackage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtChildPackage.Properties.DisplayMember = "Item Name"
        Me.txtChildPackage.Properties.NullText = ""
        Me.txtChildPackage.Properties.ValueMember = "Item Name"
        Me.txtChildPackage.Properties.View = Me.gridChild
        Me.txtChildPackage.Size = New System.Drawing.Size(226, 22)
        Me.txtChildPackage.TabIndex = 712
        '
        'gridChild
        '
        Me.gridChild.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridChild.Name = "gridChild"
        Me.gridChild.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridChild.OptionsView.ShowGroupPanel = False
        '
        'txtExtraPerson
        '
        Me.txtExtraPerson.EditValue = ""
        Me.txtExtraPerson.Enabled = False
        Me.txtExtraPerson.Location = New System.Drawing.Point(357, 141)
        Me.txtExtraPerson.Name = "txtExtraPerson"
        Me.txtExtraPerson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExtraPerson.Properties.Appearance.Options.UseFont = True
        Me.txtExtraPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtExtraPerson.Properties.DisplayMember = "Item Name"
        Me.txtExtraPerson.Properties.NullText = ""
        Me.txtExtraPerson.Properties.ValueMember = "Item Name"
        Me.txtExtraPerson.Properties.View = Me.gridExtraperson
        Me.txtExtraPerson.Size = New System.Drawing.Size(226, 22)
        Me.txtExtraPerson.TabIndex = 714
        '
        'gridExtraperson
        '
        Me.gridExtraperson.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridExtraperson.Name = "gridExtraperson"
        Me.gridExtraperson.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridExtraperson.OptionsView.ShowGroupPanel = False
        '
        'ckEntraperson
        '
        Me.ckEntraperson.Location = New System.Drawing.Point(190, 141)
        Me.ckEntraperson.Name = "ckEntraperson"
        Me.ckEntraperson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEntraperson.Properties.Appearance.Options.UseFont = True
        Me.ckEntraperson.Properties.Appearance.Options.UseTextOptions = True
        Me.ckEntraperson.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckEntraperson.Properties.Caption = "Package for Extra Person"
        Me.ckEntraperson.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckEntraperson.Size = New System.Drawing.Size(160, 19)
        Me.ckEntraperson.TabIndex = 718
        '
        'ckChild
        '
        Me.ckChild.Location = New System.Drawing.Point(190, 116)
        Me.ckChild.Name = "ckChild"
        Me.ckChild.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckChild.Properties.Appearance.Options.UseFont = True
        Me.ckChild.Properties.Appearance.Options.UseTextOptions = True
        Me.ckChild.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckChild.Properties.Caption = "Package for Child"
        Me.ckChild.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckChild.Size = New System.Drawing.Size(160, 19)
        Me.ckChild.TabIndex = 719
        '
        'packagechild
        '
        Me.packagechild.EnterMoveNextControl = True
        Me.packagechild.Location = New System.Drawing.Point(589, 113)
        Me.packagechild.Name = "packagechild"
        Me.packagechild.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.packagechild.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.packagechild.Properties.Appearance.Options.UseFont = True
        Me.packagechild.Properties.Appearance.Options.UseForeColor = True
        Me.packagechild.Properties.Appearance.Options.UseTextOptions = True
        Me.packagechild.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.packagechild.Properties.ReadOnly = True
        Me.packagechild.Size = New System.Drawing.Size(43, 22)
        Me.packagechild.TabIndex = 720
        Me.packagechild.Visible = False
        '
        'packageExtraperson
        '
        Me.packageExtraperson.EnterMoveNextControl = True
        Me.packageExtraperson.Location = New System.Drawing.Point(589, 138)
        Me.packageExtraperson.Name = "packageExtraperson"
        Me.packageExtraperson.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.packageExtraperson.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.packageExtraperson.Properties.Appearance.Options.UseFont = True
        Me.packageExtraperson.Properties.Appearance.Options.UseForeColor = True
        Me.packageExtraperson.Properties.Appearance.Options.UseTextOptions = True
        Me.packageExtraperson.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.packageExtraperson.Properties.ReadOnly = True
        Me.packageExtraperson.Size = New System.Drawing.Size(43, 22)
        Me.packageExtraperson.TabIndex = 721
        Me.packageExtraperson.Visible = False
        '
        'ckActived
        '
        Me.ckActived.Location = New System.Drawing.Point(357, 168)
        Me.ckActived.Name = "ckActived"
        Me.ckActived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckActived.Properties.Appearance.Options.UseFont = True
        Me.ckActived.Properties.Caption = "Active"
        Me.ckActived.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckActived.Size = New System.Drawing.Size(107, 19)
        Me.ckActived.TabIndex = 722
        '
        'ckEnableExtraNight
        '
        Me.ckEnableExtraNight.Location = New System.Drawing.Point(190, 92)
        Me.ckEnableExtraNight.Name = "ckEnableExtraNight"
        Me.ckEnableExtraNight.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableExtraNight.Properties.Appearance.Options.UseFont = True
        Me.ckEnableExtraNight.Properties.Appearance.Options.UseTextOptions = True
        Me.ckEnableExtraNight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckEnableExtraNight.Properties.Caption = "Extra Night"
        Me.ckEnableExtraNight.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckEnableExtraNight.Size = New System.Drawing.Size(160, 19)
        Me.ckEnableExtraNight.TabIndex = 724
        '
        'txtExtraNight
        '
        Me.txtExtraNight.EditValue = ""
        Me.txtExtraNight.Enabled = False
        Me.txtExtraNight.Location = New System.Drawing.Point(357, 90)
        Me.txtExtraNight.Name = "txtExtraNight"
        Me.txtExtraNight.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExtraNight.Properties.Appearance.Options.UseFont = True
        Me.txtExtraNight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtExtraNight.Properties.DisplayMember = "Item Name"
        Me.txtExtraNight.Properties.NullText = ""
        Me.txtExtraNight.Properties.ValueMember = "Item Name"
        Me.txtExtraNight.Properties.View = Me.gridExtraNight
        Me.txtExtraNight.Size = New System.Drawing.Size(226, 22)
        Me.txtExtraNight.TabIndex = 723
        '
        'gridExtraNight
        '
        Me.gridExtraNight.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridExtraNight.Name = "gridExtraNight"
        Me.gridExtraNight.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridExtraNight.OptionsView.ShowGroupPanel = False
        '
        'extraNight
        '
        Me.extraNight.EnterMoveNextControl = True
        Me.extraNight.Location = New System.Drawing.Point(589, 89)
        Me.extraNight.Name = "extraNight"
        Me.extraNight.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.extraNight.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.extraNight.Properties.Appearance.Options.UseFont = True
        Me.extraNight.Properties.Appearance.Options.UseForeColor = True
        Me.extraNight.Properties.Appearance.Options.UseTextOptions = True
        Me.extraNight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.extraNight.Properties.ReadOnly = True
        Me.extraNight.Size = New System.Drawing.Size(43, 22)
        Me.extraNight.TabIndex = 725
        Me.extraNight.Visible = False
        '
        'frmHotelRoomRate1
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(878, 621)
        Me.Controls.Add(Me.extraNight)
        Me.Controls.Add(Me.ckEnableExtraNight)
        Me.Controls.Add(Me.txtExtraNight)
        Me.Controls.Add(Me.ckActived)
        Me.Controls.Add(Me.packageExtraperson)
        Me.Controls.Add(Me.packagechild)
        Me.Controls.Add(Me.ckChild)
        Me.Controls.Add(Me.ckEntraperson)
        Me.Controls.Add(Me.txtExtraPerson)
        Me.Controls.Add(Me.txtChildPackage)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtAdultPackage)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.packageadult)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.typecode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Em)
        Me.Name = "frmHotelRoomRate1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Rate"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRoomType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.packageadult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultPackage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAdult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChildPackage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExtraperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEntraperson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckChild.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.packagechild.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.packageExtraperson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableExtraNight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraNight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridExtraNight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extraNight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRoomType As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridRoomType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents typecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hotelcif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BreakdownConfigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents packageadult As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdultPackage As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridAdult As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtChildPackage As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridChild As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtExtraPerson As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridExtraperson As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckEntraperson As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckChild As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents packagechild As DevExpress.XtraEditors.TextEdit
    Friend WithEvents packageExtraperson As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckActived As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckEnableExtraNight As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtExtraNight As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridExtraNight As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents extraNight As DevExpress.XtraEditors.TextEdit
End Class
