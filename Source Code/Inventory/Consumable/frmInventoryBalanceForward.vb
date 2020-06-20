Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Public Class frmInventoryBalanceForward
   
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub frmShiftSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadData()
        LoadTemporaryData()
    End Sub

    Public Sub SaveTemporaryData()
        If System.IO.File.Exists(Application.StartupPath.ToString & "\BeginningBalance.txt") = True Then
            System.IO.File.Delete(Application.StartupPath.ToString & "\BeginningBalance.txt")
        End If
        Dim details As String = ""
        ProgressBarControl1.Properties.Maximum = GridView1.RowCount
        For I = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(I, "Beggining Balance").ToString > 0 Then
                details += GridView1.GetRowCellValue(I, "productid").ToString & "|" & GridView1.GetRowCellValue(I, "Barcode").ToString & "|" & GridView1.GetRowCellValue(I, "Product Name").ToString & "|" & GridView1.GetRowCellValue(I, "Unit").ToString & "|" & Val(CC(GridView1.GetRowCellValue(I, "Beggining Balance").ToString)) & "|" & Val(CC(GridView1.GetRowCellValue(I, "Unit Cost").ToString)) & "|" & Val(CC(GridView1.GetRowCellValue(I, "Enter Sales By Amount").ToString)) & "|" & vbLf
            End If
            ProgressBarControl1.EditValue = I
            ProgressBarControl1.Update()
        Next

        Dim detailsFile = Nothing
        detailsFile = New StreamWriter(Application.StartupPath.ToString & "\BeginningBalance.txt", True)
        detailsFile.WriteLine(details)
        detailsFile.Close()
        MessageBox.Show("Connection Successfully Save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub LoadTemporaryData()
        Dim a As String = ""
        If System.IO.File.Exists(Application.StartupPath.ToString & "\BeginningBalance.txt") = True Then
            For I = 0 To GridView1.RowCount - 1
                For Each strLine As String In ReadFile(Application.StartupPath.ToString & "\BeginningBalance.txt").Split(vbLf)
                    If strLine <> "" Then
                        Dim word As String() = strLine.Split("|")
                        If GridView1.GetRowCellValue(I, "productid").ToString = word(0) Then
                            GridView1.SetRowCellValue(I, "Beggining Balance", word(4))
                            GridView1.SetRowCellValue(I, "Unit Cost", word(5))
                            GridView1.SetRowCellValue(I, "Enter Sales By Amount", word(6))
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Public Function ReadFile(ByVal path As String) As String
        Me.Cursor = Cursors.WaitCursor
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        ReadFile = oReader.ReadToEnd
        Me.Cursor = Cursors.Default
        Return ReadFile
    End Function

    Public Sub LoadData()
        LoadXgrid("select productid,barcode as 'Barcode', itemname as 'Product Name',Unit,0 as 'Beggining Balance', 0 as 'Unit Cost', if(salemode='esba',1,0) as 'Enter Sales By Amount' from tblglobalproducts where catid in (select catid from tblprocategory where consumable=1) order by itemname asc", "tblglobalproducts", Em, GridView1, Me)
        XgridHideColumn({"productid"}, GridView1)
        XgridColWidth({"Product Name"}, GridView1, 250)
        XgridColCurrency({"Unit Cost"}, GridView1)
        XgridColNumber("Beggining Balance", GridView1)
        XgridColAlign({"Unit", "Beggining Balance"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgriDisableColumn({"productid", "Unit", "Barcode", "Product Name"}, GridView1)

        Dim edit As RepositoryItemCheckEdit = New RepositoryItemCheckEdit()
        Dim trueValue As Int64 = 1
        Dim falseValue As Int64 = 0
        edit.ValueChecked = trueValue
        edit.ValueUnchecked = falseValue
        GridView1.Columns("Enter Sales By Amount").ColumnEdit = edit
    End Sub

    Private Sub OverideAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverideAttendanceToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to upload beginning inventory?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblinventory" : com.ExecuteNonQuery()
            com.CommandText = "ALTER TABLE `tblinventory` AUTO_INCREMENT = 1;" : com.ExecuteNonQuery()

            com.CommandText = "delete from tblinventoryledger" : com.ExecuteNonQuery()
            com.CommandText = "ALTER TABLE `tblinventoryledger` AUTO_INCREMENT = 1;" : com.ExecuteNonQuery()
            ProgressBarControl1.Properties.Maximum = GridView1.RowCount
            For I = 0 To GridView1.RowCount - 1
                com.CommandText = "update tblglobalproducts set barcode='" & GridView1.GetRowCellValue(I, "Barcode").ToString & "',itemname='" & rchar(UCase(GridView1.GetRowCellValue(I, "Product Name").ToString)) & "',purchasedprice='" & Val(CC(GridView1.GetRowCellValue(I, "Unit Cost").ToString)) & "' where productid='" & GridView1.GetRowCellValue(I, "productid").ToString & "'" : com.ExecuteNonQuery()
                If Val(CC(GridView1.GetRowCellValue(I, "Beggining Balance").ToString)) > 0 Then
                    UpdateInventory("Beg Balance", "", globalofficeid, AppBeginvendorId, "", GridView1.GetRowCellValue(I, "productid").ToString, Val(CC(GridView1.GetRowCellValue(I, "Beggining Balance").ToString)), Val(CC(GridView1.GetRowCellValue(I, "Unit Cost").ToString)), "bal forward", "", "", Now)
                End If
                ProgressBarControl1.EditValue = I
                ProgressBarControl1.Update()
            Next
            XtraMessageBox.Show("Inventory successfully uploaded", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        SaveTemporaryData()
    End Sub
End Class