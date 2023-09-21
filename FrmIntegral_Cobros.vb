Imports System.Data.SqlClient

Public Class FrmIntegral_Cobros
    Sub Limpiar()
        With Me
            .TXT_CLI_NOM.Text = ""
            .TXT_FACT_NC.Text = ""
            .TXT_FACT_NUM.Text = ""
            .TXT_FACT_SALDO_BS.Text = 0
            .TXT_FACT_SALDO_D.Text = 0
            .TXT_FACT_TASA.Text = 0
            .TXT_FAL_BS.Text = 0
            .TXT_FAL_D.Text = 0
            .TXT_FOR_BS.Text = 0
            .TXT_FOR_D.Text = 0
            .TXT_IGTF.Text = 0
            .GRID.Rows.Clear()
        End With
    End Sub

    Sub CalcularMontos()
        Dim FormaBs As Decimal = 0, FormaD As Decimal = 0, IGTF As Decimal = 0
        TXT_FOR_BS.Text = FormaBs
        TXT_FOR_D.Text = FormaD
        TXT_IGTF.Text = 0
        For I = 0 To GRID.Rows.Count - 2
            If GRID.Item(0, I).Value = "TransferenciaD" Or GRID.Item(0, I).Value = "EfectivoD" Then
                FormaD = FormaD + GRID.Item(2, I).Value
                FormaBs = FormaBs + (GRID.Item(2, I).Value * TXT_FACT_TASA.Text)
                IGTF = IGTF + (GRID.Item(2, I).Value * 3 / 100)
            Else
                FormaD = FormaD + (GRID.Item(2, I).Value / TXT_FACT_TASA.Text)
                FormaBs = FormaBs + GRID.Item(2, I).Value
            End If
        Next
        TXT_IGTF.Text = IGTF
        TXT_FOR_BS.Text = FormaBs
        TXT_FOR_D.Text = FormaD
        Dim TotalDeuda As Decimal, TotalAbono As Decimal
        TotalDeuda = TXT_FACT_SALDO_BS.Text + (IGTF * TXT_FACT_TASA.Text)
        TotalAbono = TXT_FOR_BS.Text
        TXT_FAL_BS.Text = TotalDeuda - TotalAbono
        TotalDeuda = TXT_FACT_SALDO_D.Text + IGTF
        TotalAbono = TXT_FOR_D.Text
        TXT_FAL_D.Text = TotalDeuda - TotalAbono

    End Sub

    Sub CargarDatosFacturas(ByVal Fact_Num As String)
        TXT_FACT_NUM.Text = "" : TXT_FACT_NC.Text = ""
        TXT_FACT_SALDO_BS.Text = ""
        TXT_FACT_FEC.Text = "" : TXT_FACT_TASA.Text = ""
        TXT_CLI_NOM.Text = ""
        GRID.Rows.Clear()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            ' Condicion de Pago
            'StrSQL = "SELECT A.codigo,A.numcontrol,A.monto,A.montodeuda,A.fecha,A.TasaCambioBareFact,B.cedula,TRIM(B.nombre)+ ' '+TRIM(B.apellido) paciente FROM " & BDEmpresaIntegral & "factura A INNER JOIN " & BDEmpresaIntegral & "paciente B ON A.cod_paciente=B.historia where a.codigo='" & Fact_Num & "' and montodeuda>0 and a.codstatus='PorCobrar' "
            StrSQL = "SELECT A.NRO_DOC codigo,A.N_CONTROL numcontrol,A.total_neto monto,A.SALDO montodeuda,A.FEC_EMIS fecha,A.tasa,B.RIF cedula,B.CLI_DES paciente,DBO.TasaAUnaFecha(C.i_moneda_articulo,1,GETDATE()) TasaCambioBareFact  FROM sadocumentoventa A INNER JOIN sacliente B ON A.CO_CLI=B.CO_CLI INNER JOIN par_emp C ON 1=1 where CO_TIPO_DOC='FACT' and SALDO>0 AND anulado=0 and a.NRO_DOC='" & Fact_Num & "'"
            Dim cmd As SqlCommand = con.CreateCommand()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                TXT_FACT_NUM.Text = Arreglo("codigo") : TXT_FACT_NC.Text = Arreglo("numcontrol")
                TXT_FACT_SALDO_BS.Text = Arreglo("montodeuda")
                TXT_FACT_FEC.Text = Arreglo("fecha") : TXT_FACT_TASA.Text = Arreglo("TasaCambioBareFact")
                TXT_CLI_NOM.Text = " (" & Trim(Arreglo("cedula")) & ") " & Trim(Arreglo("paciente"))
                TXT_FACT_SALDO_D.Text = Arreglo("montodeuda") / Arreglo("TasaCambioBareFact")
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarFactura")
        End Try




    End Sub

    Sub CargarListasColumnas()
        ColumnaBanco.Items.Clear()
        ColumnaForma.Items.Clear()
      
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            ' Condicion de Pago
            StrSQL = "SELECT nombre FROM " & BDEmpresaIntegral & "maestro WHERE codgrupo='009'"
            StrSQL = "select TRIM(B.cod_cta)+' / '+REPLACE(A.des_ban,CASE WHEN A.des_ban LIKE 'BANCO%' THEN 'BANCO' ELSE '' END,'')+' ('+B.num_cta+')' nombre from saBanco A INNER JOIN saCuentaBancaria B ON B.co_ban=A.co_ban WHERE B.co_mone IN (SELECT g_moneda FROM par_emp) --AND B.CAMPO6='SI'"
            Dim cmd As SqlCommand = con.CreateCommand()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                ColumnaBanco.Items.Add(Arreglo("nombre"))
            End While
            con.Close()
            con.Open()
            ColumnaBanco.DropDownWidth = 250

            ' Condicion de Pago
            StrSQL = "SELECT DISTINCT codformapago FROM " & BDEmpresaIntegral & "pagosfactura order by codformapago"

            Dim cmd2 As SqlCommand = con.CreateCommand()

            cmd2.CommandText = StrSQL
            Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
            While Arreglo2.Read
                ColumnaForma.Items.Add(Arreglo2("codformapago"))
            End While
            con.Close()


        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarListas")
        End Try

    End Sub

    Private Sub FrmIntegral_Cobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListasColumnas()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim Nro As String = InputBox("Por favor, indique el Nro de Factura a Cobrar", "Nro Factura")
        If Len(Nro) < 3 Then Exit Sub
        Limpiar()
        If UCase(Mid(Nro, 1, 2)) = "A-" Or UCase(Mid(Nro, 1, 2)) = "B-" Then
            Nro = Mid(Nro, 1, 2) + Replicate("0", 7 - (Len(Nro) - 2)) + Mid(Nro, 3, 100)
        End If
        CargarDatosFacturas(Nro)
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()


        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception

        End Try
       
        TablaGrid.Columns.Add("codformapago", GetType(String))
        TablaGrid.Columns.Add("fecha", GetType(Date))
        TablaGrid.Columns.Add("monto", GetType(Decimal))
        TablaGrid.Columns.Add("numrecurpago", GetType(String))
        TablaGrid.Columns.Add("bancorecupag", GetType(String))
        TablaGrid.Columns.Add("observa", GetType(String))
        Dim I As Integer

        ActualizarFechaServidor()
        For I = 0 To GRID.Rows.Count - 2
            TablaGrid.Rows.Add(GRID.Item(0, I).Value, CDate(IIf(Len(GRID.Item(1, I).Value) > 5, GRID.Item(1, I).Value, FechaServidor)).ToShortDateString, GRID.Item(2, I).Value, GRID.Item(3, I).Value, GRID.Item(4, I).Value, GRID.Item(5, I).Value)
        Next
       


        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_Cobros", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.AddWithValue("@Lista", TablaGrid)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@FACT_NUM", TXT_FACT_NUM.Text)

        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso no Completado")
                Exit Sub
            Else
                If ParametroOutNumDoc.Value <> "" Then
                    If VariableSecuenciaAtencionClienteParticular = 1 Then
                        ImprimirIGTF(ParametroOutNumDoc.Value)
                        Me.Hide()
                    Else
                        MsgBox("Cobro generado con exito", MsgBoxStyle.Information, "SisSalud")
                        Limpiar()
                    End If
                Else
                    MsgBox("Cobro generado con exito", MsgBoxStyle.Information, "SisSalud")
                    Limpiar()
                End If
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CreacionFacturas")
            Exit Sub
        End Try
    End Sub
    Private Sub GRID_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellEndEdit
        If e.ColumnIndex = 2 Then
            CalcularMontos()
        End If
    End Sub
End Class