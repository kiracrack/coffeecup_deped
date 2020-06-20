Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins

Public Class frmBankSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.F1 Then


        ElseIf keyData = Keys.F2 Then
            If SplitContainerControl1.Collapsed = True Then
                SplitContainerControl1.Collapsed = False
            Else
                SplitContainerControl1.Collapsed = True
            End If
        ElseIf keyData = (Keys.Control) + Keys.P Then
            BarButtonItem2.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub filter()
        LoadXgrid("Select bankcode ,accountnumber as 'Account Number',  accountname as 'Account Name', bankname as 'Bank Name' from tblpaymentbank order by datesaved asc", "tblpaymentbank", Em, GridView1, Me)
        GridView1.BestFitColumns()
        XgridHideColumn({"bankcode"}, GridView1)
        XgridColAlign({"Account Number"}, GridView1, Utils.HorzAlignment.Center)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If code.Text = "" Then
            XtraMessageBox.Show("Please provide Bank Code!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub
        ElseIf txtAccountNumber.Text = "" Then
            XtraMessageBox.Show("Please provide Account Number!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountNumber.Focus()
            Exit Sub
        ElseIf txtAccountName.Text = "" Then
            XtraMessageBox.Show("Please provide Account Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountName.Focus()
            Exit Sub
        ElseIf txtBankName.Text = "" Then
            XtraMessageBox.Show("Please provide Bank Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBankName.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            If countqry("tblpaymentbank", "bankcode='" & code.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Bank Code! Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                code.Focus()
                Exit Sub
            ElseIf countqry("tblpaymentbank", "accountnumber='" & txtAccountNumber.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate account number! Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                code.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblpaymentbank set bankcode='" & code.Text & "', accountnumber='" & txtAccountNumber.Text & "',accountname='" & rchar(txtAccountName.Text) & "', bankname='" & rchar(txtBankName.Text) & "', datesaved=current_timestamp"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblpaymentbank set accountnumber='" & txtAccountNumber.Text & "', accountname='" & rchar(txtAccountName.Text) & "', bankname='" & rchar(txtBankName.Text) & "' where bankcode='" & code.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Bank Account successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearfields()
        code.Text = getcodeid("bankcode", "tblpaymentbank", "100001")
        txtAccountNumber.Text = ""
        txtBankName.Text = ""
        txtAccountName.Text = ""
        mode.Text = ""
        If mode.Text = "edit" Then
            code.Properties.ReadOnly = True
        Else
            code.Properties.ReadOnly = False
        End If
        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpaymentbank where bankcode='" & code.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtAccountNumber.Text = rst("accountnumber").ToString
            txtAccountName.Text = rst("accountname").ToString
            txtBankName.Text = rst("bankname").ToString
        End While
        rst.Close()
        If mode.Text = "edit" Then
            code.Properties.ReadOnly = True
        Else
            code.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Bank Code") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mode.Text = ""
        code.Text = GridView1.GetFocusedRowCellValue("Bank Code").ToString
        mode.Text = "edit"
        SplitContainerControl1.Collapsed = False

        If mode.Text = "edit" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        clearfields()
        LoadGridviewAppearance(GridView1)
        filter()
        LoadToComboBox("bankname", "tblpaymentbank", txtBankName, True)
        If globalAllowAdd = True Or LCase(globaluser) = "root" Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False
        End If
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdEdit.Visible = True
            Em.ContextMenuStrip = gridmenustrip
        Else
            cmdEdit.Visible = False
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub
     
End Class