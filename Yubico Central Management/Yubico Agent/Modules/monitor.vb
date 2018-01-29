Imports System.Net
Imports System.Text


Module monitor

    ' YK_Agent specific functions

    Public Function YK_Agent_GetKeyInfo() As String()

        Dim ykinfo_frm(4) As String
        Dim ykinfo() As String = YK_Agent_GetFromykinfo()
        If ykinfo(0) = "" Or ykinfo(0) Is Nothing Then
            Dim noYubikey As String = cfg_lang.frm_monitor_lbl_monitor_yub_touch_output_not_present
            ykinfo_frm(0) = noYubikey
            ykinfo_frm(1) = noYubikey
            ykinfo_frm(2) = noYubikey
            ykinfo_frm(3) = noYubikey
            ykinfo_frm(4) = noYubikey
        Else
            ykinfo = YK_Agent_ConvertInfo_to_Names(ykinfo)
            ykinfo_frm(0) = ykinfo(8)
            ykinfo_frm(1) = ykinfo(9)
            ykinfo_frm(2) = ykinfo(0)
            ykinfo_frm(3) = ykinfo(3)
            ykinfo_frm(4) = ykinfo(4)
        End If
        Return ykinfo_frm
    End Function
    Public Function YK_Agent_GetSystemInfo() As String()
        Try
            Dim SystemInfo(5) As String
            SystemInfo(0) = My.User.Name
            SystemInfo(1) = Generic_GetIP()
            SystemInfo(2) = My.Computer.Name
            SystemInfo(3) = My.Computer.Info.OSFullName
            SystemInfo(4) = Generic_GetWMI_SingleEntry("Win32_ComputerSystem", "manufacturer") & " " & Generic_GetWMI_SingleEntry("Win32_ComputerSystem", "model")
            SystemInfo(5) = GetExternalIP()
            Return SystemInfo
        Catch ex As Exception

        End Try
    End Function
    Public Function YK_Agent_GetFromykinfo() As String()
        Dim ykinfo_result(9) As String
        Dim plugin_ykinfo_path As String = Application.StartupPath & "\Plugins\ykinfo"
        ' MessageBox.Show(plugin_ykinfo_path)
        Dim ykinfo_export As String = plugin_ykinfo_path & "\ykinfo.txt"
        Dim ps_ykinfo As New System.Diagnostics.Process()
        With ps_ykinfo.StartInfo
            .FileName = plugin_ykinfo_path & "\export.bat"
            '  .Arguments = "-s > c:\users\ronny.wolf\desktop\test.txt"
            '" -q 1> c:\users\ronny.wolf\desktop\output2.txt"
            ' MessageBox.Show(plugin_ykinfo_path)
            .WorkingDirectory = plugin_ykinfo_path ' "C:\Users\ronny.wolf\Source\Repos\Yubico-Central-Management\Yubico Central Management\Yubico Agent\bin\Debug\Plugins\ykinfo"
            .RedirectStandardOutput = False
            .RedirectStandardError = False
            .RedirectStandardInput = False
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Hidden
            .CreateNoWindow = True
        End With

        ps_ykinfo.Start()
        ps_ykinfo.WaitForExit()

        Dim ykinfo_export_count As Integer = 0
        If System.IO.File.Exists(ykinfo_export) Then
            'Dim ykinfo_export_file As String = Application.StartupPath & "\Plugins\ykinfo\ykinfo.txt"
            Dim ykinfo_fs As System.IO.FileStream = New System.IO.FileStream(ykinfo_export, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite)
            Dim ykinfo_sr As System.IO.StreamReader = New System.IO.StreamReader(ykinfo_fs)
            ykinfo_sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin)
            While ykinfo_sr.Peek() > -1
                ykinfo_result(ykinfo_export_count) = ykinfo_sr.ReadLine
                ykinfo_export_count = ykinfo_export_count + 1
            End While
            ykinfo_sr.Close()
            ykinfo_fs.Close()
            System.IO.File.Delete(ykinfo_export)
        End If
        Return ykinfo_result
    End Function
    Public Function YK_Agent_ConvertInfo_to_Names(ByVal output As String()) As String()
        Select Case output(8)
            Case "1050"
                output(8) = "Yubico AB"
        End Select
        Select Case output(9)
            Case "407"
                output(9) = "Yubikey 4 Nano"
        End Select
        Return output
    End Function

    ' Generic Functions

    Public Function Generic_GetIP() As String
        Try
            Dim ipaddress As String
            Dim NetworkCard() As NetworkInformation.NetworkInterface = NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
            For Each card As NetworkInformation.NetworkInterface In NetworkCard
                If card.OperationalStatus = NetworkInformation.OperationalStatus.Up Then
                    Dim gateways As NetworkInformation.GatewayIPAddressInformationCollection = card.GetIPProperties.GatewayAddresses
                    If gateways.FirstOrDefault IsNot Nothing Then
                        Dim UnicastColl As NetworkInformation.UnicastIPAddressInformationCollection = card.GetIPProperties.UnicastAddresses
                        For Each ip In UnicastColl
                            ipaddress = ip.Address.ToString
                        Next
                    End If
                End If
            Next
            Return ipaddress
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function Generic_GetWMI_SingleEntry(ByVal From_source As String, ByVal SearchString As String)
        Try
            Dim Result As String
            Dim objCS As New System.Management.ManagementObjectSearcher
            objCS = New Management.ManagementObjectSearcher("SELECT * FROM " & From_source)
            For Each objMgmt In objCS.Get
                Result = objMgmt(SearchString).ToString()
            Next
            Return Result
        Catch ex As Exception

        End Try
    End Function

End Module
