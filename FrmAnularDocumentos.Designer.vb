<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnularDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnularDocumentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_MONTO_DOC = New DevComponents.Editors.DoubleInput
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_CLI_DOC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_FEC_DOC = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_TIPO_DOC = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.OPCION1 = New System.Windows.Forms.RadioButton
        Me.OPCION3 = New System.Windows.Forms.RadioButton
        Me.OPCION2 = New System.Windows.Forms.RadioButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TXT_OBSERVACION = New System.Windows.Forms.TextBox
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        CType(Me.TXT_MONTO_DOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_DOC)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_CLI_DOC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_FEC_DOC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.TXT_NRO_DOC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_TIPO_DOC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento a Anular"
        '
        'TXT_MONTO_DOC
        '
        '
        '
        '
        Me.TXT_MONTO_DOC.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TXT_MONTO_DOC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_MONTO_DOC.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TXT_MONTO_DOC.Increment = 1
        Me.TXT_MONTO_DOC.IsInputReadOnly = True
        Me.TXT_MONTO_DOC.Location = New System.Drawing.Point(460, 67)
        Me.TXT_MONTO_DOC.Name = "TXT_MONTO_DOC"
        Me.TXT_MONTO_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_MONTO_DOC.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Monto:"
        '
        'TXT_CLI_DOC
        '
        Me.TXT_CLI_DOC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_CLI_DOC.Location = New System.Drawing.Point(74, 64)
        Me.TXT_CLI_DOC.Name = "TXT_CLI_DOC"
        Me.TXT_CLI_DOC.ReadOnly = True
        Me.TXT_CLI_DOC.Size = New System.Drawing.Size(298, 20)
        Me.TXT_CLI_DOC.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cliente"
        '
        'TXT_FEC_DOC
        '
        Me.TXT_FEC_DOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FEC_DOC.Location = New System.Drawing.Point(460, 25)
        Me.TXT_FEC_DOC.Name = "TXT_FEC_DOC"
        Me.TXT_FEC_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_FEC_DOC.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(378, 26)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(22, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.SymbolSize = 10.0!
        Me.ButtonX1.TabIndex = 8
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(234, 26)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.ReadOnly = True
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(138, 20)
        Me.TXT_NRO_DOC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro:"
        '
        'TXT_TIPO_DOC
        '
        Me.TXT_TIPO_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_TIPO_DOC.FormattingEnabled = True
        Me.TXT_TIPO_DOC.Items.AddRange(New Object() {"FACT", "N/CR", "N/DB"})
        Me.TXT_TIPO_DOC.Location = New System.Drawing.Point(74, 25)
        Me.TXT_TIPO_DOC.Name = "TXT_TIPO_DOC"
        Me.TXT_TIPO_DOC.Size = New System.Drawing.Size(121, 21)
        Me.TXT_TIPO_DOC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OPCION1)
        Me.GroupBox2.Controls.Add(Me.OPCION3)
        Me.GroupBox2.Controls.Add(Me.OPCION2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 145)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Anulacion"
        '
        'OPCION1
        '
        Me.OPCION1.AutoSize = True
        Me.OPCION1.Checked = True
        Me.OPCION1.Location = New System.Drawing.Point(16, 28)
        Me.OPCION1.Name = "OPCION1"
        Me.OPCION1.Size = New System.Drawing.Size(270, 17)
        Me.OPCION1.TabIndex = 2
        Me.OPCION1.TabStop = True
        Me.OPCION1.Text = "Solo Anulacion. Sin ningun tipo de accion adicional."
        Me.OPCION1.UseVisualStyleBackColor = True
        '
        'OPCION3
        '
        Me.OPCION3.AutoSize = True
        Me.OPCION3.Location = New System.Drawing.Point(17, 108)
        Me.OPCION3.Name = "OPCION3"
        Me.OPCION3.Size = New System.Drawing.Size(407, 17)
        Me.OPCION3.TabIndex = 1
        Me.OPCION3.Text = "Eliminación del Documento. Elimina el registro y libera los documentos asociados." & _
            ""
        Me.ToolTip1.SetToolTip(Me.OPCION3, resources.GetString("OPCION3.ToolTip"))
        Me.OPCION3.UseVisualStyleBackColor = True
        '
        'OPCION2
        '
        Me.OPCION2.AutoSize = True
        Me.OPCION2.Location = New System.Drawing.Point(16, 67)
        Me.OPCION2.Name = "OPCION2"
        Me.OPCION2.Size = New System.Drawing.Size(595, 17)
        Me.OPCION2.TabIndex = 0
        Me.OPCION2.TabStop = True
        Me.OPCION2.Text = "Anulación por mala Impresión. El documento se anulará y se creará  un nuevo docum" & _
            "ento con las mismas características"
        Me.ToolTip1.SetToolTip(Me.OPCION2, "Esta opción es muy útil si hubo un atascamiento en la impresora al momento de imp" & _
                "rimir. Es una forma fácil de crear un documento remplazante de manera rápida.")
        Me.OPCION2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'TXT_OBSERVACION
        '
        Me.TXT_OBSERVACION.Location = New System.Drawing.Point(5, 275)
        Me.TXT_OBSERVACION.Multiline = True
        Me.TXT_OBSERVACION.Name = "TXT_OBSERVACION"
        Me.TXT_OBSERVACION.Size = New System.Drawing.Size(382, 74)
        Me.TXT_OBSERVACION.TabIndex = 3
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(584, 307)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(49, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 22
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(511, 307)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(49, 36)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 23
        '
        'FrmAnularDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 373)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.TXT_OBSERVACION)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAnularDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulacion de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TXT_MONTO_DOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_MONTO_DOC As DevComponents.Editors.DoubleInput
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_CLI_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_FEC_DOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_NRO_DOC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_TIPO_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OPCION2 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OPCION1 As System.Windows.Forms.RadioButton
    Friend WithEvents OPCION3 As System.Windows.Forms.RadioButton
    Friend WithEvents TXT_OBSERVACION As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
End Class
