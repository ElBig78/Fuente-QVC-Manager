<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbSubcategoria = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombreLargo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombreCorto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCodigoAuxiliar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigoPrincipal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStockMinimo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtStockMaximo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtPrecio4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtPrecio6 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtPrecio5 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtPrecio1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPrecio3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPrecio2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.CmbCntaVenta = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CmbCntaCosto = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CmbCntaInventario = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmbIva = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbIce = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 39)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento de Artículo"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CmbMarca)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.CmbSubcategoria)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.TxtNombreLargo)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.TxtNombreCorto)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.CmbCategoria)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.CmbTipoProducto)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TxtCodigoAuxiliar)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TxtCodigoPrincipal)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 45)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(540, 222)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos Generales"
        '
        'CmbMarca
        '
        Me.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(94, 134)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(427, 21)
        Me.CmbMarca.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Marca:"
        '
        'CmbSubcategoria
        '
        Me.CmbSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSubcategoria.FormattingEnabled = True
        Me.CmbSubcategoria.Location = New System.Drawing.Point(94, 188)
        Me.CmbSubcategoria.Name = "CmbSubcategoria"
        Me.CmbSubcategoria.Size = New System.Drawing.Size(427, 21)
        Me.CmbSubcategoria.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "SubCategoría:"
        '
        'TxtNombreLargo
        '
        Me.TxtNombreLargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreLargo.Location = New System.Drawing.Point(94, 107)
        Me.TxtNombreLargo.MaxLength = 150
        Me.TxtNombreLargo.Name = "TxtNombreLargo"
        Me.TxtNombreLargo.Size = New System.Drawing.Size(427, 21)
        Me.TxtNombreLargo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nombre Largo:"
        '
        'TxtNombreCorto
        '
        Me.TxtNombreCorto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreCorto.Location = New System.Drawing.Point(94, 80)
        Me.TxtNombreCorto.MaxLength = 50
        Me.TxtNombreCorto.Name = "TxtNombreCorto"
        Me.TxtNombreCorto.Size = New System.Drawing.Size(427, 21)
        Me.TxtNombreCorto.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre Corto:"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(94, 161)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(427, 21)
        Me.CmbCategoria.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Categoría:"
        '
        'CmbTipoProducto
        '
        Me.CmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoProducto.FormattingEnabled = True
        Me.CmbTipoProducto.Items.AddRange(New Object() {"BIEN", "SERVICIO"})
        Me.CmbTipoProducto.Location = New System.Drawing.Point(94, 53)
        Me.CmbTipoProducto.Name = "CmbTipoProducto"
        Me.CmbTipoProducto.Size = New System.Drawing.Size(427, 21)
        Me.CmbTipoProducto.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo Producto:"
        '
        'TxtCodigoAuxiliar
        '
        Me.TxtCodigoAuxiliar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoAuxiliar.Location = New System.Drawing.Point(289, 27)
        Me.TxtCodigoAuxiliar.Name = "TxtCodigoAuxiliar"
        Me.TxtCodigoAuxiliar.Size = New System.Drawing.Size(232, 21)
        Me.TxtCodigoAuxiliar.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código Auxiliar:"
        '
        'TxtCodigoPrincipal
        '
        Me.TxtCodigoPrincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoPrincipal.Location = New System.Drawing.Point(94, 26)
        Me.TxtCodigoPrincipal.Name = "TxtCodigoPrincipal"
        Me.TxtCodigoPrincipal.Size = New System.Drawing.Size(100, 21)
        Me.TxtCodigoPrincipal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código Principal:"
        '
        'TxtStockMinimo
        '
        Me.TxtStockMinimo.Location = New System.Drawing.Point(94, 56)
        Me.TxtStockMinimo.Name = "TxtStockMinimo"
        Me.TxtStockMinimo.Size = New System.Drawing.Size(100, 21)
        Me.TxtStockMinimo.TabIndex = 1
        Me.TxtStockMinimo.Text = "0"
        Me.TxtStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Stock Mínimo:"
        '
        'TxtStockMaximo
        '
        Me.TxtStockMaximo.Location = New System.Drawing.Point(94, 83)
        Me.TxtStockMaximo.Name = "TxtStockMaximo"
        Me.TxtStockMaximo.Size = New System.Drawing.Size(100, 21)
        Me.TxtStockMaximo.TabIndex = 2
        Me.TxtStockMaximo.Text = "0"
        Me.TxtStockMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Stock Máximo:"
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(94, 29)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(100, 21)
        Me.TxtCosto.TabIndex = 0
        Me.TxtCosto.Text = "0.00"
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Costo:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TxtCosto)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio4)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.Label16)
        Me.GroupControl3.Controls.Add(Me.TxtStockMaximo)
        Me.GroupControl3.Controls.Add(Me.Label11)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio6)
        Me.GroupControl3.Controls.Add(Me.TxtStockMinimo)
        Me.GroupControl3.Controls.Add(Me.Label17)
        Me.GroupControl3.Controls.Add(Me.Label10)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio5)
        Me.GroupControl3.Controls.Add(Me.Label18)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio1)
        Me.GroupControl3.Controls.Add(Me.Label13)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio3)
        Me.GroupControl3.Controls.Add(Me.Label14)
        Me.GroupControl3.Controls.Add(Me.TxtPrecio2)
        Me.GroupControl3.Controls.Add(Me.Label15)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 273)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(540, 122)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Datos de Control y Precio"
        '
        'TxtPrecio4
        '
        Me.TxtPrecio4.Location = New System.Drawing.Point(421, 29)
        Me.TxtPrecio4.Name = "TxtPrecio4"
        Me.TxtPrecio4.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio4.TabIndex = 6
        Me.TxtPrecio4.Text = "0.00"
        Me.TxtPrecio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(366, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Precio 4:"
        '
        'TxtPrecio6
        '
        Me.TxtPrecio6.Location = New System.Drawing.Point(421, 83)
        Me.TxtPrecio6.Name = "TxtPrecio6"
        Me.TxtPrecio6.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio6.TabIndex = 8
        Me.TxtPrecio6.Text = "0.00"
        Me.TxtPrecio6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Precio 6:"
        '
        'TxtPrecio5
        '
        Me.TxtPrecio5.Location = New System.Drawing.Point(421, 56)
        Me.TxtPrecio5.Name = "TxtPrecio5"
        Me.TxtPrecio5.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio5.TabIndex = 7
        Me.TxtPrecio5.Text = "0.00"
        Me.TxtPrecio5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(366, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Precio 5:"
        '
        'TxtPrecio1
        '
        Me.TxtPrecio1.Location = New System.Drawing.Point(254, 29)
        Me.TxtPrecio1.Name = "TxtPrecio1"
        Me.TxtPrecio1.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio1.TabIndex = 3
        Me.TxtPrecio1.Text = "0.00"
        Me.TxtPrecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(202, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Precio 1:"
        '
        'TxtPrecio3
        '
        Me.TxtPrecio3.Location = New System.Drawing.Point(254, 83)
        Me.TxtPrecio3.Name = "TxtPrecio3"
        Me.TxtPrecio3.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio3.TabIndex = 5
        Me.TxtPrecio3.Text = "0.00"
        Me.TxtPrecio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(202, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Precio 3:"
        '
        'TxtPrecio2
        '
        Me.TxtPrecio2.Location = New System.Drawing.Point(254, 56)
        Me.TxtPrecio2.Name = "TxtPrecio2"
        Me.TxtPrecio2.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecio2.TabIndex = 4
        Me.TxtPrecio2.Text = "0.00"
        Me.TxtPrecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(202, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Precio 2:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.CmbCntaVenta)
        Me.GroupControl2.Controls.Add(Me.Label23)
        Me.GroupControl2.Controls.Add(Me.CmbCntaCosto)
        Me.GroupControl2.Controls.Add(Me.Label21)
        Me.GroupControl2.Controls.Add(Me.CmbCntaInventario)
        Me.GroupControl2.Controls.Add(Me.Label22)
        Me.GroupControl2.Controls.Add(Me.CmbIva)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Controls.Add(Me.CmbIce)
        Me.GroupControl2.Controls.Add(Me.Label19)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 401)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(540, 178)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Datos Contables"
        '
        'CmbCntaVenta
        '
        Me.CmbCntaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCntaVenta.FormattingEnabled = True
        Me.CmbCntaVenta.Location = New System.Drawing.Point(94, 139)
        Me.CmbCntaVenta.Name = "CmbCntaVenta"
        Me.CmbCntaVenta.Size = New System.Drawing.Size(427, 21)
        Me.CmbCntaVenta.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Cta. Venta:"
        '
        'CmbCntaCosto
        '
        Me.CmbCntaCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCntaCosto.FormattingEnabled = True
        Me.CmbCntaCosto.Location = New System.Drawing.Point(94, 112)
        Me.CmbCntaCosto.Name = "CmbCntaCosto"
        Me.CmbCntaCosto.Size = New System.Drawing.Size(427, 21)
        Me.CmbCntaCosto.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Cta. Costo:"
        '
        'CmbCntaInventario
        '
        Me.CmbCntaInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCntaInventario.FormattingEnabled = True
        Me.CmbCntaInventario.Location = New System.Drawing.Point(94, 85)
        Me.CmbCntaInventario.Name = "CmbCntaInventario"
        Me.CmbCntaInventario.Size = New System.Drawing.Size(427, 21)
        Me.CmbCntaInventario.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Cta. Inventario:"
        '
        'CmbIva
        '
        Me.CmbIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIva.FormattingEnabled = True
        Me.CmbIva.Location = New System.Drawing.Point(94, 59)
        Me.CmbIva.Name = "CmbIva"
        Me.CmbIva.Size = New System.Drawing.Size(427, 21)
        Me.CmbIva.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "IVA:"
        '
        'CmbIce
        '
        Me.CmbIce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIce.FormattingEnabled = True
        Me.CmbIce.Location = New System.Drawing.Point(94, 32)
        Me.CmbIce.Name = "CmbIce"
        Me.CmbIce.Size = New System.Drawing.Size(427, 21)
        Me.CmbIce.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "ICE:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(361, 585)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 40)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(463, 585)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(89, 40)
        Me.BtnGrabar.TabIndex = 3
        Me.BtnGrabar.TabStop = False
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 628)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCodigoPrincipal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoAuxiliar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbMarca As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbSubcategoria As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreLargo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNombreCorto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbTipoProducto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtStockMinimo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtStockMaximo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtPrecio1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPrecio3 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPrecio2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPrecio4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtPrecio6 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtPrecio5 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CmbCntaVenta As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents CmbCntaCosto As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CmbCntaInventario As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CmbIva As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbIce As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGrabar As Button
End Class
