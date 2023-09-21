Imports System.Data.SqlClient

Public Class FrmPaquetes
    Dim hayCambios As Boolean = False
    Dim cargando As Boolean = False

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        Nuevo()
    End Sub
    Sub Nuevo()
        Limpiar()
    End Sub
    Sub guardar()
        Dim SP As New SPEjecutable("usp_guardarPaquete")
        Dim parametroOutID As New SqlParameter
        parametroOutID.Direction = ParameterDirection.InputOutput
        parametroOutID.ParameterName = "ID_PAQUETE"
        parametroOutID.Value = IIf(TXT_ID_PAQUETE.Text = "", 0, TXT_ID_PAQUETE.Text)


        SP.ComandoSql.Parameters.AddWithValue("@CO_US", Cod_Usuario)
        SP.ComandoSql.Parameters.AddWithValue("@PAQUETE", TXT_PAQUETE.Text)
        SP.ComandoSql.Parameters.Add(parametroOutID)

        Dim lista As New DataTable
        lista.Columns.Add("id", GetType(Integer))
        lista.Columns.Add("id_sub_paquete", GetType(Integer))
        lista.Columns.Add("id_concepto", GetType(Integer))

        GRID_CONCEPTOS.AllowUserToAddRows = False
        For i = 0 To GRID_CONCEPTOS.Rows.Count - 1
            lista.Rows.Add(GRID_CONCEPTOS.Item(0, i).Value, DBNull.Value, GRID_CONCEPTOS.Item(1, i).Value)
        Next
        GRID_CONCEPTOS.AllowUserToAddRows = True

        GRID_PAQUETES.AllowUserToAddRows = False
        For i = 0 To GRID_PAQUETES.Rows.Count - 1
            lista.Rows.Add(GRID_PAQUETES.Item(0, i).Value, GRID_PAQUETES.Item(1, i).Value, DBNull.Value)
        Next
        GRID_PAQUETES.AllowUserToAddRows = True

        SP.ComandoSql.Parameters.AddWithValue("@LISTA", lista)


        SP.Ejecutar()
        If SP.ParametroOutStatus.Value = 0 Then Exit Sub

        If TXT_ID_PAQUETE.Text = "" Then
            TXT_PAQUETE.ReadOnly = True
            TXT_PAQUETE.BackColor = Color.LemonChiffon
            TXT_ID_PAQUETE.Text = parametroOutID.Value
        End If
        hayCambios = False

        Dim tmpNombre As String = TXT_PAQUETE.Text

        Limpiar()
        TXT_ID_PAQUETE.Text = parametroOutID.Value
        TXT_PAQUETE.Text = tmpNombre
    End Sub
    Sub Limpiar()
        If hayCambios Then
            If SourceAceptarCambios() Then
                guardar()
            End If
        End If
        TXT_ID_PAQUETE.Text = ""
        TXT_PAQUETE.Text = ""

        GRID_CONCEPTOS.Rows.Clear()
        GRID_TODOS_CONCEPTOS.Rows.Clear()
        GRID_PAQUETES.Rows.Clear()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        If MsgBoxResult.Yes = MsgBox("El paquete actual será eliminado." & vbCrLf & " ¿Desea continuar?", MsgBoxStyle.YesNo, "Eliminar") Then
            SelectSQL("DELETE PAQUETE_CONCEPTOS WHERE ID_PAQUETE = " & TXT_ID_PAQUETE.Text)
            SelectSQL("DELETE PAQUETES WHERE ID = " & TXT_ID_PAQUETE.Text)
            Limpiar()
        End If
    End Sub

    Private Sub FrmPaquetes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub

    Private Sub FrmPaquetes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Nuevo()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        Limpiar()
        Dim busqueda As New FrmBusquedaQry("id,nombre", "PAQUETES", "nombre", ordenPR:="nombre")
        busqueda.WidthColumnas.Add(1, 250)
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub

        TXT_ID_PAQUETE.Text = resultado(0)
        TXT_PAQUETE.Text = resultado(1)
    End Sub
    Sub Buscar()
       
        If TXT_ID_PAQUETE.Text = "" Then Exit Sub
        TXT_PAQUETE.BackColor = Color.LemonChiffon
        TXT_PAQUETE.ReadOnly = True

        cargando = True

        Dim tablaConceptos As New DataTable
        tablaConceptos = SelectSQL("SELECT b.id, a.id id_concepto,a.nombre FROM CONCEPTOS A INNER JOIN PAQUETE_CONCEPTOS B ON A.ID = B.ID_CONCEPTO WHERE B.ID_CONCEPTO IS NOT NULL AND B.ID_PAQUETE = " & TXT_ID_PAQUETE.Text)
        For I = 0 To tablaConceptos.Rows.Count - 1
            GRID_CONCEPTOS.Rows.Add(tablaConceptos.Rows(I).Item(0).ToString(), tablaConceptos.Rows(I).Item(1).ToString(), tablaConceptos.Rows(I).Item(2).ToString())
        Next

        Dim tablaSubPaquetes As New DataTable
        tablaSubPaquetes = SelectSQL("SELECT b.id, a.id id_sub_paquete,a.nombre FROM PAQUETES A INNER JOIN PAQUETE_CONCEPTOS B ON A.ID = B.ID_SUB_PAQUETE WHERE B.ID_SUB_PAQUETE IS NOT NULL AND B.ID_PAQUETE = " & TXT_ID_PAQUETE.Text)
        For I = 0 To tablaSubPaquetes.Rows.Count - 1
            GRID_PAQUETES.Rows.Add(tablaSubPaquetes.Rows(I).Item(0), tablaSubPaquetes.Rows(I).Item(1), tablaSubPaquetes.Rows(I).Item(2))
        Next


        Dim SP As New SPEjecutable("usp_cargarPaquete")
        SP.ComandoSql.Parameters.AddWithValue("@ID_PAQUETE", TXT_ID_PAQUETE.Text)
        SP.Leer()
        Dim tablaTodosConceptos As New DataTable
        tablaTodosConceptos.Load(SP.arreglo)

        For i = 0 To tablaTodosConceptos.Rows.Count - 1
            GRID_TODOS_CONCEPTOS.Rows.Add(tablaTodosConceptos.Rows(i).Item("nombre"), tablaTodosConceptos.Rows(i).Item("nombre_paquete"))
        Next

        cargando = False
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        guardar()

    End Sub

    Private Sub TXT_ID_PAQUETE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_PAQUETE.TextChanged
        Buscar()
    End Sub

    Private Sub GRID_CONCEPTOS_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_CONCEPTOS.CellEndEdit
        If cargando Then Exit Sub
        If e.ColumnIndex = 1 Then
            If GRID_CONCEPTOS.Item(1, e.RowIndex).Value <> "" Then
                Dim nombre As New DataTable
                nombre = SelectSQL("select nombre from CONCEPTOS where id= " & GRID_CONCEPTOS.Item(1, e.RowIndex).Value)
                If nombre.Rows.Count = 0 Then Exit Sub
                GRID_CONCEPTOS.Item(2, e.RowIndex).Value = nombre.Rows(0).Item(0)
            End If
        End If
    End Sub

    Private Sub GRID_PAQUETES_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_PAQUETES.CellEndEdit
        If cargando Then Exit Sub
        If e.ColumnIndex = 1 Then
            If GRID_PAQUETES.Item(1, e.RowIndex).Value.ToString <> "" Then
                Dim nombre As New DataTable
                nombre = SelectSQL("select nombre from PAQUETES where id= " & GRID_PAQUETES.Item(1, e.RowIndex).Value)
                If nombre.Rows.Count = 0 Then Exit Sub
                GRID_PAQUETES.Item(2, e.RowIndex).Value = nombre.Rows(0).Item(0)


            End If
        End If
    End Sub

    Private Sub GRID_CONCEPTOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_CONCEPTOS.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim busqueda As New FrmBusquedaQry("id,nombre", "CONCEPTOS", "nombre", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(1, 320)
            Dim idi As Integer = GRID_CONCEPTOS.CurrentRow.Index
            If idi = GRID_CONCEPTOS.Rows.Count - 1 Then
                GRID_CONCEPTOS.Rows.Add()
                'idi = GRID_CONCEPTOS.Rows.Count - 2
            End If
            Dim resultado As List(Of String) = busqueda.ejecutar()
            If resultado.Count = 0 Then Exit Sub
            GRID_CONCEPTOS.Item(1, idi).Value = resultado(0)
            GRID_CONCEPTOS.Item(2, idi).Value = resultado(1)

        End If
    End Sub

  
    Private Sub GRID_PAQUETES_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_PAQUETES.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim busqueda As New FrmBusquedaQry("id,nombre", "PAQUETES", "nombre", ordenPR:="nombre")
            busqueda.WidthColumnas.Add(1, 320)
            Dim idi As Integer = GRID_PAQUETES.CurrentRow.Index
            If idi = GRID_PAQUETES.Rows.Count - 1 Then
                GRID_PAQUETES.Rows.Add()
                'idi = GRID_CONCEPTOS.Rows.Count - 2
            End If
            Dim resultado As List(Of String) = busqueda.ejecutar()
            If resultado.Count = 0 Then Exit Sub
            GRID_PAQUETES.Item(1, idi).Value = resultado(0)
            GRID_PAQUETES.Item(2, idi).Value = resultado(1)

        End If
    End Sub

    Private Sub TXT_PAQUETE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PAQUETE.TextChanged

    End Sub

  
    Private Sub GRID_CONCEPTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID_CONCEPTOS.Click
        hayCambios = True
    End Sub

    Private Sub GRID_PAQUETES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID_PAQUETES.Click
        hayCambios = True
    End Sub
End Class