﻿Module Localization
    Public cfg_lang As configuration
    Public Structure configuration
        Dim btn_main_admin_login_open As String
        Dim btn_main_admin_login_save As String
        Dim btn_main_admin_login_close As String
        Dim btn_main_admin_login_initial As String
        Dim btn_main_admin_login_login As String
        Dim btn_main_admin_login_login_failed As String
        Dim btn_main_admin_login_login_success As String
        Dim btn_main_admin_login_empty As String
        Dim frm_initial_lbl_initial_enc As String
        Dim frm_monitor_grb_monitor_systeminfo As String
        Dim frm_monitor_grb_monitor_yubiinfo As String
        Dim frm_monitor_lbl_monitor_sys_devicemodel_text As String
        Dim frm_monitor_lbl_monitor_sys_hostname_text As String
        Dim frm_monitor_lbl_monitor_sys_ip_text As String
        Dim frm_monitor_lbl_monitor_sys_os_text As String
        Dim frm_monitor_lbl_monitor_sys_username As String
        Dim frm_monitor_lbl_monitor_yub_firmware_text As String
        Dim frm_monitor_lbl_monitor_yub_model_text As String
        Dim frm_monitor_lbl_monitor_yub_serial_text As String
        Dim frm_monitor_lbl_monitor_yub_touch_text As String
        Dim frm_monitor_lbl_monitor_yub_vendor_text As String
        Dim frm_admin_grb_admin_general As String
        Dim frm_admin_grb_admin_management As String
        Dim frm_admin_lbl_admin_central_auth As String
        Dim frm_admin_lbl_admin_central_password As String
        Dim frm_admin_lbl_admin_central_username As String
        Dim frm_admin_lbl_admin_central_server As String
        Dim frm_admin_lbl_admin_general_language As String
        Dim frm_admin_lbl_admin_general_mode As String
        Dim frm_admin_lbl_admin_general_theme As String
        Dim frm_admin_save_lbl_admin_save As String
        Dim frm_admin_save_btn_admin_save_no As String
        Dim frm_admin_save_btn_admin_save_yes As String
        Dim cms_notify_agent_about As String
        Dim cms_notify_agent_close As String
        Dim cms_notify_agent_open As String
        Dim frm_initial_lbl_initial_enc_login As String
    End Structure

    Public Function GetLanguage(ByVal lang As String)
        Dim counter As Integer = 0
        cfg_lang.btn_main_admin_login_open = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_save = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_close = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_initial = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_login = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_login_failed = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_login_success = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.btn_main_admin_login_empty = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_initial_lbl_initial_enc = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_grb_monitor_systeminfo = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_grb_monitor_yubiinfo = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_sys_devicemodel_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_sys_hostname_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_sys_ip_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_sys_os_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_sys_username = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_yub_firmware_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_yub_model_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_yub_serial_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_yub_touch_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_monitor_lbl_monitor_yub_vendor_text = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_grb_admin_general = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_grb_admin_management = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_central_auth = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_central_password = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_central_username = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_central_server = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_general_language = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_general_mode = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_lbl_admin_general_theme = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_save_lbl_admin_save = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_save_btn_admin_save_no = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_admin_save_btn_admin_save_yes = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.cms_notify_agent_about = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.cms_notify_agent_close = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.cms_notify_agent_open = Read_Config(lang, counter)
        counter = counter + 1
        cfg_lang.frm_initial_lbl_initial_enc_login = Read_Config(lang, counter)
        counter = counter + 1
    End Function
End Module
