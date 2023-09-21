Imports System.Data.SqlClient

Public Class FrmIntegral_MigrarDocumentos
    Sub CargarNoExportadas()
        Try
            GRID_NO_EXPORTADAS.Rows.Clear()
            StrSQL = "SELECT codigo,TIPO_DOC,RazonSocial,rif,fecha,monto FROM (SELECT A.codigo,A.TIPO_DOC,A.RazonSocial,A.rif,A.fecha,A.monto,B.nro_doc NULO FROM VQAPIntegral_Documentos A LEFT JOIN saDocumentoVenta B ON A.codigo COLLATE SQL_Latin1_General_CP1_CI_AS=B.nro_doc AND A.tipo_doc=B.co_tipo_doc ) AS X WHERE NULO IS NULL"
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            cmd.CommandTimeout = 0
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID_NO_EXPORTADAS.Rows.Add(Trim(Arreglo("codigo")), Trim(Arreglo("TIPO_DOC")), Trim(Arreglo("RazonSocial")), Trim(Arreglo("rif")), CDate(Arreglo("fecha")).ToShortDateString, Format(Arreglo("monto"), "N2"))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarNoExportadas")
        End Try

    End Sub

    Private Sub FrmIntegral_MigrarDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarNoExportadas()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim I As Integer
        For I = 0 To GRID_NO_EXPORTADAS.Rows.Count - 1
            GRID_NO_EXPORTADAS.Item(6, I).Value = True
        Next
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim TablaNroFacturas As New DataTable
        Try
            TablaNroFacturas.Columns.Clear()
        Catch ex As Exception
        End Try
        TablaNroFacturas.Columns.Add("NroFactura", GetType(String))
        TablaNroFacturas.Columns.Add("TipoDoc", GetType(String))
        Dim I As Integer
        Try
            For I = 0 To GRID_NO_EXPORTADAS.Rows.Count - 1
                If GRID_NO_EXPORTADAS.Item(6, I).Value = True Then
                    TablaNroFacturas.Rows.Add(GRID_NO_EXPORTADAS.Item(0, I).Value, GRID_NO_EXPORTADAS.Item(1, I).Value)
                End If
            Next
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CostruirTablaFacturas")
            Exit Sub
        End Try

        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.Int) : ParametroOutNumDoc.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_MigrarDocumentos", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@ListaDocumentos", TablaNroFacturas)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@Co_Tipo_Doc", "DOC")

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso Completado")
                CargarNoExportadas()

            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub
End Class