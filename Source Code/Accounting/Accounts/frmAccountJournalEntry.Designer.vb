<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountJournalEntry
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
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReferenceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.dueid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDueFrom = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridDueFrom = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTrndate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDueFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDueFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(254, 301)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(86, 29)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(121, 300)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(129, 30)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "Confirm save"
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.Location = New System.Drawing.Point(122, 217)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNumber.Properties.Appearance.Options.UseFont = True
        Me.txtReferenceNumber.Size = New System.Drawing.Size(218, 20)
        Me.txtReferenceNumber.TabIndex = 5
        '
        'dueid
        '
        Me.dueid.Location = New System.Drawing.Point(439, 35)
        Me.dueid.Name = "dueid"
        Me.dueid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueid.Properties.Appearance.Options.UseFont = True
        Me.dueid.Properties.Appearance.Options.UseTextOptions = True
        Me.dueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dueid.Properties.ReadOnly = True
        Me.dueid.Size = New System.Drawing.Size(53, 20)
        Me.dueid.TabIndex = 581
        Me.dueid.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(23, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl3.TabIndex = 648
        Me.LabelControl3.Text = "Transaction Name"
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(122, 14)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "Item Name"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.ValueMember = "Item Name"
        Me.txtItem.Properties.View = Me.gridItem
        Me.txtItem.Size = New System.Drawing.Size(218, 20)
        Me.txtItem.TabIndex = 0
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'itemcode
        '
        Me.itemcode.EditValue = ""
        Me.itemcode.Location = New System.Drawing.Point(439, 63)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Properties.Appearance.Options.UseTextOptions = True
        Me.itemcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.itemcode.Size = New System.Drawing.Size(53, 20)
        Me.itemcode.TabIndex = 649
        Me.itemcode.Visible = False
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = "0.00"
        Me.txtDebit.Location = New System.Drawing.Point(122, 37)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDebit.Properties.Appearance.Options.UseFont = True
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.Mask.EditMask = "n"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebit.Size = New System.Drawing.Size(128, 26)
        Me.txtDebit.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(81, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl4.TabIndex = 655
        Me.LabelControl4.Text = "Debit"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(39, 174)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 657
        Me.LabelControl2.Text = "Select Account"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(122, 240)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(218, 56)
        Me.txtRemarks.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(71, 243)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 659
        Me.LabelControl5.Text = "Remarks"
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = "0.00"
        Me.txtCredit.Location = New System.Drawing.Point(122, 66)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCredit.Properties.Appearance.Options.UseFont = True
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.Mask.EditMask = "n"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredit.Size = New System.Drawing.Size(128, 26)
        Me.txtCredit.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(77, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 19)
        Me.LabelControl1.TabIndex = 661
        Me.LabelControl1.Text = "Credit"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = "client"
        Me.RadioGroup1.Location = New System.Drawing.Point(122, 95)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("client", "Client Accounts"), New DevExpress.XtraEditors.Controls.RadioGroupItem("bank", "Bank/Cash Accounts"), New DevExpress.XtraEditors.Controls.RadioGroupItem("vendor", "Vendor/Supplier")})
        Me.RadioGroup1.Size = New System.Drawing.Size(218, 72)
        Me.RadioGroup1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(42, 99)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl6.TabIndex = 663
        Me.LabelControl6.Text = "Due To / From"
        '
        'txtDueFrom
        '
        Me.txtDueFrom.EditValue = "Select Group"
        Me.txtDueFrom.Location = New System.Drawing.Point(121, 171)
        Me.txtDueFrom.Name = "txtDueFrom"
        Me.txtDueFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueFrom.Properties.Appearance.Options.UseFont = True
        Me.txtDueFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDueFrom.Properties.DisplayMember = "Account Name"
        Me.txtDueFrom.Properties.NullText = ""
        Me.txtDueFrom.Properties.ValueMember = "Account Name"
        Me.txtDueFrom.Properties.View = Me.gridDueFrom
        Me.txtDueFrom.Size = New System.Drawing.Size(219, 20)
        Me.txtDueFrom.TabIndex = 3
        '
        'gridDueFrom
        '
        Me.gridDueFrom.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridDueFrom.Name = "gridDueFrom"
        Me.gridDueFrom.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridDueFrom.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(19, 220)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl7.TabIndex = 664
        Me.LabelControl7.Text = "Reference Number"
        '
        'txtTrndate
        '
        Me.txtTrndate.EditValue = New Date(CType(0, Long))
        Me.txtTrndate.EnterMoveNextControl = True
        Me.txtTrndate.Location = New System.Drawing.Point(122, 194)
        Me.txtTrndate.Name = "txtTrndate"
        Me.txtTrndate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrndate.Properties.Appearance.Options.UseFont = True
        Me.txtTrndate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTrndate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTrndate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtTrndate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTrndate.Size = New System.Drawing.Size(218, 20)
        Me.txtTrndate.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(28, 198)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl8.TabIndex = 666
        Me.LabelControl8.Text = "Transaction Date"
        '
        'frmAccountJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 352)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtTrndate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dueid)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtDueFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry"
        CType(Me.txtReferenceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDueFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDueFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReferenceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDueFrom As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridDueFrom As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrndate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
