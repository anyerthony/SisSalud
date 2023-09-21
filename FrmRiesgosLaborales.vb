Public Class FrmRiesgosLaborales
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.RIESGOS_LABORALESTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmRiesgosLaborales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS.CLASIFICACION_RIESGO_LABORAL' table. You can move, or remove it, as needed.
        Me.CLASIFICACION_RIESGO_LABORALTableAdapter.Fill(Me.DataSet_IPSS.CLASIFICACION_RIESGO_LABORAL)
        'TODO: This line of code loads data into the 'DataSet_IPSS.RIESGOS_ANTECEDENTE_LABORAL' table. You can move, or remove it, as needed.
        
        tabla = Me.DataSet_IPSS.RIESGOS_LABORALES
        source = RIESGOSLABORALESBindingSource
        ds = source.DataSource
        adaptador = RIESGOS_LABORALESTableAdapter

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