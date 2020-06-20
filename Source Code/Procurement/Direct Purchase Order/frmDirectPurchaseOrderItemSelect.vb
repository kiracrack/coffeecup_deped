Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Skins

Public Class frmDirectPurchaseOrderItemSelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Control) + Keys.Enter Then
            cmdaction.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
  
    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If mode.Text <> "edit" Then
            id.Text = getGlobalTrnid(GlobalOrganizationCode, globaluserid)
            txtquan.Text = "1"
        End If
        txtquan.Focus()
        loadPOdetails()

    End Sub
  
    Private Sub g_product_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
        Dim View As GridView = sender
        If gen_filterappearance = True Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Accountable Person"))
            If status = "Not assigned yet" Then
                If e.Column.Name = "colAccountablePerson" Then
                    e.Appearance.ForeColor = Color.Red
                End If

            End If
        End If
    End Sub
   
    Public Sub loadPOdetails()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as '" & GlobalOfficeCaption & "', (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST' from tblrequisitions where PID='" & ponumber.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
        End While
        rst.Close()
    End Sub
   
    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquan.GotFocus
        txtquan.SelectionStart = 0
        txtquan.SelectionLength = Len(txtquan.Text)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If Val(CC(txtquan.Text)) <= 0 Then
            XtraMessageBox.Show("Quantity missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        
        ElseIf txtunit.Text = "" Then
            XtraMessageBox.Show("Please select unit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunit.Focus()
            Exit Sub

        ElseIf txtsti.Text = "" Then
            XtraMessageBox.Show("Estimate Cost missing entry!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsti.Focus()
            Exit Sub
        End If

        If Val(CC(txtsti.Text)) <> Val(CC(tempCost.Text)) Then
            If XtraMessageBox.Show("System detected current price of a product has been changed!" & vbNewLine & "Do you want to update the product database record of the current price? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If countqry("tblitemvendor", " itemid='" & proid.Text & "' and vendorid = '" & vendorid.Text & "'") = 0 Then
                    com.CommandText = "INSERT INTO tblitemvendor set itemid='" & proid.Text & "', vendorid = '" & vendorid.Text & "', unit='" & txtunit.Text & "', officeid='" & officeid.Text & "', procost='" & Val(CC(txtsti.Text)) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblitemvendor set unit='" & txtunit.Text & "', procost='" & Val(CC(txtsti.Text)) & "', officeid='" & officeid.Text & "', lastupdate=current_timestamp where itemid='" & proid.Text & "' and vendorid = '" & vendorid.Text & "'" : com.ExecuteNonQuery()
                End If
                frmDirectPurchaseOrderItem.filterItem()
            End If
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblpurchaseorderitem set quantity='" & Val(CC(txtquan.Text)) & "',itemname='" & rchar(txtItemname.Text) & "', " _
                                                  + " vendorid='" & vendorid.Text & "', " _
                                                  + " UNIT='" & txtunit.Text & "', " _
                                                  + " COST='" & Val(CC(txtsti.Text)) & "', " _
                                                  + " TOTAL='" & Val(CC(txttotal.Text)) & "', " _
                                                  + " remarks='" & If(txtremarks.Text = "Remarks (Optional)", "", rchar(txtremarks.Text)) & "' where trnid='" & trnid.Text & "'"
            com.ExecuteNonQuery()
            frmDirectCreatePurchaseOrder.filterCurrentPO()
        Else
            com.CommandText = "insert into tblpurchaseorderitem set requestref='direct-po', ponumber='" & ponumber.Text & "', itemname='" & rchar(txtItemname.Text) & "'," _
                                                   + " PRODUCTID='" & proid.Text & "', " _
                                                   + " CATID='" & catid.Text & "', " _
                                                   + " officeid='" & officeid.Text & "', " _
                                                   + " vendorid='" & vendorid.Text & "', " _
                                                   + " UNIT='" & txtunit.Text & "', " _
                                                   + " QUANTITY='" & Val(CC(txtquan.Text)) & "', " _
                                                   + " COST='" & Val(CC(txtsti.Text)) & "', " _
                                                   + " TOTAL='" & Val(CC(txttotal.Text)) & "', " _
                                                   + " remarks='" & If(txtremarks.Text = "Remarks (Optional)", "", rchar(txtremarks.Text)) & "',trnby='" & globaluserid & "',datetrn=current_timestamp"
            com.ExecuteNonQuery()
            frmDirectCreatePurchaseOrder.filterCurrentPO()
        End If
        txtquan.Focus()
        frmDirectPurchaseOrderItem.txtfilter.SelectAll()
        frmDirectPurchaseOrderItem.txtfilter.Focus()
        mode.Text = ""
        Me.Close()
    End Sub

    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = CC(txtquan.Text)
        stm = CC(txtsti.Text)
        ttl = Val(quan) * Val(stm)
        txttotal.Text = Format(ttl, "n")
    End Sub

    Private Sub proid_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proid.EditValueChanged
        showProductInformation()
    End Sub

    Public Sub showProductInformation()
        If proid.Text = "" Then Exit Sub
        If mode.Text = "edit" Then
            com.CommandText = "select * from tblpurchaseorderitem where trnid='" & trnid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                catid.Text = rst("catid").ToString
                vendorid.Text = rst("vendorid").ToString
                txtquan.Text = rst("quantity").ToString
                txtunit.Text = rst("unit").ToString
                txtremarks.Text = rst("remarks").ToString
                txtsti.Text = Format(Val(rst("cost")), "n")
                tempCost.Text = rst("cost").ToString
            End While
            rst.Close()
        Else
            com.CommandText = "select * from tblglobalproducts where productid='" & proid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                catid.Text = rst("catid").ToString
                txtunit.Text = rst("unit").ToString
            End While
            rst.Close()
            com.CommandText = "select * from tblitemvendor where itemid='" & proid.Text & "' and vendorid='" & vendorid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtsti.Text = Format(Val(rst("procost")), "n")
                tempCost.Text = rst("procost").ToString
            End While
            rst.Close()

        End If
    End Sub

    Private Sub txtquan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquan.EditValueChanged
        calctotal()
    End Sub

    Private Sub txtsti_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsti.EditValueChanged
        calctotal()
    End Sub
End Class