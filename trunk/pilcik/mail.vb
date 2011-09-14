Public Class mail

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If spravaTextBox.Text <> "" And nadpisTextBox.Text <> "" Then
            Dim chyba As String
            posli_mail(nadpisTextBox.Text, spravaTextBox.Text, chyba)
            MsgBox("Správa úspešne odoslaná, budeme sa snažiť čo najskôr odpovedať.", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Nemáte vyplnené niektoré pole", MsgBoxStyle.Information)
        End If
    End Sub
End Class