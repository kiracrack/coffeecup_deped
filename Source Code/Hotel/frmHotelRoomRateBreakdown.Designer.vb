<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomRateBreakdown
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ratecode = New DevExpress.XtraEditors.TextEdit()
        Me.roomtype = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.roomrate = New DevExpress.XtraTab.XtraTabPage()
        Me.child = New DevExpress.XtraTab.XtraTabPage()
        Me.extra = New DevExpress.XtraTab.XtraTabPage()
        Me.txtDayrate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ratecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roomtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.roomrate.SuspendLayout()
        CType(Me.txtDayrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(518, 389)
        Me.Em.TabIndex = 697
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(145, 76)
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__plus
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(144, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
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
        'ratecode
        '
        Me.ratecode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ratecode.EnterMoveNextControl = True
        Me.ratecode.Location = New System.Drawing.Point(426, 237)
        Me.ratecode.Name = "ratecode"
        Me.ratecode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ratecode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ratecode.Properties.Appearance.Options.UseFont = True
        Me.ratecode.Properties.Appearance.Options.UseForeColor = True
        Me.ratecode.Properties.Appearance.Options.UseTextOptions = True
        Me.ratecode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ratecode.Properties.ReadOnly = True
        Me.ratecode.Size = New System.Drawing.Size(43, 22)
        Me.ratecode.TabIndex = 698
        Me.ratecode.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.roomtype.EnterMoveNextControl = True
        Me.roomtype.Location = New System.Drawing.Point(377, 237)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Properties.Appearance.Options.UseFont = True
        Me.roomtype.Properties.Appearance.Options.UseForeColor = True
        Me.roomtype.Properties.Appearance.Options.UseTextOptions = True
        Me.roomtype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.roomtype.Properties.ReadOnly = True
        Me.roomtype.Size = New System.Drawing.Size(43, 22)
        Me.roomtype.TabIndex = 702
        Me.roomtype.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 52)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.roomrate
        Me.XtraTabControl1.Size = New System.Drawing.Size(524, 421)
        Me.XtraTabControl1.TabIndex = 703
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.roomrate, Me.child, Me.extra})
        '
        'roomrate
        '
        Me.roomrate.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.roomrate.Appearance.Header.Options.UseFont = True
        Me.roomrate.Controls.Add(Me.roomtype)
        Me.roomrate.Controls.Add(Me.ratecode)
        Me.roomrate.Controls.Add(Me.Em)
        Me.roomrate.Name = "roomrate"
        Me.roomrate.Size = New System.Drawing.Size(518, 389)
        Me.roomrate.Text = "Room Rate Breakdown"
        '
        'child
        '
        Me.child.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.child.Appearance.Header.Options.UseFont = True
        Me.child.Name = "child"
        Me.child.Size = New System.Drawing.Size(518, 389)
        Me.child.Text = "Child Rate Breakdown"
        '
        'extra
        '
        Me.extra.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.extra.Appearance.Header.Options.UseFont = True
        Me.extra.Name = "extra"
        Me.extra.Size = New System.Drawing.Size(518, 389)
        Me.extra.Text = "Extra Person Rate Breakdown"
        '
        'txtDayrate
        '
        Me.txtDayrate.Location = New System.Drawing.Point(93, 16)
        Me.txtDayrate.Name = "txtDayrate"
        Me.txtDayrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDayrate.Properties.Appearance.Options.UseFont = True
        Me.txtDayrate.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDayrate.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtDayrate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDayrate.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.txtDayrate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDayrate.Size = New System.Drawing.Size(117, 24)
        Me.txtDayrate.TabIndex = 704
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(21, 18)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl6.TabIndex = 705
        Me.LabelControl6.Text = "Select Day"
        '
        'frmHotelRoomRateBreakdown
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(523, 473)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtDayrate)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmHotelRoomRateBreakdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Break Down"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ratecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roomtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.roomrate.ResumeLayout(False)
        CType(Me.txtDayrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ratecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents roomtype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents roomrate As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents child As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents extra As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDayrate As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
