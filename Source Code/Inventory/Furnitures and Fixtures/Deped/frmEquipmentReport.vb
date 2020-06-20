Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmEquipmentReport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        txtDateAcquired.EditValue = CDate(Now)
        LoadCategory()
        LoadOffice()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT catid, Description from tblprocategory where ffe=1", "tblprocategory", txtCategory, gridcategory, Me)
        gridcategory.Columns("catid").Visible = False
    End Sub
    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        catid.Text = txtCategory.Properties.View.GetFocusedRowCellValue("catid").ToString()

    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_inventory, Me)
        gv_inventory.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
      
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If ck_inventory.Checked = True And CheckEdit1.Checked = True Then
            GenerateByOfficeEquipmentDepedTemplate(ck_inventory.CheckState, If(txtTemplate.SelectedIndex = 0, True, False), CDate(txtDateAcquired.EditValue).ToString("MMMM dd, yyyy"), txtCategory.Text, officeid.Text, _
                                             "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as propertynumber, " _
              + " (select description from tblprocategory where catid=tblofficeequipment.catid) as category, " _
              + " (select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as 'officename', " _
              + " (select DESCRIPTION from tblprosubcategory where subcatid = tblofficeequipment.subcatid) as 'subcatname', " _
              + " (select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as model, " _
              + " (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as acctperson, " _
              + " date_format(dateacquired,'%Y-%m-%d') as tdacc from tblofficeequipment where dateacquired <= '" & ConvertDate(txtDateAcquired.EditValue) & "' and " _
              + " " & If(txtTemplate.SelectedIndex = 0, "unitcost<15000", "unitcost>=15000") & "  " _
              + " order by (select sequence from tblprocategory where catid=tblofficeequipment.catid) asc, " _
              + " (select DESCRIPTION from tblprosubcategory where subcatid = tblofficeequipment.subcatid) asc, " _
              + " productname asc, (select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) asc, unitcost desc, propertyno asc,  seriesno asc " _
              + " ", Me)
        Else
            GenerateByOfficeEquipmentDepedTemplate(ck_inventory.CheckState, If(txtTemplate.SelectedIndex = 0, True, False), CDate(txtDateAcquired.EditValue).ToString("MMMM dd, yyyy"), txtCategory.Text, officeid.Text, _
                                             "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as propertynumber, " _
              + " (select description from tblprocategory where catid=tblofficeequipment.catid) as category, " _
              + " (select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as 'officename', " _
              + " (select DESCRIPTION from tblprosubcategory where subcatid = tblofficeequipment.subcatid) as 'subcatname', " _
              + " (select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as model, " _
              + " (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as acctperson, " _
              + " date_format(dateacquired,'%Y-%m-%d') as tdacc from tblofficeequipment where dateacquired <= '" & ConvertDate(txtDateAcquired.EditValue) & "' and " _
              + " " & If(txtTemplate.SelectedIndex = 0, "unitcost<15000", "unitcost>=15000") & If(ck_inventory.Checked = True, "", " and officeid='" & officeid.Text & "' ") & If(CheckEdit1.Checked = True, "", "  and catid='" & catid.Text & "' ") & " " _
              + " order by (select sequence from tblprocategory where catid=tblofficeequipment.catid) asc, " _
              + " (select DESCRIPTION from tblprosubcategory where subcatid = tblofficeequipment.subcatid) asc, " _
              + " productname asc, (select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) asc, unitcost desc, propertyno asc,  seriesno asc " _
              + " ", Me)
        End If
        
    End Sub

    Private Sub ck_inventory_CheckedChanged(sender As Object, e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
            officeid.Text = ""
        Else
            LoadOffice()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtCategory.Enabled = False
            txtCategory.Properties.DataSource = False
            txtCategory.Text = ""
            catid.Text = ""
        Else
            LoadCategory()
            txtCategory.Enabled = True
        End If
    End Sub
End Class