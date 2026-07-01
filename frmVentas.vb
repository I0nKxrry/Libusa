Public Class frmVentas
    Private Sub DetallePedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DetallePedidoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetallePedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
        Me.DetallePedidoTableAdapter.Fill(Me.DBLibusaDataSet.DetallePedido)

    End Sub
End Class