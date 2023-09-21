Imports System.Data.SqlClient

Public Class FrmFacturacionAltamira

    Sub AplicarFiltros()

        If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 1 Then
            Dim I As Integer, Monto As Decimal = 0
            For I = 0 To GRID.Rows.Count - 1
                GRID.Rows(I).Visible = True
                If TXT_FILTRO_EMPRESA.Text <> "Todos" Then
                    If GRID.Item(0, I).Value <> TXT_FILTRO_EMPRESA.Text Then
                        If TXT_BUSCAR.Text = "" Then
                            GRID.Rows(I).Visible = False
                        Else
                            If GRID.Item(0, I).Value Then
                            Else
                                GRID.Rows(I).Visible = False
                            End If
                        End If
                    End If
                End If
                If TXT_BUSCAR.Text <> "" Then
                    If UCase(GRID.Item(0, I).Value) + UCase(GRID.Item(1, I).Value) + UCase(GRID.Item(2, I).Value) Like "*" & UCase(TXT_BUSCAR.Text) & "*" Then
                    Else
                        GRID.Rows(I).Visible = False
                    End If
                End If
            Next

        Else
            If TXT_BUSCAR.Text = "" Then Exit Sub
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Try
                GRID.Rows.Clear()
                StrSQL = "SELECT NombreEmpresa,NroIngreso,NombrePaciente+' ('+RifPaciente+')' Paciente,FechaIngreso,monttotaserv FROM VQAPIntegral_Ingresos WHERE CodIntegralAseguradora='000001' AND facturado='N' AND FechaIngreso>='3/1/2023' AND monttotaserv>0 AND NroIngreso LIKE '%" & TXT_BUSCAR.Text & "%'"
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    GRID.Rows.Add(Trim(Arreglo("NombreEmpresa")), Trim(Arreglo("NroIngreso")), Trim(Arreglo("Paciente")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Format(Arreglo("monttotaserv"), "N2"))
                End While
                con.Close()
            Catch ex As Exception
                con.Close()
                ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarIngresosPorFacturar")
            End Try
        End If


    End Sub

    Sub CargarFiltros()
        TXT_FILTRO_EMPRESA.Items.Clear()
        TXT_FILTRO_EMPRESA.Items.Add("Todos")
        If PAR_CargarTodosLosRegistrosIngresosPorFacturar = 1 Then
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Try
                StrSQL = "SELECT nombre NombreEmpresa  FROM " & BDEmpresaIntegral & "empresa A INNER JOIN " & BDEmpresaIntegral & "ingreso B ON A.codigo=B.cod_empresa WHERE B.fecha>='1/1/2022' and b.cod_asegurad='000001' GROUP BY A.nombre "
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
        TXT_FILTRO_EMPRESA.Text = "Todos"
    End Sub

    Sub Cargar()
        Try
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT NombreEmpresa,NroIngreso,NombrePaciente+' ('+RifPaciente+')' Paciente,FechaIngreso,monttotaserv FROM VQAPIntegral_Ingresos WHERE CodIntegralAseguradora='000001' AND facturado='N' AND FechaIngreso>='3/1/2023' AND monttotaserv>0"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(Trim(Arreglo("NombreEmpresa")), Trim(Arreglo("NroIngreso")), Trim(Arreglo("Paciente")), CDate(Arreglo("FechaIngreso")).ToShortDateString, Format(Arreglo("monttotaserv"), "N2"))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.ToString, ex.Message, Me.Name, "Cargar")
        End Try


    End Sub

    Private Sub FrmFacturacionAltamira_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
        CargarFiltros()
    End Sub

    Private Sub TXT_BUSCAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSCAR.KeyPress
        If Asc(e.KeyChar) = 13 Then
            AplicarFiltros()
        End If
    End Sub


    Private Sub TXT_FILTRO_EMPRESA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILTRO_EMPRESA.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub GRID_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellContentClick

    End Sub

    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        If e.ColumnIndex = 5 Then
            If ValidarCorrelativo() <> 1 Then
                Exit Sub
            End If
            If InputNroCtrl() <> 1 Then
                NroControl = 0
                Exit Sub
            End If


            Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConValidacion.Open()
            Dim TablaIngresos As New DataTable
            Try
                TablaIngresos.Columns.Clear()
            Catch ex As Exception

            End Try
            TablaIngresos.Columns.Add("nro_ingreso", GetType(String))
            TablaIngresos.Columns.Add("pagador", GetType(String))

            TablaIngresos.Rows.Add(GRID.Item(1, e.RowIndex).Value, "000001")
           

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

            ComandoSql.Parameters.AddWithValue("@TIPO_CLIENTE", 1)


            ComandoSql.Parameters.AddWithValue("@DEDUCIBLE", 0)
            ComandoSql.Parameters.AddWithValue("@CO_CONDICIO", "30")
            ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
            ComandoSql.Parameters.AddWithValue("@DESCRIPCION", "")
            ComandoSql.Parameters.AddWithValue("@OBSERVACION", "")
            ComandoSql.Parameters.AddWithValue("@FORMATO", 2)



            If ConValidacion.State = ConnectionState.Closed Then
                ConValidacion.Open()
            End If

            Try

                ComandoSql.ExecuteNonQuery()
                If ParametroOutStatus.Value <> 1 Then
                    MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                    Exit Sub
                Else
                    If CoSucursal = "03" Then
                        Imprimirfactura("RptFormatoFacturaProfit.rpt", ParametroOutNumDoc.Value)
                    Else
                        ImprimirfacturaEmpresa("RptFormatoFacturaEmpresa.rpt", ParametroOutNumDoc.Value, 2, True)
                    End If
                End If
            Catch ex As Exception
                ManejoErrores(ex.Message, ex.ToString, Me.Name, "CreacionFacturas")
                Exit Sub
            End Try
            TablaIngresos.Rows.Clear()
            Cargar()
        End If
    End Sub

    Private Sub TXT_BUSCAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSCAR.TextChanged

    End Sub
End Class