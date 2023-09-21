Public Class FrmConceptos
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.CONCEPTOSTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmConceptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tablatipos As New DataTable
        tablatipos.Columns.Add("cod")
        tablatipos.Columns.Add("nombre")

        tablatipos.Rows.Clear()
        tablatipos.Rows.Add("E", "Examen")
        tablatipos.Rows.Add("P", "Procedimiento")
        tablatipos.Rows.Add("I", "Insumo")

        LISTA_TIPOS.DataSource = tablatipos


        'TODO: This line of code loads data into the 'DataSet_IPSS.ESPECIALIDADES' table. You can move, or remove it, as needed.
        Me.ESPECIALIDADESTableAdapter.Fill(Me.DataSet_IPSS.ESPECIALIDADES)
        'TODO: This line of code loads data into the 'DataSet_IPSS.CLASIFICACION_CONCEPTOS' table. You can move, or remove it, as needed.
        Me.CLASIFICACION_CONCEPTOSTableAdapter.Fill(Me.DataSet_IPSS.CLASIFICACION_CONCEPTOS)
        'TODO: This line of code loads data into the 'DataSet_IPSS.CONCEPTOS' table. You can move, or remove it, as needed.

        tabla = Me.DataSet_IPSS.CONCEPTOS
        source = CONCEPTOSBindingSource
        ds = source.DataSource
        adaptador = CONCEPTOSTableAdapter

        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)

        adaptador.Fill(tabla)




    End Sub

    Private Sub LISTA_TIPOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTA_TIPOS.SelectedIndexChanged
        If LISTA_TIPOS.SelectedValue.ToString = "E" Then
            L_TIPO_EXAMEN.Visible = True
            LISTA_TIPO_EXAMEN.Visible = True
        Else
            L_TIPO_EXAMEN.Visible = False
            LISTA_TIPO_EXAMEN.Visible = False

            LISTA_TIPO_EXAMEN.Text = ""
        End If
    End Sub


    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        botonera.Eliminar()
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        botonera.Add()
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        botonera.Guardar()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        botonera.Buscar()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        source.EndEdit()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        source.EndEdit()
    End Sub
End Class