Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class FeneConnexion
    Public VariableEssaie As Integer
    Sub Effacement()
        '*****************Initialisation******************'
        TxtUserId.Clear()
        TxtMotPasse.Clear()
        TxtUserId.Focus()
        TxtMotPasse.Enabled = False
        BtnValider.Enabled = False
        BtnAnnuler.Enabled = False
        BtnQuitter.Enabled = True
    End Sub
    Private Sub TxtUserId_TextChanged(sender As Object, e As EventArgs) Handles TxtUserId.TextChanged
        ErrorProvider1.Clear()
    End Sub
    Private Sub TxtMotPasse_TextChanged(sender As Object, e As EventArgs) Handles TxtMotPasse.TextChanged
        ErrorProvider2.Clear()
    End Sub
    Private Sub FormBoitCon_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        '*******************Message de comfirmation avant de quitter l'application*************************

        Dim Testmsg As DialogResult = MsgBox("Voulez-vous réellement quitter ?", MessageBoxButtons.YesNo)
        If Testmsg = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FeneConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Connexion1.State = ConnectionState.Closed Then
            Connexion1.Open()
            Call Effacement()
        End If
    End Sub
    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        If TxtMotPasse.Text = Password Then
            FeneMenuPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Mot de passe incorrect, Veillez ressayer", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VariableEssaie += 1
        End If

        If VariableEssaie = 3 Then
            MessageBox.Show("Nombre d'essayer atteint!", "Information", MessageBoxButtons.OK)
            TxtMotPasse.Clear()
            Application.Exit()
        End If
    End Sub

    Private Sub TxtMotPasse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMotPasse.KeyPress
        If e.KeyChar = Chr(13) Then

            BtnValider.Enabled = True
            BtnValider.Focus()
        End If
    End Sub

    Private Sub TxtUserId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUserId.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtUserId.Text <> "" Then


                Sql2 = "Select * From UTILISATEURS Where NOMUTIL='" & TxtUserId.Text & "'"
                Commande1 = New SqlCommand(Sql2, Connexion1)
                DataReader1 = Commande1.ExecuteReader

                Do While DataReader1.Read
                    If TxtUserId.Text = DataReader1.GetString(1) Then
                        Password = DataReader1.GetString(2)
                        UserId = DataReader1.GetString(1)
                        DataReader1.Close()
                        TxtMotPasse.Enabled = True
                        TxtMotPasse.Focus()
                        Exit Sub
                    End If
                Loop
                DataReader1.Close()
                MessageBox.Show("User_Id inexistant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Effacement()
                TxtUserId.Focus()
                VariableEssaie += 1

            Else
                ErrorProvider1.SetError(TxtUserId, "Saisissez quelque chose svp !")
                TxtUserId.Focus()
            End If
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click

    End Sub
End Class