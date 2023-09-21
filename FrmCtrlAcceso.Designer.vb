<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCtrlAcceso
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCtrlAcceso))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_ACCESOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_USUARIOS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.GRID_USUARIOPERFIL = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GRID_SUCURSAL = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.BS_ACCESOS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_USUARIOS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonX7 = New DevComponents.DotNetBar.ButtonX
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GRID_ACCESOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GRID_USUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GRID_USUARIOPERFIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GRID_SUCURSAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_ACCESOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_USUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(610, 359)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonX1)
        Me.TabPage1.Controls.Add(Me.GRID_ACCESOS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(602, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accesos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(545, 276)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(51, 51)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 1
        '
        'GRID_ACCESOS
        '
        Me.GRID_ACCESOS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_ACCESOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_ACCESOS.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_ACCESOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_ACCESOS.Location = New System.Drawing.Point(6, 6)
        Me.GRID_ACCESOS.Name = "GRID_ACCESOS"
        Me.GRID_ACCESOS.RowHeadersWidth = 15
        Me.GRID_ACCESOS.Size = New System.Drawing.Size(590, 255)
        Me.GRID_ACCESOS.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonX6)
        Me.TabPage2.Controls.Add(Me.ButtonX5)
        Me.TabPage2.Controls.Add(Me.ButtonX2)
        Me.TabPage2.Controls.Add(Me.GRID_USUARIOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(602, 333)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Usuarios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Location = New System.Drawing.Point(536, 281)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.Symbol = ""
        Me.ButtonX6.TabIndex = 4
        Me.ButtonX6.Tooltip = "Copiar Usuario"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Location = New System.Drawing.Point(452, 281)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.Symbol = ""
        Me.ButtonX5.TabIndex = 3
        Me.ButtonX5.Tooltip = "Convertir a Usuario SisSalud"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(6, 281)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Tooltip = "DesHabilitar"
        '
        'GRID_USUARIOS
        '
        Me.GRID_USUARIOS.AllowUserToAddRows = False
        Me.GRID_USUARIOS.AllowUserToDeleteRows = False
        Me.GRID_USUARIOS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_USUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_USUARIOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_USUARIOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_USUARIOS.Location = New System.Drawing.Point(6, 6)
        Me.GRID_USUARIOS.Name = "GRID_USUARIOS"
        Me.GRID_USUARIOS.RowHeadersWidth = 15
        Me.GRID_USUARIOS.Size = New System.Drawing.Size(590, 269)
        Me.GRID_USUARIOS.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonX4)
        Me.TabPage3.Controls.Add(Me.ButtonX3)
        Me.TabPage3.Controls.Add(Me.GRID_USUARIOPERFIL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(602, 333)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Acceso-Usuario"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(536, 281)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.TabIndex = 4
        Me.ButtonX4.Tooltip = "Agregar Perfil"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(455, 281)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 3
        Me.ButtonX3.Tooltip = "DesHabilitar"
        '
        'GRID_USUARIOPERFIL
        '
        Me.GRID_USUARIOPERFIL.AllowUserToAddRows = False
        Me.GRID_USUARIOPERFIL.AllowUserToDeleteRows = False
        Me.GRID_USUARIOPERFIL.BackgroundColor = System.Drawing.Color.White
        Me.GRID_USUARIOPERFIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_USUARIOPERFIL.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_USUARIOPERFIL.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_USUARIOPERFIL.Location = New System.Drawing.Point(6, 6)
        Me.GRID_USUARIOPERFIL.Name = "GRID_USUARIOPERFIL"
        Me.GRID_USUARIOPERFIL.RowHeadersWidth = 15
        Me.GRID_USUARIOPERFIL.Size = New System.Drawing.Size(590, 269)
        Me.GRID_USUARIOPERFIL.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ButtonX7)
        Me.TabPage4.Controls.Add(Me.GRID_SUCURSAL)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(602, 333)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Usuario-Sucursal"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GRID_SUCURSAL
        '
        Me.GRID_SUCURSAL.AllowUserToAddRows = False
        Me.GRID_SUCURSAL.AllowUserToDeleteRows = False
        Me.GRID_SUCURSAL.BackgroundColor = System.Drawing.Color.White
        Me.GRID_SUCURSAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_SUCURSAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.GRID_SUCURSAL.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_SUCURSAL.Location = New System.Drawing.Point(6, 20)
        Me.GRID_SUCURSAL.Name = "GRID_SUCURSAL"
        Me.GRID_SUCURSAL.RowHeadersWidth = 15
        Me.GRID_SUCURSAL.Size = New System.Drawing.Size(590, 255)
        Me.GRID_SUCURSAL.TabIndex = 3
        '
        'ButtonX7
        '
        Me.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX7.Location = New System.Drawing.Point(536, 281)
        Me.ButtonX7.Name = "ButtonX7"
        Me.ButtonX7.Size = New System.Drawing.Size(60, 46)
        Me.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX7.Symbol = ""
        Me.ButtonX7.TabIndex = 5
        Me.ButtonX7.Tooltip = "Agregar Sucursal"
        '
        'FrmCtrlAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCtrlAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de acceso"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GRID_ACCESOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GRID_USUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GRID_USUARIOPERFIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GRID_SUCURSAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_ACCESOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_USUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GRID_ACCESOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GRID_USUARIOS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents BS_ACCESOS As System.Windows.Forms.BindingSource
    Friend WithEvents BS_USUARIOS As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GRID_USUARIOPERFIL As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GRID_SUCURSAL As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX7 As DevComponents.DotNetBar.ButtonX
End Class
