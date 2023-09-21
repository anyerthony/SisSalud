Imports System.Data.SqlClient

Public Class FrmBuscarEmpresas
    Dim Fila As Integer
    Sub SeleccionarEmpresa(ByVal Codigo As String)
        Dim Sw As Integer = 0
        Select Case TXT_PANTALLA.Text
            Case Is = "FrmConsultorios"
                With FrmConsultorios
                    StrSQL = "SELECT TOP 1 * FROM consultorioempresa WHERE cod_empresa='" & Codigo & "' AND cod_consulto='" & .TXT_CODIGO.Text & "'"
                    Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                    Dim cmd As SqlCommand = con.CreateCommand()
                    con.Open()
                    cmd.CommandText = StrSQL
                    Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                    While Arreglo.Read
                        Sw = 1
                    End While
                    con.Close()
                    If Sw = 0 Then
                        If (MsgBox("Usted procederá a agregar la empresa: " & GRID.Item(2, Fila).Value & " al consultorio/agencia " & .TXT_NOM.Text & ". Desea continuar?", MsgBoxStyle.YesNo, "Confirmacion")) <> MsgBoxResult.Yes Then Exit Sub
                        StrSQL = "INSERT consultorioempresa (COD_CONSULTO,COD_EMPRESA) SELECT '" & .TXT_CODIGO.Text & "','" & Codigo & "' " _
                        & " INSERT QAPD_CONTROL..AUDITORIA (usuario,fecha,aplicacion,tabla,num_doc,tipo,maquina,campos)  " _
                        & " SELECT '" & Cod_Usuario & "',GETDATE(),'SISSALUD','consultorioempresa','" & .TXT_CODIGO.Text & "','I',HOST_NAME(),'" & Codigo & "'"
                        Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                        ConProcesarModificacion.Open()
                        Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
                        ComandoProcesarModificaciones.CommandType = CommandType.Text
                        ComandoProcesarModificaciones.ExecuteNonQuery()
                        ComandoProcesarModificaciones.Dispose()
                        ComandoProcesarModificaciones.CommandTimeout = 0
                        ConProcesarModificacion.Close()
                        .CargarEmpresas(.TXT_CODIGO.Text)
                        Me.Close()
                    Else
                        MsgBox("Disculpe, la empresa ya esta relacionada al consultorio", MsgBoxStyle.Information, "SisSalud")
                    End If
                End With
        End Select
       
        Me.Hide()
    End Sub
    Sub Buscar()
        Try
            GRID.Rows.Clear()
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT codigo,rif,nombre FROM " & BDEmpresaIntegral & "empresa "
            If Len(TXT_BUSCAR.Text) >= 1 Then
                StrSQL = StrSQL + " WHERE rif LIKE '%" & TXT_BUSCAR.Text & "%' or nombre LIKE '%" & TXT_BUSCAR.Text & "%' " _
                & " OR codigo LIKE '%" & TXT_BUSCAR.Text & "%'"
            End If
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(Trim(Arreglo("codigo")), Trim(Arreglo("rif")), Trim(Arreglo("nombre")))
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

        SeleccionarEmpresa(GRID.Item(0, e.RowIndex).Value)


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
                SeleccionarEmpresa(GRID.Item(0, Fila - 1).Value)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class