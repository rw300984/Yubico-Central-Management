Imports System.Net

Module plg_sysinfo
    Public Structure sysinfo
        Dim username As String
        Dim ip_internal As String
        Dim computername As String
        Dim os As String
        Dim manufacturer As String
        Dim ip_external As String
    End Structure
    Public res_sysinfo As sysinfo

    Public Function AddSysInfoToDB(ByVal data As sysinfo) As Boolean
        Dim sqlitecmd As String
        Dim state As Boolean = CheckIfSysInfoinDB()
        If state = False Then
            sqlitecmd = "INSERT INTO ykresult_sysinfo (username,ip_internal,ip_external,computername,os,manufacturer) VALUES ('" & data.username & "','" & data.ip_internal & "','" & data.ip_external & "','" & data.computername & "','" & data.os & "','" & data.manufacturer & "')"
        Else
            sqlitecmd = "UPDATE ykresult_sysinfo Set username='" & data.username & "',ip_internal='" & data.ip_internal & "',ip_external='" & data.ip_external & "',computername='" & data.computername & "',os='" & data.os & "',manufacturer='" & data.manufacturer & "' WHERE id='1'"
        End If

        Dim result As Boolean = False
        Try
            result = db.ExecuteNonQuery("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function CheckIfSysInfoinDB() As Boolean
        Dim sqlitecmd As String = "Select id FROM ykresult_sysinfo WHERE id='1'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function GetSysInfoFromDB() As sysinfo
        Dim result As sysinfo
        Dim sqlitecmd As String = "Select * FROM ykresult_sysinfo WHERE id='1'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 6)
            result.username = TryCast(res_array(1), String)
            result.ip_internal = TryCast(res_array(2), String)
            result.ip_external = TryCast(res_array(3), String)
            result.computername = TryCast(res_array(4), String)
            result.os = TryCast(res_array(5), String)
            result.manufacturer = TryCast(res_array(6), String)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function YK_Agent_GetSystemInfo()
        Try
            res_sysinfo.username = My.User.Name
            res_sysinfo.ip_internal = Generic_GetIP()
            res_sysinfo.computername = My.Computer.Name
            res_sysinfo.os = My.Computer.Info.OSFullName
            res_sysinfo.manufacturer = Generic_GetWMI_SingleEntry("Win32_ComputerSystem", "manufacturer") & " " & Generic_GetWMI_SingleEntry("Win32_ComputerSystem", "model")
            res_sysinfo.ip_external = GetExternalIP()
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
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
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
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
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function

End Module
