Imports System.ComponentModel
Public Class CrudVenta
    Dim conexion As New coneccion()
    Dim dt As New DataTable

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            dateTimeFecha.Text = dtg.Cells(1).Value.ToString()
            txtPrecio.Text = dtg.Cells(2).Value.ToString()
            txtCantidad.Text = dtg.Cells(3).Value.ToString()
            txtCodCliente.Text = dtg.Cells(4).Value.ToString()
            txtCodProducto.Text = dtg.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtCodigo.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtCodCliente.Clear()
        txtCodProducto.Clear()
    End Sub

    Private Sub mostrarBusqueda()
        Try
            dt = conexion.BuscarVenta("idVenta like '%" + txtCodCliente.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
                conexion.coneccion.Close()
            Else
                DataGridView1.DataSource = Nothing
                conexion.coneccion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mostrarDatos()
        conexion.consulta("select idVenta as 'Codigo de Venta', fechaVenta as 'Fecha de Venta', precio as 'Precio de Producto', cantidad as Cantidad, idCliente as 'Codigo de Cliente', idProducto as 'Codigo del Producto' from factura.Venta", "factura.Venta")
        DataGridView1.DataSource = conexion.datSet.Tables("factura.Venta")
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If txtCodigo.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or txtCodCliente.Text = "" Or txtCodCliente.Text = "" Then
            MsgBox("Error al ingresar intentar ingresar los datos. No deje campos vacios", vbExclamation)
        ElseIf Not IsNumeric(txtCodigo.Text) Or Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(txtCantidad.Text) Or Not IsNumeric(txtCodCliente.Text) Or Not IsNumeric(txtCodProducto.Text) Then
            MsgBox("Error al ingresar intentar ingresar los datos. los campos de Codigos, precio y cantidad solo permiten valores numericos", vbExclamation)
        Else
            Try
                Dim guardar As String =
                 "insert into factura.Venta values(" + txtCodigo.Text + ",'" + dateTimeFecha.Text + "',
             '" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtCodCliente.Text + "','" + txtCodProducto.Text + "')"

                If (conexion.insertar(guardar)) Then
                    MessageBox.Show("Guardado")
                    mostrarDatos()

                    conexion.coneccion.Close()
                Else
                    MessageBox.Show("Error al guardar")
                    conexion.coneccion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.coneccion.Close()
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtCodigo.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or txtCodCliente.Text = "" Or txtCodCliente.Text = "" Then
            MsgBox("Error al ingresar intentar ingresar los datos. No deje campos vacios", vbExclamation)
        ElseIf Not IsNumeric(txtCodigo.Text) Or Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(txtCantidad.Text) Or Not IsNumeric(txtCodCliente.Text) Or Not IsNumeric(txtCodProducto.Text) Then
            MsgBox("Error al ingresar intentar ingresar los datos. los campos de Codigos, precio y cantidad solo permiten valores numericos", vbExclamation)
        Else
            Try
                Dim modificar As String =
                "idVenta='" + txtCodigo.Text + "', fechaVenta='" + dateTimeFecha.Text + "', precio='" + txtPrecio.Text + "', cantidad='" + txtCantidad.Text + "', idCliente ='" + txtCodCliente.Text + "', idProducto ='" + txtCodProducto.Text + "'"
                If (conexion.modificar("factura.Venta", modificar, " idVenta=" + txtCodigo.Text)) Then
                    MessageBox.Show("Actualizado")
                    mostrarDatos()
                    limpiar()
                    conexion.coneccion.Close()
                Else
                    MessageBox.Show("Error al actualizar")
                    conexion.coneccion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
        End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("factura.Venta", "idVenta=" + txtCodigo.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                limpiar()
                conexion.coneccion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.coneccion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCodCliente.Text = "" Then
            MsgBox("Escriba un numero en campo Codigo Cliente", vbInformation)
            mostrarDatos()
        ElseIf Not IsNumeric(txtCodCliente.Text) Then
            MsgBox("Ingrese un valor numerico en el campo Codigo Cliente", vbInformation)
            txtCodigo.Text = ""
            mostrarDatos()
        Else
            mostrarBusqueda()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        llenarCampos(e)
    End Sub
End Class