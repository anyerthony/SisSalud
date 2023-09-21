Public Class FrmBusquedaQry
    Public nombreTabla As String
    Public columnas As String
    Public filtro1 As String
    Public filtro2 As String
    Public filtroObigatorio As String
    Public orden As String
    Dim SQL_FILTRO1 As String
    Dim SQL_FILTRO2 As String

    Public seleccion As New List(Of String)
    Public WidthColumnas As New Dictionary(Of Integer, Integer)
    Public columnasOcultas As New List(Of Integer)


    Dim tabla As New DataTable


    Sub New(ByVal columnasPR As String, ByVal tablaPR As String, Optional ByVal filtro1PR As String = "", Optional ByVal filtro2PR As String = "", Optional ByVal filtroObligatorioPR As String = "", Optional ByVal ordenPR As String = "")

        SQL_FILTRO1 = filtro1PR.Substring(filtro1PR.IndexOf(" ") + 1, filtro1PR.Length - (filtro1PR.IndexOf(" ") + 1))
        SQL_FILTRO2 = filtro2PR.Substring(filtro2PR.IndexOf(" ") + 1, filtro2PR.Length - (filtro2PR.IndexOf(" ") + 1))

        If filtro1PR.Length > 0 Then
            filtro1PR = filtro1PR.Replace(SQL_FILTRO1, "")
        End If
        If filtro2PR.Length > 0 Then
            filtro2PR = filtro2PR.Replace(SQL_FILTRO2, "")
        End If



        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If filtro1PR.Length = 0 Then
            filtro1PR = SQL_FILTRO1
        End If
        If filtro2PR.Length = 0 Then
            filtro2PR = SQL_FILTRO2
        End If

        ' Add any initialization after the InitializeComponent() call.
        nombreTabla = tablaPR
        columnas = columnasPR
        filtro1 = filtro1PR
        filtro2 = filtro2PR
        filtroObigatorio = filtroObligatorioPR
        orden = ordenPR
    End Sub


    Sub Buscar()

        Dim LIK1 As String = IIf(RB_ALL.Checked, "%", "")
        Dim LIK2 As String = IIf(RB_EXACTA.Checked, "", "%")
        Dim LIK3 As String = " LIKE "
        Dim COLUM As String = IIf(RB_COLUMN1.Checked, SQL_FILTRO1, SQL_FILTRO2)
        If RB_OTRO.Checked = True Then
            COLUM = RB_OTRO.Text
        End If

        Try
            tabla = SelectSQL("SELECT " & columnas & " FROM " & nombreTabla & " WHERE " & COLUM & " LIKE '" & LIK1 & TXT_BUSQUEDA.Text & LIK2 & "' " & IIf(filtroObigatorio.Length = 0, "", "AND " & filtroObigatorio) & IIf(orden.Length = 0, "", " ORDER BY " & orden))
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.Message, "FrmBusquedaQry", "Buscar")
        End Try

        GRID.DataSource = tabla


        For Each key As Integer In WidthColumnas.Keys
            GRID.Columns(key).Width = WidthColumnas.Item(key)
        Next



    End Sub

    'Private Sub FrmBusqueda_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    source.Filter = ""
    'End Sub

    Private Sub FrmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RB_COLUMN1.Text = filtro1
        RB_COLUMN2.Text = filtro2
        'GRID.Columns(RB_COLUMN2.Text).Width = 250

        If RB_COLUMN1.Text = "" Then RB_COLUMN1.Enabled = False
        If RB_COLUMN2.Text = "" Then RB_COLUMN2.Enabled = False

        'Me.Text = Me.Text & " " & LCase(nombreTabla)



    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Seleccionar()
    End Sub

  
    Sub Seleccionar()
        seleccion.Clear()
        For i = 0 To GRID.CurrentRow.Cells.Count - 1
            seleccion.Add(GRID.CurrentRow.Cells(i).Value.ToString)
        Next
        Me.Close()
    End Sub

   

    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        Seleccionar()
    End Sub


    Private Sub RB_OTRO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_OTRO.CheckedChanged
        If RB_OTRO.Checked = True Then
            RB_OTRO.Text = InputBox("Indique el nombre de la columna por la cual desea filtrar")
        End If
    End Sub


    Private Sub TXT_BUSQUEDA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BUSQUEDA.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar()
            GRID.Select()

        End If
    End Sub
    Function ejecutar() As List(Of String)
        Me.ShowDialog()
        Return seleccion
    End Function
   

    Private Sub GRID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Seleccionar()
        End If
    End Sub
End Class