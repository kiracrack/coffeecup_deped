<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewStockout
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
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtproduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtquan = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.stockid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.ttlquan = New DevExpress.XtraEditors.TextEdit()
        Me.serverid = New DevExpress.XtraEditors.TextEdit()
        Me.txtServer = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_server = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pandata = New DevExpress.XtraEditors.PanelControl()
        Me.agentid = New DevExpress.XtraEditors.TextEdit()
        Me.txtagent = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_client = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtbatchcode = New DevExpress.XtraEditors.ButtonEdit()
        Me.panloading = New DevExpress.XtraEditors.PanelControl()
        Me.lblcap = New DevExpress.XtraEditors.LabelControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.timertransfer = New System.Windows.Forms.Timer(Me.components)
        Me.timerbegin = New System.Windows.Forms.Timer(Me.components)
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttlquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.serverid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_server, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pandata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandata.SuspendLayout()
        CType(Me.agentid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtagent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_client, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbatchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panloading.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(190, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 575
        Me.LabelControl5.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(195, 335)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 574
        Me.LabelControl4.Text = "Send to"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(177, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 572
        Me.LabelControl3.Text = "Batch Code"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(125, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl1.TabIndex = 573
        Me.LabelControl1.Text = "Select From Inventory"
        '
        'txtproduct
        '
        Me.txtproduct.EditValue = ""
        Me.txtproduct.Location = New System.Drawing.Point(235, 36)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtproduct.Properties.DisplayMember = "Item Name"
        Me.txtproduct.Properties.NullText = ""
        Me.txtproduct.Properties.ValueMember = "Item Name"
        Me.txtproduct.Properties.View = Me.g_product
        Me.txtproduct.Size = New System.Drawing.Size(195, 20)
        Me.txtproduct.TabIndex = 0
        '
        'g_product
        '
        Me.g_product.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_product.Name = "g_product"
        Me.g_product.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_product.OptionsView.ShowGroupPanel = False
        '
        'txtquan
        '
        Me.txtquan.EditValue = "0.00"
        Me.txtquan.Location = New System.Drawing.Point(235, 60)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquan.Properties.Appearance.Options.UseFont = True
        Me.txtquan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtquan.Size = New System.Drawing.Size(144, 25)
        Me.txtquan.TabIndex = 1
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(9, 126)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(421, 197)
        Me.Em.TabIndex = 578
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HiToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 26)
        '
        'HiToolStripMenuItem
        '
        Me.HiToolStripMenuItem.Image = Global.SalesManagement.My.Resources.Resources.blog__minus
        Me.HiToolStripMenuItem.Name = "HiToolStripMenuItem"
        Me.HiToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HiToolStripMenuItem.Text = "Remove Selected"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(299, 90)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(131, 28)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = "Add to Batch"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(299, 380)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 28)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Confirm and Send"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Clear"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(439, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 445)
        Me.barDockControlBottom.Size = New System.Drawing.Size(439, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 423)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(439, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 423)
        '
        'stockid
        '
        Me.stockid.EnterMoveNextControl = True
        Me.stockid.Location = New System.Drawing.Point(9, 39)
        Me.stockid.Name = "stockid"
        Me.stockid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockid.Properties.Appearance.Options.UseFont = True
        Me.stockid.Properties.Appearance.Options.UseTextOptions = True
        Me.stockid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.stockid.Properties.ReadOnly = True
        Me.stockid.Size = New System.Drawing.Size(53, 20)
        Me.stockid.TabIndex = 585
        Me.stockid.Visible = False
        '
        'productid
        '
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(9, 67)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.productid.Properties.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(53, 20)
        Me.productid.TabIndex = 585
        Me.productid.Visible = False
        '
        'ttlquan
        '
        Me.ttlquan.EnterMoveNextControl = True
        Me.ttlquan.Location = New System.Drawing.Point(8, 93)
        Me.ttlquan.Name = "ttlquan"
        Me.ttlquan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlquan.Properties.Appearance.Options.UseFont = True
        Me.ttlquan.Properties.Appearance.Options.UseTextOptions = True
        Me.ttlquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ttlquan.Properties.ReadOnly = True
        Me.ttlquan.Size = New System.Drawing.Size(53, 20)
        Me.ttlquan.TabIndex = 590
        Me.ttlquan.Visible = False
        '
        'serverid
        '
        Me.serverid.EnterMoveNextControl = True
        Me.serverid.Location = New System.Drawing.Point(240, 383)
        Me.serverid.Name = "serverid"
        Me.serverid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serverid.Properties.Appearance.Options.UseFont = True
        Me.serverid.Properties.Appearance.Options.UseTextOptions = True
        Me.serverid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.serverid.Properties.ReadOnly = True
        Me.serverid.Size = New System.Drawing.Size(53, 20)
        Me.serverid.TabIndex = 595
        Me.serverid.Visible = False
        '
        'txtServer
        '
        Me.txtServer.EditValue = ""
        Me.txtServer.Location = New System.Drawing.Point(235, 332)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtServer.Properties.DisplayMember = "Server Name"
        Me.txtServer.Properties.NullText = ""
        Me.txtServer.Properties.ValueMember = "Server Name"
        Me.txtServer.Properties.View = Me.g_server
        Me.txtServer.Size = New System.Drawing.Size(195, 20)
        Me.txtServer.TabIndex = 3
        '
        'g_server
        '
        Me.g_server.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_server.Name = "g_server"
        Me.g_server.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_server.OptionsView.ShowGroupPanel = False
        '
        'pandata
        '
        Me.pandata.Controls.Add(Me.txtunit)
        Me.pandata.Controls.Add(Me.agentid)
        Me.pandata.Controls.Add(Me.txtagent)
        Me.pandata.Controls.Add(Me.LabelControl2)
        Me.pandata.Controls.Add(Me.txtbatchcode)
        Me.pandata.Controls.Add(Me.panloading)
        Me.pandata.Controls.Add(Me.LabelControl3)
        Me.pandata.Controls.Add(Me.txtServer)
        Me.pandata.Controls.Add(Me.serverid)
        Me.pandata.Controls.Add(Me.ttlquan)
        Me.pandata.Controls.Add(Me.productid)
        Me.pandata.Controls.Add(Me.stockid)
        Me.pandata.Controls.Add(Me.SimpleButton1)
        Me.pandata.Controls.Add(Me.cmdadd)
        Me.pandata.Controls.Add(Me.Em)
        Me.pandata.Controls.Add(Me.LabelControl5)
        Me.pandata.Controls.Add(Me.LabelControl4)
        Me.pandata.Controls.Add(Me.LabelControl1)
        Me.pandata.Controls.Add(Me.txtproduct)
        Me.pandata.Controls.Add(Me.txtquan)
        Me.pandata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pandata.Location = New System.Drawing.Point(0, 22)
        Me.pandata.Name = "pandata"
        Me.pandata.Size = New System.Drawing.Size(439, 423)
        Me.pandata.TabIndex = 605
        '
        'agentid
        '
        Me.agentid.EnterMoveNextControl = True
        Me.agentid.Location = New System.Drawing.Point(179, 383)
        Me.agentid.Name = "agentid"
        Me.agentid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agentid.Properties.Appearance.Options.UseFont = True
        Me.agentid.Properties.Appearance.Options.UseTextOptions = True
        Me.agentid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.agentid.Properties.ReadOnly = True
        Me.agentid.Size = New System.Drawing.Size(53, 20)
        Me.agentid.TabIndex = 605
        Me.agentid.Visible = False
        '
        'txtagent
        '
        Me.txtagent.EditValue = ""
        Me.txtagent.Location = New System.Drawing.Point(235, 356)
        Me.txtagent.Name = "txtagent"
        Me.txtagent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagent.Properties.Appearance.Options.UseFont = True
        Me.txtagent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtagent.Properties.DisplayMember = "Fullname"
        Me.txtagent.Properties.NullText = ""
        Me.txtagent.Properties.ValueMember = "Fullname"
        Me.txtagent.Properties.View = Me.g_client
        Me.txtagent.Size = New System.Drawing.Size(195, 20)
        Me.txtagent.TabIndex = 4
        '
        'g_client
        '
        Me.g_client.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_client.Name = "g_client"
        Me.g_client.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_client.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(184, 359)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 604
        Me.LabelControl2.Text = "Deliver By"
        '
        'txtbatchcode
        '
        Me.txtbatchcode.EditValue = ""
        Me.txtbatchcode.Location = New System.Drawing.Point(235, 10)
        Me.txtbatchcode.Name = "txtbatchcode"
        Me.txtbatchcode.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.txtbatchcode.Properties.Appearance.Options.UseFont = True
        Me.txtbatchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtbatchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtbatchcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtbatchcode.Properties.Mask.BeepOnError = True
        Me.txtbatchcode.Properties.ReadOnly = True
        Me.txtbatchcode.Size = New System.Drawing.Size(195, 22)
        Me.txtbatchcode.TabIndex = 602
        '
        'panloading
        '
        Me.panloading.Controls.Add(Me.lblcap)
        Me.panloading.Controls.Add(Me.ProgressBarControl1)
        Me.panloading.Location = New System.Drawing.Point(65, 173)
        Me.panloading.Name = "panloading"
        Me.panloading.Size = New System.Drawing.Size(314, 78)
        Me.panloading.TabIndex = 601
        Me.panloading.Visible = False
        '
        'lblcap
        '
        Me.lblcap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblcap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblcap.Location = New System.Drawing.Point(28, 53)
        Me.lblcap.Name = "lblcap"
        Me.lblcap.Size = New System.Drawing.Size(260, 13)
        Me.lblcap.TabIndex = 1
        Me.lblcap.Text = "Sending..."
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(28, 24)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(260, 20)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'timertransfer
        '
        Me.timertransfer.Interval = 1000
        '
        'timerbegin
        '
        Me.timerbegin.Interval = 5000
        '
        'txtunit
        '
        Me.txtunit.EditValue = ""
        Me.txtunit.Location = New System.Drawing.Point(382, 60)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(48, 25)
        Me.txtunit.TabIndex = 606
        '
        'frmNewStockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 445)
        Me.Controls.Add(Me.pandata)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewStockout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Stockout"
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttlquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.serverid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_server, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pandata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandata.ResumeLayout(False)
        Me.pandata.PerformLayout()
        CType(Me.agentid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtagent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_client, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbatchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panloading.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttlquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents serverid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServer As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_server As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pandata As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panloading As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblcap As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents timertransfer As System.Windows.Forms.Timer
    Friend WithEvents timerbegin As System.Windows.Forms.Timer
    Friend WithEvents txtbatchcode As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtagent As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_client As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents agentid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
End Class
