Public Class FrmArticuloListado
    Dim ObjCrud As ClassCRUD
    Dim Query As String
    Dim dTableProducto As New DataTable
    Private Sub BtnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles BtnNuevoArticulo.Click
        My.Forms.FrmArticulo.ShowDialog()
        My.Forms.FrmArticulo.Dispose()
    End Sub

    Private Sub FrmArticuloListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub
    Private Sub CargarProductos()
        Try
            ObjCrud = New ClassCRUD
            Query = "CALL SP_PRODUCTO_LISTAR()"
            dTableProducto = ObjCrud.Retrieve(Query)
            Me.GridControl1.DataSource = dTableProducto
            Me.GridView1.BestFitColumns()
        Catch ex As Exception
            MensajeError("No se pudo consultar el listado de artículos registrados " & ex.Message)
        End Try
    End Sub
End Class