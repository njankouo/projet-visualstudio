Public Class Utilisateur
    Private Id_ As Integer
    Private Nom_ As String
    Private Login_ As String
    Private Password_ As String

#Region "Get et Set"
    Public Property Id
        Get
            Return Id_
        End Get
        Set(ByVal value)
            Id_ = value
        End Set
    End Property

    Public Property Nom
        Get
            Return Nom_
        End Get
        Set(ByVal value)
            Nom_ = value
        End Set
    End Property

    Public Property Login
        Get
            Return Login_
        End Get
        Set(ByVal value)
            Login_ = value
        End Set
    End Property

    Public Property Password
        Get
            Return Password_
        End Get
        Set(ByVal value)
            Password_ = value
        End Set
    End Property
#End Region
End Class
