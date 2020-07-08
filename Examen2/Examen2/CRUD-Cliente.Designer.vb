<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudClientes
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(250, 137)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 56
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(250, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar por Codigo"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(101, 73)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(117, 20)
        Me.txtApellido.TabIndex = 54
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 53
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(101, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(117, 20)
        Me.txtCodigo.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Codigo"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(250, 108)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.btnEliminar.TabIndex = 48
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(250, 79)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(102, 23)
        Me.btnActualizar.TabIndex = 47
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(250, 21)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(102, 23)
        Me.btnCrear.TabIndex = 46
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 183)
        Me.DataGridView1.TabIndex = 45
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(101, 99)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(117, 61)
        Me.txtDireccion.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Direccion"
        '
        'CRUD_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 364)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CRUD_Cliente"
        Me.Text = "CRUD_Cliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label1 As Label
End Class
