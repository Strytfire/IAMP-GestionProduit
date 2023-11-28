Imports System.Data
Imports ModeleIAPM

Namespace Global.ModeleIAPM
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

        Public Shared Sub AjouterClient(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("Insert into client values (" & id & " ,'" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
        End Sub

        Public Shared Sub SupprimerClient(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from client where idclient = " & id)
        End Sub

        Public Shared Sub ModifierClient(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("update client set NomClient = '" & n & "',prenomClient = '" & p & "',AdRueClient = '" & r & "',AdCpClient = '" & cp & "',AdVilleClient = '" & v & "' Where idClient = " & id & "")
        End Sub

        Public Shared Function RechercherClient(re As String)
            Return GestionBDD.Executer_Requete_Select("Select * FROM Client where ((NomClient LIKE '%" & re & "%') or (PrenomClient like '%" & re & "%') or (AdRueClient like '%" & re & "%') or (AdCpClient like '%" & re & "%') or  (AdVilleClient like '%" & re & "%'))")
        End Function
        Public Shared Function GetClientByID(idcom As Integer) As DataTable
            Return GestionBDD.Executer_Requete_Select("Select idClient, CONCAT(NomClient,' ',PrenomClient) as Patronyme  From client,commande  WHERE (commande.idCli=client.idClient) AND idCommande LIKE '" & idcom & "'")
        End Function



    End Class
End Namespace
