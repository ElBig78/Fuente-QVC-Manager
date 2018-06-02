Public Class FrmArticulo
    Dim ObjCrud As ClassCRUD
    Dim Query As String = ""
    Public CodigoArticuloSeleccionado As String = "0"
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
        LblTitulo.Text = "Creando artículo"
        If CodigoArticuloSeleccionado <> "0" Then
            LblTitulo.Text = "Modificando artículo"
            ConsultarDatosArticulo()
        End If
    End Sub
    Private Sub ConsultarDatosArticulo()
        Try
            Dim dTable As New DataTable
            Dim dTablePrecios As New DataTable
            Dim drow As DataRow
            Query = String.Format("select * from producto where co_prin = '{0}'", CodigoArticuloSeleccionado)
            dTable = ObjCrud.Retrieve(Query)
            drow = dTable.Rows(0)
            Me.TxtCodigoPrincipal.Text = drow(0).ToString
            Me.TxtCodigoAuxiliar.Text = drow(1).ToString
            Me.CmbTipoProducto.SelectedIndex = CInt(IIf(drow(2).ToString = "B", 0, 1))
            Me.TxtNombreCorto.Text = drow(3).ToString
            Me.TxtNombreLargo.Text = drow(4).ToString
            Me.CmbMarca.SelectedValue = CInt(drow(5).ToString)
            Me.CmbCategoria.SelectedValue = CInt(drow(6).ToString)
            FiltrarSubCategoria()
            Me.CmbSubcategoria.SelectedValue = CInt(drow(7).ToString)
            Me.TxtCosto.Text = drow(8).ToString
            Me.CmbCntaInventario.SelectedValue = CInt(drow(11).ToString)
            Me.CmbCntaCosto.SelectedValue = CInt(drow(12).ToString)
            Me.CmbCntaVenta.SelectedValue = CInt(drow(13).ToString)
            Me.CmbIce.SelectedValue = CInt(drow(15).ToString)
            Me.CmbIva.SelectedValue = CInt(drow(16).ToString)
            Me.TxtStockMinimo.Text = drow(17).ToString
            Me.TxtStockMaximo.Text = drow(18).ToString
            Query = String.Format("select co_prec, mo_prec from producto_precio where co_prod = '{0}'", TxtCodigoPrincipal.Text)
            dTablePrecios = ObjCrud.Retrieve(Query)
            For i As Integer = 0 To dTablePrecios.Rows.Count - 1
                drow = dTablePrecios.Rows(i)
                If CInt(drow(0).ToString) = 1 Then
                    Me.TxtPrecio1.Text = drow(1).ToString
                ElseIf CInt(drow(0).ToString) = 2 Then
                    Me.TxtPrecio2.Text = drow(1).ToString
                ElseIf CInt(drow(0).ToString) = 3 Then
                    Me.TxtPrecio3.Text = drow(1).ToString
                ElseIf CInt(drow(0).ToString) = 4 Then
                    Me.TxtPrecio4.Text = drow(1).ToString
                ElseIf CInt(drow(0).ToString) = 5 Then
                    Me.TxtPrecio5.Text = drow(1).ToString
                ElseIf CInt(drow(0).ToString) = 6 Then
                    Me.TxtPrecio6.Text = drow(1).ToString
                End If
            Next
            TxtCodigoPrincipal.Enabled = False
        Catch ex As Exception
            MensajeError("No se pudo cargar la información del artículo seleccionado " & ex.Message)
        End Try
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

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Grabar()
    End Sub
    Private Function ValidaGrabar() As Boolean
        ValidaGrabar = True
        If TxtCodigoPrincipal.Text = "" Then
            MensajeError("Código Principal no puede estar vacío")
            TxtCodigoPrincipal.Focus()
            ValidaGrabar = False
            Exit Function
        ElseIf TxtNombreCorto.Text = "" Then
            MensajeError("Nombre corto no puede estar vacío")
            TxtNombreCorto.Focus()
            ValidaGrabar = False
            Exit Function
        ElseIf TxtPrecio1.Text = "0.00" Or CInt(TxtPrecio1.Text) = 0 Or TxtPrecio1.Text = "" Then
            MensajeError("Precio1 debe ser mayor a 0.00")
            TxtPrecio1.Focus()
            ValidaGrabar = False
            Exit Function
        End If
    End Function
    Private Sub Grabar()
        If ValidaGrabar() = False Then
            Exit Sub
        End If
        Dim dTable As New DataTable
        Dim QueryAuxi As String = ""
        Dim drow As DataRow
        If MensajeConfirmacion("Confirma que los datos están correctos?") = False Then
            Exit Sub
        End If
        Try
            If CodigoArticuloSeleccionado = "0" Then
                Query = String.Format("select count(*) from producto where co_prin = '{0}'", TxtCodigoPrincipal.Text)
                dTable = ObjCrud.Retrieve(Query)
                drow = dTable.Rows(0)
                If CInt(drow(0).ToString) > 0 Then
                    MensajeError("El código que intenta ingresar ya existe")
                    Exit Sub
                End If
            End If
            Query = String.Format("CALL SP_PRODUCTO_GRABAR_DESK('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8},'{9}','{10}','{11}','{12}','{13}','{14}',{15},{16},{17},{18})",
                                  TxtCodigoPrincipal.Text, TxtCodigoAuxiliar.Text, IIf(CmbTipoProducto.SelectedIndex = 0, "B", "S"), TxtNombreCorto.Text, TxtNombreLargo.Text,
                                  CmbMarca.SelectedValue, CmbCategoria.SelectedValue, CmbSubcategoria.SelectedValue, CDec(TxtCosto.Text), "A", "", CmbCntaInventario.SelectedValue,
                                  CmbCntaCosto.SelectedValue, CmbCntaVenta.SelectedValue, Now.ToString("yyyy-MM-dd"), CmbIce.SelectedValue, CmbIva.SelectedValue, TxtStockMinimo.Text, TxtStockMaximo.Text)
            'GRABAR EN TABLA PRECIOS
            QueryAuxi = String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 1, CDec(TxtPrecio1.Text), CDec(TxtPrecio1.Text))
            If TxtPrecio2.Text <> "0.00" And CInt(TxtPrecio2.Text) > 0 And TxtPrecio2.Text <> "" Then
                QueryAuxi = QueryAuxi & ";" & String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 2, CDec(TxtPrecio2.Text), CDec(TxtPrecio2.Text))
            End If
            If TxtPrecio3.Text <> "0.00" And CInt(TxtPrecio3.Text) > 0 And TxtPrecio3.Text <> "" Then
                QueryAuxi = QueryAuxi & ";" & String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 3, CDec(TxtPrecio3.Text), CDec(TxtPrecio3.Text))
            End If
            If TxtPrecio4.Text <> "0.00" And CInt(TxtPrecio4.Text) > 0 And TxtPrecio4.Text <> "" Then
                QueryAuxi = QueryAuxi & ";" & String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 4, CDec(TxtPrecio4.Text), CDec(TxtPrecio4.Text))
            End If
            If TxtPrecio5.Text <> "0.00" And CInt(TxtPrecio5.Text) > 0 And TxtPrecio5.Text <> "" Then
                QueryAuxi = QueryAuxi & ";" & String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 5, CDec(TxtPrecio5.Text), CDec(TxtPrecio5.Text))
            End If
            If TxtPrecio6.Text <> "0.00" And CInt(TxtPrecio6.Text) > 0 And TxtPrecio6.Text <> "" Then
                QueryAuxi = QueryAuxi & ";" & String.Format("insert into producto_precio(co_prod,co_prec,mo_prec) values('{0}',{1},{2}) on duplicate key update mo_prec = {3}", TxtCodigoPrincipal.Text, 6, CDec(TxtPrecio6.Text), CDec(TxtPrecio6.Text))
            End If
            If ObjCrud.CUD(Query, False) Then
                If ObjCrud.CUD(QueryAuxi, False) Then
                    If CodigoArticuloSeleccionado = "0" Then
                        QueryAuxi = String.Format("INSERT INTO producto_bodega 
                                               SELECT co_regi, '{0}', 0 
                                               FROM bodega where co_regi > 0", TxtCodigoPrincipal.Text)
                        If ObjCrud.CUD(QueryAuxi, False) Then
                            MensajeInformacion("Proceso realizado correctamente")
                        End If
                    Else
                        MensajeInformacion("Proceso realizado correctamente")
                    End If
                    LimpiarControles()
                End If
            End If
        Catch ex As Exception
            MensajeError("No se pudo realizar la acción solicitada")
        End Try
    End Sub
    Private Sub LimpiarControles()
        CodigoArticuloSeleccionado = "0"
        TxtCodigoAuxiliar.Clear()
        TxtCodigoPrincipal.Clear()
        TxtNombreCorto.Clear()
        TxtNombreLargo.Clear()
        TxtCosto.Text = "0.00"
        TxtStockMinimo.Text = "0"
        TxtStockMaximo.Text = "0"
        TxtPrecio1.Text = "0.00"
        TxtPrecio2.Text = "0.00"
        TxtPrecio3.Text = "0.00"
        TxtPrecio4.Text = "0.00"
        TxtPrecio5.Text = "0.00"
        TxtPrecio6.Text = "0.00"
        TxtCodigoPrincipal.Enabled = True
        TxtCodigoPrincipal.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If MensajeConfirmacion("Confirma que desea cancelar?") = False Then
            Exit Sub
        End If
        LimpiarControles()
    End Sub
End Class