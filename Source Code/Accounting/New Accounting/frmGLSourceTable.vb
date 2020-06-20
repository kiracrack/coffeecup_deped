Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmGLSourceTable
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLSourceTable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmGLSourceTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadTable()
        filterItem()
    End Sub

    Public Sub LoadTable()
        txtTableName.Properties.Items.Clear()
        com.CommandText = "show tables from " & sqldatabase & ";" : rst = com.ExecuteReader
        While rst.Read
            txtTableName.Properties.Items.Add(rst("Tables_in_" & sqldatabase).ToString)
        End While
        rst.Close()
    End Sub

    Public Sub filterItem()
        LoadXgrid("Select id,tablename as 'Table Name', itemcode as 'Item Code', desccode as 'Item Details', Parameter, AccountTag from tblgltransactionsourcetable order by tabledesc asc", "tblgltransactionsourcetable", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Table Name", "Item Code", "Item Details", "AccountTag"}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub


    Public Sub loadFields()
        If txtTableName.Text = "" Then Exit Sub
        txtitemcode.Properties.Items.Clear() : txtdescode.Properties.Items.Clear()
        com.CommandText = "show fields from " & txtTableName.Text & ";" : rst = com.ExecuteReader
        While rst.Read
            txtitemcode.Properties.Items.Add(rst("Field").ToString)
            txtdescode.Properties.Items.Add(rst("Field").ToString)
        End While
        rst.Close()
    End Sub

    Public Sub ShowDetails()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblgltransactionsourcetable where id='" & id.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtTableName.Text = .Rows(cnt)("tablename").ToString
                loadFields()
                txtTableDescription.Text = .Rows(cnt)("tabledesc").ToString
                txtitemcode.Text = .Rows(cnt)("itemcode").ToString
                txtItemDetails.Text = .Rows(cnt)("itemdetails").ToString
                txtdescode.Text = .Rows(cnt)("desccode").ToString
                txtDescDetails.Text = .Rows(cnt)("descdetails").ToString
                txtparameter.Text = .Rows(cnt)("parameter").ToString
                CheckEdit1.Checked = CBool(.Rows(cnt)("accounttag").ToString)
            End With
        Next

    End Sub

    Private Sub txtTableName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtTableName.SelectedValueChanged
        txtTableDescription.Focus()
        loadFields()
    End Sub

    Private Sub txtitemcode_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtitemcode.SelectedValueChanged
        txtItemDetails.Focus()
    End Sub

    Private Sub txtdescode_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtdescode.SelectedValueChanged
        txtDescDetails.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtTableName.Text = "" Then
            XtraMessageBox.Show("Please select table name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTableName.Focus()
            Exit Sub
        ElseIf txtTableDescription.Text = "" Then
            XtraMessageBox.Show("Please enter table description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTableDescription.Focus()
            Exit Sub
        ElseIf txtitemcode.Text = "" Then
            XtraMessageBox.Show("Please select item code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtitemcode.Focus()
            Exit Sub
        ElseIf txtItemDetails.Text = "" Then
            XtraMessageBox.Show("Please enter item code description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemDetails.Focus()
            Exit Sub
        ElseIf txtdescode.Text = "" Then
            XtraMessageBox.Show("Please select item name code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdescode.Focus()
            Exit Sub
        ElseIf txtDescDetails.Text = "" Then
            XtraMessageBox.Show("Please enter item name description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescDetails.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to Continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblgltransactionsourcetable set tablename='" & txtTableName.Text & "', tabledesc='" & rchar(txtTableDescription.Text) & "',itemcode='" & txtitemcode.Text & "', itemdetails='" & rchar(txtItemDetails.Text) & "',desccode='" & txtdescode.Text & "', descdetails='" & rchar(txtDescDetails.Text) & "',parameter='" & rchar(txtparameter.Text) & "', accounttag=" & CheckEdit1.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblgltransactionsourcetable set tablename='" & txtTableName.Text & "', tabledesc='" & rchar(txtTableDescription.Text) & "',itemcode='" & txtitemcode.Text & "', itemdetails='" & rchar(txtItemDetails.Text) & "',desccode='" & txtdescode.Text & "', descdetails='" & rchar(txtDescDetails.Text) & "',parameter='" & rchar(txtparameter.Text) & "', accounttag=" & CheckEdit1.CheckState & "" : com.ExecuteNonQuery()
            End If
            filterItem() : mode.Text = "" : id.Text = "" : txtTableName.SelectedIndex = -1 : txtTableDescription.Text = "" : txtitemcode.Properties.Items.Clear() : txtitemcode.Text = "" : txtItemDetails.Text = "" : txtdescode.Properties.Items.Clear() : txtdescode.Text = "" : txtDescDetails.Text = "" : txtparameter.Text = ""
            XtraMessageBox.Show("Item successfully save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterItem()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        mode.Text = "edit"
        ShowDetails()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to Continue? there's is no undo function once the code is deleted? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblgltransactionsourcetable where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            filterItem()
            XtraMessageBox.Show("Item successfully deleted", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class