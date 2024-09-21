Module ConstantManagement

    Public ReadOnly SETTING_FILE_PATH As String = "..\..\..\settings.ini"
    Public SESSION_FILE_PATH As String = "..\..\..\Session\Temp\temp_ses.file"
    Public SESSION_TIME As Integer = 3
    Public LOGIN_CLASS As String = "TugasBesarMasCepi.Form1"

    Public ReadOnly UserTableColumn As KeyValuePair(Of String, String()) = New KeyValuePair(Of String, String())("user_table", New String() {"id", "email", "username", "user_password"})

End Module
