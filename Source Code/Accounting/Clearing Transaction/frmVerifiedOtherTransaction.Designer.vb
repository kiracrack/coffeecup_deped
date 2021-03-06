﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifiedOtherTransaction
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
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.dueid = New DevExpress.XtraEditors.TextEdit()
        Me.lblchecktype = New DevExpress.XtraEditors.LabelControl()
        Me.txtChargeFrom = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gridDepositTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.creditAccount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransactionName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Gridview_TransactionName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChargeFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDepositTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.creditAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(271, 79)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(150, 30)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Confirm Cleared"
        '
        'dueid
        '
        Me.dueid.Location = New System.Drawing.Point(535, 98)
        Me.dueid.Name = "dueid"
        Me.dueid.Properties.Appearance.Options.UseTextOptions = True
        Me.dueid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dueid.Properties.ReadOnly = True
        Me.dueid.Size = New System.Drawing.Size(62, 20)
        Me.dueid.TabIndex = 581
        '
        'lblchecktype
        '
        Me.lblchecktype.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblchecktype.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblchecktype.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblchecktype.Location = New System.Drawing.Point(34, 50)
        Me.lblchecktype.Name = "lblchecktype"
        Me.lblchecktype.Size = New System.Drawing.Size(135, 20)
        Me.lblchecktype.TabIndex = 715
        Me.lblchecktype.Text = "Affect Cash Account"
        '
        'txtChargeFrom
        '
        Me.txtChargeFrom.EditValue = "Select Group"
        Me.txtChargeFrom.Location = New System.Drawing.Point(178, 47)
        Me.txtChargeFrom.Name = "txtChargeFrom"
        Me.txtChargeFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtChargeFrom.Properties.Appearance.Options.UseFont = True
        Me.txtChargeFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtChargeFrom.Properties.DisplayMember = "Account Name"
        Me.txtChargeFrom.Properties.ImmediatePopup = True
        Me.txtChargeFrom.Properties.NullText = ""
        Me.txtChargeFrom.Properties.ValueMember = "Account Name"
        Me.txtChargeFrom.Properties.View = Me.gridDepositTo
        Me.txtChargeFrom.Size = New System.Drawing.Size(243, 26)
        Me.txtChargeFrom.TabIndex = 714
        '
        'gridDepositTo
        '
        Me.gridDepositTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridDepositTo.Name = "gridDepositTo"
        Me.gridDepositTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridDepositTo.OptionsView.ShowGroupPanel = False
        '
        'creditAccount
        '
        Me.creditAccount.EnterMoveNextControl = True
        Me.creditAccount.Location = New System.Drawing.Point(113, 89)
        Me.creditAccount.Name = "creditAccount"
        Me.creditAccount.Size = New System.Drawing.Size(56, 20)
        Me.creditAccount.TabIndex = 716
        Me.creditAccount.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(49, 21)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(120, 20)
        Me.LabelControl9.TabIndex = 742
        Me.LabelControl9.Text = "Transaction Name"
        '
        'txtTransactionName
        '
        Me.txtTransactionName.EditValue = "Select Group"
        Me.txtTransactionName.Location = New System.Drawing.Point(178, 17)
        Me.txtTransactionName.Name = "txtTransactionName"
        Me.txtTransactionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtTransactionName.Properties.Appearance.Options.UseFont = True
        Me.txtTransactionName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransactionName.Properties.DisplayMember = "Transaction Name"
        Me.txtTransactionName.Properties.NullText = ""
        Me.txtTransactionName.Properties.ValueMember = "itemcode"
        Me.txtTransactionName.Properties.View = Me.Gridview_TransactionName
        Me.txtTransactionName.Size = New System.Drawing.Size(243, 26)
        Me.txtTransactionName.TabIndex = 741
        '
        'Gridview_TransactionName
        '
        Me.Gridview_TransactionName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Gridview_TransactionName.Name = "Gridview_TransactionName"
        Me.Gridview_TransactionName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Gridview_TransactionName.OptionsView.ShowGroupPanel = False
        '
        'itemcode
        '
        Me.itemcode.EnterMoveNextControl = True
        Me.itemcode.Location = New System.Drawing.Point(178, 89)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(56, 20)
        Me.itemcode.TabIndex = 743
        Me.itemcode.Visible = False
        '
        'frmVerifiedOtherTransaction
        '
        Me.AcceptButton = Me.cmdOk
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 135)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtTransactionName)
        Me.Controls.Add(Me.creditAccount)
        Me.Controls.Add(Me.lblchecktype)
        Me.Controls.Add(Me.txtChargeFrom)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dueid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerifiedOtherTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Transaction for Clearing"
        CType(Me.dueid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChargeFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDepositTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.creditAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dueid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblchecktype As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChargeFrom As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gridDepositTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents creditAccount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransactionName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents Gridview_TransactionName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
End Class
