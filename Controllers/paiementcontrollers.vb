
Imports MySql.Data.MySqlClient
Public Class paiementControllers
    Public Shared Sub save(ByVal paiement As Paiement)
        If (paiement.id = 0) Then
            Dim cmd As New MySqlCommand("insert into paiement(type_paiement,date_paiement,montant,idpersonnel)values (?,?,?,?)", BDD.connecter())

            cmd.Parameters.AddWithValue("a", paiement.type_paiement)
            cmd.Parameters.AddWithValue("b", paiement.date_paiement)
            cmd.Parameters.AddWithValue("c", paiement.montant)
            cmd.Parameters.AddWithValue("d", paiement.personnel.id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Else
            Dim cmd As New MySqlCommand("update paiement set type_paiement=?,date_paiement=?,montant=?,idpersonnel=?,where id=?", BDD.connecter())

            cmd.Parameters.AddWithValue("a", paiement.type_paiement)
            cmd.Parameters.AddWithValue("b", paiement.date_paiement)
            cmd.Parameters.AddWithValue("c", paiement.montant)
            cmd.Parameters.AddWithValue("d", paiement.personnel.id)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        End If
    End Sub

    Public Shared Sub delete(ByVal id As Integer)
        Dim cmd As New MySqlCommand("delete from paiement where id=?", BDD.connecter())

        cmd.Parameters.AddWithValue("a", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Shared Function find(ByVal id As Integer) As paiement
        Dim p As New paiement()
        Dim cmd As New MySqlCommand("select * from paiement where id=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", id)

        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            p.id = dr.GetInt32(0)
            p.type_paiement = dr.GetString(1)
            p.date_paiement = dr.GetString(2)
            p.montant = dr.GetString(3)
            p.personnel = PersonnelControllers.find(dr.GetInt32(4))
        End If
        cmd.Dispose()
        Return p
    End Function
    Public Shared Function findall() As List(Of paiement)
        Dim ps As New List(Of paiement)
        Dim cmd As New MySqlCommand("select id from paiement", BDD.connecter())
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim p As paiement = find(dr.GetInt32(0))
            ps.Add(p)

        End While
        cmd.Dispose()
        dr.Close()
        Return ps


    End Function

End Class
