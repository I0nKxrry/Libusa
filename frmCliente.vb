Public Class frmCliente
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLibusaDataSet)

    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajustar MaxLength antes de llenar para evitar ConstraintException
        Try
            If Me.DBLibusaDataSet IsNot Nothing AndAlso Me.DBLibusaDataSet.Cliente IsNot Nothing Then
                Dim col = Me.DBLibusaDataSet.Cliente.Columns("TipoCliente")
                If col IsNot Nothing Then
                    col.MaxLength = 50 ' ajustar según la longitud real en la BD
                End If
            End If

            Me.ClienteTableAdapter.Fill(Me.DBLibusaDataSet.Cliente)

            ' Limpiar errores de fila para que no se muestren en pantalla
            For Each r As System.Data.DataRow In Me.DBLibusaDataSet.Cliente.Rows
                If r.HasErrors Then r.ClearErrors()
            Next
        Catch ex As Exception
            ' Registrar el error si se desea, pero no mostrarlo al usuario
            ' Ejemplo: Debug.WriteLine(ex.ToString())
        End Try

    End Sub
End Class