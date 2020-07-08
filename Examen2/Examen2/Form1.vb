Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form1
    Public coneccion As coneccion = New coneccion

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        abrirFormulario(CRUD)
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)        If PanelMostrar.Controls.Count > 0 Then            Me.PanelMostrar.Controls.RemoveAt(0)        End If        Dim frm As Form = TryCast(formHijo, Form)        frm.TopLevel = False        frm.Dock = DockStyle.Fill        Me.PanelMostrar.Controls.Add(frm)        Me.PanelMostrar.Tag = frm        frm.Show()    End Sub

    Private Sub PanelMostrar_Paint(sender As Object, e As PaintEventArgs) Handles PanelMostrar.Paint

    End Sub
End Class
