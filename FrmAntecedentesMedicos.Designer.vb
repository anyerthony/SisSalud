<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAntecedentesMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAntecedentesMedicos))
        Me.BTN_BUSCAR = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BTN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BTN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ANTECEDENTESMEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_IPSS = New SisSalud.DataSet_IPSS
        Me.ANTECEDENTES_MEDICOSTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.ANTECEDENTES_MEDICOSTableAdapter
        Me.TIPOANTECEDENTEMEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_ANTECEDENTE_MEDICOTableAdapter = New SisSalud.DataSet_IPSSTableAdapters.TIPO_ANTECEDENTE_MEDICOTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ANTECEDENTESMEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOANTECEDENTEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANTECEDENTESMEDICOSBindingSource, "nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(95, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 20)
        Me.TextBox2.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANTECEDENTESMEDICOSBindingSource, "id_tipo", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TIPOANTECEDENTEMEDICOBindingSource, "id", True))
        Me.TextBox1.Location = New System.Drawing.Point(95, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 20)
        Me.TextBox1.TabIndex = 72
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource, "nombre", True))
        Me.TextBox3.Location = New System.Drawing.Point(191, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 74
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANTECEDENTESMEDICOSBindingSource, "id", True))
        Me.TextBox4.Location = New System.Drawing.Point(95, 12)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(86, 20)
        Me.TextBox4.TabIndex = 75
        '
        'ANTECEDENTESMEDICOSBindingSource
        '
        Me.ANTECEDENTESMEDICOSBindingSource.DataMember = "ANTECEDENTES_MEDICOS"
        Me.ANTECEDENTESMEDICOSBindingSource.DataSource = Me.DataSet_IPSS
        '
        'DataSet_IPSS
        '
        Me.DataSet_IPSS.DataSetName = "DataSet_IPSS"
        Me.DataSet_IPSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ANTECEDENTES_MEDICOSTableAdapter
        '
        Me.ANTECEDENTES_MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'TIPOANTECEDENTEMEDICOBindingSource
        '
        Me.TIPOANTECEDENTEMEDICOBindingSource.DataMember = "TIPO_ANTECEDENTE_MEDICO"
        Me.TIPOANTECEDENTEMEDICOBindingSource.DataSource = Me.DataSet_IPSS
        '
        'TIPO_ANTECEDENTE_MEDICOTableAdapter
        '
        Me.TIPO_ANTECEDENTE_MEDICOTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource
        '
        'ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource
        '
        Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource.DataMember = "ANTECEDENTES_MEDICOS_TIPO_ANTECEDENTE_MEDICO"
        Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource.DataSource = Me.ANTECEDENTESMEDICOSBindingSource
        '
        'FrmAntecedentesMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 156)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "FrmAntecedentesMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Medicos"
        CType(Me.ANTECEDENTESMEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOANTECEDENTEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_BUSCAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_IPSS As SisSalud.DataSet_IPSS
    Friend WithEvents ANTECEDENTESMEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ANTECEDENTES_MEDICOSTableAdapter As SisSalud.DataSet_IPSSTableAdapters.ANTECEDENTES_MEDICOSTableAdapter
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TIPOANTECEDENTEMEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPO_ANTECEDENTE_MEDICOTableAdapter As SisSalud.DataSet_IPSSTableAdapters.TIPO_ANTECEDENTE_MEDICOTableAdapter
    Friend WithEvents ANTECEDENTESMEDICOSTIPOANTECEDENTEMEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
