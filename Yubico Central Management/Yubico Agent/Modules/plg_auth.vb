Module plg_auth
    Public Structure auth_user
        Dim user As String
        Dim role As String
        Dim key As String
    End Structure

    Public Function AddUserToDB(ByVal machine_key As String, ByVal data As auth_user) As Boolean
        Dim sqlitecmd As String
        Dim state As Boolean = CheckIfUserInDB()
        If state = False Then
            sqlitecmd = "INSERT INTO ykauth_users (user,role,key) VALUES ('" & data.user & "','" & data.role & "','" & Crypto.AES_Encrypt(machine_key, data.key) & "')"
        Else
            sqlitecmd = "UPDATE ykauth_users Set user='" & data.user & "',role='" & data.role & "',key='" & Crypto.AES_Encrypt(machine_key, data.key) & "'' WHERE user='" & data.user & "'"
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

    Public Function GetUserFromDB() As auth_user
        Dim result As auth_user
        Dim sqlitecmd As String = "Select * FROM ykauth_users WHERE user='" & My.User.Name & "'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 3)
            result.user = TryCast(res_array(1), String)
            result.role = TryCast(res_array(2), String)
            result.key = TryCast(res_array(3), String)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function CheckIfUserInDB() As Boolean
        Dim sqlitecmd As String = "Select id FROM ykauth_users WHERE user='" & My.User.Name & "'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function CheckIfUsersExists() As Boolean
        Dim sqlitecmd As String = "Select id FROM ykauth_users WHERE id='1'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function VerifyUser(userpassword As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim user As auth_user
            Dim user_exists As Boolean = plg_auth.CheckIfUserInDB()
            If user_exists = True Then
                user = plg_auth.GetUserFromDB()
                Dim SHA1_Machinekey As String = SHA1StringHash(AES_Decrypt(user.key, userpassword))
                If SHA1_Machinekey = Config.GetSingleValueFromDB("initial") Then
                    result = True
                End If
            Else
                result = False
            End If
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

End Module
