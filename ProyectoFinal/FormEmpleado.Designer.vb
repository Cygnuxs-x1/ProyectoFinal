<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
=======
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LNombreApellido = New System.Windows.Forms.Label()
        Me.LDocumento = New System.Windows.Forms.Label()
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.LIdeEmpleado = New System.Windows.Forms.Label()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BSolicitudes = New System.Windows.Forms.Button()
        Me.btnMiPerfil = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnIrCatalogo = New System.Windows.Forms.Button()
        Me.PSolicitudes = New System.Windows.Forms.Panel()
        Me.BAprobarVenta = New System.Windows.Forms.Button()
        Me.CBEstadoSolicitud = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LSolicitudes = New System.Windows.Forms.Label()
        Me.DGVSolicitudes = New System.Windows.Forms.DataGridView()
<<<<<<< HEAD
        Me.LDocumento = New System.Windows.Forms.Label()
        Me.LNombreApellido = New System.Windows.Forms.Label()
        Me.LVentasRealizadas = New System.Windows.Forms.Label()
        Me.DGVVentas = New System.Windows.Forms.DataGridView()
=======
        Me.PPerfil = New System.Windows.Forms.Panel()
        Me.PaSolicitudes = New System.Windows.Forms.Panel()
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PSolicitudes.SuspendLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
<<<<<<< HEAD
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
=======
        Me.PPerfil.SuspendLayout()
        Me.PaSolicitudes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LNombreApellido
        '
        Me.LNombreApellido.AutoSize = True
        Me.LNombreApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreApellido.ForeColor = System.Drawing.SystemColors.Control
        Me.LNombreApellido.Location = New System.Drawing.Point(277, 9)
        Me.LNombreApellido.Name = "LNombreApellido"
        Me.LNombreApellido.Size = New System.Drawing.Size(147, 18)
        Me.LNombreApellido.TabIndex = 0
        Me.LNombreApellido.Text = "Nombre + Apellido"
        '
        'LDocumento
        '
        Me.LDocumento.AutoSize = True
        Me.LDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDocumento.ForeColor = System.Drawing.SystemColors.Control
        Me.LDocumento.Location = New System.Drawing.Point(265, 106)
        Me.LDocumento.Name = "LDocumento"
        Me.LDocumento.Size = New System.Drawing.Size(86, 18)
        Me.LDocumento.TabIndex = 2
        Me.LDocumento.Text = "Documento"
        '
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        'LIdeEmpleado
        '
        Me.LIdeEmpleado.AutoSize = True
        Me.LIdeEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIdeEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.LIdeEmpleado.Location = New System.Drawing.Point(27, 189)
        Me.LIdeEmpleado.Name = "LIdeEmpleado"
        Me.LIdeEmpleado.Size = New System.Drawing.Size(68, 18)
        Me.LIdeEmpleado.TabIndex = 3
        Me.LIdeEmpleado.Text = "IdCliente:"
        '
        'PBFoto
        '
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(30, 45)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(141, 131)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 5
        Me.PBFoto.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BSolicitudes)
        Me.PanelMenu.Controls.Add(Me.btnMiPerfil)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.PBFoto)
        Me.PanelMenu.Controls.Add(Me.btnIrCatalogo)
        Me.PanelMenu.Controls.Add(Me.LIdeEmpleado)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 600)
        Me.PanelMenu.TabIndex = 6
        '
        'BSolicitudes
        '
        Me.BSolicitudes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.BSolicitudes.Location = New System.Drawing.Point(29, 282)
        Me.BSolicitudes.Name = "BSolicitudes"
        Me.BSolicitudes.Size = New System.Drawing.Size(143, 37)
        Me.BSolicitudes.TabIndex = 19
        Me.BSolicitudes.Text = "Solicitudes"
        Me.BSolicitudes.UseVisualStyleBackColor = False
        '
        'btnMiPerfil
        '
        Me.btnMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiPerfil.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMiPerfil.Location = New System.Drawing.Point(30, 385)
        Me.btnMiPerfil.Name = "btnMiPerfil"
        Me.btnMiPerfil.Size = New System.Drawing.Size(144, 33)
        Me.btnMiPerfil.TabIndex = 18
        Me.btnMiPerfil.Text = "Mi Perfil"
        Me.btnMiPerfil.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrarSesion.Location = New System.Drawing.Point(30, 494)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(141, 33)
        Me.btnCerrarSesion.TabIndex = 17
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnIrCatalogo
        '
        Me.btnIrCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnIrCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrCatalogo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnIrCatalogo.Location = New System.Drawing.Point(30, 332)
        Me.btnIrCatalogo.Name = "btnIrCatalogo"
        Me.btnIrCatalogo.Size = New System.Drawing.Size(143, 37)
        Me.btnIrCatalogo.TabIndex = 8
        Me.btnIrCatalogo.Text = "Ir a Catalogo"
        Me.btnIrCatalogo.UseVisualStyleBackColor = False
        '
        'PSolicitudes
        '
