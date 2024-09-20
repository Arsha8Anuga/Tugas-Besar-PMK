Module ConstantManagement

    Public SETTING_FILE_PATH As String = "..\settings.ini"

    Public ReadOnly UserTableColumn As KeyValuePair(Of String, String()) = New KeyValuePair(Of String, String())("user_table", New String() {"id", "email", "username", "user_password"})

End Module
