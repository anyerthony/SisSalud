Imports System.Data.SqlClient

Public Class FrmBuscarDocumentos
    Sub Buscar()
        GRID.Rows.Clear()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            StrSQL = "SET DATEFORMAT DMY DECLARE @TIPO VARCHAR(MAX)='" & TXT_TIPO.Text & "',@STR VARCHAR(MAX)='" & TXT_BUSQ.Text & "' " _
            & "SELECT co_tipo_doc,nro_doc,fec_emis,total_neto,B.cli_des " _
            & "FROM saDocumentoVenta A INNER JOIN saCliente B ON A.co_cli=B.co_cli " _
            & "WHERE A.FEC_EMIS>='" & CDate(TXT_FECHA.Text).ToShortDateString & "' AND A.co_tipo_doc=@TIPO AND (A.nro_doc LIKE '%'+@STR+'%' OR B.cli_des LIKE '%'+@STR+'%' OR B.co_cli LIKE '%'+@STR+'%' OR B.rif LIKE '%'+@STR+'%')"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID.Rows.Add(Arreglo("co_tipo_doc"), Trim(Arreglo("nro_doc")), CDate(Arreglo("fec_emis")).ToShortDateString, Arreglo("total_neto"), Trim(Arreglo("cli_des")))
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Buscar")
        End Try
    End Sub

    Private Sub TXT_BUSQ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSQ.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Buscar()
        End If
    End Sub

    Private Sub GRID_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellContentDoubleClick
        Try
            Select Case TXT_PANTALLA.Text
                Case Is = "FrmIntegral_CrearNotas"
                    With FrmIntegral_CrearNotas
                        .TXT_NRO_DOC.Text = GRID.Item(1, e.RowIndex).Value
                        .TXT_CLI_DOC.Text = GRID.Item(4, e.RowIndex).Value
                        .TXT_FEC_DOC.Text = GRID.Item(2, e.RowIndex).Value
                        .TXT_MONTO_DOC.Text = GRID.Item(3, e.RowIndex).Value
                        .TXT_TIPO_DOC.Text = TXT_TIPO.Text
                        Select Case TXT_TIPO.Text
                            Case Is = "FACT"
                                StrSQL = "DECLARE @NRO_FACT VARCHAR(MAX)='" & GRID.Item(1, e.RowIndex).Value & "'" _
                                & " SELECT Z.nombre Descripcion,Y.cantservapli Cantidad,Y.precservapli*W.TasaCambioBareFact Precio " _
                                & " FROM " & BDEmpresaIntegral & "detallefactura X INNER JOIN " & BDEmpresaIntegral & "serviinteraplic Y ON X.cod_ingreso=Y.cod_ingreso INNER JOIN " & BDEmpresaIntegral & "serviciointerno Z ON Y.cod_servicio=Z.codigo INNER JOIN " & BDEmpresaIntegral & "factura W ON X.cod_factura=W.codigo " _
                                & " where x.cod_factura=@NRO_FACT UNION " _
                                & " SELECT Z.nombre Descripcion,Y.cantservapli Cantidad,Y.precservapli*W.TasaCambioBareFact Precio " _
                                & " FROM " & BDEmpresaIntegral & "factservinte Y INNER JOIN " & BDEmpresaIntegral & "serviciointerno Z ON Y.cod_servicio=Z.codigo INNER JOIN " & BDEmpresaIntegral & "factura W ON Y.cod_factura=W.codigo " _
                                & " where y.cod_factura=@NRO_FACT "

                        End Select
                        .GRID_DETALLE.Rows.Clear()
                        Try
                            If My.Settings.CargarDetalleDocumentoOrigenCrearNotas = 1 Then
                                Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                                Dim cmd As SqlCommand = con.CreateCommand()
                                con.Open()
                                cmd.CommandText = StrSQL
                                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                                While Arreglo.Read
                                    .GRID_DETALLE.Rows.Add(Arreglo("Descripcion"), Arreglo("Cantidad"), Arreglo("Precio"))
                                End While
                                .CalcularMonto()
                                con.Close()
                            Else
                                .GRID_DETALLE.Rows.Add("AJUSTE POR DIFERENCIA EN FACTURA", 0, 0)
                            End If
                            
                        Catch ex As Exception
                            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GRID_CellContentDoubleClick")
                        End Try

                    End With
                Case Is = "FrmAnularDocumentos"
                    With FrmAnularDocumentos
                        .TXT_NRO_DOC.Text = GRID.Item(1, e.RowIndex).Value
                        .TXT_CLI_DOC.Text = GRID.Item(4, e.RowIndex).Value
                        .TXT_FEC_DOC.Text = GRID.Item(2, e.RowIndex).Value
                        .TXT_MONTO_DOC.Text = GRID.Item(3, e.RowIndex).Value
                    End With
            End Select
            
            Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmBuscarDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TXT_FECHA.Text = CDate(TXT_FECHA.Text).AddDays(-30)
    End Sub
End Class