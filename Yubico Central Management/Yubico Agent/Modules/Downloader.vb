Module Downloader
    Public Function SHA1_CheckDownload(ByVal tool As String, ByVal filename As String)
        Try
            Dim result As Integer = 0
            Dim sha1_downloaded As String = SHA512FileHash(filename)
            Select Case tool
                Case "yk_minidriver"
                    If sha1_downloaded = cfg_tools.yk_minidriver_download_sha1 Then
                        result = 1
                    End If
                Case "yk_personal"
                    If sha1_downloaded = cfg_tools.yk_personal_download_sha1 Then
                        result = 1
                    End If
                Case "yk_piv"
                    If sha1_downloaded = cfg_tools.yk_piv_download_sha1 Then
                        result = 1
                    End If
            End Select
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
End Module
