Public Class tz_protokol_lkt

    Private Sub tz_protokol_lkt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim id As Integer = tlacove_zostavy.ComboBox1.SelectedValue
        'TODO: This line of code loads data into the 'pilcik_dbDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.vseobecne_udajeTableAdapter.Fill(Me.pilcik_dbDataSet.vseobecne_udaje)
        'TODO: This line of code loads data into the 'pilcik_dbDataSet.protokolKurz' table. You can move, or remove it, as needed.
        Me.protokolKurzTableAdapter.Fill(Me.pilcik_dbDataSet.protokolKurz, id)
        'TODO: This line of code loads data into the 'pilcik_dbDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.skusobna_komisiaTableAdapter.Fill(Me.pilcik_dbDataSet.skusobna_komisia)
        'TODO: This line of code loads data into the 'pilcik_dbDataSet.osobaClenoviaKurzu' table. You can move, or remove it, as needed.
        Me.osobaClenoviaKurzuTableAdapter.Fill(Me.pilcik_dbDataSet.osobaClenoviaKurzu, id)
        'TODO: This line of code loads data into the 'pilcik_dbDataSet.pocetClenovKurzu' table. You can move, or remove it, as needed.
        Me.pocetClenovKurzuTableAdapter.Fill(Me.pilcik_dbDataSet.pocetClenovKurzu, id)





        'TODO: This line of code loads data into the 'protokolDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'protokolDataSet.skusobna_komisia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'protokolDataSet.osoba' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'pocet_clenov_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'vseobecne_udajeDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.



        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class