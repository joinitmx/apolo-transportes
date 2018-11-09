Public Class ConsultaEntradasSalidasListResponse
    Private vEntradas As Integer
    Private vSalidas As Integer
    Private vId As Integer
    Private vFecha As String
    Private vidChofer As Integer
    Private vidVehiculo As Integer
    Private vidOrigenes As Integer
    Private vidTipoCarga As Integer
    Private vidTipoTransporte As Integer
    Private vEstatus As Integer
    
    Public Property Id As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Public Property Entradas As Integer
        Get
            Return vEntradas
        End Get
        Set(value As Integer)
            vEntradas = value
        End Set
    End Property

    Public Property Salidas As Integer
        Get
            Return vSalidas
        End Get
        Set(value As Integer)
            vSalidas = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return vFecha
        End Get
        Set(value As Fecha)
            vFecha = value
        End Set
    End Property
    
    Public Property idOrigenes As Integer
        Get
            Return vidOrigenes
        End Get
        Set(value As Integer)
            vidOrigenes = value
        End Set
    End Property
    
    Public Property idChofer As Integer
        Get
            Return vidChofer
        End Get
        Set(value As Integer)
            vidChofer = value
        End Set
    End Property
    
    Public Property idVehiculo As Integer
        Get
            Return vidVehiculo
        End Get
        Set(value As Integer)
            vidVehiculo = value
        End Set
    End Property
    
    Public Property idTipoCarga As Integer
        Get
            Return vidTipoCarga
        End Get
        Set(value As Integer)
            vidTipoCarga = value
        End Set
    End Property
    
    Public Property idTipoTransporte As Integer
        Get
            Return vidTipoTransporte
        End Get
        Set(value As Integer)
            vidTipoTransporte = value
        End Set
    End Property
    
    Public Property Estatus As Integer
        Get
            Return vEstatus
        End Get
        Set(value As Integer)
            vEstatus = value
        End Set
    End Property
    
End Class

Public Class ConsultaEntradasSalidasListRequest

    Private vTipo As Integer

    Public Property Tipo As Integer
        Get
            Return vTipo
        End Get
        Set(ByVal value As Integer)
            vTipo = value
        End Set
    End Property

End Class
