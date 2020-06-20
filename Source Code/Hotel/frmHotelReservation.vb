Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing

Public Class frmHotelReservation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim apt As Appointment = SchedulerControl1.Storage.CreateAppointment(AppointmentType.Normal)
        apt.Start = DateTime.Today
        apt.AllDay = True
        apt.Subject = "Subject"
        apt.Description = "Description"

        SchedulerControl1.Storage.Appointments.Add(apt)
    End Sub
    Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
        If e.ViewInfo.DisplayText = String.Empty Then
            e.ViewInfo.ToolTipText = String.Format("Started at {0:g}", e.ViewInfo.Appointment.Start)
        End If
    End Sub
    Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles ToolTipController1.BeforeShow
        Dim aptViewInfo As AppointmentViewInfo
        Dim controller As ToolTipController = DirectCast(sender, ToolTipController)
        Try
            aptViewInfo = CType(controller.ActiveObject, AppointmentViewInfo)
        Catch
            Return
        End Try

        If aptViewInfo Is Nothing Then
            Return
        End If

        If ToolTipController1.ToolTipType = ToolTipType.Standard Then
            e.IconType = ToolTipIconType.Information
            e.ToolTip = aptViewInfo.Description
        End If

        If ToolTipController1.ToolTipType = ToolTipType.SuperTip Then
            Dim SuperTip As New SuperToolTip()
            Dim args As New SuperToolTipSetupArgs()
            args.Title.Text = "Info"
            args.Title.Font = New Font("Times New Roman", 14)
            args.Contents.Text = aptViewInfo.Description
            'args.Contents.Image = resImage
            args.ShowFooterSeparator = True
            args.Footer.Font = New Font("Comic Sans MS", 8)
            args.Footer.Text = "SuperTip"
            SuperTip.Setup(args)
            e.SuperTip = SuperTip
        End If
    End Sub
End Class