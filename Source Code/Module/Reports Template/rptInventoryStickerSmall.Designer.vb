<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptInventoryStickerSmall
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptInventoryStickerSmall))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAccountablePerson = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtIssueNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyName, Me.txtAccountablePerson, Me.txtIssueNumber, Me.XrPictureBox1})
        Me.TopMargin.HeightF = 59.375!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial Narrow", 5.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.000002!, 10.00001!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(147.2502!, 12.5!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseForeColor = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtCompanyName.Visible = False
        '
        'txtAccountablePerson
        '
        Me.txtAccountablePerson.Font = New System.Drawing.Font("Tahoma", 5.75!)
        Me.txtAccountablePerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAccountablePerson.LocationFloat = New DevExpress.Utils.PointFloat(7.999999!, 45.91664!)
        Me.txtAccountablePerson.Name = "txtAccountablePerson"
        Me.txtAccountablePerson.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAccountablePerson.SizeF = New System.Drawing.SizeF(143.2502!, 8.333336!)
        Me.txtAccountablePerson.StylePriority.UseFont = False
        Me.txtAccountablePerson.StylePriority.UseForeColor = False
        Me.txtAccountablePerson.StylePriority.UseTextAlignment = False
        Me.txtAccountablePerson.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtIssueNumber
        '
        Me.txtIssueNumber.Font = New System.Drawing.Font("Tahoma", 5.75!)
        Me.txtIssueNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIssueNumber.LocationFloat = New DevExpress.Utils.PointFloat(39.83352!, 25.5!)
        Me.txtIssueNumber.Name = "txtIssueNumber"
        Me.txtIssueNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtIssueNumber.SizeF = New System.Drawing.SizeF(111.4166!, 9.375002!)
        Me.txtIssueNumber.StylePriority.UseFont = False
        Me.txtIssueNumber.StylePriority.UseForeColor = False
        Me.txtIssueNumber.StylePriority.UseTextAlignment = False
        Me.txtIssueNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(156.5!, 58.96!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptInventoryStickerSmall
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 59, 0)
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents txtIssueNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAccountablePerson As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class
