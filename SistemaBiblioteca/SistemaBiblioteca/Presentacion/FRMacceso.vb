Public Class FRMacceso

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim oUsuarioServicio As New UsuarioServicio
        Dim oUsuario As Usuario = Nothing

        'Validamos que las cajas no esten vacías
        If txt_contraseña.Text = String.Empty Or txt_usuario.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar usuario y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            oUsuario = oUsuarioServicio.validarUsuario(txt_usuario.Text, txt_contraseña.Text)
            If Not IsNothing(oUsuario) Then
                FRMmenu.actualizarUsuarioLogueado(oUsuario)
                Me.Close()
            Else
                MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                txt_contraseña.Text = String.Empty
                txt_usuario.Text = String.Empty
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub FRMacceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fecha_hora_actual.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class