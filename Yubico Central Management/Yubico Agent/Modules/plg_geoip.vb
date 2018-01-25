
Module plg_geoip
    Public Structure geoip
        Dim external_ip1 As String
        Dim external_ip2 As String
        Dim external_ip3 As String
        Dim geoip_service_mode As String
        Dim geoip_db_mode As Integer
    End Structure
    Public cfg_geoip As geoip

    Dim geoip_status As Integer = 0
    Private Function IpAddress(ByVal url As String) As String
        Dim ip As String
        Try
            Using wc As New Net.WebClient
                ip = System.Text.Encoding.UTF8.GetString(wc.DownloadData(url))
            End Using
            ip = ip.Replace(" ", "")
            ip = ip.Trim
            Return ip
        Catch ex As Exception
            geoip_status = geoip_status + 1
        End Try
    End Function

    Public Function GetExternalIP() As String
        Dim Lst_GetExternalIP As New List(Of String)
        Lst_GetExternalIP.Add(cfg_geoip.external_ip1)
        Lst_GetExternalIP.Add(cfg_geoip.external_ip2)
        Lst_GetExternalIP.Add(cfg_geoip.external_ip3)
        Dim externalip As String = ""
        For Each entry As String In Lst_GetExternalIP
            externalip = IpAddress(entry)
        Next
        If externalip = "" Or geoip_status = 3 Then
            Return "n.a"
        Else
            Return externalip
        End If
    End Function

    Public Function GetLocationFromMaxMindDB(ByVal externalip As String)
        Dim city As New MaxMind.GeoIP2.Responses.CityResponse
        Dim dbreader As MaxMind.GeoIP2.DatabaseReader
        Try
            Select Case cfg_geoip.geoip_db_mode
                Case 0
                    dbreader = New MaxMind.GeoIP2.DatabaseReader("plugins\geoip\GeoLite2-City.mmdb")
                Case 1
                    dbreader = New MaxMind.GeoIP2.DatabaseReader("plugins\geoip\GeoLite2-City.mmdb", MaxMind.Db.FileAccessMode.MemoryMapped)
                Case 2
                    dbreader = New MaxMind.GeoIP2.DatabaseReader("plugins\geoip\GeoLite2-City.mmdb", MaxMind.Db.FileAccessMode.Memory)
            End Select
            city = dbreader.City(externalip)
            '     Process.Start("http://maps.google.com/?q=" & city.Location.Latitude & "," & city.Location.Longitude)
            '   MessageBox.Show(city.City.Name & vbCrLf & city.Country.Name & vbCrLf & city.Continent.Name & vbCrLf & city.Location.Latitude & vbCrLf & city.Location.Longitude & vbCrLf & city.Postal.Code)
        Catch ex As Exception
            '  MessageBox.Show("Address not found")
        End Try
    End Function

    Public Function GetGeoIPXML(ByVal config As String)
        Dim counter As Integer = 0
        cfg_geoip.external_ip1 = Read_Config(config, counter)
        counter = counter + 1
        cfg_geoip.external_ip2 = Read_Config(config, counter)
        counter = counter + 1
        cfg_geoip.external_ip3 = Read_Config(config, counter)
        counter = counter + 1
        cfg_geoip.geoip_service_mode = Read_Config(config, counter)
        counter = counter + 1
        cfg_geoip.geoip_db_mode = Read_Config(config, counter)
        counter = counter + 1
    End Function

End Module
