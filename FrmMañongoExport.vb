Public Class FrmMañongoExport

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        
        Try
            Dim ServidorMañongo As String = "VALSERVER02"
            StrSQL = "BACKUP DATABASE [Integral] TO  DISK = N'C:\SQL\BackupExportCss\Integral.bak' WITH NOFORMAT, INIT,  NAME = N'Integral-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 100"
            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & ServidorMañongo & ";Initial Catalog=master;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ConProcesarModificacion.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "FrmMañongoExport", "Backup")
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Settings.ExportMañongoDirRestaurar & "Integral.bak") = True Then
                My.Computer.FileSystem.DeleteFile(My.Settings.ExportMañongoDirRestaurar & "Integral.bak")
            End If
            My.Computer.FileSystem.CopyFile(My.Settings.ExportMañongoDirBackup & "Integral.bak", My.Settings.ExportMañongoDirRestaurar & "Integral.bak")
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "FrmMañongoExport", "CopiarBackup")
        End Try

        Try
            StrSQL = "USE [master] ALTER DATABASE [Copy_Manongo] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [Copy_Manongo] FROM  DISK = N'C:\ProfitCompartido\BDManongoExportada\Integral.bak' WITH  FILE = 1,  MOVE N'Integral_Data' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Copy_Manongo.mdf',  MOVE N'Integral_Log' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Copy_Manongo_log.ldf',  NOUNLOAD,  REPLACE,  STATS = 100 ALTER DATABASE [Copy_Manongo] SET MULTI_USER"

            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=master;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ConProcesarModificacion.Close()
            ResultProcesarModificacion = 1
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "FrmMañongoExport", "Restaurar")
        End Try
        Try
            StrSQL = ""
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.antecedentelab "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.tratamiento "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ingreso "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.accidentelab "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.entornotrabajo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.servicioexterno "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consultarecdig "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.insumo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pacienterecdig "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.perfilservicio "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.perfilservint "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.cuenta "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.centrocosto "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.paciente "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.moneda "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.cita "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.perfilservext "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.tiporetencion "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.tasacambio "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.perfilinsumo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pagoscompra "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.aseguradoraempresa "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.medienvifact "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.astmprueba "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.astmresultado "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.clasifreposo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.notalarga "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.clasifdiagno "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ctacontable "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.astminforme "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.serviexteraplic "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.maestro "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.resultreubic "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.reubicacionlab "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.insumoaplicado "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pagosfactura "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.reubicacionlabresultado "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.empresa "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ingresorecdig "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.limitacion "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.diagnostico "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.profesion "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.limitacionLab "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.tipoantecedente "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consultadiagnostico "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pacienteant "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.limitaciones "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.antecedente "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.detallefactura "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.control "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ctabancaria "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.licencia "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.factservinte "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consultorio "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.factura "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.cheque "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.informemedicolibre "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.presentacion "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.notacredito "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.areanegocio "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.dosis "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.detallenotacredito "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.aseguradora "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.medicina "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ordenreferencia "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.examen "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.notadebito "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.listaresultado "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.presupuesto "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.detallenotadebito "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.grupoexamen "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.presupuestoservint "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.examegrupoexame "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consultorioempresa "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.presupuestoservext "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.proveedor "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.presupuestoinsumo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pacientefamiliar "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.usuario "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.pacientetipant "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.compromisopago "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.compra "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.centrosaludivss "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.compracomppago "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.zona "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.gruposervicio "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.diatrabajo "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.ciudad "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consulta "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.dependencia "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.serviinteraplic "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.consultaexamen "
            StrSQL = StrSQL + "ALTER SCHEMA DBO TRANSFER INTEGRAL.serviciointerno "


            Dim ConProcesarModificacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=Copy_Manongo;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            ConProcesarModificacion.Open()
            Dim ComandoProcesarModificaciones As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, ConProcesarModificacion)
            ComandoProcesarModificaciones.CommandType = CommandType.Text
            ComandoProcesarModificaciones.ExecuteNonQuery()
            ComandoProcesarModificaciones.Dispose()
            ConProcesarModificacion.Close()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "FrmMañongoExport", "CambiarEsquema")
        End Try

        MsgBox("Proceso Completado")

    End Sub
End Class