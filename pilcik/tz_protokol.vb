Public Class tz_protokol

    Private Sub tz_protokol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.vseobecne_udajeTableAdapter.Fill(Me.Vseobecne_udajeDataSet.vseobecne_udaje)


        'TODO: This line of code loads data into the 'ProtokolDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.Skusobna_komisiaTableAdapter.Fill(Me.ProtokolDataSet.skusobna_komisia)

        Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue()


        'TODO: This line of code loads data into the 'ProtokolDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.ProtokolDataSet.kurz, id_kurzu)
        'TODO: This line of code loads data into the 'ProtokolDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.ProtokolDataSet.osoba, id_kurzu)
        'TODO: This line of code loads data into the 'Pocet_clenov_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.
        Me.Clenovia_kurzuTableAdapter.Fill(Me.Pocet_clenov_kurzuDataSet.clenovia_kurzu, id_kurzu)











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