<<<<<<< HEAD
        Me.PSolicitudes.Controls.Add(Me.BAprobarVenta)
        Me.PSolicitudes.Controls.Add(Me.CBEstadoSolicitud)
        Me.PSolicitudes.Controls.Add(Me.Label1)
        Me.PSolicitudes.Controls.Add(Me.LSolicitudes)
        Me.PSolicitudes.Controls.Add(Me.DGVSolicitudes)
        Me.PSolicitudes.Location = New System.Drawing.Point(200, 0)
=======
        Me.PSolicitudes.Controls.Add(Me.PPerfil)
        Me.PSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PSolicitudes.Location = New System.Drawing.Point(0, 0)
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.PSolicitudes.Name = "PSolicitudes"
        Me.PSolicitudes.Size = New System.Drawing.Size(1264, 559)
        Me.PSolicitudes.TabIndex = 7
        '
        'BAprobarVenta
        '
        Me.BAprobarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BAprobarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAprobarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAprobarVenta.ForeColor = System.Drawing.SystemColors.Control
<<<<<<< HEAD
        Me.BAprobarVenta.Location = New System.Drawing.Point(337, 423)
=======
        Me.BAprobarVenta.Location = New System.Drawing.Point(556, 454)
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.BAprobarVenta.Name = "BAprobarVenta"
        Me.BAprobarVenta.Size = New System.Drawing.Size(155, 37)
        Me.BAprobarVenta.TabIndex = 20
        Me.BAprobarVenta.Text = "Actualizar"
        Me.BAprobarVenta.UseVisualStyleBackColor = False
        '
        'CBEstadoSolicitud
        '
        Me.CBEstadoSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstadoSolicitud.FormattingEnabled = True
        Me.CBEstadoSolicitud.Items.AddRange(New Object() {"Aprobada", "Desaprobada"})
<<<<<<< HEAD
        Me.CBEstadoSolicitud.Location = New System.Drawing.Point(287, 361)
=======
        Me.CBEstadoSolicitud.Location = New System.Drawing.Point(506, 392)
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.CBEstadoSolicitud.Name = "CBEstadoSolicitud"
        Me.CBEstadoSolicitud.Size = New System.Drawing.Size(215, 26)
        Me.CBEstadoSolicitud.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
<<<<<<< HEAD
        Me.Label1.Location = New System.Drawing.Point(58, 364)
=======
        Me.Label1.Location = New System.Drawing.Point(277, 395)
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cambiar ESTADO de Solicitud:"
        '
        'LSolicitudes
        '
        Me.LSolicitudes.AutoSize = True
        Me.LSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSolicitudes.ForeColor = System.Drawing.SystemColors.Control
<<<<<<< HEAD
        Me.LSolicitudes.Location = New System.Drawing.Point(58, 58)
=======
        Me.LSolicitudes.Location = New System.Drawing.Point(277, 75)
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.LSolicitudes.Name = "LSolicitudes"
        Me.LSolicitudes.Size = New System.Drawing.Size(80, 18)
        Me.LSolicitudes.TabIndex = 1
        Me.LSolicitudes.Text = "Solicitudes"
        '
        'DGVSolicitudes
        '
        Me.DGVSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
