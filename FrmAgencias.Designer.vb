<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgencias))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.AGENCIASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.AGENCIASTableAdapter
        Me.AGENCIASCIUDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIUDADESTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.CIUDADESTableAdapter
        Me.AGENCIASZONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZONASTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.ZONASTableAdapter
        Me.CIUDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIUDADESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENCIASCIUDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGENCIASZONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIUDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIUDADESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Cod. Integral:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "cod_integral", True))
        Me.TextBox1.Location = New System.Drawing.Point(95, 299)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 72
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "id", True))
        Me.TextBox6.Location = New System.Drawing.Point(95, 12)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(90, 20)
        Me.TextBox6.TabIndex = 71
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_BUSCAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(191, 12)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(20, 20)
        Me.BTN_BUSCAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_BUSCAR.Symbol = ""
        Me.BTN_BUSCAR.SymbolSize = 12.0!
        Me.BTN_BUSCAR.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ELIMINAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(23, 338)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_ELIMINAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ELIMINAR.Symbol = ""
        Me.BTN_ELIMINAR.TabIndex = 67
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_GUARDAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(336, 338)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_GUARDAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_GUARDAR.Symbol = ""
        Me.BTN_GUARDAR.TabIndex = 66
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_NUEVO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_NUEVO.Location = New System.Drawing.Point(102, 338)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(60, 23)
        Me.BTN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_NUEVO.Symbol = ""
        Me.BTN_NUEVO.TabIndex = 65
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(95, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 20)
        Me.TextBox2.TabIndex = 64
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "rif", True))
        Me.TextBox3.Location = New System.Drawing.Point(95, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(288, 20)
        Me.TextBox3.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "RIF:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "dir", True))
        Me.TextBox4.Location = New System.Drawing.Point(95, 90)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(288, 99)
        Me.TextBox4.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Zona:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASZONASBindingSource, "nombre", True))
        Me.TextBox5.Location = New System.Drawing.Point(191, 221)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 20)
        Me.TextBox5.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Ciudad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASCIUDADESBindingSource, "nombre", True))
        Me.TextBox7.Location = New System.Drawing.Point(191, 195)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(192, 20)
        Me.TextBox7.TabIndex = 78
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "id_ciudad", True))
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CIUDADESBindingSource1, "id", True))
        Me.TextBox8.Location = New System.Drawing.Point(95, 195)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(90, 20)
        Me.TextBox8.TabIndex = 82
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "id_zona", True))
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ZONASBindingSource, "id", True))
        Me.TextBox9.Location = New System.Drawing.Point(95, 221)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(90, 20)
        Me.TextBox9.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Correo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "tlfn_local", True))
        Me.TextBox10.Location = New System.Drawing.Point(234, 247)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(146, 20)
        Me.TextBox10.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(23, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Teléfonos:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "tlfn", True))
        Me.TextBox11.Location = New System.Drawing.Point(95, 247)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(133, 20)
        Me.TextBox11.TabIndex = 84
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AGENCIASBindingSource, "correo", True))
        Me.TextBox12.Location = New System.Drawing.Point(95, 273)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(288, 20)
        Me.TextBox12.TabIndex = 88
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(234, 14)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 89
        Me.CheckBox1.Text = "Propia"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.AGENCIASZONASBindingSource
        '
        'AGENCIASBindingSource
        '
        Me.AGENCIASBindingSource.DataMember = "AGENCIAS"
        Me.AGENCIASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AGENCIASTableAdapter
        '
        Me.AGENCIASTableAdapter.ClearBeforeFill = True
        '
        'AGENCIASCIUDADESBindingSource
        '
        Me.AGENCIASCIUDADESBindingSource.DataMember = "AGENCIAS_CIUDADES"
        Me.AGENCIASCIUDADESBindingSource.DataSource = Me.AGENCIASBindingSource
        '
        'CIUDADESTableAdapter
        '
        Me.CIUDADESTableAdapter.ClearBeforeFill = True
        '
        'AGENCIASZONASBindingSource
        '
        Me.AGENCIASZONASBindingSource.DataMember = "AGENCIAS_ZONAS"
        Me.AGENCIASZONASBindingSource.DataSource = Me.AGENCIASBindingSource
        '
        'ZONASTableAdapter
        '
        Me.ZONASTableAdapter.ClearBeforeFill = True
        '
        'CIUDADESBindingSource
        '
        Me.CIUDADESBindingSource.DataMember = "CIUDADES"
        Me.CIUDADESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'ZONASBindingSource
        '
        Me.ZONASBindingSource.DataMember = "ZONAS"
        Me.ZONASBindingSource.DataSource = Me.DataSet_IPSS
        '
        'CIUDADESBindingSource1
        '
        Me.CIUDADESBindingSource1.DataMember = "CIUDADES"
        Me.CIUDADESBindingSource1.DataSource = Me.DataSet_IPSS
        '
        'FrmAgencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 372)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_GUARDAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAgencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agencias"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENCIASCIUDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGENCIASZONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIUDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIUDADESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents AGENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AGENCIASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.AGENCIASTableAdapter
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AGENCIASCIUDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUDADESTableAdapter As SisSalud.DataSet_IPSSTableAdapters.CIUDADESTableAdapter
    Friend WithEvents AGENCIASZONASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZONASTableAdapter As SisSalud.DataSet_IPSSTableAdapters.ZONASTableAdapter
    Friend WithEvents CIUDADESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ZONASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUDADESBindingSource As System.Windows.Forms.BindingSource
End Class
