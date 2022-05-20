Imports System.Data

Imports MySql.Data.MySqlClient
Public Class frmUsuarios

    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"



    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet1.users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.Inventariotitanv2DataSet1.users)
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet1.users' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet.users' Puede moverla o quitarla según sea necesario.
        DataGridView1.DataSource = CargarDatos()


    End Sub

    Private Function CargarDatos() As DataTable
        Dim dtUsers As New DataTable

        Using conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            Using cmd As New MySqlCommand("Select * From Users", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                dtUsers.Load(reader)

                conn.Close()

            End Using
        End Using
        Return dtUsers

    End Function



    Private Sub DataGridView1_CelltClick_(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        borrarTexto()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            txtID.Text = DataGridView1.Item(0, i).Value
            txtNombre.Text = DataGridView1.Item(1, i).Value
            txtPassword.Text = DataGridView1.Item(2, i).Value
            btnEditar.Enabled = True

        Catch ex As Exception
            MsgBox("Selecciona un campo valido")
            btnEditar.Enabled = False

        End Try





    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        habilitarCampos()
        habilitarBotones()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        borrarTexto()
        deshabilitarCampos()
        deshabilitarBotones()

    End Sub


    Private Sub borrarTexto()
        txtID.Text = ""
        txtNombre.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim updateStr = "UPDATE Users Set Nombre='" & txtNombre.Text & "' ,Password='" & txtPassword.Text & "' Where Usuario='" & txtID.Text & "'"


            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim cmd As New MySqlCommand(updateStr, conn
                                        )
            cmd.ExecuteNonQuery()
            MsgBox("User Updated succesfully")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try




        borrarTexto()

        deshabilitarCampos()
        deshabilitarBotones()
        DataGridView1.DataSource = CargarDatos()

    End Sub

    Private Sub frmUsuarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Show()


    End Sub

    Private Sub habilitarCampos()
        txtNombre.Enabled = True
        txtPassword.Enabled = True
    End Sub
    Private Sub deshabilitarCampos()
        txtNombre.Enabled = False
        txtPassword.Enabled = False
    End Sub

    Public Sub habilitarBotones()
        btnCancelar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Public Sub deshabilitarBotones()
        btnCancelar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim deleteStr = "Delete from users where usuario ='" & txtID.Text & "'"


            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim cmd As New MySqlCommand(deleteStr, conn
                                        )
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted succesfully")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try
        borrarTexto()

        deshabilitarCampos()
        deshabilitarBotones()
        DataGridView1.DataSource = CargarDatos()
    End Sub


End Class