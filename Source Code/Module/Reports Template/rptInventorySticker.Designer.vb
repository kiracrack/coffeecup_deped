<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptInventorySticker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptInventorySticker))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSerialNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtModel = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBrand = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtItemName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAssetCode = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAccountablePerson = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtoffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDateIssue = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDatePurchase = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyName, Me.txtDetails, Me.txtSerialNumber, Me.txtModel, Me.txtBrand, Me.txtCategory, Me.txtItemName, Me.txtAssetCode, Me.txtAccountablePerson, Me.txtoffice, Me.txtDateIssue, Me.txtDatePurchase, Me.txtIssueNumber, Me.XrPictureBox1})
        Me.TopMargin.HeightF = 365.625!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial Narrow", 10.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 21.875!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(305.5835!, 18.75!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseForeColor = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txtCompanyName.Visible = False
        '
        'txtDetails
        '
        Me.txtDetails.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDetails.LocationFloat = New DevExpress.Utils.PointFloat(17.83334!, 307.4167!)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDetails.SizeF = New System.Drawing.SizeF(211.8335!, 31.24994!)
        Me.txtDetails.StylePriority.UseFont = False
        Me.txtDetails.StylePriority.UseForeColor = False
        Me.txtDetails.StylePriority.UseTextAlignment = False
        Me.txtDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtSerialNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSerialNumber.LocationFloat = New DevExpress.Utils.PointFloat(67.87516!, 272.0!)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSerialNumber.SizeF = New System.Drawing.SizeF(161.7917!, 12.5!)
        Me.txtSerialNumber.StylePriority.UseFont = False
        Me.txtSerialNumber.StylePriority.UseForeColor = False
        Me.txtSerialNumber.StylePriority.UseTextAlignment = False
        Me.txtSerialNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtModel.LocationFloat = New DevExpress.Utils.PointFloat(53.0!, 252.5!)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtModel.SizeF = New System.Drawing.SizeF(176.6669!, 12.5!)
        Me.txtModel.StylePriority.UseFont = False
        Me.txtModel.StylePriority.UseForeColor = False
        Me.txtModel.StylePriority.UseTextAlignment = False
        Me.txtModel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtBrand
        '
        Me.txtBrand.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBrand.LocationFloat = New DevExpress.Utils.PointFloat(51.0!, 232.4583!)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBrand.SizeF = New System.Drawing.SizeF(178.6668!, 12.5!)
        Me.txtBrand.StylePriority.UseFont = False
        Me.txtBrand.StylePriority.UseForeColor = False
        Me.txtBrand.StylePriority.UseTextAlignment = False
        Me.txtBrand.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCategory.LocationFloat = New DevExpress.Utils.PointFloat(65.87517!, 211.9583!)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCategory.SizeF = New System.Drawing.SizeF(163.7917!, 12.5!)
        Me.txtCategory.StylePriority.UseFont = False
        Me.txtCategory.StylePriority.UseForeColor = False
        Me.txtCategory.StylePriority.UseTextAlignment = False
        Me.txtCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtItemName.LocationFloat = New DevExpress.Utils.PointFloat(76.04165!, 192.2083!)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtItemName.SizeF = New System.Drawing.SizeF(153.6252!, 12.5!)
        Me.txtItemName.StylePriority.UseFont = False
        Me.txtItemName.StylePriority.UseForeColor = False
        Me.txtItemName.StylePriority.UseTextAlignment = False
        Me.txtItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtAssetCode
        '
        Me.txtAssetCode.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtAssetCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAssetCode.LocationFloat = New DevExpress.Utils.PointFloat(76.04162!, 172.7083!)
        Me.txtAssetCode.Name = "txtAssetCode"
        Me.txtAssetCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAssetCode.SizeF = New System.Drawing.SizeF(153.6252!, 12.5!)
        Me.txtAssetCode.StylePriority.UseFont = False
        Me.txtAssetCode.StylePriority.UseForeColor = False
        Me.txtAssetCode.StylePriority.UseTextAlignment = False
        Me.txtAssetCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtAccountablePerson
        '
        Me.txtAccountablePerson.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtAccountablePerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAccountablePerson.LocationFloat = New DevExpress.Utils.PointFloat(17.83334!, 151.2083!)
        Me.txtAccountablePerson.Name = "txtAccountablePerson"
        Me.txtAccountablePerson.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAccountablePerson.SizeF = New System.Drawing.SizeF(211.8335!, 12.5!)
        Me.txtAccountablePerson.StylePriority.UseFont = False
        Me.txtAccountablePerson.StylePriority.UseForeColor = False
        Me.txtAccountablePerson.StylePriority.UseTextAlignment = False
        Me.txtAccountablePerson.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Tahoma", 7.75!)
        Me.txtoffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoffice.LocationFloat = New DevExpress.Utils.PointFloat(53.0!, 112.5834!)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtoffice.SizeF = New System.Drawing.SizeF(176.6668!, 12.5!)
        Me.txtoffice.StylePriority.UseFont = False
        Me.txtoffice.StylePriority.UseForeColor = False
        Me.txtoffice.StylePriority.UseTextAlignment = False
        Me.txtoffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDateIssue
        '
        Me.txtDateIssue.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.txtDateIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDateIssue.LocationFloat = New DevExpress.Utils.PointFloat(75.04167!, 92.75002!)
        Me.txtDateIssue.Name = "txtDateIssue"
        Me.txtDateIssue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDateIssue.SizeF = New System.Drawing.SizeF(154.6252!, 12.5!)
        Me.txtDateIssue.StylePriority.UseFont = False
        Me.txtDateIssue.StylePriority.UseForeColor = False
        Me.txtDateIssue.StylePriority.UseTextAlignment = False
        Me.txtDateIssue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDatePurchase
        '
        Me.txtDatePurchase.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.txtDatePurchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDatePurchase.LocationFloat = New DevExpress.Utils.PointFloat(98.95834!, 72.5!)
        Me.txtDatePurchase.Name = "txtDatePurchase"
        Me.txtDatePurchase.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDatePurchase.SizeF = New System.Drawing.SizeF(130.7086!, 12.5!)
        Me.txtDatePurchase.StylePriority.UseFont = False
        Me.txtDatePurchase.StylePriority.UseForeColor = False
        Me.txtDatePurchase.StylePriority.UseTextAlignment = False
        Me.txtDatePurchase.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtIssueNumber
        '
        Me.txtIssueNumber.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.txtIssueNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIssueNumber.LocationFloat = New DevExpress.Utils.PointFloat(65.87518!, 54.0!)
        Me.txtIssueNumber.Name = "txtIssueNumber"
        Me.txtIssueNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtIssueNumber.SizeF = New System.Drawing.SizeF(163.7917!, 12.5!)
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
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(328.125!, 365.0!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptInventorySticker
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 366, 0)
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents txtIssueNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSerialNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtModel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBrand As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtItemName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAssetCode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAccountablePerson As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtoffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDateIssue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDatePurchase As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
End Class
