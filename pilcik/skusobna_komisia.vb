Public Class skusobna_komisia

    Private Sub Skusobna_komisiaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Skusobna_komisiaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()


    End Sub

    Private Sub skusobna_komisia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.skusobna_komisia' table. You can move, or remove it, as needed.


        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()

    End Sub
End Class