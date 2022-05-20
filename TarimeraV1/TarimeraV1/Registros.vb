Imports MySql.Data.MySqlClient

Public Class Registros

    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"

    Private Sub Registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet1.registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.Inventariotitanv2DataSet1.registro)
        DataGridView1.DataSource = CargarDatos()

    End Sub

    Private Sub Registros_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Show()

    End Sub

    Private Function CargarDatos() As DataTable
        Dim dtUsers As New DataTable

        Using conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            Using cmd As New MySqlCommand("Select * From Registro", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                dtUsers.Load(reader)

                conn.Close()

            End Using
        End Using
        Return dtUsers

    End Function


End Class