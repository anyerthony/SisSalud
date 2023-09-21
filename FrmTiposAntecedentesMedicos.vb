Public Class FrmTiposAntecedentesMedicos
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.TIPO_ANTECEDENTE_MEDICOTableAdapter
    Dim botonera As CtrlSource
  


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
    Private Sub FrmTiposAntecedentesMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tabla = Me.DataSet_IPSS.TIPO_ANTECEDENTE_MEDICO
        source = TIPOANTECEDENTEMEDICOBindingSource
        ds = source.DataSource
        adaptador = TIPO_ANTECEDENTE_MEDICOTableAdapter

        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)

        adaptador.Fill(tabla)
    End Sub
End Class