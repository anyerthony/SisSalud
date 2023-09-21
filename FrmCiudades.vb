
Public Class FrmCiudades
    Dim tabla As DataTable
    Dim ds As DataSet
    Dim source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.CIUDADESTableAdapter
    Dim botonera As CtrlSource

    Private Sub FrmCiudades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS.CIUDADES' table. You can move, or remove it, as needed.


        tabla = Me.DataSet_IPSS.CIUDADES
        source = CIUDADESBindingSource
        ds = source.DataSource
        adaptador = CIUDADESTableAdapter

        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)


        adaptador.Fill(tabla)

    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        botonera.Buscar()
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

End Class