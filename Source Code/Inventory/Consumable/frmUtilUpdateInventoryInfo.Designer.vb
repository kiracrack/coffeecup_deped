<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilUpdateInventoryInfo
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtproduct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNewUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockRef = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(54, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl1.TabIndex = 554
        Me.LabelControl1.Text = "Particular"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(111, 64)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Properties.Appearance.Options.UseFont = True
        Me.txtproduct.Properties.Appearance.Options.UseTextOptions = True
        Me.txtproduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtproduct.Properties.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(249, 22)
        Me.txtproduct.TabIndex = 553
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(93, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(283, 13)
        Me.LabelControl8.TabIndex = 561
        Me.LabelControl8.Text = "This form is allow user to update inventory information"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(93, 19)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(157, 19)
        Me.LabelControl9.TabIndex = 560
        Me.LabelControl9.Text = "Update Inventory Info"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(91, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(248, 13)
        Me.LabelControl10.TabIndex = 559
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(111, 144)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(171, 32)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Confirm Update"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(30, 117)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 15)
        Me.LabelControl2.TabIndex = 625
        Me.LabelControl2.Text = "Purchase Cost"
        '
        'txtNewUnitCost
        '
        Me.txtNewUnitCost.EditValue = "0"
        Me.txtNewUnitCost.EnterMoveNextControl = True
        Me.txtNewUnitCost.Location = New System.Drawing.Point(111, 112)
        Me.txtNewUnitCost.Name = "txtNewUnitCost"
        Me.txtNewUnitCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNewUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewUnitCost.Properties.Appearance.Options.UseFont = True
        Me.txtNewUnitCost.Properties.Appearance.Options.UseForeColor = True
        Me.txtNewUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNewUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNewUnitCost.Properties.Mask.EditMask = "n"
        Me.txtNewUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNewUnitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNewUnitCost.Size = New System.Drawing.Size(171, 26)
        Me.txtNewUnitCost.TabIndex = 1
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.EnterMoveNextControl = True
        Me.trnid.Location = New System.Drawing.Point(93, 315)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Properties.ValidateOnEnterKey = True
        Me.trnid.Size = New System.Drawing.Size(77, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'txtStockRef
        '
        Me.txtStockRef.EditValue = ""
        Me.txtStockRef.EnterMoveNextControl = True
        Me.txtStockRef.Location = New System.Drawing.Point(111, 89)
        Me.txtStockRef.Name = "txtStockRef"
        Me.txtStockRef.Properties.ValidateOnEnterKey = True
        Me.txtStockRef.Size = New System.Drawing.Size(77, 20)
        Me.txtStockRef.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(66, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 15)
        Me.LabelControl3.TabIndex = 629
        Me.LabelControl3.Text = "Stock #"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.document_pencil
        Me.PanelControl1.Location = New System.Drawing.Point(21, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 558
        '
        'frmUtilUpdateInventoryInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 199)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtStockRef)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtNewUnitCost)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtproduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilUpdateInventoryInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Inventory Info"
        CType(Me.txtproduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtproduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNewUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
