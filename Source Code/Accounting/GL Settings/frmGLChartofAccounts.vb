Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns

Public Class frmGLChartofAccounts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGLGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadCompany()
    End Sub

    Public Sub LoadCompany()
        LoadXgridLookupSearch("SELECT code as compid,companyname as 'Select Company' from tblcompany order by code asc", "tblcompany", txtCompany, GridView_company, Me)
        GridView_company.Columns("compid").Visible = False
    End Sub
    Private Sub txtCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.EditValueChanged
        On Error Resume Next
        compid.Text = txtCompany.Properties.View.GetFocusedRowCellValue("compid").ToString()
        If compid.Text <> "" Then
            treeview()
        End If
    End Sub


    Public Sub treeview()
        TreeView1.Nodes.Clear()
        'Create Group
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblglitem where glgroup=1 and companyid='" & compid.Text & "' order by groupcode asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                Dim mainNode As New TreeNode()
                mainNode.Name = .Rows(cnt)("groupcode").ToString
                mainNode.Text = .Rows(cnt)("groupcode").ToString & " - " & .Rows(cnt)("itemname").ToString
                Me.TreeView1.Nodes.Add(mainNode)
            End With
        Next


        'create gl list
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblglitem where level>0 and companyid='" & compid.Text & "' order by level,itemcode asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                InsertTree(.Rows(cnt)("itemcode").ToString, .Rows(cnt)("itemcode").ToString & " - " & .Rows(cnt)("itemname").ToString, .Rows(cnt)("parent").ToString)
            End With
        Next

    End Sub

   
    Public Sub InsertTree(ByVal itemcode As String, ByVal itemname As String, ByVal parent As String)
        Dim mainNode As New TreeNode()
        mainNode.Name = itemcode
        mainNode.Text = itemname

        Dim MyNode() As TreeNode
        MyNode = TreeView1.Nodes.Find(parent, True)
        MyNode(0).Nodes.Add(mainNode)
    End Sub

    Private Sub ExpandGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpandGroupsToolStripMenuItem.Click
        TreeView1.ExpandAll()
    End Sub

    Private Sub CollapseGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollapseGroupsToolStripMenuItem.Click
        TreeView1.CollapseAll()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmGLAddItem.Show(Me)
    End Sub

    Private Sub cmdClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        If BarCheckItem1.Checked = True Then
            TreeView1.ExpandAll()
        Else
            TreeView1.CollapseAll()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frmGLAddGroup.Show(Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LoadXgrid("select * from tblglitem where companyid='" & compid.Text & "'", "tblglitem", Em, GridView1, Me)
        ExportGridToExcel(Me.Text & "-" & txtCompany.Text, GridView1)

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        LoadXgrid("select  itemcode, " & GlobalGLitemname & " as 'PARTICULARS' from tblglitem as a where companyid='" & compid.Text & "'", "tblglitem", Em, GridView1, Me)
        ExportGridToExcel(Me.Text & "-" & txtCompany.Text, GridView1)
    End Sub
End Class