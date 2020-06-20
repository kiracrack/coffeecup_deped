<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoffeecupClient
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtSystemName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDownloadUrl = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVersion = New DevExpress.XtraEditors.TextEdit()
        Me.txtvalunit = New DevExpress.XtraEditors.LabelControl()
        Me.lbl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDetails = New DevExpress.XtraEditors.TextEdit()
        Me.txtFeatures = New DevExpress.XtraEditors.MemoEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menu_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDownloadUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.txtSystemName)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtPassword)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtDownloadUrl)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtVersion)
        Me.PanelControl1.Controls.Add(Me.txtvalunit)
        Me.PanelControl1.Controls.Add(Me.lbl2)
        Me.PanelControl1.Controls.Add(Me.txtDetails)
        Me.PanelControl1.Controls.Add(Me.txtFeatures)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(364, 471)
        Me.PanelControl1.TabIndex = 622
        '
        'txtSystemName
        '
        Me.txtSystemName.Appearance.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtSystemName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtSystemName.Location = New System.Drawing.Point(14, 7)
        Me.txtSystemName.Name = "txtSystemName"
        Me.txtSystemName.Size = New System.Drawing.Size(218, 13)
        Me.txtSystemName.TabIndex = 420
        Me.txtSystemName.Text = "Current Coffeecup Client Information"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(31, 428)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 419
        Me.LabelControl4.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.EditValue = ""
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(82, 425)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPassword.Properties.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(165, 20)
        Me.txtPassword.TabIndex = 418
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(34, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl3.TabIndex = 417
        Me.LabelControl3.Text = "Features"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 415
        Me.LabelControl2.Text = "Download Url"
        '
        'txtDownloadUrl
        '
        Me.txtDownloadUrl.EditValue = ""
        Me.txtDownloadUrl.EnterMoveNextControl = True
        Me.txtDownloadUrl.Location = New System.Drawing.Point(82, 76)
        Me.txtDownloadUrl.Name = "txtDownloadUrl"
        Me.txtDownloadUrl.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDownloadUrl.Properties.ReadOnly = True
        Me.txtDownloadUrl.Size = New System.Drawing.Size(267, 20)
        Me.txtDownloadUrl.TabIndex = 414
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 413
        Me.LabelControl1.Text = "Version"
        '
        'txtVersion
        '
        Me.txtVersion.EditValue = ""
        Me.txtVersion.EnterMoveNextControl = True
        Me.txtVersion.Location = New System.Drawing.Point(82, 53)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVersion.Properties.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(97, 20)
        Me.txtVersion.TabIndex = 412
        '
        'txtvalunit
        '
        Me.txtvalunit.Location = New System.Drawing.Point(349, 11)
        Me.txtvalunit.Name = "txtvalunit"
        Me.txtvalunit.Size = New System.Drawing.Size(0, 13)
        Me.txtvalunit.TabIndex = 411
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(45, 33)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(32, 13)
        Me.lbl2.TabIndex = 410
        Me.lbl2.Text = "Details"
        '
        'txtDetails
        '
        Me.txtDetails.EditValue = ""
        Me.txtDetails.EnterMoveNextControl = True
        Me.txtDetails.Location = New System.Drawing.Point(82, 30)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDetails.Properties.ReadOnly = True
        Me.txtDetails.Size = New System.Drawing.Size(250, 20)
        Me.txtDetails.TabIndex = 8
        '
        'txtFeatures
        '
        Me.txtFeatures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFeatures.EditValue = ""
        Me.txtFeatures.Location = New System.Drawing.Point(82, 99)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Properties.ReadOnly = True
        Me.txtFeatures.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFeatures.Size = New System.Drawing.Size(267, 321)
        Me.txtFeatures.TabIndex = 416
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.cms
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(386, 12)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(549, 471)
        Me.Em.TabIndex = 623
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Refresh})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(141, 26)
        '
        'menu_Refresh
        '
        Me.menu_Refresh.ForeColor = System.Drawing.Color.Black
        Me.menu_Refresh.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.menu_Refresh.Name = "menu_Refresh"
        Me.menu_Refresh.Size = New System.Drawing.Size(140, 22)
        Me.menu_Refresh.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'frmCoffeecupClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 491)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmCoffeecupClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Client Monitoring"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDownloadUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDownloadUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtvalunit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFeatures As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSystemName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menu_Refresh As System.Windows.Forms.ToolStripMenuItem
End Class
