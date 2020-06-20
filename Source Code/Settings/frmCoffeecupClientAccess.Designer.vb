<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoffeecupClientAccess
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.code = New DevExpress.XtraEditors.TextEdit()
        Me.txtPermission = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPermission = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.appStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdremove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckdefault = New DevExpress.XtraEditors.CheckEdit()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appStrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckdefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Permission"
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(211, 109)
        Me.code.Name = "code"
        Me.code.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Properties.Appearance.Options.UseFont = True
        Me.code.Properties.Appearance.Options.UseTextOptions = True
        Me.code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.code.Properties.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(77, 20)
        Me.code.TabIndex = 508
        Me.code.Visible = False
        '
        'txtPermission
        '
        Me.txtPermission.EditValue = "sss"
        Me.txtPermission.Location = New System.Drawing.Point(68, 12)
        Me.txtPermission.Name = "txtPermission"
        Me.txtPermission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPermission.Properties.DisplayMember = "Permission"
        Me.txtPermission.Properties.NullText = ""
        Me.txtPermission.Properties.ValueMember = "Permission"
        Me.txtPermission.Properties.View = Me.gridPermission
        Me.txtPermission.Size = New System.Drawing.Size(269, 20)
        Me.txtPermission.TabIndex = 506
        '
        'gridPermission
        '
        Me.gridPermission.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPermission.Name = "gridPermission"
        Me.gridPermission.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPermission.OptionsView.ShowGroupPanel = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(238, 35)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(99, 25)
        Me.cmdUpdate.TabIndex = 510
        Me.cmdUpdate.Text = "Add to Account"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.appStrip
        Me.Em.Location = New System.Drawing.Point(8, 65)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(335, 279)
        Me.Em.TabIndex = 685
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'appStrip
        '
        Me.appStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdremove, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.appStrip.Name = "gridmenustrip"
        Me.appStrip.Size = New System.Drawing.Size(145, 54)
        '
        'cmdremove
        '
        Me.cmdremove.Image = Global.Coffeecup.My.Resources.Resources.window_suppressed
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(144, 22)
        Me.cmdremove.Text = "Remove Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ckdefault
        '
        Me.ckdefault.Location = New System.Drawing.Point(68, 36)
        Me.ckdefault.Name = "ckdefault"
        Me.ckdefault.Properties.Caption = "Set default permission"
        Me.ckdefault.Size = New System.Drawing.Size(136, 19)
        Me.ckdefault.TabIndex = 686
        '
        'userid
        '
        Me.userid.Location = New System.Drawing.Point(136, 163)
        Me.userid.Name = "userid"
        Me.userid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Properties.Appearance.Options.UseFont = True
        Me.userid.Properties.Appearance.Options.UseTextOptions = True
        Me.userid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.userid.Properties.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(77, 20)
        Me.userid.TabIndex = 687
        Me.userid.Visible = False
        '
        'frmCoffeecupClientAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 349)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.ckdefault)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtPermission)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCoffeecupClientAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffeecup Client Access"
        CType(Me.code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appStrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckdefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPermission As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPermission As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckdefault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents appStrip As ContextMenuStrip
    Friend WithEvents cmdremove As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
End Class
