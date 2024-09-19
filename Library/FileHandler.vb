Imports System.IO

Module FileHandler

    Private Const SELECT_ALL_LINES As String = "all"


    Public Function EnvReader(filePath As String, ParamArray fileHeader As String()) As String()

        Dim fileChecker As New FileInfo(filePath)
        Dim dataHolder As New List(Of String)()

        If fileChecker.Exists Then
            Dim lines As String() = File.ReadAllLines(filePath)

        End If


    End Function

End Module
