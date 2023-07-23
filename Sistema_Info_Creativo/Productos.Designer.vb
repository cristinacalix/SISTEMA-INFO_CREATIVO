<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtPrecioMayorista = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(635, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 79)
        Me.Button1.TabIndex = 58
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(209, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(203, 19)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "PRODUCTOS"
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(328, 144)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(143, 20)
        Me.dtpFechaRegistro.TabIndex = 56
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Items.AddRange(New Object() {"Computadoras", "Accesorios para computadoras", "Audio", "Scanners", "Almacenamiento", "Redes", "Impresoras", ""})
        Me.CmbCategoria.Location = New System.Drawing.Point(281, 48)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(102, 21)
        Me.CmbCategoria.TabIndex = 55
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Location = New System.Drawing.Point(346, 230)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 43)
        Me.BtnEliminar.TabIndex = 54
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.BackgroundImage = CType(resources.GetObject("Btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.Btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsalir.Location = New System.Drawing.Point(398, 230)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(34, 43)
        Me.Btnsalir.TabIndex = 53
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Location = New System.Drawing.Point(293, 230)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(38, 43)
        Me.BtnBuscar.TabIndex = 52
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(240, 230)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(38, 43)
        Me.BtnGuardar.TabIndex = 51
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Location = New System.Drawing.Point(181, 230)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(33, 43)
        Me.BtnNuevo.TabIndex = 50
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(125, 79)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(102, 20)
        Me.txtNombreProducto.TabIndex = 49
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(125, 111)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(418, 20)
        Me.txtDescripcionProducto.TabIndex = 48
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(441, 47)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(102, 20)
        Me.txtModelo.TabIndex = 47
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(125, 143)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(102, 20)
        Me.txtNombreProveedor.TabIndex = 46
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(92, 183)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(85, 20)
        Me.txtPrecioUnitario.TabIndex = 45
        '
        'txtPrecioMayorista
        '
        Me.txtPrecioMayorista.Location = New System.Drawing.Point(302, 183)
        Me.txtPrecioMayorista.Name = "txtPrecioMayorista"
        Me.txtPrecioMayorista.Size = New System.Drawing.Size(81, 20)
        Me.txtPrecioMayorista.TabIndex = 44
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(441, 183)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(102, 20)
        Me.txtStock.TabIndex = 43
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(125, 49)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(62, 20)
        Me.txtIdProducto.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Fecha Registro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Precio Unitario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(393, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Precio Mayoritario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Nombre Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Descripcion Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Id Producto"
        '
        'dgvproductos
        '
        Me.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproductos.Location = New System.Drawing.Point(4, 294)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(732, 210)
        Me.dgvproductos.TabIndex = 59
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 516)
        Me.Controls.Add(Me.dgvproductos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpFechaRegistro)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.txtDescripcionProducto)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtPrecioMayorista)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtPrecioMayorista As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvproductos As DataGridView
End Class
