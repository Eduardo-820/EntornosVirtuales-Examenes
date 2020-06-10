Imports System.ComponentModel

Public Class FormInicio
    Dim usuario, password As String

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If txtUsuario.Text = "" Then
                MsgBox("No se ingreso el nombre del Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf txtPassword.Text = "" Then
                MsgBox("No se ingreso la contraseña del Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf Ucase(txtUsuario.Text) <> usuario Or txtPassword.Text <> password Then
                MsgBox("El Nombre o la Contraseña son incorrectos.", MessageBoxIcon.Error, "Error")
            ElseIf Ucase(txtUsuario.Text) = usuario Then
                FormIngresarPruebas.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Try
            If txtUsuario.Text = "" Then
                MsgBox("No se ingreso un nombre para el Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf txtPassword.Text = "" Then
                MsgBox("No se ingreso una contraseña para el nuevo Usuario", MessageBoxIcon.Warning, "Advertencia")
            Else
                usuario = UCase(txtUsuario.Text)
                password = txtPassword.Text
                txtUsuario.Clear()
                txtPassword.Clear()
                MsgBox("Usuario Registrado", MessageBoxIcon.Information, "Informacion")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'validating
    Private Sub txtPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtPassword.Validating
        If txtPassword.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Realizado por: Eduardo Ernesto Lopez.", MessageBoxButtons.OK, "Informacion")
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If txtUsuario.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub
End Class
