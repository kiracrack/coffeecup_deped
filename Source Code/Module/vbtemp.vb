Module vbtemp
    '    Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
    'Imports System.IO
    'Imports System.Drawing
    'Imports DevExpress.XtraEditors
    'Imports DevExpress.XtraGrid
    'Imports DevExpress.XtraGrid.Views.Grid
    'Imports DevExpress.XtraGrid.GridColumnSummaryItem
    'Imports DevExpress.XtraEditors.Controls
    'Imports DevExpress.Utils
    'Imports DevExpress.XtraReports.UI

    '    Public Class frmPurchaseItems
    '        Private Function formatcurrency(ByVal i As Integer)
    '            GridView1.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
    '            GridView1.Columns(i).DisplayFormat.FormatString = "n"
    '            Return 0
    '        End Function

    '        Private Sub frmPurchaseItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '            pid.Text = ""
    '        End Sub
    '        Private Sub frmPurchaseItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '            FilterOption()
    '        End Sub
    '        Public Sub FilterOption()
    '            If txtStatus.Text = "REVISED" Then
    '                filter(pid.Text, 2)
    '            Else
    '                filter(pid.Text, 1)
    '            End If
    '        End Sub
    '        Private Sub pid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid.EditValueChanged
    '            If pid.Text = "" Then Exit Sub
    '            loaddetails(pid.Text)
    '        End Sub
    '        Public Function loaddetails(ByVal id As String)
    '            com.CommandText = "select *, (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
    '                                     + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
    '                                     + " CASE WHEN STATUS='0' THEN 'Stock' WHEN STATUS='1' THEN 'FOR APPROVAL' WHEN STATUS='2' THEN 'APPROVED' WHEN STATUS='3' THEN 'CANCELED' WHEN STATUS='4' THEN 'REVISED' END  as 'STATS'  " _
    '                                     + " from tblrequisitions where PID='" & id & "'"
    '            rst = com.ExecuteReader
    '            While rst.Read
    '                txtRequestby.Text = rst("REQUEST").ToString
    '                txtDesignation.Text = rst("DESIGNATION").ToString
    '                txtdatereq.Text = rst("DATEREQUEST").ToString
    '                txtpotitle.Text = rst("POTITLE").ToString
    '                txtdetails.Text = rst("DETAILS").ToString
    '                txtStatus.Text = rst("STATS").ToString
    '            End While
    '            rst.Close()
    '            Return 0
    '        End Function
    '        Public Function filter(ByVal pid As String, ByVal status As Integer)
    '            If txtStatus.Text = "Stock" Then
    '                LoadXgrid("Select potrnid as 'TRNID', " _
    '                          + " (select ITEMNAME from tblglobalproducts where PRODUCTID = tblpurchasedclosed.PRODUCTID ) as 'Particular Item', " _
    '                          + " (select DESCRIPTION from tblglobalproducts where PRODUCTID = tblpurchasedclosed.PRODUCTID ) as 'Description', " _
    '                          + " (select DESCRIPTION from tblprocategory where CATID = tblpurchasedclosed.CATID ) as 'Category', " _
    '                          + " QUANTITY as 'Quantity'," _
    '                          + " (select UNIT from tblglobalproducts where PRODUCTID = tblpurchasedclosed.PRODUCTID ) as 'Unit', " _
    '                          + " COST as 'Cost', " _
    '                          + " TOTAL as 'Total', " _
    '                          + " (select COMPANYNAME from tblglobalvendor where vendorid = tblpurchasedclosed.vendorid ) as 'Vendor', " _
    '                          + " (select officename from tblcompoffice where officeid = tblpurchasedclosed.officeid ) as '" & GlobalOfficeCaption & "' " _
    '                          + " from tblpurchasedclosed " _
    '                          + " where POID='" & pid & "'", "tblpurchasedclosed", Em, GridView1, Me)
    '            Else
    '                LoadXgrid("Select TRNID,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular Item', " _
    '                          + " (select DESCRIPTION from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Description', " _
    '                          + " QUANTITY as 'Quantity'," _
    '                          + " (select UNIT from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Unit', " _
    '                          + " COST as 'Cost', " _
    '                          + " TOTAL as 'Total', " _
    '                          + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
    '                          + " from tblrequisitionsitem " _
    '                          + " where PURCHASEID='" & pid & "' and STATUS=" & status, "tblrequisitionsitem", Em, GridView1, Me)
    '            End If
    '            GridView1.Columns("Particular Item").ColumnEdit = MemoEdit
    '            GridView1.Columns("Description").ColumnEdit = MemoEdit

    '            GridView1.Columns("TRNID").Visible = False
    '            XgridColCurrency({"Cost"}, GridView1)
    '            XgridColCurrency({"Total"}, GridView1)

    '            GridView1.Columns("Total").Summary.Clear()
    '            GridView1.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Total = {0:n} Php")
    '            CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True
    '            Return 0
    '        End Function

    '        Private Sub BarLargeButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
    '            Me.Close()
    '        End Sub

    '        Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint.ItemClick
    '            ShowReportPO()
    '        End Sub
    '        Public Sub ShowReportPO()
    '            Dim report As New rptPRequest()
    '            report.txtpoID.Text = StrConv(pid.Text, vbUpperCase)
    '            report.txtRequestby.Text = StrConv(txtRequestby.Text, vbUpperCase)
    '            report.txtdesignation.Text = txtDesignation.Text
    '            report.txtdate.Text = txtdatereq.Text
    '            report.txtdetails.Text = txtdetails.Text

    '            report.txtpreparename.Text = txtRequestby.Text
    '            report.txtpreparedesignation.Text = txtDesignation.Text

    '            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
    '            report.ShowRibbonPreviewDialog()
    '        End Sub
    '        'Private Sub cmdApprove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdApprove.ItemClick
    '        '    If CheckSelectedRow("TRNID", GridView1) = True Then
    '        '        If XtraMessageBox.Show("Are you sure you want to approve this this Request order? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        '            com.CommandText = "update tblrequisitions set STATUS='2', APPROVALBY='" & globaluserid & "',DATEAPPROVAL='" & GlobalDateTime() & "'   where PID='" & pid.Text & "'"
    '        '            com.ExecuteNonQuery()
    '        '            FilterOption()
    '        '            XtraMessageBox.Show("Request order status successfully approved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        End If
    '        '    End If
    '        'End Sub



    '        Private Sub txtStatus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatus.EditValueChanged
    '            'If txtStatus.Text = "FOR APPROVAL" Then
    '            '    cmdApprove.Enabled = True
    '            '    cmdRevise.Enabled = True
    '            '    cmdCancel.Enabled = True
    '            'Else
    '            '    cmdApprove.Enabled = False
    '            '    cmdRevise.Enabled = False
    '            '    cmdCancel.Enabled = False
    '            'End If
    '        End Sub

    '        'Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRevise.ItemClick
    '        '    If CheckSelectedRow("TRNID", GridView1) = True Then
    '        '        If XtraMessageBox.Show("Are you sure you want to revise this Request order? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        '            com.CommandText = "update tblrequisitions set STATUS='4', APPROVALBY='" & globaluserid & "',DATEAPPROVAL='" & GlobalDateTime() & "'  where PID='" & pid.Text & "'"
    '        '            com.ExecuteNonQuery()

    '        '            com.CommandText = "insert into tblrevised set PID='" & pid.Text & "',DATEREVISE='" & GlobalDateTime() & "'"
    '        '            com.ExecuteNonQuery()

    '        '            com.CommandText = "INSERT INTO tblrequisitionsitem (TRNID,PURCHASEID,PRODUCTID,CATID,QUANTITY,COST,TOTAL,STATUS) " _
    '        '                            + "SELECT TRNID,PURCHASEID,PRODUCTID,CATID,QUANTITY,COST,TOTAL,1 FROM tblrequisitionsitem WHERE tblrequisitionsitem.PURCHASEID='" & pid.Text & "'"
    '        '            FilterOption()
    '        '            XtraMessageBox.Show("Request order status successfully revised!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        End If
    '        '    End If
    '        'End Sub


    '        'Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCancel.ItemClick
    '        '    If CheckSelectedRow("TRNID", GridView1) = True Then
    '        '        If XtraMessageBox.Show("Are you sure you want to cancel this Request order? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        '            com.CommandText = "update tblrequisitionsset STATUS='3', APPROVALBY='" & globaluserid & "',DATEAPPROVAL='" & GlobalDateTime() & "'  where PID='" & pid.Text & "'"
    '        '            com.ExecuteNonQuery()
    '        '            FilterOption()
    '        '            XtraMessageBox.Show("Request order status successfully canceled!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        End If
    '        '    End If
    '        'End Sub

    '    End Class

    '------------------------------- MY INVENTORY --------------------------------
    'Public Sub filter()
    '    If officeid.Text = "" Then Exit Sub
    '    If CheckEdit1.Checked = True Then
    '        LoadXgrid("Select (select description from tblprocategory where catid=tblpurchasedclosed.catid) as 'Category',ID,officeid,(select officename from tblcompoffice where officeid=tblpurchasedclosed.officeid) as 'Received to' ,PRODUCTID as 'Particular ID', " _
    '                        + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblpurchasedclosed.PRODUCTID) as 'Particular', " _
    '                        + " QUANTITY as 'Quantity', " _
    '                        + " UNIT as 'Unit', " _
    '                        + " COST as 'Unit Price', Total," _
    '                        + " DATETRN as 'Date Stock', " _
    '                        + " REMARKS as 'Remarks' " _
    '                        + " from tblpurchasedclosed where " _
    '                        + " officeid='" & officeid.Text & "' " _
    '                        + " order by 'Particular' desc", "tblpurchasedclosed", Em, inventoryGrid, Me)
    '        inventoryGrid.Columns("Category").Group()
    '        inventoryGrid.ExpandAllGroups()
    '    Else
    '        'If catid.Text = "" Then Exit Sub
    '        LoadXgrid("Select ID,officeid,(select officename from tblcompoffice where officeid=tblpurchasedclosed.officeid) as 'Received to' ,PRODUCTID as 'Particular ID', " _
    '                        + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tblpurchasedclosed.PRODUCTID) as 'Particular', " _
    '                        + " QUANTITY as 'Quantity', " _
    '                        + " UNIT as 'Unit', " _
    '                        + " COST as 'Unit Price', Total," _
    '                        + " DATETRN as 'Date Stock'," _
    '                        + " REMARKS as 'Remarks' " _
    '                        + " from tblpurchasedclosed where " _
    '                        + " officeid='" & officeid.Text & "' and " _
    '                        + " CATID='" & catid.Text & "' " _
    '                        + " order by 'Particular' desc", "tblpurchasedclosed", Em, inventoryGrid, Me)


    '    End If


    'inventoryGrid.Columns("Remarks").ColumnEdit = MemoEdit
    'inventoryGrid.BestFitColumns()

    'inventoryGrid.Columns("ID").Visible = False
    'inventoryGrid.Columns("officeid").Visible = False

    'XgridColCurrency("Unit Price", inventoryGrid)
    'XgridColCurrency("Total", inventoryGrid)
    'inventoryGrid.Columns("Unit Price").Width = 100
    'inventoryGrid.Columns("Total").Width = 140
    'inventoryGrid.Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center

    'inventoryGrid.Columns("Total").Summary.Clear()
    'inventoryGrid.Columns("Total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Total = {0:n} Php")
    'CType(inventoryGrid.Columns("Total").View, GridView).OptionsView.ShowFooter = True
    'End Sub

    'Public Function ExtractSpecificZipFile(ByVal refno As String) As Boolean
    '    Dim extract_location As String = Application.StartupPath.ToString & "\Extracted\"
    '    MdiCoffeeCup.timernotification.Stop()
    '    Try
    '        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
    '        If (System.IO.Directory.Exists(extract_location)) Then
    '            My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
    '        End If
    '        Dim qry As String = ""
    '        For Each strresult In refno.Split(New Char() {","c})
    '            qry = qry + "referenceno='" & strresult & "' or "
    '        Next
    '        qry = qry.Remove(qry.Count - 3, 3)

    '        com.CommandText = "select * from tblattachments where  " & qry & "" : rst = com.ExecuteReader()
    '        While rst.Read
    '            Dim fileStreamIn As FileStream = New FileStream(ZIPFILE_LOCATION & "\" & rst("datesaved").ToString & ".zip", FileMode.Open, FileAccess.Read)
    '            Dim fileStreamOut As FileStream
    '            Dim zf As ZipFile = New ZipFile(fileStreamIn)
    '            Dim Size As Integer
    '            Dim buffer(409600) As Byte
    '            Dim Zentry As ZipEntry = zf.GetEntry(rst("archivedfilename").ToString)
    '            If (Zentry Is Nothing) Then
    '                XtraMessageBox.Show(rst("originalfilename").ToString & " not found in Archived", _
    '                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                rst.Close()
    '                Return False
    '                Exit Function
    '            End If

    '            Dim fstr As ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
    '            fstr = zf.GetInputStream(Zentry)

    '            'Dim strFullPath As String = Path.GetDirectoryName(Zentry.Name)
    '            'Directory.CreateDirectory(strFullPath)
    '            'fileStreamOut = New FileStream(strFullPath & "\" & Path.GetFileName(Zentry.Name), FileMode.Create, FileAccess.Write)
    '            If Not System.IO.Directory.Exists(extract_location) = True Then
    '                System.IO.Directory.CreateDirectory(extract_location)
    '            End If
    '            fileStreamOut = New FileStream(extract_location + "\" + Path.GetFileName(rst("originalfilename").ToString), FileMode.Create, FileAccess.Write)

    '            Do
    '                Size = fstr.Read(buffer, 0, buffer.Length)
    '                fileStreamOut.Write(buffer, 0, Size)
    '            Loop While (Size > 0)

    '            fstr.Close()
    '            fileStreamOut.Close()
    '            fileStreamIn.Close()
    '        End While
    '        rst.Close()
    '        '   Call Shell("explorer /select," & extract_location, AppWinStyle.NormalFocus)
    '        'Dim objShell = CreateObject("Wscript.Shell")
    '        'objShell.run(extract_location)
    '        Process.Start("explorer.exe", extract_location)
    '        MdiCoffeeCup.timernotification.Start()
    '        SplashScreenManager.CloseForm()
    '        Return (True)
    '    Catch ex As Exception
    '        SplashScreenManager.CloseForm()
    '        XtraMessageBox.Show("Message:" & ex.Message & vbCrLf, _
    '                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        rst.Close()
    '        Return False
    '    End Try

    'End Function
End Module
