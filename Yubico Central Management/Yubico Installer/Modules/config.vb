Imports System.Xml

Module config
    Public cfg As Configuration
    Public Structure Configuration
        Dim install_path_mode As Integer
        Dim install_path_custom As String
        Dim install_path_default As String
        Dim install_path_success As Integer
        Dim install_update_mode As Integer
        Dim install_update_success As Integer
        Dim install_password_mode As Integer
        Dim install_password_random As String
        Dim install_password_custom As String
        Dim install_password_success As Integer
        Dim install_options_mode As String
        Dim install_options_business_server As String
        Dim install_options_business_auth As String
        Dim install_options_business_username As String
        Dim install_options_business_password As String
        Dim install_options_success As Integer
        Dim main_action As Integer
        Dim install_success_status As Integer
        Dim install_rollback_status As Integer
    End Structure
    Public Structure initial_configuration
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
        Dim integrity_lang_de_file As String
        Dim integrity_lang_en_file As String
        Dim integrity_tools As String
        Dim integrity_tools_file As String
        Dim integrity_geoip As String
        Dim integrity_geoip_file As String

    End Structure
    Public Function Write_Config(ByVal config_file As String, ByVal key As String, ByVal cfg_config As initial_configuration) As Integer
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
    Private Sub CreateNodes(ByVal Element As String, ByVal Value As String, ByVal ConfigWriter As XmlTextWriter)
        ConfigWriter.WriteStartElement(Element)
        ConfigWriter.WriteString(Value)
        ConfigWriter.WriteEndElement()
    End Sub
End Module
