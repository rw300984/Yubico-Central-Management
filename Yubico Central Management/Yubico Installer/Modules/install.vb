Module install

    Public Function StartInstallation() As Integer
        Dim install_path As String
        Dim password As String
        If cfg.install_path_mode = 0 Then
            install_path = cfg.install_path_default
        Else
            install_path = cfg.install_path_custom
        End If
        If cfg.install_password_mode = 0 Then
            password = cfg.install_password_random
        Else
            password = cfg.install_password_custom
        End If
        cfg.install_success_status = StopAllServicesAndProcess()
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = CreateFolderStructure(install_path)
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = SetPermissions(install_path)
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = ExtractApplication(install_path)
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = RegisterDLLs(install_path & "\plugins\ykclient\yubiclientapi.dll")
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = RegisterInstallation(install_path)
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = InstallService(install_path & "\services\Yubico Agent Service.exe")
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = GenerateDefaultConfig(install_path, password)
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
        cfg.install_success_status = StartService()
        If cfg.install_success_status = 0 Then
            Exit Function
        End If
    End Function

    Public Function RollbackInstallation(ByVal Install_path As String, ByVal stage As Integer) As Integer

    End Function

    Public Function StartUninstallation()

    End Function

    Public Function StartUpdate()

    End Function

    Public Function ResetConfiguration()

    End Function
End Module
