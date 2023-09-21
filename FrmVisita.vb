Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmVisita
    Dim idPaciente As Integer = 0
    Dim tablaAdeguradoras As New DataTable
    Dim tablaEmpresas As New DataTable
    Dim tablaDependencias As New DataTable
    Dim tablaBaremos As New DataTable
    Dim cargando As Boolean = False

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        FrmBuscarPaquete.ShowDialog()
    End Sub

    Private Sub TXT_CEDULA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CEDULA.KeyPress
        If e.KeyChar = Chr(13) Then
            buscarCI()
        End If

    End Sub
    Sub buscarCI()
        Try
            TXT_CI_TITULAR.Enabled = False
            TXT_NOMBRE_TITULAR.Enabled = False
            LISTA_ASEGURADORAS.Enabled = False
            LISTA_EMPRESAS.Enabled = False
            LISTA_DEPENDENCIAS.Enabled = False
            TXT_CLAVE.Enabled = False
            BTN_NUEVA_CLAVE.Enabled = False
            CK_ESPERA.Enabled = False
            LISTA_TARJETAS.Enabled = False

            tablaAdeguradoras.Rows.Clear()
            tablaEmpresas.Rows.Clear()
            tablaDependencias.Rows.Clear()
            tablaBaremos.Rows.Clear()

            'TXT_CEDULA.Text = ""
            TXT_NOMBRE.Text = ""
            TXT_TELEFONO.Text = ""
            TXT_CORREO.Text = ""


            Dim tablaPaciente As New DataTable
            tablaPaciente = SelectSQL("SELECT * FROM PACIENTES WHERE RIF = '" & TXT_CEDULA.Text & "'")
            If tablaPaciente.Rows.Count = 0 Then
                If MsgBoxResult.Yes = MsgBox("Disculpe, no se encontró el paciente indicado." & vbCrLf & "Desea registrar un pacientecon esta cédula?", MsgBoxStyle.YesNo, "No se encontró el paciente.") Then
                    FrmPaciente.ShowDialog()
                    FrmPaciente.TXT_CI.Text = TXT_CEDULA.Text
                    FrmPaciente.TXT_CI.ReadOnly = True
                    FrmPaciente.TXT_CI.BackColor = Color.LemonChiffon
                    tablaPaciente = SelectSQL("SELECT * FROM PACIENTES WHERE RIF = '" & TXT_CEDULA.Text & "'")
                    buscarCI()
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If

            TXT_NOMBRE.Text = tablaPaciente.Rows(0).Item("nombre")
            TXT_CORREO.Text = tablaPaciente.Rows(0).Item("correo")
            TXT_TELEFONO.Text = tablaPaciente.Rows(0).Item("tlfn") & " / " & tablaPaciente.Rows(0).Item("tlfn_local")

            idPaciente = tablaPaciente.Rows(0).Item("id")
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "Visitas", "Buscar Paciente")
        End Try
       


    End Sub


    Private Sub CB_TIPO_PACIENTE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTA_TIPO_PACIENTE.SelectedIndexChanged

        TXT_CI_TITULAR.Enabled = False
        TXT_NOMBRE_TITULAR.Enabled = False
        LISTA_ASEGURADORAS.Enabled = False
        LISTA_EMPRESAS.Enabled = False
        LISTA_DEPENDENCIAS.Enabled = False
        TXT_CLAVE.Enabled = False
        BTN_NUEVA_CLAVE.Enabled = False
        CK_ESPERA.Enabled = False
        LISTA_TARJETAS.Enabled = False

        tablaAdeguradoras.Rows.Clear()
        tablaEmpresas.Rows.Clear()
        tablaDependencias.Rows.Clear()
        tablaBaremos.Rows.Clear()
       

        Select Case LISTA_TIPO_PACIENTE.Text
            Case "Asegurado"
                TXT_CI_TITULAR.Enabled = True
                TXT_NOMBRE_TITULAR.Enabled = True
                LISTA_ASEGURADORAS.Enabled = True
                LISTA_EMPRESAS.Enabled = True
                LISTA_DEPENDENCIAS.Enabled = True
                TXT_CLAVE.Enabled = True
                BTN_NUEVA_CLAVE.Enabled = True
                CK_ESPERA.Enabled = True


                tablaEmpresas = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN EMPRESAS B ON A.id_empresa=b.id WHERE a.id_cliente = " & idPaciente & "GROUP BY b.id,b.nombre")
                'If tablaRelacion.Rows.Count = 0 Then Exit Sub

                'cargando = True
                LISTA_EMPRESAS.DataSource = tablaEmpresas
                'LISTA_EMPRESAS.DisplayMember = "nombre"

                'cargando = False
                'LISTA_EMPRESAS.ValueMember = "id"





            Case "Privado"
                TXT_CI_TITULAR.Enabled = True
                TXT_NOMBRE_TITULAR.Enabled = True
                LISTA_EMPRESAS.Enabled = True
                LISTA_DEPENDENCIAS.Enabled = True

                tablaEmpresas = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN EMPRESAS B ON A.id_empresa=b.id WHERE a.id_cliente = " & idPaciente & "GROUP BY b.id,b.nombre")
                'If tablaRelacion.Rows.Count = 0 Then Exit Sub

                'cargando = True
                LISTA_EMPRESAS.DataSource = tablaEmpresas


            Case "Afiliado"
                LISTA_TARJETAS.Enabled = True
            Case "Particular"
                tablaBaremos.Rows.Clear()
                tablaBaremos = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN BAREMOS B ON A.id_baremo=b.id WHERE a.id_cliente = " & idPaciente & " AND a.id_empresa IS NULL AND a.id_dependencia IS NULL AND a.id_aseguradora  IS NULL GROUP BY b.id,b.nombre")
                LISTA_BAREMO.DataSource = tablaBaremos


        End Select

    End Sub

  

    Private Sub LISTA_EMPRESAS_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LISTA_EMPRESAS.SelectedValueChanged
        tablaDependencias.Rows.Clear()
        If cargando Then Exit Sub
        If LISTA_EMPRESAS.SelectedValue Is Nothing Then Exit Sub
        tablaDependencias = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN DEPENDENCIAS B ON A.id_dependencia=b.id WHERE a.id_cliente = " & idPaciente & " AND a.id_empresa = " & LISTA_EMPRESAS.SelectedValue & " GROUP BY b.id,b.nombre")
        'If tablaRelacion.Rows.Count = 0 Then Exit Sub

        'cargando = True
        LISTA_DEPENDENCIAS.DataSource = tablaDependencias
        'LISTA_DEPENDENCIAS.DisplayMember = "nombre"
        'cargando = False

        'LISTA_DEPENDENCIAS.ValueMember = "id"


    End Sub



    Private Sub LISTA_DEPENDENCIAS_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LISTA_DEPENDENCIAS.SelectedValueChanged

        If LISTA_TIPO_PACIENTE.Text = "Asegurado" Then
            tablaAdeguradoras.Rows.Clear()
            If cargando Then Exit Sub
            If LISTA_DEPENDENCIAS.SelectedValue Is Nothing Then Exit Sub
            tablaAdeguradoras = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN EMPRESAS B ON A.id_aseguradora=b.id WHERE a.id_cliente = " & idPaciente & " AND a.id_empresa = " & LISTA_EMPRESAS.SelectedValue & " AND a.id_dependencia = " & LISTA_DEPENDENCIAS.SelectedValue & " GROUP BY b.id,b.nombre")
            'If tablaRelacion.Rows.Count = 0 Then Exit Sub

            'cargando = True
            LISTA_ASEGURADORAS.DataSource = tablaAdeguradoras
            'LISTA_ASEGURADORAS.DisplayMember = "nombre"
            'cargando = False

            'LISTA_ASEGURADORAS.ValueMember = "id"
        ElseIf LISTA_TIPO_PACIENTE.Text = "Privado" Then
            tablaBaremos.Rows.Clear()
            If cargando Then Exit Sub
            If LISTA_DEPENDENCIAS.SelectedValue Is Nothing Then Exit Sub
            tablaBaremos = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN BAREMOS B ON A.id_baremo=b.id WHERE a.id_cliente = " & idPaciente & " AND a.id_empresa = " & LISTA_EMPRESAS.SelectedValue & " AND a.id_dependencia = " & LISTA_DEPENDENCIAS.SelectedValue & " AND a.id_aseguradora is null GROUP BY b.id,b.nombre")
            'If tablaRelacion.Rows.Count = 0 Then Exit Sub

            'cargando = True
            LISTA_BAREMO.DataSource = tablaBaremos
        End If

    End Sub

    Private Sub LISTA_ASEGURADORAS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTA_ASEGURADORAS.SelectedIndexChanged
        tablaBaremos.Rows.Clear()
        If cargando Then Exit Sub
        If LISTA_ASEGURADORAS.SelectedValue Is Nothing Then Exit Sub
        tablaBaremos = SelectSQL("SELECT b.id, b.nombre FROM CLIENTE_EMPRESA_ASEGURADORA A INNER JOIN BAREMOS B ON A.id_baremo=b.id WHERE a.id_cliente = " & idPaciente & " AND a.id_empresa = " & LISTA_EMPRESAS.SelectedValue & " AND a.id_dependencia = " & LISTA_DEPENDENCIAS.SelectedValue & " AND a.id_aseguradora = " & LISTA_ASEGURADORAS.SelectedValue & " GROUP BY b.id,b.nombre")
        'If tablaRelacion.Rows.Count = 0 Then Exit Sub

        'cargando = True
        LISTA_BAREMO.DataSource = tablaBaremos
        'LISTA_BAREMO.DisplayMember = "nombre"
        'cargando = False

        'LISTA_BAREMO.ValueMember = "id"
    End Sub

    Private Sub FrmVisita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tablaMotivos As New DataTable
        tablaMotivos = SelectSQL("SELECT id, nombre FROM MOTIVOS")
        LISTA_MOTIVOS.DataSource = tablaMotivos
        'LISTA_MOTIVOS.ValueMember = "id"
        'LISTA_MOTIVOS.DisplayMember = "nombre"
    End Sub

    Private Sub TXT_CEDULA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_CEDULA.KeyDown
        If e.Control And e.KeyCode = Keys.B Then
            ctrlB()
        End If
    End Sub


    Private Sub TXT_CEDULA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CEDULA.TextChanged

    End Sub

    Sub ctrlB()
        Dim busqueda As New FrmBusquedaQry("isnull(rif,'') rif,isnull(nombre,'') + ' ' + isnull(apellido,'') nombre", "PACIENTES", "nombre", "rif", "status = 1", "2")
        busqueda.WidthColumnas.Add(1, 250)
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub
        TXT_CEDULA.Text = resultado(0).ToString
        buscarCI()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        ctrlB()
    End Sub
End Class