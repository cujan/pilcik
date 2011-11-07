Public Class skusobna_komisia


    Private Sub skusobna_komisia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.Skusobna_komisiaTableAdapter.Fill(Me.Pilcik_dbDataSet.skusobna_komisia)


        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized
    End Sub

  

   
    Private Sub Skusobna_komisiaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Skusobna_komisiaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub
End Class