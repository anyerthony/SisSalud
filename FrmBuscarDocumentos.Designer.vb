<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarDocumentos))
        Me.TXT_BUSQ = New System.Windows.Forms.TextBox
        Me.TXT_TIPO = New System.Windows.Forms.ComboBox
        Me.GRID = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker
        Me.TXT_PANTALLA = New System.Windows.Forms.TextBox
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_BUSQ
        '
        Me.TXT_BUSQ.Location = New System.Drawing.Point(136, 12)
        Me.TXT_BUSQ.Name = "TXT_BUSQ"
        Me.TXT_BUSQ.Size = New System.Drawing.Size(462, 20)
        Me.TXT_BUSQ.TabIndex = 0
        '
        'TXT_TIPO
        '
        Me.TXT_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO.FormattingEnabled = True
        Me.TXT_TIPO.Items.AddRange(New Object() {"FACT", "N/CR", "N/DB"})
        Me.TXT_TIPO.Location = New System.Drawing.Point(9, 11)
        Me.TXT_TIPO.Name = "TXT_TIPO"
        Me.TXT_TIPO.Size = New System.Drawing.Size(121, 21)
        Me.TXT_TIPO.TabIndex = 2
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.BackgroundColor = System.Drawing.Color.White
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID.Location = New System.Drawing.Point(9, 41)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.Size = New System.Drawing.Size(744, 291)
        Me.GRID.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nro."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        '
        '
        '
        Me.Column4.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Monto"
        Me.Column4.Increment = 1
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 250
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(649, 12)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(104, 20)
        Me.TXT_FECHA.TabIndex = 4
        '
        'TXT_PANTALLA
        '
        Me.TXT_PANTALLA.Location = New System.Drawing.Point(880, 105)
        Me.TXT_PANTALLA.Name = "TXT_PANTALLA"
        Me.TXT_PANTALLA.ReadOnly = True
        Me.TXT_PANTALLA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PANTALLA.TabIndex = 5
        '
        'FrmBuscarDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 339)
        Me.Controls.Add(Me.TXT_PANTALLA)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.GRID)
        Me.Controls.Add(Me.TXT_TIPO)
        Me.Controls.Add(Me.TXT_BUSQ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Documentos"
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_BUSQ As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents GRID As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TXT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXT_PANTALLA As System.Windows.Forms.TextBox
End Class
