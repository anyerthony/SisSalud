Imports System.Data.SqlClient

Public Class FrmAsignarBaremos
    Dim buscando As Boolean = False
    Dim ultimaBusqueda As String = "trabajadores"

    Private Sub FrmAsignarBaremos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GRID_PACIENTES.Columns(11).DisplayIndex = 0

    End Sub

    Private Sub TXT_ID_ASEGURADORA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ID_ASEGURADORA.KeyDown
        If e.KeyCode = Keys.F2 Then
            buscando = Not buscando
            Dim busqueda As New FrmBusquedaQry("id, rif, nombre", "empresas", "nombre", "rif", "aseguradora = 1", "nombre")
            busqueda.WidthColumnas.Add(0, 30)
            busqueda.WidthColumnas.Add(1, 80)
            busqueda.WidthColumnas.Add(2, 300)

            Dim resultado As New List(Of String)
            resultado = busqueda.ejecutar()

            If resultado.Count = 0 Then Exit Sub
            TXT_ID_ASEGURADORA.Text = resultado(0)
            TXT_ASEGURADORA.Text = resultado(2)
            buscando = Not buscando

        End If
    End Sub

    Private Sub TXT_ID_GRUPO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ID_GRUPO.KeyDown
        If e.KeyCode = Keys.F2 Then
            buscando = Not buscando
            Dim busqueda As New FrmBusquedaQry("id, nombre", "GRUPO_EMPRESAS", "nombre", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(0, 30)
            busqueda.WidthColumnas.Add(1, 300)


            Dim resultado As New List(Of String)
            resultado = busqueda.ejecutar()

            If resultado.Count = 0 Then Exit Sub
            TXT_ID_GRUPO.Text = resultado(0)
            TXT_GRUPO.Text = resultado(1)
            buscando = Not buscando
        End If
    End Sub

    Private Sub TXT_ID_EMPRESA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ID_EMPRESA.KeyDown
        If e.KeyCode = Keys.F2 Then
            buscando = Not buscando
            Dim busqueda As New FrmBusquedaQry("id, rif, nombre", "empresas", "nombre", "rif", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(0, 30)
            busqueda.WidthColumnas.Add(1, 80)
            busqueda.WidthColumnas.Add(2, 300)

            Dim resultado As New List(Of String)
            resultado = busqueda.ejecutar()

            If resultado.Count = 0 Then Exit Sub
            TXT_ID_EMPRESA.Text = resultado(0)
            TXT_EMPRESA.Text = resultado(2)
            buscando = Not buscando

        End If
    End Sub

    Private Sub TXT_ID_DEPENDENCIA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ID_DEPENDENCIA.KeyDown
        If e.KeyCode = Keys.F2 Then
            buscando = Not buscando
            Dim busqueda As New FrmBusquedaQry("id, nombre", "DEPENDENCIAS", "nombre", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(0, 30)
            busqueda.WidthColumnas.Add(1, 300)

            Dim resultado As New List(Of String)
            resultado = busqueda.ejecutar()

            If resultado.Count = 0 Then Exit Sub
            TXT_ID_DEPENDENCIA.Text = resultado(0)
            TXT_DEPENDENCIA.Text = resultado(1)
            buscando = Not buscando

        End If
    End Sub

    Sub buscarNombre(ByVal id As String, ByRef TXT As TextBox, ByVal tabla As String, ByVal filtro As String)
        If id = "" Then
            TXT.Text = ""
            Exit Sub
        End If
        Dim tmp As New DataTable
        tmp = SelectSQL("SELECT nombre FROM " & tabla & " WHERE id = " & id & " " & filtro)
        If tmp.Rows.Count = 0 Then
            TXT.Text = ""
            Exit Sub
        End If
        TXT.Text = tmp.Rows(0).Item(0)
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        buscar()
    End Sub

    Sub buscar()

        ultimaBusqueda = "trabajadores"
        CH_ALL.Checked = True
        GRID_PACIENTES.Rows.Clear()
        Dim proceso As New SPEjecutable("usp_buscarBaremoPacientePorRelacion")
        proceso.ComandoSql.Parameters.AddWithValue("@id_aseguradora", IIf(TXT_ID_ASEGURADORA.Text = "", DBNull.Value, TXT_ID_ASEGURADORA.Text))
        proceso.ComandoSql.Parameters.AddWithValue("@id_grupo_empresas", IIf(TXT_ID_GRUPO.Text = "", DBNull.Value, TXT_ID_GRUPO.Text))
        proceso.ComandoSql.Parameters.AddWithValue("@id_empresa", IIf(TXT_ID_EMPRESA.Text = "", DBNull.Value, TXT_ID_EMPRESA.Text))
        proceso.ComandoSql.Parameters.AddWithValue("@id_dependencia", IIf(TXT_ID_DEPENDENCIA.Text = "", DBNull.Value, TXT_ID_DEPENDENCIA.Text))
        proceso.ComandoSql.Parameters.AddWithValue("@sin_asegurar", CK_SIN_ASEGURAR.Checked)


        proceso.Leer()
        Dim ar As SqlDataReader = proceso.arreglo
        While ar.Read()
            GRID_PACIENTES.Rows.Add(ar("id_relacion"), ar("id_cliente"), ar("nombre_cliente"), ar("id_aseguradora"), ar("nombre_aseguradora"), ar("id_empresa"), ar("nombre_empresa"), ar("id_dependencia"), ar("nombre_dependencia"), ar("id_baremo"), ar("nombre_baremo"), 1)
        End While
    End Sub

    Sub buscarParticulares()

        ultimaBusqueda = "particulares"
        CH_ALL.Checked = True
        GRID_PACIENTES.Rows.Clear()
        Dim proceso As New SPEjecutable("usp_buscarBaremoPacienteParticular")
        proceso.Leer()

        Dim ar As SqlDataReader = proceso.arreglo
        While ar.Read()
            GRID_PACIENTES.Rows.Add(ar("id_relacion"), ar("id_cliente"), ar("nombre_cliente"), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, ar("id_baremo"), ar("nombre_baremo"), 1)
        End While
    End Sub

    Private Sub TXT_ID_BAREMO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ID_BAREMO.KeyDown
        If e.KeyCode = Keys.F2 Then
            buscando = Not buscando
            Dim busqueda As New FrmBusquedaQry("id, nombre", "BAREMOS", "nombre", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(0, 30)
            busqueda.WidthColumnas.Add(1, 300)


            Dim resultado As New List(Of String)
            resultado = busqueda.ejecutar()

            If resultado.Count = 0 Then Exit Sub
            TXT_ID_BAREMO.Text = resultado(0)
            TXT_BAREMO.Text = resultado(1)
            buscando = Not buscando

        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If TXT_ID_BAREMO.Text = "" Then
            L_BAREMO.ForeColor = Color.Red
            Interaction.Beep()
            Exit Sub
        End If
        Dim procesoGurdar As New SPEjecutable("usp_actualizarBaremosRelacion")
        Dim tabla As New DataTable
        tabla.Clear()
        tabla.Columns.Add("id_relacion", GetType(Integer))
        tabla.Columns.Add("id_cliente", GetType(Integer))
        tabla.Columns.Add("id_aseguradora", GetType(Integer))
        tabla.Columns.Add("id_empresa", GetType(Integer))
        tabla.Columns.Add("id_dependencia", GetType(Integer))
        tabla.Columns.Add("actualizar", GetType(Boolean))

        For i = 0 To GRID_PACIENTES.Rows.Count - 1
            tabla.Rows.Add(GRID_PACIENTES.Item(0, i).Value, GRID_PACIENTES.Item(1, i).Value, GRID_PACIENTES.Item(3, i).Value, GRID_PACIENTES.Item(5, i).Value, GRID_PACIENTES.Item(7, i).Value, GRID_PACIENTES.Item(11, i).Value)
        Next


        procesoGurdar.ComandoSql.Parameters.AddWithValue("@LISTA", tabla)
        procesoGurdar.ComandoSql.Parameters.AddWithValue("@ID_BAREMO", TXT_ID_BAREMO.Text)

        procesoGurdar.Ejecutar()

        If ultimaBusqueda = "trabajadores" Then
            buscar()
        Else
            buscarParticulares()
        End If

    End Sub

    Private Sub TXT_ID_ASEGURADORA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_ASEGURADORA.TextChanged
        GRID_PACIENTES.Rows.Clear()
        If buscando = False Then
            buscarNombre(TXT_ID_ASEGURADORA.Text, TXT_ASEGURADORA, "EMPRESAS", "AND aseguradora = 1")
        End If

    End Sub

    Private Sub TXT_ID_GRUPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_GRUPO.TextChanged
        GRID_PACIENTES.Rows.Clear()
        If buscando = False Then
            buscarNombre(TXT_ID_GRUPO.Text, TXT_GRUPO, "GRUPO_EMPRESAS", "")
        End If

    End Sub

    Private Sub TXT_ID_EMPRESA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_EMPRESA.TextChanged
        GRID_PACIENTES.Rows.Clear()
        If buscando = False Then
            buscarNombre(TXT_ID_EMPRESA.Text, TXT_EMPRESA, "EMPRESAS", "")
        End If

    End Sub

    Private Sub TXT_ID_DEPENDENCIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_DEPENDENCIA.TextChanged
        GRID_PACIENTES.Rows.Clear()
        If buscando = False Then
            buscarNombre(TXT_ID_DEPENDENCIA.Text, TXT_DEPENDENCIA, "DEPENDENCIAS", "")
        End If

    End Sub

    Private Sub TXT_ID_BAREMO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_BAREMO.TextChanged
        If buscando = False Then
            buscarNombre(TXT_ID_BAREMO.Text, TXT_BAREMO, "BAREMOS", "")
        End If
        L_BAREMO.ForeColor = Label1.ForeColor
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        TXT_ID_ASEGURADORA.Text = ""
        TXT_ID_GRUPO.Text = ""
        TXT_ID_EMPRESA.Text = ""
        TXT_ID_DEPENDENCIA.Text = ""

        TXT_ASEGURADORA.Text = ""
        TXT_GRUPO.Text = ""
        TXT_EMPRESA.Text = ""
        TXT_DEPENDENCIA.Text = ""

        buscarParticulares()
    End Sub

    
    Private Sub TXT_FILTRO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FILTRO.KeyPress
        If e.KeyChar = Chr(13) Then
            For i = 0 To GRID_PACIENTES.Rows.Count - 1
                If LCase(GRID_PACIENTES.Item(2, i).Value.ToString) Like "*" & LCase(TXT_FILTRO.Text) & "*" Then
                    GRID_PACIENTES.Rows(i).Visible = True
                Else
                    GRID_PACIENTES.Rows(i).Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        CH_ALL.Checked = Not CH_ALL.Checked
        For i = 0 To GRID_PACIENTES.Rows.Count - 1
            If GRID_PACIENTES.Rows(i).Visible = True Then
                GRID_PACIENTES.Item(11, i).Value = CH_ALL.Checked
            End If

        Next
    End Sub

    Private Sub TXT_ID_ASEGURADORA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_ASEGURADORA.KeyPress
        If e.KeyChar = Chr(13) Then
            buscar()
        End If
    End Sub

    Private Sub TXT_ID_GRUPO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_GRUPO.KeyPress
        If e.KeyChar = Chr(13) Then
            buscar()
        End If
    End Sub

    Private Sub TXT_ID_EMPRESA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_EMPRESA.KeyPress
        If e.KeyChar = Chr(13) Then
            buscar()
        End If
    End Sub

    Private Sub TXT_ID_DEPENDENCIA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_DEPENDENCIA.KeyPress
        If e.KeyChar = Chr(13) Then
            buscar()
        End If
    End Sub

    Private Sub TXT_ID_BAREMO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID_BAREMO.KeyPress
        If e.KeyChar = Chr(13) Then
            If ultimaBusqueda = "trabajadores" Then
                buscar()
            Else
                buscarParticulares()
            End If

        End If
    End Sub

    Private Sub CK_SIN_ASEGURAR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_SIN_ASEGURAR.CheckedChanged
        TXT_ID_ASEGURADORA.Text = ""
        TXT_ASEGURADORA.Text = ""

        TXT_ID_ASEGURADORA.Enabled = Not CK_SIN_ASEGURAR.Checked
        TXT_ASEGURADORA.Enabled = Not CK_SIN_ASEGURAR.Checked
    End Sub
End Class