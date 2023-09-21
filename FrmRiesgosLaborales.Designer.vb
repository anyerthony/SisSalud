<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRiesgosLaborales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRiesgosLaborales))
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RIESGOSLABORALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.RIESGOS_LABORALESTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.RIESGOS_LABORALESTableAdapter
        Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLASIFICACION_RIESGO_LABORALTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.CLASIFICACION_RIESGO_LABORALTableAdapter
        Me.CLASIFICACIONRIESGOLABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIESGOSLABORALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLASIFICACIONRIESGOLABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RIESGOSLABORALESBindingSource, "id", True))
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
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(20, 121)
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
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(333, 121)
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
        Me.BTN_NUEVO.Location = New System.Drawing.Point(99, 121)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(60, 23)
        Me.BTN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_NUEVO.Symbol = ""
        Me.BTN_NUEVO.TabIndex = 65
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RIESGOSLABORALESBindingSource, "nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(95, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 20)
        Me.TextBox2.TabIndex = 64
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource, "nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(191, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 73
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RIESGOSLABORALESBindingSource, "id_clasificacion", True))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CLASIFICACIONRIESGOLABORALBindingSource, "id", True))
        Me.TextBox3.Location = New System.Drawing.Point(98, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(87, 20)
        Me.TextBox3.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Clasificación:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource
        '
        'RIESGOSLABORALESBindingSource
        '
        Me.RIESGOSLABORALESBindingSource.DataMember = "RIESGOS_LABORALES"
        Me.RIESGOSLABORALESBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RIESGOS_LABORALESTableAdapter
        '
        Me.RIESGOS_LABORALESTableAdapter.ClearBeforeFill = True
        '
        'RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource
        '
        Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource.DataMember = "RIESGOS_LABORALES_CLASIFICACION_RIESGO_LABORAL"
        Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource.DataSource = Me.RIESGOSLABORALESBindingSource
        '
        'CLASIFICACION_RIESGO_LABORALTableAdapter
        '
        Me.CLASIFICACION_RIESGO_LABORALTableAdapter.ClearBeforeFill = True
        '
        'CLASIFICACIONRIESGOLABORALBindingSource
        '
        Me.CLASIFICACIONRIESGOLABORALBindingSource.DataMember = "CLASIFICACION_RIESGO_LABORAL"
        Me.CLASIFICACIONRIESGOLABORALBindingSource.DataSource = Me.DataSet_IPSS
        '
        'FrmRiesgosLaborales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 156)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
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
        Me.Name = "FrmRiesgosLaborales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riesgos Laborales"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIESGOSLABORALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLASIFICACIONRIESGOLABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents RIESGOSLABORALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RIESGOS_LABORALESTableAdapter As SisSalud.DataSet_IPSSTableAdapters.RIESGOS_LABORALESTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RIESGOSLABORALESCLASIFICACIONRIESGOLABORALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLASIFICACION_RIESGO_LABORALTableAdapter As SisSalud.DataSet_IPSSTableAdapters.CLASIFICACION_RIESGO_LABORALTableAdapter
    Friend WithEvents CLASIFICACIONRIESGOLABORALBindingSource As System.Windows.Forms.BindingSource
End Class
