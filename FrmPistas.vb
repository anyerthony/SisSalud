Public Class FrmPistas
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.PISTASTableAdapter
    Dim botonera As CtrlSource

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tabla = Me.DataSet_IPSS.PISTAS
        source = PISTASBindingSource
        ds = source.DataSource
        adaptador = PISTASTableAdapter

        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)

        adaptador.Fill(tabla)
    End Sub

    Private Sub FrmPistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS_FILES.ARCHIVOS1' table. You can move, or remove it, as needed.
       
        

    End Sub

End Class