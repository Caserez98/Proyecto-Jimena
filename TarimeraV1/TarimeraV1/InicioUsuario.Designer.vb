<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Inventariotitanv2DataSet1 = New TarimeraV1.inventariotitanv2DataSet1()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New TarimeraV1.inventariotitanv2DataSet1TableAdapters.registroTableAdapter()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(51, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tomar Herramienta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Registrar Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Herrameintas Tomadas"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(422, 179)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(153, 24)
        Me.ComboBox2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(607, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Registrar Entrada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Inventariotitanv2DataSet1
        '
        Me.Inventariotitanv2DataSet1.DataSetName = "inventariotitanv2DataSet1"
        Me.Inventariotitanv2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "registro"
        Me.RegistroBindingSource.DataSource = Me.Inventariotitanv2DataSet1
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(472, 30)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(607, 30)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(113, 23)
        Me.btnCerrarSesion.TabIndex = 8
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'InicioUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 391)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InicioUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioUsuario"
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Inventariotitanv2DataSet1 As inventariotitanv2DataSet1
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As inventariotitanv2DataSet1TableAdapters.registroTableAdapter
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnCerrarSesion As Button
End Class
