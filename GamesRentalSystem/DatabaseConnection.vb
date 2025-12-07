Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=;database=games_rental_system")

    Public Sub openConn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub closeConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
