Public Class FrmAntecedentesMedicos
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.ANTECEDENTES_MEDICOSTableAdapter
    Dim botonera As CtrlSource
    Private Sub FrmAntecedentesMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS.TIPO_ANTECEDENTE_MEDICO' table. You can move, or remove it, as needed.
        Me.TIPO_ANTECEDENTE_MEDICOTableAdapter.Fill(Me.DataSet_IPSS.TIPO_ANTECEDENTE_MEDICO)

        tabla = Me.DataSet_IPSS.ANTECEDENTES_MEDICOS
        source = ANTECEDENTESMEDICOSBindingSource
        ds = source.DataSource
        adaptador = ANTECEDENTES_MEDICOSTableAdapter

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

  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        source.EndEdit()
        TIPO_ANTECEDENTE_MEDICOTableAdapter.Fill(Me.DataSet_IPSS.TIPO_ANTECEDENTE_MEDICO)
    End Sub
End Class