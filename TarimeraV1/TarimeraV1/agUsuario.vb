Imports MySql.Data.MySqlClient

Public Class agUsuario

    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"

    Private Sub agUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub agUsuario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Show()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim str1 = txtID.Text.Trim
        Dim str2 = txtNombre.Text.Trim
        Dim str3 = txtPassword.Text.Trim
        Dim msgText = ""
        If str1.Length = 0 Then
            msgText += "Campo de Usuairo Vacio "
        End If
        If str2.Length = 0 Then
            msgText += "Campo de Nombre Vacio "
        End If
        If str3.Length = 0 Then
            msgText += "Campo de Password Vacio "
        End If
        If (msgText.Length > 0) Then
            MsgBox(msgText
                   )
        Else
            Try
                Dim insert = "Insert into Users (Usuario,Nombre,Password) Values (@id,@nombre,@password)"


                Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
                conn.Open()
                Dim cmd As New MySqlCommand(insert, conn
                                            )
                cmd.Parameters.Add("@id", MySqlDbType.VarChar
                                   ).Value = txtID.Text
                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar
                                   ).Value = txtNombre.Text
                cmd.Parameters.Add("@password", MySqlDbType.VarChar
                                   ).Value = txtPassword.Text


                cmd.ExecuteNonQuery()
                MsgBox("User Updated succesfully")
                borrarTexto()
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message
                       )

            End Try

        End If

    End Sub

    Private Sub borrarTexto()
        txtID.Text = ""
        txtNombre.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        borrarTexto()

    End Sub
End Class