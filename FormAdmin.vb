Public Class FormAdmin
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim vol As New Vol With {
        .Numero = txtNumero.Text,
        .Destination = txtDestination.Text,
        .PlacesDisponibles = Convert.ToInt32(txtPlaces.Text),
        .Prix = Convert.ToDecimal(txtPrix.Text)
    }
        Vols.Add(vol)
        RafraichirListe()
        MessageBox.Show("Vol ajouté avec succès !")
    End Sub
End Class