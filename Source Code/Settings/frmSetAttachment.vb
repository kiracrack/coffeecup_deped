Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmSetAttachment
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmDepositOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LabelControl1.Text = "Please upload not more than " & (GlobalAllowableAttachSize / 1024) / 1024 & " MB"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub txtAttachment1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFilePath.ButtonClick
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = GlobalFiletypeSupport
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                'Read the contents of the file
                txtFilePath.Text = objOpenFileDialog.FileName
                'Display the file contents in the TextBox
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        If txtFilePath.Text = "" Then
            XtraMessageBox.Show("Please select file!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFilePath.Focus()
            Exit Sub
        ElseIf checkAttachment(txtFilePath.Text) = False Then
            XtraMessageBox.Show("Attached file is to large!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFilePath.Focus()
            Exit Sub
        End If
        If txtFilePath.Text <> "" Then
            FileAttach(0) = txtFilePath.Text
            If AddAttachmentPackage(refno.Text, "requisition-approved", {txtFilePath.Text}) = True Then
                XtraMessageBox.Show("Attachment successfully added", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Me.Close()
    End Sub
     
End Class