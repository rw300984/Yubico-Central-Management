Public Class frm_main

    ' Load forms on start

    Dim frm_monitor As New frm_monitor
    Dim frm_admin As New frm_admin

    ' Context Menu strip item on click event to show version and copyright

    Private Sub cms_notify_agent_about_Click(sender As Object, e As EventArgs) Handles cms_notify_agent_about.Click
        tray_notify_agent.ShowBalloonTip(2000, "Yubico Agent", "Version: " & My.Application.Info.Version.Major & vbCrLf & My.Application.Info.Copyright, ToolTipIcon.Info)
    End Sub

    ' Context Menu Strip close the whole application

    Private Sub cms_notify_agent_close_Click(sender As Object, e As EventArgs) Handles cms_notify_agent_close.Click
        Application.Exit()
    End Sub

    ' Context Menu Strip open frm_main on click

    Private Sub cms_notify_agent_open_Click(sender As Object, e As EventArgs) Handles cms_notify_agent_open.Click
        If Me.WindowState = FormWindowState.Minimized Then
            PositionMainForm()
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            frm_monitor.Visible = True
            frm_monitor.Show()
        Else
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' On Left Mouse Click event show frm_main or close |  On Right Mouse Click event show cms_notify_agent

    Private Sub tray_notify_agent_MouseClick(sender As Object, e As MouseEventArgs) Handles tray_notify_agent.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Minimized Then
                PositionMainForm()
                Me.Show()
                Me.WindowState = FormWindowState.Normal
                frm_monitor.Visible = True
                frm_monitor.Show()
            Else
                Me.Hide()
                Me.WindowState = FormWindowState.Minimized
            End If
        Else
            cms_notify_agent.Show()
        End If
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForms()
    End Sub

    Private Function LoadForms()
        PositionMainForm()
        Me.Hide()
        frm_monitor.Hide()
        frm_admin.Hide()
        frm_admin.Visible = False
        frm_monitor.Visible = False

        frm_admin.TopLevel = False
        frm_admin.WindowState = FormWindowState.Maximized
        frm_admin.FormBorderStyle = FormBorderStyle.None
        frm_admin.Dock = DockStyle.Fill

        frm_monitor.TopLevel = False
        frm_monitor.WindowState = FormWindowState.Maximized
        frm_monitor.FormBorderStyle = FormBorderStyle.None
        frm_monitor.Dock = DockStyle.Fill

        panel_main_form.Controls.Add(frm_monitor)
        panel_main_form.Controls.Add(frm_admin)

        btn_main_admin_login.Text = "Open configuration"
        frm_monitor.grb_monitor_systeminfo.Text = "System information"
        frm_monitor.grb_monitor_yubiinfo.Text = "Yubikey information"
        frm_admin.grb_admin_general.Text = "General settings"
        frm_admin.grb_admin_management.Text = "Central management settings"
        frm_monitor.lbl_monitor_sys_devicemodel_text.Text = "Device model"
        '  frm_monitor.lbl_monitor_sys_geo_text.Text = "Geo location"
        frm_monitor.lbl_monitor_sys_hostname_text.Text = "Hostname"
        frm_monitor.lbl_monitor_sys_ip_text.Text = "IP address"
        frm_monitor.lbl_monitor_sys_os_text.Text = "OS"
        frm_monitor.lbl_monitor_sys_username_text.Text = "Username"
        ' frm_monitor.lbl_monitor_yub_capabilities_text.Text = "Features"
        frm_monitor.lbl_monitor_yub_firmware_text.Text = "Firmware"
        frm_monitor.lbl_monitor_yub_model_text.Text = "Model"
        frm_monitor.lbl_monitor_yub_serial_text.Text = "Serial"
        frm_monitor.lbl_monitor_yub_touch_text.Text = "Touch Level"
        frm_monitor.lbl_monitor_yub_vendor_text.Text = "Vendor"
        frm_admin.lbl_admin_central_auth.Text = "Authentication"
        frm_admin.lbl_admin_central_password.Text = "Password"
        frm_admin.lbl_admin_central_username.Text = "Username"
        frm_admin.lbl_admin_central_server.Text = "Server"
        frm_admin.lbl_admin_general_language.Text = "Language"
        frm_admin.lbl_admin_general_mode.Text = "Mode"
        frm_admin.lbl_admin_general_theme.Text = "Theme"
        cms_notify_agent_about.Text = "About"
        cms_notify_agent_close.Text = "Exit"
        cms_notify_agent_open.Text = "Open"

    End Function

    ' Show child forms on button click event (monitor / admin)

    Private Sub btn_main_admin_login_Click(sender As Object, e As EventArgs) Handles btn_main_admin_login.Click
        If btn_main_admin_login.Text = "Open configuration" Then
            frm_monitor.Visible = False
            frm_monitor.Hide()
            frm_admin.Visible = True
            frm_admin.Show()
            btn_main_admin_login.Text = "Close configuration"
        Else
            frm_monitor.Visible = True
            frm_monitor.Show()
            frm_admin.Visible = False
            frm_admin.Hide()
            btn_main_admin_login.Text = "Open configuration"
        End If
    End Sub
    Public Function PositionMainForm()
        Dim Size As Rectangle = FindDockedTaskBars(Screen.FromControl(Me).Bounds, Screen.FromControl(Me).WorkingArea)
        Dim Position As Integer = FindTaskbarlocation(Screen.FromControl(Me).Bounds, Screen.FromControl(Me).WorkingArea)
        Select Case Position
            Case 0
                Me.Left = Size.Right + 2
                Me.Top = Size.Bottom - 300 - 2
            Case 1
                Me.Left = Size.Left - 350 - 2
                Me.Top = Size.Bottom - 300 - 2
            Case 2
                Me.Left = Size.Right - 350 - 2
                Me.Top = Size.Bottom + 2
            Case 3
                Me.Left = Size.Right - 350 - 2
                Me.Top = Size.Top - 300 - 2
            Case 4
                Me.Left = Size.Right - 350 - 2
                Me.Top = Size.Top - 300 - 2
        End Select
    End Function
End Class
