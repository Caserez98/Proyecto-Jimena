Imports MySql.Data.MySqlClient

Public Class Inicio

    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"
    Public UsuarioID As String
    Public UID As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario = txtUsuario.Text

        Dim password = txtPassword.Text

        If (usuario.Equals("admin") And (password.Equals("admin"))
        ) Then
            txtPassword.Text=""
            txtUsuario.Text=""
            Me.Hide()
            frmMenu.Show()
        Else
            If obtenerUsuario.Length > 0 Then
                UsuarioID = obtenerUsuario()
                UID = usuario
                Me.Hide()
                InicioUsuario.Show()
            End If

        End If


    End Sub

    Private Function obtenerUsuario() As String
        Dim result = ""

        Try
            Dim str = "Select Nombre From Users Where Usuario='" & txtUsuario.Text & "' and Password='" & txtPassword.Text & "'"

            Using conn As MySqlConnection = New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(str, conn)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    reader.Read()
                    result = reader(0)
                    conn.Close()

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Usuario o Contraseña Incorrectos")

        End Try

        Return result
    End Function

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class