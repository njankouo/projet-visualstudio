Imports MySql.Data.MySqlClient
Public Class FonctionControllers
    Public Shared Sub save(ByVal f As Fonction)
        If (f.Id = 0) Then
            Dim cmd As New MySqlCommand("insert into fonction(libelle,salairebase) values(?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("a", f.Libelle)
            cmd.Parameters.AddWithValue("b", f.SalaireBase)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New MySqlCommand("update fonction set libelle=?,salairebase=? where id=?", BDD.connecter())
            cmd.Parameters.AddWithValue("a", f.Libelle)
            cmd.Parameters.AddWithValue("b", f.SalaireBase)
            cmd.Parameters.AddWithValue("c", f.Id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
    End Sub
    Public Shared Sub delete(ByVal id As Integer)
        Dim cmd As New MySqlCommand("delete from fonction  where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'recherche une ligne d'un enregistrement 
    Public Shared Function find(ByVal id As Integer) As Fonction
        Dim f As Fonction = New Fonction()
        Dim cmd As New MySqlCommand("select * from fonction where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            f.Id = dr.GetInt32(0)
            f.Libelle = dr.GetString(1)
            f.SalaireBase = dr.GetDouble(2)
        End If
        cmd.Dispose()
        dr.Close()
        Return f
    End Function
    'recuperer id de la fonction
    Public Shared Function find(ByVal id As String) As Fonction
        Dim f As Fonction = New Fonction()
        Dim cmd As New MySqlCommand("select id from fonction where libelle=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            f.Id = dr.GetInt32(0)
        End If
        cmd.Dispose()
        dr.Close()
        Return f
    End Function
    ' liste des fonctions
    Public Shared Function findAll() As List(Of Fonction)
        Dim fs As New List(Of Fonction)()
        Dim cmd As New MySqlCommand("select id from fonction ", BDD.connecter())
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim f As Fonction = find(dr.GetInt32(0))
            fs.Add(f)
        End While
        cmd.Dispose()
        dr.Close()
        Return fs
    End Function
End Class

