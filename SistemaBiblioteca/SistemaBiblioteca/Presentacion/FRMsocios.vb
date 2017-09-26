Public Class FRMsocios
    Private dt As New DataTable
    Private Sub FRMsocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oSocioServicio As New SocioServicio
        oSocioServicio.actualizarGrilla(dgv_socios)
        inhabilitarComponentes()
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
        txt_calle.Enabled = True
        txt_mail.Enabled = True
        txt_numero_calle.Enabled = True
        txt_cod_postal.Enabled = True
    End Sub

    Private Sub inhabilitarComponentes()
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_dni.Enabled = False
        txt_telefono.Enabled = False
        txt_calle.Enabled = False
        txt_mail.Enabled = False
        txt_numero_calle.Enabled = False
        txt_cod_postal.Enabled = False
        btneditar.Enabled = False
        btncancelar.Enabled = False
        btnEliminar.Enabled = False
        btn_agregar.Enabled = False
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim oSocioServicio As New SocioServicio
        If oSocioServicio.verificarDniSocio(txt_dni.Text) = False Then
            If validar_campos() Then
                If oSocioServicio.nuevoSocio(txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_telefono.Text, txt_mail.Text, txt_calle.Text, txt_numero_calle.Text, txt_cod_postal.Text) > 0 Then
                    oSocioServicio.actualizarGrilla(dgv_socios)
                    MessageBox.Show("Socio insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarComponentes()
                    inhabilitarComponentes()
                End If
            End If
        Else
            MessageBox.Show("Numero de documento ya existente!. Ingrese un documento diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub limpiarComponentes()
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_dni.Text = ""
        txt_telefono.Text = ""
        txt_calle.Text = ""
        txt_mail.Text = ""
        txt_idSocio.Text = ""
        txt_numero_calle.Text = ""
        txt_cod_postal.Text = ""
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarComponentes()
        inhabilitarComponentes()
    End Sub

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_socios.CellClick
        cargarComponentes(e)
        inhabilitarComponentes()
    End Sub


    Private Sub dataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_socios.CellDoubleClick
        cargarComponentes(e)
        habilitarComponentes()
        btneditar.Enabled = True
        btnEliminar.Enabled = True

    End Sub

    Private Sub cargarComponentes(e)
        txt_idSocio.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(0).Value.ToString())
        txt_nombre.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(3).Value.ToString())
        txt_apellido.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(4).Value.ToString())
        txt_dni.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(5).Value.ToString())
        txt_telefono.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(6).Value.ToString())
        txt_mail.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(7).Value.ToString())
        txt_calle.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(8).Value.ToString())
        txt_numero_calle.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(9).Value.ToString())
        txt_cod_postal.Text = Convert.ToString(dgv_socios.Rows(e.RowIndex).Cells(10).Value.ToString())
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim oSocioServicio As New SocioServicio
        If oSocioServicio.verificarDniSocioCargado(txt_dni.Text, txt_idSocio.Text) = False Then
            If validar_campos() Then
                If oSocioServicio.modificarSocio(txt_idSocio.Text, txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_telefono.Text, txt_mail.Text, txt_calle.Text, txt_numero_calle.Text, txt_cod_postal.Text) > 0 Then
                    oSocioServicio.actualizarGrilla(dgv_socios)
                    MessageBox.Show("Socio Modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarComponentes()
                    inhabilitarComponentes()
                End If
            End If
        Else
            MessageBox.Show("Numero de documento encontrado!. Ingrese documento diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim oSocioServicio As New SocioServicio
        oSocioServicio.registrarBajaSocio(txt_idSocio.Text)
        oSocioServicio.actualizarGrilla(dgv_socios)
        MessageBox.Show("Socio dado de Baja !", _
                "Gestion de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information _
                , MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim oSocioServicio As New SocioServicio
        oSocioServicio.actualizarGrillaFiltrada(dgv_socios, oSocioServicio.filtrarSocio(cbo_filtro.SelectedItem.ToString(), txt_filtro.Text))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim oSocioServicio As New SocioServicio
        oSocioServicio.actualizarGrilla(dgv_socios)
        limpiarComponentes()
        inhabilitarComponentes()

    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios

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

        If txt_dni.Text = String.Empty Then
            txt_dni.BackColor = Color.Red
            txt_dni.Focus()
            Return False
        Else
            txt_dni.BackColor = Color.White
        End If


        If txt_calle.Text = String.Empty Then
            txt_calle.BackColor = Color.Red
            txt_calle.Focus()
            Return False
        Else
            txt_calle.BackColor = Color.White
        End If

        If txt_numero_calle.Text = String.Empty Then
            txt_numero_calle.BackColor = Color.Red
            txt_numero_calle.Focus()
            Return False
        Else
            txt_numero_calle.BackColor = Color.White
        End If

        Return True
    End Function


End Class