Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class ConsultaEntradasSalidasController
        Inherits ApiController

        <HttpPost>
        Public Function Post(Parametros As ConsultaEntradasSalidasListRequest) As HttpResponseMessage
            Try
            Dim da As New MySqlDataAdapter("SELECT Id, Fecha, idOrigenes, idChofer, idVehiculo, idTipoCarga, Estatus, idTipoTransporte FROM tblMovimientos WHERE Tipo = " & Parametros.Tipo, cn)
                Dim dt As New DataTable
                Dim E as integer
                dim S as integer 
                
                da.Fill(dt)

                If dt.Rows.Count > 0 Then

                    Dim res(dt.Rows.Count) As ConsultaEntradasSalidasListResponse
                    
                    For i = 1 To dt.Rows.Count
                        
                        if dt.Rows(i)("Tipo") = 0 then E=E+1
                        if dt.Rows(i)("Tipo") = 1 then S=S+1
                                                
                        res(i) = New ConsultaEntradasSalidasListResponse
                        res(i).Entradas = 0
                        res(i).Salidas = 0
                        res(i).Id = dt.Rows(i)("Id")
                        res(i).Fecha = dt.Rows(i)("Fecha").ToString
                        res(i).idOrigenes = dt.Rows(i)("idOrigenes")
                        res(i).idChofer = dt.Rows(i)("idChofer")
                        res(i).idVehiculo = dt.Rows(i)("idVehiculo")
                        res(i).idTipoCarga = dt.Rows(i)("idTipoCarga")
                        res(i).idEstatus = dt.Rows(i)("idEstatus")
                        res(i).idTipoTransporte = dt.Rows(i)("idTipoTransporte")
                        
                    Next
                    
                       res(0).Entradas = E
                       res(0).Salidas = S
                       res(0).Id = dt.Rows(i)("Id")
                       res(0).Fecha = "-"
                       res(0).idChofer = 0
                       res(0).idVehiculo = 0
                       res(0).idTipoCarga = 0
                       res(0).idEstatus = 0
                       res(0).idTipoTransporte = 0
    
                        
                    Return Request.CreateResponse(HttpStatusCode.OK, res, Configuration.Formatters.JsonFormatter)

                Else
                    Throw New ArgumentException("No existe ningun registro en la tabla. (tblMovimientos) ")
                End If

            Catch ex As Exception
                Dim e As New Errores
                e.MensajeError = ex.Message
                Return Request.CreateResponse(HttpStatusCode.BadRequest, e, Configuration.Formatters.JsonFormatter)
            End Try
        End Function

    End Class

End Namespace
