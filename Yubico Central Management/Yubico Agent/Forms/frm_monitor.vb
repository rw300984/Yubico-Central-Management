Imports System.ComponentModel

Public Class frm_monitor
    Public bgw_status As Integer = 0
    Private Sub bgw_ykinfo_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ykinfo.DoWork
        Do
            Select Case bgw_status
                Case 0
                    Dim ykinfo As String() = YK_Agent_GetKeyInfo()
                    bgw_ykinfo.ReportProgress(0, ykinfo)
                    Threading.Thread.Sleep(1000)
                Case 1
                    '  If bgw_ykinfo.CancellationPending = True Then
                    Exit Sub
                    ' End If
            End Select
        Loop
    End Sub

    Private Sub bgw_ykinfo_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_ykinfo.ProgressChanged
        Dim ykinfo As String() = TryCast(e.UserState, String())
        lbl_monitor_yub_vendor_output.Text = ykinfo(0)
        lbl_monitor_yub_model_output.Text = ykinfo(1)
        lbl_monitor_yub_firmware_output.Text = ykinfo(3)
        lbl_monitor_yub_serial_output.Text = ykinfo(2)
        If ykinfo(4) = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present Then
            lbl_monitor_yub_touch_output.Text = ykinfo(4)
        ElseIf CType(ykinfo(4), Double) > 520 And CType(ykinfo(4), Double) < 65000 Then
            lbl_monitor_yub_touch_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_touched
        ElseIf CType(ykinfo(4), Double) <= 520 Then
            lbl_monitor_yub_touch_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_touched
        End If
    End Sub

    Private Sub frm_monitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        bgw_ykinfo.RunWorkerAsync()
    End Sub

    Private Sub frm_monitor_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            YK_Agent_FillSystemInfo()
            bgw_status = 0
            If bgw_ykinfo.IsBusy Then
            Else
                bgw_ykinfo.RunWorkerAsync()
            End If
        Else
            bgw_status = 1
            bgw_ykinfo.CancelAsync()
        End If
    End Sub

    Public Function YK_Agent_FillSystemInfo()
        Dim Systeminfo As String() = YK_Agent_GetSystemInfo()
        lbl_monitor_sys_username_output.Text = Systeminfo(0)
        lbl_monitor_sys_ip_output.Text = Systeminfo(1)
        lbl_monitor_sys_hostname_output.Text = Systeminfo(2)
        lbl_monitor_sys_os_output.Text = Systeminfo(3)
        lbl_monitor_sys_devicemodel_output.Text = Systeminfo(4)
    End Function

End Class