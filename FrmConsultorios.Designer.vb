<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultorios))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GRID_LISTADO = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_STATUS = New System.Windows.Forms.TextBox
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_EMPRESAS = New System.Windows.Forms.DataGridView
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        Me.TXT_CIU = New System.Windows.Forms.ComboBox
        Me.TXT_EDO = New System.Windows.Forms.ComboBox
        Me.TXT_TLF = New System.Windows.Forms.TextBox
        Me.TXT_DIR = New System.Windows.Forms.TextBox
        Me.TXT_DES = New System.Windows.Forms.TextBox
        Me.TXT_NOM = New System.Windows.Forms.TextBox
        Me.TXT_EXT = New System.Windows.Forms.TextBox
        Me.TXT_RIF = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GRID_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GRID_EMPRESAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(961, 430)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GRID_LISTADO)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(953, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agencias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GRID_LISTADO
        '
        Me.GRID_LISTADO.AllowUserToAddRows = False
        Me.GRID_LISTADO.AllowUserToDeleteRows = False
        Me.GRID_LISTADO.AllowUserToResizeColumns = False
        Me.GRID_LISTADO.AllowUserToResizeRows = False
        Me.GRID_LISTADO.BackgroundColor = System.Drawing.Color.White
        Me.GRID_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_LISTADO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_LISTADO.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_LISTADO.Location = New System.Drawing.Point(6, 6)
        Me.GRID_LISTADO.Name = "GRID_LISTADO"
        Me.GRID_LISTADO.ReadOnly = True
        Me.GRID_LISTADO.RowHeadersWidth = 15
        Me.GRID_LISTADO.Size = New System.Drawing.Size(872, 392)
        Me.GRID_LISTADO.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Rif"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Direccion"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TXT_CODIGO)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.ButtonX1)
        Me.TabPage2.Controls.Add(Me.GRID_EMPRESAS)
        Me.TabPage2.Controls.Add(Me.TXT_CIU)
        Me.TabPage2.Controls.Add(Me.TXT_EDO)
        Me.TabPage2.Controls.Add(Me.TXT_TLF)
        Me.TabPage2.Controls.Add(Me.TXT_DIR)
        Me.TabPage2.Controls.Add(Me.TXT_DES)
        Me.TabPage2.Controls.Add(Me.TXT_NOM)
        Me.TabPage2.Controls.Add(Me.TXT_EXT)
        Me.TabPage2.Controls.Add(Me.TXT_RIF)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(953, 404)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonX2)
        Me.Panel1.Controls.Add(Me.TXT_STATUS)
        Me.Panel1.Controls.Add(Me.ButtonX4)
        Me.Panel1.Controls.Add(Me.ButtonX3)
        Me.Panel1.Location = New System.Drawing.Point(10, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 354)
        Me.Panel1.TabIndex = 24
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(15, 91)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(54, 46)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolSize = 20.0!
        Me.ButtonX2.TabIndex = 18
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'TXT_STATUS
        '
        Me.TXT_STATUS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_STATUS.Location = New System.Drawing.Point(5, 311)
        Me.TXT_STATUS.Name = "TXT_STATUS"
        Me.TXT_STATUS.ReadOnly = True
        Me.TXT_STATUS.Size = New System.Drawing.Size(70, 20)
        Me.TXT_STATUS.TabIndex = 22
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(15, 18)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(54, 46)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.SymbolSize = 20.0!
        Me.ButtonX4.TabIndex = 23
        Me.ButtonX4.Tooltip = "Nuevo"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(15, 259)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(54, 46)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolSize = 20.0!
        Me.ButtonX3.TabIndex = 21
        Me.ButtonX3.Tooltip = "Activar/Desactivar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(446, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Empresas Asociadas"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CODIGO.Location = New System.Drawing.Point(181, 32)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.ReadOnly = True
        Me.TXT_CODIGO.Size = New System.Drawing.Size(258, 20)
        Me.TXT_CODIGO.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Codigo"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(893, 25)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(42, 32)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 20.0!
        Me.ButtonX1.TabIndex = 17
        Me.ButtonX1.Tooltip = "Agregar"
        '
        'GRID_EMPRESAS
        '
        Me.GRID_EMPRESAS.AllowUserToAddRows = False
        Me.GRID_EMPRESAS.AllowUserToDeleteRows = False
        Me.GRID_EMPRESAS.AllowUserToResizeColumns = False
        Me.GRID_EMPRESAS.AllowUserToResizeRows = False
        Me.GRID_EMPRESAS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_EMPRESAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_EMPRESAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_EMPRESAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_EMPRESAS.Location = New System.Drawing.Point(449, 60)
        Me.GRID_EMPRESAS.Name = "GRID_EMPRESAS"
        Me.GRID_EMPRESAS.ReadOnly = True
        Me.GRID_EMPRESAS.RowHeadersWidth = 10
        Me.GRID_EMPRESAS.Size = New System.Drawing.Size(488, 320)
        Me.GRID_EMPRESAS.TabIndex = 16
        '
        'Column6
        '
        Me.Column6.HeaderText = "Codigo"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Rif"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 120
        '
        'Column8
        '
        Me.Column8.HeaderText = "Nombre"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 200
        '
        'Column9
        '
        Me.Column9.HeaderText = "Del"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Text = Nothing
        Me.Column9.Width = 40
        '
        'TXT_CIU
        '
        Me.TXT_CIU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_CIU.FormattingEnabled = True
        Me.TXT_CIU.Location = New System.Drawing.Point(181, 359)
        Me.TXT_CIU.Name = "TXT_CIU"
        Me.TXT_CIU.Size = New System.Drawing.Size(258, 21)
        Me.TXT_CIU.TabIndex = 10
        '
        'TXT_EDO
        '
        Me.TXT_EDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_EDO.FormattingEnabled = True
        Me.TXT_EDO.Location = New System.Drawing.Point(181, 319)
        Me.TXT_EDO.Name = "TXT_EDO"
        Me.TXT_EDO.Size = New System.Drawing.Size(258, 21)
        Me.TXT_EDO.TabIndex = 9
        '
        'TXT_TLF
        '
        Me.TXT_TLF.Location = New System.Drawing.Point(181, 278)
        Me.TXT_TLF.Name = "TXT_TLF"
        Me.TXT_TLF.Size = New System.Drawing.Size(258, 20)
        Me.TXT_TLF.TabIndex = 8
        '
        'TXT_DIR
        '
        Me.TXT_DIR.Location = New System.Drawing.Point(181, 232)
        Me.TXT_DIR.Multiline = True
        Me.TXT_DIR.Name = "TXT_DIR"
        Me.TXT_DIR.Size = New System.Drawing.Size(258, 40)
        Me.TXT_DIR.TabIndex = 7
        '
        'TXT_DES
        '
        Me.TXT_DES.Location = New System.Drawing.Point(181, 186)
        Me.TXT_DES.Multiline = True
        Me.TXT_DES.Name = "TXT_DES"
        Me.TXT_DES.Size = New System.Drawing.Size(258, 40)
        Me.TXT_DES.TabIndex = 6
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(181, 143)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(258, 20)
        Me.TXT_NOM.TabIndex = 5
        '
        'TXT_EXT
        '
        Me.TXT_EXT.Location = New System.Drawing.Point(181, 105)
        Me.TXT_EXT.Name = "TXT_EXT"
        Me.TXT_EXT.Size = New System.Drawing.Size(258, 20)
        Me.TXT_EXT.TabIndex = 4
        '
        'TXT_RIF
        '
        Me.TXT_RIF.Location = New System.Drawing.Point(181, 70)
        Me.TXT_RIF.Name = "TXT_RIF"
        Me.TXT_RIF.Size = New System.Drawing.Size(258, 20)
        Me.TXT_RIF.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CodExterno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ciudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rif"
        '
        'FrmConsultorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 454)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultorios/Agencias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GRID_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GRID_EMPRESAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GRID_LISTADO As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_CIU As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_EDO As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_TLF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DIR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DES As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOM As System.Windows.Forms.TextBox
    Friend WithEvents TXT_EXT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_RIF As System.Windows.Forms.TextBox
    Friend WithEvents GRID_EMPRESAS As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_STATUS As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
End Class
