Public Class frm_initial
    Dim old_btn_text

    Private Sub frm_initial_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_initial_enc_password.AutoSize = False
        txt_initial_enc_password.Size = New System.Drawing.Size(121, 25)
    End Sub

    Private Sub frm_initial_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Visible Then
            old_btn_text = frm_main.btn_main_admin_login.Text
        End If
    End Sub

    Private Sub txt_initial_enc_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_initial_enc_password.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            My.Forms.frm_main.btn_main_admin_login.PerformClick()
        End If
    End Sub

    Private Sub txt_initial_enc_password_TextChanged(sender As Object, e As EventArgs) Handles txt_initial_enc_password.TextChanged
        cfg_config.initial_verify = txt_initial_enc_password.Text
        Dim mode As Integer
        Select Case frm_main.btn_main_admin_login.Text
            Case cfg_lang.btn_main_admin_login_initial
                mode = 1
            Case cfg_lang.btn_main_admin_login_initial_password_complexity
                mode = 1
            Case Else
                mode = 0
        End Select
        If mode = 1 Then
            Dim status As Boolean = Crypto.ValidatePassword(cfg_config.initial_verify)
            Select Case status
                Case False
                    My.Forms.frm_main.btn_main_admin_login.Enabled = False
                    frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_initial_password_complexity
                Case True
                    My.Forms.frm_main.btn_main_admin_login.Enabled = True
                    frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_initial
                    frm_main.btn_main_admin_login.Update()
            End Select
        Else

        End If
    End Sub
End Class