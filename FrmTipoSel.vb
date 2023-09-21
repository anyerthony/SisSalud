Imports System.Data.SqlClient

Public Class FrmTipoSel
    Sub Cargar(ByVal Tipo As String)
        TXT_LISTA.Items.Clear()
        TXT_LABEL.Text = ""
        Select Case Tipo
            Case Is = "TipoBaremos"
                TXT_LABEL.Text = "Tipo Baremo"
                StrSQL = "SELECT '('+TRIM(A.co_precio)+') '+TRIM(A.des_precio)+'                                                    |'+TRIM(MAX (B.tip_cli)) TIPO_CLIENTE FROM saTipoPrecio A INNER JOIN saTipoCliente B ON A.co_precio=B.co_precio GROUP BY A.co_precio,A.des_precio"
                Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    TXT_LISTA.Items.Add(Arreglo("TIPO_CLIENTE"))
                End While
                con.Close()

        End Select
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If MsgBox("Usted esta por modificar el tipo de precio al cliente codigo: " & TXT_COD_CLIENTE.Text & " , desea continuar? ", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        ProcesarModificacion("INSERT saPista (fecha,tablaOri,rowguidOri,usuario_id,co_sucu,tipo_op,maquina,campos) SELECT GETDATE(),'saCliente', rowguid,'" & Cod_Usuario & "', '" & CoSucursal & "', 'M', 'ProcesoAutomaticoQAPD', '[Tipo]='+ tip_cli + ' -> ' + DBO.SUSSTRING('" & TXT_LISTA.Text & "',2,'|')  FROM saCliente where co_cli = '" & TXT_COD_CLIENTE.Text & "' DECLARE @TIPO AS VARCHAR(MAX)=DBO.SUSSTRING('" & TXT_LISTA.Text & "',2,'|')  UPDATE SACLIENTE SET TIP_CLI=@TIPO WHERE CO_CLI='" & TXT_COD_CLIENTE.Text & "'")
        FrmAseguradorasClientes.Cargar()
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class