Imports System.Net.Mail
Imports System.IO

'
' Created by SharpDevelop.
' User: jvinces
' Date: 24/04/2013
' Time: 15:36
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module Module1
    Private Declare Ansi Function GetPrivateProfileString _
                   Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
                         (ByVal lpApplicationName As String, _
                         ByVal lpKeyName As String, ByVal lpDefault As String, _
                         ByVal lpReturnedString As String, _
                         ByVal nSize As Integer, ByVal lpFileName As String) _
                         As Integer
    Private Declare Ansi Function WritePrivateProfileString _
           Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
           (ByVal lpApplicationName As String, _
           ByVal lpKeyName As String, ByVal lpString As String, _
           ByVal lpFileName As String) As Integer

#Region "Variables Imprime Tickets"
    'PARA IMPRIMIR TICKETS
    Public Const GENERIC_WRITE = &H40000000
    Public Const OPEN_EXISTING = 3
    Public Const FILE_SHARE_WRITE = &H2
    Public LPTPORT As String
    Public hPort As Integer, hPortP As IntPtr
    Public retval As Integer

    Public Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer

    Public Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Integer) As Integer

    Public Structure SECURITY_ATTRIBUTES
        Private nLength As Integer
        Private lpSecurityDescriptor As Integer
        Private bInheritHandle As Integer
    End Structure
#End Region

#Region "Variables Facturacion Electronica"
    Public ambiente As Integer = 0
    'Public ciudad As String = "Guayaquil"
    'Public telefonoEmpresa As String = "042625878"
    Public tipoEmision As Integer = 1
    Public RazonSocialEmpresa As String = ""
    Public NombreComercial As String = ""
    Public RucEmpresa As String = ""
    Public ContribuyenteEspecial As String = ""
    Public ObligadoContabilidad As String = ""
    Public CodigoEstablecimiento As String = ""
    Public CodigoPuntoEmision As String = ""
    'Public serie As String = "001001"
    'Public codigoNumerico As String = "54235879"
    Public digitoVerificador As String = ""
    Public claveAcceso As String = ""
    'Public codDoc As String = "01"
    'Public estab As String = "001"
    'Public ptoEmi As String = "002"
    'Public secuencial As String = ""
    Public DirMatriz As String = ""
    Public DirSucursal As String = ""
    Public RutaArchivoP12 As String = Application.StartupPath & "\cert.p12"
    Public ClaveArchivoP12 As String = ""
    Public RutaBase As String = Application.StartupPath
    Public RutaGenerados As String = ""
    Public RutaFirmados As String = ""
    Public RutaAutorizados As String = ""
    Public RutaNoAutorizados As String = ""
    Public URLRecepcionProduccion As String = ""
    Public URLRecepcionPrueba As String = ""
    Public URLAutorizacionProduccion As String = ""
    Public URLAutorizacionPrueba As String = ""
