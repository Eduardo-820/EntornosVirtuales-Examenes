Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form1
    Public coneccion As coneccion = New coneccion
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCRUD_Click(sender As Object, e As EventArgs) Handles btnCRUD.Click
        CRUD.Show()
    End Sub
End Class
