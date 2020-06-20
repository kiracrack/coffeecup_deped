<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewReceived
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
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.stockid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtstock = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_stocks = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtproduct = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtbatchcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.txtquan = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbatchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(212, 130)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(131, 28)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Confirm"
        '
        'catid
        '
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(134, 247)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(38, 20)
        Me.catid.TabIndex = 547
        Me.catid.Visible = False
        '
        'stockid
        '
        Me.stockid.EnterMoveNextControl = True
        Me.stockid.Location = New System.Drawing.Point(90, 222)
        Me.stockid.Name = "stockid"
        Me.stockid.Size = New System.Drawing.Size(38, 20)
        Me.stockid.TabIndex = 546
        Me.stockid.Visible = False
        '
        'productid
        '
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(90, 248)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(38, 20)
        Me.productid.TabIndex = 545
        Me.productid.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(103, 86)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 544
        Me.LabelControl5.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(84, 110)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl4.TabIndex = 543
        Me.LabelControl4.Text = "Inventory to"
        '
        'txtstock
        '
        Me.txtstock.EditValue = ""
        Me.txtstock.Location = New System.Drawing.Point(148, 107)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtstock.Properties.DisplayMember = "Select Stock"
        Me.txtstock.Properties.NullText = ""
        Me.txtstock.Properties.ValidateOnEnterKey = True
        Me.txtstock.Properties.ValueMember = "Select Stock"
        Me.txtstock.Properties.View = Me.g_stocks
        Me.txtstock.Size = New System.Drawing.Size(195, 20)
        Me.txtstock.TabIndex = 1
        '
        'g_stocks
        '
        Me.g_stocks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_stocks.Name = "g_stocks"
        Me.g_stocks.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_stocks.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(61, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl1.TabIndex = 542
        Me.LabelControl1.Text = "Received Product"
        '
        'txtproduct
        '
        Me.txtproduct.EditValue = ""
        Me.txtproduct.Location = New System.Drawing.Point(148, 33)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtproduct.Properties.DisplayMember = "Product"
        Me.txtproduct.Properties.NullText = ""
        Me.txtproduct.Properties.ValueMember = "trnid"
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
        'txtbatchcode
        '
        Me.txtbatchcode.EnterMoveNextControl = True
        Me.txtbatchcode.Location = New System.Drawing.Point(148, 56)
        Me.txtbatchcode.Name = "txtbatchcode"
        Me.txtbatchcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatchcode.Properties.Appearance.Options.UseFont = True
        Me.txtbatchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtbatchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtbatchcode.Properties.ReadOnly = True
        Me.txtbatchcode.Size = New System.Drawing.Size(195, 20)
        Me.txtbatchcode.TabIndex = 546
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(90, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 542
        Me.LabelControl3.Text = "Batch Code"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Confirm"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Cancel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(438, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 168)
        Me.barDockControlBottom.Size = New System.Drawing.Size(438, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 146)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(438, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 146)
        '
        'trnid
        '
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(90, 274)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(38, 20)
        Me.trnid.TabIndex = 554
        Me.trnid.Visible = False
        '
        'txtquan
        '
        Me.txtquan.EditValue = "0.00"
        Me.txtquan.Location = New System.Drawing.Point(148, 79)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquan.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtquan.Properties.Appearance.Options.UseBackColor = True
        Me.txtquan.Properties.Appearance.Options.UseFont = True
        Me.txtquan.Properties.Appearance.Options.UseForeColor = True
        Me.txtquan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtquan.Properties.ReadOnly = True
        Me.txtquan.Size = New System.Drawing.Size(145, 25)
        Me.txtquan.TabIndex = 564
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(349, 34)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Receive All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 569
        '
        'txtunit
        '
        Me.txtunit.EditValue = ""
        Me.txtunit.Location = New System.Drawing.Point(295, 79)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(48, 25)
        Me.txtunit.TabIndex = 607
        '
        'frmNewReceived
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 168)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.txtbatchcode)
        Me.Controls.Add(Me.stockid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewReceived"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Received Item"
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbatchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtstock As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_stocks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtbatchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtquan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
End Class