#End Region


    Public CoUsua As Integer = 1
    Public NoUsua As String = ""
    Public CoRol As Integer = 0
    Public CadenaConexion As String = ""
    Public CadenaConexionAccess As String = ""
    Public vgBase As String = "contabilidad_qvcec"
    Public dbname As String = vgBase
    Public dbhost As String = "160.153.16.63"
    Public user As String = "jquir"
    Public pass As String = "Romanos2412"
    Public UsarServidorLocal As Boolean = False

    Public CodigoCiudad As String = ""

    Public ImpresoraTPV As String
    Public ImpresoraComanda As String
    Public LineasBlancoIniciaTicket As Int16 = 0
    Public LineasBlancoTerminaTicket As Int16 = 0
    Public MensajeFinal As String = ""
    Public InversoIVA As Decimal = 0
    Public PorcIVA As Decimal = 12

    Public ProductosPorTicket As Integer = 10
    Public PuertoEnviaCorreo As Integer = 0
    Public ServidorSmtp As String = ""
    Public CorreoEnvia As String = ""
    Public ClaveCorreoEnvia As String = ""
    Public UtilizaSSL As Boolean = True
    Public TituloAsuntoCorreo As String = ""
    Public ContenidoCorreo As String = ""
    Public RutaImagenAdjunto As String = ""
    Public RutaArchivoHTML As String = ""
    Public ContenidoHTML As String = ""

    Public Sub Mensajes(ByVal Tipo As String, ByVal Mensaje As String)
        'If Tipo = "Error" Then
        '    My.Forms.FrmMensaje.BackColor = Color.Red
        '    My.Forms.FrmMensaje.LblMensaje.ForeColor = Color.White
        'ElseIf Tipo = "Informacion" Then
        '    My.Forms.FrmMensaje.BackColor = Color.Green
        '    My.Forms.FrmMensaje.LblMensaje.ForeColor = Color.White
        'ElseIf Tipo = "Advertencia" Then
        '    My.Forms.FrmMensaje.BackColor = Color.Gold
        '    My.Forms.FrmMensaje.LblMensaje.ForeColor = Color.White
        'End If
        'My.Forms.FrmMensaje.LblMensaje.Text = Mensaje
        'My.Forms.FrmMensaje.ShowDialog()
    End Sub

    Public Function XMLtoByte(ByVal RutaArchivoXML As String) As Byte()
        Dim fs As FileStream = File.OpenRead(RutaArchivoXML)
        Dim bytes As Byte() = ReadWholeArray(fs)
        Return bytes
        'Dim sw As StreamWriter = New StreamWriter("C:\fnew.XML")
        'Dim write As String = System.Text.Encoding.[Default].GetString(bytes)
        'sw.Write(write)
        'sw.Close()
    End Function

    Public Function ReadWholeArray(ByVal stream As Stream) As Byte()
        Dim data As Byte() = New Byte(stream.Length - 1) {}
        Dim offset As Integer = 0
        Dim remaining As Integer = data.Length
        While remaining > 0
            Dim read As Integer = stream.Read(data, offset, remaining)
            If read <= 0 Then Throw New EndOfStreamException(String.Format("End of stream reached with {0} bytes left to read", remaining))
            remaining -= read
            offset += read
        End While

        Return data
    End Function




    Public Function UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String) As Boolean
        UploadFile = False
        Dim _FileInfo As New System.IO.FileInfo(_FileName)
        ' Create FtpWebRequest object from the Uri provided
        Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)
        ' Provide the WebPermission Credintials
        _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)
        ' By default KeepAlive is true, where the control connection is not closed
        ' after a command is executed.
        _FtpWebRequest.KeepAlive = False
        ' set timeout for 20 seconds
        _FtpWebRequest.Timeout = 20000
        ' Specify the command to be executed.
        _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile
        ' Specify the data transfer type.
        _FtpWebRequest.UseBinary = True
        ' Notify the server about the size of the uploaded file
        _FtpWebRequest.ContentLength = _FileInfo.Length
        ' The buffer size is set to 2kb
        Dim buffLength As Integer = 2048
        Dim buff(buffLength - 1) As Byte
        ' Opens a file stream (System.IO.FileStream) to read the file to be uploaded
        Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()
        Try
            ' Stream to which the file to be upload is written
            Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()
            ' Read from the file stream 2kb at a time
            Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)
            ' Till Stream content ends
            Do While contentLen <> 0
                ' Write Content from the file stream to the FTP Upload Stream
                _Stream.Write(buff, 0, contentLen)
                contentLen = _FileStream.Read(buff, 0, buffLength)
            Loop
            ' Close the file stream and the Request Stream
            _Stream.Close()
            _Stream.Dispose()
            _FileStream.Close()
            _FileStream.Dispose()
            UploadFile = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Public Sub MensajeNormal()
        MessageBox.Show("La acción fue realizada con éxito", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MensajeError(ByVal Mensaje As String)
        MessageBox.Show("Ha Ocurrido el siguiente Error " & Mensaje, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Public Sub MensajeInformacion(ByVal Mensaje As String)
        MessageBox.Show(Mensaje, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function DigitoMod11(ByVal Cadena As String) As String
        Dim DigitoVerificador As String = ""
        Dim CadenaInvertida As String = ""
        Dim CantidadTotal As Integer = 0
        Dim Temporal As Integer = 0
        Dim Pivote As Integer = 2
        Dim Longitud As Integer = Cadena.Length
        For i As Integer = Longitud - 1 To 0 Step -1
            CadenaInvertida = CadenaInvertida + Cadena.Substring(i, 1)
        Next
        For i As Integer = 0 To Longitud - 1
            If Pivote = 8 Then
                Pivote = 2
            End If
            Temporal = Integer.Parse(CadenaInvertida.Substring(i, 1)) * Pivote
            CantidadTotal = CantidadTotal + Temporal
            Pivote = Pivote + 1
        Next
        DigitoVerificador = 11 - (CantidadTotal Mod 11)
        If DigitoVerificador = 11 Then
            DigitoVerificador = 0
        ElseIf DigitoVerificador = 10 Then
            DigitoVerificador = 1
        End If
        Return DigitoVerificador
    End Function


    Public Function MensajeConfirmacion(ByVal Mensaje As String) As Boolean
        Dim Respuesta As Boolean = False
        If MessageBox.Show(Mensaje, "Administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Respuesta = True
        Else
            Respuesta = False
        End If
        Return Respuesta
    End Function
    Public Function IsReal(ByVal Number As Integer) As Integer
        Dim i As Integer
        i = -1 'Fail
        If (Number / 1) = (Number \ 1) Then
            i = 0 'Integer
        Else
            i = 1 'Real
        End If
        Return i
    End Function
    Public Sub LlenarListView(ByVal Lview As ListView, ByVal Table As DataTable)
        Try
            With Lview
                .Items.Clear()
                '.Columns.Clear()
                .View = View.Details
                '.GridLines = True
                .FullRowSelect = True
            End With
            ' Añadir los registros de la tabla   
            With Table
                For f As Integer = 0 To .Rows.Count - 1
                    Dim dato As New ListViewItem(.Rows(f).Item(0).ToString)
                    ' recorrer las columnas   
                    For c As Integer = 1 To .Columns.Count - 1
                        dato.SubItems.Add(.Rows(f).Item(c).ToString())
                    Next
                    Lview.Items.Add(dato)
                Next
            End With
        Catch ex As Exception
            MensajeError("No se pudieron cargar datos en el ListView " & ex.Message)
        End Try
    End Sub
    Public Function EnviaCorreo(Destinatario As String, ByVal ArchivoXML As String, ByVal ArchivoPDF As String) As Boolean
        EnviaCorreo = False
        Dim msg As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
        'BarraProgreso.Value = 5
        msg.To.Add(Destinatario)
        'SI SE DESEA AGREGAR MAS DESTINATARIOS**********************
        'msg.To.Add("you@yourcompany.com")
        'msg.To.Add("you2@yourcompany.com")
        'msg.CC.Add("cc1@yourcompany.com")
        'msg.CC.Add("cc2@yourcompany.com")
        'msg.Bcc.Add("blindcc1@yourcompany.com")
        'msg.Bcc.Add("blindcc2@yourcompany.com")
        '***********************************************************
        'BarraProgreso.Value = 10
        msg.From = New MailAddress(CorreoEnvia, "Sistema de Facturación Electrónica ", System.Text.Encoding.UTF8)
        msg.Subject = TituloAsuntoCorreo
        msg.SubjectEncoding = System.Text.Encoding.UTF8
        'BarraProgreso.Value = 24
        msg.Body = ContenidoCorreo
        msg.BodyEncoding = System.Text.Encoding.UTF8
        'BarraProgreso.Value = 43
        msg.IsBodyHtml = False
        'Aquí es donde se hace lo especial
        Dim client As New SmtpClient()
        'If RutaArchivoHTML <> "" Then
        '    Dim reader As StreamReader
        '    reader = File.OpenText(RutaArchivoHTML)
        '    msg.Body = reader.ReadToEnd()
        '    reader.Close()
        '    msg.IsBodyHtml = True
        'Else
        '    msg.Body = ContenidoCorreo
        'End If

        'PARA ADJUNTAR ARCHIVOS********************************
        msg.Attachments.Add(New Attachment(ArchivoXML))
        msg.Attachments.Add(New Attachment(ArchivoPDF))
        '******************************************************

        'specify the priority of the mail message
        'msg.ReplyTo = New MailAddress("SomeOtherAddress@mycompany.com")


        'BarraProgreso.Value = 59
        client.Credentials = New System.Net.NetworkCredential(CorreoEnvia, ClaveCorreoEnvia)
        client.Port = PuertoEnviaCorreo
        'BarraProgreso.Value = 70
        client.Host = ServidorSmtp
        client.EnableSsl = UtilizaSSL 'Esto es para que vaya a través de SSL que es obligatorio con GMail
        Try
            'BarraProgreso.Value = 80
            client.Send(msg)
            'BarraProgreso.Value = 100
            'MensajeInformacion("Correo Enviado Satisfactoriamente ")
            EnviaCorreo = True
            RutaImagenAdjunto = ""
            'BarraProgreso.Value = 0
        Catch ex As System.Net.Mail.SmtpException
            MsgBox("Ocurrio un error por favor intente de nuevo" & ex.Message)
        End Try
    End Function
    Public Sub colorearListView(ByRef LView As ListView)
        Dim i As Integer
        For i = 0 To LView.Items.Count - 1
            If i = Int(i / 2) * 2 Then
                LView.Items.Item(i).BackColor = Color.White
            Else
                LView.Items.Item(i).BackColor = Color.LightBlue
            End If
        Next
        LView.FullRowSelect = True
    End Sub
    Public Sub colorearTareasTerminadas(ByRef LView As ListView)
        Dim i As Integer
        For i = 0 To LView.Items.Count - 1
            If LView.Items(i).SubItems(4).Text = "False" Then
                LView.Items.Item(i).BackColor = Color.LightPink
            End If
        Next
        LView.FullRowSelect = True
    End Sub
    Function EliminarCaracteresEspeciales(ByVal s As String, ByVal filtro As String) As String
        Dim i As Integer, t As New System.Text.StringBuilder(s)
        For i = 0 To filtro.Length() - 1
            t.Replace(filtro.Substring(i, 1), " ")
        Next
        Return t.ToString
    End Function
    Public Function LeerIni(ByVal strKey As String, Optional ByVal strSection As String = "Settings") As String
        LeerIni = ""
        Try
            Dim strValue As String
            'Dim intPos As Integer = 0
            strValue = Space(1024)
            GetPrivateProfileString(strSection, strKey, "NOT_FOUND", strValue, 1024, "C:\Windows\System32\SIS.ini")
            Do While InStrRev(strValue, " ") = Len(strValue)
                strValue = Mid(strValue, 1, Len(strValue) - 1)
            Loop
            ' to remove a special chr in the last place
            strValue = Mid(strValue, 1, Len(strValue) - 1)
            LeerIni = strValue
        Catch ex As Exception
            MensajeError("Error form Fucntions.GetIniSettings " & Err.Description)
        End Try
    End Function
    Public Sub EscribirIni(ByVal strKey As String, ByVal strValue As String, Optional ByVal strSection As String = "settings")
        Try
            'Dim intPos As Integer = 0
            WritePrivateProfileString(strSection, strKey, strValue, "C:\Windows\System32\SIS.ini")
        Catch ex As Exception
            MensajeError("Error form Fucntions.GetIniSettings " & Err.Description)
        End Try
    End Sub
    Public Sub EstiloDataGridView(ByVal dgridview As DataGridView)
        dgridview.GridColor = Color.Red
        dgridview.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgridview.BackgroundColor = Color.White

        dgridview.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        dgridview.DefaultCellStyle.SelectionForeColor = Color.White

        'dgridview.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
        dgridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        dgridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgridview.AllowUserToResizeColumns = False
        dgridview.AllowUserToDeleteRows = False
        dgridview.AllowUserToAddRows = False
        dgridview.AllowUserToOrderColumns = False
        dgridview.EditMode = DataGridViewEditMode.EditProgrammatically
        dgridview.MultiSelect = False

        dgridview.RowsDefaultCellStyle.BackColor = Color.LightCyan
        dgridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
    End Sub
    Public Function imageToByteArray(ByVal imageIn As System.Drawing.Image, ByVal pformato As System.Drawing.Imaging.ImageFormat) As Byte()
        Dim ms As New IO.MemoryStream
        Try
            imageIn.Save(ms, pformato)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error " & ex.Message)
        End Try
        Return ms.ToArray()
    End Function
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim returnImage As Image = Nothing
        Try
            Dim ms As New IO.MemoryStream(byteArrayIn)
            returnImage = Image.FromStream(ms)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error " & ex.Message)
        End Try
        Return returnImage
    End Function
    Public Function ObjectToByteArray(ByVal _Object As Object) As Byte()
        Try
            ' create new memory stream
            Dim _MemoryStream As New System.IO.MemoryStream()
            ' create new BinaryFormatter
            Dim _BinaryFormatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            ' Serializes an object, or graph of connected objects, to the given stream.
            _BinaryFormatter.Serialize(_MemoryStream, _Object)
            ' convert stream to byte array and return
            Return _MemoryStream.ToArray()
        Catch _Exception As Exception
            ' Error
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try
        ' Error occured, return null
        Return Nothing
    End Function
End Module
