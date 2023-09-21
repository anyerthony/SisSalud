<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelEmpresa))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_EMPRESA = New System.Windows.Forms.ComboBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor, Seleccione la Empresa"
        '
        'TXT_EMPRESA
        '
        Me.TXT_EMPRESA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_EMPRESA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_EMPRESA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_EMPRESA.FormattingEnabled = True
        Me.TXT_EMPRESA.Items.AddRange(New Object() {"DarSalud", "Viñedos", "Mañongo", "Demostracion"})
        Me.TXT_EMPRESA.Location = New System.Drawing.Point(16, 40)
        Me.TXT_EMPRESA.Name = "TXT_EMPRESA"
        Me.TXT_EMPRESA.Size = New System.Drawing.Size(200, 21)
        Me.TXT_EMPRESA.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(16, 69)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(200, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Aceptar"
        '
        'FrmSelEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(253, 117)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TXT_EMPRESA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSelEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_EMPRESA As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
