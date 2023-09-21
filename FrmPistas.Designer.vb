<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPistas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPistas))
        Me.GRID = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CousDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaquinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TablaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdfilaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CamposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PISTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.PISTASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.PISTASTableAdapter
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PISTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.AutoGenerateColumns = False
        Me.GRID.BackgroundColor = System.Drawing.Color.White
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CousDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.MaquinaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.TablaDataGridViewTextBoxColumn, Me.IdfilaDataGridViewTextBoxColumn, Me.CamposDataGridViewTextBoxColumn})
        Me.GRID.DataSource = Me.PISTASBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID.Location = New System.Drawing.Point(0, 0)
        Me.GRID.MultiSelect = False
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.Size = New System.Drawing.Size(630, 435)
        Me.GRID.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'CousDataGridViewTextBoxColumn
        '
        Me.CousDataGridViewTextBoxColumn.DataPropertyName = "co_us"
        Me.CousDataGridViewTextBoxColumn.HeaderText = "co_us"
        Me.CousDataGridViewTextBoxColumn.Name = "CousDataGridViewTextBoxColumn"
        Me.CousDataGridViewTextBoxColumn.ReadOnly = True
        Me.CousDataGridViewTextBoxColumn.Width = 80
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'MaquinaDataGridViewTextBoxColumn
        '
        Me.MaquinaDataGridViewTextBoxColumn.DataPropertyName = "maquina"
        Me.MaquinaDataGridViewTextBoxColumn.HeaderText = "maquina"
        Me.MaquinaDataGridViewTextBoxColumn.Name = "MaquinaDataGridViewTextBoxColumn"
        Me.MaquinaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaquinaDataGridViewTextBoxColumn.Width = 150
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 30
        '
        'TablaDataGridViewTextBoxColumn
        '
        Me.TablaDataGridViewTextBoxColumn.DataPropertyName = "tabla"
        Me.TablaDataGridViewTextBoxColumn.HeaderText = "tabla"
        Me.TablaDataGridViewTextBoxColumn.Name = "TablaDataGridViewTextBoxColumn"
        Me.TablaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdfilaDataGridViewTextBoxColumn
        '
        Me.IdfilaDataGridViewTextBoxColumn.DataPropertyName = "id_fila"
        Me.IdfilaDataGridViewTextBoxColumn.HeaderText = "id_fila"
        Me.IdfilaDataGridViewTextBoxColumn.Name = "IdfilaDataGridViewTextBoxColumn"
        Me.IdfilaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdfilaDataGridViewTextBoxColumn.Width = 80
        '
        'CamposDataGridViewTextBoxColumn
        '
        Me.CamposDataGridViewTextBoxColumn.DataPropertyName = "campos"
        Me.CamposDataGridViewTextBoxColumn.HeaderText = "campos"
        Me.CamposDataGridViewTextBoxColumn.Name = "CamposDataGridViewTextBoxColumn"
        Me.CamposDataGridViewTextBoxColumn.ReadOnly = True
        Me.CamposDataGridViewTextBoxColumn.Width = 500
        '
        'PISTASBindingSource
        '
        Me.PISTASBindingSource.DataMember = "PISTAS"
        Me.PISTASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PISTASTableAdapter
        '
        Me.PISTASTableAdapter.ClearBeforeFill = True
        '
        'FrmPistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 435)
        Me.Controls.Add(Me.GRID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPistas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPistas"
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PISTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRID As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents PISTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PISTASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.PISTASTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CousDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TablaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdfilaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CamposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
