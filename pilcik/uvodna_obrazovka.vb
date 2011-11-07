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

        Label6.Text = My.Application.Info.Version.ToString

        'kontrola novej verzie
        Try

            Dim wc As New WebClient
            Dim version As String
            Dim currentVersion As String = My.Application.Info.Version.ToString
            version = wc.DownloadString("http://polnohospodari.sk/pilcik/verzia.txt")

            If version > currentVersion Then
                If MsgBox("Existuje novšia verzia programu, chcete ju nainštalovať?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    If My.Computer.FileSystem.FileExists("C:\pilcik\tmp\setup_update.exe") Then
                        My.Computer.FileSystem.DeleteFile("C:\pilcik\tmp\setup_update.exe")
                    End If
                    My.Computer.Network.DownloadFile("http://polnohospodari.sk/pilcik/setup_update.exe", "C:\pilcik\tmp\setup_update.exe")
                    Process.Start("C:\pilcik\tmp\setup_update.exe")
                    hlavna_aplikacia.Close()
                End If
            End If
        Catch

        End Try
    End Sub

    Private Sub verziaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub skonecena_platnostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        skoncena_platnost_osoba.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Computer.Network.DownloadFile("http://polnohospodari.sk/pilcik/setup_update.exe", "D:\a\setup_update.exe")
        'Process.Start("D:\a\setup_update.exe")
        'hlavna_aplikacia.Close()

        Dim wc As New WebClient
        Dim version As String
        Dim currentVersion As String = My.Application.Info.Version.ToString
        version = wc.DownloadString("http://polnohospodari.sk/pilcik/verzia.txt")

        If version > currentVersion Then
            MsgBox("Je to novsia verzia")
        Else
            MsgBox("Nje je nova verzia")
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim currentVersion As String = My.Application.Info.Version.ToString
        MsgBox(currentVersion)
    End Sub
End Class