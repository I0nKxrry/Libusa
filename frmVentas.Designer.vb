<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Dim CodigoPedidoLabel As System.Windows.Forms.Label
        Dim CodigoLibroLabel As System.Windows.Forms.Label
        Dim UnidadesSolicitadasLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLibroLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.DetallePedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallePedidoTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.DetallePedidoTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.DetallePedidoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DetallePedidoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoLibroTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesSolicitadasTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioLibroTextBox = New System.Windows.Forms.TextBox()
        Me.DetallePedidoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoPedidoLabel = New System.Windows.Forms.Label()
        CodigoLibroLabel = New System.Windows.Forms.Label()
        UnidadesSolicitadasLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLibroLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallePedidoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetallePedidoBindingNavigator.SuspendLayout()
        CType(Me.DetallePedidoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetallePedidoBindingSource
        '
        Me.DetallePedidoBindingSource.DataMember = "DetallePedido"
        Me.DetallePedidoBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'DetallePedidoTableAdapter
        '
        Me.DetallePedidoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccionCobranzaTableAdapter = Nothing
        Me.TableAdapterManager.AplicacionPagoTableAdapter = Nothing
        Me.TableAdapterManager.AutorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ControlFacturaGuiaTableAdapter = Nothing
        Me.TableAdapterManager.DetalleDevolucionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleEnvioTableAdapter = Nothing
        Me.TableAdapterManager.DetalleFacturaTableAdapter = Nothing
        Me.TableAdapterManager.DetalleGuiaRemisionTableAdapter = Nothing
        Me.TableAdapterManager.DetalleNotaDebitoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleOrdenCompraTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Me.DetallePedidoTableAdapter
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
        'DetallePedidoBindingNavigator
        '
        Me.DetallePedidoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DetallePedidoBindingNavigator.BindingSource = Me.DetallePedidoBindingSource
        Me.DetallePedidoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DetallePedidoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DetallePedidoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DetallePedidoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DetallePedidoBindingNavigatorSaveItem})
        Me.DetallePedidoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DetallePedidoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DetallePedidoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DetallePedidoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DetallePedidoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DetallePedidoBindingNavigator.Name = "DetallePedidoBindingNavigator"
        Me.DetallePedidoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DetallePedidoBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.DetallePedidoBindingNavigator.TabIndex = 0
        Me.DetallePedidoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 20)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'DetallePedidoBindingNavigatorSaveItem
        '
        Me.DetallePedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DetallePedidoBindingNavigatorSaveItem.Image = CType(resources.GetObject("DetallePedidoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DetallePedidoBindingNavigatorSaveItem.Name = "DetallePedidoBindingNavigatorSaveItem"
        Me.DetallePedidoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DetallePedidoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoPedidoLabel
        '
        CodigoPedidoLabel.AutoSize = True
        CodigoPedidoLabel.Location = New System.Drawing.Point(183, 77)
        CodigoPedidoLabel.Name = "CodigoPedidoLabel"
        CodigoPedidoLabel.Size = New System.Drawing.Size(101, 16)
        CodigoPedidoLabel.TabIndex = 1
        CodigoPedidoLabel.Text = "Codigo Pedido:"
        '
        'CodigoPedidoTextBox
        '
        Me.CodigoPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "CodigoPedido", True))
        Me.CodigoPedidoTextBox.Location = New System.Drawing.Point(328, 74)
        Me.CodigoPedidoTextBox.Name = "CodigoPedidoTextBox"
        Me.CodigoPedidoTextBox.Size = New System.Drawing.Size(205, 22)
        Me.CodigoPedidoTextBox.TabIndex = 2
        '
        'CodigoLibroLabel
        '
        CodigoLibroLabel.AutoSize = True
        CodigoLibroLabel.Location = New System.Drawing.Point(183, 105)
        CodigoLibroLabel.Name = "CodigoLibroLabel"
        CodigoLibroLabel.Size = New System.Drawing.Size(87, 16)
        CodigoLibroLabel.TabIndex = 3
        CodigoLibroLabel.Text = "Codigo Libro:"
        '
        'CodigoLibroTextBox
        '
        Me.CodigoLibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "CodigoLibro", True))
        Me.CodigoLibroTextBox.Location = New System.Drawing.Point(328, 102)
        Me.CodigoLibroTextBox.Name = "CodigoLibroTextBox"
        Me.CodigoLibroTextBox.Size = New System.Drawing.Size(205, 22)
        Me.CodigoLibroTextBox.TabIndex = 4
        '
        'UnidadesSolicitadasLabel
        '
        UnidadesSolicitadasLabel.AutoSize = True
        UnidadesSolicitadasLabel.Location = New System.Drawing.Point(183, 133)
        UnidadesSolicitadasLabel.Name = "UnidadesSolicitadasLabel"
        UnidadesSolicitadasLabel.Size = New System.Drawing.Size(139, 16)
        UnidadesSolicitadasLabel.TabIndex = 5
        UnidadesSolicitadasLabel.Text = "Unidades Solicitadas:"
        '
        'UnidadesSolicitadasTextBox
        '
        Me.UnidadesSolicitadasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "UnidadesSolicitadas", True))
        Me.UnidadesSolicitadasTextBox.Location = New System.Drawing.Point(328, 130)
        Me.UnidadesSolicitadasTextBox.Name = "UnidadesSolicitadasTextBox"
        Me.UnidadesSolicitadasTextBox.Size = New System.Drawing.Size(205, 22)
        Me.UnidadesSolicitadasTextBox.TabIndex = 6
        '
        'PrecioUnitarioLibroLabel
        '
        PrecioUnitarioLibroLabel.AutoSize = True
        PrecioUnitarioLibroLabel.Location = New System.Drawing.Point(183, 161)
        PrecioUnitarioLibroLabel.Name = "PrecioUnitarioLibroLabel"
        PrecioUnitarioLibroLabel.Size = New System.Drawing.Size(131, 16)
        PrecioUnitarioLibroLabel.TabIndex = 7
        PrecioUnitarioLibroLabel.Text = "Precio Unitario Libro:"
        '
        'PrecioUnitarioLibroTextBox
        '
        Me.PrecioUnitarioLibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "PrecioUnitarioLibro", True))
        Me.PrecioUnitarioLibroTextBox.Location = New System.Drawing.Point(328, 158)
        Me.PrecioUnitarioLibroTextBox.Name = "PrecioUnitarioLibroTextBox"
        Me.PrecioUnitarioLibroTextBox.Size = New System.Drawing.Size(205, 22)
        Me.PrecioUnitarioLibroTextBox.TabIndex = 8
        '
        'DetallePedidoDataGridView
        '
        Me.DetallePedidoDataGridView.AutoGenerateColumns = False
        Me.DetallePedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallePedidoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DetallePedidoDataGridView.DataSource = Me.DetallePedidoBindingSource
        Me.DetallePedidoDataGridView.Location = New System.Drawing.Point(108, 239)
        Me.DetallePedidoDataGridView.Name = "DetallePedidoDataGridView"
        Me.DetallePedidoDataGridView.RowHeadersWidth = 51
        Me.DetallePedidoDataGridView.RowTemplate.Height = 24
        Me.DetallePedidoDataGridView.Size = New System.Drawing.Size(622, 220)
        Me.DetallePedidoDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoPedido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoPedido"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodigoLibro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodigoLibro"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UnidadesSolicitadas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UnidadesSolicitadas"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PrecioUnitarioLibro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PrecioUnitarioLibro"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.DetallePedidoDataGridView)
        Me.Controls.Add(CodigoPedidoLabel)
        Me.Controls.Add(Me.CodigoPedidoTextBox)
        Me.Controls.Add(CodigoLibroLabel)
        Me.Controls.Add(Me.CodigoLibroTextBox)
        Me.Controls.Add(UnidadesSolicitadasLabel)
        Me.Controls.Add(Me.UnidadesSolicitadasTextBox)
        Me.Controls.Add(PrecioUnitarioLibroLabel)
        Me.Controls.Add(Me.PrecioUnitarioLibroTextBox)
        Me.Controls.Add(Me.DetallePedidoBindingNavigator)
        Me.Name = "frmVentas"
        Me.Text = "frmVentas"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallePedidoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetallePedidoBindingNavigator.ResumeLayout(False)
        Me.DetallePedidoBindingNavigator.PerformLayout()
        CType(Me.DetallePedidoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents DetallePedidoBindingSource As BindingSource
    Friend WithEvents DetallePedidoTableAdapter As DBLibusaDataSetTableAdapters.DetallePedidoTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetallePedidoBindingNavigator As BindingNavigator
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
    Friend WithEvents DetallePedidoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoPedidoTextBox As TextBox
    Friend WithEvents CodigoLibroTextBox As TextBox
    Friend WithEvents UnidadesSolicitadasTextBox As TextBox
    Friend WithEvents PrecioUnitarioLibroTextBox As TextBox
    Friend WithEvents DetallePedidoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
