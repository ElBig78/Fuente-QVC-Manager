Public Class FrmArticuloListado
    Dim ObjCrud As ClassCRUD
    Dim Query As String
    Dim dTableProducto As New DataTable
    Dim CodigoArticuloSeleccionado As String = ""
    Private Sub BtnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles BtnNuevoArticulo.Click
        My.Forms.FrmArticulo.ShowDialog()
        CargarProductos()
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
            CodigoArticuloSeleccionado = ""
        Catch ex As Exception
            MensajeError("No se pudo consultar el listado de artículos registrados " & ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        CodigoArticuloSeleccionado = Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, "Codigo Principal")
    End Sub
    Private Sub Modificar()
        If CodigoArticuloSeleccionado = "" Then
            MensajeInformacion("Debe seleccionar un artículo antes de realizar esta acción")
            Exit Sub
        End If
        My.Forms.FrmArticulo.CodigoArticuloSeleccionado = CodigoArticuloSeleccionado
        My.Forms.FrmArticulo.ShowDialog()
        CargarProductos()
        My.Forms.FrmArticulo.Dispose()
    End Sub

    Private Sub BtnModificarArticulo_Click(sender As Object, e As EventArgs) Handles BtnModificarArticulo.Click
        Modificar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        CodigoArticuloSeleccionado = Me.GridView1.GetRowCellDisplayText(Me.GridView1.FocusedRowHandle, "Codigo Principal")
        Modificar()
    End Sub

    Private Sub BtnEliminarArticulo_Click(sender As Object, e As EventArgs) Handles BtnEliminarArticulo.Click
        If CodigoArticuloSeleccionado = "" Then
            MensajeInformacion("Debe seleccionar un artículo antes de realizar esta acción")
            Exit Sub
        End If
        If MensajeConfirmacion("Confirma que dese eliminar el registro seleccionado?") = False Then
            Exit Sub
        End If
        Try
            Query = String.Format("update producto set in_esta = '{0}' where co_prin = '{1}'", "I", CodigoArticuloSeleccionado)
            If ObjCrud.CUD(Query, False) Then
                CargarProductos()
                MensajeInformacion("Artículo eliminado con éxito")
            End If
        Catch ex As Exception
            MensajeError("No se pudo eliminar el artículo seleccionado " & ex.Message)
        End Try
    End Sub
End Class