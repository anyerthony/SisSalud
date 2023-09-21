<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresas))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASGRUPOEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRUPOEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIUDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FORMATOSFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.EMPRESASTableAdapter
        Me.FORMATOS_FACTURATableAdapter = New SisSalud.DataSet_IPSSTableAdapters.FORMATOS_FACTURATableAdapter
        Me.PAISESTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.PAISESTableAdapter
        Me.ZONASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.ZONASTableAdapter
        Me.CIUDADESTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.CIUDADESTableAdapter
        Me.GRUPO_EMPRESASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.GRUPO_EMPRESASTableAdapter
        Me.EMPRESA_ASEGURADORATableAdapter = New SisSalud.DataSet_IPSSTableAdapters.EMPRESA_ASEGURADORATableAdapter
        Me.TAB_EMPRESA_ASEGURADORA = New System.Windows.Forms.TabPage
        Me.GRID_ASEGURADORAS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdaseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CousDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TXT_ID_BAREMO = New System.Windows.Forms.TextBox
        Me.ComboBoxEx5 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.TXT_DIAS_CRED = New System.Windows.Forms.TextBox
        Me.TXT_MONTO_POL = New System.Windows.Forms.TextBox
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TXT_DIRECCION = New System.Windows.Forms.TextBox
        Me.TXT_ID_CLIENTE = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.LISTA_FORMATOS_FACTURA = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.CK_CLAVE = New System.Windows.Forms.CheckBox
        Me.CK_EMPRESA = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TAB_TRABAJADORES = New System.Windows.Forms.TabPage
        Me.GRID_TRABAJADORES = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DEPENDENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESA_CLIENTETableAdapter = New SisSalud.DataSet_IPSSTableAdapters.EMPRESA_CLIENTETableAdapter
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.DEPENDENCIASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.DEPENDENCIASTableAdapter
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdempresaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CousDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_dependencia = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASGRUPOEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRUPOEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIUDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMATOSFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_EMPRESA_ASEGURADORA.SuspendLayout()
        CType(Me.GRID_ASEGURADORAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TAB_TRABAJADORES.SuspendLayout()
        CType(Me.GRID_TRABAJADORES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPENDENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource
        '
        'FKEMPRESACLIENTEEMPRESACLIENTEBindingSource
        '
        Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource.DataMember = "FK_EMPRESA_CLIENTE_EMPRESA_CLIENTE"
        Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource.DataSource = Me.EMPRESASBindingSource
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource
        '
        Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource.DataMember = "FK_EMPRESA_ASEGURADORA_EMPRESA_ASEGURADORA"
        Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource.DataSource = Me.EMPRESASBindingSource
        '
        'EMPRESASGRUPOEMPRESASBindingSource
        '
        Me.EMPRESASGRUPOEMPRESASBindingSource.DataMember = "EMPRESAS_GRUPO_EMPRESAS"
        Me.EMPRESASGRUPOEMPRESASBindingSource.DataSource = Me.EMPRESASBindingSource
        '
        'GRUPOEMPRESASBindingSource
        '
        Me.GRUPOEMPRESASBindingSource.DataMember = "GRUPO_EMPRESAS"
        Me.GRUPOEMPRESASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'CIUDADESBindingSource
        '
        Me.CIUDADESBindingSource.DataMember = "CIUDADES"
        Me.CIUDADESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'ZONASBindingSource
        '
        Me.ZONASBindingSource.DataMember = "ZONAS"
        Me.ZONASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'PAISESBindingSource
        '
        Me.PAISESBindingSource.DataMember = "PAISES"
        Me.PAISESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'FORMATOSFACTURABindingSource
        '
        Me.FORMATOSFACTURABindingSource.DataMember = "FORMATOS_FACTURA"
        Me.FORMATOSFACTURABindingSource.DataSource = Me.DataSet_IPSS
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FORMATOS_FACTURATableAdapter
        '
        Me.FORMATOS_FACTURATableAdapter.ClearBeforeFill = True
        '
        'PAISESTableAdapter
        '
        Me.PAISESTableAdapter.ClearBeforeFill = True
        '
        'ZONASTableAdapter
        '
        Me.ZONASTableAdapter.ClearBeforeFill = True
        '
        'CIUDADESTableAdapter
        '
        Me.CIUDADESTableAdapter.ClearBeforeFill = True
        '
        'GRUPO_EMPRESASTableAdapter
        '
        Me.GRUPO_EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'EMPRESA_ASEGURADORATableAdapter
        '
        Me.EMPRESA_ASEGURADORATableAdapter.ClearBeforeFill = True
        '
        'TAB_EMPRESA_ASEGURADORA
        '
        Me.TAB_EMPRESA_ASEGURADORA.Controls.Add(Me.GRID_ASEGURADORAS)
        Me.TAB_EMPRESA_ASEGURADORA.Location = New System.Drawing.Point(4, 22)
        Me.TAB_EMPRESA_ASEGURADORA.Name = "TAB_EMPRESA_ASEGURADORA"
        Me.TAB_EMPRESA_ASEGURADORA.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_EMPRESA_ASEGURADORA.Size = New System.Drawing.Size(564, 479)
        Me.TAB_EMPRESA_ASEGURADORA.TabIndex = 1
        Me.TAB_EMPRESA_ASEGURADORA.Text = "Aseguradoras contratadas"
        Me.TAB_EMPRESA_ASEGURADORA.UseVisualStyleBackColor = True
        '
        'GRID_ASEGURADORAS
        '
        Me.GRID_ASEGURADORAS.AutoGenerateColumns = False
        Me.GRID_ASEGURADORAS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_ASEGURADORAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_ASEGURADORAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdempresaDataGridViewTextBoxColumn, Me.IdaseguradoraDataGridViewTextBoxColumn, Me.CousDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2})
        Me.GRID_ASEGURADORAS.DataSource = Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_ASEGURADORAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_ASEGURADORAS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_ASEGURADORAS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_ASEGURADORAS.Location = New System.Drawing.Point(3, 3)
        Me.GRID_ASEGURADORAS.Name = "GRID_ASEGURADORAS"
        Me.GRID_ASEGURADORAS.RowHeadersWidth = 20
        Me.GRID_ASEGURADORAS.Size = New System.Drawing.Size(558, 473)
        Me.GRID_ASEGURADORAS.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdempresaDataGridViewTextBoxColumn
        '
        Me.IdempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa"
        Me.IdempresaDataGridViewTextBoxColumn.HeaderText = "id_empresa"
        Me.IdempresaDataGridViewTextBoxColumn.Name = "IdempresaDataGridViewTextBoxColumn"
        Me.IdempresaDataGridViewTextBoxColumn.Visible = False
        '
        'IdaseguradoraDataGridViewTextBoxColumn
        '
        Me.IdaseguradoraDataGridViewTextBoxColumn.DataPropertyName = "id_aseguradora"
        Me.IdaseguradoraDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdaseguradoraDataGridViewTextBoxColumn.Name = "IdaseguradoraDataGridViewTextBoxColumn"
        Me.IdaseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdaseguradoraDataGridViewTextBoxColumn.Width = 30
        '
        'CousDataGridViewTextBoxColumn
        '
        Me.CousDataGridViewTextBoxColumn.DataPropertyName = "co_us"
        Me.CousDataGridViewTextBoxColumn.HeaderText = "co_us"
        Me.CousDataGridViewTextBoxColumn.Name = "CousDataGridViewTextBoxColumn"
        Me.CousDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "auxiliar"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.TXT_ID_BAREMO)
        Me.TabPage1.Controls.Add(Me.ComboBoxEx5)
        Me.TabPage1.Controls.Add(Me.TXT_DIAS_CRED)
        Me.TabPage1.Controls.Add(Me.TXT_MONTO_POL)
        Me.TabPage1.Controls.Add(Me.ComboBoxEx2)
        Me.TabPage1.Controls.Add(Me.ComboBoxEx1)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TXT_DIRECCION)
        Me.TabPage1.Controls.Add(Me.TXT_ID_CLIENTE)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.LISTA_FORMATOS_FACTURA)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.BTN_BUSCAR)
        Me.TabPage1.Controls.Add(Me.BTN_ELIMINAR)
        Me.TabPage1.Controls.Add(Me.BTN_GUARDAR)
        Me.TabPage1.Controls.Add(Me.BTN_NUEVO)
        Me.TabPage1.Controls.Add(Me.CK_CLAVE)
        Me.TabPage1.Controls.Add(Me.CK_EMPRESA)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Nombre)
        Me.TabPage1.Controls.Add(Me.ButtonX1)
        Me.TabPage1.Controls.Add(Me.CheckBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información básica"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASGRUPOEMPRESASBindingSource, "nombre", True))
        Me.TextBox12.Location = New System.Drawing.Point(233, 291)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(263, 20)
        Me.TextBox12.TabIndex = 183
        '
        'TXT_ID_BAREMO
        '
        Me.TXT_ID_BAREMO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "id_grupo", True))
        Me.TXT_ID_BAREMO.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.GRUPOEMPRESASBindingSource, "id", True))
        Me.TXT_ID_BAREMO.Location = New System.Drawing.Point(143, 291)
        Me.TXT_ID_BAREMO.Name = "TXT_ID_BAREMO"
        Me.TXT_ID_BAREMO.Size = New System.Drawing.Size(84, 20)
        Me.TXT_ID_BAREMO.TabIndex = 182
        '
        'ComboBoxEx5
        '
        Me.ComboBoxEx5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPRESASBindingSource, "id_ciudad", True))
        Me.ComboBoxEx5.DataSource = Me.CIUDADESBindingSource
        Me.ComboBoxEx5.DisplayMember = "nombre"
        Me.ComboBoxEx5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx5.FormattingEnabled = True
        Me.ComboBoxEx5.ItemHeight = 14
        Me.ComboBoxEx5.Location = New System.Drawing.Point(143, 162)
        Me.ComboBoxEx5.Name = "ComboBoxEx5"
        Me.ComboBoxEx5.Size = New System.Drawing.Size(156, 20)
        Me.ComboBoxEx5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx5.TabIndex = 179
        Me.ComboBoxEx5.ValueMember = "id"
        '
        'TXT_DIAS_CRED
        '
        Me.TXT_DIAS_CRED.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "dias_cred", True))
        Me.TXT_DIAS_CRED.Location = New System.Drawing.Point(143, 343)
        Me.TXT_DIAS_CRED.Name = "TXT_DIAS_CRED"
        Me.TXT_DIAS_CRED.Size = New System.Drawing.Size(84, 20)
        Me.TXT_DIAS_CRED.TabIndex = 177
        '
        'TXT_MONTO_POL
        '
        Me.TXT_MONTO_POL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "monto_poliza", True))
        Me.TXT_MONTO_POL.Location = New System.Drawing.Point(338, 343)
        Me.TXT_MONTO_POL.Name = "TXT_MONTO_POL"
        Me.TXT_MONTO_POL.Size = New System.Drawing.Size(158, 20)
        Me.TXT_MONTO_POL.TabIndex = 176
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPRESASBindingSource, "id_zona", True))
        Me.ComboBoxEx2.DataSource = Me.ZONASBindingSource
        Me.ComboBoxEx2.DisplayMember = "nombre"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 14
        Me.ComboBoxEx2.Location = New System.Drawing.Point(374, 136)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(122, 20)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 172
        Me.ComboBoxEx2.ValueMember = "id"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPRESASBindingSource, "id_pais", True))
        Me.ComboBoxEx1.DataSource = Me.PAISESBindingSource
        Me.ComboBoxEx1.DisplayMember = "nombre"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 14
        Me.ComboBoxEx1.Location = New System.Drawing.Point(143, 136)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(158, 20)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 171
        Me.ComboBoxEx1.ValueMember = "id"
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "rif", True))
        Me.TextBox11.Location = New System.Drawing.Point(143, 58)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(132, 20)
        Me.TextBox11.TabIndex = 168
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "tlfn_local", True))
        Me.TextBox7.Location = New System.Drawing.Point(322, 110)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(174, 20)
        Me.TextBox7.TabIndex = 166
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "tlfn", True))
        Me.TextBox5.Location = New System.Drawing.Point(143, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(158, 20)
        Me.TextBox5.TabIndex = 165
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "correo", True))
        Me.TextBox4.Location = New System.Drawing.Point(143, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(353, 20)
        Me.TextBox4.TabIndex = 164
        '
        'TXT_DIRECCION
        '
        Me.TXT_DIRECCION.AccessibleName = "Dirección"
        Me.TXT_DIRECCION.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "dir", True))
        Me.TXT_DIRECCION.Location = New System.Drawing.Point(143, 195)
        Me.TXT_DIRECCION.Multiline = True
        Me.TXT_DIRECCION.Name = "TXT_DIRECCION"
        Me.TXT_DIRECCION.Size = New System.Drawing.Size(353, 90)
        Me.TXT_DIRECCION.TabIndex = 163
        '
        'TXT_ID_CLIENTE
        '
        Me.TXT_ID_CLIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_ID_CLIENTE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "id", True))
        Me.TXT_ID_CLIENTE.Location = New System.Drawing.Point(143, 6)
        Me.TXT_ID_CLIENTE.Name = "TXT_ID_CLIENTE"
        Me.TXT_ID_CLIENTE.ReadOnly = True
        Me.TXT_ID_CLIENTE.Size = New System.Drawing.Size(90, 20)
        Me.TXT_ID_CLIENTE.TabIndex = 162
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(143, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(353, 20)
        Me.TextBox2.TabIndex = 161
        '
        'LISTA_FORMATOS_FACTURA
        '
        Me.LISTA_FORMATOS_FACTURA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPRESASBindingSource, "id_formato_factura", True))
        Me.LISTA_FORMATOS_FACTURA.DataSource = Me.FORMATOSFACTURABindingSource
        Me.LISTA_FORMATOS_FACTURA.DisplayMember = "nombre"
        Me.LISTA_FORMATOS_FACTURA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LISTA_FORMATOS_FACTURA.FormattingEnabled = True
        Me.LISTA_FORMATOS_FACTURA.ItemHeight = 14
        Me.LISTA_FORMATOS_FACTURA.Location = New System.Drawing.Point(374, 58)
        Me.LISTA_FORMATOS_FACTURA.Name = "LISTA_FORMATOS_FACTURA"
        Me.LISTA_FORMATOS_FACTURA.Size = New System.Drawing.Size(122, 20)
        Me.LISTA_FORMATOS_FACTURA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LISTA_FORMATOS_FACTURA.TabIndex = 160
        Me.LISTA_FORMATOS_FACTURA.ValueMember = "id"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(31, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "Grupo de empresas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EMPRESASBindingSource, "aseguradora", True))
        Me.CheckBox1.Location = New System.Drawing.Point(349, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 180
        Me.CheckBox1.Text = "Funge como aseguradora"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(74, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 178
        Me.Label14.Text = "Ciudad:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Monto de la póliza:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(305, 139)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 13)
        Me.Label29.TabIndex = 170
        Me.Label29.Text = "Zona:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(43, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "Pais:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "RIF:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_BUSCAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(239, 6)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(20, 20)
        Me.BTN_BUSCAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_BUSCAR.Symbol = ""
        Me.BTN_BUSCAR.SymbolSize = 12.0!
        Me.BTN_BUSCAR.TabIndex = 159
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ELIMINAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(239, 436)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(60, 34)
        Me.BTN_ELIMINAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ELIMINAR.Symbol = ""
        Me.BTN_ELIMINAR.TabIndex = 158
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_GUARDAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(436, 436)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(60, 34)
        Me.BTN_GUARDAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_GUARDAR.Symbol = ""
        Me.BTN_GUARDAR.TabIndex = 157
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_NUEVO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_NUEVO.Location = New System.Drawing.Point(338, 436)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(60, 34)
        Me.BTN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_NUEVO.Symbol = ""
        Me.BTN_NUEVO.TabIndex = 156
        '
        'CK_CLAVE
        '
        Me.CK_CLAVE.AutoSize = True
        Me.CK_CLAVE.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EMPRESASBindingSource, "print_clave", True))
        Me.CK_CLAVE.Location = New System.Drawing.Point(106, 401)
        Me.CK_CLAVE.Name = "CK_CLAVE"
        Me.CK_CLAVE.Size = New System.Drawing.Size(303, 17)
        Me.CK_CLAVE.TabIndex = 155
        Me.CK_CLAVE.Text = "Los documentos fiscales muestran la clave de autorización"
        Me.CK_CLAVE.UseVisualStyleBackColor = True
        '
        'CK_EMPRESA
        '
        Me.CK_EMPRESA.AutoSize = True
        Me.CK_EMPRESA.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EMPRESASBindingSource, "print_paciente", True))
        Me.CK_EMPRESA.Location = New System.Drawing.Point(107, 378)
        Me.CK_EMPRESA.Name = "CK_EMPRESA"
        Me.CK_EMPRESA.Size = New System.Drawing.Size(389, 17)
        Me.CK_EMPRESA.TabIndex = 154
        Me.CK_EMPRESA.Text = "Los documentos fiscales muestran la empresa a la que pertenece el paciente"
        Me.CK_EMPRESA.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Formato Factura:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(45, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "Días de Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Telf:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Correo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Dirección:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Razón Social:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(12, 9)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(121, 13)
        Me.Nombre.TabIndex = 147
        Me.Nombre.Text = "Codigo:"
        Me.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(143, 436)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(60, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 173
        Me.ButtonX1.Tooltip = "Activo"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EMPRESASBindingSource, "status", True))
        Me.CheckBox3.Location = New System.Drawing.Point(143, 436)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox3.TabIndex = 174
        Me.CheckBox3.Text = "Status"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TAB_EMPRESA_ASEGURADORA)
        Me.TabControl1.Controls.Add(Me.TAB_TRABAJADORES)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TAB_TRABAJADORES
        '
        Me.TAB_TRABAJADORES.Controls.Add(Me.GRID_TRABAJADORES)
        Me.TAB_TRABAJADORES.Location = New System.Drawing.Point(4, 22)
        Me.TAB_TRABAJADORES.Name = "TAB_TRABAJADORES"
        Me.TAB_TRABAJADORES.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_TRABAJADORES.Size = New System.Drawing.Size(564, 479)
        Me.TAB_TRABAJADORES.TabIndex = 2
        Me.TAB_TRABAJADORES.Text = "Trabajadores"
        Me.TAB_TRABAJADORES.UseVisualStyleBackColor = True
        '
        'GRID_TRABAJADORES
        '
        Me.GRID_TRABAJADORES.AutoGenerateColumns = False
        Me.GRID_TRABAJADORES.BackgroundColor = System.Drawing.Color.White
        Me.GRID_TRABAJADORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_TRABAJADORES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.IdempresaDataGridViewTextBoxColumn1, Me.IdCLIENTEDataGridViewTextBoxColumn, Me.CousDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.id_dependencia})
        Me.GRID_TRABAJADORES.DataSource = Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_TRABAJADORES.DefaultCellStyle = DataGridViewCellStyle4
        Me.GRID_TRABAJADORES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_TRABAJADORES.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_TRABAJADORES.Location = New System.Drawing.Point(3, 3)
        Me.GRID_TRABAJADORES.Name = "GRID_TRABAJADORES"
        Me.GRID_TRABAJADORES.RowHeadersWidth = 20
        Me.GRID_TRABAJADORES.Size = New System.Drawing.Size(558, 473)
        Me.GRID_TRABAJADORES.TabIndex = 1
        '
        'DEPENDENCIASBindingSource
        '
        Me.DEPENDENCIASBindingSource.DataMember = "DEPENDENCIAS"
        Me.DEPENDENCIASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'EMPRESASBindingSource1
        '
        Me.EMPRESASBindingSource1.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource1.DataSource = Me.DataSet_IPSS
        '
        'EMPRESA_CLIENTETableAdapter
        '
        Me.EMPRESA_CLIENTETableAdapter.ClearBeforeFill = True
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'CLIENTESTableAdapter
        '

        '
        'DEPENDENCIASTableAdapter
        '
        Me.DEPENDENCIASTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'IdempresaDataGridViewTextBoxColumn1
        '
        Me.IdempresaDataGridViewTextBoxColumn1.DataPropertyName = "id_empresa"
        Me.IdempresaDataGridViewTextBoxColumn1.HeaderText = "id_empresa"
        Me.IdempresaDataGridViewTextBoxColumn1.Name = "IdempresaDataGridViewTextBoxColumn1"
        Me.IdempresaDataGridViewTextBoxColumn1.Visible = False
        '
        'IdCLIENTEDataGridViewTextBoxColumn
        '
        Me.IdCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "id_CLIENTE"
        Me.IdCLIENTEDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdCLIENTEDataGridViewTextBoxColumn.Name = "IdCLIENTEDataGridViewTextBoxColumn"
        Me.IdCLIENTEDataGridViewTextBoxColumn.Width = 50
        '
        'CousDataGridViewTextBoxColumn1
        '
        Me.CousDataGridViewTextBoxColumn1.DataPropertyName = "co_us"
        Me.CousDataGridViewTextBoxColumn1.HeaderText = "co_us"
        Me.CousDataGridViewTextBoxColumn1.Name = "CousDataGridViewTextBoxColumn1"
        Me.CousDataGridViewTextBoxColumn1.Visible = False
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "auxiliar"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "CI - Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 350
        '
        'id_dependencia
        '
        Me.id_dependencia.DataPropertyName = "id_dependencia"
        Me.id_dependencia.DataSource = Me.DEPENDENCIASBindingSource
        Me.id_dependencia.DisplayMember = "nombre"
        Me.id_dependencia.DropDownHeight = 106
        Me.id_dependencia.DropDownWidth = 121
        Me.id_dependencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_dependencia.HeaderText = "Dependencia"
        Me.id_dependencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_dependencia.IntegralHeight = False
        Me.id_dependencia.ItemHeight = 15
        Me.id_dependencia.Name = "id_dependencia"
        Me.id_dependencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_dependencia.ValueMember = "id"
        '
        'FrmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKEMPRESACLIENTEEMPRESACLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASGRUPOEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRUPOEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIUDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMATOSFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_EMPRESA_ASEGURADORA.ResumeLayout(False)
        CType(Me.GRID_ASEGURADORAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TAB_TRABAJADORES.ResumeLayout(False)
        CType(Me.GRID_TRABAJADORES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPENDENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.EMPRESASTableAdapter
    Friend WithEvents FORMATOSFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMATOS_FACTURATableAdapter As SisSalud.DataSet_IPSSTableAdapters.FORMATOS_FACTURATableAdapter
    Friend WithEvents PAISESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAISESTableAdapter As SisSalud.DataSet_IPSSTableAdapters.PAISESTableAdapter
    Friend WithEvents ZONASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZONASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.ZONASTableAdapter
    Friend WithEvents CIUDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUDADESTableAdapter As SisSalud.DataSet_IPSSTableAdapters.CIUDADESTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASGRUPOEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GRUPO_EMPRESASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.GRUPO_EMPRESASTableAdapter
    Friend WithEvents GRUPOEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESA_ASEGURADORATableAdapter As SisSalud.DataSet_IPSSTableAdapters.EMPRESA_ASEGURADORATableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuxiliarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAB_EMPRESA_ASEGURADORA As System.Windows.Forms.TabPage
    Friend WithEvents GRID_ASEGURADORAS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID_BAREMO As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEx5 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TXT_DIAS_CRED As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MONTO_POL As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LISTA_FORMATOS_FACTURA As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CK_CLAVE As System.Windows.Forms.CheckBox
    Friend WithEvents CK_EMPRESA As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdempresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdaseguradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CousDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESASBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TAB_TRABAJADORES As System.Windows.Forms.TabPage
    Friend WithEvents GRID_TRABAJADORES As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents FKEMPRESACLIENTEEMPRESACLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESA_CLIENTETableAdapter As SisSalud.DataSet_IPSSTableAdapters.EMPRESA_CLIENTETableAdapter
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents DEPENDENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPENDENCIASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.DEPENDENCIASTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdempresaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CousDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_dependencia As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
End Class