<<<<<<< HEAD
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSolicitudes.EnableHeadersVisualStyles = False
        Me.DGVSolicitudes.Location = New System.Drawing.Point(61, 96)
        Me.DGVSolicitudes.Name = "DGVSolicitudes"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVSolicitudes.RowHeadersWidth = 45
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control
        Me.DGVSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVSolicitudes.Size = New System.Drawing.Size(966, 223)
        Me.DGVSolicitudes.TabIndex = 0
        '
        'LDocumento
        '
        Me.LDocumento.AutoSize = True
        Me.LDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDocumento.ForeColor = System.Drawing.SystemColors.Control
        Me.LDocumento.Location = New System.Drawing.Point(258, 97)
        Me.LDocumento.Name = "LDocumento"
        Me.LDocumento.Size = New System.Drawing.Size(86, 18)
        Me.LDocumento.TabIndex = 2
        Me.LDocumento.Text = "Documento"
        '
        'LNombreApellido
        '
        Me.LNombreApellido.AutoSize = True
        Me.LNombreApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreApellido.ForeColor = System.Drawing.SystemColors.Control
        Me.LNombreApellido.Location = New System.Drawing.Point(258, 55)
        Me.LNombreApellido.Name = "LNombreApellido"
        Me.LNombreApellido.Size = New System.Drawing.Size(147, 18)
        Me.LNombreApellido.TabIndex = 0
        Me.LNombreApellido.Text = "Nombre + Apellido"
        '
        'LVentasRealizadas
        '
        Me.LVentasRealizadas.AutoSize = True
        Me.LVentasRealizadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVentasRealizadas.ForeColor = System.Drawing.SystemColors.Control
        Me.LVentasRealizadas.Location = New System.Drawing.Point(258, 146)
        Me.LVentasRealizadas.Name = "LVentasRealizadas"
        Me.LVentasRealizadas.Size = New System.Drawing.Size(134, 18)
        Me.LVentasRealizadas.TabIndex = 8
        Me.LVentasRealizadas.Text = "Ventas Realizadas:"
        '
        'DGVVentas
        '
        Me.DGVVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentas.EnableHeadersVisualStyles = False
        Me.DGVVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DGVVentas.Location = New System.Drawing.Point(261, 189)
        Me.DGVVentas.Name = "DGVVentas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGVVentas.RowHeadersWidth = 45
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control
        Me.DGVVentas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVVentas.Size = New System.Drawing.Size(935, 187)
        Me.DGVVentas.TabIndex = 9
=======
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSolicitudes.EnableHeadersVisualStyles = False
        Me.DGVSolicitudes.Location = New System.Drawing.Point(280, 127)
        Me.DGVSolicitudes.Name = "DGVSolicitudes"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSolicitudes.RowHeadersWidth = 45
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control
        Me.DGVSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVSolicitudes.Size = New System.Drawing.Size(966, 223)
        Me.DGVSolicitudes.TabIndex = 0
        '
        'PPerfil
        '
        Me.PPerfil.Controls.Add(Me.PaSolicitudes)
        Me.PPerfil.Controls.Add(Me.LDocumento)
        Me.PPerfil.Controls.Add(Me.LNombreApellido)
        Me.PPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPerfil.Location = New System.Drawing.Point(0, 0)
        Me.PPerfil.Name = "PPerfil"
        Me.PPerfil.Size = New System.Drawing.Size(1264, 559)
        Me.PPerfil.TabIndex = 21
        '
        'PaSolicitudes
        '
        Me.PaSolicitudes.Controls.Add(Me.BAprobarVenta)
        Me.PaSolicitudes.Controls.Add(Me.LSolicitudes)
        Me.PaSolicitudes.Controls.Add(Me.CBEstadoSolicitud)
        Me.PaSolicitudes.Controls.Add(Me.DGVSolicitudes)
        Me.PaSolicitudes.Controls.Add(Me.Label1)
        Me.PaSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaSolicitudes.Location = New System.Drawing.Point(0, 0)
        Me.PaSolicitudes.Name = "PaSolicitudes"
        Me.PaSolicitudes.Size = New System.Drawing.Size(1264, 559)
        Me.PaSolicitudes.TabIndex = 3
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 559)
        Me.Controls.Add(Me.PSolicitudes)
        Me.Controls.Add(Me.DGVVentas)
        Me.Controls.Add(Me.LVentasRealizadas)
        Me.Controls.Add(Me.LNombreApellido)
        Me.Controls.Add(Me.LDocumento)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FormEmpleado"
        Me.Text = "FormEmpleado"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PSolicitudes.ResumeLayout(False)
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
<<<<<<< HEAD
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).EndInit()
=======
        Me.PPerfil.ResumeLayout(False)
        Me.PPerfil.PerformLayout()
        Me.PaSolicitudes.ResumeLayout(False)
        Me.PaSolicitudes.PerformLayout()
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LIdeEmpleado As Label
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnIrCatalogo As Button
    Friend WithEvents btnMiPerfil As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents PSolicitudes As Panel
    Friend WithEvents DGVSolicitudes As DataGridView
    Friend WithEvents BSolicitudes As Button
    Friend WithEvents LSolicitudes As Label
    Friend WithEvents CBEstadoSolicitud As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BAprobarVenta As Button
<<<<<<< HEAD
    Friend WithEvents LNombreApellido As Label
    Public WithEvents LDocumento As Label
    Public WithEvents LVentasRealizadas As Label
    Friend WithEvents DGVVentas As DataGridView
=======
    Friend WithEvents PPerfil As Panel
    Friend WithEvents PaSolicitudes As Panel
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
End Class
