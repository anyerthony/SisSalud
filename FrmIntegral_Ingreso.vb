Imports System.Data.SqlClient

Public Class FrmIntegral_Ingreso
    Sub CargarMorbilidad(ByVal NroIngreso As String)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim FECHA As Date = CDate(My.Computer.Clock.LocalTime).AddMonths(My.Settings.CantMesesMorbilidad)
        If Len(TXT_FECHA_MORBILIDAD.Text) <> 0 Then
            FECHA = TXT_FECHA_MORBILIDAD.Text
        End If
        TXT_CANT_MORBILIDAD.Text = ""
        TXT_MONTO_MORBILIDAD.Text = ""
        TXT_NOM_PACIENTE.Text = ""
        TXT_FEC_NAC_PACIENTE.Text = "01/01/1900"

        StrSQL = "SET DATEFORMAT DMY DECLARE @NRO_INGRESO VARCHAR(MAX)='" & NroIngreso & "',@FECHA DATETIME=' " & CDate(FECHA).ToShortDateString & "' " _
        & " DECLARE @COD_PACIENTE VARCHAR(MAX),@NOM_PACIENTE VARCHAR(MAX),@MONTO DECIMAL(18,5),@CANT INT,@FEC_NAC DATETIME " _
        & " SELECT @COD_PACIENTE=COD_PACIENTE FROM " & BDEmpresaIntegral & "ingreso WHERE codigo=@NRO_INGRESO " _
        & " SELECT @MONTO=ISNULL(SUM(monttotaserv),0) ,@CANT= COUNT(*)  FROM " & BDEmpresaIntegral & "ingreso WHERE fecha>=@FECHA AND cod_paciente=@COD_PACIENTE AND codigo<>@NRO_INGRESO " _
        & " SELECT @NOM_PACIENTE=TRIM(ISNULL(NOMBRE,''))+' '+TRIM(ISNULL(APELLIDO,'')),@FEC_NAC=fechanacimiento  FROM " & BDEmpresaIntegral & "paciente WHERE historia=@COD_PACIENTE " _
        & " IF @NOM_PACIENTE IS NULL SET @NOM_PACIENTE='' IF @MONTO IS NULL SET @MONTO=0 IF @CANT IS NULL SET @CANT=0 " _
        & " SELECT @NOM_PACIENTE NOMBRE,@MONTO MONTO,@CANT CANTIDAD,@FEC_NAC FEC_NAC"
        Dim cmd2 As SqlCommand = con.CreateCommand()
        con.Open()
        cmd2.CommandText = StrSQL
        Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
        While Arreglo2.Read
            TXT_CANT_MORBILIDAD.Text = Arreglo2("CANTIDAD")
            TXT_MONTO_MORBILIDAD.Text = Arreglo2("MONTO")
            TXT_NOM_PACIENTE.Text = Arreglo2("NOMBRE")
            TXT_FEC_NAC_PACIENTE.Text = Arreglo2("FEC_NAC")
        End While
        con.Close()
    End Sub
    Sub CargarIngreso(ByVal NroIngreso As String)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            GRID_INGRESO.Rows.Clear()
            StrSQL = "SELECT NroIngreso,NomServicio,Doctor,FechaEjecucion,Monto FROM VQAPIntegral_IngresoDetalles a WHERE A.NroIngreso='" & NroIngreso & "'"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                GRID_INGRESO.Rows.Add(Trim(Arreglo("NroIngreso")), Trim(Arreglo("NomServicio")), Trim(Arreglo("Doctor")), CDate(Arreglo("FechaEjecucion")).ToShortDateString, Format(Arreglo("Monto"), "N2"))
            End While
            con.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarIngreso")
            con.Close()
        End Try
        TXT_INGRESO.Text = NroIngreso
        CargarMorbilidad(NroIngreso)

    End Sub


    Private Sub TXT_FECHA_MORBILIDAD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FECHA_MORBILIDAD.ValueChanged
        Try
            CargarIngreso(TXT_INGRESO.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class