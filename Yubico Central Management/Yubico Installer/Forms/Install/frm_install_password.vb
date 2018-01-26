Public Class frm_install_password
    Private Sub frm_install_password_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cfg.install_password_mode = 0 Then
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
            cfg.install_password_mode = 0
            cfg.install_password_success = 1
            cfg.install_password_random = GeneratePassword(12)
            My.Forms.frm_main.btn_main_next.Enabled = True
            TextBox3.BackColor = Color.White
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
            cfg.install_password_mode = 1
            If Crypto.ValidatePassword(TextBox3.Text) = False Then
                cfg.install_password_success = 0
                TextBox3.BackColor = Color.LightCoral
                My.Forms.frm_main.btn_main_next.Enabled = False
            Else
                cfg.install_password_success = 1
                My.Forms.frm_main.btn_main_next.Enabled = True
                TextBox3.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim PasswordPolicy As Boolean = Crypto.ValidatePassword(TextBox3.Text)
        If PasswordPolicy = False Then
            TextBox3.BackColor = Color.LightCoral
            My.Forms.frm_main.btn_main_next.Enabled = False
        Else
            My.Forms.frm_main.btn_main_next.Enabled = True
            TextBox3.BackColor = Color.LightGreen
        End If
        cfg.install_password_custom = TextBox3.Text
        If TextBox3.Text = "" Then
            cfg.install_password_success = 0
        Else
            cfg.install_password_success = 1
        End If
    End Sub
End Class