Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCompOffice
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then


        End If
        Return ProcessCmdKey
    End Function
    

    Public Sub filter()
        LoadXgrid("Select officeid as 'Office Code', (select companyname from tblcompany where code=tblcompoffice.companyid) as 'Company', initialcode as 'Initial Code', officename as '" & GlobalOfficeCaption & "',shortname as 'Short Name',Address, contactnumber as 'Contact Number',ifnull((select fullname from tblaccounts where accountid = tblcompoffice.officerid ),'NOT ASSIGNED') as 'Officer Incharge',case when officeemail='' then 'No Email' else officeemail end as 'Email Address',CorporateOffice, allowbeggininginventory as 'Manual Consumable',allowmanualffeinventory as 'Manual FEE', enableoperation as 'Enable Operation',custombranchapproval as 'Custom Branch Approval',customcorporateapproval as 'Custom Corporate Approval', allowmanualconsumableinventory as 'Allow Manage Consumable Other Office', allowmanageffeotheroffice as 'Allow Manage FFE Other Office', EnableInventory, blockedrequisition as 'Blocked Requisition' from tblcompoffice where deleted=0 order by officename asc", "tblcompoffice", Em, GridView1, Me)
        XgridColAlign({"Office Code", "Initial Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()

        If GlobalNumberOfDevision = 0 Then
            cmdAdd.Visibility = XtraBars.BarItemVisibility.Always
        Else
            If countrecord("tblcompoffice") >= GlobalNumberOfDevision Then
                cmdAdd.Visibility = XtraBars.BarItemVisibility.Never
            Else
                cmdAdd.Visibility = XtraBars.BarItemVisibility.Always
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Office Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmCompOfficeInfo.mode.Text = ""
        frmCompOfficeInfo.id.Text = GridView1.GetFocusedRowCellValue("Office Code").ToString
        frmCompOfficeInfo.mode.Text = "edit"
        If frmCompOfficeInfo.Visible = True Then
            frmCompOfficeInfo.Focus()
        Else
            frmCompOfficeInfo.Show(Me)
        End If

    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(GridView1)
        
        filter()
        
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdAdd.Visibility = XtraBars.BarItemVisibility.Always
        Else
            cmdAdd.Visibility = XtraBars.BarItemVisibility.Never
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
        Else
            cmdEdit.Visible = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdRemove.Enabled = True
        Else
            cmdRemove.Enabled = False
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If GridView1.GetFocusedRowCellValue("Office Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblcompoffice set deleted=1 where officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Office Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd.ItemClick
        If frmCompOfficeInfo.Visible = True Then
            frmCompOfficeInfo.Focus()
        Else
            frmCompOfficeInfo.Show(Me)
        End If
        frmCompOfficeInfo.mode.Text = "new"
    End Sub
    Public Function BlockedRequisition(ByVal reason As String)
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblcompoffice set blockedrequisition=1, blockedreason='" & rchar(reason) & "' where officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Office Code") & "' " : com.ExecuteNonQuery()
        Next
        filter()
        XtraMessageBox.Show("Selected office successfully blocked requisition", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        PrintGeneralReport(Me.Text, "", GridView1, Me)
    End Sub

    Private Sub BlockedRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockedRequisitionToolStripMenuItem.Click
        frmBlockedRequisition.Show(Me)
    End Sub

    Private Sub UnblockedRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnblockedRequisitionToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblcompoffice set blockedrequisition=0, blockedreason='' where officeid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Office Code") & "' " : com.ExecuteNonQuery()
            Next
            filter()
            XtraMessageBox.Show("Selected office successfully unblocked requisition", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
