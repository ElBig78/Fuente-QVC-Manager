<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientoInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimientoInventario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CmbBodegaDestino = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbBodegaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAgregarArticulos = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 39)
        Me.Panel1.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(3, 12)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(258, 23)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Movimiento de Inventario"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CmbBodegaDestino)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.CmbBodegaOrigen)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.TxtDescripcion)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.CmbTipoMovimiento)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.DtpFechaMovimiento)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 44)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(764, 121)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Información del Movimiento"
        '
        'CmbBodegaDestino
        '
        Me.CmbBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBodegaDestino.Enabled = False
        Me.CmbBodegaDestino.FormattingEnabled = True
        Me.CmbBodegaDestino.Location = New System.Drawing.Point(469, 81)
        Me.CmbBodegaDestino.Name = "CmbBodegaDestino"
        Me.CmbBodegaDestino.Size = New System.Drawing.Size(288, 21)
        Me.CmbBodegaDestino.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Bodega Destino:"
        '
        'CmbBodegaOrigen
        '
        Me.CmbBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBodegaOrigen.Enabled = False
        Me.CmbBodegaOrigen.FormattingEnabled = True
        Me.CmbBodegaOrigen.Location = New System.Drawing.Point(96, 81)
        Me.CmbBodegaOrigen.Name = "CmbBodegaOrigen"
        Me.CmbBodegaOrigen.Size = New System.Drawing.Size(279, 21)
        Me.CmbBodegaOrigen.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Bodega Orígen:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(96, 54)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(661, 21)
        Me.TxtDescripcion.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Descripción:"
        '
        'CmbTipoMovimiento
        '
        Me.CmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoMovimiento.FormattingEnabled = True
        Me.CmbTipoMovimiento.Items.AddRange(New Object() {"INGRESO", "EGRESO", "TRANSFERENCIA"})
        Me.CmbTipoMovimiento.Location = New System.Drawing.Point(410, 27)
        Me.CmbTipoMovimiento.Name = "CmbTipoMovimiento"
        Me.CmbTipoMovimiento.Size = New System.Drawing.Size(347, 21)
        Me.CmbTipoMovimiento.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tipo Movimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha:"
        '
        'DtpFechaMovimiento
        '
        Me.DtpFechaMovimiento.Location = New System.Drawing.Point(96, 27)
        Me.DtpFechaMovimiento.Name = "DtpFechaMovimiento"
        Me.DtpFechaMovimiento.Size = New System.Drawing.Size(214, 21)
        Me.DtpFechaMovimiento.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.Panel2)
        Me.GroupControl2.Location = New System.Drawing.Point(10, 172)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(762, 363)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Detalle del Movimiento"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(758, 307)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAgregarArticulos)
        Me.Panel2.Controls.Add(Me.LblTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 327)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 34)
        Me.Panel2.TabIndex = 0
        '
        'BtnAgregarArticulos
        '
        Me.BtnAgregarArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BtnAgregarArticulos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarArticulos.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarArticulos.Location = New System.Drawing.Point(4, 3)
        Me.BtnAgregarArticulos.Name = "BtnAgregarArticulos"
        Me.BtnAgregarArticulos.Size = New System.Drawing.Size(124, 28)
        Me.BtnAgregarArticulos.TabIndex = 18
        Me.BtnAgregarArticulos.Text = "Agregar Artículos"
        Me.BtnAgregarArticulos.UseVisualStyleBackColor = False
        '
        'LblTotal
        '
        Me.LblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(614, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(144, 34)
        Me.LblTotal.TabIndex = 17
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(578, 541)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 40)
        Me.BtnCancelar.TabIndex = 6
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
        Me.BtnGrabar.Location = New System.Drawing.Point(680, 541)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(89, 40)
        Me.BtnGrabar.TabIndex = 5
        Me.BtnGrabar.TabStop = False
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'FrmMovimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMovimientoInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DtpFechaMovimiento As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbTipoMovimiento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CmbBodegaDestino As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbBodegaOrigen As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnAgregarArticulos As Button
End Class
