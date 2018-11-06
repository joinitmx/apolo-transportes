Public Class Errores

    Private vMensajeError As String

    Public Property MensajeError As String
        Get
            Return vMensajeError
        End Get
        Set(value As String)
            vMensajeError = value
        End Set
    End Property

End Class
