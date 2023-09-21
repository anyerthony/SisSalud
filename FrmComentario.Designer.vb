<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComentario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComentario))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_COMENTARIO = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_CODIGO = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_SERVICIO = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_DES_ADICIONAL = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(260, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Ingrese el comentario para el servicio:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(372, 220)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 2
        '
        'TXT_COMENTARIO
        '
        '
        '
        '
        Me.TXT_COMENTARIO.Border.Class = "TextBoxBorder"
        Me.TXT_COMENTARIO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_COMENTARIO.Location = New System.Drawing.Point(12, 61)
        Me.TXT_COMENTARIO.Multiline = True
        Me.TXT_COMENTARIO.Name = "TXT_COMENTARIO"
        Me.TXT_COMENTARIO.PreventEnterBeep = True
        Me.TXT_COMENTARIO.Size = New System.Drawing.Size(435, 156)
        Me.TXT_COMENTARIO.TabIndex = 0
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.TXT_CODIGO.Border.Class = "TextBoxBorder"
        Me.TXT_CODIGO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_CODIGO.Location = New System.Drawing.Point(209, 9)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.PreventEnterBeep = True
        Me.TXT_CODIGO.ReadOnly = True
        Me.TXT_CODIGO.Size = New System.Drawing.Size(86, 20)
        Me.TXT_CODIGO.TabIndex = 4
        '
        'TXT_SERVICIO
        '
        Me.TXT_SERVICIO.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.TXT_SERVICIO.Border.Class = "TextBoxBorder"
        Me.TXT_SERVICIO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_SERVICIO.Location = New System.Drawing.Point(12, 35)
        Me.TXT_SERVICIO.Name = "TXT_SERVICIO"
        Me.TXT_SERVICIO.PreventEnterBeep = True
        Me.TXT_SERVICIO.ReadOnly = True
        Me.TXT_SERVICIO.Size = New System.Drawing.Size(283, 20)
        Me.TXT_SERVICIO.TabIndex = 5
        '
        'TXT_DES_ADICIONAL
        '
        Me.TXT_DES_ADICIONAL.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TXT_DES_ADICIONAL.Border.Class = "TextBoxBorder"
        Me.TXT_DES_ADICIONAL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_DES_ADICIONAL.Location = New System.Drawing.Point(301, 35)
        Me.TXT_DES_ADICIONAL.Name = "TXT_DES_ADICIONAL"
        Me.TXT_DES_ADICIONAL.PreventEnterBeep = True
        Me.TXT_DES_ADICIONAL.Size = New System.Drawing.Size(146, 20)
        Me.TXT_DES_ADICIONAL.TabIndex = 6
        Me.TXT_DES_ADICIONAL.Tag = "TEST"
        '
        'FrmComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 258)
        Me.Controls.Add(Me.TXT_DES_ADICIONAL)
        Me.Controls.Add(Me.TXT_SERVICIO)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.TXT_COMENTARIO)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmComentario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comentario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_COMENTARIO As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_CODIGO As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_SERVICIO As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_DES_ADICIONAL As DevComponents.DotNetBar.Controls.TextBoxX
End Class
