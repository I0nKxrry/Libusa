Public Class frmLibro
    Private Sub LibroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LibroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LibroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBLibusaDataSet.Libro' Puede moverla o quitarla según sea necesario.
        Me.LibroTableAdapter.Fill(Me.DBLibusaDataSet.Libro)

    End Sub
End Class