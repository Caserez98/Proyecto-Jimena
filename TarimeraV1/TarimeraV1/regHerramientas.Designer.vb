<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regHerramientas
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerramientaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventariotitanv2DataSet1 = New TarimeraV1.inventariotitanv2DataSet1()
        Me.HerramientaTableAdapter = New TarimeraV1.inventariotitanv2DataSet1TableAdapters.herramientaTableAdapter()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCrearNueva = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodHDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HerramientaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(512, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(324, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'CodHDataGridViewTextBoxColumn
        '
        Me.CodHDataGridViewTextBoxColumn.DataPropertyName = "CodH"
        Me.CodHDataGridViewTextBoxColumn.HeaderText = "CodH"
        Me.CodHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodHDataGridViewTextBoxColumn.Name = "CodHDataGridViewTextBoxColumn"
        Me.CodHDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodHDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'HerramientaBindingSource
        '
        Me.HerramientaBindingSource.DataMember = "herramienta"
        Me.HerramientaBindingSource.DataSource = Me.Inventariotitanv2DataSet1
        '
        'Inventariotitanv2DataSet1
        '
        Me.Inventariotitanv2DataSet1.DataSetName = "inventariotitanv2DataSet1"
        Me.Inventariotitanv2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerramientaTableAdapter
        '
        Me.HerramientaTableAdapter.ClearBeforeFill = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.TarimeraV1.My.Resources.Resources._error
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(273, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 101)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.trash
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(402, 326)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 101)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.editar
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(144, 326)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(97, 101)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGuardar.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.diskette
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(14, 326)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 101)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Detalles de Herramienta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Descripcion"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(30, 138)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(156, 22)
        Me.txtCodigo.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(30, 189)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(156, 22)
        Me.txtDescripcion.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 45)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Agregar Nueva Herramienta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCrearNueva
        '
        Me.btnCrearNueva.BackColor = System.Drawing.Color.Chartreuse
        Me.btnCrearNueva.BackgroundImage = Global.TarimeraV1.My.Resources.Resources.diskette
        Me.btnCrearNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearNueva.Enabled = False
        Me.btnCrearNueva.Location = New System.Drawing.Point(12, 326)
        Me.btnCrearNueva.Name = "btnCrearNueva"
        Me.btnCrearNueva.Size = New System.Drawing.Size(97, 101)
        Me.btnCrearNueva.TabIndex = 22
        Me.btnCrearNueva.UseVisualStyleBackColor = False
        Me.btnCrearNueva.Visible = False
        '
        'regHerramientas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 450)
        Me.Controls.Add(Me.btnCrearNueva)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "regHerramientas"
        Me.Text = "regHerramientas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Inventariotitanv2DataSet1 As inventariotitanv2DataSet1
    Friend WithEvents HerramientaBindingSource As BindingSource
    Friend WithEvents HerramientaTableAdapter As inventariotitanv2DataSet1TableAdapters.herramientaTableAdapter
    Friend WithEvents CodHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCrearNueva As Button
End Class
