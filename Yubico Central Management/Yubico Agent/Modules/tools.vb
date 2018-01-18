Module tools
    Public cfg_tools As tools
    Public Structure tools
        Dim yk_minidriver_exec As String
        Dim yk_personal_exec As String
        Dim yk_piv_exec As String
        Dim yk_minidriver_exec_sha1 As String
        Dim yk_personal_exec_sha1 As String
        Dim yk_piv_exec_sha1 As String
        Dim yk_minidriver_download As String
        Dim yk_personal_download As String
        Dim yk_piv_download As String
        Dim yk_minidriver_download_sha1 As String
        Dim yk_personal_download_sha1 As String
        Dim yk_piv_download_sha1 As String
        Dim yk_personal_regkey As String
        Dim yk_piv_regkey As String
        Dim yk_tools_install_dir As String
        Dim yk_minidriver_pkg As String
        Dim yk_personal_pkg As String
        Dim yk_piv_pkg As String
    End Structure

    Public Function CheckVersionOfTools() As String()
        Dim version_array(2) As String
        Dim tools_array(2) As String

        tools_array(0) = cfg_tools.yk_minidriver_exec
        tools_array(1) = cfg_tools.yk_personal_exec
        tools_array(2) = cfg_tools.yk_piv_exec

        For Each tool As String In tools_array
            Select Case tool
                Case cfg_tools.yk_minidriver_exec
                    version_array(0) = GetFileVersion(Environment.SystemDirectory & "\" & tool)
                Case cfg_tools.yk_personal_exec
                    Dim install_dir As String
                    If Environment.Is64BitOperatingSystem Then
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\" & cfg_tools.yk_personal_regkey, cfg_tools.yk_tools_install_dir)
                    Else
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\" & cfg_tools.yk_personal_regkey, cfg_tools.yk_tools_install_dir)
                    End If

                    If install_dir = "0" Then 'Or install_dir = Nothing Then
                        version_array(1) = "0"
                    Else
                        version_array(1) = GetFileVersion(install_dir & "\" & cfg_tools.yk_personal_exec)
                    End If
                Case cfg_tools.yk_piv_exec
                    Dim install_dir As String

                    If Environment.Is64BitOperatingSystem Then
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\" & cfg_tools.yk_piv_regkey, cfg_tools.yk_tools_install_dir)
                    Else
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\" & cfg_tools.yk_piv_regkey, cfg_tools.yk_tools_install_dir)
                    End If

                    If install_dir = "0" Then ' Or install_dir = Nothing Then
                        version_array(2) = 0
                    Else
                        version_array(2) = GetFileVersion(install_dir & "\" & cfg_tools.yk_piv_exec)
                    End If
            End Select
        Next
        Return version_array
    End Function
    Public Function InstallTool(ByVal file As String) As Integer
        Dim result As String = "0"
        Try
            ' Dim yktool_install_file As String = Application.StartupPath & "\" & file
            Dim ps_yktool_install As New System.Diagnostics.Process()
            With ps_yktool_install.StartInfo
                .FileName = file
                .Arguments = "/S"
                .WorkingDirectory = Application.StartupPath
                .RedirectStandardOutput = False
                .RedirectStandardError = False
                .RedirectStandardInput = False
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Hidden
                .CreateNoWindow = True
            End With
            ps_yktool_install.Start()
            ps_yktool_install.WaitForExit()
            result = "1"
            Return result
        Catch ex As Exception

            result = "0"
            Return result
        End Try
    End Function

    Public Function InstallDriver() As Integer

    End Function
    Public Function StartTool()

    End Function
    Public Function GetToolsXML(ByVal config As String)
        Dim counter As Integer = 0
        cfg_tools.yk_minidriver_exec = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_exec = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_exec = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_minidriver_exec_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_exec_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_exec_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_minidriver_download = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_download = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_download = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_minidriver_download_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_download_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_download_sha1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_regkey = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_regkey = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_tools_install_dir = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_minidriver_pkg = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_personal_pkg = Read_Config(config, counter)
        counter = counter + 1
        cfg_tools.yk_piv_pkg = Read_Config(config, counter)
        counter = counter + 1
    End Function
    Public Function VerifyChecksum()

    End Function
End Module
