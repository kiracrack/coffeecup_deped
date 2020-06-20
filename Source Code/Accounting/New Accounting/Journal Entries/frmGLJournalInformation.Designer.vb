<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLJournalInformation
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditExpenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSaveVoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtTicketNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddExpense = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintVoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTrndate = New DevExpress.XtraEditors.DateEdit()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompany = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView_company = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_Office = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditExpenseToolStripMenuItem, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(145, 76)
        '
        'EditExpenseToolStripMenuItem
        '
        Me.EditExpenseToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.EditExpenseToolStripMenuItem.Name = "EditExpenseToolStripMenuItem"
        Me.EditExpenseToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditExpenseToolStripMenuItem.Text = "Edit Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
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
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(21, 185)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(632, 211)
        Me.Em.TabIndex = 715
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.UsePrintStyles = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Web"
        '
        'cmdSaveVoucher
        '
        Me.cmdSaveVoucher.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSaveVoucher.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSaveVoucher.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSaveVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSaveVoucher.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveVoucher.Appearance.Options.UseBackColor = True
        Me.cmdSaveVoucher.Appearance.Options.UseFont = True
        Me.cmdSaveVoucher.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSaveVoucher.Location = New System.Drawing.Point(424, 408)
        Me.cmdSaveVoucher.Name = "cmdSaveVoucher"
        Me.cmdSaveVoucher.Size = New System.Drawing.Size(165, 30)
        Me.cmdSaveVoucher.TabIndex = 716
        Me.cmdSaveVoucher.Text = "Save Ticket"
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(93, 16)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(85, 17)
        Me.lblReference.TabIndex = 725
        Me.lblReference.Text = "Ticket Number"
        '
        'txtTicketNo
        '
        Me.txtTicketNo.EnterMoveNextControl = True
        Me.txtTicketNo.Location = New System.Drawing.Point(186, 12)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtTicketNo.Properties.Appearance.Options.UseFont = True
        Me.txtTicketNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTicketNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTicketNo.Size = New System.Drawing.Size(107, 26)
        Me.txtTicketNo.TabIndex = 724
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(186, 129)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtDetails.Properties.Appearance.Options.UseFont = True
        Me.txtDetails.Size = New System.Drawing.Size(403, 50)
        Me.txtDetails.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Location = New System.Drawing.Point(75, 132)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 17)
        Me.LabelControl3.TabIndex = 728
        Me.LabelControl3.Text = "Ticket Description"
        '
        'cmdAddExpense
        '
        Me.cmdAddExpense.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAddExpense.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdAddExpense.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddExpense.Appearance.Options.UseFont = True
        Me.cmdAddExpense.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddExpense.Location = New System.Drawing.Point(82, 408)
        Me.cmdAddExpense.Name = "cmdAddExpense"
        Me.cmdAddExpense.Size = New System.Drawing.Size(165, 30)
        Me.cmdAddExpense.TabIndex = 729
        Me.cmdAddExpense.Text = "Add Item"
        '
        'cmdPrintVoucher
        '
        Me.cmdPrintVoucher.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdPrintVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPrintVoucher.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrintVoucher.Appearance.Options.UseFont = True
        Me.cmdPrintVoucher.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrintVoucher.Location = New System.Drawing.Point(253, 408)
        Me.cmdPrintVoucher.Name = "cmdPrintVoucher"
        Me.cmdPrintVoucher.Size = New System.Drawing.Size(165, 30)
        Me.cmdPrintVoucher.TabIndex = 730
        Me.cmdPrintVoucher.Text = "Print Ticket"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(488, 14)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(82, 20)
        Me.mode.TabIndex = 731
        Me.mode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl8.Location = New System.Drawing.Point(80, 104)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(98, 17)
        Me.LabelControl8.TabIndex = 733
        Me.LabelControl8.Text = "Transaction Date"
        '
        'txtTrndate
        '
        Me.txtTrndate.EditValue = New Date(CType(0, Long))
        Me.txtTrndate.EnterMoveNextControl = True
        Me.txtTrndate.Location = New System.Drawing.Point(186, 100)
        Me.txtTrndate.Name = "txtTrndate"
        Me.txtTrndate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtTrndate.Properties.Appearance.Options.UseFont = True
        Me.txtTrndate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTrndate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTrndate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtTrndate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTrndate.Size = New System.Drawing.Size(233, 26)
        Me.txtTrndate.TabIndex = 732
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(425, 74)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(49, 20)
        Me.officeid.TabIndex = 736
        Me.officeid.Visible = False
        '
        'companyid
        '
        Me.companyid.EnterMoveNextControl = True
        Me.companyid.Location = New System.Drawing.Point(424, 42)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Size = New System.Drawing.Size(50, 20)
        Me.companyid.TabIndex = 748
        Me.companyid.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Location = New System.Drawing.Point(106, 75)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl10.TabIndex = 750
        Me.LabelControl10.Text = "Select Office"
        '
        'txtCompany
        '
        Me.txtCompany.EditValue = ""
        Me.txtCompany.Location = New System.Drawing.Point(186, 42)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCompany.Properties.DisplayMember = "Select Company"
        Me.txtCompany.Properties.NullText = ""
        Me.txtCompany.Properties.ValueMember = "compid"
        Me.txtCompany.Properties.View = Me.GridView_company
        Me.txtCompany.Size = New System.Drawing.Size(232, 26)
        Me.txtCompany.TabIndex = 749
        '
        'GridView_company
        '
        Me.GridView_company.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView_company.Name = "GridView_company"
        Me.GridView_company.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView_company.OptionsView.ShowGroupPanel = False
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.Location = New System.Drawing.Point(85, 47)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(93, 17)
        Me.lblOffice.TabIndex = 746
        Me.lblOffice.Text = "Select Company"
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.Location = New System.Drawing.Point(186, 71)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select Office"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Properties.View = Me.gv_Office
        Me.txtOffice.Size = New System.Drawing.Size(232, 26)
        Me.txtOffice.TabIndex = 745
        '
        'gv_Office
        '
        Me.gv_Office.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_Office.Name = "gv_Office"
        Me.gv_Office.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_Office.OptionsView.ShowGroupPanel = False
        '
        'frmGLJournalInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 452)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtTrndate)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.txtTicketNo)
        Me.Controls.Add(Me.cmdSaveVoucher)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.cmdPrintVoucher)
        Me.Controls.Add(Me.cmdAddExpense)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGLJournalInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entries Information"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSaveVoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTicketNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddExpense As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintVoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditExpenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrndate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompany As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView_company As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_Office As DevExpress.XtraGrid.Views.Grid.GridView
End Class
