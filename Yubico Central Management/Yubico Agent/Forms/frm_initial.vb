Public Class frm_initial
    Private Sub frm_initial_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_initial_enc_password.AutoSize = False
        txt_initial_enc_password.Size = New System.Drawing.Size(121, 25)
    End Sub

    Private Sub txt_initial_enc_password_TextChanged(sender As Object, e As EventArgs) Handles txt_initial_enc_password.TextChanged
        cfg_config.initial_verify = txt_initial_enc_password.Text
    End Sub
End Class