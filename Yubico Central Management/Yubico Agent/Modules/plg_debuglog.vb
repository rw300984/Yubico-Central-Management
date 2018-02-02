Module plg_debuglog
    Public Function WriteLog(ByVal text As String, ByVal type As Integer, ByVal modul As String)
        Dim severity As String
        Select Case type
            Case 0
                severity = "info"
            Case 1
                severity = "warning"
            Case 2
                severity = "error"
            Case 3
                severity = "debug"
            Case 4
                severity = "exception"
        End Select
        Dim message As String = DateTime.Now & ";" & My.User.Name & ";" & modul & ";" & severity & ";" & text
        Dim log As New StreamWriter(Application.StartupPath & "\log\Debug.log", True)
        log.WriteLine(message)
        log.Close()
        log.Dispose()
    End Function
End Module
