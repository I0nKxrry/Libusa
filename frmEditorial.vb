Public Class frmEditorial
    Private Sub EditorialBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EditorialBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EditorialBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmEditorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.Editorial' Puede moverla o quitarla según sea necesario.
        Me.EditorialTableAdapter.Fill(Me.DBLibusaDataSet.Editorial)

    End Sub
End Class