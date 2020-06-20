<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateAdvancePaymentInvoices
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cifid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdvancePayment = New DevExpress.XtraEditors.TextEdit()
        Me.ckDiscount = New DevExpress.XtraEditors.CheckEdit()
        Me.txtClientAccount = New DevExpress.XtraEditors.TextEdit()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdvancePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseBackColor = True
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdOk.Location = New System.Drawing.Point(113, 317)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(281, 30)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "Confirm Update as Paid Invoices"
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(168, 48)
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(484, 229)
        Me.ListView1.TabIndex = 696
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(113, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl1.TabIndex = 652
        Me.LabelControl1.Text = "Client Account Name"
        '
        'cifid
        '
        Me.cifid.EnterMoveNextControl = True
        Me.cifid.Location = New System.Drawing.Point(23, 98)
        Me.cifid.Name = "cifid"
        Me.cifid.Size = New System.Drawing.Size(82, 20)
        Me.cifid.TabIndex = 706
        Me.cifid.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(131, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl5.TabIndex = 721
        Me.LabelControl5.Text = "Advance Payment Balance"
        '
        'txtAdvancePayment
        '
        Me.txtAdvancePayment.EditValue = ""
        Me.txtAdvancePayment.Location = New System.Drawing.Point(264, 51)
        Me.txtAdvancePayment.Name = "txtAdvancePayment"
        Me.txtAdvancePayment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtAdvancePayment.Properties.Appearance.Options.UseFont = True
        Me.txtAdvancePayment.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdvancePayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdvancePayment.Properties.Mask.EditMask = "n"
        Me.txtAdvancePayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdvancePayment.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAdvancePayment.Properties.ReadOnly = True
        Me.txtAdvancePayment.Size = New System.Drawing.Size(130, 22)
        Me.txtAdvancePayment.TabIndex = 720
        '
        'ckDiscount
        '
        Me.ckDiscount.Location = New System.Drawing.Point(4, 59)
        Me.ckDiscount.Name = "ckDiscount"
        Me.ckDiscount.Properties.Caption = "Check All"
        Me.ckDiscount.Size = New System.Drawing.Size(101, 19)
        Me.ckDiscount.TabIndex = 722
        '
        'txtClientAccount
        '
        Me.txtClientAccount.EditValue = ""
        Me.txtClientAccount.Location = New System.Drawing.Point(113, 28)
        Me.txtClientAccount.Name = "txtClientAccount"
        Me.txtClientAccount.Size = New System.Drawing.Size(281, 20)
        Me.txtClientAccount.TabIndex = 0
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Coffeecup.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Edit Discount"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.Coffeecup.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(167, 22)
        Me.cmdDelete.Text = "Remove Discount"
        '
        'frmUpdateAdvancePaymentInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 356)
        Me.Controls.Add(Me.ckDiscount)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtAdvancePayment)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtClientAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateAdvancePaymentInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Invoices as Paid for Advance Payment"
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.cifid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdvancePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cifid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdvancePayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtClientAccount As DevExpress.XtraEditors.TextEdit
End Class
