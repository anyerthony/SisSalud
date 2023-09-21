<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntegral_CrearNotas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntegral_CrearNotas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_MONTO_DOC = New DevComponents.Editors.DoubleInput
        Me.GRID_DETALLE = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column3 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_CLI_DOC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_FEC_DOC = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_TIPO_DOC = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_TOTAL = New DevComponents.Editors.DoubleInput
        Me.TXT_OBSERVACION = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_CLI_DES = New System.Windows.Forms.TextBox
        Me.TXT_CO_CLI = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_TIPO = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.TXT_MONTO_DOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_DOC)
        Me.GroupBox1.Controls.Add(Me.GRID_DETALLE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_CLI_DOC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_FEC_DOC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO_DOC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_TIPO_DOC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento Asociado"
        '
        'TXT_MONTO_DOC
        '
        '
        '
        '
        Me.TXT_MONTO_DOC.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_MONTO_DOC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_MONTO_DOC.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_MONTO_DOC.Increment = 1
        Me.TXT_MONTO_DOC.IsInputReadOnly = True
        Me.TXT_MONTO_DOC.Location = New System.Drawing.Point(460, 67)
        Me.TXT_MONTO_DOC.Name = "TXT_MONTO_DOC"
        Me.TXT_MONTO_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_MONTO_DOC.TabIndex = 18
        '
        'GRID_DETALLE
        '
        Me.GRID_DETALLE.BackgroundColor = System.Drawing.Color.White
        Me.GRID_DETALLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_DETALLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_DETALLE.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_DETALLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_DETALLE.Location = New System.Drawing.Point(28, 99)
        Me.GRID_DETALLE.Name = "GRID_DETALLE"
        Me.GRID_DETALLE.RowHeadersWidth = 21
        Me.GRID_DETALLE.Size = New System.Drawing.Size(567, 227)
        Me.GRID_DETALLE.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descripcion"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 300
        '
        'Column2
        '
        '
        '
        '
        Me.Column2.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Column2.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column2.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Increment = 1
        Me.Column2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        '
        '
        '
        Me.Column3.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Column3.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Increment = 1
        Me.Column3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Monto:"
        '
        'TXT_CLI_DOC
        '
        Me.TXT_CLI_DOC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_DOC.Location = New System.Drawing.Point(74, 64)
        Me.TXT_CLI_DOC.Name = "TXT_CLI_DOC"
        Me.TXT_CLI_DOC.ReadOnly = True
        Me.TXT_CLI_DOC.Size = New System.Drawing.Size(298, 20)
        Me.TXT_CLI_DOC.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cliente"
        '
        'TXT_FEC_DOC
        '
        Me.TXT_FEC_DOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_DOC.Location = New System.Drawing.Point(460, 25)
        Me.TXT_FEC_DOC.Name = "TXT_FEC_DOC"
        Me.TXT_FEC_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_FEC_DOC.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(378, 26)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(22, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Tooltip = "Buscar Documento"
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(234, 26)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.ReadOnly = True
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_NRO_DOC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro:"
        '
        'TXT_TIPO_DOC
        '
        Me.TXT_TIPO_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO_DOC.FormattingEnabled = True
        Me.TXT_TIPO_DOC.Items.AddRange(New Object() {"FACT", "N/CR", "N/DB"})
        Me.TXT_TIPO_DOC.Location = New System.Drawing.Point(74, 25)
        Me.TXT_TIPO_DOC.Name = "TXT_TIPO_DOC"
        Me.TXT_TIPO_DOC.Size = New System.Drawing.Size(121, 21)
        Me.TXT_TIPO_DOC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(431, 115)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(49, 36)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 22
        Me.ButtonX3.Tooltip = "Cancelar/Limpiar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(546, 115)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(49, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 21
        Me.ButtonX2.Tooltip = "Guardar/Generar"
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
        Me.TXT_TOTAL.Location = New System.Drawing.Point(455, 35)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(138, 20)
        Me.TXT_TOTAL.TabIndex = 20
        '
        'TXT_OBSERVACION
        '
        Me.TXT_OBSERVACION.Location = New System.Drawing.Point(15, 81)
        Me.TXT_OBSERVACION.Multiline = True
        Me.TXT_OBSERVACION.Name = "TXT_OBSERVACION"
        Me.TXT_OBSERVACION.Size = New System.Drawing.Size(385, 104)
        Me.TXT_OBSERVACION.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ButtonX4)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_DES)
        Me.GroupBox2.Controls.Add(Me.TXT_CO_CLI)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXT_TIPO)
        Me.GroupBox2.Controls.Add(Me.ButtonX2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ButtonX3)
        Me.GroupBox2.Controls.Add(Me.TXT_OBSERVACION)
        Me.GroupBox2.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 203)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento a Crear"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Observacion"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(249, 33)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(22, 20)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX4.SymbolSize = 10.0!
        Me.ButtonX4.TabIndex = 31
        Me.ButtonX4.Tooltip = "Buscar Cliente"
        '
        'TXT_CLI_DES
        '
        Me.TXT_CLI_DES.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_DES.Location = New System.Drawing.Point(74, 33)
        Me.TXT_CLI_DES.Name = "TXT_CLI_DES"
        Me.TXT_CLI_DES.ReadOnly = True
        Me.TXT_CLI_DES.Size = New System.Drawing.Size(169, 20)
        Me.TXT_CLI_DES.TabIndex = 30
        '
        'TXT_CO_CLI
        '
        Me.TXT_CO_CLI.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CO_CLI.Location = New System.Drawing.Point(28, 33)
        Me.TXT_CO_CLI.Name = "TXT_CO_CLI"
        Me.TXT_CO_CLI.ReadOnly = True
        Me.TXT_CO_CLI.Size = New System.Drawing.Size(46, 20)
        Me.TXT_CO_CLI.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cliente"
        '
        'TXT_TIPO
        '
        Me.TXT_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO.FormattingEnabled = True
        Me.TXT_TIPO.Items.AddRange(New Object() {"FACT", "N/CR", "N/DB"})
        Me.TXT_TIPO.Location = New System.Drawing.Point(286, 35)
        Me.TXT_TIPO.Name = "TXT_TIPO"
        Me.TXT_TIPO.Size = New System.Drawing.Size(138, 21)
        Me.TXT_TIPO.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tipo:"
        '
        'FrmIntegral_CrearNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 570)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIntegral_CrearNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TXT_MONTO_DOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_TIPO_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_NRO_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_FEC_DOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_CLI_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GRID_DETALLE As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column3 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONTO_DOC As DevComponents.Editors.DoubleInput
    Friend WithEvents TXT_OBSERVACION As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TOTAL As DevComponents.Editors.DoubleInput
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_CLI_DES As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CO_CLI As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
