<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarTasaIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambiarTasaIngreso))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_NRO_INGRESO = New System.Windows.Forms.TextBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_FECHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_PACIENTE = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_EMPRESA = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_MONEDA = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_MONTO = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_TASA = New System.Windows.Forms.Label
        Me.GRID_INGRESOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.nro_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GRID_INGRESOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Ingreso"
        '
        'TXT_NRO_INGRESO
        '
        Me.TXT_NRO_INGRESO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NRO_INGRESO.Location = New System.Drawing.Point(105, 24)
        Me.TXT_NRO_INGRESO.Name = "TXT_NRO_INGRESO"
        Me.TXT_NRO_INGRESO.ReadOnly = True
        Me.TXT_NRO_INGRESO.Size = New System.Drawing.Size(158, 20)
        Me.TXT_NRO_INGRESO.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(271, 25)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(19, 17)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Tooltip = "Buscar Ingreso"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_FECHA.Location = New System.Drawing.Point(105, 60)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.ReadOnly = True
        Me.TXT_FECHA.Size = New System.Drawing.Size(158, 20)
        Me.TXT_FECHA.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
        '
        'TXT_PACIENTE
        '
        Me.TXT_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PACIENTE.Location = New System.Drawing.Point(105, 97)
        Me.TXT_PACIENTE.Name = "TXT_PACIENTE"
        Me.TXT_PACIENTE.ReadOnly = True
        Me.TXT_PACIENTE.Size = New System.Drawing.Size(158, 20)
        Me.TXT_PACIENTE.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Paciente"
        '
        'TXT_EMPRESA
        '
        Me.TXT_EMPRESA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_EMPRESA.Location = New System.Drawing.Point(105, 136)
        Me.TXT_EMPRESA.Name = "TXT_EMPRESA"
        Me.TXT_EMPRESA.ReadOnly = True
        Me.TXT_EMPRESA.Size = New System.Drawing.Size(158, 20)
        Me.TXT_EMPRESA.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Empresa"
        '
        'TXT_MONEDA
        '
        Me.TXT_MONEDA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_MONEDA.Location = New System.Drawing.Point(105, 176)
        Me.TXT_MONEDA.Name = "TXT_MONEDA"
        Me.TXT_MONEDA.ReadOnly = True
        Me.TXT_MONEDA.Size = New System.Drawing.Size(158, 20)
        Me.TXT_MONEDA.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Moneda"
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_MONTO.Location = New System.Drawing.Point(105, 217)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.ReadOnly = True
        Me.TXT_MONTO.Size = New System.Drawing.Size(158, 20)
        Me.TXT_MONTO.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Monto"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(223, 243)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(40, 35)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 16
        Me.ButtonX2.Tooltip = "Cambiar Tasa"
        '
        'TXT_TASA
        '
        Me.TXT_TASA.AutoSize = True
        Me.TXT_TASA.Location = New System.Drawing.Point(39, 265)
        Me.TXT_TASA.Name = "TXT_TASA"
        Me.TXT_TASA.Size = New System.Drawing.Size(0, 13)
        Me.TXT_TASA.TabIndex = 17
        '
        'GRID_INGRESOS
        '
        Me.GRID_INGRESOS.AllowUserToAddRows = False
        Me.GRID_INGRESOS.AllowUserToOrderColumns = True
        Me.GRID_INGRESOS.AllowUserToResizeColumns = False
        Me.GRID_INGRESOS.AllowUserToResizeRows = False
        Me.GRID_INGRESOS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_INGRESOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_INGRESOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nro_ingreso})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_INGRESOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_INGRESOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_INGRESOS.Location = New System.Drawing.Point(298, 24)
        Me.GRID_INGRESOS.MultiSelect = False
        Me.GRID_INGRESOS.Name = "GRID_INGRESOS"
        Me.GRID_INGRESOS.RowHeadersVisible = False
        Me.GRID_INGRESOS.Size = New System.Drawing.Size(93, 248)
        Me.GRID_INGRESOS.TabIndex = 18
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(271, 48)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(19, 17)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX3.SymbolSize = 10.0!
        Me.ButtonX3.TabIndex = 19
        Me.ButtonX3.Tooltip = "Buscar Ingreso"
        Me.ButtonX3.Visible = False
        '
        'nro_ingreso
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.nro_ingreso.DefaultCellStyle = DataGridViewCellStyle1
        Me.nro_ingreso.HeaderText = "Ingresos"
        Me.nro_ingreso.Name = "nro_ingreso"
        Me.nro_ingreso.ReadOnly = True
        Me.nro_ingreso.Width = 70
        '
        'FrmCambiarTasaIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 284)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.GRID_INGRESOS)
        Me.Controls.Add(Me.TXT_TASA)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.TXT_MONTO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_MONEDA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_EMPRESA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_PACIENTE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TXT_NRO_INGRESO)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambiarTasaIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Tasa a Ingreso"
        CType(Me.GRID_INGRESOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_NRO_INGRESO As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_FECHA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_EMPRESA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONEDA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONTO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_TASA As System.Windows.Forms.Label
    Friend WithEvents GRID_INGRESOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents nro_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
