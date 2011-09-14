Public Class tz_protokol_pila

    Private Sub tz_protokol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        

        'TODO: This line of code loads data into the 'ProtokolDataSet.skusobna_komisia' table. You can move, or remove it, as needed.


        Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue()


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