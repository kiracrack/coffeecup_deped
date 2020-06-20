<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeUser
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.uid = New DevExpress.XtraEditors.TextEdit()
        Me.txtrequestby = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.s_grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Select User"
        '
        'uid
        '
        Me.uid.Location = New System.Drawing.Point(447, 49)
        Me.uid.Name = "uid"
        Me.uid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uid.Properties.Appearance.Options.UseFont = True
        Me.uid.Properties.Appearance.Options.UseTextOptions = True
        Me.uid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.uid.Properties.ReadOnly = True
        Me.uid.Size = New System.Drawing.Size(77, 20)
        Me.uid.TabIndex = 508
        Me.uid.Visible = False
        '
        'txtrequestby
        '
        Me.txtrequestby.EditValue = ""
        Me.txtrequestby.Location = New System.Drawing.Point(83, 22)
        Me.txtrequestby.Name = "txtrequestby"
        Me.txtrequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtrequestby.Properties.DisplayMember = "FULLNAME"
        Me.txtrequestby.Properties.NullText = ""
        Me.txtrequestby.Properties.ValueMember = "FULLNAME"
        Me.txtrequestby.Properties.View = Me.s_grid
        Me.txtrequestby.Size = New System.Drawing.Size(250, 20)
        Me.txtrequestby.TabIndex = 506
        '
        's_grid
        '
        Me.s_grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.s_grid.Name = "s_grid"
        Me.s_grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.s_grid.OptionsView.ShowGroupPanel = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(211, 48)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(122, 30)
        Me.cmdUpdate.TabIndex = 510
        Me.cmdUpdate.Text = "Activate"
        '
        'frmChangeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 93)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.uid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtrequestby)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangeUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change User"
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
End Class
