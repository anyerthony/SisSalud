<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarTasas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarTasas))
        Me.GRID_TASAS = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.co_mone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.Tasa = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TAB_TASAS = New System.Windows.Forms.TabControl
        Me.TAB_ACTUALIZAR_TASAS = New System.Windows.Forms.TabPage
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TAB_CONSULTAR_TASAS = New System.Windows.Forms.TabPage
        Me.FECHA_TASAS = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.GRID_CONSULTA = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewDateTimeInputColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.DataGridViewDoubleInputColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX
        CType(Me.GRID_TASAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_TASAS.SuspendLayout()
        Me.TAB_ACTUALIZAR_TASAS.SuspendLayout()
        Me.TAB_CONSULTAR_TASAS.SuspendLayout()
        CType(Me.FECHA_TASAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID_CONSULTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID_TASAS
        '
        Me.GRID_TASAS.AllowUserToResizeColumns = False
        Me.GRID_TASAS.AllowUserToResizeRows = False
        Me.GRID_TASAS.BackgroundColor = System.Drawing.Color.White
        Me.GRID_TASAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_TASAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.co_mone, Me.fecha, Me.Tasa})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_TASAS.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_TASAS.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_TASAS.Location = New System.Drawing.Point(-4, 0)
        Me.GRID_TASAS.Name = "GRID_TASAS"
        Me.GRID_TASAS.RowHeadersVisible = False
        Me.GRID_TASAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_TASAS.Size = New System.Drawing.Size(319, 189)
        Me.GRID_TASAS.TabIndex = 0
        '
        'co_mone
        '
        Me.co_mone.HeaderText = "Codigo"
        Me.co_mone.Name = "co_mone"
        Me.co_mone.Width = 80
        '
        'fecha
        '
        '
        '
        '
        Me.fecha.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fecha.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.fecha.MaxDate = New Date(3000, 1, 1, 0, 0, 0, 0)
        Me.fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.fecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.DisplayMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.fecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fecha.Name = "fecha"
        Me.fecha.ShowUpDown = True
        Me.fecha.Width = 110
        '
        'Tasa
        '
        '
        '
        '
        Me.Tasa.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Tasa.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Tasa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tasa.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Tasa.HeaderText = "Tasa"
        Me.Tasa.Increment = 1
        Me.Tasa.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Tasa.Name = "Tasa"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(225, 193)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(83, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Tooltip = "Guardar"
        '
        'TAB_TASAS
        '
        Me.TAB_TASAS.Controls.Add(Me.TAB_ACTUALIZAR_TASAS)
        Me.TAB_TASAS.Controls.Add(Me.TAB_CONSULTAR_TASAS)
        Me.TAB_TASAS.Location = New System.Drawing.Point(11, 12)
        Me.TAB_TASAS.Name = "TAB_TASAS"
        Me.TAB_TASAS.SelectedIndex = 0
        Me.TAB_TASAS.Size = New System.Drawing.Size(322, 253)
        Me.TAB_TASAS.TabIndex = 2
        Me.TAB_TASAS.Tag = ""
        '
        'TAB_ACTUALIZAR_TASAS
        '
        Me.TAB_ACTUALIZAR_TASAS.Controls.Add(Me.ButtonX3)
        Me.TAB_ACTUALIZAR_TASAS.Controls.Add(Me.ButtonX2)
        Me.TAB_ACTUALIZAR_TASAS.Controls.Add(Me.GRID_TASAS)
        Me.TAB_ACTUALIZAR_TASAS.Controls.Add(Me.ButtonX1)
        Me.TAB_ACTUALIZAR_TASAS.Location = New System.Drawing.Point(4, 22)
        Me.TAB_ACTUALIZAR_TASAS.Name = "TAB_ACTUALIZAR_TASAS"
        Me.TAB_ACTUALIZAR_TASAS.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_ACTUALIZAR_TASAS.Size = New System.Drawing.Size(314, 227)
        Me.TAB_ACTUALIZAR_TASAS.TabIndex = 0
        Me.TAB_ACTUALIZAR_TASAS.Text = "Cargar"
        Me.TAB_ACTUALIZAR_TASAS.UseVisualStyleBackColor = True
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(4, 193)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(83, 29)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 3
        Me.ButtonX3.Tooltip = "Borrar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(136, 193)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(83, 29)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Tooltip = "Validar"
        '
        'TAB_CONSULTAR_TASAS
        '
        Me.TAB_CONSULTAR_TASAS.Controls.Add(Me.ButtonX6)
        Me.TAB_CONSULTAR_TASAS.Controls.Add(Me.ButtonX5)
        Me.TAB_CONSULTAR_TASAS.Controls.Add(Me.ButtonX4)
        Me.TAB_CONSULTAR_TASAS.Controls.Add(Me.FECHA_TASAS)
        Me.TAB_CONSULTAR_TASAS.Controls.Add(Me.GRID_CONSULTA)
        Me.TAB_CONSULTAR_TASAS.Location = New System.Drawing.Point(4, 22)
        Me.TAB_CONSULTAR_TASAS.Name = "TAB_CONSULTAR_TASAS"
        Me.TAB_CONSULTAR_TASAS.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_CONSULTAR_TASAS.Size = New System.Drawing.Size(314, 227)
        Me.TAB_CONSULTAR_TASAS.TabIndex = 1
        Me.TAB_CONSULTAR_TASAS.Text = "Consultar"
        Me.TAB_CONSULTAR_TASAS.UseVisualStyleBackColor = True
        '
        'FECHA_TASAS
        '
        '
        '
        '
        Me.FECHA_TASAS.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.FECHA_TASAS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FECHA_TASAS.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.FECHA_TASAS.ButtonDropDown.Visible = True
        Me.FECHA_TASAS.IsPopupCalendarOpen = False
        Me.FECHA_TASAS.Location = New System.Drawing.Point(3, 4)
        Me.FECHA_TASAS.MaxDate = New Date(3000, 1, 1, 0, 0, 0, 0)
        Me.FECHA_TASAS.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.FECHA_TASAS.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FECHA_TASAS.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FECHA_TASAS.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.FECHA_TASAS.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.FECHA_TASAS.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FECHA_TASAS.MonthCalendar.DisplayMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.FECHA_TASAS.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.FECHA_TASAS.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FECHA_TASAS.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.FECHA_TASAS.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.FECHA_TASAS.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.FECHA_TASAS.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FECHA_TASAS.MonthCalendar.TodayButtonVisible = True
        Me.FECHA_TASAS.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.FECHA_TASAS.Name = "FECHA_TASAS"
        Me.FECHA_TASAS.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_TASAS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FECHA_TASAS.TabIndex = 2
        '
        'GRID_CONSULTA
        '
        Me.GRID_CONSULTA.AllowUserToAddRows = False
        Me.GRID_CONSULTA.AllowUserToDeleteRows = False
        Me.GRID_CONSULTA.AllowUserToResizeColumns = False
        Me.GRID_CONSULTA.AllowUserToResizeRows = False
        Me.GRID_CONSULTA.BackgroundColor = System.Drawing.Color.White
        Me.GRID_CONSULTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_CONSULTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewDateTimeInputColumn1, Me.DataGridViewDoubleInputColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_CONSULTA.DefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_CONSULTA.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GRID_CONSULTA.Location = New System.Drawing.Point(-4, 28)
        Me.GRID_CONSULTA.Name = "GRID_CONSULTA"
        Me.GRID_CONSULTA.RowHeadersVisible = False
        Me.GRID_CONSULTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_CONSULTA.Size = New System.Drawing.Size(322, 203)
        Me.GRID_CONSULTA.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewDateTimeInputColumn1
        '
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewDateTimeInputColumn1.HeaderText = "Fecha"
        Me.DataGridViewDateTimeInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.DisplayMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DataGridViewDateTimeInputColumn1.Name = "DataGridViewDateTimeInputColumn1"
        Me.DataGridViewDateTimeInputColumn1.ReadOnly = True
        Me.DataGridViewDateTimeInputColumn1.Width = 110
        '
        'DataGridViewDoubleInputColumn1
        '
        '
        '
        '
        Me.DataGridViewDoubleInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DataGridViewDoubleInputColumn1.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.DataGridViewDoubleInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDoubleInputColumn1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewDoubleInputColumn1.HeaderText = "Tasa"
        Me.DataGridViewDoubleInputColumn1.Increment = 1
        Me.DataGridViewDoubleInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.DataGridViewDoubleInputColumn1.Name = "DataGridViewDoubleInputColumn1"
        Me.DataGridViewDoubleInputColumn1.ReadOnly = True
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX4.Location = New System.Drawing.Point(208, 4)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(15, 20)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.SymbolSize = 9.0!
        Me.ButtonX4.TabIndex = 3
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX5.Location = New System.Drawing.Point(229, 4)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(15, 20)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.Symbol = ""
        Me.ButtonX5.SymbolSize = 9.0!
        Me.ButtonX5.TabIndex = 4
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX6.Location = New System.Drawing.Point(250, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(15, 20)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.Symbol = ""
        Me.ButtonX6.SymbolSize = 9.0!
        Me.ButtonX6.TabIndex = 5
        '
        'FrmActualizarTasas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(342, 265)
        Me.Controls.Add(Me.TAB_TASAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActualizarTasas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tasas de Cambio"
        CType(Me.GRID_TASAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_TASAS.ResumeLayout(False)
        Me.TAB_ACTUALIZAR_TASAS.ResumeLayout(False)
        Me.TAB_CONSULTAR_TASAS.ResumeLayout(False)
        CType(Me.FECHA_TASAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID_CONSULTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRID_TASAS As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TAB_TASAS As System.Windows.Forms.TabControl
    Friend WithEvents TAB_ACTUALIZAR_TASAS As System.Windows.Forms.TabPage
    Friend WithEvents TAB_CONSULTAR_TASAS As System.Windows.Forms.TabPage
    Friend WithEvents GRID_CONSULTA As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents co_mone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Tasa As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents FECHA_TASAS As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDateTimeInputColumn1 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents DataGridViewDoubleInputColumn1 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
End Class
