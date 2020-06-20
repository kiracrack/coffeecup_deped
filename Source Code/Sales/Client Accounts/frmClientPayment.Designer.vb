<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientPayment
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblbalance = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtClientAccount = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridClientAccount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtAmountTender = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalPurchase = New DevExpress.XtraEditors.LabelControl()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtVariance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReferenceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtDetails = New DevExpress.XtraEditors.TextEdit()
        Me.lblRemarks = New DevExpress.XtraEditors.LabelControl()
        Me.txtBankAccounts = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridBankAccount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.banknumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtdateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepositTo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridDepositTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.depositID = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
        Me.ckDiscount = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDiscountRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.radPaymentType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClientAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.txtAmountTender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBankAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBankAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banknumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDepositTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depositID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(47, 62)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl6.TabIndex = 691
        Me.LabelControl6.Text = "Payment Mode"
        '
        'lblbalance
        '
        Me.lblbalance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblbalance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblbalance.Location = New System.Drawing.Point(63, 181)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(101, 13)
        Me.lblbalance.TabIndex = 656
        Me.lblbalance.Text = "Total Amount"
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = ""
        Me.txtAmount.Location = New System.Drawing.Point(171, 176)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Properties.Appearance.Options.UseBackColor = True
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseForeColor = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Properties.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(130, 22)
        Me.txtAmount.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(124, 424)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(177, 30)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "Confirm Payment"
        '
        'txtClientAccount
        '
        Me.txtClientAccount.EditValue = ""
        Me.txtClientAccount.Location = New System.Drawing.Point(20, 36)
        Me.txtClientAccount.Name = "txtClientAccount"
        Me.txtClientAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClientAccount.Properties.DisplayMember = "Client"
        Me.txtClientAccount.Properties.NullText = ""
        Me.txtClientAccount.Properties.ValueMember = "Client"
        Me.txtClientAccount.Properties.View = Me.gridClientAccount
        Me.txtClientAccount.Size = New System.Drawing.Size(281, 20)
        Me.txtClientAccount.TabIndex = 0
        '
        'gridClientAccount
        '
        Me.gridClientAccount.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridClientAccount.Name = "gridClientAccount"
        Me.gridClientAccount.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridClientAccount.OptionsView.ShowGroupPanel = False
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(168, 48)
        '
        'txtAmountTender
        '
        Me.txtAmountTender.EditValue = ""
        Me.txtAmountTender.Location = New System.Drawing.Point(171, 201)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtAmountTender.Properties.Appearance.Options.UseFont = True
        Me.txtAmountTender.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountTender.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountTender.Properties.Mask.EditMask = "n"
        Me.txtAmountTender.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountTender.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmountTender.Size = New System.Drawing.Size(130, 22)
        Me.txtAmountTender.TabIndex = 2
        '
        'lblTotalPurchase
        '
        Me.lblTotalPurchase.Location = New System.Drawing.Point(82, 204)
        Me.lblTotalPurchase.Name = "lblTotalPurchase"
        Me.lblTotalPurchase.Size = New System.Drawing.Size(82, 13)
        Me.lblTotalPurchase.TabIndex = 695
        Me.lblTotalPurchase.Text = "Payment Amount"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(325, 62)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(484, 392)
        Me.ListView1.TabIndex = 696
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtVariance
        '
        Me.txtVariance.EditValue = ""
        Me.txtVariance.Location = New System.Drawing.Point(171, 250)
        Me.txtVariance.Name = "txtVariance"
        Me.txtVariance.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtVariance.Properties.Appearance.Options.UseFont = True
        Me.txtVariance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVariance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVariance.Properties.Mask.EditMask = "n"
        Me.txtVariance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVariance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVariance.Size = New System.Drawing.Size(130, 22)
        Me.txtVariance.TabIndex = 697
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl1.TabIndex = 652
        Me.LabelControl1.Text = "Client Account Name"
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.EnterMoveNextControl = True
        Me.txtReferenceNumber.Location = New System.Drawing.Point(124, 127)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(177, 20)
        Me.txtReferenceNumber.TabIndex = 699
        '
        'lblReference
        '
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblReference.Location = New System.Drawing.Point(19, 130)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(99, 13)
        Me.lblReference.TabIndex = 700
        Me.lblReference.Text = "Reference No."
        '
        'txtDetails
        '
        Me.txtDetails.EnterMoveNextControl = True
        Me.txtDetails.Location = New System.Drawing.Point(124, 149)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(177, 20)
        Me.txtDetails.TabIndex = 701
        '
        'lblRemarks
        '
        Me.lblRemarks.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblRemarks.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblRemarks.Location = New System.Drawing.Point(20, 152)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(98, 13)
        Me.lblRemarks.TabIndex = 702
        Me.lblRemarks.Text = "Details"
        '
        'txtBankAccounts
        '
        Me.txtBankAccounts.EditValue = ""
        Me.txtBankAccounts.Location = New System.Drawing.Point(124, 149)
        Me.txtBankAccounts.Name = "txtBankAccounts"
        Me.txtBankAccounts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBankAccounts.Properties.DisplayMember = "Account Name"
        Me.txtBankAccounts.Properties.NullText = ""
        Me.txtBankAccounts.Properties.ValueMember = "Account Name"
        Me.txtBankAccounts.Properties.View = Me.gridBankAccount
        Me.txtBankAccounts.Size = New System.Drawing.Size(177, 20)
        Me.txtBankAccounts.TabIndex = 703
        '
        'gridBankAccount
        '
        Me.gridBankAccount.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridBankAccount.Name = "gridBankAccount"
        Me.gridBankAccount.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridBankAccount.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(325, 21)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl7.TabIndex = 704
        Me.LabelControl7.Text = "Check Invoices for payment"
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(20, 332)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(280, 64)
        Me.txtNote.TabIndex = 5
        '
        'cifid
        '
        Me.cifid.EnterMoveNextControl = True
        Me.cifid.Location = New System.Drawing.Point(336, 127)
        Me.cifid.Name = "cifid"
        Me.cifid.Size = New System.Drawing.Size(82, 20)
        Me.cifid.TabIndex = 706
        Me.cifid.Visible = False
        '
        'banknumber
        '
        Me.banknumber.EnterMoveNextControl = True
        Me.banknumber.Location = New System.Drawing.Point(336, 151)
        Me.banknumber.Name = "banknumber"
        Me.banknumber.Size = New System.Drawing.Size(82, 20)
        Me.banknumber.TabIndex = 707
        Me.banknumber.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = New Date(CType(0, Long))
        Me.txtDateTo.EnterMoveNextControl = True
        Me.txtDateTo.Location = New System.Drawing.Point(533, 37)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDateTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(185, 20)
        Me.txtDateTo.TabIndex = 709
        '
        'txtdateFrom
        '
        Me.txtdateFrom.EditValue = New Date(CType(0, Long))
        Me.txtdateFrom.EnterMoveNextControl = True
        Me.txtdateFrom.Location = New System.Drawing.Point(325, 37)
        Me.txtdateFrom.Name = "txtdateFrom"
        Me.txtdateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtdateFrom.Properties.Appearance.Options.UseFont = True
        Me.txtdateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtdateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtdateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtdateFrom.Size = New System.Drawing.Size(185, 20)
        Me.txtdateFrom.TabIndex = 708
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(517, 40)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl8.TabIndex = 710
        Me.LabelControl8.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(123, 253)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 698
        Me.LabelControl3.Text = "Variance"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 318)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl4.TabIndex = 711
        Me.LabelControl4.Text = "Payment Note"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 404)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 713
        Me.LabelControl2.Text = "Due From"
        '
        'txtDepositTo
        '
        Me.txtDepositTo.EditValue = "Select Group"
        Me.txtDepositTo.Location = New System.Drawing.Point(72, 401)
        Me.txtDepositTo.Name = "txtDepositTo"
        Me.txtDepositTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDepositTo.Properties.DisplayMember = "Account Name"
        Me.txtDepositTo.Properties.ImmediatePopup = True
        Me.txtDepositTo.Properties.NullText = ""
        Me.txtDepositTo.Properties.ValueMember = "Account Name"
        Me.txtDepositTo.Properties.View = Me.gridDepositTo
        Me.txtDepositTo.Size = New System.Drawing.Size(228, 20)
        Me.txtDepositTo.TabIndex = 6
        '
        'gridDepositTo
        '
        Me.gridDepositTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridDepositTo.Name = "gridDepositTo"
        Me.gridDepositTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridDepositTo.OptionsView.ShowGroupPanel = False
        '
        'depositID
        '
        Me.depositID.EnterMoveNextControl = True
        Me.depositID.Location = New System.Drawing.Point(336, 174)
        Me.depositID.Name = "depositID"
        Me.depositID.Size = New System.Drawing.Size(82, 20)
        Me.depositID.TabIndex = 714
        Me.depositID.Visible = False
        '
        'txtDiscount
        '
        Me.txtDiscount.EditValue = ""
        Me.txtDiscount.Location = New System.Drawing.Point(171, 226)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtDiscount.Properties.Appearance.Options.UseFont = True
        Me.txtDiscount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDiscount.Properties.Mask.EditMask = "n"
        Me.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount.Properties.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(129, 22)
        Me.txtDiscount.TabIndex = 3
        '
        'ckDiscount
        '
        Me.ckDiscount.Location = New System.Drawing.Point(25, 227)
        Me.ckDiscount.Name = "ckDiscount"
        Me.ckDiscount.Properties.Appearance.Options.UseTextOptions = True
        Me.ckDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckDiscount.Properties.Caption = "Discount && Remarks"
        Me.ckDiscount.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckDiscount.Size = New System.Drawing.Size(142, 19)
        Me.ckDiscount.TabIndex = 717
        '
        'txtDiscountRemarks
        '
        Me.txtDiscountRemarks.EditValue = ""
        Me.txtDiscountRemarks.Location = New System.Drawing.Point(22, 284)
        Me.txtDiscountRemarks.Name = "txtDiscountRemarks"
        Me.txtDiscountRemarks.Size = New System.Drawing.Size(279, 30)
        Me.txtDiscountRemarks.TabIndex = 4
        '
        'radPaymentType
        '
        Me.radPaymentType.EditValue = "cash"
        Me.radPaymentType.Location = New System.Drawing.Point(124, 60)
        Me.radPaymentType.Name = "radPaymentType"
        Me.radPaymentType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("cash", "Cash Payment"), New DevExpress.XtraEditors.Controls.RadioGroupItem("check", "Check Payment"), New DevExpress.XtraEditors.Controls.RadioGroupItem("card", "Card Payment")})
        Me.radPaymentType.Size = New System.Drawing.Size(177, 64)
        Me.radPaymentType.TabIndex = 718
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(22, 268)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl9.TabIndex = 722
        Me.LabelControl9.Text = "Discount Remarks"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(724, 39)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Check All"
        Me.CheckEdit1.Size = New System.Drawing.Size(85, 19)
        Me.CheckEdit1.TabIndex = 723
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Edit Discount"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(167, 22)
        Me.cmdDelete.Text = "Remove Discount"
        '
        'frmClientPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 462)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.radPaymentType)
        Me.Controls.Add(Me.txtDiscountRemarks)
        Me.Controls.Add(Me.ckDiscount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.depositID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDepositTo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtdateFrom)
        Me.Controls.Add(Me.banknumber)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtVariance)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblTotalPurchase)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtClientAccount)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtBankAccounts)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(835, 501)
        Me.Name = "frmClientPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Payment Information"
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClientAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.txtAmountTender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBankAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBankAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banknumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDepositTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depositID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents txtClientAccount As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridClientAccount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblbalance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountTender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalPurchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtVariance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReferenceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRemarks As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBankAccounts As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridBankAccount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents banknumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtdateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDepositTo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridDepositTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents depositID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDiscountRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents radPaymentType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
