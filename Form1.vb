Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ObjAutor As New frmAUTOR
        ObjAutor.MdiParent = Me
        ObjAutor.show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim objcliente As New frmCliente
        objcliente.MdiParent = Me
        objcliente.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim objlibro As New frmLibro
        objlibro.MdiParent = Me
        objlibro.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim objeditorial As New frmEditorial
        objeditorial.MdiParent = Me
        objeditorial.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim objdireccion As New frmDireccion
        objdireccion.MdiParent = Me
        objdireccion.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Dim objprecioEditorial As New frmPrecioEditorial
        objprecioEditorial.MdiParent = Me
        objprecioEditorial.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Dim ObjVenta As New frmVentas
        ObjVenta.MdiParent = Me
        ObjVenta.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.LayoutMdi(0)
    End Sub
End Class
