﻿Public Class osoba_pridaj

    Private Sub osoba_pridaj_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub osoba_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.Pilcik_dbDataSet.osoba)
        Me.MdiParent = hlavna_aplikacia

        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.
        
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        'Me.OsobaDataGridView.CurrentCell = Nothing
        Label5.BringToFront()

    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PriezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriezviskoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        'kontorla cisla pilcickeho preukazu
        Dim pocet_vyskytov_cisla_preukazu As Integer
        Dim con1 As New OleDbConnection(pripojovaci_retazec)
        Dim com1 As New OleDbCommand("SELECT COUNT(*) FROM osoba GROUP BY cislo_pilcickeho_preukazu HAVING (cislo_pilcickeho_preukazu = @cislo_pilcickeho_preukazu)", con1)
        com1.Parameters.AddWithValue("cislo_pilcickeho_preukazu", Cislo_pilcickeho_preukazuTextBox.Text)
        con1.Open()
        pocet_vyskytov_cisla_preukazu = com1.ExecuteScalar()
        con1.Close()



        If pocet_vyskytov_cisla_preukazu = 0 And PriezviskoTextBox.Text <> "" Then


            Dim con As New OleDbConnection(pripojovaci_retazec)
            Dim com As New OleDbCommand("INSERT INTO osoba (titul_pred, priezvisko, meno, datum_narodenia, rodne_cislo, cislo_op, ulica, mesto, psc, cislo_pilcickeho_preukazu, email, telefon) VALUES   (@titul_pred, @priezvisko, @meno, @datum_narodenia, @rodne_cislo, @cislo_op, @ulica, @mesto, @psc, @cislo_pilcickeho_preukazu, @email, @telefon)", con)

            With com.Parameters
                .AddWithValue("titul_pred", Titul_predTextBox.Text)
                .AddWithValue("priezvisko", PriezviskoTextBox.Text)
                .AddWithValue("meno", MenoTextBox.Text)
                If Datum_narodeniaDateTimePicker.Checked = True Then
                    .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value.Date)
                Else
                    .AddWithValue("datum_narodenia", DBNull.Value)
                End If
                .AddWithValue("rodne_cislo", rodnecisloMaskedTextBox.Text)
                .AddWithValue("cislo_op", Cislo_opTextBox.Text)
                .AddWithValue("ulica", UlicaTextBox.Text)
                .AddWithValue("mesto", MestoTextBox.Text)
                .AddWithValue("psc", PscTextBox.Text)
                .AddWithValue("cislo_pilcickeho_preukazu", Cislo_pilcickeho_preukazuTextBox.Text)
                .AddWithValue("email", EmailTextBox.Text)
                .AddWithValue("telefon", TelefonTextBox.Text)

            End With
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            Me.OsobaTableAdapter.Fill(Me.Pilcik_dbDataSet.osoba)

            'vymazanie udajov z policok
            Titul_predTextBox.Text = ""
            PriezviskoTextBox.Text = ""
            MenoTextBox.Text = ""
            rodnecisloMaskedTextBox.Text = ""
            Datum_narodeniaDateTimePicker.Checked = False
            UlicaTextBox.Text = ""
            MestoTextBox.Text = ""
            PscTextBox.Text = ""
            Cislo_opTextBox.Text = ""
            Cislo_pilcickeho_preukazuTextBox.Text = ""
            EmailTextBox.Text = ""
            TelefonTextBox.Text = ""
        Else
            MsgBox("dane cislo preukazu sa uz v databaze nachadza")

        End If
    End Sub

    Private Sub OsobaBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource1BindingNavigatorSaveItem.Click
       

    End Sub

    Private Sub OsobaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub OsobaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim priezvisko As String = Label4.Text
        If Label4.Text <> "" Then
            If MsgBox("Naozaj chcete zmazať vybraného člena - " + priezvisko + "? Zmaže sa aj ako účastník všetkých kurzov!!!", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM osoba WHERE id = @id", con)
                Dim com1 As New SqlCeCommand("DELETE FROM clenovia_kurzu WHERE clen_id = @id", con)
                com.Parameters.AddWithValue("id", Label2.Text)
                com1.Parameters.AddWithValue("id", Label2.Text)
                con.Open()
                com.ExecuteNonQuery()
                com1.ExecuteNonQuery()
                con.Close()

            End If
        Else
            MsgBox("Nemáte vybraného žiadneho člena.")
        End If

    End Sub

    Private Sub KurzDataGridView_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        'Label4.Text = Label3.Text
        'Label3.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub OsobaBindingSource2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.OsobaBindingSource2.EndEdit()


    End Sub

    Private Sub OsobaDataGridView_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'nacitanie id
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
        'nacitanie prieyviska
        Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "priezvisko", True))
        Label6.Text = Label4.Text
        Label4.DataBindings.Clear()
    End Sub

    Private Sub OsobaDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub OsobaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        osoba_detail.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim priezvisko As String = TextBox1.Text & "%"
        Me.OsobaTableAdapter.FillBy_priezvisko(Me.Pilcik_dbDataSet.osoba, priezvisko)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(rodnecisloMaskedTextBox.Text)
    End Sub

    Private Sub rodnecisloMaskedTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rodnecisloMaskedTextBox.Leave

        If Not rodnecisloMaskedTextBox.Text.Contains(" ") Then

            If Datum_narodeniaDateTimePicker.Checked <> True Then
                Datum_narodeniaDateTimePicker.Checked = True

                Dim den As Integer = rodnecisloMaskedTextBox.Text.Substring(4, 2)
                Dim mesiac As Integer = rodnecisloMaskedTextBox.Text.Substring(2, 2)
                Dim rok As Integer = "19" & rodnecisloMaskedTextBox.Text.Substring(0, 2)

                Datum_narodeniaDateTimePicker.Value = New Date(rok, mesiac, den)
            End If

        End If

    End Sub

    Private Sub rodnecisloMaskedTextBox_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles rodnecisloMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub OsobaBindingSource2BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource2.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub

    Private Sub OsobaDataGridView_CellClick2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellClick
        'nacitanie id
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
        'nacitanie priezviska
        Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "priezvisko", True))
        Label6.Text = Label4.Text
        Label4.DataBindings.Clear()
    End Sub

    Private Sub OsobaDataGridView_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellContentClick

    End Sub
End Class