<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPurchaseOrder
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
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportHeader = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.imgReportFooter = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.txtOfficename = New DevExpress.XtraReports.UI.XRLabel()
        Me.pid = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpurchasetype = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPONumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVendorSuplier = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCheckDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtSignatory4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtValidDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblnote = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNoteTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtSignatory3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtNotePo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPurchaserName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPurchaserTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.imgReportHeader})
        Me.TopMargin.HeightF = 125.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 93.25!)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyNumber.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyNumber.StylePriority.UseFont = False
        Me.txtCompanyNumber.StylePriority.UseTextAlignment = False
        Me.txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 71.375!)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyAddress.SizeF = New System.Drawing.SizeF(719.0001!, 21.875!)
        Me.txtCompanyAddress.StylePriority.UseFont = False
        Me.txtCompanyAddress.StylePriority.UseTextAlignment = False
        Me.txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 49.5!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportHeader
        '
        Me.imgReportHeader.BorderWidth = 0.0!
        Me.imgReportHeader.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportHeader.KeepTogether = False
        Me.imgReportHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportHeader.Name = "imgReportHeader"
        Me.imgReportHeader.SizeF = New System.Drawing.SizeF(727.0833!, 122.9167!)
        Me.imgReportHeader.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.imgReportHeader.StylePriority.UseBorderWidth = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCopyright, Me.imgReportFooter})
        Me.BottomMargin.HeightF = 136.917!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportFooter
        '
        Me.imgReportFooter.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportFooter.Name = "imgReportFooter"
        Me.imgReportFooter.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.imgReportFooter.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 118.5!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(707.7499!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtCopyright.Visible = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrBarCode1, Me.txtOfficename, Me.pid, Me.txtpurchasetype, Me.txtPONumber, Me.txtVendorSuplier, Me.txtAmount, Me.txtCheckDate})
        Me.ReportHeader.HeightF = 83.58313!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 31.91662!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(75.0!, 15.62501!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PO NUMBER:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.BorderWidth = 0.0!
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(660.375!, 11.79171!)
        Me.XrBarCode1.Module = 4.0!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(66.62!, 66.62482!)
        Me.XrBarCode1.StylePriority.UseBorderWidth = False
        Me.XrBarCode1.StylePriority.UsePadding = False
        QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        Me.XrBarCode1.Text = "10001"
        '
        'txtOfficename
        '
        Me.txtOfficename.AutoWidth = True
        Me.txtOfficename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtOfficename.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 9.999974!)
        Me.txtOfficename.Name = "txtOfficename"
        Me.txtOfficename.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtOfficename.SizeF = New System.Drawing.SizeF(260.7501!, 21.91666!)
        Me.txtOfficename.StylePriority.UseFont = False
        Me.txtOfficename.StylePriority.UseTextAlignment = False
        Me.txtOfficename.Text = "CORPORATE OFFICE"
        Me.txtOfficename.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.pid.LocationFloat = New DevExpress.Utils.PointFloat(390.9167!, 33.58329!)
        Me.pid.Name = "pid"
        Me.pid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pid.SizeF = New System.Drawing.SizeF(262.5831!, 15.62501!)
        Me.pid.StylePriority.UseFont = False
        Me.pid.StylePriority.UseTextAlignment = False
        Me.pid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtpurchasetype
        '
        Me.txtpurchasetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchasetype.LocationFloat = New DevExpress.Utils.PointFloat(390.9167!, 10.0!)
        Me.txtpurchasetype.Name = "txtpurchasetype"
        Me.txtpurchasetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpurchasetype.SizeF = New System.Drawing.SizeF(262.5832!, 22.58333!)
        Me.txtpurchasetype.StylePriority.UseFont = False
        Me.txtpurchasetype.StylePriority.UseTextAlignment = False
        Me.txtpurchasetype.Text = "PURCHASE ORDER"
        Me.txtpurchasetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtPONumber
        '
        Me.txtPONumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtPONumber.LocationFloat = New DevExpress.Utils.PointFloat(75.99999!, 31.91662!)
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPONumber.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtPONumber.StylePriority.UseFont = False
        Me.txtPONumber.StylePriority.UseTextAlignment = False
        Me.txtPONumber.Text = "10001"
        Me.txtPONumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtVendorSuplier
        '
        Me.txtVendorSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.txtVendorSuplier.LocationFloat = New DevExpress.Utils.PointFloat(0.9999593!, 47.9166!)
        Me.txtVendorSuplier.Name = "txtVendorSuplier"
        Me.txtVendorSuplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVendorSuplier.SizeF = New System.Drawing.SizeF(319.0419!, 15.625!)
        Me.txtVendorSuplier.StylePriority.UseFont = False
        Me.txtVendorSuplier.StylePriority.UseTextAlignment = False
        Me.txtVendorSuplier.Text = "SAMPLE TEXT"
        Me.txtVendorSuplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtAmount.LocationFloat = New DevExpress.Utils.PointFloat(0.9999593!, 63.83318!)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAmount.SizeF = New System.Drawing.SizeF(319.0419!, 15.62501!)
        Me.txtAmount.StylePriority.UseFont = False
        Me.txtAmount.StylePriority.UseTextAlignment = False
        Me.txtAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtCheckDate
        '
        Me.txtCheckDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtCheckDate.LocationFloat = New DevExpress.Utils.PointFloat(391.7919!, 50.20831!)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCheckDate.SizeF = New System.Drawing.SizeF(261.7079!, 15.62502!)
        Me.txtCheckDate.StylePriority.UseFont = False
        Me.txtCheckDate.StylePriority.UseTextAlignment = False
        Me.txtCheckDate.Text = "December 31, 2013"
        Me.txtCheckDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtNote, Me.txtPosition6, Me.txtTitle6, Me.txtSignatory6, Me.txtLine6, Me.txtSignatory4, Me.txtPosition4, Me.txtLine4, Me.txtLine5, Me.txtPosition5, Me.txtSignatory5, Me.txtTitle5, Me.txtTitle4, Me.txtValidDate, Me.lblnote, Me.lblNoteTitle, Me.txtTitle1, Me.txtTitle2, Me.txtSignatory2, Me.txtPosition2, Me.txtLine2, Me.txtLine1, Me.txtPosition1, Me.txtSignatory1, Me.txtLine3, Me.txtSignatory3, Me.txtTitle3, Me.txtPosition3, Me.txtNotePo, Me.XrLabel2, Me.txtPurchaserName, Me.txtPurchaserTitle, Me.XrShape2, Me.XrShape1, Me.XrPictureBox6, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrPictureBox4, Me.XrPictureBox5, Me.XrPictureBox3})
        Me.ReportFooter.HeightF = 366.2916!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Italic)
        Me.txtNote.ForeColor = System.Drawing.Color.Red
        Me.txtNote.LocationFloat = New DevExpress.Utils.PointFloat(9.2501!, 64.87165!)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNote.SizeF = New System.Drawing.SizeF(707.7498!, 13.83334!)
        Me.txtNote.StylePriority.UseFont = False
        Me.txtNote.StylePriority.UseForeColor = False
        Me.txtNote.StylePriority.UseTextAlignment = False
        Me.txtNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtPosition6
        '
        Me.txtPosition6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition6.LocationFloat = New DevExpress.Utils.PointFloat(499.3747!, 274.1582!)
        Me.txtPosition6.Name = "txtPosition6"
        Me.txtPosition6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition6.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition6.StylePriority.UseFont = False
        Me.txtPosition6.StylePriority.UseTextAlignment = False
        Me.txtPosition6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition6.Visible = False
        '
        'txtTitle6
        '
        Me.txtTitle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle6.LocationFloat = New DevExpress.Utils.PointFloat(499.3747!, 197.825!)
        Me.txtTitle6.Name = "txtTitle6"
        Me.txtTitle6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle6.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle6.StylePriority.UseFont = False
        Me.txtTitle6.StylePriority.UseTextAlignment = False
        Me.txtTitle6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle6.Visible = False
        '
        'txtSignatory6
        '
        Me.txtSignatory6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory6.LocationFloat = New DevExpress.Utils.PointFloat(499.3747!, 257.6583!)
        Me.txtSignatory6.Name = "txtSignatory6"
        Me.txtSignatory6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory6.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory6.StylePriority.UseFont = False
        Me.txtSignatory6.StylePriority.UseTextAlignment = False
        Me.txtSignatory6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory6.Visible = False
        '
        'txtLine6
        '
        Me.txtLine6.ForeColor = System.Drawing.Color.Gray
        Me.txtLine6.LocationFloat = New DevExpress.Utils.PointFloat(499.3747!, 249.1582!)
        Me.txtLine6.Name = "txtLine6"
        Me.txtLine6.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine6.StylePriority.UseForeColor = False
        Me.txtLine6.Visible = False
        '
        'txtSignatory4
        '
        Me.txtSignatory4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory4.LocationFloat = New DevExpress.Utils.PointFloat(9.2501!, 257.8249!)
        Me.txtSignatory4.Name = "txtSignatory4"
        Me.txtSignatory4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory4.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory4.StylePriority.UseFont = False
        Me.txtSignatory4.StylePriority.UseTextAlignment = False
        Me.txtSignatory4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory4.Visible = False
        '
        'txtPosition4
        '
        Me.txtPosition4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition4.LocationFloat = New DevExpress.Utils.PointFloat(9.2501!, 274.325!)
        Me.txtPosition4.Name = "txtPosition4"
        Me.txtPosition4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition4.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition4.StylePriority.UseFont = False
        Me.txtPosition4.StylePriority.UseTextAlignment = False
        Me.txtPosition4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition4.Visible = False
        '
        'txtLine4
        '
        Me.txtLine4.ForeColor = System.Drawing.Color.Gray
        Me.txtLine4.LocationFloat = New DevExpress.Utils.PointFloat(9.2501!, 249.325!)
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine4.StylePriority.UseForeColor = False
        Me.txtLine4.Visible = False
        '
        'txtLine5
        '
        Me.txtLine5.ForeColor = System.Drawing.Color.Gray
        Me.txtLine5.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 249.325!)
        Me.txtLine5.Name = "txtLine5"
        Me.txtLine5.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine5.StylePriority.UseForeColor = False
        Me.txtLine5.Visible = False
        '
        'txtPosition5
        '
        Me.txtPosition5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition5.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 274.325!)
        Me.txtPosition5.Name = "txtPosition5"
        Me.txtPosition5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition5.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition5.StylePriority.UseFont = False
        Me.txtPosition5.StylePriority.UseTextAlignment = False
        Me.txtPosition5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition5.Visible = False
        '
        'txtSignatory5
        '
        Me.txtSignatory5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory5.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 257.8249!)
        Me.txtSignatory5.Name = "txtSignatory5"
        Me.txtSignatory5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory5.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory5.StylePriority.UseFont = False
        Me.txtSignatory5.StylePriority.UseTextAlignment = False
        Me.txtSignatory5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory5.Visible = False
        '
        'txtTitle5
        '
        Me.txtTitle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle5.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 197.825!)
        Me.txtTitle5.Name = "txtTitle5"
        Me.txtTitle5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle5.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle5.StylePriority.UseFont = False
        Me.txtTitle5.StylePriority.UseTextAlignment = False
        Me.txtTitle5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle5.Visible = False
        '
        'txtTitle4
        '
        Me.txtTitle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle4.LocationFloat = New DevExpress.Utils.PointFloat(9.2501!, 197.825!)
        Me.txtTitle4.Name = "txtTitle4"
        Me.txtTitle4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle4.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle4.StylePriority.UseFont = False
        Me.txtTitle4.StylePriority.UseTextAlignment = False
        Me.txtTitle4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle4.Visible = False
        '
        'txtValidDate
        '
        Me.txtValidDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtValidDate.ForeColor = System.Drawing.Color.Red
        Me.txtValidDate.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 349.2083!)
        Me.txtValidDate.Name = "txtValidDate"
        Me.txtValidDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtValidDate.SizeF = New System.Drawing.SizeF(707.7498!, 13.83334!)
        Me.txtValidDate.StylePriority.UseFont = False
        Me.txtValidDate.StylePriority.UseForeColor = False
        Me.txtValidDate.StylePriority.UseTextAlignment = False
        Me.txtValidDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblnote
        '
        Me.lblnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblnote.ForeColor = System.Drawing.Color.Red
        Me.lblnote.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 320.5416!)
        Me.lblnote.Name = "lblnote"
        Me.lblnote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblnote.SizeF = New System.Drawing.SizeF(705.7916!, 26.0!)
        Me.lblnote.StylePriority.UseFont = False
        Me.lblnote.StylePriority.UseForeColor = False
        Me.lblnote.StylePriority.UseTextAlignment = False
        Me.lblnote.Text = "This purchase order is only valid for thirty (30) days from the date of PO date. " & _
    "If the validity period has expired, then the approval for this PO will CANCELLED" & _
    " and REVOKED."
        Me.lblnote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblNoteTitle
        '
        Me.lblNoteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteTitle.ForeColor = System.Drawing.Color.Red
        Me.lblNoteTitle.LocationFloat = New DevExpress.Utils.PointFloat(6.250111!, 304.9166!)
        Me.lblNoteTitle.Name = "lblNoteTitle"
        Me.lblNoteTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNoteTitle.SizeF = New System.Drawing.SizeF(122.6668!, 15.625!)
        Me.lblNoteTitle.StylePriority.UseFont = False
        Me.lblNoteTitle.StylePriority.UseForeColor = False
        Me.lblNoteTitle.StylePriority.UseTextAlignment = False
        Me.lblNoteTitle.Text = "IMPORTANT NOTE:"
        Me.lblNoteTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 91.70499!)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle1.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle1.StylePriority.UseFont = False
        Me.txtTitle1.StylePriority.UseTextAlignment = False
        Me.txtTitle1.Text = "Prepared by"
        Me.txtTitle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitle2
        '
        Me.txtTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 91.70499!)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle2.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle2.StylePriority.UseFont = False
        Me.txtTitle2.StylePriority.UseTextAlignment = False
        Me.txtTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle2.Visible = False
        '
        'txtSignatory2
        '
        Me.txtSignatory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 151.7049!)
        Me.txtSignatory2.Name = "txtSignatory2"
        Me.txtSignatory2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory2.StylePriority.UseFont = False
        Me.txtSignatory2.StylePriority.UseTextAlignment = False
        Me.txtSignatory2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory2.Visible = False
        '
        'txtPosition2
        '
        Me.txtPosition2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 168.205!)
        Me.txtPosition2.Name = "txtPosition2"
        Me.txtPosition2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition2.StylePriority.UseFont = False
        Me.txtPosition2.StylePriority.UseTextAlignment = False
        Me.txtPosition2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition2.Visible = False
        '
        'txtLine2
        '
        Me.txtLine2.ForeColor = System.Drawing.Color.Gray
        Me.txtLine2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 143.205!)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine2.StylePriority.UseForeColor = False
        Me.txtLine2.Visible = False
        '
        'txtLine1
        '
        Me.txtLine1.ForeColor = System.Drawing.Color.Gray
        Me.txtLine1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 143.205!)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine1.StylePriority.UseForeColor = False
        '
        'txtPosition1
        '
        Me.txtPosition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 168.205!)
        Me.txtPosition1.Name = "txtPosition1"
        Me.txtPosition1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition1.StylePriority.UseFont = False
        Me.txtPosition1.StylePriority.UseTextAlignment = False
        Me.txtPosition1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtSignatory1
        '
        Me.txtSignatory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 151.7049!)
        Me.txtSignatory1.Name = "txtSignatory1"
        Me.txtSignatory1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory1.StylePriority.UseFont = False
        Me.txtSignatory1.StylePriority.UseTextAlignment = False
        Me.txtSignatory1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtLine3
        '
        Me.txtLine3.ForeColor = System.Drawing.Color.Gray
        Me.txtLine3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 143.0382!)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine3.StylePriority.UseForeColor = False
        Me.txtLine3.Visible = False
        '
        'txtSignatory3
        '
        Me.txtSignatory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 151.5383!)
        Me.txtSignatory3.Name = "txtSignatory3"
        Me.txtSignatory3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory3.StylePriority.UseFont = False
        Me.txtSignatory3.StylePriority.UseTextAlignment = False
        Me.txtSignatory3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory3.Visible = False
        '
        'txtTitle3
        '
        Me.txtTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 91.70499!)
        Me.txtTitle3.Name = "txtTitle3"
        Me.txtTitle3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle3.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle3.StylePriority.UseFont = False
        Me.txtTitle3.StylePriority.UseTextAlignment = False
        Me.txtTitle3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle3.Visible = False
        '
        'txtPosition3
        '
        Me.txtPosition3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 169.0382!)
        Me.txtPosition3.Name = "txtPosition3"
        Me.txtPosition3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition3.StylePriority.UseFont = False
        Me.txtPosition3.StylePriority.UseTextAlignment = False
        Me.txtPosition3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition3.Visible = False
        '
        'txtNotePo
        '
        Me.txtNotePo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotePo.LocationFloat = New DevExpress.Utils.PointFloat(14.25009!, 21.62498!)
        Me.txtNotePo.Name = "txtNotePo"
        Me.txtNotePo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNotePo.SizeF = New System.Drawing.SizeF(437.79!, 32.08!)
        Me.txtNotePo.StylePriority.UseFont = False
        Me.txtNotePo.StylePriority.UseTextAlignment = False
        Me.txtNotePo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 3.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(49.75!, 15.62501!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "NOTE: "
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtPurchaserName
        '
        Me.txtPurchaserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtPurchaserName.LocationFloat = New DevExpress.Utils.PointFloat(467.4168!, 40.79167!)
        Me.txtPurchaserName.Name = "txtPurchaserName"
        Me.txtPurchaserName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPurchaserName.SizeF = New System.Drawing.SizeF(255.7083!, 15.625!)
        Me.txtPurchaserName.StylePriority.UseFont = False
        Me.txtPurchaserName.StylePriority.UseTextAlignment = False
        Me.txtPurchaserName.Text = "Signature over Printed Name"
        Me.txtPurchaserName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtPurchaserTitle
        '
        Me.txtPurchaserTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPurchaserTitle.LocationFloat = New DevExpress.Utils.PointFloat(466.4168!, 2.79165!)
        Me.txtPurchaserTitle.Name = "txtPurchaserTitle"
        Me.txtPurchaserTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPurchaserTitle.SizeF = New System.Drawing.SizeF(87.91669!, 15.625!)
        Me.txtPurchaserTitle.StylePriority.UseFont = False
        Me.txtPurchaserTitle.StylePriority.UseTextAlignment = False
        Me.txtPurchaserTitle.Text = "Received By:"
        Me.txtPurchaserTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrShape2
        '
        Me.XrShape2.Angle = 180
        Me.XrShape2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(464.0419!, 0.0!)
        Me.XrShape2.Name = "XrShape2"
        Me.XrShape2.Shape = ShapeRectangle1
        Me.XrShape2.SizeF = New System.Drawing.SizeF(264.9999!, 59.70498!)
        Me.XrShape2.StylePriority.UseBorders = False
        '
        'XrShape1
        '
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(466.4168!, 59.70498!)
        Me.XrShape1.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(500.3943!, 192.825!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(254.8751!, 86.70499!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(225.42!, 81.45332!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 86.70499!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(225.42!, 81.45331!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(6.939125!, 192.825!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(254.8751!, 192.825!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(500.1247!, 86.70499!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(225.42!, 82.33321!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'rptPurchaseOrder
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 125, 137)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtPONumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVendorSuplier As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportHeader As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtpurchasetype As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents txtPurchaserName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPurchaserTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNotePo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtSignatory3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents txtAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCheckDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtValidDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblnote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNoteTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtSignatory4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgReportFooter As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtOfficename As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents txtNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
