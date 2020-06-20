<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDepedDesigner
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
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.barCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtItemName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAssetNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgEdu = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.txtModel = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtItemDescription = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSerial = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'barCode1
        '
        Me.barCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.barCode1.AutoModule = True
        Me.barCode1.LocationFloat = New DevExpress.Utils.PointFloat(6.435169!, 85.25465!)
        Me.barCode1.Module = 3.5!
        Me.barCode1.Name = "barCode1"
        Me.barCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.barCode1.ShowText = False
        Me.barCode1.SizeF = New System.Drawing.SizeF(104.4167!, 97.47426!)
        Me.barCode1.StylePriority.UsePadding = False
        QrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
        QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.barCode1.Symbology = QrCodeGenerator1
        Me.barCode1.Text = "KVA06160099|1|0"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.Detail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Detail.HeightF = 214.0!
        Me.Detail.Name = "Detail"
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtItemName, Me.barCode1, Me.XrLabel2, Me.txtAssetNumber, Me.XrLabel4, Me.XrLabel5, Me.XrLabel1, Me.imgEdu, Me.XrShape1, Me.txtModel, Me.txtItemDescription, Me.txtSerial, Me.XrPictureBox1})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'txtItemName
        '
        Me.txtItemName.CanGrow = False
        Me.txtItemName.Font = New System.Drawing.Font("Myriad Pro", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtItemName.LocationFloat = New DevExpress.Utils.PointFloat(110.8519!, 85.25465!)
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.txtItemName.SizeF = New System.Drawing.SizeF(223.1481!, 17.91204!)
        Me.txtItemName.StylePriority.UseFont = False
        Me.txtItemName.StylePriority.UsePadding = False
        Me.txtItemName.StylePriority.UseTextAlignment = False
        Me.txtItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New System.Drawing.Font("Myriad Pro", 10.0!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(78.97396!, 9.375015!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(246.026!, 19.66985!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Property of"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtAssetNumber
        '
        Me.txtAssetNumber.CanShrink = True
        Me.txtAssetNumber.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.txtAssetNumber.LocationFloat = New DevExpress.Utils.PointFloat(6.435169!, 182.7289!)
        Me.txtAssetNumber.Multiline = True
        Me.txtAssetNumber.Name = "txtAssetNumber"
        Me.txtAssetNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.txtAssetNumber.SizeF = New System.Drawing.SizeF(104.4167!, 23.93303!)
        Me.txtAssetNumber.StylePriority.UseFont = False
        Me.txtAssetNumber.StylePriority.UsePadding = False
        Me.txtAssetNumber.StylePriority.UseTextAlignment = False
        Me.txtAssetNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New System.Drawing.Font("Myriad Pro", 13.25!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.White
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(78.97396!, 25.04486!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(246.026!, 25.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "DEPARTMENT OF EDUCATION "
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("Myriad Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.White
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(78.97396!, 45.50375!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(246.026!, 15.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Region IX, Zamboanga Peninsula "
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New System.Drawing.Font("Myriad Pro", 7.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(78.97396!, 59.58479!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(246.026!, 15.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Division of Zamboanga del Norte"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgEdu
        '
        Me.imgEdu.BorderWidth = 0.0!
        Me.imgEdu.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgEdu.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 6.375!)
        Me.imgEdu.Name = "imgEdu"
        Me.imgEdu.SizeF = New System.Drawing.SizeF(64.97397!, 65.625!)
        Me.imgEdu.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.imgEdu.StylePriority.UseBorderWidth = False
        '
        'XrShape1
        '
        Me.XrShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.XrShape1.BorderColor = System.Drawing.Color.Transparent
        Me.XrShape1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrShape1.BorderWidth = 0.0!
        Me.XrShape1.LineWidth = 0
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0.375!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.SizeF = New System.Drawing.SizeF(339.0!, 77.87964!)
        Me.XrShape1.StylePriority.UseBackColor = False
        Me.XrShape1.StylePriority.UseBorderColor = False
        Me.XrShape1.StylePriority.UseBorders = False
        Me.XrShape1.StylePriority.UseBorderWidth = False
        '
        'txtModel
        '
        Me.txtModel.CanGrow = False
        Me.txtModel.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.txtModel.LocationFloat = New DevExpress.Utils.PointFloat(110.8519!, 102.7385!)
        Me.txtModel.Multiline = True
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.txtModel.SizeF = New System.Drawing.SizeF(223.1481!, 12.53932!)
        Me.txtModel.StylePriority.UseFont = False
        Me.txtModel.StylePriority.UsePadding = False
        Me.txtModel.StylePriority.UseTextAlignment = False
        Me.txtModel.Text = "272hhdhhdgs"
        Me.txtModel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtItemDescription
        '
        Me.txtItemDescription.CanGrow = False
        Me.txtItemDescription.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.txtItemDescription.LocationFloat = New DevExpress.Utils.PointFloat(110.8519!, 127.8171!)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.txtItemDescription.SizeF = New System.Drawing.SizeF(223.1481!, 78.84487!)
        Me.txtItemDescription.StylePriority.UseFont = False
        Me.txtItemDescription.StylePriority.UsePadding = False
        Me.txtItemDescription.StylePriority.UseTextAlignment = False
        Me.txtItemDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtSerial
        '
        Me.txtSerial.CanGrow = False
        Me.txtSerial.Font = New System.Drawing.Font("Myriad Pro", 8.0!)
        Me.txtSerial.LocationFloat = New DevExpress.Utils.PointFloat(110.8519!, 115.2778!)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.txtSerial.SizeF = New System.Drawing.SizeF(223.1481!, 12.53931!)
        Me.txtSerial.StylePriority.UseFont = False
        Me.txtSerial.StylePriority.UsePadding = False
        Me.txtSerial.StylePriority.UseTextAlignment = False
        Me.txtSerial.Text = "272hhdhhdgs"
        Me.txtSerial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 12.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'rptDepedDesigner
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
        Me.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DisplayName = "Inventory Sticker"
        Me.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.Margins = New System.Drawing.Printing.Margins(12, 12, 12, 12)
        Me.PageHeight = 238
        Me.PageWidth = 365
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "62mm x 29mm"
        Me.PrinterName = "Brother QL-720NW"
        Me.ShowPrintMarginsWarning = False
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents barCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents txtItemName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtItemDescription As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgEdu As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtAssetNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtModel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSerial As DevExpress.XtraReports.UI.XRLabel
End Class
