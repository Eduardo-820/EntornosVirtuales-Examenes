Public Class FormInicio
    Dim usuario, password As String

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If txtUsuario.Text <> usuario Or txtPassword.Text <> password Then
                MsgBox("El Nombre o la Contraseña son incorrectos.", MessageBoxIcon.Error)
            Else
                FormIngresarPruebas.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Try
            usuario = txtUsuario.Text
            password = txtPassword.Text
            txtUsuario.Clear()
            txtPassword.Clear()
            MsgBox("Usuario Registrado", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
