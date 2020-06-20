<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComunicationBox
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Em_chat = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grid_chat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.timertransfer = New System.Windows.Forms.Timer(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabChatbox = New DevExpress.XtraTab.XtraTabPage()
        Me.tabLatestNotification = New DevExpress.XtraTab.XtraTabPage()
        Me.em_latest = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grid_latest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAttachment = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_attachment = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewAttachmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grid_attachment = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.Em_chat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Grid_chat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabChatbox.SuspendLayout()
        Me.tabLatestNotification.SuspendLayout()
        CType(Me.em_latest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.grid_latest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAttachment.SuspendLayout()
        CType(Me.Em_attachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.grid_attachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("b2ec862f-ee6d-4f17-97e1-7b797002210b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(322, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(322, 542)
        Me.DockPanel1.Text = "Corporate Division"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.PanelControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(314, 515)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Em)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(314, 515)
        Me.PanelControl1.TabIndex = 334
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(2, 2)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(310, 511)
        Me.Em.TabIndex = 340
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em_chat)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.officeid)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(554, 514)
        Me.SplitContainerControl1.SplitterPosition = 71
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'Em_chat
        '
        Me.Em_chat.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em_chat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_chat.Location = New System.Drawing.Point(0, 0)
        Me.Em_chat.MainView = Me.Grid_chat
        Me.Em_chat.Name = "Em_chat"
        Me.Em_chat.Size = New System.Drawing.Size(554, 438)
        Me.Em_chat.TabIndex = 337
        Me.Em_chat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_chat})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Grid_chat
        '
        Me.Grid_chat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.Grid_chat.GridControl = Me.Em_chat
        Me.Grid_chat.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.Grid_chat.Name = "Grid_chat"
        Me.Grid_chat.OptionsBehavior.Editable = False
        Me.Grid_chat.OptionsView.RowAutoHeight = True
        Me.Grid_chat.OptionsView.ShowColumnHeaders = False
        Me.Grid_chat.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Grid_chat.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(131, 161)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeid.Properties.Appearance.Options.UseBackColor = True
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(60, 20)
        Me.officeid.TabIndex = 335
        Me.officeid.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtMessage)
        Me.PanelControl2.Controls.Add(Me.cmdaction)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(554, 71)
        Me.PanelControl2.TabIndex = 9
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.EditValue = ""
        Me.txtMessage.EnterMoveNextControl = True
        Me.txtMessage.Location = New System.Drawing.Point(1, 0)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(498, 70)
        Me.txtMessage.TabIndex = 7
        '
        'cmdaction
        '
        Me.cmdaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdaction.Location = New System.Drawing.Point(500, 0)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(53, 70)
        Me.cmdaction.TabIndex = 8
        Me.cmdaction.Text = "&Send"
        '
        'timertransfer
        '
        Me.timertransfer.Interval = 1000
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(322, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabChatbox
        Me.XtraTabControl1.Size = New System.Drawing.Size(560, 542)
        Me.XtraTabControl1.TabIndex = 338
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabChatbox, Me.tabLatestNotification, Me.tabAttachment})
        '
        'tabChatbox
        '
        Me.tabChatbox.Controls.Add(Me.SplitContainerControl1)
        Me.tabChatbox.Name = "tabChatbox"
        Me.tabChatbox.Size = New System.Drawing.Size(554, 514)
        Me.tabChatbox.Text = "Chat Box"
        '
        'tabLatestNotification
        '
        Me.tabLatestNotification.Controls.Add(Me.em_latest)
        Me.tabLatestNotification.Name = "tabLatestNotification"
        Me.tabLatestNotification.Size = New System.Drawing.Size(554, 514)
        Me.tabLatestNotification.Text = "Latest Notification Box"
        '
        'em_latest
        '
        Me.em_latest.ContextMenuStrip = Me.ContextMenuStrip2
        Me.em_latest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.em_latest.Location = New System.Drawing.Point(0, 0)
        Me.em_latest.MainView = Me.grid_latest
        Me.em_latest.Name = "em_latest"
        Me.em_latest.Size = New System.Drawing.Size(554, 514)
        Me.em_latest.TabIndex = 338
        Me.em_latest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_latest})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(114, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Text = "Refresh"
        '
        'grid_latest
        '
        Me.grid_latest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.grid_latest.GridControl = Me.em_latest
        Me.grid_latest.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.grid_latest.Name = "grid_latest"
        Me.grid_latest.OptionsBehavior.Editable = False
        Me.grid_latest.OptionsView.RowAutoHeight = True
        Me.grid_latest.OptionsView.ShowColumnHeaders = False
        Me.grid_latest.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.grid_latest.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'tabAttachment
        '
        Me.tabAttachment.Controls.Add(Me.Em_attachment)
        Me.tabAttachment.Name = "tabAttachment"
        Me.tabAttachment.Size = New System.Drawing.Size(554, 514)
        Me.tabAttachment.Text = "Attachment"
        '
        'Em_attachment
        '
        Me.Em_attachment.ContextMenuStrip = Me.ContextMenuStrip3
        Me.Em_attachment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_attachment.Location = New System.Drawing.Point(0, 0)
        Me.Em_attachment.MainView = Me.grid_attachment
        Me.Em_attachment.Name = "Em_attachment"
        Me.Em_attachment.Size = New System.Drawing.Size(554, 514)
        Me.Em_attachment.TabIndex = 338
        Me.Em_attachment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_attachment})
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAttachmentToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(166, 48)
        '
        'ViewAttachmentToolStripMenuItem
        '
        Me.ViewAttachmentToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.inbox__arrow
        Me.ViewAttachmentToolStripMenuItem.Name = "ViewAttachmentToolStripMenuItem"
        Me.ViewAttachmentToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewAttachmentToolStripMenuItem.Text = "View Attachment"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "Refresh"
        '
        'grid_attachment
        '
        Me.grid_attachment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
        Me.grid_attachment.GridControl = Me.Em_attachment
        Me.grid_attachment.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Nothing, "", "1")})
        Me.grid_attachment.Name = "grid_attachment"
        Me.grid_attachment.OptionsBehavior.Editable = False
        Me.grid_attachment.OptionsView.RowAutoHeight = True
        Me.grid_attachment.OptionsView.ShowColumnHeaders = False
        Me.grid_attachment.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.grid_attachment.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'frmComunicationBox
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 542)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(776, 481)
        Me.Name = "frmComunicationBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comunication Box"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.Em_chat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Grid_chat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabChatbox.ResumeLayout(False)
        Me.tabLatestNotification.ResumeLayout(False)
        CType(Me.em_latest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.grid_latest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAttachment.ResumeLayout(False)
        CType(Me.Em_attachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.grid_attachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em_chat As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_chat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents timertransfer As System.Windows.Forms.Timer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabChatbox As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLatestNotification As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents em_latest As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_latest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabAttachment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_attachment As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_attachment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAttachmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
