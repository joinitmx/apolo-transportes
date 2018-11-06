Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class CatalogoPuntosCheckListController
        Inherits ApiController

        <HttpPost>
        Public Function Post(Parametros As CatalogoPuntosCheckListRequest) As HttpResponseMessage
            Try
                Dim da As New MySqlDataAdapter("SELECT Id, Descripcion, TipoImagen FROM tblPuntosChecklist WHERE Estatus = " & Parametros.Estatus, cn)
                Dim dt As New DataTable
                da.Fill(dt)

                If dt.Rows.Count > 0 Then

                    Dim res(dt.Rows.Count - 1) As CatalogoPuntosCheckListResponse

                    For i = 0 To dt.Rows.Count - 1
                        res(i) = New CatalogoPuntosCheckListResponse
                        res(i).Descripcion = dt.Rows(0)("Descripcion").ToString.Trim
                        res(i).TipoImagen = dt.Rows(0)("TipoImagen")
                        res(i).Id = dt.Rows(0)("Id")
                    Next

                    Return Request.CreateResponse(HttpStatusCode.OK, res, Configuration.Formatters.JsonFormatter)

                Else
                    Throw New ArgumentException("No existe ningun registro en la tabla. (tblPuntosChecklist) ")
                End If

            Catch ex As Exception
                Dim e As New Errores
                e.MensajeError = ex.Message
                Return Request.CreateResponse(HttpStatusCode.BadRequest, e, Configuration.Formatters.JsonFormatter)
            End Try
        End Function

    End Class

End Namespace