Public Class tz_protokol_pila

    Private Sub tz_protokol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim id As Integer = tlacove_zostavy.ComboBox1.SelectedValue
        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.osobaClenoviaKurzu'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.OsobaClenoviaKurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.osobaClenoviaKurzu, id)
        Me.PocetClenovKurzuTableAdapter.Fill(Me.Pilcik_dbDataSet.pocetClenovKurzu, id)


        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.skusobna_komisia'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Skusobna_komisiaTableAdapter.Fill(Me.Pilcik_dbDataSet.skusobna_komisia)
        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.protokolKurz'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.ProtokolKurzTableAdapter.Fill(Me.Pilcik_dbDataSet.protokolKurz, id)
        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.kurz'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.KurzTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz)
        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.vseobecne_udaje'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Pilcik_dbDataSet.vseobecne_udaje)
        'TODO: Tento řádek načte data do tabulky 'Pilcik_dbDataSet.vseobecne_udaje'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Pilcik_dbDataSet.vseobecne_udaje)
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        

        'TODO: This line of code loads data into the 'ProtokolDataSet.skusobna_komisia' table. You can move, or remove it, as needed.


        'Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue()


        'TODO: This line of code loads data into the 'ProtokolDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ProtokolDataSet.osoba' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Pocet_clenov_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.












        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class