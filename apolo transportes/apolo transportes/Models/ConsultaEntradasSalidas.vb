Public Class ConsultaEntradasSalidasListResponse
    Private vEntradas As Integer
    Private vSalidas As Integer
    Private vId As Integer
    Private vFecha As String
    Private vidChofer As Integer
    Private vidVehiculo As Integer
    Private vidChofer As Integer
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

    Public Property Entradas As String
        Get
            Return vEntradas
        End Get
        Set(value As String)
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
