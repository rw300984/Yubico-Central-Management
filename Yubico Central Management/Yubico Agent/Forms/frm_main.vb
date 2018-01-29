Imports System.ComponentModel

Public Class frm_main

    ' Load forms on start

    Dim frm_monitor As New frm_monitor
    Dim frm_admin As New frm_admin
    Dim frm_admin_save As New frm_admin_save
    Dim frm_initial As New frm_initial
    Dim frm_admin_personal As New frm_admin_personal
    Dim frm_plg_ykinv As New frm_plg_ykinv
    Dim login_count As Integer = 0
    Dim bgw_close_status As Integer = 0
    Dim bgw_plg_ykinv_status As Integer = 0
    Dim Agent_frms As New List(Of Form)

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
        ' CheckConfigFileAndLoadInitFrm(0)
        ShowHideCMS_Tray()
    End Sub

    ' On Left Mouse Click event show frm_main or close |  On Right Mouse Click event show cms_notify_agent

    Private Sub tray_notify_agent_MouseClick(sender As Object, e As MouseEventArgs) Handles tray_notify_agent.MouseClick
        frm_initial.txt_initial_enc_password.Text = ""
        CheckConfigFileAndLoadInitFrm(0)
        If e.Button = MouseButtons.Left Then
            ShowHideCMS_Tray()
        Else
            ShowForms("nothing")
            cms_notify_agent.Show()
        End If
    End Sub

    Public Function ShowHideCMS_Tray()
        If Me.WindowState = FormWindowState.Minimized Then
            bgw_plg_ykinv_status = 1
            PositionMainForm()
            CheckConfigFileAndLoadInitFrm(1)
        Else
            ShowForms("nothing")
        End If
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        File.Delete("close.bin")
        Agent_frms.Add(Me)
        Agent_frms.Add(frm_admin)
        Agent_frms.Add(frm_monitor)
        Agent_frms.Add(frm_admin_save)
        Agent_frms.Add(frm_initial)
        Agent_frms.Add(frm_admin_personal)
        Agent_frms.Add(frm_plg_ykinv)
        FillGlobalFixedVariables()
        LoadForms()
        bgw_close.RunWorkerAsync()
        bgw_plg_ykinv_start()
    End Sub

    Private Function LoadForms()
        PositionMainForm()
        Me.Visible = False
        DefaultFormProperties()
    End Function

    Public Function DefaultFormProperties()
        For Each frm In Agent_frms
            If frm.Name = "frm_main" Then
            Else
                frm.Visible = False
                frm.TopLevel = False
                frm.WindowState = FormWindowState.Maximized
                frm.FormBorderStyle = FormBorderStyle.None
                frm.Dock = DockStyle.Fill
                panel_main_form.Controls.Add(frm)
            End If
        Next
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

        ' localization for frm_plg_ykinv

        frm_plg_ykinv.lbl_frm_plg_ykinv.Text = cfg_lang.frm_plg_ykinv_lbl_frm_plg_ykinv
        frm_plg_ykinv.btn_frm_plg_ykinv_addname.Text = cfg_lang.frm_plg_ykinv_btn_frm_plg_ykinv_addname
        frm_plg_ykinv.btn_frm_plg_ykinv_ignore.Text = cfg_lang.frm_plg_ykinv_btn_frm_plg_ykinv_ignore

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
                DefaultShowForms()
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_empty
            Case "frm_admin"
                DefaultShowForms()
                frm_admin.Visible = True
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_admin_personal"
                DefaultShowForms()
                frm_admin_personal.Visible = True
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_monitor"
                DefaultShowForms()
                frm_monitor.Visible = True
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_open
            Case "frm_admin_save"
                DefaultShowForms()
                frm_admin_save.Visible = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_close
            Case "frm_initial"
                DefaultShowForms()
                frm_initial.lbl_initial_enc.Text = cfg_lang.frm_initial_lbl_initial_enc
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_initial
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                frm_initial.Visible = True
            Case "frm_initial_login"
                DefaultShowForms()
                frm_initial.lbl_initial_enc.Text = cfg_lang.frm_initial_lbl_initial_enc_login
                Me.btn_main_admin_login.Enabled = True
                Me.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_login
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                frm_initial.Visible = True
            Case "frm_plg_ykinv"
                DefaultShowForms()
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                Me.btn_main_admin_login.Visible = False
                My.Forms.frm_plg_ykinv.txt_frm_plg_ykinv.BackColor = Color.AliceBlue
                frm_plg_ykinv.Visible = True
            Case "nothing"
                DefaultShowForms()
                frm_monitor.bgw_status = 1
                bgw_plg_ykinv_start()
                Me.Visible = False
                Me.WindowState = FormWindowState.Minimized
        End Select
    End Function

    Public Function DefaultShowForms()
        '  FillTextWithLanguagefile()
        For Each frm In Agent_frms
            If frm.Name = "frm_main" Then
            Else
                frm.Visible = False
            End If
        Next
        Me.btn_main_admin_login.Visible = True
        Me.btn_main_admin_login.Enabled = False
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
        Dim count As Integer = 0
        GetGeoIPXML(cfg_config.integrity_geoip_file)
        Dim org_externalip As String = GetExternalIP()
        Do While bgw_close_status = 0
            Dim geo_info As geoip_data
            Select Case count
                Case 150
                    Dim new_externalip As String = GetExternalIP()
                    If org_externalip = new_externalip Then
                    Else
                        org_externalip = new_externalip
                        Select Case cfg_geoip.geoip_service_mode
                            Case "local"
                                geo_info = GetLocationFromMaxMindDB(new_externalip)
                            Case "web"
                                geo_info = GetLocationFromWeb()
                        End Select
                    End If
                Case 0
                    If org_externalip = "" Then
                        geo_info = GetLocationFromWeb()
                    Else
                        Select Case cfg_geoip.geoip_service_mode
                            Case "local"
                                geo_info = GetLocationFromMaxMindDB(org_externalip)
                            Case "web"
                                geo_info = GetLocationFromWeb()
                        End Select
                    End If
            End Select
            If count = 150 Or count = 0 Then
                If org_externalip <> "" Then
                    Dim FileWriter As New StreamWriter(Application.StartupPath & "/temp/geo.cache", True)
                    FileWriter.WriteLine(DateTime.Now & "," & geo_info.ip & "," & geo_info.country_code & "," & geo_info.country_name & "," & geo_info.region_code & "," & geo_info.region_name & "," & geo_info.city_name & "," & geo_info.city_postal & "," & geo_info.latitude & "," & geo_info.longtitude)
                    FileWriter.Close()
                End If
                count = 0
            End If
            count = count + 1
            If File.Exists(cfg_config.temp_path & "close.bin") Then
                bgw_plg_ykinv_status = 1
                File.Delete(cfg_config.temp_path & "close.bin")
                Application.Exit()
            End If
            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Public Function bgw_plg_ykinv_start()
        If bgw_plg_ykinv.IsBusy Then
        Else
            If System.IO.File.Exists(cfg_config.config_path_file) Then
                SetLanguage(Read_Config(cfg_config.config_path_file, "2"))
                ThemeForm(Read_Config(cfg_config.config_path_file, "3"))
                LoadStartUpConfig()
                bgw_plg_ykinv_status = 0
                bgw_plg_ykinv.RunWorkerAsync()
            End If
        End If
    End Function

    Private Sub bgw_plg_ykinv_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_plg_ykinv.DoWork
        Try
            Do While bgw_plg_ykinv_status = 0
                Dim ykinfo As String() = YK_Agent_GetFromykinfo()
                Dim ykinv As plg_ykinv.dt_serial
                Dim SerialDT As New DataTable
                If System.IO.File.Exists(Application.StartupPath & "\temp\serial.cache") Then
                    SerialDT.TableName = "SerialNumbers"
                    SerialDT.ReadXml(Application.StartupPath & "\temp\serial.cache")
                Else
                    SerialDT = Serial_CreateDataTable(SerialDT)
                End If
                If plg_ykinv.Serial_ExistInDT(SerialDT, ykinfo(0)) = True Then
                    ykinv = plg_ykinv.Serial_GetYubiKey(SerialDT, ykinfo(0))
                    cfg_ykinv.dt = SerialDT
                    cfg_ykinv.GUID = ykinv.GUID
                    cfg_ykinv.Serial = ykinv.Serial
                    cfg_ykinv.Name = ykinv.Name
                    If ykinv.Name = "" Or ykinv.Name = Nothing Then
                        bgw_plg_ykinv.ReportProgress(100)
                    Else
                    End If
                Else
                    plg_ykinv.Serial_AddToDatabase(SerialDT, ykinfo(0))
                    bgw_plg_ykinv.ReportProgress(100)

                End If
                Threading.Thread.Sleep(2000)
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bgw_plg_ykinv_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_plg_ykinv.ProgressChanged
        '  MessageBox.Show("Progress")
        If frm_plg_ykinv.Visible = True Then
            bgw_plg_ykinv_status = 1
        Else
            ShowForms("frm_plg_ykinv")
        End If
    End Sub
End Class
