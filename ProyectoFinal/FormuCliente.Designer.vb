<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormuCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.BVerSolicitudes = New System.Windows.Forms.Button()
        Me.BVerCatologo = New System.Windows.Forms.Button()
        Me.PSolicitudes = New System.Windows.Forms.Panel()
        Me.LTotalSolicitudes = New System.Windows.Forms.Label()
        Me.LSolicitudes = New System.Windows.Forms.Label()
        Me.DGVSolicitudes = New System.Windows.Forms.DataGridView()
        Me.IIdCliente = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PSolicitudes.SuspendLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IIdCliente)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCambiarContraseña)
        Me.Panel1.Controls.Add(Me.BVerSolicitudes)
        Me.Panel1.Controls.Add(Me.BVerCatologo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 559)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(12, 225)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(172, 31)
        Me.btnCambiarContraseña.TabIndex = 2
        Me.btnCambiarContraseña.Text = "Canbiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'BVerSolicitudes
        '
        Me.BVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerSolicitudes.Location = New System.Drawing.Point(12, 174)
        Me.BVerSolicitudes.Name = "BVerSolicitudes"
        Me.BVerSolicitudes.Size = New System.Drawing.Size(172, 31)
        Me.BVerSolicitudes.TabIndex = 1
        Me.BVerSolicitudes.Text = "Solicitudes"
        Me.BVerSolicitudes.UseVisualStyleBackColor = True
        '
        'BVerCatologo
        '
        Me.BVerCatologo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerCatologo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerCatologo.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerCatologo.Location = New System.Drawing.Point(12, 117)
        Me.BVerCatologo.Name = "BVerCatologo"
        Me.BVerCatologo.Size = New System.Drawing.Size(172, 31)
        Me.BVerCatologo.TabIndex = 0
        Me.BVerCatologo.Text = "Catalogo"
        Me.BVerCatologo.UseVisualStyleBackColor = True
        '
        'PSolicitudes
        '
        Me.PSolicitudes.Controls.Add(Me.DGVSolicitudes)
        Me.PSolicitudes.Controls.Add(Me.LTotalSolicitudes)
        Me.PSolicitudes.Controls.Add(Me.LSolicitudes)
        Me.PSolicitudes.Location = New System.Drawing.Point(206, 0)
        Me.PSolicitudes.Name = "PSolicitudes"
        Me.PSolicitudes.Size = New System.Drawing.Size(977, 559)
        Me.PSolicitudes.TabIndex = 1
        '
        'LTotalSolicitudes
        '
        Me.LTotalSolicitudes.AutoSize = True
        Me.LTotalSolicitudes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.LTotalSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.LTotalSolicitudes.Location = New System.Drawing.Point(63, 117)
        Me.LTotalSolicitudes.Name = "LTotalSolicitudes"
        Me.LTotalSolicitudes.Size = New System.Drawing.Size(141, 18)
        Me.LTotalSolicitudes.TabIndex = 1
        Me.LTotalSolicitudes.Text = "Total de Solicitudes:"
        '
        'LSolicitudes
        '
        Me.LSolicitudes.AutoSize = True
        Me.LSolicitudes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.LSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.LSolicitudes.Location = New System.Drawing.Point(63, 66)
        Me.LSolicitudes.Name = "LSolicitudes"
        Me.LSolicitudes.Size = New System.Drawing.Size(183, 18)
        Me.LSolicitudes.TabIndex = 0
        Me.LSolicitudes.Text = "Estado de sus Solicitudes:"
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
        Me.DGVSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVSolicitudes.Location = New System.Drawing.Point(66, 151)
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
        Me.DGVSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSolicitudes.Size = New System.Drawing.Size(863, 150)
        Me.DGVSolicitudes.TabIndex = 2
        '
        'IIdCliente
        '
        Me.IIdCliente.AutoSize = True
        Me.IIdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IIdCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.IIdCliente.Location = New System.Drawing.Point(91, 66)
        Me.IIdCliente.Name = "IIdCliente"
        Me.IIdCliente.Size = New System.Drawing.Size(22, 18)
        Me.IIdCliente.TabIndex = 3
        Me.IIdCliente.Text = "ID"
        '
        'FormuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 559)
        Me.Controls.Add(Me.PSolicitudes)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Name = "FormuCliente"
        Me.Text = "FormuCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PSolicitudes.ResumeLayout(False)
        Me.PSolicitudes.PerformLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BVerSolicitudes As Button
    Friend WithEvents BVerCatologo As Button
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PSolicitudes As Panel
    Friend WithEvents LSolicitudes As Label
    Friend WithEvents LTotalSolicitudes As Label
    Friend WithEvents DGVSolicitudes As DataGridView
    Friend WithEvents IIdCliente As Label
End Class
