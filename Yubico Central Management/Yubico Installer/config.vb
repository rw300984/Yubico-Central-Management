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
        Dim install_options_mode As Integer
        Dim install_options_business_auth As String
        Dim install_options_business_username As String
        Dim install_options_business_password As String
        Dim install_options_success As Integer
    End Structure
End Module
