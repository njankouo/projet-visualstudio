Imports MySql.Data.MySqlClient
Public Class Fonction
    Private id_ As Integer
    Private libelle_ As String
    Private salairebase_ As Double


#Region "Les propriétés"

    Public Property Id()
        Get
            Return id_
        End Get
        Set(ByVal value)
            id_ = value
        End Set
    End Property

    Public Property Libelle()
        Get
            Return libelle_
        End Get
        Set(ByVal value)
            libelle_ = value
        End Set
    End Property
    Public Property SalaireBase()
        Get
            Return salairebase_
        End Get
        Set(ByVal value)
            salairebase_ = value
        End Set
    End Property
#End Region

End Class
