<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutQuantity
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
        Me.txtquantity = New DevExpress.XtraEditors.TextEdit()
        Me.Stockouttypeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtunit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.txtdatestockout = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.catid = New DevExpress.XtraEditors.TextEdit()
        Me.txtAvailableQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStockoutType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtRequestby = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.g_requestor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.requestorid = New DevExpress.XtraEditors.TextEdit()
        Me.ckAllocatedStockout = New DevExpress.XtraEditors.CheckEdit()
        Me.txtoffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcompoffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbloffice = New DevExpress.XtraEditors.LabelControl()
        Me.officeallocated = New DevExpress.XtraEditors.TextEdit()
        Me.stockid = New DevExpress.XtraEditors.TextEdit()
        Me.productid = New DevExpress.XtraEditors.TextEdit()
        Me.purchasedprice = New DevExpress.XtraEditors.TextEdit()
        Me.batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.ckBatch = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stockouttypeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatestockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdatestockout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockoutType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_requestor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestorid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllocatedStockout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeallocated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchasedprice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckBatch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtquantity
        '
        Me.txtquantity.EditValue = "0"
        Me.txtquantity.Location = New System.Drawing.Point(300, 62)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtquantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtquantity.Properties.Appearance.Options.UseBackColor = True
        Me.txtquantity.Properties.Appearance.Options.UseFont = True
        Me.txtquantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtquantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquantity.Size = New System.Drawing.Size(116, 26)
        Me.txtquantity.TabIndex = 0
        '
        'Stockouttypeid
        '
        Me.Stockouttypeid.EditValue = ""
        Me.Stockouttypeid.EnterMoveNextControl = True
        Me.Stockouttypeid.Location = New System.Drawing.Point(18, 382)
        Me.Stockouttypeid.Name = "Stockouttypeid"
        Me.Stockouttypeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stockouttypeid.Properties.Appearance.Options.UseFont = True
        Me.Stockouttypeid.Properties.Appearance.Options.UseTextOptions = True
        Me.Stockouttypeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Stockouttypeid.Size = New System.Drawing.Size(81, 20)
        Me.Stockouttypeid.TabIndex = 512
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(139, 15)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(277, 20)
        Me.txtproduct.TabIndex = 557
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(246, 95)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 556
        Me.LabelControl4.Text = "Item Unit"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(204, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl6.TabIndex = 555
        Me.LabelControl6.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(300, 92)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(116, 20)
        Me.txtunit.TabIndex = 554
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(83, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 558
        Me.LabelControl1.Text = "Particular"
        '
        'officeid
        '
        Me.officeid.EditValue = ""
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(18, 351)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Properties.Appearance.Options.UseTextOptions = True
        Me.officeid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.officeid.Size = New System.Drawing.Size(81, 20)
        Me.officeid.TabIndex = 563
        '
        'txtdatestockout
        '
        Me.txtdatestockout.EditValue = New Date(CType(0, Long))
        Me.txtdatestockout.EnterMoveNextControl = True
        Me.txtdatestockout.Location = New System.Drawing.Point(216, 39)
        Me.txtdatestockout.Name = "txtdatestockout"
        Me.txtdatestockout.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatestockout.Properties.Appearance.Options.UseFont = True
        Me.txtdatestockout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdatestockout.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtdatestockout.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtdatestockout.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtdatestockout.Size = New System.Drawing.Size(200, 20)
        Me.txtdatestockout.TabIndex = 568
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(137, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 569
        Me.LabelControl3.Text = "Date Stockout"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(87, 211)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl11.TabIndex = 575
        Me.LabelControl11.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(139, 209)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(277, 45)
        Me.txtRemarks.TabIndex = 3
        '
        'catid
        '
        Me.catid.EditValue = ""
        Me.catid.EnterMoveNextControl = True
        Me.catid.Location = New System.Drawing.Point(105, 351)
        Me.catid.Name = "catid"
        Me.catid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Properties.Appearance.Options.UseFont = True
        Me.catid.Properties.Appearance.Options.UseTextOptions = True
        Me.catid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.catid.Size = New System.Drawing.Size(81, 20)
        Me.catid.TabIndex = 580
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.EditValue = ""
        Me.txtAvailableQuantity.EnterMoveNextControl = True
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(16, 320)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(81, 20)
        Me.txtAvailableQuantity.TabIndex = 581
        Me.txtAvailableQuantity.Visible = False
        '
        'cmdAction
        '
        Me.cmdAction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdAction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAction.Appearance.Options.UseBackColor = True
        Me.cmdAction.Appearance.Options.UseFont = True
        Me.cmdAction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAction.Location = New System.Drawing.Point(249, 258)
        Me.cmdAction.Name = "cmdAction"
        Me.cmdAction.Size = New System.Drawing.Size(167, 32)
        Me.cmdAction.TabIndex = 4
        Me.cmdAction.Text = "Confirm"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Location = New System.Drawing.Point(58, 189)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl2.TabIndex = 594
        Me.LabelControl2.Text = "Stockout Type"
        '
        'txtStockoutType
        '
        Me.txtStockoutType.EditValue = ""
        Me.txtStockoutType.Location = New System.Drawing.Point(139, 186)
        Me.txtStockoutType.Name = "txtStockoutType"
        Me.txtStockoutType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockoutType.Properties.Appearance.Options.UseFont = True
        Me.txtStockoutType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockoutType.Properties.DisplayMember = "Select Inventory"
        Me.txtStockoutType.Properties.NullText = ""
        Me.txtStockoutType.Properties.ValueMember = "Select Inventory"
        Me.txtStockoutType.Properties.View = Me.g_inventory
        Me.txtStockoutType.Size = New System.Drawing.Size(277, 20)
        Me.txtStockoutType.TabIndex = 2
        Me.txtStockoutType.ToolTip = "Shortcut Key (F12)"
        '
        'g_inventory
        '
        Me.g_inventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_inventory.Name = "g_inventory"
        Me.g_inventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_inventory.OptionsView.ShowGroupPanel = False
        '
        'txtRequestby
        '
        Me.txtRequestby.EditValue = ""
        Me.txtRequestby.Location = New System.Drawing.Point(139, 163)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestby.Properties.Appearance.Options.UseFont = True
        Me.txtRequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequestby.Properties.DisplayMember = "Fullname"
        Me.txtRequestby.Properties.NullText = ""
        Me.txtRequestby.Properties.ValueMember = "Fullname"
        Me.txtRequestby.Properties.View = Me.g_requestor
        Me.txtRequestby.Size = New System.Drawing.Size(277, 20)
        Me.txtRequestby.TabIndex = 1
        '
        'g_requestor
        '
        Me.g_requestor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_requestor.Name = "g_requestor"
        Me.g_requestor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_requestor.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(73, 165)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 593
        Me.LabelControl5.Text = "Request by"
        '
        'requestorid
        '
        Me.requestorid.EditValue = ""
        Me.requestorid.EnterMoveNextControl = True
        Me.requestorid.Location = New System.Drawing.Point(103, 320)
        Me.requestorid.Name = "requestorid"
        Me.requestorid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestorid.Properties.Appearance.Options.UseFont = True
        Me.requestorid.Properties.Appearance.Options.UseTextOptions = True
        Me.requestorid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.requestorid.Size = New System.Drawing.Size(81, 20)
        Me.requestorid.TabIndex = 599
        Me.requestorid.Visible = False
        '
        'ckAllocatedStockout
        '
        Me.ckAllocatedStockout.Location = New System.Drawing.Point(137, 120)
        Me.ckAllocatedStockout.Name = "ckAllocatedStockout"
        Me.ckAllocatedStockout.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAllocatedStockout.Properties.Appearance.Options.UseFont = True
        Me.ckAllocatedStockout.Properties.Caption = "Allocated Stockout"
        Me.ckAllocatedStockout.Size = New System.Drawing.Size(279, 19)
        Me.ckAllocatedStockout.TabIndex = 604
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(139, 140)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtoffice.Properties.NullText = ""
        Me.txtoffice.Properties.ReadOnly = True
        Me.txtoffice.Properties.View = Me.gridcompoffice
        Me.txtoffice.Size = New System.Drawing.Size(277, 20)
        Me.txtoffice.TabIndex = 605
        '
        'gridcompoffice
        '
        Me.gridcompoffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcompoffice.Name = "gridcompoffice"
        Me.gridcompoffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcompoffice.OptionsView.ShowGroupPanel = False
        '
        'lbloffice
        '
        Me.lbloffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbloffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbloffice.Location = New System.Drawing.Point(47, 143)
        Me.lbloffice.Name = "lbloffice"
        Me.lbloffice.Size = New System.Drawing.Size(83, 13)
        Me.lbloffice.TabIndex = 606
        Me.lbloffice.Text = "Select "
        '
        'officeallocated
        '
        Me.officeallocated.EditValue = ""
        Me.officeallocated.EnterMoveNextControl = True
        Me.officeallocated.Location = New System.Drawing.Point(195, 351)
        Me.officeallocated.Name = "officeallocated"
        Me.officeallocated.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeallocated.Properties.Appearance.Options.UseFont = True
        Me.officeallocated.Properties.Appearance.Options.UseTextOptions = True
        Me.officeallocated.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.officeallocated.Size = New System.Drawing.Size(81, 20)
        Me.officeallocated.TabIndex = 607
        '
        'stockid
        '
        Me.stockid.EditValue = ""
        Me.stockid.EnterMoveNextControl = True
        Me.stockid.Location = New System.Drawing.Point(195, 382)
        Me.stockid.Name = "stockid"
        Me.stockid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockid.Properties.Appearance.Options.UseFont = True
        Me.stockid.Properties.Appearance.Options.UseTextOptions = True
        Me.stockid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.stockid.Size = New System.Drawing.Size(81, 20)
        Me.stockid.TabIndex = 608
        '
        'productid
        '
        Me.productid.EditValue = ""
        Me.productid.EnterMoveNextControl = True
        Me.productid.Location = New System.Drawing.Point(108, 382)
        Me.productid.Name = "productid"
        Me.productid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productid.Properties.Appearance.Options.UseFont = True
        Me.productid.Properties.Appearance.Options.UseTextOptions = True
        Me.productid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.productid.Size = New System.Drawing.Size(81, 20)
        Me.productid.TabIndex = 609
        '
        'purchasedprice
        '
        Me.purchasedprice.EditValue = ""
        Me.purchasedprice.EnterMoveNextControl = True
        Me.purchasedprice.Location = New System.Drawing.Point(195, 320)
        Me.purchasedprice.Name = "purchasedprice"
        Me.purchasedprice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasedprice.Properties.Appearance.Options.UseFont = True
        Me.purchasedprice.Properties.Appearance.Options.UseTextOptions = True
        Me.purchasedprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.purchasedprice.Size = New System.Drawing.Size(81, 20)
        Me.purchasedprice.TabIndex = 610
        '
        'batchcode
        '
        Me.batchcode.EditValue = ""
        Me.batchcode.EnterMoveNextControl = True
        Me.batchcode.Location = New System.Drawing.Point(129, 274)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchcode.Properties.Appearance.Options.UseFont = True
        Me.batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.batchcode.Size = New System.Drawing.Size(81, 20)
        Me.batchcode.TabIndex = 611
        Me.batchcode.Visible = False
        '
        'ckBatch
        '
        Me.ckBatch.Location = New System.Drawing.Point(1, 275)
        Me.ckBatch.Name = "ckBatch"
        Me.ckBatch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBatch.Properties.Appearance.Options.UseFont = True
        Me.ckBatch.Properties.Caption = "bacth"
        Me.ckBatch.Size = New System.Drawing.Size(122, 19)
        Me.ckBatch.TabIndex = 612
        Me.ckBatch.Visible = False
        '
        'frmStockoutQuantity
        '
        Me.AcceptButton = Me.cmdAction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 306)
        Me.Controls.Add(Me.ckBatch)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.purchasedprice)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.stockid)
        Me.Controls.Add(Me.officeallocated)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lbloffice)
        Me.Controls.Add(Me.ckAllocatedStockout)
        Me.Controls.Add(Me.requestorid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtStockoutType)
        Me.Controls.Add(Me.txtRequestby)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmdAction)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtdatestockout)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.Stockouttypeid)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtunit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockoutQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Quantity"
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stockouttypeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatestockout.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdatestockout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockoutType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_requestor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestorid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllocatedStockout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeallocated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchasedprice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckBatch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Stockouttypeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdatestockout As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents catid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAvailableQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStockoutType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents g_requestor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents requestorid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckAllocatedStockout As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents officeallocated As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtoffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcompoffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbloffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents stockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents productid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents purchasedprice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckBatch As DevExpress.XtraEditors.CheckEdit
End Class
