Public Class osoba_prehlad

    Private Sub osoba_prehlad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.PilcikdbDataSet.kurz)
        Me.ComboBox1.SelectedIndex = -1
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        Me.MdiParent = hlavna_aplikacia

    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub priezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles priezviskoTextBox.TextChanged
        Dim priezvisko As String = priezviskoTextBox.Text & "%"
        Me.OsobaTableAdapter.FillBy_priezvisko(Me.PilcikdbDataSet.osoba, priezvisko)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim id_kurzu As Integer = ComboBox1.SelectedValue
        Me.OsobaTableAdapter.FillBy_id_kurzu(Me.PilcikdbDataSet.osoba, id_kurzu)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            priezviskoTextBox.ReadOnly = False
        Else
            priezviskoTextBox.ReadOnly = True
            Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
            priezviskoTextBox.Text = ""
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
            Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
            ComboBox1.SelectedIndex = -1
        End If
    End Sub
End Class