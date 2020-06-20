<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitAccountablePerson
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
        Me.g_Stocks = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.ffecode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAssignedDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtAccountablePerson = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_accountable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.accountableid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtnote = New DevExpress.XtraEditors.MemoEdit()
        Me.potrnid = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdateAccountable = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.issueid = New DevExpress.XtraEditors.TextEdit()
        Me.ckPredefine = New DevExpress.XtraEditors.CheckEdit()
        Me.officeinitialcode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssignedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssignedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountablePerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_accountable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountableid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potrnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.issueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckPredefine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeinitialcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_Stocks
        '
        Me.g_Stocks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_Stocks.Name = "g_Stocks"
        Me.g_Stocks.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_Stocks.OptionsView.ShowGroupPanel = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 41)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl10.TabIndex = 590
        Me.LabelControl10.Text = "Accountable Person"
        '
        'ffecode
        '
        Me.ffecode.EditValue = ""
        Me.ffecode.EnterMoveNextControl = True
        Me.ffecode.Location = New System.Drawing.Point(16, 174)
        Me.ffecode.Name = "ffecode"
        Me.ffecode.Properties.ReadOnly = True
        Me.ffecode.Properties.ValidateOnEnterKey = True
        Me.ffecode.Size = New System.Drawing.Size(50, 20)
        Me.ffecode.TabIndex = 635
        Me.ffecode.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(54, 63)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl11.TabIndex = 638
        Me.LabelControl11.Text = "Date Issue"
        '
        'txtAssignedDate
        '
        Me.txtAssignedDate.EditValue = New Date(CType(0, Long))
        Me.txtAssignedDate.Location = New System.Drawing.Point(111, 60)
        Me.txtAssignedDate.Name = "txtAssignedDate"
        Me.txtAssignedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAssignedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtAssignedDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtAssignedDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAssignedDate.Size = New System.Drawing.Size(214, 20)
        Me.txtAssignedDate.TabIndex = 1
        '
        'txtAccountablePerson
        '
        Me.txtAccountablePerson.EditValue = ""
        Me.txtAccountablePerson.Location = New System.Drawing.Point(111, 37)
        Me.txtAccountablePerson.Name = "txtAccountablePerson"
        Me.txtAccountablePerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccountablePerson.Properties.DisplayMember = "Fullname"
        Me.txtAccountablePerson.Properties.NullText = ""
        Me.txtAccountablePerson.Properties.ValueMember = "Fullname"
        Me.txtAccountablePerson.Properties.View = Me.gv_accountable
        Me.txtAccountablePerson.Size = New System.Drawing.Size(214, 20)
        Me.txtAccountablePerson.TabIndex = 0
        Me.txtAccountablePerson.ToolTip = "Shortcut Key (F11)"
        '
        'gv_accountable
        '
        Me.gv_accountable.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_accountable.Name = "gv_accountable"
        Me.gv_accountable.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_accountable.OptionsView.ShowGroupPanel = False
        '
        'accountableid
        '
        Me.accountableid.EditValue = ""
        Me.accountableid.EnterMoveNextControl = True
        Me.accountableid.Location = New System.Drawing.Point(119, 469)
        Me.accountableid.Name = "accountableid"
        Me.accountableid.Properties.ReadOnly = True
        Me.accountableid.Properties.ValidateOnEnterKey = True
        Me.accountableid.Size = New System.Drawing.Size(89, 20)
        Me.accountableid.TabIndex = 645
        Me.accountableid.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(82, 87)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 647
        Me.LabelControl5.Text = "Note"
        '
        'txtnote
        '
        Me.txtnote.EditValue = ""
        Me.txtnote.Location = New System.Drawing.Point(111, 84)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(272, 49)
        Me.txtnote.TabIndex = 3
        Me.txtnote.ToolTip = "Remarks"
        '
        'potrnid
        '
        Me.potrnid.EditValue = ""
        Me.potrnid.EnterMoveNextControl = True
        Me.potrnid.Location = New System.Drawing.Point(214, 469)
        Me.potrnid.Name = "potrnid"
        Me.potrnid.Properties.ReadOnly = True
        Me.potrnid.Properties.ValidateOnEnterKey = True
        Me.potrnid.Size = New System.Drawing.Size(89, 20)
        Me.potrnid.TabIndex = 651
        Me.potrnid.Visible = False
        '
        'cmdUpdateAccountable
        '
        Me.cmdUpdateAccountable.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdateAccountable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdateAccountable.Location = New System.Drawing.Point(204, 137)
        Me.cmdUpdateAccountable.Name = "cmdUpdateAccountable"
        Me.cmdUpdateAccountable.Size = New System.Drawing.Size(179, 30)
        Me.cmdUpdateAccountable.TabIndex = 659
        Me.cmdUpdateAccountable.Text = "Save Accountable"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Location = New System.Drawing.Point(40, 17)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl13.TabIndex = 661
        Me.LabelControl13.Text = "Issue Number"
        '
        'issueid
        '
        Me.issueid.EditValue = "AUTO GENERATE"
        Me.issueid.Location = New System.Drawing.Point(111, 14)
        Me.issueid.Name = "issueid"
        Me.issueid.Properties.Appearance.Options.UseTextOptions = True
        Me.issueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.issueid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.issueid.Properties.ReadOnly = True
        Me.issueid.Size = New System.Drawing.Size(120, 20)
        Me.issueid.TabIndex = 660
        Me.issueid.ToolTip = "Shortcut Key (F12)"
        '
        'ckPredefine
        '
        Me.ckPredefine.Location = New System.Drawing.Point(233, 14)
        Me.ckPredefine.Name = "ckPredefine"
        Me.ckPredefine.Properties.Caption = "Predefine"
        Me.ckPredefine.Size = New System.Drawing.Size(91, 19)
        Me.ckPredefine.TabIndex = 662
        '
        'officeinitialcode
        '
        Me.officeinitialcode.EditValue = ""
        Me.officeinitialcode.EnterMoveNextControl = True
        Me.officeinitialcode.Location = New System.Drawing.Point(82, 145)
        Me.officeinitialcode.Name = "officeinitialcode"
        Me.officeinitialcode.Properties.ReadOnly = True
        Me.officeinitialcode.Properties.ValidateOnEnterKey = True
        Me.officeinitialcode.Size = New System.Drawing.Size(50, 20)
        Me.officeinitialcode.TabIndex = 663
        Me.officeinitialcode.Visible = False
        '
        'frmUnitAccountablePerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 178)
        Me.Controls.Add(Me.officeinitialcode)
        Me.Controls.Add(Me.ckPredefine)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.issueid)
        Me.Controls.Add(Me.cmdUpdateAccountable)
        Me.Controls.Add(Me.potrnid)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.accountableid)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.ffecode)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtAssignedDate)
        Me.Controls.Add(Me.txtAccountablePerson)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUnitAccountablePerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountable Person Information"
        Me.TopMost = True
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ffecode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssignedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssignedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountablePerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_accountable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountableid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potrnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.issueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckPredefine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeinitialcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents g_Stocks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ffecode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAssignedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAccountablePerson As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_accountable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents accountableid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents potrnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdateAccountable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents issueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckPredefine As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents officeinitialcode As DevExpress.XtraEditors.TextEdit
End Class
