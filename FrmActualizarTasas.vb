Imports System.Data.SqlClient
Public Class FrmActualizarTasas

    Private Sub FrmActualizarTasas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTasas(GRID_TASAS)

    End Sub
    Sub CargarTasas(ByVal Grid As DevComponents.DotNetBar.Controls.DataGridViewX)
        Try
            Grid.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "select co_mone,GETDATE() fecha, 0 tasa from samoneda where /*ISNULL(campo1,'') <> '' or*/ co_mone = 'USD' "
            If Grid.Name <> "GRID_TASAS" Then
                StrSQL = "set DATEFORMAT DMY SELECT A.co_mone,B.fecha,B.tasa_v tasa FROM saMoneda A INNER JOIN saTasa B ON A.co_mone = B.co_mone WHERE fecha = '" & FECHA_TASAS.Value.Day & "/" & FECHA_TASAS.Value.Month & "/" & FECHA_TASAS.Value.Year & "'"
            End If

            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                Grid.Rows.Add(Trim(Arreglo("co_mone")), Trim(Arreglo("fecha")), Trim(Arreglo("tasa")))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.ToString, ex.Message, Me.Name, "Cargar")
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Guardar()
    End Sub

    Sub Guardar()
        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()
        Dim TablaTasas As New DataTable
        Try
            TablaTasas.Columns.Clear()
        Catch ex As Exception

        End Try
        TablaTasas.Columns.Add("codigo", GetType(String))
        TablaTasas.Columns.Add("fecha", GetType(Date))
        TablaTasas.Columns.Add("tasa", GetType(Double))
        TablaTasas.Columns.Add("usuario", GetType(String))


        Dim I As Integer
        For I = 0 To GRID_TASAS.Rows.Count - 1
            If GRID_TASAS.Item(2, I).Value > 0 And Len(GRID_TASAS.Item(0, I).Value) > 0 And Len(GRID_TASAS.Item(1, I).Value) > 0 Then
                TablaTasas.Rows.Add(GRID_TASAS.Item(0, I).Value, GRID_TASAS.Item(1, I).Value, GRID_TASAS.Item(2, I).Value, Cod_Usuario)
            End If
        Next

        If TablaTasas.Rows.Count = 0 Then
            MsgBox("Disculpe, no se encontraron datos que guardar, verifique que la informacion este completa e intente de nuevo.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If
        If Validar() = 0 Then
            Exit Sub
        End If

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        'Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        'Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQADP_CargarTasas", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        'ComandoSql.Parameters.Add(ParametroOutResultado)
        'ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.AddWithValue("@TablaTasas", TablaTasas)
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)




        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Dim Resultado As String = ""
        Try
            ComandoSql.ExecuteReader()
            Resultado = "Tasas Cargadas correctamente"
            TablaTasas.Rows.Clear()
            CargarTasas(GRID_TASAS)
        Catch ex As Exception
            ManejoErrores(ex.ToString, ex.Message, Me.Name, "Cargar")
            Exit Sub
        End Try
        MsgBox(Resultado, MsgBoxStyle.Information, "Resultado de carga")


    End Sub
    Function Validar()
        Try
            'GRID_TASAS.Sort(GRID_TASAS.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            GRID_TASAS.Sort(GRID_TASAS.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            ManejoErrores(ex.ToString, ex.Message, Me.Name, "Ordenar")
        End Try

        Try
            Dim TablaElimina As New DataTable
            Try
                TablaElimina.Columns.Clear()
            Catch EX As Exception
            End Try
            TablaElimina.Columns.Add("row", GetType(Integer), "")

label1:
            For I As Integer = 0 To GRID_TASAS.Rows.Count() - 2
                If GRID_TASAS.Rows(I).Visible = False Then
                    GRID_TASAS.Rows.RemoveAt(I)
                    GoTo label1
                    'TablaElimina.Rows.Add(I)
                End If
            Next


            For I As Integer = 0 To GRID_TASAS.Rows.Count() - 2


                Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                StrSQL = "select co_mone from samoneda where co_mone = '" & GRID_TASAS.Item(0, I).Value & "' "

                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader

                Try
                    Arreglo.Read()
                    Dim r As String = Arreglo(0)
                Catch ex As Exception
                    MsgBox("Disculpe, la moneda " & GRID_TASAS.Item(0, I).Value & " no está registrada en profit", MsgBoxStyle.Information, "Validar")
                    'ManejoErrores(ex.ToString, ex.Message, Me.Name, "Validar")
                    Return 0
                    Exit Function
                End Try
                con.Close()

                'Dim SigMoneda As String
                'SigMoneda = ""
                'Try
                '    SigMoneda = GRID_TASAS.Item(0, I + 1).Value

                '    If GRID_TASAS.Item(0, I).Value = SigMoneda Then
                '        MsgBox("Disculpe, la moneda " & GRID_TASAS.Item(0, I).Value & " tiene dos o mas tasas asociadas", MsgBoxStyle.Information, "Validar")
                '        Return 0
                '        Exit Function
                '    End If
                'Catch ex As Exception
                'End Try



            Next


            Return 1
        Catch ex As Exception
            ManejoErrores(ex.ToString, ex.Message, Me.Name, "Validar")
            Return 0
        End Try
    End Function

    Private Sub DateTimeInput1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FECHA_TASAS.Click

    End Sub

    Private Sub DateTimeInput1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FECHA_TASAS.TextChanged
        CargarTasas(GRID_CONSULTA)
    End Sub

    Private Sub GRID_CONSULTA_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_CONSULTA.CellContentClick

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        For I As Integer = 0 To GRID_TASAS.Rows.Count() - 2
            If GRID_TASAS.Item(2, I).Value = 0 Then
                GRID_TASAS.Rows(I).Visible = False
            End If
        Next

        If Validar() = 1 Then
            Exit Sub
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        CargarTasas(GRID_TASAS)
    End Sub


    Private Sub GRID_TASAS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_TASAS.CellContentClick
       
    End Sub

    Private Sub GRID_TASAS_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_TASAS.CellEndEdit
        'If e.ColumnIndex = 1 Then
        '    Dim F As Date = GRID_TASAS.Item(1, e.RowIndex).Value
        '    For I As Integer = 0 To GRID_TASAS.Rows.Count() - 2
        '        GRID_TASAS.Item(1, I).Value = F
        '    Next
        'End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        FECHA_TASAS.Value = FECHA_TASAS.Value.AddDays(-1)
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        FECHA_TASAS.Value = FECHA_TASAS.Value.AddDays(+1)
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        CargarTasas(GRID_CONSULTA)
    End Sub
End Class