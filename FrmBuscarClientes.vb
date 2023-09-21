Imports System.Data.SqlClient

Public Class FrmBuscarClientes
    Dim Fila As Integer
    Sub SeleccionarPagador(ByVal Historia As String)
        Select Case TXT_PANTALLA.Text
            Case Is = "FrmIntegral_CrearNotas"
                With FrmIntegral_CrearNotas
                    .TXT_CLI_DES.Text = GRID.Item(1, Fila).Value
                    .TXT_CO_CLI.Text = GRID.Item(4, Fila).Value
                End With
        End Select
        Me.Hide()
    End Sub
    Sub Buscar()
        Try
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT co_cli HISTORIA,rif CEDULA,cli_des NOMBRE,fecha_reg FECHANACIMIENTO,direc1 DIRECCIONCASA FROM sacliente  "
            If Len(TXT_BUSCAR.Text) >= 1 Then
                StrSQL = StrSQL + " WHERE rif LIKE '%" & TXT_BUSCAR.Text & "%' OR co_cli LIKE '%" & TXT_BUSCAR.Text & "%' OR cli_des LIKE '%" & TXT_BUSCAR.Text & "%' OR direc1 LIKE '%" & TXT_BUSCAR.Text & "%' "
            End If
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(Trim(Arreglo("CEDULA")), Trim(Arreglo("NOMBRE")), CDate(Arreglo("FECHANACIMIENTO")).ToShortDateString, Arreglo("DIRECCIONCASA"), Trim(Arreglo("HISTORIA")))
            End While
            con.Close()
            If GRID.Rows.Count >= 1 Then
                GRID.Focus()
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Buscar")
        End Try
    End Sub

    Private Sub TXT_BUSCAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSCAR.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Buscar()
        End If
    End Sub

    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        If e.ColumnIndex = 5 Then
            With FrmClientes
                .TXT_MED_HIS.Text = GRID.Item(4, e.RowIndex).Value
                .CargarDatos()
                .ShowDialog()
            End With


            Buscar()
        Else
            SeleccionarPagador(GRID.Item(4, e.RowIndex).Value)
        End If

    End Sub

    Private Sub GRID_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellEnter
        GRID.Rows(e.RowIndex).Selected = True
        Fila = e.RowIndex
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        If e.KeyCode = Keys.Space Then
            'SeleccionarPagador(GRID.Item(4, Fila).Value)
        End If
    End Sub


    Private Sub GRID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyUp
        If e.KeyData = Keys.Enter Then
            Try
                SeleccionarPagador(GRID.Item(4, Fila - 1).Value)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class