Imports System.Drawing.Printing
Imports System.Data.SqlClient


Public Class FrmConfiguracion
    Dim CARGA As Integer

    Dim AdaptadorSucursales As System.Data.SqlClient.SqlDataAdapter
    Dim AdaptadorClientes As System.Data.SqlClient.SqlDataAdapter
    Dim AdaptadorEmpresa As System.Data.SqlClient.SqlDataAdapter


    Dim DSSucur As Data.DataSet
    Dim DSCli As Data.DataSet
    Dim DSEmp As Data.DataSet


    Sub CargarListaReportes()
        txt_reportes.Items.Clear()
        StrSQL = "SELECT A.nombre FROM QAPD_CONTROL..MANPERFILES A INNER JOIN QAPD_CONTROL..MANPERFILES_USUARIOS B ON A.id_perfil=B.id_perfil WHERE B.usuario='" & Cod_Usuario & "' AND A.nombre LIKE 'REP%' AND A.status=1 AND B.status=1"
        Dim con2 As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd2 As SqlCommand = con2.CreateCommand()
        con2.Open()
        cmd2.CommandText = StrSQL
        Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
        While Arreglo2.Read
            txt_reportes.Items.Add(Trim(Arreglo2("NOMBRE")))
        End While
    End Sub
  
    Sub ResetearFiltros()
        txt_des1.Text = "" : txt_des2.Text = "" : txt_des3.Text = "" : txt_des4.Text = "" : txt_des5.Text = ""
        txt_des6.Text = "" : txt_des7.Text = "" : txt_des8.Text = "" : txt_des9.Text = "" : txt_des10.Text = ""
        txt_des11.Text = "" : txt_des12.Text = "" : TXT_EMPREA.Text = ""

        txt_var1_3.Text = "" : txt_var2_3.Text = ""

        txt_fecha_ini.Enabled = False : txt_fecha_fin.Enabled = False : TXT_STATUS.Enabled = False
        txt_var1_3.Enabled = False : txt_var2_3.Enabled = False
        txt_var1_4.Enabled = False : txt_var2_4.Enabled = False
        txt_var1_5.Enabled = False : txt_var2_5.Enabled = False
        txt_var1_6.Enabled = False : txt_var2_6.Enabled = False
        txt_var1_7.Enabled = False : txt_var2_7.Enabled = False
        txt_var1_8.Enabled = False : txt_var2_8.Enabled = False
        txt_var1_9.Enabled = False : txt_var2_9.Enabled = False
        txt_var1_10.Enabled = False : txt_var2_10.Enabled = False
        txt_var1_11.Enabled = False : txt_var2_11.Enabled = False
        txt_var1_12.Enabled = False : txt_var2_12.Enabled = False
        TXT_SUCURSAL.Enabled = False
        TXT_CLIENTES.Enabled = False
        TXT_EMPREA.Enabled = False
        TXT_EMPRESAS.Enabled = False

        TXT_STATUS.Items.Clear()

        TXT_CLIENTES.DataSource = Nothing
        TXT_CLIENTES.Items.Clear()

        TXT_SUCURSAL.DataSource = Nothing
        TXT_SUCURSAL.Items.Clear()

        TXT_CLIENTES.DataSource = Nothing
        TXT_CLIENTES.Items.Clear()

        TXT_EMPRESAS.DataSource = Nothing
        TXT_EMPRESAS.Items.Clear()


        TXT_EMPREA.Top = 133
        TXT_EMPRESAS.Top = 133


        txt_des5.Top = 112
        TXT_CLIENTES.Top = 112

        txt_des3.Top = 91
        txt_var1_3.Top = 91
        txt_var2_3.Top = 91

        TXT_SUCURSAL.Top = 154





        txt_des4.Top = 155
        TXT_SUCURSAL.Top = 155
        txt_var1_4.Top = 155


        txt_des2.Top = 177
        TXT_STATUS.Top = 177
        txt_var2_4.Top = 177

        txt_des7.Top = 199
        txt_var1_7.Top = 199
        txt_var2_7.Top = 199
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Cr1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim Cr2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        FrmReportes.CONTROL.ShowPrintButton = True

        Dim reporteSelect As String = txt_reportes.Text
        'If UCase(reporteSelect) = "REP_RELACIONFACTURAINGRESOSLISTA" Then reporteSelect = "REP_RELACIONFACTURAINGRESOS"
        'If UCase(reporteSelect) = UCase("RepComprobanteResumido") Then reporteSelect = "RepComprobantePaciente"

        Select Case UCase(reporteSelect)
            Case Is = "REP_INGRESOSINCONSISTENTES"
                Dim NombreReporte As String = "REP_INGRESOS_INCONSISTENTES.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    Cr1.SetParameterValue("@FEC_INI", CDate(txt_fecha_ini.Text).ToShortDateString)
                    Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, Replace(BDEmpresaIntegral, "..", ""), UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try

            Case Is = "Intereses sobre Prestaciones Sociales del Nuevo Régimen"
                Dim NombreReporte As String = "RptPrestacionesIntereses.rpt"
                Try
                    Cr1.FileName = NombreReporte
                    Dim FORMULA As String = "{VSAPrestacionesIntereses.cod_emp}='" & txt_var1_3.Text & "'"
                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    If txt_var1_3.Text <> "" Then
                        FrmReportes.CONTROL.SelectionFormula = FORMULA
                    End If
                    FrmReportes.CONTROL.ReportSource = Cr1

                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try

            Case Is = "REP_RELACIONFACTURAINGRESOSLISTA"
                Dim NombreReporte As String = "REP_RELACIONFACTURAINGRESOSLISTA.rpt"
                'If UCase(txt_reportes.Text) = "REP_RELACIONFACTURAINGRESOSLISTA" Then NombreReporte = "REP_RelacionFacturaIngresosLista.rpt"

                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    Cr1.SetParameterValue("@dCo_fecha_d", CDate(txt_fecha_ini.Text).ToShortDateString)
                    Cr1.SetParameterValue("@dCo_fecha_h", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.SetParameterValue("@cCo_Numero_d", IIf(Len(txt_var1_3.Text), txt_var1_3.Text, Nothing))
                    Cr1.SetParameterValue("@cCo_Numero_h", IIf(Len(txt_var2_3.Text), txt_var2_3.Text, Nothing))
                    Cr1.SetParameterValue("@cCo_Numeroi_d", IIf(Len(txt_var1_7.Text), txt_var1_7.Text, Nothing))
                    Cr1.SetParameterValue("@cCo_Numeroi_h", IIf(Len(txt_var2_7.Text), txt_var2_7.Text, Nothing))

                    Cr1.SetParameterValue("@cCo_cliente_d", IIf(Len(TXT_CLIENTES.SelectedValue), TXT_CLIENTES.SelectedValue, Nothing))
                    Cr1.SetParameterValue("@cCo_cliente_h", IIf(Len(TXT_EMPRESAS.SelectedValue), TXT_EMPRESAS.SelectedValue, Nothing))
                    'Cr1.SetParameterValue("@dCo_fecha_h", IIf(Len(txt_var1_3.Text), txt_var1_3, Nothing))
                    Cr1.SetParameterValue("@cAnulado", TXT_STATUS.SelectedItem)
                    Cr1.SetParameterValue("@cCo_Sucursal", TXT_SUCURSAL.SelectedValue)


                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try
            Case Is = UCase("REP_ComprobantePaciente")
                Dim NombreReporte As String = "REP_ComprobantePaciente.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    Cr1.SetParameterValue("@NRO_DOC", txt_var1_3.Text)
                    'Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try
            Case Is = UCase("REP_ComprobanteResumido")
                Dim NombreReporte As String = "REP_ComprobanteResumido.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    Cr1.SetParameterValue("@NRO_DOC", txt_var1_3.Text)
                    'Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try

            Case Is = UCase("REP_Morbilidad")
                Dim NombreReporte As String = "RepMorbilidad.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    'Cr1.SetParameterValue("@NRO_DOC", txt_var1_3.Text)
                    Cr1.SetParameterValue("@FEC_INI", CDate(txt_fecha_ini.Text).ToShortDateString)
                    Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.SetParameterValue("@EMPRESA", IIf(Len(TXT_EMPRESAS.SelectedValue), TXT_EMPRESAS.SelectedValue, ""))
                    Cr1.SetParameterValue("@DEPENDENCIA", IIf(Len(TXT_CLIENTES.SelectedValue), TXT_CLIENTES.SelectedValue, ""))
                    Cr1.SetParameterValue("@DES_EMP", IIf(Len(TXT_EMPRESAS.SelectedValue), TXT_EMPRESAS.Text, ""))
                    Cr1.SetParameterValue("@DES_DEP", IIf(Len(TXT_CLIENTES.SelectedValue), TXT_CLIENTES.Text, ""))
                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try
            Case Is = UCase("RepArqueoCaja")
                Dim NombreReporte As String = "RepArqueoCaja.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    'Cr1.SetParameterValue("@NRO_DOC", txt_var1_3.Text)
                    Cr1.SetParameterValue("@FEC_INI", CDate(txt_fecha_ini.Text).ToShortDateString)
                    Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    Cr1.SetParameterValue("@CAJA_BSS", TXT_SUCURSAL.SelectedValue)

                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try
            Case Is = UCase("RepFacturacionTarjetas")
                Dim NombreReporte As String = "RepFacturacionTarjetas.rpt"
                Try
                    Cr1.FileName = ParRutaReporte + NombreReporte
                    'Cr1.SetParameterValue("@NRO_DOC", txt_var1_3.Text)
                    Cr1.SetParameterValue("@FEC_INI", CDate(txt_fecha_ini.Text).ToShortDateString)
                    Cr1.SetParameterValue("@FEC_FIN", CDate(txt_fecha_fin.Text).ToShortDateString)
                    'Cr1.SetParameterValue("@CAJA_BSS", TXT_SUCURSAL.SelectedValue)

                    Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
                    FrmReportes.CONTROL.ReportSource = Cr1
                    FrmReportes.Text = txt_reportes.Text
                    FrmReportes.ShowDialog()
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, "Reportes", txt_reportes.Text)
                End Try

        End Select





    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TXT_STATUS.Text = "Todos" : txt_fecha_ini.Text = CDate(My.Computer.Clock.LocalTime).ToShortDateString
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_fecha_fin.Text = CDate(My.Computer.Clock.LocalTime).ToShortDateString
    End Sub


    Private Sub txt_reportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_reportes.SelectedIndexChanged
        ResetearFiltros()
        CARGA = 1
        Dim reporteSelect As String = txt_reportes.Text
        If UCase(reporteSelect) = "REP_RELACIONFACTURAINGRESOSLISTA" Then reporteSelect = "REP_RELACIONFACTURAINGRESOS"

        Select Case UCase(reporteSelect)
            Case Is = "REP_INGRESOSINCONSISTENTES"
                txt_fecha_fin.Enabled = True
                txt_fecha_ini.Enabled = True
                txt_des1.Text = "Fecha de Ingreso:"
            Case Is = "REP_RELACIONFACTURAINGRESOS"
                txt_fecha_fin.Enabled = True
                txt_fecha_ini.Enabled = True
                txt_des1.Text = "Fecha de Factura:"

                TXT_STATUS.Enabled = True
                txt_des2.Enabled = True


                TXT_STATUS.Items.Add("Todo")
                TXT_STATUS.Items.Add("Cerrado")
                TXT_STATUS.Items.Add("Abierto")

                

                TXT_STATUS.SelectedItem = TXT_STATUS.Items(0)


                txt_des3.Text = "Numero Factura:"
                txt_var1_3.Enabled = True
                txt_var2_3.Enabled = True

                txt_des2.Text = "Status:"
                TXT_SUCURSAL.Enabled = True

                txt_des4.Text = "Sucursal:"


                txt_var1_5.Enabled = True
                TXT_CLIENTES.Enabled = True
                txt_des5.Text = "Aseguradora:"

                TXT_EMPREA.Text = "Empresa:"
                TXT_EMPREA.Enabled = True
                TXT_EMPRESAS.Enabled = True

                cargarEmpresas()
                cargarClientes()
                cargarSucursales()


                txt_des7.Text = "Número Ingreso:"
                txt_des7.Enabled = True
                txt_var1_7.Enabled = True
                txt_var2_7.Enabled = True

                txt_des5.Top = 133
                TXT_CLIENTES.Top = 133

                TXT_EMPREA.Top = 155
                TXT_EMPRESAS.Top = 155

                txt_des4.Top = 177
                TXT_SUCURSAL.Top = 177
                txt_var1_4.Top = 177


                txt_des2.Top = 199
                TXT_STATUS.Top = 199
                txt_var2_4.Top = 199

                txt_des7.Top = 112
                txt_var1_7.Top = 112
                txt_var2_7.Top = 112

                

            Case Is = UCase("Rep_ComprobantePaciente")
                txt_des3.Text = "Numero Factura:"
                txt_var1_3.Enabled = True
            Case Is = UCase("Rep_ComprobanteResumido")
                txt_des3.Text = "Numero Factura:"
                txt_var1_3.Enabled = True
            Case Is = UCase("REP_Morbilidad")
                txt_des1.Text = "Fecha: "
                txt_fecha_ini.Enabled = True
                txt_fecha_fin.Enabled = True

                TXT_EMPREA.Enabled = True
                TXT_EMPRESAS.Enabled = True

                TXT_EMPREA.Text = "Empresa: "

                cargarEmpresas()
                cargarDependencias("")


                txt_des5.Enabled = True
                TXT_CLIENTES.Enabled = True
                txt_des5.Text = "Dependencia: "


                txt_des5.Top = 112
                TXT_CLIENTES.Top = 112
                TXT_EMPREA.Top = 91
                TXT_EMPRESAS.Top = 91

                txt_des3.Top = 133
                txt_var1_3.Top = 133
                txt_var2_3.Top = 133

            Case Is = UCase("RepArqueoCaja")
                txt_des1.Text = "Fecha: "
                txt_fecha_ini.Enabled = True
                txt_fecha_fin.Enabled = True

                txt_des3.Text = "Caja BSS: "
                txt_des3.Enabled = True

                'txt_var1_3.Enabled = True
                TXT_SUCURSAL.Enabled = True
                TXT_SUCURSAL.Top = 91

                txt_var1_3.Top = 154
                cargarCajas()

            Case Is = UCase("RepFacturacionTarjetas")
                txt_fecha_fin.Enabled = True
                txt_fecha_ini.Enabled = True
                txt_des1.Text = "Fecha de Factura:"


        End Select
        CARGA = 0
    End Sub
    Sub cargarEmpresas()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            StrSQL = "select '' codigo, '' nombre union select codigo,trim(nombre) nombre from  " _
            & BDEmpresaIntegral & "empresa" ' a left join " & BDEmpresaIntegral & "aseguradoraempresa b on a.codigo = b.cod_empresa " _
            '& "where b.cod_asegurad = '" & TXT_CLIENTES.SelectedValue.ToString & "' order by 2"
            Dim comandoEmpresa As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoEmpresa.CommandType = CommandType.Text
            AdaptadorEmpresa = New System.Data.SqlClient.SqlDataAdapter(comandoEmpresa)
            DSEmp = New Data.DataSet("Empresa")
            AdaptadorEmpresa.Fill(DSEmp, "Empresa")
            TXT_EMPRESAS.DataSource = DSEmp.Tables("Empresa")
            TXT_EMPRESAS.ValueMember = "codigo"
            TXT_EMPRESAS.DisplayMember = "nombre"
            con.Close()
            TXT_EMPRESAS.SelectedItem = TXT_EMPRESAS.Items(0)


        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Cargar Empresas")
        End Try
    End Sub

    Sub cargarDependencias(ByVal empresa As String)
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()

            Dim comandoFormato As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            'StrSQL = "select '' co_cli, '' cli_des union select codigo co_cli,trim(nombre) cli_des from " & BDEmpresaIntegral & "aseguradora order by 2"
            StrSQL = "select '' co_cli, '' cli_des union select codigo co_cli,trim(nombre) cli_des from  " _
            & BDEmpresaIntegral & "dependencia where cod_empresa LIKE '%" & empresa & "%'"

            Dim comandoClientes As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            AdaptadorClientes = New System.Data.SqlClient.SqlDataAdapter(comandoClientes)
            DSCli = New Data.DataSet("Clientes")
            AdaptadorClientes.Fill(DSCli, "Clientes")
            TXT_CLIENTES.DataSource = DSCli.Tables("Clientes")
            TXT_CLIENTES.ValueMember = "co_cli"
            TXT_CLIENTES.DisplayMember = "cli_des"
            con.Close()
            TXT_CLIENTES.SelectedItem = TXT_CLIENTES.Items(0)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Cargar Empresas")
        End Try
    End Sub

    Sub cargarClientes()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)

            'StrSQL = "select 'TODO' co_sucur, 'Todas' sucur_des union select co_sucur,sucur_des from saSucursal "
            Dim comandoFormato As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            'AdaptadorSucursales = New System.Data.SqlClient.SqlDataAdapter(comandoFormato)
            'DSSucur = New Data.DataSet("Sucursal")
            'AdaptadorSucursales.Fill(DSSucur, "Sucursal")
            'TXT_SUCURSAL.DataSource = DSSucur.Tables("Sucursal")
            'TXT_SUCURSAL.ValueMember = "co_sucur"
            'TXT_SUCURSAL.DisplayMember = "sucur_des"
            'con.Close()
            'TXT_SUCURSAL.SelectedItem = TXT_SUCURSAL.Items(3)


            con.Open()
            StrSQL = "select '' co_cli, '' cli_des union select codigo co_cli,trim(nombre) cli_des from " & BDEmpresaIntegral & "aseguradora order by 2"
            Dim comandoClientes As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            AdaptadorClientes = New System.Data.SqlClient.SqlDataAdapter(comandoClientes)
            DSCli = New Data.DataSet("Clientes")
            AdaptadorClientes.Fill(DSCli, "Clientes")
            TXT_CLIENTES.DataSource = DSCli.Tables("Clientes")
            TXT_CLIENTES.ValueMember = "co_cli"
            TXT_CLIENTES.DisplayMember = "cli_des"
            con.Close()
            TXT_CLIENTES.SelectedItem = TXT_CLIENTES.Items(0)


        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Cargar Clientes")
        End Try
    End Sub

    Sub cargarSucursales()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()

            StrSQL = "select 'TODO' co_sucur, 'Todas' sucur_des union select co_sucur,sucur_des from saSucursal "
            Dim comandoFormato As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            AdaptadorSucursales = New System.Data.SqlClient.SqlDataAdapter(comandoFormato)
            DSSucur = New Data.DataSet("Sucursal")
            AdaptadorSucursales.Fill(DSSucur, "Sucursal")
            TXT_SUCURSAL.DataSource = DSSucur.Tables("Sucursal")
            TXT_SUCURSAL.ValueMember = "co_sucur"
            TXT_SUCURSAL.DisplayMember = "sucur_des"
            con.Close()
            TXT_SUCURSAL.SelectedItem = TXT_SUCURSAL.Items(TXT_SUCURSAL.Items.Count - 1)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Cargar Sucursales")
        End Try
    End Sub

  
    Private Sub FrmConfiguracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListaReportes()
        ResetearFiltros()
    End Sub

    Private Sub txt_var1_3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_var1_3.KeyDown
        If e.KeyValue = 13 And txt_var2_3.Text = "" Then
            txt_var2_3.Text = txt_var1_3.Text
        End If
    End Sub

    

    Private Sub TXT_EMPRESAS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_EMPRESAS.SelectedIndexChanged
        If CARGA = 1 Then Exit Sub
        If UCase(txt_reportes.Text) = "REP_MORBILIDAD" Then
            Try
                cargarDependencias(TXT_EMPRESAS.SelectedValue.ToString)
            Catch ex As Exception

            End Try

        End If
    End Sub



    Private Sub TXT_CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CLIENTES.SelectedIndexChanged
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)

        'con.Open()
        'StrSQL = "select '' codigo, '' nombre union select codigo,trim(nombre) nombre from  " _
        '& BDEmpresaIntegral & "empresa a left join " & BDEmpresaIntegral & "aseguradoraempresa b on a.codigo = b.cod_empresa " _
        '& "where b.cod_asegurad = '" & TXT_CLIENTES.SelectedValue.ToString & "' order by 2"
        'Dim comandoEmpresa As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        'comandoEmpresa.CommandType = CommandType.Text
        'AdaptadorEmpresa = New System.Data.SqlClient.SqlDataAdapter(comandoEmpresa)
        'DSEmp = New Data.DataSet("Empresa")
        'AdaptadorEmpresa.Fill(DSCli, "Empresa")
        'TXT_EMPRESAS.DataSource = DSCli.Tables("Empresa")
        'TXT_EMPRESAS.ValueMember = "codigo"
        'TXT_EMPRESAS.DisplayMember = "nombre"
        'con.Close()
        'TXT_EMPRESAS.SelectedItem = TXT_EMPRESAS.Items(0)
    End Sub
    Sub cargarCajas()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()

            StrSQL = "select cod_caja, '('+trim(cod_caja)+') '+ trim(descrip) descrip from saCaja where cod_caja in (select valor collate Modern_Spanish_CI_AS from QAPD_CONTROL..MANPARAMETROS_SISTEMAS_USUARIOS where id_parametro = 12) order by 1"
            Dim comandoFormato As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            AdaptadorSucursales = New System.Data.SqlClient.SqlDataAdapter(comandoFormato)
            DSSucur = New Data.DataSet("caja")
            AdaptadorSucursales.Fill(DSSucur, "caja")
            TXT_SUCURSAL.DataSource = DSSucur.Tables("caja")
            TXT_SUCURSAL.ValueMember = "cod_caja"
            TXT_SUCURSAL.DisplayMember = "descrip"
            con.Close()
            TXT_SUCURSAL.SelectedItem = TXT_SUCURSAL.Items(0)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Cargar Cajas")
        End Try
    End Sub
End Class