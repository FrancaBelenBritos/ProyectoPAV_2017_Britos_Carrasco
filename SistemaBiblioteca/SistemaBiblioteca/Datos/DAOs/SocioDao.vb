Public Class SocioDao
    Dim oTabla As DataTable
    Dim oSocio As Socio = Nothing

    Public Function generarSocio(ByVal nombre As String, ByVal apellido As String, ByVal documento As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numeroCalle As String, ByVal codPostal As String) As Integer
        Dim sql As String = "INSERT INTO socios (nombre,apellido,documento,telefono,mail,calle,numeroCalle,codigoPostal,habilitado) VALUES ('" & nombre & "','" & apellido & "','" & documento & "','" & telefono & "','" & mail & "','" & calle & "','" & numeroCalle & "','" & codPostal & "', 1)"
        Dim int As Integer = DBConexion.getDBHelper.EjecutarSQL(sql)
        Return int
    End Function

    Public Function existeDniSocio(ByVal documento As String) As Boolean
        Return DBConexion.getDBHelper.ConsultaSQL("SELECT * from socios WHERE documento = '" + documento + "'").Rows.Count > 0
    End Function

    Public Function existeDniSocioCargado(ByVal documento As String, ByVal idSocio As String) As Boolean
        Return DBConexion.getDBHelper.ConsultaSQL("SELECT * from socios WHERE documento = '" + documento + "' AND idSocio <> '" + idSocio + "'").Rows.Count > 0
    End Function

    Public Function filtrarSocio(ByVal filtro As String, ByRef valorFiltro As String) As DataTable
        Dim sql As String = "SELECT * FROM socios WHERE " + filtro + "= '" + valorFiltro + "'"
        Return DBConexion.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Sub actualizarGrilla(ByVal grilla As DataGridView)
        Dim sql As String = "SELECT * FROM socios "
        oTabla = DBConexion.getDBHelper.ConsultaSQL(sql)
        grilla.Rows.Clear()
        For Each fila As DataRow In oTabla.Rows
            If (fila.Item("habilitado").ToString = "1") Then
                grilla.Rows.Add(New String() {fila.Item("idSocio").ToString, fila.Item("idPrestamo").ToString, fila.Item("idAsociacion").ToString, fila.Item("nombre").ToString, fila.Item("apellido").ToString, fila.Item("documento").ToString, fila.Item("telefono").ToString, fila.Item("mail").ToString, fila.Item("calle").ToString, fila.Item("numeroCalle").ToString, fila.Item("codigoPostal").ToString})
            End If
        Next
    End Sub

    Public Function ModificarSocio(ByVal idSocio As String, ByVal nombre As String, ByVal apellido As String, ByVal documento As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numeroCalle As String, ByVal codPostal As String) As Integer
        Dim sql As String = "UPDATE socios SET nombre='" + nombre + "', apellido='" + apellido + "', documento='" + documento + "', telefono='" + telefono + "', mail='" + mail + "', calle='" + calle + "', numeroCalle='" + numeroCalle + "', codigoPostal='" + codPostal + "' WHERE idSocio ='" + idSocio + "'"
        Dim int As Integer = DBConexion.getDBHelper.EjecutarSQL(sql)
        Return int
    End Function

    Public Sub registrarBajaSocio(ByVal idSocio As String)
        Dim sql As String = "UPDATE socios SET habilitado = 0 WHERE idSocio='" + idSocio + "'"
        DBConexion.getDBHelper.EjecutarSQL(sql)
    End Sub

End Class
