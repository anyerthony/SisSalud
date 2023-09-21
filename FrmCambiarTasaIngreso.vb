Imports System.Data.SqlClient

Public Class FrmCambiarTasaIngreso

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Limpiar()
        Dim NroIngreso As String = InputBox("Indique el Nro de ingreso", "Buscar ingreso")
        If Len(NroIngreso) < 5 Then Exit Sub
        Buscar(NroIngreso)
        If Len(TXT_NRO_INGRESO.Text) > 0 Then GRID_INGRESOS.Rows.Add(TXT_NRO_INGRESO.Text)
    End Sub
    Sub Buscar(ByRef nro_ingreso As String)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        StrSQL = "EXEC spQADP_buscarIngresoCambioTasa '" & nro_ingreso & "'"
        Dim cmd As SqlCommand = con.CreateCommand()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            TXT_EMPRESA.Text = Trim(Arreglo("empresa"))
            TXT_FECHA.Text = Arreglo("fecha")
            TXT_MONEDA.Text = Arreglo("moneda")
            TXT_MONTO.Text = Arreglo("monttotaserv")
            TXT_NRO_INGRESO.Text = nro_ingreso.ToString
            TXT_PACIENTE.Text = Trim(Arreglo("paciente"))
            TXT_TASA.Text = IIf(Len(Arreglo("tasa")), "Tasa de cambio actual: " & Arreglo("tasa"), "")
        End While
        con.Close()
        If Len(TXT_NRO_INGRESO.Text) = 0 Then
            MsgBox("Disculpe, no se encontró el ingreso indicado." & vbCrLf & vbCrLf & "Por favor verifique que el ingreso esté creado en una moneda distinta a la local y no se encuentre facturado.", MsgBoxStyle.Critical, "Ingreso no encontrado")
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If GRID_INGRESOS.Rows.Count = 0 Then Exit Sub
        Dim tasa As String = InputBox("Indique la tasa de cambio para los ingresos seleccionados.", "Asignar tasa")
        If Len(tasa) = 0 Then Exit Sub

        tasa = Replace(tasa, ",", ".")
        'Dim tasa As Double
        'If Not Double.TryParse(Replace(tasa_str, ".", ","), tasa) Then
        '    MsgBox("Disculpe, el valor '" & tasa_str & "' no es una tasa de cambio válida.", MsgBoxStyle.Critical, "Tasa invalida")
        'End If
        Dim TablaIngresos As New DataTable
        Try
            TablaIngresos.Columns.Clear()
        Catch ex As Exception

        End Try
        TablaIngresos.Columns.Add("nro_ingreso", GetType(String))


        For i = 0 To GRID_INGRESOS.Rows.Count - 1
            TablaIngresos.Rows.Add(GRID_INGRESOS.Item(0, i).Value)
        Next


        'Exit Sub
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("usp_CambiarTasaIngreso", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@LISTA_INGRESOS", TablaIngresos)
        ComandoSql.Parameters.AddWithValue("@TASA", tasa)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@COMPANIA", BDEmpresa)



        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()

            Dim status As Integer = ParametroOutStatus.Value
            MsgBox(ParametroOutResultado.Value, IIf(status, MsgBoxStyle.Information, MsgBoxStyle.Critical), IIf(status, "Procesado", "Proceso no compleado"))

            'If ParametroOutStatus.Value = 1 Then
            '    MsgBox("Procesado", MsgBoxStyle.Information, "Procesado")
            'Else
            '    MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            'End If
            If ParametroOutStatus.Value = 1 Then
                GRID_INGRESOS.Rows.Clear()
            End If

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Asignar tasa a ingreso")
        End Try

        Limpiar()



    End Sub
    Sub Limpiar()
        TXT_EMPRESA.Text = ""
        TXT_FECHA.Text = ""
        TXT_MONEDA.Text = ""
        TXT_MONTO.Text = ""
        TXT_NRO_INGRESO.Text = ""
        TXT_PACIENTE.Text = ""
        TXT_TASA.Text = ""
    End Sub

    Private Sub FrmCambiarTasaIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        GRID_INGRESOS.Rows.Clear()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If TXT_NRO_INGRESO.Text = "" Then Exit Sub
        GRID_INGRESOS.Rows.Add(TXT_NRO_INGRESO.Text)
        Limpiar()
    End Sub

    Private Sub GRID_INGRESOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellContentClick

    End Sub

    Private Sub GRID_INGRESOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellDoubleClick
        Buscar(GRID_INGRESOS.Item(0, e.RowIndex).Value)
    End Sub

    Private Sub GRID_INGRESOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_INGRESOS.KeyDown
        If e.KeyCode = Keys.Delete Then
            GRID_INGRESOS.Rows.Remove(GRID_INGRESOS.CurrentRow)
        End If
    End Sub

    Private Sub GRID_INGRESOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GRID_INGRESOS.KeyPress

       
    End Sub
End Class