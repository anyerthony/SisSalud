Public Class FrmComentario
    Public id As Integer = 0
    Public pantalla As Form

    Private Sub FrmComentario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        id = 0
        pantalla = Nothing
        TXT_CODIGO.Text = ""
        TXT_COMENTARIO.Text = ""
        TXT_SERVICIO.Text = ""
    End Sub
    Private Sub FrmComentario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXT_COMENTARIO.Select()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If pantalla.Name = "FrmFacturarServicio" Then
            FrmFacturarServicio.GRID_SERVICIOS.Item(4, id).Value = TXT_COMENTARIO.Text
            FrmFacturarServicio.GRID_SERVICIOS.Item(5, id).Value = TXT_DES_ADICIONAL.Text
            'FrmFacturarServicio.GRID_SERVICIOS.Item(1, id).Value = FrmFacturarServicio.GRID_SERVICIOS.Item(6, id).Value & " " & TXT_DES_ADICIONAL.Text
            Me.Close()
        End If
    End Sub

    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub
End Class