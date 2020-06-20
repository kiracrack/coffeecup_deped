<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemControl
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
        Me.ck_all = New DevExpress.XtraEditors.CheckEdit()
        Me.ckpooption = New DevExpress.XtraEditors.RadioGroup()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCountdown = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_all.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl2.TabIndex = 507
        Me.LabelControl2.Text = "Select User Account"
        '
        'uid
        '
        Me.uid.Location = New System.Drawing.Point(364, 57)
        Me.uid.Name = "uid"
        Me.uid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uid.Properties.Appearance.Options.UseFont = True
        Me.uid.Properties.Appearance.Options.UseTextOptions = True
        Me.uid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.uid.Properties.ReadOnly = True
        Me.uid.Size = New System.Drawing.Size(162, 20)
        Me.uid.TabIndex = 508
        Me.uid.Visible = False
        '
        'txtrequestby
        '
        Me.txtrequestby.EditValue = ""
        Me.txtrequestby.Location = New System.Drawing.Point(12, 27)
        Me.txtrequestby.Name = "txtrequestby"
        Me.txtrequestby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtrequestby.Properties.DisplayMember = "Account Name"
        Me.txtrequestby.Properties.NullText = ""
        Me.txtrequestby.Properties.ValueMember = "Account Name"
        Me.txtrequestby.Properties.View = Me.s_grid
        Me.txtrequestby.Size = New System.Drawing.Size(310, 20)
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
        Me.cmdUpdate.Location = New System.Drawing.Point(12, 257)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(310, 30)
        Me.cmdUpdate.TabIndex = 510
        Me.cmdUpdate.Text = "Fire in the Hole"
        '
        'ck_all
        '
        Me.ck_all.Location = New System.Drawing.Point(241, 8)
        Me.ck_all.Name = "ck_all"
        Me.ck_all.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ck_all.Properties.Appearance.Options.UseBackColor = True
        Me.ck_all.Properties.AutoHeight = False
        Me.ck_all.Properties.Caption = "All Account"
        Me.ck_all.Size = New System.Drawing.Size(81, 19)
        Me.ck_all.TabIndex = 511
        '
        'ckpooption
        '
        Me.ckpooption.EditValue = ""
        Me.ckpooption.Location = New System.Drawing.Point(12, 51)
        Me.ckpooption.Name = "ckpooption"
        Me.ckpooption.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckpooption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("", "Shutdown System"), New DevExpress.XtraEditors.Controls.RadioGroupItem("", "Logoff Account"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Clear Logged"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Do Nothing")})
        Me.ckpooption.Size = New System.Drawing.Size(310, 84)
        Me.ckpooption.TabIndex = 620
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(12, 156)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(310, 69)
        Me.txtMessage.TabIndex = 621
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 141)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 622
        Me.LabelControl1.Text = "Message"
        '
        'txtCountdown
        '
        Me.txtCountdown.Location = New System.Drawing.Point(216, 231)
        Me.txtCountdown.Name = "txtCountdown"
        Me.txtCountdown.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountdown.Properties.Appearance.Options.UseFont = True
        Me.txtCountdown.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCountdown.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCountdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCountdown.Properties.Items.AddRange(New Object() {"5", "10", "15", "20", "30", "45", "60"})
        Me.txtCountdown.Size = New System.Drawing.Size(106, 20)
        Me.txtCountdown.TabIndex = 623
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(94, 234)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl3.TabIndex = 624
        Me.LabelControl3.Text = "Action Countdown (Sec)"
        '
        'frmSystemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 297)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ckpooption)
        Me.Controls.Add(Me.ck_all)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.uid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtrequestby)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtCountdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSystemControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Control"
        CType(Me.uid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_all.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckpooption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrequestby As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents s_grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ck_all As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckpooption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCountdown As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
