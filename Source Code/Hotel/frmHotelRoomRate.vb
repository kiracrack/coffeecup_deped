Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomRate
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
        LoadGridviewAppearance(GridView2)
        LoadRoomType()
        LoadBreakdown()
    End Sub

    Public Sub LoadRoomType()
        LoadXgridLookupEdit("select code, Description from tblhotelroomtype where hotelcif='" & hotelcif.Text & "'", "tblhotelroomtype", txtRoomType, gridRoomType, Me)
        gridRoomType.Columns("code").Visible = False
    End Sub
    Private Sub txtRoomType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomType.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRoomType.Properties.View.FocusedRowHandle.ToString)
        typecode.Text = txtRoomType.Properties.View.GetFocusedRowCellValue("code").ToString()
        LoadPackages()
        Em.Focus()
        LoadBreakdown()
    End Sub
    Public Sub LoadPackages()
        LoadXgrid("select ratecode as Code, Description, allowzerorate as 'Allow Zero Rate', Actived, lockrate as 'Lock Rate' from tblhotelroomrates where roomtype='" & typecode.Text & "' and temporaryrate=0 ", "tblhotelroomrates", Em, GridView1, Me)
        XgridColAlign({"Code", "Lock Rate"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Room Rate", "Child Rate", "Extra Person Rate", "Extra Night Rate"}, GridView1)
    End Sub
    Public Sub LoadBreakdown()
        LoadXgrid("SELECT a.dayrate+1 as 'Day',ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=a.dayrate),0) as 'Room Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=a.dayrate),0) as 'Child Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=a.dayrate),0) as 'Extra Person Rate' " _
                                                + " FROM `tblhotelratesbreakdown` as a where ratecode='" & code.Text & "' group by dayrate;", "tblhotelroomrates", Em2, GridView2, Me)
        XgridColAlign({"Day"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Room Rate", "Child Rate", "Extra Person Rate", "Extra Night Rate"}, GridView2)
    End Sub

    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtRoomType.Text = "" Then
                MessageBox.Show("Please select room type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRoomType.Focus()
                Exit Sub
            ElseIf txtDescription.Text = "" Then
                MessageBox.Show("Please enter description", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If mode.Text = "edit" Then
                    com.CommandText = "UPDATE tblhotelroomrates set roomtype='" & typecode.Text & "', description='" & rchar(txtDescription.Text) & "', actived=" & ckActived.CheckState & ",allowzerorate=" & ckAllowZero.CheckState & ", lockrate=" & ckLockrate.CheckState & " where ratecode='" & id.Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "Insert into tblhotelroomrates set roomtype='" & typecode.Text & "', description='" & rchar(txtDescription.Text) & "', actived=" & ckActived.CheckState & ",allowzerorate=" & ckAllowZero.CheckState & ",lockrate=" & ckLockrate.CheckState & "" : com.ExecuteNonQuery()
                End If
                ClearInputs() : txtDescription.Focus()
                XtraMessageBox.Show("Room Rate successfully save", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        mode.Text = "" : id.Text = "" : txtDescription.Text = ""
        ckActived.Checked = True
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to delete selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblhotelroomrates where ratecode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Code").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        Dim extra_night As Boolean = False : Dim child As Boolean = False : Dim extra As Boolean = False
        Dim strAdult As String = "" : Dim strextraNight As String = "" : Dim strchild As String = "" : Dim strExtra As String = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        com.CommandText = "select * from tblhotelroomrates where ratecode='" & id.Text & "'  " : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ckAllowZero.Checked = rst("allowzerorate")
            ckActived.Checked = rst("actived")
            ckLockrate.Checked = rst("lockrate")
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub
 
    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        LoadBreakdown()
    End Sub

    Private Sub Em_GotFocus(sender As Object, e As EventArgs) Handles Em.GotFocus
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        LoadBreakdown()
    End Sub

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        LoadBreakdown()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If GridView2.RowCount = 0 Then
            frmHotelRoomRateBreakdown.txtDayrate.SelectedIndex = 0
        Else
            frmHotelRoomRateBreakdown.txtDayrate.Text = GridView2.GetFocusedRowCellValue("Day").ToString
        End If
        frmHotelRoomRateBreakdown.roomtype.Text = typecode.Text
        frmHotelRoomRateBreakdown.ratecode.Text = code.Text
        frmHotelRoomRateBreakdown.Show(Me)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        LoadBreakdown()
    End Sub
End Class