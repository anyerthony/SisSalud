Imports System.Data.SqlClient

Public Class FrmActualizarCorrelativos

    Private Sub FrmActualizarCorrelativos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TXT_SUCURSAL.Text = "(" + CoSucursal + ") " + MDIPrincipal.ToolValorSucursal.Text
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If MsgBox("Usted procedera a cambiar los numeros consecutivos para la sucursal " & vbCrLf & MDIPrincipal.ToolValorSucursal.Text & vbCrLf & ". Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("spQAPCambiarCorrelativosFacturas", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        ComandoSql.Parameters.AddWithValue("@NRO_FACT", TXT_NRO.Text)
        ComandoSql.Parameters.AddWithValue("@NRO_CONTROL", TXT_CONTROL.Text)

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
End Class