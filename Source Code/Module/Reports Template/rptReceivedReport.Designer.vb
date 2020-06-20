<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceivedReport
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportHeader = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportFooter = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.txtSupplier = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpurchasetype = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRRNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtValidDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtSignatory3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPONumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRequisitionNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDirectIssue = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtIssueReference = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDateIssue = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRequestingOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
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
        'imgReportFooter
        '
        Me.imgReportFooter.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportFooter.Name = "imgReportFooter"
        Me.imgReportFooter.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.imgReportFooter.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtRequestingOffice, Me.XrLabel13, Me.txtDateIssue, Me.XrLabel11, Me.XrLabel6, Me.txtDirectIssue, Me.XrLabel8, Me.txtIssueReference, Me.txtRequisitionNo, Me.XrLabel5, Me.txtPONumber, Me.XrLabel3, Me.XrLabel1, Me.XrBarCode1, Me.txtSupplier, Me.txtpurchasetype, Me.txtRRNumber, Me.txtNote})
        Me.ReportHeader.HeightF = 103.3748!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 31.91662!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "RR NUMBER:"
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
        'txtSupplier
        '
        Me.txtSupplier.AutoWidth = True
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSupplier.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 9.999974!)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSupplier.SizeF = New System.Drawing.SizeF(364.8752!, 21.91666!)
        Me.txtSupplier.StylePriority.UseFont = False
        Me.txtSupplier.StylePriority.UseTextAlignment = False
        Me.txtSupplier.Text = "SUPPLIER NAME"
        Me.txtSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtpurchasetype
        '
        Me.txtpurchasetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchasetype.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 7.999992!)
        Me.txtpurchasetype.Name = "txtpurchasetype"
        Me.txtpurchasetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpurchasetype.SizeF = New System.Drawing.SizeF(275.7502!, 22.58333!)
        Me.txtpurchasetype.StylePriority.UseFont = False
        Me.txtpurchasetype.StylePriority.UseTextAlignment = False
        Me.txtpurchasetype.Text = "RECEIVING REPORT"
        Me.txtpurchasetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtRRNumber
        '
        Me.txtRRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRRNumber.LocationFloat = New DevExpress.Utils.PointFloat(96.99998!, 31.91662!)
        Me.txtRRNumber.Name = "txtRRNumber"
        Me.txtRRNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRRNumber.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtRRNumber.StylePriority.UseFont = False
        Me.txtRRNumber.StylePriority.UseTextAlignment = False
        Me.txtRRNumber.Text = " "
        Me.txtRRNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 81.79163!)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNote.SizeF = New System.Drawing.SizeF(364.8752!, 15.625!)
        Me.txtNote.StylePriority.UseFont = False
        Me.txtNote.StylePriority.UseTextAlignment = False
        Me.txtNote.Text = "SAMPLE TEXT"
        Me.txtNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtValidDate, Me.txtTitle1, Me.txtTitle2, Me.txtSignatory2, Me.txtLine2, Me.txtLine1, Me.txtPosition1, Me.txtSignatory1, Me.txtLine3, Me.txtSignatory3, Me.txtTitle3})
        Me.ReportFooter.HeightF = 366.2916!
        Me.ReportFooter.Name = "ReportFooter"
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
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 15.0!)
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
        Me.txtTitle2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 15.0!)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle2.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle2.StylePriority.UseFont = False
        Me.txtTitle2.StylePriority.UseTextAlignment = False
        Me.txtTitle2.Text = "Verified By:"
        Me.txtTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtSignatory2
        '
        Me.txtSignatory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 74.99991!)
        Me.txtSignatory2.Name = "txtSignatory2"
        Me.txtSignatory2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory2.StylePriority.UseFont = False
        Me.txtSignatory2.StylePriority.UseTextAlignment = False
        Me.txtSignatory2.Text = "Signature over Printed Name"
        Me.txtSignatory2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtLine2
        '
        Me.txtLine2.ForeColor = System.Drawing.Color.Gray
        Me.txtLine2.LocationFloat = New DevExpress.Utils.PointFloat(254.1251!, 66.50002!)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine2.StylePriority.UseForeColor = False
        '
        'txtLine1
        '
        Me.txtLine1.ForeColor = System.Drawing.Color.Gray
        Me.txtLine1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 66.50002!)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine1.StylePriority.UseForeColor = False
        '
        'txtPosition1
        '
        Me.txtPosition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 91.50002!)
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
        Me.txtSignatory1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 74.99991!)
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
        Me.txtLine3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 66.33321!)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine3.StylePriority.UseForeColor = False
        '
        'txtSignatory3
        '
        Me.txtSignatory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 74.83331!)
        Me.txtSignatory3.Name = "txtSignatory3"
        Me.txtSignatory3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory3.StylePriority.UseFont = False
        Me.txtSignatory3.StylePriority.UseTextAlignment = False
        Me.txtSignatory3.Text = "Signature over Printed Name"
        Me.txtSignatory3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtTitle3
        '
        Me.txtTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle3.LocationFloat = New DevExpress.Utils.PointFloat(499.3748!, 15.0!)
        Me.txtTitle3.Name = "txtTitle3"
        Me.txtTitle3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle3.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle3.StylePriority.UseFont = False
        Me.txtTitle3.StylePriority.UseTextAlignment = False
        Me.txtTitle3.Text = "Approved By:"
        Me.txtTitle3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtPONumber
        '
        Me.txtPONumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtPONumber.LocationFloat = New DevExpress.Utils.PointFloat(96.99998!, 47.54162!)
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPONumber.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtPONumber.StylePriority.UseFont = False
        Me.txtPONumber.StylePriority.UseTextAlignment = False
        Me.txtPONumber.Text = " "
        Me.txtPONumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 47.54162!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "PO NUMBER:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtRequisitionNo
        '
        Me.txtRequisitionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRequisitionNo.LocationFloat = New DevExpress.Utils.PointFloat(96.99998!, 63.16662!)
        Me.txtRequisitionNo.Name = "txtRequisitionNo"
        Me.txtRequisitionNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRequisitionNo.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtRequisitionNo.StylePriority.UseFont = False
        Me.txtRequisitionNo.StylePriority.UseTextAlignment = False
        Me.txtRequisitionNo.Text = " "
        Me.txtRequisitionNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 63.16662!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "REQUISITION NO:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 47.16654!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Direct Issue To:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDirectIssue
        '
        Me.txtDirectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtDirectIssue.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 47.16654!)
        Me.txtDirectIssue.Name = "txtDirectIssue"
        Me.txtDirectIssue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDirectIssue.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtDirectIssue.StylePriority.UseFont = False
        Me.txtDirectIssue.StylePriority.UseTextAlignment = False
        Me.txtDirectIssue.Text = " "
        Me.txtDirectIssue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 62.79154!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Issue Reference"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtIssueReference
        '
        Me.txtIssueReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtIssueReference.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 62.79154!)
        Me.txtIssueReference.Name = "txtIssueReference"
        Me.txtIssueReference.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtIssueReference.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtIssueReference.StylePriority.UseFont = False
        Me.txtIssueReference.StylePriority.UseTextAlignment = False
        Me.txtIssueReference.Text = " "
        Me.txtIssueReference.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDateIssue
        '
        Me.txtDateIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtDateIssue.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 78.41653!)
        Me.txtDateIssue.Name = "txtDateIssue"
        Me.txtDateIssue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDateIssue.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtDateIssue.StylePriority.UseFont = False
        Me.txtDateIssue.StylePriority.UseTextAlignment = False
        Me.txtDateIssue.Text = " "
        Me.txtDateIssue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 78.41653!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Date Issue:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtRequestingOffice
        '
        Me.txtRequestingOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRequestingOffice.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 31.54154!)
        Me.txtRequestingOffice.Name = "txtRequestingOffice"
        Me.txtRequestingOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRequestingOffice.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtRequestingOffice.StylePriority.UseFont = False
        Me.txtRequestingOffice.StylePriority.UseTextAlignment = False
        Me.txtRequestingOffice.Text = " "
        Me.txtRequestingOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(377.7498!, 31.54154!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Requesting Office:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptReceivedReport
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
    Friend WithEvents txtRRNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportHeader As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtpurchasetype As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtSignatory3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtValidDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportFooter As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtSupplier As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRequisitionNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPONumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDirectIssue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtIssueReference As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDateIssue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRequestingOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
End Class
