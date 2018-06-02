Public Class FrmMovimientoInventario
    Dim Query As String = ""
    Dim ObjCrud As ClassCRUD
    Dim TotalMovimiento As Decimal = 0
    Dim dTableArticulosMovimiento As New DataTable
    Private Sub CmbTipoMovimiento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTipoMovimiento.SelectionChangeCommitted
        If CmbTipoMovimiento.SelectedIndex = 0 Then
            Me.CmbBodegaDestino.Enabled = True
            Me.CmbBodegaOrigen.Enabled = False
        ElseIf CmbTipoMovimiento.SelectedIndex = 1 Then
            Me.CmbBodegaDestino.Enabled = False
            Me.CmbBodegaOrigen.Enabled = True
        ElseIf CmbTipoMovimiento.SelectedIndex = 2 Then
            Me.CmbBodegaDestino.Enabled = True
            Me.CmbBodegaOrigen.Enabled = True
        Else
            Me.CmbBodegaDestino.Enabled = False
            Me.CmbBodegaOrigen.Enabled = False
        End If
    End Sub

    Private Sub FrmMovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBodegas()
    End Sub
    Private Sub CargarBodegas()
        Try
            Dim dTableOrigen As New DataTable
            Dim dTableDestino As New DataTable
            ObjCrud = New ClassCRUD
            Query = "select co_regi Codigo, ds_cort_bode Nombre from bodega where co_regi > 0 order by ds_cort_bode"
            dTableOrigen = ObjCrud.Retrieve(Query)
            dTableDestino = dTableOrigen.Copy
            CmbBodegaOrigen.DataSource = dTableOrigen
            CmbBodegaOrigen.DisplayMember = "Nombre"
            CmbBodegaOrigen.ValueMember = "Codigo"

            CmbBodegaDestino.DataSource = dTableDestino
            CmbBodegaDestino.DisplayMember = "Nombre"
            CmbBodegaDestino.ValueMember = "Codigo"
        Catch ex As Exception
            MensajeError("No se pudo cargar la información de las Bodegas " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles BtnAgregarArticulos.Click
        If CmbTipoMovimiento.SelectedIndex = -1 Then
            MensajeInformacion("Debe seleccionar un tipo de movimiento antes de realizar esta acción")
            Exit Sub
        End If
        Try
            Dim CodigoBodega As Integer = 0
            Dim TipoMovimiento As String = CmbTipoMovimiento.Text
            If CmbTipoMovimiento.SelectedIndex = 0 Then
                CodigoBodega = CInt(CmbBodegaDestino.SelectedValue)
            ElseIf CmbTipoMovimiento.SelectedIndex = 1 Or CmbTipoMovimiento.SelectedIndex = 2 Then
                CodigoBodega = CInt(CmbBodegaOrigen.SelectedValue)
            End If
            Dim dTable As New DataTable
            My.Forms.FrmMovimientoInventarioSeleccionaArticulo.TipoMovimiento = TipoMovimiento
            My.Forms.FrmMovimientoInventarioSeleccionaArticulo.CodigoBodega = CodigoBodega
            My.Forms.FrmMovimientoInventarioSeleccionaArticulo.ShowDialog()
            dTable = My.Forms.FrmMovimientoInventarioSeleccionaArticulo.dTableAuxi
            If dTable.Rows.Count > 0 Then
                Me.GridControl1.DataSource = Nothing
                If dTableArticulosMovimiento.Rows.Count = 0 Then
                    dTableArticulosMovimiento = dTable
                Else
                    'AGREGAR LOS NUEVOS ARTICULOS
                    Dim dRow As DataRow
                    Dim dRow2 As DataRow
                    For i As Integer = 0 To dTable.Rows.Count - 1
                        dRow = dTable.Rows(i)
                        If ValidaExiste(dRow(0).ToString) = False Then
                            dRow2 = dTableArticulosMovimiento.NewRow
                            dRow2(0) = dRow(0)
                            dRow2(1) = dRow(1)
                            dRow2(2) = dRow(2)
                            dRow2(3) = dRow(3)
                            dRow2(4) = dRow(4)
                            dRow2(5) = dRow(5)
                            dTableArticulosMovimiento.Rows.Add(dRow2)
                        End If
                    Next
                End If
                Me.GridControl1.DataSource = dTableArticulosMovimiento
                Me.GridView1.Columns(5).Visible = False
                TotalMovimiento = CDec(dTableArticulosMovimiento.Compute("Sum(Total)", "Total > 0").ToString)
                LblTotal.Text = Format(TotalMovimiento, "currency")
            End If
            My.Forms.FrmMovimientoInventarioSeleccionaArticulo.Dispose()
        Catch ex As Exception
            MensajeError("No se pudo agregar los artículos seleccionados " & ex.Message)
        End Try
    End Sub
    Private Function ValidaExiste(ByVal Codigo As String) As Boolean
        ValidaExiste = False
        Dim dRow As DataRow
        For i As Integer = 0 To dTableArticulosMovimiento.Rows.Count - 1
            dRow = dTableArticulosMovimiento.Rows(i)
            If dRow(0).ToString = Codigo Then
                ValidaExiste = True
                Exit For
            End If
        Next
    End Function

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If GridView1.RowCount = 0 Then
            MensajeError("Debe seleccionar artículos antes de realizar esta acción")
            Exit Sub
        End If
        If CmbTipoMovimiento.SelectedIndex = -1 Then
            MensajeError("Debe seleccionar un tipo de movimiento antes de realizar esta acción")
            Exit Sub
        End If
        If CmbTipoMovimiento.SelectedIndex = 2 Then
            If CInt(CmbBodegaOrigen.SelectedValue) = CInt(CmbBodegaDestino.SelectedValue) Then
                MensajeError("En el tipo de movimiento transferencia la Bodega de Orígen y la Bodega de Destino deben ser diferentes")
                Exit Sub
            End If
        End If
        Dim Mensaje As String
        Mensaje = "Confirma que desea registrar un " & CmbTipoMovimiento.Text & " a la bodega "
        If CmbTipoMovimiento.SelectedIndex = 0 Then
            Mensaje = Mensaje & CmbBodegaDestino.GetItemText(CmbBodegaDestino.SelectedItem)
        ElseIf CmbTipoMovimiento.SelectedIndex = 1 Then
            Mensaje = Mensaje & CmbBodegaOrigen.GetItemText(CmbBodegaOrigen.SelectedItem)
        Else
            Mensaje = "Confirma que desea registrar una " & CmbTipoMovimiento.Text & " desde la bodega " & CmbBodegaOrigen.GetItemText(CmbBodegaOrigen.SelectedItem) & " hacia la bodega " & CmbBodegaDestino.GetItemText(CmbBodegaDestino.SelectedItem)
        End If
        If MensajeConfirmacion(Mensaje) = False Then
            Exit Sub
        End If
        Grabar()
    End Sub
    Private Sub Grabar()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class