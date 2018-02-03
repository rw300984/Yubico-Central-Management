Imports System.Xml

Module Config
    Public cfg_config As configuration
    Public Structure configuration
        Dim initial_enabled As Integer
        Dim initial_verify As String
        Dim admin_general_lang As String
        Dim admin_general_theme As String
        Dim admin_general_mode As String
        Dim admin_central_server As String
        Dim admin_central_auth As String
        Dim admin_central_username As String
        Dim admin_central_password As String
        'Dim integrity_lang_de As String
        'Dim integrity_lang_en As String
        'Dim integrity_tools As String
        'Dim integrity_geoip As String

        ' Below global config variables but not written to config.xml

        Dim integrity_lang_de_file As String
        Dim integrity_lang_en_file As String
        Dim integrity_tools_file As String
        Dim integrity_geoip_file As String
        Dim config_path_file As String
        Dim temp_path As String
    End Structure
    Public Function Read_Config(ByVal file As String, ByVal ConfigAttribute As String)
        Try
            Dim ConfigReader As New Xml.XmlDocument
            Dim ConfigReader_Result As String
            ConfigReader.Load(file)
            ConfigReader_Result = ConfigReader.DocumentElement.ChildNodes(ConfigAttribute).InnerText
            Return ConfigReader_Result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function AddConfigGeneralToDB(ByVal key As String, ByVal data As configuration) As Boolean
        Dim sqlitecmd As String
        Dim state As Boolean = CheckIfGeneralinDB()
        If state = False Then
            sqlitecmd = "INSERT INTO ykconfig_general (initial,lang,theme,mode,server,auth,user,password) VALUES ('" & SHA512StringHash(key) & "','" & data.admin_general_lang & "','" & data.admin_general_theme & "','" & Crypto.AES_Encrypt(data.admin_general_mode, key) & "','" & Crypto.AES_Encrypt(data.admin_central_server, key) & "','" & Crypto.AES_Encrypt(data.admin_central_auth, key) & "','" & Crypto.AES_Encrypt(data.admin_central_username, key) & "','" & Crypto.AES_Encrypt(data.admin_central_password, key) & "')"
        Else
            If data.admin_general_mode = "Business" Then
                sqlitecmd = "UPDATE ykconfig_general Set initial='" & SHA512StringHash(key) & "',lang='" & data.admin_general_lang & "',theme='" & data.admin_general_theme & "',mode='" & Crypto.AES_Encrypt(data.admin_general_mode, key) & "',server='" & Crypto.AES_Encrypt(data.admin_central_server, key) & "',auth='" & Crypto.AES_Encrypt(data.admin_central_auth, key) & "',user='" & Crypto.AES_Encrypt(data.admin_central_username, key) & "',password='" & Crypto.AES_Encrypt(data.admin_central_password, key) & "' WHERE id=1"
            Else
                sqlitecmd = "UPDATE ykconfig_general Set initial='" & SHA512StringHash(key) & "',lang='" & data.admin_general_lang & "',theme='" & data.admin_general_theme & "',mode='" & Crypto.AES_Encrypt(data.admin_general_mode, key) & "' WHERE id=1"
            End If
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

    Public Function GetSingleValueFromDB(ByVal column As String) As String
        Dim result As String
        Dim sqlitecmd As String = "Select " & column & " FROM ykconfig_general WHERE id='1'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 0)
            result = TryCast(res_array(0), String)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function CheckIfGeneralinDB() As Boolean
        Dim sqlitecmd As String = "Select id FROM ykconfig_general WHERE id='1'"
        Dim result As Boolean = False
        Try
            result = db.ExecuteScalar("\database\data.db", sqlitecmd)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function

    Public Function GetConfigGeneralFromDB(ByVal key As String) As configuration
        Dim result As configuration
        Dim sqlitecmd As String = "Select * FROM ykconfig_general WHERE id='1'"
        Try
            Dim res_array As Object() = db.ExecuteReaderSingleRow("\database\data.db", sqlitecmd, 8)
            result.initial_verify = res_array(1)
            result.admin_general_lang = TryCast(res_array(2), String)
            result.admin_general_theme = TryCast(res_array(3), String)
            result.admin_general_mode = Crypto.AES_Decrypt(res_array(4), key)
            result.admin_central_server = Crypto.AES_Decrypt(res_array(5), key)
            result.admin_central_auth = Crypto.AES_Decrypt(res_array(6), key)
            result.admin_central_username = Crypto.AES_Decrypt(res_array(7), key)
            result.admin_central_username = Crypto.AES_Decrypt(res_array(8), key)
            Return result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return result
        End Try
    End Function
End Module
