<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn = New System.Windows.Forms.Button()
        Me.btnCRUD = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Codigo Producto"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(106, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 6
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(106, 43)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 7
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(106, 78)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(106, 112)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(106, 146)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 10
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(106, 183)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtCodProducto.TabIndex = 11
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(118, 221)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 12
        Me.btn.Text = "Ingresar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btnCRUD
        '
        Me.btnCRUD.Location = New System.Drawing.Point(291, 184)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.Size = New System.Drawing.Size(62, 60)
        Me.btnCRUD.TabIndex = 13
        Me.btnCRUD.Text = "Crear Leer Actualizar Eliminar"
        Me.btnCRUD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 256)
        Me.Controls.Add(Me.btnCRUD)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txtCodProducto)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents btn As Button
    Friend WithEvents btnCRUD As Button
End Class
