Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class ClassDataPhp
    Dim dbCon As MySqlConnection
    'Dim dbname As String = "qvc_restaurant"
    'Dim dbhost As String = "160.153.16.63"
    'Dim user As String = "jquir"
    'Dim pass As String = "Apocalipsis24"
    'Dim dbname As String = vgBase
    'Dim dbhost As String = dbhost
    'Dim user As String = user
    'Dim pass As String = pass

    Public Sub ManageConnection()
        Try
            'Prepare connection and query'
            dbCon = New MySqlConnection(String.Format("server={0}; user id={1}; password={2}; database={3}; Port=3306", dbhost, user, pass, vgBase))
            If dbCon.State = ConnectionState.Closed Then
                dbCon.Open()
            Else
                dbCon.Close()
            End If
        Catch ex As Exception
            MensajeError("Falló la conexión")
        End Try
    End Sub
    Public Function Grabar(ByVal Query As String) As Boolean
        Dim cmd As New MySqlCommand
        Dim con As New MySqlConnection
        Dim Grabo As Boolean = False
        con.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; Port=3306", dbhost, user, pass, vgBase)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = Query
        cmd.CommandTimeout = 3000
        cmd.Connection = con
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            Grabo = True
        Catch ex As MySqlException
            MessageBox.Show("Error al tratar de acceder a la Base de Datos " & ex.Message)
        End Try
        con.Close()
        Return Grabo
    End Function
    Public Function CargarDatatable(ByVal Query As String) As DataTable
        Dim dt As New DataTable
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter
        con = New MySqlConnection(String.Format("Server = {0}; Uid = {1}; Pwd = {2}; Database = {3}; Port = 3306;", dbhost, user, pass, vgBase))
        Try
            con.Open()
            da = New MySqlDataAdapter(Query, con)
            da.Fill(dt)
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error al tratar de acceder a la Base de Datos " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function CargarDataSet(ByVal Query As String) As DataSet
        Dim ds As New DataSet
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter


        con = New MySqlConnection(String.Format("Server = {0}; Uid = {1}; Pwd = {2}; Database = {3}; Port = 3306;", dbhost, user, pass, vgBase))
        Try
            con.Open()
            da = New MySqlDataAdapter(Query, con)
            da.Fill(ds)
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error al tratar de acceder a la Base de Datos " & ex.Message)
        End Try
        Return ds
    End Function

    Public Function ConsultarDatosOtraBase(ByVal Query As String, ByVal Base As String) As DataTable
        Dim dt As New DataTable
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter
        con = New MySqlConnection(String.Format("server={0}; user id={1}; password={2}; database={3}; Port=3306", dbhost, user, pass, Base))
        Try
            con.Open()
            da = New MySqlDataAdapter(Query, con)
            da.Fill(dt)
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error al tratar de acceder a la Base de Datos " & ex.Message)
        End Try
        Return dt
    End Function
    Public Sub CargarCombo(ByVal Combo As ComboBox, ByVal Query As String, ByVal Tabla As String)
        Try
            Dim dTable As New DataTable
            dTable = CargarDatatable(Query)
            If dTable.Rows.Count = 0 Then
                MensajeInformacion("No existe información de " & Tabla)
                Exit Sub
            End If
            Combo.DataSource = dTable
            Combo.DisplayMember = "Descripcion"
            Combo.ValueMember = "Codigo"
        Catch ex As Exception
            MensajeError("No se pudo llenar combo de " & Tabla & " " & ex.Message)
        End Try
    End Sub
End Class
