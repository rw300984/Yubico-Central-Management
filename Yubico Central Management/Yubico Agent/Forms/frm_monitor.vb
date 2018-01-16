Public Class frm_monitor
    Private Sub frm_monitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        YK_Agent_FillSystemInfo()
        YK_Agent_FillYKinfo()
    End Sub

    Private Sub frm_monitor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        YK_Agent_FillSystemInfo()
        YK_Agent_FillYKinfo()
    End Sub

    Public Function YK_Agent_FillSystemInfo()
        Dim Systeminfo As String() = YK_Agent_GetSystemInfo()
        lbl_monitor_sys_username_output.Text = Systeminfo(0)
        lbl_monitor_sys_ip_output.Text = Systeminfo(1)
        lbl_monitor_sys_hostname_output.Text = Systeminfo(2)
        lbl_monitor_sys_os_output.Text = Systeminfo(3)
        lbl_monitor_sys_devicemodel_output.Text = Systeminfo(4)
    End Function

    Public Function YK_Agent_FillYKinfo()
        Dim YKinfo As String() = YK_Agent_GetKeyInfo()
        lbl_monitor_yub_vendor_output.Text = YKinfo(0)
        lbl_monitor_yub_model_output.Text = YKinfo(1)
        lbl_monitor_yub_firmware_output.Text = YKinfo(3)
        lbl_monitor_yub_serial_output.Text = YKinfo(2)
        lbl_monitor_yub_touch_output.Text = YKinfo(4)
    End Function
End Class