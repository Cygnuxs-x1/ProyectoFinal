<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BMasVendido = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BVerTodos = New System.Windows.Forms.Button()
        Me.BSolicitarCompra = New System.Windows.Forms.Button()
        Me.TBBusqueda = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPeso = New System.Windows.Forms.Label()
        Me.LVelocidad = New System.Windows.Forms.Label()
        Me.LAsientos = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LMotor = New System.Windows.Forms.Label()
        Me.LAño = New System.Windows.Forms.Label()
        Me.LMarcaModelo = New System.Windows.Forms.Label()
        Me.PbFotoVehiculo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBFiltroNarca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTVerMas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBPrecio = New System.Windows.Forms.ComboBox()
        Me.PanelVerTodo = New System.Windows.Forms.Panel()
        Me.DGVVehiculos = New System.Windows.Forms.DataGridView()
        Me.PVerCatalogo = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVerTodo.SuspendLayout()
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PVerCatalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BMasVendido)
        Me.Panel1.Controls.Add(Me.BVolver)
        Me.Panel1.Controls.Add(Me.BVerTodos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 611)
        Me.Panel1.TabIndex = 12
        '
        'BMasVendido
        '
        Me.BMasVendido.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMasVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMasVendido.ForeColor = System.Drawing.SystemColors.Control
        Me.BMasVendido.Location = New System.Drawing.Point(23, 225)
        Me.BMasVendido.Name = "BMasVendido"
        Me.BMasVendido.Size = New System.Drawing.Size(159, 33)
        Me.BMasVendido.TabIndex = 15
        Me.BMasVendido.Text = "Mas Vendidos"
        Me.BMasVendido.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.SystemColors.Control
        Me.BVolver.Location = New System.Drawing.Point(23, 450)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(159, 33)
        Me.BVolver.TabIndex = 14
        Me.BVolver.Text = "Cerrar Sesion"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BVerTodos
        '
        Me.BVerTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerTodos.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerTodos.Location = New System.Drawing.Point(23, 150)
        Me.BVerTodos.Name = "BVerTodos"
        Me.BVerTodos.Size = New System.Drawing.Size(159, 33)
        Me.BVerTodos.TabIndex = 13
        Me.BVerTodos.Text = "Ver Todos"
        Me.BVerTodos.UseVisualStyleBackColor = False
        '
        'BSolicitarCompra
        '
        Me.BSolicitarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSolicitarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSolicitarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSolicitarCompra.ForeColor = System.Drawing.SystemColors.Control
        Me.BSolicitarCompra.Location = New System.Drawing.Point(736, 554)
        Me.BSolicitarCompra.Name = "BSolicitarCompra"
        Me.BSolicitarCompra.Size = New System.Drawing.Size(159, 33)
        Me.BSolicitarCompra.TabIndex = 12
        Me.BSolicitarCompra.Text = "Solicitar Compra"
        Me.BSolicitarCompra.UseVisualStyleBackColor = False
        '
        'TBBusqueda
        '
        Me.TBBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBusqueda.Location = New System.Drawing.Point(736, 50)
        Me.TBBusqueda.Name = "TBBusqueda"
        Me.TBBusqueda.Size = New System.Drawing.Size(172, 24)
        Me.TBBusqueda.TabIndex = 11
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.SystemColors.Control
        Me.LStock.Location = New System.Drawing.Point(625, 182)
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
        Me.LPeso.Location = New System.Drawing.Point(625, 134)
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
        Me.LVelocidad.Location = New System.Drawing.Point(625, 87)
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
        Me.LAsientos.Location = New System.Drawing.Point(625, 41)
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
        Me.LPrecio.Location = New System.Drawing.Point(405, 182)
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
        Me.LMotor.Location = New System.Drawing.Point(405, 134)
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
        Me.LAño.Location = New System.Drawing.Point(405, 87)
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
        Me.LMarcaModelo.Location = New System.Drawing.Point(405, 41)
        Me.LMarcaModelo.Name = "LMarcaModelo"
        Me.LMarcaModelo.Size = New System.Drawing.Size(129, 18)
        Me.LMarcaModelo.TabIndex = 1
        Me.LMarcaModelo.Text = "Marca y Modelo"
        '
        'PbFotoVehiculo
        '
        Me.PbFotoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFotoVehiculo.Location = New System.Drawing.Point(32, 30)
        Me.PbFotoVehiculo.Name = "PbFotoVehiculo"
        Me.PbFotoVehiculo.Size = New System.Drawing.Size(316, 175)
        Me.PbFotoVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFotoVehiculo.TabIndex = 0
        Me.PbFotoVehiculo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(326, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Filtrar por Precio"
        '
        'CBFiltroNarca
        '
        Me.CBFiltroNarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFiltroNarca.FormattingEnabled = True
        Me.CBFiltroNarca.Items.AddRange(New Object() {"Chevrolet", "Citroen", "Fiat", "Ford", "Peugeot", "Renault", "Toyota", "Volkswagen"})
        Me.CBFiltroNarca.Location = New System.Drawing.Point(162, 48)
        Me.CBFiltroNarca.Name = "CBFiltroNarca"
        Me.CBFiltroNarca.Size = New System.Drawing.Size(152, 26)
        Me.CBFiltroNarca.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(613, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar Modelo"
        '
        'BTVerMas
        '
        Me.BTVerMas.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTVerMas.ForeColor = System.Drawing.SystemColors.Control
        Me.BTVerMas.Location = New System.Drawing.Point(736, 255)
        Me.BTVerMas.Name = "BTVerMas"
        Me.BTVerMas.Size = New System.Drawing.Size(159, 33)
        Me.BTVerMas.TabIndex = 5
        Me.BTVerMas.Text = "Ver este vehiculo"
        Me.BTVerMas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar por Marca"
        '
        'CBPrecio
        '
        Me.CBPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPrecio.FormattingEnabled = True
        Me.CBPrecio.Items.AddRange(New Object() {"Menos de 2 Millones", "Menos de 3 Millones", "Menos de 4 millones", "4 Millones o mas"})
        Me.CBPrecio.Location = New System.Drawing.Point(450, 49)
        Me.CBPrecio.Name = "CBPrecio"
        Me.CBPrecio.Size = New System.Drawing.Size(152, 26)
        Me.CBPrecio.TabIndex = 8
        '
        'PanelVerTodo
        '
        Me.PanelVerTodo.Controls.Add(Me.PVerCatalogo)
        Me.PanelVerTodo.Controls.Add(Me.DGVVehiculos)
        Me.PanelVerTodo.Controls.Add(Me.BSolicitarCompra)
        Me.PanelVerTodo.Controls.Add(Me.TBBusqueda)
        Me.PanelVerTodo.Controls.Add(Me.CBPrecio)
        Me.PanelVerTodo.Controls.Add(Me.BTVerMas)
        Me.PanelVerTodo.Controls.Add(Me.Label1)
        Me.PanelVerTodo.Controls.Add(Me.Label2)
        Me.PanelVerTodo.Controls.Add(Me.Label3)
        Me.PanelVerTodo.Controls.Add(Me.CBFiltroNarca)
        Me.PanelVerTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVerTodo.Location = New System.Drawing.Point(200, 0)
        Me.PanelVerTodo.Name = "PanelVerTodo"
        Me.PanelVerTodo.Size = New System.Drawing.Size(984, 611)
        Me.PanelVerTodo.TabIndex = 14
        '
        'DGVVehiculos
        '
        Me.DGVVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVehiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehiculos.EnableHeadersVisualStyles = False
        Me.DGVVehiculos.Location = New System.Drawing.Point(42, 99)
        Me.DGVVehiculos.Name = "DGVVehiculos"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVehiculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVVehiculos.RowHeadersWidth = 45
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control
        Me.DGVVehiculos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVVehiculos.Size = New System.Drawing.Size(866, 150)
        Me.DGVVehiculos.TabIndex = 13
        '
        'PVerCatalogo
        '
        Me.PVerCatalogo.Controls.Add(Me.PbFotoVehiculo)
        Me.PVerCatalogo.Controls.Add(Me.LMarcaModelo)
        Me.PVerCatalogo.Controls.Add(Me.LStock)
        Me.PVerCatalogo.Controls.Add(Me.LAño)
        Me.PVerCatalogo.Controls.Add(Me.LMotor)
        Me.PVerCatalogo.Controls.Add(Me.LPrecio)
        Me.PVerCatalogo.Controls.Add(Me.LPeso)
        Me.PVerCatalogo.Controls.Add(Me.LAsientos)
        Me.PVerCatalogo.Controls.Add(Me.LVelocidad)
        Me.PVerCatalogo.Location = New System.Drawing.Point(42, 305)
        Me.PVerCatalogo.Name = "PVerCatalogo"
        Me.PVerCatalogo.Size = New System.Drawing.Size(866, 232)
        Me.PVerCatalogo.TabIndex = 14
        '
        'Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.PanelVerTodo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Catalogo"
        Me.Text = "Catalogo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVerTodo.ResumeLayout(False)
        Me.PanelVerTodo.PerformLayout()
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PVerCatalogo.ResumeLayout(False)
        Me.PVerCatalogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BVolver As Button
    Friend WithEvents BVerTodos As Button
    Friend WithEvents BMasVendido As Button
    Friend WithEvents BSolicitarCompra As Button
    Friend WithEvents TBBusqueda As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents LPeso As Label
    Friend WithEvents LVelocidad As Label
    Friend WithEvents LAsientos As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LMotor As Label
    Friend WithEvents LAño As Label
    Friend WithEvents LMarcaModelo As Label
    Friend WithEvents PbFotoVehiculo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBFiltroNarca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTVerMas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBPrecio As ComboBox
    Friend WithEvents PanelVerTodo As Panel
    Friend WithEvents DGVVehiculos As DataGridView
    Friend WithEvents PVerCatalogo As Panel
End Class
