<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConceptos))
        Me.Nombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CONCEPTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.Label26 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.CONCEPTOSESPECIALIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ESPECIALIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.CLASIFICACIONCONCEPTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.LISTA_TIPOS = New System.Windows.Forms.ComboBox
        Me.L_TIPO_EXAMEN = New System.Windows.Forms.Label
        Me.LISTA_TIPO_EXAMEN = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.CONCEPTOSTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.CONCEPTOSTableAdapter
        Me.CLASIFICACION_CONCEPTOSTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.CLASIFICACION_CONCEPTOSTableAdapter
        Me.ESPECIALIDADESTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.ESPECIALIDADESTableAdapter
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.CONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLASIFICACIONCONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(65, 14)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(43, 13)
        Me.Nombre.TabIndex = 4
        Me.Nombre.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Especialidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Tipo:"
        '
        'CONCEPTOSBindingSource
        '
        Me.CONCEPTOSBindingSource.DataMember = "CONCEPTOS"
        Me.CONCEPTOSBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 145)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 13)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "Maneja inventario:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "codigo", True))
        Me.TextBox1.Location = New System.Drawing.Point(119, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(118, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(353, 20)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSESPECIALIDADESBindingSource, "nombre", True))
        Me.TextBox3.Location = New System.Drawing.Point(225, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(246, 20)
        Me.TextBox3.TabIndex = 27
        '
        'CONCEPTOSESPECIALIDADESBindingSource
        '
        Me.CONCEPTOSESPECIALIDADESBindingSource.DataMember = "CONCEPTOS_ESPECIALIDADES"
        Me.CONCEPTOSESPECIALIDADESBindingSource.DataSource = Me.CONCEPTOSBindingSource
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "id_especialidad", True))
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ESPECIALIDADESBindingSource, "id", True))
        Me.TextBox4.Location = New System.Drawing.Point(119, 64)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 26
        '
        'ESPECIALIDADESBindingSource
        '
        Me.ESPECIALIDADESBindingSource.DataMember = "ESPECIALIDADES"
        Me.ESPECIALIDADESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource, "nombre", True))
        Me.TextBox5.Location = New System.Drawing.Point(225, 90)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(246, 20)
        Me.TextBox5.TabIndex = 30
        '
        'CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource
        '
        Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource.DataMember = "CONCEPTOS_CLASIFICACION_CONCEPTOS"
        Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource.DataSource = Me.CONCEPTOSBindingSource
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CLASIFICACIONCONCEPTOSBindingSource, "id", True))
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "id_clasificacion", True))
        Me.TextBox6.Location = New System.Drawing.Point(119, 90)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 29
        '
        'CLASIFICACIONCONCEPTOSBindingSource
        '
        Me.CLASIFICACIONCONCEPTOSBindingSource.DataMember = "CLASIFICACION_CONCEPTOS"
        Me.CLASIFICACIONCONCEPTOSBindingSource.DataSource = Me.DataSet_IPSS
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Clasificación:"
        '
        'LISTA_TIPOS
        '
        Me.LISTA_TIPOS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONCEPTOSBindingSource, "tipo", True))
        Me.LISTA_TIPOS.DisplayMember = "nombre"
        Me.LISTA_TIPOS.FormattingEnabled = True
        Me.LISTA_TIPOS.Location = New System.Drawing.Point(119, 118)
        Me.LISTA_TIPOS.Name = "LISTA_TIPOS"
        Me.LISTA_TIPOS.Size = New System.Drawing.Size(100, 21)
        Me.LISTA_TIPOS.TabIndex = 31
        Me.LISTA_TIPOS.ValueMember = "cod"
        '
        'L_TIPO_EXAMEN
        '
        Me.L_TIPO_EXAMEN.AutoSize = True
        Me.L_TIPO_EXAMEN.Location = New System.Drawing.Point(225, 121)
        Me.L_TIPO_EXAMEN.Name = "L_TIPO_EXAMEN"
        Me.L_TIPO_EXAMEN.Size = New System.Drawing.Size(72, 13)
        Me.L_TIPO_EXAMEN.TabIndex = 32
        Me.L_TIPO_EXAMEN.Text = "Tipo Examen:"
        Me.L_TIPO_EXAMEN.Visible = False
        '
        'LISTA_TIPO_EXAMEN
        '
        Me.LISTA_TIPO_EXAMEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "tipo_examen", True))
        Me.LISTA_TIPO_EXAMEN.FormattingEnabled = True
        Me.LISTA_TIPO_EXAMEN.Items.AddRange(New Object() {"Funcional", "Físico", "Paraclínico"})
        Me.LISTA_TIPO_EXAMEN.Location = New System.Drawing.Point(303, 118)
        Me.LISTA_TIPO_EXAMEN.Name = "LISTA_TIPO_EXAMEN"
        Me.LISTA_TIPO_EXAMEN.Size = New System.Drawing.Size(100, 21)
        Me.LISTA_TIPO_EXAMEN.TabIndex = 33
        Me.LISTA_TIPO_EXAMEN.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "IVA %:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.CONCEPTOSESPECIALIDADESBindingSource
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSBindingSource, "iva", True))
        Me.TextBox7.Location = New System.Drawing.Point(119, 164)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 36
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_BUSCAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(228, 12)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(20, 20)
        Me.BTN_BUSCAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_BUSCAR.Symbol = ""
        Me.BTN_BUSCAR.SymbolSize = 12.0!
        Me.BTN_BUSCAR.TabIndex = 64
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_ELIMINAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(109, 201)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_ELIMINAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_ELIMINAR.Symbol = ""
        Me.BTN_ELIMINAR.TabIndex = 63
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_GUARDAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(422, 201)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(60, 23)
        Me.BTN_GUARDAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_GUARDAR.Symbol = ""
        Me.BTN_GUARDAR.TabIndex = 62
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_NUEVO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_NUEVO.Location = New System.Drawing.Point(188, 201)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(60, 23)
        Me.BTN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_NUEVO.Symbol = ""
        Me.BTN_NUEVO.TabIndex = 61
        '
        'CONCEPTOSTableAdapter
        '
        Me.CONCEPTOSTableAdapter.ClearBeforeFill = True
        '
        'CLASIFICACION_CONCEPTOSTableAdapter
        '
        Me.CLASIFICACION_CONCEPTOSTableAdapter.ClearBeforeFill = True
        '
        'ESPECIALIDADESTableAdapter
        '
        Me.ESPECIALIDADESTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CONCEPTOSBindingSource, "inventario", True))
        Me.CheckBox1.Location = New System.Drawing.Point(118, 144)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 65
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(508, 238)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_GUARDAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LISTA_TIPO_EXAMEN)
        Me.Controls.Add(Me.L_TIPO_EXAMEN)
        Me.Controls.Add(Me.LISTA_TIPOS)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmConceptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos"
        CType(Me.CONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLASIFICACIONCONCEPTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LISTA_TIPOS As System.Windows.Forms.ComboBox
    Friend WithEvents L_TIPO_EXAMEN As System.Windows.Forms.Label
    Friend WithEvents LISTA_TIPO_EXAMEN As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents CONCEPTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSTableAdapter As SisSalud.DataSet_IPSSTableAdapters.CONCEPTOSTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSCLASIFICACIONCONCEPTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLASIFICACION_CONCEPTOSTableAdapter As SisSalud.DataSet_IPSSTableAdapters.CLASIFICACION_CONCEPTOSTableAdapter
    Friend WithEvents CLASIFICACIONCONCEPTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ESPECIALIDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ESPECIALIDADESTableAdapter As SisSalud.DataSet_IPSSTableAdapters.ESPECIALIDADESTableAdapter
    Friend WithEvents CONCEPTOSESPECIALIDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
