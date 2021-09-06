Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDecompor.Click
        If (txtPalavra.Text = Nothing) Then
            MsgBox("Insira uma palavra para ser decomposta.", MsgBoxStyle.Critical, "Por favor, verifique seus dados!!")
            Exit Sub
        Else
            If (txtPalavra.Text.Length > 20) Then
                MsgBox("A palavra inserida não deve ter mais de 20 caracteres.", MsgBoxStyle.Critical, "Por favor, verifique seus dados!")
                Exit Sub
            End If

        End If

        Dim palavra As String = txtPalavra.Text

        For i = 0 To palavra.Length - 1
            MsgBox(palavra.Substring(i, 1))
        Next
    End Sub
End Class
