
Imports System.Data.OleDb 'Importacion necesaria para trabajar con ficheros excel
Imports System.Data.SqlClient

Public Class FrmCotizacionExcel

    Dim DATASET_GRID As Data.DataSet
    Dim ADATADOR_GRID As System.Data.SqlClient.SqlDataAdapter
    Dim Table_Parametro As DataTable = New DataTable
    Dim RutaExcel As String = ""
    Dim Extenciones As String = "Archivos de Microsoft Office Excel (*.xlsx)|*.xlsx"
    Dim openFileDialog1 As New OpenFileDialog
    Dim NombreHoja As String = "SOLICITUD"
    Dim VisualizarAlerta As Integer = 0
    Dim FilaConsumo As Integer = 10
    Dim FilaCotizador As Integer = 19

    Sub BuscarIngreso()
        With FrmBusquedaIngresos
            .TXT_PANTALLA.Text = Me.Name
            .GRID.Rows.Clear()
            .ShowDialog()
        End With
    End Sub

    Sub AbrirExcel(ByVal Tipo As String)
        Try
            openFileDialog1.InitialDirectory = "C:\"
            'Filtramos solo archivos con extension *.xls
            openFileDialog1.Filter = Extenciones
            'Si se presiona abrir entonces...
            If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RutaExcel = openFileDialog1.FileName
                NombreHoja = IIf(Tipo = "Consumo", "SOLICITUD", "COTIZADOR")
            End If


            AbrirDatosExcel(Tipo)
        Catch ex As Exception

        End Try

    End Sub
    Sub AbrirDatosExcel(ByVal Tipo As String)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Tipo = "Consumo" Then
            GRID_CONSUMO.Rows.Clear()
        Else
            GRID_COTIZACION.Rows.Clear()
        End If


        Dim cmd As New OleDbCommand
        Dim AdaptadorExcel As New OleDb.OleDbDataAdapter
        Dim TablaExcel As New DataTable
        Dim ColConsumoCodigo As Integer = 1
        Dim ColConsumoDescrip As Integer = 3
        Dim ColConsumoCantidad As Integer = 5
        Dim ColConsumoCosto As Integer = 6
        Dim ColConsumoNeto As Integer = 7

        Dim ColCotizCodigo As Integer = 0
        Dim ColCotizDescrip As Integer = 1
        Dim ColCotizNeto As Integer = 9

        'Directorio Predeterminado
        openFileDialog1.InitialDirectory = "C:\"
        'Filtramos solo archivos con extension *.xls
        openFileDialog1.Filter = Extenciones
        'Si se presiona abrir entonces...
        If RutaExcel <> "" Then
            'Asignamos la ruta donde se almacena el fichero excel que se va a importar
            Try
                Dim StrConexcionExcel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & RutaExcel.Trim & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=1"""
                'Dim cadconex As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & RutaExcel.Trim & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"""
                Dim cadconex As String = StrConexcionExcel
                Dim cn As New OleDb.OleDbConnection(cadconex)
                cmd.Connection = cn
                'Instanciamos nuestra cadena de conexion especial para excel,indicando la ruta del fichero                

                'Consultamos la hoja llamada Clientes de nuestro archivo *.xls
                cmd.CommandText = "select * from [" & NombreHoja.Trim() & "$]"
                cmd.CommandType = CommandType.Text
                AdaptadorExcel.SelectCommand = cmd
                'Llenamos el datatable
                AdaptadorExcel.Fill(TablaExcel)

                Dim I As Integer

                If Tipo = "Consumo" Then
                    For I = FilaConsumo To TablaExcel.Rows.Count - 1
                        If TablaExcel.Rows(I).Item(ColConsumoCodigo).ToString() <> "" And TablaExcel.Rows(I).Item(ColConsumoCantidad).ToString() <> "" And Val(TablaExcel.Rows(I).Item(ColConsumoCosto).ToString()) > 0 Then
                            GRID_CONSUMO.Rows.Add(TablaExcel.Rows(I).Item(ColConsumoCodigo).ToString(), TablaExcel.Rows(I).Item(ColConsumoDescrip).ToString(), TablaExcel.Rows(I).Item(ColConsumoCantidad).ToString(), TablaExcel.Rows(I).Item(ColConsumoNeto).ToString())
                        End If
                    Next
                Else
                    For I = FilaCotizador To TablaExcel.Rows.Count - 1
                        If TablaExcel.Rows(I).Item(ColCotizCodigo).ToString() <> "" And Val(TablaExcel.Rows(I).Item(ColCotizNeto).ToString()) > 0 Then
                            GRID_COTIZACION.Rows.Add(TablaExcel.Rows(I).Item(ColCotizCodigo).ToString(), TablaExcel.Rows(I).Item(ColCotizDescrip).ToString(), TablaExcel.Rows(I).Item(ColCotizNeto).ToString())
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox("Hubo un error en la apertura del archuvo, por favor verifique que sea valido", "Corrija el archivo")
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End Try
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        AbrirExcel("Cotizador")
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        AbrirExcel("Consumo")
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        BuscarIngreso()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click

        If TXT_NRO_ING.Text = "" Then
            MsgBox("Disculpe, debe indicar los servicios que seran asociados al Ingreso", MsgBoxStyle.Information, "Ingrese los datos solicitados e intente de nuevo")
            Exit Sub
        End If
        If GRID_COTIZACION.Rows.Count < 0 Then
            MsgBox("Disculpe, debe indicar los servicios que seran asociados al Ingreso", MsgBoxStyle.Information, "Ingrese los datos solicitados e intente de nuevo")
            Exit Sub
        End If

        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception

        End Try
       
        TablaGrid.Columns.Add("co_art", GetType(String))
        TablaGrid.Columns.Add("tipo", GetType(String))
        TablaGrid.Columns.Add("cantidad", GetType(Decimal))
        TablaGrid.Columns.Add("neto", GetType(Decimal))


        Dim I As Integer
        For I = 0 To GRID_COTIZACION.Rows.Count - 1
            If GRID_COTIZACION.Item(2, I).Value > 0 Then
                TablaGrid.Rows.Add(GRID_COTIZACION.Item(0, I).Value, 1, 1, GRID_COTIZACION.Item(2, I).Value)
            End If
        Next
        For I = 0 To GRID_CONSUMO.Rows.Count - 1
            If GRID_CONSUMO.Item(3, I).Value > 0 Then
                TablaGrid.Rows.Add(GRID_CONSUMO.Item(0, I).Value, 2, GRID_CONSUMO.Item(2, I).Value, GRID_CONSUMO.Item(3, I).Value)
            End If
        Next

        Dim Con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Con.Open()
        ComandoSql = New SqlClient.SqlCommand("spQAPIntegral_CrearCotizacion", Con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        ComandoSql.Parameters.AddWithValue("@ListaDocumentos", TablaGrid)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@NRO_INGRESO", TXT_NRO_ING.Text)
        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                Exit Sub
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CarcarCotizacion")
            Exit Sub
        End Try
        TablaGrid.Rows.Clear()
        GRID_CONSUMO.Rows.Clear()
        GRID_COTIZACION.Rows.Clear()
        Con.Close()



    End Sub
End Class