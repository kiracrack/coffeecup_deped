<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetStockHouse
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.txtStockHouse = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_stockhouse = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.refcode = New DevExpress.XtraEditors.TextEdit()
        Me.stockhouseid = New DevExpress.XtraEditors.TextEdit()
        Me.ckDevideQuantity = New DevExpress.XtraEditors.CheckEdit()
        Me.txtcost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDevidedAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtquantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAvailableQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.inventorytype = New DevExpress.XtraEditors.TextEdit()
        Me.txtInventory = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_stockhouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockhouseid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDevideQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevidedAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventorytype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(525, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 216)
        Me.barDockControlBottom.Size = New System.Drawing.Size(525, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 216)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(525, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 216)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'txtStockHouse
        '
        Me.txtStockHouse.EditValue = ""
        Me.txtStockHouse.Location = New System.Drawing.Point(117, 109)
        Me.txtStockHouse.Name = "txtStockHouse"
        Me.txtStockHouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockHouse.Properties.DisplayMember = "Select Stock House"
        Me.txtStockHouse.Properties.NullText = ""
        Me.txtStockHouse.Properties.ValueMember = "Select Stock House"
        Me.txtStockHouse.Properties.View = Me.gv_stockhouse
        Me.txtStockHouse.Size = New System.Drawing.Size(277, 20)
        Me.txtStockHouse.TabIndex = 1
        '
        'gv_stockhouse
        '
        Me.gv_stockhouse.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_stockhouse.Name = "gv_stockhouse"
        Me.gv_stockhouse.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_stockhouse.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(20, 112)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl5.TabIndex = 593
        Me.LabelControl5.Text = "Select Stock House"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.Location = New System.Drawing.Point(117, 183)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(132, 27)
        Me.SimpleButton2.TabIndex = 604
        Me.SimpleButton2.Text = "Confirm"
        '
        'officeid
        '
        Me.officeid.Location = New System.Drawing.Point(96, 248)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(73, 20)
        Me.officeid.TabIndex = 610
        Me.officeid.Visible = False
        '
        'refcode
        '
        Me.refcode.EnterMoveNextControl = True
        Me.refcode.Location = New System.Drawing.Point(12, 215)
        Me.refcode.Name = "refcode"
        Me.refcode.Size = New System.Drawing.Size(73, 20)
        Me.refcode.TabIndex = 609
        Me.refcode.Visible = False
        '
        'stockhouseid
        '
        Me.stockhouseid.Location = New System.Drawing.Point(175, 248)
        Me.stockhouseid.Name = "stockhouseid"
        Me.stockhouseid.Properties.ReadOnly = True
        Me.stockhouseid.Size = New System.Drawing.Size(73, 20)
        Me.stockhouseid.TabIndex = 615
        Me.stockhouseid.Visible = False
        '
        'ckDevideQuantity
        '
        Me.ckDevideQuantity.Location = New System.Drawing.Point(252, 59)
        Me.ckDevideQuantity.Name = "ckDevideQuantity"
        Me.ckDevideQuantity.Properties.Caption = "Devide Item Quantity"
        Me.ckDevideQuantity.Size = New System.Drawing.Size(205, 19)
        Me.ckDevideQuantity.TabIndex = 653
        '
        'txtcost
        '
        Me.txtcost.EditValue = "0.00"
        Me.txtcost.EnterMoveNextControl = True
        Me.txtcost.Location = New System.Drawing.Point(255, 35)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtcost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtcost.Properties.Mask.EditMask = "n"
        Me.txtcost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcost.Properties.ReadOnly = True
        Me.txtcost.Size = New System.Drawing.Size(133, 20)
        Me.txtcost.TabIndex = 667
        Me.txtcost.ToolTip = "Shortcut Key (F10)"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(33, 88)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl11.TabIndex = 672
        Me.LabelControl11.Text = "Devided Amount"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(70, 64)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl10.TabIndex = 671
        Me.LabelControl10.Text = "Quantity"
        '
        'txtDevidedAmount
        '
        Me.txtDevidedAmount.EditValue = "0.00"
        Me.txtDevidedAmount.EnterMoveNextControl = True
        Me.txtDevidedAmount.Location = New System.Drawing.Point(117, 85)
        Me.txtDevidedAmount.Name = "txtDevidedAmount"
        Me.txtDevidedAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDevidedAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDevidedAmount.Properties.Mask.EditMask = "n"
        Me.txtDevidedAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDevidedAmount.Properties.ReadOnly = True
        Me.txtDevidedAmount.Size = New System.Drawing.Size(132, 20)
        Me.txtDevidedAmount.TabIndex = 670
        '
        'txtquantity
        '
        Me.txtquantity.EditValue = "0"
        Me.txtquantity.EnterMoveNextControl = True
        Me.txtquantity.Location = New System.Drawing.Point(117, 60)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Properties.Appearance.Options.UseFont = True
        Me.txtquantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtquantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtquantity.Properties.Mask.EditMask = "n"
        Me.txtquantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtquantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtquantity.Properties.ReadOnly = True
        Me.txtquantity.Size = New System.Drawing.Size(132, 22)
        Me.txtquantity.TabIndex = 669
        Me.txtquantity.ToolTip = "Shortcut Key (F9)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl1.TabIndex = 674
        Me.LabelControl1.Text = "Available Quantity"
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.EditValue = "0"
        Me.txtAvailableQuantity.EnterMoveNextControl = True
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(117, 35)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtAvailableQuantity.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvailableQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAvailableQuantity.Properties.Mask.EditMask = "n"
        Me.txtAvailableQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAvailableQuantity.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAvailableQuantity.Properties.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(132, 22)
        Me.txtAvailableQuantity.TabIndex = 673
        Me.txtAvailableQuantity.ToolTip = "Shortcut Key (F9)"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(394, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 675
        Me.LabelControl2.Text = "Unit Cost"
        '
        'txtDetails
        '
        Me.txtDetails.EditValue = ""
        Me.txtDetails.Location = New System.Drawing.Point(117, 133)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(277, 46)
        Me.txtDetails.TabIndex = 676
        Me.txtDetails.ToolTip = "Remarks"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(58, 136)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl6.TabIndex = 677
        Me.LabelControl6.Text = "Unit Details"
        '
        'inventorytype
        '
        Me.inventorytype.EnterMoveNextControl = True
        Me.inventorytype.Location = New System.Drawing.Point(254, 248)
        Me.inventorytype.Name = "inventorytype"
        Me.inventorytype.Properties.ReadOnly = True
        Me.inventorytype.Size = New System.Drawing.Size(73, 20)
        Me.inventorytype.TabIndex = 682
        Me.inventorytype.Visible = False
        '
        'txtInventory
        '
        Me.txtInventory.EnterMoveNextControl = True
        Me.txtInventory.Location = New System.Drawing.Point(117, 11)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Properties.ReadOnly = True
        Me.txtInventory.Size = New System.Drawing.Size(271, 20)
        Me.txtInventory.TabIndex = 683
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(37, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl3.TabIndex = 684
        Me.LabelControl3.Text = "Inventory Type"
        '
        'trnid
        '
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(12, 190)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(73, 20)
        Me.trnid.TabIndex = 690
        Me.trnid.Visible = False
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 216)
        Me.BarDockControl1.Size = New System.Drawing.Size(525, 0)
        '
        'frmSetStockHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 216)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtInventory)
        Me.Controls.Add(Me.inventorytype)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtDevidedAmount)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.ckDevideQuantity)
        Me.Controls.Add(Me.stockhouseid)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.refcode)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.txtStockHouse)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetStockHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division of Item and Stock Housing"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_stockhouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockhouseid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDevideQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevidedAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvailableQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventorytype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtStockHouse As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_stockhouse As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents refcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stockhouseid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDevideQuantity As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtcost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDevidedAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtquantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAvailableQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInventory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents inventorytype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
End Class
