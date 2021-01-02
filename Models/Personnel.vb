Public Class Personnel
    Private id_ As Integer
    Private sexe_ As String
    Private nom_ As String
    Private telephone_ As String
    Private fonction_ As Fonction
    Private datenaissance_ As Date
    Private salairenegocier_ As String
    Private lieunaissance_ As String

#Region "les proprietes"
    Public Property id()
        Get
            Return id_
        End Get
        Set(ByVal value)
            id_ = value
        End Set
    End Property
    Public Property fonction() As Fonction
        Get
            Return fonction_
        End Get
        Set(ByVal value As Fonction)
            fonction_ = value
        End Set
    End Property
    Public Property sexe()
        Get
            Return sexe_
        End Get
        Set(ByVal value)
            sexe_ = value
        End Set
    End Property
    Public Property nom()
        Get
            Return nom_
        End Get
        Set(ByVal value)
            nom_ = value
        End Set
    End Property
    Public Property telephone()
        Get
            Return telephone_
        End Get
        Set(ByVal value)
            telephone_ = value
        End Set
    End Property
    Public Property datenaissance()
        Get
            Return datenaissance_
        End Get
        Set(ByVal value)
            datenaissance_ = value
        End Set
    End Property
    Public Property lieunaissance()
        Get
            Return lieunaissance_
        End Get
        Set(ByVal value)
            lieunaissance_ = value
        End Set
    End Property
    Public Property salairenegocier()
        Get
            Return salairenegocier_
        End Get
        Set(ByVal value)
            salairenegocier_ = value
        End Set
    End Property
#End Region
End Class
