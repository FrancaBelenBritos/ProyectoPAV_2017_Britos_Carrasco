<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjemplaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeEjemplaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PréstamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_datos_usuario = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.SociosToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.EjemplaresToolStripMenuItem, Me.PréstamosToolStripMenuItem, Me.DevolucionesToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.SALIEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GestiónDeUsuariosToolStripMenuItem
        '
        Me.GestiónDeUsuariosToolStripMenuItem.Name = "GestiónDeUsuariosToolStripMenuItem"
        Me.GestiónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.GestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeSociosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'GestiónDeSociosToolStripMenuItem
        '
        Me.GestiónDeSociosToolStripMenuItem.Name = "GestiónDeSociosToolStripMenuItem"
        Me.GestiónDeSociosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestiónDeSociosToolStripMenuItem.Text = "Gestión de Socios"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeLibrosToolStripMenuItem, Me.ReportesToolStripMenuItem1})
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'GestiónDeLibrosToolStripMenuItem
        '
        Me.GestiónDeLibrosToolStripMenuItem.Name = "GestiónDeLibrosToolStripMenuItem"
        Me.GestiónDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GestiónDeLibrosToolStripMenuItem.Text = "Gestión de Libros"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'EjemplaresToolStripMenuItem
        '
        Me.EjemplaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeEjemplaresToolStripMenuItem})
        Me.EjemplaresToolStripMenuItem.Name = "EjemplaresToolStripMenuItem"
        Me.EjemplaresToolStripMenuItem.Size = New System.Drawing.Size(84, 21)
        Me.EjemplaresToolStripMenuItem.Text = "Ejemplares"
        '
        'GestiónDeEjemplaresToolStripMenuItem
        '
        Me.GestiónDeEjemplaresToolStripMenuItem.Name = "GestiónDeEjemplaresToolStripMenuItem"
        Me.GestiónDeEjemplaresToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.GestiónDeEjemplaresToolStripMenuItem.Text = "Gestión de Ejemplares"
        '
        'PréstamosToolStripMenuItem
        '
        Me.PréstamosToolStripMenuItem.Name = "PréstamosToolStripMenuItem"
        Me.PréstamosToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.PréstamosToolStripMenuItem.Text = "Préstamos"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(97, 21)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'SALIEToolStripMenuItem
        '
        Me.SALIEToolStripMenuItem.Name = "SALIEToolStripMenuItem"
        Me.SALIEToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SALIEToolStripMenuItem.Text = "Salir"
        '
        'btn_datos_usuario
        '
        Me.btn_datos_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_datos_usuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_datos_usuario.Image = Global.SistemaBiblioteca.My.Resources.Resources.ok_accept_16747
        Me.btn_datos_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_datos_usuario.Location = New System.Drawing.Point(1082, 0)
        Me.btn_datos_usuario.Name = "btn_datos_usuario"
        Me.btn_datos_usuario.Size = New System.Drawing.Size(288, 25)
        Me.btn_datos_usuario.TabIndex = 3
        Me.btn_datos_usuario.Text = "Usuario Registrado"
        Me.btn_datos_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_datos_usuario.UseVisualStyleBackColor = True
        Me.btn_datos_usuario.Visible = False
        '
        'FRMmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaBiblioteca.My.Resources.Resources.muevo
        Me.ClientSize = New System.Drawing.Size(1362, 520)
        Me.Controls.Add(Me.btn_datos_usuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "⁂ Menú Principal ⁂"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeSociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EjemplaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeEjemplaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PréstamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_datos_usuario As System.Windows.Forms.Button
End Class
