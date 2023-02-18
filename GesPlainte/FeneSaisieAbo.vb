Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class FeneSaisieAbo
    Private Sub ChargementComboTypeAbo()
        Try

            DataAdapter1 = New SqlDataAdapter()
            DataAdapter1.SelectCommand = New SqlCommand("SELECT RTRIM(DESITYPEABO),CODTYPEABO FROM TYPEABONNE", Connexion1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)
            DataTable1 = Dataset1.Tables(0)
            CmbTypeAbo.Items.Clear()
            For Each drow As DataRow In DataTable1.Rows
                CmbTypeAbo.Items.Add(drow(0).ToString())
            Next
            Connexion1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChargementComboCabine()
        Try

            DataAdapter1 = New SqlDataAdapter()
            DataAdapter1.SelectCommand = New SqlCommand("SELECT RTRIM(DESITYPEABO),CODTYPEABO FROM TYPEABONNE", Connexion1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)
            DataTable1 = Dataset1.Tables(0)
            CmbTypeAbo.Items.Clear()
            For Each drow As DataRow In DataTable1.Rows
                CmbTypeAbo.Items.Add(drow(0).ToString())
            Next
            Connexion1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChargementComboQuartier()
        Try

            DataAdapter1 = New SqlDataAdapter()
            DataAdapter1.SelectCommand = New SqlCommand("SELECT RTRIM(DESITYPEABO),CODTYPEABO FROM TYPEABONNE", Connexion1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)
            DataTable1 = Dataset1.Tables(0)
            CmbTypeAbo.Items.Clear()
            For Each drow As DataRow In DataTable1.Rows
                CmbTypeAbo.Items.Add(drow(0).ToString())
            Next
            Connexion1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChargementComboAvenue()
        Try

            DataAdapter1 = New SqlDataAdapter()
            DataAdapter1.SelectCommand = New SqlCommand("SELECT RTRIM(DESITYPEABO),CODTYPEABO FROM TYPEABONNE", Connexion1)
            Dataset1 = New DataSet
            DataAdapter1.Fill(Dataset1)
            DataTable1 = Dataset1.Tables(0)
            CmbTypeAbo.Items.Clear()
            For Each drow As DataRow In DataTable1.Rows
                CmbTypeAbo.Items.Add(drow(0).ToString())
            Next
            Connexion1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class