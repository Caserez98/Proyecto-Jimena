Public Class frmMenu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnVerUsuarios_Click(sender As Object, e As EventArgs) Handles btnVerUsuarios.Click
        Me.Hide()
        frmUsuarios.Show()

    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Me.Hide()
        agUsuario.Show()

    End Sub

    Private Sub btnHerramientas_Click(sender As Object, e As EventArgs) Handles btnHerramientas.Click
        Me.Hide()
        regHerramientas.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Inicio.Close()

    End Sub

    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        Me.Hide()

        Registros.Show()

    End Sub
End Class
