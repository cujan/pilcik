Public Class clen_kurzu_pridaj

    Private Sub clen_kurzu_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.Pilcik_dbDataSet.osoba)
        'TODO: This line of code loads data into the 'OsobaComboDataSet.osoba' table. You can move, or remove it, as needed.

       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vybrany_kurz_id As Integer = kurz_detail.id_vybrateho_kurzu
        Dim vybrany_clen_id As Integer = Me.ComboBox1.SelectedValue


        'kontroluje ci nahodou nie je pridavany clen uz v kurze
        Dim con1 As New OleDbConnection(pripojovaci_retazec)
        Dim com1 As New OleDbCommand("SELECT COUNT(*) AS Expr1 FROM clenovia_kurzu WHERE (kurz_id = @kurz_id) AND (clen_id =@clen_id)", con1)
        com1.Parameters.AddWithValue("kurz_id", vybrany_kurz_id)
        com1.Parameters.AddWithValue("clen_id", vybrany_clen_id)
        con1.Open()
        Dim vyskyt_clena As Integer
        vyskyt_clena = com1.ExecuteScalar()
        con1.Close()




        If vyskyt_clena = 0 Then
            'pridava clena do kurzu
            Dim con As New OleDbConnection(pripojovaci_retazec)
            Dim com As New OleDbCommand("INSERT INTO clenovia_kurzu (kurz_id, clen_id) VALUES (@kurz_id,@clen_id)", con)
            com.Parameters.AddWithValue("kurz_id", vybrany_kurz_id)
            com.Parameters.AddWithValue("clen_id", vybrany_clen_id)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            kurz_detail.OsobaClenoviaKurzuTableAdapter.Fill(kurz_detail.Pilcik_dbDataSet.osobaClenoviaKurzu, kurz_detail.id_vybrateho_kurzu)
        Else
            MsgBox("Tento človek sa už v kurze nachádza!!!")
        End If
    End Sub
End Class