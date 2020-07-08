Imports System.ComponentModel
Public Class Resumen
    Dim conexion As New coneccion()
    Dim dt As New DataTable
    Private Sub Resumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarclientereporte()
    End Sub

    Private Sub mostrarclientereporte()        Try            dt = conexion.consultareporte            If dt.Rows.Count <> 0 Then                DataGridView1.DataSource = dt                conexion.coneccion.Close()            Else                DataGridView1.DataSource = Nothing                conexion.coneccion.Close()            End If        Catch ex As Exception            MsgBox(ex.Message)        End Try    End Sub

End Class