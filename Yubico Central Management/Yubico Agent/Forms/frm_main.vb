Public Class frm_main

    ' Load forms on start

    Dim frm_monitor As New frm_monitor
    Dim frm_admin As New frm_admin
    Dim frm_admin_save As New frm_admin_save
    Dim frm_initial As New frm_initial



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
        ThemeForm()
        If Me.WindowState = FormWindowState.Minimized Then
            PositionMainForm()
            Me.Show()

            If System.IO.File.Exists("Config.xml") Then
                frm_monitor.Visible = True
                frm_monitor.Show()
                Me.btn_main_admin_login.Visible = True
                Me.btn_main_admin_login.Enabled = True
            Else
                frm_initial.Visible = True
                frm_initial.Show()
                Me.btn_main_admin_login.Visible = False
                Me.btn_main_admin_login.Enabled = False
            End If
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' On Left Mouse Click event show frm_main or close |  On Right Mouse Click event show cms_notify_agent

    Private Sub tray_notify_agent_MouseClick(sender As Object, e As MouseEventArgs) Handles tray_notify_agent.MouseClick
        ThemeForm()

        If e.Button = MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Minimized Then
                PositionMainForm()
                Me.Show()
                Me.WindowState = FormWindowState.Normal
                If System.IO.File.Exists("Config.xml") Then
                    frm_monitor.Visible = True
                    frm_monitor.Show()
                    Me.btn_main_admin_login.Visible = True
                    Me.btn_main_admin_login.Enabled = True
                Else
                    frm_initial.Visible = True
                    frm_initial.Show()
                    Me.btn_main_admin_login.Visible = False
                    Me.btn_main_admin_login.Enabled = False
                End If

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

        frm_admin_save.TopLevel = False
        frm_admin_save.WindowState = FormWindowState.Maximized
        frm_admin_save.FormBorderStyle = FormBorderStyle.None
        frm_admin_save.Dock = DockStyle.Fill

        frm_initial.TopLevel = False
        frm_initial.WindowState = FormWindowState.Maximized
        frm_initial.FormBorderStyle = FormBorderStyle.None
        frm_initial.Dock = DockStyle.Fill

        panel_main_form.Controls.Add(frm_monitor)
        panel_main_form.Controls.Add(frm_admin)
        panel_main_form.Controls.Add(frm_admin_save)
        panel_main_form.Controls.Add(frm_initial)

        ' localization for frm_main

        btn_main_admin_login.Text = "Open configuration"

        ' localization for frm_monitor

        frm_initial.btn_initial_save.Text = "Save Key and start Yubico Agent"
        frm_initial.lbl_initial_enc.Text = "Please enter a new encryption key:"


        ' localization for frm_monitor

        frm_monitor.grb_monitor_systeminfo.Text = "System information"
        frm_monitor.grb_monitor_yubiinfo.Text = "Yubikey information"
        frm_monitor.lbl_monitor_sys_devicemodel_text.Text = "Device model"
        frm_monitor.lbl_monitor_sys_hostname_text.Text = "Hostname"
        frm_monitor.lbl_monitor_sys_ip_text.Text = "IP address"
        frm_monitor.lbl_monitor_sys_os_text.Text = "OS"
        frm_monitor.lbl_monitor_sys_username_text.Text = "Username"
        frm_monitor.lbl_monitor_yub_firmware_text.Text = "Firmware"
        frm_monitor.lbl_monitor_yub_model_text.Text = "Model"
        frm_monitor.lbl_monitor_yub_serial_text.Text = "Serial"
        frm_monitor.lbl_monitor_yub_touch_text.Text = "Touch level"
        frm_monitor.lbl_monitor_yub_vendor_text.Text = "Vendor"

        ' localization for frm_admin

        frm_admin.grb_admin_general.Text = "General settings"
        frm_admin.grb_admin_management.Text = "Central management settings"
        frm_admin.lbl_admin_central_auth.Text = "Authentication"
        frm_admin.lbl_admin_central_password.Text = "Password"
        frm_admin.lbl_admin_central_username.Text = "Username"
        frm_admin.lbl_admin_central_server.Text = "Server"
        frm_admin.lbl_admin_general_language.Text = "Language"
        frm_admin.lbl_admin_general_mode.Text = "Mode"
        frm_admin.lbl_admin_general_theme.Text = "Theme"

        ' localization for frm_admin_save

        frm_admin_save.lbl_admin_save.Text = "Are you sure?"
        frm_admin_save.btn_admin_save_no.Text = "No"
        frm_admin_save.btn_admin_save_yes.Text = "Yes"

        ' localization for contextmenu (notifyicon)

        cms_notify_agent_about.Text = "About"
        cms_notify_agent_close.Text = "Exit"
        cms_notify_agent_open.Text = "Open"

    End Function

    ' Show child forms on button click event (monitor / admin)

    Private Sub btn_main_admin_login_Click(sender As Object, e As EventArgs) Handles btn_main_admin_login.Click
        Select Case btn_main_admin_login.Text
            Case "Open configuration"
                frm_monitor.Visible = False
                frm_monitor.Hide()
                frm_admin_save.Visible = False
                frm_admin_save.Hide()
                frm_admin.Visible = True
                frm_admin.Show()
                btn_main_admin_login.Text = "Close configuration"
            Case "Close configuration"
                frm_monitor.Visible = True
                frm_monitor.Show()
                frm_admin_save.Visible = False
                frm_admin_save.Hide()
                frm_admin.Visible = False
                frm_admin.Hide()
                btn_main_admin_login.Text = "Open configuration"
            Case "Save configuration"
                frm_monitor.Visible = False
                frm_monitor.Hide()
                frm_admin.Visible = False
                frm_admin.Hide()
                frm_admin_save.Visible = True
                frm_admin_save.Show()
                btn_main_admin_login.Text = "Close configuration"
            Case Else

        End Select
    End Sub

    Public Function PositionMainForm()
        Dim Size As Rectangle = FindDockedTaskBars(Screen.FromControl(Me).Bounds, Screen.FromControl(Me).WorkingArea)
        Dim Position As Integer = FindTaskbarlocation(Screen.FromControl(Me).Bounds, Screen.FromControl(Me).WorkingArea)
        Select Case Position
            Case 0
                Me.Left = Size.Right + 2
                Me.Top = Size.Bottom - Me.MaximumSize.Height - 2
            Case 1
                Me.Left = Size.Left - Me.MaximumSize.Width - 2
                Me.Top = Size.Bottom - Me.MaximumSize.Height - 2
            Case 2
                Me.Left = Size.Right - Me.MaximumSize.Width - 2
                Me.Top = Size.Bottom + 2
            Case 3
                Me.Left = Size.Right - Me.MaximumSize.Width - 2
                Me.Top = Size.Top - Me.MaximumSize.Height - 2
            Case 4
                Me.Left = Size.Right - Me.MaximumSize.Width - 2
                Me.Top = Size.Top - Me.MaximumSize.Height - 2
        End Select
    End Function

    Public Function ThemeForm()
        Dim Agent_frms As New List(Of Form)
        Agent_frms.Add(Me)
        Agent_frms.Add(frm_admin)
        Agent_frms.Add(frm_monitor)
        Agent_frms.Add(frm_admin_save)
        Agent_frms.Add(frm_initial)

        For Each frm As Form In Agent_frms
            Change_theme(frm, "Gray (default)")
        Next
    End Function
End Class
