Public Class FrmEquiposLaborales
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.EQUIPOS_LABORALESTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmEquiposLaborales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tabla = Me.DataSet_IPSS.EQUIPOS_LABORALES
        source = EQUIPOSLABORALESBindingSource
        ds = source.DataSource
        adaptador = EQUIPOS_LABORALESTableAdapter

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