<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollAttendanceView
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.payrollcode = New DevExpress.XtraEditors.TextEdit()
        Me.employeeid = New DevExpress.XtraEditors.TextEdit()
        Me.shiftcode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(911, 523)
        Me.Em.TabIndex = 645
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsCustomization.AllowGroup = False
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(523, 103)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(58, 20)
        Me.payrollcode.TabIndex = 776
        Me.payrollcode.Visible = False
        '
        'employeeid
        '
        Me.employeeid.Location = New System.Drawing.Point(523, 129)
        Me.employeeid.Name = "employeeid"
        Me.employeeid.Size = New System.Drawing.Size(58, 20)
        Me.employeeid.TabIndex = 777
        Me.employeeid.Visible = False
        '
        'shiftcode
        '
        Me.shiftcode.Location = New System.Drawing.Point(523, 155)
        Me.shiftcode.Name = "shiftcode"
        Me.shiftcode.Size = New System.Drawing.Size(58, 20)
        Me.shiftcode.TabIndex = 788
        Me.shiftcode.Visible = False
        '
        'frmPayrollAttendanceView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 523)
        Me.Controls.Add(Me.shiftcode)
        Me.Controls.Add(Me.employeeid)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.Em)
        Me.MinimumSize = New System.Drawing.Size(702, 333)
        Me.Name = "frmPayrollAttendanceView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents payrollcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents employeeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents shiftcode As DevExpress.XtraEditors.TextEdit
End Class
