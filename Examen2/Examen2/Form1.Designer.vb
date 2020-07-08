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
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelMenu.Controls.Add(Me.btnProducto)
        Me.PanelMenu.Controls.Add(Me.btnCliente)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(113, 435)
        Me.PanelMenu.TabIndex = 1
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Location = New System.Drawing.Point(0, 134)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(113, 23)
        Me.btnProducto.TabIndex = 3
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Location = New System.Drawing.Point(0, 105)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(113, 23)
        Me.btnCliente.TabIndex = 2
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Location = New System.Drawing.Point(0, 76)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(113, 23)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'PanelMostrar
        '
        Me.PanelMostrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMostrar.Location = New System.Drawing.Point(113, 0)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(754, 435)
        Me.PanelMostrar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 435)
        Me.Controls.Add(Me.PanelMostrar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProducto As Button
End Class
