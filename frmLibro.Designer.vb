<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibro))
        Dim CodigoLibroLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim EdicionLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.LibroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibroTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.LibroTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.LibroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LibroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoLibroTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.EdicionTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LibroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoLibroLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        EdicionLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibroBindingNavigator.SuspendLayout()
        CType(Me.LibroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibroBindingSource
        '
        Me.LibroBindingSource.DataMember = "Libro"
        Me.LibroBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'LibroTableAdapter
        '
        Me.LibroTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.LibroTableAdapter = Me.LibroTableAdapter
        Me.TableAdapterManager.NotaDebitoTableAdapter = Nothing
        Me.TableAdapterManager.NotaEnvioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenCompraTableAdapter = Nothing
        Me.TableAdapterManager.PagoClienteTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.PrecioEditorialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibroBindingNavigator
        '
        Me.LibroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibroBindingNavigator.BindingSource = Me.LibroBindingSource
        Me.LibroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibroBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.LibroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibroBindingNavigatorSaveItem})
        Me.LibroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibroBindingNavigator.Name = "LibroBindingNavigator"
        Me.LibroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibroBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.LibroBindingNavigator.TabIndex = 0
        Me.LibroBindingNavigator.Text = "BindingNavigator1"
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
        'LibroBindingNavigatorSaveItem
        '
        Me.LibroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibroBindingNavigatorSaveItem.Image = CType(resources.GetObject("LibroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LibroBindingNavigatorSaveItem.Name = "LibroBindingNavigatorSaveItem"
        Me.LibroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.LibroBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoLibroLabel
        '
        CodigoLibroLabel.AutoSize = True
        CodigoLibroLabel.Location = New System.Drawing.Point(92, 62)
        CodigoLibroLabel.Name = "CodigoLibroLabel"
        CodigoLibroLabel.Size = New System.Drawing.Size(87, 16)
        CodigoLibroLabel.TabIndex = 1
        CodigoLibroLabel.Text = "Codigo Libro:"
        '
        'CodigoLibroTextBox
        '
        Me.CodigoLibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroBindingSource, "CodigoLibro", True))
        Me.CodigoLibroTextBox.Location = New System.Drawing.Point(185, 59)
        Me.CodigoLibroTextBox.Name = "CodigoLibroTextBox"
        Me.CodigoLibroTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoLibroTextBox.TabIndex = 2
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(92, 90)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(43, 16)
        TituloLabel.TabIndex = 3
        TituloLabel.Text = "Titulo:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(185, 87)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(289, 22)
        Me.TituloTextBox.TabIndex = 4
        '
        'EdicionLabel
        '
        EdicionLabel.AutoSize = True
        EdicionLabel.Location = New System.Drawing.Point(92, 118)
        EdicionLabel.Name = "EdicionLabel"
        EdicionLabel.Size = New System.Drawing.Size(55, 16)
        EdicionLabel.TabIndex = 5
        EdicionLabel.Text = "Edicion:"
        '
        'EdicionTextBox
        '
        Me.EdicionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroBindingSource, "Edicion", True))
        Me.EdicionTextBox.Location = New System.Drawing.Point(185, 115)
        Me.EdicionTextBox.Name = "EdicionTextBox"
        Me.EdicionTextBox.Size = New System.Drawing.Size(289, 22)
        Me.EdicionTextBox.TabIndex = 6
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(92, 147)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(34, 16)
        AñoLabel.TabIndex = 7
        AñoLabel.Text = "Año:"
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibroBindingSource, "Año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(185, 143)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.AñoDateTimePicker.TabIndex = 8
        '
        'LibroDataGridView
        '
        Me.LibroDataGridView.AutoGenerateColumns = False
        Me.LibroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LibroDataGridView.DataSource = Me.LibroBindingSource
        Me.LibroDataGridView.Location = New System.Drawing.Point(77, 195)
        Me.LibroDataGridView.Name = "LibroDataGridView"
        Me.LibroDataGridView.RowHeadersWidth = 51
        Me.LibroDataGridView.RowTemplate.Height = 24
        Me.LibroDataGridView.Size = New System.Drawing.Size(557, 220)
        Me.LibroDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoLibro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoLibro"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Titulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Edicion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Edicion"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'frmLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.LibroDataGridView)
        Me.Controls.Add(CodigoLibroLabel)
        Me.Controls.Add(Me.CodigoLibroTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(EdicionLabel)
        Me.Controls.Add(Me.EdicionTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(Me.LibroBindingNavigator)
        Me.Name = "frmLibro"
        Me.Text = "frmLibro"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibroBindingNavigator.ResumeLayout(False)
        Me.LibroBindingNavigator.PerformLayout()
        CType(Me.LibroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents LibroBindingSource As BindingSource
    Friend WithEvents LibroTableAdapter As DBLibusaDataSetTableAdapters.LibroTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibroBindingNavigator As BindingNavigator
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
    Friend WithEvents LibroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoLibroTextBox As TextBox
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents EdicionTextBox As TextBox
    Friend WithEvents AñoDateTimePicker As DateTimePicker
    Friend WithEvents LibroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
