<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPrecioPromocion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarPrecioPromocion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_SERVICIOS_INGRESOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TXT_MOTIVO_INGRESO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_ASEGURADORA = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_NOM_PACIENTE = New System.Windows.Forms.TextBox
        Me.TXT_CI_PACIENTE = New System.Windows.Forms.TextBox
        Me.TXT_FEC_INGRESO = New System.Windows.Forms.DateTimePicker
        Me.TXT_NRO_INGRESO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_PROMOCION = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID_SERVICIOS_INGRESOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID_PROMOCION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.GRID_SERVICIOS_INGRESOS)
        Me.GroupBox1.Controls.Add(Me.TXT_MOTIVO_INGRESO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_ASEGURADORA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_NOM_PACIENTE)
        Me.GroupBox1.Controls.Add(Me.TXT_CI_PACIENTE)
        Me.GroupBox1.Controls.Add(Me.TXT_FEC_INGRESO)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO_INGRESO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Ingreso"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(617, 16)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(43, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 13
        Me.ButtonX1.Text = "Buscar"
        '
        'GRID_SERVICIOS_INGRESOS
        '
        Me.GRID_SERVICIOS_INGRESOS.AllowUserToAddRows = False
        Me.GRID_SERVICIOS_INGRESOS.AllowUserToDeleteRows = False
        Me.GRID_SERVICIOS_INGRESOS.AllowUserToOrderColumns = True
        Me.GRID_SERVICIOS_INGRESOS.AllowUserToResizeColumns = False
        Me.GRID_SERVICIOS_INGRESOS.AllowUserToResizeRows = False
        Me.GRID_SERVICIOS_INGRESOS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_SERVICIOS_INGRESOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_SERVICIOS_INGRESOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_SERVICIOS_INGRESOS.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_SERVICIOS_INGRESOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_SERVICIOS_INGRESOS.Location = New System.Drawing.Point(7, 115)
        Me.GRID_SERVICIOS_INGRESOS.Name = "GRID_SERVICIOS_INGRESOS"
        Me.GRID_SERVICIOS_INGRESOS.ReadOnly = True
        Me.GRID_SERVICIOS_INGRESOS.RowHeadersVisible = False
        Me.GRID_SERVICIOS_INGRESOS.Size = New System.Drawing.Size(664, 150)
        Me.GRID_SERVICIOS_INGRESOS.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Servicio"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Doctor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'TXT_MOTIVO_INGRESO
        '
        Me.TXT_MOTIVO_INGRESO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_MOTIVO_INGRESO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_MOTIVO_INGRESO.Location = New System.Drawing.Point(424, 49)
        Me.TXT_MOTIVO_INGRESO.Name = "TXT_MOTIVO_INGRESO"
        Me.TXT_MOTIVO_INGRESO.ReadOnly = True
        Me.TXT_MOTIVO_INGRESO.Size = New System.Drawing.Size(247, 20)
        Me.TXT_MOTIVO_INGRESO.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Motivo:"
        '
        'TXT_ASEGURADORA
        '
        Me.TXT_ASEGURADORA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_ASEGURADORA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_ASEGURADORA.Location = New System.Drawing.Point(424, 82)
        Me.TXT_ASEGURADORA.Name = "TXT_ASEGURADORA"
        Me.TXT_ASEGURADORA.ReadOnly = True
        Me.TXT_ASEGURADORA.Size = New System.Drawing.Size(247, 20)
        Me.TXT_ASEGURADORA.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Aseguradora:"
        '
        'TXT_NOM_PACIENTE
        '
        Me.TXT_NOM_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NOM_PACIENTE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_NOM_PACIENTE.Location = New System.Drawing.Point(150, 84)
        Me.TXT_NOM_PACIENTE.Name = "TXT_NOM_PACIENTE"
        Me.TXT_NOM_PACIENTE.ReadOnly = True
        Me.TXT_NOM_PACIENTE.Size = New System.Drawing.Size(195, 20)
        Me.TXT_NOM_PACIENTE.TabIndex = 7
        '
        'TXT_CI_PACIENTE
        '
        Me.TXT_CI_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CI_PACIENTE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_CI_PACIENTE.Location = New System.Drawing.Point(75, 84)
        Me.TXT_CI_PACIENTE.Name = "TXT_CI_PACIENTE"
        Me.TXT_CI_PACIENTE.ReadOnly = True
        Me.TXT_CI_PACIENTE.Size = New System.Drawing.Size(69, 20)
        Me.TXT_CI_PACIENTE.TabIndex = 6
        '
        'TXT_FEC_INGRESO
        '
        Me.TXT_FEC_INGRESO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_INGRESO.Location = New System.Drawing.Point(238, 55)
        Me.TXT_FEC_INGRESO.Name = "TXT_FEC_INGRESO"
        Me.TXT_FEC_INGRESO.Size = New System.Drawing.Size(105, 20)
        Me.TXT_FEC_INGRESO.TabIndex = 5
        '
        'TXT_NRO_INGRESO
        '
        Me.TXT_NRO_INGRESO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NRO_INGRESO.ForeColor = System.Drawing.Color.Black
        Me.TXT_NRO_INGRESO.Location = New System.Drawing.Point(75, 56)
        Me.TXT_NRO_INGRESO.Name = "TXT_NRO_INGRESO"
        Me.TXT_NRO_INGRESO.ReadOnly = True
        Me.TXT_NRO_INGRESO.Size = New System.Drawing.Size(69, 20)
        Me.TXT_NRO_INGRESO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paciente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro:"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(13, 467)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 39)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 14
        Me.ButtonX2.Text = "Indicar Promocion"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(601, 473)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 39)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 15
        Me.ButtonX3.Text = "Modificar Precios"
        '
        'GRID_PROMOCION
        '
        Me.GRID_PROMOCION.AllowUserToAddRows = False
        Me.GRID_PROMOCION.AllowUserToDeleteRows = False
        Me.GRID_PROMOCION.AllowUserToOrderColumns = True
        Me.GRID_PROMOCION.AllowUserToResizeColumns = False
        Me.GRID_PROMOCION.AllowUserToResizeRows = False
        Me.GRID_PROMOCION.BackgroundColor = System.Drawing.Color.White
        Me.GRID_PROMOCION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_PROMOCION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.GRID_PROMOCION.Location = New System.Drawing.Point(13, 309)
        Me.GRID_PROMOCION.Name = "GRID_PROMOCION"
        Me.GRID_PROMOCION.RowHeadersVisible = False
        Me.GRID_PROMOCION.Size = New System.Drawing.Size(663, 150)
        Me.GRID_PROMOCION.TabIndex = 16
        '
        'Column4
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Servicio"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Precio Ingreso"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Precio Promocion"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column7
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "%Desc."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'FrmModificarPrecioPromocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(694, 527)
        Me.Controls.Add(Me.GRID_PROMOCION)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificarPrecioPromocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Precios (Promocion)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID_SERVICIOS_INGRESOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID_PROMOCION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FEC_INGRESO As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_NRO_INGRESO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOM_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CI_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ASEGURADORA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_MOTIVO_INGRESO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GRID_SERVICIOS_INGRESOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GRID_PROMOCION As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
