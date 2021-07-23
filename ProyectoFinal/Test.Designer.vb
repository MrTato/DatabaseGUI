<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet = New ProyectoFinal.DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New ProyectoFinal.DataSetTableAdapters.ClienteTableAdapter()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimernombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundonombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerapellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoapellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.PrimernombreDataGridViewTextBoxColumn, Me.SegundonombreDataGridViewTextBoxColumn, Me.PrimerapellidoDataGridViewTextBoxColumn, Me.SegundoapellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ClienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(968, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimernombreDataGridViewTextBoxColumn
        '
        Me.PrimernombreDataGridViewTextBoxColumn.DataPropertyName = "primer_nombre"
        Me.PrimernombreDataGridViewTextBoxColumn.HeaderText = "primer_nombre"
        Me.PrimernombreDataGridViewTextBoxColumn.Name = "PrimernombreDataGridViewTextBoxColumn"
        '
        'SegundonombreDataGridViewTextBoxColumn
        '
        Me.SegundonombreDataGridViewTextBoxColumn.DataPropertyName = "segundo_nombre"
        Me.SegundonombreDataGridViewTextBoxColumn.HeaderText = "segundo_nombre"
        Me.SegundonombreDataGridViewTextBoxColumn.Name = "SegundonombreDataGridViewTextBoxColumn"
        '
        'PrimerapellidoDataGridViewTextBoxColumn
        '
        Me.PrimerapellidoDataGridViewTextBoxColumn.DataPropertyName = "primer_apellido"
        Me.PrimerapellidoDataGridViewTextBoxColumn.HeaderText = "primer_apellido"
        Me.PrimerapellidoDataGridViewTextBoxColumn.Name = "PrimerapellidoDataGridViewTextBoxColumn"
        '
        'SegundoapellidoDataGridViewTextBoxColumn
        '
        Me.SegundoapellidoDataGridViewTextBoxColumn.DataPropertyName = "segundo_apellido"
        Me.SegundoapellidoDataGridViewTextBoxColumn.HeaderText = "segundo_apellido"
        Me.SegundoapellidoDataGridViewTextBoxColumn.Name = "SegundoapellidoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimernombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundonombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerapellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoapellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
