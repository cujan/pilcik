Imports System.IO
Public Class zaloha

    Private Sub zaloha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()

        zalohaButton.Enabled = False
        obnovButton.Enabled = False
        zmazButton.Enabled = False
        obnovListBox.Enabled = False

        'nacitanie zoznamu suborov do listboxu
        obnovListBox.Items.Clear()
        Dim cDir As String
        cDir = CurDir()
        Dim fileEntries As String()
        Try
            fileEntries = Directory.GetFiles(cDir & "\backup", "*.accdb-*")

            Dim fileName As String
            Dim tempFile As String
            For Each fileName In fileEntries
                tempFile = fileName.Remove(0, (cDir & "\backup").Length + 1)
                obnovListBox.Items.Add(tempFile)

            Next fileName
        Catch ex As Exception
            MsgBox("Adresár so zálohami nenájdený. Možná príčina - zatial ste nerobili žiadne zálohy. Prosím spravte zálohu databázy.")
        End Try




    End Sub

    Private Sub zalohaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zalohaButton.Click

        'zalohuje databzovy subor do priecinka backup
        Dim cDir As String
        Dim source As String
        Dim destination As String
        Dim now As String
        cDir = CurDir()
        now = Format(DateTime.Now, "dd-MM-yyyy--HH-mm-ss")

        source = cDir & "\pilcik_db.accdb"
        destination = cDir & "\backup\pilcik_db.accdb-" & now


        'poznamka.Text = source & "     " & destination

        Try
            If My.Computer.FileSystem.DirectoryExists(cDir & "\backup") Then
                My.Computer.FileSystem.CopyFile(source, destination)
                '       poznamka.Visible = True
                '      poznamka.Text = "Záloha databázy úspešne vytvorená."

            Else
                My.Computer.FileSystem.CreateDirectory(cDir & "\backup")
                My.Computer.FileSystem.CopyFile(source, destination)
                'poznamka.Visible = True
                'poznamka.Text = "Záloha databázy úspešne vytvorená."

            End If
        Catch ex As Exception
            MsgBox("Nepodarilo sa zálohovať databázu.")
        End Try


        obnovListBox.Items.Clear()
        
        Dim fileEntries As String()
        Try
            fileEntries = Directory.GetFiles(cDir & "\backup", "*.accdb-*")

            Dim fileName As String
            Dim tempFile As String
            For Each fileName In fileEntries
                tempFile = fileName.Remove(0, (cDir & "\backup").Length + 1)
                obnovListBox.Items.Add(tempFile)

            Next fileName
        Catch ex As Exception
            MsgBox("Adresár so zálohami nenájdený. Možná príčina - zatial ste nerobili žiadne zálohy. Prosím spravte zálohu databázy.")
        End Try

    End Sub

    Private Sub zalohujRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zalohujRadioButton.CheckedChanged
        If zalohujRadioButton.Checked Then
            zalohaButton.Enabled = True
        Else
            zalohaButton.Enabled = False
        End If
    End Sub

    Private Sub obnovRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obnovRadioButton.CheckedChanged
        If obnovRadioButton.Checked Then
            obnovListBox.Enabled = True
            obnovButton.Enabled = True
            zmazButton.Enabled = True
        Else
            obnovListBox.Enabled = False
            obnovButton.Enabled = False
            zmazButton.Enabled = False
        End If
    End Sub

    Private Sub zmazButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmazButton.Click
        Dim cDir As String
        Dim source As String


        cDir = CurDir()


        If Not obnovListBox.SelectedIndex = -1 Then

            source = cDir & "\backup\" & obnovListBox.SelectedItem


            'poznamka.Text = source & "     " & destination

            Try
                My.Computer.FileSystem.DeleteFile(source)
                'poznamka_obnova.Visible = True
                'poznamka_obnova.Text = "Vymazanie zálohy databázy úspešné."
            Catch ex As Exception
                MsgBox("Nepodarilo sa vymazať zálohu databázy.")

            End Try

        Else
            MsgBox("Pre vymazanie musíte označiť položku zo zoznamu záloh databázy.")
        End If

        obnovListBox.Items.Clear()

        Dim fileEntries As String()
        Try
            fileEntries = Directory.GetFiles(cDir & "\backup", "*.accdb-*")

            Dim fileName As String
            Dim tempFile As String
            For Each fileName In fileEntries
                tempFile = fileName.Remove(0, (cDir & "\backup").Length + 1)
                obnovListBox.Items.Add(tempFile)

            Next fileName
        Catch ex As Exception
            MsgBox("Adresár so zálohami nenájdený.")
        End Try
    End Sub

    Private Sub obnovButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obnovButton.Click
        Dim cDir As String
        Dim source As String
        Dim destination As String

        cDir = CurDir()


        If Not obnovListBox.SelectedIndex = -1 Then

            source = cDir & "\backup\" & obnovListBox.SelectedItem
            destination = cDir & "\pilcik_db.accdb"

            'poznamka.Text = source & "     " & destination

            Try
                My.Computer.FileSystem.CopyFile(source, destination, True)
                'poznamka_obnova.Visible = True
                'poznamka_obnova.Text = "Obnova databázy úspešná."
            Catch ex As Exception
                MsgBox("Nepodarilo sa spraviť obnovu databázy.")

            End Try

        Else
            MsgBox("Pre obnovu musíte označiť položku zo zoznamu záloh databázy.")
        End If
    End Sub
End Class