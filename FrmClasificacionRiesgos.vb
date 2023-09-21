Public Class FrmClasificacionRiesgos
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.CLASIFICACION_RIESGO_LABORALTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmClasificacionRiesgos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        tabla = Me.DataSet_IPSS.CLASIFICACION_RIESGO_LABORAL
        source = CLASIFICACIONRIESGOLABORALBindingSource
        ds = source.DataSource
        adaptador = CLASIFICACION_RIESGO_LABORALTableAdapter

        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)

        adaptador.Fill(tabla)
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
End Class