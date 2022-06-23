<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.BEntrar = New System.Windows.Forms.Button()
        Me.TBContreaseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDocumento = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelDato = New System.Windows.Forms.Panel()
        Me.BSubirFoto = New System.Windows.Forms.Button()
        Me.BCrearNuevoUsuario = New System.Windows.Forms.Button()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.DTPNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBDocumentoN = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BCrearUsuario = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelDato.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BEntrar
        '
        Me.BEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEntrar.ForeColor = System.Drawing.SystemColors.Control
        Me.BEntrar.Location = New System.Drawing.Point(101, 218)
        Me.BEntrar.Name = "BEntrar"
        Me.BEntrar.Size = New System.Drawing.Size(112, 33)
        Me.BEntrar.TabIndex = 0
        Me.BEntrar.Text = "Entrar"
        Me.BEntrar.UseVisualStyleBackColor = False
        '
        'TBContreaseña
        '
        Me.TBContreaseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContreaseña.Location = New System.Drawing.Point(20, 163)
        Me.TBContreaseña.Name = "TBContreaseña"
        Me.TBContreaseña.Size = New System.Drawing.Size(284, 24)
        Me.TBContreaseña.TabIndex = 8
        Me.TBContreaseña.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(17, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contreaseña"
        '
        'TBDocumento
        '
        Me.TBDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDocumento.Location = New System.Drawing.Point(20, 85)
        Me.TBDocumento.Name = "TBDocumento"
        Me.TBDocumento.Size = New System.Drawing.Size(284, 24)
        Me.TBDocumento.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TBDocumento)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BEntrar)
        Me.Panel1.Controls.Add(Me.TBContreaseña)
        Me.Panel1.Location = New System.Drawing.Point(42, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 289)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Documento"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(42, 406)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 33)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PanelDato
        '
        Me.PanelDato.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelDato.Controls.Add(Me.BSubirFoto)
        Me.PanelDato.Controls.Add(Me.BCrearNuevoUsuario)
        Me.PanelDato.Controls.Add(Me.TBContraseña)
        Me.PanelDato.Controls.Add(Me.TBDireccion)
        Me.PanelDato.Controls.Add(Me.DTPNacimiento)
        Me.PanelDato.Controls.Add(Me.Label8)
        Me.PanelDato.Controls.Add(Me.TBDocumentoN)
        Me.PanelDato.Controls.Add(Me.TBApellido)
        Me.PanelDato.Controls.Add(Me.TBNombre)
        Me.PanelDato.Controls.Add(Me.PBFoto)
        Me.PanelDato.Controls.Add(Me.Label7)
        Me.PanelDato.Controls.Add(Me.Label6)
        Me.PanelDato.Controls.Add(Me.Label5)
        Me.PanelDato.Controls.Add(Me.Label4)
        Me.PanelDato.Controls.Add(Me.Label3)
        Me.PanelDato.Location = New System.Drawing.Point(435, 30)
        Me.PanelDato.Name = "PanelDato"
        Me.PanelDato.Size = New System.Drawing.Size(325, 455)
        Me.PanelDato.TabIndex = 9
        '
        'BSubirFoto
        '
        Me.BSubirFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSubirFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSubirFoto.ForeColor = System.Drawing.SystemColors.Control
        Me.BSubirFoto.Location = New System.Drawing.Point(156, 341)
        Me.BSubirFoto.Name = "BSubirFoto"
        Me.BSubirFoto.Size = New System.Drawing.Size(148, 33)
        Me.BSubirFoto.TabIndex = 13
        Me.BSubirFoto.Text = "Subir Foto"
        Me.BSubirFoto.UseVisualStyleBackColor = False
        '
        'BCrearNuevoUsuario
        '
        Me.BCrearNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCrearNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCrearNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCrearNuevoUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.BCrearNuevoUsuario.Location = New System.Drawing.Point(156, 393)
        Me.BCrearNuevoUsuario.Name = "BCrearNuevoUsuario"
        Me.BCrearNuevoUsuario.Size = New System.Drawing.Size(148, 33)
        Me.BCrearNuevoUsuario.TabIndex = 10
        Me.BCrearNuevoUsuario.Text = "Crear Usuario"
        Me.BCrearNuevoUsuario.UseVisualStyleBackColor = False
        '
        'TBContraseña
        '
        Me.TBContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContraseña.Location = New System.Drawing.Point(131, 261)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(163, 24)
        Me.TBContraseña.TabIndex = 12
        Me.TBContraseña.UseSystemPasswordChar = True
        '
        'TBDireccion
        '
        Me.TBDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDireccion.Location = New System.Drawing.Point(131, 220)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(163, 24)
        Me.TBDireccion.TabIndex = 11
        '
        'DTPNacimiento
        '
        Me.DTPNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPNacimiento.Location = New System.Drawing.Point(131, 178)
        Me.DTPNacimiento.MaxDate = New Date(2004, 12, 31, 0, 0, 0, 0)
        Me.DTPNacimiento.Name = "DTPNacimiento"
        Me.DTPNacimiento.Size = New System.Drawing.Size(163, 20)
        Me.DTPNacimiento.TabIndex = 10
        Me.DTPNacimiento.Value = New Date(2004, 12, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(19, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Contraseña"
        '
        'TBDocumentoN
        '
        Me.TBDocumentoN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDocumentoN.Location = New System.Drawing.Point(131, 128)
        Me.TBDocumentoN.Name = "TBDocumentoN"
        Me.TBDocumentoN.Size = New System.Drawing.Size(163, 24)
        Me.TBDocumentoN.TabIndex = 8
        '
        'TBApellido
        '
        Me.TBApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBApellido.Location = New System.Drawing.Point(131, 79)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(163, 24)
        Me.TBApellido.TabIndex = 7
        '
        'TBNombre
        '
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(131, 36)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(163, 24)
        Me.TBNombre.TabIndex = 6
        '
        'PBFoto
        '
        Me.PBFoto.Location = New System.Drawing.Point(22, 309)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(118, 117)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 5
        Me.PBFoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(19, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(19, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(19, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(19, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(19, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre"
        '
        'BCrearUsuario
        '
        Me.BCrearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCrearUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.BCrearUsuario.Location = New System.Drawing.Point(230, 406)
        Me.BCrearUsuario.Name = "BCrearUsuario"
        Me.BCrearUsuario.Size = New System.Drawing.Size(137, 33)
        Me.BCrearUsuario.TabIndex = 10
        Me.BCrearUsuario.Text = "Crear Usuario"
        Me.BCrearUsuario.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 512)
        Me.Controls.Add(Me.BCrearUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PanelDato)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelDato.ResumeLayout(False)
        Me.PanelDato.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BEntrar As Button
    Friend WithEvents TBContreaseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBDocumento As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDato As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents DTPNacimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TBDocumentoN As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents BSubirFoto As Button
    Friend WithEvents BCrearNuevoUsuario As Button
    Friend WithEvents BCrearUsuario As Button
End Class
