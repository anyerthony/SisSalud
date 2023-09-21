Imports System.Data.SqlClient
Public Class FrmSelSucursal
    Sub ValidarAccesoSucursal()
        Dim Cerrar As Integer = 1
        StrSQL = "SELECT * FROM QAPD_CONTROL..MANUSUARIOS_SUCURSAL WHERE STATUS=1 AND SUCURSAL='" & CoSucursal & "' AND USUARIO='" & Cod_Usuario & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim Arreglo As SqlDataReader = cmd.ExecuteReader
        While Arreglo.Read
            Cerrar = 0
        End While
        con.Close()
        If Cerrar = 1 Then
            MsgBox("Disculpe, usted no esta autorizado para esta sucursal", MsgBoxStyle.Information, "Debe ingresar de nuevo al sistema")
            End
        End If
    End Sub
    Sub CargarSucursal()
        TXT_SUCURSAL.Items.Clear()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            StrSQL = "SELECT sucur_des FROM SASUCURSAL ORDER BY co_sucur"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                TXT_SUCURSAL.Items.Add(Trim(Arreglo("sucur_des")))
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "CargarSucursal")
        End Try


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If TXT_SUCURSAL.Text = "" Then
            MsgBox("Disculpe, debe selecionar una sucursal", MsgBoxStyle.Information, "Intente de Nuevo")
            Exit Sub
        End If
        MDIPrincipal.ToolValorSucursal.Text = ""
        MDI_PrincipalV2.ToolValorSucursal.Text = ""

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            StrSQL = "SELECT co_sucur,sucur_des FROM SASUCURSAL where sucur_des='" & TXT_SUCURSAL.Text & "' "
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            While Arreglo.Read
                CoSucursal = Trim(Arreglo("co_sucur"))
                MDIPrincipal.ToolValorSucursal.Text = Trim(Arreglo("sucur_des"))
                MDI_PrincipalV2.ToolValorSucursal.Text = Trim(Arreglo("sucur_des"))
                ValidarAccesoSucursal()
            End While
            con.Close()
            Me.Hide()
            'MDIPrincipal.Show()
            MDI_PrincipalV2.Show()
        Catch ex As Exception
            con.Close()
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "BtSelSucursal")
        End Try
    End Sub


End Class