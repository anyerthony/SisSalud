<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrtografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrtografia))
        Me.TXT_TEXTO = New System.Windows.Forms.TextBox
        Me.BTN_CANCELAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_ACEPTAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_ORTOGRAFIA = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'TXT_TEXTO
        '
        Me.TXT_TEXTO.Location = New System.Drawing.Point(12, 12)
        Me.TXT_TEXTO.Multiline = True
        Me.TXT_TEXTO.Name = "TXT_TEXTO"
        Me.TXT_TEXTO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_TEXTO.Size = New System.Drawing.Size(760, 506)
        Me.TXT_TEXTO.TabIndex = 0
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_CANCELAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(718, 526)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(54, 26)
        Me.BTN_CANCELAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_CANCELAR.TabIndex = 2
        Me.BTN_CANCELAR.Text = "Cancelar"
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ACEPTAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(658, 526)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(54, 26)
        Me.BTN_ACEPTAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ACEPTAR.TabIndex = 3
        Me.BTN_ACEPTAR.Text = "Aceptar"
        '
        'BTN_ORTOGRAFIA
        '
        Me.BTN_ORTOGRAFIA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ORTOGRAFIA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ORTOGRAFIA.Location = New System.Drawing.Point(12, 526)
        Me.BTN_ORTOGRAFIA.Name = "BTN_ORTOGRAFIA"
        Me.BTN_ORTOGRAFIA.Size = New System.Drawing.Size(155, 26)
        Me.BTN_ORTOGRAFIA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ORTOGRAFIA.TabIndex = 4
        Me.BTN_ORTOGRAFIA.Text = "Validar Ortografía"
        '
        'FrmOrtografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.BTN_ORTOGRAFIA)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.TXT_TEXTO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrtografia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expandir campo:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_TEXTO As System.Windows.Forms.TextBox
    Friend WithEvents BTN_CANCELAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_ACEPTAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_ORTOGRAFIA As DevComponents.DotNetBar.ButtonX
End Class
