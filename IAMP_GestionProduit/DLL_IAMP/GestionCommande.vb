Imports System.Data
Imports ModeleIAPM

Namespace Global.ModeleIAPM
    Public Class GestionCommande
        Public Shared Function GetLesCommande()
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM commande”)
        End Function

        Public Shared Function DGCommande()
            Return GestionBDD.Executer_Requete_Select(“SELECT commande.idCommande, DateCommande, CONCAT( NomClient,' ', PrenomClient) AS Patronyme, SUM(QuantiteCom*PrixHTProduit) AS MontantHT FROM commande, client, lignedecommande, produit WHERE commande.idCli = client.idClient AND commande.idcommande = lignedecommande.idCommande AND lignedecommande.idProduit = produit.idProduit GROUP BY commande.idCommande”)
        End Function
        Public Shared Function GetNBCommandes()
            Return GestionBDD.Executer_Requete_Scalaire("Select count(*) From Commande")
        End Function
        Public Shared Function GetLesProduitByCommande(idcom As Integer) As DataTable
            Return GestionBDD.Executer_Requete_Select("SELECT produit.idproduit, libelleproduit, prixhtproduit, quantitecom,(prixhtproduit * quantitecom) AS MontantLigneHT FROM produit, lignedecommande WHERE produit.idProduit = lignedecommande.idProduit AND idcommande like '" & idcom & "'")
        End Function
        Public Shared Sub Supprimerlignecom(idco As Integer, idpro As String)
            GestionBDD.Executer_Requete_Action("delete from lignedecommande where idcommande = '" & idco & "' and idProduit = '" & idpro & "' ")
        End Sub
        Public Shared Sub AjouterLigneCommande(idC As String, Idp As String, c As Integer)
            GestionBDD.Executer_Requete_Action("Insert into lignedecommande values ('" & idC & "' ,'" & Idp & "','" & c & "')")
        End Sub
        Public Shared Function GetMontantHT(idcom As Integer) As Integer
            Return GestionBDD.Executer_Requete_Scalaire("SELECT SUM(PrixhtProduit * QuantiteCom) AS MontantLigneHT from produit, lignedecommande where produit.idproduit = lignedecommande.idProduit AND idcommande = " & idcom)
        End Function
        Public Shared Sub AjouterCommande(idC As String, Idp As String, c As Integer)
            GestionBDD.Executer_Requete_Action("Insert into Commande values ('" & idC & "' ,'" & Idp & "','" & c & "')")
        End Sub
        Public Shared Sub SuprimerCommande(idC As Integer)
            GestionBDD.Executer_Requete_Action("DELETE From lignedecommande where (idCommande=" & idC & ")")
            GestionBDD.Executer_Requete_Action("DELETE From commande where (idCommande=" & idC & ")")
        End Sub
    End Class
End Namespace

