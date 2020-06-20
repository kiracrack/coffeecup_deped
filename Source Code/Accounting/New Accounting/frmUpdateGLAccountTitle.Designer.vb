<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateGLAccountTitle
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCreditAccount = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridview_credit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDebitAccount = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridview_debit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.credit = New DevExpress.XtraEditors.TextEdit()
        Me.debit = New DevExpress.XtraEditors.TextEdit()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        Me.ckCreditGroup = New DevExpress.XtraEditors.CheckEdit()
        Me.ckDebitGroup = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.txtCreditAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_credit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_debit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.debit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCreditGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDebitGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(146, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(145, 22)
        Me.cmdEdit.Text = "Edit Category"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(145, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "&Close Window"
        Me.BarLargeButtonItem1.Id = 1
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(436, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 147)
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Location = New System.Drawing.Point(239, 84)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(159, 32)
        Me.cmdUpdate.TabIndex = 696
        Me.cmdUpdate.Text = "Confirm"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(37, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl3.TabIndex = 728
        Me.LabelControl3.Text = "Credit Account"
        '
        'txtCreditAccount
        '
        Me.txtCreditAccount.EditValue = ""
        Me.txtCreditAccount.Location = New System.Drawing.Point(134, 52)
        Me.txtCreditAccount.Name = "txtCreditAccount"
        Me.txtCreditAccount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCreditAccount.Properties.Appearance.Options.UseFont = True
        Me.txtCreditAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCreditAccount.Properties.DisplayMember = "Item Name"
        Me.txtCreditAccount.Properties.NullText = ""
        Me.txtCreditAccount.Properties.ValueMember = "ItemCode"
        Me.txtCreditAccount.Properties.View = Me.gridview_credit
        Me.txtCreditAccount.Size = New System.Drawing.Size(264, 26)
        Me.txtCreditAccount.TabIndex = 727
        '
        'gridview_credit
        '
        Me.gridview_credit.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridview_credit.Name = "gridview_credit"
        Me.gridview_credit.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridview_credit.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(41, 25)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl5.TabIndex = 726
        Me.LabelControl5.Text = "Debit Account"
        '
        'txtDebitAccount
        '
        Me.txtDebitAccount.EditValue = ""
        Me.txtDebitAccount.Location = New System.Drawing.Point(134, 22)
        Me.txtDebitAccount.Name = "txtDebitAccount"
        Me.txtDebitAccount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDebitAccount.Properties.Appearance.Options.UseFont = True
        Me.txtDebitAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDebitAccount.Properties.DisplayMember = "Item Name"
        Me.txtDebitAccount.Properties.NullText = ""
        Me.txtDebitAccount.Properties.ValueMember = "ItemCode"
        Me.txtDebitAccount.Properties.View = Me.gridview_debit
        Me.txtDebitAccount.Size = New System.Drawing.Size(264, 26)
        Me.txtDebitAccount.TabIndex = 725
        '
        'gridview_debit
        '
        Me.gridview_debit.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridview_debit.Name = "gridview_debit"
        Me.gridview_debit.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridview_debit.OptionsView.ShowGroupPanel = False
        '
        'credit
        '
        Me.credit.EnterMoveNextControl = True
        Me.credit.Location = New System.Drawing.Point(81, 226)
        Me.credit.Name = "credit"
        Me.credit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.credit.Properties.Appearance.Options.UseFont = True
        Me.credit.Size = New System.Drawing.Size(41, 20)
        Me.credit.TabIndex = 735
        Me.credit.Visible = False
        '
        'debit
        '
        Me.debit.EnterMoveNextControl = True
        Me.debit.Location = New System.Drawing.Point(34, 226)
        Me.debit.Name = "debit"
        Me.debit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.debit.Properties.Appearance.Options.UseFont = True
        Me.debit.Size = New System.Drawing.Size(41, 20)
        Me.debit.TabIndex = 734
        Me.debit.Visible = False
        '
        'companyid
        '
        Me.companyid.EnterMoveNextControl = True
        Me.companyid.Location = New System.Drawing.Point(128, 226)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Size = New System.Drawing.Size(41, 20)
        Me.companyid.TabIndex = 737
        Me.companyid.Visible = False
        '
        'ckCreditGroup
        '
        Me.ckCreditGroup.Location = New System.Drawing.Point(474, 28)
        Me.ckCreditGroup.Name = "ckCreditGroup"
        Me.ckCreditGroup.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.ckCreditGroup.Properties.Appearance.Options.UseFont = True
        Me.ckCreditGroup.Properties.Caption = "Group Account"
        Me.ckCreditGroup.Size = New System.Drawing.Size(107, 19)
        Me.ckCreditGroup.TabIndex = 739
        Me.ckCreditGroup.Visible = False
        '
        'ckDebitGroup
        '
        Me.ckDebitGroup.Location = New System.Drawing.Point(474, 60)
        Me.ckDebitGroup.Name = "ckDebitGroup"
        Me.ckDebitGroup.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.ckDebitGroup.Properties.Appearance.Options.UseFont = True
        Me.ckDebitGroup.Properties.Caption = "Group Account"
        Me.ckDebitGroup.Size = New System.Drawing.Size(107, 19)
        Me.ckDebitGroup.TabIndex = 740
        Me.ckDebitGroup.Visible = False
        '
        'frmUpdateGLAccountTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 147)
        Me.Controls.Add(Me.ckDebitGroup)
        Me.Controls.Add(Me.ckCreditGroup)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.debit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCreditAccount)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtDebitAccount)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Name = "frmUpdateGLAccountTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Updater"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.txtCreditAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_credit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_debit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.debit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCreditGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDebitGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreditAccount As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridview_credit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDebitAccount As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridview_debit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents credit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents debit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDebitGroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckCreditGroup As DevExpress.XtraEditors.CheckEdit
End Class
