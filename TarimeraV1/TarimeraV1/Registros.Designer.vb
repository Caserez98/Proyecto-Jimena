<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Me.CodRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventariotitanv2DataSet1 = New TarimeraV1.inventariotitanv2DataSet1()
        Me.RegistroTableAdapter = New TarimeraV1.inventariotitanv2DataSet1TableAdapters.registroTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodRDataGridViewTextBoxColumn, Me.CodHDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.EntradaDataGridViewTextBoxColumn, Me.SalidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(55, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(679, 307)
        Me.DataGridView1.TabIndex = 0
        '
        'CodRDataGridViewTextBoxColumn
        '
        Me.CodRDataGridViewTextBoxColumn.DataPropertyName = "CodR"
        Me.CodRDataGridViewTextBoxColumn.HeaderText = "CodR"
        Me.CodRDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodRDataGridViewTextBoxColumn.Name = "CodRDataGridViewTextBoxColumn"
        Me.CodRDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodRDataGridViewTextBoxColumn.Width = 125
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
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 125
        '
        'EntradaDataGridViewTextBoxColumn
        '
        Me.EntradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.HeaderText = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EntradaDataGridViewTextBoxColumn.Name = "EntradaDataGridViewTextBoxColumn"
        Me.EntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntradaDataGridViewTextBoxColumn.Width = 125
        '
        'SalidaDataGridViewTextBoxColumn
        '
        Me.SalidaDataGridViewTextBoxColumn.DataPropertyName = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.HeaderText = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalidaDataGridViewTextBoxColumn.Name = "SalidaDataGridViewTextBoxColumn"
        Me.SalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalidaDataGridViewTextBoxColumn.Width = 125
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "registro"
        Me.RegistroBindingSource.DataSource = Me.Inventariotitanv2DataSet1
        '
        'Inventariotitanv2DataSet1
        '
        Me.Inventariotitanv2DataSet1.DataSetName = "inventariotitanv2DataSet1"
        Me.Inventariotitanv2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Registros"
        Me.Text = "Registros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventariotitanv2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Inventariotitanv2DataSet1 As inventariotitanv2DataSet1
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As inventariotitanv2DataSet1TableAdapters.registroTableAdapter
    Friend WithEvents CodRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
