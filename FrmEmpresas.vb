Public Class FrmEmpresas
    Dim tabla As DataTable
    Dim ds As DataSet
    Public source As BindingSource
    Dim adaptador As SisSalud.DataSet_IPSSTableAdapters.EMPRESASTableAdapter
    Dim botonera As CtrlSource
    Dim aseguradoras As CtrlSource
    Dim clientes As CtrlSource

    Private Sub FrmEmpresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_IPSS.DEPENDENCIAS' table. You can move, or remove it, as needed.
        Me.DEPENDENCIASTableAdapter.Fill(Me.DataSet_IPSS.DEPENDENCIAS)
        'TODO: This line of code loads data into the 'DataSet_IPSS.CLIENTES' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet_IPSS.EMPRESA_CLIENTE' table. You can move, or remove it, as needed.
        Me.EMPRESA_CLIENTETableAdapter.Fill(Me.DataSet_IPSS.EMPRESA_CLIENTE)
        Me.EMPRESASTableAdapter.Fill(Me.DataSet_IPSS.EMPRESAS)
        Me.EMPRESA_ASEGURADORATableAdapter.Fill(Me.DataSet_IPSS.EMPRESA_ASEGURADORA)
        'TODO: This line of code loads data into the 'DataSet_IPSS.GRUPO_EMPRESAS' table. You can move, or remove it, as needed.
        Me.GRUPO_EMPRESASTableAdapter.Fill(Me.DataSet_IPSS.GRUPO_EMPRESAS)
        'TODO: This line of code loads data into the 'DataSet_IPSS.CIUDADES' table. You can move, or remove it, as needed.
        Me.CIUDADESTableAdapter.Fill(Me.DataSet_IPSS.CIUDADES)
        'TODO: This line of code loads data into the 'DataSet_IPSS.ZONAS' table. You can move, or remove it, as needed.
        Me.ZONASTableAdapter.Fill(Me.DataSet_IPSS.ZONAS)
        'TODO: This line of code loads data into the 'DataSet_IPSS.PAISES' table. You can move, or remove it, as needed.
        Me.PAISESTableAdapter.Fill(Me.DataSet_IPSS.PAISES)
        'TODO: This line of code loads data into the 'DataSet_IPSS.FORMATOS_FACTURA' table. You can move, or remove it, as needed.
        Me.FORMATOS_FACTURATableAdapter.Fill(Me.DataSet_IPSS.FORMATOS_FACTURA)

        tabla = Me.DataSet_IPSS.EMPRESAS
        source = EMPRESASBindingSource
        ds = source.DataSource
        adaptador = EMPRESASTableAdapter
        botonera = New CtrlSource(tabla, ds, source, adaptador, Me)
        aseguradoras = New CtrlSource(DataSet_IPSS.EMPRESA_ASEGURADORA, ds, FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource, EMPRESA_ASEGURADORATableAdapter, Me)
        clientes = New CtrlSource(DataSet_IPSS.EMPRESA_CLIENTE, ds, FKEMPRESACLIENTEEMPRESACLIENTEBindingSource, EMPRESA_CLIENTETableAdapter, Me)

        adaptador.Fill(tabla)


        GRID_ASEGURADORAS.Columns(0).Visible = False

       
    End Sub


    Private Sub BTN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ELIMINAR.Click
        botonera.Eliminar()
    End Sub

    Private Sub BTN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_NUEVO.Click
        botonera.Add()
    End Sub

    Private Sub BTN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDAR.Click
        'FKEMPRESAASEGURADORAEMPRESAASEGURADORABindingSource.EndEdit()
        'If DataSet_IPSS.EMPRESA_ASEGURADORA.GetChanges().Rows.Count > 0 Then

        '    EMPRESA_ASEGURADORATableAdapter.Update(DataSet_IPSS.EMPRESA_ASEGURADORA)
        '    EMPRESA_ASEGURADORATableAdapter.Fill(DataSet_IPSS.EMPRESA_ASEGURADORA)
        'End If

        EMPRESA_ASEGURADORATableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE [IPSS].[dbo].[EMPRESA_ASEGURADORA] SET [id_empresa] = ?, [id_aseguradora] = ?, [co_us] = ?, [fecha] = ?, [auxiliar] = ? WHERE (([id] = ?) AND ((? = 1 AND [id_empresa] IS NULL) OR ([id_empresa] = ?)) AND ((? = 1 AND [id_aseguradora] IS NULL) OR ([id_aseguradora] = ?)) AND ((? = 1 AND [co_us] IS NULL) OR ([co_us] = ?)) AND ((? = 1 AND [fecha] IS NULL) OR ([fecha] = ?)) AND ((? = 1 AND [auxiliar] IS NULL) OR ([auxiliar] = ?) OR 1=1))"
        aseguradoras.Guardar()
        clientes.Guardar()
        botonera.Guardar()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        botonera.Buscar()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        CheckBox3.Checked = Not CheckBox3.Checked
        botonera.Guardar()
    End Sub

    Private Sub TXT_ID_BAREMO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        source.EndEdit()
    End Sub

   
    Private Sub DataGridViewX1_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ASEGURADORAS.CellValueChanged
        If e.ColumnIndex = 2 Then
            Dim tmp As New DataTable
            If GRID_ASEGURADORAS.Rows.Count > 1 Then tmp = SelectSQL("select nombre from empresas where id = " & GRID_ASEGURADORAS.Item(2, e.RowIndex).Value)
            If tmp.Rows.Count > 0 Then
                Dim nombre As String = tmp.Rows(0).Item(0)
                If nombre.Length = 0 Then nombre = ""
                GRID_ASEGURADORAS.Item(5, e.RowIndex).Value = nombre
            End If
        End If
    End Sub


    Private Sub GRID_ASEGURADORAS_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ASEGURADORAS.CellEndEdit
        'If e.ColumnIndex = 2 Then
        '    Dim tmp As New DataTable
        '    If GRID_ASEGURADORAS.Rows.Count > 1 Then tmp = SelectSQL("select nombre from empresas where id = " & GRID_ASEGURADORAS.Item(2, e.RowIndex).Value)
        '    If tmp.Rows.Count > 0 Then
        '        Dim nombre As String = tmp.Rows(0).Item(0)
        '        If nombre.Length = 0 Then nombre = ""
        '        GRID_ASEGURADORAS.Item(5, e.RowIndex).Value = nombre
        '    End If
        'End If

    End Sub

   
    Private Sub GRID_ASEGURADORAS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_ASEGURADORAS.CellContentClick

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAB_EMPRESA_ASEGURADORA.Click

    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        If e.TabPageIndex <> 0 And Val(TXT_ID_CLIENTE.Text) < 0 Then
            If SourceAceptarCambios() Then
                botonera.Guardar()
            Else
                tabla.RejectChanges()
            End If
        End If
        'If e.TabPage.Name = "TAB_EMPRESA_ASEGURADORA" Then
        '    For i = 0 To GRID_ASEGURADORAS.Rows.Count - 1
        '        Dim tmp As New DataTable
        '        If GRID_ASEGURADORAS.Item(2, i).Value = Nothing Then Continue For
        '        tmp = SelectSQL("select nombre from empresas where id = " & GRID_ASEGURADORAS.Item(2, i).Value)
        '        If tmp.Rows.Count > 0 Then
        '            Dim nombre As String = tmp.Rows(0).Item(0)
        '            If nombre.Length = 0 Then nombre = ""
        '            GRID_ASEGURADORAS.Item(5, i).Value = nombre
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
       
    End Sub

    Private Sub GRID_ASEGURADORAS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_ASEGURADORAS.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim busqueda As New FrmBusqueda
            busqueda.ds = Me.DataSet_IPSS
            busqueda.tabla = DataSet_IPSS.EMPRESAS
            busqueda.source = EMPRESASBindingSource1
            busqueda.Text = "Buscar en " & EMPRESASBindingSource1.DataMember

            busqueda.ShowDialog()

            Dim rowid As Integer = GRID_ASEGURADORAS.CurrentRow.Index

            If GRID_ASEGURADORAS.CurrentRow.Index = GRID_ASEGURADORAS.Rows.Count - 1 Then
                aseguradoras.Add()
                aseguradoras.Eliminar()
                rowid = GRID_ASEGURADORAS.Rows.Count - 2
            End If

            GRID_ASEGURADORAS.Item(2, rowid).Value = EMPRESASBindingSource1.Current.row.id
      
        End If
    End Sub

   
    Private Sub TXT_ID_CLIENTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID_CLIENTE.TextChanged
      
    End Sub

    Private Sub GRID_TRABAJADORES_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_TRABAJADORES.CellValueChanged
        If e.ColumnIndex = 2 Then
            Dim tmp As New DataTable
            If GRID_TRABAJADORES.Rows.Count > 1 Then tmp = SelectSQL("select isnull(rif,'') + ' - ' + isnull(nombre,'') + ' ' + isnull(apellido,'') from clientes where id = " & GRID_TRABAJADORES.Item(2, e.RowIndex).Value)
            If tmp.Rows.Count > 0 Then
                Dim nombre As String = tmp.Rows(0).Item(0)
                If nombre.Length = 0 Then nombre = ""
                GRID_TRABAJADORES.Item(5, e.RowIndex).Value = nombre
            End If
        End If
    End Sub

    Private Sub GRID_TRABAJADORES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID_TRABAJADORES.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim busqueda As New FrmBusqueda
            busqueda.ds = Me.DataSet_IPSS
            busqueda.tabla = DataSet_IPSS.PACIENTES
            busqueda.source = CLIENTESBindingSource
            busqueda.Text = "Buscar en " & CLIENTESBindingSource.DataMember

            busqueda.ShowDialog()

            Dim rowid As Integer = GRID_TRABAJADORES.CurrentRow.Index

            If GRID_TRABAJADORES.CurrentRow.Index = GRID_TRABAJADORES.Rows.Count - 1 Then
                clientes.Add()
                clientes.Eliminar()
                rowid = GRID_TRABAJADORES.Rows.Count - 2
            End If

            GRID_TRABAJADORES.Item(2, rowid).Value = CLIENTESBindingSource.Current.row.id

        End If
    End Sub
End Class