Imports System.Data.SqlClient
Public Class FrmLogin
    Sub Entrar()
        Try
            StrSQL = "exec " & My.Settings.BaseDatosMasterProfit & "pAutenticarUsuario '" & TXT_USUARIO.Text & "','" & TXT_PASSWORD.Text & " '"
            Dim Sw As Integer = 0
            Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                If Arreglo(0).ToString = 1 Then
                    Sw = 1
                    Cod_Usuario = Mid(TXT_USUARIO.Text, 1, 6)
                    Nombre_Usuario = TXT_USUARIO.Text
                    MDIPrincipal.ToolValorUsuario.Text = Cod_Usuario
                    MDI_PrincipalV2.ToolValorUsuario.Text = Cod_Usuario
                    If UCase(Cod_Usuario) = "SA_01" Or UCase(Cod_Usuario) = "GPARAD" Then
                        MDIPrincipal.ExportarMañongoACaracasToolStripMenuItem1.Visible = True
                    End If
                    con.Close()
                    CargarParametrosUsuarios()
                    Me.Hide()
                    FrmSelEmpresa.Show()
                    Exit Sub
                Else
                    MsgBox("Disculpe, sus credenciales no son válidas", MsgBoxStyle.Information, "Intente Nuevamente")
                    Exit Sub
                End If
            End While

            If Sw = 0 Then
                MsgBox("Disculpe, sus credenciales no son válidas", MsgBoxStyle.Information, "Intente Nuevamente")
            End If
            con.Close()

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "ValidadorCredenciales")

        End Try
       

    End Sub
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        
        Entrar()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        End
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Conectar()
        'Entrar()
        If Environment.MachineName = "JEFE-SISTEMAS2" Then
            TXT_USUARIO.Text = "sa_01"
            TXT_PASSWORD.Text = "."
        End If




    End Sub
End Class
