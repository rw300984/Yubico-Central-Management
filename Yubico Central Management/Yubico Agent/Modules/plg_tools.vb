

Module plg_tools
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
        Try
            Dim version_array(2) As String
            Dim tools_array(2) As String

            tools_array(0) = cfg_tools.yk_minidriver_exec
            tools_array(1) = cfg_tools.yk_personal_exec
            tools_array(2) = cfg_tools.yk_piv_exec

            For Each tool As String In tools_array
                Select Case tool
                    Case cfg_tools.yk_minidriver_exec
                        ' MessageBox.Show(Environment.SystemDirectory & "\" & tool)
                        'MessageBox.Show(System.IO.File.Exists(Environment.SystemDirectory & "\" & tool))
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function InstallTool(ByVal file As String) As Integer
        Dim result As String = "0"
        Try
            ' Dim yktool_install_file As String = Application.StartupPath & "\" & file
            Dim ps_yktool_install As New System.Diagnostics.Process()
            With ps_yktool_install.StartInfo
                .FileName = file
                .Arguments = "/S"
                .WorkingDirectory = cfg_config.temp_path
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
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            result = "0"
            Return result
        End Try
    End Function
    Public Function InstallDriver(ByVal driverpack As String) As String
        Try
            ' Extract Driver
            ZipFile.ExtractToDirectory(driverpack, cfg_config.temp_path)
            Dim ps_inst_driver As New Process
            Dim path_to_inf As String = ""
            Select Case True
                Case My.Computer.Info.OSFullName.Contains("Windows 10")
                    path_to_inf = cfg_config.temp_path & "YKmd-Windows10\ykmd.inf"
                Case Else
                    path_to_inf = cfg_config.temp_path & "YKmd-Windows7-8.1\ykmd.inf"
            End Select
            With ps_inst_driver.StartInfo
                .FileName = "rundll32.exe"
                .Arguments = "advpack.dll,LaunchINFSectionEx " & Chr(34) & path_to_inf & Chr(34)
                .WindowStyle = ProcessWindowStyle.Hidden
                .UseShellExecute = True
                .Verb = "runas"
            End With

            ps_inst_driver.Start()
            ps_inst_driver.WaitForExit()

            Directory.Delete(cfg_config.temp_path & "YKmd-Windows10", True)
            Directory.Delete(cfg_config.temp_path & "YKmd-Windows7-8.1", True)
            File.Delete(driverpack)
            File.Delete(cfg_config.temp_path & "README.txt")
            Dim version As String() = CheckVersionOfTools()
            Return version(0)
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
    Public Function StartTool(ByVal tool As String) As Integer
        Try
            Dim ps_exec As String
            Dim hklm_reg_path_64 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\"
            Dim hklm_reg_path_32 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\"
            Dim status As Integer = 0
            Select Case tool
                Case "yk_personal"
                    If Environment.Is64BitOperatingSystem Then
                        ps_exec = GetRegistryEntry(hklm_reg_path_64 & cfg_tools.yk_personal_regkey, cfg_tools.yk_tools_install_dir) & "\" & cfg_tools.yk_personal_exec
                    Else
                        ps_exec = GetRegistryEntry(hklm_reg_path_32 & cfg_tools.yk_personal_regkey, cfg_tools.yk_tools_install_dir) & "\" & cfg_tools.yk_personal_exec
                    End If

                    If SHA512FileHash(ps_exec) = cfg_tools.yk_personal_exec_sha1 Then
                        status = 1
                    End If
                Case "yk_piv"
                    If Environment.Is64BitOperatingSystem Then
                        ps_exec = GetRegistryEntry(hklm_reg_path_64 & cfg_tools.yk_piv_regkey, cfg_tools.yk_tools_install_dir) & "\" & cfg_tools.yk_piv_exec
                    Else
                        ps_exec = GetRegistryEntry(hklm_reg_path_32 & cfg_tools.yk_piv_regkey, cfg_tools.yk_tools_install_dir) & "\" & cfg_tools.yk_piv_exec
                    End If
                    If SHA512FileHash(ps_exec) = cfg_tools.yk_piv_exec_sha1 Then
                        status = 1
                    End If
            End Select
            If status = 1 Then
                Process.Start(ps_exec)
                Return status
            Else
                Return status
            End If
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
    Public Function GetToolsFromDB() As tools
        Dim result As tools
        Dim sqlitecmd As String = "Select * FROM ykconfig_tools WHERE id='1'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 18)
            With result
                .yk_minidriver_exec = TryCast(res_array(1), String)
                .yk_personal_exec = TryCast(res_array(2), String)
                .yk_piv_exec = TryCast(res_array(3), String)
                .yk_minidriver_exec_sha1 = TryCast(res_array(4), String)
                .yk_personal_exec_sha1 = TryCast(res_array(5), String)
                .yk_piv_exec_sha1 = TryCast(res_array(6), String)
                .yk_minidriver_download = TryCast(res_array(7), String)
                .yk_personal_download = TryCast(res_array(8), String)
                .yk_piv_download = TryCast(res_array(9), String)
                .yk_minidriver_download_sha1 = TryCast(res_array(10), String)
                .yk_personal_download_sha1 = TryCast(res_array(11), String)
                .yk_piv_download_sha1 = TryCast(res_array(12), String)
                .yk_personal_regkey = TryCast(res_array(13), String)
                .yk_piv_regkey = TryCast(res_array(14), String)
                .yk_tools_install_dir = TryCast(res_array(15), String)
                .yk_minidriver_pkg = TryCast(res_array(16), String)
                .yk_personal_pkg = TryCast(res_array(17), String)
                .yk_piv_pkg = TryCast(res_array(18), String)
            End With
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function VerifyChecksum()

    End Function
End Module
