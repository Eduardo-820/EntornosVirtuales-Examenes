Imports System.Data.SqlClient

Public Class coneccion

    Public coneccion As SqlConnection = New SqlConnection("DataSource= DESKTOP-BFND73I; Inicial Catalog=Tienda; Integrated Security=True")
    Public comandoBuilder As SqlCommandBuilder
    Public comando As SqlCommand
    Public datSet As DataSet = New DataSet()
    Public datRead As SqlDataReader
    Public datAdap As SqlDataAdapter

    Public Sub conectar()
        Try
            coneccion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("Error al conectar")
        Finally
            coneccion.Close()
        End Try
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
End Class
