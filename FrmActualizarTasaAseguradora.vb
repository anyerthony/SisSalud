Imports System.Data.SqlClient

Public Class FrmActualizarTasaAseguradora

    Sub Cargar()

        GRID_ASEGURADORAS.Rows.Clear()
        StrSQL = "EXEC usp_CargarAseguradoras " + Replace(BDEmpresaIntegral, "..", "")
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_ASEGURADORAS.Rows.Add(Arreglo("codigo"), Arreglo("rif"), Arreglo("nombre"), Arreglo("tasa"))
        End While
    End Sub

    Private Sub FrmActualizarTasaAseguradora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Private Sub TXT_ASEGURADORA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ASEGURADORA.TextChanged
        'If TXT_ASEGURADORA.Text <> "" Then
        For i = 0 To GRID_ASEGURADORAS.Rows.Count() - 1
            GRID_ASEGURADORAS.Rows(i).Visible = UCase(GRID_ASEGURADORAS.Item(2, i).Value) Like "*" & UCase(TXT_ASEGURADORA.Text) & "*"
        Next
        'End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        TXT_ASEGURADORA.Text = ""
        Cargar()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim TablaAseguradoras As New DataTable
        Try
            TablaAseguradoras.Columns.Clear()
        Catch ex As Exception

        End Try
        TablaAseguradoras.Columns.Add("codigo", GetType(String))
        TablaAseguradoras.Columns.Add("tasa", GetType(Double))



        For i = 0 To GRID_ASEGURADORAS.Rows.Count - 1
            If GRID_ASEGURADORAS.Item(3, i).Value = 0 Then Continue For
            TablaAseguradoras.Rows.Add(GRID_ASEGURADORAS.Item(0, i).Value, GRID_ASEGURADORAS.Item(3, i).Value)
        Next

        If TablaAseguradoras.Rows.Count = 0 Then Exit Sub


        'Exit Sub
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("usp_CambiarTasaAseguradora", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@LISTA_ASEGURADORAS", TablaAseguradoras)
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
            Limpiar()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Asignar tasa a aseguradora")
        End Try



    End Sub

    Sub Limpiar()
        TXT_ASEGURADORA.Text = ""
        'For i = 0 To GRID_ASEGURADORAS.Rows.Count - 1
        '    GRID_ASEGURADORAS.Item(3, i).Value = 0
        'Next
        Cargar()
    End Sub
End Class