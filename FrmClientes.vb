Imports System.Data.SqlClient
Public Class FrmClientes
    Sub CargarDatos()
        If TXT_MED_HIS.Text = "" Then Exit Sub
        Try
            TXT_MED_APE.Text = ""
            TXT_MED_CED.Text = ""
            TXT_MED_DIR.Text = ""
            'TXT_MED_NAC.Text = ""
            TXT_MED_NOM.Text = ""
            TXT_MED_TLF.Text = ""
            TXT_PRO_COD.Text = ""
            TXT_PRO_DIR.Text = ""
            TXT_PRO_NOM.Text = ""
            TXT_PRO_TLF.Text = ""
            TXT_PRO_RIF.Text = ""

            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            StrSQL = "SELECT CEDULA,NOMBRE,APELLIDO,FECHANACIMIENTO,DIRECCIONCASA,TELEFONOCELULAR FROM " & BDEmpresaIntegral & "PACIENTE WHERE HISTORIA='" & TXT_MED_HIS.Text & "'"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                TXT_MED_APE.Text = Arreglo("APELLIDO")
                TXT_MED_CED.Text = Arreglo("CEDULA")
                TXT_MED_DIR.Text = Arreglo("DIRECCIONCASA")
                TXT_MED_NAC.Text = CDate(Arreglo("FECHANACIMIENTO")).ToShortDateString
                TXT_MED_NOM.Text = Arreglo("NOMBRE")
                TXT_MED_TLF.Text = Arreglo("TELEFONOCELULAR")
            End While
            con.Close()

            con.Open()
            StrSQL = "SELECT co_cli,ISNULL(direc1,'') direc1,cli_des,ISNULL(telefonos,'') telefonos  FROM sacliente WHERE rif='" & TXT_MED_CED.Text & "'"
            Dim CmdPro As SqlCommand = con.CreateCommand()

            CmdPro.CommandText = StrSQL
            Dim ArregloPro As SqlDataReader = CmdPro.ExecuteReader
            While ArregloPro.Read
                TXT_PRO_COD.Text = ArregloPro("co_cli")
                TXT_PRO_DIR.Text = ArregloPro("direc1")
                TXT_PRO_NOM.Text = ArregloPro("cli_des")
                TXT_PRO_TLF.Text = ArregloPro("telefonos")
                TXT_PRO_RIF.Text = TXT_MED_CED.Text

            End While
            con.Close()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.Message, Me.Name, "CargarDatos")
        End Try



    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FrmBuscarPaciente.TXT_PANTALLA.Text = Me.Name
        FrmBuscarPaciente.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("spQADP_ActualizaCliente", con)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0

        ComandoSql.Parameters.AddWithValue("@HISTORIA", TXT_MED_HIS.Text)
        ComandoSql.Parameters.AddWithValue("@NOMBRE", TXT_MED_NOM.Text)
        ComandoSql.Parameters.AddWithValue("@APELLIDO", TXT_MED_APE.Text)
        ComandoSql.Parameters.AddWithValue("@CEDULA", TXT_MED_CED.Text)
        ComandoSql.Parameters.AddWithValue("@TELEFONO", TXT_MED_TLF.Text)
        ComandoSql.Parameters.AddWithValue("@DIR", TXT_MED_DIR.Text)
        ComandoSql.Parameters.AddWithValue("@ACT_PROFIT", IIf(CheckBox1.Checked = True, 1, 0))
        ComandoSql.Parameters.AddWithValue("@USUARIO", Cod_Usuario)

        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value = 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Information, "Proceso Completado")
                TXT_MED_HIS.Text = ""
                TXT_MED_APE.Text = ""
                TXT_MED_CED.Text = ""
                TXT_MED_DIR.Text = ""
                'TXT_MED_NAC.Text = ""
                TXT_MED_NOM.Text = ""
                TXT_MED_TLF.Text = ""
                TXT_PRO_COD.Text = ""
                TXT_PRO_DIR.Text = ""
                TXT_PRO_NOM.Text = ""
                TXT_PRO_TLF.Text = ""
                TXT_PRO_RIF.Text = ""

            Else
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "GuardarRegistro")
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        TXT_MED_HIS.Text = ""
        TXT_MED_APE.Text = ""
        TXT_MED_CED.Text = ""
        TXT_MED_DIR.Text = ""
        ' TXT_MED_NAC.Text = ""
        TXT_MED_NOM.Text = ""
        TXT_MED_TLF.Text = ""
        TXT_PRO_COD.Text = ""
        TXT_PRO_DIR.Text = ""
        TXT_PRO_NOM.Text = ""
        TXT_PRO_TLF.Text = ""
        TXT_PRO_RIF.Text = ""
    End Sub
End Class