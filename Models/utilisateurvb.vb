Public Class utilisateurvb
    Private id_ As Integer
    Private nomuser_ As String
    Private login_ As Integer
    Private password_ As Integer


#Region "Les propriétés"

    Public Property Id()
        Get
            Return id_
        End Get
        Set(ByVal value)
            id_ = value
        End Set
    End Property



    Public Property nomuser()
        Get
            Return nomuser_
        End Get
        Set(ByVal value)
            nomuser_ = value
        End Set
    End Property



    Public Property login()
        Get
            Return login_
        End Get
        Set(ByVal value)
            login_ = value
        End Set
    End Property


    Public Property password()
        Get
            Return password_
        End Get
        Set(ByVal value)
            password_ = value
        End Set
    End Property


#End Region

End Class
