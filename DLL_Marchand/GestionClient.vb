
Imports Mysqlx.XDevAPI.Relational

Namespace Global.MarchandPPE
    Public Class GestionClient
        Public Shared Function GetLesClients() As DataTable
            Return GestionBDD.Executer_Requete_Select(“Select * from Client”)

        End Function

        Public Shared Function GetLesClientsCB() As DataTable
            Return GestionBDD.Executer_Requete_Select("Select idClient,CONCAT(NomClient,' ',PrenomClient) as Patronyme from Client")
        End Function

        Public Shared Function GetNBClients() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Client")
        End Function

        Public Shared Sub AjouterClient(id As Integer, n As String, p As String, t As String, em As String, r As String, v As String, cp As Integer, log As String)
            GestionBDD.Executer_Requete_Action("Insert into Client (idClient,Nom_Utilisateur,Prenom_Utilisateur,Tel_Utilisateur,Email_Utilisateur,AdRue_Utilisateur,AdVille_Utilisateur,AdCP_Utilisateur,Login_Utilisateur) values (" & id & " ,'" & n & "','" & p & "','" & t & "','" & em & "','" & r & "','" & v & "'," & cp & ",'" & log & "')")
        End Sub

        Public Shared Sub SupprimerClient(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from Utilisateur where Id_Utilisateur = " & id)
        End Sub

        Public Shared Sub ModifierClient(id As Integer, n As String, p As String, r As String, cp As Integer, v As String, tel As String, logi As String, mail As String)
            GestionBDD.Executer_Requete_Action("update Utilisateur set Nom_Utilisateur = '" & n & "',Prenom_Utilisateur = '" & p & "',AdRue_Utilisateur = '" & r & "',AdCP_Utilisateur = '" & cp & "',AdVille_Utilisateur = '" & v & "',Tel_Utilisateur = '" & tel & "',Login_Utilisateur = '" & logi & "',Email_Utilisateur = '" & mail & "' Where Id_Utilisateur = " & id & "")
        End Sub

        Public Shared Function RechercherClient(re As String)
            Return GestionBDD.Executer_Requete_Select("Select * FROM Utilisateur where ((Nom_Utilisateur LIKE '%" & re & "%') or (Prenom_Utilisateur like '%" & re & "%') or (AdRue_Utilisateur like '%" & re & "%') or (AdCP_Utilisateur like '%" & re & "%') or  (AdVille_Utilisateur like '%" & re & "%'))")
        End Function
        Public Shared Function GetClientByID(idcom As Integer) As DataTable
            Return GestionBDD.Executer_Requete_Select("SELECT idClient, CONCAT(NomClient,' ',PrenomClient) as Patronyme From Client,Commande WHERE (Commande.idCli=Client.idClient) AND idCommande LIKE '" & idcom & "'")
        End Function
        'Public Shared Function RechercheProduit(Produit As Integer) As DataTable
        '    Return GestionBDD.Executer_Requete_Select("call RechercheProduit('" & Produit & "')")
        'End Function
        'Public Shared Function GetClient() As DataTable
        '    Return GestionBDD.Executer_Requete_Select("call GetLesClient")
        'End Function
        'Public Shared Function GetTypleByTable(table As Integer) As DataTable
        '    Return GestionBDD.Executer_Requete_Select("call GetTupleBTable('" & table & "')")
        'End Function
        'Public Shared Function GetSupprimerClient(id As Integer) As DataTable
        '    GestionBDD.Executer_Requete_Action("call SuppCli(" & id & ")")
        'End Function





    End Class
End Namespace