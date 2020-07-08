Imports System.ComponentModel
Public Class CrudClientes
    Dim conexion As New coneccion()
    Dim dt As New DataTable

    Private Sub CRUD_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)        Try            Dim dtg As DataGridViewRow = DataGridView1.Rows(e.RowIndex)            txtCodigo.Text = dtg.Cells(0).Value.ToString()            txtNombre.Text = dtg.Cells(1).Value.ToString()            txtApellido.Text = dtg.Cells(2).Value.ToString()            txtDireccion.Text = dtg.Cells(3).Value.ToString()        Catch ex As Exception            MsgBox(ex.Message)        End Try    End Sub

    Private Sub mostrarBusqueda()        Try            dt = conexion.BuscarCliente("idCliente like '%" + txtCodigo.Text + "%'")            If dt.Rows.Count <> 0 Then                DataGridView1.DataSource = dt                conexion.coneccion.Close()            Else                DataGridView1.DataSource = Nothing                conexion.coneccion.Close()            End If        Catch ex As Exception            MsgBox(ex.Message)        End Try    End Sub

    Private Sub mostrarDatos()        conexion.consulta("select idCliente as 'Codigo Cliente', nombre as 'Nombre',apellido as 'Apellido',direccion as 'Direccion' from factura.cliente", "factura.cliente")        DataGridView1.DataSource = conexion.datSet.Tables("factura.cliente")    End Sub

    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()        Dim valor As Int16        If txtCodigo.Text = "" Then            MsgBox("Escriba un numero en la casilla", vbInformation)        ElseIf Not IsNumeric(txtCodigo.Text) Then            MsgBox("Ingrese un valor numerico", "Aviso")            txtCodigo.Text = ""        ElseIf IsNumeric(valor) Then            valor = Val(txtCodigo.Text)            If valor = 0 Then                MsgBox("Ingrese una edad valida", vbInformation)            ElseIf valor < 1 Then                MsgBox("Ingrese una edad valida", vbInformation)            ElseIf valor > 100 Then                MsgBox("Ingrese una edad valida entre 1 y 100", vbInformation)            End If        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try            Dim guardar As String =             "insert into factura.cliente values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "')"            If (conexion.insertar(guardar)) Then                MessageBox.Show("Guardado")                mostrarDatos()                conexion.coneccion.Close()            Else                MessageBox.Show("Error al guardar")                conexion.coneccion.Close()            End If        Catch ex As Exception            MsgBox(ex.Message)            conexion.coneccion.Close()        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try            Dim modificar As String =            "idCliente=" + txtCodigo.Text + ", nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', direccion='" + txtDireccion.Text + "'"            If (conexion.modificar("factura.cliente", modificar, " idCliente=" + txtCodigo.Text)) Then                MessageBox.Show("Actualizado")                mostrarDatos()                limpiar()                conexion.coneccion.Close()            Else                MessageBox.Show("Error al actualizar")                conexion.coneccion.Close()            End If        Catch ex As Exception            MsgBox(ex.Message)            conexion.coneccion.Close()        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try            If (conexion.eliminar("factura.cliente", "idCliente=" + txtCodigo.Text)) Then                MessageBox.Show("Eliminado")                mostrarDatos()                limpiar()                conexion.coneccion.Close()            Else                MessageBox.Show("Error al Eliminar")                conexion.coneccion.Close()            End If        Catch ex As Exception            MsgBox(ex.Message)            conexion.coneccion.Close()        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        llenarCampos(e)
    End Sub
End Class