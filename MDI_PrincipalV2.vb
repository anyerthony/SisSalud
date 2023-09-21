Imports System.Data.SqlClient

Public Class MDI_PrincipalV2

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
                    BTN_FACTURAR.Visible = True
                    BTN_FACTURAR_INGRESOS.Visible = True
                Case Is = "FACTURAR TARJETA"
                    BTN_FACTURAR.Visible = True
                    BTN_FACTURAR_TARJETAS.Visible = True
                Case Is = "FACTURAR SERVICIO"
                    BTN_FACTURAR.Visible = True
                    BTN_FACTURAR_SERVICIOS.Visible = True
                Case Is = "MIGRAR DOCUMENTOS"
                    BTN_MIGRAR.Visible = True
                    BTN_MIGRAR_DOCUMENTOS.Visible = True
                Case Is = "MIGRAR FACTURAS"
                    BTN_MIGRAR.Visible = True
                    BTN_MIGRAR_FACTURAS.Visible = True
                Case Is = "MAESTRO CLIENTES"
                    BTN_MAESTRO_CLIENTES.Visible = True
                Case Is = "CREAR NOTAS"
                    BTN_CREAR_NOTAS.Visible = True
                Case Is = "ANULAR DOCUMENTOS"
                    BTN_ANULAR.Visible = True
                Case Is = "MODIFICACION NRO CTRL"
                    BTN_MOD_CTRL.Visible = True
                Case Is = "ADMINISTRACION"
                    'AdministracionToolStripMenuItem1.Visible = True
                Case Is = "MENU OPERACIONES"
                    TAB_OPERACIONES.Visible = True
                Case Is = "MENU MANTENIMINETO"
                    TAB_MANTENIMIENTO.Visible = True
                Case Is = "MENU FACTURACION"
                    TAB_FACTURACION.Visible = True
                Case Is = "CREAR INGRESO"
                    BTN_INGRESOS_MPPT.Visible = True
                Case Is = "MENU_ADMINISTRACION"
                    TAB_ADMINISTRACION.Visible = True
                Case Is = "FACTURAR ALTAMIRA"
                    'FacturarAltamiraToolStripMenuItem.Visible = True
                Case Is = "IMPRESION DE DOCUMENTOS"
                    'ImpresionDeDocumentosToolStripMenuItem.Visible = True
                Case Is = "IMPRESION DE IGTF"
                    BTN_REP_IGTF.Visible = True
                Case Is = "IMPRESION DE FACTURAS"
                    BTN_REP_FACTURAS.Visible = True
                Case Is = "CAMBIAR CORRELATIVOS"
                    BTN_CORRELATIVOS.Visible = True
                Case Is = "TASAS DE CAMBIO OPERACIONES"
                    BTN_TASAS_OP.Visible = True
                Case Is = "CREAR SERVICIOS"
                    FrmFacturarServicio.CREAR_SERVICIO.Visible = True
                Case Is = "ACCESO COMPLETO PARAMETROS USUARIO"
                    BTN_PARAMETROS_USUARIOS.Visible = True
                Case Is = "CREAR VISITAS"
                    BTN_VISITA.Visible = True
                Case Is = "CAMBIAR TASA A INGRESO OPERACIONES"
                    BTN_TASA_INGRESO_OP.Visible = True
                Case Is = "TASAS DE CAMBIO FACTURACION"
                    BTN_TASAS.Visible = True
                Case Is = "CAMBIAR TASA A INGRESO FACTURACION"
                    BTN_TASA_INGRESO.Visible = True
                Case Is = "CAMBIAR TASA ASEGURADORA"
                    'ModificarTasaAseguradorasToolStripMenuItem.Visible = True
                Case Is = "MENU_MAESTROS"
                    '.Visible = True
                Case Is = "COBRAR"
                    BTN_COBRAR.Visible = True
                Case Is = "REPORTES FACTURACION"
                    BTN_REPORTES_FACTURACION.Visible = True
                Case Is = "IMPRESION DE DOCUMENTOS"
                    'ImpresionDeDocumentosToolStripMenuItem.Visible = True

            End Select
        End While
        con.Close()


    End Sub

    Private Sub MDI_PrincipalV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Bounds = Screen.GetWorkingArea(MDIPrincipal)
        Me.MaximumSize = Screen.GetWorkingArea(Me).Size
        Me.WindowState = FormWindowState.Maximized

        CargarPerfil()

        RibbonControl1.Expanded = False


        Dim tmp As New DataTable
        tmp.Columns.Add("c1", GetType(String))
        tmp.Rows.Add(DBNull.Value)

    End Sub


    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Me.Close()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        FrmSelSucursal.ShowDialog()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        FrmParametrosUsuarios.Cargar()
        FrmParametrosUsuarios.ShowDialog()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        FrmSelEmpresa.ShowDialog()
    End Sub

    Private Sub BTN_FACTURAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURAR.Click
        If BTN_FACTURAR_INGRESOS.Visible Then
            FrmIntegral_Facturar.MdiParent = Me
            FrmIntegral_Facturar.Show()
        ElseIf BTN_FACTURAR_TARJETAS.Visible Then
            FrmFacturarTarjetas.MdiParent = Me
            FrmFacturarTarjetas.Show()
        ElseIf BTN_FACTURAR_SERVICIOS.Visible Then
            FrmFacturarServicio.MdiParent = Me
            FrmFacturarServicio.Show()
        End If

    End Sub

    Private Sub BTN_FACTURAR_INGRESOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURAR_INGRESOS.Click
        FrmIntegral_Facturar.MdiParent = Me
        FrmIntegral_Facturar.Show()
    End Sub

    Private Sub BTN_CREAR_NOTAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CREAR_NOTAS.Click
        FrmIntegral_CrearNotas.MdiParent = Me
        FrmIntegral_CrearNotas.Show()
    End Sub

    Private Sub BTN_FACTURAR_TARJETAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURAR_TARJETAS.Click
        FrmFacturarTarjetas.MdiParent = Me
        FrmFacturarTarjetas.Show()
    End Sub

    Private Sub BTN_FACTURAR_SERVICIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FACTURAR_SERVICIOS.Click
        FrmFacturarServicio.MdiParent = Me
        FrmFacturarServicio.Show()
    End Sub

    Private Sub BTN_COBRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_COBRAR.Click
        FrmIntegral_Cobros.MdiParent = Me
        FrmIntegral_Cobros.Show()
    End Sub

    Private Sub BTN_MIGRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MIGRAR.Click
        If BTN_MIGRAR_DOCUMENTOS.Visible Then
            FrmIntegral_MigrarDocumentos.MdiParent = Me
            FrmIntegral_MigrarDocumentos.Show()
        ElseIf BTN_MIGRAR_FACTURAS.Visible = True Then
            FrmIntegralFacturas.MdiParent = Me
            FrmIntegralFacturas.Show()
        End If


    End Sub

    Private Sub BTN_MIGRAR_DOCUMENTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MIGRAR_DOCUMENTOS.Click
        FrmIntegral_MigrarDocumentos.MdiParent = Me
        FrmIntegral_MigrarDocumentos.Show()
    End Sub

    Private Sub BTN_MIGRAR_FACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MIGRAR_FACTURAS.Click
        FrmIntegralFacturas.MdiParent = Me
        FrmIntegralFacturas.Show()
    End Sub

    Private Sub BTN_ANULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ANULAR.Click
        FrmAnularDocumentos.MdiParent = Me
        FrmAnularDocumentos.Show()
    End Sub

    Private Sub BTN_MOD_CTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MOD_CTRL.Click
        FrmModificacionNroCtrl.MdiParent = Me
        FrmModificacionNroCtrl.Show()
    End Sub

    Private Sub BTN_CORRELATIVOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CORRELATIVOS.Click
        FrmActualizarCorrelativos.MdiParent = Me
        FrmActualizarCorrelativos.Show()
    End Sub

    Private Sub BTN_TASAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TASAS.Click
        FrmActualizarTasas.MdiParent = Me
        FrmActualizarTasas.Show()
    End Sub

    Private Sub BTN_TASA_INGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TASA_INGRESO.Click
        FrmCambiarTasaIngreso.MdiParent = Me
        FrmCambiarTasaIngreso.Show()
    End Sub

    Private Sub BTN_MAESTRO_CLIENTES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MAESTRO_CLIENTES.Click
        FrmClientes.MdiParent = Me
        FrmClientes.Show()
    End Sub

  

    Private Sub BTN_DEPENDENCIAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DEPENDENCIAS.Click
        FrmDependencias.MdiParent = Me
        FrmDependencias.Show()
    End Sub

    Private Sub BTN_PAISES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PAISES.Click
        FrmPaises.MdiParent = Me
        FrmPaises.Show()
    End Sub

    Private Sub BTN_CIUDADES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CIUDADES.Click
        FrmCiudades.MdiParent = Me
        FrmCiudades.Show()
    End Sub

    Private Sub BTN_ZONAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ZONAS.Click
        FrmZonas.MdiParent = Me
        FrmZonas.Show()
    End Sub

    Private Sub BTN_PROFESIONES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROFESIONES.Click
        FrmProfeciones.MdiParent = Me
        FrmProfeciones.Show()
    End Sub

    Private Sub BTN_NIVEL_EDUCATIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NIVEL_EDUCATIVO.Click
        FrmNivelesEducativos.MdiParent = Me
        FrmNivelesEducativos.Show()
    End Sub

    Private Sub BTN_FORMATO_FACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FORMATO_FACTURAS.Click
        FrmFormatosFactura.MdiParent = Me
        FrmFormatosFactura.Show()
    End Sub

    Private Sub BTN_BAREMOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BAREMOS.Click

    End Sub

    Private Sub BTN_REP_IGTF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REP_IGTF.Click
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

    Private Sub BTN_REP_FACTURAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REP_FACTURAS.Click
        FrmImprimirFactura.MdiParent = Me
        FrmImprimirFactura.Show()
    End Sub

    Private Sub BTN_REPORTES_FACTURACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REPORTES_FACTURACION.Click
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub BTN_COLAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_COLAP.Click
        RibbonControl1.Expanded = Not RibbonControl1.Expanded
        If RibbonControl1.Expanded Then
            BTN_COLAP.Text = "Colapsar cinta de opciones"
        Else
            BTN_COLAP.Text = "Expandir cinta de opciones"
        End If
    End Sub

    Private Sub BTN_RELACION_ASEGURADORA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_RELACION_ASEGURADORA.Click
        FrmAseguradorasClientes.MdiParent = Me
        FrmAseguradorasClientes.Show()
    End Sub

    Private Sub BTN_COTIZACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_COTIZACION.Click
        FrmCotizacionExcel.MdiParent = Me
        FrmCotizacionExcel.Show()
    End Sub

    Private Sub BTN_MODIFICAR_PRECIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_MODIFICAR_PRECIOS.Click
        FrmModificarPrecioPromocion.MdiParent = Me
        FrmModificarPrecioPromocion.Show()
    End Sub

    Private Sub BTN_BAREMOS_AD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BAREMOS_AD.Click
        CrearBaremo()
    End Sub

    Private Sub BTN_REPORTES_AD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REPORTES_AD.Click
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub BTN_INGRESOS_MPPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_INGRESOS_MPPT.Click
        FrmCrearIngreso.MdiParent = Me
        FrmCrearIngreso.Show()
    End Sub

    Private Sub BTN_TASA_INGRESO_OP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TASA_INGRESO_OP.Click
        FrmCambiarTasaIngreso.MdiParent = Me
        FrmCambiarTasaIngreso.Show()
    End Sub

    Private Sub BTN_VISITA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_VISITA.Click
        FrmVisita.MdiParent = Me
        FrmVisita.Show()
    End Sub

    Private Sub BTN_CONSULTORIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CONSULTORIOS.Click
        FrmConsultorios.MdiParent = Me
        FrmConsultorios.Show()
    End Sub

    Private Sub BTN_TASAS_OP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_TASAS_OP.Click
        FrmActualizarTasas.MdiParent = Me
        FrmActualizarTasas.Show()
    End Sub

    Private Sub BTN_ACCESOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACCESOS.Click
        FrmCtrlAcceso.MdiParent = Me
        FrmCtrlAcceso.Show()
    End Sub

    Private Sub BTN_PARAMETROS_USUARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PARAMETROS_USUARIOS.Click
        FrmParametros_OtrosUsuarios.MdiParent = Me
        FrmParametros_OtrosUsuarios.Show()
    End Sub

    Private Sub BTN_PISTAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PISTAS.Click
        FrmPistas.MdiParent = Me
        FrmPistas.Show()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        FrmCompanias.MdiParent = Me
        FrmCompanias.Show()
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        FrmTiposAntecedentesMedicos.MdiParent = Me
        FrmTiposAntecedentesMedicos.Show()
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        FrmAntecedentesMedicos.MdiParent = Me
        FrmAntecedentesMedicos.Show()
    End Sub

    Private Sub MDI_PrincipalV2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        FrmClasificacionRiesgos.MdiParent = Me
        FrmClasificacionRiesgos.Show()
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        FrmRiesgosLaborales.MdiParent = Me
        FrmRiesgosLaborales.Show()
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        FrmEquiposLaborales.MdiParent = Me
        FrmEquiposLaborales.Show()
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        FrmEmpresas.MdiParent = Me
        FrmEmpresas.Show()

    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        FrmGrupoEmpresas.MdiParent = Me
        FrmGrupoEmpresas.Show()
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        FrmAsignarBaremos.MdiParent = Me
        FrmAsignarBaremos.Show()

    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        FrmMotivos.MdiParent = Me
        FrmMotivos.Show()
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        FrmEspecialidades.MdiParent = Me
        FrmEspecialidades.Show()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        FrmPaquetes.MdiParent = Me
        FrmPaquetes.Show()
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        FrmConceptos.MdiParent = Me
        FrmConceptos.Show()
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        FrmClasificacionConceptos.MdiParent = Me
        FrmClasificacionConceptos.Show()
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        FrmAgencias.MdiParent = Me
        FrmAgencias.Show()

    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        FrmDoctores.MdiParent = Me
        FrmDoctores.Show()
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PACIENTES.Click
        FrmPaciente.MdiParent = Me
        FrmPaciente.Show()
    End Sub

End Class