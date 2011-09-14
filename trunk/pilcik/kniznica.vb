Imports System.Net.Mail
Module kniznica
    Public Function pripojovaci_retazec() As String

        Dim pripojovaci_retazec_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pilcik_db.accdb"


        Return pripojovaci_retazec_string
    End Function
    'posielanie mailov
    Public Function posli_mail(ByVal nadpis As String, ByVal telo As String, ByVal zoznam_chyb As String) As Boolean
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient

        Try
            If My.Computer.Network.IsAvailable = True Then
                SmtpServer.Credentials = New Net.NetworkCredential("aplikacia.pilcik", "aplikaciapilcik")
                SmtpServer.Port = 587
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.EnableSsl = True
                mail.To.Add("aplikacia.pilcik@gmail.com")
                mail.From = New Net.Mail.MailAddress("holubjan@gmail.com")
                mail.Subject = nadpis
                mail.Priority = Net.Mail.MailPriority.High
                mail.Body = telo
                SmtpServer.Send(mail)
            ElseIf My.Computer.Network.IsAvailable = False Then
                MsgBox("chyba , nieste pripojeny k sieti internet ", MsgBoxStyle.Critical, "odosielanie mailu")
            End If
        Catch ex As Exception
            MsgBox("chyba , zadali ste nespravne udaje" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "odosielanie mailu")
        End Try

        Return True
    End Function
    
End Module
