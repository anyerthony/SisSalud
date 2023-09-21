Imports System.Data.SqlClient

Public Class FrmAntecedentesLaborales
    Dim antecedentes() As DataRow
    Dim riesgos As DataTable
    Dim equipos As DataTable

    Dim source As New BindingSource


    Sub New(ByRef ant() As DataRow, ByRef ries As DataTable, ByRef equi As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        antecedentes = ant

        riesgos = ries
        equipos = equi

       
    End Sub

    Private Sub TXT_SALUD_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SALUD.DoubleClick
        TXT_SALUD.Text = Expandir(TXT_SALUD.Text, TXT_SALUD.AccessibleName)
    End Sub

    Private Sub TXT_ENFERMEDAD_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ENFERMEDAD.DoubleClick
        TXT_ENFERMEDAD.Text = Expandir(TXT_ENFERMEDAD.Text, TXT_ENFERMEDAD.AccessibleName)
    End Sub

    Private Sub TXT_ACCIDENTE_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ACCIDENTE.DoubleClick
        TXT_ACCIDENTE.Text = Expandir(TXT_ACCIDENTE.Text, TXT_ACCIDENTE.AccessibleName)
    End Sub

    Private Sub TXT_OBSERVACION_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_OBSERVACION.DoubleClick
        TXT_OBSERVACION.Text = Expandir(TXT_OBSERVACION.Text, TXT_OBSERVACION.AccessibleName)
    End Sub

    Private Sub FrmAntecedentesLaborales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        For Each antecedente As DataRow In antecedentes
            antecedente("empresa") = TXT_EMPRESA.Text
            antecedente("duracion") = TXT_DURACION.Text
            antecedente("horario") = TXT_HORARIO.Text
            antecedente("industria") = TXT_INDUSTRIA.Text
            antecedente("problemas_salud") = TXT_SALUD.Text
            antecedente("accidente_laboral") = TXT_ACCIDENTE.Text
            antecedente("enfermedad_ocupacional") = TXT_ENFERMEDAD.Text
            antecedente("observacion") = TXT_OBSERVACION.Text
            antecedente("cargo") = TXT_CARGO.Text

            antecedente("descripcion_cargo") = TXT_DES_CARGO.Text
            antecedente("cond_ambi") = LISTA_AMBIENTALES.Text
            antecedente("cond_activ") = LISTA_ACTIVIDADES.Text
            antecedente("cond_carga") = LISTA_CARGA.Text
            antecedente("cond_riesgo") = lISTA_RIESGOS.Text

        Next

      


    End Sub

  


    Private Sub FrmAntecedentesLaborales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each antecedente As DataRow In antecedentes
            TXT_EMPRESA.Text = antecedente("empresa").ToString
            TXT_DURACION.Text = antecedente("duracion").ToString
            TXT_HORARIO.Text = antecedente("horario").ToString
            TXT_INDUSTRIA.Text = antecedente("industria").ToString
            TXT_SALUD.Text = antecedente("problemas_salud").ToString
            TXT_ACCIDENTE.Text = antecedente("accidente_laboral").ToString
            TXT_ENFERMEDAD.Text = antecedente("enfermedad_ocupacional").ToString
            TXT_OBSERVACION.Text = antecedente("observacion").ToString
            TXT_CARGO.Text = antecedente("cargo").ToString
            TXT_DES_CARGO.Text = antecedente("descripcion_cargo").ToString
            LISTA_AMBIENTALES.Text = antecedente("cond_ambi").ToString
            LISTA_ACTIVIDADES.Text = antecedente("cond_activ").ToString
            LISTA_CARGA.Text = antecedente("cond_carga").ToString
            lISTA_RIESGOS.Text = antecedente("cond_riesgo").ToString

        Next



        GRID_RIESGOS.DataSource = riesgos
        GRID_RIESGOS.Columns("id").Visible = False
        GRID_RIESGOS.Columns("id_antecedente").Visible = False
        GRID_RIESGOS.Columns("reng_num").Visible = False
        GRID_RIESGOS.Columns("id_riesgo").Width = 45
        GRID_RIESGOS.Columns("nombre").Width = 150

        GRID_EQUIPOS.DataSource = equipos
        GRID_EQUIPOS.Columns("id").Visible = False
        GRID_EQUIPOS.Columns("id_antecedente").Visible = False
        GRID_EQUIPOS.Columns("reng_num").Visible = False
        GRID_EQUIPOS.Columns("id_equipo").Width = 45
        GRID_EQUIPOS.Columns("nombre").Width = 200







    End Sub

   

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        'GRID_RIESGOS.AllowUserToAddRows = False
        For i = 0 To GRID_RIESGOS.Rows.Count - 1
            If GRID_RIESGOS.Item("reng_num", i).Value.ToString = DBNull.Value.ToString Then
                GRID_RIESGOS.CurrentCell = Nothing
                GRID_RIESGOS.Rows(i).Visible = False
                Continue For
            End If
            If GRID_RIESGOS.Item("reng_num", i).Value = antecedentes(0)("reng_num") Then
                GRID_RIESGOS.Rows(i).Visible = True
            Else
                GRID_RIESGOS.CurrentCell = Nothing
                GRID_RIESGOS.Rows(i).Visible = False
            End If
        Next
        'riesgos.DefaultView.RowFilter = "reng_num = " & antecedentes(0)("reng_num")

    End Sub

    

   


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim busqueda As New FrmBusquedaQry("a.id, a.nombre,b.nombre tipo", "RIESGOS_LABORALES a,CLASIFICACION_RIESGO_LABORAL b", "nombre a.nombre", "tipo b.nombre", "a.id_clasificacion=b.id", ordenPR:="nombre")
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub
        riesgos.Rows.Add()

        GRID_RIESGOS.Item("id_riesgo", GRID_RIESGOS.Rows.Count - 1).Value = resultado(0)
        GRID_RIESGOS.Item("reng_num", GRID_RIESGOS.Rows.Count - 1).Value = antecedentes(0)("reng_num")
        GRID_RIESGOS.Item("nombre", GRID_RIESGOS.Rows.Count - 1).Value = resultado(1)
        GRID_RIESGOS.Item("tipo", GRID_RIESGOS.Rows.Count - 1).Value = resultado(2)



    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If GRID_RIESGOS.CurrentCell Is Nothing Then Exit Sub
        GRID_RIESGOS.Rows.RemoveAt(GRID_RIESGOS.CurrentCell.RowIndex)
    End Sub

    Private Sub GRID_RIESGOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_RIESGOS.CellContentClick

    End Sub

    Private Sub GRID_RIESGOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_RIESGOS.CellDoubleClick
        If e.ColumnIndex = GRID_RIESGOS.Columns("observacion").Index Then
            GRID_RIESGOS.Item(e.ColumnIndex, e.RowIndex).Value = Expandir(GRID_RIESGOS.Item(e.ColumnIndex, e.RowIndex).Value, "Observacion")
        End If
    End Sub

    

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim busqueda As New FrmBusquedaQry("id, nombre", "EQUIPOS_LABORALES", "nombre", "tipo", "", ordenPR:="nombre")
        Dim resultado As List(Of String) = busqueda.ejecutar()
        If resultado.Count = 0 Then Exit Sub
        equipos.Rows.Add()

        GRID_EQUIPOS.Item("id_equipo", GRID_EQUIPOS.Rows.Count - 1).Value = resultado(0)
        GRID_EQUIPOS.Item("reng_num", GRID_EQUIPOS.Rows.Count - 1).Value = antecedentes(0)("reng_num")
        GRID_EQUIPOS.Item("nombre", GRID_EQUIPOS.Rows.Count - 1).Value = resultado(1)

    End Sub

 

    Private Sub GRID_EQUIPOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_EQUIPOS.CellDoubleClick
        If e.ColumnIndex = GRID_EQUIPOS.Columns("observacion").Index Then
            GRID_RIESGOS.Item(e.ColumnIndex, e.RowIndex).Value = Expandir(GRID_EQUIPOS.Item(e.ColumnIndex, e.RowIndex).Value, "Observacion")
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If GRID_EQUIPOS.CurrentCell Is Nothing Then Exit Sub
        GRID_EQUIPOS.Rows.RemoveAt(GRID_EQUIPOS.CurrentCell.RowIndex)
    End Sub
End Class