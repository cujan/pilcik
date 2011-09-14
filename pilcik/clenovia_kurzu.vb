Public Class clenovia_kurzu

    Private Sub clenovia_kurzu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.

        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()

    End Sub

    Private Sub Clenovia_kurzuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Clenovia_kurzuBindingSource.EndEdit()


    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
       

    End Sub
End Class