<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCheckPrint
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCheckDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckPayee = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtNumberInWords = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCheckDate, Me.txtCheckAmount, Me.txtCheckPayee, Me.txtNumberInWords})
        Me.TopMargin.HeightF = 268.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCheckDate
        '
        Me.txtCheckDate.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtCheckDate.BorderWidth = 0.5!
        Me.txtCheckDate.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.txtCheckDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCheckDate.LocationFloat = New DevExpress.Utils.PointFloat(600.5!, 51.66666!)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckDate.SizeF = New System.Drawing.SizeF(186.0034!, 13.54166!)
        Me.txtCheckDate.StylePriority.UseBorders = False
        Me.txtCheckDate.StylePriority.UseBorderWidth = False
        Me.txtCheckDate.StylePriority.UseFont = False
        Me.txtCheckDate.StylePriority.UseForeColor = False
        Me.txtCheckDate.StylePriority.UseTextAlignment = False
        Me.txtCheckDate.Text = "*** December, 13 1987 ***"
        Me.txtCheckDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtCheckAmount.BorderWidth = 0.5!
        Me.txtCheckAmount.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCheckAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCheckAmount.LocationFloat = New DevExpress.Utils.PointFloat(580.5!, 79.08334!)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckAmount.SizeF = New System.Drawing.SizeF(186.0034!, 13.54!)
        Me.txtCheckAmount.StylePriority.UseBorders = False
        Me.txtCheckAmount.StylePriority.UseBorderWidth = False
        Me.txtCheckAmount.StylePriority.UseFont = False
        Me.txtCheckAmount.StylePriority.UseForeColor = False
        Me.txtCheckAmount.StylePriority.UseTextAlignment = False
        Me.txtCheckAmount.Text = "*** 1,000.00 ***"
        Me.txtCheckAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtCheckPayee
        '
        Me.txtCheckPayee.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtCheckPayee.BorderWidth = 0.5!
        Me.txtCheckPayee.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCheckPayee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCheckPayee.LocationFloat = New DevExpress.Utils.PointFloat(108.25!, 79.08334!)
        Me.txtCheckPayee.Name = "txtCheckPayee"
        Me.txtCheckPayee.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckPayee.SizeF = New System.Drawing.SizeF(454.9341!, 13.54!)
        Me.txtCheckPayee.StylePriority.UseBorders = False
        Me.txtCheckPayee.StylePriority.UseBorderWidth = False
        Me.txtCheckPayee.StylePriority.UseFont = False
        Me.txtCheckPayee.StylePriority.UseForeColor = False
        Me.txtCheckPayee.StylePriority.UseTextAlignment = False
        Me.txtCheckPayee.Text = "*** JUAN DELA CRUZ MARTINEZ  ***"
        Me.txtCheckPayee.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtNumberInWords
        '
        Me.txtNumberInWords.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtNumberInWords.BorderWidth = 0.5!
        Me.txtNumberInWords.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.txtNumberInWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNumberInWords.LocationFloat = New DevExpress.Utils.PointFloat(108.25!, 103.375!)
        Me.txtNumberInWords.Name = "txtNumberInWords"
        Me.txtNumberInWords.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNumberInWords.SizeF = New System.Drawing.SizeF(667.8368!, 13.54!)
        Me.txtNumberInWords.StylePriority.UseBorders = False
        Me.txtNumberInWords.StylePriority.UseBorderWidth = False
        Me.txtNumberInWords.StylePriority.UseFont = False
        Me.txtNumberInWords.StylePriority.UseForeColor = False
        Me.txtNumberInWords.StylePriority.UseTextAlignment = False
        Me.txtNumberInWords.Text = "*** ONE THOUSAND PESOS ONLY ***"
        Me.txtNumberInWords.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptCheckPrint
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 268, 0)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents txtCheckDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckPayee As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNumberInWords As DevExpress.XtraReports.UI.XRLabel
End Class
