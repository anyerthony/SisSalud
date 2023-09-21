<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarTasaAseguradora
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarTasaAseguradora))
        Me.GRID_ASEGURADORAS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TXT_ASEGURADORA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreO = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        CType(Me.GRID_ASEGURADORAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID_ASEGURADORAS
        '
        Me.GRID_ASEGURADORAS.AllowUserToAddRows = False
        Me.GRID_ASEGURADORAS.AllowUserToDeleteRows = False
        Me.GRID_ASEGURADORAS.AllowUserToResizeColumns = False
        Me.GRID_ASEGURADORAS.AllowUserToResizeRows = False
        Me.GRID_ASEGURADORAS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GRID_ASEGURADORAS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_ASEGURADORAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_ASEGURADORAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.comentario, Me.NombreO})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_ASEGURADORAS.DefaultCellStyle = DataGridViewCellStyle4
        Me.GRID_ASEGURADORAS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_ASEGURADORAS.Location = New System.Drawing.Point(12, 40)
        Me.GRID_ASEGURADORAS.Name = "GRID_ASEGURADORAS"
        Me.GRID_ASEGURADORAS.RowHeadersWidth = 10
        Me.GRID_ASEGURADORAS.Size = New System.Drawing.Size(836, 358)
        Me.GRID_ASEGURADORAS.TabIndex = 31
        '
        'TXT_ASEGURADORA
        '
        Me.TXT_ASEGURADORA.Location = New System.Drawing.Point(58, 12)
        Me.TXT_ASEGURADORA.Name = "TXT_ASEGURADORA"
        Me.TXT_ASEGURADORA.Size = New System.Drawing.Size(278, 20)
        Me.TXT_ASEGURADORA.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Buscar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(15, 404)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 38)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 34
        Me.ButtonX1.Tooltip = "Borrar"
        '
        'codigo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 70
        '
        'nombre
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.nombre.HeaderText = "RIF"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'comentario
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.comentario.DefaultCellStyle = DataGridViewCellStyle3
        Me.comentario.HeaderText = "Nombre"
        Me.comentario.Name = "comentario"
        Me.comentario.ReadOnly = True
        Me.comentario.ToolTipText = "Doble click para agregar un comentario demutipleas lineas."
        Me.comentario.Width = 550
        '
        'NombreO
        '
        '
        '
        '
        Me.NombreO.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.NombreO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NombreO.HeaderText = "Tasa"
        Me.NombreO.Increment = 1
        Me.NombreO.Name = "NombreO"
        Me.NombreO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NombreO.Width = 80
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(773, 404)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 38)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 35
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'FrmActualizarTasaAseguradora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 454)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_ASEGURADORA)
        Me.Controls.Add(Me.GRID_ASEGURADORAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActualizarTasaAseguradora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Tasas Aseguradoras"
        CType(Me.GRID_ASEGURADORAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID_ASEGURADORAS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TXT_ASEGURADORA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreO As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
