Public Class kurz_novy

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KurzBindingSource.EndEdit()


    End Sub

    Private Sub kurz_novy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub kurz_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.c_typ_kurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Kurz_pocetDataSet.kurz' table. You can move, or remove it, as needed.

        Me.MdiParent = hlavna_aplikacia
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.
        'Me.KurzDataGridView.CurrentRow.Selected = Nothing
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        KurzDataGridView.CurrentCell = Nothing
        Label3.BringToFront()

        'generovanie cisla protokolu
        Dim cislo_protokolu As String

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT MAX(SUBSTRING(cislo_protokolu, 1, LEN(cislo_protokolu) - 5)) + 1 AS Expr1 FROM kurz WHERE     (DATEPART(year, zaciatok_kurzu) = DATEPART(year, GETDATE()))", con)

        con.Open()
        cislo_protokolu = com.ExecuteScalar
        con.Close()

        Label7.Text = cislo_protokolu & "/" & DatePart(DateInterval.Year, Date.Today)
    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click


        If NazovTextBox.Text <> "" And Zaciatok_kurzuDateTimePicker.Checked = True And Koniec_kurzuDateTimePicker.Checked = True And TypComboBox.Text <> "" And Miesto_konaniaTextBox.Text <> "" Then


            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("INSERT INTO kurz (nazov, zaciatok_kurzu, koniec_kurzu, typ, miesto_konania, cislo_protokolu) VALUES (@nazov,@zaciatok_kurzu,@koniec_kurzu,@typ,@miesto_konania, @cislo_protokolu)", con)

            With com.Parameters
                .AddWithValue("nazov", NazovTextBox.Text)
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
                .AddWithValue("miesto_konania", Miesto_konaniaTextBox.Text)
                .AddWithValue("cislo_protokolu", Label7.Text)
            End With

            con.Open()
            com.ExecuteNonQuery()
            con.Close()



            NazovTextBox.Text = ""
            Zaciatok_kurzuDateTimePicker.Checked = False
            Koniec_kurzuDateTimePicker.Checked = False
            'refresh uvodnej obrazovky
            uvodna_obrazovka.Refresh()
            'obnovenie cisla protokolu
            Dim cislo_protokolu As String


            Dim com1 As New SqlCeCommand("SELECT COUNT(*)  FROM kurz WHERE DATEPART(year, zaciatok_kurzu) = DATEPART(year, GETDATE())", con)

            con.Open()
            cislo_protokolu = com1.ExecuteScalar
            con.Close()

            Label7.Text = cislo_protokolu + 1 & "/" & DatePart(DateInterval.Year, Date.Today)

        Else
            MsgBox("Nemáte zadabé všetky údaje")
        End If
    End Sub

    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nazov As String = Label4.Text
        If Label4.Text <> "" Then
            If MsgBox("Naozaj chcete zmazať vybraný kurz - " + nazov + " ? Bude zmazany aj v prehľade jednotlivých členov.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM kurz WHERE id = @id", con)
                Dim com1 As New SqlCeCommand("DELETE FROM clenovia_kurzu WHERE kurz_id = @id", con)
                com.Parameters.AddWithValue("id", Label2.Text)
                com1.Parameters.AddWithValue("id", Label2.Text)
                con.Open()
                com.ExecuteNonQuery()
                com1.ExecuteNonQuery()
                con.Close()

            End If
        Else
            MsgBox("Nemáte vybraný žiaden kurz.")
        End If

    End Sub

    Private Sub Miesto_konaniaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Miesto_konaniaTextBox.TextChanged

    End Sub

    Private Sub KurzDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        kurz_detail.Show()
    End Sub

    Private Sub KurzDataGridView_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellClick
        'id
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
        'nazov kurzu
        Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "nazov", True))
        Label5.Text = Label4.Text
        Label4.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellContentClick

    End Sub

    Private Sub KurzDataGridView_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellDoubleClick
        kurz_detail.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pomocny.Show()
    End Sub
End Class