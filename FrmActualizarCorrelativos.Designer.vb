<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarCorrelativos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarCorrelativos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_SUCURSAL = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_NRO = New DevComponents.Editors.IntegerInput
        Me.TXT_CONTROL = New DevComponents.Editors.IntegerInput
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        CType(Me.TXT_NRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_CONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal"
        '
        'TXT_SUCURSAL
        '
        Me.TXT_SUCURSAL.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_SUCURSAL.Location = New System.Drawing.Point(123, 26)
        Me.TXT_SUCURSAL.Multiline = True
        Me.TXT_SUCURSAL.Name = "TXT_SUCURSAL"
        Me.TXT_SUCURSAL.ReadOnly = True
        Me.TXT_SUCURSAL.Size = New System.Drawing.Size(140, 23)
        Me.TXT_SUCURSAL.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ult. Nro. Factura"
        '
        'TXT_NRO
        '
        '
        '
        '
        Me.TXT_NRO.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_NRO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_NRO.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_NRO.Location = New System.Drawing.Point(123, 70)
        Me.TXT_NRO.Name = "TXT_NRO"
        Me.TXT_NRO.Size = New System.Drawing.Size(140, 20)
        Me.TXT_NRO.TabIndex = 3
        '
        'TXT_CONTROL
        '
        '
        '
        '
        Me.TXT_CONTROL.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_CONTROL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_CONTROL.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_CONTROL.Location = New System.Drawing.Point(123, 130)
        Me.TXT_CONTROL.Name = "TXT_CONTROL"
        Me.TXT_CONTROL.Size = New System.Drawing.Size(140, 20)
        Me.TXT_CONTROL.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ultimo Nro. Control"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(218, 168)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(45, 44)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 25.0!
        Me.ButtonX1.TabIndex = 6
        Me.ButtonX1.Tooltip = "Guardar"
        '
        'FrmActualizarCorrelativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 235)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TXT_CONTROL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_NRO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_SUCURSAL)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActualizarCorrelativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Correlativos"
        CType(Me.TXT_NRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_CONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_SUCURSAL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_NRO As DevComponents.Editors.IntegerInput
    Friend WithEvents TXT_CONTROL As DevComponents.Editors.IntegerInput
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
