Imports System.Data.SqlClient

Public Class FrmIngresosPorFacturas
    Sub CargarIngresos(ByVal NroFactura As String)
        Try
            GRID_INGRESOS.Rows.Clear()
            StrSQL = "SELECT [Ingreso],[Paciente],[Empresa],[Fecha],[MotivoConsulta],[StatusIngreso],[Monto],[Usuario] FROM VQAPIntegral_Ingresos WHERE ingreso in (SELECT COD_INGRESO FROM " & BDEmpresaIntegral & "DETALLEFACTURA WHERE COD_FACTURA='" & NroFactura & "')"
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID_INGRESOS.Rows.Add(Trim(Arreglo("Ingreso")), Trim(Arreglo("Paciente")), Trim(Arreglo("EMPRESA")), CDate(Arreglo("fecha")).ToShortDateString, Trim(Arreglo("MotivoConsulta")), Trim(Arreglo("StatusIngreso")), Format(Arreglo("monto"), "N2"), Trim(Arreglo("USUARIO")))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "FrmIngresosPorFacturas")
        End Try
    End Sub

    Private Sub GRID_INGRESOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_INGRESOS.CellContentClick
        If e.ColumnIndex = 0 Then
            With FrmIntegral_Ingreso
                .CargarIngreso(GRID_INGRESOS.Item(0, e.RowIndex).Value)
                .ShowDialog()
            End With
        End If
    End Sub
End Class