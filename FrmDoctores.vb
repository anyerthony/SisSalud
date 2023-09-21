Public Class FrmDoctores

    Private Sub CK_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_1.CheckedChanged
        HORA_1_M_D.Enabled = CK_1.Checked
        HORA_1_M_H.Enabled = CK_1.Checked
    End Sub
    Private Sub CK_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_2.CheckedChanged
        HORA_2_M_D.Enabled = CK_2.Checked
        HORA_2_M_H.Enabled = CK_2.Checked
    End Sub
    Private Sub CK_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_3.CheckedChanged
        HORA_3_M_D.Enabled = CK_3.Checked
        HORA_3_M_H.Enabled = CK_3.Checked
    End Sub
    Private Sub CK_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_4.CheckedChanged
        HORA_4_M_D.Enabled = CK_4.Checked
        HORA_4_M_H.Enabled = CK_4.Checked
    End Sub
    Private Sub CK_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_5.CheckedChanged
        HORA_5_M_D.Enabled = CK_5.Checked
        HORA_5_M_H.Enabled = CK_5.Checked
    End Sub
    Private Sub CK_6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_6.CheckedChanged
        HORA_6_M_D.Enabled = CK_6.Checked
        HORA_6_M_H.Enabled = CK_6.Checked
    End Sub
    Private Sub CK_7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_7.CheckedChanged
        HORA_7_M_D.Enabled = CK_7.Checked
        HORA_7_M_H.Enabled = CK_7.Checked
    End Sub


    Private Sub CK_T_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_1.CheckedChanged, CK_1.CheckedChanged
        HORA_1_T_D.Enabled = CK_1.Checked
        HORA_1_T_H.Enabled = CK_1.Checked
    End Sub
    Private Sub CK_T_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_2.CheckedChanged, CK_2.CheckedChanged
        HORA_2_T_D.Enabled = CK_2.Checked
        HORA_2_T_H.Enabled = CK_2.Checked
    End Sub
    Private Sub CK_T_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_3.CheckedChanged, CK_3.CheckedChanged
        HORA_3_T_D.Enabled = CK_3.Checked
        HORA_3_T_H.Enabled = CK_3.Checked
    End Sub
    Private Sub CK_T_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_4.CheckedChanged, CK_4.CheckedChanged
        HORA_4_T_D.Enabled = CK_4.Checked
        HORA_4_T_H.Enabled = CK_4.Checked
    End Sub
    Private Sub CK_T_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_5.CheckedChanged
        HORA_5_T_D.Enabled = CK_T_5.Checked
        HORA_5_T_H.Enabled = CK_T_5.Checked
    End Sub
    Private Sub CK_T_6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_6.CheckedChanged
        HORA_6_T_D.Enabled = CK_T_6.Checked
        HORA_6_T_H.Enabled = CK_T_6.Checked
    End Sub
    Private Sub CK_T_7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_T_7.CheckedChanged
        HORA_7_T_D.Enabled = CK_T_7.Checked
        HORA_7_T_H.Enabled = CK_T_7.Checked
    End Sub

    Private Sub FrmDoctores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nuevo()
    End Sub
    Sub nuevo()
        limpiar()
    End Sub
    Sub limpiar()

    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        Dim busqueda As New FrmBusquedaQry("id,cod_usuario, nombre + ' ' + apellido nombre", "DOCTORES", "nombre", "apellido", "", "2")
        busqueda.WidthColumnas.Add(1, 50)
        busqueda.WidthColumnas.Add(2, 200)
        busqueda.columnasOcultas.Add(0)
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub
        limpiar()
        TXT_ID_DOCTOR.Text = resultado(0).ToString
        buscarDoctor()
    End Sub
    Sub buscarDoctor()
        Dim tablaDoctor As New DataTable
        tablaDoctor = SelectSQL("SELECT * FROM DOCTORES WHERE RIF = '" & TXT_ID_DOCTOR.Text & "'")
        If tablaDoctor.Rows.Count = 0 Then Exit Sub
        Dim rowDoctor As DataRow = tablaDoctor.Rows(0)
        TXT_COD_DOCTOR.Text = rowDoctor.Item("nombre")
        TXT_NOMBRE.Text = rowDoctor.Item("nombre")
        TXT_APELLIDO.Text = rowDoctor.Item("nombre")
        TXT_CORREO.Text = rowDoctor.Item("nombre")
        TXT_TLFN.Text = rowDoctor.Item("nombre")
        TXT_TLFN_LOCAL.Text = rowDoctor.Item("nombre")
        TXT_MPPS.Text = rowDoctor.Item("nombre")
        TXT_INPSASEL.Text = rowDoctor.Item("nombre")
        TXT_COLEGIO.Text = rowDoctor.Item("nombre")
        TXT_MINUTOS.Text = rowDoctor.Item("nombre")

        Dim tablaEspecialidades As DataTable = SelectSQL("select A.id, A.id_especialidad,B.nombre from DOCTORES_ESPECIALIDADES A INNER JOIN ESPECIALIDADES B ON A.id_especialidad = B.id WHERE A.id_doctor = " & TXT_ID_DOCTOR.Text)
        For Each row As DataRow In tablaEspecialidades.Rows()
            GRID_ESPECIALIDADES.Rows.Add(row.Item("id"), row.Item("id_especialidad"), row.Item("nombre"))
        Next

        Dim tablaHorario As DataTable = SelectSQL("select * from DOCTORES_HORARIOS where id_doctor = " & TXT_ID_DOCTOR.Text)
        Dim lunes As DataRow = tablaHorario.Select("dia = 1")(0)
        Dim martes As DataRow = tablaHorario.Select("dia = 2")(0)
        Dim miercoles As DataRow = tablaHorario.Select("dia = 3")(0)
        Dim jueves As DataRow = tablaHorario.Select("dia = 4")(0)
        Dim viernes As DataRow = tablaHorario.Select("dia = 5")(0)
        Dim sabado As DataRow = tablaHorario.Select("dia = 6")(0)
        Dim domingo As DataRow = tablaHorario.Select("dia = 7")(0)

        HORA_1_M_D.Text = lunes.Item("desde_am")
        HORA_1_M_H.Text = lunes.Item("hasta_am")

        HORA_1_T_D.Text = lunes.Item("desde_pm")
        HORA_1_T_H.Text = lunes.Item("hasta_pm")

        CK_1.Checked = lunes.Item("turno_manana")
        CK_T_1.Checked = lunes.Item("turno_tarde")

        'FIN DEL DIA 1

     

        'FIN DEL DIA 2

        HORA_2_M_D.Text = martes.Item("desde_am")
        HORA_2_M_H.Text = martes.Item("hasta_am")

        HORA_2_T_D.Text = martes.Item("desde_pm")
        HORA_2_T_H.Text = martes.Item("hasta_pm")

        CK_2.Checked = martes.Item("turno_manana")
        CK_T_2.Checked = martes.Item("turno_tarde")

        'FIN DEL DIA 3

        HORA_3_M_D.Text = miercoles.Item("desde_am")
        HORA_3_M_H.Text = miercoles.Item("hasta_am")

        HORA_3_T_D.Text = miercoles.Item("desde_pm")
        HORA_3_T_H.Text = miercoles.Item("hasta_pm")

        CK_3.Checked = miercoles.Item("turno_manana")
        CK_T_3.Checked = miercoles.Item("turno_tarde")

        'FIN DEL DIA 4

        HORA_4_M_D.Text = jueves.Item("desde_am")
        HORA_4_M_H.Text = jueves.Item("hasta_am")

        HORA_4_T_D.Text = jueves.Item("desde_pm")
        HORA_4_T_H.Text = jueves.Item("hasta_pm")

        CK_4.Checked = jueves.Item("turno_manana")
        CK_T_4.Checked = jueves.Item("turno_tarde")

        'FIN DEL DIA 5

        HORA_5_M_D.Text = viernes.Item("desde_am")
        HORA_5_M_H.Text = viernes.Item("hasta_am")

        HORA_5_T_D.Text = viernes.Item("desde_pm")
        HORA_5_T_H.Text = viernes.Item("hasta_pm")

        CK_5.Checked = viernes.Item("turno_manana")
        CK_T_5.Checked = viernes.Item("turno_tarde")

        'FIN DEL DIA 6

        HORA_6_M_D.Text = sabado.Item("desde_am")
        HORA_6_M_H.Text = sabado.Item("hasta_am")

        HORA_6_T_D.Text = sabado.Item("desde_pm")
        HORA_6_T_H.Text = sabado.Item("hasta_pm")

        CK_6.Checked = sabado.Item("turno_manana")
        CK_T_6.Checked = sabado.Item("turno_tarde")

        'FIN DEL DIA 7

        HORA_7_M_D.Text = domingo.Item("desde_am")
        HORA_7_M_H.Text = domingo.Item("hasta_am")

        HORA_7_T_D.Text = domingo.Item("desde_pm")
        HORA_7_T_H.Text = domingo.Item("hasta_pm")

        CK_7.Checked = domingo.Item("turno_manana")
        CK_T_7.Checked = domingo.Item("turno_tarde")




    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        Dim spGuardar As New SPEjecutable("usp_guardarDoctor")
        spGuardar.ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        Dim tablaDoctor As New DataTable
        Dim tablaEspecialidades As New DataTable
        Dim tablaHorario As New DataTable

        tablaDoctor = SelectSQL("SELECT * FROM DOCTORES id = 0")

        tablaDoctor.Rows.Add(IIf(TXT_ID_DOCTOR.Text = "", DBNull.Value, TXT_ID_DOCTOR), TXT_COD_DOCTOR.Text, TXT_MINUTOS.Text, TXT_MPPS.Text, TXT_INPSASEL.Text, TXT_COLEGIO.Text)

        tablaEspecialidades = SelectSQL("select A.id, A.id_especialidad,B.nombre from DOCTORES_ESPECIALIDADES A INNER JOIN ESPECIALIDADES B ON A.id_especialidad = B.id WHERE A.id_doctor =  0")
        tablaHorario = SelectSQL("select * from DOCTORES_HORARIOS where id_doctor = 0")


        spGuardar.ComandoSql.Parameters.AddWithValue("@DOCTOR", tablaDoctor)
        spGuardar.ComandoSql.Parameters.AddWithValue("@ESPECIALIDADES", tablaEspecialidades)
        spGuardar.ComandoSql.Parameters.AddWithValue("@HORARIO", tablaHorario)

        spGuardar.Ejecutar()
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        nuevo()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        If TXT_ID_DOCTOR.Text = "" Then Exit Sub
        Dim spEliminar As New SPEjecutable("usp_eliminarDoctor")
        spEliminar.ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        spEliminar.Ejecutar()
    End Sub
End Class