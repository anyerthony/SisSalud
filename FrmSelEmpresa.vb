Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmSelEmpresa

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Select Case TXT_EMPRESA.Text
            Case Is = "DarSalud"
                BDEmpresa = "Flavica_a"
                BDEmpresaIntegral = "Integral.."

                MDIPrincipal.ToolValorEmpresa.Text = "DarSalud"
                MDI_PrincipalV2.ToolValorEmpresa.Text = "DarSalud"

            Case Is = "Viñedos"
                BDEmpresa = "UNIMED_A"
                BDEmpresaIntegral = "Integral_Vinedo.."

                MDIPrincipal.ToolValorEmpresa.Text = "Viñedos"
                MDI_PrincipalV2.ToolValorEmpresa.Text = "Viñedos"

            Case Is = "Mañongo"
                BDEmpresa = "MANONGO_A"
                BDEmpresaIntegral = "Integral_Manongo.."

                MDIPrincipal.ToolValorEmpresa.Text = "Mañongo"
                MDI_PrincipalV2.ToolValorEmpresa.Text = "Mañongo"

            Case Is = "Demostracion"
                'If UCase(Cod_Usuario) <> "SA_01" Then
                '    MsgBox("Disculpe, usted no esta autorizado para ingresar a esta empresa", MsgBoxStyle.Critical, "No lo haga")
                '    End
                'End If
                BDEmpresa = "SALUD_TEST"
                MDIPrincipal.ToolValorEmpresa.Text = "Demostracion"
                MDI_PrincipalV2.ToolValorEmpresa.Text = "Demostracion"

                BDEmpresaIntegral = "Integral_test.."
                'BDEmpresaIPSS = "IPSS_TEST"
            Case Else
                MsgBox("Disculpe, debe selecionar una empresa", MsgBoxStyle.Information, "Error")
                Exit Sub
        End Select
        BindingSourceCON = "Provider=SQLOLEDB;Data Source=" & Servidor & ";Persist Security Info=True;Password=" & PasswordSystem & ";User ID=" & UserSystem & ";Initial Catalog=" & Replace(BDEmpresaIntegral, "..", "") & ""


        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Try
            StrSQL = "SELECT B.* " & _
                    "FROM MasterProfitProA..MpUsuario a LEFT JOIN MasterProfitProA..MpUsuario_Perfil B ON A.Cod_Usuario = B.cod_usuario " & _
                    "WHERE A.Cod_Usuario= '" & Cod_Usuario & "' AND (" & _
                    "A.Acceso_Todas_Empresa_Admi = 1 OR " & _
                    "B.cod_empresa = '" & BDEmpresa & "')"
            Dim cmd As SqlCommand = con.CreateCommand()
            con.Open()
            cmd.CommandText = StrSQL
            Dim Arreglo As SqlDataReader = cmd.ExecuteReader
            Dim Validado As Integer = 0
            While Arreglo.Read
                Validado = 1
            End While
            con.Close()

            If Validado = 0 Then
                MsgBox("Disculpe, no está autorizado para seleccionar esta empresa.", MsgBoxStyle.Information, "Debe ingresar de nuevo al sistema")
                End
            End If

            Me.Hide()
            'MDIPrincipal.Show()
        Catch ex As Exception
            con.Close()
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "BtSelSucursal")
        End Try

        Me.Hide()
        FrmSelSucursal.CargarSucursal()
        FrmSelSucursal.ShowDialog()
    End Sub
End Class