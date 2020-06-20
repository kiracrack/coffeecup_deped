Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.Utils

Public Class frmGLJournalDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLJournalDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmGLJournalDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadItem()

        If mode.Text = "edit" Then
            showItemTicketItemInfo()
        End If
    End Sub
    Public Sub LoadItem()
        If LCase(globaluser) = "root" Then
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name', debit from tblglitem where companyid='" & companyid.Text & "' and sl=1 ", "tblglitem", txtItem, gridItem, Me)
        Else
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name', debit from tblglitem where companyid='" & companyid.Text & "' and sl=1 and itemcode in (select itemcode from tblglaccountfilter where permissioncode='" & globalPermissionAccess & "' and companyid='" & companyid.Text & "') ", "tblglitem", txtItem, gridItem, Me)
        End If

        XgridHideColumn({"itemcode", "debit"}, gridItem)
    End Sub
    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        ItemCode.Text = txtItem.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        ckDebit.Checked = CBool(txtItem.Properties.View.GetFocusedRowCellValue("debit").ToString())
        txtNote.Focus()
    End Sub

    Public Sub showItemTicketItemInfo()
        com.CommandText = "select * from tblgljournalitems where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItem.Text = rst("itemcode").ToString
            ItemCode.Text = rst("itemcode").ToString
            txtNote.Text = rst("remarks").ToString
            txtDebit.Text = rst("debitamount").ToString
            txtCredit.Text = rst("creditamount").ToString
            ckDebit.Checked = CBool(rst("debit"))
        End While
        rst.Close()
    End Sub


    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtItem.Text = "" Then
            XtraMessageBox.Show("Please select item name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Exit Sub
        ElseIf txtNote.Text = "" Then
            XtraMessageBox.Show("Please enter remarks!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNote.Focus()
            Exit Sub
        ElseIf Val(CC(txtDebit.Text)) = 0 And Val(CC(txtCredit.Text)) = 0 Then
            XtraMessageBox.Show("Please enter either credit or debit amount!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Val(CC(txtDebit.Text)) > 0 And Val(CC(txtCredit.Text)) > 0 Then
            XtraMessageBox.Show("Please enter only either credit or debit!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblgljournalitems set  " _
                         + " itemcode='" & ItemCode.Text & "', " _
                         + " itemname='" & txtItem.Text & "', " _
                         + " debitamount='" & Val(CC(txtDebit.Text)) & "', " _
                         + " creditamount='" & Val(CC(txtCredit.Text)) & "', " _
                         + " remarks='" & rchar(txtNote.Text) & "',debit=" & ckDebit.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
            If frmGLJournalInformation.Visible = True Then
                frmGLJournalInformation.LoadTickets()
            End If
            Me.Close()
        Else
            com.CommandText = "insert into tblgljournalitems set ticketno='" & txtTicketNo.Text & "', " _
                         + " itemcode='" & ItemCode.Text & "', " _
                         + " itemname='" & txtItem.Text & "', " _
                         + " debitamount='" & Val(CC(txtDebit.Text)) & "', " _
                         + " creditamount='" & Val(CC(txtCredit.Text)) & "', " _
                         + " remarks='" & rchar(txtNote.Text) & "', debit=" & ckDebit.CheckState & " " : com.ExecuteNonQuery()
            txtDebit.EditValue = 0 : txtCredit.EditValue = 0
            txtItem.Focus()
            txtItem.ShowPopup()
            If frmGLJournalInformation.Visible = True Then
                frmGLJournalInformation.LoadTickets()
            End If
        End If
      
    End Sub

    Private Sub txtDebit_GotFocus(sender As Object, e As EventArgs) Handles txtDebit.GotFocus
        Me.AcceptButton = cmdOk
    End Sub

    Private Sub txtCredit_GotFocus(sender As Object, e As EventArgs) Handles txtCredit.GotFocus
        Me.AcceptButton = cmdOk
    End Sub

    Private Sub value_EditValueChanged(sender As Object, e As EventArgs) Handles txtCredit.EditValueChanged, txtDebit.EditValueChanged
        If Val(CC(txtDebit.Text)) > 0 Then
            txtCredit.ReadOnly = True
        ElseIf Val(CC(txtCredit.Text)) > 0 Then
            txtDebit.ReadOnly = True
        Else
            txtDebit.ReadOnly = False
            txtCredit.ReadOnly = False
        End If
    End Sub

  
End Class