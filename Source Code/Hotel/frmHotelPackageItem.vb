Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.Utils

Public Class frmHotelPackageItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomRateBreakDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGridviewAppearance(gridoffice)
        LoadGridviewAppearance(GridView1)
        LoadOffice()
        LoadData()
        LoadCode()

    End Sub
    
    Public Sub LoadCode()
        If mode.Text <> "edit" Then
            code.Text = getcodeid("itemcode", "tblhotelpackageitem", "100")
        End If
    End Sub
    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Office' from tblcompoffice where deleted=0", "tblcompoffice", txtOffice, gridoffice, Me)
        gridoffice.Columns("officeid").Visible = False
    End Sub
    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtOffice.Properties.View.FocusedRowHandle.ToString)
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub ShowBreakdownInfo()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid=tblhotelpackageitem.centerofficeid) as office from tblhotelpackageitem where itemcode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            ckEnableCenter.Checked = rst("enablecenter")
            officeid.Text = rst("centerofficeid").ToString
            txtOffice.Text = rst("office").ToString
           
        End While
        rst.Close()
    End Sub

    Public Sub LoadData()
        LoadXgrid("select itemcode as Code, Description, EnableCenter, (select officename from tblcompoffice where officeid=tblhotelpackageitem.centerofficeid) as 'Center Profit'  from tblhotelpackageitem", "tblhotelpackageitem", Em, GridView1, Me)
        XgridColAlign({"Code", "Center Profit"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdcomsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtDescription.Text = "" Then
                MessageBox.Show("Please item name", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescription.Focus()
                Exit Sub
            ElseIf txtOffice.Text = "" And ckEnableCenter.Checked = True Then
                MessageBox.Show("Please select center office", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtOffice.Focus()
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to Continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If mode.Text = "edit" Then
                    com.CommandText = "UPDATE tblhotelpackageitem set Description='" & rchar(txtDescription.Text) & "', enablecenter=" & ckEnableCenter.CheckState & ", centerofficeid='" & officeid.Text & "' where itemcode='" & code.Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "INSERT INTO tblhotelpackageitem set itemcode='" & code.Text & "', Description='" & rchar(txtDescription.Text) & "', enablecenter=" & ckEnableCenter.CheckState & ", centerofficeid='" & officeid.Text & "' " : com.ExecuteNonQuery()
                End If
                mode.Text = "" : txtDescription.Text = "" : code.Text = "" : LoadCode() : LoadData() : txtDescription.Focus()
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

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to removed selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblhotelpackageitem where itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "'" : com.ExecuteNonQuery()
            Next
            XtraMessageBox.Show("Item successfully removed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        code.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        mode.Text = "edit"
        ShowBreakdownInfo()
    End Sub

    Private Sub ckEnableCenter_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableCenter.CheckedChanged
        If ckEnableCenter.Checked = True Then
            txtOffice.Enabled = True
        Else
            txtOffice.Enabled = False
            officeid.Text = ""
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
End Class