<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrudVenta
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(667, 183)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(240, 25)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(102, 23)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(240, 83)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(102, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(240, 112)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(107, 155)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtCodProducto.TabIndex = 23
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(107, 129)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 22
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(107, 103)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 21
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(107, 77)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 20
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(107, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Codigo Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Codigo Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Codigo"
        '
        'dateTimeFecha
        '
        Me.dateTimeFecha.CustomFormat = "yyyy/MM/dd"
        Me.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeFecha.Location = New System.Drawing.Point(107, 51)
        Me.dateTimeFecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateTimeFecha.Name = "dateTimeFecha"
        Me.dateTimeFecha.Size = New System.Drawing.Size(100, 20)
        Me.dateTimeFecha.TabIndex = 24
        Me.dateTimeFecha.Value = New Date(2020, 1, 30, 0, 0, 0, 0)
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(240, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar por Cliente"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(240, 141)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 26
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'CrudVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dateTimeFecha)
        Me.Controls.Add(Me.txtCodProducto)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudVenta"
        Me.Text = "CRUD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dateTimeFecha As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
End Class
