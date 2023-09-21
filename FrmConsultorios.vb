Imports System.Data.SqlClient

Public Class FrmConsultorios
    Dim DSEstado As Data.DataSet
    Dim AdaptadorEstado As System.Data.SqlClient.SqlDataAdapter
    Dim DSCiudad As Data.DataSet
    Dim AdaptadorCiudad As System.Data.SqlClient.SqlDataAdapter
    Sub CargarEmpresas(ByVal Consultorio As String)
        GRID_EMPRESAS.Rows.Clear()
        StrSQL = "select b.codigo,b.rif,b.nombre from consultorioempresa a inner join empresa b on a.cod_empresa=b.codigo where a.cod_consulto='" & Consultorio & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_EMPRESAS.Rows.Add(Trim(Arreglo("codigo")), Trim(Arreglo("RIF")), Trim(Arreglo("NOMBRE")))
        End While
        con.Close()

    End Sub
    Sub CargarEstados()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            StrSQL = "select codigo,nombre from maestro where codgrupo='002'"
            Dim comandoCondicio As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoCondicio.CommandType = CommandType.Text
            AdaptadorEstado = New System.Data.SqlClient.SqlDataAdapter(comandoCondicio)
            DSEstado = New Data.DataSet("Estados")
            AdaptadorEstado.Fill(DSEstado, "Estados")
            TXT_EDO.DataSource = DSEstado.Tables("Estados")
            TXT_EDO.ValueMember = "codigo"
            TXT_EDO.DisplayMember = "nombre"
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarEstado")
        End Try
    End Sub
    Sub CargarCiudades()
        Try
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            StrSQL = "select codigo,nombre from ciudad"
            Dim comandoCondicio As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            comandoCondicio.CommandType = CommandType.Text
            AdaptadorCiudad = New System.Data.SqlClient.SqlDataAdapter(comandoCondicio)
            DSCiudad = New Data.DataSet("Ciudades")
            AdaptadorCiudad.Fill(DSCiudad, "Ciudades")
            TXT_CIU.DataSource = DSCiudad.Tables("Ciudades")
            TXT_CIU.ValueMember = "codigo"
            TXT_CIU.DisplayMember = "nombre"
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarCiudad")
        End Try
    End Sub
    Sub LimpiarDetalle()
        GRID_EMPRESAS.Rows.Clear()
        TXT_CODIGO.Text = ""
        TXT_RIF.Text = ""
        TXT_EXT.Text = ""
        TXT_NOM.Text = ""
        TXT_DES.Text = ""
        TXT_DIR.Text = ""
        TXT_TLF.Text = ""
        TXT_STATUS.Text = ""
    End Sub
    Sub SeleccionarItems(ByVal Codigo As String)
        LimpiarDetalle()
        StrSQL = "SELECT CODIGO,RIF,codexterno,nombre,descripcion,direccion,telefono1,cod_estado,cod_ciudad,codstatus FROM CONSULTORIO WHERE CODIGO='" & Codigo & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            TXT_CODIGO.Text = Trim(Arreglo("codigo"))
            TXT_RIF.Text = Trim(Arreglo("RIF"))
            TXT_EXT.Text = Trim(Arreglo("codexterno"))
            TXT_NOM.Text = Trim(Arreglo("nombre"))
            TXT_DES.Text = Trim(Arreglo("descripcion"))
            TXT_DIR.Text = Trim(Arreglo("direccion"))
            TXT_TLF.Text = Trim(Arreglo("telefono1"))
            TXT_STATUS.Text = Trim(Arreglo("codstatus"))
            TXT_CIU.SelectedValue = Trim(Arreglo("cod_ciudad"))
            TXT_EDO.SelectedValue = Trim(Arreglo("cod_estado"))
            CargarEmpresas(Trim(Arreglo("codigo")))
        End While
        con.Close()
    End Sub
    Sub CargarListado()
        GRID_LISTADO.Rows.Clear()
        StrSQL = "SELECT CODIGO,RIF,NOMBRE,DIRECCION,CODSTATUS FROM CONSULTORIO"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_LISTADO.Rows.Add(Trim(Arreglo("CODIGO")), Trim(Arreglo("RIF")), Trim(Arreglo("NOMBRE")), Trim(Arreglo("DIRECCION")), Trim(Arreglo("CODSTATUS")))
        End While
        con.Close()
    End Sub
    Private Sub FrmConsultorios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListado()
        CargarCiudades()
        CargarEstados()
    End Sub

    Private Sub GRID_LISTADO_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_LISTADO.CellDoubleClick
        If e.RowIndex > -1 Then
            Try
                SeleccionarItems(GRID_LISTADO.Item(0, e.RowIndex).Value)
                TabControl1.SelectedIndex = 1
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNroDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNroDoc.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("prQADP_GuardarConsultorio", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@CODIGO", TXT_CODIGO.Text)
        ComandoSql.Parameters.AddWithValue("@RIF", TXT_RIF.Text)
        ComandoSql.Parameters.AddWithValue("@EXTERNO", TXT_EXT.Text)
        ComandoSql.Parameters.AddWithValue("@NOMBRE", TXT_NOM.Text)
        ComandoSql.Parameters.AddWithValue("@DESCRIPCION", TXT_DES.Text)
        ComandoSql.Parameters.AddWithValue("@DIRECCION", TXT_DIR.Text)
        ComandoSql.Parameters.AddWithValue("@TLF", TXT_TLF.Text)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@ESTADO", TXT_EDO.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CIUDAD", TXT_CIU.SelectedValue)
        

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNroDoc)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Consultorio/Agencia creada con exito. Codigo Nro:" & ParametroOutNroDoc.Value)
                CargarListado()
                TabControl1.SelectedIndex = 0
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        LimpiarDetalle()
    End Sub

 
    Private Sub GRID_EMPRESAS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_EMPRESAS.CellDoubleClick
        Try
            If e.ColumnIndex <> 3 Then Exit Sub
            If (MsgBox("Usted procederá a eliminar la empresa " & GRID_EMPRESAS.Item(2, e.RowIndex).Value & " del consultorio/agencia " & TXT_NOM.Text & ". Desea continuar?", MsgBoxStyle.YesNo, "Confirmacion")) <> MsgBoxResult.Yes Then Exit Sub
            StrSQL = "DELETE consultorioempresa WHERE COD_CONSULTO='" & TXT_CODIGO.Text & "' AND COD_EMPRESA='" & GRID_EMPRESAS.Item(0, e.RowIndex).Value & "' " _
            & " INSERT QAPD_CONTROL..AUDITORIA (usuario,fecha,aplicacion,tabla,num_doc,tipo,maquina,campos) " _
            & " SELECT '" & Cod_Usuario & "',GETDATE(),'SISSALUD','consultorioempresa','" & TXT_CODIGO.Text & "','E',HOST_NAME(),'" & GRID_EMPRESAS.Item(0, e.RowIndex).Value & "'"
            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ComandoProcesarModificaciones.CommandTimeout = 0
            ConProcesarModificacion.Close()
            CargarEmpresas(TXT_CODIGO.Text)
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBuscarEmpresas.TXT_PANTALLA.Text = Me.Name
        FrmBuscarEmpresas.ShowDialog()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If MsgBox("Usted procederá a " & IIf(TXT_STATUS.Text = "Activo", "Inactivar", "Activar") & " la empresa " & TXT_NOM.Text & ". Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        StrSQL = "UPDATE CONSULTORIO SET CODSTATUS='" & IIf(TXT_STATUS.Text = "Activo", "Inactivo", "Activo") & "' where codigo='" & TXT_CODIGO.Text & "' " _
        & " INSERT QAPD_CONTROL..AUDITORIA (usuario,fecha,aplicacion,tabla,num_doc,tipo,maquina,campos) " _
        & " SELECT '" & Cod_Usuario & "',GETDATE(),'SISSALUD','CONSULTORIO','" & TXT_CODIGO.Text & "','M',HOST_NAME(),'Cambio de Status a: " & IIf(TXT_STATUS.Text = "Activo", "Inactivo", "Activo") & "'"
        Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConProcesarModificacion.Open()
        Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
        ComandoProcesarModificaciones.CommandType = CommandType.Text
        ComandoProcesarModificaciones.ExecuteNonQuery()
        ComandoProcesarModificaciones.Dispose()
        ComandoProcesarModificaciones.CommandTimeout = 0
        ConProcesarModificacion.Close()
        CargarListado()
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub GRID_LISTADO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_LISTADO.CellContentClick

    End Sub
End Class