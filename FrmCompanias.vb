Public Class FrmCompanias
    Dim tabla As DataTable
    Dim ds As DataSet
    Dim source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.COMPAÑIASTableAdapter
    Dim botonera As CtrlSource

    Private Sub FrmCompanias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        botonera.ValidarCambios()
    End Sub


    Private Sub FrmCompanias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        source = COMPAÑIASBindingSource
        ds = source.DataSource
        tabla = Me.DataSet_IPSS.COMPAÑIAS
        adaptador = COMPAÑIASTableAdapter
        'adaptador.Connection.ConnectionString = BindingSourceCON


        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)



        Me.COMPAÑIASTableAdapter.Fill(Me.DataSet_IPSS.COMPAÑIAS)



    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        botonera.Buscar()
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        botonera.Guardar()
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        botonera.Add()
    End Sub

    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        botonera.Eliminar()
    End Sub
End Class