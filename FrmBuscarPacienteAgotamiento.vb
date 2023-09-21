Imports System.Data.SqlClient

Public Class FrmBuscarPacienteAgotamiento
    Dim Fila As Integer
    Sub SeleccionarPagador(ByVal Historia As String)
        With FrmCrearIngreso
            .TXT_COD_PACIENTE.Text = GRID.Item(6, Fila).Value
            .TXT_NOM_PACIENTE.Text = GRID.Item(1, Fila).Value
        End With
        Me.Hide()
    End Sub

    Private Sub TXT_BUSCAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSCAR.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim Encontrado As Integer = 0
            StrSQL = "EXEC prQADP_FindAseguradoAltamira '" & TXT_NAC.Text & "'," & TXT_BUSCAR.Text & ",'" & PAR_CodCobertura & "','" & PAR_CodTipoPreAdmin & "'"
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                Dim Historia = ""
                Encontrado = 1
                StrSQL = "SELECT DBO.ftQADP_FindHistoriaDesdeAscel('" & Arreglo("RIFASEG") & "') result"
                Dim con2 As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                Dim cmd2 As SqlCommand = con2.CreateCommand()
                con2.Open()
                cmd2.CommandText = StrSQL
                Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
                While Arreglo2.Read
                    Historia = Arreglo2("result")
                End While
                GRID.Rows.Add(Trim(Arreglo("RIFASEG")), Trim(Arreglo("NOMASEG")), CDate(Arreglo("FECNAC")).ToShortDateString, Arreglo("EDAD"), Trim(Arreglo("PARENTESCO")), Arreglo("AGOTAMIENTO"), Historia)
            End While
            con.Close()
            If Encontrado = 0 Then
                MsgBox("Disculpe, no se encontro informacion asociada a este titular, por favor verifique la informacion e intente de nuevo", MsgBoxStyle.Information, "Datos no encontrados")
            End If
        End If
    End Sub


    Private Sub GRID_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellEnter
        GRID.Rows(e.RowIndex).Selected = True
        Fila = e.RowIndex
    End Sub

    Private Sub GRID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        If e.KeyCode = Keys.Space Then
            SeleccionarPagador(GRID.Item(4, Fila).Value)
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



    Private Sub GRID_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellContentClick
        SeleccionarPagador(GRID.Item(4, Fila).Value)
    End Sub

End Class