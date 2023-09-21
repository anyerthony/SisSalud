Imports System.Data.SqlClient
Public Class FrmBusquedaIngresos
    Sub SeleccionarItems(ByVal Fila As Integer)
        Try
            Select Case TXT_PANTALLA.Text
                Case Is = "FrmModificarPrecioPromocion"
                    FrmModificarPrecioPromocion.CargarIngreso(GRID.Item(0, Fila).Value)
                    Me.Hide()
                Case Is = "FrmCotizacionExcel"
                    With FrmCotizacionExcel
                        .TXT_NRO_ING.Text = GRID.Item(0, Fila).Value
                        .TXT_FEC_ING.Text = GRID.Item(1, Fila).Value
                        .TXT_PACIENTE.Text = GRID.Item(2, Fila).Value
                        .TXT_MOTIVO_ING.Text = GRID.Item(3, Fila).Value
                        .TXT_TIPO_ING.Text = GRID.Item(4, Fila).Value
                        .TXT_CI.Text = GRID.Item(5, Fila).Value
                    End With
                    Me.Hide()
            End Select
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "SeleccionarItems")
        End Try
        
    End Sub
    Sub CargarLista()
        Try
            Select Case TXT_PANTALLA.Text
                Case Is = "FrmModificarPrecioPromocion"
                    GRID.Rows.Clear()
                    StrSQL = "SELECT A.codigo,A.fecha,trim(B.nombre)+' '+trim(B.apellido) Paciente,A.codmotivcons,a.codtipopacie Tipo,b.cedula FROM " & BDEmpresaIntegral & "ingreso A INNER JOIN " & BDEmpresaIntegral & "paciente B ON A.cod_paciente=B.historia WHERE A.codstatus='Abierto' and facturado='N'"
                    Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    Dim cmd As SqlCommand = con.CreateCommand()
                    con.Open()
                    cmd.CommandText = StrSQL
                    Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                    While Arreglo.Read
                        GRID.Rows.Add(Arreglo("codigo"), Arreglo("fecha"), Arreglo("Paciente"), Arreglo("codmotivcons"))
                    End While
                Case Is = "FrmCotizacionExcel"
                    GRID.Rows.Clear()
                    StrSQL = "SELECT * FROM (SELECT A.codigo,A.fecha,trim(B.nombre)+' '+trim(B.apellido) Paciente,A.codmotivcons,a.codtipopacie Tipo,b.cedula,C.cod_ingreso NULO FROM " & BDEmpresaIntegral & "ingreso A INNER JOIN " & BDEmpresaIntegral & "paciente B ON A.cod_paciente=B.historia LEFT JOIN " & BDEmpresaIntegral & "serviinteraplic C ON A.codigo=C.cod_ingreso WHERE A.codstatus='Abierto' and facturado='N' ) AS X WHERE NULO IS NULL"
                    Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    Dim cmd As SqlCommand = con.CreateCommand()
                    con.Open()
                    cmd.CommandText = StrSQL
                    Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                    While Arreglo.Read
                        GRID.Rows.Add(Arreglo("codigo"), Arreglo("fecha"), Arreglo("Paciente"), Arreglo("codmotivcons"), Arreglo("Tipo"), Arreglo("cedula"))
                    End While
            End Select
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarLista")
        End Try
       
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarLista()
        End If
    End Sub
    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        If e.ColumnIndex < 0 Then Exit Sub
        SeleccionarItems(e.RowIndex)
    End Sub
End Class