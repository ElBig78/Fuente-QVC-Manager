
Public Class FrmMovimientoInventarioSeleccionaArticulo
    Dim Query As String = ""
    Dim ObjCrud As ClassCRUD
    Dim dTableArticulos As New DataTable
    Public dTableAuxi As New DataTable
    Dim dView As DataView
    Public CodigoBodega As Integer = 0
    Public TipoMovimiento As String = ""
    Private Sub FrmMovimientoInventarioSeleccionaArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarArticulos()
    End Sub
    Private Sub CargarArticulos()
        Try
            ObjCrud = New ClassCRUD
            Query = String.Format("select a.co_prin Codigo, a.ds_desc_cort Nombre, a.mo_cost Costo, 1 Cantidad, 0.00 Total,
                     ifnull((select nu_stock 
                            from producto_bodega x 
                            where x.co_bode = {0} 
                            and x.co_prod = a.co_prin),0) '{1}'
                     from producto a
                     where in_tipo_item = 'B'
                     order by ds_desc_cort", CodigoBodega, "STOCK BODEGA " & TipoMovimiento)
            dTableArticulos = ObjCrud.Retrieve(Query)
            Me.GridControl1.DataSource = dTableArticulos
            GridView1.BestFitColumns()
            GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(0).OptionsColumn.AllowEdit = False
            GridView1.Columns(1).OptionsColumn.AllowEdit = False
            GridView1.Columns(4).OptionsColumn.AllowEdit = False
        Catch ex As Exception
            MensajeError("No se pudo cargar el listado de artículos " & ex.Message)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If view Is Nothing Then
                Return
            End If
            Dim cellValue As Decimal
            If e.Column.FieldName = "Costo" Or e.Column.FieldName = "Cantidad" Then
                cellValue = CDec(view.GetRowCellValue(e.RowHandle, view.Columns("Cantidad")).ToString()) * CDec(view.GetRowCellValue(e.RowHandle, view.Columns("Costo")).ToString())
                view.SetRowCellValue(e.RowHandle, view.Columns("Total"), cellValue)
            End If
        Catch ex As Exception
            MensajeError("No se pudo calcular el Total " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        dView = dTableArticulos.DefaultView
        dView.RowFilter = "Total > 0"
        dTableAuxi = dView.ToTable
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class