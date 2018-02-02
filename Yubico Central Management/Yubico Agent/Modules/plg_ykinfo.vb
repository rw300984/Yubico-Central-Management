Module plg_ykinfo
    Public Structure ykinfo
        Dim serial As String
        Dim firmware As String
        Dim touch As String
        Dim vendor As String
        Dim model As String
    End Structure
    Public res_ykinfo As ykinfo
    Public Function AddYKInfoToDB(ByVal ykinfo As ykinfo) As Boolean
        Dim sqlitecmd As String
        Dim state As Boolean = CheckIfYKInfoinDB()
        If state = False Then
            sqlitecmd = "INSERT INTO ykresult_info (vendor,model,serial,firmware,touch) VALUES ('" & ykinfo.vendor & "','" & ykinfo.model & "','" & ykinfo.serial & "','" & ykinfo.firmware & "','" & ykinfo.touch & "')"
        Else
            sqlitecmd = "UPDATE ykresult_info SET vendor='" & ykinfo.vendor & "',model='" & ykinfo.model & "',serial='" & ykinfo.serial & "',firmware='" & ykinfo.firmware & "',touch='" & ykinfo.touch & "' WHERE id='1'"
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
    Public Function CheckIfYKInfoinDB() As Boolean
        Dim sqlitecmd As String = "Select id FROM ykresult_info WHERE id='1'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function GetYKInfoFromDB() As ykinfo
        Dim result As ykinfo
        Dim sqlitecmd As String = "Select * FROM ykresult_info WHERE id='1'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 5)
            result.vendor = TryCast(res_array(1), String)
            result.model = TryCast(res_array(2), String)
            result.serial = TryCast(res_array(3), String)
            result.firmware = TryCast(res_array(4), String)
            result.touch = TryCast(res_array(5), String)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
    Public Function YK_Agent_GetFromykinfo() As String()
        Try
            Dim ykinfo_result(9) As String
            Dim plugin_ykinfo_path As String = Application.StartupPath & "\Plugins\ykinfo"
            Dim ykinfo_export As String = plugin_ykinfo_path & "\ykinfo.txt"
            Dim ps_ykinfo As New System.Diagnostics.Process()
            With ps_ykinfo.StartInfo
                .FileName = plugin_ykinfo_path & "\export.bat"
                .WorkingDirectory = plugin_ykinfo_path
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function YK_Agent_ConvertInfo_to_Names(ByVal mode As Integer, ByVal input As String) As String
        Try
            Dim result As String = "not available"
            Select Case mode
                Case 0 ' Vendor assignment
                    Select Case input
                        Case "1050"
                            result = "Yubico AB"
                    End Select
                Case 1 ' Model assignment
                    Select Case input
                        Case "407"
                            result = "Yubikey 4 Nano"
                    End Select
            End Select
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
End Module
