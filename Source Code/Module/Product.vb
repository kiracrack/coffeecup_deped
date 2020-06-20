Module Product
    Public Function EditProduct(ByVal productid As String, ByVal frm As Form)
        If GlobalProductTemplate = 1 Then
            frmProductTemplate1.mode.Text = ""
            frmProductTemplate1.productid.Text = productid
            frmProductTemplate1.mode.Text = "edit"
            frmProductTemplate1.Show(frm)

        End If
        Return True
    End Function

    Public Function AddProduct(ByVal AddFrom As String, ByVal frm As Form)
        If GlobalProductTemplate = 1 Then
            frmProductTemplate1.selfrom.Text = AddFrom
            frmProductTemplate1.Show(frm)
       
        End If
        Return 0
    End Function

    Public Sub UpdateDefaultProductInformation(ByVal mode As String, ByVal productid As String, ByVal catid As String, ByVal subcatid As String, ByVal itemname As String, ByVal codename As String, ByVal unit As String)
        Dim SqlQuery As String = "catid='" & catid & "',subcatid='" & subcatid & "',itemname='" & rchar(itemname) & "', codename='" & codename & "', unit='" & unit & "'"
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp " : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate2(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal itemname As String, ByVal unit As String, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal servicechargeitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal customproductorder As Boolean, ByVal requiredattendingpersonnel As Boolean, ByVal enableofficecenter As Boolean, ByVal officecenter As String, ByVal EnableCoupon As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',itemname='" & rchar(itemname) & "', unit='" & unit & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ",svchargeitem=" & servicechargeitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", customproductorder=" & customproductorder & ", requiredattendingpersonnel=" & requiredattendingpersonnel & ", enablecenter=" & enableofficecenter & ", officecenter='" & officecenter & "', enablecoupon=" & EnableCoupon & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "',salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & " "
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp " : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate3(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal itemname As String, ByVal partnumber As String, ByVal unit As String, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',itemname='" & rchar(itemname) & "',partnumber='" & rchar(partnumber) & "', unit='" & unit & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "',salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & ""
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & "  where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductTemplate4(ByVal mode As String, ByVal productid As String, ByVal barcode As String, ByVal catid As String, ByVal itemname As String, ByVal partnumber As String, ByVal unit As String, ByVal enablesell As Boolean, ByVal vatableitem As Boolean, ByVal forcontract As Boolean, ByVal menumakeritem As Boolean, ByVal servicemakeritem As Boolean, ByVal purchasedprice As Double, ByVal calcsellrate As Double, ByVal sellingprice As Double, ByVal sellingprice1 As Double, ByVal sellingprice2 As Double, ByVal sellingprice3 As Double, ByVal sellingprice4 As Double, ByVal salemode As String, ByVal allowinputdiscountedamount As Boolean)
        Dim SqlQuery As String = "barcode='" & barcode & "', catid='" & catid & "',itemname='" & rchar(itemname) & "',partnumber='" & rchar(partnumber) & "', unit='" & unit & "', enablesell=" & enablesell & ", vatableitem=" & vatableitem & ", forcontract=" & forcontract & ", menuitem=" & menumakeritem & ", servicemenuproduct=" & servicemakeritem & ", purchasedprice='" & Val(CC(purchasedprice)) & "', calcsellrate='" & Val(CC(calcsellrate)) & "', sellingprice='" & Val(CC(sellingprice)) & "', sellingprice1='" & Val(CC(sellingprice1)) & "', sellingprice2='" & Val(CC(sellingprice2)) & "', sellingprice3='" & Val(CC(sellingprice3)) & "', sellingprice4='" & Val(CC(sellingprice4)) & "', salemode='" & salemode & "', allowinputdiscountedamount=" & allowinputdiscountedamount & ""
        If mode = "edit" Then
            com.CommandText = "UPDATE tblglobalproducts set " & SqlQuery & " where productid='" & productid & "'" : com.ExecuteNonQuery()
            If enablesell = True And forcontract = True Then
                UpdateProductMenumakerService(productid, sellingprice)
            End If
        Else
            com.CommandText = "insert into tblglobalproducts set productid='" & productid & "', " & SqlQuery & ", entryby='" & globaluserid & "', dateentered=current_timestamp" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateProductMenumakerService(ByVal productid As String, ByVal amount As Double)
        com.CommandText = "update tblproductserviceitem set amount='" & amount & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
    End Sub
End Module
