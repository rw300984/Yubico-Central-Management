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
            Dim SerialDT As New DataTable

            If System.IO.File.Exists(install_path & "\temp\serial.cache") Then
                SerialDT.TableName = "SerialNumbers"
                SerialDT.ReadXml(install_path & "\temp\serial.cache")
            Else
                SerialDT = CreateSerialDataTable(SerialDT)
            End If
            '   Dim test As New System.IO.StreamWriter(install_path & "\temp\test.txt", True)
            Dim exec_path As String = install_path & "\Yubico Agent.exe"
            Dim close_path As String = install_path & "\temp\close.bin"

            Dim yubi_client As New YubiClientAPILib.YubiClient
            If yubi_client.isInserted = YubiClientAPILib.ycRETCODE.ycRETCODE_OK Then
                Dim serial As New YubiClientAPILib.ycRETCODE
                serial = yubi_client.readSerial(YubiClientAPILib.ycCALL_MODE.ycCALL_BLOCKING)
                If serial = YubiClientAPILib.ycRETCODE.ycRETCODE_OK Then
                    yubi_client.dataEncoding = YubiClientAPILib.ycENCODING.ycENCODING_UINT32
                    If MatchSerialDatatable(SerialDT, yubi_client.dataBuffer) = False Then
                        AddSerialDatatable(SerialDT, yubi_client.dataBuffer.ToString)
                        SerialDT.WriteXml(install_path & "\temp\serial.cache", XmlWriteMode.WriteSchema)
                    Else
                    End If
                End If
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
    Private Shared Function CreateSerialDataTable(ByVal table As DataTable) As DataTable
        table.TableName = "SerialNumbers"
        table.Columns.Add("Serial", GetType(String))
        table.Columns.Add("GUID", GetType(String))
        table.Columns.Add("Name", GetType(String))
        table.AcceptChanges()
        Return table
    End Function
    Private Shared Function AddSerialDatatable(ByVal SerialDataTable As DataTable, ByVal Serial As String)
        SerialDataTable.Rows.Add(Serial, Guid.NewGuid.ToString, "")
        SerialDataTable.AcceptChanges()
    End Function
    Private Shared Function MatchSerialDatatable(ByVal SerialDatatable As DataTable, ByVal Serial As String) As Boolean
        Dim result As DataRow()
        result = SerialDatatable.Select("Serial = " & Serial)
        If result.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
