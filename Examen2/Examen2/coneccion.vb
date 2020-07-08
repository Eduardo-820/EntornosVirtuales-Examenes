Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class coneccion

    Public coneccion As SqlConnection = New SqlConnection("Data Source= DESKTOP-BFND73I; Initial Catalog=Tienda; Integrated Security=True")
    Public comandoBuilder As SqlCommandBuilder
    Public comando As SqlCommand
    Public datSet As DataSet = New DataSet()
    Public datRead As SqlDataReader
    Public datAdap As SqlDataAdapter

    Public Sub conectar()
        Try
            coneccion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            'MsgBox("Error al conectar")
        Finally
            coneccion.Close()
        End Try
    End Sub

    Public Sub consulta(ByVal sql, ByVal tabla)
        datSet.Tables.Clear()
        datAdap = New SqlDataAdapter(sql, coneccion)
        comandoBuilder = New SqlCommandBuilder(datAdap)
        datAdap.Fill(datSet, tabla)
    End Sub

    Function eliminar(ByVal tabla, ByVal donde)
        coneccion.Open()
        Dim borrar As String = "delete from " + tabla + " where " + donde
        comando = New SqlCommand(borrar, coneccion)
        Dim a As Integer = comando.ExecuteNonQuery
        coneccion.Close()
        If (a > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal donde)
        coneccion.Open()
        Dim actualizar As String = "update " + tabla + " set " + campos + " where " + donde
        comando = New SqlCommand(actualizar, coneccion)
        Dim a As Integer = comando.ExecuteNonQuery
        coneccion.Close()
        If (a > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function insertar(ByVal sql)
        coneccion.Open()
        comando = New SqlCommand(sql, coneccion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function BuscarVenta(ByVal condicion) As DataTable
        Try
            coneccion.Open()
            Dim encontrar As String = "select idVenta as 'Codigo de Venta', fechaVenta as 'Fecha de Venta', precio as 'Precio de Producto', cantidad as Cantidad, idCliente as 'Codigo de Cliente', idProducto as 'Codigo del Producto' from factura.Venta" + " where " + condicion

            Dim cmd As New SqlCommand(encontrar, coneccion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            coneccion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function BuscarProducto(ByVal condicion) As DataTable
        Try
            coneccion.Open()
            Dim encontrar As String = "select idProducto as 'Codigo Producto', nombreProducto as 'Nombre del Producto',descripcion as 'Descripcion' from factura.producto" + " where " + condicion

            Dim cmd As New SqlCommand(encontrar, coneccion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            coneccion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function BuscarCliente(ByVal condicion) As DataTable
        Try
            coneccion.Open()
            Dim encontrar As String = "select idCliente as 'Codigo', nombre as 'Nombre', apellido as 'Apellido', direccion as 'Direccion' from factura.cliente" + " where " + condicion

            Dim cmd As New SqlCommand(encontrar, coneccion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            coneccion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
