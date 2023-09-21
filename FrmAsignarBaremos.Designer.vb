<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarBaremos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarBaremos))
        Me.GRID_PACIENTES = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.id_relacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_aseguradora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_aseguradora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_dependencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_dependencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_baremo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.baremo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actualizar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TXT_ID_ASEGURADORA = New System.Windows.Forms.TextBox
        Me.TXT_ASEGURADORA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_GRUPO = New System.Windows.Forms.TextBox
        Me.TXT_ID_GRUPO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_EMPRESA = New System.Windows.Forms.TextBox
        Me.TXT_ID_EMPRESA = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_DEPENDENCIA = New System.Windows.Forms.TextBox
        Me.TXT_ID_DEPENDENCIA = New System.Windows.Forms.TextBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.L_BAREMO = New System.Windows.Forms.Label
        Me.TXT_BAREMO = New System.Windows.Forms.TextBox
        Me.TXT_FILTRO = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.CH_ALL = New System.Windows.Forms.CheckBox
        Me.TXT_ID_BAREMO = New System.Windows.Forms.TextBox
        Me.CK_SIN_ASEGURAR = New System.Windows.Forms.CheckBox
        CType(Me.GRID_PACIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID_PACIENTES
        '
        Me.GRID_PACIENTES.AllowUserToAddRows = False
        Me.GRID_PACIENTES.AllowUserToDeleteRows = False
        Me.GRID_PACIENTES.AllowUserToResizeRows = False
        Me.GRID_PACIENTES.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_PACIENTES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_PACIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_PACIENTES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_relacion, Me.id_cliente, Me.nombre, Me.id_aseguradora, Me.nombre_aseguradora, Me.id_empresa, Me.nombre_empresa, Me.id_dependencia, Me.nombre_dependencia, Me.id_baremo, Me.baremo, Me.actualizar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_PACIENTES.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_PACIENTES.EnableHeadersVisualStyles = False
        Me.GRID_PACIENTES.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_PACIENTES.Location = New System.Drawing.Point(17, 197)
        Me.GRID_PACIENTES.Name = "GRID_PACIENTES"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_PACIENTES.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_PACIENTES.RowHeadersVisible = False
        Me.GRID_PACIENTES.Size = New System.Drawing.Size(872, 247)
        Me.GRID_PACIENTES.TabIndex = 0
        '
        'id_relacion
        '
        Me.id_relacion.HeaderText = "id"
        Me.id_relacion.Name = "id_relacion"
        Me.id_relacion.Visible = False
        '
        'id_cliente
        '
        Me.id_cliente.HeaderText = "id_cliente"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "CI - Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nombre.Width = 200
        '
        'id_aseguradora
        '
        Me.id_aseguradora.HeaderText = "id_aseguradora"
        Me.id_aseguradora.Name = "id_aseguradora"
        Me.id_aseguradora.Visible = False
        '
        'nombre_aseguradora
        '
        Me.nombre_aseguradora.HeaderText = "Aseguradora"
        Me.nombre_aseguradora.Name = "nombre_aseguradora"
        Me.nombre_aseguradora.Width = 200
        '
        'id_empresa
        '
        Me.id_empresa.HeaderText = "id_empresa"
        Me.id_empresa.Name = "id_empresa"
        Me.id_empresa.Visible = False
        '
        'nombre_empresa
        '
        Me.nombre_empresa.HeaderText = "Empresa"
        Me.nombre_empresa.Name = "nombre_empresa"
        Me.nombre_empresa.Width = 200
        '
        'id_dependencia
        '
        Me.id_dependencia.HeaderText = "id_dependencia"
        Me.id_dependencia.Name = "id_dependencia"
        Me.id_dependencia.Visible = False
        '
        'nombre_dependencia
        '
        Me.nombre_dependencia.HeaderText = "Dependencia"
        Me.nombre_dependencia.Name = "nombre_dependencia"
        '
        'id_baremo
        '
        Me.id_baremo.HeaderText = "id_baremo"
        Me.id_baremo.Name = "id_baremo"
        Me.id_baremo.ReadOnly = True
        Me.id_baremo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_baremo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id_baremo.Visible = False
        '
        'baremo
        '
        Me.baremo.HeaderText = "Baremo actual"
        Me.baremo.Name = "baremo"
        Me.baremo.ReadOnly = True
        Me.baremo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.baremo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'actualizar
        '
        Me.actualizar.HeaderText = "Aplica"
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Width = 40
        '
        'TXT_ID_ASEGURADORA
        '
        Me.TXT_ID_ASEGURADORA.Location = New System.Drawing.Point(150, 11)
        Me.TXT_ID_ASEGURADORA.Name = "TXT_ID_ASEGURADORA"
        Me.TXT_ID_ASEGURADORA.Size = New System.Drawing.Size(57, 20)
        Me.TXT_ID_ASEGURADORA.TabIndex = 1
        '
        'TXT_ASEGURADORA
        '
        Me.TXT_ASEGURADORA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_ASEGURADORA.Location = New System.Drawing.Point(213, 12)
        Me.TXT_ASEGURADORA.Name = "TXT_ASEGURADORA"
        Me.TXT_ASEGURADORA.ReadOnly = True
        Me.TXT_ASEGURADORA.Size = New System.Drawing.Size(459, 20)
        Me.TXT_ASEGURADORA.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aseguradora"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(44, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grupo de empresas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_GRUPO
        '
        Me.TXT_GRUPO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_GRUPO.Location = New System.Drawing.Point(213, 38)
        Me.TXT_GRUPO.Name = "TXT_GRUPO"
        Me.TXT_GRUPO.ReadOnly = True
        Me.TXT_GRUPO.Size = New System.Drawing.Size(459, 20)
        Me.TXT_GRUPO.TabIndex = 5
        '
        'TXT_ID_GRUPO
        '
        Me.TXT_ID_GRUPO.Location = New System.Drawing.Point(150, 37)
        Me.TXT_ID_GRUPO.Name = "TXT_ID_GRUPO"
        Me.TXT_ID_GRUPO.Size = New System.Drawing.Size(57, 20)
        Me.TXT_ID_GRUPO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(44, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Empresa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_EMPRESA
        '
        Me.TXT_EMPRESA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_EMPRESA.Location = New System.Drawing.Point(213, 64)
        Me.TXT_EMPRESA.Name = "TXT_EMPRESA"
        Me.TXT_EMPRESA.ReadOnly = True
        Me.TXT_EMPRESA.Size = New System.Drawing.Size(459, 20)
        Me.TXT_EMPRESA.TabIndex = 8
        '
        'TXT_ID_EMPRESA
        '
        Me.TXT_ID_EMPRESA.Location = New System.Drawing.Point(150, 63)
        Me.TXT_ID_EMPRESA.Name = "TXT_ID_EMPRESA"
        Me.TXT_ID_EMPRESA.Size = New System.Drawing.Size(57, 20)
        Me.TXT_ID_EMPRESA.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(44, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Dependencia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_DEPENDENCIA
        '
        Me.TXT_DEPENDENCIA.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_DEPENDENCIA.Location = New System.Drawing.Point(213, 90)
        Me.TXT_DEPENDENCIA.Name = "TXT_DEPENDENCIA"
        Me.TXT_DEPENDENCIA.ReadOnly = True
        Me.TXT_DEPENDENCIA.Size = New System.Drawing.Size(459, 20)
        Me.TXT_DEPENDENCIA.TabIndex = 11
        '
        'TXT_ID_DEPENDENCIA
        '
        Me.TXT_ID_DEPENDENCIA.Location = New System.Drawing.Point(150, 89)
        Me.TXT_ID_DEPENDENCIA.Name = "TXT_ID_DEPENDENCIA"
        Me.TXT_ID_DEPENDENCIA.Size = New System.Drawing.Size(57, 20)
        Me.TXT_ID_DEPENDENCIA.TabIndex = 10
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(782, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(84, 45)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 13
        Me.ButtonX1.Text = "Buscar Trabajadores"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(17, 169)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(45, 22)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 14
        Me.ButtonX2.Text = "Todo"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(821, 450)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(68, 37)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 15
        '
        'L_BAREMO
        '
        Me.L_BAREMO.Location = New System.Drawing.Point(44, 116)
        Me.L_BAREMO.Name = "L_BAREMO"
        Me.L_BAREMO.Size = New System.Drawing.Size(100, 17)
        Me.L_BAREMO.TabIndex = 18
        Me.L_BAREMO.Text = "Nuevo baremo"
        Me.L_BAREMO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_BAREMO
        '
        Me.TXT_BAREMO.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_BAREMO.Location = New System.Drawing.Point(213, 116)
        Me.TXT_BAREMO.Name = "TXT_BAREMO"
        Me.TXT_BAREMO.ReadOnly = True
        Me.TXT_BAREMO.Size = New System.Drawing.Size(459, 20)
        Me.TXT_BAREMO.TabIndex = 17
        '
        'TXT_FILTRO
        '
        Me.TXT_FILTRO.Location = New System.Drawing.Point(213, 169)
        Me.TXT_FILTRO.Name = "TXT_FILTRO"
        Me.TXT_FILTRO.Size = New System.Drawing.Size(459, 20)
        Me.TXT_FILTRO.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(163, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Filtrar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(782, 79)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(84, 45)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 21
        Me.ButtonX4.Text = "Buscar Particulares"
        '
        'CH_ALL
        '
        Me.CH_ALL.AutoSize = True
        Me.CH_ALL.Checked = True
        Me.CH_ALL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CH_ALL.Location = New System.Drawing.Point(68, 175)
        Me.CH_ALL.Name = "CH_ALL"
        Me.CH_ALL.Size = New System.Drawing.Size(15, 14)
        Me.CH_ALL.TabIndex = 22
        Me.CH_ALL.UseVisualStyleBackColor = True
        Me.CH_ALL.Visible = False
        '
        'TXT_ID_BAREMO
        '
        Me.TXT_ID_BAREMO.BackColor = System.Drawing.SystemColors.Window
        Me.TXT_ID_BAREMO.Location = New System.Drawing.Point(150, 116)
        Me.TXT_ID_BAREMO.Name = "TXT_ID_BAREMO"
        Me.TXT_ID_BAREMO.Size = New System.Drawing.Size(57, 20)
        Me.TXT_ID_BAREMO.TabIndex = 23
        '
        'CK_SIN_ASEGURAR
        '
        Me.CK_SIN_ASEGURAR.AutoSize = True
        Me.CK_SIN_ASEGURAR.Location = New System.Drawing.Point(678, 14)
        Me.CK_SIN_ASEGURAR.Name = "CK_SIN_ASEGURAR"
        Me.CK_SIN_ASEGURAR.Size = New System.Drawing.Size(85, 17)
        Me.CK_SIN_ASEGURAR.TabIndex = 24
        Me.CK_SIN_ASEGURAR.Text = "Sin asegurar"
        Me.CK_SIN_ASEGURAR.UseVisualStyleBackColor = True
        '
        'FrmAsignarBaremos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 499)
        Me.Controls.Add(Me.CK_SIN_ASEGURAR)
        Me.Controls.Add(Me.TXT_ID_BAREMO)
        Me.Controls.Add(Me.CH_ALL)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_FILTRO)
        Me.Controls.Add(Me.L_BAREMO)
        Me.Controls.Add(Me.TXT_BAREMO)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_DEPENDENCIA)
        Me.Controls.Add(Me.TXT_ID_DEPENDENCIA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_EMPRESA)
        Me.Controls.Add(Me.TXT_ID_EMPRESA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_GRUPO)
        Me.Controls.Add(Me.TXT_ID_GRUPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_ASEGURADORA)
        Me.Controls.Add(Me.TXT_ID_ASEGURADORA)
        Me.Controls.Add(Me.GRID_PACIENTES)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAsignarBaremos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Baremos"
        CType(Me.GRID_PACIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID_PACIENTES As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TXT_ID_ASEGURADORA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ASEGURADORA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_GRUPO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID_GRUPO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_EMPRESA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID_EMPRESA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_DEPENDENCIA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID_DEPENDENCIA As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents L_BAREMO As System.Windows.Forms.Label
    Friend WithEvents TXT_BAREMO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FILTRO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id_relacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_aseguradora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_aseguradora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_dependencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_dependencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_baremo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baremo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actualizar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CH_ALL As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_ID_BAREMO As System.Windows.Forms.TextBox
    Friend WithEvents CK_SIN_ASEGURAR As System.Windows.Forms.CheckBox
End Class
