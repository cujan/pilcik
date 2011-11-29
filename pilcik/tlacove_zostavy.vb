Public Class tlacove_zostavy
    Public id_kurzu As Integer = 14
    Private Sub tlacove_zostavy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.

        Me.MdiParent = hlavna_aplikacia
        protokol_kurzComboBox.SelectedIndex = -1
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'protokol pila
        If protokol_pila_RadioButton.Checked And protokol_kurzComboBox.SelectedIndex <> -1 Then
            Dim id_kurzu As Integer = protokol_kurzComboBox.SelectedValue
            tz_protokol_pila.Show()
        End If

        'protokol LKT
        If protokol_lkt_RadioButton.Checked And protokol_kurzComboBox.SelectedIndex <> -1 Then
            Dim id_kurzu As Integer = protokol_kurzComboBox.SelectedValue
            tz_protokol_lkt.Show()
        End If


    End Sub

    Private Sub protokolCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub protokol_kurzComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles protokol_kurzComboBox.SelectedIndexChanged
        Label2.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles protokol_pila_RadioButton.CheckedChanged
        If protokol_pila_RadioButton.Checked Then
            protokol_kurzComboBox.Visible = True
            Label2.Visible = True
        End If


    End Sub

    Private Sub protokol_lkt_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles protokol_lkt_RadioButton.CheckedChanged
        If protokol_lkt_RadioButton.Checked Then
            protokol_kurzComboBox.Visible = True
            Label2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tz_protokol_pila.Show()
    End Sub
End Class