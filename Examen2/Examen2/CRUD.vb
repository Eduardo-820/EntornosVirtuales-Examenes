Public Class CRUD
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (coneccion.eliminar("factura.Venta", "codigo=" + txtCodCliente.Text)) Then

        End If
    End Sub
End Class