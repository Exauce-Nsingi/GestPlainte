Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class FeneSaisieReclamation
    Sub Initialisation()
        TxtNumPlainte.Clear()
        TxtAvenue.Text = ""
        TxtNomsAbo.Enabled = True

    End Sub
    Private Sub Effacement()

        CmbLibTypePlainte.Text = ""
        TxtNumAbo.Clear()
        TxtAvenue.Clear()
        TxtNumParce.Clear()
        TxtNomsAbo.Clear()
        TxtNumAbo.Focus()

    End Sub
    Private Sub ChargementCombo()
        Try

            DataAdapter1 = New SqlDataAdapter()
            DataAdapter1.SelectCommand = New SqlCommand("Select rtrim(LIBTYPEPLAINTE),CODTYPEPLAINTE From TYPEPLAINTE", Connexion1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)
            DataTable1 = Dataset1.Tables(0)
            CmbLibTypePlainte.Items.Clear()
            For Each drow As DataRow In DataTable1.Rows
                CmbLibTypePlainte.Items.Add(drow(0).ToString())
            Next
            Connexion1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub AffichageGrille()
        Try

            Sql1 = "SELECT PL.NUMPLAINTE,PL.DATEDEPOT,PL.NUMABO,LIBTYPEPLAINTE,NOMSABO,DESIAVENUE,NUMPARCELLE From TYPEPLAINTE TP,PLAINTES PL,ABONNES AB,AVENUE AV,PARCELLE Where PL.NUMABO=AB.NUMABO and AB.CODAVENUE=AV.CODAVENUE and TP.CODTYPEPLAINTE=TP.CODTYPEPLAINTE"
            Commande1 = New SqlCommand(Sql1, Connexion1)
            DataAdapter1 = New SqlDataAdapter(Commande1)
            Dataset1 = New DataSet
            Try
                DataAdapter1.Fill(Dataset1, Sql1)
                DataGridView1.DataSource = Dataset1.Tables(Sql1)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            With DataGridView1
                .Columns(0).HeaderText = "N° Plainte"
                .Columns(1).HeaderText = "Date Plainte"
                .Columns(2).HeaderText = "N° Abonné"
                .Columns(3).HeaderText = "Type Plainte"
                .Columns(4).HeaderText = "Noms Abonné"
                .Columns(5).HeaderText = "Avenue"
                .Columns(6).HeaderText = "N° Parcelle"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Incrementer()
        Try
            Sql1 = "Select NUMPLAINTE From PLAINTES Order by NUMPLAINTE Desc"
            Commande1 = New SqlCommand(Sql1, Connexion1)
            DataAdapter1 = New SqlDataAdapter(Commande1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)

            If Connexion1.State = ConnectionState.Closed Then
                Connexion1.Open()
            End If
            DataTable1 = Dataset1.Tables(0)
            If DataTable1.Rows.Count <> 0 Then
                TxtNumPlainte.Text = DataTable1.Rows(0)("NUMPLAINTE").ToString + 1
            Else
                TxtNumPlainte.Text = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub FeneSaisieReclamation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUser.Text = UserId
        TxtDatePlainte.Text = Date.Now.ToShortDateString

        '**************************Test et ouverture de la connexion***************************'

        If Connexion1.State = ConnectionState.Closed Then
            Connexion1.Open()
        End If

        Call ChargementCombo()
        Call Incrementer()
        Call AffichageGrille()
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Close()
        FeneMenuEnregistrement.Show()
    End Sub

    Private Sub FeneSaisieReclamation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        '*******************Message de comfirmation avant de quitter l'application*************************

        Dim Testmsg As DialogResult = MsgBox("Voulez-vous réellement quitter ?", MessageBoxButtons.YesNo)
        If Testmsg = DialogResult.Yes Then
            Me.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click

        Dim msgSupp As DialogResult = MessageBox.Show("Suppresion effectuée", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgSupp = DialogResult.Yes Then
            Commande1.CommandText = "Delete From PLAINTES Where NUMPLAINTE=" & TxtNumPlainte.Text & ""
            Commande1.ExecuteNonQuery()

        End If

    End Sub
    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        Commande1.CommandText = "Update PLAINTES Set DATEDEPOT='" & TxtDatePlainte.Text & "',NUMABO='" & TxtNumAbo.Text & "',CODTYPEPLAINTE='" & TxtCodeTypePlainte.Text & "' Where NUMPLAINTE=" & TxtNumPlainte.Text & ""
        Commande1.ExecuteNonQuery()
        MsgBox("Modification effectuée")
        Call Effacement()
    End Sub

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        Commande1.CommandText = "Insert Into PLAINTES (DATEDEPOT,NUMABO,CODTYPEPLAINTE) Values('" & TxtDatePlainte.Text & "'," & TxtNumAbo.Text & ",'" & TxtCodeTypePlainte.Text & "')"
        Commande1.ExecuteNonQuery()
        MsgBox("Enregistrement effectué")
        Call Effacement()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        Call Effacement()
    End Sub

    Private Sub CmbLibTypePlainte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLibTypePlainte.SelectedIndexChanged

        Sql2 = "SELECT CODTYPEPLAINTE FROM TYPEPLAINTE WHERE LIBTYPEPLAINTE='" & CmbLibTypePlainte.Text & "'"
        Commande1 = New SqlCommand(Sql2, Connexion1)
        DataAdapter1.Fill(Dataset1, "TYPEPLAINTE")
        DataTable1 = Dataset1.Tables(0)
        TxtCodeTypePlainte.Text = DataTable1.Rows(0).Item(0)

    End Sub

    Private Sub TxtNumAbo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumAbo.KeyPress

        Sql2 = "SELECT NUMABO,NOMSABO,DESIAVENUE,NUMPARCELLE FROM ABONNES AB,AVENUE AV WHERE AB.CODAVENUE=AV.CODAVENUE"
        DataReader1 = Commande1.ExecuteReader
        If e.KeyChar = Chr(13) Then
            If TxtNumAbo.Text = "" Then
                ErrorProvider1.SetError(TxtNumAbo, "Veuillez saisir le numéro de l'Abonne!")
                TxtNumAbo.Focus()
            Else
                Do While DataReader1.Read
                    If TxtNumAbo.Text = DataReader1.GetString(0) Then
                        TxtNomsAbo.Text = DataReader1.GetString(1)
                        TxtAvenue.Text = DataReader1.GetString(2)
                        TxtNumParce.Text = DataReader1.GetString(3)
                        DataReader1.Close()
                        BtnEnregistrer.Enabled = True
                        BtnEnregistrer.Focus()
                        Exit Sub
                    End If
                Loop
                DataReader1.Close()
                MessageBox.Show("Abonné(e) inexistant(e)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Effacement()
            End If
        End If
    End Sub
End Class