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
        Dim salir As MsgBoxResult = MsgBox("Esta seguro de querer salir?", MsgBoxStyle.YesNo, "Salir")
        If salir = MsgBoxResult.Yes Then
            End
        End If
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
            If txtNombre.Text = "" Then
                MsgBox("No se introdujo un Nombre", MessageBoxIcon.Error, "Error")
            ElseIf txtEdad.Text = "" Then                   'dato vacio en edad
                MsgBox("No se ha especificado la edad", MessageBoxIcon.Error, "Error")
            ElseIf Not IsNumeric(txtEdad.Text) Then     'dato no valido en edad
                MsgBox("Edad debe ser un numero", MessageBoxIcon.Error, "Error")
                txtEdad.Text = ""
            ElseIf cmboxDepartamento.Text = "" Then     'departamento no seleccionado
                MsgBox("No se ha seleccionado un departamento", MessageBoxIcon.Error, "Error")
            ElseIf txtMunicipio.Text = "" Then          'dato vacio en municipio
                MsgBox("No ha especificado Municipio", MessageBoxIcon.Error, "Error")
            ElseIf cmboxResultado.Text = "" Then        'resultado de la prueba no seleccionado
                MsgBox("No se ha seleccionado un resultado de la prueba", MessageBoxIcon.Error, "Error")
            ElseIf cmboxResultado.Text = "Positivo" And cmboxEstado.Text = "" Then  'estado no seleccionado
                MsgBox("No se ha seleccionado el estado del caso", MessageBoxIcon.Error, "Error")
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

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

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

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If txtMunicipio.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub cmboxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxDepartamento.SelectedIndexChanged

    End Sub

    Private Sub cmboxDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmboxDepartamento.Validating
        If cmboxDepartamento.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub cmboxResultado_Validating(sender As Object, e As CancelEventArgs) Handles cmboxResultado.Validating
        If cmboxResultado.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    'mouse hover
    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ingrese la edad del paciente (utilice numeros enteros)")
    End Sub

    Private Sub cmboxDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmboxDepartamento.MouseHover
        ToolTip.SetToolTip(cmboxDepartamento, "Seleccione el departamento al que pertenece el paciente")
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese el nombre del municio al que pertenece el paciente")
    End Sub

    Private Sub cmboxResultado_MouseHover(sender As Object, e As EventArgs) Handles cmboxResultado.MouseHover
        ToolTip.SetToolTip(cmboxResultado, "Seleccione el resultado de la prueba en el paciente")
    End Sub

    Private Sub cmboxEstado_MouseHover(sender As Object, e As EventArgs) Handles cmboxEstado.MouseHover
        ToolTip.SetToolTip(cmboxEstado, "Estado en el que se encuentra el paciente")
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Escriba una descripcion sobre el estado del paciente")
    End Sub

    Private Sub cmboxReporte_MouseHover(sender As Object, e As EventArgs) Handles cmboxReporte.MouseHover
        ToolTip.SetToolTip(cmboxReporte, "Seleccione un departamento ver el reporte")
    End Sub
End Class