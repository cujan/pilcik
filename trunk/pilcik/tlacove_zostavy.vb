Public Class tlacove_zostavy
    'Public id_kurzu As Integer = ComboBox1.SelectedValue
    Public textPila As String = "Pila"
    Private Sub tlacove_zostavy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz_pohlad' table. You can move, or remove it, as needed.
        Me.Kurz_pohladTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz_pohlad)
        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.ComboBox1.SelectedValue = -1

        Me.MdiParent = hlavna_aplikacia

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        


    End Sub

    Private Sub protokolCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub protokol_kurzComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        


    End Sub

    Private Sub protokol_lkt_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tz_protokol_lkt.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pilaRadioButton.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedValue <> Nothing Then
            If pilaRadioButton.Checked Then
                tz_protokol_pila.Show()

            ElseIf lktRadioButton.Checked Then
                tz_protokol_lkt.Show()
            Else
                MsgBox("Nemáte vybratú žiadnu tlačovú zostavu", MsgBoxStyle.Information)

            End If
        Else
            MsgBox("Nemáte vybratý žiaden kurz", MsgBoxStyle.Information)
        End If
        'MsgBox(ComboBox1.SelectedValue)
    End Sub
End Class