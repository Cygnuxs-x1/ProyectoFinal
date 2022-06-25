<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PContraseña = New System.Windows.Forms.Panel()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LIDCliente = New System.Windows.Forms.Label()
        Me.BVerSolicitudes = New System.Windows.Forms.Button()
        Me.BVerCatologo = New System.Windows.Forms.Button()
        Me.PSolicitudes = New System.Windows.Forms.Panel()
        Me.LTotalSolicitudes = New System.Windows.Forms.Label()
        Me.DGVSolicitudes = New System.Windows.Forms.DataGridView()
        Me.LSolicitudes = New System.Windows.Forms.Label()
        Me.LBienvenida = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PContraseña.SuspendLayout()
        Me.PSolicitudes.SuspendLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PContraseña)
        Me.PanelMenu.Controls.Add(Me.btnCambiarContraseña)
        Me.PanelMenu.Controls.Add(Me.BCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.LIDCliente)
        Me.PanelMenu.Controls.Add(Me.BVerSolicitudes)
        Me.PanelMenu.Controls.Add(Me.BVerCatologo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 559)
        Me.PanelMenu.TabIndex = 0
        '
        'PContraseña
        '
        Me.PContraseña.Controls.Add(Me.btnGuardarCambios)
        Me.PContraseña.Controls.Add(Me.TextBox2)
        Me.PContraseña.Controls.Add(Me.Label3)
        Me.PContraseña.Controls.Add(Me.TextBox1)
        Me.PContraseña.Controls.Add(Me.Label4)
        Me.PContraseña.Location = New System.Drawing.Point(30, 280)
        Me.PContraseña.Name = "PContraseña"
        Me.PContraseña.Size = New System.Drawing.Size(310, 189)
        Me.PContraseña.TabIndex = 7
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardarCambios.Location = New System.Drawing.Point(86, 93)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(144, 33)
        Me.btnGuardarCambios.TabIndex = 8
        Me.btnGuardarCambios.Text = "GuardarCambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(18, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Contraseña Actual"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(16, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña Nueva"
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(30, 241)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(148, 33)
        Me.btnCambiarContraseña.TabIndex = 8
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(30, 460)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(148, 33)
        Me.BCerrarSesion.TabIndex = 4
        Me.BCerrarSesion.Text = "Cerrar sesion"
        Me.BCerrarSesion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(27, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Su IdCliente es:"
        '
        'LIDCliente
        '
        Me.LIDCliente.AutoSize = True
        Me.LIDCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIDCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.LIDCliente.Location = New System.Drawing.Point(143, 412)
        Me.LIDCliente.Name = "LIDCliente"
        Me.LIDCliente.Size = New System.Drawing.Size(22, 18)
        Me.LIDCliente.TabIndex = 2
        Me.LIDCliente.Text = "ID"
        '
        'BVerSolicitudes
        '
        Me.BVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerSolicitudes.Location = New System.Drawing.Point(30, 192)
        Me.BVerSolicitudes.Name = "BVerSolicitudes"
        Me.BVerSolicitudes.Size = New System.Drawing.Size(148, 33)
        Me.BVerSolicitudes.TabIndex = 1
        Me.BVerSolicitudes.Text = "Ver Solicitudes"
        Me.BVerSolicitudes.UseVisualStyleBackColor = True
        '
        'BVerCatologo
        '
        Me.BVerCatologo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerCatologo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerCatologo.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerCatologo.Location = New System.Drawing.Point(30, 126)
        Me.BVerCatologo.Name = "BVerCatologo"
        Me.BVerCatologo.Size = New System.Drawing.Size(148, 33)
        Me.BVerCatologo.TabIndex = 0
        Me.BVerCatologo.Text = "Ver Catalogo"
        Me.BVerCatologo.UseVisualStyleBackColor = True
        '
        'PSolicitudes
        '
        Me.PSolicitudes.Controls.Add(Me.LTotalSolicitudes)
        Me.PSolicitudes.Controls.Add(Me.DGVSolicitudes)
        Me.PSolicitudes.Controls.Add(Me.LSolicitudes)
        Me.PSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PSolicitudes.Location = New System.Drawing.Point(200, 0)
        Me.PSolicitudes.Name = "PSolicitudes"
        Me.PSolicitudes.Size = New System.Drawing.Size(984, 559)
        Me.PSolicitudes.TabIndex = 1
        '
        'LTotalSolicitudes
        '
        Me.LTotalSolicitudes.AutoSize = True
        Me.LTotalSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.LTotalSolicitudes.Location = New System.Drawing.Point(47, 88)
        Me.LTotalSolicitudes.Name = "LTotalSolicitudes"
        Me.LTotalSolicitudes.Size = New System.Drawing.Size(133, 18)
        Me.LTotalSolicitudes.TabIndex = 2
        Me.LTotalSolicitudes.Text = "Solicitudes Totales"
        '
        'DGVSolicitudes
        '
        Me.DGVSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.DGVSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DGVSolicitudes.Location = New System.Drawing.Point(66, 143)
        Me.DGVSolicitudes.Name = "DGVSolicitudes"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSolicitudes.RowHeadersWidth = 45
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        Me.DGVSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVSolicitudes.Size = New System.Drawing.Size(868, 168)
        Me.DGVSolicitudes.TabIndex = 1
        '
        'LSolicitudes
        '
        Me.LSolicitudes.AutoSize = True
        Me.LSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.LSolicitudes.Location = New System.Drawing.Point(47, 53)
        Me.LSolicitudes.Name = "LSolicitudes"
        Me.LSolicitudes.Size = New System.Drawing.Size(207, 18)
        Me.LSolicitudes.TabIndex = 0
        Me.LSolicitudes.Text = "Estado de sus solicitudes:"
        '
        'LBienvenida
        '
        Me.LBienvenida.AutoSize = True
        Me.LBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBienvenida.ForeColor = System.Drawing.SystemColors.Control
        Me.LBienvenida.Location = New System.Drawing.Point(253, 71)
        Me.LBienvenida.Name = "LBienvenida"
        Me.LBienvenida.Size = New System.Drawing.Size(79, 18)
        Me.LBienvenida.TabIndex = 2
        Me.LBienvenida.Text = "Bienvenida"
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 559)
        Me.Controls.Add(Me.PSolicitudes)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.LBienvenida)
        Me.Name = "FormCliente"
        Me.Text = "FormCliente"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PContraseña.ResumeLayout(False)
        Me.PContraseña.PerformLayout()
        Me.PSolicitudes.ResumeLayout(False)
        Me.PSolicitudes.PerformLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BVerCatologo As Button
    Friend WithEvents PSolicitudes As Panel
    Friend WithEvents BVerSolicitudes As Button
    Friend WithEvents LSolicitudes As Label
    Friend WithEvents DGVSolicitudes As DataGridView
    Friend WithEvents LIDCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LTotalSolicitudes As Label
    Friend WithEvents LBienvenida As Label
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents PContraseña As Panel
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
