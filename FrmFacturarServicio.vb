Imports System.Data.SqlClient

Public Class FrmFacturarServicio
    Dim DSCondicion As Data.DataSet
    Dim AdaptadorCondicio As System.Data.SqlClient.SqlDataAdapter
    Dim DSMoneda As Data.DataSet
    Dim AdaptadorMoneda As System.Data.SqlClient.SqlDataAdapter


    Sub Limpiar()

        TXT_CLI_HIS.Text = ""
        TXT_CLI_NOM.Text = ""
        TXT_CLI_RIF.Text = ""
        TXT_OBSERVA.Text = ""
        TXT_TOTAL.Text = 0
        TXT_servicios.Text = ""


        'GRID_SERVICIOS.Rows.Clear()
        'CargarServicos()

        'BuscarServicios("")
        'GuardarValores()
        'Dim I As Integer
        'TXT_TOTAL.Text = MONTO
        'For I = 0 To GRID_SERVICIOS.Rows.Count - 1
        '    'MONTO = MONTO + (GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value)
        '    GRID_SERVICIOS.Item(0, I).Value = 0
        '    GRID_SERVICIOS.Item(1, I).Value = 0
        '    'GuardarValores()
        'Next
        'GuardarValores()

        For I As Integer = 0 To GRID_SERVICIOS.Rows.Count - 1
            GRID_SERVICIOS.Item(2, I).Value = 0
            GRID_SERVICIOS.Item(3, I).Value = 0
            GRID_SERVICIOS.Item(4, I).Value = ""
            GRID_SERVICIOS.Item(5, I).Value = ""
            GRID_SERVICIOS.Item(1, I).Value = GRID_SERVICIOS.Item(6, I).Value

            GRID_SERVICIOS.Rows(I).Visible = True
        Next




    End Sub
    Sub BuscarServicios(ByVal Art_des As String)
        'MsgBox(InStr("test", Art_des))
        For I As Integer = 0 To GRID_SERVICIOS.Rows.Count - 1
            If (UCase(GRID_SERVICIOS.Item(1, I).Value) Like "*" & UCase(Art_des) & "*") Then
                GRID_SERVICIOS.Rows(I).Visible = True
            Else
                GRID_SERVICIOS.Rows(I).Visible = False
            End If
        Next
        'dv.RowFilter = String.Format("Servicio like '%{0}%'", Art_des)
    End Sub

    Sub CalcularTotal()
        Dim I As Integer, MONTO As Decimal = 0
        TXT_TOTAL.Text = MONTO
        For I = 0 To GRID_SERVICIOS.Rows.Count - 1
            If GRID_SERVICIOS.Item(2, I).Value.ToString = "" Then GRID_SERVICIOS.Item("cantidad", I).Value = "0"
            If GRID_SERVICIOS.Item(3, I).Value.ToString = "" Then GRID_SERVICIOS.Item("precio", I).Value = "0"

            MONTO = MONTO + (GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value)
        Next
        TXT_TOTAL.Text = MONTO
    End Sub

    Sub CargarListas()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)


        ' Condicion de Pago

        StrSQL = "select co_cond,cond_des from saCondicionPago"
        Dim comandoCondicio As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoCondicio.CommandType = CommandType.Text
        AdaptadorCondicio = New System.Data.SqlClient.SqlDataAdapter(comandoCondicio)
        DSCondicion = New Data.DataSet("Condicio")
        AdaptadorCondicio.Fill(DSCondicion, "Condicio")
        TXT_CON.DataSource = DSCondicion.Tables("Condicio")
        TXT_CON.ValueMember = "co_cond"
        TXT_CON.DisplayMember = "cond_des"


        ' Monedas
        StrSQL = "select co_mone,mone_des from saMoneda WHERE co_mone IN (SELECT g_moneda FROM par_emp)"
        Dim comandoMoneda As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoMoneda.CommandType = CommandType.Text
        AdaptadorMoneda = New System.Data.SqlClient.SqlDataAdapter(comandoMoneda)
        DSMoneda = New Data.DataSet("Moneda")
        AdaptadorMoneda.Fill(DSMoneda, "Moneda")
        TXT_MONEDA.DataSource = DSMoneda.Tables("Moneda")
        TXT_MONEDA.ValueMember = "co_mone"
        TXT_MONEDA.DisplayMember = "mone_des"

        Limpiar()


    End Sub
    Sub CargarServicos()
        GRID_SERVICIOS.Rows.Clear()
        'Dim tb As New DataTable
        'Dim ds As New DataSet

        'Try
        '    tb.Rows.Clear()
        '    tb.Columns.Clear()
        'Catch ex As Exception

        'End Try

        'tb.TableName = "test"

        'Dim cl As New DataColumn
        'cl.ColumnName = "Codigo"

        'Dim cl2 As New DataColumn
        'cl2.ColumnName = "Servicio"

        'Dim cl3 As New DataColumn
        'cl3.ColumnName = "cantidad"
        ''MsgBox(System.Type.GetType("DevComponents.DotNetBar.Controls.DataGridViewDoubleInputCell").ToString)

        'Dim cl4 As New DataColumn
        'cl4.ColumnName = "precio"

        'Dim cl5 As New DataColumn
        'cl5.ColumnName = "comentario"




        'tb.Columns.Add(cl)
        'tb.Columns.Add(cl2)
        'tb.Columns.Add(cl3)
        'tb.Columns.Add(cl4)
        ''tb.Columns.Add(cl5)




        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = "SELECT CO_ART,trim(ART_DES) ART_DES,0 cant,0 precio,'' comentario FROM saArticulo WHERE CO_COLOR='" & My.Settings.CoColorProductos_Servicios & "' and modelo<>''"
        Dim cmd As SqlCommand = con.CreateCommand()

        cmd.CommandText = StrSQL
        cmd.CommandTimeout = 0
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_SERVICIOS.Rows.Add(Arreglo("CO_ART"), Arreglo("ART_DES"), Arreglo("cant"), Arreglo("precio"), Arreglo("comentario"), Arreglo("comentario"), Arreglo("ART_DES"))
            'tb.Rows.Add(Trim(Arreglo("co_art")), Trim(Arreglo("art_des")))
        End While

        'Dim da As New SqlDataAdapter(cmd)


        'da.Fill(ds)

        'dv.Table = tb

        'GRID_SERVICIOS.DataSource = dv

        'GRID_SERVICIOS.Columns("Codigo").Visible = False
        'GRID_SERVICIOS.Columns("cantidad").Visible = False
        'GRID_SERVICIOS.Columns("precio").Visible = False


        'GRID_SERVICIOS.Columns("Servicio").ReadOnly = True
        'GRID_SERVICIOS.Columns("Servicio").Width = 250

        'GRID_SERVICIOS.Columns("Cantidad").HeaderText = "Cant."
        'GRID_SERVICIOS.Columns("Cantidad").Width = 50
        'GRID_SERVICIOS.Columns("Cantidad").CellType.FullName = System.Type.GetType("DevComponents.DotNetBar.Controls.DataGridViewDoubleInputCell")

        'GRID_SERVICIOS.Columns(3).DisplayIndex = 0
        'GRID_SERVICIOS.Columns(3).DefaultCellStyle.BackColor = Color.LemonChiffon

        'For I = 0 To GRID_SERVICIOS.Rows.Count - 1
        '    'MONTO = MONTO + (GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value)
        '    GRID_SERVICIOS.Item(0, I).Value = 0
        '    GRID_SERVICIOS.Item(1, I).Value = 0
        '    GRID_SERVICIOS.Item("cantidad", I).Value = 0
        '    GRID_SERVICIOS.Item("precio", I).Value = 0
        '    'GuardarValores()
        'Next

        'GuardarValores()
        con.Close()
    End Sub

    'Sub CargarValores()
    '    Dim I As Integer
    '    'TXT_TOTAL.Text = MONTO
    '    For I = 0 To GRID_SERVICIOS.Rows.Count - 1
    '        'MONTO = MONTO + (GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value)
    '        GRID_SERVICIOS.Item(0, I).Value = GRID_SERVICIOS.Item("Cantidad", I).Value
    '        GRID_SERVICIOS.Item(1, I).Value = GRID_SERVICIOS.Item("Precio", I).Value
    '    Next
    'End Sub
    'Sub GuardarValores()
    '    Dim I As Integer
    '    'TXT_TOTAL.Text = MONTO
    '    For I = 0 To GRID_SERVICIOS.Rows.Count - 1
    '        'MONTO = MONTO + (GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value)
    '        GRID_SERVICIOS.Item("Cantidad", I).Value = GRID_SERVICIOS.Item(0, I).Value
    '        GRID_SERVICIOS.Item("Precio", I).Value = GRID_SERVICIOS.Item(1, I).Value
    '    Next
    'End Sub


    Private Sub BT_FIND_CLI_FACT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_FIND_CLI_FACT.Click
        TXT_CLI_HIS.Text = ""
        TXT_COD_ASEGURA.Text = ""
        TXT_COD_EMPRESA.Text = ""
        FrmBuscarAseguradora.TXT_PANTALLA.Text = Me.Name & "Cliente"
        FrmBuscarAseguradora.ShowDialog()
    End Sub

    Private Sub FrmFacturarServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListas()
        CargarServicos()
    End Sub

    Private Sub GRID_SERVICIOS_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_SERVICIOS.CellClick
        If e.ColumnIndex = 4 Then
            FrmComentario.TXT_CODIGO.Text = GRID_SERVICIOS.Item(0, e.RowIndex).Value
            FrmComentario.TXT_SERVICIO.Text = GRID_SERVICIOS.Item(1, e.RowIndex).Value
            FrmComentario.TXT_COMENTARIO.Text = GRID_SERVICIOS.Item(4, e.RowIndex).Value
            FrmComentario.TXT_DES_ADICIONAL.Text = GRID_SERVICIOS.Item(5, e.RowIndex).Value
            'FrmComentario.TXT_ID.Text = e.RowIndex.ToString
            FrmComentario.id = e.RowIndex
            FrmComentario.pantalla = Me
            FrmComentario.ShowDialog()
        End If
    End Sub

    Private Sub GRID_SERVICIOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_SERVICIOS.CellContentClick

    End Sub

    Private Sub GRID_SERVICIOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_SERVICIOS.CellDoubleClick
       
    End Sub

    Private Sub GRID_SERVICIOS_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_SERVICIOS.CellEndEdit
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            'GuardarValores()
            'CargarValores()
            CalcularTotal()

        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        VerServiciosSelec()
        If TXT_CLI_HIS.Text = "" Or TXT_COD_ASEGURA.Text = "" Or TXT_COD_EMPRESA.Text = "" Then
            MsgBox("Disculpe, los datos del cliente/aseguradora/empresa no estan completos. Por favor intente de nuevo", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If


        If TXT_TOTAL.Text = "" Or TXT_TOTAL.Text = "0,00" Then
            MsgBox("Disculpe, No se encontro informacion para facturar, debe seleccionar indicar la cantidad y el pecio de almenos un servicio.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        If ValidarCorrelativo() <> 1 Then
            Exit Sub
        End If
        If InputNroCtrl() <> 1 Then
            NroControl = 0
            Exit Sub
        End If

        For I = 0 To GRID_SERVICIOS.Rows.Count - 1
            GRID_SERVICIOS.Item(4, I).Value = GRID_SERVICIOS.Item(5, I).Value & " " & vbCr & GRID_SERVICIOS.Item(4, I).Value
        Next



        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception
        End Try
        TablaGrid.Columns.Add("co_art", GetType(String))
        TablaGrid.Columns.Add("cantidad", GetType(Decimal))
        TablaGrid.Columns.Add("precio", GetType(Decimal))
        TablaGrid.Columns.Add("comentario", GetType(String))
        'TablaGrid.Columns.Add("des_adic", GetType(String))


        For I = 0 To GRID_SERVICIOS.Rows.Count - 1
            If GRID_SERVICIOS.Item(2, I).Value * GRID_SERVICIOS.Item(3, I).Value <> 0 Then
                TablaGrid.Rows.Add(GRID_SERVICIOS.Item(0, I).Value, GRID_SERVICIOS.Item(2, I).Value, GRID_SERVICIOS.Item(3, I).Value, GRID_SERVICIOS.Item(4, I).Value)
            End If
        Next


        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_FacturarServicio", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@MONEDA", TXT_MONEDA.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CONDICION", TXT_CON.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@CO_CLI", TXT_CLI_HIS.Text)
        ComandoSql.Parameters.AddWithValue("@COD_ASEGURADORA", TXT_COD_ASEGURA.Text)
        ComandoSql.Parameters.AddWithValue("@COD_EMPRESA", TXT_COD_EMPRESA.Text)
        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        ComandoSql.Parameters.AddWithValue("@CEDULA", TXT_CLI_RIF.Text)
        ComandoSql.Parameters.AddWithValue("@OBSERVACION", TXT_OBSERVA.Text)
        ComandoSql.Parameters.AddWithValue("@LISTA_SERVICIOS", TablaGrid)


        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                Imprimirfactura("RptFormatoFacturaParticular.rpt", ParametroOutNumDoc.Value)
                Limpiar()
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Limpiar()
    End Sub

  
    Private Sub TXT_servicios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_servicios.TextChanged
        BuscarServicios(TXT_servicios.Text)
        'CargarValores()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        VerServiciosSelec()
    End Sub
    Sub VerServiciosSelec()
        'dv.RowFilter = String.Format("cantidad > 0")
        'CargarValores()
        CalcularTotal()
        For I As Integer = 0 To GRID_SERVICIOS.Rows.Count - 1
            If (GRID_SERVICIOS.Item(2, I).Value Or GRID_SERVICIOS.Item(3, I).Value) Then
                GRID_SERVICIOS.Rows(I).Visible = True
                GRID_SERVICIOS.Item(1, I).Value = GRID_SERVICIOS.Item(6, I).Value & " " & GRID_SERVICIOS.Item(5, I).Value
                'GRID_SERVICIOS.Item(4, I).Value = GRID_SERVICIOS.Item(5, I).Value & " " & vbCr & GRID_SERVICIOS.Item(4, I).Value
            Else
                GRID_SERVICIOS.Rows(I).Visible = False
            End If
        Next



    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREAR_SERVICIO.Click
        Dim art_des As String
        art_des = InputBox("Ingrese el nombre del servicio que desea crear." & vbCr & vbCr & "Este proceso eliminará la informacion cargada hasta el momento.", "Crear nuevo servicio").ToString
        If Len(Trim(art_des)) = 0 Then
            Exit Sub
        End If

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@CO_ART", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQADP_CrearArticulo", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@ART_DES", art_des)
        'ComandoSql.Parameters.AddWithValue("@CONDICION", TXT_CON.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        'ComandoSql.Parameters.AddWithValue("@CO_CLI", TXT_CLI_HIS.Text)
        'ComandoSql.Parameters.AddWithValue("@COD_ASEGURADORA", TXT_COD_ASEGURA.Text)
        'ComandoSql.Parameters.AddWithValue("@COD_EMPRESA", TXT_COD_EMPRESA.Text)
        'ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        'ComandoSql.Parameters.AddWithValue("@CEDULA", TXT_CLI_RIF.Text)
        'ComandoSql.Parameters.AddWithValue("@OBSERVACION", TXT_OBSERVA.Text)
        'ComandoSql.Parameters.AddWithValue("@LISTA_SERVICIOS", TablaGrid)


        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                'Imprimirfactura("RptFormatoFacturaParticular.rpt", ParametroOutNumDoc.Value)
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.OkOnly, "Crear servicio")
                Limpiar()
                CargarServicos()
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Crear servicio")
        End Try
    End Sub
End Class