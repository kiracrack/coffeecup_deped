<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestProcessing
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
        Me.cmdMove = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.g_po = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcontrol_po = New DevExpress.XtraGrid.GridControl()
        Me.gridview_po = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbldisbursingoffice = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisbursingOffice = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmdViewFullRequest = New DevExpress.XtraEditors.SimpleButton()
        Me.g_requestor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pid = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchaseBy = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtoffice = New DevExpress.XtraEditors.TextEdit()
        Me.lbloffice = New DevExpress.XtraEditors.LabelControl()
        Me.processtype = New DevExpress.XtraEditors.TextEdit()
        Me.reqid = New DevExpress.XtraEditors.TextEdit()
        Me.potype = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcontrol_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisbursingOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_requestor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.processtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Location = New System.Drawing.Point(768, 432)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 30)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdMove
        '
        Me.cmdMove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdMove.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdMove.Appearance.Options.UseBackColor = True
        Me.cmdMove.Appearance.Options.UseFont = True
        Me.cmdMove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdMove.Location = New System.Drawing.Point(513, 432)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(252, 30)
        Me.cmdMove.TabIndex = 2
        Me.cmdMove.Text = "Confirm && Process Purchase Order"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(13, 82)
        Me.Em.MainView = Me.g_po
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(867, 343)
        Me.Em.TabIndex = 640
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.g_po})
        '
        'g_po
        '
        Me.g_po.GridControl = Me.Em
        Me.g_po.Name = "g_po"
        Me.g_po.OptionsCustomization.AllowColumnMoving = False
        Me.g_po.OptionsCustomization.AllowColumnResizing = False
        Me.g_po.OptionsCustomization.AllowGroup = False
        Me.g_po.OptionsMenu.EnableColumnMenu = False
        Me.g_po.OptionsPrint.UsePrintStyles = False
        Me.g_po.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.g_po.OptionsSelection.UseIndicatorForSelection = False
        Me.g_po.OptionsView.RowAutoHeight = True
        Me.g_po.OptionsView.ShowGroupPanel = False
        '
        'gcontrol_po
        '
        Me.gcontrol_po.Location = New System.Drawing.Point(218, 149)
        Me.gcontrol_po.MainView = Me.gridview_po
        Me.gcontrol_po.Name = "gcontrol_po"
        Me.gcontrol_po.Size = New System.Drawing.Size(484, 178)
        Me.gcontrol_po.TabIndex = 641
        Me.gcontrol_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_po})
        Me.gcontrol_po.Visible = False
        '
        'gridview_po
        '
        Me.gridview_po.GridControl = Me.gcontrol_po
        Me.gridview_po.Name = "gridview_po"
        Me.gridview_po.OptionsBehavior.Editable = False
        Me.gridview_po.OptionsCustomization.AllowColumnMoving = False
        Me.gridview_po.OptionsCustomization.AllowColumnResizing = False
        Me.gridview_po.OptionsCustomization.AllowGroup = False
        Me.gridview_po.OptionsMenu.EnableColumnMenu = False
        Me.gridview_po.OptionsPrint.UsePrintStyles = False
        Me.gridview_po.OptionsView.ShowGroupPanel = False
        Me.gridview_po.PaintStyleName = "Web"
        '
        'lbldisbursingoffice
        '
        Me.lbldisbursingoffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbldisbursingoffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisbursingoffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbldisbursingoffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbldisbursingoffice.Location = New System.Drawing.Point(12, 436)
        Me.lbldisbursingoffice.Name = "lbldisbursingoffice"
        Me.lbldisbursingoffice.Size = New System.Drawing.Size(127, 20)
        Me.lbldisbursingoffice.TabIndex = 728
        Me.lbldisbursingoffice.Text = "Disbursing Level"
        '
        'txtDisbursingOffice
        '
        Me.txtDisbursingOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDisbursingOffice.Location = New System.Drawing.Point(146, 433)
        Me.txtDisbursingOffice.Name = "txtDisbursingOffice"
        Me.txtDisbursingOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisbursingOffice.Properties.Appearance.Options.UseFont = True
        Me.txtDisbursingOffice.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDisbursingOffice.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtDisbursingOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDisbursingOffice.Properties.Items.AddRange(New Object() {"BRANCH", "CORPORATE"})
        Me.txtDisbursingOffice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDisbursingOffice.Size = New System.Drawing.Size(207, 28)
        Me.txtDisbursingOffice.TabIndex = 727
        '
        'cmdViewFullRequest
        '
        Me.cmdViewFullRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdViewFullRequest.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewFullRequest.Appearance.Options.UseFont = True
        Me.cmdViewFullRequest.Enabled = False
        Me.cmdViewFullRequest.Location = New System.Drawing.Point(361, 432)
        Me.cmdViewFullRequest.Name = "cmdViewFullRequest"
        Me.cmdViewFullRequest.Size = New System.Drawing.Size(149, 30)
        Me.cmdViewFullRequest.TabIndex = 729
        Me.cmdViewFullRequest.Text = "View Full Request"
        '
        'g_requestor
        '
        Me.g_requestor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_requestor.Name = "g_requestor"
        Me.g_requestor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_requestor.OptionsView.ShowGroupPanel = False
        '
        'pid
        '
        Me.pid.EditValue = ""
        Me.pid.Location = New System.Drawing.Point(124, 10)
        Me.pid.Name = "pid"
        Me.pid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Properties.Appearance.Options.UseFont = True
        Me.pid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pid.Properties.DisplayMember = "Request. ID"
        Me.pid.Properties.NullText = ""
        Me.pid.Properties.ValueMember = "Request. ID"
        Me.pid.Properties.View = Me.g_requestor
        Me.pid.Size = New System.Drawing.Size(319, 20)
        Me.pid.TabIndex = 634
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(14, 13)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl8.TabIndex = 635
        Me.LabelControl8.Text = "Approved Request"
        '
        'txtPurchaseBy
        '
        Me.txtPurchaseBy.EditValue = ""
        Me.txtPurchaseBy.Location = New System.Drawing.Point(124, 33)
        Me.txtPurchaseBy.Name = "txtPurchaseBy"
        Me.txtPurchaseBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseBy.Properties.Appearance.Options.UseFont = True
        Me.txtPurchaseBy.Properties.ReadOnly = True
        Me.txtPurchaseBy.Properties.ValidateOnEnterKey = True
        Me.txtPurchaseBy.Size = New System.Drawing.Size(236, 20)
        Me.txtPurchaseBy.TabIndex = 636
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(52, 36)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 637
        Me.LabelControl6.Text = "Request by"
        '
        'txtoffice
        '
        Me.txtoffice.EditValue = ""
        Me.txtoffice.Location = New System.Drawing.Point(124, 56)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoffice.Properties.Appearance.Options.UseFont = True
        Me.txtoffice.Properties.ReadOnly = True
        Me.txtoffice.Properties.ValidateOnEnterKey = True
        Me.txtoffice.Size = New System.Drawing.Size(236, 20)
        Me.txtoffice.TabIndex = 638
        '
        'lbloffice
        '
        Me.lbloffice.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloffice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbloffice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbloffice.Location = New System.Drawing.Point(19, 59)
        Me.lbloffice.Name = "lbloffice"
        Me.lbloffice.Size = New System.Drawing.Size(90, 14)
        Me.lbloffice.TabIndex = 639
        '
        'processtype
        '
        Me.processtype.EditValue = ""
        Me.processtype.Location = New System.Drawing.Point(480, 10)
        Me.processtype.Name = "processtype"
        Me.processtype.Properties.ReadOnly = True
        Me.processtype.Properties.ValidateOnEnterKey = True
        Me.processtype.Size = New System.Drawing.Size(94, 20)
        Me.processtype.TabIndex = 642
        Me.processtype.Visible = False
        '
        'reqid
        '
        Me.reqid.EditValue = ""
        Me.reqid.Location = New System.Drawing.Point(480, 36)
        Me.reqid.Name = "reqid"
        Me.reqid.Properties.ReadOnly = True
        Me.reqid.Properties.ValidateOnEnterKey = True
        Me.reqid.Size = New System.Drawing.Size(94, 20)
        Me.reqid.TabIndex = 730
        Me.reqid.Visible = False
        '
        'potype
        '
        Me.potype.EditValue = ""
        Me.potype.Location = New System.Drawing.Point(580, 36)
        Me.potype.Name = "potype"
        Me.potype.Properties.ReadOnly = True
        Me.potype.Properties.ValidateOnEnterKey = True
        Me.potype.Size = New System.Drawing.Size(94, 20)
        Me.potype.TabIndex = 731
        Me.potype.Visible = False
        '
        'frmRequestProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 469)
        Me.Controls.Add(Me.potype)
        Me.Controls.Add(Me.reqid)
        Me.Controls.Add(Me.cmdViewFullRequest)
        Me.Controls.Add(Me.lbldisbursingoffice)
        Me.Controls.Add(Me.txtDisbursingOffice)
        Me.Controls.Add(Me.processtype)
        Me.Controls.Add(Me.lbloffice)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtPurchaseBy)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.gcontrol_po)
        Me.Controls.Add(Me.Em)
        Me.MinimumSize = New System.Drawing.Size(908, 508)
        Me.Name = "frmRequestProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Generator"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcontrol_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisbursingOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_requestor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.processtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents g_po As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcontrol_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_po As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbldisbursingoffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisbursingOffice As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdViewFullRequest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g_requestor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pid As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchaseBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtoffice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbloffice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents processtype As DevExpress.XtraEditors.TextEdit
    Friend WithEvents reqid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents potype As DevExpress.XtraEditors.TextEdit
End Class
