Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomRate1
    Private BandgridView As GridView
    Private BandChild As GridView
    Private BandExtraperson As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(gridRoomType)
        LoadGridviewAppearance(GridView1)
        LoadGridviewAppearance(gridAdult)
        LoadGridviewAppearance(gridChild)
        LoadGridviewAppearance(gridExtraperson)
        LoadGridviewAppearance(gridExtraNight)
        LoadRoomType()
        LoadRoomRates()
        LoadExtraNightPackage()
        LoadAdultPackage()
        LoadChildPackage()
        LoadExtraPersonPackage()
    End Sub

    Public Sub LoadExtraNightPackage()
        LoadXgridLookupSearch("select productid, itemname as 'Item Name',sellingprice as Amount from tblglobalproducts where servicemenuproduct=1 and deleted=0", "tblglobalproducts", txtExtraNight, gridExtraNight, Me)
        gridExtraNight.Columns("productid").Visible = False
        XgridColCurrency({"Amount"}, gridExtraNight)
    End Sub

    Private Sub txtExtraNight_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtraNight.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtExtraNight.Properties.View.FocusedRowHandle.ToString)
        extraNight.Text = txtExtraNight.Properties.View.GetFocusedRowCellValue("productid").ToString()

    End Sub

    Public Sub LoadAdultPackage()
        LoadXgridLookupSearch("select productid, itemname as 'Item Name',sellingprice as Amount from tblglobalproducts where servicemenuproduct=1 and deleted=0", "tblglobalproducts", txtAdultPackage, gridAdult, Me)
        gridAdult.Columns("productid").Visible = False
        XgridColCurrency({"Amount"}, gridAdult)
    End Sub

    Private Sub txtAdultPackage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdultPackage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtAdultPackage.Properties.View.FocusedRowHandle.ToString)
        packageadult.Text = txtAdultPackage.Properties.View.GetFocusedRowCellValue("productid").ToString()
        txtAmount.Text = txtAdultPackage.Properties.View.GetFocusedRowCellValue("Amount").ToString()
    End Sub

    Public Sub LoadChildPackage()
        LoadXgridLookupSearch("select productid, itemname as 'Item Name',sellingprice as Amount from tblglobalproducts where servicemenuproduct=1 and deleted=0", "tblglobalproducts", txtChildPackage, gridChild, Me)
        gridChild.Columns("productid").Visible = False
        XgridColCurrency({"Amount"}, gridChild)
    End Sub

    Private Sub txtChildPackage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChildPackage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtChildPackage.Properties.View.FocusedRowHandle.ToString)
        packagechild.Text = txtChildPackage.Properties.View.GetFocusedRowCellValue("productid").ToString()

    End Sub

    Public Sub LoadExtraPersonPackage()
        LoadXgridLookupSearch("select productid, itemname as 'Item Name',sellingprice as Amount from tblglobalproducts where servicemenuproduct=1 and deleted=0", "tblglobalproducts", txtExtraPerson, gridExtraperson, Me)
        gridExtraperson.Columns("productid").Visible = False
        XgridColCurrency({"Amount"}, gridExtraperson)
    End Sub

    Private Sub txtExtraPerson_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtraPerson.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtExtraPerson.Properties.View.FocusedRowHandle.ToString)
        packageExtraperson.Text = txtExtraPerson.Properties.View.GetFocusedRowCellValue("productid").ToString()

    End Sub
    Public Sub LoadRoomType()
        LoadXgridLookupEdit("select code, Description from tblhotelroomtype where hotelcif='" & hotelcif.Text & "'", "tblhotelroomtype", txtRoomType, gridRoomType, Me)
        gridRoomType.Columns("code").Visible = False
    End Sub
    Private Sub txtRoomType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRoomType.Properties.View.FocusedRowHandle.ToString)
        typecode.Text = txtRoomType.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadRoomRates()
    End Sub

    Public Sub LoadRoomRates()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select id, adultpackageid,childppackageid, (select itemname from tblglobalproducts where productid=tblhotelroomrates.adultpackageid) as 'Room Rate Package', Amount as 'Room rate', " _
                    + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.extranightpackageid)  as 'Extra Night', (select ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice) from tblglobalproducts where productid=tblhotelroomrates.extranightpackageid) as 'Extra Night Rate', " _
                    + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.childppackageid) as 'Child Package',  (select ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice) from tblglobalproducts where productid=tblhotelroomrates.childppackageid) as 'Child Rate', " _
                    + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.extrapersonpackageid) as 'Extra Person Package',  (select ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice) from tblglobalproducts where productid=tblhotelroomrates.extrapersonpackageid) as 'Extra Person Rate'," _
                    + " Actived  from tblhotelroomrates where roomtype='" & typecode.Text & "'", "tblhotelroomrates", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblhotelroomrates")
        GridView1.Columns("id").Visible = False
        GridView1.Columns("adultpackageid").Visible = False
        XgridHideColumn({"id", "adultpackageid", "childppackageid"}, GridView1)
        XgridColCurrency({"Room rate", "Room Profit", "Extra Night Rate", "Child Rate", "Extra Person Rate"}, GridView1)

        '############## Band Gridview #####################
        msda = New MySqlDataAdapter("select source_productid as 'adultpackageid', (select itemname from tblglobalproducts where productid=tblproductserviceitem.productid) as 'Item Name', Amount  from tblproductserviceitem", conn)
        msda.Fill(dst, "tblproductserviceitem")

        BandgridView = New GridView(Em)
        LoadGridviewAppearance(BandgridView)
        Dim keyColumn As DataColumn = dst.Tables("tblhotelroomrates").Columns("adultpackageid")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblproductserviceitem").Columns("adultpackageid")

        dst.Relations.Add("RoomRatePackageBreakdown", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("RoomRatePackageBreakdown", BandgridView)

        Em.DataSource = dst.Tables("tblhotelroomrates")


        BandgridView.PopulateColumns(dst.Tables("tblproductserviceitem"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"adultpackageid"}, BandgridView)
        XgridColCurrency({"Amount"}, BandgridView)
        XgridGeneralSummaryCurrency({"Amount"}, BandgridView)

        ''############## Band Gridview #####################
        'msda = New MySqlDataAdapter("select source_productid as 'childppackageid', (select itemname from tblglobalproducts where productid=tblproductserviceitem.productid) as 'Item Name', Amount  from tblproductserviceitem", conn)
        'msda.Fill(dst, "tblproductserviceitem")

        'BandChild = New GridView(Em)
        'LoadGridviewAppearance(BandChild)
        'Dim keyColumn2 As DataColumn = dst.Tables("tblhotelroomrates").Columns("childppackageid")
        'Dim foreignKeyColumn3 As DataColumn = dst.Tables("tblproductserviceitem").Columns("childppackageid")

        'dst.Relations.Add("ChildPackageBreakdown", keyColumn, foreignKeyColumn3)
        'Em.LevelTree.Nodes.Add("ChildPackageBreakdown", BandChild)

        'Em.DataSource = dst.Tables("tblhotelroomrates")


        'BandChild.PopulateColumns(dst.Tables("tblproductserviceitem"))
        'BandChild.BestFitColumns()
        'BandChild.OptionsView.ColumnAutoWidth = False
        'BandChild.OptionsView.RowAutoHeight = False
        'BandChild.OptionsCustomization.AllowGroup = False
        'BandChild.OptionsView.ShowGroupPanel = False
        'BandChild.OptionsBehavior.Editable = False
        'XgridHideColumn({"childppackageid"}, BandChild)
        'XgridColCurrency({"Amount"}, BandChild)
        'XgridGeneralSummaryCurrency({"Amount"}, BandChild)
    End Sub

    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtRoomType.Text = "" Then
                MessageBox.Show("Please select room type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomType.Focus()
                Exit Sub
            ElseIf txtAdultPackage.Text = "" Then
                MessageBox.Show("Please select adult package", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAdultPackage.Focus()
                Exit Sub
            ElseIf ckChild.Checked = True And txtChildPackage.Text = "" Then
                MessageBox.Show("Please select child package", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtChildPackage.Focus()
                Exit Sub
            ElseIf ckEntraperson.Checked = True And txtExtraPerson.Text = "" Then
                MessageBox.Show("Please select extra person package", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtExtraPerson.Focus()
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If mode.Text = "edit" Then
                    com.CommandText = "UPDATE tblhotelroomrates set roomtype='" & typecode.Text & "', amount='" & Val(CC(txtAmount.Text)) & "',  adultpackageid='" & packageadult.Text & "',enableextranightpackage='" & ckEnableExtraNight.CheckState & "', extranightpackageid='" & extraNight.Text & "', enablechildpackage=" & ckChild.CheckState & ",childppackageid='" & packagechild.Text & "',enablextrapersonpackage=" & ckEntraperson.CheckState & ",extrapersonpackageid='" & packageExtraperson.Text & "', actived=" & ckActived.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "Insert into tblhotelroomrates set roomtype='" & typecode.Text & "', amount='" & Val(CC(txtAmount.Text)) & "',  adultpackageid='" & packageadult.Text & "',enableextranightpackage='" & ckEnableExtraNight.CheckState & "', extranightpackageid='" & extraNight.Text & "', enablechildpackage=" & ckChild.CheckState & ",childppackageid='" & packagechild.Text & "',enablextrapersonpackage=" & ckEntraperson.CheckState & ",extrapersonpackageid='" & packageExtraperson.Text & "', actived=" & ckActived.CheckState & "" : com.ExecuteNonQuery()
                End If
                If XtraMessageBox.Show("Are you sure you want to add new package?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    ClearInputs()
                Else
                    MessageBox.Show("Room Rate successfully save", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                LoadRoomRates()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClearInputs()
        mode.Text = "" : id.Text = ""
        txtAdultPackage.Enabled = True
        txtAdultPackage.Properties.DataSource = Nothing
        txtAdultPackage.Text = ""
        packageadult.Text = ""
        LoadAdultPackage()

        txtChildPackage.Enabled = True
        txtChildPackage.Properties.DataSource = Nothing
        txtChildPackage.Text = ""
        packagechild.Text = ""
        LoadChildPackage()

        txtExtraPerson.Enabled = True
        txtExtraPerson.Properties.DataSource = Nothing
        txtExtraPerson.Text = ""
        LoadExtraPersonPackage()
        packageExtraperson.Text = ""
        ckActived.Checked = True
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblhotelroomrates where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadRoomRates()
            XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        Dim extra_night As Boolean = False : Dim child As Boolean = False : Dim extra As Boolean = False
        Dim strAdult As String = "" : Dim strextraNight As String = "" : Dim strchild As String = "" : Dim strExtra As String = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblhotelroomrates.adultpackageid) as adult, " _
                        + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.extranightpackageid) as extranight, " _
                        + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.childppackageid) as child, " _
                        + " (select itemname from tblglobalproducts where productid=tblhotelroomrates.extrapersonpackageid) as extra from tblhotelroomrates where id='" & id.Text & "'  " : rst = com.ExecuteReader
        While rst.Read
            txtAmount.Text = rst("amount").ToString
            packageadult.Text = rst("adultpackageid").ToString

            extra_night = rst("enableextranightpackage")
            extraNight.Text = rst("extranightpackageid").ToString
            strextraNight = rst("extranight").ToString

            strAdult = rst("adult").ToString

            child = rst("enablechildpackage")
            strchild = rst("child").ToString
            packagechild.Text = rst("childppackageid").ToString

            extra = rst("enablextrapersonpackage")
            strExtra = rst("extra").ToString
            packageExtraperson.Text = rst("extrapersonpackageid").ToString

            ckActived.Checked = rst("actived")
        End While
        rst.Close()
        ckEnableExtraNight.Checked = extra_night
        If ckEnableExtraNight.Checked = True Then
            txtExtraNight.Enabled = True
        Else
            txtExtraNight.Enabled = False
        End If

        ckChild.Checked = child
        If ckChild.Checked = True Then
            txtExtraPerson.Enabled = True
        Else
            txtExtraPerson.Enabled = False
        End If

        ckEntraperson.Checked = extra
        If ckEntraperson.Checked = True Then
            txtExtraPerson.Enabled = True
        Else
            txtExtraPerson.Enabled = False
        End If
        txtAdultPackage.Text = strAdult
        txtExtraNight.Text = strextraNight
        txtChildPackage.Text = strchild
        txtExtraPerson.Text = strExtra
        mode.Text = "edit"
    End Sub

    'Private Sub BreakdownConfigationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreakdownConfigationToolStripMenuItem.Click
    '    frmHotelRoomRateBreakDown.roomtype.Text = typecode.Text
    '    frmHotelRoomRateBreakDown.roomrateid.Text = GridView1.GetFocusedRowCellValue("id").ToString
    '    If frmHotelPackageItem.Visible = True Then
    '        frmHotelPackageItem.Focus()
    '    Else
    '        frmHotelPackageItem.Show(Me)
    '    End If
    'End Sub


    Private Sub ckEnableExtraNight_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableExtraNight.CheckedChanged
        If ckEnableExtraNight.Checked = True Then
            txtExtraNight.Enabled = True
            txtExtraNight.Properties.DataSource = Nothing
            txtExtraNight.Text = ""
            LoadExtraNightPackage()
        Else
            txtExtraNight.Enabled = False
            extraNight.Text = ""
        End If
    End Sub



    Private Sub ckChild_CheckedChanged(sender As Object, e As EventArgs) Handles ckChild.CheckedChanged
        If ckChild.Checked = True Then
            txtChildPackage.Enabled = True
            txtChildPackage.Properties.DataSource = Nothing
            txtChildPackage.Text = ""
            LoadChildPackage()
        Else
            txtChildPackage.Enabled = False
            packagechild.Text = ""
        End If
    End Sub


    Private Sub ckEntraperson_CheckedChanged(sender As Object, e As EventArgs) Handles ckEntraperson.CheckedChanged
        If ckEntraperson.Checked = True Then
            txtExtraPerson.Enabled = True
            txtExtraPerson.Properties.DataSource = Nothing
            txtExtraPerson.Text = ""
            LoadExtraPersonPackage()
        Else
            txtExtraPerson.Enabled = False
            packageExtraperson.Text = ""
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadRoomRates()
    End Sub

End Class