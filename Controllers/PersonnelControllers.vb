Imports MySql.Data.MySqlClient
Public Class PersonnelControllers
    Public Shared Sub save(ByVal personnel As Personnel)
        If (personnel.id = 0) Then
            Dim cmd As New MySqlCommand("insert into personnel(nom,sexe,telephone,datenaissance,lieu_naissance,salaire_negocier,idfonction) values(?,?,?,?,?,?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("a", personnel.nom)
            cmd.Parameters.AddWithValue("b", personnel.sexe)
            cmd.Parameters.AddWithValue("c", personnel.telephone)
            cmd.Parameters.AddWithValue("d", personnel.datenaissance)
            cmd.Parameters.AddWithValue("e", personnel.lieunaissance)
            cmd.Parameters.AddWithValue("f", personnel.salairenegocier)
            cmd.Parameters.AddWithValue("g", personnel.fonction.Id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New MySqlCommand("update personnel set nom=?,sexe=?,telephone=?,datenaissance=?,lieu_naissance=?,salaire_negocier=?,idfonction=? where id=?", BDD.connecter())
            cmd.Parameters.AddWithValue("a", personnel.nom)
            cmd.Parameters.AddWithValue("b", personnel.sexe)
            cmd.Parameters.AddWithValue("c", personnel.telephone)
            cmd.Parameters.AddWithValue("d", personnel.datenaissance)
            cmd.Parameters.AddWithValue("e", personnel.lieunaissance)
            cmd.Parameters.AddWithValue("f", personnel.salairenegocier)
            cmd.Parameters.AddWithValue("g", personnel.fonction.Id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
    End Sub
    Public Shared Sub delete(ByVal id As Integer)
        Dim cmd As New MySqlCommand("delete from personnel where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Shared Function find(ByVal id As Integer) As Personnel
        Dim p As New Personnel()
        Dim cmd As New MySqlCommand("select * from personnel where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            p.id = dr.GetInt32(0)
            p.nom = dr.GetString(1)
            p.sexe = dr.GetString(2)
            p.telephone = dr.GetString(3)
            p.datenaissance = dr.GetDateTime(4)
            p.lieunaissance = dr.GetString(5)
            p.salairenegocier = dr.GetInt32(6)
            p.fonction = FonctionControllers.find(dr.GetInt32(7))
        End If
        cmd.Dispose()
        Return p
    End Function



    'recuperer id du personnel
    Public Shared Function find(ByVal id As String) As Personnel
        Dim p As Personnel = New Personnel()
        Dim cmd As New MySqlCommand("select id from personnel where nom=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            p.id = dr.GetInt32(0)
        End If
        cmd.Dispose()
        dr.Close()
        Return p
    End Function
    'recherche le personnel 

    Public Shared Function bosco(ByVal fantome As String) As Personnel

        Dim p As Personnel = New Personnel()
        Dim cmd As New MySqlCommand("select * from personnel where nom=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", fantome)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            p.id = dr.GetInt32(0)
            p.nom = dr.GetString(1)
            p.sexe = dr.GetString(2)
            p.telephone = dr.GetString(3)
            p.datenaissance = dr.GetDateTime(4)
            p.lieunaissance = dr.GetString(5)
            p.salairenegocier = dr.GetInt32(6)
            p.fonction = FonctionControllers.find(dr.GetInt32(7))

        End If
        cmd.Dispose()
        dr.Close()
        Return p

    End Function






    Public Shared Function findAll() As List(Of Personnel)
        Dim ps As New List(Of Personnel)
        Dim cmd As New MySqlCommand("select id from personnel", BDD.connecter())
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim p As Personnel = find(dr.GetInt32(0))
            ps.Add(p)
        End While
        cmd.Dispose()
        dr.Close()
        Return ps
    End Function
End Class