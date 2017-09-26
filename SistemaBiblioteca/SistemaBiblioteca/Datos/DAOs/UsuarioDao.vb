Public Class UsuarioDao
    Dim oTabla As DataTable
    Dim oUsuario As Usuario = Nothing
    Public Function obtenerUsuario_loginPass(ByVal login As String, ByVal password As String) As Usuario
        Dim sql As String = "SELECT * from usuarios WHERE login = '" + login + "' AND password= '" + password + "'"
        oTabla = DBConexion.getDBHelper.ConsultaSQL(sql)
        cargarUsuario()
        Return oUsuario
    End Function

    Public Function generarUsuario(ByVal cargo As String, ByVal login As String, ByVal password As String, ByVal nombre As String, ByVal apellido As String, ByVal mail As String, ByVal telefono As String, ByVal documento As String) As Integer
        Dim sql As String = "INSERT INTO usuarios (cargo,login,password,nombre,apellido,mail,estado,telefono,documento) VALUES ('" & cargo & "','" & login & "','" & password & "','" & nombre & "','" & apellido & "','" & mail & "', 1, '" & telefono & "','" & documento & "')"
        Dim int As Integer = DBConexion.getDBHelper.EjecutarSQL(sql)
        Return int
    End Function

    Public Function existeLoginUsuario(ByVal login As String) As Boolean
        Return DBConexion.getDBHelper.ConsultaSQL("SELECT * from usuarios WHERE login = '" + login + "'").Rows.Count > 0
    End Function

    Public Function existeLoginUsuarioCargado(ByVal login As String, ByVal idUsuario As String) As Boolean
        Return DBConexion.getDBHelper.ConsultaSQL("SELECT * from usuarios WHERE login = '" + login + "' AND idUsuario <> '" + idUsuario + "'").Rows.Count > 0
    End Function


    Private Sub cargarUsuario()
        If oTabla.Rows.Count Then
            oUsuario = New Usuario
            oUsuario.idUsuario = Convert.ToInt32(oTabla.Rows(0).Item("idUsuario").ToString)
            oUsuario.cargo = oTabla.Rows(0).Item("cargo").ToString
            oUsuario.login = oTabla.Rows(0).Item("login").ToString
            oUsuario.password = oTabla.Rows(0).Item("password").ToString
            oUsuario.nombre = oTabla.Rows(0).Item("nombre").ToString
            oUsuario.apellido = oTabla.Rows(0).Item("apellido".ToString)
            oUsuario.mail = oTabla.Rows(0).Item("mail").ToString
            oUsuario.estado = Convert.ToInt32(oTabla.Rows(0).Item("estado").ToString)
            oUsuario.telefono = Convert.ToInt32(oTabla.Rows(0).Item("telefono").ToString)
            oUsuario.documento = Convert.ToInt32(oTabla.Rows(0).Item("documento").ToString)
        End If
    End Sub

    Public Sub actualizarGrilla(ByVal grilla As DataGridView)
        Dim sql As String = "SELECT * FROM usuarios "
        oTabla = DBConexion.getDBHelper.ConsultaSQL(sql)
        grilla.Rows.Clear()
        For Each fila As DataRow In oTabla.Rows
            If (fila.Item("Estado").ToString = "1") Then
                grilla.Rows.Add(New String() {fila.Item("IdUsuario").ToString, fila.Item("Cargo").ToString, fila.Item("Login").ToString, fila.Item("Password").ToString, fila.Item("Nombre").ToString, fila.Item("Apellido").ToString, fila.Item("Mail").ToString, fila.Item("Estado").ToString, fila.Item("Telefono").ToString, fila.Item("Documento").ToString})
            End If
        Next
    End Sub

    Public Function ModificarUsuario(ByVal idUsuario As String, ByVal cargo As String, ByVal login As String, ByVal password As String, ByVal nombre As String, ByVal apellido As String, ByVal mail As String, ByVal telefono As String, ByVal documento As String) As Integer
        Dim sql As String = "UPDATE usuarios SET nombre='" + nombre + "', apellido='" + apellido + "', documento='" + documento + "', telefono='" + telefono + "', cargo='" + cargo + "', mail='" + mail + "', login='" + login + "', password='" + password + "' WHERE idUsuario='" + idUsuario + "'"
        Dim int As Integer = DBConexion.getDBHelper.EjecutarSQL(sql)
        Return int
    End Function

    Public Function filtrarUsuario(ByVal filtro As String, ByRef valorFiltro As String) As DataTable
        Dim sql As String = "SELECT * FROM usuarios WHERE " + filtro + "= '" + valorFiltro + "'"
        Return DBConexion.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Sub registrarBajaUsuario(ByVal idUsuario As String)
        Dim sql As String = "UPDATE usuarios SET estado = 0 WHERE idUsuario='" + idUsuario + "'"
        DBConexion.getDBHelper.EjecutarSQL(sql)
    End Sub

End Class
