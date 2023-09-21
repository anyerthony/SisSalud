<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimirFactura))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.CH_Empresa = New System.Windows.Forms.CheckBox
        Me.TXT_FacturaImprimir = New System.Windows.Forms.TextBox
        Me.RB_Particular = New System.Windows.Forms.RadioButton
        Me.RB_Paciente = New System.Windows.Forms.RadioButton
        Me.RB_Detallado = New System.Windows.Forms.RadioButton
        Me.RB_Resumido = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.RB_Profit = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(104, 183)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORMATO:"
        '
        'CH_Empresa
        '
        Me.CH_Empresa.AutoSize = True
        Me.CH_Empresa.Location = New System.Drawing.Point(201, 97)
        Me.CH_Empresa.Name = "CH_Empresa"
        Me.CH_Empresa.Size = New System.Drawing.Size(15, 14)
        Me.CH_Empresa.TabIndex = 4
        Me.CH_Empresa.UseVisualStyleBackColor = True
        '
        'TXT_FacturaImprimir
        '
        Me.TXT_FacturaImprimir.Location = New System.Drawing.Point(65, 157)
        Me.TXT_FacturaImprimir.Name = "TXT_FacturaImprimir"
        Me.TXT_FacturaImprimir.Size = New System.Drawing.Size(146, 20)
        Me.TXT_FacturaImprimir.TabIndex = 5
        '
        'RB_Particular
        '
        Me.RB_Particular.AutoSize = True
        Me.RB_Particular.Location = New System.Drawing.Point(98, 12)
        Me.RB_Particular.Name = "RB_Particular"
        Me.RB_Particular.Size = New System.Drawing.Size(69, 17)
        Me.RB_Particular.TabIndex = 6
        Me.RB_Particular.TabStop = True
        Me.RB_Particular.Text = "Particular"
        Me.RB_Particular.UseVisualStyleBackColor = True
        '
        'RB_Paciente
        '
        Me.RB_Paciente.AutoSize = True
        Me.RB_Paciente.Location = New System.Drawing.Point(186, 9)
        Me.RB_Paciente.Name = "RB_Paciente"
        Me.RB_Paciente.Size = New System.Drawing.Size(86, 17)
        Me.RB_Paciente.TabIndex = 7
        Me.RB_Paciente.TabStop = True
        Me.RB_Paciente.Text = "Por Paciente"
        Me.RB_Paciente.UseVisualStyleBackColor = True
        '
        'RB_Detallado
        '
        Me.RB_Detallado.AutoSize = True
        Me.RB_Detallado.Location = New System.Drawing.Point(186, 32)
        Me.RB_Detallado.Name = "RB_Detallado"
        Me.RB_Detallado.Size = New System.Drawing.Size(94, 17)
        Me.RB_Detallado.TabIndex = 8
        Me.RB_Detallado.TabStop = True
        Me.RB_Detallado.Text = "Lote Detallado"
        Me.RB_Detallado.UseVisualStyleBackColor = True
        '
        'RB_Resumido
        '
        Me.RB_Resumido.AutoSize = True
        Me.RB_Resumido.Location = New System.Drawing.Point(186, 55)
        Me.RB_Resumido.Name = "RB_Resumido"
        Me.RB_Resumido.Size = New System.Drawing.Size(96, 17)
        Me.RB_Resumido.TabIndex = 9
        Me.RB_Resumido.TabStop = True
        Me.RB_Resumido.Text = "Lote Resumido"
        Me.RB_Resumido.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mostrar nombe de la empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Numero de Factura"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(217, 157)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(24, 20)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolSize = 12.0!
        Me.ButtonX2.TabIndex = 12
        '
        'RB_Profit
        '
        Me.RB_Profit.AutoSize = True
        Me.RB_Profit.Location = New System.Drawing.Point(98, 35)
        Me.RB_Profit.Name = "RB_Profit"
        Me.RB_Profit.Size = New System.Drawing.Size(49, 17)
        Me.RB_Profit.TabIndex = 13
        Me.RB_Profit.TabStop = True
        Me.RB_Profit.Text = "Profit"
        Me.RB_Profit.UseVisualStyleBackColor = True
        '
        'FrmImprimirFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.RB_Profit)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RB_Resumido)
        Me.Controls.Add(Me.RB_Detallado)
        Me.Controls.Add(Me.RB_Paciente)
        Me.Controls.Add(Me.RB_Particular)
        Me.Controls.Add(Me.TXT_FacturaImprimir)
        Me.Controls.Add(Me.CH_Empresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImprimirFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CH_Empresa As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_FacturaImprimir As System.Windows.Forms.TextBox
    Friend WithEvents RB_Particular As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Paciente As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Detallado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Resumido As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RB_Profit As System.Windows.Forms.RadioButton
End Class
