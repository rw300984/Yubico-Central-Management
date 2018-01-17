Module Downloader
    Dim WithEvents WC As New System.Net.WebClient
    Public Sub DownLoadFileInBackground2(ByVal address As String)
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateCertificate
        System.Net.ServicePointManager.Expect100Continue = True
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        WC.DownloadFileAsync(New Uri(address), "DownloadedFile.zip")
    End Sub
    Private Function ValidateCertificate(sender As Object, certificate As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        My.Forms.frm_admin_personal.ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Module
