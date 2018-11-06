Public Class CatalogoPuntosCheckListResponse

    Private vTipoImagen As Integer
    Private vDescripcion As String
    Private vId As Integer

    Public Property Id As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return vDescripcion
        End Get
        Set(value As String)
            vDescripcion = value
        End Set
    End Property

    Public Property TipoImagen As Integer
        Get
            Return vTipoImagen
        End Get
        Set(value As Integer)
            vTipoImagen = value
        End Set
    End Property

End Class

Public Class CatalogoPuntosCheckListRequest

    Private vEstatus As Integer

    Public Property Estatus As Integer
        Get
            Return vEstatus
        End Get
        Set(ByVal value As Integer)
            vEstatus = value
        End Set
    End Property

End Class
