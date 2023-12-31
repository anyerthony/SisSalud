
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource

Imports System.IO
Imports System.Text
Imports System.Data.SqlClient


Module Module1
    Public StrSQL As String
    Public Cod_Usuario As String = "PROFIT"
    Public Nombre_Usuario As String
    Public NroControl As Integer


    'Public Sep_Decimal As String = System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
    'Public Sep_Mil As String = System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator
    ' Public Sep_Decimal As String = My.Settings.SeparadorDecimal
    ' Public Sep_Mil As String = My.Settings.SeparadorMil
    Public Servidor As String = My.Settings.Servidor

    Public MensajeProcesarModificacion As String
    Public ResultProcesarModificacion As Integer
    Public PerfilAdministrator As Integer = 0
    Public ParRutaReporte As String = My.Application.Info.DirectoryPath + "\Reportes\"
    Public UserSystem As String = "SISSALUDUSER"
    Public PasswordSystem As String = "$1$$@LUDU$3R"
    Public BDEmpresa As String = My.Settings.BaseDeDatos
    Public BDEmpresaIntegral As String = My.Settings.BaseDatosIntegral
    Public CoSucursal As String
    Public DATASET_EMPRESAS As Data.DataSet
    Public ADATADOR_EMPRESAS As System.Data.SqlClient.SqlDataAdapter
    Public RutaReportes As String = "c:\temp"
    Public BDEmpresaIPSS As String = My.Settings.BaseDeDatosIPSS

    Public FechaValorCierreNomina As String
    Public FechaServidor As DateTime
    Public VariableSecuenciaAtencionClienteParticular As Integer = 0

    Public PAR_SeparadorDecimal As String
    Public PAR_SeparadorMil As String
    Public PAR_CargarDetalleDocumentoOrigenCrearNotas As String
    Public PAR_MostrarPatallaImpresionFactura As String
    Public PAR_CargarTodosLosRegistrosIngresosPorFacturar As String
    Public PAR_COD_CONSULTORIO As String
    Public PAR_COD_ASEGURADORA As String
    Public PAR_CodCobertura As String
    Public PAR_CodTipoPreAdmin As String
    Public PAR_MostrarPatallaSiguienteFactura As String
    Public PAR_MostrarPatallaNroCtrl As String
    Public BindingSourceCON As String



    Sub CargarParametrosUsuarios()
        StrSQL = "SELECT A.ID,A.NOMBRE,isnull(B.valor,'') VALOR FROM QAPD_CONTROL..MANPARAMETROS_SISTEMAS A LEFT JOIN QAPD_CONTROL..MANPARAMETROS_SISTEMAS_USUARIOS B ON A.ID=B.ID_PARAMETRO AND B.USUARIO='" & Cod_Usuario & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            Select Case Arreglo("NOMBRE")
                Case Is = "SeparadorDecimal"
                    PAR_SeparadorDecimal = Arreglo("VALOR")
                Case Is = "SeparadorMil"
                    PAR_SeparadorMil = Arreglo("VALOR")
                Case Is = "CargarDetalleDocumentoOrigenCrearNotas"
                    PAR_CargarDetalleDocumentoOrigenCrearNotas = Arreglo("VALOR")
                Case Is = "MostrarPatallaImpresionFactura"
                    PAR_MostrarPatallaImpresionFactura = Arreglo("VALOR")
                Case Is = "CargarTodosLosRegistrosIngresosPorFacturar"
                    PAR_CargarTodosLosRegistrosIngresosPorFacturar = Arreglo("VALOR")
                Case Is = "COD_CONSULTORIO"
                    PAR_COD_CONSULTORIO = Arreglo("VALOR")
                Case Is = "COD_ASEGURADORA"
                    PAR_COD_ASEGURADORA = Arreglo("VALOR")
                Case Is = "CodCobertura"
                    PAR_CodCobertura = Arreglo("VALOR")
                Case Is = "CodTipoPreAdmin"
                    PAR_CodTipoPreAdmin = Arreglo("VALOR")
                Case Is = "MostrarPatallaSiguienteFactura"
                    PAR_MostrarPatallaSiguienteFactura = Arreglo("VALOR")
                Case Is = "MostrarPatallaNroCtrl"
                    PAR_MostrarPatallaNroCtrl = Arreglo("VALOR")


            End Select
        End While
    End Sub
    Sub ManejoErrores(ByVal MensajeCorto As String, ByVal MensajeLargo As String, ByVal Pantalla As String, ByVal Proceso As String)
        MsgBox("Disculpe, ha ocurrido un error. Por favor indíquele a soporte técnico que: " & vbCr & MensajeCorto & vbCr & "Pantalla: " & Pantalla & vbCr & "Proceso: " & Proceso, MsgBoxStyle.Exclamation, "Error No Controlado")
    End Sub

    Function VerificarExistenciaFacturaMediSoftware(ByVal NroFact As String) As Integer
        VerificarExistenciaFacturaMediSoftware = 0
        StrSQL = "SELECT CODIGO FROM " & BDEmpresaIntegral & "FACTURA WHERE CODIGO='" & NroFact & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            VerificarExistenciaFacturaMediSoftware = 1
        End While
        con.Close()

    End Function
    Sub Imprimirfactura(ByVal NombreFormato As String, ByVal FactNum As String)
        Dim Cr1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim Cr2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        NombreFormato = NombreFormato

        'If VerificarExistenciaFacturaMediSoftware(FactNum) = 0 Then
        'NombreFormato = "RptFormatoFacturaProfit.rpt"
        'End If


        FrmReportes.CONTROL.ShowPrintButton = True

        If CoSucursal = "03" Then NombreFormato = "RptFormatoFacturaProfit.rpt"

        Dim NombreReporte As String = ParRutaReporte & NombreFormato
        Try

            Cr1.FileName = NombreReporte
            Cr1.SetParameterValue("@FACT_NUM", FactNum)



            'If NombreFormato = "RptFormatoFacturaParticular.rpt" Then
            Cr1.SetParameterValue("@FORMATO", 1)
            Cr1.SetParameterValue("@EmpresaPrint", 1)
            'End If



            Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
            FrmReportes.CONTROL.ReportSource = Cr1
            FrmReportes.Text = NombreFormato
            FrmReportes.ShowDialog()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Formato Factura Particular")
        End Try
    End Sub
    Sub ImprimirfacturaEmpresa(ByVal NombreFormato As String, ByVal FactNum As String, ByVal Formato As Integer, ByVal EmpresaPrint As Boolean)
        Dim Cr1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim Cr2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'NombreFormato = NombreFormato
        'If VerificarExistenciaFacturaMediSoftware(FactNum) = 0 Then
        '    NombreFormato = "RptFormatoFacturaProfit.rpt"
        'End If
        'MsgBox(NombreFormato)
        Try
            Dim NombreReporte As String
            If CoSucursal = "03" Then
                NombreFormato = "RptFormatoFacturaProfit.rpt"
            End If

            FrmReportes.CONTROL.ShowPrintButton = True
            NombreReporte = ParRutaReporte & NombreFormato
            Cr1.FileName = NombreReporte
            Cr1.SetParameterValue("@FORMATO", Formato)
            Cr1.SetParameterValue("@EmpresaPrint", EmpresaPrint)
            Cr1.SetParameterValue("@FACT_NUM", FactNum)

            Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
            FrmReportes.CONTROL.ReportSource = Cr1
            FrmReportes.Text = NombreFormato
            FrmReportes.ShowDialog()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Formato Factura Empresa")
        End Try
    End Sub

    Sub ImprimirIGTF(ByVal IGTFNum As String)
        Dim Cr1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim Cr2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        FrmReportes.CONTROL.ShowPrintButton = True

        Dim NombreReporte As String = ParRutaReporte & "RptFormatoIGTF.rpt"
        Try
            Cr1.FileName = NombreReporte
            Cr1.SetParameterValue("@NRO_DOC", IGTFNum)
            Cr1.DataSourceConnections.Item(0).SetConnection(Servidor, BDEmpresa, UserSystem, PasswordSystem)
            FrmReportes.CONTROL.ReportSource = Cr1
            FrmReportes.Text = "Formato IGTF"
            FrmReportes.ShowDialog()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Reportes", "Formato IGTF")
        End Try
    End Sub

    Sub ProcesarModificacion(ByVal Instruccion As String)
        Try
            Instruccion = "SET DATEFORMAT DMY " + Instruccion
            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(Instruccion, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ComandoProcesarModificaciones.CommandTimeout = 0
            ConProcesarModificacion.Close()
            ResultProcesarModificacion = 1
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Modulo", "ProcesarModificacion")
            ResultProcesarModificacion = 0
        End Try


    End Sub

    Sub CrearBaremo()
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim Descrip As String = InputBox("Por favor indique la descripcion del Baremo a crear", "Nombre del baremo")
        If Len(Descrip) <= 1 Then Exit Sub

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output

        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQADP_CrearBaremo", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@DESCRIP", Descrip)

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso Completado")

            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Modulo", "CrearBaremo")
        End Try
    End Sub

    Function ReturnDecimal(ByVal Valor As String)
        Try
            Valor = Replace(Valor, PAR_SeparadorMil, "")

            ReturnDecimal = Decimal.ToDouble(Valor)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al procesar las cantidades. Generalmente ocurre cuando indica más de un separador decimal o un carácter distinto a los valores numéricos. El detalle del error es:" & vbCr & ex.Message, MsgBoxStyle.Information, "Corrija la cifra")
            ReturnDecimal = 0
        End Try

    End Function

    Function AgregarChar13(ByVal Texto As String)
        Dim Largo As Integer = 120, Grupos As Integer = 1, Ciclo As Integer = 0, Retorna As String = "", Arranque As Integer = 1
        Grupos = Len(Texto) / Largo
        If Grupos >= 1 Then
            Retorna = ""
            For Ciclo = 0 To Grupos
                Retorna = Retorna & Mid(Texto, Arranque, Largo)
                Arranque = Arranque + Largo
            Next
        Else
            Retorna = Texto
        End If

        AgregarChar13 = Retorna

    End Function

    Function Replicate(ByVal Caracter As String, ByVal Cantidad As Integer)
        Dim Retorna As String = "", III As Integer

        For III = 1 To Cantidad
            Retorna = Retorna + Caracter
        Next


        Replicate = Retorna

    End Function
    Function FormatoFechaDDMMYYY(ByVal Fecha As Date)
        Dim Retorna As String = ""
        Dim Dia As String = Trim(Str(CDate(Fecha).Day))
        Dim Mes As String = Trim(Str(CDate(Fecha).Month))
        Retorna = Replicate("0", 2 - Len(Dia)) + Dia + "/" + Replicate("0", 2 - Len(Mes)) + Mes + "/" + Trim(Str(CDate(Fecha).Year))
        FormatoFechaDDMMYYY = Retorna

    End Function

    Function FormatoFechaSoloNumeros(ByVal Fecha As Date)
        Dim Retorna As String = ""
        Dim Dia As String = Trim(Str(CDate(Fecha).Day))
        Dim Mes As String = Trim(Str(CDate(Fecha).Month))
        Retorna = Replicate("0", 2 - Len(Dia)) + Dia + Replicate("0", 2 - Len(Mes)) + Mes + Mid(Trim(Str(CDate(Fecha).Year)), 3, 2)
        FormatoFechaSoloNumeros = Retorna

    End Function

    Function ReturnValorDecimal(ByVal Cadena As String)
        Dim I As Integer, PuntoDecimal As String = 0, ValorStr As String = "", ValorDecimal As Decimal = 0
        Try
            For I = 1 To Len(Cadena)
                If Mid(Cadena, I, 1) = "," Or Mid(Cadena, I, 1) = "." Then
                    If PuntoDecimal = 0 Then
                        PuntoDecimal = 1
                        ValorStr = ValorStr + PAR_SeparadorDecimal
                    End If
                Else
                    ValorStr = ValorStr + Mid(Cadena, I, 1)
                End If
            Next

        Catch exx As Exception
            ReturnValorDecimal = 0
            Exit Function
        End Try

        Try
            ReturnValorDecimal = Decimal.ToDouble(ValorStr)
        Catch exxx As Exception
            ReturnValorDecimal = 0
        End Try
    End Function

    Sub SecuenciaAtencionClienteParticular(ByVal NroFactura As String)
        VariableSecuenciaAtencionClienteParticular = 1
        FrmIntegral_Cobros.CargarDatosFacturas(NroFactura)
        FrmIntegral_Cobros.ShowDialog()
        Imprimirfactura("RptFormatoFacturaParticular.rpt", NroFactura)

        VariableSecuenciaAtencionClienteParticular = 0
    End Sub

    Sub ActualizarFechaServidor()
        Try
            StrSQL = "SELECT GETDATE() FECHA"
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                FechaServidor = Arreglo("FECHA")
            End While
        Catch ex As Exception

        End Try

    End Sub

    Sub CargarInformacionFactura(ByVal NroFact As String)


        If VerificarExistenciaFacturaMediSoftware(NroFact) = 0 Then
            FrmImprimirFactura.RB_Profit.Checked = True
        Else
            Dim FormatoFactura As String = ""
            Dim MostrarEmpresa As String = ""
            Try
                StrSQL = "select case when b.codigo is null then 'PAC' ELSE a.codmodfactur END Formato, isnull(b.mostemprfact,'N') Empresa from " & BDEmpresaIntegral & " factura a left join " & BDEmpresaIntegral & "aseguradora b on a.cod_asegurad = b.codigo where a.codigo = '" & NroFact & "'"
                Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
                Dim cmd As SqlCommand = con.CreateCommand()
                con.Open()
                cmd.CommandText = StrSQL
                Dim Arreglo As SqlDataReader = cmd.ExecuteReader
                While Arreglo.Read
                    'FechaServidor = Arreglo("FECHA")
                    FormatoFactura = Arreglo("Formato")
                    MostrarEmpresa = Arreglo("Empresa")
                End While
            Catch ex As Exception

            End Try

            Select Case FormatoFactura
                Case "PA"
                    FrmImprimirFactura.RB_Paciente.Checked = True
                Case "LD"
                    FrmImprimirFactura.RB_Detallado.Checked = True
                Case "LR"
                    FrmImprimirFactura.RB_Resumido.Checked = True
                Case "PAC"
                    FrmImprimirFactura.RB_Particular.Checked = True
            End Select

            FrmImprimirFactura.CH_Empresa.Checked = False
            If MostrarEmpresa = "S" Then
                FrmImprimirFactura.CH_Empresa.Checked = True
            End If



        End If

    End Sub

    Function ValidarCorrelativo()
        If PAR_MostrarPatallaSiguienteFactura <> 1 Then
            ValidarCorrelativo = 1
            Exit Function
        End If

        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output
        Dim ParametroOutNumControl = New SqlParameter("@NUMCONTROL_STR", SqlDbType.VarChar, 2500) : ParametroOutNumControl.Direction = ParameterDirection.Output


        ComandoSql = New SqlClient.SqlCommand("spQADP_SiguienteFactura", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.Add(ParametroOutNumControl)

        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)



        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                ValidarCorrelativo = 0
                Exit Function
            End If




            If MsgBox("Proxima factura: " & ParametroOutNumDoc.Value.ToString & " con el Nro. de control: " & ParametroOutNumControl.Value.ToString & ".", MsgBoxStyle.OkCancel, "Confirmación de Correlativos") = MsgBoxResult.Cancel Then
                ValidarCorrelativo = 0
                Exit Function
            End If




            ValidarCorrelativo = 1

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Modulo", "Validar correlativo")
            ValidarCorrelativo = 0
        End Try

    End Function

    Function InputNroCtrl()
        NroControl = 0
        If PAR_MostrarPatallaNroCtrl <> 1 Then
            InputNroCtrl = 1
            Exit Function
        End If

        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output
        Dim ParametroOutNumControl = New SqlParameter("@NUMCONTROL_STR", SqlDbType.VarChar, 2500) : ParametroOutNumControl.Direction = ParameterDirection.Output


        ComandoSql = New SqlClient.SqlCommand("spQADP_SiguienteFactura", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.Add(ParametroOutNumControl)

        ComandoSql.Parameters.AddWithValue("@SUCURSAL", CoSucursal)



        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                InputNroCtrl = 0
                Exit Function
            End If

            'If MsgBox("Proxima factura: " & ParametroOutNumDoc.Value.ToString & " con el Nro. de control: " & ParametroOutNumControl.Value.ToString & ".", MsgBoxStyle.OkCancel, "Confirmación de Correlativos") = MsgBoxResult.Cancel Then
            '    InputNroCtrl = 0
            '    Exit Function
            'End If
            'Dim nroControl As Integer
            Try
                NroControl = Val(InputBox("Por favor ingrese la parte numerica del numero de control correspondiente a la factura Nro.: " & ParametroOutNumDoc.Value.ToString & ".", "Ingresar Nro. de control"))
                If NroControl = 0 Then
                    InputNroCtrl = 0
                    Exit Function
                End If
            Catch ex As Exception
                ManejoErrores(ex.Message, ex.ToString, "Modulo", "Cargar Numero control")
                InputNroCtrl = 0
                Exit Function
            End Try


            InputNroCtrl = 1

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Modulo", "Cargar Numero control")
            InputNroCtrl = 0
        End Try

    End Function

    Public Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String, ByVal Ruta As String, ByVal DescripcionArchivo As String, ByVal parameterValues As Dictionary(Of String, Object)) As String

        For Each parameterField As ParameterField In rpt.ParameterFields
            If parameterValues.ContainsKey(parameterField.Name) Then
                rpt.SetParameterValue(parameterField.Name, parameterValues(parameterField.Name))
            End If
        Next

        Dim vFileName As String = ""
        Dim diskOpts As New DiskFileDestinationOptions
        Try
            With rpt.ExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
            End With
            vFileName = Ruta & "\" & Replace(NombreArchivo, ".rpt", "") & DescripcionArchivo & ".pdf"
            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            'rpt.Refresh()
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            MsgBox("Error al generar PDF " & NombreArchivo & ". Por favor comuniquese con soporte tecnico e informele que: " + ex.Message, MsgBoxStyle.Information, "Error")

        End Try

        Return vFileName
    End Function

  
    Function SourceAceptarCambios() As Boolean
        Return IIf(MsgBox("Desea Guardar los cambios pendientes?", MsgBoxStyle.YesNo, "Guardar") = MsgBoxResult.Yes, True, False)
    End Function

    Function Expandir(ByVal texto As String, ByVal titulo As String) As String
        Dim FrmExpandir As New FrmOrtografia(texto, titulo)
        Return FrmExpandir.Expandir()
    End Function

    Function SelectSQL(ByVal consulta As String, Optional ByVal BD As String = "IPSS") As DataTable
        Dim results As New DataTable

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BD & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = consulta
        Dim cmd As SqlCommand = con.CreateCommand()
        cmd.CommandText = StrSQL
        cmd.CommandTimeout = 0
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        results.Load(Arreglo)
        con.Close()

        


        Return results
    End Function
    Function GenerarIdArchivo() As Integer
        Try
            Dim SW As Integer = 0, IdImagen As Integer
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & "_FILES;User ID=" & UserSystem & ";Password=" & PasswordSystem)

            Dim cmd As SqlCommand = con.CreateCommand()

            StrSQL = "INSERT IPSS_FILES..ARCHIVOS (archivo) SELECT NULL IMAGEN"
            ProcesarModificacion(StrSQL)

            StrSQL = "SELECT MAX(ID) ID FROM ARCHIVOS"
            Dim cmd2 As SqlCommand = con.CreateCommand()
            con.Open()
            cmd2.CommandText = StrSQL
            Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
            While Arreglo2.Read
                IdImagen = Arreglo2("ID")
            End While

            con.Close()


            Return IdImagen
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "GenerarIdArchivo")
        End Try

    End Function



End Module





