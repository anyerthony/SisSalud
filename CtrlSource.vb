Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Data.Common

Public Class CtrlSource
    Dim tabla As DataTable
    Dim ds As DataSet
    Dim source As BindingSource
    Dim adaptador As Object
    Dim co_us_mod As New TextBox
    Dim fecha As New TextBox
    Dim formulario As Form
    Dim sourcePrincipal As Boolean
    Public aceptaCambios As Boolean = True
    Public cambiosGuardados As Boolean = False
    Sub New(ByVal tb As DataTable, ByVal dst As DataSet, ByVal sr As BindingSource, ByVal ad As Object, ByVal frm As Form)
        Try
            tabla = tb
            ds = dst
            source = sr
            adaptador = ad
            formulario = frm



            co_us_mod.DataBindings.Add("Text", source, "co_us")
            fecha.DataBindings.Add("Text", source, "fecha")


            formulario.Controls.Add(co_us_mod)
            co_us_mod.Visible = False

            formulario.Controls.Add(fecha)
            fecha.Visible = False

            sourcePrincipal = Not TypeOf source.DataSource Is BindingSource

            If sourcePrincipal Then
                AgregarListener(formulario)

                AddHandler formulario.KeyDown, AddressOf TeclaPulsada
                AddHandler formulario.FormClosing, AddressOf cerrar
            End If


        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "New")
        End Try




    End Sub

    Private Sub AgregarListener(ByVal padre As Object)
        Try
            For Each c As Control In padre.Controls
                For Each cc As Control In c.Controls
                    AgregarListener(cc)
                Next
                If TypeOf c Is TextBox Or TypeOf c Is DevComponents.DotNetBar.Controls.DataGridViewX Or TypeOf c Is DevComponents.DotNetBar.ButtonX Then
                   
                    AddHandler c.KeyDown, AddressOf TeclaPulsada
                End If
            Next
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "AgregarListener")
        End Try

    End Sub

    Private Sub TeclaPulsada(ByVal sender As Object, ByVal e As KeyEventArgs)
        Try
            If e.Control AndAlso e.KeyCode = Keys.U Then
                ' La combinación de teclas Ctrl + A se presionó
                'MessageBox.Show("Se presionó la combinación de teclas Ctrl + U en el formulario " & formulario.Text)
                Dim pistas As New FrmPistas
                pistas.source.Filter = "id_fila = " & tabla.Rows(source.Position).Item(0).ToString & " and tabla = '" & tabla.TableName & "'"
                pistas.ShowDialog()
            ElseIf e.Control AndAlso e.KeyCode = Keys.B Then
                Buscar()
            ElseIf e.KeyCode = Keys.F2 And sender.DataBindings("tag") IsNot Nothing Then
                BuscarEn(sender.databindings("Tag").datasource)
                If TypeOf sender Is DevComponents.DotNetBar.Controls.DataGridViewX Then
                    sender.rows.item(sender.currentrow.index).cells(1).value = sender.DataBindings("tag").Datasource.current.row.id
                Else
                    sender.Text = sender.DataBindings("tag").Datasource.current.row.id
                End If


            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "TeclaPulsada")
        End Try
        ' Verifica si se presionó la combinación de teclas Ctrl + A

    End Sub
    Sub cerrar()
        If CambiosPendientes() Then
            If SourceAceptarCambios() Then
                Guardar()
            Else
                For Each tablai As DataTable In ds.Tables
                    tablai.RejectChanges()
                Next
            End If
        End If
    End Sub



    Sub Primero()
        If sourcePrincipal Then ValidarCambios()

        Try
            source.MoveFirst()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Primero")
        End Try

    End Sub



    Sub ValidarCambios()

        Try
            source.EndEdit()
            If tabla.GetChanges() IsNot Nothing Then
                If SourceAceptarCambios() Then
                    adaptador.Update(tabla)

                Else
                    tabla.RejectChanges()
                End If
            End If
            If aceptaCambios Then AceptarCambios()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "ValidarCambios")
        End Try

    End Sub

    Function CambiosPendientes() As Boolean
        Dim hayCambios As Boolean = False
        Try
            source.EndEdit()
            For Each tablai As DataTable In ds.Tables
                If UCase(tablai.TableName) = "ARCHIVOS" Then Continue For
                If tablai.GetChanges() IsNot Nothing Then
                    hayCambios = True
                End If
            Next
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "CambiosPendientes")
        End Try
        Return hayCambios
    End Function

    Sub Anterior()
        If sourcePrincipal Then ValidarCambios()
        Try
            source.MovePrevious()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Anterior")
        End Try

    End Sub

    Sub Siguiente()
        If sourcePrincipal Then ValidarCambios()
        Try
            source.MoveNext()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Siguiente")
        End Try

    End Sub

    Sub Ultimo()
        If sourcePrincipal Then ValidarCambios()
        Try
            source.MoveLast()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Ultimo")
        End Try

    End Sub

    Sub Buscar()
        If sourcePrincipal Then ValidarCambios()
        Try
            Dim Formulario_busqueda As New FrmBusqueda
            Formulario_busqueda.ds = ds
            Formulario_busqueda.tabla = tabla
            Formulario_busqueda.source = source
            Formulario_busqueda.Text = "Buscar " & tabla.TableName

            'Formulario_busqueda.MdiParent = MDIPrincipal
            Formulario_busqueda.ShowDialog()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Buscar")
        End Try

    End Sub
    Sub BuscarEn(ByVal en As BindingSource)
        Try
            Dim Formulario_busqueda As New FrmBusqueda
            Formulario_busqueda.ds = ds
            Formulario_busqueda.tabla = ds.Tables(en.DataMember)
            Formulario_busqueda.source = en
            Formulario_busqueda.Text = "Buscar en " & en.DataMember

            'Formulario_busqueda.MdiParent = MDIPrincipal
            Formulario_busqueda.ShowDialog()
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "BuscarEn")
        End Try
        'ValidarCambios()

    End Sub

    Sub Add()
        If sourcePrincipal Then ValidarCambios()

        Try
            source.AddNew()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Add")
        End Try

    End Sub


    Sub Guardar()

        cambiosGuardados = False
        source.EndEdit()
        If tabla.GetChanges() Is Nothing Then Exit Sub
        Try
            'co_us_mod.Text = Cod_Usuario
            'fecha.Text = Date.Now().ToString
            For Each fila As DataRow In tabla.Rows
                If fila.RowState = DataRowState.Added Or fila.RowState = DataRowState.Modified Then
                    fila.Item("co_us") = Cod_Usuario
                    fila.Item("fecha") = Date.Now().ToString
                End If



            Next
            source.Filter = ""
            Dim actual As Integer = source.Position





            'For Each TableAd As FieldInfo In formulario.GetType().GetFields(BindingFlags.Instance Or BindingFlags.NonPublic)
            '    If TableAd.Name Like "*TableAdapter*" Then
            '        Dim TableName As String = TableAd.ToString.Replace(TableAd.ToString.Substring(TableAd.ToString.IndexOf(" ")), "")
            '        TableName = Replace(TableName, "TableAdapter", "")
            '        TableName = TableName.Substring(TableName.LastIndexOf(".") + 1)
            '        Dim TT As Object = TableAd.GetValue(formulario)
            '        Try

            '        Catch ex As Exception

            '        End Try
            '        TT.Update(ds.Tables(TableName))
            '    End If
            'Next

            source.EndEdit()
            adaptador.Update(tabla)



            If aceptaCambios Then
                adaptador.Fill(tabla)
                AceptarCambios()
            End If



            If actual < 0 Then
                source.MoveLast()
            Else
                source.Position = actual
            End If

            cambiosGuardados = True
            If sourcePrincipal Then
                MsgBox("Guardado con éxito", MsgBoxStyle.Information, "Guardar")
            Else
                source.DataSource.datasource.tables(source.DataSource.datamember).rows(0).item("co_us") = source.DataSource.datasource.tables(source.DataSource.datamember).rows(0).item("co_us")
            End If

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Guardar")
        End Try

    End Sub
    Sub AceptarCambios()
        tabla.AcceptChanges()
    End Sub
    Sub Fill()
        adaptador.Fill(tabla)
    End Sub

    Sub Eliminar()
        If sourcePrincipal Then
            Try
                If (MsgBox("Desea eliminar el registro actual?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes) Then
                    source.RemoveCurrent()
                    adaptador.Update(tabla)
                End If
            Catch ex As Exception
                ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "Eliminar")
            End Try
        Else
            source.RemoveCurrent()
        End If


    End Sub

    Function GenerarIdArchivo() As Integer
        Try
            Dim SW As Integer = 0, IdImagen As Integer
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & "_FILES;User ID=" & UserSystem & ";Password=" & PasswordSystem)

            Dim cmd As SqlCommand = con.CreateCommand()

            StrSQL = "INSERT IPSS_FILES..ARCHIVOS (archivo) SELECT NULL IMAGEN"
            ProcesarModificacion(StrSQL)

            StrSQL = "SELECT MAX(ID) ID FROM ARCHIVOS"
            Dim cmd2 As SqlCommand = con.CreateCommand()
            con.Open()
            cmd2.CommandText = StrSQL
            Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
            While Arreglo2.Read
                IdImagen = Arreglo2("ID")
            End While

            con.Close()


            Return IdImagen
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, "CtrlSource", "GenerarIdArchivo")
        End Try

    End Function

  

End Class
