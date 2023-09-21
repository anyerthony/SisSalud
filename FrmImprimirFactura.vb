Public Class FrmImprimirFactura

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim NroFact As String '= InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")
        NroFact = TXT_FacturaImprimir.Text
        If Len(NroFact) < 7 Then
            MsgBox("Disculpe, debe indicar el nro de factura completo", MsgBoxStyle.Information, "Intente de nuevo")
            Exit Sub
        End If

        If RB_Detallado.Checked = False And RB_Paciente.Checked = False And RB_Particular.Checked = False And RB_Profit.Checked = False And RB_Resumido.Checked = False Then
            MsgBox("Disculpe, debe indicar el formato de la factura", MsgBoxStyle.Information, "Intente de nuevo")
            Exit Sub
        End If

        If RB_Particular.Checked = True Then
            Imprimirfactura("RptFormatoFacturaParticular.rpt", NroFact)
        ElseIf RB_Profit.Checked = True Then
            Imprimirfactura("RptFormatoFacturaProfit.rpt", NroFact)
        Else
            Dim Formato As Integer
            If RB_Detallado.Checked = True Then
                Formato = 1
            ElseIf RB_Resumido.Checked = True Then
                Formato = 2
            Else
                Formato = 3
            End If

            ImprimirfacturaEmpresa("RptFormatoFacturaEmpresa.rpt", NroFact, Formato, CH_Empresa.Checked)
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim NroFact As String '= InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")
       
        NroFact = TXT_FacturaImprimir.Text
        If Len(NroFact) < 7 Then
            MsgBox("Disculpe, debe indicar el nro de factura completo", MsgBoxStyle.Information, "Intente de nuevo")
            Exit Sub
        End If
        'Imprimirfactura("RptFormatoFacturaProfit.rpt", NroFact)
        CargarInformacionFactura(NroFact)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmImprimirFactura_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RB_Detallado.Checked = False
        RB_Paciente.Checked = False
        RB_Particular.Checked = False
        RB_Profit.Checked = False
        RB_Resumido.Checked = False

        CH_Empresa.Checked = False

        TXT_FacturaImprimir.Text = ""

    End Sub

    Private Sub FrmImprimirFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXT_FacturaImprimir.TabIndex = 0
    End Sub

    Private Sub TXT_FacturaImprimir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FacturaImprimir.KeyPress
        If e.KeyChar = Convert.ToChar(keys.Return) Then

            Dim NroFact As String '= InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")
            NroFact = TXT_FacturaImprimir.Text
            If Len(NroFact) < 7 Then
                MsgBox("Disculpe, debe indicar el nro de factura completo", MsgBoxStyle.Information, "Intente de nuevo")
                Exit Sub
            End If

            If RB_Detallado.Checked = False And RB_Paciente.Checked = False And RB_Particular.Checked = False And RB_Profit.Checked = False And RB_Resumido.Checked = False Then
                MsgBox("Disculpe, debe indicar el formato de la factura", MsgBoxStyle.Information, "Intente de nuevo")
                Exit Sub
            End If

            If RB_Particular.Checked = True Or RB_Profit.Checked = True Then
                Imprimirfactura("RptFormatoFacturaParticular.rpt", NroFact)
            Else
                Dim Formato As Integer
                If RB_Detallado.Checked = True Then
                    Formato = 1
                ElseIf RB_Resumido.Checked = True Then
                    Formato = 2
                Else
                    Formato = 3
                End If

                ImprimirfacturaEmpresa("RptFormatoFacturaEmpresa.rpt", NroFact, Formato, CH_Empresa.Checked)
            End If
        End If
    End Sub

    Private Sub TXT_FacturaImprimir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FacturaImprimir.TextChanged
        Dim NroFact As String '= InputBox("Por favor indique el Nro de factura a Imprimir", "Nro Factura")

        NroFact = TXT_FacturaImprimir.Text
        If Len(TXT_FacturaImprimir.Text) >= 9 Then
            CargarInformacionFactura(NroFact)
        End If
    End Sub
End Class