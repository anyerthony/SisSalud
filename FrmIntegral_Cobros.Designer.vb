<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntegral_Cobros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntegral_Cobros))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_CLI_NOM = New System.Windows.Forms.TextBox
        Me.TXT_FACT_TASA = New System.Windows.Forms.TextBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.Label12 = New System.Windows.Forms.Label
        Me.TXT_FACT_FEC = New System.Windows.Forms.TextBox
        Me.TXT_FACT_NC = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXT_FACT_NUM = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_FACT_SALDO_BS = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GRID = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.ColumnaForma = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
        Me.ColumnaFecha = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.ColumnaMonto = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnaBanco = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_FACT_SALDO_D = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_FOR_D = New System.Windows.Forms.TextBox
        Me.TXT_FOR_BS = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT_FAL_D = New System.Windows.Forms.TextBox
        Me.TXT_FAL_BS = New System.Windows.Forms.TextBox
        Me.TXT_IGTF = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_CLI_NOM)
        Me.GroupBox1.Controls.Add(Me.TXT_FACT_TASA)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TXT_FACT_FEC)
        Me.GroupBox1.Controls.Add(Me.TXT_FACT_NC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_FACT_NUM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(876, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura:"
        '
        'TXT_CLI_NOM
        '
        Me.TXT_CLI_NOM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_NOM.Location = New System.Drawing.Point(604, 19)
        Me.TXT_CLI_NOM.Name = "TXT_CLI_NOM"
        Me.TXT_CLI_NOM.ReadOnly = True
        Me.TXT_CLI_NOM.Size = New System.Drawing.Size(268, 20)
        Me.TXT_CLI_NOM.TabIndex = 6
        '
        'TXT_FACT_TASA
        '
        Me.TXT_FACT_TASA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_TASA.Location = New System.Drawing.Point(482, 19)
        Me.TXT_FACT_TASA.Name = "TXT_FACT_TASA"
        Me.TXT_FACT_TASA.ReadOnly = True
        Me.TXT_FACT_TASA.Size = New System.Drawing.Size(66, 20)
        Me.TXT_FACT_TASA.TabIndex = 11
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(122, 19)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(19, 17)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Tooltip = "Buscar Factura"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(559, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Cliente: "
        '
        'TXT_FACT_FEC
        '
        Me.TXT_FACT_FEC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_FEC.Location = New System.Drawing.Point(342, 19)
        Me.TXT_FACT_FEC.Name = "TXT_FACT_FEC"
        Me.TXT_FACT_FEC.ReadOnly = True
        Me.TXT_FACT_FEC.Size = New System.Drawing.Size(84, 20)
        Me.TXT_FACT_FEC.TabIndex = 7
        '
        'TXT_FACT_NC
        '
        Me.TXT_FACT_NC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_NC.Location = New System.Drawing.Point(198, 19)
        Me.TXT_FACT_NC.Name = "TXT_FACT_NC"
        Me.TXT_FACT_NC.ReadOnly = True
        Me.TXT_FACT_NC.Size = New System.Drawing.Size(95, 20)
        Me.TXT_FACT_NC.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tasa:"
        '
        'TXT_FACT_NUM
        '
        Me.TXT_FACT_NUM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_NUM.Location = New System.Drawing.Point(10, 19)
        Me.TXT_FACT_NUM.Name = "TXT_FACT_NUM"
        Me.TXT_FACT_NUM.ReadOnly = True
        Me.TXT_FACT_NUM.Size = New System.Drawing.Size(106, 20)
        Me.TXT_FACT_NUM.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Control:"
        '
        'TXT_FACT_SALDO_BS
        '
        Me.TXT_FACT_SALDO_BS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_SALDO_BS.Location = New System.Drawing.Point(11, 35)
        Me.TXT_FACT_SALDO_BS.Name = "TXT_FACT_SALDO_BS"
        Me.TXT_FACT_SALDO_BS.ReadOnly = True
        Me.TXT_FACT_SALDO_BS.Size = New System.Drawing.Size(95, 20)
        Me.TXT_FACT_SALDO_BS.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Saldo Bs.:"
        '
        'GRID
        '
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.BackgroundColor = System.Drawing.Color.White
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaForma, Me.ColumnaFecha, Me.ColumnaMonto, Me.Column4, Me.ColumnaBanco, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID.Location = New System.Drawing.Point(12, 141)
        Me.GRID.Name = "GRID"
        Me.GRID.Size = New System.Drawing.Size(1045, 252)
        Me.GRID.TabIndex = 3
        '
        'ColumnaForma
        '
        Me.ColumnaForma.DisplayMember = "Text"
        Me.ColumnaForma.DropDownHeight = 106
        Me.ColumnaForma.DropDownWidth = 121
        Me.ColumnaForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColumnaForma.HeaderText = "Forma de Pago"
        Me.ColumnaForma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ColumnaForma.IntegralHeight = False
        Me.ColumnaForma.ItemHeight = 15
        Me.ColumnaForma.Name = "ColumnaForma"
        Me.ColumnaForma.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaForma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColumnaForma.Width = 150
        '
        'ColumnaFecha
        '
        '
        '
        '
        Me.ColumnaFecha.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ColumnaFecha.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.ColumnaFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ColumnaFecha.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.ColumnaFecha.HeaderText = "Fecha"
        Me.ColumnaFecha.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.ColumnaFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.ColumnaFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ColumnaFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.ColumnaFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ColumnaFecha.MonthCalendar.DisplayMonth = New Date(2023, 2, 1, 0, 0, 0, 0)
        Me.ColumnaFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.ColumnaFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.ColumnaFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ColumnaFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.ColumnaFecha.Name = "ColumnaFecha"
        '
        'ColumnaMonto
        '
        '
        '
        '
        Me.ColumnaMonto.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ColumnaMonto.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.ColumnaMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ColumnaMonto.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.ColumnaMonto.HeaderText = "Monto"
        Me.ColumnaMonto.Increment = 1
        Me.ColumnaMonto.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.ColumnaMonto.Name = "ColumnaMonto"
        Me.ColumnaMonto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column4
        '
        Me.Column4.HeaderText = "Referencia"
        Me.Column4.Name = "Column4"
        '
        'ColumnaBanco
        '
        Me.ColumnaBanco.DisplayMember = "Text"
        Me.ColumnaBanco.DropDownHeight = 106
        Me.ColumnaBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColumnaBanco.DropDownWidth = 121
        Me.ColumnaBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColumnaBanco.HeaderText = "Banco/Cuenta"
        Me.ColumnaBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ColumnaBanco.IntegralHeight = False
        Me.ColumnaBanco.ItemHeight = 15
        Me.ColumnaBanco.Name = "ColumnaBanco"
        Me.ColumnaBanco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColumnaBanco.Width = 320
        '
        'Column6
        '
        Me.Column6.HeaderText = "Observacion"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 200
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(1017, 89)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(40, 35)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXT_IGTF)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TXT_FACT_SALDO_D)
        Me.GroupBox2.Controls.Add(Me.TXT_FACT_SALDO_BS)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 65)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Por Cobrar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Saldo $.:"
        '
        'TXT_FACT_SALDO_D
        '
        Me.TXT_FACT_SALDO_D.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FACT_SALDO_D.Location = New System.Drawing.Point(111, 35)
        Me.TXT_FACT_SALDO_D.Name = "TXT_FACT_SALDO_D"
        Me.TXT_FACT_SALDO_D.ReadOnly = True
        Me.TXT_FACT_SALDO_D.Size = New System.Drawing.Size(112, 20)
        Me.TXT_FACT_SALDO_D.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TXT_FOR_D)
        Me.GroupBox3.Controls.Add(Me.TXT_FOR_BS)
        Me.GroupBox3.Location = New System.Drawing.Point(430, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 65)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Formas de Pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "$.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Bs.:"
        '
        'TXT_FOR_D
        '
        Me.TXT_FOR_D.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FOR_D.Location = New System.Drawing.Point(121, 35)
        Me.TXT_FOR_D.Name = "TXT_FOR_D"
        Me.TXT_FOR_D.ReadOnly = True
        Me.TXT_FOR_D.Size = New System.Drawing.Size(112, 20)
        Me.TXT_FOR_D.TabIndex = 14
        '
        'TXT_FOR_BS
        '
        Me.TXT_FOR_BS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FOR_BS.Location = New System.Drawing.Point(11, 35)
        Me.TXT_FOR_BS.Name = "TXT_FOR_BS"
        Me.TXT_FOR_BS.ReadOnly = True
        Me.TXT_FOR_BS.Size = New System.Drawing.Size(95, 20)
        Me.TXT_FOR_BS.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TXT_FAL_D)
        Me.GroupBox4.Controls.Add(Me.TXT_FAL_BS)
        Me.GroupBox4.Location = New System.Drawing.Point(745, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(252, 65)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Faltante:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "$.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Bs.:"
        '
        'TXT_FAL_D
        '
        Me.TXT_FAL_D.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FAL_D.Location = New System.Drawing.Point(121, 35)
        Me.TXT_FAL_D.Name = "TXT_FAL_D"
        Me.TXT_FAL_D.ReadOnly = True
        Me.TXT_FAL_D.Size = New System.Drawing.Size(112, 20)
        Me.TXT_FAL_D.TabIndex = 14
        '
        'TXT_FAL_BS
        '
        Me.TXT_FAL_BS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FAL_BS.Location = New System.Drawing.Point(11, 35)
        Me.TXT_FAL_BS.Name = "TXT_FAL_BS"
        Me.TXT_FAL_BS.ReadOnly = True
        Me.TXT_FAL_BS.Size = New System.Drawing.Size(95, 20)
        Me.TXT_FAL_BS.TabIndex = 9
        '
        'TXT_IGTF
        '
        Me.TXT_IGTF.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_IGTF.Location = New System.Drawing.Point(260, 34)
        Me.TXT_IGTF.Name = "TXT_IGTF"
        Me.TXT_IGTF.ReadOnly = True
        Me.TXT_IGTF.Size = New System.Drawing.Size(112, 20)
        Me.TXT_IGTF.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "IGTF $.:"
        '
        'FrmIntegral_Cobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1069, 408)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.GRID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIntegral_Cobros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_FACT_NUM As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FACT_TASA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_FACT_SALDO_BS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FACT_FEC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FACT_NC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CLI_NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GRID As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_FACT_SALDO_D As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_FOR_D As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FOR_BS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_FAL_D As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FAL_BS As System.Windows.Forms.TextBox
    Friend WithEvents ColumnaForma As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents ColumnaFecha As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents ColumnaMonto As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaBanco As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_IGTF As System.Windows.Forms.TextBox
End Class
