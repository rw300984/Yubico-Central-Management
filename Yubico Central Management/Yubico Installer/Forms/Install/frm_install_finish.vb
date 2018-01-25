Public Class frm_install_finish
    Private Sub frm_install_finish_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If cfg.install_password_mode = 0 Then
            My.Forms.frm_main.RoundedPanel1.BackColor = Color.FromArgb(154, 202, 60)
            My.Forms.frm_main.RoundedPanel1.BorderColor = Color.FromArgb(154, 202, 60)
            My.Forms.frm_main.RoundedPanel1.Visible = True
            My.Forms.frm_main.Label1.Text = "Your Yubico Agent password is: " & cfg.install_password_random
        End If
    End Sub
End Class