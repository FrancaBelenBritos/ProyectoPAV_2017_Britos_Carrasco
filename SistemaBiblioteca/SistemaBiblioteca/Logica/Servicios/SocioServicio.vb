Public Class SocioServicio
    Private oSocioDao As SocioDao

    Public Sub New()
        oSocioDao = New SocioDao
    End Sub

    Public Function nuevoSocio(ByVal nombre As String, ByVal apellido As String, ByVal documento As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numeroCalle As String, ByVal codPostal As String) As Integer
        Return oSocioDao.generarSocio(nombre, apellido, documento, telefono, mail, calle, numeroCalle, codPostal)
    End Function

    Public Function verificarDniSocio(ByVal documento As String) As Boolean
        Return oSocioDao.existeDniSOcio(documento)
    End Function

    Public Function verificarDniSocioCargado(ByVal documento As String, ByVal idSocio As String) As Boolean
        Return oSocioDao.existeDniSocioCargado(documento, idSocio)
    End Function

    Public Function filtrarSocio(ByVal filtro As String, ByVal valorFiltro As String) As DataTable
        Return oSocioDao.filtrarSocio(filtro, valorFiltro)
    End Function

    Public Sub actualizarGrilla(ByVal grilla As DataGridView)
        oSocioDao.actualizarGrilla(grilla)
    End Sub

    Public Sub actualizarGrillaFiltrada(ByVal grilla As DataGridView, ByVal tabla As DataTable)
        grilla.Rows.Clear()
        For Each fila As DataRow In tabla.Rows
            If (fila.Item("habilitado").ToString = "1") Then
                grilla.Rows.Add(New String() {fila.Item("IdSocio").ToString, fila.Item("idPrestamo").ToString, fila.Item("idAsociacion").ToString, fila.Item("nombre").ToString, fila.Item("apellido").ToString, fila.Item("documento").ToString, fila.Item("telefono").ToString, fila.Item("mail").ToString, fila.Item("calle").ToString, fila.Item("numeroCalle").ToString, fila.Item("codigoPostal").ToString})
            End If
        Next
        If grilla.Rows.Count = 0 Then
            If MessageBox.Show("No se encontraron Socios", _
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                actualizarGrilla(grilla)
            End If
        End If
    End Sub

    Public Function modificarSocio(ByVal idSocio As String, ByVal nombre As String, ByVal apellido As String, ByVal documento As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numeroCalle As String, ByVal codPostal As String) As Integer
        Return oSocioDao.ModificarSocio(idSocio, nombre, apellido, documento, telefono, mail, calle, numeroCalle, codPostal)
    End Function

    Public Sub registrarBajaSocio(ByVal idSocio As String)
        oSocioDao.registrarBajaSocio(idSocio)
    End Sub

End Class
