<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitionsManagement
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
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUpdateRequisitionStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditRequest = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_action = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAttachmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtractAttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancelLastApprovingAction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txttodate = New DevExpress.XtraEditors.DateEdit()
        Me.txtfrmdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ck_AllOffice = New DevExpress.XtraEditors.CheckEdit()
        Me.lblOffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckasof = New DevExpress.XtraEditors.CheckEdit()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ckPendingRequest = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCorporate = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabOffice = New DevExpress.XtraTab.XtraTabPage()
        Me.cms.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_AllOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ckPendingRequest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabCorporate.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.cmdUpdateRequisitionStatus, Me.cmdEditRequest, Me.menu_action, Me.AttachmentsToolStripMenuItem, Me.cmdCancelLastApprovingAction, Me.ToolStripSeparator1, Me.menu_Refresh})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(232, 164)
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources._164
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Full Details"
        '
        'cmdUpdateRequisitionStatus
        '
        Me.cmdUpdateRequisitionStatus.Image = Global.Coffeecup.My.Resources.Resources.notebook__arrow1
        Me.cmdUpdateRequisitionStatus.Name = "cmdUpdateRequisitionStatus"
        Me.cmdUpdateRequisitionStatus.Size = New System.Drawing.Size(231, 22)
        Me.cmdUpdateRequisitionStatus.Text = "Update Requisition Status"
        '
        'cmdEditRequest
        '
        Me.cmdEditRequest.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEditRequest.Name = "cmdEditRequest"
        Me.cmdEditRequest.Size = New System.Drawing.Size(231, 22)
        Me.cmdEditRequest.Text = "Edit Selected Request"
        '
        'menu_action
        '
        Me.menu_action.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_edit, Me.ToolStripSeparator2, Me.menu_cancel})
        Me.menu_action.Image = Global.Coffeecup.My.Resources.Resources.microformats
        Me.menu_action.Name = "menu_action"
        Me.menu_action.Size = New System.Drawing.Size(231, 22)
        Me.menu_action.Text = "Request Action Menu"
        '
        'menu_edit
        '
        Me.menu_edit.Image = Global.Coffeecup.My.Resources.Resources.notebooks
        Me.menu_edit.Name = "menu_edit"
        Me.menu_edit.Size = New System.Drawing.Size(228, 22)
        Me.menu_edit.Text = "Duplicate and Revise Request"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'menu_cancel
        '
        Me.menu_cancel.Image = Global.Coffeecup.My.Resources.Resources.ui_toolbar_bookmark
        Me.menu_cancel.Name = "menu_cancel"
        Me.menu_cancel.Size = New System.Drawing.Size(228, 22)
        Me.menu_cancel.Text = "Cancel Full Request"
        '
        'AttachmentsToolStripMenuItem
        '
        Me.AttachmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetAttachmentToolStripMenuItem1, Me.cmdViewAttachment, Me.ExtractAttachmentToolStripMenuItem})
        Me.AttachmentsToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow
        Me.AttachmentsToolStripMenuItem.Name = "AttachmentsToolStripMenuItem"
        Me.AttachmentsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AttachmentsToolStripMenuItem.Text = "Attachments"
        '
        'SetAttachmentToolStripMenuItem1
        '
        Me.SetAttachmentToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.inbox__plus
        Me.SetAttachmentToolStripMenuItem1.Name = "SetAttachmentToolStripMenuItem1"
        Me.SetAttachmentToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.SetAttachmentToolStripMenuItem1.Text = "Add Attachment"
        '
        'cmdViewAttachment
        '
        Me.cmdViewAttachment.Image = Global.Coffeecup.My.Resources.Resources.inbox_document_text
        Me.cmdViewAttachment.Name = "cmdViewAttachment"
        Me.cmdViewAttachment.Size = New System.Drawing.Size(175, 22)
        Me.cmdViewAttachment.Text = "View Attachment"
        '
        'ExtractAttachmentToolStripMenuItem
        '
        Me.ExtractAttachmentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow1
        Me.ExtractAttachmentToolStripMenuItem.Name = "ExtractAttachmentToolStripMenuItem"
        Me.ExtractAttachmentToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ExtractAttachmentToolStripMenuItem.Text = "Extract Attachment"
        '
        'cmdCancelLastApprovingAction
        '
        Me.cmdCancelLastApprovingAction.Image = Global.Coffeecup.My.Resources.Resources.cross_button
        Me.cmdCancelLastApprovingAction.Name = "cmdCancelLastApprovingAction"
        Me.cmdCancelLastApprovingAction.Size = New System.Drawing.Size(231, 22)
        Me.cmdCancelLastApprovingAction.Text = "Cancel Last Approving Action"
        Me.cmdCancelLastApprovingAction.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(228, 6)
        '
        'menu_Refresh
        '
        Me.menu_Refresh.ForeColor = System.Drawing.Color.Black
        Me.menu_Refresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.menu_Refresh.Name = "menu_Refresh"
        Me.menu_Refresh.Size = New System.Drawing.Size(231, 22)
        Me.menu_Refresh.Text = "Refresh Data"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarCheckItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "&Close Window"
        Me.BarCheckItem1.Id = 0
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Report"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export to Excel"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Column Settings"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(930, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 569)
        Me.barDockControlBottom.Size = New System.Drawing.Size(930, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 547)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(930, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 547)
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdaction.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.Appearance.Options.UseFont = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdaction.Location = New System.Drawing.Point(243, 60)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(141, 30)
        Me.cmdaction.TabIndex = 578
        Me.cmdaction.Text = "Filter Search"
        '
        'txttodate
        '
        Me.txttodate.EditValue = New Date(CType(0, Long))
        Me.txttodate.Enabled = False
        Me.txttodate.EnterMoveNextControl = True
        Me.txttodate.Location = New System.Drawing.Point(243, 35)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodate.Properties.Appearance.Options.UseFont = True
        Me.txttodate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttodate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txttodate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txttodate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttodate.Size = New System.Drawing.Size(141, 20)
        Me.txttodate.TabIndex = 577
        '
        'txtfrmdate
        '
        Me.txtfrmdate.EditValue = New Date(CType(0, Long))
        Me.txtfrmdate.Enabled = False
        Me.txtfrmdate.EnterMoveNextControl = True
        Me.txtfrmdate.Location = New System.Drawing.Point(87, 35)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrmdate.Properties.Appearance.Options.UseFont = True
        Me.txtfrmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfrmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtfrmdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtfrmdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtfrmdate.Size = New System.Drawing.Size(141, 20)
        Me.txtfrmdate.TabIndex = 576
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(55, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl4.TabIndex = 583
        Me.LabelControl4.Text = "From"
        '
        'ck_AllOffice
        '
        Me.ck_AllOffice.EditValue = True
        Me.ck_AllOffice.Location = New System.Drawing.Point(388, 12)
        Me.ck_AllOffice.Name = "ck_AllOffice"
        Me.ck_AllOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_AllOffice.Properties.Appearance.Options.UseFont = True
        Me.ck_AllOffice.Properties.Caption = "View All"
        Me.ck_AllOffice.Size = New System.Drawing.Size(80, 19)
        Me.ck_AllOffice.TabIndex = 582
        '
        'lblOffice
        '
        Me.lblOffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblOffice.Location = New System.Drawing.Point(9, 14)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(72, 13)
        Me.lblOffice.TabIndex = 581
        Me.lblOffice.Text = "Select "
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.Enabled = False
        Me.txtOffice.Location = New System.Drawing.Point(87, 11)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select Inventory"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.ValueMember = "Select Inventory"
        Me.txtOffice.Properties.View = Me.gv_inventory
        Me.txtOffice.Size = New System.Drawing.Size(297, 20)
        Me.txtOffice.TabIndex = 574
        '
        'gv_inventory
        '
        Me.gv_inventory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_inventory.Name = "gv_inventory"
        Me.gv_inventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_inventory.OptionsView.ShowGroupPanel = False
        '
        'ckasof
        '
        Me.ckasof.Enabled = False
        Me.ckasof.Location = New System.Drawing.Point(85, 58)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckasof.Properties.Appearance.Options.UseFont = True
        Me.ckasof.Properties.Caption = "use report as of"
        Me.ckasof.Size = New System.Drawing.Size(135, 19)
        Me.ckasof.TabIndex = 589
        '
        'officeid
        '
        Me.officeid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.officeid.Location = New System.Drawing.Point(1470, 45)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(83, 21)
        Me.officeid.TabIndex = 508
        Me.officeid.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckPendingRequest)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lblOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckasof)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdaction)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txttodate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtfrmdate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ck_AllOffice)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.MinSize = 100
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(930, 547)
        Me.SplitContainerControl1.TabIndex = 595
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ckPendingRequest
        '
        Me.ckPendingRequest.EditValue = True
        Me.ckPendingRequest.Location = New System.Drawing.Point(388, 36)
        Me.ckPendingRequest.Name = "ckPendingRequest"
        Me.ckPendingRequest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPendingRequest.Properties.Appearance.Options.UseFont = True
        Me.ckPendingRequest.Properties.Caption = "Pending Request"
        Me.ckPendingRequest.Size = New System.Drawing.Size(113, 19)
        Me.ckPendingRequest.TabIndex = 590
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabCorporate
        Me.XtraTabControl1.Size = New System.Drawing.Size(930, 442)
        Me.XtraTabControl1.TabIndex = 323
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCorporate, Me.tabOffice})
        '
        'tabCorporate
        '
        Me.tabCorporate.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCorporate.Appearance.Header.Options.UseFont = True
        Me.tabCorporate.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCorporate.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCorporate.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCorporate.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCorporate.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCorporate.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCorporate.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCorporate.Appearance.PageClient.Options.UseFont = True
        Me.tabCorporate.Controls.Add(Me.Em)
        Me.tabCorporate.Name = "tabCorporate"
        Me.tabCorporate.Size = New System.Drawing.Size(924, 412)
        Me.tabCorporate.Text = "Corporate Level Requisition"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(924, 412)
        Me.Em.TabIndex = 322
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'tabOffice
        '
        Me.tabOffice.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabOffice.Appearance.Header.Options.UseFont = True
        Me.tabOffice.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabOffice.Appearance.HeaderActive.Options.UseFont = True
        Me.tabOffice.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabOffice.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabOffice.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabOffice.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabOffice.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabOffice.Appearance.PageClient.Options.UseFont = True
        Me.tabOffice.Name = "tabOffice"
        Me.tabOffice.Size = New System.Drawing.Size(924, 412)
        Me.tabOffice.Text = "Office Level Requisition"
        '
        'frmRequisitionsManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 569)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(766, 481)
        Me.Name = "frmRequisitionsManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cms.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_AllOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ckPendingRequest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabCorporate.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menu_Refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents menu_action As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttodate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtfrmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ck_AllOffice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblOffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckasof As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents AttachmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAttachmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckPendingRequest As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabOffice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabCorporate As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ExtractAttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCancelLastApprovingAction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdUpdateRequisitionStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditRequest As System.Windows.Forms.ToolStripMenuItem
End Class
