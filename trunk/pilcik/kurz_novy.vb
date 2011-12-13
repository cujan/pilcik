Public Class kurz_novy

    Public idKurz As Integer = -1
    Public nazovKurzu As String = String.Empty

    Private Sub kurz_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.miesto_konania' table. You can move, or remove it, as needed.
        Me.Miesto_konaniaTableAdapter.Fill(Me.Pilcik_dbDataSet.miesto_konania)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.c_typ_kurzu' table. You can move, or remove it, as needed.
        Me.C_typ_kurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.c_typ_kurzu)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.nazov_kurzu' table. You can move, or remove it, as needed.
        Me.Nazov_kurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.nazov_kurzu)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz)
        'TODO: This line of code loads data into the 'PilcikdbDataSet.c_typ_kurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Kurz_pocetDataSet.kurz' table. You can move, or remove it, as needed.

        Me.MdiParent = hlavna_aplikacia
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.
        'Me.KurzDataGridView.CurrentRow.Selected = Nothing
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        'KurzDataGridView.CurrentCell = Nothing
        Label3.BringToFront()

        'generovanie cisla protokolu
        Dim cislo_protokolu As String

        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("SELECT     MAX(CINT(MID(cislo_protokolu, 1, LEN(cislo_protokolu) - 5))) + 1 FROM(kurz) WHERE     (DATEPART('yyyy', zaciatok_kurzu) = datepart('yyyy', now))", con)

        con.Open()
        cislo_protokolu = com.ExecuteScalar
        con.Close()

        cislo_protokoluTextBox.Text = cislo_protokolu & "/" & DatePart(DateInterval.Year, Date.Today)
    End Sub

    

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click


        If Zaciatok_kurzuDateTimePicker.Checked = True And Koniec_kurzuDateTimePicker.Checked = True And TypComboBox.Text <> "" Then


            Dim con As New OleDbConnection(pripojovaci_retazec)
            Dim com As New OleDbCommand("INSERT INTO kurz (nazov, zaciatok_kurzu, koniec_kurzu, typ, miesto_konania, cislo_protokolu) VALUES (@nazov,@zaciatok_kurzu,@koniec_kurzu,@typ,@miesto_konania, @cislo_protokolu)", con)

            With com.Parameters
                .AddWithValue("nazov", NazovComboBox.SelectedValue)
                If Zaciatok_kurzuDateTimePicker.Checked = True Then
                    .AddWithValue("zaciatok_kurzu", Zaciatok_kurzuDateTimePicker.Value.Date)
                Else
                    .AddWithValue("zaciatok_kurzu", DBNull.Value)
                End If
                If Koniec_kurzuDateTimePicker.Checked = True Then
                    .AddWithValue("koniec_kurzu", Koniec_kurzuDateTimePicker.Value.Date)
                Else
                    .AddWithValue("koniec_kurzu", DBNull.Value)
                End If
                .AddWithValue("typ", TypComboBox.SelectedValue)
                .AddWithValue("miesto_konania", Miesto_konaniaComboBox.SelectedValue)
                .AddWithValue("cislo_protokolu", cislo_protokoluTextBox.Text)
            End With

            con.Open()
            com.ExecuteNonQuery()
            con.Close()


            Me.KurzTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz)
            NazovComboBox.SelectedValue = -1
            Zaciatok_kurzuDateTimePicker.Checked = False
            Koniec_kurzuDateTimePicker.Checked = False
            'refresh uvodnej obrazovky
            uvodna_obrazovka.Refresh()
            'obnovenie cisla protokolu
            Dim cislo_protokolu As String


            Dim com1 As New OleDbCommand("SELECT COUNT(*)  FROM kurz WHERE DATEPART('yyyy', zaciatok_kurzu) = DATEPART('yyyy', now)", con)

            con.Open()
            cislo_protokolu = com1.ExecuteScalar
            con.Close()

            cislo_protokoluTextBox.Text = cislo_protokolu + 1 & "/" & DatePart(DateInterval.Year, Date.Today)

        Else
            MsgBox("Nemáte zadabé všetky údaje")
        End If


    End Sub


    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If nazovKurzu <> String.Empty Then
            If MsgBox("Naozaj chcete zmazať vybraný kurz - " + nazovKurzu + " ? Bude zmazany aj v prehľade jednotlivých členov.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim con As New OleDbConnection(pripojovaci_retazec)
                Dim com As New OleDbCommand("DELETE FROM kurz WHERE id = @id", con)
                Dim com1 As New OleDbCommand("DELETE FROM clenovia_kurzu WHERE kurz_id = @id", con)
                com.Parameters.AddWithValue("id", idKurz)
                com1.Parameters.AddWithValue("id", idKurz)
                con.Open()
                com.ExecuteNonQuery()
                com1.ExecuteNonQuery()
                con.Close()

                Me.KurzTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz)
            End If
        Else
            MsgBox("Nemáte vybraný žiaden kurz.")
        End If

    End Sub

   



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pomocny.Show()
    End Sub

    
    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellClick
        'nastavenie id kurzu
        idKurz = Me.KurzBindingSource.Current("id")

        'nastavenie nazvu kurzu
        nazovKurzu = Me.KurzBindingSource.Current("nazov kurzu")

    End Sub

    Private Sub KurzDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellDoubleClick
        kurz_detail.Show()
    End Sub
End Class