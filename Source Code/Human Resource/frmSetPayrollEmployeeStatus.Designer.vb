<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPayrollEmployeeStatus
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
        Me.positioncode = New DevExpress.XtraEditors.TextEdit()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEmployeeType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdApprove = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.positioncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'positioncode
        '
        Me.positioncode.Location = New System.Drawing.Point(135, 53)
        Me.positioncode.Name = "positioncode"
        Me.positioncode.Properties.Appearance.Options.UseTextOptions = True
        Me.positioncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.positioncode.Properties.ReadOnly = True
        Me.positioncode.Size = New System.Drawing.Size(53, 20)
        Me.positioncode.TabIndex = 580
        Me.positioncode.Visible = False
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.SetDefaultToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.FormatGridToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(168, 120)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(167, 22)
        Me.cmdDelete.Text = "Remove"
        '
        'SetDefaultToolStripMenuItem
        '
        Me.SetDefaultToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.dialog_ok_4
        Me.SetDefaultToolStripMenuItem.Name = "SetDefaultToolStripMenuItem"
        Me.SetDefaultToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SetDefaultToolStripMenuItem.Text = "Set Default Group"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'FormatGridToolStripMenuItem
        '
        Me.FormatGridToolStripMenuItem.Image = Global.Coffeecup.My.Resources.Resources.edit
        Me.FormatGridToolStripMenuItem.Name = "FormatGridToolStripMenuItem"
        Me.FormatGridToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.FormatGridToolStripMenuItem.Text = "View Appearance"
        '
        'txtEmployeeType
        '
        Me.txtEmployeeType.EditValue = ""
        Me.txtEmployeeType.Location = New System.Drawing.Point(135, 21)
        Me.txtEmployeeType.Name = "txtEmployeeType"
        Me.txtEmployeeType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeType.Properties.Appearance.Options.UseFont = True
        Me.txtEmployeeType.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtEmployeeType.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtEmployeeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEmployeeType.Properties.PopupSizeable = True
        Me.txtEmployeeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtEmployeeType.Size = New System.Drawing.Size(256, 26)
        Me.txtEmployeeType.TabIndex = 709
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(19, 24)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(110, 20)
        Me.LabelControl13.TabIndex = 710
        Me.LabelControl13.Text = "Employee Status"
        '
        'cmdApprove
        '
        Me.cmdApprove.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdApprove.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdApprove.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmdApprove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdApprove.Appearance.Options.UseBackColor = True
        Me.cmdApprove.Appearance.Options.UseFont = True
        Me.cmdApprove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdApprove.Location = New System.Drawing.Point(269, 51)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.Size = New System.Drawing.Size(122, 32)
        Me.cmdApprove.TabIndex = 711
        Me.cmdApprove.Text = "Confirm"
        '
        'frmSetPayrollEmployeeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 99)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtEmployeeType)
        Me.Controls.Add(Me.positioncode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetPayrollEmployeeStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Employee Status"
        CType(Me.positioncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.txtEmployeeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents positioncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEmployeeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdApprove As DevExpress.XtraEditors.SimpleButton
End Class
