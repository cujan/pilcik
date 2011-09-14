Imports System.Net.Mail
Public Class uvodna_obrazovka

    Private Sub uvodna_obrazovka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized

        'pocet evidovanych osob a kurzov
        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("SELECT COUNT(*) FROM osoba", con)
        Dim com1 As New OleDbCommand("SELECT COUNT(*) FROM kurz", con)
        con.Open()
        Dim pocet_osob As Integer = com.ExecuteScalar()
        Dim pocet_kurz As Integer = com1.ExecuteScalar()
        con.Close()
        Label4.Text = pocet_osob
        Label5.Text = pocet_kurz
    End Sub

    Private Sub verziaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verziaLabel.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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
                mail.Subject = "paradzina"
                mail.Priority = Net.Mail.MailPriority.High
                mail.Body = "text v maili"
                SmtpServer.Send(mail)
            ElseIf My.Computer.Network.IsAvailable = False Then
                MsgBox("chyba , nieste pripojeny k sieti internet ", MsgBoxStyle.Critical, "odosielanie mailu")
            End If
        Catch ex As Exception
            MsgBox("chyba , zadali ste nespravne udaje" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "odosielanie mailu")
        End Try
    End Sub

    Private Sub skonecena_platnostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skonecena_platnostButton.Click
        skoncena_platnost_osoba.Show()
    End Sub
End Class