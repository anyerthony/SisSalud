Imports System.Data.SqlClient

Public Class FrmArticulo
    Sub CargarListas()
        ' Categorias
        Dim DSCategoria As Data.DataSet
        Dim AdaptadorCategoria As System.Data.SqlClient.SqlDataAdapter
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        If TXT_TIPO.Text = "Servicio" Then
            StrSQL = "SELECT co_cat,cat_des FROM saCatArticulo WHERE UPPER(CAMPO1)='SI'"
        Else
            StrSQL = "SELECT co_cat,cat_des FROM saCatArticulo WHERE UPPER(ISNULL(CAMPO1,''))<>'SI'"
        End If



        Dim comandoSQL As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoSQL.CommandType = CommandType.Text
        AdaptadorCategoria = New System.Data.SqlClient.SqlDataAdapter(comandoSQL)
        DSCategoria = New Data.DataSet("Categoria")
        AdaptadorCategoria.Fill(DSCategoria, "Categoria")
        TXT_CAT.DataSource = DSCategoria.Tables("Categoria")
        TXT_CAT.ValueMember = "co_cat"
        TXT_CAT.DisplayMember = "cat_des"

        ' Color
        Dim DSColor As Data.DataSet
        Dim AdaptadorColor As System.Data.SqlClient.SqlDataAdapter
        con.Close()
        con.Open()
        If TXT_TIPO.Text = "Servicio" Then
            StrSQL = "SELECT co_color,des_color FROM saColor WHERE UPPER(CAMPO1)='SI'"
        Else
            StrSQL = "SELECT co_color,des_color FROM saColor WHERE UPPER(ISNULL(CAMPO1,''))<>'SI'"
        End If

        Dim ComandoColor As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        AdaptadorColor = New System.Data.SqlClient.SqlDataAdapter(ComandoColor)
        DSColor = New Data.DataSet("Color")
        AdaptadorColor.Fill(DSColor, "Color")
        TXT_COL.DataSource = DSColor.Tables("Color")
        TXT_COL.ValueMember = "co_color"
        TXT_COL.DisplayMember = "des_color"

        ' Linea
        Dim DSLinea As Data.DataSet
        Dim AdaptadorLinea As System.Data.SqlClient.SqlDataAdapter
        con.Close()
        con.Open()
        If TXT_TIPO.Text = "Servicio" Then
            StrSQL = "SELECT co_lin,lin_des FROM saLineaArticulo WHERE UPPER(CAMPO1)='SI'"
        Else
            StrSQL = "SELECT co_lin,lin_des FROM saLineaArticulo WHERE UPPER(ISNULL(CAMPO1,''))<>'SI'"
        End If

        Dim ComandoLinea As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        AdaptadorLinea = New System.Data.SqlClient.SqlDataAdapter(ComandoLinea)
        DSLinea = New Data.DataSet("Linea")
        AdaptadorLinea.Fill(DSLinea, "Linea")
        TXT_LIN.DataSource = DSLinea.Tables("Linea")
        TXT_LIN.ValueMember = "co_lin"
        TXT_LIN.DisplayMember = "lin_des"


        'BAREMOS
        GRID_PRECIO.Rows.Clear()
        If TXT_TIPO.Text = "Servicio" Then
            StrSQL = "SELECT co_precio,des_precio FROM saTipoPrecio WHERE UPPER(CAMPO1)='SI'"
        Else
            StrSQL = "SELECT co_precio,des_precio FROM saTipoPrecio WHERE UPPER(ISNULL(CAMPO1,''))<>'SI'"
        End If

        Dim cmd As SqlCommand = con.CreateCommand()
        con.Close()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_PRECIO.Rows.Add(Trim(Arreglo("co_precio")), Trim(Arreglo("des_precio")))
        End While
        con.Close()

        If TXT_TIPO.Text <> "Servicio" Then
            'TipoMedi
            TXT_TIPO_MEDI.Items.Clear()
            StrSQL = "SELECT distinct codtipo FROM " & BDEmpresaIntegral & "serviciointerno "
            Dim CmdMedi As SqlCommand = con.CreateCommand()
            con.Close()
            con.Open()
            CmdMedi.CommandText = StrSQL
            Dim ArregloMedi As SqlDataReader = CmdMedi.ExecuteReader
            While ArregloMedi.Read
                TXT_TIPO_MEDI.Items.Add(Trim(ArregloMedi("codtipo")))
            End While
        End If
        

    End Sub

    Private Sub FrmArticulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListas()
    End Sub

    Private Sub TXT_LIN_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_LIN.SelectedValueChanged
        Try
            ' SubLinea
            If Len(TXT_LIN.SelectedValue) <= 1 Then Exit Sub
            Dim DSSubLinea As Data.DataSet
            Dim AdaptadorSubLinea As System.Data.SqlClient.SqlDataAdapter
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            con.Open()
            StrSQL = "SELECT co_subl,subl_des FROM saSubLinea WHERE co_lin ='" & TXT_LIN.SelectedValue & "'"
            Dim ComandoSubLinea As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
            AdaptadorSubLinea = New System.Data.SqlClient.SqlDataAdapter(ComandoSubLinea)
            DSSubLinea = New Data.DataSet("SubLinea")
            AdaptadorSubLinea.Fill(DSSubLinea, "SubLinea")
            TXT_SUB.DataSource = DSSubLinea.Tables("SubLinea")
            TXT_SUB.ValueMember = "co_subl"
            TXT_SUB.DisplayMember = "subl_des"
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        TXT_NOMBRE.Text = ""
        Dim I As Integer
        For I = 0 To GRID_PRECIO.Rows.Count - 1
            GRID_PRECIO.Item(2, I).Value = 0
        Next
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Hide()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim TablaBaremos As New DataTable
        Try
            TablaBaremos.Columns.Clear()
        Catch ex As Exception
        End Try
        TablaBaremos.Columns.Add("co_precio", GetType(String))
        TablaBaremos.Columns.Add("precio", GetType(Decimal))
        Dim I As Integer
        Try
            For I = 0 To GRID_PRECIO.Rows.Count - 1
                TablaBaremos.Rows.Add(GRID_PRECIO.Item(0, I).Value, GRID_PRECIO.Item(2, I).Value)
            Next
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CostruirTablaPrecios")
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

        ComandoSql = New SqlClient.SqlCommand("spQADP_CreaUnArticulo", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@ListaPrecio", TablaBaremos)
        ComandoSql.Parameters.AddWithValue("@CO_USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@ART_DES", TXT_NOMBRE.Text)
        ComandoSql.Parameters.AddWithValue("@CO_CAT", TXT_CAT.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CO_LIN", TXT_LIN.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CO_SUB", TXT_SUB.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CO_COL", TXT_COL.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@TIPO_MEDI", TXT_TIPO_MEDI.Text)
        ComandoSql.Parameters.AddWithValue("@TIPO", TXT_TIPO.Text)

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


            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try

    End Sub

    Private Sub TXT_TIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TIPO.SelectedIndexChanged

    End Sub

    Private Sub TXT_TIPO_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_TIPO.SelectedValueChanged
        CargarListas()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        ProcesarModificacion("Exec spQADP_ActualizaMaestros")

    End Sub
End Class