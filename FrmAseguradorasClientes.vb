Imports System.Data.SqlClient

Public Class FrmAseguradorasClientes
    Sub Cargar()
        GRID.Rows.Clear()
        StrSQL = "SET DATEFORMAT DMY SELECT DISTINCT c.codigo,C.nombre Aseguradora,c.rif,ISNULL(d.co_cli,'') co_cli,ISNULL(d.cli_des,'') cli_des,ISNULL(F.des_precio,'') des_precio " _
        & " FROM " & BDEmpresaIntegral & "ingreso A INNER JOIN " & BDEmpresaIntegral & "aseguradora C ON A.cod_asegurad=C.codigo " _
        & " LEFT JOIN saCliente D ON UPPER(TRIM(REPLACE(REPLACE(C.rif,'-',''),'.',''))) COLLATE SQL_Latin1_General_CP1_CI_AS=UPPER(TRIM(REPLACE(REPLACE(D.rif,'-',''),'.',''))) " _
        & " LEFT JOIN saTipoCliente E ON D.tip_cli=E.tip_cli " _
        & " LEFT JOIN saTipoPrecio F ON E.co_precio=F.co_precio "

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID.Rows.Add(Trim(Arreglo("codigo")), Trim(Arreglo("Aseguradora")), Trim(Arreglo("rif")), Trim(Arreglo("co_cli")), Trim(Arreglo("cli_des")), Trim(Arreglo("des_precio")))

        End While
        con.Close()


    End Sub

    Private Sub TXT_FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cargar()
    End Sub

    Private Sub GRID_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellContentClick
        Select Case e.ColumnIndex
            Case Is = 5
                With FrmTipoSel
                    .Cargar("TipoBaremos")
                    .TXT_COD_CLIENTE.Text = GRID.Item(3, e.RowIndex).Value
                    .ShowDialog()

                End With

        End Select
    End Sub

    
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Cargar()
    End Sub

    Private Sub FrmAseguradorasClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub
End Class