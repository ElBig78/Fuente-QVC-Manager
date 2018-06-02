Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Partial Public Class FrmMain
    Dim ObjCrud As ClassCRUD
    Dim Query As String = ""
    Dim dTableModulo As New DataTable
    Dim dTableOpcion As New DataTable
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ribbonControl1.Images = ImageList1
        CargarModulos()
    End Sub
    Private Sub CargarModulos()
        Try
            Dim dset As New DataSet
            Dim page As RibbonPage
            Dim item As BarButtonItem
            Dim dRow As DataRow
            Dim dRow2 As DataRow
            Dim dView As DataView
            ObjCrud = New ClassCRUD
            Query = "select * from desk_modulo; select * from desk_modulo_opcion"
            dset = ObjCrud.RetrieveDataset(Query)
            dTableModulo = dset.Tables(0)
            dTableOpcion = dset.Tables(1)
            dView = dTableOpcion.DefaultView
            For i As Integer = 0 To dTableModulo.Rows.Count - 1
                dRow = dTableModulo.Rows(i)
                page = New RibbonPage(dRow("ds_modu").ToString)
                dView.RowFilter = "co_modu = " & dRow("co_modu").ToString
                Dim group As New RibbonPageGroup("Opciones")
                For j As Integer = 0 To dView.ToTable.Rows.Count - 1
                    dRow2 = dView.ToTable.Rows(j)
                    item = Ribbon.Items.CreateButton(dRow2("ds_opci").ToString)
                    item.ImageIndex = 0
                    item.Id = Ribbon.Manager.GetNewItemId() 'Ensures correct runtime layout (de)serialization.
                    item.Name = dRow2("ds_nomb_form").ToString
                    'If dRow2("ds_nomb_form").ToString <> "" Then
                    '    MsgBox(item.Name)
                    'End If
                    AddHandler item.ItemClick, AddressOf item_ItemClick
                    group.ItemLinks.Add(item)
                Next
                page.Groups.Add(group)
                ribbonControl1.Pages.Add(page)
            Next
        Catch ex As Exception
            MensajeError("No se pudo cargar la información de los módulos " & ex.Message)
        End Try
    End Sub
    Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        '...
        If e.Link.Caption = "ARTICULO" Then
            My.Forms.FrmArticuloListado.MdiParent = Me
            My.Forms.FrmArticuloListado.Show()
        ElseIf e.Link.Caption = "MOVIMIENTO DE INVENTARIO" Then
            'My.Forms.FrmMovimientoInventario.MdiParent = Me
            My.Forms.FrmMovimientoInventario.Show()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub
End Class
