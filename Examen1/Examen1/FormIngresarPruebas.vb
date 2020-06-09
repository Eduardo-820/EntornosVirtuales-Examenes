Imports System.ComponentModel

Public Class FormIngresarPruebas
    Dim opcion, departamento, activos(18), recuperados(18), muertos(18) As Integer

    Private Sub cmboxReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxReporte.SelectedIndexChanged
        departamento = Mid(Val(cmboxReporte.Text), 1, 2)
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
        Else
            cmboxEstado.Enabled = False
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            'mensajes de error por falta de datos
            If txtEdad.Text = "" Then                   'dato vacio en edad
                MsgBox("No se ha especificado la edad", MessageBoxIcon.Error)
            ElseIf Not IsNumeric(txtEdad.Text) Then     'dato no valido en edad
                MsgBox("Edad debe ser un numero", MessageBoxIcon.Error)
                txtEdad.Text = ""
            ElseIf cmboxDepartamento.Text = "" Then     'departamento no seleccionado
                MsgBox("No se ha seleccionado un departamento", MessageBoxIcon.Error)
            ElseIf txtMunicipio.Text = "" Then          'dato vacio en municipio
                MsgBox("No ha especificado Municipio", MessageBoxIcon.Error)
            ElseIf cmboxResultado.Text = "" Then        'resultado de la prueba no seleccionado
                MsgBox("No se ha seleccionado un resultado de la prueba", MessageBoxIcon.Error)
            ElseIf cmboxResultado.Text = "Positivo" And cmboxEstado.Text = "" Then  'estado no seleccionado
                MsgBox("No se ha seleccionado el estado del caso", MessageBoxIcon.Error)
            Else
                opcion = Mid(Val(cmboxDepartamento.Text), 1, 2)
                Select Case opcion
                    Case 1
                        departamento = 1
                    Case 2
                        departamento = 2
                    Case 3
                        departamento = 3
                    Case 4
                        departamento = 4
                    Case 5
                        departamento = 5
                    Case 6
                        departamento = 6
                    Case 7
                        departamento = 7
                    Case 8
                        departamento = 8
                    Case 9
                        departamento = 9
                    Case 10
                        departamento = 10
                    Case 11
                        departamento = 11
                    Case 12
                        departamento = 12
                    Case 13
                        departamento = 13
                    Case 14
                        departamento = 14
                    Case 15
                        departamento = 15
                    Case 16
                        departamento = 16
                    Case 17
                        departamento = 17
                    Case 18
                        departamento = 18
                End Select

                If cmboxResultado.Text = "Positivo" Then    'añadir activo,recuperado o anotar fallecido al departamento
                    If cmboxEstado.Text = "Activo" Then
                        activos(departamento) += 1
                    ElseIf cmboxEstado.Text = "Recuperado" Then
                        recuperados(departamento) += 1
                    ElseIf cmboxEstado.Text = "Fallecido" Then
                        muertos(departamento) += 1
                    End If
                End If

                'añadir registro a la lista
                listboxLista.Items.Add(txtNombre.Text & " | " & txtEdad.Text & " | " & Mid(cmboxDepartamento.Text, 4, 10) & " | " & txtMunicipio.Text & " | " & cmboxResultado.Text & " | " & txtDescripcion.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'validating
    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If txtEdad.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        ElseIf Not IsNumeric(txtEdad.Text) Then
            Me.ErrorProvider1.SetError(sender, "Debe ser un valor numerico")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If txtMunicipio.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub cmboxDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmboxDepartamento.Validating
        If cmboxDepartamento.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub cmboxResultado_Validating(sender As Object, e As CancelEventArgs) Handles cmboxResultado.Validating
        If cmboxResultado.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub
End Class