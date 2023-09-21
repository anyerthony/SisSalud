<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearIngreso))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_COD_PACIENTE = New System.Windows.Forms.TextBox
        Me.TXT_NOM_PACIENTE = New System.Windows.Forms.TextBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_MOTIVO = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_CLAVE = New System.Windows.Forms.TextBox
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_SERVICIOS = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paciente:"
        '
        'TXT_COD_PACIENTE
        '
        Me.TXT_COD_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_COD_PACIENTE.Location = New System.Drawing.Point(70, 15)
        Me.TXT_COD_PACIENTE.Name = "TXT_COD_PACIENTE"
        Me.TXT_COD_PACIENTE.ReadOnly = True
        Me.TXT_COD_PACIENTE.Size = New System.Drawing.Size(100, 20)
        Me.TXT_COD_PACIENTE.TabIndex = 1
        '
        'TXT_NOM_PACIENTE
        '
        Me.TXT_NOM_PACIENTE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NOM_PACIENTE.Location = New System.Drawing.Point(176, 15)
        Me.TXT_NOM_PACIENTE.Name = "TXT_NOM_PACIENTE"
        Me.TXT_NOM_PACIENTE.ReadOnly = True
        Me.TXT_NOM_PACIENTE.Size = New System.Drawing.Size(221, 20)
        Me.TXT_NOM_PACIENTE.TabIndex = 2
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(403, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(30, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Motivo:"
        '
        'TXT_MOTIVO
        '
        Me.TXT_MOTIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_MOTIVO.FormattingEnabled = True
        Me.TXT_MOTIVO.Location = New System.Drawing.Point(70, 52)
        Me.TXT_MOTIVO.Name = "TXT_MOTIVO"
        Me.TXT_MOTIVO.Size = New System.Drawing.Size(327, 21)
        Me.TXT_MOTIVO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clave:"
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.Location = New System.Drawing.Point(70, 182)
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.Size = New System.Drawing.Size(327, 20)
        Me.TXT_CLAVE.TabIndex = 7
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(389, 248)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(55, 40)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(15, 248)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(55, 40)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 9
        Me.ButtonX3.Tooltip = "Cancelar"
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(70, 92)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(327, 21)
        Me.TXT_DOCTOR.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Doctor:"
        '
        'TXT_SERVICIOS
        '
        Me.TXT_SERVICIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_SERVICIOS.FormattingEnabled = True
        Me.TXT_SERVICIOS.Location = New System.Drawing.Point(70, 133)
        Me.TXT_SERVICIOS.Name = "TXT_SERVICIOS"
        Me.TXT_SERVICIOS.Size = New System.Drawing.Size(327, 21)
        Me.TXT_SERVICIOS.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Servicio:"
        '
        'FrmCrearIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 334)
        Me.Controls.Add(Me.TXT_SERVICIOS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_DOCTOR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.TXT_CLAVE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_MOTIVO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TXT_NOM_PACIENTE)
        Me.Controls.Add(Me.TXT_COD_PACIENTE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCrearIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_COD_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOM_PACIENTE As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_MOTIVO As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_CLAVE As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_DOCTOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_SERVICIOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
