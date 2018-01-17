Public Class frm_admin_personal
    Private Sub cbx_admin_general_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_language.SelectedIndexChanged
        cfg_config.admin_general_lang = cbx_admin_general_language.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub cbx_admin_general_theme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_theme.SelectedIndexChanged
        cfg_config.admin_general_theme = cbx_admin_general_theme.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub cbx_admin_general_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_admin_general_mode.SelectedIndexChanged
        cfg_config.admin_general_mode = cbx_admin_general_mode.Text
        My.Forms.frm_main.btn_main_admin_login.Text = cfg_lang.btn_main_admin_login_save
    End Sub

    Private Sub btn_admin_personal_yubi_driver_Click(sender As Object, e As EventArgs) Handles btn_admin_personal_yubi_driver.Click
        Select Case btn_admin_personal_yubi_driver.Text
            Case btn_admin_personal_yubi_driver.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                MessageBox.Show("let's install")
                btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run
            Case btn_admin_personal_yubi_driver.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar1.Visible = True
                btn_admin_personal_yubi_driver.Enabled = False
                btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground2("https://www.yubico.com/wp-content/uploads/2017/10/yubikey-smart-card-minidriver-3.3.1.5.zip", "yubikey-smart-card-minidriver-3.3.1.5.zip")
        End Select
    End Sub

    Private Sub btn_admin_personal_pivmanager_Click(sender As Object, e As EventArgs) Handles btn_admin_personal_pivmanager.Click
        Select Case True
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                MessageBox.Show("let's install")
                btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_run)
                MessageBox.Show("start application")
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar3.Visible = True
                btn_admin_personal_pivmanager.Enabled = False
                btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground4("https://developers.yubico.com/yubikey-piv-manager/Releases/yubikey-piv-manager-1.4.2d-win.exe", "yubikey-piv-manager-1.4.2d-win.exe")
        End Select
    End Sub

    Private Sub btn_admin_personal_yubi_personalization_Click(sender As Object, e As EventArgs) Handles btn_admin_personal_yubi_personalization.Click
        Select Case True
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                MessageBox.Show("let's install")
                btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_run)
                MessageBox.Show("start application")
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar2.Visible = True
                btn_admin_personal_yubi_personalization.Enabled = False
                btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground3("https://developers.yubico.com/yubikey-personalization-gui/Releases/yubikey-personalization-gui-3.1.24.exe", "yubikey-personalization-gui-3.1.24.exe")
        End Select

    End Sub

    ' Download 1

    Dim WithEvents WC1 As New System.Net.WebClient
    Public Sub DownLoadFileInBackground2(ByVal source As String, ByVal destination As String)
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateCertificate1
        System.Net.ServicePointManager.Expect100Continue = True
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        WC1.DownloadFileAsync(New Uri(source), destination)
    End Sub
    Private Function ValidateCertificate1(sender As Object, certificate As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Private Sub WC1_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WC1.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub WC1_DownloadProgressComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC1.DownloadFileCompleted
        btn_admin_personal_yubi_driver.Enabled = True
        btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
    End Sub

    ' Download 2

    Dim WithEvents WC2 As New System.Net.WebClient
    Public Sub DownLoadFileInBackground3(ByVal source As String, ByVal destination As String)
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateCertificate2
        System.Net.ServicePointManager.Expect100Continue = True
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        WC2.DownloadFileAsync(New Uri(source), destination)
    End Sub
    Private Function ValidateCertificate2(sender As Object, certificate As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Private Sub WC2_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WC2.DownloadProgressChanged
        ProgressBar2.Value = e.ProgressPercentage
    End Sub
    Private Sub WC2_DownloadProgressComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC2.DownloadFileCompleted
        btn_admin_personal_yubi_personalization.Enabled = True
        btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
    End Sub

    ' Download 3

    Dim WithEvents WC3 As New System.Net.WebClient
    Public Sub DownLoadFileInBackground4(ByVal source As String, ByVal destination As String)
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateCertificate3
        System.Net.ServicePointManager.Expect100Continue = True
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        WC3.DownloadFileAsync(New Uri(source), destination)
    End Sub
    Private Function ValidateCertificate3(sender As Object, certificate As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Private Sub WC3_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WC3.DownloadProgressChanged
        ProgressBar3.Value = e.ProgressPercentage
    End Sub
    Private Sub WC3_DownloadProgressComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC3.DownloadFileCompleted
        btn_admin_personal_pivmanager.Enabled = True
        btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
    End Sub
End Class