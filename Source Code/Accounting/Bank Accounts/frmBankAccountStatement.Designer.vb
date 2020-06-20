<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccountStatement
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
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtTotalDebit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentBalance = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalPurchase = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCredit = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.accountno = New DevExpress.XtraEditors.TextEdit()
        Me.txtBankAccountName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtdateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtTotalDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBankAccountName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarLargeButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem1, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar3
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 3"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Close Window"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&Show Search Panel"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Statement"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Export to Excel"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 564)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 542)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 542)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTotalDebit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDateTo)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtCurrentBalance)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblTotalPurchase)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTotalCredit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.accountno)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtBankAccountName)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtdateFrom)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1028, 542)
        Me.SplitContainerControl1.SplitterPosition = 68
        Me.SplitContainerControl1.TabIndex = 11
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtTotalDebit
        '
        Me.txtTotalDebit.EditValue = ""
        Me.txtTotalDebit.Location = New System.Drawing.Point(646, 32)
        Me.txtTotalDebit.Name = "txtTotalDebit"
        Me.txtTotalDebit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtTotalDebit.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalDebit.Properties.Mask.EditMask = "n"
        Me.txtTotalDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDebit.Properties.ReadOnly = True
        Me.txtTotalDebit.Size = New System.Drawing.Size(139, 26)
        Me.txtTotalDebit.TabIndex = 698
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(646, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 699
        Me.LabelControl1.Text = "Total Debit"
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = New Date(CType(0, Long))
        Me.txtDateTo.EnterMoveNextControl = True
        Me.txtDateTo.Location = New System.Drawing.Point(485, 32)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDateTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(155, 26)
        Me.txtDateTo.TabIndex = 702
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(485, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.TabIndex = 703
        Me.LabelControl2.Text = "Date to as of"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(936, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 701
        Me.LabelControl4.Text = "Current Balance"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.EditValue = ""
        Me.txtCurrentBalance.Location = New System.Drawing.Point(936, 32)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCurrentBalance.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentBalance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCurrentBalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCurrentBalance.Properties.Mask.EditMask = "n"
        Me.txtCurrentBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCurrentBalance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCurrentBalance.Properties.ReadOnly = True
        Me.txtCurrentBalance.Size = New System.Drawing.Size(139, 26)
        Me.txtCurrentBalance.TabIndex = 700
        '
        'lblTotalPurchase
        '
        Me.lblTotalPurchase.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPurchase.Location = New System.Drawing.Point(791, 15)
        Me.lblTotalPurchase.Name = "lblTotalPurchase"
        Me.lblTotalPurchase.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalPurchase.TabIndex = 697
        Me.lblTotalPurchase.Text = "Total Credit"
        '
        'txtTotalCredit
        '
        Me.txtTotalCredit.EditValue = ""
        Me.txtTotalCredit.Location = New System.Drawing.Point(791, 32)
        Me.txtTotalCredit.Name = "txtTotalCredit"
        Me.txtTotalCredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtTotalCredit.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCredit.Properties.Mask.EditMask = "n"
        Me.txtTotalCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCredit.Properties.ReadOnly = True
        Me.txtTotalCredit.Size = New System.Drawing.Size(139, 26)
        Me.txtTotalCredit.TabIndex = 696
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(152, 11)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.CheckEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Properties.Caption = "Show zero account balance"
        Me.CheckEdit1.Size = New System.Drawing.Size(163, 19)
        Me.CheckEdit1.TabIndex = 590
        '
        'accountno
        '
        Me.accountno.Location = New System.Drawing.Point(786, 75)
        Me.accountno.Name = "accountno"
        Me.accountno.Properties.ReadOnly = True
        Me.accountno.Size = New System.Drawing.Size(73, 20)
        Me.accountno.TabIndex = 589
        Me.accountno.Visible = False
        '
        'txtBankAccountName
        '
        Me.txtBankAccountName.EditValue = ""
        Me.txtBankAccountName.Location = New System.Drawing.Point(10, 32)
        Me.txtBankAccountName.Name = "txtBankAccountName"
        Me.txtBankAccountName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtBankAccountName.Properties.Appearance.Options.UseFont = True
        Me.txtBankAccountName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBankAccountName.Properties.DisplayMember = "Bank Account"
        Me.txtBankAccountName.Properties.NullText = ""
        Me.txtBankAccountName.Properties.ValueMember = "Bank Account"
        Me.txtBankAccountName.Properties.View = Me.gridClient
        Me.txtBankAccountName.Size = New System.Drawing.Size(308, 26)
        Me.txtBankAccountName.TabIndex = 580
        '
        'gridClient
        '
        Me.gridClient.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridClient.Name = "gridClient"
        Me.gridClient.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridClient.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.Location = New System.Drawing.Point(12, 15)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(75, 13)
        Me.lblOffice.TabIndex = 584
        Me.lblOffice.Text = "Select Account"
        '
        'txtdateFrom
        '
        Me.txtdateFrom.EditValue = New Date(CType(0, Long))
        Me.txtdateFrom.EnterMoveNextControl = True
        Me.txtdateFrom.Location = New System.Drawing.Point(324, 32)
        Me.txtdateFrom.Name = "txtdateFrom"
        Me.txtdateFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtdateFrom.Properties.Appearance.Options.UseFont = True
        Me.txtdateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtdateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtdateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtdateFrom.Size = New System.Drawing.Size(155, 26)
        Me.txtdateFrom.TabIndex = 582
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(324, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 586
        Me.LabelControl3.Text = "Date from"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1028, 469)
        Me.Em.TabIndex = 323
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshLedgerToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(153, 26)
        '
        'RefreshLedgerToolStripMenuItem
        '
        Me.RefreshLedgerToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshLedgerToolStripMenuItem.Name = "RefreshLedgerToolStripMenuItem"
        Me.RefreshLedgerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshLedgerToolStripMenuItem.Text = "Refresh Ledger"
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
        'frmBankAccountStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 564)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmBankAccountStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Account Statement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtTotalDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBankAccountName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtBankAccountName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridClient As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents accountno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblTotalPurchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RefreshLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
End Class
