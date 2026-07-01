<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDireccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDireccion))
        Dim CodigoDireccionLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.DireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DireccionTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.DireccionTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.DireccionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DireccionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoDireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.DistritoTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoDireccionLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        DistritoLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DireccionBindingNavigator.SuspendLayout()
        CType(Me.DireccionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DireccionBindingSource
        '
        Me.DireccionBindingSource.DataMember = "Direccion"
        Me.DireccionBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'DireccionTableAdapter
        '
        Me.DireccionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DireccionTableAdapter = Me.DireccionTableAdapter
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
        'DireccionBindingNavigator
        '
        Me.DireccionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DireccionBindingNavigator.BindingSource = Me.DireccionBindingSource
        Me.DireccionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DireccionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DireccionBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DireccionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DireccionBindingNavigatorSaveItem})
        Me.DireccionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DireccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DireccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DireccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DireccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DireccionBindingNavigator.Name = "DireccionBindingNavigator"
        Me.DireccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DireccionBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.DireccionBindingNavigator.TabIndex = 0
        Me.DireccionBindingNavigator.Text = "BindingNavigator1"
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
        'DireccionBindingNavigatorSaveItem
        '
        Me.DireccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DireccionBindingNavigatorSaveItem.Image = CType(resources.GetObject("DireccionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DireccionBindingNavigatorSaveItem.Name = "DireccionBindingNavigatorSaveItem"
        Me.DireccionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DireccionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoDireccionLabel
        '
        CodigoDireccionLabel.AutoSize = True
        CodigoDireccionLabel.Location = New System.Drawing.Point(86, 85)
        CodigoDireccionLabel.Name = "CodigoDireccionLabel"
        CodigoDireccionLabel.Size = New System.Drawing.Size(114, 16)
        CodigoDireccionLabel.TabIndex = 1
        CodigoDireccionLabel.Text = "Codigo Direccion:"
        '
        'CodigoDireccionTextBox
        '
        Me.CodigoDireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "CodigoDireccion", True))
        Me.CodigoDireccionTextBox.Location = New System.Drawing.Point(206, 82)
        Me.CodigoDireccionTextBox.Name = "CodigoDireccionTextBox"
        Me.CodigoDireccionTextBox.Size = New System.Drawing.Size(195, 22)
        Me.CodigoDireccionTextBox.TabIndex = 2
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(86, 113)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(53, 16)
        CiudadLabel.TabIndex = 3
        CiudadLabel.Text = "Ciudad:"
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(206, 110)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(195, 22)
        Me.CiudadTextBox.TabIndex = 4
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.Location = New System.Drawing.Point(86, 141)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(51, 16)
        DistritoLabel.TabIndex = 5
        DistritoLabel.Text = "Distrito:"
        '
        'DistritoTextBox
        '
        Me.DistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Distrito", True))
        Me.DistritoTextBox.Location = New System.Drawing.Point(206, 138)
        Me.DistritoTextBox.Name = "DistritoTextBox"
        Me.DistritoTextBox.Size = New System.Drawing.Size(195, 22)
        Me.DistritoTextBox.TabIndex = 6
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(86, 169)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(41, 16)
        CalleLabel.TabIndex = 7
        CalleLabel.Text = "Calle:"
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(206, 166)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(195, 22)
        Me.CalleTextBox.TabIndex = 8
        '
        'DireccionDataGridView
        '
        Me.DireccionDataGridView.AutoGenerateColumns = False
        Me.DireccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DireccionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DireccionDataGridView.DataSource = Me.DireccionBindingSource
        Me.DireccionDataGridView.Location = New System.Drawing.Point(73, 226)
        Me.DireccionDataGridView.Name = "DireccionDataGridView"
        Me.DireccionDataGridView.RowHeadersWidth = 51
        Me.DireccionDataGridView.RowTemplate.Height = 24
        Me.DireccionDataGridView.Size = New System.Drawing.Size(642, 220)
        Me.DireccionDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoDireccion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoDireccion"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Distrito"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Calle"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calle"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'frmDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.DireccionDataGridView)
        Me.Controls.Add(CodigoDireccionLabel)
        Me.Controls.Add(Me.CodigoDireccionTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(DistritoLabel)
        Me.Controls.Add(Me.DistritoTextBox)
        Me.Controls.Add(CalleLabel)
        Me.Controls.Add(Me.CalleTextBox)
        Me.Controls.Add(Me.DireccionBindingNavigator)
        Me.Name = "frmDireccion"
        Me.Text = "frmDireccion"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DireccionBindingNavigator.ResumeLayout(False)
        Me.DireccionBindingNavigator.PerformLayout()
        CType(Me.DireccionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents DireccionBindingSource As BindingSource
    Friend WithEvents DireccionTableAdapter As DBLibusaDataSetTableAdapters.DireccionTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DireccionBindingNavigator As BindingNavigator
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
    Friend WithEvents DireccionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoDireccionTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents DistritoTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents DireccionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
