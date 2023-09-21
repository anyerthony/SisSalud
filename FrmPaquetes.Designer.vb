<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaquetes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaquetes))
        Me.TXT_ID_PAQUETE = New System.Windows.Forms.TextBox
        Me.TXT_PAQUETE = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GRID_TODOS_CONCEPTOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.nombre_concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_sub_paquete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GRID_CONCEPTOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GRID_PAQUETES = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GRID_TODOS_CONCEPTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GRID_CONCEPTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GRID_PAQUETES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_ID_PAQUETE
        '
        Me.TXT_ID_PAQUETE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_ID_PAQUETE.Location = New System.Drawing.Point(38, 9)
        Me.TXT_ID_PAQUETE.Name = "TXT_ID_PAQUETE"
        Me.TXT_ID_PAQUETE.ReadOnly = True
        Me.TXT_ID_PAQUETE.Size = New System.Drawing.Size(79, 20)
        Me.TXT_ID_PAQUETE.TabIndex = 0
        '
        'TXT_PAQUETE
        '
        Me.TXT_PAQUETE.BackColor = System.Drawing.Color.White
        Me.TXT_PAQUETE.Location = New System.Drawing.Point(123, 9)
        Me.TXT_PAQUETE.Name = "TXT_PAQUETE"
        Me.TXT_PAQUETE.Size = New System.Drawing.Size(307, 20)
        Me.TXT_PAQUETE.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.BTN_ELIMINAR)
        Me.Panel1.Controls.Add(Me.BTN_GUARDAR)
        Me.Panel1.Controls.Add(Me.BTN_NUEVO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 389)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 348)
        Me.TabControl1.TabIndex = 74
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GRID_TODOS_CONCEPTOS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Todos los conceptos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GRID_TODOS_CONCEPTOS
        '
        Me.GRID_TODOS_CONCEPTOS.AllowUserToAddRows = False
        Me.GRID_TODOS_CONCEPTOS.AllowUserToResizeRows = False
        Me.GRID_TODOS_CONCEPTOS.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_TODOS_CONCEPTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_TODOS_CONCEPTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_TODOS_CONCEPTOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre_concepto, Me.nombre_sub_paquete})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_TODOS_CONCEPTOS.DefaultCellStyle = DataGridViewCellStyle4
        Me.GRID_TODOS_CONCEPTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_TODOS_CONCEPTOS.EnableHeadersVisualStyles = False
        Me.GRID_TODOS_CONCEPTOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GRID_TODOS_CONCEPTOS.Location = New System.Drawing.Point(3, 3)
        Me.GRID_TODOS_CONCEPTOS.Name = "GRID_TODOS_CONCEPTOS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_TODOS_CONCEPTOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GRID_TODOS_CONCEPTOS.RowHeadersVisible = False
        Me.GRID_TODOS_CONCEPTOS.Size = New System.Drawing.Size(428, 316)
        Me.GRID_TODOS_CONCEPTOS.TabIndex = 2
        '
        'nombre_concepto
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.nombre_concepto.DefaultCellStyle = DataGridViewCellStyle2
        Me.nombre_concepto.HeaderText = "Nombre"
        Me.nombre_concepto.Name = "nombre_concepto"
        Me.nombre_concepto.ReadOnly = True
        Me.nombre_concepto.Width = 250
        '
        'nombre_sub_paquete
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.nombre_sub_paquete.DefaultCellStyle = DataGridViewCellStyle3
        Me.nombre_sub_paquete.HeaderText = "Sub Paquete"
        Me.nombre_sub_paquete.Name = "nombre_sub_paquete"
        Me.nombre_sub_paquete.ReadOnly = True
        Me.nombre_sub_paquete.Width = 150
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GRID_CONCEPTOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conceptos sin sub paquete"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GRID_CONCEPTOS
        '
        Me.GRID_CONCEPTOS.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_CONCEPTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GRID_CONCEPTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_CONCEPTOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_CONCEPTOS.DefaultCellStyle = DataGridViewCellStyle8
        Me.GRID_CONCEPTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_CONCEPTOS.EnableHeadersVisualStyles = False
        Me.GRID_CONCEPTOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GRID_CONCEPTOS.Location = New System.Drawing.Point(3, 3)
        Me.GRID_CONCEPTOS.Name = "GRID_CONCEPTOS"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_CONCEPTOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GRID_CONCEPTOS.Size = New System.Drawing.Size(428, 316)
        Me.GRID_CONCEPTOS.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 320
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GRID_PAQUETES)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(434, 322)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sub paquetes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GRID_PAQUETES
        '
        Me.GRID_PAQUETES.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_PAQUETES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.GRID_PAQUETES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_PAQUETES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_PAQUETES.DefaultCellStyle = DataGridViewCellStyle12
        Me.GRID_PAQUETES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_PAQUETES.EnableHeadersVisualStyles = False
        Me.GRID_PAQUETES.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GRID_PAQUETES.Location = New System.Drawing.Point(3, 3)
        Me.GRID_PAQUETES.Name = "GRID_PAQUETES"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_PAQUETES.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.GRID_PAQUETES.Size = New System.Drawing.Size(428, 316)
        Me.GRID_PAQUETES.TabIndex = 3
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LemonChiffon
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 320
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ELIMINAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(57, 354)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_ELIMINAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ELIMINAR.Symbol = ""
        Me.BTN_ELIMINAR.TabIndex = 73
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_GUARDAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(370, 354)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_GUARDAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_GUARDAR.Symbol = ""
        Me.BTN_GUARDAR.TabIndex = 72
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_NUEVO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_NUEVO.Location = New System.Drawing.Point(136, 354)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(60, 23)
        Me.BTN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_NUEVO.Symbol = ""
        Me.BTN_NUEVO.TabIndex = 71
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_BUSCAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(12, 9)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(20, 20)
        Me.BTN_BUSCAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_BUSCAR.Symbol = ""
        Me.BTN_BUSCAR.SymbolSize = 12.0!
        Me.BTN_BUSCAR.TabIndex = 74
        '
        'FrmPaquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 427)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXT_PAQUETE)
        Me.Controls.Add(Me.TXT_ID_PAQUETE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPaquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paquetes"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GRID_TODOS_CONCEPTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GRID_CONCEPTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GRID_PAQUETES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_ID_PAQUETE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PAQUETE As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GRID_TODOS_CONCEPTOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GRID_CONCEPTOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GRID_PAQUETES As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_sub_paquete As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
