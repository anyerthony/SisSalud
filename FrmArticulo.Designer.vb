<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_TIPO = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_CAT = New System.Windows.Forms.ComboBox
        Me.TXT_LIN = New System.Windows.Forms.ComboBox
        Me.TXT_SUB = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_COL = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GRID_PRECIO = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.BS_CATEGORIA = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_TIPO_MEDI = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        CType(Me.GRID_PRECIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_CATEGORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(73, 13)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(347, 20)
        Me.TXT_NOMBRE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Categoria (Solo Profit)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Linea/Grupo Servicio"
        '
        'TXT_TIPO
        '
        Me.TXT_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO.FormattingEnabled = True
        Me.TXT_TIPO.Items.AddRange(New Object() {"Servicio", "Ctr Inventario"})
        Me.TXT_TIPO.Location = New System.Drawing.Point(16, 66)
        Me.TXT_TIPO.Name = "TXT_TIPO"
        Me.TXT_TIPO.Size = New System.Drawing.Size(167, 21)
        Me.TXT_TIPO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo (Solo Profit)"
        '
        'TXT_CAT
        '
        Me.TXT_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_CAT.DropDownWidth = 250
        Me.TXT_CAT.FormattingEnabled = True
        Me.TXT_CAT.ItemHeight = 13
        Me.TXT_CAT.Location = New System.Drawing.Point(197, 167)
        Me.TXT_CAT.Name = "TXT_CAT"
        Me.TXT_CAT.Size = New System.Drawing.Size(167, 21)
        Me.TXT_CAT.TabIndex = 8
        '
        'TXT_LIN
        '
        Me.TXT_LIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_LIN.DropDownWidth = 250
        Me.TXT_LIN.FormattingEnabled = True
        Me.TXT_LIN.Location = New System.Drawing.Point(15, 122)
        Me.TXT_LIN.Name = "TXT_LIN"
        Me.TXT_LIN.Size = New System.Drawing.Size(167, 21)
        Me.TXT_LIN.TabIndex = 9
        '
        'TXT_SUB
        '
        Me.TXT_SUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_SUB.DropDownWidth = 250
        Me.TXT_SUB.FormattingEnabled = True
        Me.TXT_SUB.Location = New System.Drawing.Point(197, 121)
        Me.TXT_SUB.Name = "TXT_SUB"
        Me.TXT_SUB.Size = New System.Drawing.Size(167, 21)
        Me.TXT_SUB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sub-Linea/Tipo Servicio"
        '
        'TXT_COL
        '
        Me.TXT_COL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_COL.DropDownWidth = 250
        Me.TXT_COL.FormattingEnabled = True
        Me.TXT_COL.Location = New System.Drawing.Point(19, 167)
        Me.TXT_COL.Name = "TXT_COL"
        Me.TXT_COL.Size = New System.Drawing.Size(167, 21)
        Me.TXT_COL.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Color/Especialidad"
        '
        'GRID_PRECIO
        '
        Me.GRID_PRECIO.AllowUserToAddRows = False
        Me.GRID_PRECIO.AllowUserToDeleteRows = False
        Me.GRID_PRECIO.AllowUserToOrderColumns = True
        Me.GRID_PRECIO.AllowUserToResizeColumns = False
        Me.GRID_PRECIO.AllowUserToResizeRows = False
        Me.GRID_PRECIO.BackgroundColor = System.Drawing.Color.White
        Me.GRID_PRECIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_PRECIO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_PRECIO.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_PRECIO.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_PRECIO.Location = New System.Drawing.Point(15, 199)
        Me.GRID_PRECIO.Name = "GRID_PRECIO"
        Me.GRID_PRECIO.RowHeadersVisible = False
        Me.GRID_PRECIO.Size = New System.Drawing.Size(421, 166)
        Me.GRID_PRECIO.TabIndex = 14
        '
        'Column3
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Codigo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Baremo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 170
        '
        'Column2
        '
        '
        '
        '
        Me.Column2.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column2.HeaderText = "Precio$"
        Me.Column2.Increment = 1
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 150
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(332, 399)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(104, 47)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 15
        Me.ButtonX1.Text = "Guardar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(19, 399)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(104, 47)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 16
        Me.ButtonX2.Text = "Salir"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(180, 399)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(104, 47)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 17
        Me.ButtonX3.Text = "Restablecer"
        '
        'TXT_TIPO_MEDI
        '
        Me.TXT_TIPO_MEDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO_MEDI.DropDownWidth = 250
        Me.TXT_TIPO_MEDI.FormattingEnabled = True
        Me.TXT_TIPO_MEDI.Location = New System.Drawing.Point(197, 66)
        Me.TXT_TIPO_MEDI.Name = "TXT_TIPO_MEDI"
        Me.TXT_TIPO_MEDI.Size = New System.Drawing.Size(167, 21)
        Me.TXT_TIPO_MEDI.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tipo (Solo MediSoftware)"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(376, 151)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(60, 37)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 20
        Me.ButtonX4.Text = "Actualiza Maestros"
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 467)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.TXT_TIPO_MEDI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GRID_PRECIO)
        Me.Controls.Add(Me.TXT_COL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_SUB)
        Me.Controls.Add(Me.TXT_LIN)
        Me.Controls.Add(Me.TXT_CAT)
        Me.Controls.Add(Me.TXT_TIPO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo/Servicio"
        CType(Me.GRID_PRECIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_CATEGORIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_CAT As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_LIN As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_SUB As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_COL As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GRID_PRECIO As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents BS_CATEGORIA As System.Windows.Forms.BindingSource
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_TIPO_MEDI As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
End Class
