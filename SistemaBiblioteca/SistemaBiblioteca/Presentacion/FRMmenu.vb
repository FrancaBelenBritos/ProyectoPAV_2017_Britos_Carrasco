Public Class FRMmenu

    Private Sub FRMmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FRMacceso.ShowDialog()
    End Sub

    Private Sub GestiónDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeSociosToolStripMenuItem.Click
        FRMsocios.ShowDialog()
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal usuario As Usuario)
        btn_datos_usuario.Visible = True
        btn_datos_usuario.Text = "Usuario: " + usuario.nombre + " | Cargo: " + usuario.cargo
    End Sub

    Private Sub SALIEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIEToolStripMenuItem.Click
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        FRMusuarios.ShowDialog()
    End Sub
End Class