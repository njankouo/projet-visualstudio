Imports MySql.Data.MySqlClient

Public Class utilisateurcontrollers
    Public Shared Function contrôle(ByVal login As Object, ByVal password As Object) As Boolean
        Dim result As Boolean = False
        Dim cmd As New MySqlCommand("select * from utilisateur where  login=? and password= ?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", login)
        cmd.Parameters.AddWithValue("b", password)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            result = True
        End If
        Return result
    End Function

    Public Shared Sub save(ByVal u As utilisateurvb)
        If (u.Id = 0) Then
            Dim cmd As New MySqlCommand("insert into utilisateur(nomuser,login,password) values(?,?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("a", u.nomuser)
            cmd.Parameters.AddWithValue("b", u.login)
            cmd.Parameters.AddWithValue("c", u.password)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New MySqlCommand("update utilisateur set nomuser=?,login=?,password=? where id=?", BDD.connecter())
            cmd.Parameters.AddWithValue("a", u.nomuser)
            cmd.Parameters.AddWithValue("b", u.login)
            cmd.Parameters.AddWithValue("c", u.password)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
    End Sub

    Public Shared Sub delete(ByVal id As Integer)
        Dim cmd As New MySqlCommand("delete from utilisateur  where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'recherche une ligne d'un enregistrement 
    Public Shared Function find(ByVal id As Integer) As utilisateurvb
        Dim u As utilisateurvb = New utilisateurvb()
        Dim cmd As New MySqlCommand("select * from utilisateur where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            u.Id = dr.GetInt32(0)
            u.nomuser = dr.GetString(1)
            u.login = dr.GetDouble(2)
            u.password = dr.GetDouble(3)
        End If
        cmd.Dispose()
        dr.Close()
        Return u
    End Function

    Public Shared Function findAll() As List(Of utilisateurvb)
        Dim fs As List(Of utilisateurvb) = New List(Of utilisateurvb)()
        Dim cmd As New MySqlCommand("select id from utilisateur ", BDD.connecter())
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim u As utilisateurvb = find(dr.GetInt32(0))
            fs.Add(u)
        End While
        cmd.Dispose()
        dr.Close()
        Return fs
    End Function

End Class
