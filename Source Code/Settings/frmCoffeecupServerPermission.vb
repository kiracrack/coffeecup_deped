Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmCoffeecupServerPermission

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub ClearFields()
        Load_Menu()
        txtpermission.Properties.DataSource = Nothing
        txtpermission.Text = ""
        percode.Text = ""
        If percode.Text <> "" Then
            cmdEditItem.Enabled = True
        Else
            cmdEditItem.Enabled = False
        End If
    End Sub
    Private Sub frmUsersAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadGridviewAppearance(gv_permission)
        Load_Menu()
        LoadPermission()

        If EnableModuleProcurement = True Then
            cmdProcurement.Visible = True
        Else
            cmdProcurement.Visible = False
        End If

        If EnableModuleInventory = True Then
            cmdInventory.Visible = True
        Else
            cmdInventory.Visible = False
        End If

        If EnableModuleSales = True Then
            cmdSales.Visible = True
        Else
            cmdSales.Visible = False
        End If

        If EnableModuleFuel = True Then
            cmdFuel.Visible = True
        Else
            cmdFuel.Visible = False
        End If

        If EnableModuleHotel = True Then
            cmdHotel.Visible = True
        Else
            cmdHotel.Visible = False
        End If

        If EnableModuleHR = True Then
            cmdHumanResource.Visible = True
        Else
            cmdHumanResource.Visible = False
        End If

        If EnableModulePayroll = True Then
            cmdPayrollManagement.Visible = True
        Else
            cmdPayrollManagement.Visible = False
        End If

        If EnableAccounting = True Then
            cmdAccountsPayable.Visible = True
            cmdTransactionClearing.Visible = True
        Else
            cmdAccountsPayable.Visible = False
            cmdTransactionClearing.Visible = False
        End If
    End Sub
    Public Sub LoadPermission()
        ClearFields()
        LoadXgridLookupSearch("SELECT percode,permission as 'Select Permission',approver from tblpermissions", "tblpermissions", txtpermission, gv_permission, Me)
        gv_permission.Columns("percode").Visible = False
        gv_permission.Columns("approver").Visible = False
    End Sub
    Private Sub txtpermission_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpermission.EditValueChanged
        On Error Resume Next
        percode.Text = txtpermission.Properties.View.GetFocusedRowCellValue("percode").ToString()
        If percode.Text <> "" Then
            Load_Menu()
            LoadPermissionTemplate()
            cmdEditItem.Enabled = True
            cmdDelete.Enabled = True
        Else
            Load_Menu()
            cmdEditItem.Enabled = False
            cmdDelete.Enabled = False
        End If
    End Sub
    Public Sub LoadPermissionTemplate()
        On Error Resume Next
        com.CommandText = "select * from tblpermissionstemplate where percode='" & percode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            If rst("grouppermission").ToString = "rbnProcurement" And EnableModuleProcurement = True Then
                list_procurement.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnAccountsPayable" And EnableModuleProcurement = True Then
                list_AccountsPayable.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnInventory" And EnableModuleInventory = True Then
                list_inventory.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnProduct" Then
                list_product.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnSales" And EnableModuleSales = True Then
                list_sales.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnFuel" And EnableModuleFuel = True Then
                list_fuel.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnHotel" And EnableModuleHotel = True Then
                list_hotel.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnHumanResource" And EnableModuleHR = True Then
                list_hr.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnPayrollManagement" And EnableModulePayroll = True Then
                list_payroll.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnAccounting" And EnableAccounting = True Then
                list_accounting.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnPreference" And EnableModuleReportGen = True Then
                list_preference.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked

            ElseIf rst("grouppermission").ToString = "rbnSettings" Then
                list_settings.Items.Item(rst("menus").ToString).CheckState = CheckState.Checked
            End If
        End While
        rst.Close()

        com.CommandText = "select * from tblpermissionsclearing where percode='" & percode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            list_TransactionClearing.Items.Item(rst("tabname").ToString).CheckState = CheckState.Checked
        End While
        rst.Close()


    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Sub Load_Menu()
        Dim mCurrentItem As BarItem
        list_procurement.Items.Clear()
        list_AccountsPayable.Items.Clear()
        list_sales.Items.Clear()
        list_fuel.Items.Clear()
        list_hotel.Items.Clear()
        list_hr.Items.Clear()
        list_payroll.Items.Clear()
        list_inventory.Items.Clear()
        list_product.Items.Clear()
        list_accounting.Items.Clear()
        list_preference.Items.Clear()
        list_settings.Items.Clear()
        list_TransactionClearing.Items.Clear()
        For Each currentPage As RibbonPage In MdiCoffeeCup.MainMenu.Pages
            For Each currentGroup As RibbonPageGroup In currentPage.Groups
                For Each currenLink As BarItemLink In currentGroup.ItemLinks
                    mCurrentItem = currenLink.Item
                    If currentPage.Name = "rbnProcurement" And EnableModuleProcurement = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_procurement.Items.Add(mCurrentItem.Name, False)
                            list_procurement.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_procurement.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If
                    ElseIf currentPage.Name = "rbnAccountsPayable" And EnableModuleProcurement = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_AccountsPayable.Items.Add(mCurrentItem.Name, False)
                            list_AccountsPayable.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_AccountsPayable.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnInventory" And EnableModuleInventory = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_inventory.Items.Add(mCurrentItem.Name, False)
                            list_inventory.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_inventory.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnProduct" Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_product.Items.Add(mCurrentItem.Name, False)
                            list_product.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_product.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnSales" And EnableModuleSales = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_sales.Items.Add(mCurrentItem.Name, False)
                            list_sales.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_sales.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnFuel" And EnableModuleFuel = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_fuel.Items.Add(mCurrentItem.Name, False)
                            list_fuel.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_fuel.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnHotel" And EnableModuleHotel = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_hotel.Items.Add(mCurrentItem.Name, False)
                            list_hotel.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_hotel.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnHumanResource" And EnableModuleHR = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_hr.Items.Add(mCurrentItem.Name, False)
                            list_hr.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_hr.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnPayrollManagement" And EnableModulePayroll = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_payroll.Items.Add(mCurrentItem.Name, False)
                            list_payroll.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_payroll.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If


                    ElseIf currentPage.Name = "rbnAccounting" And EnableAccounting = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_accounting.Items.Add(mCurrentItem.Name, False)
                            list_accounting.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_accounting.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnPreference" And EnableModuleReportGen = True Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_preference.Items.Add(mCurrentItem.Name, False)
                            list_preference.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_preference.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    ElseIf currentPage.Name = "rbnSettings" Then
                        If mCurrentItem.Visibility = BarItemVisibility.Always Then
                            list_settings.Items.Add(mCurrentItem.Name, False)
                            list_settings.Items.Item(mCurrentItem.Name).Description = mCurrentItem.Caption
                            list_settings.Items.Item(mCurrentItem.Name).Value = mCurrentItem.Name
                        End If

                    End If
                Next currenLink
            Next currentGroup
        Next currentPage

        'Load tapages of all transaction clearing 
        For Each tb In frmTransactionClearing.XtraTabControl1.TabPages
            list_TransactionClearing.Items.Add(tb.Name.ToString, False)
            list_TransactionClearing.Items.Item(tb.Name.ToString).Description = tb.Text.ToString
            list_TransactionClearing.Items.Item(tb.Name.ToString).Value = tb.Name.ToString
        Next

    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        If txtpermission.Text = "" Then
            XtraMessageBox.Show("Please select Permission!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpermission.Focus()
            Exit Sub
        End If
        'PROCUREMENT
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        com.CommandText = "DELETE from tblpermissionstemplate where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblpermissionsclearing where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
        If list_procurement.CheckedItemsCount > 0 Then
            For n = 0 To list_procurement.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnProcurement', menus='" & list_procurement.Items.Item(list_procurement.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        If list_AccountsPayable.CheckedItemsCount > 0 Then
            For n = 0 To list_AccountsPayable.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnAccountsPayable', menus='" & list_procurement.Items.Item(list_procurement.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'INVENTORY
        If list_inventory.CheckedItemsCount > 0 Then
            For n = 0 To list_inventory.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnInventory', menus='" & list_inventory.Items.Item(list_inventory.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'FUEL
        If list_fuel.CheckedItemsCount > 0 Then
            For n = 0 To list_fuel.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnFuel', menus='" & list_fuel.Items.Item(list_fuel.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'Hotel
        If list_hotel.CheckedItemsCount > 0 Then
            For n = 0 To list_hotel.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnHotel', menus='" & list_hotel.Items.Item(list_hotel.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'Human Resource
        If list_hr.CheckedItemsCount > 0 Then
            For n = 0 To list_hr.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnHumanResource', menus='" & list_hr.Items.Item(list_hr.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'Payroll
        If list_payroll.CheckedItemsCount > 0 Then
            For n = 0 To list_payroll.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnPayrollManagement', menus='" & list_payroll.Items.Item(list_payroll.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'PRODUCT
        If list_product.CheckedItemsCount > 0 Then
            For n = 0 To list_product.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnProduct', menus='" & list_product.Items.Item(list_product.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'SALES
        If list_sales.CheckedItemsCount > 0 Then
            For n = 0 To list_sales.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnSales', menus='" & list_sales.Items.Item(list_sales.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'ACCOUNTING
        If list_accounting.CheckedItemsCount > 0 Then
            For n = 0 To list_accounting.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnAccounting', menus='" & list_accounting.Items.Item(list_accounting.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'REPORT
        If list_preference.CheckedItemsCount > 0 Then
            For n = 0 To list_preference.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnPreference', menus='" & list_preference.Items.Item(list_preference.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'SETTINGS
        If list_settings.CheckedItemsCount > 0 Then
            For n = 0 To list_settings.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionstemplate set percode='" & percode.Text & "',grouppermission='rbnSettings', menus='" & list_settings.Items.Item(list_settings.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        'TRANSACTION CLEARING
        If list_TransactionClearing.CheckedItemsCount > 0 Then
            For n = 0 To list_TransactionClearing.CheckedItems.Count - 1
                com.CommandText = "insert into tblpermissionsclearing set percode='" & percode.Text & "', tabname='" & list_TransactionClearing.Items.Item(list_TransactionClearing.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
            Next
        End If

        SplashScreenManager.CloseForm()
        XtraMessageBox.Show("Permission template Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If XtraTabControl1.SelectedTabPage Is tabProcurement Then
            For n = 0 To list_procurement.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_procurement.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabAccountsPayable Then
            For n = 0 To list_AccountsPayable.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_AccountsPayable.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabInventory Then
            For n = 0 To list_inventory.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_inventory.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabProduct Then
            For n = 0 To list_product.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_product.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabSales Then
            For n = 0 To list_sales.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_sales.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabFuel Then
            For n = 0 To list_fuel.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_fuel.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabHotel Then
            For n = 0 To list_hotel.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_hotel.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabHR Then
            For n = 0 To list_hr.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_hr.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabPayroll Then
            For n = 0 To list_payroll.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_payroll.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next

        ElseIf XtraTabControl1.SelectedTabPage Is TabAccounting Then
            For n = 0 To list_accounting.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_accounting.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabReports Then
            For n = 0 To list_preference.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_preference.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabSettings Then
            For n = 0 To list_settings.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_settings.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        ElseIf XtraTabControl1.SelectedTabPage Is tabTransactionClearing Then
            For n = 0 To list_TransactionClearing.ItemCount - 1
                If CheckEdit1.Checked = True Then
                    list_TransactionClearing.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblpermissions where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpermissionstemplate where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblpermissionsclearing where percode='" & percode.Text & "'" : com.ExecuteNonQuery()
            LoadPermission()
            XtraMessageBox.Show("Permission Successfully deleted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#Region "ACTION BUTTON"

    Private Sub cmdProcurement_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdProcurement.LinkClicked
        XtraTabControl1.SelectedTabPage = tabProcurement
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdAccountsPayable_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountsPayable.LinkClicked
        XtraTabControl1.SelectedTabPage = tabAccountsPayable
        CheckEdit1.Checked = False
    End Sub


    Private Sub cmdInventory_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdInventory.LinkClicked
        XtraTabControl1.SelectedTabPage = tabInventory
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdProduct_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdProduct.LinkClicked
        XtraTabControl1.SelectedTabPage = tabProduct
        CheckEdit1.Checked = False
    End Sub
    Private Sub cmdSalesManagement_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSales.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSales
        CheckEdit1.Checked = False
    End Sub
    Private Sub cmdFuelManagement_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdFuel.LinkClicked
        XtraTabControl1.SelectedTabPage = tabFuel
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdHotel_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHotel.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHotel
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdAccountingSystem_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAccountingSystem.LinkClicked
        XtraTabControl1.SelectedTabPage = TabAccounting
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdReports_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdPreference.LinkClicked
        XtraTabControl1.SelectedTabPage = tabReports
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdSettings_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSettings.LinkClicked
        XtraTabControl1.SelectedTabPage = tabSettings
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdHumanResource_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdHumanResource.LinkClicked
        XtraTabControl1.SelectedTabPage = tabHR
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdPayrollManagement_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdPayrollManagement.LinkClicked
        XtraTabControl1.SelectedTabPage = tabPayroll
        CheckEdit1.Checked = False
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdTransactionClearing.LinkClicked
        XtraTabControl1.SelectedTabPage = tabTransactionClearing
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click
        frmCoffeecupServerPermissionInfo.percode.Text = percode.Text
        frmCoffeecupServerPermissionInfo.Show(Me)
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        frmCoffeecupServerPermissionInfo.Show(Me)
    End Sub

#End Region

  
End Class