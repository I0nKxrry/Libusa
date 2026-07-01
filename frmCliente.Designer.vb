<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim TipoClienteLabel As System.Windows.Forms.Label
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim TelefonoClienteLabel As System.Windows.Forms.Label
        Dim CorreoClienteLabel As System.Windows.Forms.Label
        Dim CreditoDisponibleLabel As System.Windows.Forms.Label
        Dim EstadoClienteLabel As System.Windows.Forms.Label
        Dim FechaFinInhabilitacionLabel As System.Windows.Forms.Label
        Me.DBLibusaDataSet = New Libusa.DBLibusaDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Libusa.DBLibusaDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New Libusa.DBLibusaDataSetTableAdapters.TableAdapterManager()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TipoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.CreditoDisponibleTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFinInhabilitacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoClienteLabel = New System.Windows.Forms.Label()
        TipoClienteLabel = New System.Windows.Forms.Label()
        NombreClienteLabel = New System.Windows.Forms.Label()
        TelefonoClienteLabel = New System.Windows.Forms.Label()
        CorreoClienteLabel = New System.Windows.Forms.Label()
        CreditoDisponibleLabel = New System.Windows.Forms.Label()
        EstadoClienteLabel = New System.Windows.Forms.Label()
        FechaFinInhabilitacionLabel = New System.Windows.Forms.Label()
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBLibusaDataSet
        '
        Me.DBLibusaDataSet.DataSetName = "DBLibusaDataSet"
        Me.DBLibusaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DBLibusaDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccionCobranzaTableAdapter = Nothing
        Me.TableAdapterManager.AplicacionPagoTableAdapter = Nothing
        Me.TableAdapterManager.AutorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
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
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(973, 27)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(93, 62)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(98, 16)
        CodigoClienteLabel.TabIndex = 1
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CodigoCliente", True))
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(249, 59)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoClienteTextBox.TabIndex = 2
        '
        'TipoClienteLabel
        '
        TipoClienteLabel.AutoSize = True
        TipoClienteLabel.Location = New System.Drawing.Point(93, 90)
        TipoClienteLabel.Name = "TipoClienteLabel"
        TipoClienteLabel.Size = New System.Drawing.Size(82, 16)
        TipoClienteLabel.TabIndex = 3
        TipoClienteLabel.Text = "Tipo Cliente:"
        '
        'TipoClienteTextBox
        '
        Me.TipoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "TipoCliente", True))
        Me.TipoClienteTextBox.Location = New System.Drawing.Point(249, 87)
        Me.TipoClienteTextBox.Name = "TipoClienteTextBox"
        Me.TipoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TipoClienteTextBox.TabIndex = 4
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Location = New System.Drawing.Point(93, 118)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(103, 16)
        NombreClienteLabel.TabIndex = 5
        NombreClienteLabel.Text = "Nombre Cliente:"
        '
        'NombreClienteTextBox
        '
        Me.NombreClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "NombreCliente", True))
        Me.NombreClienteTextBox.Location = New System.Drawing.Point(249, 115)
        Me.NombreClienteTextBox.Name = "NombreClienteTextBox"
        Me.NombreClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreClienteTextBox.TabIndex = 6
        '
        'TelefonoClienteLabel
        '
        TelefonoClienteLabel.AutoSize = True
        TelefonoClienteLabel.Location = New System.Drawing.Point(93, 146)
        TelefonoClienteLabel.Name = "TelefonoClienteLabel"
        TelefonoClienteLabel.Size = New System.Drawing.Size(108, 16)
        TelefonoClienteLabel.TabIndex = 7
        TelefonoClienteLabel.Text = "Telefono Cliente:"
        '
        'TelefonoClienteTextBox
        '
        Me.TelefonoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "TelefonoCliente", True))
        Me.TelefonoClienteTextBox.Location = New System.Drawing.Point(249, 143)
        Me.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox"
        Me.TelefonoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoClienteTextBox.TabIndex = 8
        '
        'CorreoClienteLabel
        '
        CorreoClienteLabel.AutoSize = True
        CorreoClienteLabel.Location = New System.Drawing.Point(93, 174)
        CorreoClienteLabel.Name = "CorreoClienteLabel"
        CorreoClienteLabel.Size = New System.Drawing.Size(95, 16)
        CorreoClienteLabel.TabIndex = 9
        CorreoClienteLabel.Text = "Correo Cliente:"
        '
        'CorreoClienteTextBox
        '
        Me.CorreoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CorreoCliente", True))
        Me.CorreoClienteTextBox.Location = New System.Drawing.Point(249, 171)
        Me.CorreoClienteTextBox.Name = "CorreoClienteTextBox"
        Me.CorreoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CorreoClienteTextBox.TabIndex = 10
        '
        'CreditoDisponibleLabel
        '
        CreditoDisponibleLabel.AutoSize = True
        CreditoDisponibleLabel.Location = New System.Drawing.Point(93, 202)
        CreditoDisponibleLabel.Name = "CreditoDisponibleLabel"
        CreditoDisponibleLabel.Size = New System.Drawing.Size(121, 16)
        CreditoDisponibleLabel.TabIndex = 11
        CreditoDisponibleLabel.Text = "Credito Disponible:"
        '
        'CreditoDisponibleTextBox
        '
        Me.CreditoDisponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CreditoDisponible", True))
        Me.CreditoDisponibleTextBox.Location = New System.Drawing.Point(249, 199)
        Me.CreditoDisponibleTextBox.Name = "CreditoDisponibleTextBox"
        Me.CreditoDisponibleTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CreditoDisponibleTextBox.TabIndex = 12
        '
        'EstadoClienteLabel
        '
        EstadoClienteLabel.AutoSize = True
        EstadoClienteLabel.Location = New System.Drawing.Point(93, 230)
        EstadoClienteLabel.Name = "EstadoClienteLabel"
        EstadoClienteLabel.Size = New System.Drawing.Size(97, 16)
        EstadoClienteLabel.TabIndex = 13
        EstadoClienteLabel.Text = "Estado Cliente:"
        '
        'EstadoClienteTextBox
        '
        Me.EstadoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "EstadoCliente", True))
        Me.EstadoClienteTextBox.Location = New System.Drawing.Point(249, 227)
        Me.EstadoClienteTextBox.Name = "EstadoClienteTextBox"
        Me.EstadoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EstadoClienteTextBox.TabIndex = 14
        '
        'FechaFinInhabilitacionLabel
        '
        FechaFinInhabilitacionLabel.AutoSize = True
        FechaFinInhabilitacionLabel.Location = New System.Drawing.Point(93, 259)
        FechaFinInhabilitacionLabel.Name = "FechaFinInhabilitacionLabel"
        FechaFinInhabilitacionLabel.Size = New System.Drawing.Size(150, 16)
        FechaFinInhabilitacionLabel.TabIndex = 15
        FechaFinInhabilitacionLabel.Text = "Fecha Fin Inhabilitacion:"
        '
        'FechaFinInhabilitacionDateTimePicker
        '
        Me.FechaFinInhabilitacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "FechaFinInhabilitacion", True))
        Me.FechaFinInhabilitacionDateTimePicker.Location = New System.Drawing.Point(249, 255)
        Me.FechaFinInhabilitacionDateTimePicker.Name = "FechaFinInhabilitacionDateTimePicker"
        Me.FechaFinInhabilitacionDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaFinInhabilitacionDateTimePicker.TabIndex = 16
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(67, 283)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowHeadersWidth = 51
        Me.ClienteDataGridView.RowTemplate.Height = 24
        Me.ClienteDataGridView.Size = New System.Drawing.Size(807, 151)
        Me.ClienteDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoCliente"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TipoCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoCliente"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombreCliente"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TelefonoCliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TelefonoCliente"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CreditoDisponible"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CreditoDisponible"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaFinInhabilitacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaFinInhabilitacion"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 598)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(TipoClienteLabel)
        Me.Controls.Add(Me.TipoClienteTextBox)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteTextBox)
        Me.Controls.Add(TelefonoClienteLabel)
        Me.Controls.Add(Me.TelefonoClienteTextBox)
        Me.Controls.Add(CorreoClienteLabel)
        Me.Controls.Add(Me.CorreoClienteTextBox)
        Me.Controls.Add(CreditoDisponibleLabel)
        Me.Controls.Add(Me.CreditoDisponibleTextBox)
        Me.Controls.Add(EstadoClienteLabel)
        Me.Controls.Add(Me.EstadoClienteTextBox)
        Me.Controls.Add(FechaFinInhabilitacionLabel)
        Me.Controls.Add(Me.FechaFinInhabilitacionDateTimePicker)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Name = "frmCliente"
        Me.Text = "frmCliente"
        CType(Me.DBLibusaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBLibusaDataSet As DBLibusaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DBLibusaDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As DBLibusaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As BindingNavigator
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
    Friend WithEvents ClienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoClienteTextBox As TextBox
    Friend WithEvents TipoClienteTextBox As TextBox
    Friend WithEvents NombreClienteTextBox As TextBox
    Friend WithEvents TelefonoClienteTextBox As TextBox
    Friend WithEvents CorreoClienteTextBox As TextBox
    Friend WithEvents CreditoDisponibleTextBox As TextBox
    Friend WithEvents EstadoClienteTextBox As TextBox
    Friend WithEvents FechaFinInhabilitacionDateTimePicker As DateTimePicker
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
