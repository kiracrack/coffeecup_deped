<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLCaptureChartofAccount
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.companyid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCompany = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView_company = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChartofAccounts = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChartofAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(139, 48)
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(133, 92)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(181, 32)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Confirm Upload"
        '
        'companyid
        '
        Me.companyid.EditValue = ""
        Me.companyid.Location = New System.Drawing.Point(461, 131)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Options.UseTextOptions = True
        Me.companyid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.companyid.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.companyid.Properties.Mask.BeepOnError = True
        Me.companyid.Properties.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(39, 20)
        Me.companyid.TabIndex = 655
        Me.companyid.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.EditValue = ""
        Me.txtCompany.Location = New System.Drawing.Point(133, 41)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCompany.Properties.DisplayMember = "Company"
        Me.txtCompany.Properties.NullText = ""
        Me.txtCompany.Properties.ValueMember = "Code"
        Me.txtCompany.Properties.View = Me.GridView_company
        Me.txtCompany.Size = New System.Drawing.Size(231, 22)
        Me.txtCompany.TabIndex = 747
        '
        'GridView_company
        '
        Me.GridView_company.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView_company.Name = "GridView_company"
        Me.GridView_company.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView_company.OptionsView.ShowGroupPanel = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(72, 44)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 15)
        Me.LabelControl6.TabIndex = 748
        Me.LabelControl6.Text = "Company"
        '
        'txtChartofAccounts
        '
        Me.txtChartofAccounts.Location = New System.Drawing.Point(133, 66)
        Me.txtChartofAccounts.Name = "txtChartofAccounts"
        Me.txtChartofAccounts.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChartofAccounts.Properties.Appearance.Options.UseFont = True
        Me.txtChartofAccounts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtChartofAccounts.Properties.ReadOnly = True
        Me.txtChartofAccounts.Size = New System.Drawing.Size(320, 22)
        Me.txtChartofAccounts.TabIndex = 749
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(65, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl1.TabIndex = 750
        Me.LabelControl1.Text = "Upload File"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(81, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(251, 15)
        Me.LabelControl2.TabIndex = 751
        Me.LabelControl2.Text = "Please use Standard Chart of Account Excel File "
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(138, 22)
        Me.cmdEdit.Text = "Edit Code"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus1
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(138, 22)
        Me.cmdDelete.Text = "Delete Code"
        '
        'frmGLCaptureChartofAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 151)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtChartofAccounts)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGLCaptureChartofAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Chart of Account"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChartofAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents companyid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCompany As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView_company As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChartofAccounts As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
