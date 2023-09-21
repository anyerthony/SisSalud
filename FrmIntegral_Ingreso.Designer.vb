<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntegral_Ingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntegral_Ingreso))
        Me.GRID_INGRESO = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_NOM_PACIENTE = New System.Windows.Forms.TextBox
        Me.TXT_FEC_NAC_PACIENTE = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_PAGADOR = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_MONTO_MORBILIDAD = New DevComponents.Editors.DoubleInput
        Me.TXT_CANT_MORBILIDAD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_FECHA_MORBILIDAD = New System.Windows.Forms.DateTimePicker
        Me.TXT_INGRESO = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.GRID_INGRESO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TXT_MONTO_MORBILIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID_INGRESO
        '
        Me.GRID_INGRESO.AllowUserToAddRows = False
        Me.GRID_INGRESO.AllowUserToDeleteRows = False
        Me.GRID_INGRESO.AllowUserToResizeColumns = False
        Me.GRID_INGRESO.AllowUserToResizeRows = False
        Me.GRID_INGRESO.BackgroundColor = System.Drawing.Color.White
        Me.GRID_INGRESO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_INGRESO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_INGRESO.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_INGRESO.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_INGRESO.Location = New System.Drawing.Point(5, 51)
        Me.GRID_INGRESO.Name = "GRID_INGRESO"
        Me.GRID_INGRESO.ReadOnly = True
        Me.GRID_INGRESO.RowHeadersWidth = 21
        Me.GRID_INGRESO.Size = New System.Drawing.Size(800, 260)
        Me.GRID_INGRESO.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Servicio"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Doctor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = "Monto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fec. Nac."
        '
        'TXT_NOM_PACIENTE
        '
        Me.TXT_NOM_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NOM_PACIENTE.Location = New System.Drawing.Point(131, 29)
        Me.TXT_NOM_PACIENTE.Name = "TXT_NOM_PACIENTE"
        Me.TXT_NOM_PACIENTE.ReadOnly = True
        Me.TXT_NOM_PACIENTE.Size = New System.Drawing.Size(214, 20)
        Me.TXT_NOM_PACIENTE.TabIndex = 3
        '
        'TXT_FEC_NAC_PACIENTE
        '
        Me.TXT_FEC_NAC_PACIENTE.Enabled = False
        Me.TXT_FEC_NAC_PACIENTE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_NAC_PACIENTE.Location = New System.Drawing.Point(363, 29)
        Me.TXT_FEC_NAC_PACIENTE.Name = "TXT_FEC_NAC_PACIENTE"
        Me.TXT_FEC_NAC_PACIENTE.Size = New System.Drawing.Size(80, 20)
        Me.TXT_FEC_NAC_PACIENTE.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quien Paga:"
        '
        'TXT_PAGADOR
        '
        Me.TXT_PAGADOR.BackColor = System.Drawing.Color.AliceBlue
        Me.TXT_PAGADOR.Location = New System.Drawing.Point(456, 29)
        Me.TXT_PAGADOR.Name = "TXT_PAGADOR"
        Me.TXT_PAGADOR.ReadOnly = True
        Me.TXT_PAGADOR.Size = New System.Drawing.Size(310, 20)
        Me.TXT_PAGADOR.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_MORBILIDAD)
        Me.GroupBox1.Controls.Add(Me.TXT_CANT_MORBILIDAD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_FECHA_MORBILIDAD)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 49)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales Ingresos Anteriores del Paciente:"
        '
        'TXT_MONTO_MORBILIDAD
        '
        '
        '
        '
        Me.TXT_MONTO_MORBILIDAD.BackgroundStyle.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_MONTO_MORBILIDAD.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_MONTO_MORBILIDAD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_MONTO_MORBILIDAD.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_MONTO_MORBILIDAD.Colors.Highlight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_MONTO_MORBILIDAD.Colors.HighlightText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_MONTO_MORBILIDAD.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_MONTO_MORBILIDAD.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_MONTO_MORBILIDAD.Increment = 1
        Me.TXT_MONTO_MORBILIDAD.IsInputReadOnly = True
        Me.TXT_MONTO_MORBILIDAD.Location = New System.Drawing.Point(307, 19)
        Me.TXT_MONTO_MORBILIDAD.Name = "TXT_MONTO_MORBILIDAD"
        Me.TXT_MONTO_MORBILIDAD.Size = New System.Drawing.Size(107, 20)
        Me.TXT_MONTO_MORBILIDAD.TabIndex = 6
        '
        'TXT_CANT_MORBILIDAD
        '
        Me.TXT_CANT_MORBILIDAD.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CANT_MORBILIDAD.Location = New System.Drawing.Point(623, 20)
        Me.TXT_CANT_MORBILIDAD.Name = "TXT_CANT_MORBILIDAD"
        Me.TXT_CANT_MORBILIDAD.ReadOnly = True
        Me.TXT_CANT_MORBILIDAD.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CANT_MORBILIDAD.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cantidad Ingresos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Monto Facturado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Desde"
        '
        'TXT_FECHA_MORBILIDAD
        '
        Me.TXT_FECHA_MORBILIDAD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA_MORBILIDAD.Location = New System.Drawing.Point(68, 23)
        Me.TXT_FECHA_MORBILIDAD.Name = "TXT_FECHA_MORBILIDAD"
        Me.TXT_FECHA_MORBILIDAD.Size = New System.Drawing.Size(80, 20)
        Me.TXT_FECHA_MORBILIDAD.TabIndex = 0
        '
        'TXT_INGRESO
        '
        Me.TXT_INGRESO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_INGRESO.Location = New System.Drawing.Point(16, 29)
        Me.TXT_INGRESO.Name = "TXT_INGRESO"
        Me.TXT_INGRESO.ReadOnly = True
        Me.TXT_INGRESO.Size = New System.Drawing.Size(109, 20)
        Me.TXT_INGRESO.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ingreso:"
        '
        'FrmIntegral_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 428)
        Me.Controls.Add(Me.TXT_INGRESO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_PAGADOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_FEC_NAC_PACIENTE)
        Me.Controls.Add(Me.TXT_NOM_PACIENTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GRID_INGRESO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIntegral_Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Ingreso"
        CType(Me.GRID_INGRESO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TXT_MONTO_MORBILIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID_INGRESO As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOM_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FEC_NAC_PACIENTE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_PAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_FECHA_MORBILIDAD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_CANT_MORBILIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXT_INGRESO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONTO_MORBILIDAD As DevComponents.Editors.DoubleInput
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
