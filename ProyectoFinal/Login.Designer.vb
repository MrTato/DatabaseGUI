<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.MaskedTextBoxPassword = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ProyectoFinal.DataSet()
        Me.UsuarioTableAdapter = New ProyectoFinal.DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal.DataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 435)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 180)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MaskedTextBoxPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxUsuario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelPassword)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonAccept)
        Me.SplitContainer1.Size = New System.Drawing.Size(422, 180)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 5
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(48, 26)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(85, 20)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "ID Usuario"
        '
        'MaskedTextBoxPassword
        '
        Me.MaskedTextBoxPassword.Location = New System.Drawing.Point(151, 76)
        Me.MaskedTextBoxPassword.Name = "MaskedTextBoxPassword"
        Me.MaskedTextBoxPassword.Size = New System.Drawing.Size(219, 20)
        Me.MaskedTextBoxPassword.TabIndex = 4
        Me.MaskedTextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsuario.Location = New System.Drawing.Point(151, 26)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(219, 13)
        Me.TextBoxUsuario.TabIndex = 1
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(85, 74)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(48, 20)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Clave"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonCancel.Location = New System.Drawing.Point(347, 0)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 52)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonAccept.Location = New System.Drawing.Point(0, 0)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(75, 52)
        Me.ButtonAccept.TabIndex = 0
        Me.ButtonAccept.Text = "Aceptar"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources._51FNMU3MwkL__SX425_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(422, 426)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 618)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_FacturaTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.LastIDFacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 618)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MaskedTextBoxPassword As MaskedTextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
End Class
