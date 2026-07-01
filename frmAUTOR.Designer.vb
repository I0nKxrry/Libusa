<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAUTOR
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
        Dim CodigoAutorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAUTOR))
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.AutorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.AutorTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.AutorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoAutorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.AutorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoAutorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutorBindingNavigator.SuspendLayout()
        CType(Me.AutorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoAutorLabel
        '
        CodigoAutorLabel.AutoSize = True
        CodigoAutorLabel.Location = New System.Drawing.Point(81, 54)
        CodigoAutorLabel.Name = "CodigoAutorLabel"
        CodigoAutorLabel.Size = New System.Drawing.Size(88, 16)
        CodigoAutorLabel.TabIndex = 1
        CodigoAutorLabel.Text = "Codigo Autor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(81, 82)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(59, 16)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(81, 110)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(60, 16)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(81, 138)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(91, 16)
        NacionalidadLabel.TabIndex = 7
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutorBindingSource
        '
        Me.AutorBindingSource.DataMember = "Autor"
        Me.AutorBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'AutorTableAdapter
        '
        Me.AutorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccionCobranzaTableAdapter = Nothing
        Me.TableAdapterManager.AplicacionPagoTableAdapter = Nothing
        Me.TableAdapterManager.AutorTableAdapter = Me.AutorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ControlFacturaGuiaTableAdapter = Nothing
        Me.TableAdapterManager.DetalleDevolucionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleEnvioTableAdapter = Nothing
        Me.TableAdapterManager.DetalleFacturaTableAdapter = Nothing
        Me.TableAdapterManager.DetalleGuiaRemisionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleNotaDebitoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleOrdenCompraTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionClienteTableAdapter = Nothing
        Me.TableAdapterManager.DireccionClienteTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Nothing
        Me.TableAdapterManager.EditorialTableAdapter = Nothing
        Me.TableAdapterManager.FacturaEditorTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.GuiaRemisionTableAdapter = Nothing
        Me.TableAdapterManager.HistorialCobranzaTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.LibroAutorTableAdapter = Nothing
        Me.TableAdapterManager.LibroTableAdapter = Nothing
        Me.TableAdapterManager.NotaDebitoTableAdapter = Nothing
        Me.TableAdapterManager.NotaEnvioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenCompraTableAdapter = Nothing
        Me.TableAdapterManager.PagoClienteTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.PrecioEditorialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AutorBindingNavigator
        '
        Me.AutorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AutorBindingNavigator.BindingSource = Me.AutorBindingSource
        Me.AutorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AutorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AutorBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AutorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AutorBindingNavigatorSaveItem})
        Me.AutorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AutorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AutorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AutorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AutorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AutorBindingNavigator.Name = "AutorBindingNavigator"
        Me.AutorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AutorBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.AutorBindingNavigator.TabIndex = 0
        Me.AutorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'AutorBindingNavigatorSaveItem
        '
        Me.AutorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AutorBindingNavigatorSaveItem.Image = CType(resources.GetObject("AutorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AutorBindingNavigatorSaveItem.Name = "AutorBindingNavigatorSaveItem"
        Me.AutorBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.AutorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoAutorTextBox
        '
        Me.CodigoAutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorBindingSource, "CodigoAutor", True))
        Me.CodigoAutorTextBox.Location = New System.Drawing.Point(178, 51)
        Me.CodigoAutorTextBox.Name = "CodigoAutorTextBox"
        Me.CodigoAutorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoAutorTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(178, 79)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(211, 22)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(178, 107)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(211, 22)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorBindingSource, "Nacionalidad", True))
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(178, 135)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(211, 22)
        Me.NacionalidadTextBox.TabIndex = 8
        '
        'AutorDataGridView
        '
        Me.AutorDataGridView.AutoGenerateColumns = False
        Me.AutorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AutorDataGridView.DataSource = Me.AutorBindingSource
        Me.AutorDataGridView.Location = New System.Drawing.Point(96, 182)
        Me.AutorDataGridView.Name = "AutorDataGridView"
        Me.AutorDataGridView.RowHeadersWidth = 51
        Me.AutorDataGridView.RowTemplate.Height = 24
        Me.AutorDataGridView.Size = New System.Drawing.Size(552, 220)
        Me.AutorDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoAutor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoAutor"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nacionalidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nacionalidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'frmAUTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 493)
        Me.Controls.Add(Me.AutorDataGridView)
        Me.Controls.Add(CodigoAutorLabel)
        Me.Controls.Add(Me.CodigoAutorTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadTextBox)
        Me.Controls.Add(Me.AutorBindingNavigator)
        Me.Name = "frmAUTOR"
        Me.Text = "frmAUTOR"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutorBindingNavigator.ResumeLayout(False)
        Me.AutorBindingNavigator.PerformLayout()
        CType(Me.AutorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents AutorBindingSource As BindingSource
    Friend WithEvents AutorTableAdapter As DBLibusaDataSetTableAdapters.AutorTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutorBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AutorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoAutorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NacionalidadTextBox As TextBox
    Friend WithEvents AutorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
