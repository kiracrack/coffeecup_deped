Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI

Public Class frmRequestProcessing
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmApproverFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        lbloffice.Text = GlobalOfficeCaption
        LoadGridviewAppearance(g_po)
        LoadGridviewAppearance(g_requestor)

        If processtype.Text = "po" Then
            LoadApprovedRequest("and enablepo=1")
            Me.Text = "Purchase Order Processing"
            cmdMove.Text = "Confirm && Process Purchase Order"
            lbldisbursingoffice.Text = "Approving Level"

        Else
            LoadApprovedRequest("and enablepo=0")
            Me.Text = "Payment Request Processing"
            cmdMove.Text = "Confirm && Process For Payment Order"
            lbldisbursingoffice.Text = "Approving Level"
        End If
        XgridColCurrency({"Total Amount"}, g_po)
        XgridHideColumn({"pid", "officeid", "vendorid"}, g_po)
        XgridAllowColumnEdit({"pid", "officeid", "vendorid", "Vendor", "Total Amount"}, g_po, False)
    End Sub

    Public Sub LoadApprovedRequest(ByVal query As String)
        LoadXgridLookupSearch("SELECT PID as 'Request. ID',requestby, tblrequesttype.description,  " _
                             + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as '" & GlobalOfficeCaption & "', " _
                             + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
                             + " (select fullname as FULLNAME from tblaccounts where accountid=tblrequisitions.REQUESTBY and username <> 'ROOT') as 'Request by', DATEREQUEST as 'Date Request' " _
                             + " from tblrequisitions inner join tblrequesttype on tblrequisitions.potypeid = tblrequesttype.potypeid WHERE ((corporatelevel=0 and approvedbranch=1) or (corporatelevel=1 and approvedbranch=1 and approvedcorporate=1)) and generatedpo=0 " & query & " and cancelled=0 order by daterequest desc", "tblrequisitions", pid, g_requestor, Me)

        XgridHideColumn({"requestby", "description"}, g_requestor)
        XgridColCurrency({"Total Amount"}, g_requestor)
        pid.Properties.PopupFormMinSize = New Size(750, 300)
    End Sub
    Private Sub txtRequestor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(pid.Properties.View.FocusedRowHandle.ToString)
        pid.Text = pid.Properties.View.GetFocusedRowCellValue("Request. ID").ToString()
        reqid.Text = pid.Properties.View.GetFocusedRowCellValue("requestby").ToString()
        potype.Text = pid.Properties.View.GetFocusedRowCellValue("description").ToString()
        txtPurchaseBy.Text = pid.Properties.View.GetFocusedRowCellValue("Request by").ToString()
        txtoffice.Text = pid.Properties.View.GetFocusedRowCellValue(GlobalOfficeCaption).ToString()
        txtDisbursingOffice.SelectedIndex = If(CBool(qrysingledata("dislevel", "if(corporatelevel=1,true,false) as dislevel", "where pid='" & pid.Text & "'", "tblrequisitions")) = True, 1, 0)
        If pid.Text <> "" Then
            CreatePurchaseOrder()
            cmdViewFullRequest.Enabled = True
        Else
            cmdViewFullRequest.Enabled = False
        End If
    End Sub

    Public Sub CreatePurchaseOrder()
        LoadXgrid("select (select companyname from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid) as 'Vendor','' as 'Invoice No.', sum(total) as 'Total Amount', " _
                             + " tblrequisitions.pid,tblrequisitions.officeid,vendorid,requestby, details as 'Note' " _
                             + " from tblrequisitions inner join tblrequisitionsitem on tblrequisitions.pid = tblrequisitionsitem.pid " _
                             + " WHERE tblrequisitions.pid='" & pid.Text & "' group by tblrequisitionsitem.vendorid", "tblrequisitionsitem", Em, g_po, Me)
        XgridColCurrency({"Total Amount"}, g_po)
        XgridHideColumn({"pid", "officeid", "vendorid", "requestby"}, g_po)
        XgridAllowColumnEdit({"pid", "officeid", "vendorid", "Vendor", "Total Amount"}, g_po, False)
        g_po.UserCellPadding = New Padding(5)
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        If pid.Text = "" Then
            XtraMessageBox.Show("Please select approved request!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            pid.Focus()
            Exit Sub
        ElseIf GlobalEnableponumbersequence = False Then
            XtraMessageBox.Show("PO Sequence number currently not configured! Please contact your system administrator", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            pid.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to continue confirm current request!", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            GenerateApprovedRequest(pid.Text)
            com.CommandText = "delete from tblpurchaseorder where requestref= '" & pid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpurchaseorderitem where requestref= '" & pid.Text & "'" : com.ExecuteNonQuery()
            Dim getPOtypeid As String = qrysingledata("potypeid", "potypeid", "tblrequisitions where pid='" & pid.Text & "'")
            For I = 0 To g_po.RowCount - 1
                Dim ponumber As String = getDirectPONumberSequence()
                com.CommandText = "insert into tblpurchaseorder set ponumber='" & ponumber & "', " _
                                                    + " invoiceno='" & rchar(g_po.GetRowCellValue(I, "Invoice No.").ToString) & "', " _
                                                    + " requestref= '" & g_po.GetRowCellValue(I, "pid").ToString & "', " _
                                                    + " requestby= '" & g_po.GetRowCellValue(I, "requestby").ToString & "', " _
                                                    + " officeid='" & g_po.GetRowCellValue(I, "officeid").ToString & "', " _
                                                    + " vendorid='" & g_po.GetRowCellValue(I, "vendorid").ToString & "', " _
                                                    + " createby='" & globaluserid & "', " _
                                                    + " subtotal='" & Val(CC(g_po.GetRowCellValue(I, "Total Amount").ToString)) & "', " _
                                                    + " totalamount='" & Val(CC(g_po.GetRowCellValue(I, "Total Amount").ToString)) & "', " _
                                                    + " datetrn=current_timestamp, " & If(GlobalPOExpiry > 0, "dateexpiry=date_format(current_timestamp+ interval " & GlobalPOExpiry & " day,'%Y-%m-%d'), ", "") _
                                                    + " corporatelevel=" & txtDisbursingOffice.SelectedIndex & ", " _
                                                    + " paymentrequestedby='" & globaluserid & "', " _
                                                    + " note='" & rchar(g_po.GetRowCellValue(I, "Note").ToString) & "' " _
                                                    + If(processtype.Text = "po", ",forpo=1 " & If(GlobalDirectApprovedPo = True, ",verified=1,verifiedby='" & globaluserid & "', dateverified=current_timestamp", "") & "", ",forpo=0, verified=1,verifiedby='" & globaluserid & "', dateverified=current_timestamp, forwarded=1,delivered=1,datedelivered=current_timestamp,receivedby='" & globaluserid & "', paymentrequested=0") : com.ExecuteNonQuery()

                com.CommandText = "INSERT INTO `tblpurchaseorderitem` (requestref,ponumber,officeid,vendorid,productid,itemname,catid,quantity,unit,cost,total,remarks,allocatedrefcode,trnby,datetrn,delivered,datedelivered) " _
                                                                 + " SELECT pid,ponumber,tblrequisitionsitem.officeid,tblrequisitionsitem.vendorid,productid,(select itemname from tblglobalproducts where productid=tblrequisitionsitem.productid),catid,quantity,unit,cost,total,remarks,allocatedrefcode,tblrequisitionsitem.trnby,tblrequisitionsitem.datetrn, " & If(processtype.Text = "po", "0,null", "1,current_timestamp") & " FROM `tblrequisitionsitem` inner join tblpurchaseorder on tblrequisitionsitem.pid  = tblpurchaseorder.requestref and tblrequisitionsitem.vendorid = tblpurchaseorder.vendorid where tblrequisitionsitem.pid = '" & g_po.GetRowCellValue(I, "pid").ToString & "' and tblrequisitionsitem.vendorid = '" & g_po.GetRowCellValue(I, "vendorid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblrequisitionsitem set verifieditem=1 where pid = '" & g_po.GetRowCellValue(I, "pid").ToString & "' and vendorid = '" & g_po.GetRowCellValue(I, "vendorid").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO `tblapprovalhistory` set approvaltype='" & getPOtypeid & "', " _
                                                              + " appdescription='" & If(processtype.Text = "po", "purchase order", "payment order") & "', " _
                                                              + " mainreference='" & pid.Text & "', " _
                                                              + " referenceno='" & ponumber & "', " _
                                                              + " status='processed', " _
                                                              + " remarks='" & "Process Ref# " & ponumber & "-" & rchar(g_po.GetRowCellValue(I, "Vendor").ToString) & "', " _
                                                              + " apptitle='" & globaldesignation & "', " _
                                                              + " applevel='-', " _
                                                              + " confirmid='" & globaluserid & "', " _
                                                              + " confirmby='" & globalfullname & "', " _
                                                              + " position='" & globaldesignation & "', " _
                                                              + " dateconfirm=current_timestamp, " _
                                                              + " finalapprover=0 " : com.ExecuteNonQuery()
                NextEmailPurchaseOrderApprover(ponumber, txtDisbursingOffice.SelectedIndex, "")
                If GlobalEnableVoucherPaymentPosting = True And processtype.Text <> "po" Then
                    com.CommandText = "insert into tblglaccountledger set officeid='" & g_po.GetRowCellValue(I, "officeid").ToString & "',batchcode='',journalmode='payable-accounts',accountno='" & g_po.GetRowCellValue(I, "vendorid").ToString & "',referenceno='" & ponumber & "',itemcode='" & GlobalPOPaymentGLItemCode & "',remarks='" & rchar(g_po.GetRowCellValue(I, "Note").ToString) & "',debit='" & Val(CC(g_po.GetRowCellValue(I, "Total Amount").ToString)) & "',credit=0,datetrn=current_timestamp,trnby='" & globaluserid & "',cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            com.CommandText = "update tblrequisitions set generatedpo=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()

            If processtype.Text = "po" Then
                InsertEmailNotification("requisition", getEmailAccount(reqid.Text), "REQUEST #" & pid.Text & " - PO GENERATED FOR APPROVAL", FormatingEmailRequisition(pid.Text, UCase(potype.Text)), "")
                pid.Properties.DataSource = Nothing : pid.Text = "" : txtPurchaseBy.Text = "" : txtoffice.Text = "" : CreatePurchaseOrder()
                LoadApprovedRequest("and enablepo=1")

            Else
                pid.Properties.DataSource = Nothing : pid.Text = "" : txtPurchaseBy.Text = "" : txtoffice.Text = "" : CreatePurchaseOrder()
                LoadApprovedRequest("and enablepo=0")
            End If

            XtraMessageBox.Show("purchase order successfully processed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Public Sub GenerateApprovedRequest(ByVal pid As String)
        Dim requestlocation As String = Application.StartupPath.ToString & "\Requisitions\" & Now.ToString("yyyy-MM-dd")
        If (Not System.IO.Directory.Exists(requestlocation)) Then
            System.IO.Directory.CreateDirectory(requestlocation)
        End If

        Dim report As New rptPurchaseRequest()
        report.pid.Text = pid
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblrequisitions.requestby) as 'requestor', " _
                        + " (select designation from tblaccounts where accountid=tblrequisitions.requestby) as 'position', " _
                        + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'potype' from tblrequisitions where pid='" & pid & "'" : rst = com.ExecuteReader()
        While rst.Read
            report.txtRequestby.Text = StrConv(rst("requestor").ToString, vbUpperCase)
            report.txtdesignation.Text = rst("position").ToString
            report.txtoffice.Text = txtoffice.Text
            report.txtDateRequest.Text = CDate(rst("daterequest").ToString).ToString("MMMM dd, yyyy hh:mm:ss tt")
            report.txtpurchasetype.Text = UCase(rst("potype").ToString)
            report.txtdetails.Text = rst("details").ToString
            report.officeid.Text = rst("officeid").ToString
        End While
        rst.Close()

        LoadXgrid("Select (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                             + " ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid=tblrequisitionsitem.officeid and productid=tblrequisitionsitem.productid),0) as 'Onhand', " _
                             + " QUANTITY as 'Quantity'," _
                             + " UNIT as 'Unit', " _
                             + " COST as 'Cost', " _
                             + " TOTAL as 'Total', " _
                             + " Remarks, " _
                             + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid) as 'Vendor' " _
                             + " from tblrequisitionsitem " _
                             + " where pid='" & pid & "' order by (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid) asc", "tblrequisitionsitem", gcontrol_po, gridview_po, Me)

        XgridColCurrency({"Cost", "Total"}, gridview_po)

        gridview_po.Columns("Onhand").Width = 2
        gridview_po.Columns("Quantity").Width = 2
        gridview_po.Columns("Unit").Width = 2
        gridview_po.Columns("Cost").Width = 2
        gridview_po.Columns("Total").Width = 2
        gridview_po.Columns("Vendor").Width = 3

        gridview_po.Columns("Remarks").Width = 100
        gridview_po.Columns("Remarks").ColumnEdit = MemoEdit
        RemovedNoValueColumn("Remarks", gridview_po, Me)

        XgridColAlign({"Quantity", "Onhand", "Unit"}, gridview_po, DevExpress.Utils.HorzAlignment.Center)
        gridview_po.Columns("Total").Summary.Clear()
        gridview_po.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n}")
        CType(gridview_po.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(gcontrol_po))
        If Not (System.IO.File.Exists(requestlocation & "\" & pid & ".pdf")) Then
            System.IO.File.Delete(requestlocation & "\" & pid & ".pdf")
        End If

        report.ExportToPdf(requestlocation & "\" & pid & ".pdf")
        FileAttach(0) = requestlocation & "\" & pid & ".pdf"
        AddAttachmentPackage(pid, "requisition-approved", {requestlocation & "\" & pid & ".pdf"})
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdViewFullRequest.Click
        frmRequestProfile.pid.Text = pid.Text
        frmRequestProfile.Show(Me)
    End Sub

End Class