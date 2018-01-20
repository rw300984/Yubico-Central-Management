Imports System.Timers
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
        Dim yubi_client As New YubiClientAPILib.YubiClient
        If yubi_client.isInserted = YubiClientAPILib.ycRETCODE.ycRETCODE_OK Then
            Dim ps As Process() = Process.GetProcessesByName("Yubico Agent")
            If ps.Length > 0 Then
            Else
                ProcessExtensions.StartProcessAsCurrentUser("C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\Yubico Agent.exe",, "C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\")
            End If
        Else
            If System.IO.File.Exists("C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\close.bin") Then
            Else
                Dim close_file As New System.IO.FileStream("C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\close.bin", IO.FileMode.Create)
                close_file.Close()
            End If
        End If
    End Sub

    Protected Overrides Sub OnStop()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\close.bin", True)
        file.WriteLine("")
        file.Close()
    End Sub
End Class
