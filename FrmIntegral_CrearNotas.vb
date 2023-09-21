Imports System.Data.SqlClient

Public Class FrmIntegral_CrearNotas

    Sub CalcularMonto()
        Try
            Dim I As Integer = 0, Monto As Decimal = 0
            For I = 0 To GRID_DETALLE.Rows.Count - 2
                Monto = Monto + (ReturnValorDecimal(GRID_DETALLE.Item(1, I).Value) * ReturnValorDecimal(GRID_DETALLE.Item(2, I).Value))
            Next
            TXT_TOTAL.Text = Monto
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBuscarDocumentos.TXT_TIPO.Text = TXT_TIPO_DOC.Text
        FrmBuscarDocumentos.TXT_PANTALLA.Text = Me.Name
        FrmBuscarDocumentos.GRID.Rows.Clear()
        FrmBuscarDocumentos.ShowDialog()
    End Sub

    Private Sub GRID_DETALLE_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_DETALLE.CellContentClick

    End Sub

    Private Sub GRID_DETALLE_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_DETALLE.CellEndEdit
        Try
            If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
                CalcularMonto()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_CrearNotas", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception
        End Try
        
        TablaGrid.Columns.Add("descripcion", GetType(String))
        TablaGrid.Columns.Add("cantidad", GetType(Decimal))
        TablaGrid.Columns.Add("precio", GetType(Decimal))


        Dim I As Integer
        For I = 0 To GRID_DETALLE.Rows.Count - 2
            TablaGrid.Rows.Add(GRID_DETALLE.Item(0, I).Value, GRID_DETALLE.Item(1, I).Value, GRID_DETALLE.Item(2, I).Value)
        Next



        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        ComandoSql.Parameters.AddWithValue("@NRO_FACT", TXT_NRO_DOC.Text)
        ComandoSql.Parameters.AddWithValue("@TIPO_DOC_ORIGEN", TXT_TIPO_DOC.Text)
        ComandoSql.Parameters.AddWithValue("@OBSERVACION", TXT_OBSERVACION.Text)
        ComandoSql.Parameters.AddWithValue("@TIPO_DOC_CREA", TXT_TIPO.Text)
        ComandoSql.Parameters.AddWithValue("@CO_CLI", IIf(TXT_CO_CLI.Text = "", Nothing, TXT_CO_CLI.Text))
        ComandoSql.Parameters.AddWithValue("@ListaDetalle", TablaGrid)

      
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso Completado")

            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        TXT_CLI_DES.Text = ""
        TXT_CO_CLI.Text = ""
        TXT_CLI_DOC.Text = ""
        TXT_MONTO_DOC.Text = 0
        TXT_NRO_DOC.Text = ""
        TXT_OBSERVACION.Text = ""
        TXT_TIPO.Text = ""
        TXT_TIPO_DOC.Text = ""
        TXT_TOTAL.Text = ""
        GRID_DETALLE.Rows.Clear()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        With FrmBuscarClientes
            .TXT_BUSCAR.Text = ""
            .TXT_PANTALLA.Text = Me.Name
            .GRID.Rows.Clear()
            .ShowDialog()
        End With
    End Sub
End Class