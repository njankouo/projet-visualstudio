Imports MySql.Data.MySqlClient
Public Class paiement
        Private id_ As Integer
        Private type_paiement_ As String
        Private date_paiement_ As Date
        Private montant_ As String
        Private personnel_ As Personnel
#Region "les proprietes"
        Public Property id()
            Get
                Return id_
            End Get
            Set(ByVal value)
                id_ = value
            End Set
        End Property

        Public Property personnel() As Personnel
            Get
                Return personnel_
            End Get
            Set(ByVal value As Personnel)
                personnel_ = value
            End Set
        End Property

        Public Property type_paiement()
            Get
                Return type_paiement_
            End Get
            Set(ByVal value)
                type_paiement_ = value
            End Set
        End Property
        Public Property date_paiement()
            Get
                Return date_paiement_
            End Get
            Set(ByVal value)
                date_paiement_ = value
            End Set
        End Property
        Public Property montant()
            Get
                Return montant_
            End Get
            Set(ByVal value)
                montant_ = value
            End Set
        End Property
#End Region

End Class
