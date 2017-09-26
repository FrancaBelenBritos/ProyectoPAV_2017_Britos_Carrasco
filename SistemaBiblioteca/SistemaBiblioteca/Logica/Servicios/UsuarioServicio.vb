Public Class UsuarioServicio
    Private oUsuarioDao As UsuarioDao

    Public Sub New()
        oUsuarioDao = New UsuarioDao
    End Sub

    Public Function validarUsuario(ByVal login As String, ByVal password As String) As Usuario
        Return oUsuarioDao.obtenerUsuario_loginPass(login, password)
    End Function
    Public Function nuevoUsuario(ByVal cargo As String, ByVal login As String, ByVal password As String, ByVal nombre As String, ByVal apellido As String, ByVal mail As String, ByVal telefono As String, ByVal documento As String) As Integer
        Return oUsuarioDao.generarUsuario(cargo, login, password, nombre, apellido, mail, telefono, documento)
    End Function

    Public Function verificarLoginUsuario(ByVal login As String) As Boolean
        Return oUsuarioDao.existeLoginUsuario(login)
    End Function

    Public Function verificarLoginUsuarioCargado(ByVal login As String, ByVal idUsuario As String) As Boolean
        Return oUsuarioDao.existeLoginUsuarioCargado(login, idUsuario)
    End Function

    Public Sub actualizarGrilla(ByVal grilla As DataGridView)
        oUsuarioDao.actualizarGrilla(grilla)
    End Sub
    Public Function modificarUsuario(ByVal idUsuario As String, ByVal cargo As String, ByVal login As String, ByVal password As String, ByVal nombre As String, ByVal apellido As String, ByVal mail As String, ByVal telefono As String, ByVal documento As String) As Integer
        Return oUsuarioDao.ModificarUsuario(idUsuario, cargo, login, password, nombre, apellido, mail, telefono, documento)
    End Function

    Public Sub actualizarGrillaFiltrada(ByVal grilla As DataGridView, ByVal tabla As DataTable)
        grilla.Rows.Clear()
        For Each fila As DataRow In tabla.Rows
            If (fila.Item("Estado").ToString = "1") Then
                grilla.Rows.Add(New String() {fila.Item("IdUsuario").ToString, fila.Item("Cargo").ToString, fila.Item("Login").ToString, fila.Item("Password").ToString, fila.Item("Nombre").ToString, fila.Item("Apellido").ToString, fila.Item("Mail").ToString, fila.Item("Estado").ToString, fila.Item("Telefono").ToString, fila.Item("Documento").ToString})
            End If
        Next
        If grilla.Rows.Count = 0 Then
            If MessageBox.Show("No se encontraron Usuarios", _
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                actualizarGrilla(grilla)
            End If
        End If
    End Sub

    Public Function filtrarUsuario(ByVal filtro As String, ByVal valorFiltro As String) As DataTable
        Return oUsuarioDao.filtrarUsuario(filtro, valorFiltro)
    End Function

    Public Sub registrarBajaUsuario(ByVal idUsuiario As String)
        oUsuarioDao.registrarBajaUsuario(idUsuiario)
    End Sub
End Class
