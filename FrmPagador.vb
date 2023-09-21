Imports System.Data.SqlClient
Public Class FrmPagador
    Dim Fila As Integer
    Sub SeleccionarPagador(ByVal Historia As String)
        Dim FilaGrid As Integer = TXT_FILA_GRID_INGRESO.Text

        Select Case TXT_PANTALLA.Text
            Case Is = "FrmIntegral_Facturar"
                FrmIntegral_Facturar.GRID_INGRESOS.Item(7, FilaGrid).Value = Historia
                FrmIntegral_Facturar.Show()
            Case Is = "FrmIntegral_Facturar_Deducible"
                FrmIntegral_Facturar.GRID_DEDUCIBLE.Item(7, FilaGrid).Value = Historia
                FrmIntegral_Facturar.Show()
        End Select
        
        Me.Hide()
    End Sub
    Sub Buscar()
        Try
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT HISTORIA,CEDULA,TRIM(NOMBRE)+' '+TRIM(APELLIDO) NOMBRE,FECHANACIMIENTO,DIRECCIONCASA FROM " & BDEmpresaIntegral & "PACIENTE "
            If Len(TXT_BUSCAR.Text) >= 1 Then
                StrSQL = StrSQL + " WHERE CEDULA LIKE '%" & TXT_BUSCAR.Text & "%' OR historia LIKE '%" & TXT_BUSCAR.Text & "%' OR NOMBRE LIKE '%" & TXT_BUSCAR.Text & "%' OR DIRECCIONCASA LIKE '%" & TXT_BUSCAR.Text & "%' OR APELLIDO LIKE '%" & TXT_BUSCAR.Text & "%' OR CONVERT(varchar,fechanacimiento,3) LIKE '%" & Replace(TXT_BUSCAR.Text, "-", "/") & "%'"
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
        SeleccionarPagador(GRID.Item(4, e.RowIndex).Value)
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