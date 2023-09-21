<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoSel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoSel))
        Me.TXT_LISTA = New System.Windows.Forms.ComboBox
        Me.TXT_LABEL = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_COD_CLIENTE = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TXT_LISTA
        '
        Me.TXT_LISTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_LISTA.FormattingEnabled = True
        Me.TXT_LISTA.Location = New System.Drawing.Point(23, 42)
        Me.TXT_LISTA.Name = "TXT_LISTA"
        Me.TXT_LISTA.Size = New System.Drawing.Size(225, 21)
        Me.TXT_LISTA.TabIndex = 0
        '
        'TXT_LABEL
        '
        Me.TXT_LABEL.AutoSize = True
        Me.TXT_LABEL.Location = New System.Drawing.Point(23, 23)
        Me.TXT_LABEL.Name = "TXT_LABEL"
        Me.TXT_LABEL.Size = New System.Drawing.Size(39, 13)
        Me.TXT_LABEL.TabIndex = 1
        Me.TXT_LABEL.Text = "Label1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(22, 69)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(225, 22)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Aceptar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(23, 108)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(225, 22)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "Cancelar"
        '
        'TXT_COD_CLIENTE
        '
        Me.TXT_COD_CLIENTE.AutoSize = True
        Me.TXT_COD_CLIENTE.Location = New System.Drawing.Point(73, 164)
        Me.TXT_COD_CLIENTE.Name = "TXT_COD_CLIENTE"
        Me.TXT_COD_CLIENTE.Size = New System.Drawing.Size(39, 13)
        Me.TXT_COD_CLIENTE.TabIndex = 4
        Me.TXT_COD_CLIENTE.Text = "Label1"
        '
        'FrmTipoSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 148)
        Me.Controls.Add(Me.TXT_COD_CLIENTE)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TXT_LABEL)
        Me.Controls.Add(Me.TXT_LISTA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTipoSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTipoSel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_LISTA As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_LABEL As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_COD_CLIENTE As System.Windows.Forms.Label
End Class
