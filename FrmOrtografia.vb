Imports Microsoft.Office.Interop.Word
Imports System.IO
Public Class FrmOrtografia
    Dim textoO As String
    Dim ruta As String
    Dim tituloO As String
    Dim wordApp As Application
    Dim wordDoc As Document

    Sub New(ByVal texto As String, ByVal titulo As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TXT_TEXTO.Text = texto
        Me.Text = Me.Text & " " & titulo
        textoO = texto
        tituloO = titulo

    End Sub
 


    Private Sub BTN_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCELAR.Click
        TXT_TEXTO.Text = textoO
        Me.Close()
    End Sub
   
   
    Private Sub BTN_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ACEPTAR.Click
        textoO = TXT_TEXTO.Text
        Me.Close()
    End Sub

    Public Function Expandir() As String
        Me.ShowDialog()
        Return textoO
    End Function
    Sub CrearDocumentoWord(ByVal texto As String, ByVal titulo As String)
        Try
            ' Crea una nueva instancia de Word
            wordApp = New Application

            wordApp.Visible = True
            wordApp.Activate()


            ' Crea un nuevo documento
            wordDoc = wordApp.Documents.Add

            ' Agrega texto al documento
            wordDoc.Content.Text = texto

            ruta = Path.Combine(Path.GetTempPath(), titulo)

            ' Guarda el documento en el disco
            wordDoc.SaveAs(ruta)

            ' Cierra Word
            'wordApp.Quit()


            AddHandler wordApp.DocumentBeforeClose, AddressOf cerrarWord
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub cerrarWord(ByVal doc As Object, ByRef cancel As Boolean)
        Try
            wordDoc.Save()
            Dim thread As New Threading.Thread(AddressOf UpdateTextBox)
            thread.Start(wordDoc.Content.Text)

        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Cerrar documento word")
        End Try

    End Sub


    Private Sub BTN_ORTOGRAFIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ORTOGRAFIA.Click

        CrearDocumentoWord(TXT_TEXTO.Text, tituloO)


    End Sub


    ' Crear un delegado para actualizar el TextBox
    Delegate Sub UpdateTextBoxDelegate(ByVal text As String)

    ' Método para actualizar el TextBox
    Private Sub UpdateTextBox(ByVal text As String)
        Try
            If TXT_TEXTO.InvokeRequired Then
                TXT_TEXTO.Invoke(New UpdateTextBoxDelegate(AddressOf UpdateTextBox), text)
            Else
                text = text.Replace(vbCr, vbCrLf)
                text = text.Replace(vbTab, "    ")
                TXT_TEXTO.Text = text
                'System.IO.File.Delete(ruta & ".doc")
                'System.IO.File.Delete(ruta & ".docx")
            End If
        Catch ex As Exception
            ManejoErrores(ex.Message, ex.ToString, Me.Name, "Actualizar txt")
        End Try

    End Sub

    Private Sub FrmOrtografia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If TXT_TEXTO.Text <> textoO & vbCrLf And TXT_TEXTO.Text <> textoO Then
            If SourceAceptarCambios() Then
                textoO = TXT_TEXTO.Text
            End If
        End If
    End Sub
End Class