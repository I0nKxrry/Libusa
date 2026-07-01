Public Class frmDireccion
    Private Sub DireccionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DireccionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DireccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.DBLibusaDataSet.Direccion)

    End Sub
End Class