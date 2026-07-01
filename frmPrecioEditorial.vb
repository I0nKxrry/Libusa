Public Class frmPrecioEditorial
    Private Sub PrecioEditorialBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PrecioEditorialBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PrecioEditorialBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmPrecioEditorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.PrecioEditorial' Puede moverla o quitarla según sea necesario.
        Me.PrecioEditorialTableAdapter.Fill(Me.DBLibusaDataSet.PrecioEditorial)

    End Sub
End Class