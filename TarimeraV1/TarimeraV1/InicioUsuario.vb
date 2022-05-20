Imports MySql.Data.MySqlClient

Public Class InicioUsuario
    Dim cadenaConexion As String = "server=localhost;database=inventariotitanv2;user id=root;password=root;port=3306;"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub InicioUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventariotitanv2DataSet1.registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.Inventariotitanv2DataSet1.registro)
        Label1.Text += " " & Inicio.UsuarioID


        cargarHerramientas()
        cargarPedidos()

    End Sub

    Public Sub cargarHerramientas()
        Try
            Dim Str = "Select Descripcion from Herramienta"
            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("Herramienta")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ComboBox1.DataSource = dt
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = ""

            End If
            conn.Close()



        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargarPedidos()
        Try
            Dim Str = "Select CodR from registro where Usuario='" & Inicio.UID & "' AND Entrada is NULL"

            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("Registro")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ComboBox2.DataSource = dt
                ComboBox2.DisplayMember = "CodR"
                ComboBox2.ValueMember = ""

            End If
            conn.Close()



        Catch ex As Exception

        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = obtenerHerramienta()
        crearRegistro(id)
        cargarHerramientas()
        cargarPedidos()

    End Sub

    Private Sub crearRegistro(id)
        Try
            Dim insert = "Insert into registro (CodH,Usuario,Entrada,Salida) Values (@CodH,@Usuario,@Entrada,@Salida)"
            Dim ThisMoment As Date
            ThisMoment = Now
            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()

            Dim cmd As New MySqlCommand(insert, conn
                                            )

            cmd.Parameters.Add("@CodH", MySqlDbType.Int32
                                   ).Value = id
            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = Inicio.UID
            cmd.Parameters.Add("@Entrada", MySqlDbType.DateTime
                                   ).Value = Nothing
            cmd.Parameters.Add("@Salida", MySqlDbType.DateTime
                                   ).Value = ThisMoment

            cmd.ExecuteNonQuery()
            MsgBox("Registro agregado correctamente")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message
                       )

        End Try
    End Sub

    Private Sub entregarHerramienta()
        Try
            Dim ThisMoment As Date
            ThisMoment = Now
            Dim updateStr = "UPDATE Registro Set Entrada=@entrada Where CodR='" & ComboBox2.Text & "'"


            Dim conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            conn.Open()
            Dim cmd As New MySqlCommand(updateStr, conn
                                        )
            cmd.Parameters.Add("@entrada", MySqlDbType.DateTime
                                   ).Value = ThisMoment
            cmd.ExecuteNonQuery()
            MsgBox("Herramienta Entregada exitosamente")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try
        cargarHerramientas()
        cargarPedidos()
    End Sub

    Private Function obtenerHerramienta() As Integer
        Dim result = 0
        Dim str = "Select CodH from Herramienta Where Descripcion='" & ComboBox1.Text & "'"

        Using conn As MySqlConnection = New MySqlConnection(cadenaConexion)
            Using cmd As New MySqlCommand(str, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                result = reader(0)
                conn.Close()

            End Using
        End Using
        Return result
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        entregarHerramienta()
        cargarHerramientas()
        cargarPedidos()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub InicioUsuario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Inicio.UID = ""
        Inicio.UsuarioID = ""
        Inicio.txtPassword.Text = ""
        Inicio.txtUsuario.Text = ""

        Inicio.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()
        Inicio.Close()

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click

        Me.Close()
        Inicio.Show()

    End Sub
End Class