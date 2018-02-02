Module plg_ykinv
    Public Structure ykinv
        Dim Serial As String
        Dim GUID As String
        Dim Name As String
        Dim user As String
    End Structure

    Public res_ykinv As ykinv

    Public Function ykinv_serial_exists(ByVal serial As String) As Boolean
        Dim sqlitecmd As String = "Select id FROM ykresult_inv WHERE serial='" & serial & "' AND user='" & My.User.Name & "'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function ykinv_serial_get(ByVal serial As String) As ykinv
        Dim result As ykinv
        Dim sqlitecmd As String = "Select * FROM ykresult_inv WHERE serial='" & serial & "' AND user='" & My.User.Name & "'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 4)
            result.GUID = TryCast(res_array(1), String)
            result.Serial = TryCast(res_array(2), String)
            result.Name = TryCast(res_array(3), String)
            result.user = TryCast(res_array(4), String)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function ykinv_serial_change(ByVal data As ykinv) As Boolean
        Dim sqlitecmd As String
        sqlitecmd = "Update ykresult_inv SET uid='" & data.GUID & "',serial='" & data.Serial & "',name='" & data.Name & "',user='" & data.user & "' WHERE serial='" & data.Serial & "' AND user='" & data.user & "'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteNonQuery("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function ykinv_serial_add(ByVal data As ykinv) As Boolean
        Dim sqlitecmd As String
        data.Name = data.Name.Replace("'", "''")
        sqlitecmd = "INSERT INTO ykresult_inv (uid,serial,name,user) VALUES ('" & Guid.NewGuid.ToString & "','" & data.Serial & "','" & data.Name & "','" & My.User.Name & "')"
        Dim result As Boolean = False
        Try
            result = db.ExecuteNonQuery("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function ykinv_delete() As Boolean

    End Function

End Module
