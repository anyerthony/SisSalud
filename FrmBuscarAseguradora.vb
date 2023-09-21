Imports System.Data.SqlClient
Public Class FrmBuscarAseguradora

    Dim Fila As Integer
    Sub SeleccionarPagador(ByVal Historia As String)
        Dim Sw As Integer = 0
        Select Case TXT_PANTALLA.Text
            Case Is = "FrmFacturarServicioCliente"
                With FrmFacturarServicio
                    StrSQL = "SELECT TOP 1 CO_CLI FROM SACLIENTE WHERE RIF='" & GRID.Item(0, Fila).Value & "' AND TIP_CLI<>'00' AND INACTIVO=0"
                    Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    Dim cmd As SqlCommand = con.CreateCommand()
                    con.Open()
                    cmd.CommandText = StrSQL
                    Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                    While Arreglo.Read
                        Sw = 1
                        .TXT_CLI_NOM.Text = GRID.Item(1, Fila).Value
                        .TXT_CLI_RIF.Text = GRID.Item(0, Fila).Value
                        .TXT_CLI_HIS.Text = Arreglo("CO_CLI")
                        .TXT_COD_ASEGURA.Text = GRID.Item(3, Fila).Value
                        .TXT_COD_EMPRESA.Text = GRID.Item(4, Fila).Value
                    End While
                    con.Close()

                End With
        End Select
        If Sw = 0 Then
            MsgBox("Cliente no encontrado en Profit. Por favor revise si existe un cliente activo en el Profit, busquelo por RIF", MsgBoxStyle.Information, "Intente de nuevo")
        End If
        Me.Hide()
    End Sub
    Sub Buscar()
        Try
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT A.cod_asegurad ,B.rif,B.nombre+'/'+C.nombre NOMBRE,B.dirfiscal,A.cod_empresa FROM " & BDEmpresaIntegral & "aseguradoraempresa A INNER JOIN " & BDEmpresaIntegral & "aseguradora B ON A.cod_asegurad=B.codigo INNER JOIN " & BDEmpresaIntegral & "empresa C ON A.cod_empresa=C.codigo  "
            If Len(TXT_BUSCAR.Text) >= 1 Then
                StrSQL = StrSQL + " WHERE B.rif LIKE '%" & TXT_BUSCAR.Text & "%' or C.rif LIKE '%" & TXT_BUSCAR.Text & "%' " _
                & " OR A.cod_asegurad LIKE '%" & TXT_BUSCAR.Text & "%' or A.cod_empresa LIKE '%" & TXT_BUSCAR.Text & "%' " _
                & " OR B.nombre LIKE '%" & TXT_BUSCAR.Text & "%' OR C.nombre LIKE '%" & TXT_BUSCAR.Text & "%' " _
                & " OR B.dirfiscal LIKE '%" & TXT_BUSCAR.Text & "%' OR C.direccion LIKE '%" & TXT_BUSCAR.Text & "%' "
            End If
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(Trim(Arreglo("RIF")), Trim(Arreglo("NOMBRE")), Arreglo("dirfiscal"), Trim(Arreglo("cod_asegurad")), Trim(Arreglo("cod_empresa")))
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