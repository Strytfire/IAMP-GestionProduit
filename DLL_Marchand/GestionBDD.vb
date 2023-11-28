Imports MySql.Data
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Global.MarchandPPE
    Public Class GestionBDD
        Public Shared MaConnexion As New MySqlClient.MySqlConnection
        Public Shared MaCommande As New MySqlClient.MySqlCommand
        'Public Shared MaCommandeSpecialRequete As New MySqlClient.MySqlCommand
        Public Shared MonAdapter As New MySqlClient.MySqlDataAdapter
        Public Shared MonJeuDeDonnees As New Data.DataSet
        Public Shared MaRequete As String
        Public Shared Serveur As String
        Public Shared BDD As String
        Public Shared Login As String
        Public Shared Mdp As String
        Public Shared machaine As String = "Data Source=" & Serveur & ";Initial Catalog=" & BDD & ";User ID=" & Login & ";Password=" & Mdp & ""
        Public Shared CptVue As Integer = 0
        Public Shared Sub SeConnecter()
            machaine = "Data Source=" & Serveur & ";Initial Catalog=" & BDD & ";User ID=" & Login & ";Password=" & Mdp & ""

            MaConnexion.ConnectionString = machaine
            MaConnexion.Open()
            MonJeuDeDonnees = New Data.DataSet("ppe_marchand_cintrat")
            MonJeuDeDonnees.Clear()
            MaCommande.CommandType = CommandType.Text
            MaCommande.Connection = MaConnexion
        End Sub
        Public Shared Function Executer_Requete_Select(ByVal marequeteselect As String) As Data.DataTable
            Dim result As New Data.DataTable
            'on crée une vue à chaque appel : penser à vider le dataset régulièrement pour ne 
            'pas encombrer la mémoire - cptvue est un attribut statique à rajouter aux 
            'attributs de votre classe GestionBDD
            Dim MaVue As String = "MaVue" & CptVue
            Try
                MaCommande.CommandText = marequeteselect
                MonAdapter.SelectCommand = MaCommande
                MonAdapter.Fill(MonJeuDeDonnees, MaVue)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            result = MonJeuDeDonnees.Tables(MaVue)
            CptVue = CptVue + 1
            Return result
        End Function
        Public Shared Function Generer_Cle_Primaire(ByVal nomcle As String, ByVal nomtable As String) As Integer
            MaCommande.CommandText = "SELECT Max(" & nomcle & ") FROM " & nomtable
            Return CInt(MaCommande.ExecuteScalar + 1)
            'ExecuteScalar : Cas des requêtes renvoyant un résultat unique!
        End Function
        Public Shared Function Executer_Requete_Scalaire(ByVal marequetescalaire As String) As Integer
            MaCommande.CommandText = marequetescalaire
            Return CInt(MaCommande.ExecuteScalar)
            'ExecuteScalar : Cas des requêtes renvoyant un résultat unique: count/max/sum!
        End Function
        Public Shared Sub Executer_Requete_Action(ByVal marequeteaction As String)
            Try
                MaCommande.CommandText = marequeteaction
                MaCommande.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Erreur dans la tentative d'action sur la BDD : " &
           ex.Message, "Erreur dans la tentative d'insertion", MessageBoxButtons.OK,
           MessageBoxIcon.Error)
            End Try
        End Sub
        Public Shared Sub ViderJeuDeDonnées()
            MonJeuDeDonnees.Clear()
        End Sub
        Public Shared Function ValidNomPrenom(ByVal adresse As String) As Boolean
            Dim myRegex As System.Text.RegularExpressions.Regex
            'myRegex = New Regex("^[a-zA-Z]+$")'
            myRegex = New Regex("^[\D]+$")
            '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
            Return myRegex.IsMatch(adresse) 'retourne true ou false selon la vérification
        End Function
        Public Shared Function ValidCP(ByRef num As String) As Boolean
            Dim myRegex As System.Text.RegularExpressions.Regex
            myRegex = New Regex("^[0-9]{5}$")
            Return myRegex.IsMatch(num)

        End Function


    End Class
End Namespace
