<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferedInfo
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
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.lblinvetory = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.txtInventoryfrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtInventoryto = New DevExpress.XtraEditors.TextEdit()
        Me.txtRequestby = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesignation = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit()
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.inventoryto = New DevExpress.XtraEditors.TextEdit()
        Me.inventoryfrom = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventoryfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventoryto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(34, 116)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 538
        Me.LabelControl1.Text = "Transfer to"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(33, 139)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl9.TabIndex = 543
        Me.LabelControl9.Text = "Request By"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(94, 43)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(239, 13)
        Me.LabelControl8.TabIndex = 563
        Me.LabelControl8.Text = "This form is allow to view request item information"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(94, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 19)
        Me.lblTitle.TabIndex = 562
        Me.lblTitle.Text = "Transfered Request Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(94, 49)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(250, 13)
        Me.LabelControl10.TabIndex = 561
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.Coffeecup.My.Resources.Resources.preferences_system_network_2
        Me.PanelControl1.Location = New System.Drawing.Point(22, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl1.TabIndex = 560
        '
        'Em
        '
        Me.Em.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(354, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(534, 382)
        Me.Em.TabIndex = 589
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Total", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(33, 69)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 593
        Me.LabelControl6.Text = "Batch Code"
        '
        'Batchcode
        '
        Me.Batchcode.EditValue = ""
        Me.Batchcode.EnterMoveNextControl = True
        Me.Batchcode.Location = New System.Drawing.Point(93, 66)
        Me.Batchcode.Name = "Batchcode"
        Me.Batchcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batchcode.Properties.Appearance.Options.UseFont = True
        Me.Batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.Batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Batchcode.Properties.ReadOnly = True
        Me.Batchcode.Size = New System.Drawing.Size(161, 20)
        Me.Batchcode.TabIndex = 592
        '
        'lblinvetory
        '
        Me.lblinvetory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblinvetory.Location = New System.Drawing.Point(13, 92)
        Me.lblinvetory.Name = "lblinvetory"
        Me.lblinvetory.Size = New System.Drawing.Size(75, 13)
        Me.lblinvetory.TabIndex = 600
        Me.lblinvetory.Text = "From Inventory"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(65, 184)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 605
        Me.LabelControl4.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(93, 182)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(251, 54)
        Me.txtNote.TabIndex = 3
        '
        'cmdPrint
        '
        Me.cmdPrint.Appearance.BackColor2 = System.Drawing.Color.Lavender
        Me.cmdPrint.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrint.Location = New System.Drawing.Point(186, 263)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(158, 30)
        Me.cmdPrint.TabIndex = 608
        Me.cmdPrint.Text = "Print Request Copy"
        '
        'txtInventoryfrom
        '
        Me.txtInventoryfrom.EditValue = ""
        Me.txtInventoryfrom.Location = New System.Drawing.Point(93, 89)
        Me.txtInventoryfrom.Name = "txtInventoryfrom"
        Me.txtInventoryfrom.Properties.ReadOnly = True
        Me.txtInventoryfrom.Size = New System.Drawing.Size(251, 20)
        Me.txtInventoryfrom.TabIndex = 0
        Me.txtInventoryfrom.ToolTip = "Shortcut Key (F12)"
        '
        'txtInventoryto
        '
        Me.txtInventoryto.EditValue = ""
        Me.txtInventoryto.Location = New System.Drawing.Point(93, 112)
        Me.txtInventoryto.Name = "txtInventoryto"
        Me.txtInventoryto.Properties.ReadOnly = True
        Me.txtInventoryto.Size = New System.Drawing.Size(251, 20)
        Me.txtInventoryto.TabIndex = 1
        '
        'txtRequestby
        '
        Me.txtRequestby.EditValue = ""
        Me.txtRequestby.Location = New System.Drawing.Point(93, 135)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Properties.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(251, 20)
        Me.txtRequestby.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(51, 161)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 610
        Me.LabelControl2.Text = "Position"
        '
        'txtDesignation
        '
        Me.txtDesignation.EditValue = ""
        Me.txtDesignation.Location = New System.Drawing.Point(93, 158)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Properties.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(251, 20)
        Me.txtDesignation.TabIndex = 609
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 242)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 612
        Me.LabelControl3.Text = "Request Status"
        '
        'txtStatus
        '
        Me.txtStatus.EditValue = ""
        Me.txtStatus.EnterMoveNextControl = True
        Me.txtStatus.Location = New System.Drawing.Point(93, 239)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Properties.Appearance.Options.UseFont = True
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(251, 20)
        Me.txtStatus.TabIndex = 611
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirm.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdConfirm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdConfirm.Appearance.Options.UseBackColor = True
        Me.cmdConfirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdConfirm.Location = New System.Drawing.Point(186, 263)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(158, 30)
        Me.cmdConfirm.TabIndex = 613
        Me.cmdConfirm.Text = "Confirm Request"
        '
        'inventoryto
        '
        Me.inventoryto.EditValue = ""
        Me.inventoryto.Location = New System.Drawing.Point(33, 350)
        Me.inventoryto.Name = "inventoryto"
        Me.inventoryto.Properties.ReadOnly = True
        Me.inventoryto.Size = New System.Drawing.Size(70, 20)
        Me.inventoryto.TabIndex = 614
        Me.inventoryto.Visible = False
        '
        'inventoryfrom
        '
        Me.inventoryfrom.EditValue = ""
        Me.inventoryfrom.Location = New System.Drawing.Point(109, 350)
        Me.inventoryfrom.Name = "inventoryfrom"
        Me.inventoryfrom.Properties.ReadOnly = True
        Me.inventoryfrom.Size = New System.Drawing.Size(70, 20)
        Me.inventoryfrom.TabIndex = 615
        Me.inventoryfrom.Visible = False
        '
        'frmTransferedInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 382)
        Me.Controls.Add(Me.inventoryfrom)
        Me.Controls.Add(Me.inventoryto)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lblinvetory)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.Batchcode)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtInventoryfrom)
        Me.Controls.Add(Me.txtInventoryto)
        Me.Controls.Add(Me.txtRequestby)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransferedInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Transfer Items"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventoryfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventoryto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblinvetory As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtInventoryfrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInventoryto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRequestby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesignation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents inventoryto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents inventoryfrom As DevExpress.XtraEditors.TextEdit
End Class
