Imports MySql.Data.MySqlClient
Public Class BDD
    
    Public Shared Function connecter()
        Dim con As String = ("dsn=bdpaint")
        Dim conn As MySqlConnection = New MySqlConnection

        conn.ConnectionString = con
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'Else
                '   conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return conn
    End Function
End Class
