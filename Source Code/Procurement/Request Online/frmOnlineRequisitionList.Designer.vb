<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineRequisitionList
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
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ParticularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAttachmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtractAttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.POTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tabForReceiving = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPending = New DevExpress.XtraTab.XtraTabPage()
        Me.tabReceived = New DevExpress.XtraTab.XtraTabPage()
        Me.tabDisapproved = New DevExpress.XtraTab.XtraTabPage()
        Me.tabCancelled = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ckasof = New DevExpress.XtraEditors.CheckEdit()
        Me.txtfrmdate = New DevExpress.XtraEditors.DateEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txttodate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POTabControl.SuspendLayout()
        Me.tabPending.SuspendLayout()
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Report"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Export to Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 533)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 511)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 511)
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1022, 397)
        Me.Em.TabIndex = 13
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParticularToolStripMenuItem, Me.cmdCancel, Me.AttachmentsToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayFormatToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(166, 120)
        '
        'ParticularToolStripMenuItem
        '
        Me.ParticularToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.book_open_list
        Me.ParticularToolStripMenuItem.Name = "ParticularToolStripMenuItem"
        Me.ParticularToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ParticularToolStripMenuItem.Text = "View Request"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.Coffeecup.My.Resources.Resources.ui_toolbar_bookmark1
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(165, 22)
        Me.cmdCancel.Text = "Hold Request"
        '
        'AttachmentsToolStripMenuItem
        '
        Me.AttachmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetAttachmentToolStripMenuItem1, Me.cmdViewAttachment, Me.ExtractAttachmentToolStripMenuItem})
        Me.AttachmentsToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow
        Me.AttachmentsToolStripMenuItem.Name = "AttachmentsToolStripMenuItem"
        Me.AttachmentsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
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
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "View Appearance"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'POTabControl
        '
        Me.POTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.POTabControl.Location = New System.Drawing.Point(0, 106)
        Me.POTabControl.Name = "POTabControl"
        Me.POTabControl.SelectedTabPage = Me.tabForReceiving
        Me.POTabControl.Size = New System.Drawing.Size(1028, 427)
        Me.POTabControl.TabIndex = 19
        Me.POTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabForReceiving, Me.tabPending, Me.tabReceived, Me.tabDisapproved, Me.tabCancelled})
        '
        'tabForReceiving
        '
        Me.tabForReceiving.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabForReceiving.Appearance.Header.Options.UseFont = True
        Me.tabForReceiving.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabForReceiving.Appearance.HeaderActive.Options.UseFont = True
        Me.tabForReceiving.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabForReceiving.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabForReceiving.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabForReceiving.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabForReceiving.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabForReceiving.Appearance.PageClient.Options.UseFont = True
        Me.tabForReceiving.Name = "tabForReceiving"
        Me.tabForReceiving.Size = New System.Drawing.Size(1022, 397)
        Me.tabForReceiving.Text = "Pending for Receiving Request"
        '
        'tabPending
        '
        Me.tabPending.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Appearance.Header.Options.UseFont = True
        Me.tabPending.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Appearance.HeaderActive.Options.UseFont = True
        Me.tabPending.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabPending.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabPending.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Appearance.PageClient.Options.UseFont = True
        Me.tabPending.Controls.Add(Me.Em)
        Me.tabPending.Name = "tabPending"
        Me.tabPending.Size = New System.Drawing.Size(1022, 397)
        Me.tabPending.Text = "Pending Office Approval"
        '
        'tabReceived
        '
        Me.tabReceived.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReceived.Appearance.Header.Options.UseFont = True
        Me.tabReceived.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReceived.Appearance.HeaderActive.Options.UseFont = True
        Me.tabReceived.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReceived.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabReceived.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReceived.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabReceived.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabReceived.Appearance.PageClient.Options.UseFont = True
        Me.tabReceived.Name = "tabReceived"
        Me.tabReceived.Size = New System.Drawing.Size(1022, 397)
        Me.tabReceived.Text = "Received Requisition Logs"
        '
        'tabDisapproved
        '
        Me.tabDisapproved.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabDisapproved.Appearance.Header.Options.UseFont = True
        Me.tabDisapproved.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabDisapproved.Appearance.HeaderActive.Options.UseFont = True
        Me.tabDisapproved.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabDisapproved.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabDisapproved.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabDisapproved.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabDisapproved.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabDisapproved.Appearance.PageClient.Options.UseFont = True
        Me.tabDisapproved.Name = "tabDisapproved"
        Me.tabDisapproved.Size = New System.Drawing.Size(1022, 397)
        Me.tabDisapproved.Text = "Disapproved Requisition"
        '
        'tabCancelled
        '
        Me.tabCancelled.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCancelled.Appearance.Header.Options.UseFont = True
        Me.tabCancelled.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCancelled.Appearance.HeaderActive.Options.UseFont = True
        Me.tabCancelled.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCancelled.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tabCancelled.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCancelled.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tabCancelled.Appearance.PageClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCancelled.Appearance.PageClient.Options.UseFont = True
        Me.tabCancelled.Name = "tabCancelled"
        Me.tabCancelled.Size = New System.Drawing.Size(1022, 397)
        Me.tabCancelled.Text = "Cancelled Requisition logs"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(24, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 595
        Me.LabelControl3.Text = "From"
        '
        'ckasof
        '
        Me.ckasof.Location = New System.Drawing.Point(55, 60)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckasof.Properties.Appearance.Options.UseFont = True
        Me.ckasof.Properties.Caption = "use report as of"
        Me.ckasof.Size = New System.Drawing.Size(135, 19)
        Me.ckasof.TabIndex = 597
        '
        'txtfrmdate
        '
        Me.txtfrmdate.EditValue = New Date(CType(0, Long))
        Me.txtfrmdate.EnterMoveNextControl = True
        Me.txtfrmdate.Location = New System.Drawing.Point(57, 37)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrmdate.Properties.Appearance.Options.UseFont = True
        Me.txtfrmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfrmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtfrmdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtfrmdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtfrmdate.Size = New System.Drawing.Size(141, 20)
        Me.txtfrmdate.TabIndex = 592
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
        Me.cmdaction.Location = New System.Drawing.Point(220, 62)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(141, 30)
        Me.cmdaction.TabIndex = 594
        Me.cmdaction.Text = "Filter Search"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(203, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 596
        Me.LabelControl1.Text = "To"
        '
        'txttodate
        '
        Me.txttodate.EditValue = New Date(CType(0, Long))
        Me.txttodate.EnterMoveNextControl = True
        Me.txttodate.Location = New System.Drawing.Point(220, 37)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodate.Properties.Appearance.Options.UseFont = True
        Me.txttodate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttodate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txttodate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txttodate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttodate.Size = New System.Drawing.Size(141, 20)
        Me.txttodate.TabIndex = 593
        '
        'frmOnlineRequisitionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 533)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ckasof)
        Me.Controls.Add(Me.txtfrmdate)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.POTabControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmOnlineRequisitionList"
        Me.Text = "Online Requisition Report"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POTabControl.ResumeLayout(False)
        Me.tabPending.ResumeLayout(False)
        CType(Me.ckasof.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfrmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttodate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabForReceiving As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabReceived As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCancelled As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDisapproved As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ParticularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabPending As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckasof As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtfrmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttodate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AttachmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAttachmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtractAttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
