Public Class FeneMenuEnregistrement
    Private Sub FeneMenuEnregistrement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = UserId
    End Sub

    Private Sub BtnSaisie_Click(sender As Object, e As EventArgs) Handles BtnSaisie.Click
        Me.Hide()

    End Sub
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        FeneMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnReclamation_Click(sender As Object, e As EventArgs) Handles BtnReclamation.Click
        Me.Hide()
        FeneSaisieReclamation.Show()
    End Sub
End Class