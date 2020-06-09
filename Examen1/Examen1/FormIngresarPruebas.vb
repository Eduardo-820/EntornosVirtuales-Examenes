Imports System.ComponentModel

Public Class FormIngresarPruebas
    Dim nombre, municipio As String
    Dim departamento, edad, activos(18), recuperados(18), muertos(18) As Integer

    Private Sub cmboxReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxReporte.SelectedIndexChanged
        departamento = cmboxReporte.Text
        txtActivos.Text = activos(departamento)
        txtRecuperados.Text = recuperados(departamento)
        txtFallecidos.Text = muertos(departamento)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormInicio.Close()
    End Sub

    Private Sub cmboxResultado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxResultado.SelectedIndexChanged
        If cmboxResultado.Text = "Positivo" Then
            cmboxEstado.Enabled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If Not IsNumeric(txtEdad.Text) Then
                MsgBox("Edad debe ser un numero", MessageBoxIcon.Error)
                txtEdad.Text = ""
            ElseIf cmboxDepartamento.Text = "" Then
                MsgBox("No se ha seleccionado un departamento", MessageBoxIcon.Error)
            ElseIf cmboxResultado.Text = "" Then
                MsgBox("No se ha seleccionado un resultado de la prueba", MessageBoxIcon.Error)
            ElseIf cmboxResultado.Text = "Positivo" And cmboxEstado.Text = "" Then
                MsgBox("No se ha seleccionado el estado del caso", MessageBoxIcon.Error)
            Else
                nombre = txtNombre.Text
                edad = txtEdad.Text
                departamento = cmboxDepartamento.Text
                municipio = txtMunicipio.Text

                If cmboxResultado.Text = "Positivo" Then
                    If cmboxEstado.Text = "Activo" Then
                        activos(departamento) += 1
                    ElseIf cmboxEstado.Text = "Recuperado" Then
                        recuperados(departamento) += 1
                    ElseIf cmboxEstado.Text = "Fallecido" Then
                        muertos(departamento) += 1
                    End If
                End If
                listboxLista.Items.Add(nombre & " | " & edad & " | " & departamento & " | " & municipio & " | " & cmboxResultado.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If txtEdad.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating

    End Sub
End Class