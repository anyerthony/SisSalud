Public Class FrmAgencias
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.AGENCIASTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmAgencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS.ZONAS' table. You can move, or remove it, as needed.
        Me.ZONASTableAdapter.Fill(Me.DataSet_IPSS.ZONAS)
        'TODO: This line of code loads data into the 'DataSet_IPSS.CIUDADES' table. You can move, or remove it, as needed.
        Me.CIUDADESTableAdapter.Fill(Me.DataSet_IPSS.CIUDADES)

        tabla = Me.DataSet_IPSS.AGENCIAS
        source = AGENCIASBindingSource
        ds = source.DataSource
        adaptador = AGENCIASTableAdapter

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

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        source.EndEdit()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        source.EndEdit()
    End Sub
End Class