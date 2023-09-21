<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqueda))
        Me.GRID = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TXT_BUSQUEDA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RB_INICIO = New System.Windows.Forms.RadioButton
        Me.RB_ALL = New System.Windows.Forms.RadioButton
        Me.RB_EXACTA = New System.Windows.Forms.RadioButton
        Me.RB_COLUMN1 = New System.Windows.Forms.RadioButton
        Me.RB_COLUMN2 = New System.Windows.Forms.RadioButton
        Me.ButtonX7 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_OTRO = New System.Windows.Forms.RadioButton
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.BackgroundColor = System.Drawing.Color.White
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID.Location = New System.Drawing.Point(12, 55)
        Me.GRID.MultiSelect = False
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.Size = New System.Drawing.Size(407, 150)
        Me.GRID.TabIndex = 0
        '
        'TXT_BUSQUEDA
        '
        Me.TXT_BUSQUEDA.Location = New System.Drawing.Point(72, 15)
        Me.TXT_BUSQUEDA.Name = "TXT_BUSQUEDA"
        Me.TXT_BUSQUEDA.Size = New System.Drawing.Size(321, 20)
        Me.TXT_BUSQUEDA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'RB_INICIO
        '
        Me.RB_INICIO.AutoSize = True
        Me.RB_INICIO.Location = New System.Drawing.Point(14, 19)
        Me.RB_INICIO.Name = "RB_INICIO"
        Me.RB_INICIO.Size = New System.Drawing.Size(124, 17)
        Me.RB_INICIO.TabIndex = 3
        Me.RB_INICIO.Text = "Coincidencia al inicio"
        Me.RB_INICIO.UseVisualStyleBackColor = True
        '
        'RB_ALL
        '
        Me.RB_ALL.AutoSize = True
        Me.RB_ALL.Checked = True
        Me.RB_ALL.Location = New System.Drawing.Point(14, 42)
        Me.RB_ALL.Name = "RB_ALL"
        Me.RB_ALL.Size = New System.Drawing.Size(111, 17)
        Me.RB_ALL.TabIndex = 5
        Me.RB_ALL.TabStop = True
        Me.RB_ALL.Text = "Cualquier caracter"
        Me.RB_ALL.UseVisualStyleBackColor = True
        '
        'RB_EXACTA
        '
        Me.RB_EXACTA.AutoSize = True
        Me.RB_EXACTA.Location = New System.Drawing.Point(14, 65)
        Me.RB_EXACTA.Name = "RB_EXACTA"
        Me.RB_EXACTA.Size = New System.Drawing.Size(58, 17)
        Me.RB_EXACTA.TabIndex = 6
        Me.RB_EXACTA.Text = "Exacta"
        Me.RB_EXACTA.UseVisualStyleBackColor = True
        '
        'RB_COLUMN1
        '
        Me.RB_COLUMN1.AutoSize = True
        Me.RB_COLUMN1.Location = New System.Drawing.Point(16, 19)
        Me.RB_COLUMN1.Name = "RB_COLUMN1"
        Me.RB_COLUMN1.Size = New System.Drawing.Size(66, 17)
        Me.RB_COLUMN1.TabIndex = 8
        Me.RB_COLUMN1.Text = "Column1"
        Me.RB_COLUMN1.UseVisualStyleBackColor = True
        '
        'RB_COLUMN2
        '
        Me.RB_COLUMN2.AutoSize = True
        Me.RB_COLUMN2.Checked = True
        Me.RB_COLUMN2.Location = New System.Drawing.Point(16, 42)
        Me.RB_COLUMN2.Name = "RB_COLUMN2"
        Me.RB_COLUMN2.Size = New System.Drawing.Size(66, 17)
        Me.RB_COLUMN2.TabIndex = 9
        Me.RB_COLUMN2.TabStop = True
        Me.RB_COLUMN2.Text = "Column2"
        Me.RB_COLUMN2.UseVisualStyleBackColor = True
        '
        'ButtonX7
        '
        Me.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX7.Location = New System.Drawing.Point(349, 241)
        Me.ButtonX7.Name = "ButtonX7"
        Me.ButtonX7.Size = New System.Drawing.Size(70, 40)
        Me.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX7.Symbol = ""
        Me.ButtonX7.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_ALL)
        Me.GroupBox1.Controls.Add(Me.RB_INICIO)
        Me.GroupBox1.Controls.Add(Me.RB_EXACTA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 93)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_OTRO)
        Me.GroupBox2.Controls.Add(Me.RB_COLUMN2)
        Me.GroupBox2.Controls.Add(Me.RB_COLUMN1)
        Me.GroupBox2.Location = New System.Drawing.Point(192, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 93)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda por:"
        '
        'RB_OTRO
        '
        Me.RB_OTRO.AutoSize = True
        Me.RB_OTRO.Location = New System.Drawing.Point(16, 65)
        Me.RB_OTRO.Name = "RB_OTRO"
        Me.RB_OTRO.Size = New System.Drawing.Size(45, 17)
        Me.RB_OTRO.TabIndex = 10
        Me.RB_OTRO.Text = "Otro"
        Me.RB_OTRO.UseVisualStyleBackColor = True
        '
        'FrmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 316)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonX7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_BUSQUEDA)
        Me.Controls.Add(Me.GRID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TXT_BUSQUEDA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_INICIO As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ALL As System.Windows.Forms.RadioButton
    Friend WithEvents RB_EXACTA As System.Windows.Forms.RadioButton
    Friend WithEvents RB_COLUMN1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_COLUMN2 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_OTRO As System.Windows.Forms.RadioButton
End Class
