<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresarPruebas
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmboxResultado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmboxDepartamento = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cmboxEstado = New System.Windows.Forms.ComboBox()
        Me.cmboxReporte = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFallecidos = New System.Windows.Forms.TextBox()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.listboxLista = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(499, 304)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Municipio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Resultado"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(95, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(115, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(95, 48)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(115, 20)
        Me.txtEdad.TabIndex = 7
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(95, 101)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(115, 20)
        Me.txtMunicipio.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 181)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(139, 59)
        Me.txtDescripcion.TabIndex = 10
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmboxResultado
        '
        Me.cmboxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxResultado.FormattingEnabled = True
        Me.cmboxResultado.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.cmboxResultado.Location = New System.Drawing.Point(95, 127)
        Me.cmboxResultado.Name = "cmboxResultado"
        Me.cmboxResultado.Size = New System.Drawing.Size(115, 21)
        Me.cmboxResultado.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descripcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmboxDepartamento)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.cmboxEstado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmboxResultado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 286)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Caso"
        '
        'cmboxDepartamento
        '
        Me.cmboxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxDepartamento.FormattingEnabled = True
        Me.cmboxDepartamento.Items.AddRange(New Object() {"01 Atlántida", "02 Choluteca", "03 Colón", "04 Comayagua", "05 Copán", "06 Cortés", "07 El Paraíso", "08 Francisco Morazán", "09 Gracias a Dios", "10 Intibucá", "11 Islas de la Bahía", "12 La Paz", "13 Lempira", "14 Ocotepeque", "15 Olancho", "16 Santa Bárbara", "17 Valle", "18 Yoro"})
        Me.cmboxDepartamento.Location = New System.Drawing.Point(95, 74)
        Me.cmboxDepartamento.Name = "cmboxDepartamento"
        Me.cmboxDepartamento.Size = New System.Drawing.Size(115, 21)
        Me.cmboxDepartamento.TabIndex = 16
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(159, 257)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 15
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cmboxEstado
        '
        Me.cmboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxEstado.Enabled = False
        Me.cmboxEstado.FormattingEnabled = True
        Me.cmboxEstado.Items.AddRange(New Object() {"Activo", "Recuperado", "Fallecido"})
        Me.cmboxEstado.Location = New System.Drawing.Point(95, 154)
        Me.cmboxEstado.Name = "cmboxEstado"
        Me.cmboxEstado.Size = New System.Drawing.Size(115, 21)
        Me.cmboxEstado.TabIndex = 14
        '
        'cmboxReporte
        '
        Me.cmboxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxReporte.FormattingEnabled = True
        Me.cmboxReporte.Items.AddRange(New Object() {"01 Atlántida", "02 Choluteca", "03 Colón", "04 Comayagua", "05 Copán", "06 Cortés", "07 El Paraíso", "08 Francisco Morazán", "09 Gracias a Dios", "10 Intibucá", "11 Islas de la Bahía", "12 La Paz", "13 Lempira", "14 Ocotepeque", "15 Olancho", "16 Santa Bárbara", "17 Valle", "18 Yoro"})
        Me.cmboxReporte.Location = New System.Drawing.Point(89, 21)
        Me.cmboxReporte.Name = "cmboxReporte"
        Me.cmboxReporte.Size = New System.Drawing.Size(115, 21)
        Me.cmboxReporte.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.listboxLista)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 286)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cmboxReporte)
        Me.GroupBox3.Controls.Add(Me.txtFallecidos)
        Me.GroupBox3.Controls.Add(Me.txtActivos)
        Me.GroupBox3.Controls.Add(Me.txtRecuperados)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 126)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Casos del Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Activos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Recuperados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fallecidos"
        '
        'txtFallecidos
        '
        Me.txtFallecidos.Location = New System.Drawing.Point(89, 100)
        Me.txtFallecidos.Name = "txtFallecidos"
        Me.txtFallecidos.ReadOnly = True
        Me.txtFallecidos.Size = New System.Drawing.Size(115, 20)
        Me.txtFallecidos.TabIndex = 21
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(89, 48)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.ReadOnly = True
        Me.txtActivos.Size = New System.Drawing.Size(115, 20)
        Me.txtActivos.TabIndex = 17
        '
        'txtRecuperados
        '
        Me.txtRecuperados.Location = New System.Drawing.Point(89, 74)
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.ReadOnly = True
        Me.txtRecuperados.Size = New System.Drawing.Size(115, 20)
        Me.txtRecuperados.TabIndex = 20
        '
        'listboxLista
        '
        Me.listboxLista.FormattingEnabled = True
        Me.listboxLista.HorizontalScrollbar = True
        Me.listboxLista.Location = New System.Drawing.Point(6, 146)
        Me.listboxLista.Name = "listboxLista"
        Me.listboxLista.ScrollAlwaysVisible = True
        Me.listboxLista.Size = New System.Drawing.Size(296, 134)
        Me.listboxLista.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Estado actual"
        '
        'FormIngresarPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "FormIngresarPruebas"
        Me.Text = "Ingresar Pruebas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cmboxResultado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmboxEstado As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cmboxDepartamento As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmboxReporte As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFallecidos As TextBox
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents listboxLista As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
End Class
