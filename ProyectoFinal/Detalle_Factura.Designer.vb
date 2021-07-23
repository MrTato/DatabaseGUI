<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Factura
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
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ProyectoFinal.DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_FacturaTableAdapter = New ProyectoFinal.DataSetTableAdapters.Detalle_FacturaTableAdapter()
        Me.FacturaTableAdapter = New ProyectoFinal.DataSetTableAdapters.FacturaTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ProyectoFinal.DataSetTableAdapters.ProductoTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdFacturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleFacturaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(467, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(445, 507)
        Me.DataGridView1.TabIndex = 54
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
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Subtotal"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(333, 50)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 20)
        Me.TextBox4.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Cantidad"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(271, 50)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 20)
        Me.TextBox3.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1287, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1206, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1125, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Factura"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(90, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 20)
        Me.TextBox2.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Catálogo de Detalle"
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DataSet
        '
        'Detalle_FacturaTableAdapter
        '
        Me.Detalle_FacturaTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ProductoBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(919, 106)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(443, 507)
        Me.DataGridView3.TabIndex = 56
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(463, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 24)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Detalle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(915, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 24)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Producto"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.FacturaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(15, 106)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(446, 507)
        Me.DataGridView2.TabIndex = 60
        '
        'IdFacturaDataGridViewTextBoxColumn1
        '
        Me.IdFacturaDataGridViewTextBoxColumn1.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn1.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn1.Name = "IdFacturaDataGridViewTextBoxColumn1"
        Me.IdFacturaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Factura"
        '
        'Detalle_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 625)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
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
        Me.MinimizeBox = False
        Me.Name = "Detalle_Factura"
        Me.ShowIcon = False
        Me.Text = "Detalle_Factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
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
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As DataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
End Class
