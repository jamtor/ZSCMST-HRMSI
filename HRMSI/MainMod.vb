Module MainMod
    'Public con As New MySqlConnection
    Public msCon As New SqlConnection

    Public Sub dbopen()
        If msCon.State = ConnectionState.Open Then msCon.Close()
        msCon.ConnectionString = My.Settings.mssqlCon
        msCon.Open()
    End Sub

End Module
