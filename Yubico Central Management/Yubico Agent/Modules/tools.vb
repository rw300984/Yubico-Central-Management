Module tools
    Public Function CheckVersionOfTools() As String()
        Dim version_array(2) As String
        Dim tools_array(2) As String

        tools_array(0) = "ykmd.dll"
        tools_array(1) = "yubikey-personalization-gui.exe"
        tools_array(2) = "pivman.exe"

        For Each tool As String In tools_array
            Select Case tool
                Case "ykmd.dll"
                    version_array(0) = GetFileVersion(Environment.SystemDirectory & "\" & tool)
                Case "yubikey-personalization-gui.exe"
                    Dim install_dir As String
                    If Environment.Is64BitOperatingSystem Then
                        Install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Yubico\yubikey-personalization-gui", "Install_Dir")
                    Else
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\Yubico\yubikey-personalization-gui", "Install_Dir")
                    End If

                    If install_dir = "0" Then 'Or install_dir = Nothing Then
                        version_array(1) = "0"
                    Else
                        version_array(1) = GetFileVersion(install_dir & "\yubikey-personalization-gui.exe")
                    End If
                Case "pivman.exe"
                    Dim install_dir As String

                    If Environment.Is64BitOperatingSystem Then
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Yubico\YubiKey PIV Manager", "Install_Dir")
                    Else
                        install_dir = GetRegistryEntry("HKEY_LOCAL_MACHINE\SOFTWARE\Yubico\YubiKey PIV Manager", "Install_Dir")
                    End If

                    If install_dir = "0" Then ' Or install_dir = Nothing Then
                        version_array(2) = 0
                    Else
                        version_array(2) = GetFileVersion(install_dir & "\pivman.exe")
                    End If
            End Select
        Next
        Return version_array
    End Function
    Public Function InstallTool() As Integer

    End Function

    Public Function InstallDriver() As Integer

    End Function
    Public Function StartTool()

    End Function

End Module
