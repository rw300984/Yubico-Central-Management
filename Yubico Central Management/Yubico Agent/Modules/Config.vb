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
        Dim integrity_lang_de As String
        Dim integrity_lang_en As String
        Dim integrity_tools As String
        Dim integrity_geoip As String

        ' Below global config variables but not written to config.xml

        Dim integrity_lang_de_file As String
        Dim integrity_lang_en_file As String
        Dim integrity_tools_file As String
        Dim integrity_geoip_file As String
        Dim config_path_file As String
        Dim temp_path As String
    End Structure
    Public Function Write_Config(ByVal config_file As String, ByVal key As String) As Integer
        Dim ConfigWriter As New XmlTextWriter(config_file, System.Text.Encoding.UTF8)
        ConfigWriter.WriteStartDocument(True)
        ConfigWriter.Formatting = Formatting.Indented
        ConfigWriter.Indentation = 2
        ConfigWriter.WriteStartElement("Configuration")
        CreateNodes("intial_verify", Crypto.AES_Encrypt(cfg_config.initial_verify, key), ConfigWriter)
        CreateNodes("intial_enabled", cfg_config.initial_enabled, ConfigWriter)
        CreateNodes("admin_general_lang", cfg_config.admin_general_lang, ConfigWriter)
        CreateNodes("admin_general_theme", cfg_config.admin_general_theme, ConfigWriter)
        CreateNodes("admin_general_mode", Crypto.AES_Encrypt(cfg_config.admin_general_mode, key), ConfigWriter)
        CreateNodes("admin_central_server", Crypto.AES_Encrypt(cfg_config.admin_central_server, key), ConfigWriter)
        CreateNodes("admin_central_auth", Crypto.AES_Encrypt(cfg_config.admin_central_auth, key), ConfigWriter)
        CreateNodes("admin_central_username", Crypto.AES_Encrypt(cfg_config.admin_central_username, key), ConfigWriter)
        CreateNodes("admin_central_password", Crypto.AES_Encrypt(cfg_config.admin_central_password, key), ConfigWriter)
        CreateNodes("integrity_lang_de", Crypto.AES_Encrypt(SHA1FileHash(cfg_config.integrity_lang_de_file), key), ConfigWriter)
        CreateNodes("integrity_lang_en", Crypto.AES_Encrypt(SHA1FileHash(cfg_config.integrity_lang_en_file), key), ConfigWriter)
        CreateNodes("integrity_tools", Crypto.AES_Encrypt(SHA1FileHash(cfg_config.integrity_tools_file), key), ConfigWriter)
        CreateNodes("integrity_geoip", Crypto.AES_Encrypt(SHA1FileHash(cfg_config.integrity_geoip_file), key), ConfigWriter)
        ConfigWriter.WriteEndElement()
        ConfigWriter.WriteEndDocument()
        ConfigWriter.Close()
    End Function
    Public Function Read_Config(ByVal file As String, ByVal ConfigAttribute As String)
        Dim ConfigReader As New Xml.XmlDocument
        Dim ConfigReader_Result As String
        ConfigReader.Load(file)
        ConfigReader_Result = ConfigReader.DocumentElement.ChildNodes(ConfigAttribute).InnerText
        Return ConfigReader_Result
    End Function
    Private Sub CreateNodes(ByVal Element As String, ByVal Value As String, ByVal ConfigWriter As XmlTextWriter)
        ConfigWriter.WriteStartElement(Element)
        ConfigWriter.WriteString(Value)
        ConfigWriter.WriteEndElement()
    End Sub
    Public Function GetConfig(ByVal config As String, ByVal key As String)
        Dim counter As Integer = 0
        cfg_config.initial_verify = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.initial_enabled = Read_Config(config, counter)
        counter = counter + 1
        cfg_config.admin_general_lang = Read_Config(config, counter)
        counter = counter + 1
        cfg_config.admin_general_theme = Read_Config(config, counter)
        counter = counter + 1
        cfg_config.admin_general_mode = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.admin_central_server = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.admin_central_auth = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.admin_central_username = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.admin_central_password = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.integrity_lang_de = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.integrity_lang_en = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.integrity_tools = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
        cfg_config.integrity_geoip = Crypto.AES_Decrypt(Read_Config(config, counter), key)
        counter = counter + 1
    End Function
End Module
