Module Downloader
    Public Function SHA1_CheckDownload(ByVal tool As String, ByVal filename As String)
        Dim result As Integer = 0
        If My.Forms.frm_main.IntegrityCheck(1) > 0 Then

        Else
            Dim sha1_downloaded As String = SHA1FileHash(filename)
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

        End If

        Return result
    End Function
End Module
