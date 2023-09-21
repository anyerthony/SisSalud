Imports System.Data.SqlClient

Public Class FrmFacturarTarjetas
    Dim DSProdcuto As Data.DataSet
    Dim AdaptadorProducto As System.Data.SqlClient.SqlDataAdapter
    Dim DSCondicion As Data.DataSet
    Dim AdaptadorCondicio As System.Data.SqlClient.SqlDataAdapter
    Dim DSMoneda As Data.DataSet
    Dim AdaptadorMoneda As System.Data.SqlClient.SqlDataAdapter

    Sub Limpiar()
        Me.TXT_MONTO.Text = 0
        Me.TXT_PAC_CED.Text = ""
        Me.TXT_PAC_FNA.Text = ""
        Me.TXT_PAC_HIS.Text = ""
        Me.TXT_PAC_NOM.Text = ""
        Me.TXT_TARJETA.Text = ""
        Me.TXT_COUTA.Text = 1
        Me.TXT_FEC_FIN.Text = ""
        Me.TXT_FEC_INI.Text = ""
        Check_PAC.Checked = False
        TXT_CLI_HIS.Text = ""
        TXT_CLI_NOM.Text = ""
        TXT_CLI_RIF.Text = ""

        TXT_OBSERVA.Text = ""
    End Sub

    Sub CargarListas()
        ' Productos
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = "SELECT CO_ART,ART_DES FROM saArticulo WHERE CO_COLOR='" & My.Settings.CoColorProductos_Tarjetas & "' and modelo<>''"
        Dim comandoProducto As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoProducto.CommandType = CommandType.Text
        AdaptadorProducto = New System.Data.SqlClient.SqlDataAdapter(comandoProducto)
        DSProdcuto = New Data.DataSet("Prodcuto")
        AdaptadorProducto.Fill(DSProdcuto, "Prodcuto")
        TXT_PRODUCTO.DataSource = DSProdcuto.Tables("Prodcuto")
        TXT_PRODUCTO.ValueMember = "co_art"
        TXT_PRODUCTO.DisplayMember = "art_des"

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



    End Sub


    Private Sub FrmFacturarTarjetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarListas()

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If ValidarCorrelativo() <> 1 Then
            Exit Sub
        End If
        If InputNroCtrl() <> 1 Then
            NroControl = 0
            Exit Sub
        End If

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNroDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNroDoc.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_FacturarTarjeta", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@NRO_HISTORIA", TXT_CLI_HIS.Text)
        ComandoSql.Parameters.AddWithValue("@MONTO", Decimal.ToDouble(TXT_MONTO.Text))
        ComandoSql.Parameters.AddWithValue("@MONEDA", TXT_MONEDA.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@CONDICION", TXT_CON.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@FEC_INI", CDate(TXT_FEC_INI.Text).ToShortDateString)
        ComandoSql.Parameters.AddWithValue("@FEC_FIN", CDate(TXT_FEC_FIN.Text).ToShortDateString)
        ComandoSql.Parameters.AddWithValue("@COUTA", TXT_COUTA.Text)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)
        ComandoSql.Parameters.AddWithValue("@CO_ART", TXT_PRODUCTO.SelectedValue)
        ComandoSql.Parameters.AddWithValue("@NRO_TARJETA", TXT_TARJETA.Text)
        ComandoSql.Parameters.AddWithValue("@PACIENTE", TXT_PAC_CED.Text)
        ComandoSql.Parameters.AddWithValue("@CEDULA", TXT_CLI_RIF.Text)
        ComandoSql.Parameters.AddWithValue("@OBSERVACION", TXT_OBSERVA.Text)

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNroDoc)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                Imprimirfactura("RptFormatoFacturaParticular.rpt", ParametroOutNroDoc.Value)
                Limpiar()
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBuscarPaciente.TXT_PANTALLA.Text = Me.Name
        FrmBuscarPaciente.ShowDialog()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Limpiar()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_PAC.CheckedChanged
        BT_FIND_CLI_FACT.Enabled = True
        If Check_PAC.Checked = True Then
            TXT_CLI_HIS.Text = TXT_PAC_HIS.Text
            TXT_CLI_NOM.Text = TXT_PAC_NOM.Text
            TXT_CLI_RIF.Text = TXT_PAC_CED.Text
            BT_FIND_CLI_FACT.Enabled = False
        Else
            TXT_CLI_HIS.Text = ""
            TXT_CLI_NOM.Text = ""
            TXT_CLI_RIF.Text = ""
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_FIND_CLI_FACT.Click
        FrmBuscarPaciente.TXT_PANTALLA.Text = Me.Name & "Cliente"
        FrmBuscarPaciente.ShowDialog()
    End Sub

    Private Sub TXT_PAC_HIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PAC_HIS.TextChanged
        If Check_PAC.Checked = True Then
            TXT_CLI_HIS.Text = TXT_PAC_HIS.Text
            TXT_CLI_NOM.Text = TXT_PAC_NOM.Text
            TXT_CLI_RIF.Text = TXT_PAC_CED.Text
        End If
    End Sub

   
    
    Private Sub TXT_PRODUCTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRODUCTO.SelectedIndexChanged

    End Sub
End Class