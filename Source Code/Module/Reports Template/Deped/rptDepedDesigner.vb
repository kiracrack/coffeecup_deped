Public Class rptDepedDesigner
    Public Sub BindData()
        imgEdu.Image = Image.FromFile(Application.StartupPath.ToString & "\img\education.png")
        'imgDeped.Image = Image.FromFile(Application.StartupPath.ToString & "\img\deped.png")
        com.CommandText = "select *,if(sequenceno='',propertyno ,concat(propertyno,'-',sequenceno)) as propertynumber,(select DESCRIPTION from tblofficeequipmentmodel where code = tblofficeequipment.modelid) as model,(select officename from tblcompoffice where officeid=tblofficeequipment.officeid) as office, (select fullname from tblaccounts where accountid=tblofficeequipment.accountable) as acctname from tblofficeequipment where id='" & strMaNV & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAssetNumber.Text = rst("propertynumber").ToString
            txtItemName.Text = rst("productname").ToString
            txtModel.Text = "Model: " & rst("model").ToString
            txtSerial.Text = "Serial #: " & rst("serialnumber").ToString
            txtItemDescription.Text = rst("productdetails").ToString & Environment.NewLine _
                & "Date Acquired: " & CDate(rst("dateacquired").ToString).ToString("MM/dd/yyyy") & Environment.NewLine _
                & "Acquisition Cost: " + FormatNumber(Val(rst("totalcost").ToString), 2) & Environment.NewLine _
                & "Location: " + rst("office").ToString & Environment.NewLine _
                & "Accountable: " + rst("acctname").ToString

            barCode1.Text = rst("propertyno").ToString
        End While
        rst.Close()
    End Sub
End Class