Imports System.ComponentModel

Public Class frm_monitor
    Public bgw_status As Integer = 0
    Private Sub bgw_ykinfo_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ykinfo.DoWork
        Dim count As Integer = 0
        Do
            Select Case bgw_status
                Case 0
                    '   Dim res_ykinfo As ykinfo = plg_ykinfo.GetYKInfoFromDB()
                    bgw_ykinfo.ReportProgress(0) ' , res_ykinfo)
                    If count = 60 Or count = 0 Then
                        Dim systeminfo As sysinfo = plg_sysinfo.GetSysInfoFromDB()
                        bgw_ykinfo.ReportProgress(1, systeminfo)
                        count = 0
                    End If
                    count = count + 1
                    Threading.Thread.Sleep(1000)
                Case 1
                    count = 0
                    Exit Sub
            End Select
        Loop
    End Sub

    Private Sub bgw_ykinfo_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_ykinfo.ProgressChanged
        Select Case e.ProgressPercentage
            Case 0
                ' Dim ykinfo As ykinfo = e.UserState
                If res_ykinfo.vendor = "" Then
                    lbl_monitor_yub_vendor_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
                Else
                    lbl_monitor_yub_vendor_output.Text = YK_Agent_ConvertInfo_to_Names(0, res_ykinfo.vendor)
                End If
                If res_ykinfo.model = "" Then
                    lbl_monitor_yub_model_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
                Else
                    lbl_monitor_yub_model_output.Text = YK_Agent_ConvertInfo_to_Names(1, res_ykinfo.model)
                End If
                If res_ykinfo.firmware = "" Then
                    lbl_monitor_yub_firmware_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
                Else
                    lbl_monitor_yub_firmware_output.Text = res_ykinfo.firmware
                End If
                If res_ykinfo.serial = "" Then
                    lbl_monitor_yub_serial_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
                Else
                    If res_ykinv.Name = "" Or res_ykinv.Name = Nothing Or res_ykinfo.serial = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present Then
                        lbl_monitor_yub_serial_output.Text = res_ykinfo.serial
                    Else
                        If res_ykinv.Name = "#ignore#" Then
                            lbl_monitor_yub_serial_output.Text = res_ykinfo.serial & " (Guest)"
                        Else
                            lbl_monitor_yub_serial_output.Text = res_ykinfo.serial & " (" & res_ykinv.Name & ")"
                        End If
                    End If
                End If
                If res_ykinfo.touch = "" Then
                    lbl_monitor_yub_touch_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
                Else
                    If CType(res_ykinfo.touch, Double) > 520 And CType(res_ykinfo.touch, Double) < 65000 Then
                        lbl_monitor_yub_touch_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_touched
                    ElseIf CType(res_ykinfo.touch, Double) <= 520 Then
                        lbl_monitor_yub_touch_output.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_touched
                    End If
                End If
            Case 1
                Dim systeminfo As sysinfo = e.UserState
                lbl_monitor_sys_username_output.Text = systeminfo.username
                lbl_monitor_sys_ip_output.Text = systeminfo.ip_internal & " - " & systeminfo.ip_external
                lbl_monitor_sys_hostname_output.Text = systeminfo.computername
                lbl_monitor_sys_os_output.Text = systeminfo.os
                lbl_monitor_sys_devicemodel_output.Text = systeminfo.manufacturer
        End Select
    End Sub

    Private Sub frm_monitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Visible = False
        '  bgw_ykinfo.RunWorkerAsync()
    End Sub

    Private Sub frm_monitor_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
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
End Class