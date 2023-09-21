Imports System.Data.SqlClient

Public Class FrmParametros_OtrosUsuarios
    Sub Cargar()

        GRID_PARAMETROS.Rows.Clear()
        StrSQL = "SELECT A.ID,A.NOMBRE,isnull(B.valor,'') VALOR FROM QAPD_CONTROL..MANPARAMETROS_SISTEMAS A LEFT JOIN QAPD_CONTROL..MANPARAMETROS_SISTEMAS_USUARIOS B ON A.ID=B.ID_PARAMETRO AND B.USUARIO='" & TXT_USUARIO.Text & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_PARAMETROS.Rows.Add(Arreglo("NOMBRE"), Arreglo("VALOR"), Arreglo("ID"))
        End While

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception
        End Try
        TablaGrid.Columns.Add("ID", GetType(Integer))
        TablaGrid.Columns.Add("VALOR", GetType(String))
        For I = 0 To GRID_PARAMETROS.Rows.Count - 1
            TablaGrid.Rows.Add(GRID_PARAMETROS.Item(2, I).Value, GRID_PARAMETROS.Item(1, I).Value)
        Next

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=QAPD_CONTROL;User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output


        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_GuardaParametrosusuarios", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0


        ComandoSql.Parameters.AddWithValue("@USUARIO", TXT_USUARIO.Text)

        ComandoSql.Parameters.AddWithValue("@LISTA_PARAMETROS", TablaGrid)


        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox("Parametros Guardados con Exito", MsgBoxStyle.Information, "Proceso Finalizado")
                CargarParametrosUsuarios()
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try


    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If MsgBox("Usted procedera a eliminar sus parametros y en su lugar, se copiara los parametros de otro usuario. Desea continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        Dim ACopiar As String = InputBox("Por favor indique el codigo del usuario que desea copiar", "CodigoUsuario")
        If Len(ACopiar) < 3 Then Exit Sub
        StrSQL = "DECLARE @USUARIO VARCHAR(MAX)='" & TXT_USUARIO.Text & "' INSERT AUDITORIA (USUARIO,APLICACION,TABLA,NUM_DOC,TIPO,MAQUINA,CAMPOS) " _
        & "	SELECT @USUARIO,TRIM(APP_NAME()),'MANPARAMETROS_SISTEMAS_USUARIOS',id_parametro,'M',TRIM(HOST_NAME()),valor FROM MANPARAMETROS_SISTEMAS_USUARIOS WHERE usuario=@USUARIO " _
        & " DELETE MANPARAMETROS_SISTEMAS_USUARIOS WHERE usuario=@USUARIO " _
        & " INSERT MANPARAMETROS_SISTEMAS_USUARIOS(id_parametro,usuario,valor) " _
        & " SELECT id_parametro,@USUARIO usuario,valor FROM MANPARAMETROS_SISTEMAS_USUARIOS WHERE USUARIO='" & ACopiar & "'"
        Try

            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=QAPD_CONTROL;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ComandoProcesarModificaciones.CommandTimeout = 0
            ConProcesarModificacion.Close()
            CargarParametrosUsuarios()
            MsgBox("Paracopiados con exito", MsgBoxStyle.Information, "Proceso Completado")

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Modulo", "ProcesarModificacion")
            Exit Sub
        End Try

    End Sub

    Private Sub TXT_USUARIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_USUARIO.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cargar()
        End If
    End Sub

    
End Class