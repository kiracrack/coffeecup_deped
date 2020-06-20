Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmPulloutForm
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPulloutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountable()
        LoadTemporaryItem()
        txtBorrowedDate.EditValue = CDate(Now)
        txtReturnedDate.EditValue = CDate(Now)
        If mode.Text = "edit" Then
            LoadInfo()
        Else
            yeartrn.Text = CDate(Now).ToShortDateString
            CreateControlNumber()
        End If
    End Sub

    Public Sub LoadAccountable()
        LoadXgridLookupSearch("select officeid,accountid, Fullname, (select Officename from tblcompoffice where officeid=tblaccounts.officeid) as 'Office' from tblaccounts where username<>'ROOT' and deleted=0 order by fullname asc", "tblaccounts", txtBorrowersname, s_grid, Me)
        s_grid.Columns("accountid").Visible = False
        XgridHideColumn({"officeid"}, s_grid)
    End Sub

    Private Sub txtrequestby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBorrowersname.EditValueChanged
        On Error Resume Next
        borrowerid.Text = txtBorrowersname.Properties.View.GetFocusedRowCellValue("accountid").ToString()
        officeid.Text = txtBorrowersname.Properties.View.GetFocusedRowCellValue("officeid").ToString()
        txtOffice.Text = txtBorrowersname.Properties.View.GetFocusedRowCellValue("Office").ToString()
    End Sub

    Public Sub LoadInfo()
        com.CommandText = "select * from tblofficeequipmentpullout where trncode='" & trncode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtBorrowedDate.EditValue = CDate(rst("dateborrowed").ToString)
            txtReturnedDate.EditValue = If(rst("datereturned").ToString = "", CDate(Now), CDate(rst("datereturned").ToString))
            txtBorrowersname.EditValue = rst("borrower").ToString
            borrowerid.Text = rst("borrower").ToString
        End While
        rst.Close()
    End Sub

    Public Sub CreateControlNumber()
        Dim vno As String = getControlNumber(CDate(yeartrn.Text).ToString("yyyy"), "tblofficeequipmentpullout")
        trncode.Text = CDate(yeartrn.Text).ToString("yyyy") & CDate(yeartrn.Text).ToString("MM") & "-" & vno
        seriesno.Text = vno
    End Sub

    Public Sub LoadTemporaryItem()
        Try
            If mode.Text = "edit" Then
                LoadXgrid("Select b.id, QTY, b.Unit as UOM, itemname as ITEM, REASON, REMARKS from tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid where trncode='" & trncode.Text & "' order by itemname asc", "tblofficeequipment", Em, Gridview1, Me)
            Else
                LoadXgrid("Select b.id, QTY, b.Unit as UOM, itemname as ITEM, REASON, REMARKS from tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid where trncode='' order by itemname asc", "tblofficeequipment", Em, Gridview1, Me)
            End If

            XgridHideColumn({"id"}, Gridview1)
            XgridColAlign({"QTY", "UOM"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)

            For Each col In Gridview1.Columns
                col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                XgridDisableColumn({col.ToString}, Gridview1)
            Next

            XgridEnableColumn({"QTY", "REASON", "REMARKS"}, Gridview1)

            Gridview1.Appearance.HeaderPanel.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.Row.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.FooterPanel.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.GroupFooter.Font = New Font("Segoe UI", 9.0!)
            Gridview1.UserCellPadding = New Padding(2)
            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    Gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PulloutItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PulloutItemToolStripMenuItem.Click
        For I = 0 To Gridview1.SelectedRowsCount - 1
            com.CommandText = "DELETE FROM tblofficeequipmentpulloutitem where id='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
        Next
        LoadTemporaryItem()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gridview1.CellValueChanged
        If e.Column.FieldName = "QTY" Or e.Column.FieldName = "REASON" Or e.Column.FieldName = "REMARKS" Then
            com.CommandText = "update tblofficeequipmentpulloutitem set qty='" & Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("QTY")).ToString() & "', reason='" & rchar(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("REASON")).ToString()) & "',remarks='" & rchar(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("REMARKS")).ToString()) & "' where id='" & Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("id")).ToString() & "'" : com.ExecuteNonQuery()
            Gridview1.BestFitColumns()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTemporaryItem()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If MessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblofficeequipmentpullout set borrower='" & borrowerid.Text & "', dateborrowed='" & ConvertDate(txtBorrowedDate.EditValue) & "', timeborrowed=current_time,datereturned='" & ConvertDate(txtReturnedDate.EditValue) & "', trnby='" & globaluserid & "',datetrn=current_timestamp where trncode='" & trncode.Text & "' " : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid set a.officeid='" & officeid.Text & "' where b.trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblofficeequipmentpulloutitem set borroweroffice='" & officeid.Text & "' where trncode='" & trncode.Text & "' " : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblofficeequipmentpullout set trncode='" & trncode.Text & "', yeartrn='" & CDate(yeartrn.Text).ToString("yyyy") & "',seriesno='" & seriesno.Text & "', borrower='" & borrowerid.Text & "', dateborrowed='" & ConvertDate(txtBorrowedDate.EditValue) & "',datereturned='" & ConvertDate(txtReturnedDate.EditValue) & "', timeborrowed=current_time,trnby='" & globaluserid & "',datetrn=current_timestamp " : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblofficeequipment as a inner join tblofficeequipmentpulloutitem as b on a.id=b.trnid set a.officeid='" & officeid.Text & "' where b.trncode=''" : com.ExecuteNonQuery()
                com.CommandText = "update tblofficeequipmentpulloutitem set trncode='" & trncode.Text & "', borroweroffice='" & officeid.Text & "' where trncode='' " : com.ExecuteNonQuery()
            End If

            XtraMessageBox.Show("Pullout slip successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If mode.Text <> "edit" Then
                GeneratePulloutSlip(trncode.Text, Me)
            End If
            Me.Close()
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GeneratePulloutSlip(trncode.Text, Me)
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        If LCase(GlobalReportTemplate) = "deped" Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmDepedFFESummary.MdiParent = MdiCoffeeCup
            frmDepedFFESummary.Show()
            frmDepedFFESummary.Focus()
            SplashScreenManager.CloseForm()
        Else
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmInventoryFFESummary.MdiParent = MdiCoffeeCup
            frmInventoryFFESummary.Show()
            frmInventoryFFESummary.Focus()
            SplashScreenManager.CloseForm()
        End If
    End Sub
End Class