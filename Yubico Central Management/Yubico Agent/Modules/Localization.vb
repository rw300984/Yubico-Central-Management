Module Localization
    Public Function ChangeLanguage(ByVal Lang As String)
        Select Case Lang
            Case "DE"
                ' Localization for frm_main

                frm_main.btn_main_admin_login.Text = "Konfiguration öffnen"

                ' Localization for frm_monitor

                frm_monitor.grb_monitor_systeminfo.Text = "System Informationen"
                frm_monitor.grb_monitor_yubiinfo.Text = "Yubikey Informationen"
                frm_monitor.lbl_monitor_sys_devicemodel_text.Text = "Geräte / Modell"
                frm_monitor.lbl_monitor_sys_hostname_text.Text = "Rechnername"
                frm_monitor.lbl_monitor_sys_ip_text.Text = "IP address"
                frm_monitor.lbl_monitor_sys_os_text.Text = "OS"
                frm_monitor.lbl_monitor_sys_username_text.Text = "Benutzername"
                frm_monitor.lbl_monitor_yub_firmware_text.Text = "Firmware"
                frm_monitor.lbl_monitor_yub_model_text.Text = "Modell"
                frm_monitor.lbl_monitor_yub_serial_text.Text = "Seriennummer"
                frm_monitor.lbl_monitor_yub_touch_text.Text = "Touch Level"
                frm_monitor.lbl_monitor_yub_vendor_text.Text = "Hersteller"

                ' Localization for frm_admin

                frm_admin.grb_admin_general.Text = "Generelle Einstellungen"
                frm_admin.grb_admin_management.Text = "CMS Einstellungen"
                frm_admin.lbl_admin_central_auth.Text = "Authentifizierung"
                frm_admin.lbl_admin_central_password.Text = "Password"
                frm_admin.lbl_admin_central_username.Text = "Benutzername"
                frm_admin.lbl_admin_central_server.Text = "Server"
                frm_admin.lbl_admin_general_language.Text = "Sprache"
                frm_admin.lbl_admin_general_mode.Text = "Modus"
                frm_admin.lbl_admin_general_theme.Text = "Theme"

                ' Localization for frm_admin_save

                frm_admin_save.lbl_admin_save.Text = "Sind Sie sicher?"
                frm_admin_save.btn_admin_save_no.Text = "Nein"
                frm_admin_save.btn_admin_save_yes.Text = "Ja"

                ' Localization for ContextMenu (NotifyIcon)

                frm_main.cms_notify_agent_about.Text = "Über"
                frm_main.cms_notify_agent_close.Text = "Beenden"
                frm_main.cms_notify_agent_open.Text = "Öffnen"

            Case "EN"
                ' Localization for frm_main

                frm_main.btn_main_admin_login.Text = "Open configuration"

                ' Localization for frm_monitor

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
                frm_monitor.lbl_monitor_yub_touch_text.Text = "Touch Level"
                frm_monitor.lbl_monitor_yub_vendor_text.Text = "Vendor"

                ' Localization for frm_admin

                frm_admin.grb_admin_general.Text = "General settings"
                frm_admin.grb_admin_management.Text = "Central management settings"
                frm_admin.lbl_admin_central_auth.Text = "Authentication"
                frm_admin.lbl_admin_central_password.Text = "Password"
                frm_admin.lbl_admin_central_username.Text = "Username"
                frm_admin.lbl_admin_central_server.Text = "Server"
                frm_admin.lbl_admin_general_language.Text = "Language"
                frm_admin.lbl_admin_general_mode.Text = "Mode"
                frm_admin.lbl_admin_general_theme.Text = "Theme"

                ' Localization for frm_admin_save

                frm_admin_save.lbl_admin_save.Text = "Are you sure?"
                frm_admin_save.btn_admin_save_no.Text = "No"
                frm_admin_save.btn_admin_save_yes.Text = "Yes"

                ' Localization for ContextMenu (NotifyIcon)

                frm_main.cms_notify_agent_about.Text = "About"
                frm_main.cms_notify_agent_close.Text = "Exit"
                frm_main.cms_notify_agent_open.Text = "Open"
        End Select

    End Function
End Module
