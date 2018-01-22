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

        Select Case True
            Case btn_admin_personal_yubi_driver.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                Dim install_result As String = InstallDriver(cfg_config.temp_path & cfg_tools.yk_minidriver_pkg)
                If install_result <> "0" Then
                    btn_admin_personal_yubi_driver.Enabled = False
                    btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_installed & " (" & install_result & ")"
                Else
                    btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                End If
            Case btn_admin_personal_yubi_driver.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar1.Visible = True
                btn_admin_personal_yubi_driver.Enabled = False
                btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground2(cfg_tools.yk_minidriver_download, cfg_config.temp_path & cfg_tools.yk_minidriver_pkg)
        End Select
    End Sub

    Private Sub btn_admin_personal_pivmanager_Click(sender As Object, e As EventArgs) Handles btn_admin_personal_pivmanager.Click
        Select Case True
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                btn_admin_personal_pivmanager.Enabled = False
                Dim inst_result As Integer = tools.InstallTool(cfg_config.temp_path & cfg_tools.yk_piv_pkg)
                If inst_result = "1" Then
                    Dim count As Integer = 0
                    Dim status As Integer = 0
                    Dim version_array() As String = tools.CheckVersionOfTools()
                    Do While count < 60
                        Threading.Thread.Sleep(1000)
                        version_array = tools.CheckVersionOfTools()
                        If version_array(2) = "0" Then
                            count = count + 1
                        Else
                            count = 60
                            status = 1
                            btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & version_array(2) & ")"
                            System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_piv_pkg)
                            btn_admin_personal_pivmanager.Enabled = True
                        End If
                    Loop
                    If status = 0 Then
                        btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                    Else
                        btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & version_array(2) & ")"
                        System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_piv_pkg)
                        btn_admin_personal_pivmanager.Enabled = True
                    End If
                ElseIf inst_result = "0" Then
                    btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                Else
                End If
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_run)
                If StartTool("yk_piv") = 0 Then
                    btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                    btn_admin_personal_pivmanager.Enabled = False
                    btn_admin_personal_pivmanager.BackColor = Color.Coral
                Else

                End If
            Case btn_admin_personal_pivmanager.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar3.Visible = True
                btn_admin_personal_pivmanager.Enabled = False
                btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground4(cfg_tools.yk_piv_download, cfg_config.temp_path & cfg_tools.yk_piv_pkg)
        End Select
    End Sub

    Private Sub btn_admin_personal_yubi_personalization_Click(sender As Object, e As EventArgs) Handles btn_admin_personal_yubi_personalization.Click
        Select Case True
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_install)
                btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                btn_admin_personal_yubi_personalization.Enabled = False
                Dim inst_result As Integer = tools.InstallTool(cfg_config.temp_path & cfg_tools.yk_personal_pkg)
                If inst_result = "1" Then
                    Dim count As Integer = 0
                    Dim status As Integer = 0
                    Dim version_array() As String = tools.CheckVersionOfTools()
                    Do While count < 60
                        Threading.Thread.Sleep(1000)
                        version_array = tools.CheckVersionOfTools()
                        If version_array(1) = "0" Then
                            count = count + 1
                        Else
                            count = 60
                            status = 1
                            btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & version_array(1) & ")"
                            System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_personal_pkg)
                            btn_admin_personal_yubi_personalization.Enabled = True
                        End If
                    Loop
                    If status = 0 Then
                        btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                    Else
                        btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_run & " (" & version_array(1) & ")"
                        System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_personal_pkg)
                        btn_admin_personal_yubi_personalization.Enabled = True
                    End If
                ElseIf inst_result = "0" Then
                    btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                Else
                End If
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_run)
                If StartTool("yk_personal") = 0 Then
                    btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
                    btn_admin_personal_yubi_personalization.Enabled = False
                    btn_admin_personal_yubi_personalization.BackColor = Color.Coral
                Else

                End If
            Case btn_admin_personal_yubi_personalization.Text.Contains(cfg_lang.frm_admin_personal_btn_admin_personal_download)
                ProgressBar2.Visible = True
                btn_admin_personal_yubi_personalization.Enabled = False
                btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_wait
                DownLoadFileInBackground3(cfg_tools.yk_personal_download, cfg_config.temp_path & cfg_tools.yk_personal_pkg)
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
        Dim integrity As String = Downloader.SHA1_CheckDownload("yk_minidriver", cfg_config.temp_path & cfg_tools.yk_minidriver_pkg)
        btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_check
        btn_admin_personal_yubi_driver.Update()
        Threading.Thread.Sleep(2000)
        If integrity = 0 Then
            btn_admin_personal_yubi_driver.Enabled = False
            btn_admin_personal_yubi_driver.BackColor = Color.Coral
            btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
            System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_minidriver_pkg)
        Else
            btn_admin_personal_yubi_driver.Enabled = True
            btn_admin_personal_yubi_driver.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
            ProgressBar1.Visible = False
        End If
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
        Dim integrity As String = Downloader.SHA1_CheckDownload("yk_personal", cfg_config.temp_path & cfg_tools.yk_personal_pkg)
        btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_check
        btn_admin_personal_yubi_personalization.Update()
        Threading.Thread.Sleep(2000)
        If integrity = 0 Then
            btn_admin_personal_yubi_personalization.Enabled = False
            btn_admin_personal_yubi_personalization.BackColor = Color.Coral
            btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
            System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_personal_pkg)
        Else
            btn_admin_personal_yubi_personalization.Enabled = True
            btn_admin_personal_yubi_personalization.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
            ProgressBar2.Visible = False
        End If
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
        Dim Integrity As Integer = Downloader.SHA1_CheckDownload("yk_piv", cfg_config.temp_path & cfg_tools.yk_piv_pkg)
        btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_check
        btn_admin_personal_pivmanager.Update()
        Threading.Thread.Sleep(2000)
        If Integrity = 0 Then
            btn_admin_personal_pivmanager.Enabled = False
            btn_admin_personal_pivmanager.BackColor = Color.Coral
            btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_integrity_failed
            System.IO.File.Delete(cfg_config.temp_path & cfg_tools.yk_piv_pkg)
        Else
            btn_admin_personal_pivmanager.Enabled = True
            btn_admin_personal_pivmanager.Text = cfg_lang.frm_admin_personal_btn_admin_personal_install
            ProgressBar3.Visible = False
        End If

    End Sub

    Private Sub frm_admin_personal_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            If Directory.Exists(cfg_config.temp_path) Then
            Else
                Directory.CreateDirectory(cfg_config.temp_path)
            End If
        End If
    End Sub
End Class