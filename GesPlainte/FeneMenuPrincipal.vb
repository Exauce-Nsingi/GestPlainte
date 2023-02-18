Public Class FeneMenuPrincipal
    Private Sub FeneMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = UserId
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub FeneMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '*******************Message de comfirmation avant de quitter l'application*************************

        Dim Testmsg As DialogResult = MsgBox("Voulez-vous réellement quitter ?", MessageBoxButtons.YesNo)
        If Testmsg = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnEnregistre_Click(sender As Object, e As EventArgs) Handles BtnEnregistre.Click
        Me.Hide()
        FeneMenuEnregistrement.Show()
    End Sub
End Class