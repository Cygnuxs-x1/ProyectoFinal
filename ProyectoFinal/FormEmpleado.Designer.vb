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
        Me.LNombreApellido = New System.Windows.Forms.Label()
        Me.LDocumento = New System.Windows.Forms.Label()
        Me.LFechaNacimiento = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnIrCatalogo = New System.Windows.Forms.Button()
        Me.BMasVendido = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnMiPerfil = New System.Windows.Forms.Button()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LNombreApellido
        '
        Me.LNombreApellido.AutoSize = True
        Me.LNombreApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreApellido.ForeColor = System.Drawing.SystemColors.Control
        Me.LNombreApellido.Location = New System.Drawing.Point(12, 9)
        Me.LNombreApellido.Name = "LNombreApellido"
        Me.LNombreApellido.Size = New System.Drawing.Size(141, 17)
        Me.LNombreApellido.TabIndex = 0
        Me.LNombreApellido.Text = "Nombre + Apellido"
        '
        'LDocumento
        '
        Me.LDocumento.AutoSize = True
        Me.LDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDocumento.ForeColor = System.Drawing.SystemColors.Control
        Me.LDocumento.Location = New System.Drawing.Point(12, 183)
        Me.LDocumento.Name = "LDocumento"
        Me.LDocumento.Size = New System.Drawing.Size(80, 17)
        Me.LDocumento.TabIndex = 2
        Me.LDocumento.Text = "Documento"
        '
        'LFechaNacimiento
        '
        Me.LFechaNacimiento.AutoSize = True
        Me.LFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaNacimiento.ForeColor = System.Drawing.SystemColors.Control
        Me.LFechaNacimiento.Location = New System.Drawing.Point(12, 151)
        Me.LFechaNacimiento.Name = "LFechaNacimiento"
        Me.LFechaNacimiento.Size = New System.Drawing.Size(66, 17)
        Me.LFechaNacimiento.TabIndex = 3
        Me.LFechaNacimiento.Text = "IdCliente:"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.SystemColors.Control
        Me.LDireccion.Location = New System.Drawing.Point(12, 210)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(67, 17)
        Me.LDireccion.TabIndex = 4
        Me.LDireccion.Text = "Direccion"
        '
        'PBFoto
        '
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(15, 41)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(102, 95)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 5
        Me.PBFoto.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnMiPerfil)
        Me.PanelMenu.Controls.Add(Me.LDireccion)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.BMasVendido)
        Me.PanelMenu.Controls.Add(Me.PBFoto)
        Me.PanelMenu.Controls.Add(Me.btnIrCatalogo)
        Me.PanelMenu.Controls.Add(Me.LFechaNacimiento)
        Me.PanelMenu.Controls.Add(Me.LNombreApellido)
        Me.PanelMenu.Controls.Add(Me.LDocumento)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(253, 600)
        Me.PanelMenu.TabIndex = 6
        '
        'btnIrCatalogo
        '
        Me.btnIrCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnIrCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrCatalogo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnIrCatalogo.Location = New System.Drawing.Point(30, 263)
        Me.btnIrCatalogo.Name = "btnIrCatalogo"
        Me.btnIrCatalogo.Size = New System.Drawing.Size(131, 37)
        Me.btnIrCatalogo.TabIndex = 8
        Me.btnIrCatalogo.Text = "Ir a Catalogo"
        Me.btnIrCatalogo.UseVisualStyleBackColor = False
        '
        'BMasVendido
        '
        Me.BMasVendido.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMasVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMasVendido.ForeColor = System.Drawing.SystemColors.Control
        Me.BMasVendido.Location = New System.Drawing.Point(30, 306)
        Me.BMasVendido.Name = "BMasVendido"
        Me.BMasVendido.Size = New System.Drawing.Size(129, 33)
        Me.BMasVendido.TabIndex = 16
        Me.BMasVendido.Text = "Mas Vendidos"
        Me.BMasVendido.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrarSesion.Location = New System.Drawing.Point(30, 427)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(129, 33)
        Me.btnCerrarSesion.TabIndex = 17
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnMiPerfil
        '
        Me.btnMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiPerfil.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMiPerfil.Location = New System.Drawing.Point(30, 345)
        Me.btnMiPerfil.Name = "btnMiPerfil"
        Me.btnMiPerfil.Size = New System.Drawing.Size(129, 33)
        Me.btnMiPerfil.TabIndex = 18
        Me.btnMiPerfil.Text = "Mi Perfil"
        Me.btnMiPerfil.UseVisualStyleBackColor = False
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 559)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FormEmpleado"
        Me.Text = "FormEmpleado"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LNombreApellido As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents PanelMenu As Panel
    Public WithEvents LDocumento As Label
    Friend WithEvents btnIrCatalogo As Button
    Friend WithEvents btnMiPerfil As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents BMasVendido As Button
End Class
