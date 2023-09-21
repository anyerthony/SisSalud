Imports System.Data.SqlClient

Public Class FrmPaciente
    Dim cargando As Integer
    Dim guardando As Integer
    Dim tablaPaciente As New DataTable
    Dim tabla_antLab As New DataTable
    Dim tabla_antLab_riesgos As New DataTable
    Dim tabla_antLab_equipos As New DataTable

    Dim cantidadTrabajos As Integer = 1



    Dim DS_foto As Data.DataSet
    Dim AdaptadorTab_foto As System.Data.SqlClient.SqlDataAdapter
    Dim cb_foto As System.Data.SqlClient.SqlCommandBuilder
    Dim bs_foto As New BindingSource

    Dim DS_ci As Data.DataSet
    Dim AdaptadorTab_ci As System.Data.SqlClient.SqlDataAdapter
    Dim cb_ci As System.Data.SqlClient.SqlCommandBuilder
    Dim bs_ci As New BindingSource




    Private Sub guardar()
        guardando = 1

        For i = 0 To tablaPaciente.Columns.Count - 1
            tablaPaciente.Columns(i).ReadOnly = False
            tablaPaciente.Columns(i).AllowDBNull = True
        Next

        Try

            tablaPaciente.Rows.Clear()
            tablaPaciente.Rows.Add()
            Dim rowPaciente As DataRow = tablaPaciente.Rows(0)
            rowPaciente.Item("id") = IIf(TXT_ID_CLIENTE.Text = "", DBNull.Value, TXT_ID_CLIENTE.Text)
            rowPaciente.Item("nombre") = TXT_NOMBRE.Text
            rowPaciente.Item("apellido") = TXT_APELLIDO.Text
            rowPaciente.Item("ci") = TXT_CI.Text
            rowPaciente.Item("correo") = TXT_CORREO.Text
            rowPaciente.Item("tlfn") = TXT_TLFN.Text
            rowPaciente.Item("tlfn_local") = TXT_TLFN_LOCAL.Text
            rowPaciente.Item("dir") = TXT_DIRECCION.Text
            rowPaciente.Item("id_foto") = IIf(TXT_ID_FOTO.Text = "", DBNull.Value, TXT_ID_FOTO.Text)
            rowPaciente.Item("id_ci") = IIf(TXT_ID_CI.Text = "", DBNull.Value, TXT_ID_CI.Text)
            rowPaciente.Item("historia") = TXT_RESUMEN_CLINICO.Text
            rowPaciente.Item("fecha_nacimiento") = TXT_FECHA.Text
            rowPaciente.Item("numero_hijos") = IIf(TXT_HIJOS.Text = "", 0, TXT_HIJOS.Text)
            rowPaciente.Item("status") = CK_STATUS.Checked


            rowPaciente.Item("id_pais") = IIf(LISTA_PAISES.SelectedIndex = -1, DBNull.Value, LISTA_PAISES.SelectedValue)
            rowPaciente.Item("id_zona") = IIf(LISTA_ZONAS.SelectedIndex = -1, DBNull.Value, LISTA_ZONAS.SelectedValue)
            rowPaciente.Item("id_ciudad") = IIf(LISTA_CIUDADES.SelectedIndex = -1, DBNull.Value, LISTA_CIUDADES.SelectedValue)
            rowPaciente.Item("sexo") = LISTA_SEXO.SelectedValue
            rowPaciente.Item("grupo_sanguineo") = LISTA_SANGRE.SelectedValue
            rowPaciente.Item("id_nivel_educativo") = IIf(LISTA_EDUCA.SelectedIndex = -1, DBNull.Value, LISTA_EDUCA.SelectedValue)
            rowPaciente.Item("lateralidad") = LISTA_LATERAL.SelectedValue
            rowPaciente.Item("id_profesion") = IIf(LISTA_PROF.SelectedIndex = -1, DBNull.Value, LISTA_PROF.SelectedValue)
            rowPaciente.Item("estado_civil") = LISTA_CIVIL.SelectedValue



            Dim spGuardar As New SPEjecutable("usp_guardarPaciente")

            Dim TablaGrid As New DataTable
            Try
                TablaGrid.Columns.Clear()
            Catch ex As Exception


            End Try
            TablaGrid.Columns.Add("id", GetType(Integer))
            TablaGrid.Columns.Add("id_antecedente", GetType(Integer))
            TablaGrid.Columns.Add("observacion", GetType(String))

            Dim I As Integer


            For I = 0 To GRID_ANTECEDENTES_MEDICOS.Rows.Count - 1
                TablaGrid.Rows.Add(GRID_ANTECEDENTES_MEDICOS.Item(0, I).Value, GRID_ANTECEDENTES_MEDICOS.Item(1, I).Value, GRID_ANTECEDENTES_MEDICOS.Item(4, I).Value)
            Next




            Dim parRiesgos As New DataTable
            Dim parEquipos As New DataTable

            Try
                parRiesgos.Columns.Clear()
                parEquipos.Columns.Clear()
            Catch ex As Exception
            End Try
            Try

                parEquipos.Columns.Clear()
            Catch ex As Exception
            End Try

            parRiesgos.Columns.Add("id", GetType(Integer))
            parRiesgos.Columns.Add("id_antecedente", GetType(Integer))
            parRiesgos.Columns.Add("id_riesgo", GetType(Integer))
            parRiesgos.Columns.Add("reng_num", GetType(Integer))
            parRiesgos.Columns.Add("observacion", GetType(String))

            parEquipos.Columns.Add("id", GetType(Integer))
            parEquipos.Columns.Add("id_antecedente", GetType(Integer))
            parEquipos.Columns.Add("id_equipo", GetType(Integer))
            parEquipos.Columns.Add("reng_num", GetType(Integer))
            parEquipos.Columns.Add("observacion", GetType(String))


            For I = 0 To tabla_antLab_riesgos.Rows.Count - 1
                parRiesgos.Rows.Add(tabla_antLab_riesgos.Rows(I).Item("id"), tabla_antLab_riesgos.Rows(I).Item("id_antecedente"), tabla_antLab_riesgos.Rows(I).Item("id_riesgo"), tabla_antLab_riesgos.Rows(I).Item("reng_num"), tabla_antLab_riesgos.Rows(I).Item("observacion"))
            Next
            For I = 0 To tabla_antLab_equipos.Rows.Count - 1
                parEquipos.Rows.Add(tabla_antLab_equipos.Rows(I).Item("id"), tabla_antLab_equipos.Rows(I).Item("id_antecedente"), tabla_antLab_equipos.Rows(I).Item("id_equipo"), tabla_antLab_equipos.Rows(I).Item("reng_num"), tabla_antLab_equipos.Rows(I).Item("observacion"))
            Next




            spGuardar.ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
            spGuardar.ComandoSql.Parameters.AddWithValue("@ANTEDENTES_MEDICOS", TablaGrid)
            spGuardar.ComandoSql.Parameters.AddWithValue("@ANTEDENTES_LABORALES", tabla_antLab)
            spGuardar.ComandoSql.Parameters.AddWithValue("@RIESGOS", parRiesgos)
            spGuardar.ComandoSql.Parameters.AddWithValue("@EQUIPOS", parEquipos)
            spGuardar.ComandoSql.Parameters.AddWithValue("@PACIENTE", tablaPaciente)


            spGuardar.Ejecutar()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Guardar paciente")
        End Try


        Try
            bs_ci.EndEdit()
            AdaptadorTab_ci.Update(DS_ci, "Imagen")

            DS_ci.Tables("Imagen").Clear()
            AdaptadorTab_ci.Fill(DS_ci, "Imagen")

            bs_foto.EndEdit()
            AdaptadorTab_foto.Update(DS_foto, "Imagen")

            DS_foto.Tables("Imagen").Clear()
            AdaptadorTab_foto.Fill(DS_foto, "Imagen")
            guardando = 0
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Guardar Imagenes")
            Exit Sub
        End Try

    End Sub

    Private Sub validarCambios()

    End Sub

    Sub cargarListas()
        Try
            Dim tablaPaises As New DataTable
            tablaPaises = SelectSQL("select id, nombre from PAISES order by nombre")
            LISTA_PAISES.DataSource = tablaPaises
            LISTA_PAISES.SelectedIndex = -1

            Dim tablaZonas As New DataTable
            tablaZonas = SelectSQL("select id, nombre from ZONAS order by nombre")
            LISTA_ZONAS.DataSource = tablaZonas
            LISTA_ZONAS.SelectedIndex = -1

            Dim tablaCiudades As New DataTable
            tablaCiudades = SelectSQL("select id, nombre from CIUDADES order by nombre")
            LISTA_CIUDADES.DataSource = tablaCiudades
            LISTA_CIUDADES.SelectedIndex = -1

            Dim tablaNivelesEducativos As New DataTable
            tablaNivelesEducativos = SelectSQL("select id, nombre from NIVELES_EDUCATIVOS order by nombre")
            LISTA_EDUCA.DataSource = tablaNivelesEducativos
            LISTA_EDUCA.SelectedIndex = -1

            Dim tablaProfesiones As New DataTable
            tablaProfesiones = SelectSQL("select id, nombre from PROFESIONES order by nombre")
            LISTA_PROF.DataSource = tablaProfesiones
            LISTA_PROF.SelectedIndex = -1

            Dim tablaSexo As New DataTable
            tablaSexo = SelectSQL("select valor, nombre from vSEXO order by nombre")
            LISTA_SEXO.DataSource = tablaSexo
            LISTA_SEXO.SelectedIndex = -1

            Dim tablaSangre As New DataTable
            tablaSangre = SelectSQL("select tipo from vTIPOS_SANGRE order by 1")
            LISTA_SANGRE.DataSource = tablaSangre
            LISTA_SANGRE.SelectedIndex = -1

            Dim tablaLateralidades As New DataTable
            tablaLateralidades = SelectSQL("select tipo from vLATERALIDADES order by orden")
            LISTA_LATERAL.DataSource = tablaLateralidades
            LISTA_LATERAL.SelectedIndex = -1

            Dim tablaCivil As New DataTable
            tablaCivil = SelectSQL("select nombre from vESTADO_CIVIL order by 1")
            LISTA_CIVIL.DataSource = tablaCivil
            LISTA_CIVIL.SelectedIndex = -1
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Pacientes", "Cargar Listas")
        End Try

    End Sub

    Private Sub FrmPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()


        GRID_ANTECEDENTES_LABORALES.DataSource = tabla_antLab


        tabla_antLab.Columns.Add("reng_num", GetType(Integer))
        tabla_antLab.Columns.Add("id", GetType(Integer))
        tabla_antLab.Columns.Add("Actual", GetType(Boolean))
        tabla_antLab.Columns.Add("Empresa", GetType(String))
        tabla_antLab.Columns.Add("duracion", GetType(String))
        tabla_antLab.Columns.Add("horario", GetType(String))
        tabla_antLab.Columns.Add("industria", GetType(String))
        tabla_antLab.Columns.Add("problemas_salud", GetType(String))
        tabla_antLab.Columns.Add("accidente_laboral", GetType(String))
        tabla_antLab.Columns.Add("enfermedad_ocupacional", GetType(String))
        tabla_antLab.Columns.Add("observacion", GetType(String))
        tabla_antLab.Columns.Add("descripcion_cargo", GetType(String))
        tabla_antLab.Columns.Add("cond_ambi", GetType(String))
        tabla_antLab.Columns.Add("cond_activ", GetType(String))
        tabla_antLab.Columns.Add("cond_carga", GetType(String))
        tabla_antLab.Columns.Add("cond_riesgo", GetType(String))
        tabla_antLab.Columns.Add("cargo", GetType(String))


        tabla_antLab_riesgos.Columns.Add("id", GetType(Integer))
        tabla_antLab_riesgos.Columns.Add("id_antecedente", GetType(Integer))
        tabla_antLab_riesgos.Columns.Add("id_riesgo", GetType(Integer))
        tabla_antLab_riesgos.Columns.Add("nombre", GetType(String))
        tabla_antLab_riesgos.Columns.Add("tipo", GetType(String))
        tabla_antLab_riesgos.Columns.Add("reng_num", GetType(Integer))
        tabla_antLab_riesgos.Columns.Add("observacion", GetType(String))

        tabla_antLab_equipos.Columns.Add("id", GetType(Integer))
        tabla_antLab_equipos.Columns.Add("id_antecedente", GetType(Integer))
        tabla_antLab_equipos.Columns.Add("id_equipo", GetType(Integer))
        tabla_antLab_equipos.Columns.Add("nombre", GetType(String))
        tabla_antLab_equipos.Columns.Add("reng_num", GetType(Integer))
        tabla_antLab_equipos.Columns.Add("observacion", GetType(String))



        Dim columna As New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        columna.Name = "detalles"
        columna.HeaderText = "Detalles"
        columna.Width = 50
        'GRID_ANTECEDENTES_LABORALES.Columns.Insert(17, columna)

        GRID_ANTECEDENTES_LABORALES.Columns.Add(columna)

        For i = 0 To GRID_ANTECEDENTES_LABORALES.Columns.Count - 1
            Dim li As New ArrayList
            li.Add("Actual")
            li.Add("Empresa")
            li.Add("detalles")
            'li.Add("reng_num")


            If li.Contains(GRID_ANTECEDENTES_LABORALES.Columns(i).Name) Then Continue For
            GRID_ANTECEDENTES_LABORALES.Columns(i).Visible = False
        Next
        GRID_ANTECEDENTES_LABORALES.Columns("Actual").Width = 50
        GRID_ANTECEDENTES_LABORALES.Columns("Empresa").Width = 200
        GRID_ANTECEDENTES_LABORALES.Columns("detalles").Width = 50
        GRID_ANTECEDENTES_LABORALES.Columns("reng_num").Width = 50

        tablaPaciente = SelectSQL("SELECT * FROM PACIENTES WHERE ID = 0")


    End Sub

    Sub cargarAntecedentesMedicos()
        GRID_ANTECEDENTES_MEDICOS.Rows.Clear()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = "SELECT  a.id id,a.id_antecedente, b.nombre nombre_antecedente,A.observacion, C.nombre tipo_antecedente FROM PACIENTES_ANTECEDENTES_MEDICOS A INNER JOIN ANTECEDENTES_MEDICOS B ON A.id_antecedente = B.id INNER JOIN TIPO_ANTECEDENTE_MEDICO C ON B.id_tipo = C.id where a.id_cliente = " & TXT_ID_CLIENTE.Text
        Dim cmd As SqlCommand = con.CreateCommand()

        cmd.CommandText = StrSQL
        cmd.CommandTimeout = 0
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_ANTECEDENTES_MEDICOS.Rows.Add(Arreglo("id"), Arreglo("id_antecedente"), Arreglo("nombre_antecedente"), Arreglo("tipo_antecedente"), Arreglo("observacion"))
            'tb.Rows.Add(Trim(Arreglo("co_art")), Trim(Arreglo("art_des")))
        End While
    End Sub

    Sub guardarAntecedentesMedicos()
        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()

        Dim TablaGrid As New DataTable
        Try
            TablaGrid.Columns.Clear()
        Catch ex As Exception


        End Try
        TablaGrid.Columns.Add("id", GetType(Integer))
        TablaGrid.Columns.Add("id_antecedente", GetType(Integer))
        TablaGrid.Columns.Add("observacion", GetType(String))

        Dim I As Integer


        For I = 0 To GRID_ANTECEDENTES_MEDICOS.Rows.Count - 1
            TablaGrid.Rows.Add(GRID_ANTECEDENTES_MEDICOS.Item(0, I).Value, GRID_ANTECEDENTES_MEDICOS.Item(1, I).Value, GRID_ANTECEDENTES_MEDICOS.Item(4, I).Value)
        Next


        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        'Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("usp_guardarAntecedentesMedicos", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        'ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.AddWithValue("@ANTEDENTES", TablaGrid)
        ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@ID_CLIENTE", TXT_ID_CLIENTE.Text)



        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                Exit Sub
            End If

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Guardar Antecedentes Medicos")
            Exit Sub
        End Try
        TablaGrid.Rows.Clear()


    End Sub

    Sub cargarAntecedentesLaborales()
        cantidadTrabajos = 1
        'GRID_ANTECEDENTES_LABORALES.Rows.Clear()
        Try
            tabla_antLab.Rows.Clear()
        Catch ex As Exception

        End Try

        Try
            tabla_antLab_riesgos.Rows.Clear()
        Catch ex As Exception

        End Try


        Try
            tabla_antLab_equipos.Rows.Clear()
        Catch ex As Exception

        End Try

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = "SELECT * FROM PACIENTES_ANTECEDENTES_LABORALES where id_cliente = " & TXT_ID_CLIENTE.Text
        Dim cmd As SqlCommand = con.CreateCommand()

        cmd.CommandText = StrSQL
        cmd.CommandTimeout = 0
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            'GRID_ANTECEDENTES_LABORALES.Rows.Add(Arreglo("id"), Arreglo("actual"), Arreglo("empresa"))
            tabla_antLab.Rows.Add(cantidadTrabajos, Arreglo("id"), Arreglo("actual"), Arreglo("empresa"), Arreglo("duracion"), Arreglo("horario"), Arreglo("industria"), Arreglo("problemas_salud"), Arreglo("accidente_laboral"), Arreglo("enfermedad_ocupacional"), Arreglo("observacion"), Arreglo("descripcion_cargo"), Arreglo("cond_ambi"), Arreglo("cond_activ"), Arreglo("cond_carga"), Arreglo("cond_riesgo"), Arreglo("cargo"))
            cantidadTrabajos = cantidadTrabajos + 1
        End While
        con.Close()

        con.Open()
        StrSQL = "SELECT A.id,A.id_antecedente,A.id_riesgo,B.nombre,C.nombre tipo,a.observacion FROM RIESGOS_ANTECEDENTE_LABORAL A INNER JOIN RIESGOS_LABORALES B ON A.id_riesgo = B.id INNER JOIN CLASIFICACION_RIESGO_LABORAL C ON B.id_clasificacion = c.id where id_antecedente in (select x.id from PACIENTES_ANTECEDENTES_LABORALES x where id_cliente = " & TXT_ID_CLIENTE.Text & ")"
        cmd.CommandText = StrSQL
        Arreglo = cmd.ExecuteReader
        While Arreglo.Read
            tabla_antLab_riesgos.Rows.Add(Arreglo("id"), Arreglo("id_antecedente"), Arreglo("id_riesgo"), Arreglo("tipo"), Arreglo("nombre"), 0, Arreglo("observacion"))
        End While
        con.Close()

        con.Open()
        StrSQL = "SELECT B.id, B.id_antecedente,B.id_equipo,C.nombre,B.observacion FROM PACIENTES_ANTECEDENTES_LABORALES A INNER JOIN EQUIPOS_ANTECEDENTE_LABORAL B ON A.id=B.id_antecedente INNER JOIN EQUIPOS_LABORALES C ON B.id_equipo = C.id WHERE id_cliente = " & TXT_ID_CLIENTE.Text
        cmd.CommandText = StrSQL
        Arreglo = cmd.ExecuteReader
        While Arreglo.Read
            tabla_antLab_equipos.Rows.Add(Arreglo("id"), Arreglo("id_antecedente"), Arreglo("id_equipo"), Arreglo("nombre"), 0, Arreglo("observacion"))
        End While
        con.Close()


        For i = 0 To tabla_antLab.Rows.Count - 1
            Dim reng_num As Integer = tabla_antLab.Rows(i).Item("reng_num")
            Dim idi As Integer = tabla_antLab.Rows(i).Item("id")

            For j = 0 To tabla_antLab_riesgos.Rows.Count - 1
                If tabla_antLab_riesgos.Rows(j).Item("id_antecedente") = idi Then
                    tabla_antLab_riesgos.Rows(j).Item("reng_num") = reng_num
                End If
            Next

            For j = 0 To tabla_antLab_equipos.Rows.Count - 1
                If tabla_antLab_equipos.Rows(j).Item("id_antecedente") = idi Then
                    tabla_antLab_equipos.Rows(j).Item("reng_num") = reng_num
                End If
            Next
        Next




    End Sub

    Sub guardarAntecedentesLaborales()
        Dim ConValidacion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        ConValidacion.Open()

        Dim parRiesgos As New DataTable
        Dim parEquipos As New DataTable

        Try
            parRiesgos.Columns.Clear()
            parEquipos.Columns.Clear()
        Catch ex As Exception
        End Try
        Try

            parEquipos.Columns.Clear()
        Catch ex As Exception
        End Try

        parRiesgos.Columns.Add("id", GetType(Integer))
        parRiesgos.Columns.Add("id_antecedente", GetType(Integer))
        parRiesgos.Columns.Add("id_riesgo", GetType(Integer))
        parRiesgos.Columns.Add("reng_num", GetType(Integer))
        parRiesgos.Columns.Add("observacion", GetType(String))

        parEquipos.Columns.Add("id", GetType(Integer))
        parEquipos.Columns.Add("id_antecedente", GetType(Integer))
        parEquipos.Columns.Add("id_equipo", GetType(Integer))
        parEquipos.Columns.Add("reng_num", GetType(Integer))
        parEquipos.Columns.Add("observacion", GetType(String))


        For i = 0 To tabla_antLab_riesgos.Rows.Count - 1
            parRiesgos.Rows.Add(tabla_antLab_riesgos.Rows(i).Item("id"), tabla_antLab_riesgos.Rows(i).Item("id_antecedente"), tabla_antLab_riesgos.Rows(i).Item("id_riesgo"), tabla_antLab_riesgos.Rows(i).Item("reng_num"), tabla_antLab_riesgos.Rows(i).Item("observacion"))
        Next
        For i = 0 To tabla_antLab_equipos.Rows.Count - 1
            parEquipos.Rows.Add(tabla_antLab_equipos.Rows(i).Item("id"), tabla_antLab_equipos.Rows(i).Item("id_antecedente"), tabla_antLab_equipos.Rows(i).Item("id_equipo"), tabla_antLab_equipos.Rows(i).Item("reng_num"), tabla_antLab_equipos.Rows(i).Item("observacion"))
        Next


        'Dim I As Integer


        'For I = 0 To GRID_ANTECEDENTES_LABORALES.Rows.Count - 1
        '    TablaGrid.Rows.Add()
        'Next


        Dim ComandoSql As System.Data.SqlClient.SqlCommand
        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & My.Settings.BaseDatos & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim ParametroOutStatus = New SqlParameter("@STATUS", SqlDbType.Int) : ParametroOutStatus.Direction = ParameterDirection.Output
        Dim ParametroOutResultado = New SqlParameter("@RESULTADO", SqlDbType.VarChar, 2500) : ParametroOutResultado.Direction = ParameterDirection.Output
        'Dim ParametroOutNumDoc = New SqlParameter("@NUM_DOC", SqlDbType.VarChar, 2500) : ParametroOutNumDoc.Direction = ParameterDirection.Output

        ComandoSql = New SqlClient.SqlCommand("usp_guardarAntecedentesLaborales", ConValidacion)
        ComandoSql.CommandType = CommandType.StoredProcedure
        ComandoSql.CommandTimeout = 0
        ComandoSql.Parameters.Add(ParametroOutStatus)
        ComandoSql.Parameters.Add(ParametroOutResultado)
        'ComandoSql.Parameters.Add(ParametroOutNumDoc)
        ComandoSql.Parameters.AddWithValue("@ANTEDENTES", tabla_antLab)
        ComandoSql.Parameters.AddWithValue("@RIESGOS", parRiesgos)
        ComandoSql.Parameters.AddWithValue("@EQUIPOS", parEquipos)
        ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        ComandoSql.Parameters.AddWithValue("@ID_CLIENTE", TXT_ID_CLIENTE.Text)



        If ConValidacion.State = ConnectionState.Closed Then
            ConValidacion.Open()
        End If

        Try
            ComandoSql.ExecuteNonQuery()
            If ParametroOutStatus.Value <> 1 Then
                MsgBox(ParametroOutResultado.Value, MsgBoxStyle.Critical, "Proceso no Completado")
                Exit Sub
            End If

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Guardar Antecedentes Laborales")
            Exit Sub
        End Try
        parRiesgos.Rows.Clear()

    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        If TXT_ID_CLIENTE.Text = "" Then Exit Sub
        Dim spEliminar As New SPEjecutable("usp_eliminarPaciente")
        spEliminar.ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        spEliminar.ComandoSql.Parameters.AddWithValue("@ID_PACIENTE", TXT_ID_CLIENTE.Text)

        spEliminar.Ejecutar()
        If spEliminar.ParametroOutStatus.Value = 1 Then
            limpiar()
        End If
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        validarCambios()
        limpiar()
    End Sub
    Sub limpiar()
        TXT_ID_CLIENTE.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_APELLIDO.Text = ""
        TXT_CI.Text = ""
        TXT_CORREO.Text = ""
        TXT_TLFN.Text = ""
        TXT_TLFN_LOCAL.Text = ""
        TXT_DIRECCION.Text = ""
        TXT_ID_FOTO.Text = ""
        TXT_ID_CI.Text = ""
        TXT_RESUMEN_CLINICO.Text = ""
        TXT_FECHA.Text = ""
        TXT_HIJOS.Text = ""
        CK_STATUS.Checked = True


        asegnarValor(LISTA_PAISES, "")
        asegnarValor(LISTA_ZONAS, "")
        asegnarValor(LISTA_CIUDADES, "")
        asegnarValor(LISTA_SEXO, "")
        asegnarValor(LISTA_SANGRE, "")
        asegnarValor(LISTA_EDUCA, "")
        asegnarValor(LISTA_LATERAL, "")
        asegnarValor(LISTA_PROF, "")
        asegnarValor(LISTA_CIVIL, "")

        
        tablaPaciente.Rows.Clear()
        tabla_antLab.Rows.Clear()
        tabla_antLab_riesgos.Rows.Clear()
        tabla_antLab_equipos.Rows.Clear()

        GRID_ANTECEDENTES_MEDICOS.Rows.Clear()

        IMG_FOTO.Image = Nothing
        IMG_CI.Image = Nothing


    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        guardar()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        'validarCambios()
        'botonera.Buscar()
        buscar()

    End Sub


    Sub cargarPaciente(ByVal id As String)
        Try
            tablaPaciente = SelectSQL("select * from PACIENTES where id = " & id)
            If tablaPaciente.Rows.Count = 0 Then Exit Sub
            Dim rowPaciente As DataRow = tablaPaciente.Rows(0)

            TXT_ID_CLIENTE.Text = rowPaciente.Item("id")
            TXT_NOMBRE.Text = rowPaciente.Item("nombre").ToString
            TXT_APELLIDO.Text = rowPaciente.Item("apellido").ToString
            TXT_CI.Text = rowPaciente.Item("ci").ToString
            TXT_CORREO.Text = rowPaciente.Item("correo").ToString
            TXT_TLFN.Text = rowPaciente.Item("tlfn").ToString
            TXT_TLFN_LOCAL.Text = rowPaciente.Item("tlfn_local").ToString
            TXT_DIRECCION.Text = rowPaciente.Item("dir").ToString
            TXT_ID_FOTO.Text = rowPaciente.Item("id_foto").ToString
            TXT_ID_CI.Text = rowPaciente.Item("id_ci").ToString
            TXT_RESUMEN_CLINICO.Text = rowPaciente.Item("historia").ToString
            TXT_FECHA.Text = rowPaciente.Item("fecha_nacimiento").ToString
            TXT_HIJOS.Text = rowPaciente.Item("numero_hijos").ToString
            CK_STATUS.Checked = rowPaciente.Item("status").ToString

 
            asegnarValor(LISTA_PAISES, rowPaciente.Item("id_pais"))
            asegnarValor(LISTA_ZONAS, rowPaciente.Item("id_zona"))
            asegnarValor(LISTA_CIUDADES, rowPaciente.Item("id_ciudad"))
            asegnarValor(LISTA_SEXO, rowPaciente.Item("sexo"))
            asegnarValor(LISTA_SANGRE, rowPaciente.Item("grupo_sanguineo"))
            asegnarValor(LISTA_EDUCA, rowPaciente.Item("id_nivel_educativo"))
            asegnarValor(LISTA_LATERAL, rowPaciente.Item("lateralidad"))
            asegnarValor(LISTA_PROF, rowPaciente.Item("id_profesion"))
            asegnarValor(LISTA_CIVIL, rowPaciente.Item("estado_civil"))



            cargarImagen_foto(TXT_ID_FOTO.Text)
            cargarImagen_ci(TXT_ID_CI.Text)

            cargarAntecedentesMedicos()
            cargarAntecedentesLaborales()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Cargar paciente")
        End Try


    End Sub

    Sub asegnarValor(ByRef LISTA As DevComponents.DotNetBar.Controls.ComboBoxEx, ByVal valor As Object)
        If valor.ToString = "" Then
            LISTA.SelectedIndex = -1
        Else
            LISTA.SelectedValue = valor
        End If
    End Sub

    Sub cargarImagen_foto(ByVal id As String)
        Try
            If id.Length = 0 Then
                id = 0
            End If


            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & "_FILES;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim comandoSQLimagen As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT id,archivo FROM ARCHIVOS where id=" & id, con)
            AdaptadorTab_foto = New System.Data.SqlClient.SqlDataAdapter(comandoSQLimagen)
            DS_foto = New Data.DataSet("Imagen")

            AdaptadorTab_foto.Fill(DS_foto, "Imagen")
            bs_foto.DataSource = DS_foto.Tables("Imagen")

            IMG_FOTO.DataBindings.Clear()
            IMG_FOTO.DataBindings.Add("Image", bs_foto, "archivo", True, DataSourceUpdateMode.OnValidation)

            cb_foto = New System.Data.SqlClient.SqlCommandBuilder(AdaptadorTab_foto)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Cargar")
        End Try
    End Sub

    Sub cargarImagen_ci(ByVal id As String)
        Try
            If id.Length = 0 Then
                id = 0
            End If


            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & "_FILES;User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim comandoSQLimagen As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT id,archivo FROM ARCHIVOS where id=" & id, con)
            AdaptadorTab_ci = New System.Data.SqlClient.SqlDataAdapter(comandoSQLimagen)
            DS_ci = New Data.DataSet("Imagen")

            AdaptadorTab_ci.Fill(DS_ci, "Imagen")
            bs_ci.DataSource = DS_ci.Tables("Imagen")

            IMG_CI.DataBindings.Clear()
            IMG_CI.DataBindings.Add("Image", bs_ci, "archivo", True, DataSourceUpdateMode.OnValidation)

            cb_ci = New System.Data.SqlClient.SqlCommandBuilder(AdaptadorTab_ci)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Cargar")
        End Try
    End Sub


    Sub buscar()
        Dim busqueda As New FrmBusquedaQry("id,isnull(nombre,'')+' '+isnull(apellido,'') nombre,ci", "PACIENTES", "nombre", "ci", ordenPR:="nombre")
        busqueda.WidthColumnas.Add(1, 200)
        busqueda.WidthColumnas.Add(2, 60)
        busqueda.WidthColumnas.Add(0, 0)

        'busqueda.GRID.Columns(0).Visible = False
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub

        cargarPaciente(resultado(0))
    End Sub



    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        CK_STATUS.Checked = Not CK_STATUS.Checked
        guardar()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_STATUS.CheckedChanged
        ButtonX1.Tooltip = IIf(CK_STATUS.Checked, "Desactivar", "Activar")
        ButtonX1.Symbol = IIf(CK_STATUS.Checked, ChrW("&Hf05d"), ChrW("&Hf05c"))

        L_INACTIVO.Visible = Not CK_STATUS.Checked
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If TXT_ID_FOTO.Text = "" Then
            TXT_ID_FOTO.Text = GenerarIdArchivo()
            cargarImagen_foto(TXT_ID_FOTO.Text)
        End If

        Try
            OpenFileDialog1.Filter = "Archivos JPG|*.jpg"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                IMG_FOTO.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "SeleccionarImagen")
        End Try

    End Sub



    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        If TXT_ID_CI.Text = "" Then
            TXT_ID_CI.Text = GenerarIdArchivo()
            cargarImagen_ci(TXT_ID_CI.Text)
        End If

        Try
            OpenFileDialog1.Filter = "Archivos JPG|*.jpg"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                IMG_CI.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "SeleccionarImagen")
        End Try
    End Sub



    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        IMG_FOTO.Image = Nothing
    End Sub


    Private Sub TXT_ID_BAREMO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub



    Private Sub ButtonX4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        IMG_CI.Image = Nothing
    End Sub

    Private Sub GRID_ANTECEDENTES_MEDICOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ANTECEDENTES_MEDICOS.CellDoubleClick
        If e.ColumnIndex = 4 Then
            GRID_ANTECEDENTES_MEDICOS.Item(e.ColumnIndex, e.RowIndex).Value = Expandir(GRID_ANTECEDENTES_MEDICOS.Item(e.ColumnIndex, e.RowIndex).Value, GRID_ANTECEDENTES_MEDICOS.Columns(e.ColumnIndex).Name)
        End If
    End Sub



    Private Sub GRID_ANTECEDENTES_MEDICOS_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ANTECEDENTES_MEDICOS.CellValueChanged
        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then
            buscarAntecedenteMedico(GRID_ANTECEDENTES_MEDICOS.Item(e.ColumnIndex, e.RowIndex).Value, e.RowIndex)
        End If
    End Sub
    Sub buscarAntecedenteMedico(ByVal id As Integer, ByVal row As Integer)
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()
        StrSQL = "SELECT A.nombre nombre_antecedente,B.nombre tipo_antecedente FROM ANTECEDENTES_MEDICOS A INNER JOIN TIPO_ANTECEDENTE_MEDICO B ON A.id_tipo = B.id WHERE A.ID = " & id
        Dim cmd As SqlCommand = con.CreateCommand()
        cmd.CommandText = StrSQL
        cmd.CommandTimeout = 0
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            GRID_ANTECEDENTES_MEDICOS.Item(2, row).Value = Arreglo("nombre_antecedente")
            GRID_ANTECEDENTES_MEDICOS.Item(3, row).Value = Arreglo("tipo_antecedente")
        End While
        con.Close()

    End Sub



    Private Sub GRID_ANTECEDENTES_LABORALES_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ANTECEDENTES_LABORALES.CellClick
        'cargarAntecedentesLaborales_condiciones(GRID_ANTECEDENTES_LABORALES.Item(11, e.RowIndex).Value)

    End Sub


    Private Sub GRID_ANTECEDENTES_LABORALES_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ANTECEDENTES_LABORALES.CellEndEdit
        If GRID_ANTECEDENTES_LABORALES.Item(1, e.RowIndex).Value Is Nothing Then
            GRID_ANTECEDENTES_LABORALES.Item(1, e.RowIndex).Value = 0
        End If
    End Sub

    Private Sub TextBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_DIRECCION.DoubleClick
        TXT_DIRECCION.Text = Expandir(TXT_DIRECCION.Text, TXT_DIRECCION.AccessibleName)
    End Sub

    Private Sub TXT_RESUMEN_CLINICO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_RESUMEN_CLINICO.DoubleClick
        TXT_RESUMEN_CLINICO.Text = Expandir(TXT_RESUMEN_CLINICO.Text, TXT_RESUMEN_CLINICO.AccessibleName)
    End Sub



    Private Sub GRID_ANTECEDENTES_LABORALES_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ANTECEDENTES_LABORALES.CellContentClick
        If e.ColumnIndex = GRID_ANTECEDENTES_LABORALES.Columns(0).Index Then
            Dim p1() As DataRow = tabla_antLab.Select("reng_num = " & GRID_ANTECEDENTES_LABORALES.Item("reng_num", e.RowIndex).Value)
            'Dim p2() As DataRow = tabla_antLab_riesgos.Select("reng_num = " & GRID_ANTECEDENTES_LABORALES.Item("reng_num", e.RowIndex).Value)

            Dim Detalle As New FrmAntecedentesLaborales(p1, tabla_antLab_riesgos, tabla_antLab_equipos)
            Detalle.ShowDialog()


        End If
    End Sub


    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        tabla_antLab.Rows.Add(cantidadTrabajos)
        Dim p1() As DataRow = tabla_antLab.Select("reng_num = " & cantidadTrabajos)
        'Dim p2() As DataRow = tabla_antLab_riesgos.Select("reng_num = " & GRID_ANTECEDENTES_LABORALES.Item("reng_num", e.RowIndex).Value)

        Dim Detalle As New FrmAntecedentesLaborales(p1, tabla_antLab_riesgos, tabla_antLab_equipos)
        Detalle.ShowDialog()
        cantidadTrabajos = cantidadTrabajos + 1
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If GRID_ANTECEDENTES_LABORALES.CurrentRow Is Nothing Then Exit Sub
        GRID_ANTECEDENTES_LABORALES.Rows.Remove(GRID_ANTECEDENTES_LABORALES.CurrentRow)
    End Sub

    Private Sub GRID_ANTECEDENTES_MEDICOS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_ANTECEDENTES_MEDICOS.KeyDown
      
    End Sub

    Private Sub TXT_ID_CLIENTE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_CLIENTE.KeyPress
        If e.KeyChar = Chr(Keys.F2) Then
            buscar()
        End If
    End Sub

    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        Dim busqueda As New FrmBusquedaQry("id,nombre", "ANTECEDENTES_MEDICOS", "nombre", ordenPR:="nombre")
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub
        GRID_ANTECEDENTES_MEDICOS.Rows.Add()
        Dim rowid As Integer = GRID_ANTECEDENTES_MEDICOS.Rows.Count - 1
      
        GRID_ANTECEDENTES_MEDICOS.Item("id_antecedente", rowid).Value = resultado(0)
    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        If GRID_ANTECEDENTES_MEDICOS.CurrentRow Is Nothing Then Exit Sub
        GRID_ANTECEDENTES_MEDICOS.Rows.Remove(GRID_ANTECEDENTES_MEDICOS.CurrentRow)
    End Sub
End Class