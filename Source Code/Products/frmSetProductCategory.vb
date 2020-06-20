Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSetProductCategory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmSetProductCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadCategory()
        LoadGridviewAppearance(combogrid)
    End Sub

    Private Sub catid_EditValueChanged(sender As Object, e As EventArgs) Handles catid.EditValueChanged
        LoadCategory()
        'txtprocat.ShowPopup()
    End Sub
    Public Sub LoadCategory()
        LoadXgridLookupEdit("select catid, DESCRIPTION 'Select' from tblprocategory order by description asc", "tblprocategory", txtprocat, combogrid, Me)
        combogrid.Columns("catid").Visible = False
    End Sub

    Private Sub txtprocat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocat.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtprocat.Properties.View.FocusedRowHandle.ToString)
        catid.Text = txtprocat.Properties.View.GetFocusedRowCellValue("catid").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If txtprocat.Text = "" Then
            XtraMessageBox.Show("Please select category!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprocat.Focus()
            Exit Sub
        End If
        frmProductManagement.SetCategory(txtprocat.Text, catid.Text)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub


End Class
