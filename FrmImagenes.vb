Imports System.Data.SqlClient

Public Class FrmImagenes
    Dim DSimagen As Data.DataSet
    Dim AdaptadorTabimg As System.Data.SqlClient.SqlDataAdapter
    Dim cb As System.Data.SqlClient.SqlCommandBuilder
    Dim IdImagen As Integer

    Sub ValidarRegistro(ByVal ID As Integer)
        Dim SW As Integer = 0
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        StrSQL = "SELECT ID FROM IMAGENES WHERE ID=" & Str(ID)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            SW = 1
            IdImagen = ID
        End While
        If SW = 0 Then
            StrSQL = "INSERT " & BDEmpresaIPSS & "..IMAGENES (IMAGEN) SELECT NULL IMAGEN"
            ProcesarModificacion(StrSQL)
            con.Close()
            StrSQL = "SELECT MAX(ID) FROM IMAGENES"
            Dim cmd2 As SqlCommand = con.CreateCommand()
            con.Open()
            cmd2.CommandText = StrSQL
            Dim Arreglo2 As SqlDataReader = cmd2.ExecuteReader
            While Arreglo2.Read
                IdImagen = Arreglo2("ID")
            End While


        End If
        con.Close()
    End Sub
    Sub Cargar(ByVal ID As Integer)
        Try
            ValidarRegistro(ID)


            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim comandoSQLimagen As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT id,imagen FROM IMAGENES where id=" & IdImagen, con)
            AdaptadorTabimg = New System.Data.SqlClient.SqlDataAdapter(comandoSQLimagen)
            DSimagen = New Data.DataSet("Imagen")

            AdaptadorTabimg.Fill(DSimagen, "Imagen")
            bsimagen.DataSource = DSimagen.Tables("Imagen")

            Imagenbox.DataBindings.Clear()
            Imagenbox.DataBindings.Add("Image", bsimagen, "imagen", True, DataSourceUpdateMode.OnValidation, New Bitmap("C:\Users\she\desktop\GO.PNG"))

            cb = New System.Data.SqlClient.SqlCommandBuilder(AdaptadorTabimg)







        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Cargar")
        End Try



    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imagenbox.Click
        Try
            OpenFileDialog1.Filter = "Archivos JPG|*.jpg"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Imagenbox.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "SeleccionarImagen")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        bsimagen.EndEdit()
        AdaptadorTabimg.Update(DSimagen, "Imagen")

        'Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresaIPSS & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)

        'Dim comandoSQL As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand("SET DATEFORMAT DMY update PRUEBA_IMAGEN set TEXTO=GETDATE() where ID= " & IdImagen, con)
        'comandoSQL.CommandType = CommandType.Text

        'If comandoSQL.Connection.State <> ConnectionState.Open Then
        '    comandoSQL.Connection.Open()
        'End If

        'comandoSQL.ExecuteNonQuery()

        DSimagen.Tables("Imagen").Clear()
        AdaptadorTabimg.Fill(DSimagen, "Imagen")


        'If comandoSQL.Connection.State = ConnectionState.Open Then
        '    comandoSQL.Connection.Close()
        'End If



        Me.Close()

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub FrmImagenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class