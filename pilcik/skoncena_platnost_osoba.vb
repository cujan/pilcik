Public Class skoncena_platnost_osoba

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()


    End Sub

    Private Sub skoncena_platnost_osoba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vyprsanie_platnosti_preukazuDataSet.osoba' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Vyprsanie_platnosti_preukazuDataSet.osoba' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Vyprsanie_platnosti_preukazuDataSet.osoba' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()


    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()


    End Sub

    Private Sub FillBy_skoncena_platnostToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy_skoncena_platnostToolStripButton.Click
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class