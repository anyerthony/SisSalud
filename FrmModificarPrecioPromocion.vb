Imports System.Data.SqlClient

Public Class FrmModificarPrecioPromocion
    Sub CargarIngreso(ByVal NroIngreso As String)
        Dim I As Integer = 0
        GRID_SERVICIOS_INGRESOS.Rows.Clear()
        StrSQL = "DECLARE @NRO_INGRESO VARCHAR(MAX)='" & NroIngreso & "' " _
        & "SELECT A.codigo,A.fecha,A.codmotivcons,B.cedula CI_PACIENTE,TRIM(B.nombre)+' '+ TRIM(B.apellido) NOM_PACIENTE,ISNULL(E.nombre,'') ASEGURADORA,D.nombre SERVICIO ,C.precservapli PRECIO ,F.nombre Doctor" _
        & " FROM " & BDEmpresaIntegral & "ingreso A INNER JOIN " & BDEmpresaIntegral & "paciente B ON A.cod_paciente=B.historia INNER JOIN " & BDEmpresaIntegral & "serviinteraplic C ON A.codigo=C.cod_ingreso INNER JOIN " & BDEmpresaIntegral & "serviciointerno D ON C.cod_servicio=D.codigo INNER JOIN " & BDEmpresaIntegral & "usuario F ON C.cod_doctor=F.username  LEFT JOIN " & BDEmpresaIntegral & "aseguradora E ON A.cod_asegurad=E.codigo " _
        & " WHERE A.codigo=@NRO_INGRESO"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            If I = 0 Then
                TXT_NRO_INGRESO.Text = Arreglo("codigo") : TXT_FEC_INGRESO.Text = Arreglo("fecha")
                TXT_MOTIVO_INGRESO.Text = Arreglo("codmotivcons") : TXT_CI_PACIENTE.Text = Arreglo("CI_PACIENTE")
                TXT_NOM_PACIENTE.Text = Arreglo("NOM_PACIENTE") : TXT_ASEGURADORA.Text = Arreglo("ASEGURADORA")
            End If
            GRID_SERVICIOS_INGRESOS.Rows.Add(Arreglo("servicio"), Arreglo("Doctor"), Arreglo("Precio"))
            I = 1
        End While
        con.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBusquedaIngresos.TXT_PANTALLA.Text = Me.Name
        FrmBusquedaIngresos.ShowDialog()
    End Sub

    
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim CodPlantilla As String
        GRID_PROMOCION.Rows.Clear()
        CodPlantilla = InputBox("Por favor indique el código de la plantilla que tiene la información de la promoción", "CodigoPlantilla", "")
        If Len(CodPlantilla) = 0 Then Exit Sub
        CodPlantilla = Replicate("0", 10 - Len(CodPlantilla)) + CodPlantilla
        StrSQL = "DECLARE @NRO_INGRESO VARCHAR(MAX)='" & TXT_NRO_INGRESO.Text & "',@NRO_PNATILLA AS VARCHAR(MAX)='" & CodPlantilla & "'" _
        & "SELECT a.CODIGO_SERVICIO,a.PrecioIngreso,a.Servicio,ISNULL(b.PrecioPromocion,a.PrecioIngreso) PrecioPromocion FROM (SELECT Y.codexternoadm CODIGO_SERVICIO,X.precservapli PrecioIngreso,Y.nombre Servicio FROM IntegralManongo..serviinteraplic X INNER JOIN IntegralManongo..serviciointerno Y ON X.cod_servicio =Y.codigo WHERE X.cod_ingreso=@NRO_INGRESO) A LEFT JOIN (SELECT R.co_art COD_SERVICIO,R.prec_vta PrecioPromocion FROM saPlantillaVentaReng R INNER JOIN saPlantillaVenta P ON R.doc_num=P.doc_num WHERE R.doc_num=@NRO_PNATILLA) B ON A.CODIGO_SERVICIO COLLATE SQL_Latin1_General_CP1_CI_AS=B.COD_SERVICIO"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_PROMOCION.Rows.Add(Arreglo("Servicio"), Arreglo("PrecioIngreso"), Arreglo("PrecioPromocion"), (Arreglo("PrecioIngreso") - Arreglo("PrecioPromocion")) * 100 / Arreglo("PrecioIngreso"))
        End While
        con.Close()

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
      
    End Sub
End Class