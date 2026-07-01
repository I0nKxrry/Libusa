<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditorial))
        Dim CodigoEditorLabel As System.Windows.Forms.Label
        Dim NombreEditorLabel As System.Windows.Forms.Label
        Dim AceptaDevolucionLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.EditorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EditorialTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.EditorialTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.EditorialBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EditorialBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoEditorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEditorTextBox = New System.Windows.Forms.TextBox()
        Me.AceptaDevolucionCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditorialDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CodigoEditorLabel = New System.Windows.Forms.Label()
        NombreEditorLabel = New System.Windows.Forms.Label()
        AceptaDevolucionLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditorialBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditorialBindingNavigator.SuspendLayout()
        CType(Me.EditorialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EditorialBindingSource
        '
        Me.EditorialBindingSource.DataMember = "Editorial"
        Me.EditorialBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'EditorialTableAdapter
        '
        Me.EditorialTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EditorialTableAdapter = Me.EditorialTableAdapter
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
        'EditorialBindingNavigator
        '
        Me.EditorialBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EditorialBindingNavigator.BindingSource = Me.EditorialBindingSource
        Me.EditorialBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EditorialBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EditorialBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EditorialBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EditorialBindingNavigatorSaveItem})
        Me.EditorialBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EditorialBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EditorialBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EditorialBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EditorialBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EditorialBindingNavigator.Name = "EditorialBindingNavigator"
        Me.EditorialBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EditorialBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.EditorialBindingNavigator.TabIndex = 0
        Me.EditorialBindingNavigator.Text = "BindingNavigator1"
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
        'EditorialBindingNavigatorSaveItem
        '
        Me.EditorialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditorialBindingNavigatorSaveItem.Image = CType(resources.GetObject("EditorialBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EditorialBindingNavigatorSaveItem.Name = "EditorialBindingNavigatorSaveItem"
        Me.EditorialBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EditorialBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoEditorLabel
        '
        CodigoEditorLabel.AutoSize = True
        CodigoEditorLabel.Location = New System.Drawing.Point(93, 35)
        CodigoEditorLabel.Name = "CodigoEditorLabel"
        CodigoEditorLabel.Size = New System.Drawing.Size(92, 16)
        CodigoEditorLabel.TabIndex = 1
        CodigoEditorLabel.Text = "Codigo Editor:"
        '
        'CodigoEditorTextBox
        '
        Me.CodigoEditorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditorialBindingSource, "CodigoEditor", True))
        Me.CodigoEditorTextBox.Location = New System.Drawing.Point(223, 32)
        Me.CodigoEditorTextBox.Name = "CodigoEditorTextBox"
        Me.CodigoEditorTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CodigoEditorTextBox.TabIndex = 2
        '
        'NombreEditorLabel
        '
        NombreEditorLabel.AutoSize = True
        NombreEditorLabel.Location = New System.Drawing.Point(93, 63)
        NombreEditorLabel.Name = "NombreEditorLabel"
        NombreEditorLabel.Size = New System.Drawing.Size(97, 16)
        NombreEditorLabel.TabIndex = 3
        NombreEditorLabel.Text = "Nombre Editor:"
        '
        'NombreEditorTextBox
        '
        Me.NombreEditorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EditorialBindingSource, "NombreEditor", True))
        Me.NombreEditorTextBox.Location = New System.Drawing.Point(223, 60)
        Me.NombreEditorTextBox.Name = "NombreEditorTextBox"
        Me.NombreEditorTextBox.Size = New System.Drawing.Size(104, 22)
        Me.NombreEditorTextBox.TabIndex = 4
        '
        'AceptaDevolucionLabel
        '
        AceptaDevolucionLabel.AutoSize = True
        AceptaDevolucionLabel.Location = New System.Drawing.Point(93, 93)
        AceptaDevolucionLabel.Name = "AceptaDevolucionLabel"
        AceptaDevolucionLabel.Size = New System.Drawing.Size(124, 16)
        AceptaDevolucionLabel.TabIndex = 5
        AceptaDevolucionLabel.Text = "Acepta Devolucion:"
        '
        'AceptaDevolucionCheckBox
        '
        Me.AceptaDevolucionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EditorialBindingSource, "AceptaDevolucion", True))
        Me.AceptaDevolucionCheckBox.Location = New System.Drawing.Point(223, 88)
        Me.AceptaDevolucionCheckBox.Name = "AceptaDevolucionCheckBox"
        Me.AceptaDevolucionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AceptaDevolucionCheckBox.TabIndex = 6
        Me.AceptaDevolucionCheckBox.Text = "CheckBox1"
        Me.AceptaDevolucionCheckBox.UseVisualStyleBackColor = True
        '
        'EditorialDataGridView
        '
        Me.EditorialDataGridView.AutoGenerateColumns = False
        Me.EditorialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EditorialDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.EditorialDataGridView.DataSource = Me.EditorialBindingSource
        Me.EditorialDataGridView.Location = New System.Drawing.Point(61, 135)
        Me.EditorialDataGridView.Name = "EditorialDataGridView"
        Me.EditorialDataGridView.RowHeadersWidth = 51
        Me.EditorialDataGridView.RowTemplate.Height = 24
        Me.EditorialDataGridView.Size = New System.Drawing.Size(434, 220)
        Me.EditorialDataGridView.TabIndex = 7
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreEditor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreEditor"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "AceptaDevolucion"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "AceptaDevolucion"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'frmEditorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditorialDataGridView)
        Me.Controls.Add(CodigoEditorLabel)
        Me.Controls.Add(Me.CodigoEditorTextBox)
        Me.Controls.Add(NombreEditorLabel)
        Me.Controls.Add(Me.NombreEditorTextBox)
        Me.Controls.Add(AceptaDevolucionLabel)
        Me.Controls.Add(Me.AceptaDevolucionCheckBox)
        Me.Controls.Add(Me.EditorialBindingNavigator)
        Me.Name = "frmEditorial"
        Me.Text = "frmEditorial"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditorialBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditorialBindingNavigator.ResumeLayout(False)
        Me.EditorialBindingNavigator.PerformLayout()
        CType(Me.EditorialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents EditorialBindingSource As BindingSource
    Friend WithEvents EditorialTableAdapter As DBLibusaDataSetTableAdapters.EditorialTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EditorialBindingNavigator As BindingNavigator
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
    Friend WithEvents EditorialBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoEditorTextBox As TextBox
    Friend WithEvents NombreEditorTextBox As TextBox
    Friend WithEvents AceptaDevolucionCheckBox As CheckBox
    Friend WithEvents EditorialDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
