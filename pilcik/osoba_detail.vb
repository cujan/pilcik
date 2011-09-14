Public Class osoba_detail

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()


    End Sub

    Private Sub osoba_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Dim vybrana_osoba_id As Integer = osoba_pridaj.Label1.Text
       
        Me.MdiParent = hlavna_aplikacia
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()



        MsgBox("Zmeny úspešne uložené.")
    End Sub

    Private Sub Fill_osoba_idToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class