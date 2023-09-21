Imports System.Data.SqlClient

Public Class SPEjecutable
    Dim bd As String
    Dim sp As String
    Public ComandoSql As SqlCommand
    Public arreglo As SqlDataReader
    Public ParametroOutStatus As SqlParameter

    Dim ConValidacion As System.Data.SqlClient.SqlConnection

    Sub New(ByVal nombreSP As String, Optional ByVal bdPR As String = "IPSS")
        bd = bdPR
        sp = nombreSP
        ConValidacion = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & bd & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ComandoSql = New SqlClient.SqlCommand(sp, ConValidacion)
    End Sub
    Sub Ejecutar()
        ConValidacion.Open()
        ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            'arreglo = ComandoSql.ExecuteReader()

            MsgBox(ParametroOutResultado.Value, IIf(ParametroOutStatus.Value = 1, MsgBoxStyle.Information, MsgBoxStyle.Critical), "Resultado")
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Ejecutar", sp)
            Exit Sub
        End Try
    End Sub

    Sub Leer()
        ConValidacion.Open()
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            'ComandoSql.ExecuteNonQuery()
            arreglo = ComandoSql.ExecuteReader()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Leer", sp)
            Exit Sub
        End Try
    End Sub
End Class
