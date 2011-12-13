Public Class osoba_detail

    Dim vybrana_osoba_id As Integer = osoba_pridaj.idClen

    Private Sub osoba_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        
        Me.Kurz_absolvovaneTableAdapter.FillBy_id(Me.Pilcik_dbDataSet.kurz_absolvovane, vybrana_osoba_id)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.FillBy_id(Me.Pilcik_dbDataSet.osoba, vybrana_osoba_id)
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.

       
        Me.MdiParent = hlavna_aplikacia
        If Datum_narodeniaTextBox.Text <> "" Then
            Datum_narodeniaDateTimePicker.Checked = True
            Datum_narodeniaDateTimePicker.Value = Datum_narodeniaTextBox.Text
        Else
            Datum_narodeniaDateTimePicker.Checked = False

        End If
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
       
        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("UPDATE osoba SET titul_pred = @titul_pred, priezvisko = @priezvisko, meno = @meno, datum_narodenia = @datum_narodenia, rodne_cislo = @rodne_cislo, cislo_op = @cislo_op, ulica = @ulica, mesto = @mesto, psc = @psc, cislo_pilcickeho_preukazu = @cislo_pilcickeho_preukazu, email = @email, telefon = @telefon WHERE id = @id ", con)
        With com.Parameters
            .AddWithValue("titul_pred", Titul_predTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            If Datum_narodeniaDateTimePicker.Checked = True Then
                .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value.Date)
            Else
                .AddWithValue("datum_narodenia", DBNull.Value)
            End If


            .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
            .AddWithValue("cislo_op", Cislo_opTextBox.Text)
            .AddWithValue("ulica", UlicaTextBox.Text)
            .AddWithValue("mesto", MestoTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("cislo_pilcickeho_preukazu", Cislo_pilcickeho_preukazuTextBox.Text)
            .AddWithValue("email", EmailTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("id", vybrana_osoba_id)

        End With
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        osoba_pridaj.OsobaTableAdapter.Fill(osoba_pridaj.Pilcik_dbDataSet.osoba)

        MsgBox("Zmeny úspešne uložené")
    End Sub

    
    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub


    Private Sub Kurz_absolvovaneDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Kurz_absolvovaneDataGridView.CellContentClick

    End Sub
End Class