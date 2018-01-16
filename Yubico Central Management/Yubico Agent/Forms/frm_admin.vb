Public Class frm_admin
    Private Sub cbx_admin_central_auth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_central_auth.SelectedIndexChanged
        cfg_config.admin_central_auth = cbx_admin_central_auth.Text
        ' My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub cbx_admin_general_language_SelectedIndexChanged(sender As Object, e As EventArgs)
        cfg_config.admin_general_lang = cbx_admin_general_language.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub cbx_admin_general_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_mode.SelectedIndexChanged
        cfg_config.admin_general_mode = cbx_admin_general_mode.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub cbx_admin_general_theme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_theme.SelectedIndexChanged
        cfg_config.admin_general_theme = cbx_admin_general_theme.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub txt_admin_central_password_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_password.TextChanged
        cfg_config.admin_central_password = txt_admin_central_password.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub txt_admin_central_server_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_server.TextChanged
        cfg_config.admin_central_server = txt_admin_central_server.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub txt_admin_central_username_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_username.TextChanged
        cfg_config.admin_central_username = txt_admin_central_username.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_admin_central_password.AutoSize = False
        txt_admin_central_server.AutoSize = False
        txt_admin_central_username.AutoSize = False
        txt_admin_central_server.Size = New System.Drawing.Size(121, 23)
        txt_admin_central_username.Size = New System.Drawing.Size(121, 23)
        txt_admin_central_password.Size = New System.Drawing.Size(121, 23)
    End Sub

    Private Sub cbx_admin_general_language_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_admin_general_language.SelectedIndexChanged
        cfg_config.admin_general_lang = cbx_admin_general_language.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub
End Class