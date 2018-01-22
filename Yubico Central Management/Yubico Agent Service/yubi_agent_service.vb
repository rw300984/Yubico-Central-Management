Imports System.Timers
Imports System.Security.AccessControl
Imports murrayju.ProcessExtensions

Public Class yubi_agent_service
    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            Dim mytimer As New System.Timers.Timer()
            AddHandler mytimer.Elapsed, AddressOf OnTimedEvent
            mytimer.Interval = 1000
            mytimer.Enabled = True
            mytimer.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Shared Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Yubico Agent"
        Dim exec_path As String = install_path & "\Yubico Agent.exe"

        Dim hklm_reg_path_64 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Yubico\Yubico Agent"
        Dim hklm_reg_path_32 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Yubico\Yubico Agent"

        If System.IO.File.Exists(exec_path) Then
        Else
            If Environment.Is64BitOperatingSystem Then
                install_path = My.Computer.Registry.GetValue(hklm_reg_path_64, "install_dir", Nothing)
            Else
                install_path = My.Computer.Registry.GetValue(hklm_reg_path_64, "install_dir", Nothing)
            End If

        End If

        exec_path = install_path & "\Yubico Agent.exe"
        Dim close_path As String = install_path & "\temp\close.bin"

        Dim FolderPath As String = install_path 'Specify the folder here
        Dim UserAccountSID As String = "S-1-5-32-545" 'Specify the user here
        Dim UserAccountSIDIdentifier As New System.Security.Principal.SecurityIdentifier(UserAccountSID)

        Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(FolderPath)
        Dim FolderAcl As New DirectorySecurity
        FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccountSIDIdentifier, FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))

        FolderInfo.SetAccessControl(FolderAcl)

        Dim yubi_client As New YubiClientAPILib.YubiClient
        If yubi_client.isInserted = YubiClientAPILib.ycRETCODE.ycRETCODE_OK Then
            Dim ps As Process() = Process.GetProcessesByName("Yubico Agent")
            If ps.Length > 0 Then
            Else
                '   Dim ps_info As ProcessStartInfo
                '  With ps_info
                ' .FileName = exec_path
                '.Verb = "runas"
                'End With
                ProcessExtensions.StartProcessAsCurrentUser(exec_path,, install_path)
            End If
        Else
            If System.IO.File.Exists(close_path) Then
            Else
                Dim close_file As New System.IO.FileStream(close_path, IO.FileMode.Create)
                close_file.Close()
            End If
        End If
    End Sub

    Protected Overrides Sub OnStop()
        Dim install_path As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Yubico Agent"
        Dim exec_path As String = install_path & "\Yubico Agent.exe"

        Dim hklm_reg_path_64 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Yubico\Yubico Agent"
        Dim hklm_reg_path_32 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Yubico\Yubico Agent"


        If System.IO.File.Exists(exec_path) Then
        Else
            If Environment.Is64BitOperatingSystem Then
                install_path = My.Computer.Registry.GetValue(hklm_reg_path_64, "install_dir", Nothing)
            Else
                install_path = My.Computer.Registry.GetValue(hklm_reg_path_64, "install_dir", Nothing)
            End If

        End If

        exec_path = install_path & "\Yubico Agent.exe"
        Dim close_path As String = install_path & "\temp\close.bin"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(close_path, True)
        file.WriteLine("")
        file.Close()
    End Sub
End Class
