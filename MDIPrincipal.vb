Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MDIPrincipal

    Sub CargarPerfil()
        StrSQL = "SELECT A.id_perfil,B.nombre FROM QAPD_CONTROL..MANPERFILES_USUARIOS A INNER JOIN QAPD_CONTROL..MANPERFILES B ON A.id_perfil=B.id_perfil WHERE A.status=1 AND B.status=1 AND A.usuario='" & Cod_Usuario & "' "
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)

        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            Select Case Arreglo("nombre")
                Case Is = "FACTURAR INGRESO"
                    FacturarToolStripMenuItem1.Visible = True
                Case Is = "FACTURAR TARJETA"
                    FacturarTarjetasToolStripMenuItem.Visible = True
                Case Is = "FACTURAR SERVICIO"
                    FacturarServicioToolStripMenuItem.Visible = True
                Case Is = "MIGRAR DOCUMENTOS"
                    MigrarDocumentosToolStripMenuItem1.Visible = True
                Case Is = "MIGRAR FACTURAS"
                    MigrarFacturasToolStripMenuItem1.Visible = True
                Case Is = "MAESTRO CLIENTES"
                    MaestroDeClientesPacientesToolStripMenuItem.Visible = True
                Case Is = "CREAR NOTAS"
                    CrearNotasToolStripMenuItem.Visible = True
                Case Is = "ANULAR DOCUMENTOS"
                    AnularDocumentosToolStripMenuItem.Visible = True
                Case Is = "MODIFICACION NRO CTRL"
                    ModificacionDeNumeroDeCtrlToolStripMenuItem.Visible = True
                Case Is = "ADMINISTRACION"
                    AdministracionToolStripMenuItem1.Visible = True
                Case Is = "MENU OPERACIONES"
                    OperacionesToolStripMenuItem.Visible = True
                Case Is = "MENU MANTENIMINETO"
                    ManteniminetoToolStripMenuItem.Visible = True
                Case Is = "MENU FACTURACION"
                    IntegralToolStripMenuItem.Visible = True
                Case Is = "CREAR INGRESO"
                    IngresosToolStripMenuItem.Visible = True
                Case Is = "MENU_ADMINISTRACION"
                    AdministracionToolStripMenuItem.Visible = True
                Case Is = "FACTURAR ALTAMIRA"
                    FacturarAltamiraToolStripMenuItem.Visible = True
                Case Is = "IMPRESION DE DOCUMENTOS"
                    ImpresionDeDocumentosToolStripMenuItem.Visible = True
                Case Is = "IMPRESION DE IGTF"
                    IGTFToolStripMenuItem.Visible = True
                Case Is = "IMPRESION DE FACTURAS"
                    FacturasToolStripMenuItem.Visible = True
                Case Is = "CAMBIAR CORRELATIVOS"
                    CambiarCorrelativosToolStripMenuItem.Visible = True
                Case Is = "TASAS DE CAMBIO OPERACIONES"
                    TasasToolStripMenuItem.Visible = True
                Case Is = "CREAR SERVICIOS"
                    FrmFacturarServicio.CREAR_SERVICIO.Visible = True
                Case Is = "ACCESO COMPLETO PARAMETROS USUARIO"
                    AdministracionParametrosOtrosUsuariosToolStripMenuItem.Visible = True
                Case Is = "CREAR VISITAS"
                    VisitasToolStripMenuItem.Visible = True
                Case Is = "CAMBIAR TASA A INGRESO OPERACIONES"
                    CambiarTasaAIngresoToolStripMenuItem.Visible = True
                Case Is = "TASAS DE CAMBIO FACTURACION"
                    CambiarTasaDiariaToolStripMenuItem.Visible = True
                Case Is = "CAMBIAR TASA A INGRESO FACTURACION"
                    ModificarTasaAUnIngresoToolStripMenuItem.Visible = True
                Case Is = "CAMBIAR TASA ASEGURADORA"
                    ModificarTasaAseguradorasToolStripMenuItem.Visible = True
                Case Is = "MENU_MAESTROS"
                    MaestrosToolStripMenuItem.Visible = True
                Case Is = "COBRAR"
                    CobrarToolStripMenuItem.Visible = True
                Case Is = "REPORTES FACTURACION"
                    ReportesToolStripMenuItem1.Visible = True
                Case Is = "IMPRESION DE DOCUMENTOS"
                    ImpresionDeDocumentosToolStripMenuItem.Visible = True

            End Select
        End While
        con.Close()


    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

  

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MigrarFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MDIPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub MigrarDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SeleccionarEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarEmpresaToolStripMenuItem.Click
        FrmSelEmpresa.ShowDialog()
    End Sub

    Private Sub ExportarMañongoACaracasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RelacionarClientesProfitConAseguradorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmArticulo.MdiParent = Me
        FrmArticulo.Show()
    End Sub

    Private Sub FacturarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarToolStripMenuItem1.Click
        FrmIntegral_Facturar.MdiParent = Me
        FrmIntegral_Facturar.Show()
    End Sub

    Private Sub MigrarDocumentosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrarDocumentosToolStripMenuItem1.Click
        FrmIntegral_MigrarDocumentos.MdiParent = Me
        FrmIntegral_MigrarDocumentos.Show()
    End Sub

    Private Sub MigrarFacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrarFacturasToolStripMenuItem1.Click
        FrmIntegralFacturas.MdiParent = Me
        FrmIntegralFacturas.Show()
    End Sub

    Private Sub RelacionarAseguradorasConClientesProfitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionarAseguradorasConClientesProfitToolStripMenuItem.Click
        FrmAseguradorasClientes.MdiParent = Me
        FrmAseguradorasClientes.Show()
    End Sub

   
    Private Sub ExportarMañongoACaracasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarMañongoACaracasToolStripMenuItem1.Click
        FrmMañongoExport.MdiParent = Me
        FrmMañongoExport.Show()
    End Sub

    Private Sub ModificarPreciosPorPromocionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarPreciosPorPromocionToolStripMenuItem.Click
        FrmModificarPrecioPromocion.MdiParent = Me
        FrmModificarPrecioPromocion.Show()
    End Sub
    Private Sub CrearBaremoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearBaremoToolStripMenuItem.Click
        CrearBaremo()
    End Sub

    Private Sub NuevaCotizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaCotizacionToolStripMenuItem.Click
        FrmCotizacionExcel.MdiParent = Me
        FrmCotizacionExcel.Show()
    End Sub

    Private Sub SelecionarSucursalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarSucursalToolStripMenuItem.Click
        FrmSelSucursal.ShowDialog()
    End Sub

    Private Sub FacturarTarjetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarTarjetasToolStripMenuItem.Click
        FrmFacturarTarjetas.MdiParent = Me
        FrmFacturarTarjetas.Show()
    End Sub

    Private Sub MaestroDeClientesPacientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaestroDeClientesPacientesToolStripMenuItem.Click
        FrmClientes.MdiParent = Me
        FrmClientes.Show()
    End Sub

    Private Sub CrearNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearNotasToolStripMenuItem.Click
        FrmIntegral_CrearNotas.MdiParent = Me
        FrmIntegral_CrearNotas.Show()
    End Sub

    Private Sub AnularDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularDocumentosToolStripMenuItem.Click
        FrmAnularDocumentos.MdiParent = Me
        FrmAnularDocumentos.Show()
    End Sub

    Private Sub FacturarServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarServicioToolStripMenuItem.Click
        FrmFacturarServicio.MdiParent = Me
        FrmFacturarServicio.Show()
    End Sub

    Private Sub MDIPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.Q Then
            MDI_PrincipalV2.Show()
        End If
    End Sub

    Private Sub MDIPrincipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub MDIPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarPerfil()
        If Cod_Usuario = "sa_01" Then
            v2.Visible = True
        End If
    End Sub

    Private Sub ImprimirUnaFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobrarToolStripMenuItem.Click
        FrmIntegral_Cobros.MdiParent = Me
        FrmIntegral_Cobros.Show()
    End Sub

    Private Sub ModificacionDeNumeroDeCtrlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDeNumeroDeCtrlToolStripMenuItem.Click
        FrmModificacionNroCtrl.MdiParent = Me
        FrmModificacionNroCtrl.Show()
    End Sub

    Private Sub ConsultoriosAgenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FacturarAltamiraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarAltamiraToolStripMenuItem.Click
        FrmFacturacionAltamira.MdiParent = Me
        FrmFacturacionAltamira.Show()
    End Sub

    Private Sub ImprimirProfitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IGTFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IGTFToolStripMenuItem.Click
        Dim NroIGTF As String = InputBox("Por Favor indique el Nro de Factura asociada al IGTF", "Nro Factura", "")
        If Len(NroIGTF) < 3 Then Exit Sub
        'NroIGTF = Val(NroIGTF)
        'NroIGTF = Replicate("0", 9 - Len(NroIGTF)) + NroIGTF
        StrSQL = "SELECT nro_doc FROM saDocumentoVenta WHERE co_tipo_doc='IGTF' AND doc_orig='FACT' AND nro_orig='" & NroIGTF & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            ImprimirIGTF(Arreglo("nro_doc"))
        End While
    End Sub

    'Private Sub FacturaProfitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaProfitToolStripMenuItem.Click
    '    Dim NroFact As String = InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")
    '    If Len(NroFact) < 7 Then
    '        MsgBox("Disculpe, debe indicar el nro de factura completo", MsgBoxStyle.Information, "Intente de nuevo")
    '        Exit Sub
    '    End If
    '    Imprimirfactura("RptFormatoFacturaProfit.rpt", NroFact)
    'End Sub

    'Private Sub FacturaAParticularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaAParticularToolStripMenuItem.Click
    '    Dim NroFact As String = InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")
    '    If Len(NroFact) < 7 Then
    '        MsgBox("Disculpe, debe indicar el nro de factura completo", MsgBoxStyle.Information, "Intente de nuevo")
    '        Exit Sub
    '    End If
    '    Imprimirfactura("RptFormatoFacturaParticular.rpt", NroFact)
    'End Sub

    Private Sub CambiarCorrelativosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarCorrelativosToolStripMenuItem.Click
        FrmActualizarCorrelativos.MdiParent = Me
        FrmActualizarCorrelativos.Show()
    End Sub

    Private Sub ConsultoriosAgenciasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultoriosAgenciasToolStripMenuItem1.Click
        FrmConsultorios.MdiParent = Me
        FrmConsultorios.Show()
    End Sub

    Private Sub AccesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoToolStripMenuItem.Click
        FrmCtrlAcceso.MdiParent = Me
        FrmCtrlAcceso.Show()
    End Sub

    Private Sub CrearIngresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearIngresosToolStripMenuItem.Click
        FrmCrearIngreso.MdiParent = Me
        FrmCrearIngreso.Show()
    End Sub

    Private Sub ParametrosDelUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParametrosDelUsuarioToolStripMenuItem.Click
        FrmParametrosUsuarios.Cargar()
        FrmParametrosUsuarios.ShowDialog()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        FrmImprimirFactura.MdiParent = Me
        FrmImprimirFactura.Show()
    End Sub


    Private Sub TasasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TasasToolStripMenuItem.Click
        FrmActualizarTasas.MdiParent = Me
        FrmActualizarTasas.Show()
    End Sub

  
    Private Sub ReportesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem1.Click
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub AdministracionParametrosOtrosUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministracionParametrosOtrosUsuariosToolStripMenuItem.Click
        FrmParametros_OtrosUsuarios.MdiParent = Me
        FrmParametros_OtrosUsuarios.Show()
    End Sub

    Private Sub VisitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitasToolStripMenuItem.Click
      

        FrmVisita.MdiParent = Me
        FrmVisita.Show()
    End Sub


    Private Sub CambiarTasaAIngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTasaAIngresoToolStripMenuItem.Click
        FrmCambiarTasaIngreso.MdiParent = Me
        FrmCambiarTasaIngreso.Show()
    End Sub

    Private Sub CambiarTasaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTasaDiariaToolStripMenuItem.Click
        FrmActualizarTasas.MdiParent = Me
        FrmActualizarTasas.Show()
    End Sub

    Private Sub ModificarTasaAUnIngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarTasaAUnIngresoToolStripMenuItem.Click
        FrmCambiarTasaIngreso.MdiParent = Me
        FrmCambiarTasaIngreso.Show()
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosToolStripMenuItem.Click
        FrmConceptos.MdiParent = Me
        FrmConceptos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmPaciente.MdiParent = Me
        FrmPaciente.Show()
    End Sub

    Private Sub ModificarTasaAseguradorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarTasaAseguradorasToolStripMenuItem.Click
        FrmActualizarTasaAseguradora.MdiParent = Me
        FrmActualizarTasaAseguradora.Show()
    End Sub
    

  
    Private Sub CiudadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CiudadesToolStripMenuItem.Click
        FrmCiudades.MdiParent = Me
        FrmCiudades.Show()
    End Sub

    Private Sub ConsultoriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultoriosToolStripMenuItem.Click
        'FrmAgencias.MdiParent = Me
        'FrmAgencias.Show()
    End Sub

    Private Sub CompañiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompañiasToolStripMenuItem.Click
        FrmCompanias.MdiParent = Me
        FrmCompanias.Show()
    End Sub

    Private Sub PistasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PistasToolStripMenuItem.Click
        FrmPistas.MdiParent = Me
        FrmPistas.Show()
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaisesToolStripMenuItem.Click
        FrmPaises.MdiParent = Me
        FrmPaises.Show()
    End Sub

    Private Sub NivelesEducativosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NivelesEducativosToolStripMenuItem.Click
        FrmNivelesEducativos.MdiParent = Me
        FrmNivelesEducativos.Show()
    End Sub

    Private Sub ZonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZonasToolStripMenuItem.Click
        FrmZonas.MdiParent = Me
        FrmZonas.Show()
    End Sub

    Private Sub DependenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DependenciasToolStripMenuItem.Click
        FrmDependencias.MdiParent = Me
        FrmDependencias.Show()
    End Sub

    Private Sub ProfecionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfecionesToolStripMenuItem.Click
        FrmProfeciones.MdiParent = Me
        FrmProfeciones.Show()
    End Sub

    Private Sub FormatosFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatosFacturaToolStripMenuItem.Click
        FrmFormatosFactura.MdiParent = Me
        FrmFormatosFactura.Show()
    End Sub

    Private Sub BaremosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaremosToolStripMenuItem.Click
        FrmBaremos.MdiParent = Me
        FrmBaremos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDI_PrincipalV2.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2.Click
        If Cod_Usuario = "sa_01" Then
            MDI_PrincipalV2.Show()
        End If


    End Sub
End Class
