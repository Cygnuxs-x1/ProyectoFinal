<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
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
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPeso = New System.Windows.Forms.Label()
        Me.LVelocidad = New System.Windows.Forms.Label()
        Me.LAsientos = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LMotor = New System.Windows.Forms.Label()
        Me.LAño = New System.Windows.Forms.Label()
        Me.LMarcaModelo = New System.Windows.Forms.Label()
        Me.PbFotoVehiculo = New System.Windows.Forms.PictureBox()
        Me.txtIdVehiculo = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSolicitarCompra = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LidEmpleado = New System.Windows.Forms.Label()
        Me.LIdVehiculo = New System.Windows.Forms.Label()
        Me.LIdCliente = New System.Windows.Forms.Label()
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(375, 441)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(276, 24)
        Me.txtIdCliente.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(745, 370)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 18)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Cuotas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(733, 303)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 18)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Forma de pago:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(220, 443)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 18)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "IdCliente:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(375, 505)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(276, 24)
        Me.txtEstado.TabIndex = 55
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(375, 315)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(276, 24)
        Me.txtNombre.TabIndex = 54
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(375, 349)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(276, 24)
        Me.txtDni.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(220, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 18)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(220, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(220, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(220, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(220, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Datos del cliente:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Tarjeta de Credito", "Tarjeta de Debito", "Efectivo", "Financiacion"})
        Me.ComboBox2.Location = New System.Drawing.Point(736, 333)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(231, 26)
        Me.ComboBox2.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1 Cuota", "2 Cuotas", "3 cuotas", "4 cuotas", "5 Cuotas", "20 Cuotas", "100 Cuotas"})
        Me.ComboBox1.Location = New System.Drawing.Point(736, 391)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 26)
        Me.ComboBox1.TabIndex = 37
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(375, 283)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(276, 24)
        Me.txtApellido.TabIndex = 36
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(375, 381)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(276, 24)
        Me.dtpFecha.TabIndex = 67
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(375, 410)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(276, 24)
        Me.txtDireccion.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(220, 410)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 18)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Direccion"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.SystemColors.Control
        Me.LStock.Location = New System.Drawing.Point(580, 153)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(55, 18)
        Me.LStock.TabIndex = 8
        Me.LStock.Text = "Stock?"
        '
        'LPeso
        '
        Me.LPeso.AutoSize = True
        Me.LPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPeso.ForeColor = System.Drawing.SystemColors.Control
        Me.LPeso.Location = New System.Drawing.Point(580, 105)
        Me.LPeso.Name = "LPeso"
        Me.LPeso.Size = New System.Drawing.Size(43, 18)
        Me.LPeso.TabIndex = 7
        Me.LPeso.Text = "Peso"
        '
        'LVelocidad
        '
        Me.LVelocidad.AutoSize = True
        Me.LVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVelocidad.ForeColor = System.Drawing.SystemColors.Control
        Me.LVelocidad.Location = New System.Drawing.Point(580, 58)
        Me.LVelocidad.Name = "LVelocidad"
        Me.LVelocidad.Size = New System.Drawing.Size(88, 18)
        Me.LVelocidad.TabIndex = 6
        Me.LVelocidad.Text = "Velocidades"
        '
        'LAsientos
        '
        Me.LAsientos.AutoSize = True
        Me.LAsientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAsientos.ForeColor = System.Drawing.SystemColors.Control
        Me.LAsientos.Location = New System.Drawing.Point(580, 12)
        Me.LAsientos.Name = "LAsientos"
        Me.LAsientos.Size = New System.Drawing.Size(65, 18)
        Me.LAsientos.TabIndex = 5
        Me.LAsientos.Text = "Asientos"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.SystemColors.Control
        Me.LPrecio.Location = New System.Drawing.Point(360, 153)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(51, 18)
        Me.LPrecio.TabIndex = 4
        Me.LPrecio.Text = "Precio"
        '
        'LMotor
        '
        Me.LMotor.AutoSize = True
        Me.LMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMotor.ForeColor = System.Drawing.SystemColors.Control
        Me.LMotor.Location = New System.Drawing.Point(360, 105)
        Me.LMotor.Name = "LMotor"
        Me.LMotor.Size = New System.Drawing.Size(48, 18)
        Me.LMotor.TabIndex = 3
        Me.LMotor.Text = "Motor"
        '
        'LAño
        '
        Me.LAño.AutoSize = True
        Me.LAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAño.ForeColor = System.Drawing.SystemColors.Control
        Me.LAño.Location = New System.Drawing.Point(360, 58)
        Me.LAño.Name = "LAño"
        Me.LAño.Size = New System.Drawing.Size(34, 18)
        Me.LAño.TabIndex = 2
        Me.LAño.Text = "Año"
        '
        'LMarcaModelo
        '
        Me.LMarcaModelo.AutoSize = True
        Me.LMarcaModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarcaModelo.ForeColor = System.Drawing.SystemColors.Control
        Me.LMarcaModelo.Location = New System.Drawing.Point(360, 12)
        Me.LMarcaModelo.Name = "LMarcaModelo"
        Me.LMarcaModelo.Size = New System.Drawing.Size(129, 18)
        Me.LMarcaModelo.TabIndex = 1
        Me.LMarcaModelo.Text = "Marca y Modelo"
        '
        'PbFotoVehiculo
        '
        Me.PbFotoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFotoVehiculo.Location = New System.Drawing.Point(32, 12)
        Me.PbFotoVehiculo.Name = "PbFotoVehiculo"
        Me.PbFotoVehiculo.Size = New System.Drawing.Size(297, 171)
        Me.PbFotoVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFotoVehiculo.TabIndex = 0
        Me.PbFotoVehiculo.TabStop = False
        '
        'txtIdVehiculo
        '
        Me.txtIdVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVehiculo.Location = New System.Drawing.Point(375, 472)
        Me.txtIdVehiculo.Name = "txtIdVehiculo"
        Me.txtIdVehiculo.Size = New System.Drawing.Size(276, 24)
        Me.txtIdVehiculo.TabIndex = 72
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label27.Location = New System.Drawing.Point(220, 474)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 18)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "IdVehiculo"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Location = New System.Drawing.Point(220, 507)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 18)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "Estado"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.ForeColor = System.Drawing.Color.Snow
        Me.btnVolver.Location = New System.Drawing.Point(12, 481)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(172, 38)
        Me.btnVolver.TabIndex = 75
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnSolicitarCompra
        '
        Me.btnSolicitarCompra.BackColor = System.Drawing.Color.Red
        Me.btnSolicitarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitarCompra.ForeColor = System.Drawing.Color.Snow
        Me.btnSolicitarCompra.Location = New System.Drawing.Point(792, 443)
        Me.btnSolicitarCompra.Name = "btnSolicitarCompra"
        Me.btnSolicitarCompra.Size = New System.Drawing.Size(172, 38)
        Me.btnSolicitarCompra.TabIndex = 34
        Me.btnSolicitarCompra.Text = "Completar Venta"
        Me.btnSolicitarCompra.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LStock)
        Me.Panel1.Controls.Add(Me.PbFotoVehiculo)
        Me.Panel1.Controls.Add(Me.LMarcaModelo)
        Me.Panel1.Controls.Add(Me.LPeso)
        Me.Panel1.Controls.Add(Me.LAño)
        Me.Panel1.Controls.Add(Me.LMotor)
        Me.Panel1.Controls.Add(Me.LVelocidad)
        Me.Panel1.Controls.Add(Me.LPrecio)
        Me.Panel1.Controls.Add(Me.LAsientos)
        Me.Panel1.Location = New System.Drawing.Point(223, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 193)
        Me.Panel1.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Datos del Vehiculo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LIdCliente)
        Me.Panel2.Controls.Add(Me.LIdVehiculo)
        Me.Panel2.Controls.Add(Me.LidEmpleado)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnVolver)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 559)
        Me.Panel2.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(733, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Datos de Pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(25, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "IdCliente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(25, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "IdVehiculo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(25, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "IdEmpleado:"
        '
        'LidEmpleado
        '
        Me.LidEmpleado.AutoSize = True
        Me.LidEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LidEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.LidEmpleado.Location = New System.Drawing.Point(135, 127)
        Me.LidEmpleado.Name = "LidEmpleado"
        Me.LidEmpleado.Size = New System.Drawing.Size(22, 18)
        Me.LidEmpleado.TabIndex = 79
        Me.LidEmpleado.Text = "ID"
        '
        'LIdVehiculo
        '
        Me.LIdVehiculo.AutoSize = True
        Me.LIdVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIdVehiculo.ForeColor = System.Drawing.SystemColors.Control
        Me.LIdVehiculo.Location = New System.Drawing.Point(135, 88)
        Me.LIdVehiculo.Name = "LIdVehiculo"
        Me.LIdVehiculo.Size = New System.Drawing.Size(22, 18)
        Me.LIdVehiculo.TabIndex = 80
        Me.LIdVehiculo.Text = "ID"
        '
        'LIdCliente
        '
        Me.LIdCliente.AutoSize = True
        Me.LIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIdCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.LIdCliente.Location = New System.Drawing.Point(135, 52)
        Me.LIdCliente.Name = "LIdCliente"
        Me.LIdCliente.Size = New System.Drawing.Size(22, 18)
        Me.LIdCliente.TabIndex = 81
        Me.LIdCliente.Text = "ID"
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 559)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSolicitarCompra)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtIdVehiculo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormVenta"
        Me.Text = "FormVenta"
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPeso As Label
    Friend WithEvents LVelocidad As Label
    Friend WithEvents LAsientos As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LMotor As Label
    Friend WithEvents LAño As Label
    Friend WithEvents LMarcaModelo As Label
    Friend WithEvents PbFotoVehiculo As PictureBox
    Friend WithEvents txtIdVehiculo As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSolicitarCompra As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LIdCliente As Label
    Friend WithEvents LIdVehiculo As Label
    Friend WithEvents LidEmpleado As Label
End Class
