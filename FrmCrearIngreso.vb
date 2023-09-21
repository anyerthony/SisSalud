Imports System.Data.SqlClient

Public Class FrmCrearIngreso
    Dim DSServicio As Data.DataSet
    Dim AdaptadorServicio As System.Data.SqlClient.SqlDataAdapter
    Sub CargarMotivo()
        Try
            TXT_MOTIVO.Items.Clear()
            StrSQL = "select distinct codmotivcons from ingreso order by codmotivcons"
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                TXT_MOTIVO.Items.Add(Arreglo("codmotivcons"))
            End While
            TXT_MOTIVO.Items.Add("")
        Catch ex As Exception

        End Try

    End Sub
    Sub CargarDoctores()
        Try
            TXT_DOCTOR.Items.Clear()
            StrSQL = "select username from usuario where codperfil='Doctor' and codstatus='Activo' and cod_consulto='" & PAR_COD_CONSULTORIO & "' order by username"
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                TXT_DOCTOR.Items.Add(Arreglo("username"))
            End While
            TXT_DOCTOR.Items.Add("")
        Catch ex As Exception

        End Try

    End Sub
    Sub CargarServicio()
        StrSQL = "SELECT codigo,nombre FROM serviciointerno  WHERE codstatus='ACTIVO' AND cod_empresa='1147' AND codtipo='Consulta' order by nombre"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim comandoCondicio As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoCondicio.CommandType = CommandType.Text
        AdaptadorServicio = New System.Data.SqlClient.SqlDataAdapter(comandoCondicio)
        DSServicio = New Data.DataSet("Servicio")
        AdaptadorServicio.Fill(DSServicio, "Servicio")
        TXT_SERVICIOS.DataSource = DSServicio.Tables("Servicio")
        TXT_SERVICIOS.ValueMember = "codigo"
        TXT_SERVICIOS.DisplayMember = "nombre"
    End Sub

    Private Sub FrmCrearIngreso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cod_Usuario = Mid(My.User.Name, 1, 50)
        CargarMotivo()
        CargarDoctores()
        CargarServicio()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        'Try
        '    StrSQL = "EXEC prQADP_ProbarConexion '" & My.Settings.ServidorSedeCentral & "'"
        '    Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        '    Dim cmd As SqlCommand = con.CreateCommand()
        '    con.Open()
        '    cmd.CommandText = StrSQL
        '    Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        '    While Arreglo.Read
        '        If Arreglo("Result") = 1 Then
        '            FrmBuscarPacienteAgotamiento.TXT_NAC.Text = "V"
        '            FrmBuscarPacienteAgotamiento.ShowDialog()
        '            Exit Sub
        '        End If
        '    End While
        'Catch ex As Exception
        'End Try

        FrmBuscarPacienteAgotamiento.TXT_NAC.Text = "V"
        FrmBuscarPacienteAgotamiento.ShowDialog()
        Exit Sub
        With FrmBuscarPaciente
            .TXT_BUSCAR.Text = ""
            .GRID.Rows.Clear()
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        ComandoSql = New SqlClient.SqlCommand("prQADP_CrearIngreso", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@COD_PACIENTE", TXT_COD_PACIENTE.Text)
        ComandoSql.Parameters.AddWithValue("@CODMOTIVO", TXT_MOTIVO.Text)
        ComandoSql.Parameters.AddWithValue("@claveasegura", TXT_CLAVE.Text)
        ComandoSql.Parameters.AddWithValue("@COD_CONSULTO", PAR_COD_CONSULTORIO)
        ComandoSql.Parameters.AddWithValue("@COD_ASEGURADORA", PAR_COD_ASEGURADORA)
        ComandoSql.Parameters.AddWithValue("@DOCTOR", TXT_DOCTOR.Text)
        ComandoSql.Parameters.AddWithValue("@COD_SERVICIO", TXT_SERVICIOS.SelectedValue)

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                TXT_CLAVE.Text = ""
                TXT_COD_PACIENTE.Text = ""
                TXT_MOTIVO.Text = ""
                TXT_NOM_PACIENTE.Text = ""
                TXT_DOCTOR.Text = ""
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso Completado")
            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub
End Class
