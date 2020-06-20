Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Xml
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid.Design

Public Class frmUserProfile
    Private Sub frmUserProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadSkins()
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True)
        editProfile()
        LoadGridview()
        LoadSchemeStyle()
        txtSystemIcon.Properties.Items.Clear()
        For Each folder In System.IO.Directory.EnumerateDirectories(Application.StartupPath & "\Icon")
            txtSystemIcon.Properties.Items.Add(folder.Replace(Application.StartupPath & "\Icon\", ""))
        Next
    End Sub

#Region "USER INFORMATION"
    Dim cpass As Boolean = False

    Public Sub LoadSkins()
        Dim skins As New SkinContainerCollection
        skins = SkinManager.Default.Skins
        Dim I As Integer = 0
        For I = 0 To skins.Count - 1
            txttheme.Properties.Items.Add(skins(I).SkinName)
        Next
    End Sub
    Public Sub editProfile()
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing
        cpass = False
        txtpassword.Properties.ReadOnly = True
        txtverify.Properties.ReadOnly = True

        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblaccounts.officeid) as '" & GlobalOfficeCaption & "' from tblaccounts where accountid='" & globaluserid & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtdesignation.Text = rst("designation").ToString
            txtoffice.Text = rst(GlobalOfficeCaption).ToString
            txtusername.Text = rst("username").ToString
            txttheme.Text = rst("theme").ToString
            txtSystemIcon.Text = rst("iconfolder").ToString
            txtMenufontName.Text = rst("menufontname").ToString
            txtMenuFontSize.Text = rst("menufontsize").ToString
            txtPagefontName.Text = rst("pagefontname").ToString
            txtPagefontSize.Text = rst("pagefontsize").ToString
            ShowImage("digitalsign", signature, Me)
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If cpass = True Then
            cpass = False
            txtpassword.Text = "" : txtverify.Text = ""
            txtpassword.Properties.ReadOnly = True
            txtverify.Properties.ReadOnly = True
            SimpleButton3.Text = "Change Password"
        Else
            cpass = True
            txtpassword.Text = "" : txtverify.Text = ""
            txtpassword.Properties.ReadOnly = False
            txtverify.Properties.ReadOnly = False
            SimpleButton3.Text = "Cancel"
        End If

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtfullname.Text = "" Then
            XtraMessageBox.Show("Please enter fullname.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtdesignation.Text = "" Then
            XtraMessageBox.Show("Please select designation.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            XtraMessageBox.Show("Please enter username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        End If

        Dim passqry As String = ""
        If mode.Text = "edit" Then
            If cpass = True Then
                If txtpassword.Text = "" Then
                    XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword.Focus()
                    Exit Sub
                ElseIf txtverify.Text = "" Then
                    XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtverify.Focus()
                    Exit Sub
                ElseIf txtpassword.Text <> txtverify.Text Then
                    XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword.Text = ""
                    txtverify.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                End If
                passqry = " username='" & txtusername.Text & "', password='" & EncryptTripleDES(txtusername.Text + txtverify.Text) & "', webpassword=DES_ENCRYPT('" & txtusername.Text + txtverify.Text & "','kira'), "
            Else
                passqry = ""
            End If
            If XtraMessageBox.Show("Are you sure you want to update your account " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblaccounts set fullname = '" & txtfullname.Text & "', " _
                                 + " designation='" & txtdesignation.Text & "', " _
                                 + passqry _
                                 + " theme='" & txttheme.Text & "', iconfolder='" & txtSystemIcon.Text & "', " _
                                 + " menufontname='" & txtMenufontName.Text & "', " _
                                 + " menufontsize=" & txtMenuFontSize.Text & ", " _
                                 + " pagefontname='" & txtPagefontName.Text & "', " _
                                 + " pagefontsize=" & txtPagefontSize.Text & " " _
                                 + " where accountid='" & globaluserid & "' "
                com.ExecuteNonQuery()
                UpdateImage("accountid='" & globaluserid & "'", "digitalsign", "tblaccounts", signature, Me)
                loadglobaluser()
                globaltheme = txttheme.Text
                MdiCoffeeCup.CustomizeSystemIcon(txtSystemIcon.Text)
                MdiCoffeeCup.InitSkins()
                XtraMessageBox.Show("User successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cpass = False
            End If
        End If

    End Sub

    Private Sub signature_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles signature.Validating
        resizesignature()
    End Sub
    Public Sub resizesignature()
        If signature.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(signature.Image)
        signature.Image = Original

        Dim m As Int32 = 200
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        signature.Image = Thumb
    End Sub

#End Region

#Region "GRIDVIEW APPEARANCE"
    Public grid As DevExpress.XtraGrid.Views.Grid.GridView
    Public Function formatGrid(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        grid = xgrid
        Return grid
    End Function

    Public Sub LoadSchemeStyle()
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        Dim styles As XmlNodeList = doc.SelectNodes("/Styles/*")

        txtschemestyle.Properties.Items.Clear()
        txtschemestyle.Properties.Items.Add("Default")
        For Each scheme In styles
            txtschemestyle.Properties.Items.Add(scheme.Attributes.GetNamedItem("name").Value)
        Next
    End Sub

    Public Sub LoadGridview()
        com.CommandText = "select * from tblgridsettings where userid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            ck_enablle_features.Checked = rst("grid_enableappearance")
            txtfontfamily.Text = rst("grid_fontfamily").ToString
            txtforecolor.Text = rst("grid_forntcolor").ToString
            txtFontSize.Text = rst("grid_fontsize").ToString
            txtschemestyle.Text = rst("grid_schemestyle").ToString
            txtpaintstyle.Text = rst("grid_paintstyle").ToString
            ck_header_bold.Checked = rst("grid_header_bold")
            ck_main_bold.Checked = rst("grid_main_bold")
            ck_footer_bold.Checked = rst("grid_footer_bold")
            ck_evenrowenable.Checked = rst("grid_evenrowenable")
            ck_ShowHorzLines.Checked = rst("grid_ShowHorzLines")
            ck_ShowVertLines.Checked = rst("grid_ShowVertLines")
            ck_indicatorline.Checked = rst("grid_indicatorline")
            ck_enablefilterappearance.Checked = rst("grid_filterappearance")

        End While
        rst.Close()
        If ck_enablle_features.Checked = False Then
            FilterFeatures()
        End If
    End Sub

    Private Sub cmdAppearanceSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAppearanceSave1.Click
        If countqry("tblgridsettings", "userid='" & globaluserid & "'") = 0 Then
            com.CommandText = "insert into tblgridsettings set userid='" & globaluserid & "', grid_enableappearance=" & ck_enablle_features.CheckState & ", " _
                               + " grid_fontfamily='" & txtfontfamily.Text & "'," _
                               + " grid_forntcolor = '" & txtforecolor.Text & "', " _
                               + " grid_fontsize='" & txtFontSize.Text & "', " _
                               + " grid_schemestyle='" & txtschemestyle.Text & "', " _
                               + " grid_paintstyle='" & txtpaintstyle.Text & "', " _
                               + " grid_header_bold=" & ck_header_bold.CheckState & ", " _
                               + " grid_main_bold=" & ck_main_bold.CheckState & ", " _
                               + " grid_footer_bold=" & ck_footer_bold.CheckState & ", " _
                               + " grid_evenrowenable=" & ck_evenrowenable.CheckState & ", " _
                               + " grid_ShowHorzLines=" & ck_ShowHorzLines.CheckState & ", " _
                               + " grid_ShowVertLines=" & ck_ShowVertLines.CheckState & ", " _
                               + " grid_indicatorline=" & ck_indicatorline.CheckState & ", " _
                               + " grid_filterappearance=" & ck_enablefilterappearance.CheckState & ";" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblgridsettings set grid_enableappearance=" & ck_enablle_features.CheckState & ", " _
                               + " grid_fontfamily='" & txtfontfamily.Text & "'," _
                               + " grid_forntcolor = '" & txtforecolor.Text & "', " _
                               + " grid_fontsize='" & txtFontSize.Text & "', " _
                               + " grid_schemestyle='" & txtschemestyle.Text & "', " _
                               + " grid_paintstyle='" & txtpaintstyle.Text & "', " _
                               + " grid_header_bold=" & ck_header_bold.CheckState & ", " _
                               + " grid_main_bold=" & ck_main_bold.CheckState & ", " _
                               + " grid_footer_bold=" & ck_footer_bold.CheckState & ", " _
                               + " grid_evenrowenable=" & ck_evenrowenable.CheckState & ", " _
                               + " grid_ShowHorzLines=" & ck_ShowHorzLines.CheckState & ", " _
                               + " grid_ShowVertLines=" & ck_ShowVertLines.CheckState & ", " _
                               + " grid_indicatorline=" & ck_indicatorline.CheckState & ", " _
                               + " grid_filterappearance=" & ck_enablefilterappearance.CheckState & " where userid='" & globaluserid & "';" : com.ExecuteNonQuery()
        End If
        LoadUserGridAppearance()
        If Not grid Is Nothing Then
            LoadGridviewAppearance(grid)
        End If
        XtraMessageBox.Show("Gridview appearance successfully saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ck_enablle_features_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_enablle_features.CheckedChanged
        FilterFeatures()
    End Sub
    Public Sub FilterFeatures()
        If ck_enablle_features.Checked = False Then
            txtfontfamily.Text = "Tahoma"
            txtforecolor.Text = "Black"
            txtFontSize.Text = "8.25"
            txtschemestyle.Text = "Default"
            txtpaintstyle.Text = "Default"

            ck_header_bold.Checked = False
            ck_main_bold.Checked = False
            ck_footer_bold.Checked = False
            ck_evenrowenable.Checked = False
            ck_ShowHorzLines.Checked = False
            ck_ShowVertLines.Checked = False
            ck_indicatorline.Checked = False
            ck_enablefilterappearance.Checked = False

            txtfontfamily.Enabled = False
            txtforecolor.Enabled = False
            txtFontSize.Enabled = False
            txtschemestyle.Enabled = False
            txtpaintstyle.Enabled = False
            ck_header_bold.Enabled = False
            ck_main_bold.Enabled = False
            ck_footer_bold.Enabled = False
            ck_evenrowenable.Enabled = False
            ck_ShowHorzLines.Enabled = False
            ck_ShowVertLines.Enabled = False
            ck_indicatorline.Enabled = False
            ck_enablefilterappearance.Enabled = False

        Else
            txtfontfamily.Enabled = True
            txtforecolor.Enabled = True
            txtFontSize.Enabled = True
            txtschemestyle.Enabled = True
            txtpaintstyle.Enabled = True
            ck_header_bold.Enabled = True
            ck_main_bold.Enabled = True
            ck_footer_bold.Enabled = True
            ck_evenrowenable.Enabled = True
            ck_ShowHorzLines.Enabled = True
            ck_ShowVertLines.Enabled = True
            ck_indicatorline.Enabled = True
            ck_enablefilterappearance.Enabled = True
        End If
    End Sub
#End Region

 
    Private Sub txttheme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttheme.SelectedIndexChanged
        MdiCoffeeCup.DefaultLookAndFeel1.LookAndFeel.SkinName = txttheme.SelectedItem.ToString()
    End Sub

    Private Sub txtfontfamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfontfamily.SelectedIndexChanged, _
        txtforecolor.EditValueChanged, txtFontSize.EditValueChanged, txtschemestyle.EditValueChanged, txtpaintstyle.EditValueChanged
        If Not grid Is Nothing Then
            FloatingChangeAppearance(grid)
        End If
    End Sub

    Private Sub ck_header_bold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_header_bold.CheckedChanged, _
        ck_header_bold.CheckedChanged, _
        ck_main_bold.CheckedChanged, _
        ck_footer_bold.CheckedChanged, _
        ck_evenrowenable.CheckedChanged, _
        ck_ShowHorzLines.CheckedChanged, _
        ck_ShowVertLines.CheckedChanged, _
        ck_indicatorline.CheckedChanged, _
        ck_enablefilterappearance.CheckedChanged
        If Not grid Is Nothing Then
            FloatingChangeAppearance(grid)
        End If
    End Sub
    Public Function FloatingChangeAppearance(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim gvScheme As XAppearances = New XAppearances(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        xgrid.OptionsSelection.EnableAppearanceFocusedCell = False
        If ck_enablle_features.Checked = True Then
            gvScheme.LoadScheme(txtschemestyle.Text, xgrid)
            xgrid.PaintStyleName = txtpaintstyle.Text
            If ck_indicatorline.Checked = True Then
                xgrid.OptionsView.ShowIndicator = True
            Else
                xgrid.OptionsView.ShowIndicator = False
            End If

            If ck_evenrowenable.Checked = True Then
                xgrid.OptionsView.EnableAppearanceEvenRow = True
                xgrid.OptionsView.EnableAppearanceOddRow = True
            Else
                xgrid.OptionsView.EnableAppearanceEvenRow = False
                xgrid.OptionsView.EnableAppearanceOddRow = False
            End If

            If ck_ShowHorzLines.Checked = True Then
                xgrid.OptionsView.ShowHorizontalLines = True
            Else
                xgrid.OptionsView.ShowHorizontalLines = False
            End If

            If ck_ShowVertLines.Checked = True Then
                xgrid.OptionsView.ShowVerticalLines = True
            Else
                xgrid.OptionsView.ShowVerticalLines = False
            End If
            If ck_header_bold.Checked = True Then
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If ck_main_bold.Checked = True Then
                xgrid.Appearance.Row.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.Row.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If ck_footer_bold.Checked = True Then
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            xgrid.Appearance.HeaderPanel.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.Row.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.FooterPanel.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.GroupFooter.ForeColor = Color.FromName(txtforecolor.Text)
        Else
            gvScheme.LoadScheme("Default", xgrid)
            xgrid.PaintStyleName = "Default"
        End If
        Return xgrid
    End Function

    
    Private Sub txtSystemIcon_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtSystemIcon.SelectedValueChanged
        MdiCoffeeCup.CustomizeSystemIcon(txtSystemIcon.Text)
    End Sub

  
End Class