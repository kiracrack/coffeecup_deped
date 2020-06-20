Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetStockHouse
    Private cost
    Private total
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        loadStockHouse()
        showProductinfo()
        LoadGridviewAppearance(gv_stockhouse)
    End Sub

    Public Sub loadStockHouse()
        LoadXgridLookupSearch("SELECT stockhouseid, stockhousename as 'Select Stock House' from tblstockhouse where officeid='" & officeid.Text & "'", "tblaccounts", txtStockHouse, gv_stockhouse, Me)
        gv_stockhouse.Columns("stockhouseid").Visible = False
    End Sub
    Private Sub txtStockHouse_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockHouse.EditValueChanged
        On Error Resume Next
        stockhouseid.Text = txtStockHouse.Properties.View.GetFocusedRowCellValue("stockhouseid").ToString()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Val(CC(txtquantity.Text)) < 0 And ckDevideQuantity.Checked = True Then
            XtraMessageBox.Show("Please enter quantity!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) And ckDevideQuantity.Checked = True Then
            XtraMessageBox.Show("Maximum quantity is " & txtAvailableQuantity.Text & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf txtDetails.Text = "" And ckDevideQuantity.Checked = True And inventorytype.Text = "cffe" Then
            XtraMessageBox.Show("Please provide remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        ElseIf txtStockHouse.Text = "" And ckDevideQuantity.Checked = False And inventorytype.Text = "cffe" Then
            XtraMessageBox.Show("Please select stock house!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to Continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If inventorytype.Text = "cffe" Then

                Dim strstockhouse As String = ""
                If stockhouseid.Text = "" Then
                    strstockhouse = "default"
                Else
                    strstockhouse = stockhouseid.Text
                End If

                If ckDevideQuantity.Checked = True Then
                    '#update selected ffe as history
                    com.CommandText = "insert into tblinventoryffe (ffecode,ponumber,productid,catid,quantity,unit,cost,total,vendorid,officeid,stockhouseid,remarks,datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,trnby,datetrn,actived,history) " _
                            + " select ffecode,ponumber,productid,catid,quantity,unit,cost,total,vendorid,officeid,stockhouseid,remarks,datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,trnby,datetrn,actived,1 from tblinventoryffe where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

                    '#add new copy devided ffe inventory
                    com.CommandText = "insert into tblinventoryffe (ffecode,ponumber,productid,catid,quantity,unit,cost,total,vendorid,officeid,stockhouseid,remarks,datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,trnby,datetrn,actived,history) " _
                            + " select ffecode,ponumber,productid,catid,'" & Val(CC(txtquantity.Text)) & "',unit,cost,'" & Val(CC(txtDevidedAmount.Text)) & "',vendorid,officeid,'" & strstockhouse & "','" & rchar(txtDetails.Text) & "',datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,'" & globaluserid & "',current_timestamp,actived,0 from tblinventoryffe where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

                    '#update selected ffe inventory
                    com.CommandText = "update tblinventoryffe set quantity=quantity-" & Val(CC(txtquantity.Text)) & ",total=total-" & Val(CC(txtDevidedAmount.Text)) & ", trnby='" & globaluserid & "',datetrn=current_timestamp where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
                    frmInventoryFFESummary.filterInventory()
                    XtraMessageBox.Show("Item Successfully Saved!!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    '#update selected ffe as history
                    com.CommandText = "update tblinventoryffe set history=1 where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

                    '#add new copy devided ffe inventory
                    com.CommandText = "insert into tblinventoryffe (ffecode,ponumber,productid,catid,quantity,unit,cost,total,vendorid,officeid,stockhouseid,remarks,datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,trnby,datetrn,actived,history) " _
                            + " select ffecode,ponumber,productid,catid,quantity,unit,cost,total,vendorid,officeid,'" & strstockhouse & "','" & rchar(txtDetails.Text) & "',datepurchased,depreciationmode,depreciationvalue,depreciationtype,age,bookvalue,'" & globaluserid & "',current_timestamp,actived,0 from tblinventoryffe where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
                    frmInventoryFFESummary.filterInventory()
                    XtraMessageBox.Show("Item Successfully saved to stock house " & StrConv(txtStockHouse.Text, vbProperCase) & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Else
                If ckDevideQuantity.Checked = True Then
                    com.CommandText = "insert into tblinventory (officeid,stockhouseid,catid,productname,categoryname,productid,quantity,unit,purchasedprice,sellingprice,income,lastupdate,lasttrnby,dateinventory) " _
                            + " select officeid,'" & stockhouseid.Text & "',catid,(select itemname from tblglobalproducts where productid=tblinventory.productid), (select description from tblprocategory where catid = tblinventory.catid),productid,'" & Val(CC(txtquantity.Text)) & "',unit,'" & Val(CC(txtcost.Text)) & "',sellingprice,0,current_timestamp, '" & globaluserid & "',current_timestamp from tblinventory where trnid='" & refcode.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblinventory set quantity=quantity-" & Val(CC(txtquantity.Text)) & ",lasttrnby='" & globaluserid & "', lastupdate=current_timestamp where trnid='" & refcode.Text & "'" : com.ExecuteNonQuery()
                    frmInventoryConsumables.FilterInventoryReports()
                    XtraMessageBox.Show("Item Successfully devided to stock house " & StrConv(txtStockHouse.Text, vbProperCase) & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    If txtStockHouse.Text = "" Then
                        XtraMessageBox.Show("Please select stock house!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtStockHouse.Focus()
                        Exit Sub
                    End If
                    com.CommandText = "update tblinventory set stockhouseid='" & stockhouseid.Text & "',lasttrnby='" & globaluserid & "',lastupdate=current_timestamp where trnid='" & refcode.Text & "'" : com.ExecuteNonQuery()
                    frmInventoryConsumables.FilterInventoryReports()
                    XtraMessageBox.Show("Item Successfully saved to stock house " & StrConv(txtStockHouse.Text, vbProperCase) & "!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ckDevideQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles ckDevideQuantity.CheckedChanged
        If ckDevideQuantity.Checked = True Then
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
            txtquantity.Properties.ReadOnly = False
        Else
            txtquantity.Properties.Appearance.BackColor = Color.White
            txtquantity.Properties.Appearance.ForeColor = Color.Black
            txtquantity.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub txtquan_EditValueChanged(sender As Object, e As EventArgs) Handles txtquantity.EditValueChanged
        If txtquantity.Text = "" Or Val(CC(txtquantity.Text)) < 1 Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        Else
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
        End If
        CalCulator()
    End Sub
    Public Sub CalCulator()
        txtDevidedAmount.Text = Format(Val(CC(txtcost.Text)) * Val(CC(txtquantity.Text)), "n")
    End Sub
    Public Sub showProductinfo()
        If inventorytype.Text = "cffe" Then
            txtInventory.Text = "CFFE INVENTORY"
            txtDetails.Properties.ReadOnly = False
            com.CommandText = "select * from tblinventoryffe where id='" & trnid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtquantity.Text = rst("quantity").ToString
                txtAvailableQuantity.Text = rst("quantity").ToString
                txtcost.Text = rst("cost").ToString
            End While
            rst.Close()
        Else
            txtInventory.Text = "CONSUMABLE INVENTORY"
            txtDetails.Properties.ReadOnly = True
            com.CommandText = "select * from tblinventory where trnid='" & refcode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtquantity.Text = rst("quantity").ToString
                txtAvailableQuantity.Text = rst("quantity").ToString
                txtcost.Text = rst("purchasedprice").ToString
            End While
            rst.Close()
        End If
    End Sub
End Class