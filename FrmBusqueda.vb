Public Class FrmBusqueda
    Public ds As DataSet
    Public tabla As DataTable
    Public source As BindingSource

    Sub Buscar()
        Dim LIK1 As String = IIf(RB_ALL.Checked, "%", "")
        Dim LIK2 As String = IIf(RB_EXACTA.Checked, "", "%")
        Dim LIK3 As String = " LIKE "
        Dim COLUM As String = IIf(RB_COLUMN1.Checked, RB_COLUMN1.Text, RB_COLUMN2.Text)
        If RB_OTRO.Checked = True Then
            COLUM = RB_OTRO.Text
        End If
        Dim numero As String = IIf(tabla.Columns(COLUM).DataType.Name = GetType(Integer).Name, "", "'")
        If numero = "" Then
            LIK1 = ""
            LIK2 = ""
            LIK3 = " = "
        End If
        Dim TXT As String = UCase(TXT_BUSQUEDA.Text)
        If TXT = "" And numero = "" Then TXT = 0
        source.Filter = COLUM & LIK3 & numero & LIK1 & TXT & LIK2 & numero
    End Sub

    'Private Sub FrmBusqueda_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    source.Filter = ""
    'End Sub

    Private Sub FrmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GRID.DataSource = source
        'GRID.DataMember = tabla.TableName
        RB_COLUMN1.Text = tabla.Columns(0).ColumnName
        RB_COLUMN2.Text = tabla.Columns(1).ColumnName
        GRID.Columns(RB_COLUMN2.Text).Width = 250
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Seleccionar()
    End Sub

    Private Sub TXT_BUSQUEDA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSQUEDA.TextChanged
        Buscar()
    End Sub
    Sub Seleccionar()
        Dim actual As Object = source.Current
        'TXT_BUSQUEDA.Text = ""
        source.Position = source.IndexOf(actual)
        Me.Close()
    End Sub

    Private Sub GRID_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellContentClick

    End Sub

    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        Seleccionar()
    End Sub

 
    Private Sub RB_OTRO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_OTRO.CheckedChanged
        If RB_OTRO.Checked = True Then
            RB_OTRO.Text = InputBox("Indique el nombre de la columna por la cual desea filtrar")
        End If
    End Sub
End Class