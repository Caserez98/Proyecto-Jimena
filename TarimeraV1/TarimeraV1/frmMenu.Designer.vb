<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHerramientas = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnVerUsuarios = New System.Windows.Forms.Button()
        Me.btnRegistros = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(651, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ver Usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(651, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agregar Usuarios"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(498, 36)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(131, 48)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(635, 36)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 48)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Cerrar Sesion"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ver/Agregar Herramienta"
        '
        'btnHerramientas
        '
        Me.btnHerramientas.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.tools
        Me.btnHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHerramientas.Location = New System.Drawing.Point(99, 114)
        Me.btnHerramientas.Name = "btnHerramientas"
        Me.btnHerramientas.Size = New System.Drawing.Size(126, 119)
        Me.btnHerramientas.TabIndex = 4
        Me.btnHerramientas.UseVisualStyleBackColor = True
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.agregar_usuario
        Me.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(498, 259)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(126, 119)
        Me.btnAgregarUsuario.TabIndex = 1
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'btnVerUsuarios
        '
        Me.btnVerUsuarios.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.user
        Me.btnVerUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerUsuarios.Location = New System.Drawing.Point(498, 116)
        Me.btnVerUsuarios.Name = "btnVerUsuarios"
        Me.btnVerUsuarios.Size = New System.Drawing.Size(126, 119)
        Me.btnVerUsuarios.TabIndex = 0
        Me.btnVerUsuarios.UseVisualStyleBackColor = True
        '
        'btnRegistros
        '
        Me.btnRegistros.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.portapapeles
        Me.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistros.Location = New System.Drawing.Point(99, 270)
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Size = New System.Drawing.Size(126, 119)
        Me.btnRegistros.TabIndex = 8
        Me.btnRegistros.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ver Registros"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegistros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnHerramientas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.btnVerUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerUsuarios As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHerramientas As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistros As Button
    Friend WithEvents Label4 As Label
End Class
