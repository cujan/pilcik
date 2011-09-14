Public Class kurz_detail

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub kurz_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.c_typ_kurzu' table. You can move, or remove it, as needed.

        Me.MdiParent = hlavna_aplikacia
        Dim id_vybrateho_kurzu As Integer = kurz_novy.Label2.Text
        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Label1.BringToFront()
        If TypTextBox.Text = "" Then
            typ_nazovComboBox.SelectedValue = -1
        Else
            typ_nazovComboBox.SelectedValue = TypTextBox.Text
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(kurz_novy.Label2.Text)
    End Sub

    Private Sub pridaj_clenaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_clenaButton.Click
        clen_kurzu_pridaj.Show()
    End Sub

    Private Sub Clenovia_kurzuDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Clenovia_kurzuDataGridView.CellClick
        Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clenovia_kurzuBindingSource, "osoba_id", True))
        Label3.Text = Label2.Text
        Label2.DataBindings.Clear()
    End Sub

    Private Sub Clenovia_kurzuDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Clenovia_kurzuDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label2.Text <> "" Then
            If MsgBox("Naozaj chcete odobrať  vybraného člena z kurzu ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim id_clen As Integer = Label2.Text
                Dim id_kurz As Integer = IdLabel1.Text

                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM clenovia_kurzu WHERE(kurz_id = @id_kurz) AND (clen_id = @id_clen)", con)
                com.Parameters.AddWithValue("id_clen", id_clen)
                com.Parameters.AddWithValue("id_kurz", id_kurz)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()


            End If
        Else
            MsgBox("Nemáte vybraného žiadneho člena.")
        End If
    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NazovTextBox.ReadOnly = False
        Zaciatok_kurzuDateTimePicker.Enabled = True
        Koniec_kurzuDateTimePicker.Enabled = True
        Cislo_protokoluTextBox.ReadOnly = False
        typ_nazovComboBox.Enabled = True
        Button3.Visible = True
        Miesto_konaniaTextBox.ReadOnly = False
        Button2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NazovTextBox.ReadOnly = True
        Zaciatok_kurzuDateTimePicker.Enabled = False
        Koniec_kurzuDateTimePicker.Enabled = False
        Cislo_protokoluTextBox.ReadOnly = True
        typ_nazovComboBox.Enabled = False
        Button2.Visible = True
        Miesto_konaniaTextBox.ReadOnly = True
        Button3.Visible = False
        Dim id_vybrateho_kurzu As Integer = kurz_novy.Label2.Text

        'update zaznamov v tabulke kurz
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("UPDATE kurz SET  nazov = @nazov, zaciatok_kurzu = @zaciatok_kurzu, koniec_kurzu = @koniec_kurzu, typ = @typ, miesto_konania = @miesto_konania, cislo_protokolu = @cislo_protokolu WHERE     id = @id", con)
        With com.Parameters
            .AddWithValue("nazov", NazovTextBox.Text)
            .AddWithValue("zaciatok_kurzu", Zaciatok_kurzuDateTimePicker.Value.Date)
            .AddWithValue("koniec_kurzu", Koniec_kurzuDateTimePicker.Value.Date)
            .AddWithValue("typ", typ_nazovComboBox.SelectedValue)
            .AddWithValue("miesto_konania", Miesto_konaniaTextBox.Text)
            .AddWithValue("cislo_protokolu", Cislo_protokoluTextBox.Text)
            .AddWithValue("id", id_vybrateho_kurzu)
        End With
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

    End Sub
End Class