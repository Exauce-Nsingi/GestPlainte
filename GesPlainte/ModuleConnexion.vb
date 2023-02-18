Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ModConnexion

    Public Connexion1 As New SqlConnection("Data Source=PC-IRNSINGI\IR_NSINGI;Initial Catalog=BD_GESPLAINTE;Integrated Security=True")
    Public Commande1 As SqlCommand
    Public Dataset1 As DataSet
    Public DataReader1 As SqlDataReader = Nothing
    Public DataAdapter1 As New SqlDataAdapter
    Public DataTable1 As New DataTable

    Public Sql1, Sql2, Sql3 As String
    Public UserId, Password As String
End Module