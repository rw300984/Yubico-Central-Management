Imports System.ComponentModel

Public Class frm_main

    ' Load forms on start

    Dim frm_monitor As New frm_monitor
    Dim frm_admin As New frm_admin
    Dim frm_admin_save As New frm_admin_save
    Dim frm_initial As New frm_initial
    Dim frm_admin_personal As New frm_admin_personal
    Dim login_count As Integer = 0
    Dim bgw_close_status As Integer = 0

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
        frm_initial.txt_initial_enc_password.Text = ""
        CheckConfigFileAndLoadInitFrm(0)
        If Me.WindowState = FormWindowState.Minimized Then
            PositionMainForm()
            CheckConfigFileAndLoadInitFrm(1)
        Else
            ShowForms("nothing")
        End If
    End Sub

    ' On Left Mouse Click event show frm_main or close |  On Right Mouse Click event show cms_notify_agent

    Private Sub tray_notify_agent_MouseClick(sender As Object, e As MouseEventArgs) Handles tray_notify_agent.MouseClick
        frm_initial.txt_initial_enc_password.Text = ""
        CheckConfigFileAndLoadInitFrm(0)
        If e.Button = MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Minimized Then
                PositionMainForm()
                CheckConfigFileAndLoadInitFrm(1)
            Else
                ShowForms("nothing")
            End If
        Else
            ShowForms("nothing")
            cms_notify_agent.Show()
        End If
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        '   System.Reflection.Assembly.LoadFile(Application.StartupPath & "\plugins\geoip\MaxMind.Db.dll")
        '  System.Reflection.Assembly.LoadFile(Application.StartupPath & "\plugins\geoip\MaxMind.GeoIP2.dll")
        ' System.Reflection.Assembly.LoadFile(Application.StartupPath & "\plugins\geoip\Newtonsoft.Json.dll")

        File.Delete("close.bin")
        bgw_close.RunWorkerAsync()
        FillGlobalFixedVariables()
        LoadForms()
    End Sub

    Private Function LoadForms()
        PositionMainForm()
        Me.Visible = False
        frm_admin.Visible = False
        frm_monitor.Visible = False
        frm_admin_save.Visible = False
        frm_admin_personal.Visible = False
        frm_initial.Visible = False

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

        frm_admin_personal.TopLevel = False
        frm_admin_personal.WindowState = FormWindowState.Maximized
        frm_admin_personal.FormBorderStyle = FormBorderStyle.None
        frm_admin_personal.Dock = DockStyle.Fill

        panel_main_form.Controls.Add(frm_monitor)
        panel_main_form.Controls.Add(frm_admin)
        panel_main_form.Controls.Add(frm_admin_save)
        panel_main_form.Controls.Add(frm_initial)
        panel_main_form.Controls.Add(frm_admin_personal)
    End Function

    Public Function FillTextWithLanguagefile()
        frm_initial.lbl_initial_enc.Text = cfg_lang.frm_initial_lbl_initial_enc
        frm_monitor.grb_monitor_systeminfo.Text = cfg_lang.frm_monitor_grb_monitor_systeminfo
        frm_monitor.grb_monitor_yubiinfo.Text = cfg_lang.frm_monitor_grb_monitor_yubiinfo
        frm_monitor.lbl_monitor_sys_devicemodel_text.Text = cfg_lang.frm_monitor_lbl_monitor_sys_devicemodel_text
        frm_monitor.lbl_monitor_sys_hostname_text.Text = cfg_lang.frm_monitor_lbl_monitor_sys_hostname_text
        frm_monitor.lbl_monitor_sys_ip_text.Text = cfg_lang.frm_monitor_lbl_monitor_sys_ip_text
        frm_monitor.lbl_monitor_sys_os_text.Text = cfg_lang.frm_monitor_lbl_monitor_sys_os_text
        frm_monitor.lbl_monitor_sys_username_text.Text = cfg_lang.frm_monitor_lbl_monitor_sys_username
        frm_monitor.lbl_monitor_yub_firmware_text.Text = cfg_lang.frm_monitor_lbl_monitor_yub_firmware_text
        frm_monitor.lbl_monitor_yub_model_text.Text = cfg_lang.frm_monitor_lbl_monitor_yub_model_text
        frm_monitor.lbl_monitor_yub_serial_text.Text = cfg_lang.frm_monitor_lbl_monitor_yub_serial_text
        frm_monitor.lbl_monitor_yub_touch_text.Text = cfg_lang.frm_monitor_lbl_monitor_yub_touch_text
        frm_monitor.lbl_monitor_yub_vendor_text.Text = cfg_lang.frm_monitor_lbl_monitor_yub_vendor_text

        ' localization for frm_admin

        frm_admin.grb_admin_general.Text = cfg_lang.frm_admin_grb_admin_general
        frm_admin.grb_admin_management.Text = cfg_lang.frm_admin_grb_admin_management
        frm_admin.lbl_admin_central_auth.Text = cfg_lang.frm_admin_lbl_admin_central_auth
        frm_admin.lbl_admin_central_password.Text = cfg_lang.frm_admin_lbl_admin_central_password
        frm_admin.lbl_admin_central_username.Text = cfg_lang.frm_admin_lbl_admin_central_username
        frm_admin.lbl_admin_central_server.Text = cfg_lang.frm_admin_lbl_admin_central_server
        frm_admin.lbl_admin_general_language.Text = cfg_lang.frm_admin_lbl_admin_general_language
        frm_admin.lbl_admin_general_mode.Text = cfg_lang.frm_admin_lbl_admin_general_mode
        frm_admin.lbl_admin_general_theme.Text = cfg_lang.frm_admin_lbl_admin_general_theme

        ' localization for frm_admin_save

        frm_admin_save.lbl_admin_save.Text = cfg_lang.frm_admin_save_lbl_admin_save
        frm_admin_save.btn_admin_save_no.Text = cfg_lang.frm_admin_save_btn_admin_save_no
        frm_admin_save.btn_admin_save_yes.Text = cfg_lang.frm_admin_save_btn_admin_save_yes

        ' localization for contextmenu (notifyicon)

        cms_notify_agent_about.Text = cfg_lang.cms_notify_agent_about
        cms_notify_agent_close.Text = cfg_lang.cms_notify_agent_close
        cms_notify_agent_open.Text = cfg_lang.cms_notify_agent_open

        ' locatilization for frm_admin_personal

        frm_admin_personal.lbl_admin_general_language.Text = cfg_lang.frm_admin_lbl_admin_general_language
        frm_admin_personal.lbl_admin_general_mode.Text = cfg_lang.frm_admin_lbl_admin_general_mode
        frm_admin_personal.lbl_admin_general_theme.Text = cfg_lang.frm_admin_lbl_admin_general_theme
        frm_admin_personal.lbl_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_lbl_admin_personal_yubi_driver
        frm_admin_personal.lbl_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_lbl_admin_personal_yubi_personalization
        frm_admin_personal.lbl_admin_personal_yubi_pivmanager.Text = cfg_lang.frm_admin_personal_lbl_admin_personal_yubi_pivmanager
        frm_admin_personal.grb_admin_general.Text = cfg_lang.frm_admin_grb_admin_general
        frm_admin_personal.grb_admin_personal_tools.Text = cfg_lang.frm_admin_personal_grb_admin_personal_tools

        Dim tools_installed As String() = CheckVersionOfTools()

        If tools_installed(0) = "0" Then

            frm_admin_personal.btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_download
        Else
            frm_admin_personal.btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_installed & " (" & tools_installed(0) & ")"
            frm_admin_personal.btn_admin_personal_yubi_driver.Enabled = False
        End If
        If tools_installed(1) = "0" Then
            frm_admin_personal.btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_download
        Else

            frm_admin_personal.btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & tools_installed(1) & ")"

        End If
        If tools_installed(2) = "0" Then

            frm_admin_personal.btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_download
        Else

            frm_admin_personal.btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & tools_installed(2) & ")"
        End If
    End Function

    ' Show child forms on button click event (monitor / admin)

    Private Sub btn_main_admin_login_Click(sender As Object, e As EventArgs) Handles btn_main_admin_login.Click
        Select Case btn_main_admin_login.Text
            Case cfg_lang.btn_main_admin_login_open
                Dim Integrity As Integer = IntegrityCheck(1)
                If Integrity = 0 Then
                    Select Case cfg_config.admin_general_mode
                        Case "Personal"
                            ShowForms("frm_admin_personal")
                        Case "Business"
                            ShowForms("frm_admin")
                    End Select
                Else
                    IntegrityFailedFor_btn_admin_login()
                End If
            Case cfg_lang.btn_main_admin_login_close
                Dim Integrity As Integer = IntegrityCheck(1)
                If Integrity = 0 Then
                    ShowForms("frm_monitor")
                Else
                    IntegrityFailedFor_btn_admin_login()
                End If
            Case cfg_lang.btn_main_admin_login_save
                Dim Integrity As Integer = IntegrityCheck(1)
                If Integrity = 0 Then
                    ShowForms("frm_admin_save")
                Else
                    IntegrityFailedFor_btn_admin_login()
                End If
            Case cfg_lang.btn_main_admin_login_initial
                cfg_config.initial_enabled = 0
                cfg_config.admin_general_mode = "Personal"
                cfg_config.admin_general_theme = "Gray (default)"
                cfg_config.admin_general_lang = "English"
                Config.Write_Config(cfg_config.config_path_file, frm_initial.txt_initial_enc_password.Text)
                Config.GetConfig(cfg_config.config_path_file, frm_initial.txt_initial_enc_password.Text)
                FillControlsWithConfig()
                ShowForms("frm_monitor")
            Case cfg_lang.btn_main_admin_login_login
                Config.GetConfig(cfg_config.config_path_file, frm_initial.txt_initial_enc_password.Text)
                If cfg_config.initial_verify = frm_initial.txt_initial_enc_password.Text Then
                    Dim integrity As Integer = IntegrityCheck(0)
                    If integrity = 0 Then
                        btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login_success
                        btn_main_admin_login.Update()
                        FillControlsWithConfig()
                        Threading.Thread.Sleep(1000)
                        ShowForms("frm_monitor")
                        login_count = 0
                    Else
                        IntegrityFailedFor_btn_admin_login()
                    End If
                Else
                    If login_count > 3 Then
                        btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login_failed_count_reached
                        btn_main_admin_login.BackColor = Color.Coral
                        btn_main_admin_login.Update()
                        Threading.Thread.Sleep(5000)
                        Application.Exit()
                    Else
                        Dim delay As Integer = 0
                        If login_count = 0 Then
                            delay = 5000
                        Else
                            delay = 5000 * (login_count + 1)
                        End If
                        btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login_failed & cfg_lang.btn_main_admin_login_login_failed_delay & delay / 1000
                        btn_main_admin_login.BackColor = Color.Coral
                        btn_main_admin_login.Update()
                        If login_count = 0 Then
                            Threading.Thread.Sleep(delay)
                        Else
                            Threading.Thread.Sleep(delay)
                        End If
                        btn_main_admin_login.BackColor = Color.FromArgb(154, 202, 60)
                        btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login
                        btn_main_admin_login.Update()
                        login_count = login_count + 1
                    End If
                End If
            Case Else
        End Select
    End Sub

    Public Function SetLanguage(ByVal lang As String)
        Dim languagefile As String
        Select Case lang
            Case "English"
                languagefile = cfg_config.integrity_lang_en_file
            Case "Deutsch"
                languagefile = cfg_config.integrity_lang_de_file
            Case Else
                languagefile = cfg_config.integrity_lang_en_file
        End Select
        GetLanguage(languagefile)
    End Function

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

    Public Function ThemeForm(ByVal theme As String)
        Dim Agent_frms As New List(Of Form)
        Agent_frms.Add(Me)
        Agent_frms.Add(frm_admin)
        Agent_frms.Add(frm_monitor)
        Agent_frms.Add(frm_admin_save)
        Agent_frms.Add(frm_initial)
        Agent_frms.Add(frm_admin_personal)

        Dim Agent_ctrls As New List(Of Control)

        Agent_ctrls.Add(cms_notify_agent)

        For Each frm As Form In Agent_frms
            Change_theme_frm(frm, theme)
        Next
        For Each ctr As Control In Agent_ctrls
            Change_theme_controls(ctr, theme)
        Next
    End Function

    Public Function ShowForms(ByVal form As String)
        Select Case form
            Case "frm_main"
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = False
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
                Me.btn_main_admin_login.Enabled = False
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_empty
            Case "frm_admin"
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = False
                frm_admin.Visible = True
                frm_admin_personal.Visible = False
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_admin_personal"
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = False
                frm_admin.Visible = False
                frm_admin_personal.Visible = True
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_monitor"
                frm_monitor.Visible = True
                frm_admin_save.Visible = False
                frm_initial.Visible = False
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_open
            Case "frm_admin_save"
                frm_monitor.Visible = False
                frm_admin_save.Visible = True
                frm_initial.Visible = False
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
                Me.btn_main_admin_login.Enabled = False
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_initial"
                frm_initial.lbl_initial_enc.Text = cfg_lang.frm_initial_lbl_initial_enc
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_initial
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = True
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
            Case "frm_initial_login"
                frm_initial.lbl_initial_enc.Text = cfg_lang.frm_initial_lbl_initial_enc_login
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = True
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
            Case "nothing"
                frm_monitor.bgw_status = 1
                Me.Visible = False
                Me.WindowState = FormWindowState.Minimized
                frm_monitor.Visible = False
                frm_admin_save.Visible = False
                frm_initial.Visible = False
                frm_admin.Visible = False
                frm_admin_personal.Visible = False
        End Select
    End Function

    Public Function FillControlsWithConfig()
        frm_admin.txt_admin_central_password.Text = cfg_config.admin_central_password
        frm_admin.txt_admin_central_username.Text = cfg_config.admin_central_username
        frm_admin.txt_admin_central_server.Text = cfg_config.admin_central_server
        frm_admin.cbx_admin_central_auth.Text = cfg_config.admin_central_auth
        frm_admin.cbx_admin_general_language.Text = cfg_config.admin_general_lang
        frm_admin.cbx_admin_general_mode.Text = cfg_config.admin_general_mode
        frm_admin.cbx_admin_general_theme.Text = cfg_config.admin_general_theme
        frm_admin_personal.cbx_admin_general_language.Text = cfg_config.admin_general_lang
        frm_admin_personal.cbx_admin_general_mode.Text = cfg_config.admin_general_mode
        frm_admin_personal.cbx_admin_general_theme.Text = cfg_config.admin_general_theme
    End Function

    Public Function IntegrityCheck(ByVal Mode As Integer) As Integer
        Dim status As Integer = 0

        Dim new_integrity_files As New List(Of String)
        new_integrity_files.Add(SHA1FileHash(cfg_config.integrity_lang_de_file))
        new_integrity_files.Add(SHA1FileHash(cfg_config.integrity_lang_en_file))
        new_integrity_files.Add(SHA1FileHash(cfg_config.integrity_tools_file))
        new_integrity_files.Add(SHA1FileHash(cfg_config.integrity_geoip_file))

        Dim org_integrity_files As New List(Of String)
        org_integrity_files.Add(cfg_config.integrity_lang_de)
        org_integrity_files.Add(cfg_config.integrity_lang_en)
        org_integrity_files.Add(cfg_config.integrity_tools)
        org_integrity_files.Add(cfg_config.integrity_geoip)

        Select Case Mode
            Case 1
                If frm_initial.Visible = True Then
                    status = status + 1
                End If
                Dim count As Integer = 0
                For Each sha1_file As String In new_integrity_files
                    If sha1_file <> org_integrity_files(count) Then

                        status = status + 1
                        count = count + 1
                    Else
                        count = count + 1
                    End If
                Next
            Case 0
                Dim count As Integer = 0
                For Each sha1_file As String In new_integrity_files
                    If sha1_file <> org_integrity_files(count) Then

                        status = status + 1
                        count = count + 1
                    Else
                        count = count + 1
                    End If
                Next
        End Select
        Return status
    End Function
    Public Function IntegrityFailedFor_btn_admin_login()
        btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_integrity
        btn_main_admin_login.Update()
        btn_main_admin_login.BackColor = Color.Coral
        btn_main_admin_login.Update()
        Threading.Thread.Sleep(5000)
        Application.Exit()
    End Function

    Public Function CheckConfigFileAndLoadInitFrm(ByVal Mode As Integer)
        Select Case Mode
            Case 0
                If System.IO.File.Exists(cfg_config.config_path_file) Then
                    ThemeForm(Read_Config(cfg_config.config_path_file, "3"))
                    SetLanguage(Read_Config(cfg_config.config_path_file, "2"))
                    LoadStartUpConfig()
                Else
                    ThemeForm("Gray (default)")
                    SetLanguage("English")
                End If
            Case 1
                If System.IO.File.Exists(cfg_config.config_path_file) Then
                    If Read_Config(cfg_config.config_path_file, "1") = 1 Then
                        ShowForms("frm_initial")
                    Else
                        ShowForms("frm_initial_login")
                    End If
                Else
                    ShowForms("frm_initial")
                End If
        End Select
    End Function

    Public Function LoadStartUpConfig()
        GetToolsXML(cfg_config.integrity_tools_file)
        GetGeoIPXML(cfg_config.integrity_geoip_file)
        FillTextWithLanguagefile()
    End Function



    Public Function FillGlobalFixedVariables()
        cfg_config.integrity_lang_de_file = Application.StartupPath & "\Lang\de.xml"
        cfg_config.integrity_lang_en_file = Application.StartupPath & "\Lang\en.xml"
        cfg_config.integrity_tools_file = Application.StartupPath & "\Config\tools.xml"
        cfg_config.integrity_geoip_file = Application.StartupPath & "\Config\geoip.xml"
        cfg_config.config_path_file = Application.StartupPath & "\Config\config.xml"
        cfg_config.temp_path = Application.StartupPath & "\temp\"

        If Directory.Exists(cfg_config.temp_path) Then
        Else
            Directory.CreateDirectory(cfg_config.temp_path)
        End If
    End Function

    Private Sub bgw_close_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_close.DoWork
        Do While bgw_close_status = 0
            If File.Exists(cfg_config.temp_path & "close.bin") Then
                File.Delete(cfg_config.temp_path & "close.bin")
                Application.Exit()
            End If
            Threading.Thread.Sleep(2000)
        Loop
    End Sub
End Class
