﻿Imports System.ComponentModel
Public Class Resumen
    Dim conexion As New coneccion()
    Dim dt As New DataTable
    Private Sub Resumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarclientereporte()
    End Sub

    Private Sub mostrarclientereporte()

End Class