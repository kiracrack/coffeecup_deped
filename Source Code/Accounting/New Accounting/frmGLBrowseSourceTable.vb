Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmGLBrowseSourceTable
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLBrowseSourceTable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmGLBrowseSourceTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadTable()
    End Sub

    Public Sub LoadTable()
        LoadXgridLookupSearch("select id,tablename,itemcode,itemdetails,desccode,descdetails,parameter, tabledesc as 'Select' from tblgltransactionsourcetable where accounttag=" & ckAccount.CheckState & " order by tabledesc asc", "tblgltransactionsourcetable", txtGroup, gvGroup, Me)
        XgridHideColumn({"id", "tablename", "itemcode", "itemdetails", "desccode", "descdetails", "parameter"}, gvGroup)
    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtGroup.Properties.View.FocusedRowHandle.ToString)
        id.Text = txtGroup.Properties.View.GetFocusedRowCellValue("id").ToString()
        tablename.Text = txtGroup.Properties.View.GetFocusedRowCellValue("tablename").ToString()
        itemcode.Text = txtGroup.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        itemdetails.Text = txtGroup.Properties.View.GetFocusedRowCellValue("itemdetails").ToString()
        desccode.Text = txtGroup.Properties.View.GetFocusedRowCellValue("desccode").ToString()
        descdetails.Text = txtGroup.Properties.View.GetFocusedRowCellValue("descdetails").ToString()
        parameter.Text = txtGroup.Properties.View.GetFocusedRowCellValue("parameter").ToString()
        filterItem()
    End Sub

    Public Sub filterItem()
        If id.Text = "" Then Exit Sub
        If ckAccount.Checked = True Then
            LoadXgrid("Select " & itemcode.Text & " as '" & itemdetails.Text & "', " & desccode.Text & " as '" & descdetails.Text & "', gltoken  from " & tablename.Text & If(parameter.Text = "", "", " where " & parameter.Text) & "", tablename.Text, Em, GridView1, Me)
        Else
            LoadXgrid("Select " & itemcode.Text & " as '" & itemdetails.Text & "', " & desccode.Text & " as '" & descdetails.Text & "'  from " & tablename.Text & If(parameter.Text = "", "", " where " & parameter.Text) & "", tablename.Text, Em, GridView1, Me)
        End If
        XgridHideColumn({"gltoken"}, GridView1)
        XgridColAlign({itemdetails.Text}, GridView1, HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ckAccount.Checked = True Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "INSERT INTO tblgltaggingaccountdetails set groupid='" & groupid.Text & "',sourceid='" & id.Text & "', referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), itemdetails.Text).ToString & "', description='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), descdetails.Text).ToString & "', gltoken='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "gltoken").ToString & "'" : com.ExecuteNonQuery()
                Next
                frmTAGDetails.LoadTaggedAccount()
                Me.Close()
            Else
                For I = 0 To GridView1.SelectedRowsCount - 1
                    com.CommandText = "INSERT INTO tblgltransactiontagging set companyid='" & companyid.Text & "',groupid='" & groupid.Text & "', itemid='" & itemid.Text & "',sourceid='" & id.Text & "', referenceno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), itemdetails.Text).ToString & "', description='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), descdetails.Text).ToString & "'" : com.ExecuteNonQuery()
                Next
                frmGLAccountingSetup.ShowDetupDetails()
                Me.Close()
            End If
        End If
        
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterItem()
    End Sub

    
    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmGLSourceTable.ShowDialog(Me)
        LoadTable()
    End Sub
End Class

