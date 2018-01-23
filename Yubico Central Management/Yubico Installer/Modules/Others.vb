Imports System.Security.AccessControl
Imports System.IO
Imports System.ServiceProcess
Imports System.IO.Compression

Module Others
    Public Function StopAllServicesAndProcess() As Integer
        Dim result As Integer = 0
        Try
            Dim count As Integer = 0
            For Each svc As ServiceController In ServiceController.GetServices
                If svc.ServiceName = "yubi_agent_svc" Then
                    count = count + 1
                    svc.Stop()
                    svc.WaitForStatus(ServiceControllerStatus.Stopped)
                End If
            Next
            If count = 1 Then
                Threading.Thread.Sleep(5000)
            End If
            For Each ps As Process In Process.GetProcesses
                If ps.ProcessName = "Yubico Agent" Then
                    ps.Kill()
                End If
            Next
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function RegisterInstallation(ByVal install_path As String) As Integer
        Dim result As Integer = 0
        Try
            'Setting My Values
            Dim ApplicationName As String = "Yubico Agent (Alpha)"
            Dim ApplicationVersion As String = "0.0.1.0"
            Dim ApplicationPublisher As String = "RW300984 (Ronny Wolf)"
            Dim ApplicationUnInstallPath As String = install_path & "unintall.exe"
            Dim ApplicationInstallDirectory As String = install_path

            'Opening the Uninstall RegistryKey (don't forget to set the writable flag to true)
            With My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall", True)

                'Creating my AppRegistryKey
                Dim AppKey As Microsoft.Win32.RegistryKey = .CreateSubKey(ApplicationName)

                'Adding my values to my AppRegistryKey
                AppKey.SetValue("DisplayName", ApplicationName, Microsoft.Win32.RegistryValueKind.String)
                AppKey.SetValue("DisplayVersion", ApplicationVersion, Microsoft.Win32.RegistryValueKind.String)
                '  AppKey.SetValue("DisplayIcon", ApplicationIconPath, Microsoft.Win32.RegistryValueKind.String)
                AppKey.SetValue("Publisher", ApplicationPublisher, Microsoft.Win32.RegistryValueKind.String)
                AppKey.SetValue("UninstallString", ApplicationUnInstallPath, Microsoft.Win32.RegistryValueKind.String)
                AppKey.SetValue("UninstallPath", ApplicationUnInstallPath, Microsoft.Win32.RegistryValueKind.String)
                AppKey.SetValue("InstallLocation", ApplicationInstallDirectory, Microsoft.Win32.RegistryValueKind.String)
            End With
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function ExtractApplication(ByVal dest_path As String) As Integer
        Dim result As Integer = 0
        Try
            If Directory.Exists(dest_path) Then
                If File.Exists(dest_path & "\Yubico Agent.zip") Then
                    File.Delete(dest_path & "\Yubico Agent.zip")
                End If
            Else
                Directory.CreateDirectory(dest_path)
            End If
            System.IO.File.WriteAllBytes(dest_path & "\Yubico Agent.zip", My.Resources.Yubico_Agent)
            ZipFile.ExtractToDirectory(dest_path & "\Yubico Agent.zip", dest_path)
            Threading.Thread.Sleep(2000)
            File.Delete(dest_path & "\Yubico Agent.zip")
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function InstallService(ByVal source_service_file As String) As Integer
        Dim result As Integer = 0
        Try
            Dim DotNetPath As String = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()
            Dim ps_installsvc As New Process
            With ps_installsvc.StartInfo
                .FileName = DotNetPath & "\installutil.exe"
                .Arguments = Chr(34) & source_service_file & Chr(34)
                .Verb = "runas"
                .UseShellExecute = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Hidden
            End With
            ps_installsvc.Start()
            ps_installsvc.WaitForExit()
            Threading.Thread.Sleep(5000)
            Dim count As Integer
            For Each svc As ServiceController In ServiceController.GetServices
                If svc.ServiceName = "yubi_agent_svc" Then
                    count = count + 1
                End If
            Next
            If count = 1 Then
                result = 1
            End If
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function UninstallService(ByVal source_service_file As String)
        Dim result As Integer = 0
        Try
            Dim DotNetPath As String = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()
            Dim ps_installsvc As New Process
            With ps_installsvc.StartInfo
                .FileName = DotNetPath & "\installutil.exe"
                .Arguments = "/u " & source_service_file
                .Verb = "runas"
                .UseShellExecute = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Hidden
            End With
            ps_installsvc.Start()
            ps_installsvc.WaitForExit()
            Threading.Thread.Sleep(5000)
            Dim count As Integer
            For Each svc As ServiceController In ServiceController.GetServices
                If svc.ServiceName = "yubi_agent_svc" Then
                    count = count + 1
                End If
            Next
            If count = 0 Then
                result = 1
            End If
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function RegisterDLLs(ByVal source_dll As String) As Integer
        Dim result As Integer = 0
        Try
            Dim ps_regdll As New Process
            With ps_regdll.StartInfo
                .FileName = "regsvr32.exe"
                .Arguments = "/s " & Chr(34) & source_dll & Chr(34)
                .Verb = "runas"
                .UseShellExecute = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Hidden
            End With
            ps_regdll.Start()
            ps_regdll.WaitForExit()
            Threading.Thread.Sleep(5000)
            Dim value As String = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\YubiClientAPI.YubiClient", Nothing, Nothing)
            If value = "YubiClient Class" Then
                result = 1
            End If
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function UnRegisterDLLs(ByVal source_dll As String) As Integer
        Dim result As Integer = 0
        Try
            Dim ps_regdll As New Process
            With ps_regdll.StartInfo
                .FileName = "regsvr32.exe"
                .Arguments = "/u " & Chr(34) & source_dll & Chr(34)
                .Verb = "runas"
                .UseShellExecute = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Hidden
            End With
            ps_regdll.Start()
            ps_regdll.WaitForExit()
            Threading.Thread.Sleep(5000)
            Dim value As String = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\YubiClientAPI.YubiClient", Nothing, Nothing)
            If value = "YubiClient Class" Then
                result = 0
            Else
                result = 1
            End If
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function IntegrityCheck() As Integer

    End Function

    Public Function CreateFolderStructure(ByVal install_path As String) As Integer
        Dim result As Integer = 0
        Try
            If Directory.Exists(install_path) Then
                Directory.Delete(install_path, True)
                Directory.CreateDirectory(install_path)
            Else
                Directory.CreateDirectory(install_path)
            End If
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function SetPermissions(ByVal install_path As String)
        Dim result As Integer = 0
        Try
            Dim UserAccountSID As String = "S-1-5-32-545" 'Specify the user here
            Dim UserAccountSIDIdentifier As New System.Security.Principal.SecurityIdentifier(UserAccountSID)

            Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(install_path)
            Dim FolderAcl As New DirectorySecurity
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccountSIDIdentifier, FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
            FolderInfo.SetAccessControl(FolderAcl)
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function StartService() As Integer
        Dim result As Integer = 0
        Try
            For Each sc As ServiceController In ServiceController.GetServices
                If sc.ServiceName = "yubi_agent_svc" Then
                    sc.Start()
                    sc.WaitForStatus(ServiceControllerStatus.Running)
                End If
            Next
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function

    Public Function GenerateDefaultConfig(ByVal install_path As String, ByVal password As String, ByVal agent_mode As String) As Integer
        Dim result As Integer = 0
        Try
            Dim config_path As String = install_path & "\config\config.xml"
            Dim lang_de_path As String = install_path & "\lang\de.xml"
            Dim lang_en_path As String = install_path & "\lang\en.xml"
            Dim config_tools_path As String = install_path & "\config\tools.xml"

            Dim cfg_config As New initial_configuration
            With cfg_config
                .initial_verify = password
                .initial_enabled = 0
                .integrity_lang_de_file = lang_de_path
                .integrity_lang_en_file = lang_en_path
                .integrity_tools_file = config_tools_path
                .admin_general_lang = "English"
                .admin_central_auth = cfg.install_options_business_auth
                .admin_central_server = cfg.install_options_business_server
                .admin_central_username = cfg.install_options_business_username
                .admin_central_password = cfg.install_options_business_password
                .admin_general_theme = "Gray (default)"
                .admin_general_mode = agent_mode
            End With

            Write_Config(config_path, password, cfg_config)
            result = 1
            Return result
        Catch ex As Exception
            Return result
        End Try
    End Function
End Module
