Public Class FrmArticulo
    Dim ObjCrud As ClassCRUD
    Dim Query As String = ""
    Public CodigoArticuloSeleccionado As String = ""
    Dim dTableCuentaInventario As New DataTable
    Dim dTableCuentaCosto As New DataTable
    Dim dTableCuentaVenta As New DataTable
    Dim dTableIce As New DataTable
    Dim dTableTipoIVA As New DataTable
    Dim dTableMarca As New DataTable
    Dim dTableCategoria As New DataTable
    Dim dTableSubCategoria As New DataTable
    Dim dViewSubCategoria As DataView
    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCuentasContables()
        CargarComboMarca()
        CargarCategoriaSubCategoria()
        CmbTipoProducto.SelectedIndex = 0
    End Sub
    Private Sub CargarComboMarca()
        Try
            Query = "CALL SP_MARCA_CARGAR_COMBO()"
            dTableMarca = ObjCrud.Retrieve(Query)
            CmbMarca.DataSource = dTableMarca
            CmbMarca.DisplayMember = "Nombre"
            CmbMarca.ValueMember = "Codigo"
        Catch ex As Exception
            MensajeError("No se pudo cargar la información de marcas " & ex.Message)
        End Try
    End Sub
    Private Sub FiltrarSubCategoria()
        Try
            dViewSubCategoria = dTableSubCategoria.DefaultView
            dViewSubCategoria.RowFilter = "co_cate = " & CmbCategoria.SelectedValue.ToString
            CmbSubcategoria.DataSource = dViewSubCategoria.ToTable
            CmbSubcategoria.DisplayMember = "Nombre"
            CmbSubcategoria.ValueMember = "Codigo"
        Catch ex As Exception
            MensajeError("No se pudo cargar el combo de subcategorias " & ex.Message)
        End Try
    End Sub
    Private Sub CargarCategoriaSubCategoria()
        Try
            Dim dSet As New DataSet
            Query = "CALL SP_CATEGORIA_SUBCATEGORIA_COMBOS()"
            dSet = ObjCrud.RetrieveDataset(Query)
            dTableCategoria = dSet.Tables(0)
            dTableSubCategoria = dSet.Tables(1)
            CmbCategoria.DataSource = dTableCategoria
            CmbCategoria.DisplayMember = "Nombre"
            CmbCategoria.ValueMember = "Codigo"
            FiltrarSubCategoria()
        Catch ex As Exception
            MensajeError("No se pudo cargar la información de categorías " & ex.Message)
        End Try
    End Sub
    Private Sub CargarCuentasContables()
        Try
            ObjCrud = New ClassCRUD
            Dim dSet As New DataSet
            Query = "CALL SP_PRODUCTO_CUENTAS_CONTABLES_LISTAR()"
            dSet = ObjCrud.RetrieveDataset(Query)
            dTableCuentaInventario = dSet.Tables(0)
            dTableCuentaCosto = dSet.Tables(1)
            dTableCuentaVenta = dSet.Tables(2)
            dTableIce = dSet.Tables(3)
            dTableTipoIVA = dSet.Tables(4)

            CmbCntaInventario.DataSource = dTableCuentaInventario
            CmbCntaInventario.DisplayMember = "Cuenta"
            CmbCntaInventario.ValueMember = "Codigo"

            CmbCntaCosto.DataSource = dTableCuentaCosto
            CmbCntaCosto.DisplayMember = "Cuenta"
            CmbCntaCosto.ValueMember = "Codigo"

            CmbCntaVenta.DataSource = dTableCuentaVenta
            CmbCntaVenta.DisplayMember = "Cuenta"
            CmbCntaVenta.ValueMember = "Codigo"

            CmbIce.DataSource = dTableIce
            CmbIce.DisplayMember = "Nombre"
            CmbIce.ValueMember = "Codigo"
            CmbIce.SelectedValue = 0

            CmbIva.DataSource = dTableTipoIVA
            CmbIva.DisplayMember = "Nombre"
            CmbIva.ValueMember = "Codigo"

        Catch ex As Exception
            MensajeError("No se pudo cargar las cuentas contables de artículos " & ex.Message)
        End Try
    End Sub

    Private Sub CmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCategoria.SelectionChangeCommitted
        FiltrarSubCategoria()
    End Sub
End Class