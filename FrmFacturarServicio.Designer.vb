<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturarServicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturarServicio))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BT_FIND_CLI_FACT = New DevComponents.DotNetBar.ButtonX
        Me.TXT_CLI_RIF = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TXT_CLI_HIS = New System.Windows.Forms.TextBox
        Me.TXT_CLI_NOM = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_OBSERVA = New System.Windows.Forms.TextBox
        Me.TXT_CON = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXT_MONEDA = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_SERVICIOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column4 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Adic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TXT_TOTAL = New DevComponents.Editors.DoubleInput
        Me.TXT_COD_ASEGURA = New System.Windows.Forms.TextBox
        Me.TXT_COD_EMPRESA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_servicios = New System.Windows.Forms.TextBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.CREAR_SERVICIO = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox2.SuspendLayout()
        CType(Me.GRID_SERVICIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BT_FIND_CLI_FACT)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_RIF)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_HIS)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_NOM)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 89)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturar a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Aseguradora / Empresa:"
        '
        'BT_FIND_CLI_FACT
        '
        Me.BT_FIND_CLI_FACT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_FIND_CLI_FACT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BT_FIND_CLI_FACT.Location = New System.Drawing.Point(204, 22)
        Me.BT_FIND_CLI_FACT.Name = "BT_FIND_CLI_FACT"
        Me.BT_FIND_CLI_FACT.Size = New System.Drawing.Size(22, 20)
        Me.BT_FIND_CLI_FACT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_FIND_CLI_FACT.Symbol = ""
        Me.BT_FIND_CLI_FACT.SymbolColor = System.Drawing.Color.Red
        Me.BT_FIND_CLI_FACT.SymbolSize = 10.0!
        Me.BT_FIND_CLI_FACT.TabIndex = 7
        '
        'TXT_CLI_RIF
        '
        Me.TXT_CLI_RIF.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_RIF.Location = New System.Drawing.Point(310, 22)
        Me.TXT_CLI_RIF.Name = "TXT_CLI_RIF"
        Me.TXT_CLI_RIF.ReadOnly = True
        Me.TXT_CLI_RIF.Size = New System.Drawing.Size(120, 20)
        Me.TXT_CLI_RIF.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(261, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Cedula:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "CodProfit:"
        '
        'TXT_CLI_HIS
        '
        Me.TXT_CLI_HIS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_HIS.Location = New System.Drawing.Point(79, 22)
        Me.TXT_CLI_HIS.Name = "TXT_CLI_HIS"
        Me.TXT_CLI_HIS.ReadOnly = True
        Me.TXT_CLI_HIS.Size = New System.Drawing.Size(109, 20)
        Me.TXT_CLI_HIS.TabIndex = 2
        '
        'TXT_CLI_NOM
        '
        Me.TXT_CLI_NOM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_NOM.Location = New System.Drawing.Point(139, 54)
        Me.TXT_CLI_NOM.Name = "TXT_CLI_NOM"
        Me.TXT_CLI_NOM.ReadOnly = True
        Me.TXT_CLI_NOM.Size = New System.Drawing.Size(499, 20)
        Me.TXT_CLI_NOM.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Observación:"
        '
        'TXT_OBSERVA
        '
        Me.TXT_OBSERVA.Location = New System.Drawing.Point(114, 144)
        Me.TXT_OBSERVA.Multiline = True
        Me.TXT_OBSERVA.Name = "TXT_OBSERVA"
        Me.TXT_OBSERVA.Size = New System.Drawing.Size(541, 36)
        Me.TXT_OBSERVA.TabIndex = 26
        '
        'TXT_CON
        '
        Me.TXT_CON.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_CON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_CON.FormattingEnabled = True
        Me.TXT_CON.Location = New System.Drawing.Point(412, 107)
        Me.TXT_CON.Name = "TXT_CON"
        Me.TXT_CON.Size = New System.Drawing.Size(226, 21)
        Me.TXT_CON.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(328, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Cond. de Pago"
        '
        'TXT_MONEDA
        '
        Me.TXT_MONEDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_MONEDA.FormattingEnabled = True
        Me.TXT_MONEDA.Location = New System.Drawing.Point(114, 107)
        Me.TXT_MONEDA.Name = "TXT_MONEDA"
        Me.TXT_MONEDA.Size = New System.Drawing.Size(158, 21)
        Me.TXT_MONEDA.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Moneda:"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(12, 423)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX3.TabIndex = 29
        Me.ButtonX3.Tooltip = "Borrar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(448, 423)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX2.TabIndex = 28
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'GRID_SERVICIOS
        '
        Me.GRID_SERVICIOS.AllowUserToAddRows = False
        Me.GRID_SERVICIOS.AllowUserToDeleteRows = False
        Me.GRID_SERVICIOS.AllowUserToResizeColumns = False
        Me.GRID_SERVICIOS.AllowUserToResizeRows = False
        Me.GRID_SERVICIOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GRID_SERVICIOS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_SERVICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_SERVICIOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.Column3, Me.Column4, Me.comentario, Me.Adic, Me.NombreO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_SERVICIOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_SERVICIOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_SERVICIOS.Location = New System.Drawing.Point(12, 214)
        Me.GRID_SERVICIOS.Name = "GRID_SERVICIOS"
        Me.GRID_SERVICIOS.RowHeadersWidth = 10
        Me.GRID_SERVICIOS.Size = New System.Drawing.Size(644, 203)
        Me.GRID_SERVICIOS.TabIndex = 30
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'nombre
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.nombre.HeaderText = "Servicio"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 410
        '
        'Column3
        '
        '
        '
        '
        Me.Column3.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.HeaderText = "Cant."
        Me.Column3.Increment = 1
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        '
        '
        '
        Me.Column4.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Increment = 1
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'comentario
        '
        Me.comentario.HeaderText = "Comentario"
        Me.comentario.Name = "comentario"
        Me.comentario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comentario.ToolTipText = "Doble click para agregar un comentario demutipleas lineas."
        Me.comentario.Width = 75
        '
        'Adic
        '
        Me.Adic.HeaderText = "Descripcion_adicional"
        Me.Adic.Name = "Adic"
        Me.Adic.Visible = False
        '
        'NombreO
        '
        Me.NombreO.HeaderText = "Nombre Original"
        Me.NombreO.Name = "NombreO"
        Me.NombreO.Visible = False
        '
        'TXT_TOTAL
        '
        '
        '
        '
        Me.TXT_TOTAL.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_TOTAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_TOTAL.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_TOTAL.Increment = 1
        Me.TXT_TOTAL.IsInputReadOnly = True
        Me.TXT_TOTAL.Location = New System.Drawing.Point(535, 423)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(121, 20)
        Me.TXT_TOTAL.TabIndex = 31
        '
        'TXT_COD_ASEGURA
        '
        Me.TXT_COD_ASEGURA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_COD_ASEGURA.Location = New System.Drawing.Point(671, 27)
        Me.TXT_COD_ASEGURA.Name = "TXT_COD_ASEGURA"
        Me.TXT_COD_ASEGURA.ReadOnly = True
        Me.TXT_COD_ASEGURA.Size = New System.Drawing.Size(120, 20)
        Me.TXT_COD_ASEGURA.TabIndex = 32
        '
        'TXT_COD_EMPRESA
        '
        Me.TXT_COD_EMPRESA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_COD_EMPRESA.Location = New System.Drawing.Point(671, 61)
        Me.TXT_COD_EMPRESA.Name = "TXT_COD_EMPRESA"
        Me.TXT_COD_EMPRESA.ReadOnly = True
        Me.TXT_COD_EMPRESA.Size = New System.Drawing.Size(120, 20)
        Me.TXT_COD_EMPRESA.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Buscar servicio:"
        '
        'TXT_servicios
        '
        Me.TXT_servicios.BackColor = System.Drawing.Color.White
        Me.TXT_servicios.Location = New System.Drawing.Point(119, 188)
        Me.TXT_servicios.Name = "TXT_servicios"
        Me.TXT_servicios.Size = New System.Drawing.Size(443, 20)
        Me.TXT_servicios.TabIndex = 35
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(365, 424)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX1.TabIndex = 36
        Me.ButtonX1.Tooltip = "Ver servicios seleccionados"
        '
        'CREAR_SERVICIO
        '
        Me.CREAR_SERVICIO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CREAR_SERVICIO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CREAR_SERVICIO.Location = New System.Drawing.Point(568, 186)
        Me.CREAR_SERVICIO.Name = "CREAR_SERVICIO"
        Me.CREAR_SERVICIO.Size = New System.Drawing.Size(25, 22)
        Me.CREAR_SERVICIO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CREAR_SERVICIO.Symbol = ""
        Me.CREAR_SERVICIO.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CREAR_SERVICIO.SymbolSize = 10.0!
        Me.CREAR_SERVICIO.TabIndex = 37
        Me.CREAR_SERVICIO.Tooltip = "Crear nuevo servicio"
        Me.CREAR_SERVICIO.Visible = False
        '
        'FrmFacturarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 504)
        Me.Controls.Add(Me.CREAR_SERVICIO)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_servicios)
        Me.Controls.Add(Me.TXT_COD_EMPRESA)
        Me.Controls.Add(Me.TXT_COD_ASEGURA)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.GRID_SERVICIOS)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_OBSERVA)
        Me.Controls.Add(Me.TXT_CON)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_MONEDA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacturarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar Servicio"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GRID_SERVICIOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BT_FIND_CLI_FACT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_CLI_RIF As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXT_CLI_HIS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CLI_NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_OBSERVA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CON As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GRID_SERVICIOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TXT_TOTAL As DevComponents.Editors.DoubleInput
    Friend WithEvents TXT_COD_ASEGURA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_COD_EMPRESA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_servicios As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column4 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREAR_SERVICIO As DevComponents.DotNetBar.ButtonX
End Class
