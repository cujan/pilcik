Public Class kurz_detail
    Public id_vybrateho_kurzu As Integer = kurz_novy.Label2.Text
    Private Sub kurz_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osobaClenoviaKurzu' table. You can move, or remove it, as needed.
        Me.OsobaClenoviaKurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.osobaClenoviaKurzu, id_vybrateho_kurzu)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osobaClenoviaKurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.miesto_konania' table. You can move, or remove it, as needed.
        Me.Miesto_konaniaTableAdapter.Fill(Me.Pilcik_dbDataSet.miesto_konania)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.c_typ_kurzu' table. You can move, or remove it, as needed.
        Me.C_typ_kurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.c_typ_kurzu)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.nazov_kurzu' table. You can move, or remove it, as needed.
        Me.Nazov_kurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.nazov_kurzu)

        Me.MdiParent = hlavna_aplikacia


        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz_id' table. You can move, or remove it, as needed.
        Me.Kurz_idTableAdapter.FillBy_id(Me.Pilcik_dbDataSet.kurz_id, id_vybrateho_kurzu)

        Label4.Text = kurz_novy.Label2.Text

        Label1.BringToFront()
        'If TypTextBox.Text = "" Then
        'typ_nazovComboBox.SelectedValue = -1
        'Else
        'typ_nazovComboBox.SelectedValue = TypTextBox.Text
        'End If

        'natypovanie comboboxov - nazov typ a miesto

        nazovComboBox.SelectedValue = NazovTextBox.Text
        typComboBox.SelectedValue = TypTextBox.Text
        miestoKonaniaComboBox.SelectedValue = Miesto_konaniaTextBox.Text
    End Sub

    Private Sub pridaj_clenaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_clenaButton.Click
        clen_kurzu_pridaj.Show()
    End Sub


    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmenButton.Click

        nazovComboBox.Enabled = True
        Zaciatok_kurzuDateTimePicker.Enabled = True
        Koniec_kurzuDateTimePicker.Enabled = True
        typComboBox.Enabled = True
        miestoKonaniaComboBox.Enabled = True
        Cislo_protokoluTextBox.Enabled = True
        ulozButton.Visible = True
        zmenButton.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        nazovComboBox.Enabled = False
        Zaciatok_kurzuDateTimePicker.Enabled = False
        Koniec_kurzuDateTimePicker.Enabled = False
        typComboBox.Enabled = False
        miestoKonaniaComboBox.Enabled = False
        Cislo_protokoluTextBox.Enabled = False

        zmenButton.Visible = True
        ulozButton.Visible = False






        'update zaznamov v tabulke kurz
        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("UPDATE kurz SET  nazov = @nazov, zaciatok_kurzu = @zaciatok_kurzu, koniec_kurzu = @koniec_kurzu, typ = @typ, miesto_konania = @miesto_konania, cislo_protokolu = @cislo_protokolu WHERE     id = @id", con)
        With com.Parameters
            .AddWithValue("nazov", NazovTextBox.Text)
            .AddWithValue("zaciatok_kurzu", Zaciatok_kurzuDateTimePicker.Value.Date)
            .AddWithValue("koniec_kurzu", Koniec_kurzuDateTimePicker.Value.Date)
            .AddWithValue("typ", TypTextBox.Text)
            .AddWithValue("miesto_konania", Miesto_konaniaTextBox.Text)
            .AddWithValue("cislo_protokolu", Cislo_protokoluTextBox.Text)
            .AddWithValue("id", id_vybrateho_kurzu)
        End With
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        kurz_novy.KurzTableAdapter.Fill(kurz_novy.Pilcik_dbDataSet.kurz)
    End Sub

  

   

    

    
    Private Sub Kurz_idBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kurz_idBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Kurz_idBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub

    Private Sub nazovComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nazovComboBox.SelectedIndexChanged
        NazovTextBox.Text = nazovComboBox.SelectedValue
    End Sub

    Private Sub typComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typComboBox.SelectedIndexChanged
        TypTextBox.Text = typComboBox.SelectedValue
    End Sub

    Private Sub miestoKonaniaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miestoKonaniaComboBox.SelectedIndexChanged
        Miesto_konaniaTextBox = miestoKonaniaComboBox.SelectedValue
    End Sub

    Private Sub OsobaClenoviaKurzuDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaClenoviaKurzuDataGridView.CellClick
        Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaClenoviaKurzuBindingSource, "id", True))
        Label3.Text = Label2.Text
        Label2.DataBindings.Clear()
    End Sub

   
    Private Sub OsobaClenoviaKurzuDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaClenoviaKurzuDataGridView.CellContentClick

    End Sub

    Private Sub ZmazClenaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZmazClenaButton.Click
        If Label2.Text <> "" And Label3.Text <> "Label3" Then
            If MsgBox("Naozaj chcete odobrať  vybraného člena z kurzu ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim id_clen As Integer = CInt(Label3.Text)
                Dim id_kurz As Integer = id_vybrateho_kurzu
                Dim id_kurz_na_zmazanie As Integer
                Dim con As New OleDbConnection(pripojovaci_retazec)
                Dim com As New OleDbCommand("SELECT id  FROM clenovia_kurzu WHERE (kurz_id = @id_kurz) AND (clen_id = @id_clen)", con)
                Dim com1 As New OleDbCommand("DELETE FROM clenovia_kurzu WHERE id = @id", con)
                com.Parameters.AddWithValue("id_kurz", id_kurz)
                com.Parameters.AddWithValue("id_clen", id_clen)
                con.Open()
                id_kurz_na_zmazanie = com.ExecuteScalar
                com1.Parameters.AddWithValue("id", id_kurz_na_zmazanie)
                com1.ExecuteNonQuery()
                con.Close()
                Me.OsobaClenoviaKurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.osobaClenoviaKurzu, id_vybrateho_kurzu)

            End If
        Else
            MsgBox("Nemáte vybraného žiadneho člena.")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(id_vybrateho_kurzu)
    End Sub
End Class