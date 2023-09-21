Imports System.Data.SqlClient

Public Class FrmIntegral_Facturar
    Dim DSCondicion As Data.DataSet
    Dim DSFormato As Data.DataSet

    Dim AdaptadorCondicio As System.Data.SqlClient.SqlDataAdapter
    Dim AdaptadorFormato As System.Data.SqlClient.SqlDataAdapter
    Dim cargando As Integer, filtrando As Integer = 0

    Sub CargarListas()

        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            ' Condicion de Pago
            StrSQL = "select co_cond,cond_des from saCondicionPago"
            Dim comandoCondicio As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoCondicio.CommandType = CommandType.Text
            AdaptadorCondicio = New System.Data.SqlClient.SqlDataAdapter(comandoCondicio)
            DSCondicion = New Data.DataSet("Condicio")
            AdaptadorCondicio.Fill(DSCondicion, "Condicio")
            TXT_CON.DataSource = DSCondicion.Tables("Condicio")
            TXT_CON.ValueMember = "co_cond"
            TXT_CON.DisplayMember = "cond_des"
            con.Close()

            ' Formato de Factura
            StrSQL = "select codigo,descripcion from tbQADP_FormatoFactura"
            Dim comandoFormato As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoFormato.CommandType = CommandType.Text
            AdaptadorFormato = New System.Data.SqlClient.SqlDataAdapter(comandoFormato)
            DSFormato = New Data.DataSet("Formato")
            AdaptadorFormato.Fill(DSFormato, "Formato")
            TXT_FOR.DataSource = DSFormato.Tables("Formato")
            TXT_FOR.ValueMember = "codigo"
            TXT_FOR.DisplayMember = "descripcion"
            con.Close()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarListas")
        End Try

    End Sub


    Sub CalcularFacturar()
        Dim I As Integer, Facturar As Decimal
        For I = 0 To GRID_INGRESOS.Rows.Count - 1
            If GRID_INGRESOS.Rows(I).Visible = True And GRID_INGRESOS.Item(11, I).Value = True Then
                Facturar = Facturar + GRID_INGRESOS.Item(10, I).Value
            End If
            TXT_TOTAL_FACTURAR.Text = Facturar
        Next
    End Sub

    Sub AplicarFiltros()
        Dim aseguradora As String = "", aseguradora_i As String = ""
        Dim Empresa As String = "", Empresa_i As String = ""
        filtrando = 1

        aseguradora = TXT_FILTRO_ASEGURADORA.Text
        Empresa = TXT_FILTRO_EMPRESA.Text

        'GRID_DEDUCIBLE.Sort(GRID_DEDUCIBLE.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        'GRID_INGRESOS.Sort(GRID_INGRESOS.Columns(0), System.ComponentModel.ListSortDirection.Ascending)


        If cargando = 1 Then Exit Sub

        If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 1 Then
            Dim I As Integer, Monto As Decimal = 0

            'For I = 0 To GRID_INGRESOS.Rows.Count - 1
            '    GRID_INGRESOS.Rows(I).Visible = True
            '    GRID_DEDUCIBLE.Rows(I).Visible = True
            'Next
            'Dim visible As Boolean
            CargarIngresosPorFacturar()
            For I = 0 To GRID_INGRESOS.Rows.Count - 1
                'GRID_INGRESOS.Rows(I).Visible = True
                'GRID_DEDUCIBLE.Rows(I).Visible = True

                'aseguradora_i = GRID_INGRESOS.Item(8, I).Value
                'Empresa_i = GRID_INGRESOS.Item(9, I).Value

                'visible = (aseguradora = aseguradora_i Or aseguradora = "Todos") And (Empresa = Empresa_i Or Empresa = "Todos")

                'GRID_INGRESOS.Rows(I).Visible = visible
                'GRID_DEDUCIBLE.Rows(I).Visible = visible


                Monto = Monto + (GRID_INGRESOS.Item(10, I).Value)
                'Facturar = Facturar + (GRID_INGRESOS.Item(11, I).Value * IIf(visible, 1, 0))


            Next
            TXT_TOTAL_MONTO.Text = Monto

        Else
            If TXT_BUSCAR.Text = "" Then Exit Sub
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Try
                GRID_INGRESOS.Rows.Clear()
                StrSQL = "SELECT NroIngreso,FechaIngreso,TipoIngreso,NombrePaciente,NombreAseguradora,NombreEmpresa,monttotaserv Monto,MotivoIngreso,SUBSTRING(Clave,1,20) Clave,rif,CodIntegralAseguradora,CodIntegralEmpresa,codpaciente,tasacambio FROM VQAPIntegral_Ingresos WHERE facturado='N' AND monttotaserv>0 AND NroIngreso LIKE '%" & TXT_BUSCAR.Text & "%' AND EstatusIngreso = 'Cerrado'"
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    GRID_INGRESOS.Rows.Add(Trim(Arreglo("NroIngreso")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Arreglo("TipoIngreso"), Arreglo("MotivoIngreso"), Arreglo("Clave"), Trim(Arreglo("NombrePaciente")), Trim(Arreglo("RIF")), "", Trim(Arreglo("NombreAseguradora")), Trim(Arreglo("NombreEmpresa")), Format(Arreglo("monto"), "N2"), False, Trim(Arreglo("CodIntegralAseguradora")), Trim(Arreglo("CodIntegralEmpresa")), Trim(Arreglo("codpaciente")), "", Trim(Arreglo("tasacambio")))
                    GRID_DEDUCIBLE.Rows.Add(Trim(Arreglo("NroIngreso")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Arreglo("TipoIngreso"), Arreglo("MotivoIngreso"), Arreglo("Clave"), Trim(Arreglo("NombrePaciente")), Trim(Arreglo("RIF")), "", Trim(Arreglo("NombreAseguradora")), Trim(Arreglo("NombreEmpresa")), Format(Arreglo("monto"), "N2"), False, Trim(Arreglo("CodIntegralAseguradora")), Trim(Arreglo("CodIntegralEmpresa")), Trim(Arreglo("codpaciente")), Trim(Arreglo("tasacambio")))
                    TXT_TOTAL_MONTO.Text = Arreglo("Monto")
                End While
                con.Close()
            Catch ex As Exception
                con.Close()
                ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarIngresosPorFacturar")
            End Try
        End If


    End Sub

    Sub CargarFiltros()
        TXT_FILTRO_ASEGURADORA.Items.Clear()
        TXT_FILTRO_ASEGURADORA.Items.Add("Todos")
        TXT_FILTRO_EMPRESA.Items.Clear()
        TXT_FILTRO_EMPRESA.Items.Add("Todos")


        If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 1 Then
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Try
                StrSQL = "SELECT DISTINCT NombreAseguradora FROM VQAPIntegral_Ingresos WHERE facturado='N' AND FECHAINGRESO >='1/1/2022' and NombreAseguradora<>''"
                StrSQL = "SELECT nombre NombreAseguradora  FROM " & BDEmpresaIntegral & "aseguradora A INNER JOIN " & BDEmpresaIntegral & "ingreso B ON A.codigo=B.cod_asegurad WHERE B.fecha>='1/1/2022' GROUP BY A.nombre "
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    TXT_FILTRO_ASEGURADORA.Items.Add(Trim(Arreglo("NombreAseguradora")))
                End While
                con.Close()
            Catch ex As Exception
                con.Close()
                ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarFiltrosAseguradoras")
            End Try
            Try
                StrSQL = "SELECT nombre NombreEmpresa  FROM " & BDEmpresaIntegral & "empresa A INNER JOIN " & BDEmpresaIntegral & "ingreso B ON A.codigo=B.cod_empresa WHERE B.fecha>='1/1/2022' GROUP BY A.nombre "

                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    TXT_FILTRO_EMPRESA.Items.Add(Trim(Arreglo("NombreEmpresa")))
                End While
                con.Close()
            Catch ex As Exception
                con.Close()
                ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarFiltrosEmpresas")
            End Try
        End If




        TXT_FILTRO_ASEGURADORA.Text = "Todos"
        TXT_FILTRO_EMPRESA.Text = "Todos"
    End Sub

    Sub CargarIngresosPorFacturar()
        VariableSecuenciaAtencionClienteParticular = 0
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            GRID_INGRESOS.Rows.Clear()
            If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 1 Then
                Dim filtro_aseguradora As String, filtro_empresa As String, filtro_ingreso As String
                filtro_aseguradora = IIf(TXT_FILTRO_ASEGURADORA.Text = "Todos", "", "AND NombreAseguradora LIKE '%" & TXT_FILTRO_ASEGURADORA.Text & "%' ")
                filtro_empresa = IIf(TXT_FILTRO_EMPRESA.Text = "Todos", "", "AND NombreEmpresa LIKE '%" & TXT_FILTRO_EMPRESA.Text & "%' ")
                filtro_ingreso = IIf(TXT_BUSCAR.Text = "", "", "AND (NroIngreso LIKE '%" & TXT_BUSCAR.Text & "%' OR NombrePaciente LIKE '%" & TXT_BUSCAR.Text & "%' OR rif LIKE '%" & TXT_BUSCAR.Text & "%' OR Clave LIKE '%" & TXT_BUSCAR.Text & "%')")

                StrSQL = "SELECT NroIngreso,FechaIngreso,TipoIngreso,NombrePaciente,NombreAseguradora,NombreEmpresa,monttotaserv Monto,MotivoIngreso,SUBSTRING(Clave,1,20) Clave,rif,CodIntegralAseguradora,CodIntegralEmpresa,codpaciente,tasacambio FROM VQAPIntegral_Ingresos WHERE facturado='N' AND monttotaserv>0 AND FECHAINGRESO >='10/26/2022' AND EstatusIngreso = 'Cerrado' AND facturable = 'S' " & filtro_aseguradora & filtro_empresa & filtro_ingreso & " order by 1"
            Else
                StrSQL = "SELECT '' NroIngreso,'1/1/1900' FechaIngreso,'' TipoIngreso,'' NombrePaciente,'' NombreAseguradora,'' NombreEmpresa,0 Monto,'' MotivoIngreso,'' Clave,'' rif,'' CodIntegralAseguradora,'' CodIntegralEmpresa,'' codpaciente FROM SAMONEDA WHERE 1=2"
            End If

            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            'Dim i As Integer = 0
            While Arreglo.Read
                GRID_INGRESOS.Rows.Add(Trim(Arreglo("NroIngreso")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Arreglo("TipoIngreso"), Arreglo("MotivoIngreso"), Arreglo("Clave"), Trim(Arreglo("NombrePaciente")), Trim(Arreglo("RIF")), "", Trim(Arreglo("NombreAseguradora")), Trim(Arreglo("NombreEmpresa")), Format(Arreglo("monto"), "N2"), False, Trim(Arreglo("CodIntegralAseguradora")), Trim(Arreglo("CodIntegralEmpresa")), Trim(Arreglo("codpaciente")), "", Trim(Arreglo("tasacambio")))
                GRID_DEDUCIBLE.Rows.Add(Trim(Arreglo("NroIngreso")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Arreglo("TipoIngreso"), Arreglo("MotivoIngreso"), Arreglo("Clave"), Trim(Arreglo("NombrePaciente")), Trim(Arreglo("RIF")), "", Trim(Arreglo("NombreAseguradora")), Trim(Arreglo("NombreEmpresa")), Format(Arreglo("monto"), "N2"), False, Trim(Arreglo("CodIntegralAseguradora")), Trim(Arreglo("CodIntegralEmpresa")), Trim(Arreglo("codpaciente")), Trim(Arreglo("tasacambio")))
                'Dim i As Integer = GRID_INGRESOS.Rows.Count - 1
                'GRID_INGRESOS.Rows(i).Visible = GRID_INGRESOS.Item(11, i).Value
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarIngresosPorFacturar")
        End Try
        cargando = 1

        If filtrando = 0 Then
            CargarFiltros()
            CargarListas()
        End If
        cargando = 0
    End Sub


    Sub Guardar(ByVal Deducible As Integer)
        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()

        Dim FormatoSeleccionado As String = TXT_FOR.SelectedValue
        Dim TipoCliente As Integer = IIf(TXT_NOMBRE_FACTURA.Text = "Aseguradora", 1, IIf(TXT_NOMBRE_FACTURA.Text = "Empresa", 2, 3))


        Dim TipoGrupo As String = TXT_GRUPO_FACTURA.Text, Grupo As String = "", ProximoGrupo As String = "", EmpresaPrint As Boolean = CH_MOSTRAR_EMPRESA.Checked, NombeFactura As String = TXT_NOMBRE_FACTURA.Text, CondPago As String = TXT_CON.SelectedValue
        Dim VarDeducible As String, MontoDeducible As Decimal = 0
        If Deducible = 0 Then
            Select Case TXT_GRUPO_FACTURA.Text
                Case Is = "Aseguradora"
                    GRID_INGRESOS.Sort(GRID_INGRESOS.Columns(12), System.ComponentModel.ListSortDirection.Ascending)
                Case Is = "Empresa"
                    GRID_INGRESOS.Sort(GRID_INGRESOS.Columns(13), System.ComponentModel.ListSortDirection.Ascending)
                Case Is = "Paciente"
                    GRID_INGRESOS.Sort(GRID_INGRESOS.Columns(15), System.ComponentModel.ListSortDirection.Ascending)
                Case Else
                    MsgBox("Disculpe, no indico como se va a agrupar/organizar las facturas. Por favor selecione una opcion de la lista: Facturar Agrupado por:")
                    Exit Sub
            End Select
        Else
            VarDeducible = InputBox("Por favor indique el monto del deducible", "Deducible")
            If Len(VarDeducible) = 0 Then Exit Sub
            MontoDeducible = Decimal.ToDouble(VarDeducible)
        End If

        Dim TablaGrid As New DataTable, TablaIngresos As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception

        End Try
        Try
            TablaIngresos.Columns.Clear()
        Catch ex As Exception

        End Try
        TablaGrid.Columns.Add("nro_ingreso", GetType(String))
        TablaGrid.Columns.Add("pagador", GetType(String))
        TablaGrid.Columns.Add("grupo", GetType(String))

        TablaIngresos.Columns.Add("nro_ingreso", GetType(String))
        TablaIngresos.Columns.Add("pagador", GetType(String))
        Dim I As Integer

        If Deducible = 0 Then
            For I = 0 To GRID_INGRESOS.Rows.Count - 1
                If GRID_INGRESOS.Item(11, I).Value = True And GRID_INGRESOS.Rows(I).Visible = True Then
                    Grupo = IIf(TipoGrupo = "Aseguradora", GRID_INGRESOS.Item(12, I).Value, IIf(TipoGrupo = "Empresa", GRID_INGRESOS.Item(13, I).Value, GRID_INGRESOS.Item(15, I).Value))
                    TablaGrid.Rows.Add(GRID_INGRESOS.Item(0, I).Value, Grupo, Grupo)
                End If
            Next
        Else
            For I = 0 To GRID_DEDUCIBLE.Rows.Count - 1
                If GRID_DEDUCIBLE.Rows(I).Selected = True Then
                    TablaGrid.Rows.Add(GRID_DEDUCIBLE.Item(0, I).Value, GRID_DEDUCIBLE.Item(14, I).Value, GRID_DEDUCIBLE.Item(14, I).Value)
                    Exit For
                End If
            Next
        End If

        Dim Descripcion As String = "", Observacion As String = ""
        If Deducible = 0 Then
            Descripcion = TXT_DESCRIPCION.Text
            Observacion = TXT_OBSERVACION.Text
        End If
        For I = 0 To TablaGrid.Rows.Count - 1
            TablaIngresos.Rows.Add(TablaGrid.Rows(I).Item(0).ToString, TablaGrid.Rows(I).Item(1).ToString)
            Try
                ProximoGrupo = ""
                ProximoGrupo = TablaGrid.Rows(I + 1).Item(2).ToString
            Catch ex As Exception
            End Try
            If ProximoGrupo <> TablaGrid.Rows(I).Item(2).ToString Then

                If ValidarCorrelativo() <> 1 Then
                    CargarIngresosPorFacturar()
                    CalcularFacturar()
                    Exit Sub
                End If

                
                If InputNroCtrl() <> 1 Then
                    NroControl = 0
                    CargarIngresosPorFacturar()
                    CalcularFacturar()
                    Exit Sub
                End If

                Dim ComandoSql As System.Data.SqlClient.SqlCommand
                'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
                Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
                Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

                ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_FacturarIngresos", ConValidacion)
                ComandoSql.CommandType = CommandType.StoredProcedure
                ComandoSql.CommandTimeout = 0
                ComandoSql.Parameters.Add(ParametroOutStatus)
                ComandoSql.Parameters.Add(ParametroOutResultado)
                ComandoSql.Parameters.Add(ParametroOutNumDoc)
                ComandoSql.Parameters.AddWithValue("@ListaDocumentos", TablaIngresos)
                ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
                If Deducible = 0 Then
                    'ComandoSql.Parameters.AddWithValue("@TIPO_CLIENTE", IIf(TXT_NOMBRE_FACTURA.Text = "Aseguradora", 1, IIf(TXT_NOMBRE_FACTURA.Text = "Empresa", 2, 3)))
                    ComandoSql.Parameters.AddWithValue("@TIPO_CLIENTE", TipoCliente)
                Else
                    ComandoSql.Parameters.AddWithValue("@TIPO_CLIENTE", 3)
                End If

                ComandoSql.Parameters.AddWithValue("@DEDUCIBLE", MontoDeducible)
                ComandoSql.Parameters.AddWithValue("@CO_CONDICIO", CondPago)
                ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
                ComandoSql.Parameters.AddWithValue("@DESCRIPCION", Descripcion)
                ComandoSql.Parameters.AddWithValue("@OBSERVACION", Observacion)
                ComandoSql.Parameters.AddWithValue("@FORMATO", FormatoSeleccionado)
                ComandoSql.Parameters.AddWithValue("@NUM_CONTROL", NroControl)


                If ConValidacion.State = ConnectionState.Closed Then
                    ConValidacion.Open()
                End If

                Try
                    ComandoSql.ExecuteNonQuery()
                    If ParametroOutStatus.Value <> 1 Then
                        MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                        Exit Sub
                    Else

                        If PAR_MostrarPatallaImpresionFactura = 1 Then
                            'If VerificarExistenciaFacturaMediSoftware(ParametroOutNumDoc.Value) = 1 Then
                            If NombeFactura = "Paciente" Or Deducible = 1 Then
                                SecuenciaAtencionClienteParticular(ParametroOutNumDoc.Value)
                            Else
                                Dim f As Integer
                                Select Case FormatoSeleccionado
                                    Case "PA"
                                        f = 3
                                    Case "LD"
                                        f = 1
                                    Case "LR"
                                        f = 2

                                End Select
                                ImprimirfacturaEmpresa("RptFormatoFacturaEmpresa.rpt", ParametroOutNumDoc.Value, f, EmpresaPrint)
                                Try
                                    Dim ProximaFactura As String
                                    ProximaFactura = TablaGrid.Rows(I + 1).Item(2).ToString
                                    If MsgBox("¿Se imprimió correctamente la Factura Nro: " & ParametroOutNumDoc.Value.ToString & " ?", MsgBoxStyle.YesNo, "Confirmación de Impresión") = MsgBoxResult.No Then
                                        If MsgBox("¿Desea visualizar la venta de anulación de documentos?", MsgBoxStyle.YesNo, "Confirmación de Impresión") = MsgBoxResult.Yes Then
                                            FrmAnularDocumentos.ShowDialog()
                                        End If
                                        If MsgBox("¿Abortar la generación de factura(s) restante(s)?", MsgBoxStyle.YesNo, "Confirmación de Impresión") = MsgBoxResult.Yes Then
                                            CargarIngresosPorFacturar()
                                            Exit Sub
                                        End If

                                    End If
                                Catch ex As Exception

                                End Try
                            End If
                            'CargarIngresosPorFacturar()
                            'Exit Sub
                            'Else
                            'Imprimirfactura("RptFormatoFacturaProfit.rpt", ParametroOutNumDoc.Value)
                            'End If
                            'Else
                            MsgBox("Factura generada con exito", MsgBoxStyle.Information, "Factura Nro: " & ParametroOutNumDoc.Value)
                        End If
                    End If
                Catch ex As Exception
                    ManejoErrores(ex.Message, ex.ToString, Me.Name, "CreacionFacturas")
                    Exit Sub
                End Try
                TablaIngresos.Rows.Clear()
            End If
        Next



        CargarIngresosPorFacturar()


    End Sub

    Private Sub FrmIntegral_Facturar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarIngresosPorFacturar()
        GRID_INGRESOS.Columns(16).DisplayIndex = 11
        'For I = 0 To GRID_INGRESOS.Rows.Count - 1
        '    GRID_INGRESOS.Rows(I).Visible = False
        '    GRID_DEDUCIBLE.Rows(I).Visible = False
        'Next
    End Sub

    Private Sub GRID_INGRESOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellContentClick
        Try
            If e.ColumnIndex = 0 Then
                With FrmIntegral_Ingreso
                    .CargarIngreso(GRID_INGRESOS(0, e.RowIndex).Value)
                    If GRID_INGRESOS.Item(7, e.RowIndex).Value = "" Then
                        .TXT_PAGADOR.Text = GRID_INGRESOS.Item(6, e.RowIndex).Value
                        .TXT_PAGADOR.BackColor = Color.LemonChiffon
                    Else
                        .TXT_PAGADOR.Text = GRID_INGRESOS.Item(7, e.RowIndex).Value
                        .TXT_PAGADOR.BackColor = Color.AliceBlue
                    End If
                    .ShowDialog()
                End With
            End If
            If e.ColumnIndex = 7 Then
                FrmPagador.GRID.Rows.Clear()
                FrmPagador.TXT_FILA_GRID_INGRESO.Text = e.RowIndex
                FrmPagador.TXT_BUSCAR.Text = ""
                FrmPagador.TXT_PANTALLA.Text = Me.Name
                FrmPagador.ShowDialog()

            End If
            If e.ColumnIndex = 4 Then
                Dim Clave As String = InputBox("Usted procederá a cambiar la clave del ingreso. Si no desea cambiarla, solo haga clic en cancelar o deje el campo vacío", "Nueva Clave", GRID_INGRESOS.Item(4, e.RowIndex).Value)
                If Clave = GRID_INGRESOS.Item(4, e.RowIndex).Value Or Clave = "" Then
                Else

                    Dim ConExecute As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    ConExecute.Open()

                    Dim ComandoSql As System.Data.SqlClient.SqlCommand
                    'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
                    Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

                    ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_CambiarClaveIngreso", ConExecute)
                    ComandoSql.CommandType = CommandType.StoredProcedure
                    ComandoSql.Parameters.Add(ParametroOutStatus)
                    ComandoSql.Parameters.Add(ParametroOutResultado)

                    ComandoSql.Parameters.AddWithValue("@NRO_INGRESO", GRID_INGRESOS.Item(0, e.RowIndex).Value)
                    ComandoSql.Parameters.AddWithValue("@CLAVE", Clave)
                    ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)

                    If ConExecute.State = ConnectionState.Closed Then
                        ConExecute.Open()
                    End If
                    Try
                        ComandoSql.ExecuteNonQuery()
                        If ParametroOutStatus.Value <> 1 Then
                            MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                            Exit Sub
                        End If
                        MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information)
                        GRID_INGRESOS.Item(4, e.RowIndex).Value = Clave
                    Catch ex As Exception
                        ManejoErrores(ex.Message, ex.ToString, Me.Name, "CambiodeClave")
                        Exit Sub
                    End Try
                End If
            End If

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CambiodeClave")
        End Try

       
    End Sub

    Private Sub TXT_FILTRO_ASEGURADORA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILTRO_ASEGURADORA.SelectedIndexChanged
        'AplicarFiltros()
        'Se deshabilita para optimizar la busqueda con el boton de aplicar filtros
        
    End Sub

    Private Sub TXT_FILTRO_EMPRESA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILTRO_EMPRESA.SelectedIndexChanged
        'AplicarFiltros()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOTON_SELALL.Click
        Dim I As Integer
        For I = 0 To GRID_INGRESOS.Rows.Count - 1
            If BOTON_SELALL.Text = "Select All" Then
                GRID_INGRESOS.Item(11, I).Value = False
                If GRID_INGRESOS.Rows(I).Visible = True Then
                    GRID_INGRESOS.Item(11, I).Value = True
                End If
            Else
                GRID_INGRESOS.Item(11, I).Value = True
                If GRID_INGRESOS.Rows(I).Visible = True Then
                    GRID_INGRESOS.Item(11, I).Value = False
                End If
            End If
        Next
        If BOTON_SELALL.Text = "Select All" Then
            BOTON_SELALL.Text = "UnSelect All"
        Else
            BOTON_SELALL.Text = "Select All"
        End If
        CalcularFacturar()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim I As Integer
        For I = 0 To GRID_INGRESOS.Rows.Count - 1
            GRID_INGRESOS.Item(15, I).Value = GRID_INGRESOS.Item(IIf(GRID_INGRESOS.Item(7, I).Value = "", 14, 7), I).Value

        Next
        Guardar(0)


    End Sub

    Private Sub GRID_INGRESOS_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellEndEdit
        If e.ColumnIndex = 11 Then
            CalcularFacturar()
        End If
    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Guardar(1)
    End Sub

    Private Sub GRID_INGRESOS_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellEnter
        Try
            GRID_INGRESOS.Rows(e.RowIndex).Selected = True
            Try
                Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                StrSQL = "DECLARE @NRO_INGRESO VARCHAR(MAX)='" & GRID_INGRESOS.Item(0, e.RowIndex).Value & "'" _
                & " SELECT TOP 1 co_cond FROM saCondicionPago WHERE dias_cred IN (SELECT CASE WHEN codtipopacie='Asegurado' THEN ISNULL(B.diascredfact,0) ELSE 0 END FROM " & BDEmpresaIntegral & "ingreso A LEFT JOIN " & BDEmpresaIntegral & "aseguradora B ON A.cod_asegurad=B.codigo WHERE A.codigo=@NRO_INGRESO)"
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    TXT_CON.SelectedValue = Arreglo("co_cond")
                End While
                con.Close()

                'Formato factura
                StrSQL = "DECLARE @NRO_INGRESO VARCHAR(MAX)='" & GRID_INGRESOS.Item(0, e.RowIndex).Value & "'" _
                & "SELECT ISNULL(b.codmodfactur,'PA') Formato, ISNULL(b.mostemprfact,'N') EmpresaPrint FROM " & BDEmpresaIntegral & "ingreso A LEFT JOIN " & BDEmpresaIntegral & "aseguradora B ON A.cod_asegurad=B.codigo WHERE A.codigo=@NRO_INGRESO"
                con.Open()
                cmd.CommandText = StrSQL
                Dim ArregloFormato As SqlDataReader = cmd.ExecuteReader

                While ArregloFormato.Read
                    TXT_FOR.SelectedValue = ArregloFormato("Formato")
                    CH_MOSTRAR_EMPRESA.Checked = False
                    If ArregloFormato("EmpresaPrint") = "S" Then
                        CH_MOSTRAR_EMPRESA.Checked = True
                    End If
                End While
                con.Close()
                'end

                If GRID_INGRESOS.Item(2, e.RowIndex).Value = "Asegurado" Then
                    TXT_NOMBRE_FACTURA.Text = "Aseguradora"
                    TXT_GRUPO_FACTURA.Text = "Aseguradora"
                Else
                    TXT_NOMBRE_FACTURA.Text = "Paciente"
                    TXT_GRUPO_FACTURA.Text = "Paciente"
                End If
                    
            Catch ex As Exception

            End Try

        Catch ex As Exception
        End Try

    End Sub

    Private Sub TXT_BUSCAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSCAR.KeyPress
        If Asc(e.KeyChar) = 13 Then
            AplicarFiltros()
            'Dim monto As Decimal = 0, facturar As Decimal = 0
            'If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 0 Then
            '    AplicarFiltros()
            '    Exit Sub
            'End If
            'For I = 0 To GRID_DEDUCIBLE.Rows.Count - 1
            '    If TXT_BUSCAR.Text = "" Then
            '        GRID_INGRESOS.Rows(I).Visible = True
            '        GRID_DEDUCIBLE.Rows(I).Visible = True
            '        Continue For
            '    End If

            '    'If TXT_BUSCAR.Text <> "" Then
            '    'If UCase(GRID_INGRESOS.Item(0, I).Value) + UCase(GRID_INGRESOS.Item(3, I).Value) + UCase(GRID_INGRESOS.Item(4, I).Value) + UCase(GRID_INGRESOS.Item(5, I).Value) + UCase(GRID_INGRESOS.Item(6, I).Value) Like "*" & UCase(TXT_BUSCAR.Text) & "*" Then
            '    'Else
            '    GRID_INGRESOS.Rows(I).Visible = UCase(GRID_INGRESOS.Item(0, I).Value) + UCase(GRID_INGRESOS.Item(3, I).Value) + UCase(GRID_INGRESOS.Item(4, I).Value) + UCase(GRID_INGRESOS.Item(5, I).Value) + UCase(GRID_INGRESOS.Item(6, I).Value) Like "*" & UCase(TXT_BUSCAR.Text) & "*"
            '    GRID_DEDUCIBLE.Rows(I).Visible = UCase(GRID_DEDUCIBLE.Item(0, I).Value) + UCase(GRID_DEDUCIBLE.Item(3, I).Value) + UCase(GRID_DEDUCIBLE.Item(4, I).Value) + UCase(GRID_DEDUCIBLE.Item(5, I).Value) + UCase(GRID_DEDUCIBLE.Item(6, I).Value) Like "*" & UCase(TXT_BUSCAR.Text) & "*"

            '    'End If

            '    'If UCase(GRID_DEDUCIBLE.Item(0, I).Value) + UCase(GRID_DEDUCIBLE.Item(3, I).Value) + UCase(GRID_DEDUCIBLE.Item(4, I).Value) + UCase(GRID_DEDUCIBLE.Item(5, I).Value) + UCase(GRID_DEDUCIBLE.Item(6, I).Value) Like "*" & UCase(TXT_BUSCAR.Text) & "*" Then
            '    'Else
            '    '    GRID_DEDUCIBLE.Rows(I).Visible = False
            '    'End If
            '    ''End If

            '    If GRID_INGRESOS.Rows(I).Visible = True Then
            '        monto = monto + GRID_INGRESOS.Item(10, I).Value
            '        If GRID_INGRESOS.Item(10, I).Value = True Then
            '            facturar = facturar + GRID_INGRESOS.Item(11, I).Value
            '        End If
            '    End If
            'Next
            'TXT_TOTAL_MONTO.Text = monto
        End If

    End Sub

    Private Sub TXT_BUSCAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSCAR.TextChanged

    End Sub

    Private Sub GRID_DEDUCIBLE_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_DEDUCIBLE.CellContentClick

    End Sub

    Private Sub GRID_DEDUCIBLE_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_DEDUCIBLE.CellDoubleClick

        Try
            If e.ColumnIndex = 0 Then
                With FrmIntegral_Ingreso
                    .CargarIngreso(GRID_DEDUCIBLE(0, e.RowIndex).Value)
                    If GRID_DEDUCIBLE.Item(7, e.RowIndex).Value = "" Then
                        .TXT_PAGADOR.Text = GRID_DEDUCIBLE.Item(6, e.RowIndex).Value
                        .TXT_PAGADOR.BackColor = Color.LemonChiffon
                    Else
                        .TXT_PAGADOR.Text = GRID_INGRESOS.Item(7, e.RowIndex).Value
                        .TXT_PAGADOR.BackColor = Color.AliceBlue
                    End If
                    .ShowDialog()
                End With
            End If
            If e.ColumnIndex = 7 Then
                FrmPagador.GRID.Rows.Clear()
                FrmPagador.TXT_FILA_GRID_INGRESO.Text = e.RowIndex
                FrmPagador.TXT_BUSCAR.Text = ""
                FrmPagador.TXT_PANTALLA.Text = Me.Name & "_Deducible"
                FrmPagador.ShowDialog()

            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        AplicarFiltros()
    End Sub

   
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class