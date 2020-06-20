Imports DevExpress.XtraEditors

Public Class frmAssetsDepreciation

    Private Sub frmChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If ckpooption.SelectedIndex = 0 Then
            lbl2.Text = "Annual Depreciation Rate"
            txtvalunit.Text = "%"
        Else
            lbl2.Text = "Number of years to depreciate over"
            txtvalunit.Text = "Year(s)"
        End If
        LoadGridviewAppearance(GridView1)
        LoadCategory()
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If
        If globalAllowDelete = True Or LCase(globaluser) = "root" Then
            cmdremove.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            cmdremove.Visible = False
            ToolStripSeparator2.Visible = False
        End If
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupEdit("select CATID,DESCRIPTION 'Select Category' from tblprocategory where ffe=1 order by DESCRIPTION asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("CATID").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("CATID").ToString()
        txtprocat.Text = txtprocat.Properties.View.GetFocusedRowCellValue("Select Category").ToString()
        If catid.Text = "" Then Exit Sub
        loadProduct()
        LoadDepreciation()
    End Sub

    Public Sub loadProduct()
        ls.Items.Clear()
        com.CommandText = "select * from tblinventoryffetype where catid='" & catid.Text & "' and code not in (select ffetype from tbldeprecitionofassets where catid='" & catid.Text & "') order by description asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add(rst("code"), False)
            ls.Items.Item(rst("code")).Description = rst("description").ToString
            ls.Items.Item(rst("code")).Value = rst("code").ToString
        End While
        rst.Close()
    End Sub

    Public Sub LoadDepreciation()
        LoadXgrid("select depcode, (select description from tblinventoryffetype where code = tbldeprecitionofassets.ffetype) as 'Category', " _
                  + " case when depmode = 0 then 'Reducing Balance' else 'Straight Line' end as 'Depreciation Type',  " _
                  + " case when depmode = 0 then concat(depvalue, '%') else concat(depvalue, ' Year(s)') end as 'Value' " _
                  + " from tbldeprecitionofassets where catid='" & catid.Text & "' order by (select description from tblinventoryffetype where code = tbldeprecitionofassets.ffetype) asc", "tbldeprecitionofassets", Em, GridView1, Me)

        GridView1.Columns("depcode").Visible = False
        XgridColAlign({"Value"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("Are you sure you want to continue save?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For n = 0 To ls.CheckedItems.Count - 1
                com.CommandText = "delete from tbldeprecitionofassets where ffetype='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbldeprecitionofassets set catid='" & catid.Text & "', ffetype='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "', depmode='" & ckpooption.SelectedIndex.ToString & "', depvalue='" & Val(CC(txtValue.Text)) & "', lasttrnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Next
            loadProduct()
            txtValue.Text = "0"
            LoadDepreciation()
            XtraMessageBox.Show("Settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ckpooption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ckpooption.SelectedIndexChanged
        If ckpooption.SelectedIndex = 0 Then
            lbl2.Text = "Annual Depreciation Rate"
            txtvalunit.Text = "%"
        Else
            lbl2.Text = "Number of years to depreciate over"
            txtvalunit.Text = "Year(s)"
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For n = 0 To ls.ItemCount - 1
            If CheckEdit1.Checked = True Then
                ls.Items.Item(n).CheckState = CheckState.Checked
            Else
                ls.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
    End Sub

    Private Sub txtfilter_EditValueChanged(sender As Object, e As EventArgs)
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        loadProduct()
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdInactive_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If XtraMessageBox.Show("Are you sure you want to continue remove?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("depcode", "depcode", "tbldeprecitionofassets", GridView1, Me)
            loadProduct()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadDepreciation()
    End Sub
End Class