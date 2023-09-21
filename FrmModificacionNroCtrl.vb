Imports System.Data.SqlClient

Public Class FrmModificacionNroCtrl

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            GRID.Rows.Clear()
            StrSQL = "DECLARE @TIPO_DOC VARCHAR(MAX)='" & TXT_TIPO_DOC.Text & "',@DOC_INI VARCHAR(11)='" & TXT_NRO_DOC_INI.Text & "',@DOC_FIN VARCHAR(11)='" & TXT_NRO_DOC_FIN.Text & "',@NRO_CTRL INT=" & TXT_NRO_CTRL.Text & "-1 " _
            & "IF LEN(@DOC_INI)  <= 9	SET @DOC_INI=REPLICATE('0',9-LEN(@DOC_INI))+@DOC_INI " _
            & "IF LEN(@DOC_FIN)  <= 9 SET @DOC_FIN=REPLICATE('0',9-LEN(@DOC_FIN))+@DOC_FIN " _
            & " SELECT X.fec_emis,X.cli_des,X.total_neto,X.nro_doc,X.n_control,'00-'+REPLICATE('0',8-LEN(NRO_CTRL))+TRIM(STR(NRO_CTRL)) NRO_CTRL FROM (" _
            & " SELECT A.fec_emis,B.cli_des,A.total_neto,A.nro_doc,A.n_control, ROW_NUMBER() OVER(PARTITION BY 1 ORDER BY A.NRO_DOC)+@NRO_CTRL AS NRO_CTRL " _
            & " FROM SADOCUMENTOVENTA A INNER JOIN SACLIENTE B ON A.CO_CLI=B.CO_CLI WHERE A.co_tipo_doc=@TIPO_DOC AND A.nro_doc BETWEEN @DOC_INI AND @DOC_FIN " _
            & " ) AS X ORDER BY X.nro_doc"

            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(CDate(Arreglo("fec_emis")).ToShortDateString, Trim(Arreglo("cli_des")), Format(Arreglo("total_neto"), "N2"), Trim(Arreglo("nro_doc")), Trim(Arreglo("n_control")), Trim(Arreglo("NRO_CTRL")))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarGrid")
        End Try
       

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception
        End Try
        TablaGrid.Columns.Add("nro_doc", GetType(String))
        TablaGrid.Columns.Add("n_control_old", GetType(String))
        TablaGrid.Columns.Add("n_control_new", GetType(String))
        For I = 0 To GRID.Rows.Count - 1
            TablaGrid.Rows.Add(GRID.Item(3, I).Value, GRID.Item(4, I).Value, GRID.Item(5, I).Value)
        Next

        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_ModificarNroCtrl", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.AddWithValue("@ListaDocumentos", TablaGrid)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@TIPO_DOC", TXT_TIPO_DOC.Text)

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                Exit Sub
            Else
                MsgBox("Numeros de Control actualizado con exito", MsgBoxStyle.Information, "Proceso Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "AplicarCambios")
            Exit Sub
        End Try


    End Sub
End Class