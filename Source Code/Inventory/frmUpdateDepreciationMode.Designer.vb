<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDepreciationMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateDepreciationMode))
        Me.g_Stocks = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.accountableid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.potrnid = New DevExpress.XtraEditors.TextEdit()
        Me.txtMemoLetter = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountableid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potrnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemoLetter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_Stocks
        '
        Me.g_Stocks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.g_Stocks.Name = "g_Stocks"
        Me.g_Stocks.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.g_Stocks.OptionsView.ShowGroupPanel = False
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
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(9, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl5.TabIndex = 647
        Me.LabelControl5.Text = "Memorandum of Receipt and Accountability"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = "The items stated above are in good condition"
        Me.txtRemarks.Location = New System.Drawing.Point(9, 207)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(575, 23)
        Me.txtRemarks.TabIndex = 2
        Me.txtRemarks.ToolTip = "Remarks"
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
        'txtMemoLetter
        '
        Me.txtMemoLetter.EditValue = resources.GetString("txtMemoLetter.EditValue")
        Me.txtMemoLetter.Location = New System.Drawing.Point(9, 26)
        Me.txtMemoLetter.Name = "txtMemoLetter"
        Me.txtMemoLetter.Size = New System.Drawing.Size(575, 176)
        Me.txtMemoLetter.TabIndex = 1
        Me.txtMemoLetter.ToolTip = "Remarks"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(300, 237)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(179, 30)
        Me.SimpleButton1.TabIndex = 661
        Me.SimpleButton1.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(115, 237)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(179, 30)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Confirm Print"
        '
        'frmUpdateDepreciationMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 273)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtMemoLetter)
        Me.Controls.Add(Me.potrnid)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.accountableid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateDepreciationMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmation of Memorandum"
        Me.TopMost = True
        CType(Me.g_Stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountableid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potrnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemoLetter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents g_Stocks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents accountableid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents potrnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMemoLetter As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
