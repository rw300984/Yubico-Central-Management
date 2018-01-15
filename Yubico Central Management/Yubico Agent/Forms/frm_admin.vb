Public Class frm_admin
    Private Sub cbx_admin_central_auth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_central_auth.SelectedIndexChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub cbx_admin_general_language_SelectedIndexChanged(sender As Object, e As EventArgs)
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub cbx_admin_general_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_mode.SelectedIndexChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub cbx_admin_general_theme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_theme.SelectedIndexChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"

    End Sub

    Private Sub txt_admin_central_password_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_password.TextChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub txt_admin_central_server_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_server.TextChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub txt_admin_central_username_TextChanged(sender As Object, e As EventArgs) Handles txt_admin_central_username.TextChanged
        My.Forms.frm_main.btn_main_admin_login.Text = "Save configuration"
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_admin_central_password.AutoSize = False
        txt_admin_central_server.AutoSize = False
        txt_admin_central_username.AutoSize = False
        txt_admin_central_server.Size = New System.Drawing.Size(121, 23)
        txt_admin_central_username.Size = New System.Drawing.Size(121, 23)
        txt_admin_central_password.Size = New System.Drawing.Size(121, 23)
    End Sub
End Class