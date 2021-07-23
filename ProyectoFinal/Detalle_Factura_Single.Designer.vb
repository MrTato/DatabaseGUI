<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Factura_Single
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.IdProductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ProyectoFinal.DataSet()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_FacturaTableAdapter = New ProyectoFinal.DataSetTableAdapters.Detalle_FacturaTableAdapter()
        Me.ProductoTableAdapter = New ProyectoFinal.DataSetTableAdapters.ProductoTableAdapter()
        Me.LastIDFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LastIDFacturaTableAdapter = New ProyectoFinal.DataSetTableAdapters.LastIDFacturaTableAdapter()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New ProyectoFinal.DataSetTableAdapters.FacturaTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastIDFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 24)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Detalle"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ProductoBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(462, 106)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(444, 434)
        Me.DataGridView2.TabIndex = 71
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleFacturaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(444, 434)
        Me.DataGridView1.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Subtotal"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(344, 54)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 66
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(750, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "Terminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(669, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(588, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Producto"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(163, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 20)
        Me.TextBox2.TabIndex = 60
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 20)
        Me.TextBox1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Detalle de Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Factura"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(12, 54)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(69, 20)
        Me.TextBox4.TabIndex = 74
        '
        'IdProductoDataGridViewTextBoxColumn1
        '
        Me.IdProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn1.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn1.Name = "IdProductoDataGridViewTextBoxColumn1"
        Me.IdProductoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "Detalle_Factura"
        Me.DetalleFacturaBindingSource.DataSource = Me.DataSet
        '
        'Detalle_FacturaTableAdapter
        '
        Me.Detalle_FacturaTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'LastIDFacturaBindingSource
        '
        Me.LastIDFacturaBindingSource.DataMember = "LastIDFactura"
        Me.LastIDFacturaBindingSource.DataSource = Me.DataSet
        '
        'LastIDFacturaTableAdapter
        '
        Me.LastIDFacturaTableAdapter.ClearBeforeFill = True
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(831, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 76
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Detalle_Factura_Single
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 607)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Detalle_Factura_Single"
        Me.ShowIcon = False
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastIDFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As DataSet
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents Detalle_FacturaTableAdapter As DataSetTableAdapters.Detalle_FacturaTableAdapter
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LastIDFacturaBindingSource As BindingSource
    Friend WithEvents LastIDFacturaTableAdapter As DataSetTableAdapters.LastIDFacturaTableAdapter
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As DataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents Button4 As Button
End Class
