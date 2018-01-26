
Module plg_geoip
    Public Structure geoip
        Dim external_ip1 As String
        Dim external_ip2 As String
        Dim external_ip3 As String
        Dim geoip_service_mode As String
        Dim geoip_db_mode As Integer
    End Structure

    Public Structure geoip_data
        Dim ip As String
        Dim country_code As String
        Dim country_name As String
        Dim region_code As String
        Dim region_name As String
        Dim city_name As String
        Dim city_postal As String
        Dim latitude As String
        Dim longtitude As String
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
            If externalip <> "" Then
            Else
                externalip = IpAddress(entry)
            End If
        Next
        If externalip = "" Or geoip_status = 3 Then
            Return ""
        Else
            Return externalip
        End If
    End Function

    Public Function GetLocationFromMaxMindDB(ByVal externalip As String) As geoip_data
        Dim geoip_info As geoip_data
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

            geoip_info.ip = externalip
            geoip_info.country_code = city.Country.IsoCode
            geoip_info.country_name = city.Country.Name
            geoip_info.region_code = city.MostSpecificSubdivision.IsoCode
            geoip_info.region_name = city.MostSpecificSubdivision.Name
            geoip_info.city_name = city.City.Name
            geoip_info.city_postal = city.Postal.Code
            geoip_info.latitude = city.Location.Latitude
            geoip_info.longtitude = city.Location.Longitude

            '   Dim cache_file As New StreamWriter(Application.StartupPath & "\temp\geo.cache", True)
            '  cache_file.WriteLine(DateTime.Now & "," & city.City.Name & "," & city.Country.Name & "," & city.Continent.Name & "," & city.Location.Latitude & "," & city.Location.Longitude & "," & city.Postal.Code)
            ' cache_file.Close()

            Return geoip_info
        Catch ex As Exception
            Return Nothing
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

    Public Function GetLocationFromWeb() As geoip_data
        Dim geoip_string As String
        Dim geoip_info As geoip_data
        '  Dim test123 As String = "82.206.64.226,DE,Germany,HE,Hesse,Hofheim am Taunus,65719,Europe/Berlin,50.0833,8.4500,0"

        Try
            Using wc As New Net.WebClient
                geoip_string = System.Text.Encoding.UTF8.GetString(wc.DownloadData("http://freegeoip.net/csv"))
            End Using
            geoip_string = geoip_string.Replace(" ", "")
            geoip_string = geoip_string.Trim

            Dim geoip_array As String()
            geoip_array = geoip_string.Split(",")

            geoip_info.ip = geoip_array(0)
            geoip_info.country_code = geoip_array(1)
            geoip_info.country_name = geoip_array(2)
            geoip_info.region_code = geoip_array(3)
            geoip_info.region_name = geoip_array(4)
            geoip_info.city_name = geoip_array(5)
            geoip_info.city_postal = geoip_array(6)
            geoip_info.latitude = geoip_array(8)
            geoip_info.longtitude = geoip_array(9)

            Return geoip_info
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module
