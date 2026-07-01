<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrecioEditorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrecioEditorial))
        Dim CodigoEditorLabel As System.Windows.Forms.Label
        Dim CodigoLibroLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLibroEditorialLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.PrecioEditorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrecioEditorialTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.PrecioEditorialTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.PrecioEditorialBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PrecioEditorialBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoEditorTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoLibroTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioLibroEditorialTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioEditorialDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoEditorLabel = New System.Windows.Forms.Label()
        CodigoLibroLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLibroEditorialLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioEditorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioEditorialBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrecioEditorialBindingNavigator.SuspendLayout()
        CType(Me.PrecioEditorialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecioEditorialBindingSource
        '
        Me.PrecioEditorialBindingSource.DataMember = "PrecioEditorial"
        Me.PrecioEditorialBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'PrecioEditorialTableAdapter
        '
        Me.PrecioEditorialTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.LibroTableAdapter = Nothing
        Me.TableAdapterManager.NotaDebitoTableAdapter = Nothing
        Me.TableAdapterManager.NotaEnvioTableAdapter = Nothing
        Me.TableAdapterManager.OrdenCompraTableAdapter = Nothing
        Me.TableAdapterManager.PagoClienteTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.PrecioEditorialTableAdapter = Me.PrecioEditorialTableAdapter
        Me.TableAdapterManager.UpdateOrder = Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrecioEditorialBindingNavigator
        '
        Me.PrecioEditorialBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrecioEditorialBindingNavigator.BindingSource = Me.PrecioEditorialBindingSource
        Me.PrecioEditorialBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PrecioEditorialBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrecioEditorialBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PrecioEditorialBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrecioEditorialBindingNavigatorSaveItem})
        Me.PrecioEditorialBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrecioEditorialBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PrecioEditorialBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PrecioEditorialBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PrecioEditorialBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PrecioEditorialBindingNavigator.Name = "PrecioEditorialBindingNavigator"
        Me.PrecioEditorialBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PrecioEditorialBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.PrecioEditorialBindingNavigator.TabIndex = 0
        Me.PrecioEditorialBindingNavigator.Text = "BindingNavigator1"
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
        'PrecioEditorialBindingNavigatorSaveItem
        '
        Me.PrecioEditorialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrecioEditorialBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrecioEditorialBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrecioEditorialBindingNavigatorSaveItem.Name = "PrecioEditorialBindingNavigatorSaveItem"
        Me.PrecioEditorialBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PrecioEditorialBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoEditorLabel
        '
        CodigoEditorLabel.AutoSize = True
        CodigoEditorLabel.Location = New System.Drawing.Point(164, 77)
        CodigoEditorLabel.Name = "CodigoEditorLabel"
        CodigoEditorLabel.Size = New System.Drawing.Size(92, 16)
        CodigoEditorLabel.TabIndex = 1
        CodigoEditorLabel.Text = "Codigo Editor:"
        '
        'CodigoEditorTextBox
        '
        Me.CodigoEditorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrecioEditorialBindingSource, "CodigoEditor", True))
        Me.CodigoEditorTextBox.Location = New System.Drawing.Point(353, 74)
        Me.CodigoEditorTextBox.Name = "CodigoEditorTextBox"
        Me.CodigoEditorTextBox.Size = New System.Drawing.Size(221, 22)
        Me.CodigoEditorTextBox.TabIndex = 2
        '
        'CodigoLibroLabel
        '
        CodigoLibroLabel.AutoSize = True
        CodigoLibroLabel.Location = New System.Drawing.Point(164, 105)
        CodigoLibroLabel.Name = "CodigoLibroLabel"
        CodigoLibroLabel.Size = New System.Drawing.Size(87, 16)
        CodigoLibroLabel.TabIndex = 3
        CodigoLibroLabel.Text = "Codigo Libro:"
        '
        'CodigoLibroTextBox
        '
        Me.CodigoLibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrecioEditorialBindingSource, "CodigoLibro", True))
        Me.CodigoLibroTextBox.Location = New System.Drawing.Point(353, 102)
        Me.CodigoLibroTextBox.Name = "CodigoLibroTextBox"
        Me.CodigoLibroTextBox.Size = New System.Drawing.Size(221, 22)
        Me.CodigoLibroTextBox.TabIndex = 4
        '
        'PrecioUnitarioLibroEditorialLabel
        '
        PrecioUnitarioLibroEditorialLabel.AutoSize = True
        PrecioUnitarioLibroEditorialLabel.Location = New System.Drawing.Point(164, 133)
        PrecioUnitarioLibroEditorialLabel.Name = "PrecioUnitarioLibroEditorialLabel"
        PrecioUnitarioLibroEditorialLabel.Size = New System.Drawing.Size(183, 16)
        PrecioUnitarioLibroEditorialLabel.TabIndex = 5
        PrecioUnitarioLibroEditorialLabel.Text = "Precio Unitario Libro Editorial:"
        '
        'PrecioUnitarioLibroEditorialTextBox
        '
        Me.PrecioUnitarioLibroEditorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrecioEditorialBindingSource, "PrecioUnitarioLibroEditorial", True))
        Me.PrecioUnitarioLibroEditorialTextBox.Location = New System.Drawing.Point(353, 130)
        Me.PrecioUnitarioLibroEditorialTextBox.Name = "PrecioUnitarioLibroEditorialTextBox"
        Me.PrecioUnitarioLibroEditorialTextBox.Size = New System.Drawing.Size(221, 22)
        Me.PrecioUnitarioLibroEditorialTextBox.TabIndex = 6
        '
        'PrecioEditorialDataGridView
        '
        Me.PrecioEditorialDataGridView.AutoGenerateColumns = False
        Me.PrecioEditorialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrecioEditorialDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PrecioEditorialDataGridView.DataSource = Me.PrecioEditorialBindingSource
        Me.PrecioEditorialDataGridView.Location = New System.Drawing.Point(112, 177)
        Me.PrecioEditorialDataGridView.Name = "PrecioEditorialDataGridView"
        Me.PrecioEditorialDataGridView.RowHeadersWidth = 51
        Me.PrecioEditorialDataGridView.RowTemplate.Height = 24
        Me.PrecioEditorialDataGridView.Size = New System.Drawing.Size(545, 220)
        Me.PrecioEditorialDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoEditor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoEditor"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnitarioLibroEditorial"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PrecioUnitarioLibroEditorial"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'frmPrecioEditorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 509)
        Me.Controls.Add(Me.PrecioEditorialDataGridView)
        Me.Controls.Add(CodigoEditorLabel)
        Me.Controls.Add(Me.CodigoEditorTextBox)
        Me.Controls.Add(CodigoLibroLabel)
        Me.Controls.Add(Me.CodigoLibroTextBox)
        Me.Controls.Add(PrecioUnitarioLibroEditorialLabel)
        Me.Controls.Add(Me.PrecioUnitarioLibroEditorialTextBox)
        Me.Controls.Add(Me.PrecioEditorialBindingNavigator)
        Me.Name = "frmPrecioEditorial"
        Me.Text = "frmPrecioEditorial"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioEditorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioEditorialBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrecioEditorialBindingNavigator.ResumeLayout(False)
        Me.PrecioEditorialBindingNavigator.PerformLayout()
        CType(Me.PrecioEditorialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents PrecioEditorialBindingSource As BindingSource
    Friend WithEvents PrecioEditorialTableAdapter As DBLibusaDataSetTableAdapters.PrecioEditorialTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrecioEditorialBindingNavigator As BindingNavigator
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
    Friend WithEvents PrecioEditorialBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoEditorTextBox As TextBox
    Friend WithEvents CodigoLibroTextBox As TextBox
    Friend WithEvents PrecioUnitarioLibroEditorialTextBox As TextBox
    Friend WithEvents PrecioEditorialDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
