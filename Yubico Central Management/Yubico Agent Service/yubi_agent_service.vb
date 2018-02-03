Imports System.Timers
Imports System.Security.AccessControl
Imports murrayju.ProcessExtensions
Imports Microsoft.Win32
Imports System.Xml


Public Class yubi_agent_service

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            Dim mytimer As New System.Timers.Timer()
            AddHandler mytimer.Elapsed, AddressOf OnTimedEvent
            mytimer.Interval = 2000
            mytimer.Enabled = True
            mytimer.Start()
        Catch ex As Exception
        End Try
    End Sub
    Private Shared Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        Try
            Dim install_path As String
            Dim key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", False)
            With My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", True)
                install_path = .GetValue("InstallLocation").ToString
            End With

            Dim exec_path As String = install_path & "\Yubico Agent.exe"
            Dim close_path As String = install_path & "\temp\close.bin"

            Dim yubi_client As New YubiClientAPILib.YubiClient
            If yubi_client.isInserted = YubiClientAPILib.ycRETCODE.ycRETCODE_OK Then
                Dim ps As Process() = Process.GetProcessesByName("Yubico Agent")
                If ps.Length > 0 Then
                Else
                    ProcessExtensions.StartProcessAsCurrentUser(exec_path,, install_path)
                End If
            Else
                If System.IO.File.Exists(close_path) Then
                Else
                    Dim close_file As New System.IO.FileStream(close_path, IO.FileMode.Create)
                    close_file.Close()
                End If
            End If
        Catch ex As Exception
            Dim install_path As String
            Dim key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", False)
            With My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", True)
                install_path = .GetValue("InstallLocation").ToString
            End With
            Dim test As New System.IO.StreamWriter(install_path & "\temp\exception.txt", True)
            test.WriteLine(ex.Message)
            test.Close()
        End Try
    End Sub
    Protected Overrides Sub OnStop()
        Dim install_path As String
        Dim key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", False)
        With My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", True)
            install_path = .GetValue("InstallLocation").ToString
        End With
        Dim close_path As String = install_path & "\temp\close.bin"
        Dim close_file As New System.IO.FileStream(close_path, IO.FileMode.Create)
        close_file.Close()
    End Sub
End Class
