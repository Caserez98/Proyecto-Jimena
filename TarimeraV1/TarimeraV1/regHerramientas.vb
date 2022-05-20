Imports MySql.Data.MySqlClient

Public Class regHerramientas

    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"

    Private Sub regHerramientas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet1.herramienta' Puede moverla o quitarla según sea necesario.
        Me.HerramientaTableAdapter.Fill(Me.Inventariotitanv2DataSet1.herramienta)
        DataGridView1.DataSource = CargarDatos()

    End Sub

    Private Function CargarDatos() As DataTable
        Dim dtUsers As New DataTable

        Using conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            Using cmd As New MySqlCommand("Select * From Herramienta", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                dtUsers.Load(reader)

                conn.Close()

            End Using
        End Using
        Return dtUsers

    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub




    Private Sub borrarTexto()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        borrarTexto()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            txtCodigo.Text = DataGridView1.Item(0, i).Value
            txtDescripcion.Text = DataGridView1.Item(1, i).Value
            deshabilitarBotones()

            btnEditar.Enabled = True
            deshabilitarTexto()
        Catch ex As Exception
            MsgBox("Selecciona opcion valida")
            btnEditar.Enabled = False


        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        borrarTexto()
        deshabilitarBotones()
        btnGuardar.Visible = False
        btnCrearNueva.Visible = True
        btnCrearNueva.Enabled = True
        btnCancelar.Enabled = True
        habilitarTexto()



    End Sub

    Private Sub habilitarBotones()
        btnGuardar.Visible = True
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        btnCrearNueva.Enabled = False
        btnCrearNueva.Visible = False
    End Sub

    Private Sub deshabilitarBotones()
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnEditar.Enabled = False
        btnCrearNueva.Visible = False
        btnCrearNueva.Enabled = False
        btnGuardar.Visible = True



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        habilitarBotones()
        txtDescripcion.Enabled = True



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        deshabilitarTexto()
        borrarTexto()

        deshabilitarBotones()

    End Sub

    Private Sub btnCrearNueva_Click(sender As Object, e As EventArgs) Handles btnCrearNueva.Click

        Dim str1 = txtCodigo.Text.Trim
        Dim str2 = txtDescripcion.Text.Trim
        Dim msgText = ""
        If str1.Length = 0 Then
            msgText += "Campo de Usuairo Vacio "
        End If
        If str2.Length = 0 Then
            msgText += "Campo de Nombre Vacio "
        End If
        If (msgText.Length > 0) Then
            MsgBox(msgText
                   )
        Else
            Try
                Dim insert = "Insert into Herramienta (CodH,Descripcion) Values (@id,@descripcion)"


                Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
                conn.Open()
                Dim cmd As New MySqlCommand(insert, conn
                                            )
                cmd.Parameters.Add("@id", MySqlDbType.VarChar
                                   ).Value = txtCodigo.Text
                cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar
                                   ).Value = txtDescripcion.Text


                cmd.ExecuteNonQuery()
                MsgBox("Herramienta Agregada correctamente")
                borrarTexto()
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message
                       )

            End Try

        End If


        deshabilitarTexto()
        borrarTexto()
        DataGridView1.DataSource = CargarDatos()
        deshabilitarBotones()
    End Sub

    Private Sub regHerramientas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Show()


    End Sub



    Private Sub habilitarTexto()
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True


    End Sub

    Private Sub deshabilitarTexto()
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim updateStr = "UPDATE Herramienta Set Descripcion='" & txtDescripcion.Text & "' Where CodH='" & txtCodigo.Text & "'"


            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim cmd As New MySqlCommand(updateStr, conn
                                        )
            cmd.ExecuteNonQuery()
            MsgBox("Herramienta Actualizada exitosamente")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try


        DataGridView1.DataSource = CargarDatos()


        deshabilitarBotones()
        deshabilitarTexto()
        borrarTexto()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim deleteStr = "Delete from Herramienta where CodH ='" & txtCodigo.Text & "'"


            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim cmd As New MySqlCommand(deleteStr, conn
                                        )
            cmd.ExecuteNonQuery()
            MsgBox("Herramienta eliminada correctamente")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try
        DataGridView1.DataSource = CargarDatos()


        deshabilitarBotones()
        deshabilitarTexto()
        borrarTexto()
    End Sub
End Class