Public Class FRMusuarios

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim oUsuarioServicio As New UsuarioServicio
        If oUsuarioServicio.verificarLoginUsuario(txt_login.Text) = False Then
            If validar_campos() Then
                If oUsuarioServicio.nuevoUsuario(cbo_cargo.SelectedItem.ToString(), txt_login.Text, txt_password.Text, txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text, txt_dni.Text) > 0 Then
                    oUsuarioServicio.actualizarGrilla(dgv_usuarios)
                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarComponentes()
                    inhabilitarComponentes()
                End If
            End If
        Else
            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios

        If cbo_cargo.Text = "Seleccionar Cargo" Then
            cbo_cargo.BackColor = Color.Red
            cbo_cargo.Focus()
            Return False
        Else
            cbo_cargo.BackColor = Color.White
        End If


        If txt_dni.Text = String.Empty Then
            txt_dni.BackColor = Color.Red
            txt_dni.Focus()
            Return False
        Else
            txt_dni.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If

        If txt_login.Text = String.Empty Then
            txt_login.BackColor = Color.Red
            txt_login.Focus()
            Return False
        Else
            txt_login.BackColor = Color.White
        End If


        If txt_password.Text = String.Empty Then
            txt_password.BackColor = Color.Red
            txt_password.Focus()
            Return False
        Else
            txt_password.BackColor = Color.White
        End If

        Return True
    End Function

    Private Sub inhabilitarComponentes()
        cbo_cargo.Enabled = False
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_dni.Enabled = False
        txt_telefono.Enabled = False
        txt_mail.Enabled = False
        txt_login.Enabled = False
        txt_password.Enabled = False
        btneditar.Enabled = False
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btn_agregar.Enabled = False
    End Sub

    Private Sub FRMusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oUsuarioServicio As New UsuarioServicio
        oUsuarioServicio.actualizarGrilla(dgv_usuarios)
        inhabilitarComponentes()
    End Sub

    Private Sub limpiarComponentes()
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_dni.Text = ""
        txt_telefono.Text = ""
        txt_login.Text = ""
        txt_password.Text = ""
        txt_mail.Text = ""
        txt_idUsuario.Text = ""
        cbo_cargo.Text = "Seleccionar Cargo"

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiarComponentes()
        habilitarComponentes()
        btn_agregar.Enabled = True
        btneditar.Enabled = False
        btnEliminar.Enabled = False
        btncancelar.Enabled = True
    End Sub

    Private Sub habilitarComponentes()
        txt_nombre.Enabled = True
        txt_apellido.Enabled = True
        txt_dni.Enabled = True
        txt_telefono.Enabled = True
        txt_login.Enabled = True
        txt_password.Enabled = True
        txt_mail.Enabled = True
        cbo_cargo.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim oUsuarioServicio As New UsuarioServicio
        If oUsuarioServicio.verificarLoginUsuarioCargado(txt_login.Text, txt_idUsuario.Text) = False Then
            If validar_campos() Then
                If oUsuarioServicio.modificarUsuario(txt_idUsuario.Text, cbo_cargo.SelectedItem.ToString(), txt_login.Text, txt_password.Text, txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text, txt_dni.Text) > 0 Then
                    oUsuarioServicio.actualizarGrilla(dgv_usuarios)
                    MessageBox.Show("Usuario Modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarComponentes()
                    inhabilitarComponentes()
                End If
            End If
        Else
            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cargarComponentes(e)
        txt_idUsuario.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(0).Value.ToString())
        cbo_cargo.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(1).Value.ToString())
        txt_login.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(2).Value.ToString())
        txt_password.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(3).Value.ToString())
        txt_nombre.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(4).Value.ToString())
        txt_apellido.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(5).Value.ToString())
        txt_mail.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(6).Value.ToString())
        txt_mail.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(6).Value.ToString())
        txt_telefono.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(8).Value.ToString())
        txt_dni.Text = Convert.ToString(dgv_usuarios.Rows(e.RowIndex).Cells(9).Value.ToString())

    End Sub

    Private Sub dgv_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellClick
        cargarComponentes(e)
        inhabilitarComponentes()
    End Sub


    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        cargarComponentes(e)
        habilitarComponentes()
        btneditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim oUsuarioServicio As New UsuarioServicio
        oUsuarioServicio.actualizarGrillaFiltrada(dgv_usuarios, oUsuarioServicio.filtrarUsuario(cbo_filtro.SelectedItem.ToString(), txt_buscar.Text))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim oUsuarioServicio As New UsuarioServicio
        oUsuarioServicio.actualizarGrilla(dgv_usuarios)
        limpiarComponentes()
        inhabilitarComponentes()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim oUsuarioServicio As New UsuarioServicio
        oUsuarioServicio.registrarBajaUsuario(txt_idUsuario.Text)
        If MessageBox.Show("Usuario dado de Baja !", _
                "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            oUsuarioServicio.actualizarGrilla(dgv_usuarios)
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarComponentes()
        inhabilitarComponentes()
    End Sub

End Class