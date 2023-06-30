Module MainMod
    'Public con As New MySqlConnection
    Public msCon As New SqlConnection

    Public Sub dbopen()
        If msCon.State = ConnectionState.Open Then msCon.Close()
        msCon.ConnectionString = My.Settings.mssqlCon
        msCon.Open()
    End Sub

    Public Function NullText(ByVal x As Object) As Object
        On Error GoTo errhanler
        If IsDBNull(x) Then
            NullText = " "
        Else
            NullText = x
        End If
errhanler:
        If Err.Number > 0 Then
            NullText = " "
        End If
    End Function

    Public Function NullNum(ByVal x As Object) As Object
        If IsDBNull(x) Then
            NullNum = 0
        Else
            NullNum = x
        End If
    End Function


End Module
