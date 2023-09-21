<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturarTarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturarTarjetas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_PAC_FNA = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_PAC_CED = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_PAC_HIS = New System.Windows.Forms.TextBox
        Me.TXT_PAC_NOM = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT_COUTA = New System.Windows.Forms.ComboBox
        Me.TXT_FEC_INI = New System.Windows.Forms.DateTimePicker
        Me.TXT_FEC_FIN = New System.Windows.Forms.DateTimePicker
        Me.TXT_MONEDA = New System.Windows.Forms.ComboBox
        Me.TXT_MONTO = New DevComponents.Editors.DoubleInput
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXT_CON = New System.Windows.Forms.ComboBox
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_PRODUCTO = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TXT_TARJETA = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Check_PAC = New System.Windows.Forms.CheckBox
        Me.BT_FIND_CLI_FACT = New DevComponents.DotNetBar.ButtonX
        Me.TXT_CLI_RIF = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TXT_CLI_HIS = New System.Windows.Forms.TextBox
        Me.TXT_CLI_NOM = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TXT_OBSERVA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.TXT_MONTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.TXT_PAC_FNA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_PAC_CED)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_PAC_HIS)
        Me.GroupBox1.Controls.Add(Me.TXT_PAC_NOM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(192, 21)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(22, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 7
        '
        'TXT_PAC_FNA
        '
        Me.TXT_PAC_FNA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_PAC_FNA.Location = New System.Drawing.Point(519, 18)
        Me.TXT_PAC_FNA.Name = "TXT_PAC_FNA"
        Me.TXT_PAC_FNA.Size = New System.Drawing.Size(82, 20)
        Me.TXT_PAC_FNA.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Nacimiento:"
        '
        'TXT_PAC_CED
        '
        Me.TXT_PAC_CED.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PAC_CED.Location = New System.Drawing.Point(280, 18)
        Me.TXT_PAC_CED.Name = "TXT_PAC_CED"
        Me.TXT_PAC_CED.ReadOnly = True
        Me.TXT_PAC_CED.Size = New System.Drawing.Size(120, 20)
        Me.TXT_PAC_CED.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cedula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Historia:"
        '
        'TXT_PAC_HIS
        '
        Me.TXT_PAC_HIS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PAC_HIS.Location = New System.Drawing.Point(66, 22)
        Me.TXT_PAC_HIS.Name = "TXT_PAC_HIS"
        Me.TXT_PAC_HIS.ReadOnly = True
        Me.TXT_PAC_HIS.Size = New System.Drawing.Size(120, 20)
        Me.TXT_PAC_HIS.TabIndex = 2
        '
        'TXT_PAC_NOM
        '
        Me.TXT_PAC_NOM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PAC_NOM.Location = New System.Drawing.Point(68, 48)
        Me.TXT_PAC_NOM.Name = "TXT_PAC_NOM"
        Me.TXT_PAC_NOM.ReadOnly = True
        Me.TXT_PAC_NOM.Size = New System.Drawing.Size(533, 20)
        Me.TXT_PAC_NOM.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fecha Inicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha Fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Monto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Moneda:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Cuota Nro:"
        '
        'TXT_COUTA
        '
        Me.TXT_COUTA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_COUTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_COUTA.FormattingEnabled = True
        Me.TXT_COUTA.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.TXT_COUTA.Location = New System.Drawing.Point(261, 222)
        Me.TXT_COUTA.Name = "TXT_COUTA"
        Me.TXT_COUTA.Size = New System.Drawing.Size(48, 21)
        Me.TXT_COUTA.TabIndex = 6
        '
        'TXT_FEC_INI
        '
        Me.TXT_FEC_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_INI.Location = New System.Drawing.Point(390, 223)
        Me.TXT_FEC_INI.Name = "TXT_FEC_INI"
        Me.TXT_FEC_INI.Size = New System.Drawing.Size(73, 20)
        Me.TXT_FEC_INI.TabIndex = 7
        '
        'TXT_FEC_FIN
        '
        Me.TXT_FEC_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_FIN.Location = New System.Drawing.Point(535, 223)
        Me.TXT_FEC_FIN.Name = "TXT_FEC_FIN"
        Me.TXT_FEC_FIN.Size = New System.Drawing.Size(78, 20)
        Me.TXT_FEC_FIN.TabIndex = 8
        '
        'TXT_MONEDA
        '
        Me.TXT_MONEDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_MONEDA.FormattingEnabled = True
        Me.TXT_MONEDA.Location = New System.Drawing.Point(72, 271)
        Me.TXT_MONEDA.Name = "TXT_MONEDA"
        Me.TXT_MONEDA.Size = New System.Drawing.Size(248, 21)
        Me.TXT_MONEDA.TabIndex = 9
        '
        'TXT_MONTO
        '
        '
        '
        '
        Me.TXT_MONTO.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_MONTO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_MONTO.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_MONTO.Increment = 1
        Me.TXT_MONTO.Location = New System.Drawing.Point(476, 263)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(141, 20)
        Me.TXT_MONTO.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(385, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Cond. de Pago"
        '
        'TXT_CON
        '
        Me.TXT_CON.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_CON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_CON.FormattingEnabled = True
        Me.TXT_CON.Location = New System.Drawing.Point(475, 309)
        Me.TXT_CON.Name = "TXT_CON"
        Me.TXT_CON.Size = New System.Drawing.Size(142, 21)
        Me.TXT_CON.TabIndex = 12
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(489, 366)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX2.TabIndex = 13
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(335, 366)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX3.TabIndex = 14
        Me.ButtonX3.Tooltip = "Borrar"
        '
        'TXT_PRODUCTO
        '
        Me.TXT_PRODUCTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_PRODUCTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_PRODUCTO.DropDownWidth = 350
        Me.TXT_PRODUCTO.FormattingEnabled = True
        Me.TXT_PRODUCTO.Location = New System.Drawing.Point(72, 312)
        Me.TXT_PRODUCTO.Name = "TXT_PRODUCTO"
        Me.TXT_PRODUCTO.Size = New System.Drawing.Size(248, 21)
        Me.TXT_PRODUCTO.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Producto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Tarjeta:"
        '
        'TXT_TARJETA
        '
        Me.TXT_TARJETA.BackColor = System.Drawing.Color.White
        Me.TXT_TARJETA.Location = New System.Drawing.Point(80, 225)
        Me.TXT_TARJETA.Name = "TXT_TARJETA"
        Me.TXT_TARJETA.Size = New System.Drawing.Size(111, 20)
        Me.TXT_TARJETA.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Check_PAC)
        Me.GroupBox2.Controls.Add(Me.BT_FIND_CLI_FACT)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_RIF)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_HIS)
        Me.GroupBox2.Controls.Add(Me.TXT_CLI_NOM)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 89)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente/Factura"
        '
        'Check_PAC
        '
        Me.Check_PAC.AutoSize = True
        Me.Check_PAC.Location = New System.Drawing.Point(20, 21)
        Me.Check_PAC.Name = "Check_PAC"
        Me.Check_PAC.Size = New System.Drawing.Size(96, 17)
        Me.Check_PAC.TabIndex = 8
        Me.Check_PAC.Text = "Paciente Paga"
        Me.Check_PAC.UseVisualStyleBackColor = True
        '
        'BT_FIND_CLI_FACT
        '
        Me.BT_FIND_CLI_FACT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_FIND_CLI_FACT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BT_FIND_CLI_FACT.Location = New System.Drawing.Point(389, 21)
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
        Me.TXT_CLI_RIF.Location = New System.Drawing.Point(477, 18)
        Me.TXT_CLI_RIF.Name = "TXT_CLI_RIF"
        Me.TXT_CLI_RIF.ReadOnly = True
        Me.TXT_CLI_RIF.Size = New System.Drawing.Size(120, 20)
        Me.TXT_CLI_RIF.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(428, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Cedula:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(212, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Historia:"
        '
        'TXT_CLI_HIS
        '
        Me.TXT_CLI_HIS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_HIS.Location = New System.Drawing.Point(263, 22)
        Me.TXT_CLI_HIS.Name = "TXT_CLI_HIS"
        Me.TXT_CLI_HIS.ReadOnly = True
        Me.TXT_CLI_HIS.Size = New System.Drawing.Size(120, 20)
        Me.TXT_CLI_HIS.TabIndex = 2
        '
        'TXT_CLI_NOM
        '
        Me.TXT_CLI_NOM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_NOM.Location = New System.Drawing.Point(68, 48)
        Me.TXT_CLI_NOM.Name = "TXT_CLI_NOM"
        Me.TXT_CLI_NOM.ReadOnly = True
        Me.TXT_CLI_NOM.Size = New System.Drawing.Size(533, 20)
        Me.TXT_CLI_NOM.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nombre:"
        '
        'TXT_OBSERVA
        '
        Me.TXT_OBSERVA.Location = New System.Drawing.Point(72, 366)
        Me.TXT_OBSERVA.Multiline = True
        Me.TXT_OBSERVA.Name = "TXT_OBSERVA"
        Me.TXT_OBSERVA.Size = New System.Drawing.Size(248, 69)
        Me.TXT_OBSERVA.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Observa:"
        '
        'FrmFacturarTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 467)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_OBSERVA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXT_TARJETA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXT_PRODUCTO)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.TXT_CON)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_MONTO)
        Me.Controls.Add(Me.TXT_MONEDA)
        Me.Controls.Add(Me.TXT_FEC_FIN)
        Me.Controls.Add(Me.TXT_FEC_INI)
        Me.Controls.Add(Me.TXT_COUTA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacturarTarjetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar Tarjetas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TXT_MONTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PAC_FNA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_PAC_CED As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_PAC_HIS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PAC_NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_COUTA As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_FEC_INI As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_FEC_FIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_MONTO As DevComponents.Editors.DoubleInput
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_CON As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_PRODUCTO As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXT_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BT_FIND_CLI_FACT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_CLI_RIF As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXT_CLI_HIS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CLI_NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Check_PAC As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_OBSERVA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
