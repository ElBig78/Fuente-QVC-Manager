Public Class ClassCRUD
    Dim ObjData As ClassDataPhp
    Dim Query As String
    Public Function CUD(ByVal Query As String, ByVal MostrarMensaje As Boolean) As Boolean
        CUD = False
        Try
            ObjData = New ClassDataPhp
            If ObjData.Grabar(Query) Then
                CUD = True
                If MostrarMensaje Then
                    Mensajes("Informacion", "Acción realizada correctamente")
                End If
            End If
        Catch ex As Exception
            Mensajes("Error", "No se pudo realizar la acción " & ex.Message)
        End Try
    End Function
    Public Function DevuelveMaxId(ByVal Campo As String, ByVal Tabla As String, Optional ByVal Inner As String = "") As Integer
        DevuelveMaxId = 0
        Try
            Dim dTable As New DataTable
            Dim drow As DataRow
            ObjData = New ClassDataPhp
            dTable = Nothing
            Query = "select IFNULL(max(" & Campo & "),0) from " & Tabla & Inner
            dTable = ObjData.CargarDatatable(Query)
            drow = dTable.Rows(0)
            DevuelveMaxId = CInt(drow(0))
        Catch ex As Exception
            Mensajes("Error", "No se pudo obtener el valor máximo del registro " & ex.Message)
        End Try
    End Function
    Public Function Retrieve(ByVal Query As String) As DataTable
        Dim dTable As New DataTable
        dTable = Nothing
        Try
            ObjData = New ClassDataPhp
            dTable = ObjData.CargarDatatable(Query)
        Catch ex As Exception
            Mensajes("Error", "No se pudo consultar el servidor " & ex.Message)
        End Try
        Return dTable
    End Function
    Public Function RetrieveDataset(ByVal Query As String) As DataSet
        Dim ds As New DataSet
        Try
            ObjData = New ClassDataPhp
            ds = ObjData.CargarDataSet(Query)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error al tratar de acceder a la Base de Datos " & ex.Message)
        End Try
        Return ds
    End Function
End Class
