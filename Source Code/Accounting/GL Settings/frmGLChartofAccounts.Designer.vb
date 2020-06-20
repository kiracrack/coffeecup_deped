<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLChartofAccounts
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TreeviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollapseGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.compid = New DevExpress.XtraEditors.TextEdit()
        Me.txtCompany = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView_company = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeviewToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(162, 26)
        '
        'TreeviewToolStripMenuItem
        '
        Me.TreeviewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpandGroupsToolStripMenuItem, Me.CollapseGroupsToolStripMenuItem})
        Me.TreeviewToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.folder_stand
        Me.TreeviewToolStripMenuItem.Name = "TreeviewToolStripMenuItem"
        Me.TreeviewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TreeviewToolStripMenuItem.Text = "Treeview Display"
        '
        'ExpandGroupsToolStripMenuItem
        '
        Me.ExpandGroupsToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.folder_tree
        Me.ExpandGroupsToolStripMenuItem.Name = "ExpandGroupsToolStripMenuItem"
        Me.ExpandGroupsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExpandGroupsToolStripMenuItem.Text = "Expand Groups"
        '
        'CollapseGroupsToolStripMenuItem
        '
        Me.CollapseGroupsToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.folders_stack1
        Me.CollapseGroupsToolStripMenuItem.Name = "CollapseGroupsToolStripMenuItem"
        Me.CollapseGroupsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CollapseGroupsToolStripMenuItem.Text = "Collapse Groups"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenuStrip = Me.gridmenustrip
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TreeView1.Location = New System.Drawing.Point(7, 64)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(629, 529)
        Me.TreeView1.TabIndex = 648
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.BarButtonItem2, Me.BarCheckItem1, Me.BarButtonItem1, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Main menu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.Name = "cmdClose"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Expand View"
        Me.BarCheckItem1.Id = 3
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export to Excel"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(641, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 597)
        Me.barDockControlBottom.Size = New System.Drawing.Size(641, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 575)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(641, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 575)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Addnew Account Title"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Addnew Account Group"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(86, 139)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(473, 265)
        Me.Em.TabIndex = 653
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.Em.Visible = False
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'compid
        '
        Me.compid.EnterMoveNextControl = True
        Me.compid.Location = New System.Drawing.Point(552, 101)
        Me.compid.Name = "compid"
        Me.compid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.compid.Properties.Appearance.Options.UseFont = True
        Me.compid.Size = New System.Drawing.Size(50, 20)
        Me.compid.TabIndex = 745
        Me.compid.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.EditValue = ""
        Me.txtCompany.Location = New System.Drawing.Point(7, 32)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCompany.Properties.DisplayMember = "Select Company"
        Me.txtCompany.Properties.NullText = ""
        Me.txtCompany.Properties.ValueMember = "compid"
        Me.txtCompany.Properties.View = Me.GridView_company
        Me.txtCompany.Size = New System.Drawing.Size(294, 26)
        Me.txtCompany.TabIndex = 746
        '
        'GridView_company
        '
        Me.GridView_company.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView_company.Name = "GridView_company"
        Me.GridView_company.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView_company.OptionsView.ShowGroupPanel = False
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Print to Excel"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'frmGLChartofAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 597)
        Me.Controls.Add(Me.compid)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmGLChartofAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TreeviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollapseGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Public WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents compid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompany As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView_company As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
End Class
