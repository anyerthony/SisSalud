Imports System.Data.SqlClient

Public Class FrmAnularDocumentos

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBuscarDocumentos.TXT_TIPO.Text = TXT_TIPO_DOC.Text
        FrmBuscarDocumentos.TXT_PANTALLA.Text = Me.Name
        FrmBuscarDocumentos.GRID.Rows.Clear()
        FrmBuscarDocumentos.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_AnularDocumentos", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        ComandoSql.Parameters.AddWithValue("@NRO_DOC", TXT_NRO_DOC.Text)
        ComandoSql.Parameters.AddWithValue("@TIPO_DOC", TXT_TIPO_DOC.Text)
        ComandoSql.Parameters.AddWithValue("@OBSERVACION", TXT_OBSERVACION.Text)
        ComandoSql.Parameters.AddWithValue("@TIPO_ANULACION", IIf(OPCION3.Checked = True, 3, IIf(OPCION2.Checked = True, 2, 1)))


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
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "AnularDocumento")
        End Try
    End Sub
End Class