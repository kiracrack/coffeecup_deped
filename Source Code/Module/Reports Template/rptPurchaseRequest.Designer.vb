<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPurchaseRequest
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
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.status = New DevExpress.XtraReports.UI.XRLabel()
        Me.officeid = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpurchasetype = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtoffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.pid = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdesignation = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDateRequest = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRequestby = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtPosition3 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.txtTitle6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPosition6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportHeader = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.imgReportFooter = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
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
        Me.TopMargin.HeightF = 124.625!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 95.25!)
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
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 73.375!)
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
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 51.5!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCopyright, Me.imgReportFooter})
        Me.BottomMargin.HeightF = 138.5!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(22.25015!, 118.875!)
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.status, Me.officeid, Me.txtpurchasetype, Me.lblOffice, Me.txtoffice, Me.pid, Me.XrLabel8, Me.XrLabel2, Me.txtdetails, Me.txtdesignation, Me.txtDateRequest, Me.txtRequestby, Me.XrLabel9})
        Me.ReportHeader.HeightF = 129.8333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.status.LocationFloat = New DevExpress.Utils.PointFloat(77.45818!, 72.49998!)
        Me.status.Name = "status"
        Me.status.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.status.SizeF = New System.Drawing.SizeF(34.74985!, 15.62501!)
        Me.status.StylePriority.UseFont = False
        Me.status.StylePriority.UseTextAlignment = False
        Me.status.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.status.Visible = False
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.officeid.LocationFloat = New DevExpress.Utils.PointFloat(42.70833!, 73.37498!)
        Me.officeid.Name = "officeid"
        Me.officeid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.officeid.SizeF = New System.Drawing.SizeF(34.74985!, 15.62501!)
        Me.officeid.StylePriority.UseFont = False
        Me.officeid.StylePriority.UseTextAlignment = False
        Me.officeid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.officeid.Visible = False
        '
        'txtpurchasetype
        '
        Me.txtpurchasetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtpurchasetype.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 15.0!)
        Me.txtpurchasetype.Name = "txtpurchasetype"
        Me.txtpurchasetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpurchasetype.SizeF = New System.Drawing.SizeF(425.7084!, 22.58333!)
        Me.txtpurchasetype.StylePriority.UseFont = False
        Me.txtpurchasetype.StylePriority.UseTextAlignment = False
        Me.txtpurchasetype.Text = "PURCHASE REQUEST"
        Me.txtpurchasetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblOffice
        '
        Me.lblOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.lblOffice.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 90.58327!)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblOffice.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.lblOffice.StylePriority.UseFont = False
        Me.lblOffice.StylePriority.UseTextAlignment = False
        Me.lblOffice.Text = "OFFICE:"
        Me.lblOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtoffice.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 90.58326!)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtoffice.SizeF = New System.Drawing.SizeF(352.4809!, 15.62501!)
        Me.txtoffice.StylePriority.UseFont = False
        Me.txtoffice.StylePriority.UseTextAlignment = False
        Me.txtoffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.pid.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 40.87499!)
        Me.pid.Name = "pid"
        Me.pid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pid.SizeF = New System.Drawing.SizeF(352.4809!, 15.625!)
        Me.pid.StylePriority.UseFont = False
        Me.pid.StylePriority.UseTextAlignment = False
        Me.pid.Text = "SAMPLE TEXT"
        Me.pid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 40.875!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "REQUEST ID:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 106.2083!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "DETAILS:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtdetails
        '
        Me.txtdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtdetails.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 106.2083!)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdetails.SizeF = New System.Drawing.SizeF(352.4809!, 15.625!)
        Me.txtdetails.StylePriority.UseFont = False
        Me.txtdetails.StylePriority.UseTextAlignment = False
        Me.txtdetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtdesignation
        '
        Me.txtdesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtdesignation.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 73.375!)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdesignation.SizeF = New System.Drawing.SizeF(352.4809!, 15.625!)
        Me.txtdesignation.StylePriority.UseFont = False
        Me.txtdesignation.StylePriority.UseTextAlignment = False
        Me.txtdesignation.Text = "Sample Text"
        Me.txtdesignation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtDateRequest
        '
        Me.txtDateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtDateRequest.LocationFloat = New DevExpress.Utils.PointFloat(475.4585!, 14.99999!)
        Me.txtDateRequest.Name = "txtDateRequest"
        Me.txtDateRequest.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDateRequest.SizeF = New System.Drawing.SizeF(254.5415!, 22.58334!)
        Me.txtDateRequest.StylePriority.UseFont = False
        Me.txtDateRequest.StylePriority.UseTextAlignment = False
        Me.txtDateRequest.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtRequestby
        '
        Me.txtRequestby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestby.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 56.87497!)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRequestby.SizeF = New System.Drawing.SizeF(352.4809!, 15.625!)
        Me.txtRequestby.StylePriority.UseFont = False
        Me.txtRequestby.StylePriority.UseTextAlignment = False
        Me.txtRequestby.Text = "SAMPLE TEXT"
        Me.txtRequestby.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 56.87498!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "REQUEST BY:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtPosition3, Me.txtSignatory6, Me.txtLine6, Me.txtSignatory4, Me.txtPosition4, Me.txtLine4, Me.txtLine5, Me.txtPosition5, Me.txtSignatory5, Me.txtTitle5, Me.txtTitle4, Me.txtTitle1, Me.txtTitle2, Me.txtSignatory2, Me.txtPosition2, Me.txtLine2, Me.txtLine1, Me.txtPosition1, Me.txtSignatory1, Me.txtLine3, Me.txtSignatory3, Me.txtTitle3, Me.txtTitle6, Me.txtPosition6, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrPictureBox3, Me.XrPictureBox6, Me.XrPictureBox5, Me.XrPictureBox4, Me.txtNote})
        Me.ReportFooter.HeightF = 247.8492!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtPosition3
        '
        Me.txtPosition3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition3.LocationFloat = New DevExpress.Utils.PointFloat(497.3524!, 107.4424!)
        Me.txtPosition3.Name = "txtPosition3"
        Me.txtPosition3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition3.StylePriority.UseFont = False
        Me.txtPosition3.StylePriority.UseTextAlignment = False
        Me.txtPosition3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition3.Visible = False
        '
        'txtSignatory6
        '
        Me.txtSignatory6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory6.LocationFloat = New DevExpress.Utils.PointFloat(497.3523!, 202.0625!)
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
        Me.txtLine6.LocationFloat = New DevExpress.Utils.PointFloat(497.3523!, 193.5624!)
        Me.txtLine6.Name = "txtLine6"
        Me.txtLine6.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine6.StylePriority.UseForeColor = False
        Me.txtLine6.Visible = False
        '
        'txtSignatory4
        '
        Me.txtSignatory4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory4.LocationFloat = New DevExpress.Utils.PointFloat(7.227662!, 202.2291!)
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
        Me.txtPosition4.LocationFloat = New DevExpress.Utils.PointFloat(7.227662!, 218.7292!)
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
        Me.txtLine4.LocationFloat = New DevExpress.Utils.PointFloat(7.227662!, 193.7292!)
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine4.StylePriority.UseForeColor = False
        Me.txtLine4.Visible = False
        '
        'txtLine5
        '
        Me.txtLine5.ForeColor = System.Drawing.Color.Gray
        Me.txtLine5.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 193.7292!)
        Me.txtLine5.Name = "txtLine5"
        Me.txtLine5.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine5.StylePriority.UseForeColor = False
        Me.txtLine5.Visible = False
        '
        'txtPosition5
        '
        Me.txtPosition5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition5.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 218.7292!)
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
        Me.txtSignatory5.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 202.2291!)
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
        Me.txtTitle5.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 137.2292!)
        Me.txtTitle5.Name = "txtTitle5"
        Me.txtTitle5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle5.SizeF = New System.Drawing.SizeF(225.42!, 18.74999!)
        Me.txtTitle5.StylePriority.UseFont = False
        Me.txtTitle5.StylePriority.UseTextAlignment = False
        Me.txtTitle5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle5.Visible = False
        '
        'txtTitle4
        '
        Me.txtTitle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle4.LocationFloat = New DevExpress.Utils.PointFloat(7.227659!, 137.2292!)
        Me.txtTitle4.Name = "txtTitle4"
        Me.txtTitle4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle4.SizeF = New System.Drawing.SizeF(222.3591!, 18.74999!)
        Me.txtTitle4.StylePriority.UseFont = False
        Me.txtTitle4.StylePriority.UseTextAlignment = False
        Me.txtTitle4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle4.Visible = False
        '
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle1.LocationFloat = New DevExpress.Utils.PointFloat(7.227659!, 25.1092!)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle1.SizeF = New System.Drawing.SizeF(225.42!, 18.74999!)
        Me.txtTitle1.StylePriority.UseFont = False
        Me.txtTitle1.StylePriority.UseTextAlignment = False
        Me.txtTitle1.Text = "Prepared by"
        Me.txtTitle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitle2
        '
        Me.txtTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle2.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 25.1092!)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle2.SizeF = New System.Drawing.SizeF(225.42!, 18.74999!)
        Me.txtTitle2.StylePriority.UseFont = False
        Me.txtTitle2.StylePriority.UseTextAlignment = False
        Me.txtTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle2.Visible = False
        '
        'txtSignatory2
        '
        Me.txtSignatory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory2.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 91.10911!)
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
        Me.txtPosition2.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 107.6092!)
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
        Me.txtLine2.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 82.60921!)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine2.StylePriority.UseForeColor = False
        Me.txtLine2.Visible = False
        '
        'txtLine1
        '
        Me.txtLine1.ForeColor = System.Drawing.Color.Gray
        Me.txtLine1.LocationFloat = New DevExpress.Utils.PointFloat(7.227661!, 82.60921!)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine1.StylePriority.UseForeColor = False
        '
        'txtPosition1
        '
        Me.txtPosition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition1.LocationFloat = New DevExpress.Utils.PointFloat(7.227661!, 107.6092!)
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
        Me.txtSignatory1.LocationFloat = New DevExpress.Utils.PointFloat(7.227661!, 91.10911!)
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
        Me.txtLine3.LocationFloat = New DevExpress.Utils.PointFloat(497.3524!, 82.44241!)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine3.StylePriority.UseForeColor = False
        Me.txtLine3.Visible = False
        '
        'txtSignatory3
        '
        Me.txtSignatory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory3.LocationFloat = New DevExpress.Utils.PointFloat(497.3524!, 90.94251!)
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
        Me.txtTitle3.LocationFloat = New DevExpress.Utils.PointFloat(497.3524!, 25.1092!)
        Me.txtTitle3.Name = "txtTitle3"
        Me.txtTitle3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle3.SizeF = New System.Drawing.SizeF(225.4199!, 18.74999!)
        Me.txtTitle3.StylePriority.UseFont = False
        Me.txtTitle3.StylePriority.UseTextAlignment = False
        Me.txtTitle3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle3.Visible = False
        '
        'txtTitle6
        '
        Me.txtTitle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle6.LocationFloat = New DevExpress.Utils.PointFloat(497.3522!, 137.2292!)
        Me.txtTitle6.Name = "txtTitle6"
        Me.txtTitle6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle6.SizeF = New System.Drawing.SizeF(225.42!, 18.74999!)
        Me.txtTitle6.StylePriority.UseFont = False
        Me.txtTitle6.StylePriority.UseTextAlignment = False
        Me.txtTitle6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle6.Visible = False
        '
        'txtPosition6
        '
        Me.txtPosition6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition6.LocationFloat = New DevExpress.Utils.PointFloat(497.3523!, 218.5624!)
        Me.txtPosition6.Name = "txtPosition6"
        Me.txtPosition6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition6.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition6.StylePriority.UseFont = False
        Me.txtPosition6.StylePriority.UseTextAlignment = False
        Me.txtPosition6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition6.Visible = False
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 25.1092!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(225.42!, 81.45332!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox2.Visible = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(7.227675!, 25.1092!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(225.42!, 81.45331!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(497.3523!, 25.1092!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(225.42!, 82.33321!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox3.Visible = False
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(497.6219!, 137.2292!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox6.Visible = False
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(252.1027!, 137.2292!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox5.Visible = False
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 137.2292!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(225.42!, 80.45325!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox4.Visible = False
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Italic)
        Me.txtNote.ForeColor = System.Drawing.Color.Red
        Me.txtNote.LocationFloat = New DevExpress.Utils.PointFloat(7.73053!, 4.0!)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNote.SizeF = New System.Drawing.SizeF(715.0419!, 13.83334!)
        Me.txtNote.StylePriority.UseFont = False
        Me.txtNote.StylePriority.UseForeColor = False
        Me.txtNote.StylePriority.UseTextAlignment = False
        Me.txtNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportHeader
        '
        Me.imgReportHeader.BorderWidth = 0.0!
        Me.imgReportHeader.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportHeader.KeepTogether = False
        Me.imgReportHeader.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 1.0!)
        Me.imgReportHeader.Name = "imgReportHeader"
        Me.imgReportHeader.SizeF = New System.Drawing.SizeF(727.0833!, 122.9167!)
        Me.imgReportHeader.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.imgReportHeader.StylePriority.UseBorderWidth = False
        '
        'imgReportFooter
        '
        Me.imgReportFooter.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.000007033348!, 0.0!)
        Me.imgReportFooter.Name = "imgReportFooter"
        Me.imgReportFooter.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.imgReportFooter.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.BorderWidth = 0.0!
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(647.7966!, 42.58346!)
        Me.XrBarCode1.Module = 4.0!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(81.20337!, 80.24986!)
        Me.XrBarCode1.StylePriority.UseBorderWidth = False
        Me.XrBarCode1.StylePriority.UsePadding = False
        QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        Me.XrBarCode1.Text = "10001"
        '
        'rptPurchaseRequest
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 125, 138)
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents pid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtdetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtdesignation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDateRequest As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRequestby As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtoffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtpurchasetype As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents officeid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents status As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition3 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents txtTitle6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPosition6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportHeader As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgReportFooter As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
End Class
