Public Class frmAUTOR
    Private Sub AutorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AutorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AutorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmAUTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.Autor' Puede moverla o quitarla según sea necesario.
        Me.AutorTableAdapter.Fill(Me.DBLibusaDataSet.Autor)

    End Sub
End Class