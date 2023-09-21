<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_MED_HIS = New System.Windows.Forms.TextBox
        Me.TXT_MED_CED = New System.Windows.Forms.TextBox
        Me.TXT_MED_NAC = New System.Windows.Forms.DateTimePicker
        Me.TXT_MED_NOM = New System.Windows.Forms.TextBox
        Me.TXT_MED_APE = New System.Windows.Forms.TextBox
        Me.TXT_MED_TLF = New System.Windows.Forms.TextBox
        Me.TXT_MED_DIR = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TXT_PRO_DIR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TXT_PRO_COD = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TXT_PRO_NOM = New System.Windows.Forms.TextBox
        Me.TXT_PRO_RIF = New System.Windows.Forms.TextBox
        Me.TXT_PRO_TLF = New System.Windows.Forms.TextBox
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Historia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Telefono"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_DIR)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_TLF)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_APE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_NOM)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_NAC)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_CED)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_MED_HIS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 234)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos MediSoftware"
        '
        'TXT_MED_HIS
        '
        Me.TXT_MED_HIS.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_MED_HIS.Location = New System.Drawing.Point(31, 47)
        Me.TXT_MED_HIS.Name = "TXT_MED_HIS"
        Me.TXT_MED_HIS.ReadOnly = True
        Me.TXT_MED_HIS.Size = New System.Drawing.Size(71, 20)
        Me.TXT_MED_HIS.TabIndex = 1
        '
        'TXT_MED_CED
        '
        Me.TXT_MED_CED.BackColor = System.Drawing.Color.White
        Me.TXT_MED_CED.Location = New System.Drawing.Point(31, 106)
        Me.TXT_MED_CED.Name = "TXT_MED_CED"
        Me.TXT_MED_CED.Size = New System.Drawing.Size(100, 20)
        Me.TXT_MED_CED.TabIndex = 4
        '
        'TXT_MED_NAC
        '
        Me.TXT_MED_NAC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_MED_NAC.Location = New System.Drawing.Point(400, 47)
        Me.TXT_MED_NAC.Name = "TXT_MED_NAC"
        Me.TXT_MED_NAC.Size = New System.Drawing.Size(90, 20)
        Me.TXT_MED_NAC.TabIndex = 5
        '
        'TXT_MED_NOM
        '
        Me.TXT_MED_NOM.BackColor = System.Drawing.Color.White
        Me.TXT_MED_NOM.Location = New System.Drawing.Point(160, 46)
        Me.TXT_MED_NOM.Name = "TXT_MED_NOM"
        Me.TXT_MED_NOM.Size = New System.Drawing.Size(198, 20)
        Me.TXT_MED_NOM.TabIndex = 6
        '
        'TXT_MED_APE
        '
        Me.TXT_MED_APE.BackColor = System.Drawing.Color.White
        Me.TXT_MED_APE.Location = New System.Drawing.Point(160, 106)
        Me.TXT_MED_APE.Name = "TXT_MED_APE"
        Me.TXT_MED_APE.Size = New System.Drawing.Size(198, 20)
        Me.TXT_MED_APE.TabIndex = 7
        '
        'TXT_MED_TLF
        '
        Me.TXT_MED_TLF.BackColor = System.Drawing.Color.White
        Me.TXT_MED_TLF.Location = New System.Drawing.Point(400, 106)
        Me.TXT_MED_TLF.Name = "TXT_MED_TLF"
        Me.TXT_MED_TLF.Size = New System.Drawing.Size(100, 20)
        Me.TXT_MED_TLF.TabIndex = 8
        '
        'TXT_MED_DIR
        '
        Me.TXT_MED_DIR.Location = New System.Drawing.Point(99, 160)
        Me.TXT_MED_DIR.Multiline = True
        Me.TXT_MED_DIR.Name = "TXT_MED_DIR"
        Me.TXT_MED_DIR.Size = New System.Drawing.Size(401, 55)
        Me.TXT_MED_DIR.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_PRO_TLF)
        Me.GroupBox2.Controls.Add(Me.TXT_PRO_RIF)
        Me.GroupBox2.Controls.Add(Me.TXT_PRO_NOM)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.TXT_PRO_DIR)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_PRO_COD)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 218)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Profit"
        '
        'TXT_PRO_DIR
        '
        Me.TXT_PRO_DIR.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PRO_DIR.Location = New System.Drawing.Point(160, 130)
        Me.TXT_PRO_DIR.Multiline = True
        Me.TXT_PRO_DIR.Name = "TXT_PRO_DIR"
        Me.TXT_PRO_DIR.ReadOnly = True
        Me.TXT_PRO_DIR.Size = New System.Drawing.Size(340, 74)
        Me.TXT_PRO_DIR.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Direccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Telefono"
        '
        'TXT_PRO_COD
        '
        Me.TXT_PRO_COD.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PRO_COD.Location = New System.Drawing.Point(31, 71)
        Me.TXT_PRO_COD.Name = "TXT_PRO_COD"
        Me.TXT_PRO_COD.ReadOnly = True
        Me.TXT_PRO_COD.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PRO_COD.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(157, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nombre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "R.I.F."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(293, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(212, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Al Guardar, Copiar desde MediSoftware"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TXT_PRO_NOM
        '
        Me.TXT_PRO_NOM.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PRO_NOM.Location = New System.Drawing.Point(160, 71)
        Me.TXT_PRO_NOM.Name = "TXT_PRO_NOM"
        Me.TXT_PRO_NOM.ReadOnly = True
        Me.TXT_PRO_NOM.Size = New System.Drawing.Size(340, 20)
        Me.TXT_PRO_NOM.TabIndex = 11
        '
        'TXT_PRO_RIF
        '
        Me.TXT_PRO_RIF.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PRO_RIF.Location = New System.Drawing.Point(31, 130)
        Me.TXT_PRO_RIF.Name = "TXT_PRO_RIF"
        Me.TXT_PRO_RIF.ReadOnly = True
        Me.TXT_PRO_RIF.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PRO_RIF.TabIndex = 12
        '
        'TXT_PRO_TLF
        '
        Me.TXT_PRO_TLF.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_PRO_TLF.Location = New System.Drawing.Point(31, 184)
        Me.TXT_PRO_TLF.Name = "TXT_PRO_TLF"
        Me.TXT_PRO_TLF.ReadOnly = True
        Me.TXT_PRO_TLF.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PRO_TLF.TabIndex = 13
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(12, 490)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX3.TabIndex = 16
        Me.ButtonX3.Tooltip = "Borrar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(462, 490)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(77, 69)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX2.TabIndex = 15
        Me.ButtonX2.Tooltip = "Guardar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(109, 47)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(22, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 10
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 586)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesParticulares / Pacientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_MED_NAC As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_MED_CED As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MED_HIS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MED_DIR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MED_TLF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MED_APE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MED_NOM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PRO_DIR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_PRO_COD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_PRO_TLF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRO_RIF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRO_NOM As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
