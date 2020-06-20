<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomRate
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
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
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
        Me.ckActived = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.ckLockrate = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllowZero = New DevExpress.XtraEditors.CheckEdit()
        Me.Em2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRoomType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hotelcif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLockrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllowZero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(608, 270)
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
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(403, 93)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(107, 26)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        '
        'txtRoomType
        '
        Me.txtRoomType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoomType.EditValue = ""
        Me.txtRoomType.EnterMoveNextControl = True
        Me.txtRoomType.Location = New System.Drawing.Point(403, 16)
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
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(335, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 15)
        Me.LabelControl1.TabIndex = 688
        Me.LabelControl1.Text = "Room Type"
        '
        'id
        '
        Me.id.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(660, 270)
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
        Me.Em.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode3.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        Me.Em.Location = New System.Drawing.Point(5, 127)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(287, 365)
        Me.Em.TabIndex = 697
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.BreakdownConfigationToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(237, 98)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(236, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(236, 22)
        Me.cmdDelete.Text = "Remove Selected"
        '
        'BreakdownConfigationToolStripMenuItem
        '
        Me.BreakdownConfigationToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.blogs_stack
        Me.BreakdownConfigationToolStripMenuItem.Name = "BreakdownConfigationToolStripMenuItem"
        Me.BreakdownConfigationToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BreakdownConfigationToolStripMenuItem.Text = "Configure Package Breakdown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(233, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
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
        Me.typecode.Location = New System.Drawing.Point(559, 270)
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
        Me.hotelcif.Location = New System.Drawing.Point(510, 270)
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
        'ckActived
        '
        Me.ckActived.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckActived.EditValue = True
        Me.ckActived.Location = New System.Drawing.Point(518, 68)
        Me.ckActived.Name = "ckActived"
        Me.ckActived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckActived.Properties.Appearance.Options.UseFont = True
        Me.ckActived.Properties.Caption = "Active Rate"
        Me.ckActived.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckActived.Size = New System.Drawing.Size(84, 19)
        Me.ckActived.TabIndex = 722
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(336, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 15)
        Me.LabelControl3.TabIndex = 732
        Me.LabelControl3.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(403, 42)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.NullText = "Room Description"
        Me.txtDescription.Size = New System.Drawing.Size(226, 22)
        Me.txtDescription.TabIndex = 731
        '
        'ckLockrate
        '
        Me.ckLockrate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckLockrate.EditValue = True
        Me.ckLockrate.Location = New System.Drawing.Point(44, 17)
        Me.ckLockrate.Name = "ckLockrate"
        Me.ckLockrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckLockrate.Properties.Appearance.Options.UseFont = True
        Me.ckLockrate.Properties.Caption = "Lock Rate"
        Me.ckLockrate.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckLockrate.Size = New System.Drawing.Size(78, 19)
        Me.ckLockrate.TabIndex = 733
        Me.ckLockrate.Visible = False
        '
        'ckAllowZero
        '
        Me.ckAllowZero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckAllowZero.EditValue = True
        Me.ckAllowZero.Location = New System.Drawing.Point(403, 68)
        Me.ckAllowZero.Name = "ckAllowZero"
        Me.ckAllowZero.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAllowZero.Properties.Appearance.Options.UseFont = True
        Me.ckAllowZero.Properties.Caption = "Allow Zero Rate"
        Me.ckAllowZero.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckAllowZero.Size = New System.Drawing.Size(109, 19)
        Me.ckAllowZero.TabIndex = 734
        '
        'Em2
        '
        Me.Em2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em2.ContextMenuStrip = Me.ContextMenuStrip1
        GridLevelNode1.RelationName = "Level1"
        Me.Em2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em2.Location = New System.Drawing.Point(298, 127)
        Me.Em2.MainView = Me.GridView2
        Me.Em2.Name = "Em2"
        Me.Em2.Size = New System.Drawing.Size(645, 365)
        Me.Em2.TabIndex = 735
        Me.Em2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(237, 54)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.blogs_stack
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(236, 22)
        Me.ToolStripMenuItem3.Text = "Configure Package Breakdown"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(233, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(236, 22)
        Me.ToolStripMenuItem4.Text = "Refresh Data"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Em2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'code
        '
        Me.code.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.code.EditValue = ""
        Me.code.Location = New System.Drawing.Point(835, 90)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.NullText = "Room Description"
        Me.code.Size = New System.Drawing.Size(70, 22)
        Me.code.TabIndex = 736
        Me.code.Visible = False
        '
        'frmHotelRoomRate
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(955, 496)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Em2)
        Me.Controls.Add(Me.ckAllowZero)
        Me.Controls.Add(Me.ckLockrate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.ckActived)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.typecode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Em)
        Me.MinimumSize = New System.Drawing.Size(971, 535)
        Me.Name = "frmHotelRoomRate"
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
        CType(Me.ckActived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLockrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllowZero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ckActived As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckLockrate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllowZero As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Em2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BreakdownConfigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
End Class
