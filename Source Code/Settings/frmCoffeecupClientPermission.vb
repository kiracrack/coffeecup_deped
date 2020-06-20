Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCoffeecupClientPermission
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            If txtdesc.Focus = True Then
                SaveData()

            End If
           
        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If
        
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        clearfields()
        LoadGridviewAppearance(GridView1)
        filter()
        Em.ForceInitialize()
        ckOfficeApprover.Text = StrConv(GlobalOfficeCaption, VbStrConv.ProperCase) & " Approver"

        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
        If globalAllowEdit = True Or globalAllowDelete = True Or LCase(globaluser) = "root" Then
            Em.ContextMenuStrip = gridmenustrip
        Else
            Em.ContextMenuStrip = Nothing
        End If
        ClearAuthority()
    End Sub

    Public Sub ClearAuthority()
        checklistbox.Items.Clear()
        checklistbox.Items.Add("Advance Search")
        checklistbox.Items.Add("Reminders")

        If EnableModuleSales = True Then
            checklistbox.Items.Add("Point of Sale")
            checklistbox.Items.Add("VIP List")
            checklistbox.Items.Add("Point of Sale Assistant")
            checklistbox.Items.Add("Check Encashment")
            checklistbox.Items.Add("Post Expense")
            checklistbox.Items.Add("Account Journal")
            checklistbox.Items.Add("Client Journal")
            checklistbox.Items.Add("Journal Entries")
            checklistbox.Items.Add("Client Payment")
            checklistbox.Items.Add("Sales Delivery")
            checklistbox.Items.Add("Other Transaction")
            checklistbox.Items.Add("Return Item")
            checklistbox.Items.Add("Auto Services")
            If GlobalEnableClinicsServices = True Then
                checklistbox.Items.Add("Clinic Services")
            End If
        End If
        If EnableModuleFuel = True Then
            checklistbox.Items.Add("Pump Reading")
        End If

        If EnableModuleHR = True Then
            checklistbox.Items.Add("Employee Attendance")
            checklistbox.Items.Add("Complaint Box")
        End If

        If EnableModuleSales = True Or EnableModuleProcurement = True Then
            checklistbox.Items.Add("For Approval Request")
            checklistbox.Items.Add("Approval Log History")
            checklistbox.Items.Add("Void Transaction")
        End If
        If EnableModuleProcurement = True Then
            checklistbox.Items.Add("New Requisition")
            checklistbox.Items.Add("Purchase Order")
            checklistbox.Items.Add("Disbursement Voucher")
            checklistbox.Items.Add("Receiving of Goods")
            checklistbox.Items.Add("Requisition Management")
        End If
        If EnableModuleInventory = True Then
            checklistbox.Items.Add("Inventory Management")
            checklistbox.Items.Add("Transfer Management")
            checklistbox.Items.Add("Stockout Management")
            checklistbox.Items.Add("Assets Management")
        End If
        If EnableModuleHotel = True Then
            checklistbox.Items.Add("Hotel Reservation")
            checklistbox.Items.Add("Hotel Management")
            'checklistbox.Items.Add("Tables and Cottages")
            checklistbox.Items.Add("Room Occupancy")
            checklistbox.Items.Add("House Keeping")
        End If
        checklistbox.Items.Add("Report Generator")
    End Sub
    Public Sub filter()
        Dim pos As String = "" : Dim fuel As String = "" : Dim hr As String = "" : Dim procurement As String = "" : Dim inventory As String = "" : Dim hotel As String = ""
        If EnableModuleSales = True Then
            pos = " pointofsale as 'Point of Sale',vip as 'VIP List', pointofsaleassistant as 'Point of Sale Assistant', cashchange as 'Check Encashment',postexpense as 'Post Expense',accountjournal as 'Account Journal', clientaccounts as 'Client Journal', journalentries as 'Journal Entries',clientpayment as 'Client Payment', salesdelivery as 'Sales Delivery', othertransaction as 'Other Transaction',returnitem as 'Return Item',autoservices as 'Auto Services',clinicservices as 'Clinic Services', "
        End If
        If EnableModuleFuel = True Then
            fuel = " pumpreading as 'Pump Reading',"
        End If
        If EnableModuleHR = True Then
            hr = "employeeattendance as 'Employee Attendance', complaintbox as 'Complaint Box', "
        End If
        If EnableModuleProcurement = True Then
            procurement = " requisition as 'New Requisition', forapprovalrequest as 'For Approval Request',apphistory as 'Approval Log History', voidtrn as 'Void Transaction', purchaseorder as 'Purchase Order',accountspayable as 'Disbursement Voucher',receivingofgoods as 'Receiving of Goods',requisitionmgt as 'Requisition Management',"
        End If
        If EnableModuleInventory = True Then
            inventory = " inventorymgt as 'Inventory Management',transfermgt as 'Transfer Management',  stockoutmgt as 'Stockout Management',assetsmgt as 'Assets Management',"
        End If
        If EnableModuleHotel = True Then
            hotel = "hotelreservation as 'Hotel Reservation', hotelmgt as 'Hotel Management', tablesandcottages as 'Tables and Cottages',roomoccupancy as 'Room Occupancy', housekeeping as 'House Keeping',"
        End If

        Dim strmodule As String = pos & fuel & hr & procurement & inventory & hotel
        If strmodule.Length > 0 Then
            strmodule = strmodule.Remove(strmodule.Length - 1, 1)
            strmodule = ", " & strmodule
        End If
        LoadXgrid("Select authCode, authDescription as 'Authorize Person', corpapprover as 'Corporate Approver', officeapprover as '" & GlobalOfficeCaption & " Approver',approveanyoffices as 'Approved any " & GlobalOfficeCaption & "', advancesearch as 'Advance Search',Reminders " & strmodule & ", reportgenerator as 'Report Generator'  from tbluserauthority order by authDescription asc", "tbluserauthority", Em, GridView1, Me)
        GridView1.Columns("authCode").Visible = False
        GridView1.BestFitColumns()
    End Sub

    Public Sub SaveData()
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter authorized approver description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
        End If
        Dim checkeditem As String = "" : Dim I As Integer = 0
        For I = 0 To checklistbox.Items.Count - 1
            If checklistbox.GetItemChecked(I).ToString = True Then
                If checklistbox.Items(I).ToString = "Advance Search" Then
                    checkeditem += "advancesearch=1,"
                End If
                If checklistbox.Items(I).ToString = "Reminders" Then
                    checkeditem += "reminders=1,"
                End If
                If checklistbox.Items(I).ToString = "For Approval Request" Then
                    checkeditem += "forapprovalrequest=1,"
                End If
                If checklistbox.Items(I).ToString = "Approval Log History" Then
                    checkeditem += "apphistory=1,"
                End If
                If checklistbox.Items(I).ToString = "Void Transaction" Then
                    checkeditem += "voidtrn=1,"
                End If
                If checklistbox.Items(I).ToString = "Point of Sale" Then
                    checkeditem += "pointofsale=1,"
                End If
                If checklistbox.Items(I).ToString = "VIP List" Then
                    checkeditem += "vip=1,"
                End If
                If checklistbox.Items(I).ToString = "Point of Sale Assistant" Then
                    checkeditem += "pointofsaleassistant=1,"
                End If
                If checklistbox.Items(I).ToString = "Check Encashment" Then
                    checkeditem += "cashchange=1,"
                End If
                If checklistbox.Items(I).ToString = "Post Expense" Then
                    checkeditem += "postexpense=1,"
                End If
                If checklistbox.Items(I).ToString = "Account Journal" Then
                    checkeditem += "accountjournal=1,"
                End If
                If checklistbox.Items(I).ToString = "Client Journal" Then
                    checkeditem += "clientaccounts=1,"
                End If
                If checklistbox.Items(I).ToString = "Journal Entries" Then
                    checkeditem += "journalentries=1,"
                End If
                If checklistbox.Items(I).ToString = "Client Payment" Then
                    checkeditem += "clientpayment=1,"
                End If
                If checklistbox.Items(I).ToString = "Sales Delivery" Then
                    checkeditem += "salesdelivery=1,"
                End If
                If checklistbox.Items(I).ToString = "Other Transaction" Then
                    checkeditem += "othertransaction=1,"
                End If
                If checklistbox.Items(I).ToString = "Return Item" Then
                    checkeditem += "returnitem=1,"
                End If
                If checklistbox.Items(I).ToString = "Auto Services" Then
                    checkeditem += "autoservices=1,"
                End If
                If checklistbox.Items(I).ToString = "Clinic Services" Then
                    checkeditem += "clinicservices=1,"
                End If
                If checklistbox.Items(I).ToString = "Pump Reading" Then
                    checkeditem += "pumpreading=1,"
                End If
                If checklistbox.Items(I).ToString = "Employee Attendance" Then
                    checkeditem += "employeeattendance=1,"
                End If
                If checklistbox.Items(I).ToString = "Complaint Box" Then
                    checkeditem += "complaintbox=1,"
                End If
                If checklistbox.Items(I).ToString = "New Requisition" Then
                    checkeditem += "requisition=1,"
                End If
                If checklistbox.Items(I).ToString = "Purchase Order" Then
                    checkeditem += "purchaseorder=1,"
                End If
                If checklistbox.Items(I).ToString = "Disbursement Voucher" Then
                    checkeditem += "accountspayable=1,"
                End If
                If checklistbox.Items(I).ToString = "Receiving of Goods" Then
                    checkeditem += "receivingofgoods=1,"
                End If
                If checklistbox.Items(I).ToString = "Requisition Management" Then
                    checkeditem += "requisitionmgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Inventory Management" Then
                    checkeditem += "inventorymgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Transfer Management" Then
                    checkeditem += "transfermgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Stockout Management" Then
                    checkeditem += "stockoutmgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Assets Management" Then
                    checkeditem += "assetsmgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Tables and Cottages" Then
                    checkeditem += "tablesandcottages=1,"
                End If
                If checklistbox.Items(I).ToString = "Hotel Reservation" Then
                    checkeditem += "hotelreservation=1,"
                End If
                If checklistbox.Items(I).ToString = "Hotel Management" Then
                    checkeditem += "hotelmgt=1,"
                End If
                If checklistbox.Items(I).ToString = "Room Occupancy" Then
                    checkeditem += "roomoccupancy=1,"
                End If

                If checklistbox.Items(I).ToString = "House Keeping" Then
                    checkeditem += "housekeeping=1,"
                End If

                If checklistbox.Items(I).ToString = "Report Generator" Then
                    checkeditem += "reportgenerator=1,"
                End If
            End If
        Next
        If mode.Text <> "edit" Then
            If countqry("tbluserauthority", "authDescription='" & txtdesc.Text & "'") > 0 Then
                XtraMessageBox.Show("Duplicate Authorized Approver!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdesc.SelectAll()
                txtdesc.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tbluserauthority set authDescription='" & rchar(txtdesc.Text) & "', " & checkeditem & " corpapprover=" & ckCorporateApprover.CheckState & ", officeapprover=" & ckOfficeApprover.CheckState & ",approveanyoffices=" & ckApproveAnyBranch.CheckState & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "delete from tbluserauthority where authCode='" & id.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tbluserauthority set authCode='" & id.Text & "', authDescription='" & rchar(txtdesc.Text) & "', " & checkeditem & " corpapprover=" & ckCorporateApprover.CheckState & ", officeapprover=" & ckOfficeApprover.CheckState & ",approveanyoffices=" & ckApproveAnyBranch.CheckState & "" : com.ExecuteNonQuery()
        End If

        clearfields() : ClearAuthority()
        filter()
        XtraMessageBox.Show("Authority successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = ""
        txtdesc.Text = ""
        ckCorporateApprover.Checked = False
        ckOfficeApprover.Checked = False
        ckApproveAnyBranch.Checked = False
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub

        com.CommandText = "select * from tbluserauthority where authCode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("authDescription").ToString
            ckOfficeApprover.Checked = rst("officeapprover")
            ckCorporateApprover.Checked = rst("corpapprover")
            ckApproveAnyBranch.Checked = rst("approveanyoffices")
            If rst("advancesearch") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Advance Search" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("reminders") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Reminders" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("forapprovalrequest") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "For Approval Request" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("apphistory") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Approval Log History" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("voidtrn") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Void Transaction" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("pointofsale") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Point of Sale" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("vip") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "VIP List" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("pointofsaleassistant") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Point of Sale Assistant" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("cashchange") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Check Encashment" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("postexpense") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Post Expense" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("accountjournal") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Account Journal" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("clientaccounts") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Client Journal" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("journalentries") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Journal Entries" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("clientpayment") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Client Payment" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("salesdelivery") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Sales Delivery" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("othertransaction") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Other Transaction" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("returnitem") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Return Item" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("autoservices") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Auto Services" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("clinicservices") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Clinic Services" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("pumpreading") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Pump Reading" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("employeeattendance") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Employee Attendance" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("complaintbox") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Complaint Box" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("requisition") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "New Requisition" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("purchaseorder") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Purchase Order" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("accountspayable") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Disbursement Voucher" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("receivingofgoods") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Receiving of Goods" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("requisitionmgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Requisition Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("inventorymgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Inventory Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("transfermgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Transfer Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("stockoutmgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Stockout Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("assetsmgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Assets Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("hotelreservation") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Hotel Reservation" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("hotelmgt") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Hotel Management" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
            If rst("tablesandcottages") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Tables and Cottages" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("roomoccupancy") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Room Occupancy" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("housekeeping") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "House Keeping" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If

            If rst("reportgenerator") = True Then
                Dim I As Integer = 0
                For I = 0 To checklistbox.Items.Count - 1
                    If checklistbox.Items(I).ToString = "Report Generator" Then
                        checklistbox.SetItemCheckState(I, CheckState.Checked)
                    End If
                Next
            End If
        End While
        rst.Close()

        If mode.Text = "edit" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("authCode").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        clearfields() : ClearAuthority()
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("authCode").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False
    End Sub

    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If GridView1.GetFocusedRowCellValue("authCode").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("authCode", "authCode", "tbluserauthority", GridView1, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        'Dim msg As String = ""
        'For I = 0 To checklistbox.Items.Count - 1
        '    msg += checklistbox.Items(I).ToString & Environment.NewLine
        'Next
        'MsgBox(msg)
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please enter description", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        ElseIf checklistbox.Items.Count = 0 Then
            XtraMessageBox.Show("Please select atleast one permission", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SaveData()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Dim I As Integer = 0
        For I = 0 To checklistbox.Items.Count - 1
            If CheckEdit2.Checked = True Then
                checklistbox.SetItemCheckState(I, CheckState.Checked)
            Else
                checklistbox.SetItemCheckState(I, CheckState.Unchecked)
            End If
        Next
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripMenuItem.Click
        com.CommandText = "INSERT INTO  `tbluserauthority` (authDescription,officeapprover,corpapprover,approveanyoffices,advancesearch,reminders,forapprovalrequest,voidtrn,apphistory,pointofsale,vip,pointofsaleassistant,pumpreading,employeeattendance,complaintbox,cashchange,postexpense,clientaccounts,clientpayment,salesdelivery,othertransaction,accountjournal,journalentries,returnitem,requisition,purchaseorder,accountspayable,receivingofgoods,requisitionmgt,inventorymgt,transfermgt,stockoutmgt,assetsmgt,hotelreservation,hotelmgt,tablesandcottages,roomoccupancy,autoservices,housekeeping,clinicservices,reportgenerator) " _
                               + " SELECT concat(authDescription,' - copy'),officeapprover,corpapprover,approveanyoffices,advancesearch,reminders,forapprovalrequest,voidtrn,apphistory,pointofsale,vip,pointofsaleassistant,pumpreading,employeeattendance,complaintbox,cashchange,postexpense,clientaccounts,clientpayment,salesdelivery,othertransaction,accountjournal,journalentries,returnitem,requisition,purchaseorder,accountspayable,receivingofgoods,requisitionmgt,inventorymgt,transfermgt,stockoutmgt,assetsmgt,hotelreservation,hotelmgt,tablesandcottages,roomoccupancy,autoservices,housekeeping,clinicservices,reportgenerator FROM `tbluserauthority` where authCode='" & GridView1.GetFocusedRowCellValue("authCode").ToString & "'" : com.ExecuteNonQuery()
        filter()
        XtraMessageBox.Show("Permission successfully duplicated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("There's no item to export!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Report File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = Me.Text & ".xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            GridView1.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class